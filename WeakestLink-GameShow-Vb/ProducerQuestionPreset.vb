Imports MySql.Data.MySqlClient
Public Class ProducerQuestionPreset
    Dim br_prijatel As Integer
    Dim prv, vtor, nivo As Integer
    'Dim myThread As System.Threading.Thread
    Public Event Raise_flag(ByVal flag As Integer)
    Dim Apub As String
    Dim Bpub As String
    Dim Cpub As String
    Dim Dpub As String
    Dim SKALA As String
    Dim POMINATO As String
    Dim i, j As String

    Public Shared QuestionID As String = ""
    Public Shared CategoryID As String = ""

    Public AscOrDesc As String = "DESC"

    Public Shared gamequestionsConnection As String = "server=" + "127.0.0.1" + ";" _
                   & "uid=" + "root" + ";" _
                   & "pwd=" + "" + ";" _
                   & "database=" + "weakestlink" + ";" _
                   & "Character Set=utf8;"

    Private Sub ProducerQuestionPreset_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Timer1.Interval = 300

    End Sub

    Private Sub Save_BT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save_BT.Click

        Dim MySqlConn As New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;user id=root;database=weakestlink;Character Set=utf8;"
        Dim READER As MySqlDataReader


        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "insert into questionsforcontestants (Round,QuestionID,CategoryID,ContestantID,Question,CorrectAnswer,Pronunciation) values ('" & Level_Box.Text & "','" & QuestionID & "','" & CategoryID & "','" & ContestantNumber_Textbox.Text & "', '" & FindQ_Box.Text & "', '" & FindA_Box.Text & "', '" & Pronunciation_TextBox.Text & "')"
            Dim COMM As MySqlCommand
            COMM = New MySqlCommand(Query, MySqlConn)
            READER = COMM.ExecuteReader

            MessageBox.Show("Прашањето е зачувано!")
            'Pronunciation_TextBox.Text = "Прашањето е зачувано!"

            READER.Close()
            READER.Dispose()

            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()

            ''NON-DATABASE 
            'ContestantNumber_Textbox.Text += 1
            ''NON-DATABASE

            'Pronunciation_TextBox.Text = "Прашањето е зачувано!"
            retrieveGameQuestionsDB()
            retrievePreSetQuestionsDB()

        End Try

        Timer1.Start()



    End Sub

    Private Sub Delete_BT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Find_BT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles QuestionPreview_DataGridView.SelectionChanged
        QuestionID = Me.QuestionPreview_DataGridView.CurrentRow.Cells("ID").Value.ToString
        CategoryID = Me.QuestionPreview_DataGridView.CurrentRow.Cells("CategoryID").Value.ToString

        FindQ_Box.Text = Me.QuestionPreview_DataGridView.CurrentRow.Cells("Question").Value.ToString
        ''''''''''\n''''''''''''
        ''Dim Question_Text As String = FindQ_Box.Text
        ''FindQ_Box.Text = Question_Text.Replace(vbLf, vbCrLf)
        ''''''''''\n''''''''''''
        FindA_Box.Text = Me.QuestionPreview_DataGridView.CurrentRow.Cells("CorrectAnswer").Value.ToString
        'FindB_Box.Text = Me.QuestionPreview_DataGridView.CurrentRow.Cells("Answer2").Value.ToString
        'FindC_Box.Text = Me.QuestionPreview_DataGridView.CurrentRow.Cells("Answer3").Value.ToString
        'FindD_Box.Text = Me.QuestionPreview_DataGridView.CurrentRow.Cells("Answer4").Value.ToString
        'Cor_Box.Text = Me.QuestionPreview_DataGridView.CurrentRow.Cells("CorrectAnswer").Value.ToString
        'MoreInfo_TextBox.Text = Me.QuestionPreview_DataGridView.CurrentRow.Cells("MoreInformation").Value.ToString
        'Pronunciation_TextBox.Text = Me.QuestionPreview_DataGridView.CurrentRow.Cells("Pronunciation").Value.ToString

        ''QuestionIDforInsert_TextBox.Text = QuestionID

    End Sub

    Private Sub TimesAnswered_TextBox_TextChanged(sender As Object, e As EventArgs) Handles TimesAnswered_TextBox.TextChanged
        RetrieveQA_Button_Click(RetrieveQA_Button, Nothing)

    End Sub

    Private Sub BottomQuest_TextBox_TextChanged(sender As Object, e As EventArgs) Handles BottomQuest_TextBox.TextChanged
        RetrieveQA_Button_Click(RetrieveQA_Button, Nothing)

    End Sub

    Private Sub QuestionDifficulty_TextBox_TextChanged(sender As Object, e As EventArgs) Handles QuestionDifficulty_TextBox.TextChanged
        RetrieveQA_Button_Click(RetrieveQA_Button, Nothing)

    End Sub

    Private Sub QuestionCategory_TextBox_TextChanged(sender As Object, e As EventArgs) Handles QuestionCategory_TextBox.TextChanged
        RetrieveQA_Button_Click(RetrieveQA_Button, Nothing)

    End Sub

    Private Sub DateOfCreation_TextBox_TextChanged(sender As Object, e As EventArgs) Handles DateOfCreation_TextBox.TextChanged
        RetrieveQA_Button_Click(RetrieveQA_Button, Nothing)

    End Sub

    Private Sub Level_Box_TextChanged(sender As Object, e As EventArgs) Handles Level_Box.TextChanged
        'If Level_Box.Text > 0 And Level_Box.Text < 6 Then
        '    QuestionDifficulty_TextBox.Text = 1

        'End If
        'If Level_Box.Text > 5 And Level_Box.Text < 11 Then
        '    QuestionDifficulty_TextBox.Text = 2

        'End If
        'If Level_Box.Text > 10 And Level_Box.Text < 16 Then
        '    QuestionDifficulty_TextBox.Text = 3

        'End If
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Level_Box.Text = "15"


    End Sub

    Public Function QuestionSelectionInfo() As String
        Dim TimesAnswered As String
        Dim QuestionCategory As String
        Dim QuestionDifficulty As String
        Dim BottomQuest As String

        Dim FullSql As String = ""

        TimesAnswered = TimesAnswered_TextBox.Text
        QuestionCategory = QuestionCategory_TextBox.Text
        QuestionDifficulty = QuestionDifficulty_TextBox.Text
        BottomQuest = BottomQuest_TextBox.Text

        Dim TimesAnsweredSQL As String = ""
        If TimesAnswered <> "" Then
            TimesAnsweredSQL = " and TimesAnswered=" + TimesAnswered + " "
            FullSql += TimesAnsweredSQL
        End If

        Dim QuestionCategorySQL As String = ""
        If QuestionCategory <> "" Then
            QuestionCategorySQL = " and CategoryID=" + QuestionCategory + " "
            FullSql += QuestionCategorySQL
        End If

        Dim QuestionDifficultySQL As String = ""
        If QuestionDifficulty <> "" Then
            QuestionDifficultySQL = " and Difficulty=" + QuestionDifficulty + " "
            FullSql += QuestionDifficultySQL
        End If

        Dim NotInPreSetSQL As String = ""
        NotInPreSetSQL = " and gamequestions.ID not in " + "(select QuestionID from questionsforcontestants)" + " "
        FullSql += NotInPreSetSQL

        Dim BottomQuestSQL As String = ""
        If BottomQuest <> "" Then
            BottomQuestSQL = " order by ID " + AscOrDesc + " limit " + BottomQuest + " "
            FullSql += BottomQuestSQL
        End If

        Return FullSql

    End Function

    Private Sub DeletePresetQ_Button_Click(sender As Object, e As EventArgs) Handles deletePresetQ_Button.Click
        disposePreSetQuestionDB()

    End Sub

    Public Sub retrieveGameQuestionsDB()

        Dim MySqlConn As MySqlConnection
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = gamequestionsConnection
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "select * from gamequestions where gamequestions.ID IS NOT NULL" + QuestionSelectionInfo()
            Dim COMM As MySqlCommand
            COMM = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = COMM
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            QuestionPreview_DataGridView.DataSource = bSource
            SDA.Update(dbDataSet)

            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try

    End Sub

    Public Sub retrievePreSetQuestionsDB()

        Dim MySqlConn As MySqlConnection
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = gamequestionsConnection
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM questionsforcontestants order by Round asc"
            Dim COMM As MySqlCommand
            COMM = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = COMM
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            PreSetQuest_DataGridView.DataSource = bSource
            SDA.Update(dbDataSet)

            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try

    End Sub

    Public Sub disposePreSetQuestionDB()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection
        Dim cmd As New MySqlCommand
        Dim td As New DataTable

        Try
            conn.ConnectionString = gamequestionsConnection
            conn.Open()
            cmd.CommandText = "delete from " + "questionsforcontestants" + " where Round='" & Level_Box.Text & "'" + " and ContestantID='" & ContestantNumber_Textbox.Text & "'"
            cmd.Connection = conn
            cmd.ExecuteNonQuery()

            conn.Close()
            conn.Dispose()

        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)

            conn.Close()
            conn.Dispose()
        End Try

        retrievePreSetQuestionsDB()

    End Sub

    Private Sub RetrieveQA_Button_Click(sender As Object, e As EventArgs) Handles RetrieveQA_Button.Click
        retrieveGameQuestionsDB()
        retrievePreSetQuestionsDB()

    End Sub

    Private Sub ContestantNumber_Textbox_TextChanged(sender As Object, e As EventArgs) Handles ContestantNumber_Textbox.TextChanged

        If ContestantNumber_Textbox.Text = 9 Then
            ContestantNumber_Textbox.Text = 1
        End If

    End Sub

    Private Sub NextCont_Button_Click(sender As Object, e As EventArgs) Handles NextCont_Button.Click
        ContestantNumber_Textbox.Text += 1

        If ContestantNumber_Textbox.Text = 9 Then
            ContestantNumber_Textbox.Text = 1
        End If
    End Sub

    Private Sub LastOrFirstSelect_Label_Click(sender As Object, e As EventArgs) Handles LastOrFirstSelect_Label.Click
        If AscOrDesc = "ASC" Then
            AscOrDesc = "DESC"
            LastOrFirstSelect_Label.Text = "Последни"
        Else
            AscOrDesc = "ASC"
            LastOrFirstSelect_Label.Text = "Први"
        End If
        retrieveGameQuestionsDB()
    End Sub

    Private Sub LevelUP_Button_Click(sender As Object, e As EventArgs) Handles LevelUP_Button.Click
        Level_Box.Text += 1

        If Level_Box.Text = 9 Then
            Level_Box.Text = 1
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'FindQ_Box.Text = ""
        'FindA_Box.Text = ""
        'Pronunciation_TextBox.Text = ""

        Timer1.Stop()
        Timer1.InitializeLifetimeService()

    End Sub

    Private Sub FindQ_Box_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindQ_Box.TextChanged

    End Sub
End Class
