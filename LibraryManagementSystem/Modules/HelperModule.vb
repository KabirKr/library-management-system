Module HelperModule
    ' Logged in user's id and username
    Public currentUserId As Integer
    Public currentUserName As String

    Private Sub SetUser(userId As Integer, username As String)
        currentUserId = userId
        currentUserName = username
    End Sub
End Module
