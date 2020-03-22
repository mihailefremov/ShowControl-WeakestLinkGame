Public Class MoneyTree
    Public MoneyTree As New List(Of Integer)
    Public MoneyTreePoints As New List(Of Integer)
    Public Bank As Decimal
    Public CorrectGivenAnswers As Integer = 0
    Public ChainOfAnswers As Integer = 0
    Public Shared ChainOfCorrectAnswers As New List(Of Integer)
    Public MAXCorrectAnswers As Integer = 8
    Public TotalBank As Decimal

    Sub New()
        MoneyTree.Add(500)
        MoneyTree.Add(1000)
        MoneyTree.Add(2000)
        MoneyTree.Add(5000)
        MoneyTree.Add(10000)
        MoneyTree.Add(15000)
        MoneyTree.Add(20000)
        MoneyTree.Add(50000)

        MoneyTreePoints.Add(10)
        MoneyTreePoints.Add(12)
        MoneyTreePoints.Add(14)
        MoneyTreePoints.Add(16)
        MoneyTreePoints.Add(18)
        MoneyTreePoints.Add(20)
        MoneyTreePoints.Add(22)
        MoneyTreePoints.Add(24)

        ''https://stackoverflow.com/questions/1587778/add-comma-thousand-separator-to-decimal-net

        Bank = 0
        CorrectGivenAnswers = 0

    End Sub

    Public Sub CorrectGivenAnswerDecrease()
        CorrectGivenAnswers -= 1
        MoneyTreeColoring()

    End Sub

    Public Sub CorrectGivenAnswerIncrease()
        CorrectGivenAnswers += 1
        ChainOfAnswers += 1
        If CorrectGivenAnswers > MAXCorrectAnswers Then
            CorrectGivenAnswers = MAXCorrectAnswers
        End If
        MoneyTreeColoring()

    End Sub

    Public Sub CorrectGivenAnswerReset()

        ChainOfCorrectAnswers.Add(ChainOfAnswers)
        CorrectGivenAnswers = 0

        MoneyTreeColoring()

    End Sub

    Public Sub CorrectAnswerMoneyTree()
        CorrectGivenAnswerIncrease()

    End Sub

    Public Sub IncorrectAnswerMoneyTree()
        CorrectGivenAnswerReset()

    End Sub

    Public Sub CurrentBankMoneyTree()

        If CorrectGivenAnswers > 0 Then
            Bank += MoneyTree.ElementAt(CorrectGivenAnswers - 1)
        End If
        QuizOperator.CurrentBank_Textbox.Text = Bank
        'QuizOperator.CG.UpdateCurrentBank(Bank)

        If BankGoalCheck() = True Then
            QuizOperator.Clock.ClockFinishedEvent()
            QuizOperator.CurrentBank_Textbox.Text = Bank
            QuizOperator.Clock.BankGoalSound()
            QuizOperator.CG.MoneyTreeMove(-1)
            Exit Sub
        End If

        CorrectGivenAnswerReset()

    End Sub

    Function BankGoalCheck() As Boolean
        Dim Check As Boolean
        Check = False

        If Val(Bank) >= MoneyTree.Last Then
            Bank = MoneyTree.Last
            Check = True
        End If

        Return Check
    End Function

    Public Sub TotalBankMoneyTree()
        If QuizOperator.CurrentRound_Textbox.Text >= 1 And QuizOperator.CurrentRound_Textbox.Text < 7 Then
            TotalBank += Bank
        ElseIf QuizOperator.CurrentRound_Textbox.Text = 7 Then
            TotalBank += 3 * Bank
        End If
        QuizOperator.TotalBank_TextBox.Text = TotalBank

    End Sub

    Public Sub ResetTreeNextRound()
        CorrectGivenAnswerReset()
        ChainOfCorrectAnswers.Clear()
        ChainOfAnswers = 0
        Bank = 0
        QuizOperator.CurrentBank_Textbox.Text = Bank
        QuizOperator.CG.MoneyTreeMove(-1)

    End Sub

    Public Sub FullResetTree()
        ResetTreeNextRound()
        TotalBank = 0

    End Sub

    Function GetCorrectAnswerPoints() As Decimal
        Dim CorrectPoints As Decimal = 0

        If CorrectGivenAnswers > 0 Then
            CorrectPoints = MoneyTreePoints.ElementAt(CorrectGivenAnswers - 1) / 4
        End If

        Return CorrectPoints

    End Function

    Function GetIncorrectAnswerPoints() As Decimal
        Dim IncorrectPoints As Decimal = 0

        If CorrectGivenAnswers >= 0 And CorrectGivenAnswers <= MAXCorrectAnswers Then
            If CorrectGivenAnswers = MAXCorrectAnswers Then
                QuizOperator.CurrentPrize_TextBox.Text = (MoneyTreePoints.Last() / 2) * (-1)
            Else
                IncorrectPoints = (MoneyTreePoints.ElementAt(CorrectGivenAnswers) / 2) * (-1)
            End If
        End If

        Return IncorrectPoints

    End Function

    Function GetBankPoints() As Decimal
        Dim BankPoints As Decimal = 0

        If CorrectGivenAnswers > 0 Then
            BankPoints = MoneyTreePoints.ElementAt(CorrectGivenAnswers - 1) / 5
        End If

        Return BankPoints

    End Function

    Public Function GetChainOfCorrectAnswers() As Integer

        Return ChainOfCorrectAnswers.Max

    End Function

    Public Sub MoneyTreeColoring()

        Dim RadioButton As String = "Sum" + (CorrectGivenAnswers + 1).ToString + "_RadioButton"

        QuizOperator.CG.MoneyTreeMove(CorrectGivenAnswers)

        If CorrectGivenAnswers >= 0 And CorrectGivenAnswers <= MAXCorrectAnswers Then
            If CorrectGivenAnswers = MAXCorrectAnswers Then
                QuizOperator.CurrentPrize_TextBox.Text = MoneyTree.Item(CorrectGivenAnswers - 1)
            Else
                QuizOperator.CurrentPrize_TextBox.Text = MoneyTree.Item(CorrectGivenAnswers)
            End If
        End If

        'For i As Integer = 1 To 8
        For Each rb As RadioButton In QuizOperator.GroupBox2.Controls.OfType(Of RadioButton)()
            If String.Compare(RadioButton, rb.Name, True) = 0 Then 'False to check case
                rb.Checked = True
            Else

            End If
        Next
        'Next

    End Sub

    Public Sub testMoneyTree()  '''TEST ''''TEST
        'CorrectAnswerMoneyTree()
        'CorrectAnswerMoneyTree()

        'CurrentBankMoneyTree()
        'UPDATE `gamequestions` Set `TimesAnswered`=0 WHERE 1

    End Sub

End Class
