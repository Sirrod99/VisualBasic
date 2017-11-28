Public Class Form1

    
    Private Sub lblSecondPlace_Click(sender As Object, e As EventArgs) Handles lblSecondPlace.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim sngRunner1Time As String
        Dim sngRunner2Time As String
        Dim sngRunner3Time As String
        sngRunner1Time = (Val(txtRunnerTime1.Text))
        sngRunner2Time = (Val(txtRunnerTime2.Text))
        sngRunner3Time = (Val(txtRunnerTime3.Text))
        'option 1
        If sngRunner1Time < sngRunner3Time And sngRunner1Time < sngRunner2Time _
         And sngRunner2Time < sngRunner3Time Then
            lblFirstPlace.Text = txtRunner1.Text
            lblSecondPlace.Text = txtRunner2.Text
            lblThirdPlace.Text = txtRunner3.Text
            'option 2
        ElseIf sngRunner1Time < sngRunner3Time And sngRunner1Time < sngRunner2Time _
         And sngRunner3Time < sngRunner2Time Then
            lblFirstPlace.Text = txtRunner1.Text
            lblSecondPlace.Text = txtRunner3.Text
            lblThirdPlace.Text = txtRunner2.Text
            'option3
        ElseIf sngRunner2Time < sngRunner1Time And sngRunner2Time < sngRunner3Time _
         And sngRunner1Time < sngRunner3Time Then
            lblFirstPlace.Text = txtRunner2.Text
            lblSecondPlace.Text = txtRunner1.Text
            lblThirdPlace.Text = txtRunner3.Text
            'option4
        ElseIf sngRunner2Time < sngRunner1Time And sngRunner2Time < sngRunner3Time _
         And sngRunner3Time < sngRunner1Time Then
            lblFirstPlace.Text = txtRunner2.Text
            lblSecondPlace.Text = txtRunner3.Text
            lblThirdPlace.Text = txtRunner1.Text
            'option5
        ElseIf sngRunner3Time < sngRunner1Time And sngRunner3Time < sngRunner2Time _
         And sngRunner1Time < sngRunner2Time Then
            lblFirstPlace.Text = txtRunner3.Text
            lblSecondPlace.Text = txtRunner1.Text
            lblThirdPlace.Text = txtRunner2.Text
            'option6
        ElseIf sngRunner3Time < sngRunner1Time And sngRunner3Time < sngRunner2Time _
         And sngRunner2Time < sngRunner1Time Then
            lblFirstPlace.Text = txtRunner3.Text
            lblSecondPlace.Text = txtRunner2.Text
            lblThirdPlace.Text = txtRunner1.Text
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
