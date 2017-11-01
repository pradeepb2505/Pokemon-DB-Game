Imports System.Data.SqlClient

Public Class Gym
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Gadd.Show()
    End Sub
    Private Function Display1()
        Dim adp As SqlDataAdapter
        Dim dt As DataTable
        adp = New SqlDataAdapter("select * from gym order by gid", con)
        dt = New DataTable()
        adp.Fill(dt)
        DataGridView1.DataSource = dt
        Return Nothing
    End Function
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call Display1()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Gupdate.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = "" Then
            MsgBox("Enter Gym ID !")
        End If
        Dim exe As String = "delete from gym where gid = '" & TextBox2.Text & " '"
        Dim sq As SqlCommand
        Try
            sq = New SqlCommand(exe, con)
            sq.ExecuteNonQuery()
            MsgBox("Gym deleted")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter Gym ID !")
        End If
        Dim gid As Integer
        gid = Val(TextBox1.Text)
        Dim sqlcmd As SqlCommand
        Dim query As String
        If TextBox1.Text = "" Then
            MsgBox("GID filed is Mandatory !")
            Exit Sub
        End If
        query = "select * from gym where gid = " & gid
        Try
            sqlcmd = New SqlCommand(query, con)
            sqlcmd.ExecuteNonQuery()
            MsgBox("Gym Found")
            Dim adp As SqlDataAdapter
            Dim dt As DataTable
            adp = New SqlDataAdapter("select * from gym where gid = " & gid, con)
            dt = New DataTable()
            adp.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Gym_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Display1()
    End Sub
End Class