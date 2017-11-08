Public Class Form1

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Clear()
        txtLastName.Clear()
        lblFullName.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnShowName_Click(sender As Object, e As EventArgs) Handles btnShowName.Click
        Dim strFullName As String
        strFullName = txtFirstName.Text & " " & txtLastName.Text
        lblFullName.Text = strFullName
    End Sub
End Class
