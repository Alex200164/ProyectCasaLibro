' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb
Public Class GestionLibrosInforme
    Private Sub GestionLibrosInforme_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As New DataTable
        Using con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=cas_lib_dib.accdb")
            con.Open()
            Using cmd As New OleDbCommand("Select * from Libros", con)
                Dim da As New OleDbDataAdapter

                da.SelectCommand = cmd

                da.Fill(dt)

            End Using
        End Using

        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "GestionLibrosInforme.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSetLibros", dt))
        End With
        Me.ReportViewer1.RefreshReport()


    End Sub
End Class