Public Class FormAbout
    '
    ' Tool Strip Events
    '
    Private Sub ToolStripHome_Click(sender As Object, e As EventArgs) Handles ToolStripHome.Click
        FormHome.Show()
        Me.Hide()
    End Sub

    Private Sub ManageBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageBooksToolStripMenuItem.Click
        FormBooks.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMembers_Click(sender As Object, e As EventArgs) Handles ToolStripMembers.Click
        FormMembers.Show()
        Me.Hide()
    End Sub

    Private Sub IssueBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IssueBooksToolStripMenuItem.Click
        FormBookIssue.Show()
        Me.Hide()
    End Sub

    Private Sub ReceiveBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceiveBookToolStripMenuItem.Click
        FormBookReturn.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripLogout_Click(sender As Object, e As EventArgs) Handles ToolStripLogout.Click
        currentUserId = 0
        currentUserName = ""

        FormLogin.Show()
        Me.Hide()
    End Sub
End Class