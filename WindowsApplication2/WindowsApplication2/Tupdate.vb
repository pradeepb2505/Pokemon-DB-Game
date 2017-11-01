Imports System.Data.SqlClient

Public Class Tupdate
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Enter all fields !")
            Exit Sub
        End If
        Dim tid As Integer
        tid = Val(ComboBox1.Text)
        Dim query As String
        query = "update trainer set name='" & TextBox2.Text & "',lvl='" & TextBox3.Text & "',place='" & TextBox4.Text & "',skill='" & TextBox5.Text & "',coins='" & TextBox6.Text & "' where tid=" & tid
        Dim ex As SqlCommand
        Try
            ex = New SqlCommand(query, con)
            ex.ExecuteNonQuery()
            MsgBox("Trainer Updated")
        Catch exc As Exception
            MsgBox(exc.Message)
        End Try
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String
        query = "select tid from trainer order by tid"
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

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim query As String
        query = "select * from trainer where tid = '" & ComboBox1.Text & "'"
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
            TextBox5.Text = dt1.Rows(0).Item(4)
            TextBox6.Text = dt1.Rows(0).Item(5)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class