Imports System.Xml.Schema
'Version: 12/12/22
'Viktor Pangburn
'Alex Yeakle
Public Class Normal
    Dim sequence(100) As Integer
    Dim amount As Integer
    'Green = 1
    'Blue = 2
    'Red = 3
    'Yellow = 4
    Dim Playing As String
    Dim counter As Integer
    Sub correct()   'If the player succeded on the pattern
        If counter > amount Then
            Score += 1
            amount += 1
            counter = 1
            LblScore.Text = "Score: " & Score
            Call Pattern()
        End If
        If time - 0.05 > 0.15 Then 'Every time at the end of the correct pattern, it speeds up.
            time -= 0.005
        End If
    End Sub
    Sub Fail()
        'If player fails pattern
        My.Computer.Audio.Play("Fail.wav", AudioPlayMode.Background)
        If Score >= Minumum Then    'If there score meets the leaderboard requirement
            Name = InputBox("Name for leaderboard, please be appropriate", "Game Over")
            HighScore.LstHighScore.Items.Add(Name & vbTab & vbTab & vbTab & Score & vbTab & vbTab & vbTab & Difficulty) 'Prints name, score, and difficulty in the leaderboard
        Else    'If there score does not meet the leaderboard requirement
            Name = MsgBox("Game Over...", MsgBoxStyle.Information, "Not high enough score")
        End If
        ReDim sequence(100)
        My.Computer.Audio.Play("SimonMainMenu.wav", AudioPlayMode.BackgroundLoop)
        Me.Close()
        HighScore.Show()
    End Sub
    Private Sub Normal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play("SimonStart.wav", AudioPlayMode.Background)
        Dim color As Integer

        'Sets up random sequence ahead of playing 
        For x = 1 To 100
            color = Int(Rnd() * 4) + 1
            sequence(x) = color
        Next

        Minumum = 10
        Score = 0
        amount = 1
        counter = 1
        Playing = "False"
        Difficulty = "Medium"
        LblScore.Text = "Hit Green to Start"
        time = 0.55
    End Sub

    Private Sub PicGreen_Click(sender As Object, e As EventArgs) Handles PicGreen.Click
        If Playing = "False" Then   'Just for green: starts game by clicking on it
            Playing = "True"
            Call Pattern()
            LblScore.Text = "Score: 0"
        Else
            PicGreen.BackColor = Color.LimeGreen      'This code is the same for all PicCOLOR subs
            If sequence(counter) = 1 Then             'When clicked, lights button up, plays sound, turns it off, 
                My.Computer.Audio.Play("Green.wav")       'adds appropriate score or stops the game if player got it wrong

                Call Disable()
                Wait(0.5)

                PicGreen.BackColor = Color.DarkGreen
                Call Enable()
                counter += 1
                Call correct()
            Else
                Call Fail()
            End If
        End If
    End Sub
    Sub Pattern()
        Call Disable()    'Disables PicBoxes while giving pattern to player
        For x = 1 To amount
            If sequence(x) = 1 Then
                My.Computer.Audio.Play("Green.wav", AudioPlayMode.Background)
                PicGreen.BackColor = Color.LimeGreen
            ElseIf sequence(x) = 2 Then
                My.Computer.Audio.Play("Blue.wav", AudioPlayMode.Background)
                PicBlue.BackColor = Color.LightBlue
            ElseIf sequence(x) = 3 Then
                My.Computer.Audio.Play("Red.wav", AudioPlayMode.Background)
                PicRed.BackColor = Color.Red
            ElseIf sequence(x) = 4 Then
                My.Computer.Audio.Play("Yellow.wav", AudioPlayMode.Background)
                PicYellow.BackColor = Color.Yellow

            End If
            Wait(time)  'Displays color for time, then changes back
            PicRed.BackColor = Color.Firebrick
            PicBlue.BackColor = Color.Navy
            PicGreen.BackColor = Color.DarkGreen
            PicYellow.BackColor = Color.DarkGoldenrod
            Wait(time)   'Next item in pattern or re-enable and wait for user input
        Next
        Call Enable()

    End Sub

    Sub Disable()
        PicRed.Enabled = False
        PicGreen.Enabled = False
        PicBlue.Enabled = False
        PicYellow.Enabled = False
    End Sub
    Sub Enable()
        PicBlue.Enabled = True
        PicGreen.Enabled = True
        PicRed.Enabled = True
        PicYellow.Enabled = True
    End Sub
    Private Sub EndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndToolStripMenuItem.Click
        'End Commented out so playes can not end program for the expo
        MsgBox("Sorry this function has been disabled for the Expo", MsgBoxStyle.Information, "Function Disabled")
    End Sub

    Private Sub PicRed_Click(sender As Object, e As EventArgs) Handles PicRed.Click
        If Playing = "True" Then

            PicRed.BackColor = Color.Red
            If sequence(counter) = 3 Then
                My.Computer.Audio.Play("Red.wav")

                Call Disable()

                Wait(0.5)
                PicRed.BackColor = Color.Firebrick
                Call Enable()
                counter += 1

                Call correct()
            Else
                Call Fail()
            End If
        End If

    End Sub

    Private Sub PicYellow_Click(sender As Object, e As EventArgs) Handles PicYellow.Click
        If Playing = "True" Then

            PicYellow.BackColor = Color.Yellow
            If sequence(counter) = 4 Then
                My.Computer.Audio.Play("Yellow.wav")
                Call Disable()
                Wait(0.5)
                PicYellow.BackColor = Color.DarkGoldenrod
                Call Enable()
                counter += 1
                Call correct()
            Else
                Call Fail()
            End If
        End If

    End Sub

    Private Sub PicBlue_Click(sender As Object, e As EventArgs) Handles PicBlue.Click
        If Playing = "True" Then

            PicBlue.BackColor = Color.LightBlue
            If sequence(counter) = 2 Then
                My.Computer.Audio.Play("Blue.wav")
                Call Disable()
                Wait(0.5)
                PicBlue.BackColor = Color.Navy
                Call Enable()
                counter += 1
                Call correct()
            Else
                Call Fail()
            End If
        End If

    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        My.Computer.Audio.Play("SimonStop.wav")   'Game Reset Code: sends player back to main page and clears the sequence
        Me.Close()

        MainMenu.Show()
        My.Computer.Audio.Play("SimonMainMenu.wav", AudioPlayMode.BackgroundLoop)
        ReDim sequence(100)

    End Sub
End Class