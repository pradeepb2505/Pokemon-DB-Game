Imports System.Data.SqlClient

Public Class PCupdate
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Enter all fields !")
            Exit Sub
        End If
        Dim pcid As Integer
        pcid = Val(ComboBox1.Text)
        Dim query As String
        query = "update pokecenter set name='" & TextBox2.Text & "',location='" & TextBox3.Text & "',doc='" & TextBox4.Text & "' where pcid=" & pcid
        Dim ex As SqlCommand
        Try
            ex = New SqlCommand(query, con)
            ex.ExecuteNonQuery()
            MsgBox("PokeCenter Updated")
        Catch exc As Exception
            MsgBox(exc.Message)
        End Try
    End Sub

    Private Sub PCupdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String
        query = "select pcid from pokecenter order by pcid"
        Try

            Dim rs As SqlDataAdapter
            rs = New SqlDataAdapter(query, con)
            Dim dt1 As New DataTable
            rs.Fill(dt1)

            Dim n, i As Integer
            n = dt1.Rows.Count

            For i = 0 To n - 1
                ComboBox1.Items.Add(dt1.Rows(i).Item(0))
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim query As String
        query = "select * from pokecenter where pcid = '" & ComboBox1.Text & "'"
        Try

            Dim rs As SqlDataAdapter
            rs = New SqlDataAdapter(query, con)
            Dim dt1 As New DataTable
            rs.Fill(dt1)

            Dim n As Integer
            n = dt1.Rows.Count

            TextBox2.Text = dt1.Rows(0).Item(1)
            TextBox3.Text = dt1.Rows(0).Item(2)
            TextBox4.Text = dt1.Rows(0).Item(3)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class