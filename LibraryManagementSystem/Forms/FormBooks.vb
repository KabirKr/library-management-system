Public Class FormBooks

    ' This var holds the id of a book which is selected in data grid view
    Dim selectedBookId As Integer = 0

    Private Sub FormBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDataGridView()
    End Sub

    Private Sub LoadDataGridView()
        Dim query As String = "SELECT [BookId], [Name], [AuthorName], [PublisherName], [QuantityInStock], [Price] FROM [Books];"

        Dim dataSet = GetDataset(query)
        BooksDataGridView.DataSource = dataSet.Tables(0)

        BooksDataGridView.Columns(1).HeaderText = "Name"
        BooksDataGridView.Columns(2).HeaderText = "Author"
        BooksDataGridView.Columns(3).HeaderText = "Publisher"
        BooksDataGridView.Columns(4).HeaderText = "Stock Quantity"
        BooksDataGridView.Columns(5).HeaderText = "Price"

        ' Hide BookId
        BooksDataGridView.Columns(0).Visible = False
    End Sub

    Private Sub BooksDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles BooksDataGridView.DoubleClick
        ' Current row index number in which double Click is performed
        Dim rowIndex As Integer = BooksDataGridView.CurrentRow.Index

        ' Fill TextBoxes with current row data
        TextBoxName.Text = BooksDataGridView.Item(1, rowIndex).Value
        TextBoxAuthor.Text = BooksDataGridView.Item(2, rowIndex).Value
        TextBoxPublisher.Text = BooksDataGridView.Item(3, rowIndex).Value
        TextBoxQuantity.Text = BooksDataGridView.Item(4, rowIndex).Value
        TextBoxPrice.Text = BooksDataGridView.Item(5, rowIndex).Value

        selectedBookId = BooksDataGridView.Item(0, rowIndex).Value
    End Sub

    Private Function ValidateInputs(name As String, author As String, publisher As String, price As String, stockQuantity As String) As Boolean
        If name = "" Then
            MsgBox("Name is required", MsgBoxStyle.Critical, "Books")
            Return False
        ElseIf author = "" Then
            MsgBox("Author is required", MsgBoxStyle.Critical, "Books")
            Return False
        ElseIf publisher = "" Then
            MsgBox("Publisher is required", MsgBoxStyle.Critical, "Books")
            Return False
        ElseIf price = "" Then
            MsgBox("Price is required", MsgBoxStyle.Critical, "Books")
            Return False
        ElseIf stockQuantity = "" Then
            MsgBox("Stock Quantity is required", MsgBoxStyle.Critical, "Books")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub ClearInputs()
        TextBoxName.Clear()
        TextBoxAuthor.Clear()
        TextBoxPublisher.Clear()
        TextBoxQuantity.Clear()
        TextBoxPrice.Clear()
        selectedBookId = 0
    End Sub

    Private Sub BtnAddBook_Click(sender As Object, e As EventArgs) Handles BtnAddBook.Click
        Dim name As String = TextBoxName.Text.Trim()
        Dim author As String = TextBoxAuthor.Text.Trim()
        Dim publisher As String = TextBoxPublisher.Text.Trim()
        Dim price As String = TextBoxPrice.Text.Trim()
        Dim stockQuantity As String = TextBoxQuantity.Text.Trim()

        If ValidateInputs(name, author, publisher, price, stockQuantity) Then
            Dim query As String = "INSERT INTO Books VALUES ('" & name & "','" & author & "','" & publisher & "','" & stockQuantity & "','" & price & "')"

            If ExecuteQuery(query) > 0 Then
                MsgBox("Book added successfully", MsgBoxStyle.Information, "Books")
                ClearInputs()
                LoadDataGridView()
            Else
                MsgBox("Error: Failed to save book", MsgBoxStyle.Critical, "Books")
            End If
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim name As String = TextBoxName.Text.Trim()
        Dim author As String = TextBoxAuthor.Text.Trim()
        Dim publisher As String = TextBoxPublisher.Text.Trim()
        Dim price As String = TextBoxPrice.Text.Trim()
        Dim stockQuantity As String = TextBoxQuantity.Text.Trim()

        If selectedBookId = 0 Then
            MsgBox("No record selected. To select a record double click in a row inside data table", MsgBoxStyle.Information, "Books")
            Exit Sub
        End If

        If ValidateInputs(name, author, publisher, price, stockQuantity) Then
            Dim query As String = "UPDATE Books SET Name='" & name & "',AuthorName='" & author & "',PublisherName='" & publisher & "',QuantityInStock='" & stockQuantity & "',price='" & price & "' WHERE BookId='" & selectedBookId & "'"

            If ExecuteQuery(query) > 0 Then
                MsgBox("Book Updated successfully", MsgBoxStyle.Information, "Books")
                ClearInputs()
                LoadDataGridView()
            Else
                MsgBox("Error: Failed to Update book", MsgBoxStyle.Critical, "Books")
            End If
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If selectedBookId = 0 Then
            MessageBox.Show("Zero record selected. To select a record double click in a row inside data table", "Delete Record Error", MessageBoxButtons.OK)
            Exit Sub
        End If

        Dim query As String = "DELETE FROM Books WHERE BookId='" & selectedBookId & "'"

        If ExecuteQuery(query) > 0 Then
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


    ' Close the application on closing the form
    Private Sub Books_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    ' Tool Strip button events
    Private Sub ToolStripHome_Click(sender As Object, e As EventArgs) Handles ToolStripHome.Click
        FormDashboard.Show()
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

    Private Sub ReceiveBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceiveBookToolStripMenuItem.Click
        FormReturnBook.Show()
        Me.Hide()
    End Sub
End Class