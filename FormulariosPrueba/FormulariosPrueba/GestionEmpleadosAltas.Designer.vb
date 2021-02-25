<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionEmpleadosAltas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionEmpleadosAltas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStripPagPrin = New System.Windows.Forms.MenuStrip()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlocNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerLaAyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button_Guardar_Alta = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GruopBox = New System.Windows.Forms.GroupBox()
        Me.TextBox_ROL = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_CONTRASENNA = New System.Windows.Forms.TextBox()
        Me.TextBox_USUARIO = New System.Windows.Forms.TextBox()
        Me.TextBox_TELEFONO = New System.Windows.Forms.TextBox()
        Me.TextBox_NOMBRE = New System.Windows.Forms.TextBox()
        Me.TextBox_APELLIDOS = New System.Windows.Forms.TextBox()
        Me.TextBox_CORREO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ISBN = New System.Windows.Forms.Label()
        Me.TextBox_DNI = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStripPagPrin.SuspendLayout()
        Me.GruopBox.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(754, 108)
        Me.Panel1.TabIndex = 51
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'MenuStripPagPrin
        '
        Me.MenuStripPagPrin.BackColor = System.Drawing.Color.Transparent
        Me.MenuStripPagPrin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HerramientasToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStripPagPrin.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripPagPrin.Name = "MenuStripPagPrin"
        Me.MenuStripPagPrin.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStripPagPrin.Size = New System.Drawing.Size(754, 24)
        Me.MenuStripPagPrin.TabIndex = 50
        Me.MenuStripPagPrin.TabStop = True
        Me.MenuStripPagPrin.Text = "MenuStrip1"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem, Me.BlocNotasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Image = CType(resources.GetObject("CalculadoraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'BlocNotasToolStripMenuItem
        '
        Me.BlocNotasToolStripMenuItem.Image = CType(resources.GetObject("BlocNotasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BlocNotasToolStripMenuItem.Name = "BlocNotasToolStripMenuItem"
        Me.BlocNotasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.BlocNotasToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.BlocNotasToolStripMenuItem.Text = "Bloc Notas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.SalirToolStripMenuItem.Text = "Salir..."
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerLaAyudaToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'VerLaAyudaToolStripMenuItem
        '
        Me.VerLaAyudaToolStripMenuItem.Image = CType(resources.GetObject("VerLaAyudaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VerLaAyudaToolStripMenuItem.Name = "VerLaAyudaToolStripMenuItem"
        Me.VerLaAyudaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.VerLaAyudaToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.VerLaAyudaToolStripMenuItem.Text = "Ver la Ayuda"
        '
        'Button_Guardar_Alta
        '
        Me.Button_Guardar_Alta.Location = New System.Drawing.Point(506, 241)
        Me.Button_Guardar_Alta.Name = "Button_Guardar_Alta"
        Me.Button_Guardar_Alta.Size = New System.Drawing.Size(86, 29)
        Me.Button_Guardar_Alta.TabIndex = 178
        Me.Button_Guardar_Alta.Text = "Alta"
        Me.Button_Guardar_Alta.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(598, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 29)
        Me.Button1.TabIndex = 176
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GruopBox
        '
        Me.GruopBox.Controls.Add(Me.TextBox_ROL)
        Me.GruopBox.Controls.Add(Me.Label8)
        Me.GruopBox.Controls.Add(Me.Label3)
        Me.GruopBox.Controls.Add(Me.TextBox_CONTRASENNA)
        Me.GruopBox.Controls.Add(Me.TextBox_USUARIO)
        Me.GruopBox.Controls.Add(Me.TextBox_TELEFONO)
        Me.GruopBox.Controls.Add(Me.TextBox_NOMBRE)
        Me.GruopBox.Controls.Add(Me.TextBox_APELLIDOS)
        Me.GruopBox.Controls.Add(Me.TextBox_CORREO)
        Me.GruopBox.Controls.Add(Me.Label5)
        Me.GruopBox.Controls.Add(Me.Label1)
        Me.GruopBox.Controls.Add(Me.Label2)
        Me.GruopBox.Controls.Add(Me.ISBN)
        Me.GruopBox.Controls.Add(Me.TextBox_DNI)
        Me.GruopBox.Controls.Add(Me.Label21)
        Me.GruopBox.Controls.Add(Me.Label20)
        Me.GruopBox.Controls.Add(Me.Button_Guardar_Alta)
        Me.GruopBox.Controls.Add(Me.Button1)
        Me.GruopBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GruopBox.ForeColor = System.Drawing.Color.Black
        Me.GruopBox.Location = New System.Drawing.Point(15, 16)
        Me.GruopBox.Name = "GruopBox"
        Me.GruopBox.Size = New System.Drawing.Size(700, 292)
        Me.GruopBox.TabIndex = 124
        Me.GruopBox.TabStop = False
        Me.GruopBox.Text = "Alta Empleado"
        '
        'TextBox_ROL
        '
        Me.TextBox_ROL.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_ROL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_ROL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ROL.Location = New System.Drawing.Point(492, 120)
        Me.TextBox_ROL.MaxLength = 20
        Me.TextBox_ROL.Name = "TextBox_ROL"
        Me.TextBox_ROL.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_ROL.TabIndex = 186
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(447, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 20)
        Me.Label8.TabIndex = 194
        Me.Label8.Text = "Rol :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(388, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 193
        Me.Label3.Text = "Contraseña :"
        '
        'TextBox_CONTRASENNA
        '
        Me.TextBox_CONTRASENNA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_CONTRASENNA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_CONTRASENNA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_CONTRASENNA.Location = New System.Drawing.Point(492, 92)
        Me.TextBox_CONTRASENNA.MaxLength = 4
        Me.TextBox_CONTRASENNA.Name = "TextBox_CONTRASENNA"
        Me.TextBox_CONTRASENNA.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_CONTRASENNA.TabIndex = 185
        '
        'TextBox_USUARIO
        '
        Me.TextBox_USUARIO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_USUARIO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_USUARIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_USUARIO.Location = New System.Drawing.Point(492, 64)
        Me.TextBox_USUARIO.MaxLength = 30
        Me.TextBox_USUARIO.Name = "TextBox_USUARIO"
        Me.TextBox_USUARIO.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_USUARIO.TabIndex = 184
        '
        'TextBox_TELEFONO
        '
        Me.TextBox_TELEFONO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_TELEFONO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_TELEFONO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_TELEFONO.Location = New System.Drawing.Point(492, 36)
        Me.TextBox_TELEFONO.MaxLength = 9
        Me.TextBox_TELEFONO.Name = "TextBox_TELEFONO"
        Me.TextBox_TELEFONO.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_TELEFONO.TabIndex = 183
        '
        'TextBox_NOMBRE
        '
        Me.TextBox_NOMBRE.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_NOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_NOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_NOMBRE.Location = New System.Drawing.Point(139, 64)
        Me.TextBox_NOMBRE.MaxLength = 50
        Me.TextBox_NOMBRE.Name = "TextBox_NOMBRE"
        Me.TextBox_NOMBRE.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_NOMBRE.TabIndex = 180
        '
        'TextBox_APELLIDOS
        '
        Me.TextBox_APELLIDOS.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_APELLIDOS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_APELLIDOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_APELLIDOS.Location = New System.Drawing.Point(139, 92)
        Me.TextBox_APELLIDOS.MaxLength = 50
        Me.TextBox_APELLIDOS.Name = "TextBox_APELLIDOS"
        Me.TextBox_APELLIDOS.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_APELLIDOS.TabIndex = 181
        '
        'TextBox_CORREO
        '
        Me.TextBox_CORREO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_CORREO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_CORREO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_CORREO.Location = New System.Drawing.Point(139, 120)
        Me.TextBox_CORREO.MaxLength = 120
        Me.TextBox_CORREO.Name = "TextBox_CORREO"
        Me.TextBox_CORREO.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_CORREO.TabIndex = 182
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(64, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 192
        Me.Label5.Text = "Nombre :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(410, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 190
        Me.Label1.Tag = ""
        Me.Label1.Text = "Teléfono :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(417, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 191
        Me.Label2.Text = "Usuario :"
        '
        'ISBN
        '
        Me.ISBN.AutoSize = True
        Me.ISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBN.Location = New System.Drawing.Point(91, 32)
        Me.ISBN.Name = "ISBN"
        Me.ISBN.Size = New System.Drawing.Size(45, 20)
        Me.ISBN.TabIndex = 187
        Me.ISBN.Text = "DNI :"
        '
        'TextBox_DNI
        '
        Me.TextBox_DNI.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_DNI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_DNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_DNI.Location = New System.Drawing.Point(139, 33)
        Me.TextBox_DNI.MaxLength = 9
        Me.TextBox_DNI.Name = "TextBox_DNI"
        Me.TextBox_DNI.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_DNI.TabIndex = 179
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(56, 90)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(81, 20)
        Me.Label21.TabIndex = 188
        Me.Label21.Text = "Apellidos :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(72, 118)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 20)
        Me.Label20.TabIndex = 189
        Me.Label20.Text = "Correo :"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GruopBox)
        Me.Panel2.Location = New System.Drawing.Point(12, 136)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(730, 324)
        Me.Panel2.TabIndex = 52
        '
        'GestionEmpleadosAltas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(754, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStripPagPrin)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionEmpleadosAltas"
        Me.Text = "Gestion de Empleados (Altas)"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStripPagPrin.ResumeLayout(False)
        Me.MenuStripPagPrin.PerformLayout()
        Me.GruopBox.ResumeLayout(False)
        Me.GruopBox.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStripPagPrin As MenuStrip
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlocNotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerLaAyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button_Guardar_Alta As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GruopBox As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox_ROL As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_CONTRASENNA As TextBox
    Friend WithEvents TextBox_USUARIO As TextBox
    Friend WithEvents TextBox_TELEFONO As TextBox
    Friend WithEvents TextBox_NOMBRE As TextBox
    Friend WithEvents TextBox_APELLIDOS As TextBox
    Friend WithEvents TextBox_CORREO As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ISBN As Label
    Friend WithEvents TextBox_DNI As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
End Class
