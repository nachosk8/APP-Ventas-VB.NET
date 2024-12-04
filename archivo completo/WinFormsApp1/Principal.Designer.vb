<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Btn_FormsClientes = New Button()
        Btn_FormsProductos = New Button()
        Btn_FormsVentas = New Button()
        Btn_salida = New Button()
        DGV_ReportesCompletos = New DataGridView()
        Btn_ActReportes = New Button()
        CType(DGV_ReportesCompletos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Btn_FormsClientes
        ' 
        Btn_FormsClientes.Cursor = Cursors.Hand
        Btn_FormsClientes.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_FormsClientes.ForeColor = Color.Red
        Btn_FormsClientes.Location = New Point(402, 97)
        Btn_FormsClientes.Name = "Btn_FormsClientes"
        Btn_FormsClientes.Size = New Size(255, 143)
        Btn_FormsClientes.TabIndex = 9
        Btn_FormsClientes.Text = "SECTOR CLIENTES"
        Btn_FormsClientes.UseVisualStyleBackColor = True
        ' 
        ' Btn_FormsProductos
        ' 
        Btn_FormsProductos.Cursor = Cursors.Hand
        Btn_FormsProductos.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_FormsProductos.ForeColor = Color.Red
        Btn_FormsProductos.Location = New Point(729, 97)
        Btn_FormsProductos.Name = "Btn_FormsProductos"
        Btn_FormsProductos.Size = New Size(255, 143)
        Btn_FormsProductos.TabIndex = 10
        Btn_FormsProductos.Text = "SECTOR PRODUCTOS"
        Btn_FormsProductos.UseVisualStyleBackColor = True
        ' 
        ' Btn_FormsVentas
        ' 
        Btn_FormsVentas.Cursor = Cursors.Hand
        Btn_FormsVentas.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_FormsVentas.ForeColor = Color.Red
        Btn_FormsVentas.Location = New Point(84, 97)
        Btn_FormsVentas.Name = "Btn_FormsVentas"
        Btn_FormsVentas.Size = New Size(255, 143)
        Btn_FormsVentas.TabIndex = 11
        Btn_FormsVentas.Text = "SECTOR VENTAS"
        Btn_FormsVentas.UseVisualStyleBackColor = True
        ' 
        ' Btn_salida
        ' 
        Btn_salida.BackColor = Color.WhiteSmoke
        Btn_salida.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_salida.ForeColor = Color.Red
        Btn_salida.Location = New Point(916, 38)
        Btn_salida.Name = "Btn_salida"
        Btn_salida.Size = New Size(68, 34)
        Btn_salida.TabIndex = 12
        Btn_salida.Text = "X"
        Btn_salida.UseVisualStyleBackColor = False
        ' 
        ' DGV_ReportesCompletos
        ' 
        DGV_ReportesCompletos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_ReportesCompletos.Location = New Point(84, 480)
        DGV_ReportesCompletos.Name = "DGV_ReportesCompletos"
        DGV_ReportesCompletos.RowHeadersWidth = 62
        DGV_ReportesCompletos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV_ReportesCompletos.Size = New Size(900, 256)
        DGV_ReportesCompletos.TabIndex = 15
        DGV_ReportesCompletos.Visible = False
        ' 
        ' Btn_ActReportes
        ' 
        Btn_ActReportes.BackColor = Color.Purple
        Btn_ActReportes.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_ActReportes.ForeColor = Color.White
        Btn_ActReportes.Location = New Point(178, 324)
        Btn_ActReportes.Name = "Btn_ActReportes"
        Btn_ActReportes.Size = New Size(736, 54)
        Btn_ActReportes.TabIndex = 16
        Btn_ActReportes.Text = "VER REPORTES DE TODAS LAS VENTAS"
        Btn_ActReportes.UseVisualStyleBackColor = False
        ' 
        ' Principal
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.Red
        ClientSize = New Size(1082, 761)
        Controls.Add(Btn_ActReportes)
        Controls.Add(DGV_ReportesCompletos)
        Controls.Add(Btn_salida)
        Controls.Add(Btn_FormsVentas)
        Controls.Add(Btn_FormsProductos)
        Controls.Add(Btn_FormsClientes)
        Name = "Principal"
        Text = "MENU"
        CType(DGV_ReportesCompletos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Btn_FormsClientes As Button
    Friend WithEvents Btn_FormsProductos As Button
    Friend WithEvents Btn_FormsVentas As Button
    Friend WithEvents Btn_salida As Button
    Friend WithEvents DGV_ReportesCompletos As DataGridView
    Friend WithEvents Btn_ActReportes As Button
End Class
