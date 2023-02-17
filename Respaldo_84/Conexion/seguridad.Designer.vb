<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class seguridad
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvActividad = New System.Windows.Forms.DataGridView()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CEDULAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NOMBREToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.APELLIDOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VERSIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PAPELERAADMINISTRACIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DgvActividad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(631, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(447, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MONITORIZACIÓN DE ACTIVIDADES"
        '
        'DgvActividad
        '
        Me.DgvActividad.AllowUserToAddRows = False
        Me.DgvActividad.AllowUserToDeleteRows = False
        Me.DgvActividad.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DgvActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvActividad.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.DgvActividad.Location = New System.Drawing.Point(321, 248)
        Me.DgvActividad.Name = "DgvActividad"
        Me.DgvActividad.ReadOnly = True
        Me.DgvActividad.Size = New System.Drawing.Size(1025, 536)
        Me.DgvActividad.TabIndex = 63
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(449, 195)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 13)
        Me.Label16.TabIndex = 98
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CEDULAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(321, 195)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(271, 26)
        Me.MenuStrip1.TabIndex = 96
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CEDULAToolStripMenuItem
        '
        Me.CEDULAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NOMBREToolStripMenuItem, Me.APELLIDOToolStripMenuItem, Me.VERSIONToolStripMenuItem, Me.PAPELERAADMINISTRACIONToolStripMenuItem})
        Me.CEDULAToolStripMenuItem.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEDULAToolStripMenuItem.Name = "CEDULAToolStripMenuItem"
        Me.CEDULAToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.CEDULAToolStripMenuItem.Text = "TIPO DE BÚSQUEDA POR DEPARTAMENTO"
        '
        'NOMBREToolStripMenuItem
        '
        Me.NOMBREToolStripMenuItem.Name = "NOMBREToolStripMenuItem"
        Me.NOMBREToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.NOMBREToolStripMenuItem.Text = "SECRETARÍA GENERAL"
        '
        'APELLIDOToolStripMenuItem
        '
        Me.APELLIDOToolStripMenuItem.Name = "APELLIDOToolStripMenuItem"
        Me.APELLIDOToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.APELLIDOToolStripMenuItem.Text = "ADMINISTRACIÓN"
        '
        'VERSIONToolStripMenuItem
        '
        Me.VERSIONToolStripMenuItem.Name = "VERSIONToolStripMenuItem"
        Me.VERSIONToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.VERSIONToolStripMenuItem.Text = "BIBLIOTECA"
        '
        'PAPELERAADMINISTRACIONToolStripMenuItem
        '
        Me.PAPELERAADMINISTRACIONToolStripMenuItem.Name = "PAPELERAADMINISTRACIONToolStripMenuItem"
        Me.PAPELERAADMINISTRACIONToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.PAPELERAADMINISTRACIONToolStripMenuItem.Text = "PAPELERA ADMINISTRACIÓN"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button3.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(1186, 177)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(160, 53)
        Me.Button3.TabIndex = 105
        Me.Button3.Text = "ATRÁS"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button7.Image = Global.WindowsApplication1.My.Resources.Resources.Imagen9
        Me.Button7.Location = New System.Drawing.Point(33, 301)
        Me.Button7.Margin = New System.Windows.Forms.Padding(0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(83, 70)
        Me.Button7.TabIndex = 103
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.Image = Global.WindowsApplication1.My.Resources.Resources.Imagen111
        Me.Button8.Location = New System.Drawing.Point(157, 301)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(83, 70)
        Me.Button8.TabIndex = 102
        Me.Button8.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.seguridad_si
        Me.PictureBox1.Location = New System.Drawing.Point(-6, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(293, 799)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 104
        Me.PictureBox1.TabStop = False
        '
        'seguridad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1371, 796)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DgvActividad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "seguridad"
        Me.Text = "SISTEMA INTEGRADO DE LA FACULTAD DE POSGRADO ""DR. ANTONIO PARRA VELASCO"""
        CType(Me.DgvActividad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgvActividad As System.Windows.Forms.DataGridView
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CEDULAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NOMBREToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents APELLIDOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VERSIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PAPELERAADMINISTRACIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
