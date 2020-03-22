Public Class Contestant

    Public Shared CurrentRound As Integer
    Public Shared CurrentContestant As Integer
    Public Shared FinalContestantPosition As Integer

    Public Shared AlphabeticlyFirstContestant As Integer
    Public Shared BestFromLastRound As Integer

    Public Shared AliveContestants As New List(Of Integer)
    Public Shared QuestionSum As Decimal

    Sub New()
        CurrentContestant = 0
        FinalContestantPosition = 0
        CurrentRound = 0
        QuestionSum = 0
        AliveContestants.Add(1)
        AliveContestants.Add(2)
        AliveContestants.Add(3)
        AliveContestants.Add(4)
        AliveContestants.Add(5)
        AliveContestants.Add(6)
        AliveContestants.Add(7)
        AliveContestants.Add(8)

    End Sub

    Public Sub NextContestant()
        CurrentContestant += 1
        If CurrentContestant >= 9 Or CurrentContestant <= 0 Then
            CurrentContestant = 1
        End If

        If Not (AliveContestants.Contains(CurrentContestant)) Then
            NextContestant()
        Else
            QuizOperator.CurrentPlayerPosition_TextBox.Text = CurrentContestant
        End If

    End Sub

    Friend Function NextFinalContestant(ByVal Contestant As Integer) As Integer
        If Contestant = 1 Then
            Return 2
        Else
            Return 1
        End If
    End Function

    Public Sub KillContestant(ByVal Position As Integer)
        AliveContestants.Remove(Position)

    End Sub

    Public Sub AddContestant(ByVal Position As Integer)
        AliveContestants.Add(Position)
        AliveContestants = AliveContestants.Distinct().ToList()
        AliveContestants.Sort()

    End Sub

    Function MakeListOfContestantsNames() As SortedDictionary(Of Integer, String)

        Dim ContestantNames As New SortedDictionary(Of Integer, String)
        AliveContestants.Clear()

        If QuizOperator.Contestant1_CheckBox.Checked = True Then
            ContestantNames.Add(1, QuizOperator.Contestant1name_TextBox.Text)
            AliveContestants.Add(1)
        End If
        If QuizOperator.Contestant2_CheckBox.Checked = True Then
            ContestantNames.Add(2, QuizOperator.Contestant2name_TextBox.Text)
            AliveContestants.Add(2)
        End If
        If QuizOperator.Contestant3_CheckBox.Checked = True Then
            ContestantNames.Add(3, QuizOperator.Contestant3name_TextBox.Text)
            AliveContestants.Add(3)
        End If
        If QuizOperator.Contestant4_CheckBox.Checked = True Then
            ContestantNames.Add(4, QuizOperator.Contestant4name_TextBox.Text)
            AliveContestants.Add(4)
        End If
        If QuizOperator.Contestant5_CheckBox.Checked = True Then
            ContestantNames.Add(5, QuizOperator.Contestant5name_TextBox.Text)
            AliveContestants.Add(5)
        End If
        If QuizOperator.Contestant6_CheckBox.Checked = True Then
            ContestantNames.Add(6, QuizOperator.Contestant6name_TextBox.Text)
            AliveContestants.Add(6)
        End If
        If QuizOperator.Contestant7_CheckBox.Checked = True Then
            ContestantNames.Add(7, QuizOperator.Contestant7name_TextBox.Text)
            AliveContestants.Add(7)
        End If
        If QuizOperator.Contestant8_CheckBox.Checked = True Then
            ContestantNames.Add(8, QuizOperator.Contestant8name_TextBox.Text)
            AliveContestants.Add(8)
        End If

        If Contestant.CurrentRound >= 8 Then
            AliveContestants.Clear()
            AliveContestants.Add(1)
            AliveContestants.Add(2)
        End If

        Return ContestantNames

    End Function

    Function SortedListOfContestantsAlphabeticly() As Integer

        Dim ContestantNames As SortedDictionary(Of Integer, String) = MakeListOfContestantsNames()

        Dim sorted = From pair In ContestantNames Order By pair.Value
        Dim sortedDictionary = sorted.ToDictionary(Function(p) p.Key, Function(p) p.Value)

        ''IN PRODUCTION ''codeproject.com/Articles/37039/Sorting-Hashtable
        ''stackoverflow.com/questions/11421515/vb-net-order-a-dictionaryof-string-integer-by-value-of-the-integer

        Return sortedDictionary.First().Key()

    End Function

    Public Sub FirstAndFinalRoundStarts()
        If CurrentRound = 1 Then
            CurrentContestant = SortedListOfContestantsAlphabeticly()
            QuizOperator.CurrentPlayerPosition_TextBox.Text = CurrentContestant
        ElseIf CurrentRound > 1 And CurrentRound < 8 Then

        ElseIf CurrentRound >= 8 Then
            WhoGoesFirst()
            QuizOperator.CurrentPlayerPosition_TextBox.Text = CurrentContestant
            FinalRoundsQuestion()
        End If
        QuizOperator.ShowPlayingContestant()
    End Sub

    Public Sub FinalRoundsQuestion()

        Dim Cont1Corrects As Integer = Int(QuizOperator.FinalContestant1correct_TextBox.Text)
        Dim Cont2Corrects As Integer = Int(QuizOperator.FinalContestant2correct_TextBox.Text)

        Dim Cont1Name As String = QuizOperator.FinalContestant1name_Textbox.Text
        Dim Cont2Name As String = QuizOperator.FinalContestant2name_Textbox.Text

        Dim Cont1Incorrects As Integer = Int(QuizOperator.FinalContestant1incorrect_TextBox.Text)
        Dim Cont2Incorrects As Integer = Int(QuizOperator.FinalContestant2incorrect_TextBox.Text)

        Dim Lista As New List(Of Integer)

        Lista.Add(Cont1Corrects)
        Lista.Add(Cont2Corrects)
        Lista.Add(Cont1Incorrects)
        Lista.Add(Cont2Incorrects)

        Dim LeftQuestions1 As Integer = 0
        Dim LeftQuestions2 As Integer = 0
        LeftQuestions1 = Cont1Corrects + Cont1Incorrects
        LeftQuestions2 = Cont2Corrects + Cont2Incorrects

        Dim Lista1 As New List(Of Integer)
        Lista1.Add(LeftQuestions1)
        Lista1.Add(LeftQuestions2)

        If CurrentRound = 8 Then
            QuizOperator.FinalActiveQuestionNumber_Textbox.Text = Lista1.Min + 1
        End If
        If QuizOperator.FinalActiveQuestionNumber_Textbox.Text > 5 And CurrentRound = 8 Then
            QuizOperator.FinalActiveQuestionNumber_Textbox.Text = 1

        End If
    End Sub

    Public Sub WhoGoesFirst()

        If CurrentRound = 8 Then
            If QuizOperator.First1_RadioButton.Checked = True Then
                Dim val As String = QuizOperator.FinalContestant1name_Textbox.Text
                QuizOperator.FinalContestant1name_Textbox.Text = QuizOperator.FinalContestant2name_Textbox.Text
                QuizOperator.FinalContestant2name_Textbox.Text = val
                MakeListOfContestantsNames()
            End If
            If QuizOperator.First2_RadioButton.Checked = True Then
                Dim val As String = QuizOperator.FinalContestant2name_Textbox.Text
                QuizOperator.FinalContestant2name_Textbox.Text = QuizOperator.FinalContestant1name_Textbox.Text
                QuizOperator.FinalContestant1name_Textbox.Text = val
                MakeListOfContestantsNames().Reverse
            End If
            CurrentContestant = AliveContestants.Item(0)
        ElseIf CurrentRound = 9 Then
            CurrentContestant = AliveContestants.Item(0)
        End If

    End Sub

    Friend Function MakeListOfContestantsStatistics() As SortedDictionary(Of Integer, String)
        Dim ContestantPositionVerdict As New SortedDictionary(Of Integer, String)
        AliveContestants.Clear()

        If QuizOperator.Contestant1_CheckBox.Checked = True Then
            ContestantPositionVerdict.Add(1, QuizOperator.Contestant1verdict_TextBox.Text)
            AliveContestants.Add(1)
        End If
        If QuizOperator.Contestant2_CheckBox.Checked = True Then
            ContestantPositionVerdict.Add(2, QuizOperator.Contestant2verdict_TextBox.Text)
            AliveContestants.Add(2)
        End If
        If QuizOperator.Contestant3_CheckBox.Checked = True Then
            ContestantPositionVerdict.Add(3, QuizOperator.Contestant3verdict_TextBox.Text)
            AliveContestants.Add(3)
        End If
        If QuizOperator.Contestant4_CheckBox.Checked = True Then
            ContestantPositionVerdict.Add(4, QuizOperator.Contestant4verdict_TextBox.Text)
            AliveContestants.Add(4)
        End If
        If QuizOperator.Contestant5_CheckBox.Checked = True Then
            ContestantPositionVerdict.Add(5, QuizOperator.Contestant5verdict_TextBox.Text)
            AliveContestants.Add(5)
        End If
        If QuizOperator.Contestant6_CheckBox.Checked = True Then
            ContestantPositionVerdict.Add(6, QuizOperator.Contestant6verdict_TextBox.Text)
            AliveContestants.Add(6)
        End If
        If QuizOperator.Contestant7_CheckBox.Checked = True Then
            ContestantPositionVerdict.Add(7, QuizOperator.Contestant7verdict_TextBox.Text)
            AliveContestants.Add(7)
        End If
        If QuizOperator.Contestant8_CheckBox.Checked = True Then
            ContestantPositionVerdict.Add(8, QuizOperator.Contestant8verdict_TextBox.Text)
            AliveContestants.Add(8)
        End If

        'Dim ContestantPositionFinalVerdict As New SortedDictionary(Of Integer, String)

        'ContestantPositionFinalVerdict.Add(1, ContestantPositionVerdict.First.Value)
        'ContestantPositionFinalVerdict.Add(2, ContestantPositionVerdict.Last.Value)

        Return ContestantPositionVerdict

    End Function

    Public Sub testContestant()  '' 'TEST 

        'UPDATE gamequestions SET TimesAnswered=0 WHERE TimesAnswered!=0
        'MessageBox.Show(GetBankPoints)

    End Sub

End Class
