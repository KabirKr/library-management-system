Imports System.Data.SqlClient

Public Class FormBookReturn

    Dim currentRecordId As Integer = 0

    Private Sub FormBookReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.IssuesTableAdapter.Fill(Me.LibraryManagementDataSet.Issues)
    End Sub


    Private Sub LoadDataGridView()
        Dim query As String = "SELECT * FROM Issues"

        Dim dataSet = New DataSet
        Dim dataAdapter = New SqlDataAdapter(query, conn)
        dataAdapter.Fill(dataSet)

        ReceiveBooksDataGridView.DataSource = dataSet.Tables(0)
    End Sub


    Private Sub ReceiveBooksDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles ReceiveBooksDataGridView.DoubleClick
        Dim rowIndex As Integer = ReceiveBooksDataGridView.CurrentRow.Index

        TextBoxBookId.Text = ReceiveBooksDataGridView.Item(1, rowIndex).Value
        TextBoxMemberId.Text = ReceiveBooksDataGridView.Item(2, rowIndex).Value
        PickerIssueDate.Value = ReceiveBooksDataGridView.Item(3, rowIndex).Value

        ' If Received Date is null then rest it to current date
        If Not IsDBNull(ReceiveBooksDataGridView.Item(4, rowIndex).Value) Then
            PickerReceiveDate.Value = ReceiveBooksDataGridView.Item(4, rowIndex).Value
        Else
            PickerReceiveDate.ResetText()
        End If

        currentRecordId = ReceiveBooksDataGridView.Item(0, rowIndex).Value
    End Sub

    '
    ' Button Event Handlers
    '
    Private Sub BtnReceive_Click(sender As Object, e As EventArgs) Handles BtnReceive.Click

        Dim bookId As String = TextBoxBookId.Text.Trim()
        Dim memberId As String = TextBoxMemberId.Text.Trim()
        Dim issueDate As String = PickerIssueDate.Value()
        Dim returnDate As String = PickerReceiveDate.Value()

        If bookId = "" Then
            MsgBox("Book id is required", MsgBoxStyle.Critical)
            Exit Sub

        ElseIf memberId = "" Then
            MsgBox("Member id is required", MsgBoxStyle.Critical)
            Exit Sub
        End If


        ' Find a book by its bookId, memberId and IssueDate
        '   If it doesn't return a book, it means the book is not issued yet

        Dim query As String = "SELECT IssueId From Issues WHERE BookId='" & bookId & "' AND MemberId='" & memberId & "' AND IssueDate='" & issueDate & "'"

        Dim dataSet = SearchData(query)

        ' Book found
        If dataSet.Tables(0).Rows.Count > 0 Then
            Dim issueId As Integer = dataSet.Tables(0).Rows(0).Item("IssueId")

            '' Update receive date for given book
            Dim qry As String = "UPDATE Issues SET ReturnDate='" & returnDate & "' WHERE IssueId='" & issueId & "'"
            If InsertQuery(qry) > 0 Then
                MsgBox("Book received successfully", MsgBoxStyle.Information)
                ClearInputs()
                LoadDataGridView()
            Else
                MsgBox("Error: Failed to Receive Book", MsgBoxStyle.Critical)
            End If

        Else
            ' Given book record is not found
            MsgBox("Book with id: " & bookId & ", member id: " & memberId & ", Date: " & issueDate & " is not found", MsgBoxStyle.Information, "Book Receive")
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim bookId As String = TextBoxBookId.Text.Trim()
        Dim memberId As String = TextBoxMemberId.Text.Trim()
        Dim issueDate As String = PickerIssueDate.Value()
        Dim returnDate As String = PickerReceiveDate.Value()

        If currentRecordId = 0 Then
            MessageBox.Show("Zero record selected. To select a record double click in a row inside data table", "Update Record Error", MessageBoxButtons.OK)

        ElseIf bookId = "" Then
        MsgBox("Book id is required", MsgBoxStyle.Critical)
            Exit Sub

        ElseIf memberId = "" Then
            MsgBox("Member id is required", MsgBoxStyle.Critical)
            Exit Sub

        End If

        Dim query As String = "UPDATE Issues SET BookId='" & bookId & "', MemberId='" & memberId & "', IssueDate='" & issueDate & "',  ReturnDate='" & returnDate & "' WHERE IssueId='" & currentRecordId & "'"
        If InsertQuery(query) > 0 Then
            MsgBox("Record Updated successfully", MsgBoxStyle.Information)
            ClearInputs()
            LoadDataGridView()
        Else
            MsgBox("Error: Failed to Update Record", MsgBoxStyle.Critical)
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
        PickerReceiveDate.ResetText()
        currentRecordId = 0
    End Sub

    Private Sub FormBookReturn_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

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

    Private Sub ToolStripAbout_Click(sender As Object, e As EventArgs) Handles ToolStripAbout.Click
        FormAbout.Show()
        Me.Hide()
    End Sub

    Private Sub IssueBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IssueBooksToolStripMenuItem.Click
        FormBookIssue.Show()
        Me.Hide()
    End Sub
End Class