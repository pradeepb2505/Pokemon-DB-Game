Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Enter all fields !")
            Exit Sub
        End If
        If Not TextBox1.Text = "poke" Or Not TextBox2.Text = "poke" Then
            MsgBox("Invalid Login !")
        Else
            MsgBox("Login Successful !")
            Start.Show()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class