﻿' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb

Public Class GestionArticulosAltas
    'Para poder jugar con las imagenes en la base de datos usamos estas variables 
    Dim imgpath As String
    Dim arrImage() As Byte
    ' Especificamos la base de datos a la que nos vamos a conectar.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=cas_lib_dib.accdb")
    ' Al adaptador le asignamos la conexion que acabamos de realizar y una consulta
    Public adaptador As New OleDbDataAdapter("Select * from Productos", conexion)     

    ' Aquí alojaremos los datos de la DB
    Public midataset As New DataSet

    ' Método que se ejecuta cuando el botón "Salir..." del ToolStrip es pulsado y que nos lleva al formulario "GestionArticulos".
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        ' Mostramos el formulario "GestionArticulos".
        GestionArticulos.Show()

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
                Dim validacion As New libreriaValidacion.Validacion
                validacion.errorLogWrite()
            End Try

            controlCalculadora = controlCalculadora + 1

        Else
            MsgBox("Solo se pueden iniciar dos calculadoras por sesión.", MsgBoxStyle.OkOnly, "Aviso")
        End If
    End Sub

    ' Método que se ejecuta cuando se pulsa el botón "Limpiar".
    ' "Limpia" todos los textBox, dejandolos vacios.
    Private Sub Button_Limpiar_Click(sender As Object, e As EventArgs) Handles Button_Limpiar.Click
        ' Vaciamos cada textBox de forma individual
        TextBox_ISBN.Clear()
        TextBox_Nombre.Clear()
        TextBox_Categoria.Clear()
        TextBox_Precio.Clear()
        TextBox_Stock.Clear()
    End Sub

    ' Método que se ejecuta cuando el botón "Alta" es pulsado. 
    ' Introduce los datos escritos por el usuario en los textBox en la DB.
    Private Sub Button_Alta_Click(sender As Object, e As EventArgs) Handles Button_Alta.Click

        If TextBox_ISBN.Text = "" Or TextBox_Nombre.Text = "" Or TextBox_Categoria.Text = "" Or TextBox_Precio.Text = "" Or TextBox_Stock.Text = "" Then
            MsgBox("No se puede dar de alta , debe rellenar todos los datos.", MsgBoxStyle.OkOnly, "Error al dar de alta.")
        Else


            If arrImage IsNot Nothing AndAlso arrImage.Length > 0 Then
                'Para subir la imagen lo que tenemos que hacer es 
                Dim mstream As New System.IO.MemoryStream()
                PictureBoxProducto.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage = mstream.GetBuffer()
                Dim FileSize As UInt64
                FileSize = mstream.Length
                mstream.Close()
                'Acaba Método para meter las imagenes dentro de la base de datos de tipo Largo. 
            End If



            Dim valor As String
                Dim control As Integer = 0

                ' Comprobamos que la clave primaria no se encuentra ya registrada.
                For contador As Integer = 0 To GestionArticulos.DataGridView_Articulos.RowCount - 1
                    valor = GestionArticulos.DataGridView_Articulos.Item(0, contador).Value

                    If valor = TextBox_ISBN.Text Then
                        MsgBox("No puedes introducir un ISBN que ya existe en la base de datos.", MsgBoxStyle.OkOnly, "Error, clave duplicada")
                        control = 1
                    End If
                Next


                If control = 0 Then
                    Try
                        ' ####################  1º Preparamos a la base de datos para recibir los datos. ##############################
                        Dim cb As New OleDbCommandBuilder(adaptador)
                        adaptador.InsertCommand = cb.GetInsertCommand

                        ' ####################  2º Recogemos los datos y los introducimos ##############################
                        Dim drc As DataRowCollection = midataset.Tables("Productos").Rows
                        drc.Add(TextBox_ISBN.Text, TextBox_Nombre.Text, TextBox_Categoria.Text, TextBox_Precio.Text, TextBox_Stock.Text, arrImage)


                        adaptador.Update(midataset.Tables("Productos"))
                    Catch ex As System.InvalidOperationException
                    ' Avisamos del error por mensaje
                    MsgBox("Algo no ha ido bien, intentalo de nuevo", MsgBoxStyle.OkOnly, "Operación invalida")
                    Dim validacion As New libreriaValidacion.Validacion
                    validacion.errorLogWrite()
                Catch ex2 As System.FormatException
                    ' Avisamos del error por mensaje
                    MsgBox("El formato de los datos introducidos es incorrecto, intentalo de nuevo", MsgBoxStyle.OkOnly, "Operación invalida")
                    Dim validacion As New libreriaValidacion.Validacion
                    validacion.errorLogWrite()
                Catch ex3 As System.Data.OleDb.OleDbException
                    ' Avisamos del error por mensaje
                    MsgBox("Algo no ha ido bien, es la sintaxis correcta?, intentalo de nuevo", MsgBoxStyle.OkOnly, "Operación invalida")
                    Dim validacion As New libreriaValidacion.Validacion
                    validacion.errorLogWrite()
                Catch ex4 As System.NullReferenceException
                    ' Avisamos del error por mensaje
                    MsgBox("Algo no ha ido bien, intentalo de nuevo. Referencia a objeto no establecida como instancia de un objeto.", MsgBoxStyle.OkOnly, "Operación invalida")
                    Dim validacion As New libreriaValidacion.Validacion
                    validacion.errorLogWrite()
                End Try
                    ' ####################  3º Actualizamos el middataset ##############################
                    ' Actualizamos el dataGridView del formulario de gestión principal
                    GestionArticulos.midataset.Clear()
                    GestionArticulos.adaptador.Fill(GestionArticulos.midataset, "Productos")

                    ' Reiniciamos su valor para la próxima vez
                    controlCalculadora = 0

                    ' Cerramos la ventana
                    Me.Close()

                    ' ####################  4º Cambiamos el estado de los botones del menuStrip ##############################
                    ' AltaToolStripMenuItem.Enabled = False
                    ' NuevoToolStripMenuItem.Enabled = True

                    'System.NullReferenceException: 'Referencia a objeto no establecida como instancia de un objeto.'
                    ' System.Data.OleDb.OleDbException: 'Error de sintaxis en la instrucción INSERT INTO.'
                End If

            End If
    End Sub

    '  Método que se ejecuta al iniciarse el formulario.
    Private Sub GestionArticulosAltas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar la memoria del cache con datos.
        adaptador.Fill(midataset, "Productos")

        ' Relacionar los campos de la tabla con los textbox
        If GestionArticulos.numeroDeControlBindingAltaArticulos = 0 Then
            Me.TextBox_ISBN.DataBindings.Add("text", midataset, "Productos.ISBN")
            Me.TextBox_Nombre.DataBindings.Add("text", midataset, "Productos.Nombre")
            Me.TextBox_Categoria.DataBindings.Add("text", midataset, "Productos.Categoria")
            Me.TextBox_Precio.DataBindings.Add("text", midataset, "Productos.Precio")
            Me.TextBox_Stock.DataBindings.Add("text", midataset, "Productos.Stock")

            GestionArticulos.numeroDeControlBindingAltaArticulos = 1
        End If

        ' Inicializamos la variable de control
        controlCalculadora = 0

        ' Vaciamos cada textBox de forma individual
        Me.TextBox_ISBN.Clear()
        Me.TextBox_Nombre.Clear()
        Me.TextBox_Categoria.Clear()
        Me.TextBox_Precio.Clear()
        Me.TextBox_Stock.Clear()

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
            Dim validacion As New libreriaValidacion.Validacion
            validacion.errorLogWrite()
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