Imports System.Data.SqlClient

Public Class FormMembers

    Dim currentRecordId As Integer = 0

    Private Sub FormMembers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MembersTableAdapter.Fill(Me.LibraryManagementDataSet.Members)
    End Sub

    Private Sub LoadDataGridView()
        Dim query As String = "SELECT * FROM Members"

        Dim dataSet = New DataSet
        Dim dataAdapter = New SqlDataAdapter(query, conn)
        dataAdapter.Fill(dataSet)

        DataGridViewMembers.DataSource = dataSet.Tables(0)
    End Sub

    Private Sub DataGridViewMembers_DoubleClick(sender As Object, e As EventArgs) Handles DataGridViewMembers.DoubleClick

        ' Current row index number in which duble Click is performed
        Dim rowIndex As Integer = DataGridViewMembers.CurrentRow.Index

        ' Fill TextBoxes with current row data
        TextBoxName.Text = DataGridViewMembers.Item(1, rowIndex).Value
        TextBoxAge.Text = DataGridViewMembers.Item(2, rowIndex).Value
        TextBoxPhone.Text = DataGridViewMembers.Item(3, rowIndex).Value
        TextBoxEmail.Text = DataGridViewMembers.Item(4, rowIndex).Value
        TextBoxAddress.Text = DataGridViewMembers.Item(5, rowIndex).Value

        ' Set current record id
        currentRecordId = DataGridViewMembers.Item(0, rowIndex).Value
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim name As String = TextBoxName.Text.Trim()
        Dim age As String = TextBoxAge.Text.Trim()
        Dim phone As String = TextBoxPhone.Text.Trim()
        Dim email As String = TextBoxEmail.Text.Trim()
        Dim address As String = TextBoxAddress.Text.Trim()


        ' Validation
        If name = "" Then
            MsgBox("Name is required", MsgBoxStyle.Critical)

        ElseIf age = "" Then
            MsgBox("Age is required", MsgBoxStyle.Critical)

        ElseIf phone = "" Then
            MsgBox("Phone is required", MsgBoxStyle.Critical)

        ElseIf email = "" Then
            MsgBox("Email is required", MsgBoxStyle.Critical)

        ElseIf address = "" Then
            MsgBox("Address Quantity is required", MsgBoxStyle.Critical)

        Else
            ' Query String
            Dim query As String = "INSERT INTO Members VALUES ('" & name & "','" & age & "','" & phone & "','" & email & "','" & address & "')"

            If InsertQuery(query) > 0 Then
                MsgBox("Member added successfully", MsgBoxStyle.Information)
                ClearInputs()
                LoadDataGridView()
            Else
                MsgBox("Error: Failed to save member", MsgBoxStyle.Critical)
            End If
        End If
    End Sub


    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim name As String = TextBoxName.Text.Trim()
        Dim age As String = TextBoxAge.Text.Trim()
        Dim phone As String = TextBoxPhone.Text.Trim()
        Dim email As String = TextBoxEmail.Text.Trim()
        Dim address As String = TextBoxAddress.Text.Trim()


        ' Validation
        If currentRecordId = 0 Then
            MessageBox.Show("Zero record selected. To select a record double click in a row inside data table", "Update Record Error", MessageBoxButtons.OK)

        ElseIf name = "" Then
            MsgBox("Name is required", MsgBoxStyle.Critical)

        ElseIf age = "" Then
            MsgBox("Age is required", MsgBoxStyle.Critical)

        ElseIf phone = "" Then
            MsgBox("Phone is required", MsgBoxStyle.Critical)

        ElseIf email = "" Then
            MsgBox("Email is required", MsgBoxStyle.Critical)

        ElseIf address = "" Then
            MsgBox("Address Quantity is required", MsgBoxStyle.Critical)

        Else
            Dim query As String = "UPDATE Members SET name='" & name & "',age='" & age & "',phone='" & phone & "',email='" & email & "',address='" & address & "' WHERE MemberId='" & currentRecordId & "'"


            If InsertQuery(query) > 0 Then
                MsgBox("Member Updated successfully", MsgBoxStyle.Information)
                ClearInputs()
                LoadDataGridView()
            Else
                MsgBox("Error: Failed to save member", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If currentRecordId = 0 Then
            MessageBox.Show("Zero record selected. To select a record double click in a row inside data table", "Delete Record Error", MessageBoxButtons.OK)
            Exit Sub
        End If

        Dim query As String = "DELETE FROM Members WHERE MemberId='" & currentRecordId & "'"

        If InsertQuery(query) > 0 Then
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

    Private Sub ClearInputs()
        TextBoxName.Text = ""
        TextBoxAge.Text = ""
        TextBoxPhone.Text = ""
        TextBoxEmail.Text = ""
        TextBoxAddress.Text = ""
        currentRecordId = 0
    End Sub

    Private Sub FormMembers_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub


    '
    ' Tool Strip Events
    '
    Private Sub ToolStripHome_Click(sender As Object, e As EventArgs) Handles ToolStripHome.Click
        FormHome.Show()
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

    Private Sub ReceiveBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceiveBookToolStripMenuItem.Click
        FormBookReturn.Show()
        Me.Hide()
    End Sub

    Private Sub ManageBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageBooksToolStripMenuItem.Click
        FormBooks.Show()
        Me.Hide()
    End Sub
End Class
