Public Class KiloConverter

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Inches_Click(sender As Object, e As EventArgs) Handles btnInches.Click
        lblMessage.Text = "1 Kilometer = 39,370 inches"
    End Sub

    Private Sub btnFeet_Click(sender As Object, e As EventArgs) Handles btnFeet.Click
        lblMessage.Text = "1 Kilometer = 3,281 feet"
    End Sub

    Private Sub btnYards_Click(sender As Object, e As EventArgs) Handles btnYards.Click
        lblMessage.Text = "1 Kilometer = 1,093.6 yards"
    End Sub

    Private Sub btnMiles_Click(sender As Object, e As EventArgs) Handles btnMiles.Click
        lblMessage.Text = "1 Kilometer = 0.6214 miles"
    End Sub

    Private Sub lblMessage_Click(sender As Object, e As EventArgs) Handles lblMessage.Click

    End Sub
End Class
