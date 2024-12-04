<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Lbl_Correo = New Label()
        Lbl_Tel = New Label()
        Lbl_Cliente = New Label()
        Txb_Correo = New TextBox()
        Txb_Cliente = New TextBox()
        Txb_Telefono = New TextBox()
        Btn_Insertar = New Button()
        Btn_Eliminar = New Button()
        Btn_Modificar = New Button()
        Label1 = New Label()
        Cmb_Filtros = New ComboBox()
        Lbl_Filtros = New Label()
        Btn_ValidarFiltros = New Button()
        Lbl_DescFiltros = New Label()
        Txb_Filtros = New TextBox()
        Btn_ConfirmarBusqueda = New Button()
        Btn_Salir = New Button()
        Btn_Volver = New Button()
        DGV_Clientes = New DataGridView()
        Label2 = New Label()
        CType(DGV_Clientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Lbl_Correo
        ' 
        Lbl_Correo.AutoSize = True
        Lbl_Correo.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_Correo.ForeColor = SystemColors.ButtonHighlight
        Lbl_Correo.Location = New Point(558, 202)
        Lbl_Correo.Name = "Lbl_Correo"
        Lbl_Correo.Size = New Size(101, 30)
        Lbl_Correo.TabIndex = 1
        Lbl_Correo.Text = "CORREO"
        ' 
        ' Lbl_Tel
        ' 
        Lbl_Tel.AutoSize = True
        Lbl_Tel.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_Tel.ForeColor = SystemColors.ButtonHighlight
        Lbl_Tel.Location = New Point(554, 102)
        Lbl_Tel.Name = "Lbl_Tel"
        Lbl_Tel.Size = New Size(123, 30)
        Lbl_Tel.TabIndex = 2
        Lbl_Tel.Text = "TELEFONO"
        ' 
        ' Lbl_Cliente
        ' 
        Lbl_Cliente.AutoSize = True
        Lbl_Cliente.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_Cliente.ForeColor = SystemColors.ButtonHighlight
        Lbl_Cliente.Location = New Point(558, 6)
        Lbl_Cliente.Name = "Lbl_Cliente"
        Lbl_Cliente.Size = New Size(108, 30)
        Lbl_Cliente.TabIndex = 3
        Lbl_Cliente.Text = "NOMBRE"
        ' 
        ' Txb_Correo
        ' 
        Txb_Correo.Location = New Point(422, 253)
        Txb_Correo.Name = "Txb_Correo"
        Txb_Correo.Size = New Size(367, 31)
        Txb_Correo.TabIndex = 4
        ' 
        ' Txb_Cliente
        ' 
        Txb_Cliente.Location = New Point(422, 55)
        Txb_Cliente.Name = "Txb_Cliente"
        Txb_Cliente.Size = New Size(367, 31)
        Txb_Cliente.TabIndex = 5
        ' 
        ' Txb_Telefono
        ' 
        Txb_Telefono.Location = New Point(419, 154)
        Txb_Telefono.Name = "Txb_Telefono"
        Txb_Telefono.Size = New Size(370, 31)
        Txb_Telefono.TabIndex = 6
        ' 
        ' Btn_Insertar
        ' 
        Btn_Insertar.BackColor = Color.SeaGreen
        Btn_Insertar.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Insertar.ForeColor = Color.Ivory
        Btn_Insertar.Location = New Point(288, 309)
        Btn_Insertar.Name = "Btn_Insertar"
        Btn_Insertar.Size = New Size(133, 93)
        Btn_Insertar.TabIndex = 7
        Btn_Insertar.Text = "REGISTRAR CLIENTE"
        Btn_Insertar.UseVisualStyleBackColor = False
        ' 
        ' Btn_Eliminar
        ' 
        Btn_Eliminar.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Eliminar.ForeColor = Color.Red
        Btn_Eliminar.Location = New Point(538, 309)
        Btn_Eliminar.Name = "Btn_Eliminar"
        Btn_Eliminar.Size = New Size(126, 93)
        Btn_Eliminar.TabIndex = 9
        Btn_Eliminar.Text = "ELIMINAR CLIENTE"
        Btn_Eliminar.UseVisualStyleBackColor = True
        ' 
        ' Btn_Modificar
        ' 
        Btn_Modificar.BackColor = Color.Orange
        Btn_Modificar.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Modificar.ForeColor = SystemColors.ButtonFace
        Btn_Modificar.Location = New Point(784, 309)
        Btn_Modificar.Name = "Btn_Modificar"
        Btn_Modificar.Size = New Size(136, 93)
        Btn_Modificar.TabIndex = 10
        Btn_Modificar.Text = "MODIFICAR CONTACTO"
        Btn_Modificar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(134, 521)
        Label1.Name = "Label1"
        Label1.Size = New Size(242, 38)
        Label1.TabIndex = 11
        Label1.Text = "BUSCAR CLIENTE"
        ' 
        ' Cmb_Filtros
        ' 
        Cmb_Filtros.FormattingEnabled = True
        Cmb_Filtros.Items.AddRange(New Object() {"Cliente", "Telefono", "Correo", "VER TODOS LOS CLIENTES "})
        Cmb_Filtros.Location = New Point(491, 520)
        Cmb_Filtros.Name = "Cmb_Filtros"
        Cmb_Filtros.Size = New Size(214, 33)
        Cmb_Filtros.TabIndex = 12
        ' 
        ' Lbl_Filtros
        ' 
        Lbl_Filtros.AutoSize = True
        Lbl_Filtros.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_Filtros.ForeColor = SystemColors.ButtonHighlight
        Lbl_Filtros.Location = New Point(556, 460)
        Lbl_Filtros.Name = "Lbl_Filtros"
        Lbl_Filtros.Size = New Size(88, 28)
        Lbl_Filtros.TabIndex = 13
        Lbl_Filtros.Text = "FILTROS"
        ' 
        ' Btn_ValidarFiltros
        ' 
        Btn_ValidarFiltros.BackColor = Color.SeaGreen
        Btn_ValidarFiltros.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_ValidarFiltros.ForeColor = Color.Ivory
        Btn_ValidarFiltros.Location = New Point(518, 594)
        Btn_ValidarFiltros.Name = "Btn_ValidarFiltros"
        Btn_ValidarFiltros.Size = New Size(148, 53)
        Btn_ValidarFiltros.TabIndex = 14
        Btn_ValidarFiltros.Text = "SIGUIENTE"
        Btn_ValidarFiltros.UseVisualStyleBackColor = False
        ' 
        ' Lbl_DescFiltros
        ' 
        Lbl_DescFiltros.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_DescFiltros.ForeColor = SystemColors.ButtonHighlight
        Lbl_DescFiltros.Location = New Point(872, 452)
        Lbl_DescFiltros.Name = "Lbl_DescFiltros"
        Lbl_DescFiltros.Size = New Size(214, 38)
        Lbl_DescFiltros.TabIndex = 15
        Lbl_DescFiltros.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Txb_Filtros
        ' 
        Txb_Filtros.Location = New Point(853, 522)
        Txb_Filtros.Name = "Txb_Filtros"
        Txb_Filtros.Size = New Size(245, 31)
        Txb_Filtros.TabIndex = 16
        Txb_Filtros.Visible = False
        ' 
        ' Btn_ConfirmarBusqueda
        ' 
        Btn_ConfirmarBusqueda.BackColor = Color.SeaGreen
        Btn_ConfirmarBusqueda.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_ConfirmarBusqueda.ForeColor = Color.Ivory
        Btn_ConfirmarBusqueda.Location = New Point(904, 594)
        Btn_ConfirmarBusqueda.Name = "Btn_ConfirmarBusqueda"
        Btn_ConfirmarBusqueda.Size = New Size(148, 53)
        Btn_ConfirmarBusqueda.TabIndex = 17
        Btn_ConfirmarBusqueda.Text = "CONFIRMAR"
        Btn_ConfirmarBusqueda.UseVisualStyleBackColor = False
        Btn_ConfirmarBusqueda.Visible = False
        ' 
        ' Btn_Salir
        ' 
        Btn_Salir.BackColor = Color.Black
        Btn_Salir.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Salir.ForeColor = SystemColors.ButtonHighlight
        Btn_Salir.Location = New Point(1010, 111)
        Btn_Salir.Name = "Btn_Salir"
        Btn_Salir.Size = New Size(112, 48)
        Btn_Salir.TabIndex = 20
        Btn_Salir.Text = "SALIR"
        Btn_Salir.UseVisualStyleBackColor = False
        ' 
        ' Btn_Volver
        ' 
        Btn_Volver.BackColor = Color.Black
        Btn_Volver.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Volver.ForeColor = SystemColors.ButtonHighlight
        Btn_Volver.Location = New Point(1010, 236)
        Btn_Volver.Name = "Btn_Volver"
        Btn_Volver.Size = New Size(112, 48)
        Btn_Volver.TabIndex = 21
        Btn_Volver.Text = "VOLVER"
        Btn_Volver.UseVisualStyleBackColor = False
        ' 
        ' DGV_Clientes
        ' 
        DGV_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_Clientes.Location = New Point(151, 665)
        DGV_Clientes.Name = "DGV_Clientes"
        DGV_Clientes.RowHeadersWidth = 62
        DGV_Clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV_Clientes.Size = New Size(901, 334)
        DGV_Clientes.TabIndex = 22
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Black
        Label2.Location = New Point(-23, 438)
        Label2.Name = "Label2"
        Label2.Size = New Size(1329, 14)
        Label2.TabIndex = 68
        ' 
        ' Clientes
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Red
        ClientSize = New Size(1243, 1011)
        Controls.Add(Label2)
        Controls.Add(DGV_Clientes)
        Controls.Add(Btn_Volver)
        Controls.Add(Btn_Salir)
        Controls.Add(Btn_ConfirmarBusqueda)
        Controls.Add(Txb_Filtros)
        Controls.Add(Lbl_DescFiltros)
        Controls.Add(Btn_ValidarFiltros)
        Controls.Add(Lbl_Filtros)
        Controls.Add(Cmb_Filtros)
        Controls.Add(Label1)
        Controls.Add(Btn_Modificar)
        Controls.Add(Btn_Eliminar)
        Controls.Add(Btn_Insertar)
        Controls.Add(Txb_Telefono)
        Controls.Add(Txb_Cliente)
        Controls.Add(Txb_Correo)
        Controls.Add(Lbl_Cliente)
        Controls.Add(Lbl_Tel)
        Controls.Add(Lbl_Correo)
        Name = "Clientes"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Clientes"
        CType(DGV_Clientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_Correo As Label
    Friend WithEvents Lbl_Tel As Label
    Friend WithEvents Lbl_Cliente As Label
    Friend WithEvents Txb_Correo As TextBox
    Friend WithEvents Txb_Cliente As TextBox
    Friend WithEvents Txb_Telefono As TextBox
    Friend WithEvents Btn_Insertar As Button
    Friend WithEvents Btn_Eliminar As Button
    Friend WithEvents Btn_Modificar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Cmb_Filtros As ComboBox
    Friend WithEvents Lbl_Filtros As Label
    Friend WithEvents Btn_ValidarFiltros As Button
    Friend WithEvents Lbl_DescFiltros As Label
    Friend WithEvents Txb_Filtros As TextBox
    Friend WithEvents Btn_ConfirmarBusqueda As Button
    Friend WithEvents Btn_Salir As Button
    Friend WithEvents Btn_Volver As Button
    Friend WithEvents DGV_Clientes As DataGridView
    Friend WithEvents Label2 As Label

End Class
