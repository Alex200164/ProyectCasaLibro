﻿Public Class GestionLibros
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Limpiar.Click
        posicionarGestionInterna()
        GestionInternaLibros.Show()
    End Sub
    Private Shared Sub posicionarGestionInterna()
        GestionInternaLibros.StartPosition = FormStartPosition.Manual
        Dim a As Integer
        a = My.Computer.Screen.Bounds.Size.Width - (My.Computer.Screen.Bounds.Size.Width * 0.55)
        Dim b As Integer
        b = My.Computer.Screen.Bounds.Size.Height - (My.Computer.Screen.Bounds.Size.Height * 0.8)
        GestionInternaLibros.Location = New Point(a, b)
    End Sub
End Class