' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb

' No hace falta hacer imports libValidaciones para instanciar sus clases porque está incluida en el proyecto.
Imports System.IO

Public Class GestionEmpleadosAltas

    ' Especificamos la base de datos a la que nos vamos a conectar.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=cas_lib_dib.accdb")
    ' Al adaptador le asignamos la conexion que acabamos de realizar y una consulta
    Public adaptador As New OleDbDataAdapter("Select * from Empleados", conexion)

    ' Aquí alojaremos los datos de la DB
    Public midataset As New DataSet

    ' Método que se ejecuta cuando el botón "Salir..." del ToolStrip es pulsado y que nos lleva al formulario "GestionEmpleados".
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        ' Mostramos el formulario "GestionEmpleados".
        GestionEmpleados.Show()

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

    ' Método que se ejecuta al pulsar el botón "Limpiar"
    ' Limpia todos los textBoxes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox_DNI.Clear()
        TextBox_NOMBRE.Clear()
        TextBox_APELLIDOS.Clear()
        TextBox_CORREO.Clear()
        TextBox_TELEFONO.Clear()
        TextBox_USUARIO.Clear()
        TextBox_CONTRASENNA.Clear()
        TextBox_ROL.Clear()
    End Sub

    '  Método que se ejecuta al iniciarse el formulario.
    Private Sub GestionEmpleadosAltas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar la memoria del cache con datos.
        adaptador.Fill(midataset, "Empleados")

        If GestionEmpleados.numeroDeControlBindingAltaEmpleados = 0 Then
            ' Relacionar los campos de la tabla con los textbox
            Me.TextBox_DNI.DataBindings.Add("text", midataset, "Empleados.DNI")
            Me.TextBox_NOMBRE.DataBindings.Add("text", midataset, "Empleados.Nombre")
            Me.TextBox_APELLIDOS.DataBindings.Add("text", midataset, "Empleados.Apellidos")
            Me.TextBox_CORREO.DataBindings.Add("text", midataset, "Empleados.Correo")
            Me.TextBox_TELEFONO.DataBindings.Add("text", midataset, "Empleados.Telefono")
            Me.TextBox_USUARIO.DataBindings.Add("text", midataset, "Empleados.Usuario")
            Me.TextBox_CONTRASENNA.DataBindings.Add("text", midataset, "Empleados.Contrasenna")
            Me.TextBox_ROL.DataBindings.Add("text", midataset, "Empleados.Rol")

            GestionEmpleados.numeroDeControlBindingAltaEmpleados = 1
        End If

        ' Inicializamos la variable de control
        controlCalculadora = 0

        ' Vaciamos cada textBox de forma individual
        TextBox_DNI.Clear()
        TextBox_NOMBRE.Clear()
        TextBox_APELLIDOS.Clear()
        TextBox_CORREO.Clear()
        TextBox_TELEFONO.Clear()
        TextBox_USUARIO.Clear()
        TextBox_CONTRASENNA.Clear()
        TextBox_ROL.Clear()
    End Sub

    ' Método que se ejecuta cuando el botón "Alta" es pulsado. 
    ' Introduce los datos escritos por el usuario en los textBox en la DB.
    Private Sub Button_Guardar_Alta_Click(sender As Object, e As EventArgs) Handles Button_Guardar_Alta.Click
        If TextBox_DNI.Text = "" Or TextBox_NOMBRE.Text = "" Or TextBox_APELLIDOS.Text = "" Or TextBox_TELEFONO.Text = "" Or TextBox_CORREO.Text = "" Or TextBox_USUARIO.Text = "" Or TextBox_CONTRASENNA.Text = "" Or TextBox_ROL.Text = "" Then
            MsgBox("No se puede dar de alta , debe rellenar todos los datos.", MsgBoxStyle.OkOnly, "Error al dar de alta.")
        Else

            ' Validamos todas las cajas y si alguna es incorrecta... salimos del metodo.
            ' Instanciamos la clase
            Dim validarNumeroSocio As New libreriaValidacion.Validacion

            Dim resultado1 As Boolean = validarNumeroSocio.validarDNI(TextBox_DNI.Text, 2)
            Dim resultado2 As Boolean = validarNumeroSocio.validarTelefono(TextBox_TELEFONO.Text, 2)
            Dim resultado3 As Boolean = validarNumeroSocio.validarNombre(TextBox_NOMBRE.Text, 1)
            Dim resultado4 As Boolean = validarNumeroSocio.validarNombre(TextBox_APELLIDOS.Text, 2)
            Dim resultado5 As Boolean = validarNumeroSocio.validarCorreo(TextBox_CORREO.Text, 1)
            Dim resultado6 As Boolean = validarNumeroSocio.validarUsuario(TextBox_USUARIO.Text)
            Dim resultado7 As Boolean = validarNumeroSocio.validarContra(TextBox_CONTRASENNA.Text, 2)
            Dim resultado8 As Boolean = validarNumeroSocio.validarROL(TextBox_ROL.Text, 1)

            If resultado1 = False Then
                Exit Sub
            ElseIf resultado2 = False Then
                Exit Sub
            ElseIf resultado3 = False Then
                Exit Sub
            ElseIf resultado4 = False Then
                Exit Sub
            ElseIf resultado5 = False Then
                Exit Sub
            ElseIf resultado6 = False Then
                Exit Sub
            ElseIf resultado7 = False Then
                Exit Sub
            ElseIf resultado8 = False Then
                Exit Sub
            End If

            Dim testComp As Integer = StrComp(TextBox_ROL.Text, "Admin", CompareMethod.Text)
            Dim testComp2 As Integer = StrComp(TextBox_ROL.Text, "Encargado", CompareMethod.Text)
            Dim testComp3 As Integer = StrComp(TextBox_ROL.Text, "Empleado", CompareMethod.Text)


            If testComp <> 0 Then
                If testComp2 <> 0 Then
                    If testComp3 <> 0 Then
                        MsgBox(" El rol debe ser uno de los siguientes: Admin, Encargado o Empleado.", MsgBoxStyle.OkOnly, "Error - Rol incorrecto")
                        Exit Sub
                    End If
                End If
            End If


            Dim valor As String
            Dim control As Integer = 0

            ' Comprobamos que la clave primaria no se encuentra ya registrada.
            For contador As Integer = 0 To GestionEmpleados.DataGridView_Empleados.RowCount - 1
                valor = GestionEmpleados.DataGridView_Empleados.Item(0, contador).Value

                If valor = TextBox_DNI.Text Then
                    MsgBox("No puedes introducir un DNI que ya existe en la base de datos.", MsgBoxStyle.OkOnly, "Error, clave duplicada")
                    control = 1
                End If
            Next

            If control = 0 Then
                Try
                    ' ####################  1º Preparamos a la base de datos para recibir los datos. ##############################
                    Dim cb As New OleDbCommandBuilder(adaptador)
                    adaptador.InsertCommand = cb.GetInsertCommand

                    ' ####################  2º Recogemos los datos y los introducimos ##############################
                    Dim drc As DataRowCollection = midataset.Tables("Empleados").Rows
                    drc.Add(TextBox_DNI.Text, TextBox_NOMBRE.Text, TextBox_APELLIDOS.Text, TextBox_CORREO.Text, TextBox_TELEFONO.Text, TextBox_USUARIO.Text, TextBox_CONTRASENNA.Text, TextBox_ROL.Text)

                    adaptador.Update(midataset.Tables("Empleados"))
                    ' ####################  3º Actualizamos el middataset ##############################
                    ' Actualizamos el dataGridView del formulario de gestión principal
                    GestionEmpleados.midataset.Clear()
                    GestionEmpleados.adaptador.Fill(GestionEmpleados.midataset, "Empleados")

                    ' Reiniciamos su valor para la proxima vez
                    controlCalculadora = 0

                    ' Cerramos la ventana
                    Me.Close()

                Catch ex As System.InvalidOperationException
                    ' Avisamos del error por mensaje
                    MsgBox("Algo no ha ido bien, intentalo de nuevo", MsgBoxStyle.OkOnly, "Operación invalida")
                Catch ex2 As System.FormatException
                    ' Avisamos del error por mensaje
                    MsgBox("El formato de los datos introducidos es incorrecto, intentalo de nuevo", MsgBoxStyle.OkOnly, "Operación invalida")
                Catch ex3 As System.Data.OleDb.OleDbException
                    ' Avisamos del error por mensaje
                    MsgBox("Algo no ha ido bien, es la sintaxis correcta?, intentalo de nuevo", MsgBoxStyle.OkOnly, "Operación invalida")
                Catch ex4 As System.NullReferenceException
                    ' Avisamos del error por mensaje
                    MsgBox("Algo no ha ido bien, intentalo de nuevo. Referencia a objeto no establecida como instancia de un objeto.", MsgBoxStyle.OkOnly, "Operación invalida")
                End Try
            End If
        End If
    End Sub

    ' Validamos este campo evitando que tenga caracteres que no sean númericos y que tenga una longitud de más de 8 caracteres.
    Private Sub TextBox_DNI_TextChanged(sender As Object, e As EventArgs) Handles TextBox_DNI.TextChanged
        ' Instanciamos la clase
        Dim validarNumeroSocio As New libreriaValidacion.Validacion

        validarNumeroSocio.validarDNI(TextBox_DNI.Text, 1)

    End Sub

    ' Validamos este campo evitando que tenga caracteres que no sean númericos y que tenga una longitud de más de 9 caracteres.
    Private Sub TextBox_Telefono_TextChanged(sender As Object, e As EventArgs) Handles TextBox_TELEFONO.TextChanged
        ' Instanciamos la clase        
        Dim validarNumeroSocio As New libreriaValidacion.Validacion

        validarNumeroSocio.validarTelefono(TextBox_TELEFONO.Text, 1)
    End Sub

    ' Validamos este campo evitando que tenga caracteres que no sean númericos y que tenga una longitud de no más de 50 caracteres.
    Private Sub TextBox_Nombre_TextChanged(sender As Object, e As EventArgs) Handles TextBox_NOMBRE.TextChanged
        ' Instanciamos la clase        
        Dim validarNumeroSocio As New libreriaValidacion.Validacion

        validarNumeroSocio.validarNombre(TextBox_NOMBRE.Text, 1)
    End Sub

    ' Validamos este campo evitando que tenga caracteres que no sean númericos y que tenga una longitud de no más de 50 caracteres.
    Private Sub TextBox_Apellidos_TextChanged(sender As Object, e As EventArgs) Handles TextBox_APELLIDOS.TextChanged
        ' Instanciamos la clase
        Dim validarNumeroSocio As New libreriaValidacion.Validacion

        validarNumeroSocio.validarNombre(TextBox_APELLIDOS.Text, 2)
    End Sub

    ' Validamos este campo evitando que tenga caracteres prohibidos en un e-mail y que tenga una longitud de no más de 120 caracteres.
    Private Sub TextBox_Correo_TextChanged(sender As Object, e As EventArgs) Handles TextBox_CORREO.TextChanged
        ' Instanciamos la clase
        Dim validarNumeroSocio As New libreriaValidacion.Validacion

        validarNumeroSocio.validarCorreo(TextBox_CORREO.Text, 1)
    End Sub

    ' Validación del usuario
    Private Sub TextBox_USUARIO_TextChanged(sender As Object, e As EventArgs) Handles TextBox_USUARIO.TextChanged
        ' Instanciamos la clase
        Dim validarNumeroSocio As New libreriaValidacion.Validacion

        validarNumeroSocio.validarUsuario(TextBox_USUARIO.Text)
    End Sub

    ' Validación de la contraseña
    Private Sub TextBox_CONTRASENNA_TextChanged(sender As Object, e As EventArgs) Handles TextBox_CONTRASENNA.TextChanged
        ' Instanciamos la clase
        Dim validarNumeroSocio As New libreriaValidacion.Validacion

        validarNumeroSocio.validarContra(TextBox_CONTRASENNA.Text, 1)
    End Sub

    ' Validación del rol
    Private Sub TextBox_ROL_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ROL.TextChanged
        ' Instanciamos la clase
        Dim validarNumeroSocio As New libreriaValidacion.Validacion

        validarNumeroSocio.validarROL(TextBox_ROL.Text, 1)
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