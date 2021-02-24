﻿' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb

Public Class GestionLibrosModificaciones

    ' Variable para almacenar el ISBN inicial con el que se identificará el registro a modificar.
    Dim ISBNInicial As String

    ' Variable de control que controla que no se recoja más de una vez el valor de la primary key
    Dim numControlPK As Single = 0

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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

    '  Método que se ejecuta al iniciarse el formulario. El cual nos mostrará los datos de la Seleccion que hemos hecho en el DataGridView_Libross del formulario GestionLibros
    '  en los textBox correspondientes. Para esto crearemos un nuevo comando, y lo asociaremos al midataset para obtener los datos que queremos
    Private Sub GestionLibrosModificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Creamos un comando nuevo con una Query nueva la cual vamos a usar para poder buscar un libro en concreto
        Dim comando As New OleDbCommand(("select * from Libros where ISBN = @ISBN"), conexion)

        'Al adaptador le asignamos este nuevo comando "comando"
        adaptador.SelectCommand = comando
        'Al comando le vamos a pasar por parametro @ISBN (valor de tipo Numeric, 8) el cual va a ser cogido de la Fila(currentRow) seleccionada de la Columna 0 (ISBN)
        'del DataGridView_Libros del formulario GestionLibros. Es decir al seleccionar un elemento detectará cual es la fila y el valor de la columna 0 y lo pasará por parametro.
        comando.Parameters.Add("@ISBN", OleDbType.Numeric, 13).Value = GestionLibros.DataGridView_Libros.Item(0, GestionLibros.DataGridView_Libros.CurrentRow.Index).Value

        'Limpiamos el midataset para que no haya información residual
        midataset.Clear() 'de este form 
        'Asociamos el nuevo adaptador con el nuevo comando al midataset de la tabla Libros
        adaptador.Fill(midataset, "Libros")

        If GestionLibros.numeroDeControlBindingModificaciones = 0 Then

            'Se relacionan los campos de la tabla con los textbox y se muestran los datos del registro que queremos modificar.
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

            GestionLibros.numeroDeControlBindingModificaciones = 1
        End If

        ' Inicializamos la variable asignandole el número de socio inicial
        ISBNInicial = GestionLibros.DataGridView_Libros.Item(0, GestionLibros.DataGridView_Libros.CurrentRow.Index).Value

    End Sub

    ' Método que se ejecuta al pulsarse el botón "Modificar"
    ' Se encarga de modificar los datos ya existentes en la DB
    Private Sub Button_Modificar_Click(sender As Object, e As EventArgs) Handles Button_Modificar.Click
        If TextBox_ISBN.Text = "" Or TextBox_Titulo.Text = "" Or TextBox_Autor.Text = "" Or TextBox_Numeropags.Text = "" Or
            TextBox_Editorial.Text = "" Or TextBox_Idioma.Text = "" Or TextBox_Encuadernacion.Text = "" Or TextBox_Annoedicion.Text = "" Or
            TextBox_Plazaedicion.Text = "" Or TextBox_Traductor.Text = "" Or TextBox_Formato.Text = "" Or TextBox_Precio.Text = "" Or TextBox_Stock.Text = "" Then
            MsgBox("Debes seleccionar un registro para actualizarlo y si lo has seleccionado, no debe quedar ningún campo en blanco", MsgBoxStyle.OkOnly, "Error al dar de alta.")
        Else

            Dim valor As String
            Dim control As Integer = 0

            ' Comprobamos que la clave primaria no se encuentra ya registrada.
            For contador As Integer = 0 To GestionLibros.DataGridView_Libros.RowCount - 1
                valor = GestionLibros.DataGridView_Libros.Item(0, contador).Value

                If valor = TextBox_ISBN.Text And valor <> ISBNInicial Then
                    MsgBox("No puedes introducir un ISBN que ya existe en la base de datos.", MsgBoxStyle.OkOnly, "Error, clave duplicada")
                    control = 1
                End If
            Next

            If control = 0 Then
                Try
                    ' Montamos una query parametrizada.
                    Dim queryParametrizada As String = "UPDATE Libros SET ISBN=?, Titulo=?, Autor=?, Paginas=?, Editorial=?, Idioma=?, Encuadernacion=?, 
                                                        Anno_edicion=?, Plaza_edicion=?, Traductor=?, Formato=?, Precio=?, Stock=?,  WHERE ISBN=?"
                    Using cmd = New OleDbCommand(queryParametrizada, conexion)

                        conexion.Open()
                        cmd.Parameters.AddWithValue("@p1", Convert.ToInt64(TextBox_ISBN.Text))
                        cmd.Parameters.AddWithValue("@p2", TextBox_Titulo.Text)
                        cmd.Parameters.AddWithValue("@p3", TextBox_Autor.Text)
                        cmd.Parameters.AddWithValue("@p4", Convert.ToInt64(TextBox_Numeropags.Text))
                        cmd.Parameters.AddWithValue("@p5", TextBox_Editorial.Text)
                        cmd.Parameters.AddWithValue("@p6", TextBox_Idioma.Text)
                        cmd.Parameters.AddWithValue("@p7", TextBox_Encuadernacion.Text)
                        cmd.Parameters.AddWithValue("@p8", Convert.ToInt64(TextBox_Annoedicion.Text))
                        cmd.Parameters.AddWithValue("@p9", TextBox_Plazaedicion.Text)
                        cmd.Parameters.AddWithValue("@p10", TextBox_Traductor.Text)
                        cmd.Parameters.AddWithValue("@p11", TextBox_Formato.Text)
                        cmd.Parameters.AddWithValue("@p12", Convert.ToInt64(TextBox_Precio.Text))
                        cmd.Parameters.AddWithValue("@p13", Convert.ToInt64(TextBox_Stock.Text))
                        cmd.Parameters.AddWithValue("@p14", Convert.ToSingle(ISBNInicial))

                        cmd.ExecuteNonQuery()

                        ' System.FormatException montar try catch

                        conexion.Close()
                    End Using


                    ' Dim cb As New OleDbCommandBuilder(adaptador)
                    ' adaptador.UpdateCommand = cb.GetUpdateCommand
                Catch ex As System.InvalidOperationException
                    ' Avisamos del error por mensaje
                    MsgBox("Algo no ha ido bien, intentalo de nuevo", MsgBoxStyle.OkOnly, "Operación invalida")
                End Try


                'Dim cb As New OleDbCommandBuilder(adaptador)
                'adaptador.UpdateCommand = cb.GetUpdateCommand

                'Dim a As Integer = GestionLibros.posicionDataGridSeleccionada

                'Dim fila As DataRow = GestionLibros.midataset.Tables("Libros").Rows(a)

                '' Comenzamos la edición
                'fila.BeginEdit()
                'fila("ISBN") = TextBox_ISBN.Text
                'fila("Titulo") = TextBox_Titulo.Text
                'fila("Autor") = TextBox_Autor.Text
                'fila("Paginas") = TextBox_Numeropags.Text
                'fila("Editorial") = TextBox_Editorial.Text
                'fila("Idioma") = TextBox_Idioma.Text
                'fila("Encuadernacion") = TextBox_Encuadernacion.Text
                'fila("Anno_edicion") = TextBox_Annoedicion.Text
                'fila("Plaza_de_edicion") = TextBox_Plazaedicion.Text
                'fila("Traductor") = TextBox_Traductor.Text
                'fila("Formato") = TextBox_Formato.Text
                'fila("Precio") = TextBox_Precio.Text
                'fila("Stock") = TextBox_Stock.Text
                'fila.EndEdit()
                '' Finalizamos la edición

                '' Ejecutamos la sentencia
                'adaptador.Update(GestionLibros.midataset.Tables("Libros"))

                ' Actualizamos el dataGridView del formulario de gestión principal
                GestionLibros.midataset.Clear()
                GestionLibros.adaptador.Fill(GestionLibros.midataset, "Libros")

                ' Cerramos la ventana
                Me.Close()


            End If
        End If
    End Sub
End Class