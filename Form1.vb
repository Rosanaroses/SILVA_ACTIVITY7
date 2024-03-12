Public Class Form1
    Private Sub llblRegisternow_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblRegisternow.LinkClicked
        frmregister.Show()
        Me.Hide()
    End Sub
End Class
