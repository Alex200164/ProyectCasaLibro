' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb

' No hace falta hacer imports libValidaciones para instanciar sus clases porque está incluida en el proyecto.
Imports System.IO

Public Class GestionSociosAltas

    ' Especificamos la base de datos a la que nos vamos a conectar.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=cas_lib_dib.accdb")
    ' Al adaptador le asignamos la conexion que acabamos de realizar y una consulta
    Public adaptador As New OleDbDataAdapter("Select * from Socios", conexion)

    ' Aquí alojaremos los datos de la DB
    Public midataset As New DataSet

    ' Para evitar la apariciónd de una excepción cuando no le toca
    Dim validacionControlCorreo As Integer = 0

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
                Dim validacion As New libreriaValidacion.Validacion
                validacion.errorLogWrite()

            End Try

            controlCalculadora = controlCalculadora + 1

        Else
            MsgBox("Solo se pueden iniciar dos calculadoras por sesión.", MsgBoxStyle.OkOnly, "Aviso")
        End If
    End Sub

    ' Método que se ejecuta cuando se pulsa el botón "Limpiar".
    ' "Limpia" todos los textBox, dejandolos vacios.
    Private Sub Button_Limpiar_Click(sender As Object, e As EventArgs) Handles Button_Limpiar.Click
        ' Vaciamos cada textBox de forma individual
        TextBox_NumeroSocio.Clear()
        TextBox_Nombre.Clear()
        TextBox_Apellidos.Clear()
        TextBox_Telefono.Clear()
        TextBox_Correo.Clear()
    End Sub

    ' Método que se ejecuta cuando el botón "Alta" es pulsado. 
    ' Introduce los datos escritos por el usuario en los textBox en la DB.
    Private Sub Button_Alta_Click(sender As Object, e As EventArgs) Handles Button_Alta.Click
        If TextBox_NumeroSocio.Text = "" Or TextBox_Nombre.Text = "" Or TextBox_Apellidos.Text = "" Or TextBox_Telefono.Text = "" Or TextBox_Correo.Text = "" Then
            MsgBox("No se puede dar de alta , debe rellenar todos los datos.", MsgBoxStyle.OkOnly, "Error al dar de alta.")
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


            Dim valor As String
            Dim control As Integer = 0

            ' Comprobamos que la clave primaria no se encuentra ya registrada.
            For contador As Integer = 0 To GestionSocios.DataGridView_Socios.RowCount - 1
                valor = GestionSocios.DataGridView_Socios.Item(0, contador).Value

                If valor = TextBox_NumeroSocio.Text Then
                    MsgBox("No puedes introducir un número de socio que ya existe en la base de datos.", MsgBoxStyle.OkOnly, "Error, clave duplicada")
                    control = 1
                End If
            Next

            If control = 0 Then
                Try
                    ' ####################  1º Preparamos a la base de datos para recibir los datos. ##############################
                    Dim cb As New OleDbCommandBuilder(adaptador)
                    adaptador.InsertCommand = cb.GetInsertCommand

                    ' ####################  2º Recogemos los datos y los introducimos ##############################
                    Dim drc As DataRowCollection = midataset.Tables("Socios").Rows
                    drc.Add(TextBox_NumeroSocio.Text, TextBox_Nombre.Text, TextBox_Apellidos.Text, TextBox_Telefono.Text, TextBox_Correo.Text)

                    adaptador.Update(midataset.Tables("Socios"))
                Catch ex As System.InvalidOperationException
                    ' Avisamos del error por mensaje
                    MsgBox("Algo no ha ido bien, intentalo de nuevo", MsgBoxStyle.OkOnly, "Operación invalida")
                    Dim validacion As New libreriaValidacion.Validacion
                    validacion.errorLogWrite()
                Catch ex2 As System.FormatException
                    ' Avisamos del error por mensaje
                    MsgBox("El formato de los datos introducidos es incorrecto, intentalo de nuevo", MsgBoxStyle.OkOnly, "Operación invalida")
                    Dim validacion As New libreriaValidacion.Validacion
                    validacion.errorLogWrite()
                Catch ex3 As System.Data.OleDb.OleDbException
                    ' Avisamos del error por mensaje
                    MsgBox("Algo no ha ido bien, es la sintaxis correcta?, intentalo de nuevo", MsgBoxStyle.OkOnly, "Operación invalida")
                    Dim validacion As New libreriaValidacion.Validacion
                    validacion.errorLogWrite()
                Catch ex4 As System.NullReferenceException
                    ' Avisamos del error por mensaje
                    MsgBox("Algo no ha ido bien, intentalo de nuevo. Referencia a objeto no establecida como instancia de un objeto.", MsgBoxStyle.OkOnly, "Operación invalida")
                    Dim validacion As New libreriaValidacion.Validacion
                    validacion.errorLogWrite()
                End Try

                ' ####################  3º Actualizamos el middataset ##############################
                ' Actualizamos el dataGridView del formulario de gestión principal
                GestionSocios.midataset.Clear()
                GestionSocios.adaptador.Fill(GestionSocios.midataset, "Socios")

                ' Reiniciamos su valor para la próxima vez
                controlCalculadora = 0

                ' Cerramos la ventana
                Me.Close()

                ' System.NullReferenceException: 'Referencia a objeto no establecida como instancia de un objeto.'
                ' System.Data.OleDb.OleDbException: 'Error de sintaxis en la instrucción INSERT INTO.'
            End If

        End If
    End Sub

    '  Método que se ejecuta al iniciarse el formulario.
    Private Sub GestionSociosAltas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar la memoria del cache con datos.
        adaptador.Fill(midataset, "Socios")

        If GestionSocios.numeroDeControlBindingAltaSocios = 0 Then
            Me.TextBox_NumeroSocio.DataBindings.Add("text", midataset, "Socios.NumeroDeSocio")
            Me.TextBox_Nombre.DataBindings.Add("text", midataset, "Socios.Nombre")
            Me.TextBox_Apellidos.DataBindings.Add("text", midataset, "Socios.Apellidos")
            Me.TextBox_Telefono.DataBindings.Add("text", midataset, "Socios.Telefono")
            Me.TextBox_Correo.DataBindings.Add("text", midataset, "Socios.Correo")

            GestionSocios.numeroDeControlBindingAltaSocios = 1
        End If
        ' Relacionar los campos de la tabla con los textbox

        controlCalculadora = 0

        ' Vaciamos cada textBox de forma individual
        TextBox_NumeroSocio.Clear()
        TextBox_Nombre.Clear()
        TextBox_Apellidos.Clear()
        TextBox_Telefono.Clear()
        TextBox_Correo.Clear()

    End Sub

    ' Validamos este campo evitando que tenga caracteres que no sean númericos y que tenga una longitud de más de 8 caracteres.
    Private Sub TextBox_NumeroSocio_TextChanged(sender As Object, e As EventArgs) Handles TextBox_NumeroSocio.TextChanged
        ' Instanciamos la clase
        Dim validarNumeroSocio As New libreriaValidacion.Validacion

        validarNumeroSocio.validarNumeroSocio(TextBox_NumeroSocio.Text, 1)

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