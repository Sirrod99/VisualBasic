Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        dim numbers() as string = {"I","II","III","IV","V","VI","VII","VIII","IX","X"}        

        Dim Number As Integer = 0
        Integer.TryParse(txtEnter.Text, Number)

        If Number >= 1 And Number <= 10 Then
            lblNumber.Text = numbers(Number - 1)
        End If

    End Sub
End Class
