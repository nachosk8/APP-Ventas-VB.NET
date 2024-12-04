Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Security.Cryptography.Pkcs
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.SqlServer

Public Class Ventas

    Dim conexion As New SqlConnection
    Dim leer As SqlDataReader
    Dim comando As SqlCommand
    Dim seleccion As SqlCommand
    Dim adaptador As New SqlDataAdapter
    Dim filtro As String = ""



    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection(conectarse_A_BDD)
        Cmb_Filtro.SelectedIndex = 0
        llenar_grid_venta()
        llenar_grid_ventaitem()
        Cmb_Filtro.SelectedIndex = -1
        Dim total = totalRecaudado()
        Lbl_RecaudacionTotal.Text = "TOTAL GENERAL =  $" & Val(total) & " "
    End Sub

    Private Function totalRecaudado() As Double
        Dim total As Double = 0

        For Each fila As DataGridViewRow In DGV_ItemVenta.Rows
            If Not IsDBNull(fila.Cells(5).Value) Then
                total += Convert.ToDouble(fila.Cells(5).Value)
            End If
        Next
        Return total
    End Function
    Private Function validarConexion(busqueda As String, valorobtenido As Integer, entidad As String, comparador As String) As Boolean
        Dim consulta As String = "select " & busqueda & " from " & entidad & " where " & comparador & " = '" & Val(valorobtenido) & "'"
        seleccion = New SqlCommand(consulta, conexion)
        leer = seleccion.ExecuteReader()
        If leer.Read() Then
            Return True
        Else
            Return False
        End If
    End Function




    Private Sub falsearParaFiltrar()
        Btn_EliminarVenta.Enabled = False
        Btn_NuevaVenta.Enabled = False

    End Sub

    Public Sub llenar_grid_ventaitem()
        Dim dt As New DataTable
        Dim consulta As String = "select * from ventasitems"
        Dim adaptador As New SqlDataAdapter(consulta, conexion)
        adaptador.Fill(dt)
        DGV_ItemVenta.DataSource = dt
    End Sub
    Public Sub llenar_grid_venta()
        Dim dt As New DataTable
        Dim consulta As String = "select * from ventas"
        Dim adaptador As New SqlDataAdapter(consulta, conexion)
        adaptador.Fill(dt)
        DGV_Ventas.DataSource = dt
    End Sub
    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        Close()
    End Sub

    Private Sub Btn_Volver_Click(sender As Object, e As EventArgs) Handles Btn_Volver.Click
        Me.Close()
        Principal.Show()
    End Sub

    Private Sub Btn_NuevaVenta_Click_1(sender As Object, e As EventArgs) Handles Btn_NuevaVenta.Click
        conexion.Open()

        If Txb_Fecha.Text <> "" And IsNumeric(Txb_TotVenta.Text) And IsNumeric(Txb_IdCte.Text) Then
            If Val(Txb_TotVenta.Text) > 0 Then
                Dim fecha As Date
                If Date.TryParse(Txb_Fecha.Text, fecha) Then


                    Try
                        Dim buscar = "*"
                        Dim cte = "clientes"
                        Dim id = "ID"
                        If validarConexion(buscar, Txb_IdCte.Text, cte, id) Then
                            Dim insertar = "insert into ventas (IDCliente, Fecha, Total) values(" & Val(Txb_IdCte.Text) & ",'" & Txb_Fecha.Text & "'," & Val(Txb_TotVenta.Text) & ")"
                            comando = New SqlCommand(insertar, conexion)
                            comando.ExecuteNonQuery()
                            MsgBox("Se agrego la venta con Cliente: " & Txb_IdCte.Text & " , Fecha: " & Txb_Fecha.Text & ", y Total: " & Txb_TotVenta.Text & "")
                            llenar_grid_venta()
                        Else
                            MsgBox("No existen clientes con ese ID, consulte Los ID previamente en clientes")
                            Principal.Show()
                            Close()
                        End If
                        conexion.Close()
                    Catch ex As Exception

                        conexion.Close()
                        MsgBox("Ocurrió un error, vuelva a ingresar para realizar la solicitud")
                        Close()
                        Principal.Show()
                    End Try


                Else

                    MsgBox("Fecha incorrecta, debe ingresar una fecha existente. Ejemplo: 09-10-2001")
                End If
            End If

        Else
            MsgBox("Debe completar todos los campos, ID y Total deben ser numéricos")
        End If
        conexion.Close()
    End Sub





    Private Sub Btn_Filtros_Click_1(sender As Object, e As EventArgs) Handles Btn_Filtros.Click
        conexion.Open()

        Dim buscar = "*"
        If IsNumeric(Txb_Filtros.Text) Then
            If validarConexion(buscar, Txb_Filtros.Text, "clientes", "ID") Then
                Dim dt As New DataTable
                Dim consulta = "select * from ventas where IDCliente= '" & Txb_Filtros.Text & "'"
                Dim adaptador As New SqlDataAdapter(consulta, conexion)
                adaptador.Fill(dt)
                DGV_Ventas.DataSource = dt
            Else
                MsgBox("No tenemos registrado a ese cliente")
            End If
        Else
            MsgBox("Complete la solicitud con un ID numérico válido")
        End If
        conexion.Close()
    End Sub

    Private Sub Btn_EliminarVenta_Click_1(sender As Object, e As EventArgs) Handles Btn_EliminarVenta.Click
        conexion.Open()

        Dim consulta = "select * from ventas"
        seleccion = New SqlCommand(consulta, conexion)
        leer = seleccion.ExecuteReader
        If leer.Read Then
            Dim confirmar = MsgBox("¿Seguro desea eliminar la venta? Recuerde que esta acción borrará automáticamente los items de ventas relacionados a esta venta", vbOKCancel + vbQuestion, "Eliminar")
            If confirmar = vbOK Then
                Dim id = DGV_Ventas.CurrentRow.Cells(0).Value
                Dim idcte = DGV_Ventas.CurrentRow.Cells(1).Value
                Dim fecha = DGV_Ventas.CurrentRow.Cells(2).Value
                Dim total = DGV_Ventas.CurrentRow.Cells(3).Value
                Dim eliminar As String = "DELETE FROM ventas WHERE ID= " & id & ""
                comando = New SqlCommand(eliminar, conexion)
                comando.ExecuteNonQuery()
                Dim cascadaUno As String = "DELETE FROM ventasitems WHERE IDVenta= " & id & ""
                comando = New SqlCommand(cascadaUno, conexion)
                comando.ExecuteNonQuery()
                MsgBox("Se eliminó la venta de Cte: " & idcte & " , Fecha: " & fecha & ", y Total: " & total & "")
                llenar_grid_venta()
                llenar_grid_ventaitem()
            End If

            conexion.Close()
        Else
            MsgBox("No hay elementos para eliminar")
            conexion.Close()
        End If
    End Sub



    Private Sub Cmb_Filtro_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles Cmb_Filtro.SelectedIndexChanged
        conexion.Open()

        Select Case Cmb_Filtro.SelectedIndex
            Case 0
                llenar_grid_venta()
                Btn_Filtros.Visible = False
                Txb_Filtros.Visible = False
                Btn_EliminarVenta.Enabled = True
                Btn_NuevaVenta.Enabled = True
                'DGV_Ventas.Enabled = True
            Case 1
                falsearParaFiltrar()
                Btn_Filtros.Visible = False
                Txb_Filtros.Visible = False
                Dim dt As New DataTable
                Dim consulta = "select Total from ventas"
                Dim adaptador As New SqlDataAdapter(consulta, conexion)
                adaptador.Fill(dt)
                DGV_Ventas.DataSource = dt
                'DGV_Ventas.Enabled = False
            Case 2
                falsearParaFiltrar()
                Btn_Filtros.Visible = False
                Txb_Filtros.Visible = False
                Dim dt As New DataTable
                Dim consulta = "select ID, IDCliente from ventas"
                Dim adaptador As New SqlDataAdapter(consulta, conexion)
                adaptador.Fill(dt)
                DGV_Ventas.DataSource = dt
                'DGV_Ventas.Enabled = False
            Case 3
                falsearParaFiltrar()
                Btn_Filtros.Visible = True
                Txb_Filtros.Visible = True
                'DGV_Ventas.Enabled = False
        End Select
        conexion.Close()
    End Sub

    Private Sub Btn_ItemAgregar_Click_1(sender As Object, e As EventArgs) Handles Btn_ItemAgregar.Click
        conexion.Open()

        If IsNumeric(Txb_ItemCant.Text) And IsNumeric(Txb_ItemIdproducto.Text) And IsNumeric(Txb_ItemIDventa.Text) Then


            If Val(Txb_ItemCant.Text) > 0 Then
                Dim buscartodo = "*"
                If validarConexion(buscartodo, Txb_ItemIDventa.Text, "ventas", "ID") And validarConexion(buscartodo, Txb_ItemIdproducto.Text, "productos", "ID") Then
                    Dim id = Val(Txb_ItemIDventa.Text)
                    Dim idprod = Val(Txb_ItemIdproducto.Text)
                    Dim seleccion As String = "select Total from ventas where ID = " & id & " "
                    Dim preciototal = 0
                    Dim preciounitario = 0
                    comando = New SqlCommand(seleccion, conexion)
                    Using lector As SqlDataReader = comando.ExecuteReader()
                        If lector.Read Then
                            preciototal = lector("Total")
                        End If

                    End Using
                    Txb_ItemTotal.Text = preciototal.ToString


                    Dim seleccionar As String = "select Precio from productos where ID = " & idprod & " "
                    comando = New SqlCommand(seleccionar, conexion)
                    Using leer As SqlDataReader = comando.ExecuteReader()
                        If leer.Read Then
                            preciounitario = Val(leer("Precio"))
                        End If

                    End Using
                    Txb_ItemPrecUnit.Text = preciounitario.ToString
                    Dim insertar = "insert into ventasitems (IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) values(" & Txb_ItemIDventa.Text & "," & Txb_ItemIdproducto.Text & "," & preciounitario & "," & Txb_ItemCant.Text & "," & preciototal & ")"
                    comando = New SqlCommand(insertar, conexion)
                    comando.ExecuteNonQuery()
                    MsgBox("Se agrego correctamente el item de venta")
                    Dim dt As New DataTable
                    Dim consulta = "select * from ventasitems"
                    Dim adaptador As New SqlDataAdapter(consulta, conexion)
                    adaptador.Fill(dt)
                    DGV_ItemVenta.DataSource = dt
                    Dim total = totalRecaudado()
                    Lbl_RecaudacionTotal.Text = "TOTAL GENERAL =  $" & Val(total) & " "
                Else
                    MsgBox("Id venta/producto o ambos, son incorrectos. El error puede deberse a que el precio unitario del producto no coincide con el precio real del mismo, o que el total no coincide con los valores de la venta, revise precios de producto")
                    Principal.Show()
                    Close()

                End If
            End If

        Else
            MsgBox("Debe completar todos los campos con valores numéricos")
        End If
        conexion.Close()
    End Sub

    Private Sub Btn_ItemBorrar_Click_1(sender As Object, e As EventArgs) Handles Btn_ItemBorrar.Click
        conexion.Open()

        Dim consulta = "select * from ventasitems"
        seleccion = New SqlCommand(consulta, conexion)
        leer = seleccion.ExecuteReader
        If leer.Read Then
            Dim id = DGV_ItemVenta.CurrentRow.Cells(0).Value

            Dim eliminar As String = "DELETE FROM ventasitems WHERE ID= " & id & ""
            comando = New SqlCommand(eliminar, conexion)
            comando.ExecuteNonQuery()
            MsgBox("Se eliminó el item de ventas")
            llenar_grid_ventaitem()
            Dim total = totalRecaudado()
            Lbl_RecaudacionTotal.Text = "TOTAL GENERAL =  $" & Val(total) & " "
            conexion.Close()
        Else
            MsgBox("No hay elementos para eliminar")
            conexion.Close()
        End If
    End Sub

    Private Sub Btn_ItemModificar_Click_1(sender As Object, e As EventArgs) Handles Btn_ItemModificar.Click
        conexion.Open()
        Dim consulta = "select * from ventasitems"
        seleccion = New SqlCommand(consulta, conexion)
        leer = seleccion.ExecuteReader
        If leer.Read Then
            Btn_ItemAgregar.Enabled = False
            Btn_ItemBorrar.Enabled = False
            Btn_ItemModificar.Enabled = False
            Btn_ItemCancelarMod.Visible = True
            Btn_ItemAceptarMod.Visible = True
            MsgBox("Establezca los nuevos valores de la venta item, si quiere seguir con los originales, escribalos en sus ubicaciones")

        Else
            MsgBox("La lista esta vacia")
        End If
        conexion.Close()
    End Sub

    Private Sub Btn_ItemAceptarMod_Click_1(sender As Object, e As EventArgs) Handles Btn_ItemAceptarMod.Click
        conexion.Open()

        If IsNumeric(Txb_ItemCant.Text) And IsNumeric(Txb_ItemIdproducto.Text) And IsNumeric(Txb_ItemIDventa.Text) And IsNumeric(Txb_ItemPrecUnit.Text) And IsNumeric(Txb_ItemTotal.Text) Then
            If Val(Txb_ItemCant.Text) > 0 And Val(Txb_ItemPrecUnit.Text) > 0 And Val(Txb_ItemTotal.Text) > 0 Then
                Dim id = DGV_ItemVenta.CurrentRow.Cells(0).Value

                Dim consulta = "select * from ventasitems"
                seleccion = New SqlCommand(consulta, conexion)
                leer = seleccion.ExecuteReader
                If leer.Read Then
                    Dim buscartodo = "*"

                    If validarConexion(buscartodo, Txb_ItemIDventa.Text, "ventas", "ID") And validarConexion(buscartodo, Txb_ItemIdproducto.Text, "productos", "ID") And validarConexion(buscartodo, Val(Txb_ItemPrecUnit.Text), "productos", "Precio") And validarConexion(buscartodo, Val(Txb_ItemTotal.Text), "ventas", "Total") Then
                        Dim modificar As String = "update ventasitems set IDVenta = " & Val(Txb_ItemIDventa.Text) & ", IDProducto = " & Val(Txb_ItemIdproducto.Text) & ", PrecioUnitario = " & Val(Txb_ItemPrecUnit.Text) & ", Cantidad =" & Val(Txb_ItemCant.Text) & ", PrecioTotal = " & Val(Txb_ItemTotal.Text) & " where ID = " & id & " "
                        comando = New SqlCommand(modificar, conexion)
                        comando.ExecuteNonQuery()
                        MsgBox("se modificó el item de venta  exitosamente ")
                        llenar_grid_ventaitem()
                    Else
                        MsgBox("Id venta/producto o ambos, son incorrectos. El error puede deberse a que el precio unitario del producto no coincide con el precio real del mismo, o que el total no coincide con los valores de la venta, revise precios de producto")

                        conexion.Close()
                    End If
                Else
                    MsgBox("No hay registros para modificar")
                End If
            End If

        Else
            MsgBox("Debe completar todos los campos con valores numéricos")
        End If

        conexion.Close()
    End Sub

    Private Sub Btn_ItemCancelarMod_Click_1(sender As Object, e As EventArgs) Handles Btn_ItemCancelarMod.Click
        Btn_ItemAgregar.Enabled = True
        Btn_ItemBorrar.Enabled = True
        Btn_ItemModificar.Enabled = True
        Btn_ItemCancelarMod.Visible = False
        Btn_ItemAceptarMod.Visible = False
    End Sub

    Private Sub DGV_Ventas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Ventas.CellContentClick

        Select Case Cmb_Filtro.SelectedIndex
            Case 1, 2, 3
                Txb_IdCte.Text = ""
                Txb_Fecha.Text = ""
                Txb_TotVenta.Text = ""
            Case Else
                Txb_IdCte.Text = DGV_Ventas.CurrentRow.Cells(1).Value
                Txb_Fecha.Text = DGV_Ventas.CurrentRow.Cells(2).Value
                Txb_TotVenta.Text = DGV_Ventas.CurrentRow.Cells(3).Value


        End Select

    End Sub

    Private Sub DGV_ItemVenta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ItemVenta.CellContentClick
        Txb_ItemIDventa.Text = DGV_ItemVenta.CurrentRow.Cells(1).Value
        Txb_ItemIdproducto.Text = DGV_ItemVenta.CurrentRow.Cells(2).Value
        Txb_ItemPrecUnit.Text = DGV_ItemVenta.CurrentRow.Cells(3).Value
        Txb_ItemCant.Text = DGV_ItemVenta.CurrentRow.Cells(4).Value
        Txb_ItemTotal.Text = DGV_ItemVenta.CurrentRow.Cells(5).Value
    End Sub
End Class