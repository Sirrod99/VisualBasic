Public Class Form1


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblResult As Double


        dblResult = CDbl(txtMilesDriven.Text) / CDbl(txtGasHeld.Text)
        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGasHeld.Clear()
        txtMilesDriven.Clear()
        lblResult.Text = String.Empty
    End Sub
End Class
