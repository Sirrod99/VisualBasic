Option Strict On
Public Class DistanceCalc
    Dim speed As Double
    Dim time As Double
    Dim counter As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        speed = CDbl(txtSpeed.Text)
        time = CDbl(txtTime.Text)

        For counter As Double = 1 To time
            Console.WriteLine(counter & Distance(speed, time))
        Next
        Console.ReadLine()
    End Sub
    Private Function Distance(ByVal speed As Double, ByVal time As Double) As Double
        Distance = CDbl(speed * time)
    End Function


End Class