Imports System.Data.SqlClient
Public Class Pokemon

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Pdelete.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Padd.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Pupdate.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Display1()
    End Sub
    Private Function Display1()
        Dim adp As SqlDataAdapter
        Dim dt As DataTable
        adp = New SqlDataAdapter("select * from Pokemon order by DexNO", con)
        dt = New DataTable()
        adp.Fill(dt)
        DataGridView1.DataSource = dt
        Return Nothing
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call Display1()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter DexID !")
        End If
        Dim dex As Integer
        dex = Val(TextBox1.Text)
        Dim sqlcmd As SqlCommand
        Dim query As String
        If TextBox1.Text = "" Then
            MsgBox("DexNO filed is Mandatory !")
            Exit Sub
        End If
        query = "select * from pokemon where DexNO = " & dex
        Try
            sqlcmd = New SqlCommand(query, con)
            sqlcmd.ExecuteNonQuery()
            MsgBox("Pokemon Found")
            Dim adp As SqlDataAdapter
            Dim dt As DataTable
            adp = New SqlDataAdapter("select * from pokemon where DexNO = " & dex, con)
            dt = New DataTable()
            adp.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
