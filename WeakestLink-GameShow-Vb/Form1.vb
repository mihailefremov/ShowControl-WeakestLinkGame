Imports Svt.Caspar
Public Class QuizOperator

    Public Shared CurrentRound As Integer

    Public GameDatabase As New GameDatabasе()
    Public MoneyTree As New MoneyTree()
    Public Contestant As New Contestant()
    Public Statistics As New Statistics()
    Public Clock As New Clock()

    Public CG As New CharacterGenerator()

    Private Sub QuizOperator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ProducerQuestionPreset.Show()
        CG.MoneyTreeSet()
        CG.HeadToHeadSet()

    End Sub

    Private Sub LetsPlay_Button_Click(sender As Object, e As EventArgs) Handles LetsPlay_Button.Click
        Contestant.FirstAndFinalRoundStarts()
        Contestant.MakeListOfContestantsNames()
        Clock_Textbox.Text = Clock.ResetClockNextRound(Contestant.CurrentRound)
        Clock.PlayLetsPlaySound(Contestant.CurrentRound)
        If CurrentRound_Textbox.Text = 8 Then
            CG.UpdateNamesFinalRound()
        End If

    End Sub

    Private Sub StartRound_Button_Click(sender As Object, e As EventArgs) Handles StartRound_Button.Click
        If Contestant.CurrentRound >= 1 And Contestant.CurrentRound <= 7 Then
            Clock.PlayFullClockRoundSound(Contestant.CurrentRound)
            Clock.Timer_secondPassed.Start()
            CG.StartRound(Contestant.CurrentRound)

        Else

        End If

        GameDatabase.GetPreSetQuestion(Contestant.CurrentRound, Contestant.CurrentContestant)

    End Sub

    Public Sub GetPreSetQuestion()
        GameDatabase.MarkQuestionAnswered()
        GameDatabase.GetPreSetQuestion(Contestant.CurrentRound, Contestant.CurrentContestant)
        'MessageBox.Show(FinalActiveQuestionNumber_Textbox.Text + " " + Contestant.CurrentContestant.ToString)
        CG.OpenQuestionFinalRound(FinalActiveQuestionNumber_Textbox.Text, Contestant.CurrentContestant)

    End Sub

    Private Sub PreSetQuestion_Button_Click(sender As Object, e As EventArgs) Handles PreSetQuestion_Button.Click
        GetPreSetQuestion()

    End Sub

    Private Sub CorrectAnswerGiven_Button_Click(sender As Object, e As EventArgs) Handles CorrectAnswerGiven_Button.Click
        CorrectAnswerGiven()

    End Sub

    Public Sub CorrectAnswerGiven()
        If Contestant.CurrentRound >= 1 And Contestant.CurrentRound <= 7 Then
            MoneyTree.CorrectAnswerMoneyTree()
            Statistics.FillCorectStatistics(Contestant.CurrentContestant, MoneyTree.GetCorrectAnswerPoints)
        End If
        If Contestant.CurrentRound >= 8 Then
            Statistics.FillCorectStatistics(Contestant.CurrentContestant, 0)
            CG.CorrectAnswerFinalRound(FinalActiveQuestionNumber_Textbox.Text, CurrentPlayerPosition_TextBox.Text)
            Contestant.FinalRoundsQuestion()
        End If
        Contestant.NextContestant()
        Statistics.PredictWinners(CurrentPlayerPosition_TextBox.Text)
        GetPreSetQuestion()

    End Sub

    Private Sub IncorrectAnswerGiven_Button_Click(sender As Object, e As EventArgs) Handles IncorrectAnswerGiven_Button.Click
        IncorrectAnswerGiven()

    End Sub

    Public Sub IncorrectAnswerGiven()
        If Contestant.CurrentRound >= 1 And Contestant.CurrentRound <= 7 Then
            Statistics.FillIncorectStatistics(Contestant.CurrentContestant, MoneyTree.GetIncorrectAnswerPoints)
            MoneyTree.IncorrectAnswerMoneyTree()
        End If
        If Contestant.CurrentRound >= 8 Then
            Statistics.FillIncorectStatistics(Contestant.CurrentContestant, 0)
            CG.IncorrectAnswerFinalRound(FinalActiveQuestionNumber_Textbox.Text, CurrentPlayerPosition_TextBox.Text)
            Contestant.FinalRoundsQuestion()
        End If
        Contestant.NextContestant()
        Statistics.PredictWinners(CurrentPlayerPosition_TextBox.Text)
        GetPreSetQuestion()

    End Sub

    Private Sub BankSaid_Button_Click(sender As Object, e As EventArgs) Handles BankSaid_Button.Click
        BankSaid()

    End Sub

    Public Sub BankSaid()
        Statistics.FillBankStatistics(Contestant.CurrentContestant, MoneyTree.GetBankPoints)
        MoneyTree.CurrentBankMoneyTree()

    End Sub


    Private Sub NextRound_Button_Click(sender As Object, e As EventArgs) Handles NextRound_Button.Click
        CurrentRound_Textbox.Text += 1
        If CurrentRound_Textbox.Text = "10" Then
            CurrentRound_Textbox.Text = "0"
        End If
        Contestant.CurrentRound = CurrentRound_Textbox.Text

        If Contestant.CurrentRound >= 1 And Contestant.CurrentRound <= 8 Then
            MoneyTree.ResetTreeNextRound()
            Clock_Textbox.Text = Clock.ResetClockNextRound(Contestant.CurrentRound)

            Statistics.WeakStrongLink_PositionsVerdict()
            Contestant.CurrentContestant = Statistics.StrongestLinkPosition
            CurrentPlayerPosition_TextBox.Text = Contestant.CurrentContestant

            Statistics.ResetStatisticTable()
        End If
        Contestant.MakeListOfContestantsNames()

        If Contestant.CurrentRound >= 8 Then
            FinalContestant1name_Textbox.Text = Contestant.MakeListOfContestantsNames().Item(Contestant.MakeListOfContestantsStatistics().First().Key)
            FinalContestant2name_Textbox.Text = Contestant.MakeListOfContestantsNames().Item(Contestant.MakeListOfContestantsStatistics().Last().Key)
            FinalContestant1verdict_Textbox.Text = Contestant.MakeListOfContestantsStatistics.First.Value
            FinalContestant2verdict_Textbox.Text = Contestant.MakeListOfContestantsStatistics.Last.Value
            CG.HeadToHeadSet()
        End If

    End Sub

    Private Sub ContestantNext_Label_Click(sender As Object, e As EventArgs) Handles ContestantNext_Label.Click
        Contestant.NextContestant()

    End Sub

    Private Sub WLSLVerdict_Button_Click(sender As Object, e As EventArgs) Handles WLSLVerdict_Button.Click
        Statistics.MarkWeakStrongLinkInTable()

    End Sub

    Private Sub CurrentPlayerPosition_TextBox_TextChanged(sender As Object, e As EventArgs) Handles CurrentPlayerPosition_TextBox.TextChanged
        ShowPlayingContestant()

    End Sub

    Public Sub ShowPlayingContestant()
        If Contestant.CurrentRound >= 1 And Contestant.CurrentRound <= 7 Then
            Dim TextBox As String = "Contestant" + Contestant.CurrentContestant.ToString + "name_TextBox"

            For Each tb As TextBox In Me.TabPage1.Controls.OfType(Of TextBox)()
                If String.Compare(TextBox, tb.Name, True) = 0 Then
                    CurrentPlayerName_Textbox.Text = tb.Text
                End If
            Next
        End If
        If Contestant.CurrentRound >= 8 Then
            Dim TextBox As String = "FinalContestant" + Contestant.CurrentContestant.ToString + "name_TextBox"

            For Each tb As TextBox In Me.TabPage2.Controls.OfType(Of TextBox)()
                If String.Compare(TextBox, tb.Name, True) = 0 Then
                    CurrentPlayerName_Textbox.Text = tb.Text
                End If
            Next
        End If

    End Sub

    Private Sub Clock_Textbox_TextChanged(sender As Object, e As EventArgs) Handles Clock_Textbox.TextChanged
        Dim Value As Integer
        Dim Minutes As Integer = 0
        Dim Seconds As Integer = 0

        Value = Me.Clock_Textbox.Text
        Minutes = Math.Floor(Value / 60)
        Seconds = Value Mod 60

        Me.ClockMinutes_Label.Text = Minutes
        Me.ClockSeconds_Label.Text = Seconds

        If Len(Seconds.ToString) = 1 Then
            Me.ClockSeconds_Label.Text = "0" + Seconds.ToString
        End If

        CG.UpdateClock(ClockMinutes_Label.Text + ":" + ClockSeconds_Label.Text)

    End Sub

    Private Sub CurrentBank_Textbox_TextChanged(sender As Object, e As EventArgs) Handles CurrentBank_Textbox.TextChanged
        MoneyTree.BankGoalCheck()
        CG.UpdateCurrentBank(MoneyTree.Bank)

    End Sub

    Private Sub Clock_Label_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If Clock.Timer_secondPassed.Enabled = True Then
            Clock.Timer_secondPassed.Stop()
            MessageBox.Show("Clock Stopped")
        Else
            Clock.Timer_secondPassed.Start()
        End If

    End Sub

    Private Sub TotalBank_TextBox_TextChanged(sender As Object, e As EventArgs) Handles TotalBank_TextBox.TextChanged
        CG.UpdateTotalBank(TotalBank_TextBox.Text)
    End Sub

    Private Sub FadeInTotalBank_Label_Click(sender As Object, e As EventArgs) Handles FadeInTotalBank_Label.Click
        CG.FadeInTotalBank()
    End Sub

    Private Sub FadeOutTotalBank_Label_Click(sender As Object, e As EventArgs) Handles FadeOutTotalBank_Label.Click
        CG.FadeOutTotalBank()
    End Sub

    Private Sub FadeInTree_Label_Click(sender As Object, e As EventArgs) Handles FadeInTree_Label.Click
        CG.FadeInTree()
    End Sub

    Private Sub FadeOutTree_Label_Click(sender As Object, e As EventArgs) Handles FadeOutTree_Label.Click
        CG.FadeOutTree()
    End Sub

    Private Sub CurrentRound_Textbox_TextChanged(sender As Object, e As EventArgs) Handles CurrentRound_Textbox.TextChanged
        Contestant.CurrentRound = CurrentRound_Textbox.Text

    End Sub

    Private Sub CasparConnect_Label_Click(sender As Object, e As EventArgs) Handles CasparConnect_Label.Click
        CG.CasparCGConnect()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Statistics.PredictWinners(CurrentPlayerPosition_TextBox.Text)

    End Sub

    Private Sub FadeInFinal_Label_Click(sender As Object, e As EventArgs) Handles FadeInFinal_Label.Click
        CG.FadeInHeadToHead()

    End Sub

    Private Sub FadeOutFinal_Label_Click(sender As Object, e As EventArgs) Handles FadeOutFinal_Label.Click
        CG.FadeOutHeadToHead()

    End Sub
End Class
