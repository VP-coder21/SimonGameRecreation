Public Class HighScore
    Private Sub BtnBckMenu_Click(sender As Object, e As EventArgs) Handles BtnBckMenu.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub EndProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndProgramToolStripMenuItem.Click
        'MainMenu.Close()
    End Sub

    Private Sub EndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndToolStripMenuItem.Click
        'End
        MsgBox("Sorry this function has been disabled for the Expo", MsgBoxStyle.Information, "Function Disabled")
    End Sub
End Class