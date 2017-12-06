Public Class LightOnLightOff
    Sub TurnLightOn()
        picLightOn.Visible = True
        picLightOff.Visible = False
        lightTurnOn = lightTurnOn + 1
    End Sub
    Sub TurnLightOff()
        picLightOn.Visible = False
        picLightOff.Visible = True
    End Sub
    Dim lightTurnOn As Integer



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLightSwitch.Click
        Dim intLightOn As Integer
        Dim rand As New Random

        intLightOn = rand.Next(2)

        If intLightOn = 0 Then
            TurnLightOn()
        Else
            TurnLightOff()
        End If
        lblResult.Text = lightTurnOn
    End Sub

    Private Sub picLightOn_Click(sender As Object, e As EventArgs) Handles picLightOn.Click

    End Sub
End Class