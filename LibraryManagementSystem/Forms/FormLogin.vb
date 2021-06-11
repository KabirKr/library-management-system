Public Class FormLogin
    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click

        Dim username As String = TextBoxUsername.Text.Trim()
        Dim password As String = TextBoxPassword.Text.Trim()

        If username = "" Or password = "" Then
            MsgBox("Enter a valid username and password", MsgBoxStyle.OkOnly, "Login")
        Else
            Dim query As String = "SELECT UserName, LibrarianId FROM Librarians WHERE UserName = '" & username & "' AND Password = '" & password & "'"

            Dim dataSet = GetDataset(query)

            If dataSet.Tables(0).Rows.Count > 0 Then
                CurrentUserId = dataSet.Tables(0).Rows(0).Item("LibrarianId")
                CurrentUserName = dataSet.Tables(0).Rows(0).Item("UserName")

                TextBoxUsername.Clear()
                TextBoxPassword.Clear()

                FormDashboard.Show()
                Me.Hide()
            Else
                MsgBox("Incorrect username or password", MsgBoxStyle.Critical, "Login")
            End If
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub
End Class
