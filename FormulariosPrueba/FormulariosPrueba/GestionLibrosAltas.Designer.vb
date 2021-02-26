<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionLibrosAltas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionLibrosAltas))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button_Examinar = New System.Windows.Forms.Button()
        Me.PictureBoxProducto = New System.Windows.Forms.PictureBox()
        Me.GruopBox = New System.Windows.Forms.GroupBox()
        Me.ComboBox_Genero = New System.Windows.Forms.ComboBox()
        Me.Label_Genero = New System.Windows.Forms.Label()
        Me.ComboBox_Formato = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Encuadernacion = New System.Windows.Forms.ComboBox()
        Me.Button_Alta = New System.Windows.Forms.Button()
        Me.Button_Limpiar = New System.Windows.Forms.Button()
        Me.TextBox_Precio = New System.Windows.Forms.TextBox()
        Me.TextBox_Stock = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_Traductor = New System.Windows.Forms.TextBox()
        Me.TextBox_Plazaedicion = New System.Windows.Forms.TextBox()
        Me.TextBox_Annoedicion = New System.Windows.Forms.TextBox()
        Me.TextBox_Titulo = New System.Windows.Forms.TextBox()
        Me.TextBox_Autor = New System.Windows.Forms.TextBox()
        Me.TextBox_Numeropags = New System.Windows.Forms.TextBox()
        Me.TextBox_Editorial = New System.Windows.Forms.TextBox()
        Me.TextBox_Idioma = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ISBN = New System.Windows.Forms.Label()
        Me.TextBox_ISBN = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.VerLaAyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlocNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripPagPrin = New System.Windows.Forms.MenuStrip()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBoxProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GruopBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuStripPagPrin.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button_Examinar)
        Me.Panel2.Controls.Add(Me.PictureBoxProducto)
        Me.Panel2.Controls.Add(Me.GruopBox)
        Me.Panel2.Location = New System.Drawing.Point(12, 136)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(730, 460)
        Me.Panel2.TabIndex = 46
        '
        'Button_Examinar
        '
        Me.Button_Examinar.Location = New System.Drawing.Point(325, 358)
        Me.Button_Examinar.Name = "Button_Examinar"
        Me.Button_Examinar.Size = New System.Drawing.Size(86, 29)
        Me.Button_Examinar.TabIndex = 186
        Me.Button_Examinar.Text = "Examinar"
        Me.Button_Examinar.UseVisualStyleBackColor = True
        '
        'PictureBoxProducto
        '
        Me.PictureBoxProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxProducto.Location = New System.Drawing.Point(168, 314)
        Me.PictureBoxProducto.Name = "PictureBoxProducto"
        Me.PictureBoxProducto.Size = New System.Drawing.Size(136, 128)
        Me.PictureBoxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxProducto.TabIndex = 185
        Me.PictureBoxProducto.TabStop = False
        '
        'GruopBox
        '
        Me.GruopBox.Controls.Add(Me.ComboBox_Genero)
        Me.GruopBox.Controls.Add(Me.Label_Genero)
        Me.GruopBox.Controls.Add(Me.ComboBox_Formato)
        Me.GruopBox.Controls.Add(Me.ComboBox_Encuadernacion)
        Me.GruopBox.Controls.Add(Me.Button_Alta)
        Me.GruopBox.Controls.Add(Me.Button_Limpiar)
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
        Me.GruopBox.Location = New System.Drawing.Point(14, 16)
        Me.GruopBox.Name = "GruopBox"
        Me.GruopBox.Size = New System.Drawing.Size(701, 292)
        Me.GruopBox.TabIndex = 124
        Me.GruopBox.TabStop = False
        Me.GruopBox.Text = "Gestión de artículos"
        '
        'ComboBox_Genero
        '
        Me.ComboBox_Genero.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ComboBox_Genero.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ComboBox_Genero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_Genero.FormattingEnabled = True
        Me.ComboBox_Genero.Items.AddRange(New Object() {"Arte", "Ciencias", "Deportes y Juegos", "Filología", "Idiomas", "Juvenil", "Manialidades"})
        Me.ComboBox_Genero.Location = New System.Drawing.Point(153, 117)
        Me.ComboBox_Genero.Name = "ComboBox_Genero"
        Me.ComboBox_Genero.Size = New System.Drawing.Size(197, 28)
        Me.ComboBox_Genero.TabIndex = 4
        '
        'Label_Genero
        '
        Me.Label_Genero.AutoSize = True
        Me.Label_Genero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Genero.Location = New System.Drawing.Point(77, 120)
        Me.Label_Genero.Name = "Label_Genero"
        Me.Label_Genero.Size = New System.Drawing.Size(71, 20)
        Me.Label_Genero.TabIndex = 183
        Me.Label_Genero.Text = "Género :"
        '
        'ComboBox_Formato
        '
        Me.ComboBox_Formato.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ComboBox_Formato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_Formato.FormattingEnabled = True
        Me.ComboBox_Formato.Items.AddRange(New Object() {"Libro", "Marketplace", "Ebook", "Producto Local"})
        Me.ComboBox_Formato.Location = New System.Drawing.Point(492, 120)
        Me.ComboBox_Formato.Name = "ComboBox_Formato"
        Me.ComboBox_Formato.Size = New System.Drawing.Size(197, 28)
        Me.ComboBox_Formato.TabIndex = 12
        '
        'ComboBox_Encuadernacion
        '
        Me.ComboBox_Encuadernacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ComboBox_Encuadernacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_Encuadernacion.FormattingEnabled = True
        Me.ComboBox_Encuadernacion.Items.AddRange(New Object() {"Tapa Blanda", "Tapa Dura", "Bolsillo", "Otros formatos"})
        Me.ComboBox_Encuadernacion.Location = New System.Drawing.Point(153, 236)
        Me.ComboBox_Encuadernacion.MaxDropDownItems = 10
        Me.ComboBox_Encuadernacion.Name = "ComboBox_Encuadernacion"
        Me.ComboBox_Encuadernacion.Size = New System.Drawing.Size(197, 28)
        Me.ComboBox_Encuadernacion.TabIndex = 8
        '
        'Button_Alta
        '
        Me.Button_Alta.Location = New System.Drawing.Point(506, 241)
        Me.Button_Alta.Name = "Button_Alta"
        Me.Button_Alta.Size = New System.Drawing.Size(86, 29)
        Me.Button_Alta.TabIndex = 15
        Me.Button_Alta.Text = "Alta"
        Me.Button_Alta.UseVisualStyleBackColor = True
        '
        'Button_Limpiar
        '
        Me.Button_Limpiar.Location = New System.Drawing.Point(598, 241)
        Me.Button_Limpiar.Name = "Button_Limpiar"
        Me.Button_Limpiar.Size = New System.Drawing.Size(86, 29)
        Me.Button_Limpiar.TabIndex = 176
        Me.Button_Limpiar.Text = "Limpiar"
        Me.Button_Limpiar.UseVisualStyleBackColor = True
        '
        'TextBox_Precio
        '
        Me.TextBox_Precio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Precio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Precio.Location = New System.Drawing.Point(492, 154)
        Me.TextBox_Precio.MaxLength = 6
        Me.TextBox_Precio.Name = "TextBox_Precio"
        Me.TextBox_Precio.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Precio.TabIndex = 13
        '
        'TextBox_Stock
        '
        Me.TextBox_Stock.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Stock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Stock.Location = New System.Drawing.Point(492, 183)
        Me.TextBox_Stock.MaxLength = 4
        Me.TextBox_Stock.Name = "TextBox_Stock"
        Me.TextBox_Stock.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Stock.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(427, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 20)
        Me.Label9.TabIndex = 172
        Me.Label9.Text = "Precio :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(411, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 20)
        Me.Label8.TabIndex = 171
        Me.Label8.Text = "Formato :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(432, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 20)
        Me.Label7.TabIndex = 170
        Me.Label7.Text = "Stock :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(402, 98)
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
        Me.TextBox_Traductor.Location = New System.Drawing.Point(492, 92)
        Me.TextBox_Traductor.MaxLength = 50
        Me.TextBox_Traductor.Name = "TextBox_Traductor"
        Me.TextBox_Traductor.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Traductor.TabIndex = 11
        '
        'TextBox_Plazaedicion
        '
        Me.TextBox_Plazaedicion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Plazaedicion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Plazaedicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Plazaedicion.Location = New System.Drawing.Point(492, 64)
        Me.TextBox_Plazaedicion.MaxLength = 50
        Me.TextBox_Plazaedicion.Name = "TextBox_Plazaedicion"
        Me.TextBox_Plazaedicion.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Plazaedicion.TabIndex = 10
        '
        'TextBox_Annoedicion
        '
        Me.TextBox_Annoedicion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Annoedicion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Annoedicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Annoedicion.Location = New System.Drawing.Point(492, 36)
        Me.TextBox_Annoedicion.MaxLength = 4
        Me.TextBox_Annoedicion.Name = "TextBox_Annoedicion"
        Me.TextBox_Annoedicion.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Annoedicion.TabIndex = 9
        '
        'TextBox_Titulo
        '
        Me.TextBox_Titulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Titulo.Location = New System.Drawing.Point(154, 67)
        Me.TextBox_Titulo.MaxLength = 100
        Me.TextBox_Titulo.Name = "TextBox_Titulo"
        Me.TextBox_Titulo.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Titulo.TabIndex = 2
        '
        'TextBox_Autor
        '
        Me.TextBox_Autor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Autor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Autor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Autor.Location = New System.Drawing.Point(154, 95)
        Me.TextBox_Autor.MaxLength = 50
        Me.TextBox_Autor.Name = "TextBox_Autor"
        Me.TextBox_Autor.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Autor.TabIndex = 3
        '
        'TextBox_Numeropags
        '
        Me.TextBox_Numeropags.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Numeropags.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Numeropags.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Numeropags.Location = New System.Drawing.Point(153, 152)
        Me.TextBox_Numeropags.MaxLength = 4
        Me.TextBox_Numeropags.Name = "TextBox_Numeropags"
        Me.TextBox_Numeropags.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Numeropags.TabIndex = 5
        '
        'TextBox_Editorial
        '
        Me.TextBox_Editorial.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Editorial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Editorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Editorial.Location = New System.Drawing.Point(153, 180)
        Me.TextBox_Editorial.MaxLength = 50
        Me.TextBox_Editorial.Name = "TextBox_Editorial"
        Me.TextBox_Editorial.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Editorial.TabIndex = 6
        '
        'TextBox_Idioma
        '
        Me.TextBox_Idioma.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Idioma.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Idioma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Idioma.Location = New System.Drawing.Point(153, 208)
        Me.TextBox_Idioma.MaxLength = 50
        Me.TextBox_Idioma.Name = "TextBox_Idioma"
        Me.TextBox_Idioma.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Idioma.TabIndex = 7
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(83, 207)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(65, 20)
        Me.Label24.TabIndex = 158
        Me.Label24.Text = "Idioma :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(93, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 157
        Me.Label5.Text = "Título :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(367, 39)
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
        Me.Label2.Location = New System.Drawing.Point(359, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 20)
        Me.Label2.TabIndex = 156
        Me.Label2.Text = "Plaza de Edición :"
        '
        'ISBN
        '
        Me.ISBN.AutoSize = True
        Me.ISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBN.Location = New System.Drawing.Point(93, 35)
        Me.ISBN.Name = "ISBN"
        Me.ISBN.Size = New System.Drawing.Size(55, 20)
        Me.ISBN.TabIndex = 149
        Me.ISBN.Text = "ISBN :"
        '
        'TextBox_ISBN
        '
        Me.TextBox_ISBN.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_ISBN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_ISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ISBN.Location = New System.Drawing.Point(154, 36)
        Me.TextBox_ISBN.MaxLength = 13
        Me.TextBox_ISBN.Name = "TextBox_ISBN"
        Me.TextBox_ISBN.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_ISBN.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(66, 91)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(82, 20)
        Me.Label21.TabIndex = 151
        Me.Label21.Text = "Autor/res :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(54, 151)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(95, 20)
        Me.Label20.TabIndex = 152
        Me.Label20.Text = "Nº Páginas :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(74, 179)
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
        Me.Label6.Location = New System.Drawing.Point(14, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 20)
        Me.Label6.TabIndex = 154
        Me.Label6.Text = "Encuadernación :"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(754, 108)
        Me.Panel1.TabIndex = 45
        '
        'VerLaAyudaToolStripMenuItem
        '
        Me.VerLaAyudaToolStripMenuItem.Image = CType(resources.GetObject("VerLaAyudaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VerLaAyudaToolStripMenuItem.Name = "VerLaAyudaToolStripMenuItem"
        Me.VerLaAyudaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.VerLaAyudaToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.VerLaAyudaToolStripMenuItem.Text = "Ver la Ayuda"
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
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Image = CType(resources.GetObject("CalculadoraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem, Me.BlocNotasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'MenuStripPagPrin
        '
        Me.MenuStripPagPrin.BackColor = System.Drawing.Color.Transparent
        Me.MenuStripPagPrin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HerramientasToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStripPagPrin.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripPagPrin.Name = "MenuStripPagPrin"
        Me.MenuStripPagPrin.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStripPagPrin.Size = New System.Drawing.Size(754, 24)
        Me.MenuStripPagPrin.TabIndex = 44
        Me.MenuStripPagPrin.TabStop = True
        Me.MenuStripPagPrin.Text = "MenuStrip1"
        '
        'GestionLibrosAltas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(754, 614)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStripPagPrin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionLibrosAltas"
        Me.Text = "Gestión de Libros (Altas)"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBoxProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GruopBox.ResumeLayout(False)
        Me.GruopBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.MenuStripPagPrin.ResumeLayout(False)
        Me.MenuStripPagPrin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents GruopBox As GroupBox
    Friend WithEvents Button_Alta As Button
    Friend WithEvents Button_Limpiar As Button
    Friend WithEvents TextBox_Precio As TextBox
    Friend WithEvents TextBox_Stock As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_Traductor As TextBox
    Friend WithEvents TextBox_Plazaedicion As TextBox
    Friend WithEvents TextBox_Annoedicion As TextBox
    Friend WithEvents TextBox_Titulo As TextBox
    Friend WithEvents TextBox_Autor As TextBox
    Friend WithEvents TextBox_Numeropags As TextBox
    Friend WithEvents TextBox_Editorial As TextBox
    Friend WithEvents TextBox_Idioma As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ISBN As Label
    Friend WithEvents TextBox_ISBN As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents VerLaAyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlocNotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStripPagPrin As MenuStrip
    Friend WithEvents ComboBox_Encuadernacion As ComboBox
    Friend WithEvents ComboBox_Formato As ComboBox
    Friend WithEvents Button_Examinar As Button
    Friend WithEvents PictureBoxProducto As PictureBox
    Friend WithEvents ComboBox_Genero As ComboBox
    Friend WithEvents Label_Genero As Label
End Class
