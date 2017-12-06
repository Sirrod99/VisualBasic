Public Class TestScores

    Private Sub btnGetScores_Click(sender As Object, e As EventArgs) Handles btnGetScores.Click
        Dim intNumScores As Integer = 5
        Dim dblTestScore As Double = 0
        Dim dlbTotal As Double = 0
        Dim dblAverage As Double = 0
        Dim strInput As String = 0
        Dim IntCount As Integer = 1

        strInput = InputBox("How many test scores do you want to average?")
        If Integer.TryParse(strInput, intNumScores) Then
            Do Until IntCount > intNumScores
                strInput = InputBox("Enter test score " & IntCount.ToString)
                If Double.TryParse(strInput, dblTestScore) Then
                    IntCount += 1
                Else
                    MessageBox.Show("Enter a numeric test score.")
                End If
            Loop
            If intNumScores > 0 Then

            End If
        End If



    End Sub
End Class