Imports VB = Microsoft.VisualBasic
Module Module1
    Public Score As Integer
    Public Difficulty As String
    Public Name As String
    Public Minumum As Integer
    Public time As Single
    Public Sub Wait(ByVal seconds As Single)
        Static start As Single
        start = VB.Timer()
        Do While VB.Timer() < start + seconds
            System.Windows.Forms.Application.DoEvents()
        Loop
    End Sub

End Module
