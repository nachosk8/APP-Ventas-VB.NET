Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.SqlServer
Public Class Productos
    Dim conexion As New SqlConnection
    Dim leer As SqlDataReader
    Dim comando As SqlCommand
    Dim seleccion As SqlCommand
    Dim adaptador As New SqlDataAdapter

    Public Sub llenar_grid()
        Dim dt As New DataTable
        Dim consulta As String = "select * from productos"
        Dim adaptador As New SqlDataAdapter(consulta, conexion)
        adaptador.Fill(dt)
        DGV_Productos.DataSource = dt
    End Sub
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection(conectarse_A_BDD)
        llenar_grid()
    End Sub
    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub Btn_Volver_Click(sender As Object, e As EventArgs) Handles Btn_Volver.Click
        Me.Close()
        Principal.Show()
    End Sub

    Private Sub Btn_AgregarProd_Click(sender As Object, e As EventArgs) Handles Btn_AgregarProd.Click
        conexion.Open()
        If Txb_Categoria.Text <> "" And Txb_Precio.Text <> "" And Txb_Producto.Text <> "" And IsNumeric(Txb_Precio.Text) And Val(Txb_Precio.Text) > 0 Then

            Dim consulta As String = "select * from productos where Nombre = '" & Txb_Producto.Text & "'"
            comando = New SqlCommand(consulta, conexion)
            leer = comando.ExecuteReader()
            If leer.Read() Then
                MsgBox("Erro: Ya tenemos registrado " & Txb_Producto.Text & "")
                Txb_Producto.Text = ""
            Else
                Dim insertar As String = "insert into productos (Nombre, Precio, Categoria) values('" & Txb_Producto.Text & "', " & Txb_Precio.Text & ", '" & Txb_Categoria.Text & "')"
                comando = New SqlCommand(insertar, conexion)
                comando.ExecuteNonQuery()
                MsgBox("Se agregó el producto " & Txb_Producto.Text & " con precio " & Txb_Precio.Text & " y categoria " & Txb_Categoria.Text & "")
                Txb_Categoria.Text = ""
                Txb_Precio.Text = ""
                Txb_Producto.Text = ""
                llenar_grid()
            End If

        Else
            MsgBox("Los datos ingresado son incorrectos")
        End If
        conexion.Close()
    End Sub

    Private Sub Btn_EliminarProd_Click(sender As Object, e As EventArgs) Handles Btn_EliminarProd.Click
        Dim confirmar = MsgBox("¿Seguro desea eliminar a este producto? Recuerde que esta acción borrará automáticamente las ventas relacionadas a dicho producto", vbOKCancel + vbQuestion, "Eliminar")
        If confirmar = vbOK Then
            conexion.Open()
            Dim consulta = "select * from clientes"
            seleccion = New SqlCommand(consulta, conexion)
            leer = seleccion.ExecuteReader
            If leer.Read Then

                Dim id = DGV_Productos.CurrentRow.Cells(0).Value
                Dim eliminarVenta As String = "delete from ventasitems where IDProducto = " & id & ""
                comando = New SqlCommand(eliminarVenta, conexion)
                comando.ExecuteNonQuery()
                Dim eliminar As String = "DELETE FROM productos WHERE ID= " & id & ""
                comando = New SqlCommand(eliminar, conexion)
                comando.ExecuteNonQuery()
                MsgBox("Se eliminó el producto")
                llenar_grid()
                conexion.Close()
            Else
                MsgBox("No hay elementos para eliminar")
                conexion.Close()
            End If
        End If
        'conexion.Open()
        'If Txb_Categoria.Text <> "" And Txb_Precio.Text <> "" And Txb_Producto.Text <> "" And IsNumeric(Txb_Precio.Text) And Val(Txb_Precio.Text) > 0 Then

        '    Dim consulta As String = "select * from productos where Nombre = '" & Txb_Producto.Text & "' and Precio = " & Txb_Precio.Text & " and Categoria = '" & Txb_Categoria.Text & "'"
        '    comando = New SqlCommand(consulta, conexion)
        '    leer = comando.ExecuteReader()
        '    If leer.Read() Then
        '        Dim confirmar = MsgBox("¿Seguro desea eliminar este producto? Recuerde que esta acción borrará automáticamente los items de ventas relacionados a este producto", vbOKCancel + vbQuestion, "Eliminar")
        '        If confirmar = vbOK Then
        '            Dim id = leer("ID")
        '            Dim eliminarCascada As String = "delete from ventasitems where IDProducto= " & id & ""
        '            Dim quitar As String = "delete from productos where Nombre= '" & Txb_Producto.Text & "'"
        '            comando = New SqlCommand(quitar, conexion)
        '            comando.ExecuteNonQuery()
        '            comando = New SqlCommand(eliminarCascada, conexion)
        '            comando.ExecuteNonQuery()
        '            MsgBox("Se ha eliminado exitosamente el producto " & Txb_Producto.Text & "")
        '            Txb_Categoria.Text = ""
        '            Txb_Precio.Text = ""
        '            Txb_Producto.Text = ""
        '            llenar_grid()
        '        End If


        '    Else
        '        MsgBox("Error: Registro no encontrado")
        '    End If



        'Else
        '    MsgBox("Los datos ingresado son incorrectos, Para eliminar un producto debe ingresar todos sus datos correctamente. Si no los recuerda, puede consultarlos en la tabla de 'Stock Completo'")
        'End If
        'conexion.Close()
    End Sub

    Private Sub Btn_ModificarProd_Click(sender As Object, e As EventArgs) Handles Btn_ModificarProd.Click
        llenar_grid()

        Dim nombre = DGV_Productos.CurrentRow.Cells(1).Value
        Dim precio = DGV_Productos.CurrentRow.Cells(2).Value
        Dim categoria = DGV_Productos.CurrentRow.Cells(3).Value
        If Txb_Producto.Text = nombre And Txb_Precio.Text = precio.ToString And Txb_Categoria.Text = categoria Then
            MsgBox("Los datos del producto " & nombre & " son idénticos a los cargados en sistema, MODIFICACIÓN CANCELADA")
        Else

            If Txb_Categoria.Text <> "" And Txb_Precio.Text <> "" And Txb_Producto.Text <> "" And IsNumeric(Txb_Precio.Text) And Val(Txb_Precio.Text) > 0 Then
                conexion.Open()
                Dim consulta As String = "select * from productos where nombre = '" & Txb_Producto.Text & "' and categoria = '" & Txb_Categoria.Text & "'"
                comando = New SqlCommand(consulta, conexion)
                leer = comando.ExecuteReader()
                If leer.Read() Then
                    Dim cambio As String = "update productos set precio = " & Txb_Precio.Text & " where nombre = '" & Txb_Producto.Text & "'"
                    comando = New SqlCommand(cambio, conexion)
                    comando.ExecuteNonQuery()
                    MsgBox("se ha actualizado el precio del producto " & Txb_Producto.Text & " a $" & Txb_Precio.Text & "")
                    Txb_Categoria.Text = ""
                    Txb_Precio.Text = ""
                    Txb_Producto.Text = ""
                    conexion.Close()

                Else
                    MsgBox("registro no encontrado")
                    conexion.Close()
                End If
            Else
                MsgBox("debe completar todos los campos")
            End If

        End If
        'MsgBox("Si usted ingresa correctamente el nombre y categoria del producto, el precio actual se modificará, quedando el que usted haya escrito en precio")
        'conexion.Open()
        'If Txb_Categoria.Text <> "" And Txb_Precio.Text <> "" And Txb_Producto.Text <> "" And IsNumeric(Txb_Precio.Text) And Val(Txb_Precio.Text) > 0 Then
        '    Dim consulta As String = "select * from productos where Nombre = '" & Txb_Producto.Text & "' and Categoria = '" & Txb_Categoria.Text & "'"
        '    comando = New SqlCommand(consulta, conexion)
        '    leer = comando.ExecuteReader()
        '    If leer.Read() Then
        '        Dim cambio As String = "update productos set Precio = " & Txb_Precio.Text & " where Nombre = '" & Txb_Producto.Text & "'"
        '        comando = New SqlCommand(cambio, conexion)
        '        comando.ExecuteNonQuery()
        '        MsgBox("Se ha actualizado el precio del producto " & Txb_Producto.Text & " a $" & Txb_Precio.Text & "")
        '        Txb_Categoria.Text = ""
        '        Txb_Precio.Text = ""
        '        Txb_Producto.Text = ""

        '    Else
        '        MsgBox("Registro no encontrado")
        '    End If
        'Else
        '    MsgBox("Debe completar todos los campos")
        'End If

        'conexion.Close()
    End Sub

    Private Sub Btn_StockCompleto_Click(sender As Object, e As EventArgs) Handles Btn_StockCompleto.Click
        Txb_MaxPrecio.Text = ""
        Txb_MinPrecio.Text = ""
        conexion.Open()
        llenar_grid()
        If DGV_Productos.RowCount - 1 < 1 Then
            MsgBox("No hay Stock")
        End If

        conexion.Close()
    End Sub

    Private Sub Btn_Rango_Click(sender As Object, e As EventArgs) Handles Btn_Rango.Click
        Dim dt As New DataTable
        Dim acumulador As String = ""
        conexion.Open()
        If IsNumeric(Txb_MinPrecio.Text) And IsNumeric(Txb_MaxPrecio.Text) And Val(Txb_MinPrecio.Text) <= Val(Txb_MaxPrecio.Text) And Val(Txb_MinPrecio.Text) > 0 Then
            Dim consulta As String = "Select * from productos where Precio >= " & Val(Txb_MinPrecio.Text) & " and Precio <= " & Val(Txb_MaxPrecio.Text) & ""
            Dim adaptador As New SqlDataAdapter(consulta, conexion)
            adaptador.Fill(dt)
            DGV_Productos.DataSource = dt
            Dim totalDatos = DGV_Productos.RowCount - 1

            If totalDatos < 1 Then
                MsgBox("No hay productos entre $" & Txb_MinPrecio.Text & " y $" & Txb_MaxPrecio.Text & "")
            End If
        Else
            MsgBox("Los rangos precio minimo y maximo deben tener valores numéricos mayores a 0, además el rango mínimo no puede ser mayor al rango maximo")
        End If

        conexion.Close()
    End Sub

    Private Sub DGV_Productos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Productos.CellContentClick
        Txb_Producto.Text = DGV_Productos.CurrentRow.Cells(1).Value
        Txb_Precio.Text = DGV_Productos.CurrentRow.Cells(2).Value
        Txb_Categoria.Text = DGV_Productos.CurrentRow.Cells(3).Value

    End Sub
End Class