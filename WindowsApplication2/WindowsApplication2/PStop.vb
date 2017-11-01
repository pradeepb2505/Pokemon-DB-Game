Imports System.Data.SqlClient

Public Class PStop
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PSadd.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PSupdate.Show()
    End Sub
    Private Function Display1()
        Dim adp As SqlDataAdapter
        Dim dt As DataTable
        adp = New SqlDataAdapter("select * from pokestop order by psid", con)
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
            MsgBox("Enter PSID")
        End If
        Dim exe As String = "delete from pokestop where psid = '" & TextBox2.Text & " '"
        Dim sq As SqlCommand
        Try
            sq = New SqlCommand(exe, con)
            sq.ExecuteNonQuery()
            MsgBox("Poke-Stop deleted")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter PSID")
        End If
        Dim psid As Integer
        psid = Val(TextBox1.Text)
        Dim sqlcmd As SqlCommand
        Dim query As String
        If TextBox1.Text = "" Then
            MsgBox("PSID filed is Mandatory !")
            Exit Sub
        End If
        query = "select * from pokestop where psid = " & psid
        Try
            sqlcmd = New SqlCommand(query, con)
            sqlcmd.ExecuteNonQuery()
            MsgBox("Poke-Stop Found")
            Dim adp As SqlDataAdapter
            Dim dt As DataTable
            adp = New SqlDataAdapter("select * from pokestop where psid = " & psid, con)
            dt = New DataTable()
            adp.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PStop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Display1()
    End Sub
End Class