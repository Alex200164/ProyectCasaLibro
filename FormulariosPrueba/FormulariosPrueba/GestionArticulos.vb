' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb

' No hace falta hacer imports libValidaciones para instanciar sus clases porque está incluida en el proyecto.
Imports System.IO

Public Class GestionArticulos



    ' Especificamos la base de datos a la que nos vamos a conectar.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CasaLibroDB.accdb")
    ' Al adaptador le asignamos la conexion que acabamos de realizar y una consulta
    Public adaptador As New OleDbDataAdapter("Select * from Productos", conexion)

    'Declaramos el botón  Modificar que será creado dinamicamente junto a los resgistros del DataGridView.
    Public button_din_modificar As New DataGridViewButtonColumn
    'Creamos in estilo que aplicaremos a las caracteristicas del botón Modificar.
    Public style As New DataGridViewCellStyle

    ' Aquí alojaremos los datos de la DB
    Public midataset As New DataSet

    ' Número de control para controlar el dataBinding de los text boxes del formulario modificaciones, evitando que se relacionen dos veces.
    Public numeroDeControlBindingModificaciones As Long

    Public numeroDeControlBindingAltaArticulos As Long

    Public posicionDataGridSeleccionada As Integer

    ' Método que se ejecuta al iniciarse el formulario
    Private Sub GestionArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Cargar la memoria del cache con datos.
            adaptador.Fill(midataset, "Productos")

            Me.TextBox_ISBNOCULTO.DataBindings.Add("text", midataset, "Productos.ISBN")

            'Cargar en el datagridview, le decimos de donde sacamos los datos
            DataGridView_Articulos.DataSource = midataset
            DataGridView_Articulos.DataMember = "Productos"

            ' Inicializamos el número de control
            numeroDeControlBindingModificaciones = 0
            numeroDeControlBindingAltaArticulos = 0

            'Creación en la ultima columna del DataGridView el botón de modificar en cada registro.
            crearButtonDataGridView()

        Catch ex As System.Data.OleDb.OleDbException
            MsgBox("Parece que algo ha salido mal. Revise que la base de datos no esté abierta durante la ejecución.", MsgBoxStyle.OkOnly, "Error - Base de datos")

            ' Especificamos la posición de la ventana
            posicionarFormularioMenuPrincipal()

            ' Mostramos el menú principal.
            MenuPrincipal.Show()

            ' Cerramos este formulario
            Me.Close()

        End Try
    End Sub

    ' Método que se ejecuta al pulsar en una de las cajas del DataGridView
    Private Sub DataGridView_Articulos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Articulos.CellClick
        posicionDataGridSeleccionada = BindingContext(midataset, "Productos").Position
        Button_Eliminar.Enabled = True
    End Sub

    ' Método que permite posicionar la ventana en la posición especificada del formulario "GestionArticulosAltas".
    ' En este caso para evitar que quede encima del formulario anterior.
    Private Shared Sub posicionarGestionAltas()
        GestionArticulosAltas.StartPosition = FormStartPosition.Manual
        Dim a As Integer
        a = My.Computer.Screen.Bounds.Size.Width - (My.Computer.Screen.Bounds.Size.Width * 0.55)
        Dim b As Integer
        b = My.Computer.Screen.Bounds.Size.Height - (My.Computer.Screen.Bounds.Size.Height * 0.8)
        GestionArticulosAltas.Location = New Point(a, b)
    End Sub

    ' Método que permite posicionar la ventana en la posición especificada del formulario "GestionArticulosModificaciones".
    ' En este caso para evitar que quede encima del formulario anterior.
    Private Shared Sub posicionarGestionModificaciones()
        GestionArticulosModificaciones.StartPosition = FormStartPosition.Manual
        Dim a As Integer
        a = My.Computer.Screen.Bounds.Size.Width - (My.Computer.Screen.Bounds.Size.Width * 0.55)
        Dim b As Integer
        b = My.Computer.Screen.Bounds.Size.Height - (My.Computer.Screen.Bounds.Size.Height * 0.8)
        GestionArticulosModificaciones.Location = New Point(a, b)
    End Sub

    ' Método que permite posicionar la ventana en la posición especificada del formulario "MenuPrincipal".
    ' En este caso para evitar que quede encima del formulario anterior.
    Private Shared Sub posicionarFormularioMenuPrincipal()
        MenuPrincipal.StartPosition = FormStartPosition.Manual
        Dim a As Integer
        a = My.Computer.Screen.Bounds.Size.Width - (My.Computer.Screen.Bounds.Size.Width * 0.97)
        Dim b As Integer
        b = My.Computer.Screen.Bounds.Size.Height - (My.Computer.Screen.Bounds.Size.Height * 0.97)
        MenuPrincipal.Location = New Point(a, b)
    End Sub

    ' Método que se ejecuta cuando el botón "Añadir" es pulsado.
    Private Sub Button_Annadir_Click(sender As Object, e As EventArgs) Handles Button_Annadir.Click
        ' Posicionamos el formulario que vamos a mostrar.
        posicionarGestionAltas()
        ' Mostramos el formulario
        GestionArticulosAltas.ShowDialog()
    End Sub


    'Método que crea y da formato al botón de modificar, en cada una de los registros del DataGridView. 
    'Este bóton abrirá el formulario de GestionArticulosModificaciones. 
    Public Sub crearButtonDataGridView()
        'style.BackColor when the button Is Not selected
        style.BackColor = Color.White

        'Le asignamos un nombre   
        button_din_modificar.Name = "Modificar"
        'Le asignamos un tamaño
        button_din_modificar.Width = 50
        'declare a DataGridViewCellStyle
        button_din_modificar.FlatStyle = FlatStyle.Popup

        'Cargar en la ultima columna del DataGridView, la creación y el estilo del botón interno.
        DataGridView_Articulos.Columns.Add(button_din_modificar)
    End Sub

    'Metodo evento que capta la puslación en la celda relativa al botón. 
    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) Handles DataGridView_Articulos.CellContentClick

        'Convierte el objeto en sender
        Dim senderGrid = DirectCast(sender, DataGridView)

        'Comprueba que es una columna del data gridview que tiene el evento y que tiene indice mayor que 0
        'Si es correcto se ejecutará el comando de abrir GestionArticulosModificaciones
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            ' Posicionamos el formulario que vamos a mostrar.
            posicionarGestionModificaciones()
            ' Mostramos el formulario
            GestionArticulosModificaciones.ShowDialog()

            'System.ArgumentException hacer expecion try catch***************************


        End If
    End Sub

    'Metodo que pinta el Icono asociado al botón dinámico Modificar, el la ultima Columna del DataGridView
    Private Sub DataGridView1_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles DataGridView_Articulos.CellPainting
        If e.ColumnIndex = 6 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            'Liena de código que calcula la posicion de el dibujo en concreto.
            e.Graphics.DrawImage(My.Resources.modificar_ico, CInt((e.CellBounds.Width / 2) - (My.Resources.modificar_ico.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.modificar_ico.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
    End Sub

    'Metodo que detecta que botón se ha pulsado y envia la orden  de posicionar a: 
    'GestionLibros/GestionEmpleados/GestionSocios
    Private Sub posicionarFormulariosGestiones(ByVal btn_Name As String)
        'Especifica que el tipo de posicion de arranque será manual para Gestión Libros
        GestionLibros.StartPosition = FormStartPosition.Manual
        'Especifica que el tipo de posicion de arranque será manual para Gestión Empleados
        GestionEmpleados.StartPosition = FormStartPosition.Manual
        'Especifica que el tipo de posicion de arranque será manual para Gestión Socios
        GestionSocios.StartPosition = FormStartPosition.Manual

        'Varaible tipo Integer que calculará la posición vertical en la que ubicará el nuevo formulario
        Dim a As Integer
        a = My.Computer.Screen.Bounds.Size.Width - (My.Computer.Screen.Bounds.Size.Width * 0.97)

        'Varaible tipo Integer que calculará la posición horizontal en la que ubicará el nuevo formulario
        Dim b As Integer
        b = My.Computer.Screen.Bounds.Size.Width - (My.Computer.Screen.Bounds.Size.Width * 0.97)

        'Condición que compará el nombre del botón recibido como parametro con la cadena correspondiente a dicho botón.
        If btn_Name.Equals("gestiónlibrostoolstripmenuitem1") Then
            GestionLibros.Location = New Point(a, b) 'Posiciona en las coordenadas a y b     
        ElseIf btn_Name.Equals("gestiónempleadostoolstripmenuitem1") Then
            GestionEmpleados.Location = New Point(a, b) 'Posiciona en las coordenadas a y b
        ElseIf btn_Name.Equals("gestiónsociostoolstripmenuitem1") Then
            GestionSocios.Location = New Point(a, b) 'Posiciona en las coordenadas a y b
        End If
    End Sub

    ' Método que se ejecuta cuando es pulsado el botón "Gestion de Libros" del menuStrip
    Private Sub GestiónLibrosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GestiónLibrosToolStripMenuItem1.Click
        'Variable que nos dice cual es el Nombre del ToolStripMenuItem pulsado
        Dim item_Name As String = DirectCast(sender, ToolStripMenuItem).Name.ToLower.Replace("clear", "")

        'Confirmación sobre cambio de formulario
        If MsgBox("¿Está seguro de que desea cambiar de formulario?", 36, "Salir") = 6 Then
            Me.Hide() 'Ocultamos este formulario

            'Invocamos al método que posiciona el Formulario de Gestion
            posicionarFormulariosGestiones(item_Name)

            GestionLibros.Show()
        End If
    End Sub

    ' Método que se ejecuta cuando es pulsado el botón "Gestion de Socios" del menuStrip
    Private Sub GestiónDeSociosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónSociosToolStripMenuItem1.Click
        'Variable que nos dice cual es el Nombre del ToolStripMenuItem pulsado
        Dim item_Name As String = DirectCast(sender, ToolStripMenuItem).Name.ToLower.Replace("clear", "")

        'Confirmación sobre cambio de formulario
        If MsgBox("¿Está seguro de que desea cambiar de formulario?", 36, "Salir") = 6 Then
            Me.Hide() 'Ocultamos este formulario

            'Invocamos al método que posiciona el Formulario de Gestion
            posicionarFormulariosGestiones(item_Name)

            GestionSocios.Show()
        End If
    End Sub

    ' Método que se ejecuta cuando es pulsado el botón "Gestion de Empleados" del menuStrip
    Private Sub GestiónEmpleadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GestiónEmpleadosToolStripMenuItem1.Click
        'Variable que nos dice cual es el Nombre del ToolStripMenuItem pulsado
        Dim item_Name As String = DirectCast(sender, ToolStripMenuItem).Name.ToLower.Replace("clear", "")

        'Confirmación sobre cambio de formulario
        If MsgBox("¿Está seguro de que desea cambiar de formulario?", 36, "Salir") = 6 Then
            Me.Hide() 'Ocultamos este formulario

            'Invocamos al método que posiciona el Formulario de Gestion
            posicionarFormulariosGestiones(item_Name)

            GestionEmpleados.Show()
        End If
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

    ' Método que se ejecuta cuando el botón "Salir..." del ToolStrip es pulsado y que nos lleva al formulario "MenuPrincipal"
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        ' Especificamos la posición de la ventana
        posicionarFormularioMenuPrincipal()

        ' Mostramos el menú principal.
        MenuPrincipal.Show()


        ' Cerramos este formulario
        Me.Close()
    End Sub

    ' Método que se ejecuta al pulsar el botón "Eliminar"
    Private Sub Button_Eliminar_Click(sender As Object, e As EventArgs) Handles Button_Eliminar.Click
        Try
            If TextBox_ISBNOCULTO.Text = "" Then
                MsgBox("Debes seleccionar un registro para eliminarlo")
            Else
                ' ####################  1º Informaros a la DB de que vamos a eliminar un registro ##############################
                Dim cb As New OleDbCommandBuilder(adaptador)
                adaptador.DeleteCommand = cb.GetDeleteCommand

                ' ####################  2º Cambiamos el estado de los botones del menuStrip ##############################
                Dim res As Integer
                res = MsgBox("¿Estás seguro de que quieres eliminar?", MsgBoxStyle.YesNo)
                If res = vbYes Then

                    If BindingContext(midataset, "Productos").Count > 0 Then
                        BindingContext(midataset, "Productos").RemoveAt(BindingContext(midataset, "Productos").Position)
                    End If

                    If BindingContext(midataset, "Productos").Count = 0 Then
                        Button_Eliminar.Enabled = False
                    End If
                End If
                ' ####################  3º Cambiamos el estado de los botones del menuStrip ##############################
                adaptador.Update(midataset.Tables("Productos"))

                midataset.Clear()
                adaptador.Fill(midataset, "Productos")

                DataGridView_Articulos.DataSource = midataset
                DataGridView_Articulos.DataMember = "Productos"
                ' registro()
                ' ####################  4º Cambiamos el estado de los botones del menuStrip ##############################
                Button_Eliminar.Enabled = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Método que se ejecuta cuando el botón limpiar es presionado.
    ' Limpia todos los textBoxes del formulario
    Private Sub Button_Limpiar_Click(sender As Object, e As EventArgs) Handles Button_Limpiar.Click
        TextBox_ISBN.Clear()
        TextBox_Nombre.Clear()
        TextBox_Categoria.Clear()
        TextBox_Precio.Clear()

        ' Actualizamos el datagriview
        midataset.Clear()


        ' Cargar la memoria del cache con datos.
        adaptador.Fill(midataset, "Productos")

        ' cargar en el datagridview, le decimos de donde sacamos los datos
        DataGridView_Articulos.DataSource = midataset
        DataGridView_Articulos.DataMember = "Productos"
    End Sub

    ' Método que se ejecuta cuando el botón "Buscar" es pulsado
    ' Buscará en la DB utilizando los datos introducidos por el usuario en los TextBoxes
    Private Sub Button_Buscar_Click(sender As Object, e As EventArgs) Handles Button_Buscar.Click

        ' Comprobamos que haya datos en los textBoxes (por lo menos en uno de ellos)
        If TextBox_ISBN.Text = "" And TextBox_Nombre.Text = "" And TextBox_Categoria.Text = "" And TextBox_Precio.Text = "" Then
            MsgBox("No se puede buscar , debe rellenar al menos una caja con datos.", MsgBoxStyle.OkOnly, "Error al buscar.")
        Else

            ' Si se ha introducido todo
            If TextBox_ISBN.Text <> "" And TextBox_Nombre.Text <> "" And TextBox_Categoria.Text <> "" And TextBox_Precio.Text <> "" Then
                Dim ds As New DataSet

                Dim cb As New OleDbDataAdapter

                Dim comando As New OleDbCommand("Select * from Productos WHERE ISBN LIKE? and Nombre LIKE? and Categoria LIKE? and Precio LIKE?", conexion)

                cb.SelectCommand = comando

                comando.Parameters.Add("@var1", OleDbType.Integer, 15).Value = Convert.ToInt64(TextBox_ISBN.Text)
                comando.Parameters.Add("@var2", OleDbType.VarChar, 50).Value = TextBox_Nombre.Text
                comando.Parameters.Add("@var3", OleDbType.VarChar, 50).Value = TextBox_Categoria.Text
                comando.Parameters.Add("@var4", OleDbType.Integer, 15).Value = Convert.ToInt64(TextBox_Precio.Text)

                midataset.Clear()

                cb.Fill(midataset, "Productos")

                DataGridView_Articulos.DataSource = midataset

                DataGridView_Articulos.DataMember = "Productos"
            End If



            ' ISBN Nombre Categoria
            If TextBox_ISBN.Text <> "" And TextBox_Nombre.Text <> "" And TextBox_Categoria.Text <> "" And TextBox_Precio.Text = "" Then
                Dim ds As New DataSet

                Dim cb As New OleDbDataAdapter

                Dim comando As New OleDbCommand("Select * from Productos WHERE ISBN LIKE? and Nombre LIKE? and Categoria LIKE? ", conexion)

                cb.SelectCommand = comando

                comando.Parameters.Add("@var1", OleDbType.Integer, 15).Value = Convert.ToInt64(TextBox_ISBN.Text)
                comando.Parameters.Add("@var2", OleDbType.VarChar, 50).Value = TextBox_Nombre.Text
                comando.Parameters.Add("@var3", OleDbType.VarChar, 50).Value = TextBox_Categoria.Text

                midataset.Clear()

                cb.Fill(midataset, "Productos")

                DataGridView_Articulos.DataSource = midataset

                DataGridView_Articulos.DataMember = "Productos"
            End If

            ' Nombre Categoria Precio
            If TextBox_ISBN.Text = "" And TextBox_Nombre.Text <> "" And TextBox_Categoria.Text <> "" And TextBox_Precio.Text <> "" Then
                Dim ds As New DataSet

                Dim cb As New OleDbDataAdapter

                Dim comando As New OleDbCommand("Select * from Productos WHERE Nombre LIKE? and Categoria LIKE? and Precio LIKE?", conexion)

                cb.SelectCommand = comando

                comando.Parameters.Add("@var1", OleDbType.VarChar, 50).Value = TextBox_Nombre.Text
                comando.Parameters.Add("@var2", OleDbType.VarChar, 50).Value = TextBox_Categoria.Text
                comando.Parameters.Add("@var3", OleDbType.Integer, 15).Value = Convert.ToInt64(TextBox_Precio.Text)

                midataset.Clear()

                cb.Fill(midataset, "Productos")

                DataGridView_Articulos.DataSource = midataset

                DataGridView_Articulos.DataMember = "Productos"
            End If

            ' ISBN Categoria Precio
            If TextBox_ISBN.Text <> "" And TextBox_Nombre.Text = "" And TextBox_Categoria.Text <> "" And TextBox_Precio.Text <> "" Then
                Dim ds As New DataSet

                Dim cb As New OleDbDataAdapter

                Dim comando As New OleDbCommand("Select * from Productos WHERE ISBN LIKE? and Categoria LIKE? and Precio LIKE?", conexion)

                cb.SelectCommand = comando

                comando.Parameters.Add("@var1", OleDbType.Integer, 15).Value = Convert.ToInt64(TextBox_ISBN.Text)
                comando.Parameters.Add("@var2", OleDbType.VarChar, 50).Value = TextBox_Categoria.Text
                comando.Parameters.Add("@var3", OleDbType.Integer, 15).Value = Convert.ToInt64(TextBox_Precio.Text)

                midataset.Clear()

                cb.Fill(midataset, "Productos")

                DataGridView_Articulos.DataSource = midataset

                DataGridView_Articulos.DataMember = "Productos"
            End If

            ' ISBN Nombre Precio
            If TextBox_ISBN.Text <> "" And TextBox_Nombre.Text <> "" And TextBox_Categoria.Text = "" And TextBox_Precio.Text <> "" Then
                Dim ds As New DataSet

                Dim cb As New OleDbDataAdapter

                Dim comando As New OleDbCommand("Select * from Productos WHERE ISBN LIKE? and Nombre LIKE? and Precio LIKE?", conexion)

                cb.SelectCommand = comando

                comando.Parameters.Add("@var1", OleDbType.Integer, 15).Value = Convert.ToInt64(TextBox_ISBN.Text)
                comando.Parameters.Add("@var2", OleDbType.VarChar, 50).Value = TextBox_Nombre.Text
                comando.Parameters.Add("@var3", OleDbType.Integer, 15).Value = Convert.ToInt64(TextBox_Precio.Text)

                midataset.Clear()

                cb.Fill(midataset, "Productos")

                DataGridView_Articulos.DataSource = midataset

                DataGridView_Articulos.DataMember = "Productos"
            End If

            ' ISBN Nombre
            If TextBox_ISBN.Text <> "" And TextBox_Nombre.Text <> "" And TextBox_Categoria.Text = "" And TextBox_Precio.Text = "" Then
                Dim ds As New DataSet

                Dim cb As New OleDbDataAdapter

                Dim comando As New OleDbCommand("Select * from Productos WHERE ISBN LIKE? and Nombre LIKE? ", conexion)

                cb.SelectCommand = comando

                comando.Parameters.Add("@var1", OleDbType.Integer, 15).Value = Convert.ToInt64(TextBox_ISBN.Text)
                comando.Parameters.Add("@var2", OleDbType.VarChar, 50).Value = TextBox_Nombre.Text

                midataset.Clear()

                cb.Fill(midataset, "Productos")

                DataGridView_Articulos.DataSource = midataset

                DataGridView_Articulos.DataMember = "Productos"
            End If

            ' ISBN Categoria
            If TextBox_ISBN.Text <> "" And TextBox_Nombre.Text = "" And TextBox_Categoria.Text <> "" And TextBox_Precio.Text = "" Then
                Dim ds As New DataSet

                Dim cb As New OleDbDataAdapter

                Dim comando As New OleDbCommand("Select * from Productos WHERE ISBN LIKE? and Categoria LIKE?", conexion)

                cb.SelectCommand = comando

                comando.Parameters.Add("@var1", OleDbType.Integer, 15).Value = Convert.ToInt64(TextBox_ISBN.Text)
                comando.Parameters.Add("@var2", OleDbType.VarChar, 50).Value = TextBox_Categoria.Text

                midataset.Clear()

                cb.Fill(midataset, "Productos")

                DataGridView_Articulos.DataSource = midataset

                DataGridView_Articulos.DataMember = "Productos"
            End If

            ' Nombre Categoria
            If TextBox_ISBN.Text = "" And TextBox_Nombre.Text <> "" And TextBox_Categoria.Text <> "" And TextBox_Precio.Text = "" Then
                Dim ds As New DataSet

                Dim cb As New OleDbDataAdapter

                Dim comando As New OleDbCommand("Select * from Productos WHERE Nombre LIKE? and Categoria LIKE?", conexion)

                cb.SelectCommand = comando

                comando.Parameters.Add("@var1", OleDbType.VarChar, 50).Value = TextBox_Nombre.Text
                comando.Parameters.Add("@var2", OleDbType.VarChar, 50).Value = TextBox_Categoria.Text

                midataset.Clear()

                cb.Fill(midataset, "Productos")

                DataGridView_Articulos.DataSource = midataset

                DataGridView_Articulos.DataMember = "Productos"
            End If

            ' Categoria Precio
            If TextBox_ISBN.Text = "" And TextBox_Nombre.Text = "" And TextBox_Categoria.Text <> "" And TextBox_Precio.Text <> "" Then
                Dim ds As New DataSet

                Dim cb As New OleDbDataAdapter

                Dim comando As New OleDbCommand("Select * from Productos WHERE Categoria LIKE? and Precio LIKE?", conexion)

                cb.SelectCommand = comando

                comando.Parameters.Add("@var1", OleDbType.VarChar, 50).Value = TextBox_Categoria.Text
                comando.Parameters.Add("@var2", OleDbType.Integer, 15).Value = Convert.ToInt64(TextBox_Precio.Text)

                midataset.Clear()

                cb.Fill(midataset, "Productos")

                DataGridView_Articulos.DataSource = midataset

                DataGridView_Articulos.DataMember = "Productos"
            End If

            ' ISBN Precio
            If TextBox_ISBN.Text <> "" And TextBox_Nombre.Text = "" And TextBox_Categoria.Text = "" And TextBox_Precio.Text <> "" Then
                Dim ds As New DataSet

                Dim cb As New OleDbDataAdapter

                Dim comando As New OleDbCommand("Select * from Productos WHERE ISBN LIKE? and Precio LIKE?", conexion)

                cb.SelectCommand = comando

                comando.Parameters.Add("@var1", OleDbType.Integer, 15).Value = Convert.ToInt64(TextBox_ISBN.Text)
                comando.Parameters.Add("@var2", OleDbType.Integer, 15).Value = Convert.ToInt64(TextBox_Precio.Text)

                midataset.Clear()

                cb.Fill(midataset, "Productos")

                DataGridView_Articulos.DataSource = midataset

                DataGridView_Articulos.DataMember = "Productos"
            End If

            ' Nombre Precio
            If TextBox_ISBN.Text = "" And TextBox_Nombre.Text <> "" And TextBox_Categoria.Text = "" And TextBox_Precio.Text <> "" Then
                Dim ds As New DataSet

                Dim cb As New OleDbDataAdapter

                Dim comando As New OleDbCommand("Select * from Productos WHERE Nombre LIKE? and Precio LIKE?", conexion)

                cb.SelectCommand = comando

                comando.Parameters.Add("@var1", OleDbType.VarChar, 50).Value = TextBox_Nombre.Text
                comando.Parameters.Add("@var2", OleDbType.Integer, 15).Value = Convert.ToInt64(TextBox_Precio.Text)

                midataset.Clear()

                cb.Fill(midataset, "Productos")

                DataGridView_Articulos.DataSource = midataset

                DataGridView_Articulos.DataMember = "Productos"
            End If

            ' ISBN
            If TextBox_ISBN.Text <> "" And TextBox_Nombre.Text = "" And TextBox_Categoria.Text = "" And TextBox_Precio.Text = "" Then
                Dim ds As New DataSet

                Dim cb As New OleDbDataAdapter

                Dim comando As New OleDbCommand("Select * from Productos WHERE ISBN LIKE?", conexion)

                cb.SelectCommand = comando

                comando.Parameters.Add("@var1", OleDbType.Integer, 15).Value = Convert.ToInt64(TextBox_ISBN.Text)

                midataset.Clear()

                cb.Fill(midataset, "Productos")

                DataGridView_Articulos.DataSource = midataset

                DataGridView_Articulos.DataMember = "Productos"
            End If

            ' Nombre
            If TextBox_ISBN.Text = "" And TextBox_Nombre.Text <> "" And TextBox_Categoria.Text = "" And TextBox_Precio.Text = "" Then
                Dim ds As New DataSet

                Dim cb As New OleDbDataAdapter

                Dim comando As New OleDbCommand("Select * from Productos WHERE Nombre LIKE?", conexion)

                cb.SelectCommand = comando

                comando.Parameters.Add("@var1", OleDbType.VarChar, 50).Value = TextBox_Nombre.Text

                midataset.Clear()

                cb.Fill(midataset, "Productos")

                DataGridView_Articulos.DataSource = midataset

                DataGridView_Articulos.DataMember = "Productos"
            End If

            ' Categoria
            If TextBox_ISBN.Text = "" And TextBox_Nombre.Text = "" And TextBox_Categoria.Text <> "" And TextBox_Precio.Text = "" Then
                Dim ds As New DataSet

                Dim cb As New OleDbDataAdapter

                Dim comando As New OleDbCommand("Select * from Productos WHERE Categoria LIKE?", conexion)

                cb.SelectCommand = comando

                comando.Parameters.Add("@var1", OleDbType.VarChar, 50).Value = TextBox_Categoria.Text

                midataset.Clear()

                cb.Fill(midataset, "Productos")

                DataGridView_Articulos.DataSource = midataset

                DataGridView_Articulos.DataMember = "Productos"
            End If

            ' Precio
            If TextBox_ISBN.Text = "" And TextBox_Nombre.Text = "" And TextBox_Categoria.Text = "" And TextBox_Precio.Text <> "" Then
                Dim ds As New DataSet

                Dim cb As New OleDbDataAdapter

                Dim comando As New OleDbCommand("Select * from Productos WHERE Precio LIKE?", conexion)

                cb.SelectCommand = comando

                comando.Parameters.Add("@var1", OleDbType.Integer, 15).Value = Convert.ToInt64(TextBox_Precio.Text)

                midataset.Clear()

                cb.Fill(midataset, "Productos")

                DataGridView_Articulos.DataSource = midataset

                DataGridView_Articulos.DataMember = "Productos"
            End If

            ' MsgBox("Busqueda fallida...")

        End If ' IF 1

    End Sub

End Class

'Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
'    ' Preguntamos al usuario si desea salir o no de la aplicación
'    If MsgBox("¿Esta seguro de que desea salir de la aplicación?", 36, "Salir") = 6 Then
'        ' Especificamos la posición de la ventana
'        posicionarFormularioMenuPrincipal()

'        ' Mostramos el menú principal.
'        MenuPrincipal.Show()

'        ' Cerramos este formulario
'        Me.Close()
'    End If


' End Sub