﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionLibros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionLibros))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_Eliminar = New System.Windows.Forms.Button()
        Me.Button_Annadir = New System.Windows.Forms.Button()
        Me.DataGridView_Libros = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_Genero = New System.Windows.Forms.ComboBox()
        Me.TextBox_ISBN = New System.Windows.Forms.TextBox()
        Me.TextBox_ISBNOCULTO = New System.Windows.Forms.TextBox()
        Me.Label_Autor = New System.Windows.Forms.Label()
        Me.TextBox_Autor = New System.Windows.Forms.TextBox()
        Me.Button_Buscar = New System.Windows.Forms.Button()
        Me.Button_Limpiar = New System.Windows.Forms.Button()
        Me.Label_Genero = New System.Windows.Forms.Label()
        Me.TextBox_Titulo = New System.Windows.Forms.TextBox()
        Me.Label_Titulo = New System.Windows.Forms.Label()
        Me.Label_ISBN = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStripPagPrin = New System.Windows.Forms.MenuStrip()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónArticulosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónSociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónSociosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónEmpleadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerLaAyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarInformeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView_Libros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStripPagPrin.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button_Eliminar)
        Me.Panel1.Controls.Add(Me.Button_Annadir)
        Me.Panel1.Controls.Add(Me.DataGridView_Libros)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 127)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(959, 480)
        Me.Panel1.TabIndex = 53
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
        'Button_Annadir
        '
        Me.Button_Annadir.Location = New System.Drawing.Point(745, 160)
        Me.Button_Annadir.Name = "Button_Annadir"
        Me.Button_Annadir.Size = New System.Drawing.Size(86, 29)
        Me.Button_Annadir.TabIndex = 7
        Me.Button_Annadir.Text = "Añadir"
        Me.Button_Annadir.UseVisualStyleBackColor = True
        '
        'DataGridView_Libros
        '
        Me.DataGridView_Libros.AllowUserToAddRows = False
        Me.DataGridView_Libros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Libros.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView_Libros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Libros.Location = New System.Drawing.Point(3, 211)
        Me.DataGridView_Libros.Name = "DataGridView_Libros"
        Me.DataGridView_Libros.ReadOnly = True
        Me.DataGridView_Libros.Size = New System.Drawing.Size(938, 260)
        Me.DataGridView_Libros.TabIndex = 99
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Genero)
        Me.GroupBox1.Controls.Add(Me.TextBox_ISBN)
        Me.GroupBox1.Controls.Add(Me.TextBox_ISBNOCULTO)
        Me.GroupBox1.Controls.Add(Me.Label_Autor)
        Me.GroupBox1.Controls.Add(Me.TextBox_Autor)
        Me.GroupBox1.Controls.Add(Me.Button_Buscar)
        Me.GroupBox1.Controls.Add(Me.Button_Limpiar)
        Me.GroupBox1.Controls.Add(Me.Label_Genero)
        Me.GroupBox1.Controls.Add(Me.TextBox_Titulo)
        Me.GroupBox1.Controls.Add(Me.Label_Titulo)
        Me.GroupBox1.Controls.Add(Me.Label_ISBN)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(938, 127)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Busqueda"
        '
        'ComboBox_Genero
        '
        Me.ComboBox_Genero.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ComboBox_Genero.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ComboBox_Genero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_Genero.FormattingEnabled = True
        Me.ComboBox_Genero.Items.AddRange(New Object() {"Arte", "Ciencias", "Deportes y Juegos", "Filología", "Idiomas", "Juvenil", "Manialidades"})
        Me.ComboBox_Genero.Location = New System.Drawing.Point(723, 32)
        Me.ComboBox_Genero.Name = "ComboBox_Genero"
        Me.ComboBox_Genero.Size = New System.Drawing.Size(197, 21)
        Me.ComboBox_Genero.TabIndex = 182
        '
        'TextBox_ISBN
        '
        Me.TextBox_ISBN.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_ISBN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_ISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ISBN.Location = New System.Drawing.Point(71, 30)
        Me.TextBox_ISBN.MaxLength = 13
        Me.TextBox_ISBN.Name = "TextBox_ISBN"
        Me.TextBox_ISBN.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_ISBN.TabIndex = 1
        '
        'TextBox_ISBNOCULTO
        '
        Me.TextBox_ISBNOCULTO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_ISBNOCULTO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_ISBNOCULTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ISBNOCULTO.Location = New System.Drawing.Point(71, 30)
        Me.TextBox_ISBNOCULTO.MaxLength = 100
        Me.TextBox_ISBNOCULTO.Name = "TextBox_ISBNOCULTO"
        Me.TextBox_ISBNOCULTO.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_ISBNOCULTO.TabIndex = 100
        '
        'Label_Autor
        '
        Me.Label_Autor.AutoSize = True
        Me.Label_Autor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Autor.Location = New System.Drawing.Point(15, 84)
        Me.Label_Autor.Name = "Label_Autor"
        Me.Label_Autor.Size = New System.Drawing.Size(56, 20)
        Me.Label_Autor.TabIndex = 181
        Me.Label_Autor.Text = "Autor :"
        '
        'TextBox_Autor
        '
        Me.TextBox_Autor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Autor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Autor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Autor.Location = New System.Drawing.Point(71, 81)
        Me.TextBox_Autor.MaxLength = 50
        Me.TextBox_Autor.Name = "TextBox_Autor"
        Me.TextBox_Autor.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Autor.TabIndex = 4
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
        Me.Label_Genero.Location = New System.Drawing.Point(634, 29)
        Me.Label_Genero.Name = "Label_Genero"
        Me.Label_Genero.Size = New System.Drawing.Size(71, 20)
        Me.Label_Genero.TabIndex = 169
        Me.Label_Genero.Text = "Género :"
        '
        'TextBox_Titulo
        '
        Me.TextBox_Titulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Titulo.Location = New System.Drawing.Point(390, 26)
        Me.TextBox_Titulo.MaxLength = 100
        Me.TextBox_Titulo.Name = "TextBox_Titulo"
        Me.TextBox_Titulo.Size = New System.Drawing.Size(197, 19)
        Me.TextBox_Titulo.TabIndex = 2
        '
        'Label_Titulo
        '
        Me.Label_Titulo.AutoSize = True
        Me.Label_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Titulo.Location = New System.Drawing.Point(329, 29)
        Me.Label_Titulo.Name = "Label_Titulo"
        Me.Label_Titulo.Size = New System.Drawing.Size(55, 20)
        Me.Label_Titulo.TabIndex = 167
        Me.Label_Titulo.Text = "Título :"
        '
        'Label_ISBN
        '
        Me.Label_ISBN.AutoSize = True
        Me.Label_ISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ISBN.Location = New System.Drawing.Point(15, 29)
        Me.Label_ISBN.Name = "Label_ISBN"
        Me.Label_ISBN.Size = New System.Drawing.Size(55, 20)
        Me.Label_ISBN.TabIndex = 165
        Me.Label_ISBN.Text = "ISBN :"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(0, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(984, 94)
        Me.Panel2.TabIndex = 54
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
        'MenuStripPagPrin
        '
        Me.MenuStripPagPrin.BackColor = System.Drawing.Color.Transparent
        Me.MenuStripPagPrin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HerramientasToolStripMenuItem, Me.GestiónArticulosToolStripMenuItem, Me.GestiónSociosToolStripMenuItem, Me.GestiónEmpleadosToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.InformeToolStripMenuItem})
        Me.MenuStripPagPrin.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripPagPrin.Name = "MenuStripPagPrin"
        Me.MenuStripPagPrin.Size = New System.Drawing.Size(984, 24)
        Me.MenuStripPagPrin.TabIndex = 55
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
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.SalirToolStripMenuItem.Text = "Salir..."
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
        'InformeToolStripMenuItem
        '
        Me.InformeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarInformeToolStripMenuItem})
        Me.InformeToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
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
        'GestionLibros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 611)
        Me.Controls.Add(Me.MenuStripPagPrin)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionLibros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gestión de Libros"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView_Libros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStripPagPrin.ResumeLayout(False)
        Me.MenuStripPagPrin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_Eliminar As Button
    Friend WithEvents Button_Annadir As Button
    Friend WithEvents DataGridView_Libros As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button_Buscar As Button
    Friend WithEvents Button_Limpiar As Button
    Friend WithEvents Label_Genero As Label
    Friend WithEvents TextBox_Titulo As TextBox
    Friend WithEvents Label_Titulo As Label
    Friend WithEvents Label_ISBN As Label
    Friend WithEvents TextBox_ISBN As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label_Autor As Label
    Friend WithEvents TextBox_Autor As TextBox
    Friend WithEvents MenuStripPagPrin As MenuStrip
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónArticulosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónArticulosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GestiónSociosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónSociosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GestiónEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónEmpleadosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerLaAyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox_ISBNOCULTO As TextBox
    Friend WithEvents ComboBox_Genero As ComboBox
    Friend WithEvents InformeToolStripMenuItem As ToolStripMenuItem

    Friend WithEvents GenerarInformeToolStripMenuItem As ToolStripMenuItem


End Class
