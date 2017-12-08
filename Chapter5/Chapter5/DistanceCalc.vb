
Public Class DistanceCalc
    Sub DistanceMulti()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intCount As Integer = 1
        Dim intHours As Integer
        'Dim intDistance As Integer
        Dim intMilesPerHour As Integer
        Dim intTotalDistance As Integer
        Dim strSpeed As String
        Dim strTime As String
        Dim strInput As String

        'prompt the user to enter speed
        strInput = InputBox("What is the speed in miles-per-hour?", "Enter Speed")

        'Convert the input to a decimal
        If Integer.TryParse(strInput, intMilesPerHour) Then

        End If

        'Prompt the user to enter hours
        strInput = InputBox("What is the amount of time in hours?" & intCount.ToString(), "Enter Time")

        'Convert the input to a decimal
        If Integer.TryParse(strInput, intHours) Then

        End If

        For intCount = 1 To 2
            intTotalDistance = intHours * intCount

            'intMilesPerHour = CInt(InputBox("Enter the number of miles per hour "))
            ' intHours = CInt(InputBox("Enter the number of hours in travel time "))

            strSpeed = "Vehicle Speed: " & intMilesPerHour.ToString() & " MPH"

            strTime = "Time Traveled: " & intHours.ToString() & " hours"

            'insert speed and time to list box
            listOutput.Items.Insert(0, strSpeed)
            listOutput.Items.Insert(1, strTime)


            listOutput.Items.Insert(2, "Hours" & "     " & "Distance Traveled")

            listOutput.Items.Insert(3, "______________________")

            'Add 1 to the counter
            intCount += 1
        Next

        intTotalDistance = intMilesPerHour * intHours

        listOutput.Items.Insert(0, "Total Distance:" & intTotalDistance.ToString("n2"))

    End Sub




    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class