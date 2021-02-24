' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb

Public Class GestionEmpleadosAltas

    ' Especificamos la base de datos a la que nos vamos a conectar.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CasaLibroDB.accdb")
    ' Al adaptador le asignamos la conexion que acabamos de realizar y una consulta
    Public adaptador As New OleDbDataAdapter("Select * from Empleados", conexion)

    ' Aquí alojaremos los datos de la DB
    Public midataset As New DataSet

    ' Método que se ejecuta cuando el botón "Salir..." del ToolStrip es pulsado y que nos lleva al formulario "GestionEmpleados".
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        ' Mostramos el formulario "GestionEmpleados".
        GestionEmpleados.Show()

        ' Cerramos este formulario
        Me.Close()
    End Sub

    ' Método que se ejecuta cuando es pulsado el botón "Calculadora" del 
    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        ' Try catch para atrapar el error en caso de que el ordenador del usuario
        Try
            Dim program As String
            program = "calc.exe"
            Process.Start(program)
        Catch ex As System.ComponentModel.Win32Exception '
            MsgBox("Ha ocurrido un error, no se pudo iniciar la calculadora.", MsgBoxStyle.OkOnly, "Error (proceso calculadora)")
        End Try
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

        ' Relacionar los campos de la tabla con los textbox
        Me.TextBox_DNI.DataBindings.Add("text", midataset, "Empleados.DNI")
        Me.TextBox_NOMBRE.DataBindings.Add("text", midataset, "Empleados.Nombre")
        Me.TextBox_APELLIDOS.DataBindings.Add("text", midataset, "Empleados.Apellidos")
        Me.TextBox_CORREO.DataBindings.Add("text", midataset, "Empleados.Correo")
        Me.TextBox_TELEFONO.DataBindings.Add("text", midataset, "Empleados.Telefono")
        Me.TextBox_USUARIO.DataBindings.Add("text", midataset, "Empleados.Usuario")
        Me.TextBox_CONTRASENNA.DataBindings.Add("text", midataset, "Empleados.Contrasenna")
        Me.TextBox_ROL.DataBindings.Add("text", midataset, "Empleados.Rol")


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

            ' Cerramos la ventana
            Me.Close()

            ' ####################  4º Cambiamos el estado de los botones del menuStrip ##############################
            ' AltaToolStripMenuItem.Enabled = False
            ' NuevoToolStripMenuItem.Enabled = True

            'System.NullReferenceException: 'Referencia a objeto no establecida como instancia de un objeto.'
            ' System.Data.OleDb.OleDbException: 'Error de sintaxis en la instrucción INSERT INTO.'



        End If
    End Sub
End Class