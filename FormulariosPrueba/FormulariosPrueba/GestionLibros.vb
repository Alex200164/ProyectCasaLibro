' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb

Public Class GestionLibros

    ' Especificamos la base de datos a la que nos vamos a conectar.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CasaLibroDB.accdb")
    ' Al adaptador le asignamos la conexion que acabamos de realizar y una consulta
    Public adaptador As New OleDbDataAdapter("Select * from Libros", conexion)

    ' Aquí alojaremos los datos de la DB
    Public midataset As New DataSet

    ' Método que permite posicionar la ventana en la posición especificada del formulario "GestionLibrosAltas".
    ' En este caso para evitar que quede encima del formulario anterior.
    Private Shared Sub posicionarGestionAltas()
        GestionLibrosAltas.StartPosition = FormStartPosition.Manual
        Dim a As Integer
        a = My.Computer.Screen.Bounds.Size.Width - (My.Computer.Screen.Bounds.Size.Width * 0.55)
        Dim b As Integer
        b = My.Computer.Screen.Bounds.Size.Height - (My.Computer.Screen.Bounds.Size.Height * 0.8)
        GestionLibrosAltas.Location = New Point(a, b)
    End Sub


    ' Método que permite posicionar la ventana en la posición especificada del formulario "GestionLibrosModificaciones".
    ' En este caso para evitar que quede encima del formulario anterior.
    Private Shared Sub posicionarGestionModificaciones()
        GestionLibrosModificaciones.StartPosition = FormStartPosition.Manual
        Dim a As Integer
        a = My.Computer.Screen.Bounds.Size.Width - (My.Computer.Screen.Bounds.Size.Width * 0.55)
        Dim b As Integer
        b = My.Computer.Screen.Bounds.Size.Height - (My.Computer.Screen.Bounds.Size.Height * 0.8)
        GestionLibrosModificaciones.Location = New Point(a, b)
    End Sub

    ' Método que se ejecuta cuando el botón "Salir..." del ToolStrip es pulsado y que nos lleva al formulario "MenuPrincipal"
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        ' Mostramos el menú principal.
        MenuPrincipal.Show()

        ' Cerramos este formulario
        Me.Close()
    End Sub

    ' Método que se ejecuta cuando el botón "Modificar" es pulsado.
    Private Sub Button_Modificar_Click(sender As Object, e As EventArgs) Handles Button_Modificar.Click
        ' Posicionamos el formulario que vamos a mostrar.
        posicionarGestionModificaciones()
        ' Mostramos el formulario
        GestionLibrosModificaciones.Show()
    End Sub

    ' Método que se ejecuta cuando el botón "Añadir" es pulsado.
    Private Sub Button_Annadir_Click(sender As Object, e As EventArgs) Handles Button_Annadir.Click
        ' Posicionamos el formulario que vamos a mostrar.
        posicionarGestionAltas()
        ' Mostramos el formulario
        GestionLibrosAltas.Show()
    End Sub

    Private Sub GestionLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar la memoria del cache con datos.
        adaptador.Fill(midataset, "Libros")

        ' cargar en el datagridview, le decimos de donde sacamos los datos
        DataGridView_Libros.DataSource = midataset
        DataGridView_Libros.DataMember = "Libros"
    End Sub
End Class