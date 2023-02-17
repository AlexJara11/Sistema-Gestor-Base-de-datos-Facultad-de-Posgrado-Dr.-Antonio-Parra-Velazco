<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class administracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(administracion))
        Me.txt_orden = New System.Windows.Forms.TextBox()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.txt_codinv = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.DgvPersonas = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BUSQUEDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CODINVToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DESCRIPCIONToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AREAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MARCAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MODELOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SERIEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_busqueda = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_marca = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_modelo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_serie = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_area = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_valor = New System.Windows.Forms.TextBox()
        Me.txt_estado = New System.Windows.Forms.TextBox()
        Me.txt_color = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_observacion = New System.Windows.Forms.TextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DgvPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_orden
        '
        Me.txt_orden.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_orden.Location = New System.Drawing.Point(393, 96)
        Me.txt_orden.Multiline = True
        Me.txt_orden.Name = "txt_orden"
        Me.txt_orden.Size = New System.Drawing.Size(96, 46)
        Me.txt_orden.TabIndex = 0
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(757, 175)
        Me.txt_cantidad.Multiline = True
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(206, 46)
        Me.txt_cantidad.TabIndex = 1
        '
        'txt_codinv
        '
        Me.txt_codinv.Location = New System.Drawing.Point(394, 175)
        Me.txt_codinv.Multiline = True
        Me.txt_codinv.Name = "txt_codinv"
        Me.txt_codinv.Size = New System.Drawing.Size(206, 46)
        Me.txt_codinv.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(115, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 64)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "INGRESAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(1136, 175)
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(206, 46)
        Me.txt_descripcion.TabIndex = 4
        '
        'DgvPersonas
        '
        Me.DgvPersonas.AllowUserToAddRows = False
        Me.DgvPersonas.AllowUserToDeleteRows = False
        Me.DgvPersonas.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPersonas.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.DgvPersonas.Location = New System.Drawing.Point(629, 533)
        Me.DgvPersonas.Name = "DgvPersonas"
        Me.DgvPersonas.ReadOnly = True
        Me.DgvPersonas.Size = New System.Drawing.Size(712, 256)
        Me.DgvPersonas.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(115, 346)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 64)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "MODIFICAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ORDEN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(658, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "CANTIDAD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(296, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 36)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "CÓDIGO DE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "INVENTARIO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1019, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "DESCRIPCIÓN"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button3.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(474, 736)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(126, 53)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "LIMPIAR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button4.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(115, 466)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(131, 64)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "ELIMINAR"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BUSQUEDAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(277, 649)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(219, 26)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BUSQUEDAToolStripMenuItem
        '
        Me.BUSQUEDAToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.BUSQUEDAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CODINVToolStripMenuItem1, Me.DESCRIPCIONToolStripMenuItem1, Me.AREAToolStripMenuItem})
        Me.BUSQUEDAToolStripMenuItem.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUSQUEDAToolStripMenuItem.Name = "BUSQUEDAToolStripMenuItem"
        Me.BUSQUEDAToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.BUSQUEDAToolStripMenuItem.Text = "ELIJA SU OPCIÓN DE BÚSQUEDA"
        '
        'CODINVToolStripMenuItem1
        '
        Me.CODINVToolStripMenuItem1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CODINVToolStripMenuItem1.Name = "CODINVToolStripMenuItem1"
        Me.CODINVToolStripMenuItem1.Size = New System.Drawing.Size(204, 22)
        Me.CODINVToolStripMenuItem1.Text = "CODIGO DE INVENTARIO"
        '
        'DESCRIPCIONToolStripMenuItem1
        '
        Me.DESCRIPCIONToolStripMenuItem1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DESCRIPCIONToolStripMenuItem1.Name = "DESCRIPCIONToolStripMenuItem1"
        Me.DESCRIPCIONToolStripMenuItem1.Size = New System.Drawing.Size(204, 22)
        Me.DESCRIPCIONToolStripMenuItem1.Text = "DESCRIPCION"
        '
        'AREAToolStripMenuItem
        '
        Me.AREAToolStripMenuItem.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AREAToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AREAToolStripMenuItem.Name = "AREAToolStripMenuItem"
        Me.AREAToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.AREAToolStripMenuItem.Text = "AREA"
        '
        'MARCAToolStripMenuItem
        '
        Me.MARCAToolStripMenuItem.Name = "MARCAToolStripMenuItem"
        Me.MARCAToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MARCAToolStripMenuItem.Text = "MARCA"
        '
        'MODELOToolStripMenuItem
        '
        Me.MODELOToolStripMenuItem.Name = "MODELOToolStripMenuItem"
        Me.MODELOToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MODELOToolStripMenuItem.Text = "MODELO"
        '
        'SERIEToolStripMenuItem
        '
        Me.SERIEToolStripMenuItem.Name = "SERIEToolStripMenuItem"
        Me.SERIEToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SERIEToolStripMenuItem.Text = "SERIE"
        '
        'txt_busqueda
        '
        Me.txt_busqueda.Location = New System.Drawing.Point(495, 642)
        Me.txt_busqueda.Multiline = True
        Me.txt_busqueda.Name = "txt_busqueda"
        Me.txt_busqueda.Size = New System.Drawing.Size(126, 37)
        Me.txt_busqueda.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(298, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 18)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "MARCA"
        '
        'txt_marca
        '
        Me.txt_marca.Location = New System.Drawing.Point(393, 268)
        Me.txt_marca.Multiline = True
        Me.txt_marca.Name = "txt_marca"
        Me.txt_marca.Size = New System.Drawing.Size(206, 46)
        Me.txt_marca.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(658, 285)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 18)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "MODELO"
        '
        'txt_modelo
        '
        Me.txt_modelo.Location = New System.Drawing.Point(757, 268)
        Me.txt_modelo.Multiline = True
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.Size = New System.Drawing.Size(206, 46)
        Me.txt_modelo.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1019, 285)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 18)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "SERIE"
        '
        'txt_serie
        '
        Me.txt_serie.Location = New System.Drawing.Point(1136, 268)
        Me.txt_serie.Multiline = True
        Me.txt_serie.Name = "txt_serie"
        Me.txt_serie.Size = New System.Drawing.Size(206, 46)
        Me.txt_serie.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(658, 447)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 18)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "USUARIO"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(757, 431)
        Me.txt_usuario.Multiline = True
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(205, 46)
        Me.txt_usuario.TabIndex = 33
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(298, 447)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 18)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "ÁREA"
        '
        'txt_area
        '
        Me.txt_area.Location = New System.Drawing.Point(393, 431)
        Me.txt_area.Multiline = True
        Me.txt_area.Name = "txt_area"
        Me.txt_area.Size = New System.Drawing.Size(206, 46)
        Me.txt_area.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(658, 371)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 18)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "VALOR"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1019, 349)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 54)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "ESTADO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(APRECIACIÓN " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NO TECNICA)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(298, 371)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 18)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "COLOR"
        '
        'txt_valor
        '
        Me.txt_valor.Location = New System.Drawing.Point(757, 352)
        Me.txt_valor.Multiline = True
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(206, 46)
        Me.txt_valor.TabIndex = 27
        '
        'txt_estado
        '
        Me.txt_estado.Location = New System.Drawing.Point(1136, 349)
        Me.txt_estado.Multiline = True
        Me.txt_estado.Name = "txt_estado"
        Me.txt_estado.Size = New System.Drawing.Size(205, 46)
        Me.txt_estado.TabIndex = 26
        '
        'txt_color
        '
        Me.txt_color.Location = New System.Drawing.Point(393, 355)
        Me.txt_color.Multiline = True
        Me.txt_color.Name = "txt_color"
        Me.txt_color.Size = New System.Drawing.Size(206, 46)
        Me.txt_color.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(784, 708)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 13)
        Me.Label16.TabIndex = 47
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button5.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(115, 580)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(131, 64)
        Me.Button5.TabIndex = 49
        Me.Button5.Text = "MENÚ PRINCIPAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(466, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(676, 35)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "BIENVENIDO AL DEPARTAMENTO DE ADMINISTRACIÓN"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(834, 506)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(278, 22)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "ÁREA DE REGISTRO DE INVENTARIOS"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button6.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(309, 736)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(125, 56)
        Me.Button6.TabIndex = 52
        Me.Button6.Text = "PAPELERA"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1019, 447)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 18)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "OBSERVACIÓN"
        '
        'txt_observacion
        '
        Me.txt_observacion.Location = New System.Drawing.Point(1137, 431)
        Me.txt_observacion.Multiline = True
        Me.txt_observacion.Name = "txt_observacion"
        Me.txt_observacion.Size = New System.Drawing.Size(205, 46)
        Me.txt_observacion.TabIndex = 57
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button9.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(115, 696)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(131, 68)
        Me.Button9.TabIndex = 60
        Me.Button9.Text = "EXPORTAR A EXCEL"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.Image = Global.WindowsApplication1.My.Resources.Resources.Imagen111
        Me.Button8.Location = New System.Drawing.Point(147, 141)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(64, 55)
        Me.Button8.TabIndex = 55
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button7.Image = Global.WindowsApplication1.My.Resources.Resources.Imagen9
        Me.Button7.Location = New System.Drawing.Point(52, 141)
        Me.Button7.Margin = New System.Windows.Forms.Padding(0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(64, 55)
        Me.Button7.TabIndex = 10
        Me.Button7.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.formularios2
        Me.PictureBox1.Location = New System.Drawing.Point(-18, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(298, 810)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'administracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1381, 801)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_observacion)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_area)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_valor)
        Me.Controls.Add(Me.txt_estado)
        Me.Controls.Add(Me.txt_color)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_serie)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_modelo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_marca)
        Me.Controls.Add(Me.txt_busqueda)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DgvPersonas)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_codinv)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.txt_orden)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "administracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SISTEMA INTEGRADO DE LA FACULTAD DE POSGRADO ""DR. ANTONIO PARRA VELASCO"""
        CType(Me.DgvPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_orden As System.Windows.Forms.TextBox
    Friend WithEvents txt_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents txt_codinv As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents DgvPersonas As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CEDULAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MARCAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MODELOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt_busqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_marca As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_modelo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_serie As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_area As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_valor As System.Windows.Forms.TextBox
    Friend WithEvents txt_estado As System.Windows.Forms.TextBox
    Friend WithEvents txt_color As System.Windows.Forms.TextBox
    Friend WithEvents SERIEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents BUSQUEDAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CODINVToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DESCRIPCIONToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_observacion As System.Windows.Forms.TextBox
    Friend WithEvents AREAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button9 As System.Windows.Forms.Button
End Class
