<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionArticulosAltas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionArticulosAltas))
        Me.MenuStripPagPrin = New System.Windows.Forms.MenuStrip()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerLaAyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button_Alta = New System.Windows.Forms.Button()
        Me.Button_Limpiar = New System.Windows.Forms.Button()
        Me.TextBox_Nombre = New System.Windows.Forms.TextBox()
        Me.TextBox_Categoria = New System.Windows.Forms.TextBox()
        Me.TextBox_Stock = New System.Windows.Forms.TextBox()
        Me.TextBox_Precio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ISBN = New System.Windows.Forms.Label()
        Me.TextBox_ISBN = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GruopBox = New System.Windows.Forms.GroupBox()
        Me.Button_Examinar = New System.Windows.Forms.Button()
        Me.PictureBoxProducto = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStripPagPrin.SuspendLayout()
        Me.GruopBox.SuspendLayout()
        CType(Me.PictureBoxProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem, Me.SalirToolStripMenuItem})
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
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
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
        Me.Button_Alta.Location = New System.Drawing.Point(476, 183)
        Me.Button_Alta.Name = "Button_Alta"
        Me.Button_Alta.Size = New System.Drawing.Size(86, 29)
        Me.Button_Alta.TabIndex = 180
        Me.Button_Alta.Text = "Alta"
        Me.Button_Alta.UseVisualStyleBackColor = True
        '
        'Button_Limpiar
        '
        Me.Button_Limpiar.Location = New System.Drawing.Point(568, 183)
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
        'TextBox_Categoria
        '
        Me.TextBox_Categoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Categoria.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Categoria.Location = New System.Drawing.Point(139, 92)
        Me.TextBox_Categoria.MaxLength = 50
        Me.TextBox_Categoria.Name = "TextBox_Categoria"
        Me.TextBox_Categoria.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Categoria.TabIndex = 3
        '
        'TextBox_Stock
        '
        Me.TextBox_Stock.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Stock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Stock.Location = New System.Drawing.Point(139, 142)
        Me.TextBox_Stock.MaxLength = 4
        Me.TextBox_Stock.Name = "TextBox_Stock"
        Me.TextBox_Stock.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Stock.TabIndex = 5
        '
        'TextBox_Precio
        '
        Me.TextBox_Precio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Precio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Precio.Location = New System.Drawing.Point(139, 117)
        Me.TextBox_Precio.MaxLength = 6
        Me.TextBox_Precio.Name = "TextBox_Precio"
        Me.TextBox_Precio.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Precio.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(60, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 157
        Me.Label5.Text = "Nombre :"
        '
        'ISBN
        '
        Me.ISBN.AutoSize = True
        Me.ISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBN.Location = New System.Drawing.Point(83, 36)
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
        Me.TextBox_ISBN.Location = New System.Drawing.Point(139, 33)
        Me.TextBox_ISBN.MaxLength = 13
        Me.TextBox_ISBN.Name = "TextBox_ISBN"
        Me.TextBox_ISBN.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_ISBN.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(51, 92)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(86, 20)
        Me.Label21.TabIndex = 151
        Me.Label21.Text = "Categoría :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(75, 141)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 20)
        Me.Label20.TabIndex = 152
        Me.Label20.Text = "Stock :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(72, 116)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 20)
        Me.Label19.TabIndex = 153
        Me.Label19.Tag = ""
        Me.Label19.Text = "Precio :"
        '
        'GruopBox
        '
        Me.GruopBox.Controls.Add(Me.Button_Examinar)
        Me.GruopBox.Controls.Add(Me.PictureBoxProducto)
        Me.GruopBox.Controls.Add(Me.Button_Alta)
        Me.GruopBox.Controls.Add(Me.Button_Limpiar)
        Me.GruopBox.Controls.Add(Me.TextBox_Nombre)
        Me.GruopBox.Controls.Add(Me.TextBox_Categoria)
        Me.GruopBox.Controls.Add(Me.TextBox_Stock)
        Me.GruopBox.Controls.Add(Me.TextBox_Precio)
        Me.GruopBox.Controls.Add(Me.Label5)
        Me.GruopBox.Controls.Add(Me.ISBN)
        Me.GruopBox.Controls.Add(Me.TextBox_ISBN)
        Me.GruopBox.Controls.Add(Me.Label21)
        Me.GruopBox.Controls.Add(Me.Label20)
        Me.GruopBox.Controls.Add(Me.Label19)
        Me.GruopBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GruopBox.ForeColor = System.Drawing.Color.Black
        Me.GruopBox.Location = New System.Drawing.Point(15, 16)
        Me.GruopBox.Name = "GruopBox"
        Me.GruopBox.Size = New System.Drawing.Size(700, 232)
        Me.GruopBox.TabIndex = 124
        Me.GruopBox.TabStop = False
        Me.GruopBox.Text = "Añadir/Modificar Artículo"
        '
        'Button_Examinar
        '
        Me.Button_Examinar.Location = New System.Drawing.Point(384, 183)
        Me.Button_Examinar.Name = "Button_Examinar"
        Me.Button_Examinar.Size = New System.Drawing.Size(86, 29)
        Me.Button_Examinar.TabIndex = 184
        Me.Button_Examinar.Text = "Examinar"
        Me.Button_Examinar.UseVisualStyleBackColor = True
        '
        'PictureBoxProducto
        '
        Me.PictureBoxProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxProducto.Location = New System.Drawing.Point(476, 33)
        Me.PictureBoxProducto.Name = "PictureBoxProducto"
        Me.PictureBoxProducto.Size = New System.Drawing.Size(136, 128)
        Me.PictureBoxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxProducto.TabIndex = 183
        Me.PictureBoxProducto.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GruopBox)
        Me.Panel2.Location = New System.Drawing.Point(12, 146)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(730, 264)
        Me.Panel2.TabIndex = 52
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Location = New System.Drawing.Point(0, 27)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(754, 94)
        Me.Panel3.TabIndex = 53
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(163, 92)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 39
        Me.PictureBox2.TabStop = False
        '
        'GestionArticulosAltas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(754, 422)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.MenuStripPagPrin)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionArticulosAltas"
        Me.Text = "Gestion de Articulos (Altas)"
        Me.MenuStripPagPrin.ResumeLayout(False)
        Me.MenuStripPagPrin.PerformLayout()
        Me.GruopBox.ResumeLayout(False)
        Me.GruopBox.PerformLayout()
        CType(Me.PictureBoxProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStripPagPrin As MenuStrip
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerLaAyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button_Alta As Button
    Friend WithEvents Button_Limpiar As Button
    Friend WithEvents TextBox_Nombre As TextBox
    Friend WithEvents TextBox_Categoria As TextBox
    Friend WithEvents TextBox_Stock As TextBox
    Friend WithEvents TextBox_Precio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ISBN As Label
    Friend WithEvents TextBox_ISBN As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents GruopBox As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBoxProducto As PictureBox
    Friend WithEvents Button_Examinar As Button
End Class
