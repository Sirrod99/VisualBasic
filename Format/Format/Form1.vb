Public Class Form1


    Private Sub btnNumberFormat_Click(sender As Object, e As EventArgs) Handles btnNumberFormat.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtOne.Text)

        strResult = dblAnswer.ToString("n")
        lblFormatResult.Text = strResult
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnFixed.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtOne.Text)

        strResult = dblAnswer.ToString("f")
        lblFormatResult.Text = strResult
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExp.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtOne.Text)

        strResult = dblAnswer.ToString("e")
        lblFormatResult.Text = strResult
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnCurrency.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtOne.Text)

        strResult = dblAnswer.ToString("c")
        lblFormatResult.Text = strResult
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnPercent.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtOne.Text)
        strResult = dblAnswer.ToString("p")
        lblFormatResult.Text = strResult
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnShortDate.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(txtOne.Text)

        strResult = Answer.ToString("d")
        lblFormatResult.Text = strResult
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnLongDate.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(txtOne.Text)

        strResult = Answer.ToString("D")
        lblFormatResult.Text = strResult
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnShortTime.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtOne.Text)

        strResult = dblAnswer.ToString("t")
        lblFormatResult.Text = strResult
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnLongTime.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtOne.Text)

        strResult = dblAnswer.ToString("T")
        lblFormatResult.Text = strResult
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btnFullDate.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtOne.Text)

        strResult = dblAnswer.ToString("F")
        lblFormatResult.Text = strResult
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
