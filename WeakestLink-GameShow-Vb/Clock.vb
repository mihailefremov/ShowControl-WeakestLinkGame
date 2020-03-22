Imports WMPLib

Public Class Clock
    Dim WithEvents StartTheClockSong As New WMPLib.WindowsMediaPlayer
    Dim LetsPlayStinger As New WindowsMediaPlayer
    Dim EndRoundStinger As New WindowsMediaPlayer

    Public WithEvents Timer_secondPassed As New System.Windows.Forms.Timer
    Public WithEvents Timer_statisticsReveal As New System.Windows.Forms.Timer

    Dim SoundFolderPath As String = "C:\Weakest Link\Sounds\"
    Dim SoundName As String = ""

    Sub New()
        Timer_secondPassed.Interval = 1000
        Timer_statisticsReveal.Interval = 2200
        'Timer_secondPassed.Interval = 1000
        'AddHandler Timer_secondPassed.Elapsed, AddressOf Timer_secondPassed_Tick
        '41 1:30
        '40 1:40
        '39 1:50
        '38 2:00
        '33 2:00
        '32 2:20
        '31 2:10
        '30 2:30
        '10 BankGoal
        '9 EndRound
        '8 Start the Clock
        '6 Let's Play
        '17 Let's Play Head to Head
        '18 Head to Head Bed
        '19 Let's Play Sudden Death 
    End Sub

    Public Sub TimerEventProcessor(myObject As Object, ByVal myEventArgs As EventArgs) Handles Timer_secondPassed.Tick

        SecondPassedEvent()

    End Sub

    Public Sub TimerEventProcessor2(myObject As Object, ByVal myEventArgs As EventArgs) Handles Timer_statisticsReveal.Tick

        QuizOperator.Statistics.MarkWeakStrongLinkInTable()
        QuizOperator.CG.MoneyTreeMove(-1)
        QuizOperator.CG.EndClockRound()

        Timer_statisticsReveal.Stop()

    End Sub

    Public Sub SecondPassedEvent()

        QuizOperator.Clock_Textbox.Text -= 1

        If Val(QuizOperator.Clock_Textbox.Text) <= 0 Then
            ClockFinishedEvent()
            Timer_statisticsReveal.Start()
        End If

    End Sub

    Public Sub ClockFinishedEvent()

        QuizOperator.MoneyTree.TotalBankMoneyTree()
        Timer_secondPassed.Stop()
        Timer_statisticsReveal.Start()

    End Sub

    Function ResetClockNextRound(ByVal Round As Integer) As Integer

        If Round = 1 Then
            Return 150
        ElseIf Round = 2 Then
            Return 140
        ElseIf Round = 3 Then
            Return 130
        ElseIf Round = 4 Then
            Return 120
        ElseIf Round = 5 Then
            Return 110
        ElseIf Round = 6 Then
            Return 100
        ElseIf Round = 7 Then
            Return 90
        Else
            Return 0
        End If

    End Function

    Public Sub PlayFullClockRoundSound(ByVal Round As Integer)

        If Round = 1 Then
            SoundName = "30 Audio Track.wav"
        End If
        If Round = 2 Then
            SoundName = "31 Audio Track.wav"
        End If
        If Round = 3 Then
            SoundName = "32 Audio Track.wav"
        End If
        If Round = 4 Then
            SoundName = "33 Audio Track.wav"
        End If
        If Round = 5 Then
            SoundName = "39 Audio Track.wav"
        End If
        If Round = 6 Then
            SoundName = "40 Audio Track.wav"
        End If
        If Round = 7 Then
            SoundName = "41 Audio Track.wav"
        End If
        If Round = 8 Then
            SoundName = "18 Audio Track.wav"
        End If
        If Round = 9 Then
            'SoundName = "20 Audio Track.wav"
        End If

        StartTheClockSong.URL = SoundFolderPath + SoundName
        StartTheClockSong.controls.play()

    End Sub

    Public Sub StopRoundSong()
        StartTheClockSong.controls.stop()

    End Sub

    Public Sub PlayLetsPlaySound(ByVal Round As Integer)

        If Round >= 1 And Round <= 7 Then
            SoundName = "6 Audio Track.wav"
        End If
        If Round = 8 Then
            SoundName = "17 Audio Track.wav"
        End If
        If Round = 9 Then
            SoundName = "19 Audio Track.wav"
        End If

        LetsPlayStinger.URL = SoundFolderPath + SoundName
        LetsPlayStinger.controls.play()

    End Sub

    Public Sub PlayStartTheClockSound()

        SoundName = "8 Audio Track.wav"

        StartTheClockSong.URL = SoundFolderPath + SoundName
        StartTheClockSong.controls.play()

    End Sub

    Public Sub PlayEndClockSound()

        SoundName = "9 Audio Track.wav"

        EndRoundStinger.URL = SoundFolderPath + SoundName
        EndRoundStinger.controls.play()

    End Sub

    Public Sub BankGoalSound()
        SoundName = "10 Audio Track.wav"

        EndRoundStinger.URL = SoundFolderPath + SoundName
        EndRoundStinger.controls.play()

        StopRoundSong()

    End Sub

End Class
