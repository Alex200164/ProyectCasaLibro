' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb

Public Class GestionLibrosAltas

    ' Especificamos la base de datos a la que nos vamos a conectar.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CasaLibroDB.accdb")
    ' Al adaptador le asignamos la conexion que acabamos de realizar y una consulta
    Public adaptador As New OleDbDataAdapter("Select * from Libros", conexion)

    ' Aquí alojaremos los datos de la DB
    Public midataset As New DataSet

    ' Método que se ejecuta cuando el botón "Salir..." del ToolStrip es pulsado y que nos lleva al formulario "GestionLibros".
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        ' Mostramos el formulario "GestionLibros".
        GestionLibros.Show()

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
    Private Sub Button_Limpiar_Click_1(sender As Object, e As EventArgs) Handles Button_Limpiar.Click
        ' Vaciamos cada textBox de forma individual
        TextBox_ISBN.Clear()
        TextBox_Titulo.Clear()
        TextBox_Autor.Clear()
        TextBox_Numeropags.Clear()
        TextBox_Editorial.Clear()
        TextBox_Idioma.Clear()
        TextBox_Encuadernacion.Clear()
        TextBox_Annoedicion.Clear()
        TextBox_Plazaedicion.Clear()
        TextBox_Traductor.Clear()
        TextBox_Formato.Clear()
        TextBox_Precio.Clear()
        TextBox_Stock.Clear()
    End Sub



    ' Método que se ejecuta cuando el botón "Alta" es pulsado. 
    ' Introduce los datos escritos por el usuario en los textBox en la DB.
    Private Sub Button_Alta_Click(sender As Object, e As EventArgs) Handles Button_Alta.Click
        If TextBox_ISBN.Text = "" Or TextBox_Titulo.Text = "" Or TextBox_Autor.Text = "" Or TextBox_Numeropags.Text = "" Or
            TextBox_Editorial.Text = "" Or TextBox_Idioma.Text = "" Or TextBox_Encuadernacion.Text = "" Or TextBox_Annoedicion.Text = "" Or
            TextBox_Plazaedicion.Text = "" Or TextBox_Traductor.Text = "" Or TextBox_Formato.Text = "" Or TextBox_Precio.Text = "" Or TextBox_Stock.Text = "" Then
            MsgBox("No se puede dar de alta , debe rellenar todos los datos.", MsgBoxStyle.OkOnly, "Error al dar de alta.")
        Else

            Dim valor As String
            Dim control As Integer = 0

            ' Comprobamos que la clave primaria no se encuentra ya registrada.
            For contador As Integer = 0 To GestionLibros.DataGridView_Libros.RowCount - 1
                valor = GestionLibros.DataGridView_Libros.Item(0, contador).Value

                If valor = TextBox_ISBN.Text Then
                    MsgBox("No puedes introducir un ISBN que ya existe en la base de datos.", MsgBoxStyle.OkOnly, "Error, clave duplicada")
                    control = 1
                End If
            Next


            If control = 0 Then
                ' ####################  1º Preparamos a la base de datos para recibir los datos. ##############################
                Dim cb As New OleDbCommandBuilder(adaptador)
                adaptador.InsertCommand = cb.GetInsertCommand

                ' ####################  2º Recogemos los datos y los introducimos ##############################
                Dim drc As DataRowCollection = midataset.Tables("Libros").Rows
                drc.Add(TextBox_ISBN.Text, TextBox_Titulo.Text, TextBox_Autor.Text, TextBox_Numeropags.Text, TextBox_Editorial.Text, TextBox_Idioma.Text, TextBox_Encuadernacion.Text,
                    TextBox_Annoedicion.Text, TextBox_Plazaedicion.Text, TextBox_Traductor.Text, TextBox_Formato.Text, TextBox_Precio.Text, TextBox_Stock.Text)

                adaptador.Update(midataset.Tables("Libros"))
                ' ####################  3º Actualizamos el middataset ##############################
                ' Actualizamos el dataGridView del formulario de gestión principal
                GestionLibros.midataset.Clear()
                GestionLibros.adaptador.Fill(GestionLibros.midataset, "Libros")

                ' Cerramos la ventana
                Me.Close()

                ' ####################  4º Cambiamos el estado de los botones del menuStrip ##############################
                ' AltaToolStripMenuItem.Enabled = False
                ' NuevoToolStripMenuItem.Enabled = True

                'System.NullReferenceException: 'Referencia a objeto no establecida como instancia de un objeto.'
                'System.Data.OleDb.OleDbException: 'Error de sintaxis en la instrucción INSERT INTO.'

            End If
        End If
    End Sub

    '  Método que se ejecuta al iniciarse el formulario.
    Private Sub GestionLibrosAltas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar la memoria del cache con datos.
        adaptador.Fill(midataset, "Libros")

        If GestionLibros.numeroDeControlBindingAltaLibros = 0 Then
            ' Relacionar los campos de la tabla con los textbox
            Me.TextBox_ISBN.DataBindings.Add("text", midataset, "Libros.ISBN")
            Me.TextBox_Titulo.DataBindings.Add("text", midataset, "Libros.Titulo")
            Me.TextBox_Autor.DataBindings.Add("text", midataset, "Libros.Autor")
            Me.TextBox_Numeropags.DataBindings.Add("text", midataset, "Libros.Paginas")
            Me.TextBox_Editorial.DataBindings.Add("text", midataset, "Libros.Editorial")
            Me.TextBox_Idioma.DataBindings.Add("text", midataset, "Libros.Idioma")
            Me.TextBox_Encuadernacion.DataBindings.Add("text", midataset, "Libros.Encuadernacion")
            Me.TextBox_Annoedicion.DataBindings.Add("text", midataset, "Libros.Anno_edicion")
            Me.TextBox_Plazaedicion.DataBindings.Add("text", midataset, "Libros.Plaza_de_edicion")
            Me.TextBox_Traductor.DataBindings.Add("text", midataset, "Libros.Traductor")
            Me.TextBox_Formato.DataBindings.Add("text", midataset, "Libros.Formato")
            Me.TextBox_Precio.DataBindings.Add("text", midataset, "Libros.Precio")
            Me.TextBox_Stock.DataBindings.Add("text", midataset, "Libros.Stock")

            GestionLibros.numeroDeControlBindingAltaLibros = 1
        End If

        ' Vaciamos cada textBox de forma individual
        TextBox_ISBN.Clear()
        TextBox_Titulo.Clear()
        TextBox_Autor.Clear()
        TextBox_Numeropags.Clear()
        TextBox_Editorial.Clear()
        TextBox_Idioma.Clear()
        TextBox_Encuadernacion.Clear()
        TextBox_Annoedicion.Clear()
        TextBox_Plazaedicion.Clear()
        TextBox_Traductor.Clear()
        TextBox_Formato.Clear()
        TextBox_Precio.Clear()
        TextBox_Stock.Clear()
    End Sub
End Class