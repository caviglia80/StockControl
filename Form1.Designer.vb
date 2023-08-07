<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.LV_1 = New System.Windows.Forms.ListView()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.BTN_Salir = New System.Windows.Forms.Button()
		Me.TXT_PorcVenta = New System.Windows.Forms.TextBox()
		Me.TXT_Pack = New System.Windows.Forms.TextBox()
		Me.BTN_Cargar = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TXT_PrecioCompra = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.GB_Datos = New System.Windows.Forms.GroupBox()
		Me.TXT_GA = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.TXT_Envio = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.BTN_Color = New System.Windows.Forms.Button()
		Me.BTN_BT = New System.Windows.Forms.Button()
		Me.BTN_Borrar = New System.Windows.Forms.Button()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.TXT_Producto = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.TXT_Proveedor = New System.Windows.Forms.TextBox()
		Me.CD_1 = New System.Windows.Forms.ColorDialog()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.TT_1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.PB_2 = New System.Windows.Forms.PictureBox()
		Me.PB_1 = New System.Windows.Forms.PictureBox()
		Me.OpenFD_1 = New System.Windows.Forms.OpenFileDialog()
		Me.GB_2 = New System.Windows.Forms.GroupBox()
		Me.TCT_UnidadesCompradas = New System.Windows.Forms.TextBox()
		Me.TCT_Tventas = New System.Windows.Forms.TextBox()
		Me.TCT_Tgastos = New System.Windows.Forms.TextBox()
		Me.TCT_Tganancias = New System.Windows.Forms.TextBox()
		Me.TXT_Clave = New System.Windows.Forms.TextBox()
		Me.GB_Datos.SuspendLayout()
		CType(Me.PB_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PB_1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GB_2.SuspendLayout()
		Me.SuspendLayout()
		'
		'LV_1
		'
		Me.LV_1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LV_1.BackColor = System.Drawing.Color.Black
		Me.LV_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LV_1.Enabled = False
		Me.LV_1.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.LV_1.ForeColor = System.Drawing.Color.White
		Me.LV_1.FullRowSelect = True
		Me.LV_1.HideSelection = False
		Me.LV_1.Location = New System.Drawing.Point(12, 12)
		Me.LV_1.MultiSelect = False
		Me.LV_1.Name = "LV_1"
		Me.LV_1.Size = New System.Drawing.Size(701, 658)
		Me.LV_1.TabIndex = 0
		Me.LV_1.UseCompatibleStateImageBehavior = False
		Me.LV_1.View = System.Windows.Forms.View.Details
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(110, 201)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(61, 13)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "% de Venta"
		Me.TT_1.SetToolTip(Me.Label1, "Es el % que se cobra al cliente a partir de los costos de compra.")
		'
		'BTN_Salir
		'
		Me.BTN_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.BTN_Salir.BackColor = System.Drawing.Color.AliceBlue
		Me.BTN_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BTN_Salir.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.BTN_Salir.Location = New System.Drawing.Point(1071, 647)
		Me.BTN_Salir.Name = "BTN_Salir"
		Me.BTN_Salir.Size = New System.Drawing.Size(75, 23)
		Me.BTN_Salir.TabIndex = 12
		Me.BTN_Salir.Text = "Salir"
		Me.BTN_Salir.UseVisualStyleBackColor = False
		'
		'TXT_PorcVenta
		'
		Me.TXT_PorcVenta.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.TXT_PorcVenta.Location = New System.Drawing.Point(6, 196)
		Me.TXT_PorcVenta.Name = "TXT_PorcVenta"
		Me.TXT_PorcVenta.Size = New System.Drawing.Size(98, 23)
		Me.TXT_PorcVenta.TabIndex = 5
		Me.TXT_PorcVenta.Text = "250"
		Me.TXT_PorcVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TXT_Pack
		'
		Me.TXT_Pack.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.TXT_Pack.Location = New System.Drawing.Point(6, 167)
		Me.TXT_Pack.Name = "TXT_Pack"
		Me.TXT_Pack.Size = New System.Drawing.Size(98, 23)
		Me.TXT_Pack.TabIndex = 4
		Me.TXT_Pack.Text = "12"
		Me.TXT_Pack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'BTN_Cargar
		'
		Me.BTN_Cargar.BackColor = System.Drawing.Color.AliceBlue
		Me.BTN_Cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BTN_Cargar.Location = New System.Drawing.Point(6, 225)
		Me.BTN_Cargar.Name = "BTN_Cargar"
		Me.BTN_Cargar.Size = New System.Drawing.Size(247, 23)
		Me.BTN_Cargar.TabIndex = 7
		Me.BTN_Cargar.Text = "Cargar"
		Me.TT_1.SetToolTip(Me.BTN_Cargar, "Cargar nuevo registro." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Complete todos los campos obligatorios primero.")
		Me.BTN_Cargar.UseVisualStyleBackColor = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(110, 172)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(120, 13)
		Me.Label2.TabIndex = 8
		Me.Label2.Text = "Cantidad Pack Compra"
		Me.TT_1.SetToolTip(Me.Label2, "Cantidad de unidades del Pack.")
		'
		'TXT_PrecioCompra
		'
		Me.TXT_PrecioCompra.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.TXT_PrecioCompra.Location = New System.Drawing.Point(6, 80)
		Me.TXT_PrecioCompra.Name = "TXT_PrecioCompra"
		Me.TXT_PrecioCompra.Size = New System.Drawing.Size(98, 23)
		Me.TXT_PrecioCompra.TabIndex = 2
		Me.TXT_PrecioCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(110, 85)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(81, 13)
		Me.Label5.TabIndex = 11
		Me.Label5.Text = "Precio Compra"
		Me.TT_1.SetToolTip(Me.Label5, "Precio total de compra por el Pack, el valor total sin contar el envio o gastos a" &
		"dicionales.")
		'
		'GB_Datos
		'
		Me.GB_Datos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GB_Datos.BackColor = System.Drawing.Color.AliceBlue
		Me.GB_Datos.Controls.Add(Me.TXT_GA)
		Me.GB_Datos.Controls.Add(Me.Label7)
		Me.GB_Datos.Controls.Add(Me.TXT_Envio)
		Me.GB_Datos.Controls.Add(Me.Label3)
		Me.GB_Datos.Controls.Add(Me.BTN_Color)
		Me.GB_Datos.Controls.Add(Me.BTN_BT)
		Me.GB_Datos.Controls.Add(Me.BTN_Borrar)
		Me.GB_Datos.Controls.Add(Me.Label6)
		Me.GB_Datos.Controls.Add(Me.TXT_Producto)
		Me.GB_Datos.Controls.Add(Me.Label4)
		Me.GB_Datos.Controls.Add(Me.TXT_PrecioCompra)
		Me.GB_Datos.Controls.Add(Me.TXT_Proveedor)
		Me.GB_Datos.Controls.Add(Me.Label1)
		Me.GB_Datos.Controls.Add(Me.BTN_Cargar)
		Me.GB_Datos.Controls.Add(Me.Label2)
		Me.GB_Datos.Controls.Add(Me.Label5)
		Me.GB_Datos.Controls.Add(Me.TXT_PorcVenta)
		Me.GB_Datos.Controls.Add(Me.TXT_Pack)
		Me.GB_Datos.Enabled = False
		Me.GB_Datos.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.GB_Datos.Location = New System.Drawing.Point(719, 12)
		Me.GB_Datos.Name = "GB_Datos"
		Me.GB_Datos.Size = New System.Drawing.Size(428, 254)
		Me.GB_Datos.TabIndex = 13
		Me.GB_Datos.TabStop = False
		'
		'TXT_GA
		'
		Me.TXT_GA.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.TXT_GA.Location = New System.Drawing.Point(6, 138)
		Me.TXT_GA.Name = "TXT_GA"
		Me.TXT_GA.Size = New System.Drawing.Size(98, 23)
		Me.TXT_GA.TabIndex = 10005
		Me.TXT_GA.Text = "15"
		Me.TXT_GA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(110, 143)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(105, 13)
		Me.Label7.TabIndex = 10006
		Me.Label7.Text = "Gastos Adic. Unidad"
		Me.TT_1.SetToolTip(Me.Label7, "Ejemplos de Gastos Adicionales:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-Bolsas." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-Stickers." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-Gastos de Envio de los An" &
		"teriores.")
		'
		'TXT_Envio
		'
		Me.TXT_Envio.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.TXT_Envio.Location = New System.Drawing.Point(6, 109)
		Me.TXT_Envio.Name = "TXT_Envio"
		Me.TXT_Envio.Size = New System.Drawing.Size(98, 23)
		Me.TXT_Envio.TabIndex = 3
		Me.TXT_Envio.Text = "400"
		Me.TXT_Envio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(110, 114)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(70, 13)
		Me.Label3.TabIndex = 10004
		Me.Label3.Text = "Precio Envío"
		Me.TT_1.SetToolTip(Me.Label3, "Valor del costo de envio por el Pack a registrar.")
		'
		'BTN_Color
		'
		Me.BTN_Color.BackColor = System.Drawing.Color.AliceBlue
		Me.BTN_Color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.BTN_Color.FlatAppearance.BorderSize = 0
		Me.BTN_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BTN_Color.Image = CType(resources.GetObject("BTN_Color.Image"), System.Drawing.Image)
		Me.BTN_Color.Location = New System.Drawing.Point(250, 80)
		Me.BTN_Color.Name = "BTN_Color"
		Me.BTN_Color.Size = New System.Drawing.Size(173, 139)
		Me.BTN_Color.TabIndex = 6
		Me.TT_1.SetToolTip(Me.BTN_Color, "Cambiar el color del Pincel.")
		Me.BTN_Color.UseVisualStyleBackColor = False
		'
		'BTN_BT
		'
		Me.BTN_BT.BackColor = System.Drawing.Color.AliceBlue
		Me.BTN_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BTN_BT.Location = New System.Drawing.Point(337, 225)
		Me.BTN_BT.Name = "BTN_BT"
		Me.BTN_BT.Size = New System.Drawing.Size(86, 23)
		Me.BTN_BT.TabIndex = 9
		Me.BTN_BT.Text = "Borrar Todo"
		Me.TT_1.SetToolTip(Me.BTN_BT, "Borrar todos los registros." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Advertencia, no se podrán recuperar.")
		Me.BTN_BT.UseVisualStyleBackColor = False
		'
		'BTN_Borrar
		'
		Me.BTN_Borrar.BackColor = System.Drawing.Color.AliceBlue
		Me.BTN_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BTN_Borrar.Location = New System.Drawing.Point(250, 225)
		Me.BTN_Borrar.Name = "BTN_Borrar"
		Me.BTN_Borrar.Size = New System.Drawing.Size(88, 23)
		Me.BTN_Borrar.TabIndex = 8
		Me.BTN_Borrar.Text = "Borrar"
		Me.TT_1.SetToolTip(Me.BTN_Borrar, "Borrar solo la fila seleccionada." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Advertencia, no se podrá recuperar.")
		Me.BTN_Borrar.UseVisualStyleBackColor = False
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(362, 30)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(52, 13)
		Me.Label6.TabIndex = 16
		Me.Label6.Text = "Producto"
		Me.TT_1.SetToolTip(Me.Label6, "Datos del Producto.")
		'
		'TXT_Producto
		'
		Me.TXT_Producto.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.TXT_Producto.Location = New System.Drawing.Point(6, 22)
		Me.TXT_Producto.Name = "TXT_Producto"
		Me.TXT_Producto.Size = New System.Drawing.Size(355, 23)
		Me.TXT_Producto.TabIndex = 0
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(362, 59)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(60, 13)
		Me.Label4.TabIndex = 14
		Me.Label4.Text = "Proveedor"
		Me.TT_1.SetToolTip(Me.Label4, "Datos del Proveedor.")
		'
		'TXT_Proveedor
		'
		Me.TXT_Proveedor.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.TXT_Proveedor.Location = New System.Drawing.Point(6, 51)
		Me.TXT_Proveedor.Name = "TXT_Proveedor"
		Me.TXT_Proveedor.Size = New System.Drawing.Size(355, 23)
		Me.TXT_Proveedor.TabIndex = 1
		'
		'CD_1
		'
		Me.CD_1.AnyColor = True
		Me.CD_1.Color = System.Drawing.Color.White
		Me.CD_1.FullOpen = True
		'
		'Button1
		'
		Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Button1.BackColor = System.Drawing.Color.AliceBlue
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Button1.Location = New System.Drawing.Point(1046, 647)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(19, 23)
		Me.Button1.TabIndex = 10008
		Me.Button1.Text = "?"
		Me.TT_1.SetToolTip(Me.Button1, "IG: @Fraancaviglia")
		Me.Button1.UseVisualStyleBackColor = False
		'
		'TT_1
		'
		Me.TT_1.AutomaticDelay = 100
		Me.TT_1.AutoPopDelay = 10000
		Me.TT_1.BackColor = System.Drawing.Color.Silver
		Me.TT_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.TT_1.InitialDelay = 1500
		Me.TT_1.IsBalloon = True
		Me.TT_1.ReshowDelay = 100
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(143, 30)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(61, 15)
		Me.Label8.TabIndex = 10008
		Me.Label8.Text = "Ganancias"
		Me.TT_1.SetToolTip(Me.Label8, "Precio total de compra por el Pack, el valor total sin contar el envio o gastos a" &
		"dicionales.")
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(143, 59)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(89, 15)
		Me.Label9.TabIndex = 10010
		Me.Label9.Text = "Gastos s/Envios"
		Me.TT_1.SetToolTip(Me.Label9, "Precio total de compra por el Pack, el valor total sin contar el envio o gastos a" &
		"dicionales.")
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(367, 59)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(56, 15)
		Me.Label10.TabIndex = 10014
		Me.Label10.Text = "Unidades"
		Me.TT_1.SetToolTip(Me.Label10, "Precio total de compra por el Pack, el valor total sin contar el envio o gastos a" &
		"dicionales.")
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(367, 30)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(41, 15)
		Me.Label11.TabIndex = 10012
		Me.Label11.Text = "Ventas"
		Me.TT_1.SetToolTip(Me.Label11, "Precio total de compra por el Pack, el valor total sin contar el envio o gastos a" &
		"dicionales.")
		'
		'PB_2
		'
		Me.PB_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PB_2.BackColor = System.Drawing.Color.Transparent
		Me.PB_2.Image = CType(resources.GetObject("PB_2.Image"), System.Drawing.Image)
		Me.PB_2.Location = New System.Drawing.Point(719, 638)
		Me.PB_2.Name = "PB_2"
		Me.PB_2.Size = New System.Drawing.Size(45, 32)
		Me.PB_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PB_2.TabIndex = 10011
		Me.PB_2.TabStop = False
		Me.TT_1.SetToolTip(Me.PB_2, "Para pintar, seleccione un item de la lista primero.")
		'
		'PB_1
		'
		Me.PB_1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PB_1.Image = CType(resources.GetObject("PB_1.Image"), System.Drawing.Image)
		Me.PB_1.InitialImage = CType(resources.GetObject("PB_1.InitialImage"), System.Drawing.Image)
		Me.PB_1.Location = New System.Drawing.Point(719, 360)
		Me.PB_1.Name = "PB_1"
		Me.PB_1.Size = New System.Drawing.Size(428, 273)
		Me.PB_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PB_1.TabIndex = 10009
		Me.PB_1.TabStop = False
		'
		'GB_2
		'
		Me.GB_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GB_2.Controls.Add(Me.TCT_UnidadesCompradas)
		Me.GB_2.Controls.Add(Me.Label10)
		Me.GB_2.Controls.Add(Me.TCT_Tventas)
		Me.GB_2.Controls.Add(Me.Label11)
		Me.GB_2.Controls.Add(Me.TCT_Tgastos)
		Me.GB_2.Controls.Add(Me.Label9)
		Me.GB_2.Controls.Add(Me.TCT_Tganancias)
		Me.GB_2.Controls.Add(Me.Label8)
		Me.GB_2.Location = New System.Drawing.Point(719, 272)
		Me.GB_2.Name = "GB_2"
		Me.GB_2.Size = New System.Drawing.Size(428, 82)
		Me.GB_2.TabIndex = 10010
		Me.GB_2.TabStop = False
		Me.GB_2.Text = "Resumen:"
		'
		'TCT_UnidadesCompradas
		'
		Me.TCT_UnidadesCompradas.Enabled = False
		Me.TCT_UnidadesCompradas.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.TCT_UnidadesCompradas.Location = New System.Drawing.Point(238, 51)
		Me.TCT_UnidadesCompradas.Name = "TCT_UnidadesCompradas"
		Me.TCT_UnidadesCompradas.Size = New System.Drawing.Size(123, 23)
		Me.TCT_UnidadesCompradas.TabIndex = 10013
		Me.TCT_UnidadesCompradas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TCT_Tventas
		'
		Me.TCT_Tventas.Enabled = False
		Me.TCT_Tventas.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.TCT_Tventas.Location = New System.Drawing.Point(238, 22)
		Me.TCT_Tventas.Name = "TCT_Tventas"
		Me.TCT_Tventas.Size = New System.Drawing.Size(123, 23)
		Me.TCT_Tventas.TabIndex = 10011
		Me.TCT_Tventas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TCT_Tgastos
		'
		Me.TCT_Tgastos.Enabled = False
		Me.TCT_Tgastos.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.TCT_Tgastos.Location = New System.Drawing.Point(6, 51)
		Me.TCT_Tgastos.Name = "TCT_Tgastos"
		Me.TCT_Tgastos.Size = New System.Drawing.Size(131, 23)
		Me.TCT_Tgastos.TabIndex = 10009
		Me.TCT_Tgastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TCT_Tganancias
		'
		Me.TCT_Tganancias.Enabled = False
		Me.TCT_Tganancias.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.TCT_Tganancias.Location = New System.Drawing.Point(6, 22)
		Me.TCT_Tganancias.Name = "TCT_Tganancias"
		Me.TCT_Tganancias.Size = New System.Drawing.Size(131, 23)
		Me.TCT_Tganancias.TabIndex = 10007
		Me.TCT_Tganancias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TXT_Clave
		'
		Me.TXT_Clave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TXT_Clave.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.TXT_Clave.ForeColor = System.Drawing.Color.Red
		Me.TXT_Clave.Location = New System.Drawing.Point(770, 647)
		Me.TXT_Clave.Name = "TXT_Clave"
		Me.TXT_Clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TXT_Clave.Size = New System.Drawing.Size(270, 23)
		Me.TXT_Clave.TabIndex = 10007
		Me.TXT_Clave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.AliceBlue
		Me.ClientSize = New System.Drawing.Size(1153, 682)
		Me.Controls.Add(Me.TXT_Clave)
		Me.Controls.Add(Me.PB_2)
		Me.Controls.Add(Me.GB_2)
		Me.Controls.Add(Me.PB_1)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.GB_Datos)
		Me.Controls.Add(Me.BTN_Salir)
		Me.Controls.Add(Me.LV_1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Stock"
		Me.GB_Datos.ResumeLayout(False)
		Me.GB_Datos.PerformLayout()
		CType(Me.PB_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PB_1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GB_2.ResumeLayout(False)
		Me.GB_2.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents LV_1 As ListView
	Friend WithEvents Label1 As Label
	Friend WithEvents BTN_Salir As Button
	Friend WithEvents TXT_PorcVenta As TextBox
	Friend WithEvents TXT_Pack As TextBox
	Friend WithEvents BTN_Cargar As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents TXT_PrecioCompra As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents GB_Datos As GroupBox
	Friend WithEvents Label4 As Label
	Friend WithEvents TXT_Proveedor As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents TXT_Producto As TextBox
	Friend WithEvents BTN_Borrar As Button
	Friend WithEvents BTN_BT As Button
	Friend WithEvents BTN_Color As Button
	Friend WithEvents CD_1 As ColorDialog
	Friend WithEvents TXT_Envio As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents TXT_GA As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents TT_1 As ToolTip
	Friend WithEvents PB_1 As PictureBox
	Friend WithEvents OpenFD_1 As OpenFileDialog
	Friend WithEvents GB_2 As GroupBox
	Friend WithEvents TCT_UnidadesCompradas As TextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents TCT_Tventas As TextBox
	Friend WithEvents Label11 As Label
	Friend WithEvents TCT_Tgastos As TextBox
	Friend WithEvents Label9 As Label
	Friend WithEvents TCT_Tganancias As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents PB_2 As PictureBox
	Friend WithEvents TXT_Clave As TextBox
End Class
