Public Class GestionEmpleadosModificaciones

    ' Método que se ejecuta cuando el botón "Salir..." del ToolStrip es pulsado y que nos lleva al formulario "GestionEmpleados".
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        ' Mostramos el formulario "GestionEmpleados".
        GestionEmpleados.Show()

        ' Cerramos este formulario
        Me.Close()
    End Sub
End Class