Public Class Hard
    'Detailed explenation in normal
    Dim sequence(100) As Integer
    Dim amount As Integer
    'Green is 1
    'Blue is 2
    'Red is 3
    'Yellow is 4
    'Purple is 5
    Dim Playing As String
    Dim counter As Integer
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

    Private Sub EndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndToolStripMenuItem.Click
        'End
        MsgBox("Sorry this function has been disabled for the Expo", MsgBoxStyle.Information, "Function Disabled")
    End Sub

    Sub Fail()
        My.Computer.Audio.Play("Fail.wav", AudioPlayMode.Background)
        If Score >= Minumum Then
            Name = InputBox("Name for leaderboard, please be appropriate", "Game Over")
            HighScore.LstHighScore.Items.Add(Name & vbTab & vbTab & vbTab & Score & vbTab & vbTab & vbTab & Difficulty)
        Else
            Name = MsgBox("Game Over...", MsgBoxStyle.Information, "Not high enough score")
        End If
        ReDim sequence(100)
        My.Computer.Audio.Play("SimonMainMenu.wav", AudioPlayMode.BackgroundLoop)
        Me.Close()
        HighScore.Show()
    End Sub

    Private Sub Hard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play("SimonStart.wav", AudioPlayMode.Background)
        Dim color As Integer
        For x = 1 To 100
            color = Int(Rnd() * 5) + 1
            sequence(x) = color
        Next
        Score = 0
        amount = 1
        Minumum = 10
        Playing = "False"
        counter = 1
        Difficulty = "Hard"
        LblScore.Text = "Hit Green to Start"
        time = 0.35
    End Sub

    Private Sub PicGreen_Click(sender As Object, e As EventArgs) Handles PicGreen.Click
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
                Wait(0.25)
                Call Enable()
                counter += 1
                Call correct()
            Else
                Call Fail()
            End If
        End If
    End Sub
    'Made Subs
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
            ElseIf sequence(x) = 3 Then
                'Red
                My.Computer.Audio.Play("Red.wav", AudioPlayMode.Background)
                PicRed.BackColor = Color.Red
            ElseIf sequence(x) = 4 Then
                'Yellow
                My.Computer.Audio.Play("Yellow.wav", AudioPlayMode.Background)
                PicYellow.BackColor = Color.Yellow
            Else
                'Purple
                My.Computer.Audio.Play("5High.wav", AudioPlayMode.Background)
                PicPurple.BackColor = Color.Magenta
            End If
            Wait(time)
            PicRed.BackColor = Color.Firebrick
            PicBlue.BackColor = Color.Navy
            PicGreen.BackColor = Color.DarkGreen
            PicYellow.BackColor = Color.DarkGoldenrod
            PicPurple.BackColor = Color.Purple
            Wait(time)
        Next
        Call Enable()
    End Sub
    Sub Disable()
        PicRed.Enabled = False
        PicGreen.Enabled = False
        PicBlue.Enabled = False
        PicPurple.Enabled = False
        PicYellow.Enabled = False
    End Sub
    Sub Enable()
        PicBlue.Enabled = True
        PicGreen.Enabled = True
        PicRed.Enabled = True
        PicPurple.Enabled = True
        PicYellow.Enabled = True
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
                Wait(0.25)
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
                Wait(0.25)
                Call Enable()
                counter += 1
                Call correct()
            Else
                Call Fail()
            End If
        End If
    End Sub

    Private Sub PicPurple_Click(sender As Object, e As EventArgs) Handles PicPurple.Click
        If Playing = "False" Then

        Else
            PicPurple.BackColor = Color.Magenta
            If sequence(counter) = 5 Then
                My.Computer.Audio.Play("5High.wav", AudioPlayMode.Background)
                Call Disable()
                Wait(0.5)
                PicPurple.BackColor = Color.Purple
                Wait(0.25)
                Call Enable()
                counter += 1
                Call correct()
            Else
                Call Fail()
            End If
        End If
    End Sub

    Private Sub PicYellow_Click(sender As Object, e As EventArgs) Handles PicYellow.Click
        If Playing = "False" Then

        Else
            PicYellow.BackColor = Color.Yellow
            If sequence(counter) = 4 Then
                My.Computer.Audio.Play("Yellow.wav", AudioPlayMode.Background)
                Call Disable()
                Wait(0.5)
                PicYellow.BackColor = Color.DarkGoldenrod
                Wait(0.25)
                Call Enable()
                counter += 1
                Call correct()
            Else
                Call Fail()
            End If
        End If
    End Sub
End Class