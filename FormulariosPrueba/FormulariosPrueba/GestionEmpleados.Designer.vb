<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionEmpleados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionEmpleados))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button_Eliminar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox_APELLIDOS = New System.Windows.Forms.TextBox()
        Me.TextBox_NOMBRE = New System.Windows.Forms.TextBox()
        Me.TextBox_CORREO = New System.Windows.Forms.TextBox()
        Me.TextBox_DNIOCULTO = New System.Windows.Forms.TextBox()
        Me.Label_CORREO = New System.Windows.Forms.Label()
        Me.Button_Buscar = New System.Windows.Forms.Button()
        Me.Button_Limpiar = New System.Windows.Forms.Button()
        Me.Label_Apellidos = New System.Windows.Forms.Label()
        Me.Label_Nombre = New System.Windows.Forms.Label()
        Me.Label_DNI = New System.Windows.Forms.Label()
        Me.Button_Annadir = New System.Windows.Forms.Button()
        Me.DataGridView_Empleados = New System.Windows.Forms.DataGridView()
        Me.MenuStripPagPrin = New System.Windows.Forms.MenuStrip()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlocNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónLibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónLibrosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónArticulosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónSociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónSociosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerLaAyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TextBox_DNI = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView_Empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStripPagPrin.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'Button_Eliminar
        '
        Me.Button_Eliminar.Location = New System.Drawing.Point(837, 160)
        Me.Button_Eliminar.Name = "Button_Eliminar"
        Me.Button_Eliminar.Size = New System.Drawing.Size(86, 29)
        Me.Button_Eliminar.TabIndex = 182
        Me.Button_Eliminar.Text = "Eliminar"
        Me.Button_Eliminar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Button_Eliminar)
        Me.Panel1.Controls.Add(Me.Button_Annadir)
        Me.Panel1.Controls.Add(Me.DataGridView_Empleados)
        Me.Panel1.Location = New System.Drawing.Point(12, 130)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(959, 480)
        Me.Panel1.TabIndex = 53
        Me.Panel1.TabStop = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(641, 160)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 29)
        Me.Button1.TabIndex = 185
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TextBox_DNI)
        Me.GroupBox1.Controls.Add(Me.TextBox_APELLIDOS)
        Me.GroupBox1.Controls.Add(Me.TextBox_NOMBRE)
        Me.GroupBox1.Controls.Add(Me.TextBox_CORREO)
        Me.GroupBox1.Controls.Add(Me.TextBox_DNIOCULTO)
        Me.GroupBox1.Controls.Add(Me.Label_CORREO)
        Me.GroupBox1.Controls.Add(Me.Button_Buscar)
        Me.GroupBox1.Controls.Add(Me.Button_Limpiar)
        Me.GroupBox1.Controls.Add(Me.Label_Apellidos)
        Me.GroupBox1.Controls.Add(Me.Label_Nombre)
        Me.GroupBox1.Controls.Add(Me.Label_DNI)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(938, 127)
        Me.GroupBox1.TabIndex = 183
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Busqueda"
        '
        'TextBox_APELLIDOS
        '
        Me.TextBox_APELLIDOS.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_APELLIDOS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_APELLIDOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_APELLIDOS.Location = New System.Drawing.Point(723, 30)
        Me.TextBox_APELLIDOS.MaxLength = 100
        Me.TextBox_APELLIDOS.Name = "TextBox_APELLIDOS"
        Me.TextBox_APELLIDOS.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_APELLIDOS.TabIndex = 185
        '
        'TextBox_NOMBRE
        '
        Me.TextBox_NOMBRE.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_NOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_NOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_NOMBRE.Location = New System.Drawing.Point(392, 30)
        Me.TextBox_NOMBRE.MaxLength = 100
        Me.TextBox_NOMBRE.Name = "TextBox_NOMBRE"
        Me.TextBox_NOMBRE.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_NOMBRE.TabIndex = 184
        '
        'TextBox_CORREO
        '
        Me.TextBox_CORREO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_CORREO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_CORREO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_CORREO.Location = New System.Drawing.Point(73, 85)
        Me.TextBox_CORREO.MaxLength = 100
        Me.TextBox_CORREO.Name = "TextBox_CORREO"
        Me.TextBox_CORREO.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_CORREO.TabIndex = 183
        '
        'TextBox_DNIOCULTO
        '
        Me.TextBox_DNIOCULTO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_DNIOCULTO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_DNIOCULTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_DNIOCULTO.Location = New System.Drawing.Point(76, 30)
        Me.TextBox_DNIOCULTO.MaxLength = 100
        Me.TextBox_DNIOCULTO.Name = "TextBox_DNIOCULTO"
        Me.TextBox_DNIOCULTO.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_DNIOCULTO.TabIndex = 182
        '
        'Label_CORREO
        '
        Me.Label_CORREO.AutoSize = True
        Me.Label_CORREO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_CORREO.Location = New System.Drawing.Point(6, 84)
        Me.Label_CORREO.Name = "Label_CORREO"
        Me.Label_CORREO.Size = New System.Drawing.Size(65, 20)
        Me.Label_CORREO.TabIndex = 181
        Me.Label_CORREO.Text = "Correo :"
        '
        'Button_Buscar
        '
        Me.Button_Buscar.Location = New System.Drawing.Point(742, 82)
        Me.Button_Buscar.Name = "Button_Buscar"
        Me.Button_Buscar.Size = New System.Drawing.Size(86, 29)
        Me.Button_Buscar.TabIndex = 180
        Me.Button_Buscar.Text = "Buscar"
        Me.Button_Buscar.UseVisualStyleBackColor = True
        '
        'Button_Limpiar
        '
        Me.Button_Limpiar.Location = New System.Drawing.Point(834, 82)
        Me.Button_Limpiar.Name = "Button_Limpiar"
        Me.Button_Limpiar.Size = New System.Drawing.Size(86, 29)
        Me.Button_Limpiar.TabIndex = 179
        Me.Button_Limpiar.Text = "Limpiar"
        Me.Button_Limpiar.UseVisualStyleBackColor = True
        '
        'Label_Apellidos
        '
        Me.Label_Apellidos.AutoSize = True
        Me.Label_Apellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Apellidos.Location = New System.Drawing.Point(634, 29)
        Me.Label_Apellidos.Name = "Label_Apellidos"
        Me.Label_Apellidos.Size = New System.Drawing.Size(81, 20)
        Me.Label_Apellidos.TabIndex = 169
        Me.Label_Apellidos.Text = "Apellidos :"
        '
        'Label_Nombre
        '
        Me.Label_Nombre.AutoSize = True
        Me.Label_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Nombre.Location = New System.Drawing.Point(313, 29)
        Me.Label_Nombre.Name = "Label_Nombre"
        Me.Label_Nombre.Size = New System.Drawing.Size(73, 20)
        Me.Label_Nombre.TabIndex = 167
        Me.Label_Nombre.Text = "Nombre :"
        '
        'Label_DNI
        '
        Me.Label_DNI.AutoSize = True
        Me.Label_DNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_DNI.Location = New System.Drawing.Point(15, 29)
        Me.Label_DNI.Name = "Label_DNI"
        Me.Label_DNI.Size = New System.Drawing.Size(45, 20)
        Me.Label_DNI.TabIndex = 165
        Me.Label_DNI.Text = "DNI :"
        '
        'Button_Annadir
        '
        Me.Button_Annadir.Location = New System.Drawing.Point(745, 160)
        Me.Button_Annadir.Name = "Button_Annadir"
        Me.Button_Annadir.Size = New System.Drawing.Size(86, 29)
        Me.Button_Annadir.TabIndex = 181
        Me.Button_Annadir.Text = "Añadir"
        Me.Button_Annadir.UseVisualStyleBackColor = True
        '
        'DataGridView_Empleados
        '
        Me.DataGridView_Empleados.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Empleados.Location = New System.Drawing.Point(3, 211)
        Me.DataGridView_Empleados.Name = "DataGridView_Empleados"
        Me.DataGridView_Empleados.Size = New System.Drawing.Size(938, 260)
        Me.DataGridView_Empleados.TabIndex = 99
        '
        'MenuStripPagPrin
        '
        Me.MenuStripPagPrin.BackColor = System.Drawing.Color.Transparent
        Me.MenuStripPagPrin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HerramientasToolStripMenuItem, Me.GestiónLibrosToolStripMenuItem, Me.GestiónArticulosToolStripMenuItem, Me.GestiónSociosToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStripPagPrin.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripPagPrin.Name = "MenuStripPagPrin"
        Me.MenuStripPagPrin.Size = New System.Drawing.Size(984, 24)
        Me.MenuStripPagPrin.TabIndex = 52
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
        'GestiónLibrosToolStripMenuItem
        '
        Me.GestiónLibrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónLibrosToolStripMenuItem1})
        Me.GestiónLibrosToolStripMenuItem.Name = "GestiónLibrosToolStripMenuItem"
        Me.GestiónLibrosToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.GestiónLibrosToolStripMenuItem.Text = "Libros"
        '
        'GestiónLibrosToolStripMenuItem1
        '
        Me.GestiónLibrosToolStripMenuItem1.Image = Global.FormulariosPrueba.My.Resources.Resources.libros
        Me.GestiónLibrosToolStripMenuItem1.Name = "GestiónLibrosToolStripMenuItem1"
        Me.GestiónLibrosToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.GestiónLibrosToolStripMenuItem1.Text = "Gestión de Libros"
        '
        'GestiónArticulosToolStripMenuItem
        '
        Me.GestiónArticulosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónArticulosToolStripMenuItem1})
        Me.GestiónArticulosToolStripMenuItem.Name = "GestiónArticulosToolStripMenuItem"
        Me.GestiónArticulosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.GestiónArticulosToolStripMenuItem.Text = "Articulos"
        '
        'GestiónArticulosToolStripMenuItem1
        '
        Me.GestiónArticulosToolStripMenuItem1.Image = Global.FormulariosPrueba.My.Resources.Resources.articulos
        Me.GestiónArticulosToolStripMenuItem1.Name = "GestiónArticulosToolStripMenuItem1"
        Me.GestiónArticulosToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.GestiónArticulosToolStripMenuItem1.Text = "Gestión de Articulos"
        '
        'GestiónSociosToolStripMenuItem
        '
        Me.GestiónSociosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónSociosToolStripMenuItem1})
        Me.GestiónSociosToolStripMenuItem.Name = "GestiónSociosToolStripMenuItem"
        Me.GestiónSociosToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.GestiónSociosToolStripMenuItem.Text = "Socios"
        '
        'GestiónSociosToolStripMenuItem1
        '
        Me.GestiónSociosToolStripMenuItem1.Image = Global.FormulariosPrueba.My.Resources.Resources.socios
        Me.GestiónSociosToolStripMenuItem1.Name = "GestiónSociosToolStripMenuItem1"
        Me.GestiónSociosToolStripMenuItem1.Size = New System.Drawing.Size(167, 22)
        Me.GestiónSociosToolStripMenuItem1.Text = "Gestión de Socios"
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(0, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(984, 94)
        Me.Panel2.TabIndex = 54
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'TextBox_DNI
        '
        Me.TextBox_DNI.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_DNI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_DNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_DNI.Location = New System.Drawing.Point(76, 30)
        Me.TextBox_DNI.MaxLength = 100
        Me.TextBox_DNI.Name = "TextBox_DNI"
        Me.TextBox_DNI.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_DNI.TabIndex = 186
        '
        'GestionEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 611)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStripPagPrin)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionEmpleados"
        Me.Text = "Gestión de Empleados"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView_Empleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStripPagPrin.ResumeLayout(False)
        Me.MenuStripPagPrin.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button_Eliminar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_Annadir As Button
    Friend WithEvents DataGridView_Empleados As DataGridView
    Friend WithEvents MenuStripPagPrin As MenuStrip
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlocNotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerLaAyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GestiónLibrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónLibrosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GestiónArticulosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónArticulosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GestiónSociosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónSociosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox_APELLIDOS As TextBox
    Friend WithEvents TextBox_NOMBRE As TextBox
    Friend WithEvents TextBox_CORREO As TextBox
    Friend WithEvents TextBox_DNIOCULTO As TextBox
    Friend WithEvents Label_CORREO As Label
    Friend WithEvents Button_Buscar As Button
    Friend WithEvents Button_Limpiar As Button
    Friend WithEvents Label_Apellidos As Label
    Friend WithEvents Label_Nombre As Label
    Friend WithEvents Label_DNI As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox_DNI As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
