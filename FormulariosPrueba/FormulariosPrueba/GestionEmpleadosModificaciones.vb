' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb

' No hace falta hacer imports libValidaciones para instanciar sus clases porque está incluida en el proyecto.
Imports System.IO

Public Class GestionEmpleadosModificaciones

    ' ##################################   Variables para bases de datos   ####################################################

    ' Especificamos la base de datos a la que nos vamos a conectar.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CasaLibroDB.accdb")
    ' Al adaptador le asignamos la conexion que acabamos de realizar y una consulta
    Public adaptador As New OleDbDataAdapter("Select * from Empleados", conexion)

    ' Aquí alojaremos los datos de la DB
    Public midataset As New DataSet

    Dim numDniInicial As String

    ' Método que se ejecuta al iniciarse el formulario
    Private Sub GestionEmpleadosModificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Creamos un comando nuevo con una Query nueva la cual vamos a usar para poder buscar un socio en concreto
        Dim comando As New OleDbCommand(("select * from Empleados where DNI = @numDNI"), conexion)

        'Al adaptador le asignamos este nuevo comando "comando"
        adaptador.SelectCommand = comando
        'Al comando le vamos a pasar por parametro @numSocio (valor de tipo Numeric, 8) el cual va a ser cogido de la Fila(currentRow) seleccionada de la Columna 0 (NumeroSocio)
        'del DataGridView_Socios del formulario GestionSocios. Es decir al seleccionar un elemento detectará cual es la fila y el valor de la columna 0 y lo pasará por parametro.
        comando.Parameters.Add("@numDNI", OleDbType.VarChar, 9).Value = GestionEmpleados.DataGridView_Empleados.Item(0, GestionEmpleados.DataGridView_Empleados.CurrentRow.Index).Value

        'Limpiamos el midataset para que no haya información residual posicionDataGridSeleccionadaEmpleados
        midataset.Clear() 'de este form 
        'Asociamos el nuevo adaptador con el nuevo comando al midataset de la tabla Socios 
        adaptador.Fill(midataset, "Empleados")

        If GestionEmpleados.numeroDeControlBindingModificacionesEmpleados = 0 Then
            'Se relacionan los campos de la tabla con los textbox y se muestran los datos del registro que queremos modificar.
            Me.TextBox_DNI.DataBindings.Add("text", midataset, "Empleados.DNI")
            Me.TextBox_NOMBRE.DataBindings.Add("text", midataset, "Empleados.Nombre")
            Me.TextBox_APELLIDOS.DataBindings.Add("text", midataset, "Empleados.Apellidos")
            Me.TextBox_CORREO.DataBindings.Add("text", midataset, "Empleados.Correo")
            Me.TextBox_TELEFONO.DataBindings.Add("text", midataset, "Empleados.Telefono")
            Me.TextBox_USUARIO.DataBindings.Add("text", midataset, "Empleados.Usuario")
            Me.TextBox_CONTRASENNA.DataBindings.Add("text", midataset, "Empleados.Contrasenna")
            Me.TextBox_ROL.DataBindings.Add("text", midataset, "Empleados.Rol")


            GestionEmpleados.numeroDeControlBindingModificacionesEmpleados = 1
        End If


        ' Inicializamos la variable asignandole el número de socio inicial
        numDniInicial = GestionEmpleados.DataGridView_Empleados.Item(0, GestionEmpleados.DataGridView_Empleados.CurrentRow.Index).Value

        Try

        Catch ex As System.FormatException
            MsgBox("Se ha producido un error, intentelo de nuevo", MsgBoxStyle.OkOnly, "Error - Operación abortada")
        End Try

    End Sub


    ' #####################################################    Métodos varios    ##########################################################################


    ' Método que se ejecuta cuando se pulsa el botón "Limpiar".
    ' "Limpia" todos los textBox, dejandolos vacios.
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

    ' Método que se ejecuta cuando el botón "Salir..." del ToolStrip es pulsado y que nos lleva al formulario "GestionEmpleados".
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        ' Mostramos el formulario "GestionEmpleados".
        GestionEmpleados.Show()

        ' Cerramos este formulario
        Me.Close()
    End Sub

    Dim controlCalculadora As Integer = 0

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

    ' Método que se ejecuta al pulsarse el botón "Modificar"
    ' Se encarga de modificar los datos ya existentes en la DB
    Private Sub Button_Guardar_Alta_Click(sender As Object, e As EventArgs) Handles Button_Guardar_Alta.Click
        If TextBox_DNI.Text = "" Or TextBox_NOMBRE.Text = "" Or TextBox_APELLIDOS.Text = "" Or TextBox_TELEFONO.Text = "" Or TextBox_CORREO.Text = "" Or TextBox_USUARIO.Text = "" Or TextBox_CONTRASENNA.Text = "" Or TextBox_ROL.Text = "" Then
            MsgBox("Debes seleccionar un registro para actualizarlo y si lo has seleccionado, no debe quedar ningún campo en blanco", MsgBoxStyle.OkOnly, "Error al modificar.")
        Else

            ' Validamos todas las cajas y si alguna es incorrecta... salimos del metodo.
            ' Instanciamos la clase
            Dim validarNumeroSocio As New libreriaValidacion.Validacion

            Dim resultado1 As Boolean = validarNumeroSocio.validarDNI(TextBox_DNI.Text, 2)
            Dim resultado2 As Boolean = validarNumeroSocio.validarTelefono(TextBox_TELEFONO.Text, 2)
            Dim resultado3 As Boolean = validarNumeroSocio.validarNombre(TextBox_NOMBRE.Text, 1)
            Dim resultado4 As Boolean = validarNumeroSocio.validarNombre(TextBox_APELLIDOS.Text, 2)
            Dim resultado5 As Boolean = validarNumeroSocio.validarCorreo(TextBox_CORREO.Text, 1)
            Dim resultado6 As Boolean = validarNumeroSocio.validarUsuario(TextBox_USUARIO.Text, 1)
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

                If valor = TextBox_DNI.Text And valor <> numDniInicial Then
                    MsgBox("No puedes introducir un DNI que ya existe en la base de datos.", MsgBoxStyle.OkOnly, "Error, clave duplicada")
                    control = 1
                End If
            Next

            If control = 0 Then
                ' Try
                ' Montamos una query parametrizada.
                Dim queryParametrizada As String = "UPDATE Empleados SET DNI=?, Nombre=?, Apellidos=?, Correo=? WHERE DNI=?"
                Using cmd = New OleDbCommand(queryParametrizada, conexion)
                    conexion.Open()

                    cmd.Parameters.AddWithValue("@p1", TextBox_DNI.Text)
                    cmd.Parameters.AddWithValue("@p2", TextBox_NOMBRE.Text)
                    cmd.Parameters.AddWithValue("@p3", TextBox_APELLIDOS.Text)
                    cmd.Parameters.AddWithValue("@p4", TextBox_CORREO.Text)

                    cmd.Parameters.AddWithValue("@p5", numDniInicial)

                    ' System.FormatException montar try catch System.Data.OleDb.OleDbException

                    cmd.ExecuteNonQuery()

                    conexion.Close()

                End Using

                Dim queryParametrizada2 As String = "UPDATE Empleados SET Telefono=?, Usuario=? WHERE DNI=?"
                Using cmd2 = New OleDbCommand(queryParametrizada2, conexion)

                    conexion.Open()

                    cmd2.Parameters.AddWithValue("@p1", Convert.ToSingle(TextBox_TELEFONO.Text))
                    cmd2.Parameters.AddWithValue("@p2", TextBox_USUARIO.Text)
                    cmd2.Parameters.AddWithValue("@p3", numDniInicial)

                    cmd2.ExecuteNonQuery()

                    conexion.Close()

                End Using

                Dim queryParametrizada3 As String = "UPDATE Empleados SET Contrasenna=?, Rol=? WHERE DNI=?"
                Using cmd3 = New OleDbCommand(queryParametrizada3, conexion)

                    conexion.Open()

                    cmd3.Parameters.AddWithValue("@p1", Convert.ToInt16(TextBox_CONTRASENNA.Text))
                    cmd3.Parameters.AddWithValue("@p2", TextBox_ROL.Text)
                    cmd3.Parameters.AddWithValue("@p3", numDniInicial)
                    'Try
                    cmd3.ExecuteNonQuery()
                        'Catch ex As System.Data.OleDb.OleDbException

                        'End Try

                        conexion.Close()

                End Using


                ' Dim cb As New OleDbCommandBuilder(adaptador)
                ' adaptador.UpdateCommand = cb.GetUpdateCommand
                'Catch ex As System.InvalidOperationException
                ' Avisamos del error por mensaje
                '  MsgBox("Algo no ha ido bien, intentalo de nuevo", MsgBoxStyle.OkOnly, "Operación invalida")
                'End Try

                ' Actualizamos el dataGridView del formulario de gestión principal
                GestionEmpleados.midataset.Clear()
                GestionEmpleados.adaptador.Fill(GestionEmpleados.midataset, "Empleados")

                ' Cerramos la ventana
                Me.Close()

                ' Hacer try-catch
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