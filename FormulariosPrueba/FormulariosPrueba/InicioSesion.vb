' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb

Public Class InicioSesion

    ' Especificamos la base de datos a la que nos vamos a conectar.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=cas_lib_dib.accdb")
    ' Al adaptador le asignamos la conexion que acabamos de realizar y una consulta
    Public adaptador As New OleDbDataAdapter("Select * from Empleados", conexion)
    'Aquí alojaremos los datos de la DB
    Public midataset As New DataSet

    ' Método que se ejecuta cuando el formulario es iniciado por primera vez
    Private Sub InicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Tenemos que cargar las conexiones a las tanto a la base de datos como a la libreria.
        inicializarPantalla()

        ' Especificamos los valores de nuestra barra de progreso
        ToolStripProgressBar_InicioSesion.Step = 3 'Indicamos que vamos a aumentarlo de uno en uno
        ToolStripProgressBar_InicioSesion.Maximum = 100 ' Indicamos el máximo
        ToolStripProgressBar_InicioSesion.Minimum = 0 ' Indicamos el minimo
        ToolStripProgressBar_InicioSesion.Value = 0 ' Indicamos el valor inicial

    End Sub

    ' Método que se encargará de inicializar todos los componentes de la pantalla.
    ' Además de establecer las preferencias de algunos componentes del formulario 
    Private Sub inicializarPantalla()
        'Inicializamos las preferencias de este formulario
        Me.BackColor = Color.FromArgb(3, 76, 56)
        ' O bien dejamos el botón de close
        ' Me.MaximizeBox = False
        ' Me.MinimizeBox = False

        ' O bien quitamos la caja de los botnoes min, max y close
        Me.ControlBox = False
    End Sub

    ' Método que se ejecuta cuando el label "Contacto" es pulsado
    ' Evento del label Contacto que redirigirá a la página de la Casa del libro e Fuencarral
    Private Sub LinkLabel_contacto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_Contacto.LinkClicked
        'Nos redigirá a la página web de la as del libro
        Process.Start("https://www.casadellibro.com/nosotros/tienda/fuencarral-119/15")
    End Sub

    ' Método que se ejecuta cuando el botón "Salir" es pulsado
    ' Evento del botón salir que nos confirmará el cierre de la aplicación
    Private Sub Button_Salir_Click(sender As Object, e As EventArgs) Handles Button_Salir.Click
        ' Preguntamos al usuario si desea salir o no de la aplicación
        If MsgBox("¿Esta seguro de que desea salir de la aplicación?", 36, "Salir") = 6 Then
            Application.Exit()
        End If
    End Sub

    ' Método que se ejecuta la presionar el botón de "Iniciar sesion". Comprueba los datos introducidos y en caso afirmativo
    ' nos lleva al menu principal.
    Private Sub Button_InicioSesion_Click(sender As Object, e As EventArgs) Handles Button_InicioSesion.Click
        If TextBox_Usuario.Text = "" Or TextBox_Contraseña.Text = "" Then
            MsgBox("Por favor rellene los campos de entrada. ", 64, "Mensajes del Sistema")

        Else
            'Método que Verifica si los el usuario y contraseña coinciden y existen para un registro dentro de la base de datos.
            VerificarLogIn(TextBox_Usuario.Text.Trim, TextBox_Contraseña.Text.Trim)
        End If
    End Sub

    Private Sub VerificarLogIn(ByVal user As String, ByVal contrasena As String)
        Try
            'Usamos un comando para poder acceder a la base de datos y verificar si algun registro coincide con las datos que le hemos pasado
            'por parametros.
            Dim ds As New DataSet

            Dim cb As New OleDbDataAdapter

            Dim comando As New OleDbCommand("Select * from Empleados WHERE Usuario=@usu AND Contrasenna=@contra", conexion)

            'Abrimos la conexion que nos permitira usar metodos para reocger datos de la Query
            conexion.Open()
            cb.SelectCommand = comando
            comando.Parameters.Add("@usu", OleDbType.VarChar, 30).Value = user
            comando.Parameters.Add("@usu", OleDbType.Numeric, 4).Value = contrasena

            cb.Fill(ds, "Empleados")

            'Variable que ejecutara el metodo ExecuteReader.
            Dim reader As OleDbDataReader = comando.ExecuteReader()
            Dim meta As Object() = New Object(8) {}

            'Si existe algun resgistro que solo puede ser uno. Entonces se ha verificado el log in
            If reader.Read = True Then
                TextBox_Contraseña.Clear()
                TextBox_Usuario.Clear()

                ' Damos comienzo al timer
                Timer_BarraProgreso.Start()
                ' Actualizamos el estado 
                ToolStripStatusLabel.Text = "Status: iniciando sesión"

                If (reader.GetValue(7).ToString = "Admin") Then

                    'Mostramos la notificacion como que hemos accedido como  Admin
                    MenuPrincipal.NotifyIcon_Bienvenida.BalloonTipIcon = ToolTipIcon.Info
                    MenuPrincipal.NotifyIcon_Bienvenida.BalloonTipTitle = "Bienvenido " & reader.GetValue(5) & "!!"
                    MenuPrincipal.NotifyIcon_Bienvenida.BalloonTipText = " Tienes acceso a todas las Gestiones del programa "
                    MenuPrincipal.NotifyIcon_Bienvenida.ShowBalloonTip(5)

                    Me.Hide()
                    MenuPrincipal.Show()


                ElseIf (reader.GetValue(7).ToString = "Encargado") Then
                    MenuPrincipal.Button_GestionEmpleados.Enabled = False

                    'Restricciones para el ususairo empleado en el Menu principal
                    GestionArticulos.GestiónEmpleadosToolStripMenuItem1.Enabled = False
                    GestionLibros.GestiónEmpleadosToolStripMenuItem1.Enabled = False
                    GestionSocios.GestiónEmpleadosToolStripMenuItem1.Enabled = False

                    'Mostramos la notificacion como que hemos accedido como Encargado
                    MenuPrincipal.NotifyIcon_Bienvenida.BalloonTipIcon = ToolTipIcon.Info
                    MenuPrincipal.NotifyIcon_Bienvenida.BalloonTipTitle = "Bienvenido " & reader.GetValue(5) & "!!"
                    MenuPrincipal.NotifyIcon_Bienvenida.BalloonTipText = " Tienes acceso a Gestion de Libros, Gestion de Articulos y Gestion de Socios "
                    MenuPrincipal.NotifyIcon_Bienvenida.ShowBalloonTip(5)

                    Me.Hide()
                    MenuPrincipal.Show()


                ElseIf (reader.GetValue(7).ToString = "Empleado") Then
                    'Restricciones para el ususairo empleado
                    MenuPrincipal.Button_GestionEmpleados.Enabled = False
                    MenuPrincipal.Button_GestionSocios.Enabled = False

                    GestionArticulos.Button_Annadir.Enabled = False
                    GestionArticulos.Button_Eliminar.Enabled = False
                    GestionArticulosModificaciones.Enabled = False
                    GestionArticulos.GestiónEmpleadosToolStripMenuItem1.Enabled = False
                    GestionArticulos.GestiónSociosToolStripMenuItem1.Enabled = False

                    GestionLibros.Button_Annadir.Enabled = False
                    GestionLibros.Button_Eliminar.Enabled = False
                    GestionLibros.GestiónEmpleadosToolStripMenuItem1.Enabled = False
                    GestionLibros.GestiónSociosToolStripMenuItem1.Enabled = False

                    MenuPrincipal.NotifyIcon_Bienvenida.BalloonTipIcon = ToolTipIcon.Info
                    MenuPrincipal.NotifyIcon_Bienvenida.BalloonTipTitle = "Bienvenido " & reader.GetValue(5) & "!!"
                    MenuPrincipal.NotifyIcon_Bienvenida.BalloonTipText = " Tienes acceso a Busquedas  de Libros, Busquedas de Articulos y Gestion de Socios "
                    MenuPrincipal.NotifyIcon_Bienvenida.ShowBalloonTip(5)

                    Me.Hide()
                    MenuPrincipal.Show()


                End If

            Else
                TextBox_Contraseña.Clear()
                TextBox_Usuario.Clear()

                ' Guardamos datos del acceso en el archivo
                'accesosApp.AccesosApp("Login Erroneo. usuario: " & TBUsuario.Text & " contraseña: " & TBContrasenna.Text)

                ' Mostramos mensaje de error
                MsgBox("El usuario o contraseña introducido es incorrecto, por favor introduzca otro", MsgBoxStyle.Information, "Error en la verificación")
            End If

            conexion.Close()

        Catch ex As Exception

            '  erroresApp.ErroresApp("Excepción controlada nº" & Err.Number & " : " & ex.Message & " generada en el formulario de Gestión de Empleados")

            ' Dim encontradoError As Boolean = errores.MensajeError(Err.Number, "Por favor, revise la base de datos. ", False)

            'If encontradoError = False Then
            MsgBox("Error nº: " & Err.Number & ". " & ex.Message & " Por favor, revise la base de datos. ", MsgBoxStyle.Exclamation, ex.Message)
            ' End If

        End Try
    End Sub


    ' Método del timer que permitirá su ejecución
    ' Es ejecutado cuando se utiliza .start()
    Private Sub Timer_paraProgreso_Tick(sender As Object, e As EventArgs) Handles Timer_BarraProgreso.Tick
        ' Avanzamos x en el valor del progress bar
        ToolStripProgressBar_InicioSesion.PerformStep()

        If ToolStripProgressBar_InicioSesion.Value = 100 Then
            ' Paramos el progreso del timer
            Timer_BarraProgreso.Stop()


            ' ###### Reiniciamos la barra de progreso ######

            ' Especificamos los valores de nuestra barra de progreso nuevamente (reiniciandola)
            ToolStripProgressBar_InicioSesion.Step = 3 'Indicamos que vamos a aumentarlo de uno en uno
            ToolStripProgressBar_InicioSesion.Maximum = 100 ' Indicamos el máximo
            ToolStripProgressBar_InicioSesion.Minimum = 0 ' Indicamos el minimo
            ToolStripProgressBar_InicioSesion.Value = 0 ' Indicamos el valor inicial
            ' Actualizamos el estado a por defecto para el próximo inicio de sesión
            ToolStripStatusLabel.Text = "Status: en espera"

        End If
    End Sub



    ' Método que limpia los Textbox
    Private Sub limpiarPantalla()
        TextBox_Contraseña.Clear()
        TextBox_Usuario.Clear()
    End Sub

    Private Sub TextBox_Usuario_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Usuario.TextChanged
        ' Instanciamos la clase        
        Dim validarUsuario As New libreriaValidacion.Validacion

        If validarUsuario.validarUsuario(TextBox_Usuario.Text) = False Then
            TextBox_Usuario.Text = TextBox_Usuario.Text.Substring(0, TextBox_Usuario.Text.Length - 1)
            TextBox_Usuario.SelectionStart = TextBox_Usuario.TextLength
        End If
    End Sub

End Class