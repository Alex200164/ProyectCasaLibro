<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.Button_GestionLibros = New System.Windows.Forms.Button()
        Me.Button_GestionPapeleria = New System.Windows.Forms.Button()
        Me.Button_GestionSocios = New System.Windows.Forms.Button()
        Me.Button_GestionEmpleados = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button_CerrarSesion = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NotifyIcon_Bienvenida = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        'Button_GestionLibros
        '
        Me.Button_GestionLibros.BackgroundImage = Global.FormulariosPrueba.My.Resources.Resources.books_4
        Me.Button_GestionLibros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_GestionLibros.ImageIndex = 0
        Me.Button_GestionLibros.Location = New System.Drawing.Point(134, 66)
        Me.Button_GestionLibros.Name = "Button_GestionLibros"
        Me.Button_GestionLibros.Size = New System.Drawing.Size(299, 200)
        Me.Button_GestionLibros.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Button_GestionLibros, "Gestión Libros")
        Me.Button_GestionLibros.UseVisualStyleBackColor = True
        '
        'Button_GestionPapeleria
        '
        Me.Button_GestionPapeleria.BackgroundImage = Global.FormulariosPrueba.My.Resources.Resources.papel_1
        Me.Button_GestionPapeleria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_GestionPapeleria.Location = New System.Drawing.Point(523, 66)
        Me.Button_GestionPapeleria.Name = "Button_GestionPapeleria"
        Me.Button_GestionPapeleria.Size = New System.Drawing.Size(300, 200)
        Me.Button_GestionPapeleria.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Button_GestionPapeleria, "Gestión Articulos")
        Me.Button_GestionPapeleria.UseVisualStyleBackColor = True
        '
        'Button_GestionSocios
        '
        Me.Button_GestionSocios.BackgroundImage = Global.FormulariosPrueba.My.Resources.Resources.socios2
        Me.Button_GestionSocios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_GestionSocios.Location = New System.Drawing.Point(133, 314)
        Me.Button_GestionSocios.Name = "Button_GestionSocios"
        Me.Button_GestionSocios.Size = New System.Drawing.Size(300, 200)
        Me.Button_GestionSocios.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Button_GestionSocios, "Gestión Socios")
        Me.Button_GestionSocios.UseVisualStyleBackColor = True
        '
        'Button_GestionEmpleados
        '
        Me.Button_GestionEmpleados.BackgroundImage = Global.FormulariosPrueba.My.Resources.Resources.empleados1
        Me.Button_GestionEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_GestionEmpleados.Location = New System.Drawing.Point(523, 314)
        Me.Button_GestionEmpleados.Name = "Button_GestionEmpleados"
        Me.Button_GestionEmpleados.Size = New System.Drawing.Size(300, 200)
        Me.Button_GestionEmpleados.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Button_GestionEmpleados, "Gestión Empleados")
        Me.Button_GestionEmpleados.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "books-4.jpg")
        Me.ImageList1.Images.SetKeyName(1, "empleados1.png")
        Me.ImageList1.Images.SetKeyName(2, "logo.jpg")
        Me.ImageList1.Images.SetKeyName(3, "papel-1.jpg")
        Me.ImageList1.Images.SetKeyName(4, "socios2.jpg")
        '
        'Button_CerrarSesion
        '
        Me.Button_CerrarSesion.Location = New System.Drawing.Point(354, 547)
        Me.Button_CerrarSesion.Name = "Button_CerrarSesion"
        Me.Button_CerrarSesion.Size = New System.Drawing.Size(259, 52)
        Me.Button_CerrarSesion.TabIndex = 4
        Me.Button_CerrarSesion.Text = "CERRAR SESIÓN"
        Me.Button_CerrarSesion.UseVisualStyleBackColor = True
        '
        'NotifyIcon_Bienvenida
        '
        Me.NotifyIcon_Bienvenida.BalloonTipText = "Bienvenido"
        Me.NotifyIcon_Bienvenida.BalloonTipTitle = "A la casa del libro"
        Me.NotifyIcon_Bienvenida.Icon = CType(resources.GetObject("NotifyIcon_Bienvenida.Icon"), System.Drawing.Icon)
        Me.NotifyIcon_Bienvenida.Text = "NotifyIcon1"
        Me.NotifyIcon_Bienvenida.Visible = True
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 611)
        Me.Controls.Add(Me.Button_CerrarSesion)
        Me.Controls.Add(Me.Button_GestionEmpleados)
        Me.Controls.Add(Me.Button_GestionSocios)
        Me.Controls.Add(Me.Button_GestionPapeleria)
        Me.Controls.Add(Me.Button_GestionLibros)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_GestionLibros As Button
    Friend WithEvents Button_GestionPapeleria As Button
    Friend WithEvents Button_GestionSocios As Button
    Friend WithEvents Button_GestionEmpleados As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Button_CerrarSesion As Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents NotifyIcon_Bienvenida As NotifyIcon
End Class
