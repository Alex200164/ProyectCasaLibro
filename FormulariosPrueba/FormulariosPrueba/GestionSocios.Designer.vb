<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionSocios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionSocios))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlocNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label_Autor = New System.Windows.Forms.Label()
        Me.Button_Buscar = New System.Windows.Forms.Button()
        Me.Button_Limpiar = New System.Windows.Forms.Button()
        Me.Label_Genero = New System.Windows.Forms.Label()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerLaAyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button_Annadir = New System.Windows.Forms.Button()
        Me.Label_Nombre = New System.Windows.Forms.Label()
        Me.Label_ISBN = New System.Windows.Forms.Label()
        Me.MenuStripPagPrin = New System.Windows.Forms.MenuStrip()
        Me.GestiónLibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónLibrosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónArticulosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónEmpleadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox_NumeroSocio = New System.Windows.Forms.TextBox()
        Me.TextBox_Telefono = New System.Windows.Forms.TextBox()
        Me.TextBox_NumeroSocioOCULTO = New System.Windows.Forms.TextBox()
        Me.TextBox_Apellidos = New System.Windows.Forms.TextBox()
        Me.TextBox_Nombre = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_Eliminar = New System.Windows.Forms.Button()
        Me.DataGridView_Socios = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.InformeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarInformeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripPagPrin.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView_Socios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        'Label_Autor
        '
        Me.Label_Autor.AutoSize = True
        Me.Label_Autor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Autor.Location = New System.Drawing.Point(5, 80)
        Me.Label_Autor.Name = "Label_Autor"
        Me.Label_Autor.Size = New System.Drawing.Size(79, 20)
        Me.Label_Autor.TabIndex = 181
        Me.Label_Autor.Text = "Teléfono :"
        '
        'Button_Buscar
        '
        Me.Button_Buscar.Location = New System.Drawing.Point(742, 81)
        Me.Button_Buscar.Name = "Button_Buscar"
        Me.Button_Buscar.Size = New System.Drawing.Size(86, 29)
        Me.Button_Buscar.TabIndex = 5
        Me.Button_Buscar.Text = "Buscar"
        Me.Button_Buscar.UseVisualStyleBackColor = True
        '
        'Button_Limpiar
        '
        Me.Button_Limpiar.Location = New System.Drawing.Point(834, 81)
        Me.Button_Limpiar.Name = "Button_Limpiar"
        Me.Button_Limpiar.Size = New System.Drawing.Size(86, 29)
        Me.Button_Limpiar.TabIndex = 6
        Me.Button_Limpiar.Text = "Limpiar"
        Me.Button_Limpiar.UseVisualStyleBackColor = True
        '
        'Label_Genero
        '
        Me.Label_Genero.AutoSize = True
        Me.Label_Genero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Genero.Location = New System.Drawing.Point(636, 24)
        Me.Label_Genero.Name = "Label_Genero"
        Me.Label_Genero.Size = New System.Drawing.Size(81, 20)
        Me.Label_Genero.TabIndex = 169
        Me.Label_Genero.Text = "Apellidos :"
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
        'Button_Annadir
        '
        Me.Button_Annadir.Location = New System.Drawing.Point(745, 160)
        Me.Button_Annadir.Name = "Button_Annadir"
        Me.Button_Annadir.Size = New System.Drawing.Size(86, 29)
        Me.Button_Annadir.TabIndex = 7
        Me.Button_Annadir.Text = "Añadir"
        Me.Button_Annadir.UseVisualStyleBackColor = True
        '
        'Label_Nombre
        '
        Me.Label_Nombre.AutoSize = True
        Me.Label_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Nombre.Location = New System.Drawing.Point(315, 25)
        Me.Label_Nombre.Name = "Label_Nombre"
        Me.Label_Nombre.Size = New System.Drawing.Size(73, 20)
        Me.Label_Nombre.TabIndex = 167
        Me.Label_Nombre.Text = "Nombre :"
        '
        'Label_ISBN
        '
        Me.Label_ISBN.AutoSize = True
        Me.Label_ISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ISBN.Location = New System.Drawing.Point(11, 25)
        Me.Label_ISBN.Name = "Label_ISBN"
        Me.Label_ISBN.Size = New System.Drawing.Size(75, 20)
        Me.Label_ISBN.TabIndex = 165
        Me.Label_ISBN.Text = "Nº socio :"
        '
        'MenuStripPagPrin
        '
        Me.MenuStripPagPrin.BackColor = System.Drawing.Color.Transparent
        Me.MenuStripPagPrin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HerramientasToolStripMenuItem, Me.GestiónLibrosToolStripMenuItem, Me.GestiónArticulosToolStripMenuItem, Me.GestiónEmpleadosToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.InformeToolStripMenuItem})
        Me.MenuStripPagPrin.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripPagPrin.Name = "MenuStripPagPrin"
        Me.MenuStripPagPrin.Size = New System.Drawing.Size(984, 24)
        Me.MenuStripPagPrin.TabIndex = 49
        Me.MenuStripPagPrin.TabStop = True
        Me.MenuStripPagPrin.Text = "MenuStrip1"
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
        'GestiónEmpleadosToolStripMenuItem
        '
        Me.GestiónEmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónEmpleadosToolStripMenuItem1})
        Me.GestiónEmpleadosToolStripMenuItem.Name = "GestiónEmpleadosToolStripMenuItem"
        Me.GestiónEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.GestiónEmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'GestiónEmpleadosToolStripMenuItem1
        '
        Me.GestiónEmpleadosToolStripMenuItem1.Image = Global.FormulariosPrueba.My.Resources.Resources.empleados
        Me.GestiónEmpleadosToolStripMenuItem1.Name = "GestiónEmpleadosToolStripMenuItem1"
        Me.GestiónEmpleadosToolStripMenuItem1.Size = New System.Drawing.Size(191, 22)
        Me.GestiónEmpleadosToolStripMenuItem1.Text = "Gestión de Empleados"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TextBox_NumeroSocio)
        Me.GroupBox1.Controls.Add(Me.TextBox_Telefono)
        Me.GroupBox1.Controls.Add(Me.TextBox_NumeroSocioOCULTO)
        Me.GroupBox1.Controls.Add(Me.TextBox_Apellidos)
        Me.GroupBox1.Controls.Add(Me.TextBox_Nombre)
        Me.GroupBox1.Controls.Add(Me.Label_Autor)
        Me.GroupBox1.Controls.Add(Me.Button_Buscar)
        Me.GroupBox1.Controls.Add(Me.Button_Limpiar)
        Me.GroupBox1.Controls.Add(Me.Label_Genero)
        Me.GroupBox1.Controls.Add(Me.Label_Nombre)
        Me.GroupBox1.Controls.Add(Me.Label_ISBN)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(938, 127)
        Me.GroupBox1.TabIndex = 183
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Busqueda"
        '
        'TextBox_NumeroSocio
        '
        Me.TextBox_NumeroSocio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_NumeroSocio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_NumeroSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_NumeroSocio.Location = New System.Drawing.Point(90, 26)
        Me.TextBox_NumeroSocio.MaxLength = 100
        Me.TextBox_NumeroSocio.Name = "TextBox_NumeroSocio"
        Me.TextBox_NumeroSocio.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_NumeroSocio.TabIndex = 182
        '
        'TextBox_Telefono
        '
        Me.TextBox_Telefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Telefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Telefono.Location = New System.Drawing.Point(90, 84)
        Me.TextBox_Telefono.MaxLength = 100
        Me.TextBox_Telefono.Name = "TextBox_Telefono"
        Me.TextBox_Telefono.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Telefono.TabIndex = 4
        '
        'TextBox_NumeroSocioOCULTO
        '
        Me.TextBox_NumeroSocioOCULTO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_NumeroSocioOCULTO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_NumeroSocioOCULTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_NumeroSocioOCULTO.Location = New System.Drawing.Point(90, 26)
        Me.TextBox_NumeroSocioOCULTO.MaxLength = 100
        Me.TextBox_NumeroSocioOCULTO.Name = "TextBox_NumeroSocioOCULTO"
        Me.TextBox_NumeroSocioOCULTO.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_NumeroSocioOCULTO.TabIndex = 1
        '
        'TextBox_Apellidos
        '
        Me.TextBox_Apellidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Apellidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Apellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Apellidos.Location = New System.Drawing.Point(723, 25)
        Me.TextBox_Apellidos.MaxLength = 100
        Me.TextBox_Apellidos.Name = "TextBox_Apellidos"
        Me.TextBox_Apellidos.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Apellidos.TabIndex = 3
        '
        'TextBox_Nombre
        '
        Me.TextBox_Nombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Nombre.Location = New System.Drawing.Point(394, 26)
        Me.TextBox_Nombre.MaxLength = 100
        Me.TextBox_Nombre.Name = "TextBox_Nombre"
        Me.TextBox_Nombre.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Nombre.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Button_Eliminar)
        Me.Panel1.Controls.Add(Me.Button_Annadir)
        Me.Panel1.Controls.Add(Me.DataGridView_Socios)
        Me.Panel1.Location = New System.Drawing.Point(12, 129)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(959, 480)
        Me.Panel1.TabIndex = 50
        Me.Panel1.TabStop = True
        '
        'Button_Eliminar
        '
        Me.Button_Eliminar.Location = New System.Drawing.Point(837, 160)
        Me.Button_Eliminar.Name = "Button_Eliminar"
        Me.Button_Eliminar.Size = New System.Drawing.Size(86, 29)
        Me.Button_Eliminar.TabIndex = 8
        Me.Button_Eliminar.Text = "Eliminar"
        Me.Button_Eliminar.UseVisualStyleBackColor = True
        '
        'DataGridView_Socios
        '
        Me.DataGridView_Socios.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView_Socios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Socios.Location = New System.Drawing.Point(3, 211)
        Me.DataGridView_Socios.Name = "DataGridView_Socios"
        Me.DataGridView_Socios.Size = New System.Drawing.Size(938, 260)
        Me.DataGridView_Socios.TabIndex = 99
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(0, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(984, 94)
        Me.Panel2.TabIndex = 51
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.ServerReport.BearerToken = Nothing
        Me.ReportViewer2.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer2.TabIndex = 0
        '
        'InformeToolStripMenuItem
        '
        Me.InformeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarInformeToolStripMenuItem})
        Me.InformeToolStripMenuItem.Name = "InformeToolStripMenuItem"
        Me.InformeToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.InformeToolStripMenuItem.Text = "Informe"
        '
        'GenerarInformeToolStripMenuItem
        '
        Me.GenerarInformeToolStripMenuItem.Name = "GenerarInformeToolStripMenuItem"
        Me.GenerarInformeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GenerarInformeToolStripMenuItem.Text = "Generar Informe"
        '
        'GestionSocios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 611)
        Me.Controls.Add(Me.MenuStripPagPrin)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionSocios"
        Me.Text = "Gestión de Socios"
        Me.MenuStripPagPrin.ResumeLayout(False)
        Me.MenuStripPagPrin.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView_Socios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlocNotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label_Autor As Label
    Friend WithEvents Button_Buscar As Button
    Friend WithEvents Button_Limpiar As Button
    Friend WithEvents Label_Genero As Label
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerLaAyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button_Annadir As Button
    Friend WithEvents Label_Nombre As Label
    Friend WithEvents Label_ISBN As Label
    Friend WithEvents MenuStripPagPrin As MenuStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_Eliminar As Button
    Friend WithEvents DataGridView_Socios As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GestiónLibrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónLibrosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GestiónArticulosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónArticulosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GestiónEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónEmpleadosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TextBox_Telefono As TextBox
    Friend WithEvents TextBox_NumeroSocioOCULTO As TextBox
    Friend WithEvents TextBox_Apellidos As TextBox
    Friend WithEvents TextBox_Nombre As TextBox
    Friend WithEvents TextBox_NumeroSocio As TextBox
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents InformeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarInformeToolStripMenuItem As ToolStripMenuItem
End Class
