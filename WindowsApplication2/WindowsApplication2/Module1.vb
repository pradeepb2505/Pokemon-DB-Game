Imports System.Data.SqlClient

Module Module1
    Public con As SqlConnection
    Public Function connect()
        con = New SqlConnection("server=PRADEEP;database=pok;uid=pradeep;pwd=pradeep;")
        Try
            con.Open()
            MsgBox("Welcome to the Pokemon-Go Database and Gaming Portal !")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function


End Module
