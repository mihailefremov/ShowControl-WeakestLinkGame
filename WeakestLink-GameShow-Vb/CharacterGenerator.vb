Imports Svt.Caspar

Public Class CharacterGenerator
    Public caspar_ As New CasparDevice
    Public cgData As New CasparCGDataCollection

    Sub New()

        caspar_.Connect(My.Settings.casparHostName, My.Settings.casparPort)

    End Sub

    Public Sub CasparCGConnect()
        caspar_.Connect(My.Settings.casparHostName, My.Settings.casparPort)
        QuizOperator.CasparConnect_Label.ForeColor = Color.Red
        If caspar_.IsConnected Then
            caspar_.Channels(0).CG.Add(1, My.Settings.moneyTreeFlashTempl, False, cgData)
            caspar_.Channels(0).CG.Play(1)
            QuizOperator.CasparConnect_Label.ForeColor = Color.Green
        End If
    End Sub

    Public Sub MoneyTreeSet()
        If caspar_.IsConnected Then
            cgData.SetData("SumField_1", QuizOperator.MoneyTree.MoneyTree.Item(0).ToString)
            cgData.SetData("SumField_2", QuizOperator.MoneyTree.MoneyTree.Item(1).ToString)
            cgData.SetData("SumField_3", QuizOperator.MoneyTree.MoneyTree.Item(2).ToString)
            cgData.SetData("SumField_4", QuizOperator.MoneyTree.MoneyTree.Item(3).ToString)
            cgData.SetData("SumField_5", QuizOperator.MoneyTree.MoneyTree.Item(4).ToString)
            cgData.SetData("SumField_6", QuizOperator.MoneyTree.MoneyTree.Item(5).ToString)
            cgData.SetData("SumField_7", QuizOperator.MoneyTree.MoneyTree.Item(6).ToString)
            cgData.SetData("SumField_8", QuizOperator.MoneyTree.MoneyTree.Item(7).ToString)
            cgData.SetData("Bank_Text", "БАНКА")
            cgData.SetData("BankSume_Text", QuizOperator.CurrentBank_Textbox.Text)

            caspar_.Channels(0).CG.Add(1, My.Settings.moneyTreeFlashTempl, False, cgData)
            caspar_.Channels(0).CG.Play(1)
        End If

    End Sub

    Public Sub HeadToHeadSet()
        If caspar_.IsConnected Then

            UpdateNamesFinalRound()

            caspar_.Channels(0).CG.Add(2, My.Settings.headToHeadmoneyTreeFlashTempl, False, cgData)
            caspar_.Channels(0).CG.Play(2)
        End If

    End Sub

    Public Sub MoneyTreeReset()
        If caspar_.IsConnected Then
            caspar_.Channels(0).CG.Invoke(1, "ResetTree")
            caspar_.Channels(0).CG.Update(1, cgData)
        End If

    End Sub

    Public Sub MoneyTreeMove(ByVal CorrectAnswers As Integer)
        If caspar_.IsConnected Then
            If CorrectAnswers = -1 Then
                caspar_.Channels(0).CG.Invoke(1, "ResetTree")
            End If
            If CorrectAnswers = 0 Then
                caspar_.Channels(0).CG.Invoke(1, "ResetTree")
                caspar_.Channels(0).CG.Invoke(1, "Sum1_red")
            End If
            If CorrectAnswers = 1 Then
                caspar_.Channels(0).CG.Invoke(1, "Sum2_red")
            End If
            If CorrectAnswers = 2 Then
                caspar_.Channels(0).CG.Invoke(1, "Sum2_Fall")
            End If
            If CorrectAnswers = 3 Then
                caspar_.Channels(0).CG.Invoke(1, "Sum3_Fall")
            End If
            If CorrectAnswers = 4 Then
                caspar_.Channels(0).CG.Invoke(1, "Sum4_Fall")
            End If
            If CorrectAnswers = 5 Then
                caspar_.Channels(0).CG.Invoke(1, "Sum5_Fall")
            End If
            If CorrectAnswers = 6 Then
                caspar_.Channels(0).CG.Invoke(1, "Sum6_Fall")
            End If
            If CorrectAnswers = 7 Then
                caspar_.Channels(0).CG.Invoke(1, "Sum7_Fall")
            End If
            If CorrectAnswers = 8 Or CorrectAnswers > 8 Then
                caspar_.Channels(0).CG.Invoke(1, "Sum8_Fall")
            End If
        End If

    End Sub

    Public Sub UpdateClock(ByVal String1 As String)

        If caspar_.IsConnected Then
            cgData.SetData("Clock_Text", String1)
            caspar_.Channels(0).CG.Update(1, cgData)
        End If

    End Sub

    Public Sub UpdateCurrentBank(ByVal BankSume As Decimal)
        If caspar_.IsConnected Then
            cgData.SetData("BankSume_Text", BankSume.ToString)
            caspar_.Channels(0).CG.Update(1, cgData)
        End If
    End Sub

    Public Sub StartRound(ByVal Round As Integer)
        If caspar_.IsConnected Then
            If Round >= 1 And Round <= 7 Then
                caspar_.Channels(0).CG.Invoke(1, "FadeInMoneyTree")
                caspar_.Channels(0).CG.Invoke(1, "FadeInClock")
            End If

            caspar_.Channels(0).CG.Invoke(1, "Sum1_red")
            caspar_.Channels(0).CG.Update(1, cgData)
        End If
    End Sub

    Public Sub EndClockRound()
        If caspar_.IsConnected Then
            caspar_.Channels(0).CG.Invoke(1, "FadeOutMoneyTree")
            caspar_.Channels(0).CG.Invoke(1, "FadeOutClock")

        End If
    End Sub

    Public Sub FadeInTree()
        If caspar_.IsConnected Then
            caspar_.Channels(0).CG.Invoke(1, "FadeInMoneyTree")
        End If

    End Sub

    Public Sub FadeOutTree()
        If caspar_.IsConnected Then
            caspar_.Channels(0).CG.Invoke(1, "FadeOutMoneyTree")
        End If

    End Sub

    Friend Sub UpdateTotalBank(totalBank As Decimal)
        If caspar_.IsConnected Then
            cgData.SetData("TotalBank_TextField", totalBank.ToString)
            caspar_.Channels(0).CG.Update(1, cgData)
        End If
    End Sub

    Public Sub FadeInTotalBank()
        If caspar_.IsConnected Then
            caspar_.Channels(0).CG.Invoke(1, "FadeInTotalBank")
        End If

    End Sub

    Public Sub FadeOutTotalBank()
        If caspar_.IsConnected Then
            caspar_.Channels(0).CG.Invoke(1, "FadeOutTotalBank")
        End If

    End Sub

    Public Sub HeadToHeadSuddenDeathSet()

    End Sub

    Public Sub UpdateNamesFinalRound()
        If caspar_.IsConnected Then
            cgData.SetData("Cont1name_TextField", QuizOperator.FinalContestant1name_Textbox.Text)
            caspar_.Channels(0).CG.Update(2, cgData)
            cgData.SetData("Cont2name_TextField", QuizOperator.FinalContestant2name_Textbox.Text)
            caspar_.Channels(0).CG.Update(2, cgData)
        End If
    End Sub

    Public Sub OpenQuestionFinalRound(ByVal QuestionNum As Integer, ByVal Contestant As Integer)

        If caspar_.IsConnected Then
            If Contestant = 1 And QuestionNum >= 1 And QuestionNum <= 5 Then
                Dim Method As String = String.Empty
                Method = "Q" + QuestionNum.ToString + "A_Active"

                caspar_.Channels(0).CG.Invoke(2, Method)
            End If

            If Contestant = 2 And QuestionNum >= 1 And QuestionNum <= 5 Then
                Dim Method As String = String.Empty
                Method = "Q" + QuestionNum.ToString + "B_Active"

                caspar_.Channels(0).CG.Invoke(2, Method)
            End If
        End If

    End Sub

    Public Sub CorrectAnswerFinalRound(ByVal QuestionNum As Integer, ByVal Contestant As Integer)

        If caspar_.IsConnected Then
            If Contestant = 1 And QuestionNum >= 1 And QuestionNum <= 5 Then
                Dim Method As String = String.Empty
                Method = "Q" + QuestionNum.ToString + "A_Correct"

                caspar_.Channels(0).CG.Invoke(2, Method)
            End If

            If Contestant = 2 And QuestionNum >= 1 And QuestionNum <= 5 Then
                Dim Method As String = String.Empty
                Method = "Q" + QuestionNum.ToString + "B_Correct"

                caspar_.Channels(0).CG.Invoke(2, Method)
            End If
        End If

    End Sub

    Public Sub IncorrectAnswerFinalRound(ByVal QuestionNum As Integer, ByVal Contestant As Integer)

        If caspar_.IsConnected Then
            If Contestant = 1 And QuestionNum >= 1 And QuestionNum <= 5 Then
                Dim Method As String = String.Empty
                Method = "Q" + QuestionNum.ToString + "A_Wrong"

                caspar_.Channels(0).CG.Invoke(2, Method)
            End If

            If Contestant = 2 And QuestionNum >= 1 And QuestionNum <= 5 Then
                Dim Method As String = String.Empty
                Method = "Q" + QuestionNum.ToString + "B_Wrong"

                caspar_.Channels(0).CG.Invoke(2, Method)
            End If
        End If

    End Sub

    Public Sub ResetHeadToHead()
        If caspar_.IsConnected Then
            For QuestionNum = 1 To 5 Step 1
                Dim Method As String = String.Empty
                Method = "Q" + QuestionNum.ToString + "A_Reset"

                caspar_.Channels(0).CG.Invoke(2, Method)
            Next
            For QuestionNum = 1 To 5 Step 1
                Dim Method As String = String.Empty
                Method = "Q" + QuestionNum.ToString + "B_Reset"

                caspar_.Channels(0).CG.Invoke(2, Method)
            Next
        End If
    End Sub

    Public Sub ResetSuddenDeath()

    End Sub

    Public Sub FadeInHeadToHead()
        If caspar_.IsConnected Then
            caspar_.Channels(0).CG.Invoke(2, "FadeInHeadToHead")
        End If
    End Sub

    Public Sub FadeOutHeadToHead()
        If caspar_.IsConnected Then
            caspar_.Channels(0).CG.Invoke(2, "FadeOutHeadToHead")
        End If
    End Sub

    Public Sub FadeInSuddenDeath()

    End Sub

    Public Sub FadeOutSuddenDeath()

    End Sub

End Class
