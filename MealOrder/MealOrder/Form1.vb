Public Class Form1

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim dblBurger As Double = 8.25
        Dim dblChicken As Double = 7.25
        Dim dblChezBurger As Double = 5.25
        Dim dblTaco As Double = 3.99
        Dim dblTomato As Double = 1.0
        Dim dblLettuce As Double = 0.49
        Dim dblMayo As Double = 1.99
        Dim dblOnion As Double = 2.99
        Dim dblFries As Double = 1.99
        Dim dblChickenFingers As Double = 3.99
        Dim dblCyanide As Double = 99.99
        Dim dblTotal As Double



        If radBurger.Checked = True Then
            lblResult.Text = "You're getting a burger?"
            Total = dblBurger + Total
        ElseIf radChezBurger.Checked = True Then
            lblResult.Text = "You want our special, the Chez Burger?"
            Total = dblChezBurger + Total
        ElseIf radChicken.Checked = True Then
            lblResult.Text = "You want some chicken boy?"
        ElseIf radTaco.Checked = True Then
            lblResult.Text = "Not this again! You want a Delgodo's Taco huh?"
        End If

        If chkTomato.Checked = True Then
            lblResult.Text &= ", and tomato"
        End If
        If chkLettuce.Checked = True Then
            lblResult.Text &= ", and lettuce"
        End If
        If chkMayo.Checked = True Then
            lblResult.Text &= ", and mayo"
        End If
        If chkOnion.Checked = True Then
            lblResult.Text &= ", and a whole onion"
        End If

        If radFries.Checked = True Then
            lblResult.Text &= "Mmm, Fries baby"
        End If
        If radChickenFingers.Checked = True Then
            lblResult.Text &= "Oh boy! Chicken fingers!"
        End If
        If radCyanide.Checked = True Then
            lblResult.Text &= "Umm-Boss, why do we sell this again?"
        End If
        lblTotal.Text = Total.ToString("c")

    End Sub
End Class
