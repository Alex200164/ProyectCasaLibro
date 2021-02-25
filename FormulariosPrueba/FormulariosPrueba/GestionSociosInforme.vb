' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb

Public Class GestionSociosInforme

    Private Sub GestionSociosInforme_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As New DataTable
        Using con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=cas_lib_dib.accdb")
            con.Open()
            Using cmd As New OleDbCommand("Select * from Socios", con)
                Dim da As New OleDbDataAdapter

                da.SelectCommand = cmd

                da.Fill(dt)

            End Using
        End Using

        Dim ruta As String

        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "GestionSociosInforme.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSetSocios", dt))
        End With
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class