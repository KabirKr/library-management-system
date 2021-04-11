Public Class FormHome

    Private Sub FormHome_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub BtnBooks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBooks.Click
        FormBooks.Show()
        Me.Hide()
    End Sub
End Class