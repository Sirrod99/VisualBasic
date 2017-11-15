Public Class Form1

   
    Private Sub btnCalcAv_Click(sender As Object, e As EventArgs) Handles btnCalcAv.Click
        Dim decAverage As Decimal

        decAverage = CDec(txtTestScoreOne.Text) + CDec(txtTestScoreTwo.Text) +
            CDec(txtTestScoreThree.Text) + CDec(txtTestScoreFour.Text)
        lblAverage.Text = decAverage.ToString

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
