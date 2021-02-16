<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_BusquedaArticulos = New System.Windows.Forms.Button()
        Me.btn_BusquedaLibros = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_BusquedaArticulos
        '
        Me.btn_BusquedaArticulos.Location = New System.Drawing.Point(13, 53)
        Me.btn_BusquedaArticulos.Name = "btn_BusquedaArticulos"
        Me.btn_BusquedaArticulos.Size = New System.Drawing.Size(100, 40)
        Me.btn_BusquedaArticulos.TabIndex = 38
        Me.btn_BusquedaArticulos.Text = "Busq. Articulos"
        Me.btn_BusquedaArticulos.UseVisualStyleBackColor = True
        '
        'btn_BusquedaLibros
        '
        Me.btn_BusquedaLibros.Location = New System.Drawing.Point(13, 7)
        Me.btn_BusquedaLibros.Name = "btn_BusquedaLibros"
        Me.btn_BusquedaLibros.Size = New System.Drawing.Size(100, 40)
        Me.btn_BusquedaLibros.TabIndex = 37
        Me.btn_BusquedaLibros.Text = "Busq. Libros"
        Me.btn_BusquedaLibros.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_BusquedaLibros)
        Me.Panel1.Controls.Add(Me.btn_BusquedaArticulos)
        Me.Panel1.Location = New System.Drawing.Point(100, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(130, 108)
        Me.Panel1.TabIndex = 39
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(345, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 41
        '
        'TextBox
        '
        Me.TextBox.Location = New System.Drawing.Point(345, 89)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(100, 20)
        Me.TextBox.TabIndex = 42
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(345, 115)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 43
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(345, 206)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 44
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(345, 232)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 45
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_BusquedaArticulos As Button
    Friend WithEvents btn_BusquedaLibros As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
End Class
