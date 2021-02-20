' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb

Public Class GestionSociosAltas

    ' Especificamos la base de datos a la que nos vamos a conectar.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CasaLibroDB.accdb")
    ' Al adaptador le asignamos la conexion que acabamos de realizar y una consulta
    Public adaptador As New OleDbDataAdapter("Select * from Socios", conexion)

    ' Aquí alojaremos los datos de la DB
    Public midataset As New DataSet

    ' Método que se ejecuta cuando el botón "Salir..." del ToolStrip es pulsado y que nos lleva al formulario "GestionSocios".
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        ' Mostramos el formulario "GestionSocios".
        GestionSocios.Show()

        ' Cerramos este formulario
        Me.Close()
    End Sub

    ' Método que se ejecuta cuando es pulsado el botón "Calculadora" del menuStrip
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
            ' ####################  1º Preparamos a la base de datos para recibir los datos. ##############################
            Dim cb As New OleDbCommandBuilder(adaptador)
            adaptador.InsertCommand = cb.GetInsertCommand

            ' ####################  2º Recogemos los datos y los introducimos ##############################
            Dim drc As DataRowCollection = midataset.Tables("Socios").Rows
            drc.Add(TextBox_NumeroSocio.Text, TextBox_Nombre.Text, TextBox_Apellidos.Text, TextBox_Telefono.Text, TextBox_Correo.Text)

            adaptador.Update(midataset.Tables("Socios"))
            ' ####################  3º Actualizamos el middataset ##############################
            ' Actualizamos el dataGridView del formulario de gestión principal
            GestionSocios.midataset.Clear()
            GestionSocios.adaptador.Fill(GestionSocios.midataset, "Socios")

            ' Cerramos la ventana
            Me.Close()

            ' ####################  4º Cambiamos el estado de los botones del menuStrip ##############################
            ' AltaToolStripMenuItem.Enabled = False
            ' NuevoToolStripMenuItem.Enabled = True

            'System.NullReferenceException: 'Referencia a objeto no establecida como instancia de un objeto.'
            ' System.Data.OleDb.OleDbException: 'Error de sintaxis en la instrucción INSERT INTO.'



        End If
    End Sub



    '  Método que se ejecuta al iniciarse el formulario.
    Private Sub GestionSociosAltas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar la memoria del cache con datos.
        adaptador.Fill(midataset, "Socios")

        ' Relacionar los campos de la tabla con los textbox
        TextBox_NumeroSocio.DataBindings.Add("text", midataset, "Socios.NumeroDeSocio")
        TextBox_Nombre.DataBindings.Add("text", midataset, "Socios.Nombre")
        TextBox_Apellidos.DataBindings.Add("text", midataset, "Socios.Apellidos")
        TextBox_Telefono.DataBindings.Add("text", midataset, "Socios.Telefono")
        TextBox_Correo.DataBindings.Add("text", midataset, "Socios.Correo")

        ' Vaciamos cada textBox de forma individual
        TextBox_NumeroSocio.Clear()
        TextBox_Nombre.Clear()
        TextBox_Apellidos.Clear()
        TextBox_Telefono.Clear()
        TextBox_Correo.Clear()

    End Sub
End Class