Imports MySql.Data.MySqlClient

Public Class MockDatabase
    Implements IGameDatalayer

    Public Shared CurrentRound As Integer
    Public Shared PreSetQuestionString As String = ""
    Public Shared questionID As Long = 0

    Public Shared gamequestionsConnection As String = "server=" + "127.0.0.1" + ";" _
               & "uid=" + "root" + ";" _
               & "pwd=" + "" + ";" _
               & "database=" + "weakestlink" + ";" _
               & "Character Set=utf8;"

    Public Sub SetContestantsData(ByVal Position As Integer, ByVal Name As String) Implements IGameDatalayer.SetContestantsData
    End Sub

    Public Sub UpdateContestantsData(ByVal Position As Integer, ByVal Name As String, ByVal Correct As Integer, ByVal Incorrect As Integer, ByVal Banks As Integer, ByVal Points As Decimal) Implements IGameDatalayer.UpdateContestantsData
    End Sub

    Public Sub GetContestantsData(ByVal Position As Integer) Implements IGameDatalayer.GetContestantsData
    End Sub

    Public Sub UpdateContestantStatistics(ByVal Position As Integer) Implements IGameDatalayer.UpdateContestantStatistics
    End Sub

    Public Sub GetActiveContestants() Implements IGameDatalayer.GetActiveContestants
    End Sub

    Public Sub GetPreSetQuestion(ByVal RoundNumber As Integer, ByVal Contestant As Integer) Implements IGameDatalayer.GetPreSetQuestion
        RemoveOldQuestion()

        QuizOperator.CurrentQuestionText_TextBox.Text = "Question example: " + DateTime.Now().ToLongTimeString
        QuizOperator.CurrentAnswerText_TextBox.Text = "Answer example: " + DateTime.Now().ToLongTimeString
        questionID = "00" + DateTime.Now().ToString("ddMMyyhmmss")

        MarkPreSetQuestionOpened()

    End Sub

    Public Sub MarkPreSetQuestionOpened() Implements IGameDatalayer.MarkPreSetQuestionOpened

    End Sub

    Public Sub MarkQuestionAnswered() Implements IGameDatalayer.MarkQuestionAnswered


    End Sub

    Public Sub RemoveOldQuestion() Implements IGameDatalayer.RemoveOldQuestion
        QuizOperator.CurrentQuestionText_TextBox.Text = ""
        QuizOperator.CurrentAnswerText_TextBox.Text = ""
        'QuizOperator.InfoBox_Textbox.Text = ""
        'questionID = 0

    End Sub

End Class
