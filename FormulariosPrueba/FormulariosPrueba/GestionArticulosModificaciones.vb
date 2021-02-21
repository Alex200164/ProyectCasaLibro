' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb

Public Class GestionArticulosModificaciones

    ' Especificamos la base de datos a la que nos vamos a conectar.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CasaLibroDB.accdb")
    ' Al adaptador le asignamos la conexion que acabamos de realizar y una consulta
    Public adaptador As New OleDbDataAdapter("Select * from Productos", conexion)

    ' Aquí alojaremos los datos de la DB
    Public midataset As New DataSet

    ' Método que se ejecuta cuando el botón "Salir..." del ToolStrip es pulsado y que nos lleva al formulario "GestionArticulos".
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        ' Mostramos el formulario "GestionArticulos".
        GestionArticulos.Show()

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
        TextBox_Nombre.Clear()
        TextBox_Categoria.Clear()
        TextBox_Stock.Clear()
        TextBox_Precio.Clear()
    End Sub

    '  Método que se ejecuta al iniciarse el formulario. El cual nos mostrará los datos de la Seleccion que hemos hecho en el DataGridView_Articulos del formulario GestionArticulos
    '  en los textBox correspondientes. Para esto crearemos un nuevo comando, y lo asociaremos al midataset para obtener los datos que queremos
    Private Sub GestionArticulosModificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Creamos un comando nuevo con una Query nueva la cual vamos a usar para poder buscar un articulo en concreto
        Dim comando As New OleDbCommand(("select * from Productos where ISBN = @ISBN"), conexion)

        'Al adaptador le asignamos este nuevo comando "comando"
        adaptador.SelectCommand = comando
        'Al comando le vamos a pasar por parametro @ISBN (valor de tipo Numeric, 8) el cual va a ser cogido de la Fila(currentRow) seleccionada de la Columna 0 (ISBN)
        'del DataGridView_Aritculos del formulario GestionArituculos. Es decir al seleccionar un elemento detectará cual es la fila y el valor de la columna 0 y lo pasará por parametro.
        comando.Parameters.Add("@ISBN", OleDbType.Numeric, 13).Value = GestionArticulos.DataGridView_Articulos.Item(0, GestionArticulos.DataGridView_Articulos.CurrentRow.Index).Value

        'Limpiamos el midataset para que no haya información residual
        midataset.Clear() 'de este form 
        'Asociamos el nuevo adaptador con el nuevo comando al midataset de la tabla Productos 
        adaptador.Fill(midataset, "Productos")

        'Se relacionan los campos de la tabla con los textbox y se muestran los datos del registro que queremos modificar.
        Me.TextBox_ISBN.DataBindings.Add("text", midataset, "Productos.ISBN")
        Me.TextBox_Nombre.DataBindings.Add("text", midataset, "Productos.Nombre")
        Me.TextBox_Categoria.DataBindings.Add("text", midataset, "Productos.Categoria")
        Me.TextBox_Precio.DataBindings.Add("text", midataset, "Productos.Precio")
        Me.TextBox_Stock.DataBindings.Add("text", midataset, "Productos.Stock")

    End Sub

    ' Método que se ejecuta al pulsarse el botón "Modificar"
    ' Se encarga de modificar los datos ya existentes en la DB
    Private Sub Button_Modificar_Click(sender As Object, e As EventArgs) Handles Button_ModificarProv.Click
        If TextBox_ISBN.Text = "" Or TextBox_Nombre.Text = "" Or TextBox_Categoria.Text = "" Or TextBox_Precio.Text = "" Or TextBox_Stock.Text = "" Then
            MsgBox("Debes seleccionar un registro para actualizarlo y si lo has seleccionado, no debe quedar ningún campo en blanco", MsgBoxStyle.OkOnly, "Error al dar de alta.")
        Else
            Dim cb As New OleDbCommandBuilder(adaptador)
            adaptador.UpdateCommand = cb.GetUpdateCommand

            Dim a As Integer = GestionArticulos.posicionDataGridSeleccionada

            Dim fila As DataRow = GestionArticulos.midataset.Tables("Productos").Rows(a)

            ' Comenzamos la edición
            fila.BeginEdit()
            fila("ISBN") = TextBox_ISBN.Text
            fila("Nombre") = TextBox_Nombre.Text
            fila("Categoria") = TextBox_Categoria.Text
            fila("Precio") = TextBox_Precio.Text
            fila("Stock") = TextBox_Stock.Text
            fila.EndEdit()
            ' Finalizamos la edición

            ' Ejecutamos la sentencia
            adaptador.Update(GestionArticulos.midataset.Tables("Productos"))

            ' Actualizamos el dataGridView del formulario de gestión principal
            GestionArticulos.midataset.Clear()
            GestionArticulos.adaptador.Fill(GestionArticulos.midataset, "Productos")

            ' Cerramos la ventana
            Me.Close()


        End If
    End Sub
End Class