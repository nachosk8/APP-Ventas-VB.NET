<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos))
        Txb_Precio = New TextBox()
        Txb_Producto = New TextBox()
        Txb_Categoria = New TextBox()
        Lbl_Producto = New Label()
        Lbl_Precio = New Label()
        Lbl_Correo = New Label()
        Btn_AgregarProd = New Button()
        Btn_ModificarProd = New Button()
        Btn_EliminarProd = New Button()
        Lbl_Consulta = New Label()
        Btn_StockCompleto = New Button()
        Lbl_Rango = New Label()
        Lbl_Min = New Label()
        Lbl_Max = New Label()
        Txb_MinPrecio = New TextBox()
        Btn_Rango = New Button()
        Txb_MaxPrecio = New TextBox()
        Btn_Volver = New Button()
        Btn_Salir = New Button()
        DGV_Productos = New DataGridView()
        Label1 = New Label()
        CType(DGV_Productos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Txb_Precio
        ' 
        resources.ApplyResources(Txb_Precio, "Txb_Precio")
        Txb_Precio.Name = "Txb_Precio"
        ' 
        ' Txb_Producto
        ' 
        resources.ApplyResources(Txb_Producto, "Txb_Producto")
        Txb_Producto.Name = "Txb_Producto"
        ' 
        ' Txb_Categoria
        ' 
        resources.ApplyResources(Txb_Categoria, "Txb_Categoria")
        Txb_Categoria.Name = "Txb_Categoria"
        ' 
        ' Lbl_Producto
        ' 
        resources.ApplyResources(Lbl_Producto, "Lbl_Producto")
        Lbl_Producto.ForeColor = SystemColors.ButtonHighlight
        Lbl_Producto.Name = "Lbl_Producto"
        ' 
        ' Lbl_Precio
        ' 
        resources.ApplyResources(Lbl_Precio, "Lbl_Precio")
        Lbl_Precio.ForeColor = SystemColors.ButtonHighlight
        Lbl_Precio.Name = "Lbl_Precio"
        ' 
        ' Lbl_Correo
        ' 
        resources.ApplyResources(Lbl_Correo, "Lbl_Correo")
        Lbl_Correo.ForeColor = SystemColors.ButtonHighlight
        Lbl_Correo.Name = "Lbl_Correo"
        ' 
        ' Btn_AgregarProd
        ' 
        Btn_AgregarProd.BackColor = Color.Gainsboro
        resources.ApplyResources(Btn_AgregarProd, "Btn_AgregarProd")
        Btn_AgregarProd.ForeColor = Color.OliveDrab
        Btn_AgregarProd.Name = "Btn_AgregarProd"
        Btn_AgregarProd.UseVisualStyleBackColor = False
        ' 
        ' Btn_ModificarProd
        ' 
        Btn_ModificarProd.BackColor = Color.Gainsboro
        resources.ApplyResources(Btn_ModificarProd, "Btn_ModificarProd")
        Btn_ModificarProd.ForeColor = Color.Black
        Btn_ModificarProd.Name = "Btn_ModificarProd"
        Btn_ModificarProd.UseVisualStyleBackColor = False
        ' 
        ' Btn_EliminarProd
        ' 
        Btn_EliminarProd.BackColor = Color.LightGray
        resources.ApplyResources(Btn_EliminarProd, "Btn_EliminarProd")
        Btn_EliminarProd.ForeColor = Color.Red
        Btn_EliminarProd.Name = "Btn_EliminarProd"
        Btn_EliminarProd.UseVisualStyleBackColor = False
        ' 
        ' Lbl_Consulta
        ' 
        resources.ApplyResources(Lbl_Consulta, "Lbl_Consulta")
        Lbl_Consulta.ForeColor = SystemColors.ButtonHighlight
        Lbl_Consulta.Name = "Lbl_Consulta"
        ' 
        ' Btn_StockCompleto
        ' 
        Btn_StockCompleto.BackColor = Color.Gold
        resources.ApplyResources(Btn_StockCompleto, "Btn_StockCompleto")
        Btn_StockCompleto.ForeColor = SystemColors.InactiveCaptionText
        Btn_StockCompleto.Name = "Btn_StockCompleto"
        Btn_StockCompleto.UseVisualStyleBackColor = False
        ' 
        ' Lbl_Rango
        ' 
        resources.ApplyResources(Lbl_Rango, "Lbl_Rango")
        Lbl_Rango.ForeColor = SystemColors.ButtonHighlight
        Lbl_Rango.Name = "Lbl_Rango"
        ' 
        ' Lbl_Min
        ' 
        resources.ApplyResources(Lbl_Min, "Lbl_Min")
        Lbl_Min.ForeColor = SystemColors.ButtonHighlight
        Lbl_Min.Name = "Lbl_Min"
        ' 
        ' Lbl_Max
        ' 
        resources.ApplyResources(Lbl_Max, "Lbl_Max")
        Lbl_Max.ForeColor = SystemColors.ButtonHighlight
        Lbl_Max.Name = "Lbl_Max"
        ' 
        ' Txb_MinPrecio
        ' 
        resources.ApplyResources(Txb_MinPrecio, "Txb_MinPrecio")
        Txb_MinPrecio.Name = "Txb_MinPrecio"
        ' 
        ' Btn_Rango
        ' 
        Btn_Rango.BackColor = Color.Gold
        resources.ApplyResources(Btn_Rango, "Btn_Rango")
        Btn_Rango.Name = "Btn_Rango"
        Btn_Rango.UseVisualStyleBackColor = False
        ' 
        ' Txb_MaxPrecio
        ' 
        resources.ApplyResources(Txb_MaxPrecio, "Txb_MaxPrecio")
        Txb_MaxPrecio.Name = "Txb_MaxPrecio"
        ' 
        ' Btn_Volver
        ' 
        Btn_Volver.BackColor = Color.Black
        resources.ApplyResources(Btn_Volver, "Btn_Volver")
        Btn_Volver.ForeColor = SystemColors.ButtonHighlight
        Btn_Volver.Name = "Btn_Volver"
        Btn_Volver.UseVisualStyleBackColor = False
        ' 
        ' Btn_Salir
        ' 
        Btn_Salir.BackColor = Color.Black
        resources.ApplyResources(Btn_Salir, "Btn_Salir")
        Btn_Salir.ForeColor = SystemColors.ButtonHighlight
        Btn_Salir.Name = "Btn_Salir"
        Btn_Salir.UseVisualStyleBackColor = False
        ' 
        ' DGV_Productos
        ' 
        DGV_Productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(DGV_Productos, "DGV_Productos")
        DGV_Productos.Name = "DGV_Productos"
        DGV_Productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Black
        resources.ApplyResources(Label1, "Label1")
        Label1.Name = "Label1"
        ' 
        ' Productos
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Red
        Controls.Add(Label1)
        Controls.Add(DGV_Productos)
        Controls.Add(Btn_Volver)
        Controls.Add(Btn_Salir)
        Controls.Add(Txb_MaxPrecio)
        Controls.Add(Btn_Rango)
        Controls.Add(Txb_MinPrecio)
        Controls.Add(Lbl_Max)
        Controls.Add(Lbl_Min)
        Controls.Add(Lbl_Rango)
        Controls.Add(Btn_StockCompleto)
        Controls.Add(Lbl_Consulta)
        Controls.Add(Btn_EliminarProd)
        Controls.Add(Btn_ModificarProd)
        Controls.Add(Btn_AgregarProd)
        Controls.Add(Txb_Precio)
        Controls.Add(Txb_Producto)
        Controls.Add(Txb_Categoria)
        Controls.Add(Lbl_Producto)
        Controls.Add(Lbl_Precio)
        Controls.Add(Lbl_Correo)
        Name = "Productos"
        CType(DGV_Productos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Txb_Precio As TextBox
    Friend WithEvents Txb_Producto As TextBox
    Friend WithEvents Txb_Categoria As TextBox
    Friend WithEvents Lbl_Producto As Label
    Friend WithEvents Lbl_Precio As Label
    Friend WithEvents Lbl_Correo As Label
    Friend WithEvents Btn_AgregarProd As Button
    Friend WithEvents Btn_ModificarProd As Button
    Friend WithEvents Btn_EliminarProd As Button
    Friend WithEvents Lbl_Consulta As Label
    Friend WithEvents Btn_StockCompleto As Button
    Friend WithEvents Lbl_Rango As Label
    Friend WithEvents Lbl_Min As Label
    Friend WithEvents Lbl_Max As Label
    Friend WithEvents Txb_MinPrecio As TextBox
    Friend WithEvents Btn_Rango As Button
    Friend WithEvents Txb_MaxPrecio As TextBox
    Friend WithEvents Btn_Volver As Button
    Friend WithEvents Btn_Salir As Button
    Friend WithEvents DGV_Productos As DataGridView
    Friend WithEvents Label1 As Label
End Class
