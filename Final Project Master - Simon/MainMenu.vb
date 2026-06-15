Public Class MainMenu
    Dim Music As String
    Private Sub EndProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndProgramToolStripMenuItem.Click
        'End
    End Sub

    Private Sub BtnInstruct_Click(sender As Object, e As EventArgs) Handles BtnInstruct.Click
        'Go to instructions
        Me.Hide()
        Directions.Show()
    End Sub
    Private Sub CmboDif_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmboDif.SelectedIndexChanged
        'Select the difficulties 
        If CmboDif.Text = "" Then
            MsgBox("Please select a difficulty.", MsgBoxStyle.Information, "Select a Difficulty")
        ElseIf CmboDif.Text = "Easy" Then
            Me.Hide()
            Easy.Show()
        ElseIf CmboDif.Text = "Medium" Then
            Me.Hide()
            Normal.Show()
        ElseIf CmboDif.Text = "Hard" Then
            Me.Hide()
            Hard.Show()
        End If
    End Sub


    Private Sub BtnHigh_Click(sender As Object, e As EventArgs) Handles BtnHigh.Click
        Me.Hide()
        HighScore.Show()
    End Sub

    Private Sub EndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndToolStripMenuItem.Click
        'End
        MsgBox("Sorry this function has been disabled for the Expo, please select a difficulty to continue playing", MsgBoxStyle.Information, "Function Disabled")
    End Sub

    Private Sub BtnMusic_Click(sender As Object, e As EventArgs) Handles BtnMusic.Click
        If Music = "True" Then
            My.Computer.Audio.Stop()
            Music = "False"
            BtnMusic.Text = "Turn Music On"
        Else
            My.Computer.Audio.Play("SimonMainMenu.wav", AudioPlayMode.BackgroundLoop)
            Music = "True"
            BtnMusic.Text = "Turn Music Off"
        End If

    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Music = "True"
    End Sub
End Class