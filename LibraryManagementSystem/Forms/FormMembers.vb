Public Class FormMembers
    ' This var holds the id of a book which is selected in data grid view
    Dim selectedMemberId As Integer = 0

    Private Sub FormMembers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDataGridView()
    End Sub

    Private Sub LoadDataGridView()
        Dim query As String = "SELECT [MemberId], [Name], [Age], [Phone], [Email], [Address] FROM [Members]"

        Dim dataSet = GetDataset(query)
        MembersDataGridView.DataSource = dataSet.Tables(0)

        MembersDataGridView.Columns(1).HeaderText = "Name"
        MembersDataGridView.Columns(2).HeaderText = "Age"
        MembersDataGridView.Columns(3).HeaderText = "Phone"
        MembersDataGridView.Columns(4).HeaderText = "Email"
        MembersDataGridView.Columns(5).HeaderText = "Address"

        ' Hide MemberId column
        MembersDataGridView.Columns(0).Visible = False
    End Sub

    Private Sub DataGridViewMembers_DoubleClick(sender As Object, e As EventArgs) Handles MembersDataGridView.DoubleClick

        ' Current row index number in which double click is performed
        Dim rowIndex As Integer = MembersDataGridView.CurrentRow.Index

        ' Fill TextBoxes with current row data
        TextBoxName.Text = MembersDataGridView.Item(1, rowIndex).Value
        TextBoxAge.Text = MembersDataGridView.Item(2, rowIndex).Value
        TextBoxPhone.Text = MembersDataGridView.Item(3, rowIndex).Value
        TextBoxEmail.Text = MembersDataGridView.Item(4, rowIndex).Value
        TextBoxAddress.Text = MembersDataGridView.Item(5, rowIndex).Value

        selectedMemberId = MembersDataGridView.Item(0, rowIndex).Value
    End Sub

    Private Function ValidateInputs(name As String, age As String, phone As String, email As String, address As String) As Boolean

        If name = "" Then
            MsgBox("Name is required", MsgBoxStyle.Critical, "Members")
            Return False
        ElseIf age = "" Then
            MsgBox("Age is required", MsgBoxStyle.Critical, "Members")
            Return False
        ElseIf phone = "" Then
            MsgBox("Phone is required", MsgBoxStyle.Critical, "Members")
            Return False
        ElseIf email = "" Then
            MsgBox("Email is required", MsgBoxStyle.Critical, "Members")
            Return False
        ElseIf address = "" Then
            MsgBox("Address is required", MsgBoxStyle.Critical, "Members")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub ClearInputs()
        TextBoxName.Clear()
        TextBoxAge.Clear()
        TextBoxPhone.Clear()
        TextBoxEmail.Clear()
        TextBoxAddress.Clear()
        selectedMemberId = 0
    End Sub

    ' Button Event Handlers
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim name As String = TextBoxName.Text.Trim()
        Dim age As String = TextBoxAge.Text.Trim()
        Dim phone As String = TextBoxPhone.Text.Trim()
        Dim email As String = TextBoxEmail.Text.Trim()
        Dim address As String = TextBoxAddress.Text.Trim()

        If (ValidateInputs(name, age, phone, email, address)) Then
            Dim query As String = "INSERT INTO Members VALUES ('" & name & "','" & age & "','" & phone & "','" & email & "','" & address & "')"

            If ExecuteQuery(query) > 0 Then
                MsgBox("Member added successfully", MsgBoxStyle.Information, "Members")
                ClearInputs()
                LoadDataGridView()
            Else
                MsgBox("Error: Failed to save member", MsgBoxStyle.Critical, "Members")
            End If

        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim name As String = TextBoxName.Text.Trim()
        Dim age As String = TextBoxAge.Text.Trim()
        Dim phone As String = TextBoxPhone.Text.Trim()
        Dim email As String = TextBoxEmail.Text.Trim()
        Dim address As String = TextBoxAddress.Text.Trim()

        If selectedMemberId = 0 Then
            MsgBox("Zero record selected. To select a record double click in a row inside data table", MsgBoxStyle.Information, "Members")
            Exit Sub
        End If

        If (ValidateInputs(name, age, phone, email, address)) Then
            Dim query As String = "UPDATE Members SET name='" & name & "',age='" & age & "',phone='" & phone & "',email='" & email & "',address='" & address & "' WHERE MemberId='" & selectedMemberId & "'"

            If ExecuteQuery(query) > 0 Then
                MsgBox("Member Updated successfully", MsgBoxStyle.Information, "Members")
                ClearInputs()
                LoadDataGridView()
            Else
                MsgBox("Error: Failed to save member", MsgBoxStyle.Critical, "Members")
            End If
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If selectedMemberId = 0 Then
            MessageBox.Show("Zero record selected. To select a record double click in a row inside data table", "Delete Record Error", MessageBoxButtons.OK)
            Exit Sub
        End If

        Dim query As String = "DELETE FROM Members WHERE MemberId='" & selectedMemberId & "'"

        If ExecuteQuery(query) > 0 Then
            MsgBox("Member Deleted successfully", MsgBoxStyle.Information)
            ClearInputs()
            LoadDataGridView()
        Else
            MsgBox("Error: Failed to delete member", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        ClearInputs()
    End Sub

    ' Exit application on closing the form
    Private Sub FormMembers_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    ' Tool Strip button events
    Private Sub ToolStripHome_Click(sender As Object, e As EventArgs) Handles ToolStripHome.Click
        FormDashboard.Show()
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

    Private Sub ManageBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageBooksToolStripMenuItem.Click
        FormBooks.Show()
        Me.Hide()
    End Sub
End Class