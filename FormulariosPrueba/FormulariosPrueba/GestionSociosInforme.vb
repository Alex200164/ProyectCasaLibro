' Necesitamos importar el módelo de base de datos que vamos a utilizar, este es de access.
Imports System.Data.OleDb

Public Class GestionSociosInforme

    ' Especificamos la base de datos a la que nos vamos a conectar.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=cas_lib_dib.accdb")
    ' Al adaptador le asignamos la conexion que acabamos de realizar y una consulta
    Public adaptador As New OleDbDataAdapter("Select * from Socios", conexion)

    Private Sub GestionSociosInforme_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=cas_lib_dib.accdb")
            con.Open()
            Using cmd As New OleDbCommand("Select * from Socios", con)
                Dim da As New OleDbDataAdapter

                da.SelectCommand = cmd

                Dim dt As New DataSet

                da.Fill(dt)

            End Using
        End Using

        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "GestionSociosInforme.rdlc"
        End With



        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class