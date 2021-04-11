Public Class FormBookReturn

    Private Sub FormBookReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryManagementDataSet.Issues' table. You can move, or remove it, as needed.
        Me.IssuesTableAdapter.Fill(Me.LibraryManagementDataSet.Issues)

    End Sub

    Private Sub FormBookReturn_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class