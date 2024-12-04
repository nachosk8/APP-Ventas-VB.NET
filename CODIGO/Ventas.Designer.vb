<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Btn_Volver = New Button()
        Btn_Salir = New Button()
        Label1 = New Label()
        Gbx_Ventas = New GroupBox()
        Label3 = New Label()
        Btn_Filtros = New Button()
        Txb_Filtros = New TextBox()
        Cmb_Filtro = New ComboBox()
        Lbl_Filtro = New Label()
        DGV_Ventas = New DataGridView()
        Lbl_Tit_Lista = New Label()
        Lbl_TituloLista = New Label()
        Lbl_Fecha = New Label()
        Lbl_TotVenta = New Label()
        Lbl_IdCte = New Label()
        Txb_Fecha = New TextBox()
        Txb_IdCte = New TextBox()
        Txb_TotVenta = New TextBox()
        Btn_EliminarVenta = New Button()
        Btn_NuevaVenta = New Button()
        Gbx_ItemVenta = New GroupBox()
        Lbl_RecaudacionTotal = New Label()
        Lbl_ItemTotal = New Label()
        Lbl_Cantidad = New Label()
        Lbl_PrecUnitario = New Label()
        Lbl_IdProducto = New Label()
        Lbl_IdVenta = New Label()
        Txb_ItemIdproducto = New TextBox()
        Txb_ItemIDventa = New TextBox()
        Btn_ItemCancelarMod = New Button()
        Btn_ItemAceptarMod = New Button()
        DGV_ItemVenta = New DataGridView()
        Lbl_TitutlItem = New Label()
        Txb_ItemCant = New TextBox()
        Txb_ItemPrecUnit = New TextBox()
        Txb_ItemTotal = New TextBox()
        Btn_ItemModificar = New Button()
        Btn_ItemBorrar = New Button()
        Btn_ItemAgregar = New Button()
        Gbx_Ventas.SuspendLayout()
        CType(DGV_Ventas, ComponentModel.ISupportInitialize).BeginInit()
        Gbx_ItemVenta.SuspendLayout()
        CType(DGV_ItemVenta, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Btn_Volver
        ' 
        Btn_Volver.BackColor = Color.Black
        Btn_Volver.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Btn_Volver.ForeColor = SystemColors.ButtonHighlight
        Btn_Volver.ImeMode = ImeMode.NoControl
        Btn_Volver.Location = New Point(1132, 476)
        Btn_Volver.Name = "Btn_Volver"
        Btn_Volver.Size = New Size(112, 48)
        Btn_Volver.TabIndex = 28
        Btn_Volver.Text = "VOLVER"
        Btn_Volver.UseVisualStyleBackColor = False
        ' 
        ' Btn_Salir
        ' 
        Btn_Salir.BackColor = Color.Black
        Btn_Salir.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Btn_Salir.ForeColor = SystemColors.ButtonHighlight
        Btn_Salir.ImeMode = ImeMode.NoControl
        Btn_Salir.Location = New Point(1132, 378)
        Btn_Salir.Name = "Btn_Salir"
        Btn_Salir.Size = New Size(112, 48)
        Btn_Salir.TabIndex = 27
        Btn_Salir.Text = "SALIR"
        Btn_Salir.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Black
        Label1.Location = New Point(-2, 554)
        Label1.Name = "Label1"
        Label1.Size = New Size(1329, 14)
        Label1.TabIndex = 67
        ' 
        ' Gbx_Ventas
        ' 
        Gbx_Ventas.Controls.Add(Label3)
        Gbx_Ventas.Controls.Add(Btn_Filtros)
        Gbx_Ventas.Controls.Add(Txb_Filtros)
        Gbx_Ventas.Controls.Add(Cmb_Filtro)
        Gbx_Ventas.Controls.Add(Lbl_Filtro)
        Gbx_Ventas.Controls.Add(DGV_Ventas)
        Gbx_Ventas.Controls.Add(Lbl_Tit_Lista)
        Gbx_Ventas.Controls.Add(Lbl_TituloLista)
        Gbx_Ventas.Controls.Add(Lbl_Fecha)
        Gbx_Ventas.Controls.Add(Lbl_TotVenta)
        Gbx_Ventas.Controls.Add(Lbl_IdCte)
        Gbx_Ventas.Controls.Add(Txb_Fecha)
        Gbx_Ventas.Controls.Add(Txb_IdCte)
        Gbx_Ventas.Controls.Add(Txb_TotVenta)
        Gbx_Ventas.Controls.Add(Btn_EliminarVenta)
        Gbx_Ventas.Controls.Add(Btn_NuevaVenta)
        Gbx_Ventas.Location = New Point(12, 12)
        Gbx_Ventas.Name = "Gbx_Ventas"
        Gbx_Ventas.Size = New Size(1098, 524)
        Gbx_Ventas.TabIndex = 74
        Gbx_Ventas.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Red
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(792, 387)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 32)
        Label3.TabIndex = 79
        Label3.Visible = False
        ' 
        ' Btn_Filtros
        ' 
        Btn_Filtros.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Filtros.ForeColor = SystemColors.HotTrack
        Btn_Filtros.Location = New Point(472, 473)
        Btn_Filtros.Name = "Btn_Filtros"
        Btn_Filtros.Size = New Size(495, 45)
        Btn_Filtros.TabIndex = 78
        Btn_Filtros.Text = "CONSULTAR"
        Btn_Filtros.UseVisualStyleBackColor = True
        Btn_Filtros.Visible = False
        ' 
        ' Txb_Filtros
        ' 
        Txb_Filtros.Location = New Point(835, 426)
        Txb_Filtros.Name = "Txb_Filtros"
        Txb_Filtros.Size = New Size(132, 31)
        Txb_Filtros.TabIndex = 77
        Txb_Filtros.Visible = False
        ' 
        ' Cmb_Filtro
        ' 
        Cmb_Filtro.FormattingEnabled = True
        Cmb_Filtro.Items.AddRange(New Object() {"VER TODAS LAS VENTAS", "VER SOLO LOS TOTALES", "VER SOLO LOS ID DE LOS CLIENTES", "FILTRAR POR ID DE CLIENTE"})
        Cmb_Filtro.Location = New Point(472, 424)
        Cmb_Filtro.Name = "Cmb_Filtro"
        Cmb_Filtro.Size = New Size(312, 33)
        Cmb_Filtro.TabIndex = 76
        ' 
        ' Lbl_Filtro
        ' 
        Lbl_Filtro.AutoSize = True
        Lbl_Filtro.BackColor = Color.Red
        Lbl_Filtro.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_Filtro.ForeColor = SystemColors.ButtonHighlight
        Lbl_Filtro.Location = New Point(559, 383)
        Lbl_Filtro.Name = "Lbl_Filtro"
        Lbl_Filtro.Size = New Size(349, 32)
        Lbl_Filtro.TabIndex = 75
        Lbl_Filtro.Text = "VER VENTA SEGÚN FILTRADO"
        ' 
        ' DGV_Ventas
        ' 
        DGV_Ventas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_Ventas.Location = New Point(368, 60)
        DGV_Ventas.Name = "DGV_Ventas"
        DGV_Ventas.RowHeadersWidth = 62
        DGV_Ventas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV_Ventas.Size = New Size(710, 225)
        DGV_Ventas.TabIndex = 72
        ' 
        ' Lbl_Tit_Lista
        ' 
        Lbl_Tit_Lista.AutoSize = True
        Lbl_Tit_Lista.BackColor = Color.Red
        Lbl_Tit_Lista.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_Tit_Lista.ForeColor = SystemColors.ButtonHighlight
        Lbl_Tit_Lista.Location = New Point(440, 11)
        Lbl_Tit_Lista.Name = "Lbl_Tit_Lista"
        Lbl_Tit_Lista.Size = New Size(587, 32)
        Lbl_Tit_Lista.TabIndex = 71
        Lbl_Tit_Lista.Text = "SELECCIONE LA VENTA A ELIMINAR O MODIFICAR"
        ' 
        ' Lbl_TituloLista
        ' 
        Lbl_TituloLista.AutoSize = True
        Lbl_TituloLista.BackColor = Color.Red
        Lbl_TituloLista.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_TituloLista.ForeColor = SystemColors.ButtonHighlight
        Lbl_TituloLista.Location = New Point(688, 7)
        Lbl_TituloLista.Name = "Lbl_TituloLista"
        Lbl_TituloLista.Size = New Size(0, 32)
        Lbl_TituloLista.TabIndex = 70
        Lbl_TituloLista.Visible = False
        ' 
        ' Lbl_Fecha
        ' 
        Lbl_Fecha.AutoSize = True
        Lbl_Fecha.BackColor = Color.Red
        Lbl_Fecha.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_Fecha.ForeColor = SystemColors.ButtonHighlight
        Lbl_Fecha.Location = New Point(158, 102)
        Lbl_Fecha.Name = "Lbl_Fecha"
        Lbl_Fecha.Size = New Size(89, 32)
        Lbl_Fecha.TabIndex = 69
        Lbl_Fecha.Text = "FECHA"
        ' 
        ' Lbl_TotVenta
        ' 
        Lbl_TotVenta.AutoSize = True
        Lbl_TotVenta.BackColor = Color.Red
        Lbl_TotVenta.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_TotVenta.ForeColor = SystemColors.ButtonHighlight
        Lbl_TotVenta.Location = New Point(158, 205)
        Lbl_TotVenta.Name = "Lbl_TotVenta"
        Lbl_TotVenta.Size = New Size(85, 32)
        Lbl_TotVenta.TabIndex = 68
        Lbl_TotVenta.Text = "TOTAL"
        ' 
        ' Lbl_IdCte
        ' 
        Lbl_IdCte.AutoSize = True
        Lbl_IdCte.BackColor = Color.Red
        Lbl_IdCte.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_IdCte.ForeColor = SystemColors.ButtonHighlight
        Lbl_IdCte.Location = New Point(94, 10)
        Lbl_IdCte.Name = "Lbl_IdCte"
        Lbl_IdCte.Size = New Size(209, 32)
        Lbl_IdCte.TabIndex = 67
        Lbl_IdCte.Text = "CODIGO CLIENTE"
        ' 
        ' Txb_Fecha
        ' 
        Txb_Fecha.Location = New Point(64, 154)
        Txb_Fecha.Name = "Txb_Fecha"
        Txb_Fecha.Size = New Size(269, 31)
        Txb_Fecha.TabIndex = 66
        ' 
        ' Txb_IdCte
        ' 
        Txb_IdCte.Location = New Point(64, 55)
        Txb_IdCte.Name = "Txb_IdCte"
        Txb_IdCte.Size = New Size(269, 31)
        Txb_IdCte.TabIndex = 65
        ' 
        ' Txb_TotVenta
        ' 
        Txb_TotVenta.Location = New Point(64, 254)
        Txb_TotVenta.Name = "Txb_TotVenta"
        Txb_TotVenta.Size = New Size(269, 31)
        Txb_TotVenta.TabIndex = 64
        ' 
        ' Btn_EliminarVenta
        ' 
        Btn_EliminarVenta.BackColor = Color.Black
        Btn_EliminarVenta.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_EliminarVenta.ForeColor = Color.Red
        Btn_EliminarVenta.Location = New Point(588, 305)
        Btn_EliminarVenta.Name = "Btn_EliminarVenta"
        Btn_EliminarVenta.Size = New Size(273, 61)
        Btn_EliminarVenta.TabIndex = 62
        Btn_EliminarVenta.Text = "BORRAR VENTA"
        Btn_EliminarVenta.UseVisualStyleBackColor = False
        ' 
        ' Btn_NuevaVenta
        ' 
        Btn_NuevaVenta.BackColor = Color.Black
        Btn_NuevaVenta.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_NuevaVenta.ForeColor = Color.Gold
        Btn_NuevaVenta.Location = New Point(60, 318)
        Btn_NuevaVenta.Name = "Btn_NuevaVenta"
        Btn_NuevaVenta.Size = New Size(273, 61)
        Btn_NuevaVenta.TabIndex = 61
        Btn_NuevaVenta.Text = "AGREGAR VENTA"
        Btn_NuevaVenta.UseVisualStyleBackColor = False
        ' 
        ' Gbx_ItemVenta
        ' 
        Gbx_ItemVenta.Controls.Add(Lbl_RecaudacionTotal)
        Gbx_ItemVenta.Controls.Add(Lbl_ItemTotal)
        Gbx_ItemVenta.Controls.Add(Lbl_Cantidad)
        Gbx_ItemVenta.Controls.Add(Lbl_PrecUnitario)
        Gbx_ItemVenta.Controls.Add(Lbl_IdProducto)
        Gbx_ItemVenta.Controls.Add(Lbl_IdVenta)
        Gbx_ItemVenta.Controls.Add(Txb_ItemIdproducto)
        Gbx_ItemVenta.Controls.Add(Txb_ItemIDventa)
        Gbx_ItemVenta.Controls.Add(Btn_ItemCancelarMod)
        Gbx_ItemVenta.Controls.Add(Btn_ItemAceptarMod)
        Gbx_ItemVenta.Controls.Add(DGV_ItemVenta)
        Gbx_ItemVenta.Controls.Add(Lbl_TitutlItem)
        Gbx_ItemVenta.Controls.Add(Txb_ItemCant)
        Gbx_ItemVenta.Controls.Add(Txb_ItemPrecUnit)
        Gbx_ItemVenta.Controls.Add(Txb_ItemTotal)
        Gbx_ItemVenta.Controls.Add(Btn_ItemModificar)
        Gbx_ItemVenta.Controls.Add(Btn_ItemBorrar)
        Gbx_ItemVenta.Controls.Add(Btn_ItemAgregar)
        Gbx_ItemVenta.Location = New Point(14, 581)
        Gbx_ItemVenta.Name = "Gbx_ItemVenta"
        Gbx_ItemVenta.Size = New Size(1244, 379)
        Gbx_ItemVenta.TabIndex = 0
        Gbx_ItemVenta.TabStop = False
        ' 
        ' Lbl_RecaudacionTotal
        ' 
        Lbl_RecaudacionTotal.BackColor = Color.DarkSlateGray
        Lbl_RecaudacionTotal.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_RecaudacionTotal.ForeColor = SystemColors.ButtonFace
        Lbl_RecaudacionTotal.Location = New Point(468, 221)
        Lbl_RecaudacionTotal.Name = "Lbl_RecaudacionTotal"
        Lbl_RecaudacionTotal.Size = New Size(447, 38)
        Lbl_RecaudacionTotal.TabIndex = 91
        Lbl_RecaudacionTotal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Lbl_ItemTotal
        ' 
        Lbl_ItemTotal.AutoSize = True
        Lbl_ItemTotal.BackColor = Color.Red
        Lbl_ItemTotal.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_ItemTotal.ForeColor = SystemColors.ButtonHighlight
        Lbl_ItemTotal.Location = New Point(16, 246)
        Lbl_ItemTotal.Name = "Lbl_ItemTotal"
        Lbl_ItemTotal.Size = New Size(149, 32)
        Lbl_ItemTotal.TabIndex = 90
        Lbl_ItemTotal.Text = "Precio Total"
        ' 
        ' Lbl_Cantidad
        ' 
        Lbl_Cantidad.AutoSize = True
        Lbl_Cantidad.BackColor = Color.Red
        Lbl_Cantidad.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_Cantidad.ForeColor = SystemColors.ButtonHighlight
        Lbl_Cantidad.Location = New Point(16, 190)
        Lbl_Cantidad.Name = "Lbl_Cantidad"
        Lbl_Cantidad.Size = New Size(116, 32)
        Lbl_Cantidad.TabIndex = 89
        Lbl_Cantidad.Text = "Cantidad"
        ' 
        ' Lbl_PrecUnitario
        ' 
        Lbl_PrecUnitario.AutoSize = True
        Lbl_PrecUnitario.BackColor = Color.Red
        Lbl_PrecUnitario.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_PrecUnitario.ForeColor = SystemColors.ButtonHighlight
        Lbl_PrecUnitario.Location = New Point(16, 131)
        Lbl_PrecUnitario.Name = "Lbl_PrecUnitario"
        Lbl_PrecUnitario.Size = New Size(186, 32)
        Lbl_PrecUnitario.TabIndex = 88
        Lbl_PrecUnitario.Text = "Precio Unitario"
        ' 
        ' Lbl_IdProducto
        ' 
        Lbl_IdProducto.AutoSize = True
        Lbl_IdProducto.BackColor = Color.Red
        Lbl_IdProducto.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_IdProducto.ForeColor = SystemColors.ButtonHighlight
        Lbl_IdProducto.Location = New Point(16, 71)
        Lbl_IdProducto.Name = "Lbl_IdProducto"
        Lbl_IdProducto.Size = New Size(146, 32)
        Lbl_IdProducto.TabIndex = 87
        Lbl_IdProducto.Text = "IDProducto"
        ' 
        ' Lbl_IdVenta
        ' 
        Lbl_IdVenta.AutoSize = True
        Lbl_IdVenta.BackColor = Color.Red
        Lbl_IdVenta.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_IdVenta.ForeColor = SystemColors.ButtonHighlight
        Lbl_IdVenta.Location = New Point(16, 12)
        Lbl_IdVenta.Name = "Lbl_IdVenta"
        Lbl_IdVenta.Size = New Size(104, 32)
        Lbl_IdVenta.TabIndex = 86
        Lbl_IdVenta.Text = "IDVenta"
        ' 
        ' Txb_ItemIdproducto
        ' 
        Txb_ItemIdproducto.Location = New Point(208, 74)
        Txb_ItemIdproducto.Name = "Txb_ItemIdproducto"
        Txb_ItemIdproducto.Size = New Size(242, 31)
        Txb_ItemIdproducto.TabIndex = 85
        ' 
        ' Txb_ItemIDventa
        ' 
        Txb_ItemIDventa.Location = New Point(208, 15)
        Txb_ItemIDventa.Name = "Txb_ItemIDventa"
        Txb_ItemIDventa.Size = New Size(242, 31)
        Txb_ItemIDventa.TabIndex = 84
        ' 
        ' Btn_ItemCancelarMod
        ' 
        Btn_ItemCancelarMod.BackColor = Color.Black
        Btn_ItemCancelarMod.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_ItemCancelarMod.ForeColor = Color.Fuchsia
        Btn_ItemCancelarMod.Location = New Point(1053, 330)
        Btn_ItemCancelarMod.Name = "Btn_ItemCancelarMod"
        Btn_ItemCancelarMod.Size = New Size(164, 42)
        Btn_ItemCancelarMod.TabIndex = 83
        Btn_ItemCancelarMod.Text = "CANCELAR"
        Btn_ItemCancelarMod.UseVisualStyleBackColor = False
        Btn_ItemCancelarMod.Visible = False
        ' 
        ' Btn_ItemAceptarMod
        ' 
        Btn_ItemAceptarMod.BackColor = Color.Black
        Btn_ItemAceptarMod.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_ItemAceptarMod.ForeColor = Color.Fuchsia
        Btn_ItemAceptarMod.Location = New Point(1053, 267)
        Btn_ItemAceptarMod.Name = "Btn_ItemAceptarMod"
        Btn_ItemAceptarMod.Size = New Size(164, 42)
        Btn_ItemAceptarMod.TabIndex = 82
        Btn_ItemAceptarMod.Text = "ACEPTAR"
        Btn_ItemAceptarMod.UseVisualStyleBackColor = False
        Btn_ItemAceptarMod.Visible = False
        ' 
        ' DGV_ItemVenta
        ' 
        DGV_ItemVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_ItemVenta.Location = New Point(469, 34)
        DGV_ItemVenta.Name = "DGV_ItemVenta"
        DGV_ItemVenta.RowHeadersWidth = 62
        DGV_ItemVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV_ItemVenta.Size = New Size(759, 186)
        DGV_ItemVenta.TabIndex = 81
        ' 
        ' Lbl_TitutlItem
        ' 
        Lbl_TitutlItem.AutoSize = True
        Lbl_TitutlItem.BackColor = Color.Red
        Lbl_TitutlItem.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_TitutlItem.ForeColor = SystemColors.ButtonHighlight
        Lbl_TitutlItem.Location = New Point(540, -4)
        Lbl_TitutlItem.Name = "Lbl_TitutlItem"
        Lbl_TitutlItem.Size = New Size(625, 32)
        Lbl_TitutlItem.TabIndex = 80
        Lbl_TitutlItem.Text = "SELECCIONE  ITEM-VENTA A ELIMINAR O MODIFICAR"
        ' 
        ' Txb_ItemCant
        ' 
        Txb_ItemCant.Location = New Point(208, 190)
        Txb_ItemCant.Name = "Txb_ItemCant"
        Txb_ItemCant.Size = New Size(242, 31)
        Txb_ItemCant.TabIndex = 79
        ' 
        ' Txb_ItemPrecUnit
        ' 
        Txb_ItemPrecUnit.BackColor = SystemColors.ScrollBar
        Txb_ItemPrecUnit.Enabled = False
        Txb_ItemPrecUnit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Txb_ItemPrecUnit.Location = New Point(208, 131)
        Txb_ItemPrecUnit.Name = "Txb_ItemPrecUnit"
        Txb_ItemPrecUnit.Size = New Size(242, 31)
        Txb_ItemPrecUnit.TabIndex = 78
        ' 
        ' Txb_ItemTotal
        ' 
        Txb_ItemTotal.BackColor = SystemColors.ScrollBar
        Txb_ItemTotal.Enabled = False
        Txb_ItemTotal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Txb_ItemTotal.Location = New Point(208, 247)
        Txb_ItemTotal.Name = "Txb_ItemTotal"
        Txb_ItemTotal.Size = New Size(242, 31)
        Txb_ItemTotal.TabIndex = 77
        ' 
        ' Btn_ItemModificar
        ' 
        Btn_ItemModificar.BackColor = Color.Black
        Btn_ItemModificar.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_ItemModificar.ForeColor = Color.Fuchsia
        Btn_ItemModificar.Location = New Point(750, 289)
        Btn_ItemModificar.Name = "Btn_ItemModificar"
        Btn_ItemModificar.Size = New Size(273, 83)
        Btn_ItemModificar.TabIndex = 76
        Btn_ItemModificar.Text = "MODIFICAR ITEM  VENTA"
        Btn_ItemModificar.UseVisualStyleBackColor = False
        ' 
        ' Btn_ItemBorrar
        ' 
        Btn_ItemBorrar.BackColor = Color.Black
        Btn_ItemBorrar.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_ItemBorrar.ForeColor = Color.Red
        Btn_ItemBorrar.Location = New Point(468, 289)
        Btn_ItemBorrar.Name = "Btn_ItemBorrar"
        Btn_ItemBorrar.Size = New Size(273, 83)
        Btn_ItemBorrar.TabIndex = 75
        Btn_ItemBorrar.Text = "BORRAR ITEM VENTA"
        Btn_ItemBorrar.UseVisualStyleBackColor = False
        ' 
        ' Btn_ItemAgregar
        ' 
        Btn_ItemAgregar.BackColor = Color.Black
        Btn_ItemAgregar.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_ItemAgregar.ForeColor = Color.GreenYellow
        Btn_ItemAgregar.Location = New Point(208, 289)
        Btn_ItemAgregar.Name = "Btn_ItemAgregar"
        Btn_ItemAgregar.Size = New Size(242, 83)
        Btn_ItemAgregar.TabIndex = 74
        Btn_ItemAgregar.Text = "AGREGAR ITEM VENTA"
        Btn_ItemAgregar.UseVisualStyleBackColor = False
        ' 
        ' Ventas
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Red
        ClientSize = New Size(1271, 958)
        Controls.Add(Gbx_ItemVenta)
        Controls.Add(Gbx_Ventas)
        Controls.Add(Label1)
        Controls.Add(Btn_Volver)
        Controls.Add(Btn_Salir)
        Name = "Ventas"
        Text = "Ventas"
        Gbx_Ventas.ResumeLayout(False)
        Gbx_Ventas.PerformLayout()
        CType(DGV_Ventas, ComponentModel.ISupportInitialize).EndInit()
        Gbx_ItemVenta.ResumeLayout(False)
        Gbx_ItemVenta.PerformLayout()
        CType(DGV_ItemVenta, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Btn_Volver As Button
    Friend WithEvents Btn_Salir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Gbx_Ventas As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_Filtros As Button
    Friend WithEvents Txb_Filtros As TextBox
    Friend WithEvents Cmb_Filtro As ComboBox
    Friend WithEvents Lbl_Filtro As Label
    Friend WithEvents DGV_Ventas As DataGridView
    Friend WithEvents Lbl_Tit_Lista As Label
    Friend WithEvents Lbl_TituloLista As Label
    Friend WithEvents Lbl_Fecha As Label
    Friend WithEvents Lbl_TotVenta As Label
    Friend WithEvents Lbl_IdCte As Label
    Friend WithEvents Txb_Fecha As TextBox
    Friend WithEvents Txb_IdCte As TextBox
    Friend WithEvents Txb_TotVenta As TextBox
    Friend WithEvents Btn_EliminarVenta As Button
    Friend WithEvents Btn_NuevaVenta As Button
    Friend WithEvents Gbx_ItemVenta As GroupBox
    Friend WithEvents Lbl_RecaudacionTotal As Label
    Friend WithEvents Lbl_ItemTotal As Label
    Friend WithEvents Lbl_Cantidad As Label
    Friend WithEvents Lbl_PrecUnitario As Label
    Friend WithEvents Lbl_IdProducto As Label
    Friend WithEvents Lbl_IdVenta As Label
    Friend WithEvents Txb_ItemIdproducto As TextBox
    Friend WithEvents Txb_ItemIDventa As TextBox
    Friend WithEvents Btn_ItemCancelarMod As Button
    Friend WithEvents Btn_ItemAceptarMod As Button
    Friend WithEvents DGV_ItemVenta As DataGridView
    Friend WithEvents Lbl_TitutlItem As Label
    Friend WithEvents Txb_ItemCant As TextBox
    Friend WithEvents Txb_ItemPrecUnit As TextBox
    Friend WithEvents Txb_ItemTotal As TextBox
    Friend WithEvents Btn_ItemModificar As Button
    Friend WithEvents Btn_ItemBorrar As Button
    Friend WithEvents Btn_ItemAgregar As Button
End Class
