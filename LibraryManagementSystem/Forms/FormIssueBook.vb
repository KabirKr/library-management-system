Public Class FormIssueBook

    ' This var holds the id of a book which is selected in data grid view
    Dim selectedIssueId As Integer = 0

    Private Sub FormBookIssue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDataGridView()
    End Sub

    Private Sub LoadDataGridView()
        Dim query As String = "SELECT [IssueId], [bookId], [BookName], [memberId], [MemberName], [IssueDate] FROM [vw_BookIssuedRecord] ORDER BY [IssueDate] DESC"

        Dim dataSet = GetDataset(query)
        BooksIssueDataGridView.DataSource = dataSet.Tables(0)

        BooksIssueDataGridView.Columns(1).HeaderText = "Book ID"
        BooksIssueDataGridView.Columns(2).HeaderText = "Book Name"
        BooksIssueDataGridView.Columns(3).HeaderText = "Member ID"
        BooksIssueDataGridView.Columns(4).HeaderText = "Member Name"
        BooksIssueDataGridView.Columns(5).HeaderText = "Issue Date"

        ' Hide IssueId column
        BooksIssueDataGridView.Columns(0).Visible = False
    End Sub

    Private Sub BooksIssueDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles BooksIssueDataGridView.DoubleClick
        Dim rowIndex As Integer = BooksIssueDataGridView.CurrentRow.Index

        TextBoxBookId.Text = BooksIssueDataGridView.Item(1, rowIndex).Value
        TextBoxMemberId.Text = BooksIssueDataGridView.Item(3, rowIndex).Value
        PickerIssueDate.Value = BooksIssueDataGridView.Item(5, rowIndex).Value

        selectedIssueId = BooksIssueDataGridView.Item(0, rowIndex).Value
    End Sub

    Private Function ValidateInput(memberId As String, bookId As String) As Boolean
        If memberId = "" Then
            MsgBox("Member ID is required", MsgBoxStyle.Critical)
            Return False
        ElseIf bookId = "" Then
            MsgBox("Book ID is required", MsgBoxStyle.Critical)
            Return False
        End If

        ' Check Database for atleast one book and member with given inputs
        ' If the given book and member exists in db allow to issue that book
        Dim bookQuery As String = "SELECT TOP (1) [BookId] FROM [Books] WHERE [BookId] = '" & bookId & "'"
        Dim memberQuery As String = "SELECT TOP (1) [MemberId] FROM [Members] WHERE [MemberId] = '" & memberId & "'"
        Dim bookDataSet As DataSet = GetDataset(bookQuery)
        Dim memberDataSet As DataSet = GetDataset(memberQuery)

        If bookDataSet.Tables(0).Rows.Count <= 0 Then
            MsgBox("Book with id " & bookId & " does not exist. Please enter a valid Book ID", "Book Issue")
            Return False
        ElseIf memberDataSet.Tables(0).Rows.Count <= 0 Then
            MsgBox("Member with id " & memberId & " does not exist. Please enter a valid Member ID", "Book Issue")
            Return False
        End If
        Return True
    End Function

    Private Sub ClearInputs()
        TextBoxBookId.Clear()
        TextBoxMemberId.Clear()
        PickerIssueDate.ResetText()
        selectedIssueId = 0
    End Sub


    Private Sub BtnIssue_Click(sender As Object, e As EventArgs) Handles BtnIssue.Click
        Dim bookID As String = TextBoxBookId.Text.Trim()
        Dim memberID As String = TextBoxMemberId.Text.Trim()
        Dim issueDate As String = PickerIssueDate.Value

        If ValidateInput(memberID, bookID) Then
            Dim query As String = "INSERT INTO Issues VALUES ('" & bookID & "','" & memberID & "','" & CurrentUserId & "','" & issueDate & "', NULL)"

            If ExecuteQuery(query) > 0 Then
                MsgBox("Book issued successfully", MsgBoxStyle.Information, "Book Issue")
                ClearInputs()
                LoadDataGridView()
            Else
                MsgBox("Error: Failed to Issue book", MsgBoxStyle.Critical, "Book Issue")
            End If
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim bookId As String = TextBoxBookId.Text.Trim()
        Dim memberId As String = TextBoxMemberId.Text.Trim()
        Dim issueDate As String = PickerIssueDate.Value

        If selectedIssueId = 0 Then
            MsgBox("Zero record selected. To select a record double click in a row inside data table", MsgBoxStyle.Information, "Book Issue")
            Exit Sub
        End If

        If ValidateInput(memberId, bookId) Then
            Dim query As String = "UPDATE Issues SET BookId='" & bookId & "',MemberId='" & memberId & "',IssueDate='" & issueDate & "' WHERE IssueId='" & selectedIssueId & "'"

            If ExecuteQuery(query) > 0 Then
                MsgBox("Record updated successfully", MsgBoxStyle.Information, "Book Issue")
                ClearInputs()
                LoadDataGridView()
            Else
                MsgBox("Error: Failed to Update Record", MsgBoxStyle.Critical, "Book Issue")
            End If
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If selectedIssueId = 0 Then
            MsgBox("Zero record selected. To select a record double click in a row inside data table", MsgBoxStyle.Information, "Book Issue")
            Exit Sub
        End If

        Dim query As String = "DELETE FROM [Issues] WHERE IssueId='" & selectedIssueId & "'"

        If ExecuteQuery(query) > 0 Then
            MsgBox("Record Deleted successfully", MsgBoxStyle.Information, "Book Issue")
            ClearInputs()
            LoadDataGridView()
        Else
            MsgBox("Error: Failed to delete record", MsgBoxStyle.Critical, "Book Issue")
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        ClearInputs()
    End Sub

    ' Close the application on closing the form
    Private Sub FormBookIssue_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub ReceiveBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceiveBookToolStripMenuItem.Click
        FormReturnBook.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMembers_Click(sender As Object, e As EventArgs) Handles ToolStripMembers.Click
        FormMembers.Show()
        Me.Hide()
    End Sub
End Class