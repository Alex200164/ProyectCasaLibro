Public Class Form1
    Private Sub btn_BusquedaLibros_Click(sender As Object, e As EventArgs) Handles btn_BusquedaLibros.Click
        'Variable que nos dice cual es el Nombre del botón pulsado
        Dim btn_Name As String = DirectCast(sender, Button).Name.ToLower.Replace("clear", "")

        'Llamamos al métod que posiciona la nueva ventana y luego mostramos la ventana en cuestión 
        posicionarBusquedas(btn_Name)
        GestionLibros.Show()

    End Sub

    Private Sub btn_BusquedaArticulos_Click(sender As Object, e As EventArgs) Handles btn_BusquedaArticulos.Click
        'Variable que nos dice cual es el Nombre del botón pulsado
        Dim btn_Name As String = DirectCast(sender, Button).Name.ToLower.Replace("clear", "")

        'Método que posicionael formulario Busqueda libros donde se quiere ubicar
        posicionarBusquedas(btn_Name)
        'Mostramos el formulario BuquedaLibros
        GestionArticulos.Show()
    End Sub

    'Metodo que detecta que botón se ha pulsado y envia la orden  de posicionar a una ventana 
    'NOTA: ****COMENTAR ALEX**** 
    Private Sub posicionarBusquedas(ByVal btn_Name As String)
        GestionArticulos.StartPosition = FormStartPosition.Manual
        GestionLibros.StartPosition = FormStartPosition.Manual

        Dim a As Integer
        a = (My.Computer.Screen.Bounds.Size.Width * 0.036)
        Dim b As Integer
        b = (My.Computer.Screen.Bounds.Size.Height * 0.06)

        If btn_Name.Equals("btn_busquedalibros") Then
            GestionLibros.Location = New Point(a, b)
            'TextBox4.Text = a & "/" & b
        ElseIf (btn_Name.Equals("btn_busquedaarticulos")) Then
            GestionArticulos.Location = New Point(a, b)
            'TextBox5.Text = a & "/" & b
        End If

    End Sub

End Class
