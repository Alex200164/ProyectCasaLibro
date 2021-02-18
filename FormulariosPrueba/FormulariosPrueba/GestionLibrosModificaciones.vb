' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb

Public Class GestionLibrosModificaciones

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

    '  Método que se ejecuta al iniciarse el formulario. El cual nos mostrará los datos de la Seleccion que hemos hecho en el DataGridView_Socios del formulario GestionSocios
    '  en los textBox correspondientes. Para esto crearemos un nuevo comando, y lo asociaremos al midataset para obtener los datos que queremos
    Private Sub GestionSociosModificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Creamos un comando nuevo con una Query nueva la cual vamos a usar para poder buscar un socio en concreto
        Dim comando As New OleDbCommand(("select * from Libros where ISBN = @ISBN"), conexion)

        'Al adaptador le asignamos este nuevo comando "comando"
        adaptador.SelectCommand = comando
        'Al comando le vamos a pasar por parametro @numSocio (valor de tipo Numeric, 8) el cual va a ser cogido de la Fila(currentRow) seleccionada de la Columna 0 (NumeroSocio)
        'del DataGridView_Socios del formulario GestionSocios. Es decir al seleccionar un elemento detectará cual es la fila y el valor de la columna 0 y lo pasará por parametro.
        comando.Parameters.Add("@ISBN", OleDbType.Numeric, 13).Value = GestionLibros.DataGridView_Libros.Item(0, GestionLibros.DataGridView_Libros.CurrentRow.Index).Value

        'Limpiamos el midataset para que no haya información residual
        midataset.Clear() 'de este form 
        'Asociamos el nuevo adaptador con el nuevo comando al midataset de la tabla Socios 
        adaptador.Fill(midataset, "Libros")

        'Se relacionan los campos de la tabla con los textbox y se muestran los datos del registro que queremos modificar.
        Me.TextBox_ISBN.DataBindings.Add("text", midataset, "Libros.ISBN")
        Me.TextBox_Titulo.DataBindings.Add("text", midataset, "Libros.Titulo")
        Me.TextBox_Autor.DataBindings.Add("text", midataset, "Libros.Autor/es")
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

    End Sub

    ' Método que se ejecuta al pulsarse el botón "Modificar"
    ' Se encarga de modificar los datos ya existentes en la DB
    'Private Sub Button_Modificar_Click(sender As Object, e As EventArgs) Handles Button_Modificar.Click
    '    If TextBox_NumeroSocio.Text = "" Or TextBox_Nombre.Text = "" Or TextBox_Apellidos.Text = "" Or TextBox_Telefono.Text = "" Or TextBox_Correo.Text = "" Then
    '        MsgBox("Debes seleccionar un registro para actualizarlo y si lo has seleccionado, no debe quedar ningún campo en blanco", MsgBoxStyle.OkOnly, "Error al dar de alta.")
    '    Else
    '        Dim cb As New OleDbCommandBuilder(adaptador)
    '        adaptador.UpdateCommand = cb.GetUpdateCommand

    '        Dim a As Integer = GestionSocios.posicionDataGridSeleccionada

    '        Dim fila As DataRow = GestionSocios.midataset.Tables("Socios").Rows(a)

    '        ' Comenzamos la edición
    '        fila.BeginEdit()
    '        fila("NumeroDeSocio") = TextBox_NumeroSocio.Text
    '        fila("Nombre") = TextBox_Nombre.Text
    '        fila("Apellidos") = TextBox_Apellidos.Text
    '        fila("Telefono") = TextBox_Telefono.Text
    '        fila("Correo") = TextBox_Correo.Text
    '        fila.EndEdit()
    '        ' Finalizamos la edición

    '        ' Ejecutamos la sentencia
    '        adaptador.Update(GestionSocios.midataset.Tables("Socios"))

    '        ' Actualizamos el dataGridView del formulario de gestión principal
    '        GestionSocios.midataset.Clear()
    '        GestionSocios.adaptador.Fill(GestionSocios.midataset, "Socios")

    '        ' Cerramos la ventana
    '        Me.Close()


    '    End If
    'End Sub
End Class