Public Interface IGameDatalayer
    Sub GetActiveContestants()
    Sub GetContestantsData(Position As Integer)
    Sub GetPreSetQuestion(RoundNumber As Integer, Contestant As Integer)
    Sub MarkPreSetQuestionOpened()
    Sub MarkQuestionAnswered()
    Sub RemoveOldQuestion()
    Sub SetContestantsData(Position As Integer, Name As String)
    Sub UpdateContestantsData(Position As Integer, Name As String, Correct As Integer, Incorrect As Integer, Banks As Integer, Points As Decimal)
    Sub UpdateContestantStatistics(Position As Integer)
End Interface
