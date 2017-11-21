Public Class Form1

   
    Private Sub btnCalcAv_Click(sender As Object, e As EventArgs) Handles btnCalcAv.Click
        Dim dblScore1, dblScore2, dblScore3, dblAverage As Double

        Const NUM_SCORES As Integer = 3
        Const dblHigh_Score As Double = 95.0
        Const dblLow_Score As Double = 80.0


        Try
            dblScore1 = CDbl(txtTestScoreOne.Text)
            dblScore2 = CDbl(txtTestScoreTwo.Text)
            dblScore3 = CDbl(txtTestScoreThree.Text)
            dblAverage = (dblScore1 + dblScore2 + dblScore3) / NUM_SCORES

            lblAverage.Text = dblAverage.ToString("n2")

            If dblAverage > dblHigh_Score Then
                lblMessage.Text = "Congratulations! Good Job My Boi!"

            Else
                lblMessage.Text = "You suck!"

            End If


        Catch ex As Exception
            lblMessage.Text = "Scores Must be numeric"

        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTestScoreOne.Clear()
        txtTestScoreTwo.Clear()
        txtTestScoreThree.Clear()
        lblAverage.Text = String.Empty
        lblMessage.Text = String.Empty
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub lblAverage_Click(sender As Object, e As EventArgs) Handles lblAverage.Click

    End Sub

    Private Sub txtTestScoreOne_TextChanged(sender As Object, e As EventArgs) Handles txtTestScoreOne.TextChanged

    End Sub

    Private Sub txtTestScoreThree_TextChanged(sender As Object, e As EventArgs) Handles txtTestScoreThree.TextChanged

    End Sub

    Private Sub txtTestScoreTwo_TextChanged(sender As Object, e As EventArgs) Handles txtTestScoreTwo.TextChanged

    End Sub

    Private Sub lblMessage_Click(sender As Object, e As EventArgs) Handles lblMessage.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub
End Class
