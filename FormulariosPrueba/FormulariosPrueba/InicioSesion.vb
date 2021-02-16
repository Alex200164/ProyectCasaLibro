Public Class InicioSesion
    Private Sub InicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Tenemos que cargar las conexiones a las tanto a la base de datos como a la libreria.
        inicializarPantalla()
    End Sub

    'Método que se encargará de inicializar todos los componenetes de la pantalla.
    'Además de establecer las preferencias de algunos componentes del formulario 
    'NOTA: ***COMENTAR CON ALEX***
    Private Sub inicializarPantalla()
        'Inicializamos las preferencias de este formulario
        Me.BackColor = Color.FromArgb(3, 76, 56)
        'O bien dejamos el botón de close
        ' Me.MaximizeBox = False
        'Me.MinimizeBox = False

        'O bien quitamos la caja de los botnoes min, max y close
        Me.ControlBox = False
    End Sub

    'Método que limpia los Textbox
    Private Sub limpiarPantalla()
        TextBox_Contraseña.Clear()
        TextBox_Usuario.Clear()
    End Sub

    'Evento del botón salir que nos confirmará el cierre de la aplicación
    Private Sub Button_Salir_Click(sender As Object, e As EventArgs) Handles Button_Salir.Click
        ' Preguntamos al usuario si desea salir o no de la aplicación
        If MsgBox("¿Esta seguro de que desea salir de la aplicación?", 36, "Salir") = 6 Then
            Application.Exit()
        End If
    End Sub

    'Enveto del label Contacto que redirigirá a la página de la Casa del libro e Fuencarral
    Private Sub LinkLabel_contacto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_Contacto.LinkClicked
        'Nos redigirá a la página web de la as del libro
        Process.Start("https://www.casadellibro.com/nosotros/tienda/fuencarral-119/15")
    End Sub

    ' Método que se ejecuta la presionar el botón de "Iniciar sesion". Comprueba los datos introducidos y en caso afirmativo
    ' nos lleva al menu principal.
    Private Sub Button_InicioSesion_Click(sender As Object, e As EventArgs) Handles Button_InicioSesion.Click
        'Donde confirmaremos la veracidad de los datos de inicio de sesion 

        ' Ocultamos este formulario (se queda en segundo plano).
        Me.Hide()
        ' Mostramos al usuario el menu principal.
        MenuPrincipal.Show()
    End Sub
End Class