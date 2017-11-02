Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblMessage.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCenter.Click
        MessageBox.Show("Medium")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        MessageBox.Show("Sinister")
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        MessageBox.Show("Dexter")
    End Sub
End Class
