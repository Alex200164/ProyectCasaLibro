' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb

Public Class GestionSocios

    ' Especificamos la base de datos a la que nos vamos a conectar.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CasaLibroDB.accdb")
    ' Al adaptador le asignamos la conexion que acabamos de realizar y una consulta
    Public adaptador As New OleDbDataAdapter("Select * from Socios", conexion)

    ' Aquí alojaremos los datos de la DB
    Public midataset As New DataSet

    ' Método que se ejecuta cuando el botón "Salir..." del ToolStrip es pulsado y que nos lleva al formulario "MenuPrincipal"
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        ' Mostramos el menú principal.
        MenuPrincipal.Show()

        ' Cerramos este formulario
        Me.Close()
    End Sub

    ' Método que permite posicionar la ventana en la posición especificada del formulario "GestionSociosAltas".
    ' En este caso para evitar que quede encima del formulario anterior.
    Private Shared Sub posicionarGestionAltas()
        GestionSociosAltas.StartPosition = FormStartPosition.Manual
        Dim a As Integer
        a = My.Computer.Screen.Bounds.Size.Width - (My.Computer.Screen.Bounds.Size.Width * 0.55)
        Dim b As Integer
        b = My.Computer.Screen.Bounds.Size.Height - (My.Computer.Screen.Bounds.Size.Height * 0.8)
        GestionSociosAltas.Location = New Point(a, b)
    End Sub

    ' Método que permite posicionar la ventana en la posición especificada del formulario "GestionSociosModificaciones".
    ' En este caso para evitar que quede encima del formulario anterior.
    Private Shared Sub posicionarGestionModificaciones()
        GestionSociosModificaciones.StartPosition = FormStartPosition.Manual
        Dim a As Integer
        a = My.Computer.Screen.Bounds.Size.Width - (My.Computer.Screen.Bounds.Size.Width * 0.55)
        Dim b As Integer
        b = My.Computer.Screen.Bounds.Size.Height - (My.Computer.Screen.Bounds.Size.Height * 0.8)
        GestionSociosModificaciones.Location = New Point(a, b)
    End Sub

    ' Método que se ejecuta cuando el botón "Añadir" es pulsado.
    Private Sub Button_Annadir_Click(sender As Object, e As EventArgs) Handles Button_Annadir.Click
        ' Posicionamos el formulario que vamos a mostrar.
        posicionarGestionAltas()
        ' Mostramos el formulario
        GestionSociosAltas.Show()
    End Sub

    ' Método que se ejecuta cuando el botón "Modificar" es pulsado.
    Private Sub Button_Modificar_Click(sender As Object, e As EventArgs) Handles Button_Modificar.Click
        ' Posicionamos el formulario que vamos a mostrar.
        posicionarGestionModificaciones()
        ' Mostramos el formulario
        GestionSociosModificaciones.Show()
    End Sub

    Private Sub GestionSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar la memoria del cache con datos.
        adaptador.Fill(midataset, "Socios")

        ' cargar en el datagridview, le decimos de donde sacamos los datos
        DataGridView_Socios.DataSource = midataset
        DataGridView_Socios.DataMember = "Socios"
    End Sub
End Class