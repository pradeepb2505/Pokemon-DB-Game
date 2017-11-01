Imports System.Data.SqlClient
Public Class Padd


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Or TextBox11.Text = "" Or TextBox12.Text = "" Or TextBox13.Text = "" Then
            MsgBox("Enter all fields !")
            Exit Sub
        End If
        Dim query As String
        query = "insert into pokemon values('" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "')"
        Dim ex As SqlCommand
        Try
            ex = New SqlCommand(query, con)
            ex.ExecuteNonQuery()
            MsgBox("Pokemon Added")
        Catch exc As Exception
            MsgBox(exc.Message)
        End Try
    End Sub


End Class