' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb

' No hace falta hacer imports libValidaciones para instanciar sus clases porque está incluida en el proyecto.
Imports System.IO

Public Class GestionSociosModificaciones

    ' Variable para almacenar el número de socio inicial con el que se identificará el registro a modificar.
    Dim numSocioInicial As String

    ' Variable de control que controla que no se recoja más de una vez el valor de la primary key
    Dim numControlPK As Single = 0

    ' Para evitar la apariciónd de una excepción cuando no le toca
    Dim validacionControlCorreo As Integer = 0
    Dim validacionNumeroControl As Integer = 0

    ' Especificamos la base de datos a la que nos vamos a conectar.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=cas_lib_dib.accdb")
    ' Al adaptador le asignamos la conexion que acabamos de realizar y una consulta
    Public adaptador As New OleDbDataAdapter("Select * from Socios", conexion)

    ' Aquí alojaremos los datos de la DB
    Public midataset As New DataSet

    ' Método que se ejecuta cuando se pulsa el botón "Limpiar".
    ' "Limpia" todos los textBox, dejandolos vacios.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Vaciamos cada textBox de forma individual
        TextBox_NumeroSocio.Clear()
        TextBox_Nombre.Clear()
        TextBox_Apellidos.Clear()
        TextBox_Telefono.Clear()
        TextBox_Correo.Clear()
    End Sub

    '  Método que se ejecuta al iniciarse el formulario. El cual nos mostrará los datos de la Seleccion que hemos hecho en el DataGridView_Socios del formulario GestionSocios
    '  en los textBox correspondientes. Para esto crearemos un nuevo comando, y lo asociaremos al midataset para obtener los datos que queremos
    Private Sub GestionSociosModificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Creamos un comando nuevo con una Query nueva la cual vamos a usar para poder buscar un socio en concreto
        Dim comando As New OleDbCommand(("select * from Socios where NumeroDeSocio = @numSocio"), conexion)

        'Al adaptador le asignamos este nuevo comando "comando"
        adaptador.SelectCommand = comando
        'Al comando le vamos a pasar por parametro @numSocio (valor de tipo Numeric, 8) el cual va a ser cogido de la Fila(currentRow) seleccionada de la Columna 0 (NumeroSocio)
        'del DataGridView_Socios del formulario GestionSocios. Es decir al seleccionar un elemento detectará cual es la fila y el valor de la columna 0 y lo pasará por parametro.
        comando.Parameters.Add("@numSocio", OleDbType.Numeric, 8).Value = GestionSocios.DataGridView_Socios.Item(0, GestionSocios.DataGridView_Socios.CurrentRow.Index).Value

        'Limpiamos el midataset para que no haya información residual
        midataset.Clear() 'de este form 
        'Asociamos el nuevo adaptador con el nuevo comando al midataset de la tabla Socios 
        adaptador.Fill(midataset, "Socios")

        If GestionSocios.numeroDeControlBindingModificaciones = 0 Then
            'Se relacionan los campos de la tabla con los textbox y se muestran los datos del registro que queremos modificar.
            Me.TextBox_NumeroSocio.DataBindings.Add("text", midataset, "Socios.NumeroDeSocio")
            Me.TextBox_Nombre.DataBindings.Add("text", midataset, "Socios.Nombre")
            Me.TextBox_Apellidos.DataBindings.Add("text", midataset, "Socios.Apellidos")
            Me.TextBox_Telefono.DataBindings.Add("text", midataset, "Socios.Telefono")
            Me.TextBox_Correo.DataBindings.Add("text", midataset, "Socios.Correo")

            GestionSocios.numeroDeControlBindingModificaciones = 1
        End If

        ' Inicializamos la variable de control
        controlCalculadora = 0

        ' Inicializamos la variable asignandole el número de socio inicial
        numSocioInicial = GestionSocios.DataGridView_Socios.Item(0, GestionSocios.DataGridView_Socios.CurrentRow.Index).Value


    End Sub

    ' Método que se ejecuta al pulsarse el botón "Modificar"
    ' Se encarga de modificar los datos ya existentes en la DB
    Private Sub Button_Modificar_Click(sender As Object, e As EventArgs) Handles Button_Modificar.Click
        If TextBox_NumeroSocio.Text = "" Or TextBox_Nombre.Text = "" Or TextBox_Apellidos.Text = "" Or TextBox_Telefono.Text = "" Or TextBox_Correo.Text = "" Then
            MsgBox("Debes seleccionar un registro para actualizarlo y si lo has seleccionado, no debe quedar ningún campo en blanco", MsgBoxStyle.OkOnly, "Error al dar de alta.")
        Else

            ' Validamos todas las cajas y si alguna es incorrecta... salimos del metodo.
            ' Instanciamos la clase
            Dim validarNumeroSocio As New libreriaValidacion.Validacion

            Dim resultado1 As Boolean = validarNumeroSocio.validarNumeroSocio(TextBox_NumeroSocio.Text, 2)
            Dim resultado2 As Boolean = validarNumeroSocio.validarTelefono(TextBox_Telefono.Text, 2)
            Dim resultado3 As Boolean = validarNumeroSocio.validarNombre(TextBox_Nombre.Text, 1)
            Dim resultado4 As Boolean = validarNumeroSocio.validarNombre(TextBox_Apellidos.Text, 2)
            Dim resultado5 As Boolean = validarNumeroSocio.validarCorreo(TextBox_Correo.Text, 1)

            If resultado1 = False Then
                'MsgBox(" El dato numero socio, no puede contener caracteres que no sean numéricos o símbolos no permitidos, tampoco puede tener una longitud mayor a 8.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
                Exit Sub
            ElseIf resultado2 = False Then
                'MsgBox(" El dato telefono, no puede contener caracteres que no sean numéricos o símbolos no permitidos, tampoco puede tener una longitud mayor a 9.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
                Exit Sub
            ElseIf resultado3 = False Then
                'MsgBox(" El dato nombre, no puede contener caracteres que sean numéricos o símbolos no permitidos, tampoco puede tener una longitud mayor a 50.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
                Exit Sub
            ElseIf resultado4 = False Then
                'MsgBox(" El dato apellidos, no puede contener caracteres que sean numéricos o símbolos no permitidos, tampoco puede tener una longitud mayor a 50.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
                Exit Sub
            ElseIf resultado5 = False Then
                'MsgBox(" El dato apellidos, no puede contener caracteres que sean numéricos o símbolos no permitidos, tampoco puede tener una longitud mayor a 50.", MsgBoxStyle.OkOnly, "Error - Caracteres incorrectos")
                Exit Sub
            End If

            ' Variable auxiliar
            Dim valor As String
            ' Variable de control para controlar las primary keys duplicadas
            Dim control As Integer = 0

            ' Comprobamos que la clave primaria no se encuentra ya registrada.
            For contador As Integer = 0 To GestionSocios.DataGridView_Socios.RowCount - 1
                valor = GestionSocios.DataGridView_Socios.Item(0, contador).Value

                If valor = TextBox_NumeroSocio.Text And valor <> numSocioInicial Then
                    MsgBox("No puedes introducir un número de socio que ya existe en la base de datos.", MsgBoxStyle.OkOnly, "Error, clave duplicada")
                    ' Dado que la primary key que pretendemos introducir ya se encuentra en los registros, cambiamos la variable de control
                    control = 1
                End If
            Next

            If control = 0 Then
                Try
                    ' Montamos una query parametrizada.
                    Dim queryParametrizada As String = "UPDATE Socios SET NumeroDeSocio=?, Nombre=?, Apellidos=?, Telefono=?, Correo=? WHERE NumeroDeSocio=?"
                    Using cmd = New OleDbCommand(queryParametrizada, conexion)
                        ' Abrimos la conexión
                        conexion.Open()
                        cmd.Parameters.AddWithValue("@p1", Convert.ToInt64(TextBox_NumeroSocio.Text))
                        cmd.Parameters.AddWithValue("@p2", TextBox_Nombre.Text)
                        cmd.Parameters.AddWithValue("@p3", TextBox_Apellidos.Text)
                        cmd.Parameters.AddWithValue("@p4", Convert.ToInt64(TextBox_Telefono.Text))
                        cmd.Parameters.AddWithValue("@p5", TextBox_Correo.Text)
                        cmd.Parameters.AddWithValue("@p6", numSocioInicial)

                        cmd.ExecuteNonQuery()

                        ' Cerramos la conexión
                        conexion.Close()
                    End Using

                Catch ex As System.InvalidOperationException
                    ' Avisamos del error por mensaje
                    MsgBox("Algo no ha ido bien, intentalo de nuevo", MsgBoxStyle.OkOnly, "Operación invalida")
                Catch ex2 As System.Data.OleDb.OleDbException
                    ' Avisamos del error por mensaje
                    MsgBox("Algo no ha ido bien, intentalo de nuevo", MsgBoxStyle.OkOnly, "Operación invalida")
                Catch ex3 As System.FormatException
                    ' Avisamos del error por mensaje
                    MsgBox("Uno de los datos tiene un formato incorrecto, intentalo de nuevo", MsgBoxStyle.OkOnly, "Operación invalida")
                End Try

                ' Actualizamos el dataGridView del formulario de gestión principal
                GestionSocios.midataset.Clear()
                GestionSocios.adaptador.Fill(GestionSocios.midataset, "Socios")

                ' Reiniciamos su valor para la próxima vez
                controlCalculadora = 0

                ' Cerramos la ventana
                Me.Close()

            End If
        End If
    End Sub

    ' #####################################################    Métodos varios    ##########################################################################


    ' Método que se ejecuta cuando el botón "Salir..." del ToolStrip es pulsado y que nos lleva al formulario "GestionSocios".
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        ' Mostramos el formulario "GestionSocios".
        GestionSocios.Show()

        ' Reiniciamos el valor para la próxima vez
        controlCalculadora = 0

        ' Cerramos este formulario
        Me.Close()
    End Sub

    Dim controlCalculadora As Integer

    ' Método que se ejecuta cuando es pulsado el botón "Calculadora" del menuStrip
    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        If controlCalculadora < 2 Then
            ' Try catch para atrapar el error en caso de que el ordenador del usuario
            Try
                Dim program As String
                program = "calc.exe"
                Process.Start(program)
            Catch ex As System.ComponentModel.Win32Exception '
                MsgBox("Ha ocurrido un error, no se pudo iniciar la calculadora.", MsgBoxStyle.OkOnly, "Error (proceso calculadora)")
            End Try

            controlCalculadora = controlCalculadora + 1

        Else
            MsgBox("Solo se pueden iniciar dos calculadoras por sesión.", MsgBoxStyle.OkOnly, "Aviso")
        End If
    End Sub

    ' Validamos este campo evitando que tenga caracteres que no sean númericos y que tenga una longitud de 8 caracteres.
    Private Sub TextBox_NumeroSocio_TextChanged(sender As Object, e As EventArgs) Handles TextBox_NumeroSocio.TextChanged

        If validacionNumeroControl = 1 Then
            ' Instanciamos la clase
            Dim validarNumeroSocio As New libreriaValidacion.Validacion

            validarNumeroSocio.validarNumeroSocio(TextBox_NumeroSocio.Text, 1)
        Else
            validacionNumeroControl = 1
        End If


    End Sub

    ' Validamos este campo evitando que tenga caracteres que no sean númericos y que tenga una longitud de más de 9 caracteres.
    Private Sub TextBox_Telefono_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Telefono.TextChanged
        ' Instanciamos la clase        
        Dim validarNumeroSocio As New libreriaValidacion.Validacion

        validarNumeroSocio.validarTelefono(TextBox_Telefono.Text, 1)
    End Sub

    ' Validamos este campo evitando que tenga caracteres que no sean númericos y que tenga una longitud de no más de 50 caracteres.
    Private Sub TextBox_Nombre_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Nombre.TextChanged
        ' Instanciamos la clase        
        Dim validarNumeroSocio As New libreriaValidacion.Validacion

        validarNumeroSocio.validarNombre(TextBox_Nombre.Text, 1)
    End Sub

    ' Validamos este campo evitando que tenga caracteres que no sean númericos y que tenga una longitud de no más de 50 caracteres.
    Private Sub TextBox_Apellidos_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Apellidos.TextChanged
        ' Instanciamos la clase
        Dim validarNumeroSocio As New libreriaValidacion.Validacion

        validarNumeroSocio.validarNombre(TextBox_Apellidos.Text, 2)
    End Sub

    ' Validamos este campo evitando que tenga caracteres prohibidos en un e-mail y que tenga una longitud de no más de 120 caracteres.
    Private Sub TextBox_Correo_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Correo.TextChanged
        If validacionControlCorreo = 1 Then
            ' Instanciamos la clase
            Dim validarNumeroSocio As New libreriaValidacion.Validacion

            validarNumeroSocio.validarCorreo(TextBox_Correo.Text, 1)
        Else
            validacionControlCorreo = 1
        End If
    End Sub

    ' Esté método es ejecutado cuando el usuario presiona la tecla "F1"
    Private Sub GestionSocios_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Help.ShowHelp(Me, "CHM\LaCasaDelLibro.chm", "")
    End Sub

    ' Esté método es ejecutado cuando el usuario presiona el botón de ayuda situado en la barra superior.
    ' Muestra un documento de ayuda.
    Private Sub VerLaAyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerLaAyudaToolStripMenuItem.Click
        Help.ShowHelp(Me, "CHM\LaCasaDelLibro.chm", "")
    End Sub

End Class