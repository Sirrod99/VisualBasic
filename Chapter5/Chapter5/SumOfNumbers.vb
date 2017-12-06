Public Class SumOfNumbers

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnEnterNumbers_Click(sender As Object, e As EventArgs) Handles btnEnterNumbers.Click
        Dim strUserInput
        Dim IntUserInput As Integer
        Dim i As Integer
        strUserInput = InputBox("Enter a positive integer value", "Input Needed", 10)
        If strUserInput <> String.Empty Then
            Try
                IntUserInput = CInt(strUserInput)
                If IntUserInput < 0 Then
                    MessageBox.Show("Negative numbers are not accepted.")
                    Exit Sub
                End If

                'IntUserInput = (IntUserInput + i)
                InputBox("Sum of Numbers " & "The sum of numbers", (i + IntUserInput))

            Catch ex As Exception
                MessageBox.Show("Quantity amount must be numeric.")
            End Try
            'Show messagebox,
        Else
            MessageBox.Show("Incorrect input", "You must enter a positive integer value", MessageBoxButtons.OK)
            Exit Sub
        End If

    End Sub
End Class