Public Class Splash
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("SimonMainMenu.wav", AudioPlayMode.BackgroundLoop)
    End Sub
End Class
