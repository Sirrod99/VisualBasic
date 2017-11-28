Public Class Form1

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intNumCalories As Integer
        Dim intFatGrams As Integer
        Dim intCaloriesFromFat As Integer
        Dim dblFatPercent As Double

        'Declare a calories for fat constant
        Const intFAT_CALORIES As Integer = 9

        'Get the values and calculate.
        Try
            'Get the number of calories in the food
            intNumCalories = CInt(txtCalories.Text)

            'Get the number of fat grams.
            intFatGrams = CInt(txtFatGrams.Text)

            'Calculation
            intCaloriesFromFat = intFatGrams * intFAT_CALORIES

            If intCaloriesFromFat >= intNumCalories Then
                MessageBox.Show("Calories or fat grams were incorrectly entered.")
            End If

            'Calculate and Display the percentage of calories from fat.
            dblFatPercent = intCaloriesFromFat / intNumCalories
            lblFatPercentage.Text = dblFatPercent.ToString("P")

            'Error message for entering values less than 0
            If intNumCalories < 0 Then
                MessageBox.Show("Enter value greater than Zero")

                If intFatGrams < 0 Then
                    MessageBox.Show("Enter a value greater than Zero")


                End If

            End If

        Catch ex As Exception
            'Display Error message
            MessageBox.Show("Please enter numeric number")
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
