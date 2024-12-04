Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports Microsoft.SqlServer
Public Class Clientes
    Dim conexion As New SqlConnection
    Dim leer As SqlDataReader
    Dim comando As SqlCommand
    Dim seleccion As SqlCommand
    Dim adaptador As New SqlDataAdapter
    Dim filtro As String = ""



    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection(conectarse_A_BDD)
        Cmb_Filtros.SelectedIndex = -1
        llenar_grid()
    End Sub

    Public Sub llenar_grid()
        Dim dt As New DataTable
        Dim consulta As String = "select * from clientes"
        Dim adaptador As New SqlDataAdapter(consulta, conexion)
        adaptador.Fill(dt)
        DGV_Clientes.DataSource = dt
    End Sub

    Private Sub Btn_Insertar_Click(sender As Object, e As EventArgs) Handles Btn_Insertar.Click

        If Txb_Cliente.Text <> "" And Txb_Correo.Text <> "" And Txb_Telefono.Text <> "" Then

            If IsNumeric(Txb_Telefono.Text) Then
                conexion.Open()
                Dim consulta As String = "select * from clientes where Cliente = '" & Txb_Cliente.Text & "'"
                seleccion = New SqlCommand(consulta, conexion)
                leer = seleccion.ExecuteReader()
                If (leer.Read()) Then
                    MsgBox("Error: Cliente ya registrado previamente")
                    Txb_Cliente.Text = ""
                Else
                    Dim insertar As String = "insert into clientes (Cliente, Telefono, Correo) values('" & Txb_Cliente.Text & "','" & Txb_Telefono.Text & "',
'" & Txb_Correo.Text & "')"
                    Dim comando = New SqlCommand(insertar, conexion)
                    comando.ExecuteNonQuery()
                    MsgBox("CLIENTE '" & Txb_Cliente.Text & "' REGISTRADO", vbOKOnly, "Registro Exitoso")
                    llenar_grid()


                End If

            Else
                MsgBox("Para agregar al cliente Debe ingresar un telefono válido")

            End If

        Else
            MsgBox("Para agregar al cliente Debe completar todos los campos")

        End If
        Txb_Correo.Text = ""
        Txb_Telefono.Text = ""
        Txb_Cliente.Text = ""
        conexion.Close()

    End Sub

    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click

        Dim confirmar = MsgBox("¿Seguro desea eliminar a este cliente? Recuerde que esta acción borrará automáticamente las ventas relacionadas a dicho cliente", vbOKCancel + vbQuestion, "Eliminar")
        If confirmar = vbOK Then
            conexion.Open()
            Dim consulta = "select * from clientes"
            seleccion = New SqlCommand(consulta, conexion)
            leer = seleccion.ExecuteReader
            If leer.Read Then

                Dim id = DGV_Clientes.CurrentRow.Cells(0).Value
                Dim eliminarventaitem As String = "delete from ventasitems where IDVenta in (select ID from ventas where IDCliente = " & id & ")"
                comando = New SqlCommand(eliminarventaitem, conexion)
                comando.ExecuteNonQuery()
                Dim eliminarVenta As String = "delete from ventas where IDCliente = " & id & ""
                comando = New SqlCommand(eliminarVenta, conexion)
                comando.ExecuteNonQuery()
                Dim eliminar As String = "DELETE FROM clientes WHERE ID= " & id & ""
                comando = New SqlCommand(eliminar, conexion)
                comando.ExecuteNonQuery()
                MsgBox("Se eliminó el cliente")
                llenar_grid()
                conexion.Close()
            Else
                MsgBox("No hay elementos para eliminar")
                conexion.Close()
            End If
        End If

    End Sub

    Private Sub Btn_Modificar_Click(sender As Object, e As EventArgs) Handles Btn_Modificar.Click
        llenar_grid()

        Dim cte = DGV_Clientes.CurrentRow.Cells(1).Value
        Dim tel = DGV_Clientes.CurrentRow.Cells(2).Value
        Dim mail = DGV_Clientes.CurrentRow.Cells(3).Value
        If Txb_Telefono.Text = tel And Txb_Correo.Text = mail And Txb_Cliente.Text = cte Then
            MsgBox("Los datos del cliente " & cte & " son idénticos a los cargados en sistema, MODIFICACIÓN CANCELADA")
        Else
            MsgBox("para el usuario '" & Txb_Cliente.Text & "', modificaremos su telefono y mail, asignando los solicitados")
            If Txb_Cliente.Text <> "" And Txb_Correo.Text <> "" And Txb_Telefono.Text <> "" And IsNumeric(Txb_Telefono.Text) Then
                conexion.Open()
                Dim consulta As String = "select * from clientes where Cliente = '" & Txb_Cliente.Text & "'"
                seleccion = New SqlCommand(consulta, conexion)
                leer = seleccion.ExecuteReader()
                If leer.Read() Then
                    Dim modificar As String = "update clientes set Correo = '" & Txb_Correo.Text & "', Telefono = '" & Txb_Telefono.Text & "' where Cliente = '" & Txb_Cliente.Text & "'"
                    comando = New SqlCommand(modificar, conexion)
                    comando.ExecuteNonQuery()
                    MsgBox("Modificación Exitosa. Usuario: '" & Txb_Cliente.Text & "' | Tel: '" & Txb_Telefono.Text & "' | Correo: '" & Txb_Correo.Text & "'")
                    llenar_grid()
                Else
                    MsgBox("No se ha encontrado al cliente")
                End If
                Txb_Correo.Text = ""
                Txb_Telefono.Text = ""
                Txb_Cliente.Text = ""
                conexion.Close()

            Else
                MsgBox("Debe completar los campos, recuerde en telefono ingresar un numero valido")

            End If
        End If

    End Sub

    Private Sub Btn_ValidarFiltros_Click(sender As Object, e As EventArgs) Handles Btn_ValidarFiltros.Click
        Dim acumulador As String = ""
        If Cmb_Filtros.SelectedIndex < 0 Then
            MsgBox("Debe seleccionar un filtro antes de avanzar")
        Else
            conexion.Open()

            If Cmb_Filtros.SelectedIndex = 3 Then

                Btn_ConfirmarBusqueda.Visible = False
                Txb_Filtros.Visible = False
                llenar_grid()

            Else

                Btn_ConfirmarBusqueda.Visible = True
                Txb_Filtros.Visible = True
                filtro = Cmb_Filtros.SelectedItem()
                Lbl_DescFiltros.Text = "Ingrese " & filtro & ""
            End If


            conexion.Close()

        End If
    End Sub
    Private Sub Btn_ConfirmarBusqueda_Click(sender As Object, e As EventArgs) Handles Btn_ConfirmarBusqueda.Click
        filtro = Cmb_Filtros.SelectedItem()

        Dim acumulador As String = ""
        If Txb_Filtros.Text <> "" Then
            conexion.Open()
            Dim consulta As String = "select * from clientes where " & filtro & " = '" & Txb_Filtros.Text & "'"
            Dim dt As New DataTable
            Dim adaptador As New SqlDataAdapter(consulta, conexion)
            adaptador.Fill(dt)
            DGV_Clientes.DataSource = dt
            Dim totalDatos = DGV_Clientes.RowCount - 1
            If totalDatos = 0 Then
                MsgBox("No se encontraron registros")
            End If
        Else
            MsgBox("debe completar el filtro seleccioando")
        End If
        conexion.Close()
        Btn_ValidarFiltros.Enabled = True
        Cmb_Filtros.SelectedIndex = -1
        Txb_Filtros.Text = ""
        Btn_ConfirmarBusqueda.Visible = False
        Txb_Filtros.Visible = False
    End Sub


    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub Btn_Volver_Click(sender As Object, e As EventArgs) Handles Btn_Volver.Click
        Principal.Show()
        Me.Close()
    End Sub



    Private Sub DGV_Clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Clientes.CellContentClick
        Txb_Cliente.Text = DGV_Clientes.CurrentRow.Cells(1).Value
        Txb_Telefono.Text = DGV_Clientes.CurrentRow.Cells(2).Value
        Txb_Correo.Text = DGV_Clientes.CurrentRow.Cells(3).Value
    End Sub

End Class
