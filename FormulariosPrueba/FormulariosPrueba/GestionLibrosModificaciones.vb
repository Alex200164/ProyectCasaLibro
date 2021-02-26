' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.ComponentModel
Imports System.Data.OleDb

Public Class GestionLibrosModificaciones
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
    Public adaptador As New OleDbDataAdapter("Select * from Libros", conexion)

    ' Aquí alojaremos los datos de la DB
    Public midataset As New DataSet



    ' Método que se ejecuta cuando el botón "Salir..." del ToolStrip es pulsado y que nos lleva al formulario "GestionLibros".
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        ' Mostramos el formulario "GestionLibros".
        GestionLibros.Show()

        ' Reiniciamos su valor para la próxima vez
        controlCalculadora = 0

        ' Cerramos este formulario
        Me.Close()
    End Sub

    Dim controlCalculadora As Integer

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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Vaciamos cada textBox de forma individual
        TextBox_ISBN.Clear()
        TextBox_Titulo.Clear()
        TextBox_Autor.Clear()
        ComboBox_Genero.ResetText()
        TextBox_Numeropags.Clear()
        TextBox_Editorial.Clear()
        TextBox_Idioma.Clear()
        ComboBox_Encuadernacion.ResetText()
        TextBox_Annoedicion.Clear()
        TextBox_Plazaedicion.Clear()
        TextBox_Traductor.Clear()
        ComboBox_Formato.ResetText()
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

        'Create a new object (Which has a bitmap property). Normally this would be
        'some kind of data structure
        tObject = New TestObject

        If GestionLibros.numeroDeControlBindingModificaciones = 0 Then

            'Se relacionan los campos de la tabla con los textbox y se muestran los datos del registro que queremos modificar.
            Me.TextBox_ISBN.DataBindings.Add("text", midataset, "Libros.ISBN")
            Me.TextBox_Titulo.DataBindings.Add("text", midataset, "Libros.Titulo")
            Me.TextBox_Autor.DataBindings.Add("text", midataset, "Libros.Autor")
            Me.ComboBox_Genero.DataBindings.Add("text", midataset, "Libros.Genero")
            Me.TextBox_Numeropags.DataBindings.Add("text", midataset, "Libros.Paginas")
            Me.TextBox_Editorial.DataBindings.Add("text", midataset, "Libros.Editorial")
            Me.TextBox_Idioma.DataBindings.Add("text", midataset, "Libros.Idioma")
            Me.ComboBox_Encuadernacion.DataBindings.Add("text", midataset, "Libros.Encuadernacion")
            Me.TextBox_Annoedicion.DataBindings.Add("text", midataset, "Libros.Anno_edicion")
            Me.TextBox_Plazaedicion.DataBindings.Add("text", midataset, "Libros.Plaza_de_edicion")
            Me.TextBox_Traductor.DataBindings.Add("text", midataset, "Libros.Traductor")
            Me.ComboBox_Formato.DataBindings.Add("text", midataset, "Libros.Formato")
            Me.TextBox_Precio.DataBindings.Add("text", midataset, "Libros.Precio")
            Me.TextBox_Stock.DataBindings.Add("text", midataset, "Libros.Stock")
            Me.PictureBoxProducto.DataBindings.Add("Image", midataset, "Libros.Foto", True)

            GestionLibros.numeroDeControlBindingModificaciones = 1
        End If

        ' Inicializamos la variable asignandole el número de socio inicial
        ISBNInicial = GestionLibros.DataGridView_Libros.Item(0, GestionLibros.DataGridView_Libros.CurrentRow.Index).Value

        ' Inicializamos la variable de control
        controlCalculadora = 0

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
    Private Sub Button_Modificar_Click(sender As Object, e As EventArgs) Handles Button_Modificar.Click
        If TextBox_ISBN.Text = "" Or TextBox_Titulo.Text = "" Or TextBox_Autor.Text = "" Or ComboBox_Genero.Text = "" Or TextBox_Numeropags.Text = "" Or
            TextBox_Editorial.Text = "" Or TextBox_Idioma.Text = "" Or ComboBox_Encuadernacion.Text = "" Or TextBox_Annoedicion.Text = "" Or
            TextBox_Plazaedicion.Text = "" Or TextBox_Traductor.Text = "" Or ComboBox_Formato.Text = "" Or TextBox_Precio.Text = "" Or TextBox_Stock.Text = "" Then
            MsgBox("Debes seleccionar un registro para actualizarlo y si lo has seleccionado, no debe quedar ningún campo en blanco", MsgBoxStyle.OkOnly, "Error al dar de alta.")
        Else
            Dim mstream As New System.IO.MemoryStream()
            Try
                'Para subir la imagen lo que tenemos que hacer es 
                PictureBoxProducto.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage = mstream.GetBuffer()
                Dim FileSize As UInt64
                FileSize = mstream.Length
                mstream.Close()
                'Acaba Método para meter las imagenes dentro de la base de datos de tipo Largo. 
            Catch ex As System.NullReferenceException
                MsgBox("Ha ocurrido un error, al cargar la imagen.", MsgBoxStyle.OkOnly, "Error (proceso Formato de imagen )")
            End Try

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
                    Dim queryParametrizada As String = "UPDATE Libros SET ISBN=?, Titulo=?, Autor=?, Genero=?, Paginas=?, Editorial=?, Idioma=?, Encuadernacion=?, Anno_edicion=?, Plaza_edicion=?, Traductor=?, Formato=?, Precio=?, Stock=?, Foto=? WHERE ISBN=?"
                    Using cmd = New OleDbCommand(queryParametrizada, conexion)

                        conexion.Open()
                        cmd.Parameters.AddWithValue("@p1", TextBox_ISBN.Text)
                        cmd.Parameters.AddWithValue("@p2", TextBox_Titulo.Text)
                        cmd.Parameters.AddWithValue("@p3", TextBox_Autor.Text)
                        cmd.Parameters.AddWithValue("@p4", ComboBox_Genero.Text)
                        cmd.Parameters.AddWithValue("@p5", Convert.ToInt64(TextBox_Numeropags.Text))
                        cmd.Parameters.AddWithValue("@p6", TextBox_Editorial.Text)
                        cmd.Parameters.AddWithValue("@p7", TextBox_Idioma.Text)
                        cmd.Parameters.AddWithValue("@p8", ComboBox_Encuadernacion.Text)
                        cmd.Parameters.AddWithValue("@p9", Convert.ToInt64(TextBox_Annoedicion.Text))
                        cmd.Parameters.AddWithValue("@p10", TextBox_Plazaedicion.Text)
                        cmd.Parameters.AddWithValue("@p11", TextBox_Traductor.Text)
                        cmd.Parameters.AddWithValue("@p12", ComboBox_Formato.Text)
                        cmd.Parameters.AddWithValue("@p13", Convert.ToDouble(TextBox_Precio.Text))
                        cmd.Parameters.AddWithValue("@p14", Convert.ToInt64(TextBox_Stock.Text))
                        cmd.Parameters.AddWithValue("@p15", mstream.GetBuffer)
                        cmd.Parameters.AddWithValue("@p16", (ISBNInicial))

                        cmd.ExecuteNonQuery()

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
                GestionLibros.midataset.Clear()
                GestionLibros.adaptador.Fill(GestionLibros.midataset, "Libros")

                ' Reiniciamos su valor para la próxima vez
                controlCalculadora = 0

                ' Cerramos la ventana
                Me.Close()


            End If
        End If
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
End Class