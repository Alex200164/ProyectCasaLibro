' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb

' No hace falta hacer imports libValidaciones para instanciar sus clases porque está incluida en el proyecto.
Imports System.IO

Public Class GestionLibrosAltas

    ' Especificamos la base de datos a la que nos vamos a conectar.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=cas_lib_dib.accdb")
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
        'ComboBox_Encuadernacion.Clear()
        ComboBox_Encuadernacion.ResetText()
        TextBox_Annoedicion.Clear()
        TextBox_Plazaedicion.Clear()
        TextBox_Traductor.Clear()
        ComboBox_Formato.ResetText()
        TextBox_Precio.Clear()
        TextBox_Stock.Clear()
    End Sub



    ' Método que se ejecuta cuando el botón "Alta" es pulsado. 
    ' Introduce los datos escritos por el usuario en los textBox en la DB.
    Private Sub Button_Alta_Click(sender As Object, e As EventArgs) Handles Button_Alta.Click
        If TextBox_ISBN.Text = "" Or TextBox_Titulo.Text = "" Or TextBox_Autor.Text = "" Or TextBox_Numeropags.Text = "" Or
            TextBox_Editorial.Text = "" Or TextBox_Idioma.Text = "" Or ComboBox_Encuadernacion.Text = "" Or TextBox_Annoedicion.Text = "" Or
            TextBox_Plazaedicion.Text = "" Or TextBox_Traductor.Text = "" Or ComboBox_Formato.Text = "" Or TextBox_Precio.Text = "" Or TextBox_Stock.Text = "" Then
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
                drc.Add(TextBox_ISBN.Text, TextBox_Titulo.Text, TextBox_Autor.Text, TextBox_Numeropags.Text, TextBox_Editorial.Text, TextBox_Idioma.Text, ComboBox_Encuadernacion.Text,
                    TextBox_Annoedicion.Text, TextBox_Plazaedicion.Text, TextBox_Traductor.Text, ComboBox_Formato.Text, TextBox_Precio.Text, TextBox_Stock.Text)

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
        'Se quita todo*******************************************************************************************
    End Sub

    Private Sub TextBox_ISBN_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ISBN.TextChanged
        ' Instanciamos la clase        
        Dim validarISBN As New libreriaValidacion.Validacion

        If (validarISBN.ValidarISBN(TextBox_ISBN.Text) = False) Then
            TextBox_ISBN.Text = TextBox_ISBN.Text.Substring(0, TextBox_ISBN.Text.Length - 1)
            TextBox_ISBN.SelectionStart = TextBox_ISBN.TextLength
        End If

    End Sub

    Private Sub TextBox_Titulo_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Titulo.TextChanged
        ' Instanciamos la clase        
        Dim validarTitulo As New libreriaValidacion.Validacion

        If (validarTitulo.validarTitulolibro(TextBox_Titulo.Text) = False) Then
            TextBox_Titulo.Text = TextBox_Titulo.Text.Substring(0, TextBox_Titulo.Text.Length - 1)
            TextBox_Titulo.SelectionStart = TextBox_Titulo.TextLength
        End If
    End Sub

    Private Sub TextBox_Autor_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Autor.TextChanged
        ' Instanciamos la clase        
        Dim validarAutor As New libreriaValidacion.Validacion

        If (validarAutor.validarAutor(TextBox_Autor.Text) = False) Then
            TextBox_Autor.Text = TextBox_Autor.Text.Substring(0, TextBox_Autor.Text.Length - 1)
            TextBox_Autor.SelectionStart = TextBox_Autor.TextLength
        End If
    End Sub

    Private Sub TextBox_Numeropags_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Numeropags.TextChanged
        ' Instanciamos la clase        
        Dim validarpaginas As New libreriaValidacion.Validacion

        If (validarpaginas.validar4digitos(TextBox_Numeropags.Text) = False) Then
            TextBox_Numeropags.Text = TextBox_Numeropags.Text.Substring(0, TextBox_Numeropags.Text.Length - 1)
            TextBox_Numeropags.SelectionStart = TextBox_Numeropags.TextLength
        End If
    End Sub

    Private Sub TextBox_Editorial_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Editorial.TextChanged
        ' Instanciamos la clase        
        Dim validarEditorial As New libreriaValidacion.Validacion

        If (validarEditorial.validarEditorial(TextBox_Editorial.Text) = False) Then
            TextBox_Editorial.Text = TextBox_Editorial.Text.Substring(0, TextBox_Editorial.Text.Length - 1)
            TextBox_Editorial.SelectionStart = TextBox_Editorial.TextLength
        End If
    End Sub

    Private Sub TextBox_Idioma_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Idioma.TextChanged
        ' Instanciamos la clase        
        Dim validarIdioma As New libreriaValidacion.Validacion

        If validarIdioma.validarIdioma(TextBox_Idioma.Text) = False Then
            TextBox_Idioma.Text = TextBox_Idioma.Text.Substring(0, TextBox_Idioma.Text.Length - 1)
            TextBox_Idioma.SelectionStart = TextBox_Idioma.TextLength
        End If
    End Sub

    Private Sub TextBox_Annoedicion_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Annoedicion.TextChanged
        ' Instanciamos la clase        
        Dim validarAnnoedicion As New libreriaValidacion.Validacion

        If (validarAnnoedicion.validar4digitos(TextBox_Annoedicion.Text) = False) Then
            TextBox_Annoedicion.Text = TextBox_Annoedicion.Text.Substring(0, TextBox_Annoedicion.Text.Length - 1)
            TextBox_Annoedicion.SelectionStart = TextBox_Annoedicion.TextLength
        End If
    End Sub

    Private Sub TextBox_Plazaedicion_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Plazaedicion.TextChanged '******
        ' Instanciamos la clase        
        Dim validarPlazaEdicion As New libreriaValidacion.Validacion

        If (validarPlazaEdicion.validarPlazaEdicion(TextBox_Plazaedicion.Text, 1) = False) Then
            TextBox_Plazaedicion.Text = TextBox_Plazaedicion.Text.Substring(0, TextBox_Plazaedicion.Text.Length - 1)
            TextBox_Plazaedicion.SelectionStart = TextBox_Plazaedicion.TextLength
        End If
    End Sub

    Private Sub TextBox_Traductor_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Traductor.TextChanged '********
        ' Instanciamos la clase        
        Dim validarTraductor As New libreriaValidacion.Validacion

        If (validarTraductor.validarTraductor(TextBox_Traductor.Text) = False) Then
            TextBox_Traductor.Text = TextBox_Traductor.Text.Substring(0, TextBox_Traductor.Text.Length - 1)
            TextBox_Traductor.SelectionStart = TextBox_Traductor.TextLength
        End If
    End Sub
    Private Sub TextBox_Precio_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Precio.TextChanged
        ' Instanciamos la clase        
        Dim validarPrecio As New libreriaValidacion.Validacion


        If (validarPrecio.validarPrecio(TextBox_Precio.Text) = False) Then
            TextBox_Precio.Text = TextBox_Precio.Text.Substring(0, TextBox_Precio.Text.Length - 1)
            TextBox_Precio.SelectionStart = TextBox_Precio.TextLength
        End If
    End Sub

    Private Sub TextBox_Stock_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Stock.TextChanged
        ' Instanciamos la clase        
        Dim validarStock As New libreriaValidacion.Validacion


        If (validarStock.validar4digitos(TextBox_Stock.Text) = False) Then
            TextBox_Stock.Text = TextBox_Stock.Text.Substring(0, TextBox_Stock.Text.Length - 1)
            TextBox_Stock.SelectionStart = TextBox_Stock.TextLength
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