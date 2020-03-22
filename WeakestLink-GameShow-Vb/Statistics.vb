Public Class Statistics

    Public Shared WeakestLinkPosition As Integer
    Public Shared StrongestLinkPosition As Integer

    'Public Shared StrongestPreviousRound As List(Of Integer)

    Sub New()
        WeakestLinkPosition = 0
        StrongestLinkPosition = 0

    End Sub

    Public Sub FillCorectStatistics(ByVal Position As Integer, ByVal Points As Decimal)

        If Contestant.CurrentRound >= 1 And Contestant.CurrentRound <= 7 Then
            If Position = 1 Then
                QuizOperator.Contestant1correct_TextBox.Text += 1
                QuizOperator.Contestant1points_TextBox.Text += Points
            End If
            If Position = 2 Then
                QuizOperator.Contestant2correct_TextBox.Text += 1
                QuizOperator.Contestant2points_TextBox.Text += Points
            End If
            If Position = 3 Then
                QuizOperator.Contestant3correct_TextBox.Text += 1
                QuizOperator.Contestant3points_TextBox.Text += Points
            End If
            If Position = 4 Then
                QuizOperator.Contestant4correct_TextBox.Text += 1
                QuizOperator.Contestant4points_TextBox.Text += Points
            End If
            If Position = 5 Then
                QuizOperator.Contestant5correct_TextBox.Text += 1
                QuizOperator.Contestant5points_TextBox.Text += Points
            End If
            If Position = 6 Then
                QuizOperator.Contestant6correct_TextBox.Text += 1
                QuizOperator.Contestant6points_TextBox.Text += Points
            End If
            If Position = 7 Then
                QuizOperator.Contestant7correct_TextBox.Text += 1
                QuizOperator.Contestant7points_TextBox.Text += Points
            End If
            If Position = 8 Then
                QuizOperator.Contestant8correct_TextBox.Text += 1
                QuizOperator.Contestant8points_TextBox.Text += Points
            End If
        End If
        If Contestant.CurrentRound >= 8 Then
            If Position = 1 Then
                QuizOperator.FinalContestant1correct_TextBox.Text += 1
            End If
            If Position = 2 Then
                QuizOperator.FinalContestant2correct_TextBox.Text += 1
            End If
        End If
    End Sub

    Public Sub FillIncorectStatistics(ByVal Position As Integer, ByVal Points As Decimal)
        If Contestant.CurrentRound >= 1 And Contestant.CurrentRound <= 7 Then
            If Position = 1 Then
                QuizOperator.Contestant1incorrect_TextBox.Text += 1
                QuizOperator.Contestant1points_TextBox.Text += Points
            End If
            If Position = 2 Then
                QuizOperator.Contestant2incorrect_TextBox.Text += 1
                QuizOperator.Contestant2points_TextBox.Text += Points
            End If
            If Position = 3 Then
                QuizOperator.Contestant3incorrect_TextBox.Text += 1
                QuizOperator.Contestant3points_TextBox.Text += Points
            End If
            If Position = 4 Then
                QuizOperator.Contestant4incorrect_TextBox.Text += 1
                QuizOperator.Contestant4points_TextBox.Text += Points
            End If
            If Position = 5 Then
                QuizOperator.Contestant5incorrect_TextBox.Text += 1
                QuizOperator.Contestant5points_TextBox.Text += Points
            End If
            If Position = 6 Then
                QuizOperator.Contestant6incorrect_TextBox.Text += 1
                QuizOperator.Contestant6points_TextBox.Text += Points
            End If
            If Position = 7 Then
                QuizOperator.Contestant7incorrect_TextBox.Text += 1
                QuizOperator.Contestant7points_TextBox.Text += Points
            End If
            If Position = 8 Then
                QuizOperator.Contestant8incorrect_TextBox.Text += 1
                QuizOperator.Contestant8points_TextBox.Text += Points
            End If
        End If
        If Contestant.CurrentRound >= 8 Then
            If Position = 1 Then
                QuizOperator.FinalContestant1incorrect_TextBox.Text += 1
            End If
            If Position = 2 Then
                QuizOperator.FinalContestant2incorrect_TextBox.Text += 1
            End If
        End If
    End Sub

    Public Sub FillBankStatistics(ByVal Position As Integer, ByVal Points As Decimal)

        If Position = 1 Then
            QuizOperator.Contestant1bank_TextBox.Text += 1
            QuizOperator.Contestant1points_TextBox.Text += Points
        End If
        If Position = 2 Then
            QuizOperator.Contestant2bank_TextBox.Text += 1
            QuizOperator.Contestant2points_TextBox.Text += Points
        End If
        If Position = 3 Then
            QuizOperator.Contestant3bank_TextBox.Text += 1
            QuizOperator.Contestant3points_TextBox.Text += Points
        End If
        If Position = 4 Then
            QuizOperator.Contestant4bank_TextBox.Text += 1
            QuizOperator.Contestant4points_TextBox.Text += Points
        End If
        If Position = 5 Then
            QuizOperator.Contestant5bank_TextBox.Text += 1
            QuizOperator.Contestant5points_TextBox.Text += Points
        End If
        If Position = 6 Then
            QuizOperator.Contestant6bank_TextBox.Text += 1
            QuizOperator.Contestant6points_TextBox.Text += Points
        End If
        If Position = 7 Then
            QuizOperator.Contestant7bank_TextBox.Text += 1
            QuizOperator.Contestant7points_TextBox.Text += Points
        End If
        If Position = 8 Then
            QuizOperator.Contestant8bank_TextBox.Text += 1
            QuizOperator.Contestant8points_TextBox.Text += Points
        End If

    End Sub

    Function MakeListOfContestantsScores() As SortedDictionary(Of Integer, Decimal)

        Dim ContestantScores As New SortedDictionary(Of Integer, Decimal)

        If QuizOperator.Contestant1_CheckBox.Checked = True Then
            ContestantScores.Add(1, QuizOperator.Contestant1points_TextBox.Text)
        End If
        If QuizOperator.Contestant2_CheckBox.Checked = True Then
            ContestantScores.Add(2, QuizOperator.Contestant2points_TextBox.Text)
        End If
        If QuizOperator.Contestant3_CheckBox.Checked = True Then
            ContestantScores.Add(3, QuizOperator.Contestant3points_TextBox.Text)
        End If
        If QuizOperator.Contestant4_CheckBox.Checked = True Then
            ContestantScores.Add(4, QuizOperator.Contestant4points_TextBox.Text)
        End If
        If QuizOperator.Contestant5_CheckBox.Checked = True Then
            ContestantScores.Add(5, QuizOperator.Contestant5points_TextBox.Text)
        End If
        If QuizOperator.Contestant6_CheckBox.Checked = True Then
            ContestantScores.Add(6, QuizOperator.Contestant6points_TextBox.Text)
        End If
        If QuizOperator.Contestant7_CheckBox.Checked = True Then
            ContestantScores.Add(7, QuizOperator.Contestant7points_TextBox.Text)
        End If
        If QuizOperator.Contestant8_CheckBox.Checked = True Then
            ContestantScores.Add(8, QuizOperator.Contestant8points_TextBox.Text)
        End If

        Return ContestantScores

    End Function

    Public Sub WeakStrongLink_PositionsVerdict()
        Dim ContestantScores As SortedDictionary(Of Integer, Decimal) = MakeListOfContestantsScores()

        Dim sorted = From pair In ContestantScores Order By pair.Value
        Dim sortedDictionary = sorted.ToDictionary(Function(p) p.Key, Function(p) p.Value)

        WeakestLinkPosition = sortedDictionary.First.Key
        StrongestLinkPosition = sortedDictionary.Last.Key

        Dim sortedDictLength As Integer = sortedDictionary.Count

        'StrongestPreviousRound.Clear()
        'StrongestPreviousRound.Add(sortedDictionary.Last.Key)
        'StrongestPreviousRound.Add(sortedDictionary.Keys.ElementAt(sortedDictLength - 2))

    End Sub

    Public Sub MarkWeakStrongLinkInTable()

        WeakStrongLink_PositionsVerdict()

        Dim WeakTextBox As String = "Contestant" + WeakestLinkPosition.ToString + "verdict_TextBox"
        Dim StrongTextBox As String = "Contestant" + StrongestLinkPosition.ToString + "verdict_Textbox"

        For Each tb As TextBox In QuizOperator.TabPage1.Controls.OfType(Of TextBox)()
            If String.Compare(WeakTextBox, tb.Name, True) = 0 Then 'False to check case
                'MsgBox("Strings Match")
                tb.Text = "WL"

            ElseIf String.Compare(StrongTextBox, tb.Name, True) = 0 Then 'False to check case
                'MsgBox("Strings Do not Match")
                tb.Text = "SL"
            Else
            End If
        Next

    End Sub

    Public Sub ResetStatisticTable()
        For Each tb As TextBox In QuizOperator.TabPage1.Controls.OfType(Of TextBox)()
            If tb.Name.Contains("verdict") Then 'False to check case
                'MsgBox("Strings Match")
                tb.Text = ""

            ElseIf tb.Name.Contains("correct") Or tb.Name.Contains("incorrect") Or tb.Name.Contains("bank") Or tb.Name.Contains("points") Then 'False to check case
                tb.Text = "0"
            Else

            End If
        Next

    End Sub

    Public Sub PredictWinners(ByVal Contestant As Integer)

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
        LeftQuestions1 = 5 - (Cont1Corrects + Cont1Incorrects)
        LeftQuestions2 = 5 - (Cont2Corrects + Cont2Incorrects)

        Dim Lista1 As New List(Of Integer)
        Lista1.Add(LeftQuestions1)
        Lista1.Add(LeftQuestions2)

        Dim Cont1Prediction As Integer
        Dim Cont2Prediction As Integer

        If Lista1.Min <= 2 Then
            '' answered correctly

            QuizOperator.InfoBox_Textbox.Text = ""

            Cont1Prediction = Cont1Corrects + LeftQuestions1
            Cont2Prediction = Cont2Corrects + LeftQuestions2

            If Contestant = 1 Then
                If Cont1Corrects + 1 > Cont2Corrects + LeftQuestions2 Then
                    QuizOperator.InfoBox_Textbox.Text = Cont1Name + ", if you answer this question correctly, you are the winner"
                End If
            End If
            If Contestant = 2 Then
                If Cont2Corrects + 1 > Cont1Corrects + LeftQuestions1 Then
                    QuizOperator.InfoBox_Textbox.Text = Cont2Name + ", if you answer this question correctly, you are the winner"
                End If
            End If

            '' answered incorrectly
            If Contestant = 1 Then
                If Cont1Corrects + LeftQuestions1 - 1 < Cont2Corrects Then
                    QuizOperator.InfoBox_Textbox.Text = Cont1Name + ", if you answer this question incorrectly " + Cont2Name + " is the winner"
                End If
            End If
            If Contestant = 2 Then
                If Cont1Corrects > Cont2Corrects + LeftQuestions2 - 1 Then
                    QuizOperator.InfoBox_Textbox.Text = Cont2Name + ", if you answer this question incorrectly " + Cont1Name + " is the winner"
                End If
            End If

        End If
    End Sub
End Class
