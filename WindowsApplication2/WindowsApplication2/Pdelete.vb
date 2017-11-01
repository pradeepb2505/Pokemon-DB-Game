Imports System.Data.SqlClient
Public Class Pdelete
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter DexID !")
        End If
        Dim exe As String = "delete from Pokemon where DexNO = '" & TextBox1.Text & " '"
        Dim sq As SqlCommand
        Try
            sq = New SqlCommand(exe, con)
            sq.ExecuteNonQuery()
            MsgBox("Pokemon deleted")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class