Public Class Form1

    
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lblClassA_Click(sender As Object, e As EventArgs) Handles lblClassA.Click
        
    End Sub

    Private Sub btnCalcRev_Click(sender As Object, e As EventArgs) Handles btnCalcRev.Click
        Dim dblResult As Double

        dblResult = CDbl(txtClassA.Text) * CDbl(15)

        lblClassA.Text = CStr(dblResult)




        dblResult = CDbl(txtClassB.Text) * CDbl(12)

        lblClassB.Text = CStr(dblResult)



        dblResult = CDbl(txtClassC.Text) * CDbl(9)

        lblClassC.Text = CStr(dblResult)




        dblResult = CDbl(txtClassA.Text) + CDbl(txtClassB.Text) + CDbl(txtClassC.Text)

        lblTotalRev.Text = CStr(dblResult)
    End Sub
End Class
