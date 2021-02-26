' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'cas_lib_dibDataSetProductos.Productos' Puede moverla o quitarla según sea necesario.
        'Me.ProductosTableAdapter.Fill(Me.cas_lib_dibDataSetProductos.Productos)

        Me.ReportViewer1.RefreshReport()

        Dim dt As New DataTable
        Using con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=cas_lib_dib.accdb")
            con.Open()
            Using cmd As New OleDbCommand("Select * from Productos", con)
                Dim da As New OleDbDataAdapter

                da.SelectCommand = cmd

                da.Fill(dt)

            End Using
        End Using

        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "Report1.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("cas_lib_dibDataSetProductos", dt))
        End With
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class