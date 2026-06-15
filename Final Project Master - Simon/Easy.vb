Public Class Easy
    'Detailed explenation in normal
    Dim sequence(100) As Integer
    Dim amount As Integer
    'Green is 1
    'Blue is 2
    'Red is 3
    Dim Playing As String
    Dim counter As Integer
    Private Sub EndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndToolStripMenuItem.Click
        'End
        MsgBox("Sorry this function has been disabled for the Expo", MsgBoxStyle.Information, "Function Disabled")
    End Sub

    Sub correct()
        If counter > amount Then
            Score += 1
            amount += 1
            counter = 1
            LblScore.Text = "Score: " & Score
            Call Pattern()
        End If
        If time - 0.05 > 0.15 Then
            time -= 0.005
        End If
    End Sub
    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        My.Computer.Audio.Play("SimonStop.wav", AudioPlayMode.WaitToComplete)
        Me.Close()
        MainMenu.Show()
        My.Computer.Audio.Play("SimonMainMenu.wav", AudioPlayMode.BackgroundLoop)
        ReDim sequence(100)
    End Sub
    Sub Fail()
        My.Computer.Audio.Play("Fail.wav", AudioPlayMode.Background)
        If Score >= Minumum Then
            Name = InputBox("Name for leaderboard, please be appropriate", "Game Over")
            HighScore.LstHighScore.Items.Add(Name & vbTab & vbTab & vbTab & Score & vbTab & vbTab & vbTab & Difficulty)
        Else
            Name = MsgBox("Game Over...", MsgBoxStyle.Information, "Game Over")
        End If
        ReDim sequence(100)
        My.Computer.Audio.Play("SimonMainMenu.wav", AudioPlayMode.BackgroundLoop)
        Me.Close()
        HighScore.Show()
    End Sub

    Private Sub Easy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play("SimonStart.wav", AudioPlayMode.Background)
        Dim color As Integer
        For x = 1 To 100
            color = Int(Rnd() * 3) + 1
            sequence(x) = color
        Next
        Score = 0
        amount = 1
        Playing = "False"
        counter = 1
        Difficulty = "Easy"
        Minumum = 10
        time = 0.625
        LblScore.Text = "Hit Green to Start"
    End Sub

    Private Sub PicGreen_Click(sender As Object, e As EventArgs) Handles PicGreen.Click
        'Testing random
        'LblScore.Text = sequence(1)
        If Playing = "False" Then
            Playing = "True"
            LblScore.Text = "Score: 0"
            Call Pattern()
        Else
            PicGreen.BackColor = Color.LimeGreen
            If sequence(counter) = 1 Then
                My.Computer.Audio.Play("Green.wav", AudioPlayMode.Background)
                Call Disable()
                Wait(0.5)
                PicGreen.BackColor = Color.DarkGreen
                Wait(0.5)
                Call Enable()
                counter += 1
                Call correct()
            Else
                Call Fail()
            End If
        End If
    End Sub
    Sub Pattern()
        Call Disable()
        For x = 1 To amount
            If sequence(x) = 1 Then
                'Green
                My.Computer.Audio.Play("Green.wav", AudioPlayMode.Background)
                PicGreen.BackColor = Color.LimeGreen
            ElseIf sequence(x) = 2 Then
                'Blue
                My.Computer.Audio.Play("Blue.wav", AudioPlayMode.Background)
                PicBlue.BackColor = Color.LightBlue
            Else
                'Red
                My.Computer.Audio.Play("Red.wav", AudioPlayMode.Background)
                PicRed.BackColor = Color.Red
            End If
            Wait(time)
            PicRed.BackColor = Color.Firebrick
            PicBlue.BackColor = Color.Navy
            PicGreen.BackColor = Color.DarkGreen
            Wait(time)
        Next
        Call Enable()
    End Sub
    Sub Disable()
        PicRed.Enabled = False
        PicGreen.Enabled = False
        PicBlue.Enabled = False
    End Sub
    Sub Enable()
        PicBlue.Enabled = True
        PicGreen.Enabled = True
        PicRed.Enabled = True
    End Sub

    Private Sub PicRed_Click(sender As Object, e As EventArgs) Handles PicRed.Click
        If Playing = "False" Then

        Else
            PicRed.BackColor = Color.Red
            If sequence(counter) = 3 Then
                My.Computer.Audio.Play("Red.wav", AudioPlayMode.Background)
                Call Disable()
                Wait(0.5)
                PicRed.BackColor = Color.Firebrick
                Wait(0.5)
                Call Enable()
                counter += 1
                Call correct()
            Else
                Call Fail()
            End If
        End If
    End Sub

    Private Sub PicBlue_Click(sender As Object, e As EventArgs) Handles PicBlue.Click
        If Playing = "False" Then

        Else
            PicBlue.BackColor = Color.LightBlue
            If sequence(counter) = 2 Then
                My.Computer.Audio.Play("Blue.wav", AudioPlayMode.Background)
                Call Disable()
                Wait(0.5)
                PicBlue.BackColor = Color.Navy
                Wait(0.5)
                Call Enable()
                counter += 1
                Call correct()
            Else
                Call Fail()
            End If
        End If
    End Sub
End Class