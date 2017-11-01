Imports System.Data.SqlClient

Public Class PokeCenter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PCadd.Show()
    End Sub
    Private Function Display1()
        Dim adp As SqlDataAdapter
        Dim dt As DataTable
        adp = New SqlDataAdapter("select * from pokecenter order by pcid", con)
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
            MsgBox("Enter PCID !")
        End If
        Dim exe As String = "delete from pokecenter where pcid = '" & TextBox2.Text & " '"
        Dim sq As SqlCommand
        Try
            sq = New SqlCommand(exe, con)
            sq.ExecuteNonQuery()
            MsgBox("Poke Center deleted")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PCupdate.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter PCID !")
        End If
        Dim pcid As Integer
        pcid = Val(TextBox1.Text)
        Dim sqlcmd As SqlCommand
        Dim query As String
        If TextBox1.Text = "" Then
            MsgBox("PCID filed is Mandatory !")
            Exit Sub
        End If
        query = "select * from pokecenter where pcid = " & pcid
        Try
            sqlcmd = New SqlCommand(query, con)
            sqlcmd.ExecuteNonQuery()
            MsgBox("Poke Center Found")
            Dim adp As SqlDataAdapter
            Dim dt As DataTable
            adp = New SqlDataAdapter("select * from pokecenter where pcid = " & pcid, con)
            dt = New DataTable()
            adp.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub PokeCenter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Display1()
    End Sub
End Class