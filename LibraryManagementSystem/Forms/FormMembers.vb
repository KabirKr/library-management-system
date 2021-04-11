Public Class FormMembers

    Private Sub FormMembers_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub FormMembers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryManagementDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.LibraryManagementDataSet.Members)

    End Sub

   
    Private Sub ToolStripHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripHome.Click
        FormHome.Show()
        Me.Hide()
    End Sub
End Class