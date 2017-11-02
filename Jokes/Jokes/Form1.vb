Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblMessage.Click

    End Sub

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        lblMessage.Text = "How many programmers does it take to change a light bulb?"
    End Sub

    Private Sub btnPunch_Click(sender As Object, e As EventArgs) Handles btnPunch.Click
        lblMessage.Text = "None. That's a hardware problem."
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
