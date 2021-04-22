Public Class FormHome
    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblWelcome.Text = "Welcome " & currentUserName
    End Sub

    Private Sub BtnBooks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBooks.Click
        FormBooks.Show()
        Me.Hide()
    End Sub

    Private Sub BtnMembers_Click(sender As Object, e As EventArgs) Handles BtnMembers.Click
        FormMembers.Show()
        Me.Hide()
    End Sub

    Private Sub BtnIssueBook_Click(sender As Object, e As EventArgs) Handles BtnIssueBook.Click
        FormBookIssue.Show()
        Me.Hide()
    End Sub

    Private Sub FormHome_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub BtnReceiveBook_Click(sender As Object, e As EventArgs) Handles BtnReceiveBook.Click
        FormBookReturn.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        currentUserId = 0
        currentUserName = ""

        FormLogin.Show()
        Me.Hide()
    End Sub
End Class