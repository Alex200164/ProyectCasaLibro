Public Class MenuPrincipal

    ' Método que se ejecuta si el botón libros es pulsado, mostrando el formulario de gestión de libros
    Private Sub Button_GestionLibros_Click(sender As Object, e As EventArgs) Handles Button_GestionLibros.Click
        ' Mostramos el formulario de gestión de libros
        GestionLibros.Show()
        ' Cerramos el formulario de menú principal
        Me.Close()
    End Sub

    ' Método que se ejecuta si el botón papeleria es pulsado, mostrando el formulario de gestión de papeleria
    Private Sub Button_GestionPapeleria_Click(sender As Object, e As EventArgs) Handles Button_GestionPapeleria.Click
        ' Mostramos el formulario de gestión de papeleria
        GestionArticulos.Show()
        ' Cerramos el formulario de menú principal
        Me.Close()
    End Sub

    ' Método que se ejecuta si el botón socios es pulsado, mostrando el formulario de gestión de socios
    Private Sub Button_GestionSocios_Click(sender As Object, e As EventArgs) Handles Button_GestionSocios.Click
        ' Mostramos el formulario de gestión de socios
        GestionSocios.Show()
        ' Cerramos el formulario de menú principal
        Me.Close()
    End Sub

    ' Método que se ejecuta si el botón empleados es pulsado, mostrando el formulario de gestión de empleados
    Private Sub Button_GestionEmpleados_Click(sender As Object, e As EventArgs) Handles Button_GestionEmpleados.Click
        ' Mostramos el formulario de gestión de empleados
        GestionEmpleados.Show()
        ' Cerramos el formulario de menú principal
        Me.Close()
    End Sub

    ' Método que se ejecuta si el botón CerrarSesion es pulsado, mostrando de nuevo el formulario de inicio de sesión
    Private Sub Button_CerrarSesion_Click(sender As Object, e As EventArgs) Handles Button_CerrarSesion.Click
        ' Mostramos el formulario de inicio de sesión
        InicioSesion.Show()
        ' Cerramos el formulario de menú principal
        Me.Close()
    End Sub
End Class