Imports MySql.Data.MySqlClient

Public Class GameDatabasе
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
        PreSetQuestionString = "SELECT * FROM questionsforcontestants WHERE Answered=0 and Round=" + RoundNumber.ToString + " and (CASE WHEN (SELECT COUNT(*) FROM questionsforcontestants WHERE ContestantID=" + Contestant.ToString + " LIMIT 1) > 0 THEN (ContestantID=" + Contestant.ToString + ")" + " ELSE 1=2 END)"
        ''ako nema prasanje za takmicar od rundata togas najdi bilo koe prasanje od rundata
        ''https://stackoverflow.com/questions/27366107/second-select-query-if-first-select-returns-0-rows

        Dim MySqlConn As MySqlConnection
        MySqlConn = New MySqlConnection With {
            .ConnectionString = gamequestionsConnection
        }
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = PreSetQuestionString
            Dim COMM As MySqlCommand
            COMM = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = COMM
            SDA.Fill(dbDataSet)
            If dbDataSet.Rows.Count > 0 Then
                QuizOperator.CurrentQuestionText_TextBox.Text = dbDataSet.Rows(0)("Question").ToString()
                QuizOperator.CurrentAnswerText_TextBox.Text = dbDataSet.Rows(0)("CorrectAnswer").ToString()
                'QuizOperator.InfoBox_Textbox.Text = dbDataSet.Rows(0)("MoreInformation").ToString()
                'QuizOperator.InfoBox_Textbox.Text = dbDataSet.Rows(0)("Pronunciation").ToString()
                questionID = dbDataSet.Rows(0)("QuestionID").ToString()
            End If

            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try

        MarkPreSetQuestionOpened()

    End Sub

    Public Sub MarkPreSetQuestionOpened() Implements IGameDatalayer.MarkPreSetQuestionOpened
        Dim MySqlConn As MySqlConnection
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = gamequestionsConnection
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "update questionsforcontestants SET Answered = 1 where QuestionID='" & questionID & "'"
            Dim COMM As MySqlCommand
            COMM = New MySqlCommand(Query, MySqlConn)
            READER = COMM.ExecuteReader

            READER.Close()
            READER.Dispose()
            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try

    End Sub

    Public Sub MarkQuestionAnswered() Implements IGameDatalayer.MarkQuestionAnswered
        Dim MySqlConn As MySqlConnection
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = gamequestionsConnection
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "update gamequestions SET TimesAnswered = TimesAnswered + 1 where ID='" & questionID & "'"
            Dim COMM As MySqlCommand
            COMM = New MySqlCommand(Query, MySqlConn)
            READER = COMM.ExecuteReader

            READER.Close()
            READER.Dispose()
            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try

    End Sub

    Public Sub RemoveOldQuestion() Implements IGameDatalayer.RemoveOldQuestion
        QuizOperator.CurrentQuestionText_TextBox.Text = ""
        QuizOperator.CurrentAnswerText_TextBox.Text = ""
        'QuizOperator.InfoBox_Textbox.Text = ""
        'questionID = 0

    End Sub

End Class
