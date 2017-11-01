Imports System.Data.SqlClient

Public Class PSadd

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
            MsgBox("Enter all fields !")
            Exit Sub
        End If
        Dim query As String
        query = "insert into pokestop values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "')"
        Dim ex As SqlCommand
        Try
            ex = New SqlCommand(query, con)
            ex.ExecuteNonQuery()
            MsgBox("Poke-Stop Added")
        Catch exc As Exception
            MsgBox(exc.Message)
        End Try
    End Sub

    Private Sub PSadd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class