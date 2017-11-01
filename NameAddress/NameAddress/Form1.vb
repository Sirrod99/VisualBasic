Public Class Form1

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        lblMessage.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
