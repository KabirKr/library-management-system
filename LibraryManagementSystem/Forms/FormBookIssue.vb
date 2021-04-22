Imports System.Data.SqlClient

Public Class FormBookIssue

    Dim currentRecordId As Integer = 0

    Private Sub FormBookIssue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.IssuesTableAdapter.Fill(Me.LibraryManagementDataSet.Issues)
    End Sub


    Private Sub LoadDataGridView()
        Dim query As String = "SELECT * FROM Issues"

        Dim dataSet = New DataSet
        Dim dataAdapter = New SqlDataAdapter(query, conn)
        dataAdapter.Fill(dataSet)

        BooksIssueDataGridView.DataSource = dataSet.Tables(0)
    End Sub

    Private Sub BooksIssueDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles BooksIssueDataGridView.DoubleClick
        Dim rowIndex As Integer = BooksIssueDataGridView.CurrentRow.Index

        TextBoxBookId.Text = BooksIssueDataGridView.Item(1, rowIndex).Value
        TextBoxMemberId.Text = BooksIssueDataGridView.Item(2, rowIndex).Value
        PickerIssueDate.Value = BooksIssueDataGridView.Item(3, rowIndex).Value

        currentRecordId = BooksIssueDataGridView.Item(0, rowIndex).Value
    End Sub

    Private Sub BtnIssue_Click(sender As Object, e As EventArgs) Handles BtnIssue.Click
        Dim bookId As String = TextBoxBookId.Text.Trim()
        Dim memberId As String = TextBoxMemberId.Text.Trim()
        Dim issueDate As String = PickerIssueDate.Value

        If bookId = "" Then
            MsgBox("Book id is required", MsgBoxStyle.Critical)

        ElseIf memberId = "" Then
            MsgBox("Member id is required", MsgBoxStyle.Critical)
        Else
            Dim query As String = "INSERT INTO Issues VALUES ('" & bookId & "','" & memberId & "','" & currentUserId & "','" & issueDate & "', NULL)"

            If InsertQuery(query) > 0 Then
                MsgBox("Book issued successfully", MsgBoxStyle.Information)
                ClearInputs()
                LoadDataGridView()
            Else
                MsgBox("Error: Failed to Issue book", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim bookId As String = TextBoxBookId.Text.Trim()
        Dim memberId As String = TextBoxMemberId.Text.Trim()
        Dim issueDate As String = PickerIssueDate.Value

        If currentRecordId = 0 Then
            MessageBox.Show("Zero record selected. To select a record double click in a row inside data table", "Update Record Error", MessageBoxButtons.OK)

        ElseIf bookId = "" Then
            MsgBox("Book id is required", MsgBoxStyle.Critical)

        ElseIf memberId = "" Then
            MsgBox("Member id is required", MsgBoxStyle.Critical)

        Else
            Dim query As String = "UPDATE Issues SET BookId='" & bookId & "',MemberId='" & memberId & "',IssueDate='" & issueDate & "' WHERE IssueId='" & currentRecordId & "'"

            If InsertQuery(query) > 0 Then
                MsgBox("Record updated successfully", MsgBoxStyle.Information)
                ClearInputs()
                LoadDataGridView()
            Else
                MsgBox("Error: Failed to Update Record", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        If currentRecordId = 0 Then
            MessageBox.Show("Zero record selected. To select a record double click in a row inside data table", "Delete Record Error", MessageBoxButtons.OK)
            Exit Sub
        End If


        Dim query As String = "DELETE FROM Issues WHERE IssueId='" & currentRecordId & "'"

        If InsertQuery(query) > 0 Then
            MsgBox("Record Deleted successfully", MsgBoxStyle.Information)
            ClearInputs()
            LoadDataGridView()
        Else
            MsgBox("Error: Failed to delete record", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        ClearInputs()
    End Sub

    Private Sub ClearInputs()
        TextBoxBookId.Clear()
        TextBoxMemberId.Clear()
        PickerIssueDate.ResetText()
        currentRecordId = 0
    End Sub

    Private Sub FormBookIssue_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub ToolStripHome_Click(sender As Object, e As EventArgs) Handles ToolStripHome.Click
        FormHome.Show()
        Me.Hide()
    End Sub

    Private Sub ManageBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageBooksToolStripMenuItem.Click
        FormBooks.Show()
        Me.Hide()
    End Sub

    Private Sub ReceiveBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceiveBookToolStripMenuItem.Click
        FormBookReturn.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMembers_Click(sender As Object, e As EventArgs) Handles ToolStripMembers.Click
        FormMembers.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripAbout_Click(sender As Object, e As EventArgs) Handles ToolStripAbout.Click
        FormAbout.Show()
    End Sub

    Private Sub ToolStripLogout_Click(sender As Object, e As EventArgs) Handles ToolStripLogout.Click
        currentUserId = 0
        currentUserName = ""

        FormLogin.Show()
        Me.Hide()
    End Sub
End Class