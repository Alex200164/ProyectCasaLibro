<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionLibrosModificaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionLibrosModificaciones))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.VerLaAyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button_Modificar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox_Precio = New System.Windows.Forms.TextBox()
        Me.TextBox_Stock = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_Traductor = New System.Windows.Forms.TextBox()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlocNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox_Plazaedicion = New System.Windows.Forms.TextBox()
        Me.TextBox_Annoedicion = New System.Windows.Forms.TextBox()
        Me.TextBox_Titulo = New System.Windows.Forms.TextBox()
        Me.TextBox_Numeropags = New System.Windows.Forms.TextBox()
        Me.TextBox_Editorial = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox_Autor = New System.Windows.Forms.TextBox()
        Me.MenuStripPagPrin = New System.Windows.Forms.MenuStrip()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox_Idioma = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ISBN = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GruopBox = New System.Windows.Forms.GroupBox()
        Me.Button_Examinar = New System.Windows.Forms.Button()
        Me.ComboBox_Formato = New System.Windows.Forms.ComboBox()
        Me.PictureBoxProducto = New System.Windows.Forms.PictureBox()
        Me.ComboBox_Encuadernacion = New System.Windows.Forms.ComboBox()
        Me.TextBox_ISBN = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ComboBox_Genero = New System.Windows.Forms.ComboBox()
        Me.Label_Genero = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuStripPagPrin.SuspendLayout()
        Me.GruopBox.SuspendLayout()
        CType(Me.PictureBoxProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        'VerLaAyudaToolStripMenuItem
        '
        Me.VerLaAyudaToolStripMenuItem.Image = CType(resources.GetObject("VerLaAyudaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VerLaAyudaToolStripMenuItem.Name = "VerLaAyudaToolStripMenuItem"
        Me.VerLaAyudaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.VerLaAyudaToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.VerLaAyudaToolStripMenuItem.Text = "Ver la Ayuda"
        '
        'Button_Modificar
        '
        Me.Button_Modificar.Location = New System.Drawing.Point(503, 316)
        Me.Button_Modificar.Name = "Button_Modificar"
        Me.Button_Modificar.Size = New System.Drawing.Size(86, 29)
        Me.Button_Modificar.TabIndex = 178
        Me.Button_Modificar.Text = "Modificar"
        Me.Button_Modificar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(595, 316)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 29)
        Me.Button1.TabIndex = 176
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox_Precio
        '
        Me.TextBox_Precio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Precio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Precio.Location = New System.Drawing.Point(495, 191)
        Me.TextBox_Precio.MaxLength = 6
        Me.TextBox_Precio.Name = "TextBox_Precio"
        Me.TextBox_Precio.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Precio.TabIndex = 12
        '
        'TextBox_Stock
        '
        Me.TextBox_Stock.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Stock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Stock.Location = New System.Drawing.Point(495, 222)
        Me.TextBox_Stock.MaxLength = 4
        Me.TextBox_Stock.Name = "TextBox_Stock"
        Me.TextBox_Stock.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Stock.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(430, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 20)
        Me.Label9.TabIndex = 172
        Me.Label9.Text = "Precio :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(412, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 20)
        Me.Label8.TabIndex = 171
        Me.Label8.Text = "Formato :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(432, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 20)
        Me.Label7.TabIndex = 170
        Me.Label7.Text = "Stock :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(405, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 20)
        Me.Label3.TabIndex = 169
        Me.Label3.Text = "Traductor :"
        '
        'TextBox_Traductor
        '
        Me.TextBox_Traductor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Traductor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Traductor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Traductor.Location = New System.Drawing.Point(495, 120)
        Me.TextBox_Traductor.MaxLength = 50
        Me.TextBox_Traductor.Name = "TextBox_Traductor"
        Me.TextBox_Traductor.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Traductor.TabIndex = 10
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerLaAyudaToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.SalirToolStripMenuItem.Text = "Salir..."
        '
        'BlocNotasToolStripMenuItem
        '
        Me.BlocNotasToolStripMenuItem.Image = CType(resources.GetObject("BlocNotasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BlocNotasToolStripMenuItem.Name = "BlocNotasToolStripMenuItem"
        Me.BlocNotasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.BlocNotasToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.BlocNotasToolStripMenuItem.Text = "Bloc Notas"
        '
        'TextBox_Plazaedicion
        '
        Me.TextBox_Plazaedicion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Plazaedicion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Plazaedicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Plazaedicion.Location = New System.Drawing.Point(495, 92)
        Me.TextBox_Plazaedicion.MaxLength = 50
        Me.TextBox_Plazaedicion.Name = "TextBox_Plazaedicion"
        Me.TextBox_Plazaedicion.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Plazaedicion.TabIndex = 9
        '
        'TextBox_Annoedicion
        '
        Me.TextBox_Annoedicion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Annoedicion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Annoedicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Annoedicion.Location = New System.Drawing.Point(495, 64)
        Me.TextBox_Annoedicion.MaxLength = 4
        Me.TextBox_Annoedicion.Name = "TextBox_Annoedicion"
        Me.TextBox_Annoedicion.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Annoedicion.TabIndex = 8
        '
        'TextBox_Titulo
        '
        Me.TextBox_Titulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Titulo.Location = New System.Drawing.Point(136, 66)
        Me.TextBox_Titulo.MaxLength = 100
        Me.TextBox_Titulo.Name = "TextBox_Titulo"
        Me.TextBox_Titulo.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Titulo.TabIndex = 2
        '
        'TextBox_Numeropags
        '
        Me.TextBox_Numeropags.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Numeropags.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Numeropags.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Numeropags.Location = New System.Drawing.Point(147, 158)
        Me.TextBox_Numeropags.MaxLength = 4
        Me.TextBox_Numeropags.Name = "TextBox_Numeropags"
        Me.TextBox_Numeropags.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Numeropags.TabIndex = 4
        '
        'TextBox_Editorial
        '
        Me.TextBox_Editorial.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Editorial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Editorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Editorial.Location = New System.Drawing.Point(147, 186)
        Me.TextBox_Editorial.MaxLength = 50
        Me.TextBox_Editorial.Name = "TextBox_Editorial"
        Me.TextBox_Editorial.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Editorial.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(754, 108)
        Me.Panel1.TabIndex = 48
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Image = CType(resources.GetObject("CalculadoraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'TextBox_Autor
        '
        Me.TextBox_Autor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Autor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Autor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Autor.Location = New System.Drawing.Point(136, 94)
        Me.TextBox_Autor.MaxLength = 50
        Me.TextBox_Autor.Name = "TextBox_Autor"
        Me.TextBox_Autor.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Autor.TabIndex = 3
        '
        'MenuStripPagPrin
        '
        Me.MenuStripPagPrin.BackColor = System.Drawing.Color.Transparent
        Me.MenuStripPagPrin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HerramientasToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStripPagPrin.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripPagPrin.Name = "MenuStripPagPrin"
        Me.MenuStripPagPrin.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStripPagPrin.Size = New System.Drawing.Size(754, 24)
        Me.MenuStripPagPrin.TabIndex = 47
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
        'TextBox_Idioma
        '
        Me.TextBox_Idioma.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Idioma.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Idioma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Idioma.Location = New System.Drawing.Point(147, 214)
        Me.TextBox_Idioma.MaxLength = 50
        Me.TextBox_Idioma.Name = "TextBox_Idioma"
        Me.TextBox_Idioma.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Idioma.TabIndex = 6
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(71, 217)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(65, 20)
        Me.Label24.TabIndex = 158
        Me.Label24.Text = "Idioma :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(69, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 157
        Me.Label5.Text = "Título :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(370, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 155
        Me.Label1.Tag = ""
        Me.Label1.Text = "Año de Edición :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(362, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 20)
        Me.Label2.TabIndex = 156
        Me.Label2.Text = "Plaza de Edición :"
        '
        'ISBN
        '
        Me.ISBN.AutoSize = True
        Me.ISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBN.Location = New System.Drawing.Point(71, 35)
        Me.ISBN.Name = "ISBN"
        Me.ISBN.Size = New System.Drawing.Size(55, 20)
        Me.ISBN.TabIndex = 149
        Me.ISBN.Text = "ISBN :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(42, 94)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(82, 20)
        Me.Label21.TabIndex = 151
        Me.Label21.Text = "Autor/res :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(42, 161)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(95, 20)
        Me.Label20.TabIndex = 152
        Me.Label20.Text = "Nº Páginas :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(62, 189)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(74, 20)
        Me.Label19.TabIndex = 153
        Me.Label19.Tag = ""
        Me.Label19.Text = "Editorial :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(356, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 20)
        Me.Label6.TabIndex = 154
        Me.Label6.Text = "Encuadernación :"
        '
        'GruopBox
        '
        Me.GruopBox.Controls.Add(Me.ComboBox_Genero)
        Me.GruopBox.Controls.Add(Me.Label_Genero)
        Me.GruopBox.Controls.Add(Me.Button_Examinar)
        Me.GruopBox.Controls.Add(Me.ComboBox_Formato)
        Me.GruopBox.Controls.Add(Me.PictureBoxProducto)
        Me.GruopBox.Controls.Add(Me.ComboBox_Encuadernacion)
        Me.GruopBox.Controls.Add(Me.Button_Modificar)
        Me.GruopBox.Controls.Add(Me.Button1)
        Me.GruopBox.Controls.Add(Me.TextBox_Precio)
        Me.GruopBox.Controls.Add(Me.TextBox_Stock)
        Me.GruopBox.Controls.Add(Me.Label9)
        Me.GruopBox.Controls.Add(Me.Label8)
        Me.GruopBox.Controls.Add(Me.Label7)
        Me.GruopBox.Controls.Add(Me.Label3)
        Me.GruopBox.Controls.Add(Me.TextBox_Traductor)
        Me.GruopBox.Controls.Add(Me.TextBox_Plazaedicion)
        Me.GruopBox.Controls.Add(Me.TextBox_Annoedicion)
        Me.GruopBox.Controls.Add(Me.TextBox_Titulo)
        Me.GruopBox.Controls.Add(Me.TextBox_Autor)
        Me.GruopBox.Controls.Add(Me.TextBox_Numeropags)
        Me.GruopBox.Controls.Add(Me.TextBox_Editorial)
        Me.GruopBox.Controls.Add(Me.TextBox_Idioma)
        Me.GruopBox.Controls.Add(Me.Label24)
        Me.GruopBox.Controls.Add(Me.Label5)
        Me.GruopBox.Controls.Add(Me.Label1)
        Me.GruopBox.Controls.Add(Me.Label2)
        Me.GruopBox.Controls.Add(Me.ISBN)
        Me.GruopBox.Controls.Add(Me.TextBox_ISBN)
        Me.GruopBox.Controls.Add(Me.Label21)
        Me.GruopBox.Controls.Add(Me.Label20)
        Me.GruopBox.Controls.Add(Me.Label19)
        Me.GruopBox.Controls.Add(Me.Label6)
        Me.GruopBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GruopBox.ForeColor = System.Drawing.Color.Black
        Me.GruopBox.Location = New System.Drawing.Point(15, 16)
        Me.GruopBox.Name = "GruopBox"
        Me.GruopBox.Size = New System.Drawing.Size(700, 415)
        Me.GruopBox.TabIndex = 124
        Me.GruopBox.TabStop = False
        Me.GruopBox.Text = "Gestión de artículos"
        '
        'Button_Examinar
        '
        Me.Button_Examinar.Location = New System.Drawing.Point(172, 380)
        Me.Button_Examinar.Name = "Button_Examinar"
        Me.Button_Examinar.Size = New System.Drawing.Size(86, 29)
        Me.Button_Examinar.TabIndex = 188
        Me.Button_Examinar.Text = "Examinar"
        Me.Button_Examinar.UseVisualStyleBackColor = True
        '
        'ComboBox_Formato
        '
        Me.ComboBox_Formato.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ComboBox_Formato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_Formato.FormattingEnabled = True
        Me.ComboBox_Formato.Items.AddRange(New Object() {"Libro", "Marketplace", "Ebook", "Producto Local"})
        Me.ComboBox_Formato.Location = New System.Drawing.Point(495, 151)
        Me.ComboBox_Formato.Name = "ComboBox_Formato"
        Me.ComboBox_Formato.Size = New System.Drawing.Size(197, 28)
        Me.ComboBox_Formato.TabIndex = 180
        '
        'PictureBoxProducto
        '
        Me.PictureBoxProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxProducto.Location = New System.Drawing.Point(14, 281)
        Me.PictureBoxProducto.Name = "PictureBoxProducto"
        Me.PictureBoxProducto.Size = New System.Drawing.Size(136, 128)
        Me.PictureBoxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxProducto.TabIndex = 187
        Me.PictureBoxProducto.TabStop = False
        '
        'ComboBox_Encuadernacion
        '
        Me.ComboBox_Encuadernacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ComboBox_Encuadernacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_Encuadernacion.FormattingEnabled = True
        Me.ComboBox_Encuadernacion.Items.AddRange(New Object() {"Tapa Blanda", "Tapa Dura", "Bolsillo", "Otros formatos"})
        Me.ComboBox_Encuadernacion.Location = New System.Drawing.Point(501, 32)
        Me.ComboBox_Encuadernacion.Name = "ComboBox_Encuadernacion"
        Me.ComboBox_Encuadernacion.Size = New System.Drawing.Size(197, 28)
        Me.ComboBox_Encuadernacion.TabIndex = 179
        '
        'TextBox_ISBN
        '
        Me.TextBox_ISBN.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_ISBN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_ISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ISBN.Location = New System.Drawing.Point(136, 35)
        Me.TextBox_ISBN.MaxLength = 13
        Me.TextBox_ISBN.Name = "TextBox_ISBN"
        Me.TextBox_ISBN.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_ISBN.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GruopBox)
        Me.Panel2.Location = New System.Drawing.Point(12, 136)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(730, 445)
        Me.Panel2.TabIndex = 49
        '
        'ComboBox_Genero
        '
        Me.ComboBox_Genero.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ComboBox_Genero.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ComboBox_Genero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_Genero.FormattingEnabled = True
        Me.ComboBox_Genero.Items.AddRange(New Object() {"Arte", "Ciencias", "Deportes y Juegos", "Filología", "Idiomas", "Juvenil", "Manialidades"})
        Me.ComboBox_Genero.Location = New System.Drawing.Point(139, 119)
        Me.ComboBox_Genero.Name = "ComboBox_Genero"
        Me.ComboBox_Genero.Size = New System.Drawing.Size(197, 28)
        Me.ComboBox_Genero.TabIndex = 190
        '
        'Label_Genero
        '
        Me.Label_Genero.AutoSize = True
        Me.Label_Genero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Genero.Location = New System.Drawing.Point(62, 122)
        Me.Label_Genero.Name = "Label_Genero"
        Me.Label_Genero.Size = New System.Drawing.Size(71, 20)
        Me.Label_Genero.TabIndex = 189
        Me.Label_Genero.Text = "Género :"
        '
        'GestionLibrosModificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(754, 593)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStripPagPrin)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionLibrosModificaciones"
        Me.Text = "Gestión de Libros (Modificaciones)"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.MenuStripPagPrin.ResumeLayout(False)
        Me.MenuStripPagPrin.PerformLayout()
        Me.GruopBox.ResumeLayout(False)
        Me.GruopBox.PerformLayout()
        CType(Me.PictureBoxProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents VerLaAyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button_Modificar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox_Precio As TextBox
    Friend WithEvents TextBox_Stock As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_Traductor As TextBox
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlocNotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox_Plazaedicion As TextBox
    Friend WithEvents TextBox_Annoedicion As TextBox
    Friend WithEvents TextBox_Titulo As TextBox
    Friend WithEvents TextBox_Numeropags As TextBox
    Friend WithEvents TextBox_Editorial As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox_Autor As TextBox
    Friend WithEvents MenuStripPagPrin As MenuStrip
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox_Idioma As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ISBN As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GruopBox As GroupBox
    Friend WithEvents TextBox_ISBN As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ComboBox_Encuadernacion As ComboBox
    Friend WithEvents ComboBox_Formato As ComboBox
    Friend WithEvents Button_Examinar As Button
    Friend WithEvents PictureBoxProducto As PictureBox
    Friend WithEvents ComboBox_Genero As ComboBox
    Friend WithEvents Label_Genero As Label
End Class
