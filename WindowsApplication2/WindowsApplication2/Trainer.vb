Imports System.Data.SqlClient

Public Class Trainer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Tadd.Show()
    End Sub
    Private Function Display1()
        Dim adp As SqlDataAdapter
        Dim dt As DataTable
        adp = New SqlDataAdapter("select * from trainer order by tid", con)
        dt = New DataTable()
        adp.Fill(dt)
        DataGridView1.DataSource = dt
        Return Nothing
    End Function
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call Display1()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = "" Then
            MsgBox("Enter TID !")
        End If
        Dim exe As String = "delete from trainer where tid = '" & TextBox2.Text & " '"
        Dim sq As SqlCommand
        Try
            sq = New SqlCommand(exe, con)
            sq.ExecuteNonQuery()
            MsgBox("Trainer deleted")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Tupdate.Show()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter TID !")
        End If
        Dim tid As Integer
        tid = Val(TextBox1.Text)
        Dim sqlcmd As SqlCommand
        Dim query As String
        If TextBox1.Text = "" Then
            MsgBox("TID filed is Mandatory !")
            Exit Sub
        End If
        query = "select * from trainer where tid = " & tid
        Try
            sqlcmd = New SqlCommand(query, con)
            sqlcmd.ExecuteNonQuery()
            MsgBox("Trainer Found")
            Dim adp As SqlDataAdapter
            Dim dt As DataTable
            adp = New SqlDataAdapter("select * from trainer where tid = " & tid, con)
            dt = New DataTable()
            adp.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Trainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Display1()
    End Sub
End Class