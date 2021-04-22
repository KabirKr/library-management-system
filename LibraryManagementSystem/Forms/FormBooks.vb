Imports System.Data.SqlClient

Public Class FormBooks

    Dim currentRecordId As Integer = 0

    Private Sub FormBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BooksTableAdapter.Fill(Me.LibraryManagementDataSet.Books)
    End Sub

    Private Sub BooksDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles BooksDataGridView.DoubleClick
        ' Current row index number in which duble Click is performed
        Dim rowIndex As Integer = BooksDataGridView.CurrentRow.Index

        ' Fill TextBoxes with current row data
        TextBoxName.Text = BooksDataGridView.Item(1, rowIndex).Value
        TextBoxAuthor.Text = BooksDataGridView.Item(2, rowIndex).Value
        TextBoxPublisher.Text = BooksDataGridView.Item(3, rowIndex).Value
        TextBoxQuantity.Text = BooksDataGridView.Item(4, rowIndex).Value
        TextBoxPrice.Text = BooksDataGridView.Item(5, rowIndex).Value

        ' Set current record id
        currentRecordId = BooksDataGridView.Item(0, rowIndex).Value


    End Sub

    '
    ' Data Grid View Loader
    '
    Private Sub LoadDataGridView()
        Dim query As String = "SELECT * FROM Books"

        Dim dataSet = New DataSet
        Dim dataAdapter = New SqlDataAdapter(query, conn)
        dataAdapter.Fill(dataSet)

        BooksDataGridView.DataSource = dataSet.Tables(0)
    End Sub

    Private Sub BtnAddBook_Click(sender As Object, e As EventArgs) Handles BtnAddBook.Click
        '
        ' Input values
        '
        Dim name As String = TextBoxName.Text.Trim()
        Dim author As String = TextBoxAuthor.Text.Trim()
        Dim publisher As String = TextBoxPublisher.Text.Trim()
        Dim price As String = TextBoxPrice.Text.Trim()
        Dim stockQuantity As String = TextBoxQuantity.Text.Trim()

        '
        ' Validation
        '
        If name = "" Then
            MsgBox("Name is required", MsgBoxStyle.Critical)

        ElseIf author = "" Then
            MsgBox("Author is required", MsgBoxStyle.Critical)

        ElseIf publisher = "" Then
            MsgBox("Publisher is required", MsgBoxStyle.Critical)

        ElseIf price = "" Then
            MsgBox("Price is required", MsgBoxStyle.Critical)

        ElseIf stockQuantity = "" Then
            MsgBox("Stock Quantity is required", MsgBoxStyle.Critical)

        Else
            '
            ' Query String
            '
            Dim query As String = "INSERT INTO Books VALUES ('" & name & "','" & author & "','" & publisher & "','" & stockQuantity & "','" & price & "')"

            If InsertQuery(query) > 0 Then
                MsgBox("Book added successfully", MsgBoxStyle.Information)
                ClearInputs()
                LoadDataGridView()
            Else
                MsgBox("Error: Failed to save book", MsgBoxStyle.Critical)
            End If
        End If

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        '
        ' Input values
        '
        Dim name As String = TextBoxName.Text.Trim()
        Dim author As String = TextBoxAuthor.Text.Trim()
        Dim publisher As String = TextBoxPublisher.Text.Trim()
        Dim price As String = TextBoxPrice.Text.Trim()
        Dim stockQuantity As String = TextBoxQuantity.Text.Trim()

        '
        ' Validation
        '
        If currentRecordId = 0 Then
            MessageBox.Show("Zero record selected. To select a record double click in a row inside data table", "Update Record Error", MessageBoxButtons.OK)

        ElseIf name = "" Then
            MsgBox("Name is required", MsgBoxStyle.Critical)

        ElseIf author = "" Then
            MsgBox("Author is required", MsgBoxStyle.Critical)

        ElseIf publisher = "" Then
            MsgBox("Publisher is required", MsgBoxStyle.Critical)

        ElseIf price = "" Then
            MsgBox("Price is required", MsgBoxStyle.Critical)

        ElseIf stockQuantity = "" Then
            MsgBox("Stock Quantity is required", MsgBoxStyle.Critical)

        Else
            ' Query String
            Dim query As String = "UPDATE Books SET Name='" & name & "',AuthorName='" & author & "',PublisherName='" & publisher & "',QuantityInStock='" & stockQuantity & "',price='" & price & "' WHERE BookId='" & currentRecordId & "'"

            If InsertQuery(query) > 0 Then
                MsgBox("Book Updated successfully", MsgBoxStyle.Information)
                ClearInputs()
                LoadDataGridView()
            Else
                MsgBox("Error: Failed to Update book", MsgBoxStyle.Critical)
            End If

        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        If currentRecordId = 0 Then
            MessageBox.Show("Zero record selected. To select a record double click in a row inside data table", "Delete Record Error", MessageBoxButtons.OK)
            Exit Sub
        End If

        Dim query As String = "DELETE FROM Books WHERE BookId='" & currentRecordId & "'"

        If InsertQuery(query) > 0 Then
            MsgBox("Book Deleted successfully", MsgBoxStyle.Information)
            ClearInputs()
            LoadDataGridView()
        Else
            MsgBox("Error: Failed to delete Book", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        ClearInputs()
    End Sub

    Private Sub ClearInputs()
        TextBoxName.Text = ""
        TextBoxAuthor.Text = ""
        TextBoxPublisher.Text = ""
        TextBoxQuantity.Text = ""
        TextBoxPrice.Text = ""
        currentRecordId = 0
    End Sub

    Private Sub Books_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub


    '
    ' Tool Strip Events
    '
    Private Sub ToolStripHome_Click(sender As Object, e As EventArgs) Handles ToolStripHome.Click
        FormHome.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMembers_Click(sender As Object, e As EventArgs) Handles ToolStripMembers.Click
        FormMembers.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripAbout_Click(sender As Object, e As EventArgs) Handles ToolStripAbout.Click
        FormAbout.Show()
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