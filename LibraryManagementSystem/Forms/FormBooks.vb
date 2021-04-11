Public Class FormBooks

    Private Sub Books_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub FormBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryManagementDataSet.Books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.LibraryManagementDataSet.Books)

    End Sub

    Private Sub ToolStripHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripHome.Click
        FormHome.Show()
        Me.Hide()
    End Sub
End Class