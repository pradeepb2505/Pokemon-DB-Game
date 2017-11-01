Imports System.Data.SqlClient
Public Class Pupdate
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String
        query = "select DexNO from pokemon order by DexNO"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Or TextBox11.Text = "" Or TextBox12.Text = "" Or TextBox13.Text = "" Then
            MsgBox("Enter all fields !")
            Exit Sub
        End If
        Dim dex As Integer
        dex = Val(ComboBox1.Text)
        Dim query As String
        query = "update pokemon set Name='" & TextBox3.Text & "',EvolvesFrom='" & TextBox4.Text & "',TypeOne='" & TextBox5.Text & "',TypeTwo='" & TextBox6.Text & "',AbilityOne='" & TextBox7.Text & "',AbilityTwo='" & TextBox8.Text & "',HiddenAbility='" & TextBox9.Text & "',Region='" & TextBox10.Text & "',Status='" & TextBox11.Text & "',CP='" & TextBox12.Text & "',HP='" & TextBox13.Text & "' where DexNO=" & dex
        Dim ex As SqlCommand
        Try
            ex = New SqlCommand(query, con)
            ex.ExecuteNonQuery()
            MsgBox("Pokemon Updated")
        Catch exc As Exception
            MsgBox(exc.Message)
        End Try
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim query As String
        query = "select * from pokemon where DexNO = '" & ComboBox1.Text & "'"
        Try

            Dim rs As SqlDataAdapter
            rs = New SqlDataAdapter(query, con)
            Dim dt1 As New DataTable
            rs.Fill(dt1)

            Dim n As Integer
            n = dt1.Rows.Count

            TextBox3.Text = dt1.Rows(0).Item(1)

            If IsDBNull(dt1.Rows(0).Item(2)) Then
                TextBox4.Text = ""
            Else
                TextBox4.Text = dt1.Rows(0).Item(2)
            End If

            TextBox5.Text = dt1.Rows(0).Item(3)

            If IsDBNull(dt1.Rows(0).Item(4)) Then
                TextBox6.Text = ""
            Else
                TextBox6.Text = dt1.Rows(0).Item(4)
            End If

            TextBox7.Text = dt1.Rows(0).Item(5)

            If IsDBNull(dt1.Rows(0).Item(6)) Then
                TextBox8.Text = ""
            Else
                TextBox8.Text = dt1.Rows(0).Item(6)
            End If


            If IsDBNull(dt1.Rows(0).Item(7)) Then
                TextBox9.Text = ""
            Else
                TextBox9.Text = dt1.Rows(0).Item(7)
            End If


            TextBox10.Text = dt1.Rows(0).Item(8)

            TextBox11.Text = dt1.Rows(0).Item(9)

            TextBox12.Text = dt1.Rows(0).Item(10)

            TextBox13.Text = dt1.Rows(0).Item(11)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class