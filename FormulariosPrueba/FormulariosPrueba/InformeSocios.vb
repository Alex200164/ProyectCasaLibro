' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb

Public Class InformeSocios

    ' Especificamos la base de datos a la que nos vamos a conectar.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=cas_lib_dib.accdb")
    ' Al adaptador le asignamos la conexion que acabamos de realizar y una consulta
    Public adaptador As New OleDbDataAdapter("Select * from Socios", conexion)

    'Declaramos el botón  Modificar que será creado dinamicamente junto a los resgistros del DataGridView.
    Public button_din_modificar As New DataGridViewButtonColumn
    'Creamos in estilo que aplicaremos a las caracteristicas del botón Modificar.
    Public style As New DataGridViewCellStyle

    ' Aquí alojaremos los datos de la DB
    Public midataset As New DataSet

    ' Método que se ejecuta cuando el formulario es iniciado
    Private Sub InformeSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim comando As New OleDbCommand("Select * from Socios", conexion)

        Dim cb As New OleDbDataAdapter

        cb.SelectCommand = comando

        Dim ds As New DataSet

        cb.Fill(ds)

        With Me.ReportViewer1.LocalReport

        End With
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class