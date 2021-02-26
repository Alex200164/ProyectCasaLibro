' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.ComponentModel
Imports System.Data.OleDb

Public Class GestionArticulosModificaciones
    'Para poder jugar con las imagenes en la base de datos usamos estas variables 
    Dim imgpath As String
    Dim arrImage() As Byte


    ' Variable para almacenar el ISBN inicial con el que se identificará el registro a modificar.
    Dim ISBNInicial As String

    ' Variable de control que controla que no se recoja más de una vez el valor de la primary key
    Dim numControlPK As Single = 0

    ' Especificamos la base de datos a la que nos vamos a conectar.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=cas_lib_dib.accdb")
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

        'Create a new object (Which has a bitmap property). Normally this would be
        'some kind of data structure
        tObject = New TestObject

        If GestionArticulos.numeroDeControlBindingModificaciones = 0 Then
            'Se relacionan los campos de la tabla con los textbox y se muestran los datos del registro que queremos modificar.
            Me.TextBox_ISBN.DataBindings.Add("text", midataset, "Productos.ISBN")
            Me.TextBox_Nombre.DataBindings.Add("text", midataset, "Productos.Nombre")
            Me.TextBox_Categoria.DataBindings.Add("text", midataset, "Productos.Categoria")
            Me.TextBox_Precio.DataBindings.Add("text", midataset, "Productos.Precio")
            Me.TextBox_Stock.DataBindings.Add("text", midataset, "Productos.Stock")
            Me.PictureBoxProducto.DataBindings.Add("Image", midataset, "Productos.Foto", True)

            ' PictureBoxProducto.DataBindings.Add(New Binding("Image", tObject, "TestImage", True, DataSourceUpdateMode.OnPropertyChanged))

            GestionArticulos.numeroDeControlBindingModificaciones = 1
        End If

        ' Inicializamos la variable de control
        controlCalculadora = 0

        ' Inicializamos la variable asignandole el ISBN inicial
        ISBNInicial = GestionArticulos.DataGridView_Articulos.Item(0, GestionArticulos.DataGridView_Articulos.CurrentRow.Index).Value

    End Sub

    '*********************
    Private tObject As TestObject

    'Your test object that has a bitmap as a property
    Public Class TestObject

        'Implement the INotifyPropertyChanged Interface
        Implements INotifyPropertyChanged

        'Create a property changed event
        Private Event PropertyChanged As PropertyChangedEventHandler _
            Implements INotifyPropertyChanged.PropertyChanged

        'Create the routine to call the property changed event
        Protected Sub OnPropertyChanged(ByVal name As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
        End Sub

        'Create a property which holds your bitmap
        Private _TestImage As Bitmap
        Public Property TestImage As Bitmap
            Get
                Return _TestImage
            End Get
            Set(value As Bitmap)
                _TestImage = value

                'call the routine which raises the propertychanged event
                OnPropertyChanged("TestImage")
            End Set
        End Property

    End Class


    ' Método que se ejecuta al pulsarse el botón "Modificar"
    ' Se encarga de modificar los datos ya existentes en la DB
    Private Sub Button_Modificar_Click(sender As Object, e As EventArgs) Handles Button_ModificarProv.Click

        If TextBox_ISBN.Text = "" Or TextBox_Nombre.Text = "" Or TextBox_Categoria.Text = "" Or TextBox_Precio.Text = "" Or TextBox_Stock.Text = "" Then
            MsgBox("Debes seleccionar un registro para actualizarlo y si lo has seleccionado, no debe quedar ningún campo en blanco", MsgBoxStyle.OkOnly, "Error al dar de alta.")
        Else

            Dim mstream As New System.IO.MemoryStream()
            'Para subir la imagen lo que tenemos que hacer es 
            PictureBoxProducto.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt64
            FileSize = mstream.Length
            mstream.Close()
            'Acaba Método para meter las imagenes dentro de la base de datos de tipo Largo. 



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

                    Dim queryParametrizada As String = "UPDATE Productos SET ISBN=?, Nombre=?, Categoria=?, Precio=?, Stock=?, Foto=? WHERE ISBN=?"
                    Using cmd = New OleDbCommand(queryParametrizada, conexion)

                        conexion.Open()
                        cmd.Parameters.AddWithValue("@p1", (TextBox_ISBN.Text))
                        cmd.Parameters.AddWithValue("@p2", TextBox_Nombre.Text)
                        cmd.Parameters.AddWithValue("@p3", TextBox_Categoria.Text)
                        cmd.Parameters.AddWithValue("@p4", Convert.ToDouble(TextBox_Precio.Text))
                        cmd.Parameters.AddWithValue("@p5", Convert.ToInt64(TextBox_Stock.Text))
                        cmd.Parameters.AddWithValue("@p6", mstream.GetBuffer)
                        cmd.Parameters.AddWithValue("@p7", (ISBNInicial))

                        cmd.ExecuteNonQuery()

                        ' System.FormatException montar try catch

                        conexion.Close()
                    End Using


                    Dim cb As New OleDbCommandBuilder(adaptador)
                    adaptador.UpdateCommand = cb.GetUpdateCommand
                Catch ex As System.InvalidOperationException
                    ' Avisamos del error por mensaje
                    MsgBox("Algo no ha ido bien, intentalo de nuevo", MsgBoxStyle.OkOnly, "Operación invalida")
                Catch ex2 As System.Data.OleDb.OleDbException
                    ' Avisamos del error por mensaje
                    MsgBox("Algo no ha ido bien, intentalo de nuevo", MsgBoxStyle.OkOnly, "Operación invalida")
                Catch ex3 As System.FormatException
                    ' Avisamos del error por mensaje
                    MsgBox("Uno de los datos tiene un formato incorrecto, intentalo de nuevo", MsgBoxStyle.OkOnly, "Operación invalida")
                End Try
                ' Actualizamos el dataGridView del formulario de gestión principal
                GestionArticulos.midataset.Clear()
                GestionArticulos.adaptador.Fill(GestionArticulos.midataset, "Productos")


                ' Reiniciamos su valor para la próxima vez
                controlCalculadora = 0

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

    ' Esté método es ejecutado cuando el usuario presiona la tecla "F1"
    Private Sub GestionSocios_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Help.ShowHelp(Me, "CHM\LaCasaDelLibro.chm", "")
    End Sub

    ' Esté método es ejecutado cuando el usuario presiona el botón de ayuda situado en la barra superior.
    ' Muestra un documento de ayuda.
    Private Sub VerLaAyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerLaAyudaToolStripMenuItem.Click
        Help.ShowHelp(Me, "CHM\LaCasaDelLibro.chm", "")
    End Sub

    Private Sub TextBox_ISBN_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ISBN.TextChanged
        ' Instanciamos la clase        
        Dim validarISBN As New libreriaValidacion.Validacion

        If (validarISBN.ValidarISBN(TextBox_ISBN.Text) = False) Then
            TextBox_ISBN.Text = TextBox_ISBN.Text.Substring(0, TextBox_ISBN.Text.Length - 1)
            TextBox_ISBN.SelectionStart = TextBox_ISBN.TextLength
        End If
    End Sub

    Private Sub TextBox_Nombre_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Nombre.TextChanged
        ' Instanciamos la clase        
        Dim validarNombre As New libreriaValidacion.Validacion

        If (validarNombre.validarNombreProducto(TextBox_Nombre.Text) = False) Then
            TextBox_Nombre.Text = TextBox_Nombre.Text.Substring(0, TextBox_Nombre.Text.Length - 1)
            TextBox_Nombre.SelectionStart = TextBox_Nombre.TextLength
        End If
    End Sub

    Private Sub TextBox_Categoria_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Categoria.TextChanged
        ' Instanciamos la clase        
        Dim validarCategoria As New libreriaValidacion.Validacion

        If validarCategoria.validarCategoria(TextBox_Categoria.Text) = False Then
            TextBox_Categoria.Text = TextBox_Categoria.Text.Substring(0, TextBox_Categoria.Text.Length - 1)
            TextBox_Categoria.SelectionStart = TextBox_Categoria.TextLength
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


End Class