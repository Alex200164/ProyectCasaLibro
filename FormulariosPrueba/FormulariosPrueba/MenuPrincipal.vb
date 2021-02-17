' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb

Public Class MenuPrincipal

    ' Especificamos la base de datos a la que nos vamos a conectar.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CasaLibroDB.accdb")
    ' Al adaptador le asignamos la conexion que acabamos de realizar y una consulta
    Public adaptador As New OleDbDataAdapter("Select * from Socios", conexion)

    ' Aquí alojaremos los datos de la DB
    Public midataset As New DataSet

    ' Método que permite posicionar la ventana en la posición especificada del formulario "GestionSocios".
    ' En este caso para evitar que quede encima del formulario anterior.
    Private Shared Sub posicionarFormularioSocios()
        GestionSocios.StartPosition = FormStartPosition.Manual
        Dim a As Integer
        a = My.Computer.Screen.Bounds.Size.Width - (My.Computer.Screen.Bounds.Size.Width * 0.97)
        Dim b As Integer
        b = My.Computer.Screen.Bounds.Size.Height - (My.Computer.Screen.Bounds.Size.Height * 0.97)
        GestionSocios.Location = New Point(a, b)
    End Sub

    ' Método que permite posicionar la ventana en la posición especificada del formulario "GestionLibros".
    ' En este caso para evitar que quede encima del formulario anterior.
    Private Shared Sub posicionarFormularioLibros()
        GestionLibros.StartPosition = FormStartPosition.Manual
        Dim a As Integer
        a = My.Computer.Screen.Bounds.Size.Width - (My.Computer.Screen.Bounds.Size.Width * 0.97)
        Dim b As Integer
        b = My.Computer.Screen.Bounds.Size.Height - (My.Computer.Screen.Bounds.Size.Height * 0.97)
        GestionLibros.Location = New Point(a, b)
    End Sub

    ' Método que permite posicionar la ventana en la posición especificada del formulario "GestionEmpleados".
    ' En este caso para evitar que quede encima del formulario anterior.
    Private Shared Sub posicionarFormularioEmpleados()
        GestionEmpleados.StartPosition = FormStartPosition.Manual
        Dim a As Integer
        a = My.Computer.Screen.Bounds.Size.Width - (My.Computer.Screen.Bounds.Size.Width * 0.97)
        Dim b As Integer
        b = My.Computer.Screen.Bounds.Size.Height - (My.Computer.Screen.Bounds.Size.Height * 0.97)
        GestionEmpleados.Location = New Point(a, b)
    End Sub

    ' Método que permite posicionar la ventana en la posición especificada del formulario "GestionArticulos".
    ' En este caso para evitar que quede encima del formulario anterior.
    Private Shared Sub posicionarFormularioArticulos()
        GestionArticulos.StartPosition = FormStartPosition.Manual
        Dim a As Integer
        a = My.Computer.Screen.Bounds.Size.Width - (My.Computer.Screen.Bounds.Size.Width * 0.97)
        Dim b As Integer
        b = My.Computer.Screen.Bounds.Size.Height - (My.Computer.Screen.Bounds.Size.Height * 0.97)
        GestionArticulos.Location = New Point(a, b)
    End Sub

    ' Método que se ejecuta si el botón libros es pulsado, mostrando el formulario de gestión de libros
    Private Sub Button_GestionLibros_Click(sender As Object, e As EventArgs) Handles Button_GestionLibros.Click
        ' Comprobación de que la base de datos es accesible obligando a acceder a datos, en caso contrario, error
        Try
            ' Cargar la memoria del cache con datos.
            adaptador.Fill(midataset, "Socios")

            posicionarFormularioLibros()
            ' Mostramos el formulario de gestión de libros
            GestionLibros.Show()
            ' Cerramos el formulario de menú principal
            Me.Close()
        Catch ex As System.Data.OleDb.OleDbException
            MsgBox("Parece que algo ha salido mal. Revise que la base de datos no esté abierta durante la ejecución.", MsgBoxStyle.OkOnly, "Error - Base de datos")
        End Try
    End Sub

    ' Método que se ejecuta si el botón papeleria es pulsado, mostrando el formulario de gestión de papeleria
    Private Sub Button_GestionPapeleria_Click(sender As Object, e As EventArgs) Handles Button_GestionPapeleria.Click
        ' Comprobación de que la base de datos es accesible obligando a acceder a datos, en caso contrario, error
        Try
            ' Cargar la memoria del cache con datos.
            adaptador.Fill(midataset, "Socios")

            posicionarFormularioArticulos()
            ' Mostramos el formulario de gestión de papeleria
            GestionArticulos.Show()
            ' Cerramos el formulario de menú principal
            Me.Close()
        Catch ex As System.Data.OleDb.OleDbException
            MsgBox("Parece que algo ha salido mal. Revise que la base de datos no esté abierta durante la ejecución.", MsgBoxStyle.OkOnly, "Error - Base de datos")
        End Try
    End Sub

    ' Método que se ejecuta si el botón socios es pulsado, mostrando el formulario de gestión de socios
    Private Sub Button_GestionSocios_Click(sender As Object, e As EventArgs) Handles Button_GestionSocios.Click
        ' Comprobación de que la base de datos es accesible obligando a acceder a datos, en caso contrario, error
        Try
            ' Cargar la memoria del cache con datos.
            adaptador.Fill(midataset, "Socios")

            posicionarFormularioSocios()
            ' Mostramos el formulario de gestión de socios
            GestionSocios.Show()
            ' Cerramos el formulario de menú principal
            Me.Close()

        Catch ex As System.Data.OleDb.OleDbException
            MsgBox("Parece que algo ha salido mal. Revise que la base de datos no esté abierta durante la ejecución.", MsgBoxStyle.OkOnly, "Error - Base de datos")
        End Try
    End Sub

    ' Método que se ejecuta si el botón empleados es pulsado, mostrando el formulario de gestión de empleados
    Private Sub Button_GestionEmpleados_Click(sender As Object, e As EventArgs) Handles Button_GestionEmpleados.Click
        ' Comprobación de que la base de datos es accesible obligando a acceder a datos, en caso contrario, error
        Try
            ' Cargar la memoria del cache con datos.
            adaptador.Fill(midataset, "Socios")

            posicionarFormularioEmpleados()
            ' Mostramos el formulario de gestión de empleados
            GestionEmpleados.Show()
            ' Cerramos el formulario de menú principal
            Me.Close()
        Catch ex As System.Data.OleDb.OleDbException
            MsgBox("Parece que algo ha salido mal. Revise que la base de datos no esté abierta durante la ejecución.", MsgBoxStyle.OkOnly, "Error - Base de datos")
        End Try
    End Sub

    ' Método que se ejecuta si el botón CerrarSesion es pulsado, mostrando de nuevo el formulario de inicio de sesión
    Private Sub Button_CerrarSesion_Click(sender As Object, e As EventArgs) Handles Button_CerrarSesion.Click
        ' Mostramos el formulario de inicio de sesión
        InicioSesion.Show()
        ' Cerramos el formulario de menú principal
        Me.Close()
    End Sub
End Class