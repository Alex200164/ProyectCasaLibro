' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb

Public Class GestionArticulosModificaciones

    ' Variable para almacenar el ISBN inicial con el que se identificará el registro a modificar.
    Dim ISBNInicial As String

    ' Variable de control que controla que no se recoja más de una vez el valor de la primary key
    Dim numControlPK As Single = 0

    ' Especificamos la base de datos a la que nos vamos a conectar.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CasaLibroDB.accdb")
    ' Al adaptador le asignamos la conexion que acabamos de realizar y una consulta
    Public adaptador As New OleDbDataAdapter("Select * from Productos", conexion)

    ' Aquí alojaremos los datos de la DB
    Public midataset As New DataSet


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

        If GestionArticulos.numeroDeControlBindingModificaciones = 0 Then
            'Se relacionan los campos de la tabla con los textbox y se muestran los datos del registro que queremos modificar.
            Me.TextBox_ISBN.DataBindings.Add("text", midataset, "Productos.ISBN")
            Me.TextBox_Nombre.DataBindings.Add("text", midataset, "Productos.Nombre")
            Me.TextBox_Categoria.DataBindings.Add("text", midataset, "Productos.Categoria")
            Me.TextBox_Precio.DataBindings.Add("text", midataset, "Productos.Precio")
            Me.TextBox_Stock.DataBindings.Add("text", midataset, "Productos.Stock")

            GestionArticulos.numeroDeControlBindingModificaciones = 1
        End If

        ' Inicializamos la variable asignandole el ISBN inicial
        ISBNInicial = GestionArticulos.DataGridView_Articulos.Item(0, GestionArticulos.DataGridView_Articulos.CurrentRow.Index).Value



    End Sub

    ' Método que se ejecuta al pulsarse el botón "Modificar"
    ' Se encarga de modificar los datos ya existentes en la DB
    Private Sub Button_Modificar_Click(sender As Object, e As EventArgs) Handles Button_ModificarProv.Click

        'Para subir la imagen lo que tenemos que hacer es 
        Dim mstream As New System.IO.MemoryStream()
        PictureBoxProducto.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer()
        Dim FileSize As UInt64
        FileSize = mstream.Length
        mstream.Close()
        'Acaba Método para meter las imagenes dentro de la base de datos de tipo Largo. 



        If TextBox_ISBN.Text = "" Or TextBox_Nombre.Text = "" Or TextBox_Categoria.Text = "" Or TextBox_Precio.Text = "" Or TextBox_Stock.Text = "" Then
            MsgBox("Debes seleccionar un registro para actualizarlo y si lo has seleccionado, no debe quedar ningún campo en blanco", MsgBoxStyle.OkOnly, "Error al dar de alta.")
        Else


            Dim valor As String
            Dim control As Integer = 0

            ' Comprobamos que la clave primaria no se encuentra ya registrada.
            For contador As Integer = 0 To GestionArticulos.DataGridView_Articulos.RowCount - 1
                valor = GestionArticulos.DataGridView_Articulos.Item(0, contador).Value

                If valor = TextBox_ISBN.Text And valor <> ISBNInicial Then
                    MsgBox("No puedes introducir un ISBN que ya existe en la base de datos.", MsgBoxStyle.OkOnly, "Error, clave duplicada")
                    control = 1
                End If
            Next


            If control = 0 Then
                Try
                    ' Montamos una query parametrizada.
                    Dim queryParametrizada As String = "UPDATE Productos SET ISBN=?, Nombre=?, Categoria=?, Precio=?, Stock=?, Foto=? WHERE ISBN=?"
                    Using cmd = New OleDbCommand(queryParametrizada, conexion)

                        conexion.Open()
                        cmd.Parameters.AddWithValue("@p1", Convert.ToInt64(TextBox_ISBN.Text))
                        cmd.Parameters.AddWithValue("@p2", TextBox_Nombre.Text)
                        cmd.Parameters.AddWithValue("@p3", TextBox_Categoria.Text)
                        cmd.Parameters.AddWithValue("@p4", Convert.ToDouble(TextBox_Precio.Text))
                        cmd.Parameters.AddWithValue("@p5", Convert.ToInt64(TextBox_Stock.Text))
                        cmd.Parameters.AddWithValue("@p6", arrImage)
                        cmd.Parameters.AddWithValue("@p7", Convert.ToSingle(ISBNInicial))

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

                ' Actualizamos el dataGridView del formulario de gestión principal
                GestionArticulos.midataset.Clear()
                GestionArticulos.adaptador.Fill(GestionArticulos.midataset, "Productos")

                ' Cerramos la ventana
                Me.Close()

            End If
        End If
    End Sub


    ' #####################################################    Métodos varios    ##########################################################################


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

    Dim imgpath As String
    Dim arrImage() As Byte
    Private Sub Button_Examinar_Click(sender As Object, e As EventArgs) Handles Button_Examinar.Click
        Try
            'objeto de openfiledialog
            Dim odf As New OpenFileDialog()
            odf.Title = "Seleccione una imagen del producto"
            'tipo de fichiero
            odf.Filter = "JPG Files|*.jpg"
            'inicio de la ruta
            odf.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

            If odf.ShowDialog() = DialogResult.OK Then
                imgpath = odf.FileName
                PictureBoxProducto.ImageLocation = imgpath

                'Abremos fichiero
                'Dim fs As FileStream = File.Open(odf.FileName, FileMode.Open)
                'cogemos el imagen obj bmp
                '  Dim bmp As New Bitmap()
                'fs.Close()
                'cargamos la foto en el picturebox
                'PictureBoxProducto.Image = Image.FromFile(odf.FileName)
            End If
            odf = Nothing


        Catch ex As Exception
            'aqui buscamos el Error en GestionErrores
            '  Dim buscarError As Boolean = gestionError.mostrarError(Err.Number)

            'guardamos el Exception
            ' errores.guardarError("Excepción nº" & Err.Number & " : " & ex.Message)

            'si no ecuentramos el error mostrar mensaje del exepcion capturada
            ' If buscarError = False Then
            'MsgBox("Error : " & ex.Message, MsgBoxStyle.Exclamation)
            '  End If

        End Try
    End Sub
End Class