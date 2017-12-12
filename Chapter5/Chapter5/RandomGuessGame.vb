﻿Public Class RandomGuessGame
    Dim guesses As Integer
    Dim CG As Integer
    Dim rand As New Random
    Dim intWins As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        'Guess
        Randomize()
        Dim UG As Integer

        If Integer.TryParse(txtNumber.Text, UG) Then
            guesses = guesses + 1
            If UG = CG Then
                MessageBox.Show("You guessed my Number!")
                btnPlay.Enabled = False
                intWins = 1 + intWins

                'Action to start new game
            ElseIf guesses = 100 Then
                btnPlay.Enabled = False
                Stop
                'End current game here
            ElseIf UG < CG Then
                MessageBox.Show("Your guess is too low")
            ElseIf UG > CG Then
                MessageBox.Show("Your guess is too high.")
            End If
            txtNumber.SelectAll()
        Else
            MessageBox.Show("Please enter a number and try agian")
        End If
        lblWins.Text = intWins.ToString("n")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        'New Game
        'CG = rand.Next(1,100) 'Random number between 1 and 100 inclusive
        CG = rand.Next(100) 'Random Number between 1 and 100 Inclusive
        guesses = 100
        txtNumber.Text = ("")
        txtNumber.Select()
        btnPlay.Enabled = True
    End Sub
End Class