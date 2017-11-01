Imports System.Data.SqlClient

Public Class PCadd
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Enter all fields !")
            Exit Sub
        End If
        Dim query As String
        query = "insert into pokecenter values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
        Dim ex As SqlCommand
        Try
            ex = New SqlCommand(query, con)
            ex.ExecuteNonQuery()
            MsgBox("PokeCenter Added")
        Catch exc As Exception
            MsgBox(exc.Message)
        End Try
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub PCadd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class