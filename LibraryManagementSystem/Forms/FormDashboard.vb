Public Class FormDashboard
    Private Sub BtnBooks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBooks.Click
        FormBooks.Show()
        Me.Hide()
    End Sub

    Private Sub BtnMembers_Click(sender As Object, e As EventArgs) Handles BtnMembers.Click
        FormMembers.Show()
        Me.Hide()
    End Sub

    Private Sub BtnIssueBook_Click(sender As Object, e As EventArgs) Handles BtnIssueBook.Click
        FormIssueBook.Show()
        Me.Hide()
    End Sub

    Private Sub BtnReceiveBook_Click(sender As Object, e As EventArgs) Handles BtnReceiveBook.Click
        FormReturnBook.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        CurrentUserId = 0
        CurrentUserName = ""
        Me.Hide()
        FormLogin.Show()
    End Sub

    Private Sub LinkAboutFrom_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkAboutFrom.LinkClicked
        FormAbout.Show()
    End Sub

    Private Sub FormHome_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class