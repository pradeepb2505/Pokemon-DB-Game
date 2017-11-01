Public Class Start
    Private Sub PokemonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PokemonToolStripMenuItem.Click
        Pokemon.Show()
    End Sub

    Private Sub TrainerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrainerToolStripMenuItem.Click
        Trainer.Show()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connect()
    End Sub

    Private Sub PokeCenterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PokeCenterToolStripMenuItem.Click
        PokeCenter.Show()
    End Sub

    Private Sub GymToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GymToolStripMenuItem.Click
        Gym.Show()
    End Sub

    Private Sub GameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GameToolStripMenuItem.Click

    End Sub

    Private Sub GoGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoGameToolStripMenuItem.Click
        GameIntro.Show()
    End Sub

    Private Sub PokeStopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PokeStopToolStripMenuItem.Click
        PStop.Show()
    End Sub
End Class