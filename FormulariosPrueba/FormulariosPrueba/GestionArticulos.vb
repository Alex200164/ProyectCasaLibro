' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb

Public Class GestionArticulos

    'Declaramos el botón  Modificar que será creado dinamicamente junto a los resgistros del DataGridView.
    Public button_din_modificar As New DataGridViewButtonColumn 'Creamos el botón.

    'Creamos in estilo que aplicaremos a las caracteristicas del botón Modificar.
    Public style As New DataGridViewCellStyle


    ' Especificamos la base de datos a la que nos vamos a conectar.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CasaLibroDB.accdb")
    ' Al adaptador le asignamos la conexion que acabamos de realizar y una consulta
    Public adaptador As New OleDbDataAdapter("Select * from Productos", conexion)

    ' Aquí alojaremos los datos de la DB
    Public midataset As New DataSet

    Public posicionDataGridSeleccionada As Integer


    ' Método que se ejecuta al pulsar en una de las cajas del DataGridView
    Private Sub DataGridView_Articulos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Articulos.CellClick
        posicionDataGridSeleccionada = BindingContext(midataset, "Productos").Position
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
        GestionArticulosAltas.Show()
    End Sub

    ' Método que se ejecuta al iniciarse el formulario
    Private Sub GestionArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Cargar la memoria del cache con datos.
            adaptador.Fill(midataset, "Productos")

            ' cargar en el datagridview, le decimos de donde sacamos los datos
            DataGridView_Articulos.DataSource = midataset
            DataGridView_Articulos.DataMember = "Productos"

            'Deshabilita la visibilidad del Item Gestión de articulos, ya que estamos en dicho form.
            GestiónArticulosToolStripMenuItem.Visible = False

            'Creación en la ultima columna del DataGridView el botón de modificar en cada registro.
            crearButton()

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

    'Método que crea y da formato al botón de modificar, en cada una de los registros del DataGridView. 
    'Este bóton abrirá el formulario de GestionArticulos. 
    Public Sub crearButton()
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
        'Si es correcto se ejecutará el comando de abrir GesitonArticulos
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            ' Posicionamos el formulario que vamos a mostrar.
            posicionarGestionModificaciones()
            ' Mostramos el formulario
            GestionArticulosModificaciones.Show()
        End If
    End Sub

    '**********************************************************************245234523452345345**************************TENGO QUE COMENTARLO
    Private Sub DataGridView1_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles DataGridView_Articulos.CellPainting
        If e.ColumnIndex = 5 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            'Liena de código que calcula la posicion de el dibujo en concreto.
            e.Graphics.DrawImage(My.Resources.Webp_net_resizeimage_6_, CInt((e.CellBounds.Width / 2) - (My.Resources.Webp_net_resizeimage_6_.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.Webp_net_resizeimage_6_.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
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

    ' Método que se ejecuta cuando es pulsado el botón "Gestion de Libros" del menuStrip
    Private Sub GestiónLibrosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GestiónLibrosToolStripMenuItem1.Click
        If MsgBox("¿Está seguro de que desea cambiar de formulario?", 36, "Salir") = 6 Then
            GestionLibros.Show()
        End If
    End Sub

    ' Método que se ejecuta cuando es pulsado el botón "Gestion de Socios" del menuStrip
    Private Sub GestiónDeSociosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeSociosToolStripMenuItem.Click
        If MsgBox("¿Está seguro de que desea cambiar de formulario?", 36, "Salir") = 6 Then
            GestionSocios.Show()
        End If
    End Sub

    ' Método que se ejecuta cuando es pulsado el botón "Gestion de Empleados" del menuStrip
    Private Sub GestiónEmpleadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GestiónEmpleadosToolStripMenuItem1.Click
        If MsgBox("¿Está seguro de que desea cambiar de formulario?", 36, "Salir") = 6 Then
            GestionEmpleados.Show()
        End If
    End Sub



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

End Class