Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.SqlServer
Public Class Principal
    Dim conexion As New SqlConnection
    Dim leer As SqlDataReader
    Dim comando As SqlCommand
    Dim seleccion As SqlCommand

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection(conectarse_A_BDD)


    End Sub

    Private Sub Btn_FormsClientes_Click(sender As Object, e As EventArgs) Handles Btn_FormsClientes.Click
        DGV_ReportesCompletos.Visible = False
        Clientes.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_FormsProductos_Click(sender As Object, e As EventArgs) Handles Btn_FormsProductos.Click
        DGV_ReportesCompletos.Visible = False
        Me.Hide()
        Productos.Show()
    End Sub

    Private Sub Btn_FormsVentas_Click(sender As Object, e As EventArgs) Handles Btn_FormsVentas.Click
        DGV_ReportesCompletos.Visible = False
        Me.Hide()
        Ventas.Show()
    End Sub

    Private Sub Btn_salida_Click(sender As Object, e As EventArgs) Handles Btn_salida.Click
        Me.Close()
    End Sub

    Private Sub Btn_ActReportes_Click(sender As Object, e As EventArgs) Handles Btn_ActReportes.Click
        conexion.Open()

        DGV_ReportesCompletos.Visible = True
        Dim dt As New DataTable
        Dim consulta As String = "select c.Cliente, c.Telefono, c.Correo, v.Fecha, v.Total ,vi.Cantidad, p.Nombre, p.Categoria from clientes c inner join ventas v on c.ID = v.IDCliente inner join ventasitems vi on v.ID = vi.IDVenta inner join productos p on vi.IDProducto = p.ID"
        Dim adaptador As New SqlDataAdapter(consulta, conexion)
        adaptador.Fill(dt)
        DGV_ReportesCompletos.DataSource = dt
        conexion.Close()
    End Sub




End Class