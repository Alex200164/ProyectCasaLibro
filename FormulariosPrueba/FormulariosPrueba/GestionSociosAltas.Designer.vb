<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionSociosAltas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionSociosAltas))
        Me.MenuStripPagPrin = New System.Windows.Forms.MenuStrip()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlocNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerLaAyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button_Alta = New System.Windows.Forms.Button()
        Me.GruopBox = New System.Windows.Forms.GroupBox()
        Me.Button_Limpiar = New System.Windows.Forms.Button()
        Me.TextBox_Nombre = New System.Windows.Forms.TextBox()
        Me.TextBox_Apellidos = New System.Windows.Forms.TextBox()
        Me.TextBox_Telefono = New System.Windows.Forms.TextBox()
        Me.TextBox_Correo = New System.Windows.Forms.TextBox()
        Me.Label_Nombre = New System.Windows.Forms.Label()
        Me.Label_NumeroSocio = New System.Windows.Forms.Label()
        Me.TextBox_NumeroSocio = New System.Windows.Forms.TextBox()
        Me.Label_Apellidos = New System.Windows.Forms.Label()
        Me.Label_Telefono = New System.Windows.Forms.Label()
        Me.Label_Correo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStripPagPrin.SuspendLayout()
        Me.GruopBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripPagPrin
        '
        Me.MenuStripPagPrin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HerramientasToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStripPagPrin.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripPagPrin.Name = "MenuStripPagPrin"
        Me.MenuStripPagPrin.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStripPagPrin.Size = New System.Drawing.Size(754, 24)
        Me.MenuStripPagPrin.TabIndex = 44
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
        'Button_Alta
        '
        Me.Button_Alta.Location = New System.Drawing.Point(482, 125)
        Me.Button_Alta.Name = "Button_Alta"
        Me.Button_Alta.Size = New System.Drawing.Size(86, 29)
        Me.Button_Alta.TabIndex = 180
        Me.Button_Alta.Text = "Alta"
        Me.Button_Alta.UseVisualStyleBackColor = True
        '
        'GruopBox
        '
        Me.GruopBox.Controls.Add(Me.Button_Alta)
        Me.GruopBox.Controls.Add(Me.Button_Limpiar)
        Me.GruopBox.Controls.Add(Me.TextBox_Nombre)
        Me.GruopBox.Controls.Add(Me.TextBox_Apellidos)
        Me.GruopBox.Controls.Add(Me.TextBox_Telefono)
        Me.GruopBox.Controls.Add(Me.TextBox_Correo)
        Me.GruopBox.Controls.Add(Me.Label_Nombre)
        Me.GruopBox.Controls.Add(Me.Label_NumeroSocio)
        Me.GruopBox.Controls.Add(Me.TextBox_NumeroSocio)
        Me.GruopBox.Controls.Add(Me.Label_Apellidos)
        Me.GruopBox.Controls.Add(Me.Label_Telefono)
        Me.GruopBox.Controls.Add(Me.Label_Correo)
        Me.GruopBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GruopBox.ForeColor = System.Drawing.Color.Black
        Me.GruopBox.Location = New System.Drawing.Point(15, 16)
        Me.GruopBox.Name = "GruopBox"
        Me.GruopBox.Size = New System.Drawing.Size(700, 174)
        Me.GruopBox.TabIndex = 124
        Me.GruopBox.TabStop = False
        Me.GruopBox.Text = "Alta Socio"
        '
        'Button_Limpiar
        '
        Me.Button_Limpiar.Location = New System.Drawing.Point(574, 125)
        Me.Button_Limpiar.Name = "Button_Limpiar"
        Me.Button_Limpiar.Size = New System.Drawing.Size(86, 29)
        Me.Button_Limpiar.TabIndex = 179
        Me.Button_Limpiar.Text = "Limpiar"
        Me.Button_Limpiar.UseVisualStyleBackColor = True
        '
        'TextBox_Nombre
        '
        Me.TextBox_Nombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Nombre.Location = New System.Drawing.Point(139, 64)
        Me.TextBox_Nombre.MaxLength = 50
        Me.TextBox_Nombre.Name = "TextBox_Nombre"
        Me.TextBox_Nombre.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Nombre.TabIndex = 2
        '
        'TextBox_Apellidos
        '
        Me.TextBox_Apellidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Apellidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Apellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Apellidos.Location = New System.Drawing.Point(139, 92)
        Me.TextBox_Apellidos.MaxLength = 50
        Me.TextBox_Apellidos.Name = "TextBox_Apellidos"
        Me.TextBox_Apellidos.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Apellidos.TabIndex = 3
        '
        'TextBox_Telefono
        '
        Me.TextBox_Telefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Telefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Telefono.Location = New System.Drawing.Point(456, 36)
        Me.TextBox_Telefono.MaxLength = 9
        Me.TextBox_Telefono.Name = "TextBox_Telefono"
        Me.TextBox_Telefono.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Telefono.TabIndex = 4
        '
        'TextBox_Correo
        '
        Me.TextBox_Correo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Correo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Correo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Correo.Location = New System.Drawing.Point(456, 64)
        Me.TextBox_Correo.MaxLength = 120
        Me.TextBox_Correo.Name = "TextBox_Correo"
        Me.TextBox_Correo.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Correo.TabIndex = 5
        '
        'Label_Nombre
        '
        Me.Label_Nombre.AutoSize = True
        Me.Label_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Nombre.Location = New System.Drawing.Point(64, 64)
        Me.Label_Nombre.Name = "Label_Nombre"
        Me.Label_Nombre.Size = New System.Drawing.Size(73, 20)
        Me.Label_Nombre.TabIndex = 157
        Me.Label_Nombre.Text = "Nombre :"
        '
        'Label_NumeroSocio
        '
        Me.Label_NumeroSocio.AutoSize = True
        Me.Label_NumeroSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_NumeroSocio.Location = New System.Drawing.Point(1, 36)
        Me.Label_NumeroSocio.Name = "Label_NumeroSocio"
        Me.Label_NumeroSocio.Size = New System.Drawing.Size(136, 20)
        Me.Label_NumeroSocio.TabIndex = 149
        Me.Label_NumeroSocio.Text = "Número de socio :"
        '
        'TextBox_NumeroSocio
        '
        Me.TextBox_NumeroSocio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_NumeroSocio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_NumeroSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_NumeroSocio.Location = New System.Drawing.Point(139, 33)
        Me.TextBox_NumeroSocio.MaxLength = 8
        Me.TextBox_NumeroSocio.Name = "TextBox_NumeroSocio"
        Me.TextBox_NumeroSocio.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_NumeroSocio.TabIndex = 1
        '
        'Label_Apellidos
        '
        Me.Label_Apellidos.AutoSize = True
        Me.Label_Apellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Apellidos.Location = New System.Drawing.Point(56, 92)
        Me.Label_Apellidos.Name = "Label_Apellidos"
        Me.Label_Apellidos.Size = New System.Drawing.Size(81, 20)
        Me.Label_Apellidos.TabIndex = 151
        Me.Label_Apellidos.Text = "Apellidos :"
        '
        'Label_Telefono
        '
        Me.Label_Telefono.AutoSize = True
        Me.Label_Telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Telefono.Location = New System.Drawing.Point(378, 36)
        Me.Label_Telefono.Name = "Label_Telefono"
        Me.Label_Telefono.Size = New System.Drawing.Size(79, 20)
        Me.Label_Telefono.TabIndex = 152
        Me.Label_Telefono.Text = "Teléfono :"
        '
        'Label_Correo
        '
        Me.Label_Correo.AutoSize = True
        Me.Label_Correo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Correo.Location = New System.Drawing.Point(392, 64)
        Me.Label_Correo.Name = "Label_Correo"
        Me.Label_Correo.Size = New System.Drawing.Size(65, 20)
        Me.Label_Correo.TabIndex = 153
        Me.Label_Correo.Tag = ""
        Me.Label_Correo.Text = "Correo :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(754, 128)
        Me.Panel1.TabIndex = 45
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GruopBox)
        Me.Panel2.Location = New System.Drawing.Point(12, 141)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(730, 205)
        Me.Panel2.TabIndex = 46
        '
        'GestionSociosAltas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(754, 353)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStripPagPrin)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionSociosAltas"
        Me.Text = "Gestion de Socios (Altas)"
        Me.MenuStripPagPrin.ResumeLayout(False)
        Me.MenuStripPagPrin.PerformLayout()
        Me.GruopBox.ResumeLayout(False)
        Me.GruopBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStripPagPrin As MenuStrip
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlocNotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerLaAyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button_Alta As Button
    Friend WithEvents GruopBox As GroupBox
    Friend WithEvents Button_Limpiar As Button
    Friend WithEvents TextBox_Nombre As TextBox
    Friend WithEvents TextBox_Apellidos As TextBox
    Friend WithEvents TextBox_Telefono As TextBox
    Friend WithEvents TextBox_Correo As TextBox
    Friend WithEvents Label_Nombre As Label
    Friend WithEvents Label_NumeroSocio As Label
    Friend WithEvents TextBox_NumeroSocio As TextBox
    Friend WithEvents Label_Apellidos As Label
    Friend WithEvents Label_Telefono As Label
    Friend WithEvents Label_Correo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
