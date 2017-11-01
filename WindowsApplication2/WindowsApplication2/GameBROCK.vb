Public Class GameBROCK

    Private Sub GameBROCK_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ProgressBar2.Value = ProgressBar2.Value - 10

            PictureBox1.ImageLocation = "C:\Users\Pavan96\Desktop\RDBMS PROJECT\rdbms\images\pikanormal.jpg"
            For i As Integer = 1 To 50
                System.Threading.Thread.Sleep(10)
                System.Windows.Forms.Application.DoEvents()
            Next
            PictureBox1.ImageLocation = "C:\Users\Pavan96\Desktop\RDBMS PROJECT\rdbms\images\pika.png"
        Catch ex As Exception
            MsgBox("Player1 ASH has WON !! ")
            MsgBox("Play multiple Rounds . The health of the pokemons have been Reset !")
            ProgressBar1.Value = 100
            ProgressBar2.Value = 100
        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            ProgressBar1.Value = ProgressBar1.Value - 10

            PictureBox2.ImageLocation = "C:\Users\Pavan96\Desktop\RDBMS PROJECT\rdbms\images\charizardnormal.gif"
            For i As Integer = 1 To 50
                System.Threading.Thread.Sleep(10)
                System.Windows.Forms.Application.DoEvents()
            Next
            PictureBox2.ImageLocation = "C:\Users\Pavan96\Desktop\RDBMS PROJECT\rdbms\images\charizard.png"
        Catch ex As Exception
            MsgBox("Player2 BROCK has WON !! ")
            MsgBox("Play multiple Rounds . The health of the pokemons have been Reset !")
            ProgressBar1.Value = 100
            ProgressBar2.Value = 100
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            ProgressBar1.Value = ProgressBar1.Value + 10

            PictureBox1.ImageLocation = "C:\Users\Pavan96\Desktop\RDBMS PROJECT\rdbms\images\heal.jpg"
            For i As Integer = 1 To 20
                System.Threading.Thread.Sleep(10)
                System.Windows.Forms.Application.DoEvents()
            Next
            PictureBox1.ImageLocation = "C:\Users\Pavan96\Desktop\RDBMS PROJECT\rdbms\images\pika.png"
        Catch ex As Exception
            MsgBox("Healed To Max Health ")
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            ProgressBar2.Value = ProgressBar2.Value + 10

            PictureBox2.ImageLocation = "C:\Users\Pavan96\Desktop\RDBMS PROJECT\rdbms\images\heal.jpg"
            For i As Integer = 1 To 20
                System.Threading.Thread.Sleep(10)
                System.Windows.Forms.Application.DoEvents()
            Next
            PictureBox2.ImageLocation = "C:\Users\Pavan96\Desktop\RDBMS PROJECT\rdbms\images\charizard.png"
        Catch ex As Exception
            MsgBox("Healed To Max Health ")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ProgressBar2.Value = ProgressBar2.Value - 5

            PictureBox1.ImageLocation = "C:\Users\Pavan96\Desktop\RDBMS PROJECT\rdbms\images\pikanormal.jpg"
            For i As Integer = 1 To 50
                System.Threading.Thread.Sleep(10)
                System.Windows.Forms.Application.DoEvents()
            Next
            PictureBox1.ImageLocation = "C:\Users\Pavan96\Desktop\RDBMS PROJECT\rdbms\images\pika.png"
        Catch ex As Exception
            MsgBox("Player1 ASH has WON !!")
            MsgBox("Play multiple Rounds . The health of the pokemons have been Reset !")
            ProgressBar1.Value = 100
            ProgressBar2.Value = 100
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            ProgressBar1.Value = ProgressBar1.Value - 5

            PictureBox2.ImageLocation = "C:\Users\Pavan96\Desktop\RDBMS PROJECT\rdbms\images\charizardnormal.gif"
            For i As Integer = 1 To 50
                System.Threading.Thread.Sleep(10)
                System.Windows.Forms.Application.DoEvents()
            Next
            PictureBox2.ImageLocation = "C:\Users\Pavan96\Desktop\RDBMS PROJECT\rdbms\images\charizard.png"
        Catch ex As Exception
            MsgBox("Player2 BROCK has WON !!")
            MsgBox("Play multiple Rounds . The health of the pokemons have been Reset !")
            ProgressBar1.Value = 100
            ProgressBar2.Value = 100
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            ProgressBar2.Value = ProgressBar2.Value - 15

            PictureBox1.ImageLocation = "C:\Users\Pavan96\Desktop\RDBMS PROJECT\rdbms\images\Pikachuhidden.jpg"
            For i As Integer = 1 To 50
                System.Threading.Thread.Sleep(10)
                System.Windows.Forms.Application.DoEvents()
            Next
            PictureBox1.ImageLocation = "C:\Users\Pavan96\Desktop\RDBMS PROJECT\rdbms\images\pika.png"
        Catch ex As Exception
            MsgBox("Player1 ASH has WON !!")
            MsgBox("Play multiple Rounds . The health of the pokemons have been Reset !")
            ProgressBar1.Value = 100
            ProgressBar2.Value = 100
        End Try

    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub GameASH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            ProgressBar1.Value = ProgressBar1.Value - 15

            PictureBox2.ImageLocation = "C:\Users\Pavan96\Desktop\RDBMS PROJECT\rdbms\images\charizardhidden.jpeg"
            For i As Integer = 1 To 50
                System.Threading.Thread.Sleep(10)
                System.Windows.Forms.Application.DoEvents()
            Next
            PictureBox2.ImageLocation = "C:\Users\Pavan96\Desktop\RDBMS PROJECT\rdbms\images\charizard.png"
        Catch ex As Exception
            MsgBox("Player2 BROCK has WON !!")
            MsgBox("Play multiple Rounds . The health of the pokemons have been Reset !")
            ProgressBar1.Value = 100
            ProgressBar2.Value = 100
        End Try
    End Sub
End Class