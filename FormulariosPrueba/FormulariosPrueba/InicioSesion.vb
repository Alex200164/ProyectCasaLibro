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
        ToolStripProgressBar_InicioSesion.Step = 10 'Indicamos que vamos a aumentarlo de uno en uno
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
            MsgBox("Porfavor rellene los campos de entrada. ", 64, "Mensajes del Sistema")

        Else
            'Donde confirmaremos la veracidad de los datos de inicio de sesion 
            VerificarLogIn(TextBox_Usuario.Text.Trim, TextBox_Contraseña.Text.Trim)
        End If
    End Sub

    Private Sub VerificarLogIn(ByVal user As String, ByVal contrasena As String)
        Try
            Dim ds As New DataSet

            Dim cb As New OleDbDataAdapter

            Dim comando As New OleDbCommand("Select * from Empleados WHERE Usuario=@usu AND Contrasenna=@contra", conexion)

            conexion.Open()
            cb.SelectCommand = comando
            comando.Parameters.Add("@usu", OleDbType.VarChar, 30).Value = user
            comando.Parameters.Add("@usu", OleDbType.Numeric, 4).Value = contrasena

            cb.Fill(ds, "Empleados")

            Dim reader As OleDbDataReader = comando.ExecuteReader()
            Dim meta As Object() = New Object(8) {}

            If reader.Read = True Then
                'MsgBox(reader.GetValue(7) & reader.GetValue(6) & reader.GetValue(5))

                ' Damos comienzo al timer
                Timer_BarraProgreso.Start()
                ' Actualizamos el estado 
                ToolStripStatusLabel.Text = "Status: iniciando sesión"

                If (reader.GetValue(7).ToString = "Admin") Then
                    MenuPrincipal.NotifyIcon_Bienvenida.BalloonTipIcon = ToolTipIcon.Info
                    MenuPrincipal.NotifyIcon_Bienvenida.BalloonTipTitle = "Bienvenido " & reader.GetValue(5) & "!!"
                    MenuPrincipal.NotifyIcon_Bienvenida.BalloonTipText = " Tienes a todas las gestiones del programa "
                    MenuPrincipal.NotifyIcon_Bienvenida.ShowBalloonTip(5)
                    Me.Hide()
                    MenuPrincipal.Show()


                ElseIf (reader.GetValue(7).ToString = "Encargado") Then
                    MenuPrincipal.Button_GestionEmpleados.Enabled = False

                    MenuPrincipal.NotifyIcon_Bienvenida.BalloonTipIcon = ToolTipIcon.Info
                    MenuPrincipal.NotifyIcon_Bienvenida.BalloonTipTitle = "Bienvenido " & reader.GetValue(5) & "!!"
                    MenuPrincipal.NotifyIcon_Bienvenida.BalloonTipText = " Tienes acceso a Gestion de Libros, Gestion de Articulos y Gestion de Socios "
                    MenuPrincipal.NotifyIcon_Bienvenida.ShowBalloonTip(5)

                    Me.Hide()
                    MenuPrincipal.Show()


                ElseIf (reader.GetValue(7).ToString = "Empleado") Then
                    MenuPrincipal.Button_GestionEmpleados.Enabled = False
                    MenuPrincipal.Button_GestionSocios.Enabled = False
                    GestionArticulos.Button_Annadir.Enabled = False
                    GestionArticulos.Button_Eliminar.Enabled = False
                    GestionArticulosModificaciones.Enabled = False

                    MenuPrincipal.NotifyIcon_Bienvenida.BalloonTipIcon = ToolTipIcon.Info
                    MenuPrincipal.NotifyIcon_Bienvenida.BalloonTipTitle = "Bienvenido " & reader.GetValue(5) & "!!"
                    MenuPrincipal.NotifyIcon_Bienvenida.BalloonTipText = " Tienes acceso a Gestion de Libros, Gestion de Articulos y Gestion de Socios "
                    MenuPrincipal.NotifyIcon_Bienvenida.ShowBalloonTip(5)

                    'Me.Hide()
                    MenuPrincipal.Show()


                End If

            Else

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

            ' Ocultamos este formulario (se queda en segundo plano).
            Me.Hide()

            ' Especificamos la posición en la que queremos que se coloque en pantalla el formualario "MenuPricipal"
            posicionarFormularioMenuPrincipal()
            ' Mostramos al usuario el menu principal.
            MenuPrincipal.Show()

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

    ' Método que permite posicionar la ventana en la posición especificada del formulario "MenuPrincipal".
    ' En este caso para evitar que quede encima del formulario anterior.
    Private Shared Sub posicionarFormularioMenuPrincipal()
        MenuPrincipal.StartPosition = FormStartPosition.Manual
        Dim a As Integer
        a = My.Computer.Screen.Bounds.Size.Width - (My.Computer.Screen.Bounds.Size.Width * 0.97)
        Dim b As Integer
        b = My.Computer.Screen.Bounds.Size.Height - (My.Computer.Screen.Bounds.Size.Height * 0.97)
        MenuPrincipal.Location = New Point(a, b)
    End Sub

    ' Método que limpia los Textbox
    Private Sub limpiarPantalla()
        TextBox_Contraseña.Clear()
        TextBox_Usuario.Clear()
    End Sub


End Class