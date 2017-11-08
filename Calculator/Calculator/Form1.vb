Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        'Handler perfroms addition
        'Declares variable to hold the result
        Dim dblResult As Double

        lblOperation.Text = " + "
        dblResult = CDbl(txtNumberOne.Text) + CDbl(txtNumberTwo.Text)
        lblResult.Text = CStr(dblResult)
        
    End Sub

    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        Dim dblResult As Double

        lblOperation.Text = " * "

        dblResult = CDbl(txtNumberOne.Text) * CDbl(txtNumberTwo.Text)

        lblResult.Text = CStr(dblResult)

    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Dim dblResult As Double

        lblOperation.Text = " - "

        dblResult = CDbl(txtNumberOne.Text) - CDbl(txtNumberTwo.Text)

        lblResult.Text = CStr(dblResult)

    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        Dim dblResult As Double

        lblOperation.Text = " / "

        dblResult = CDbl(txtNumberOne.Text) / CDbl(txtNumberTwo.Text)

        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnExp_Click(sender As Object, e As EventArgs) Handles btnExp.Click
        Dim dblResult As Double

        lblOperation.Text = " ^ "

        dblResult = CDbl(txtNumberOne.Text) ^ CDbl(txtNumberTwo.Text)

        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Dim dblResult As Double

        lblOperation.Text = " ^ "
        dblResult = CDbl(txtNumberOne.Text) Mod CDbl(txtNumberTwo.Text)

        lblResult.Text = CStr(dblResult)
    End Sub
End Class
