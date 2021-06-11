Public Class FormReturnBook

    Private Sub FormBookReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDataGridView()
    End Sub

    Private Sub LoadDataGridView()
        Dim query As String = "SELECT [IssueId], [BookName], [MemberName], [IssueDate], [ReturnDate] FROM [vw_BookIssuedRecord] ORDER BY [IssueDate] DESC"

        Dim dataSet As DataSet = GetDataset(query)
        ReturnBooksDataGridView.DataSource = dataSet.Tables(0)

        ReturnBooksDataGridView.Columns(0).HeaderText = "Issue Id"
        ReturnBooksDataGridView.Columns(1).HeaderText = "Book Name"
        ReturnBooksDataGridView.Columns(2).HeaderText = "Member Name"
        ReturnBooksDataGridView.Columns(3).HeaderText = "Issue Date"
        ReturnBooksDataGridView.Columns(4).HeaderText = "Return Date"
    End Sub

    Private Sub ReceiveBooksDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles ReturnBooksDataGridView.DoubleClick
        Dim rowIndex As Integer = ReturnBooksDataGridView.CurrentRow.Index

        TextBoxIssueId.Text = ReturnBooksDataGridView.Item(0, rowIndex).Value

        ' If Return Date is null then set return date picker to current date
        If Not IsDBNull(ReturnBooksDataGridView.Item(4, rowIndex).Value) Then
            PickerReturnDate.Value = ReturnBooksDataGridView.Item(4, rowIndex).Value
        Else
            PickerReturnDate.ResetText()
        End If
    End Sub

    Private Sub BtnReceiveBook_Click(sender As Object, e As EventArgs) Handles BtnReceiveBook.Click
        Dim issueId = TextBoxIssueId.Text.Trim()
        Dim returnDate = PickerReturnDate.Value()

        If issueId = "" Then
            MsgBox("Issue ID is required", MsgBoxStyle.Critical, "Book Issue")
            Exit Sub
        End If


        Dim query As String = "SELECT TOP (1) [IssueId] FROM [Issues] WHERE [IssueId] = '" & issueId & "'"
        Dim dataSet As DataSet = GetDataset(query)

        ' Check whether a book with given issue id exist in db
        ' If book exists in db update the return date else show error message
        If dataSet.Tables(0).Rows.Count > 0 Then
            Dim qry = "UPDATE Issues SET ReturnDate='" & returnDate & "' WHERE IssueId='" & issueId & "'"
            If ExecuteQuery(qry) > 0 Then
                MsgBox("Book received successfully", MsgBoxStyle.Information, "Book Return")
                ClearInputs()
                LoadDataGridView()
            Else
                MsgBox("Error: Failed to receive book", MsgBoxStyle.Critical, "Book Issue")
            End If
        Else
            MsgBox("Book with Issue ID: " & issueId & "does not exist. Please enter a valid issue id", MsgBoxStyle.Critical, "Book Return")
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        ClearInputs()
    End Sub

    Private Sub ClearInputs()
        TextBoxIssueId.Clear()
        PickerReturnDate.ResetText()
    End Sub

    Private Sub FormBookReturn_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    ' Tool strip button events
    Private Sub ToolStripHome_Click(sender As Object, e As EventArgs) Handles ToolStripHome.Click
        FormDashboard.Show()
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
        FormIssueBook.Show()
        Me.Hide()
    End Sub
End Class