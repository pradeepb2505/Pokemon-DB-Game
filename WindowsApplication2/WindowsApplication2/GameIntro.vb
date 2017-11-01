Public Class GameIntro
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("You have selected ASH !")
        MsgBox("Player will take turns one by one to attack.They can choose any one of the attacks.They may also choose to Heal their pokemon. Hidden ability can be used only once during the whole battle ! ENJOY GAMING !!")
        GameASH.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("You have selected MYSTICAL !")
        MsgBox("Player will take turns one by one to attack.They can choose any one of the attacks.They may also choose to Heal their pokemon. Hidden ability can be used only once during the whole battle ! ENJOY GAMING !!")
        GameMYSTICAL.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("You have selected BROCK !")
        MsgBox("Player will take turns one by one to attack.They can choose any one of the attacks.They may also choose to Heal their pokemon. Hidden ability can be used only once during the whole battle ! ENJOY GAMING !!")
        GameBROCK.Show()
    End Sub

    Private Sub GameIntro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call PlayBackgroundSoundFile()
    End Sub
    Sub PlayBackgroundSoundFile()
        My.Computer.Audio.Play("C:\Users\PradeepB\Desktop\RDBMS PROJECT\rdbms\po.wav",
        AudioPlayMode.Background)
    End Sub
End Class