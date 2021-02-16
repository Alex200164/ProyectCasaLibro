<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InicioSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InicioSesion))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox_Contraseña = New System.Windows.Forms.TextBox()
        Me.TextBox_Usuario = New System.Windows.Forms.TextBox()
        Me.Label_Contraseña = New System.Windows.Forms.Label()
        Me.Label_Usuario = New System.Windows.Forms.Label()
        Me.LinkLabel_Contacto = New System.Windows.Forms.LinkLabel()
        Me.PictureBox_Logo = New System.Windows.Forms.PictureBox()
        Me.Button_Salir = New System.Windows.Forms.Button()
        Me.Button_InicioSesion = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox_Contraseña)
        Me.Panel1.Controls.Add(Me.TextBox_Usuario)
        Me.Panel1.Controls.Add(Me.Label_Contraseña)
        Me.Panel1.Controls.Add(Me.Label_Usuario)
        Me.Panel1.Location = New System.Drawing.Point(201, 333)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(294, 199)
        Me.Panel1.TabIndex = 32
        '
        'TextBox_Contraseña
        '
        Me.TextBox_Contraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Contraseña.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Contraseña.Location = New System.Drawing.Point(43, 147)
        Me.TextBox_Contraseña.MaxLength = 100
        Me.TextBox_Contraseña.Name = "TextBox_Contraseña"
        Me.TextBox_Contraseña.Size = New System.Drawing.Size(197, 22)
        Me.TextBox_Contraseña.TabIndex = 2
        '
        'TextBox_Usuario
        '
        Me.TextBox_Usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Usuario.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Usuario.Location = New System.Drawing.Point(43, 59)
        Me.TextBox_Usuario.MaxLength = 100
        Me.TextBox_Usuario.Name = "TextBox_Usuario"
        Me.TextBox_Usuario.Size = New System.Drawing.Size(197, 22)
        Me.TextBox_Usuario.TabIndex = 1
        '
        'Label_Contraseña
        '
        Me.Label_Contraseña.AutoSize = True
        Me.Label_Contraseña.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Contraseña.Location = New System.Drawing.Point(38, 102)
        Me.Label_Contraseña.Name = "Label_Contraseña"
        Me.Label_Contraseña.Size = New System.Drawing.Size(123, 30)
        Me.Label_Contraseña.TabIndex = 11
        Me.Label_Contraseña.Text = "Contraseña:"
        '
        'Label_Usuario
        '
        Me.Label_Usuario.AutoSize = True
        Me.Label_Usuario.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Usuario.Location = New System.Drawing.Point(38, 19)
        Me.Label_Usuario.Name = "Label_Usuario"
        Me.Label_Usuario.Size = New System.Drawing.Size(88, 30)
        Me.Label_Usuario.TabIndex = 10
        Me.Label_Usuario.Text = "Usuario:"
        '
        'LinkLabel_Contacto
        '
        Me.LinkLabel_Contacto.AutoSize = True
        Me.LinkLabel_Contacto.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Contacto.LinkColor = System.Drawing.Color.LightBlue
        Me.LinkLabel_Contacto.Location = New System.Drawing.Point(576, 607)
        Me.LinkLabel_Contacto.Name = "LinkLabel_Contacto"
        Me.LinkLabel_Contacto.Size = New System.Drawing.Size(97, 30)
        Me.LinkLabel_Contacto.TabIndex = 31
        Me.LinkLabel_Contacto.TabStop = True
        Me.LinkLabel_Contacto.Text = "Contacto"
        '
        'PictureBox_Logo
        '
        Me.PictureBox_Logo.Image = CType(resources.GetObject("PictureBox_Logo.Image"), System.Drawing.Image)
        Me.PictureBox_Logo.Location = New System.Drawing.Point(98, 32)
        Me.PictureBox_Logo.Name = "PictureBox_Logo"
        Me.PictureBox_Logo.Size = New System.Drawing.Size(466, 295)
        Me.PictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Logo.TabIndex = 30
        Me.PictureBox_Logo.TabStop = False
        '
        'Button_Salir
        '
        Me.Button_Salir.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Salir.Location = New System.Drawing.Point(351, 566)
        Me.Button_Salir.Name = "Button_Salir"
        Me.Button_Salir.Size = New System.Drawing.Size(144, 47)
        Me.Button_Salir.TabIndex = 35
        Me.Button_Salir.Text = "Salir"
        Me.Button_Salir.UseVisualStyleBackColor = True
        '
        'Button_InicioSesion
        '
        Me.Button_InicioSesion.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_InicioSesion.Location = New System.Drawing.Point(201, 566)
        Me.Button_InicioSesion.Name = "Button_InicioSesion"
        Me.Button_InicioSesion.Size = New System.Drawing.Size(144, 47)
        Me.Button_InicioSesion.TabIndex = 33
        Me.Button_InicioSesion.Text = "Iniciar sesión"
        Me.Button_InicioSesion.UseVisualStyleBackColor = True
        '
        'InicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(684, 661)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LinkLabel_Contacto)
        Me.Controls.Add(Me.PictureBox_Logo)
        Me.Controls.Add(Me.Button_Salir)
        Me.Controls.Add(Me.Button_InicioSesion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InicioSesion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox_Contraseña As TextBox
    Friend WithEvents TextBox_Usuario As TextBox
    Friend WithEvents Label_Contraseña As Label
    Friend WithEvents Label_Usuario As Label
    Friend WithEvents LinkLabel_Contacto As LinkLabel
    Friend WithEvents PictureBox_Logo As PictureBox
    Friend WithEvents Button_Salir As Button
    Friend WithEvents Button_InicioSesion As Button
End Class
