' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb

Public Class MenuPrincipal

    ' Especificamos la base de datos a la que nos vamos a conectar.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CasaLibroDB.accdb")
    ' Al adaptador le asignamos la conexion que acabamos de realizar y una consulta
    Public adaptador As New OleDbDataAdapter("Select * from Socios", conexion)

    ' Aquí alojaremos los datos de la DB
    Public midataset As New DataSet


    'Metodo que detecta que botón se ha pulsado y envia la orden  de posicionar a: 
    'GestionArticulos/GestionLibros/GestionEmpleados/GestionSocios
    Private Sub posicionarFormulariosGestiones(ByVal btn_Name As String)
        'Especifica que el tipo de posicion de arranque será manual para Gestión Articulos
        GestionArticulos.StartPosition = FormStartPosition.Manual
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
        If btn_Name.Equals("button_gestionlibros") Then
            GestionLibros.Location = New Point(a, b) 'Posiciona en las coordenadas a y b
        ElseIf btn_Name.Equals("button_gestionpapeleria") Then
            GestionArticulos.Location = New Point(a, b) 'Posiciona en las coordenadas a y b
        ElseIf btn_Name.Equals("button_gestionempleados") Then
            GestionEmpleados.Location = New Point(a, b) 'Posiciona en las coordenadas a y b
        ElseIf btn_Name.Equals("button_gestionsocios") Then
            GestionSocios.Location = New Point(a, b) 'Posiciona en las coordenadas a y b
        End If
    End Sub

    ' Método que se ejecuta si el botón libros es pulsado, mostrando el formulario de gestión de libros
    Private Sub Button_GestionLibros_Click(sender As Object, e As EventArgs) Handles Button_GestionLibros.Click
        ' Comprobación de que la base de datos es accesible obligando a acceder a datos, en caso contrario, error
        Try
            'Variable que nos dice cual es el Nombre del botón pulsado
            Dim btn_Name As String = DirectCast(sender, Button).Name.ToLower.Replace("clear", "")

            ' Cargar la memoria del cache con datos.
            adaptador.Fill(midataset, "Socios")

            posicionarFormulariosGestiones(btn_Name)
            ' Mostramos el formulario de gestión de libros
            GestionLibros.Show()
            ' Ocultamos el formulario de menú principal
            Me.Hide()
        Catch ex As System.Data.OleDb.OleDbException
            MsgBox("Parece que algo ha salido mal. Revise que la base de datos no esté abierta durante la ejecución.", MsgBoxStyle.OkOnly, "Error - Base de datos")
        End Try
    End Sub

    ' Método que se ejecuta si el botón papeleria es pulsado, mostrando el formulario de gestión de papeleria
    Private Sub Button_GestionPapeleria_Click(sender As Object, e As EventArgs) Handles Button_GestionPapeleria.Click
        ' Comprobación de que la base de datos es accesible obligando a acceder a datos, en caso contrario, error
        Try
            'Variable que nos dice cual es el Nombre del botón pulsado
            Dim btn_Name As String = DirectCast(sender, Button).Name.ToLower.Replace("clear", "")

            ' Cargar la memoria del cache con datos.
            adaptador.Fill(midataset, "Socios")

            posicionarFormulariosGestiones(btn_Name)
            ' Mostramos el formulario de gestión de papeleria
            GestionArticulos.Show()
            ' Ocultamos el formulario de menú principal
            Me.Hide()
        Catch ex As System.Data.OleDb.OleDbException
            MsgBox("Parece que algo ha salido mal. Revise que la base de datos no esté abierta durante la ejecución.", MsgBoxStyle.OkOnly, "Error - Base de datos")
        End Try
    End Sub

    ' Método que se ejecuta si el botón socios es pulsado, mostrando el formulario de gestión de socios
    Private Sub Button_GestionSocios_Click(sender As Object, e As EventArgs) Handles Button_GestionSocios.Click
        ' Comprobación de que la base de datos es accesible obligando a acceder a datos, en caso contrario, error
        Try
            'Variable que nos dice cual es el Nombre del botón pulsado
            Dim btn_Name As String = DirectCast(sender, Button).Name.ToLower.Replace("clear", "")

            ' Cargar la memoria del cache con datos.
            adaptador.Fill(midataset, "Socios")

            posicionarFormulariosGestiones(btn_Name)
            ' Mostramos el formulario de gestión de socios
            GestionSocios.Show()
            ' Ocultamos el formulario de menú principal
            Me.Hide()

        Catch ex As System.Data.OleDb.OleDbException
            MsgBox("Parece que algo ha salido mal. Revise que la base de datos no esté abierta durante la ejecución.", MsgBoxStyle.OkOnly, "Error - Base de datos")
        End Try
    End Sub

    ' Método que se ejecuta si el botón empleados es pulsado, mostrando el formulario de gestión de empleados
    Private Sub Button_GestionEmpleados_Click(sender As Object, e As EventArgs) Handles Button_GestionEmpleados.Click
        ' Comprobación de que la base de datos es accesible obligando a acceder a datos, en caso contrario, error
        Try
            'Variable que nos dice cual es el Nombre del botón pulsado
            Dim btn_Name As String = DirectCast(sender, Button).Name.ToLower.Replace("clear", "")

            ' Cargar la memoria del cache con datos.
            adaptador.Fill(midataset, "Socios")

            posicionarFormulariosGestiones(btn_Name)
            ' Mostramos el formulario de gestión de empleados
            GestionEmpleados.Show()
            ' Ocultamos el formulario de menú principal
            Me.Hide()
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