﻿Public Class Menu

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim box = New RunningTotal()
        box.Show()
    End Sub

    Private Sub btnTestScores_Click(sender As Object, e As EventArgs) Handles btnTestScores.Click
        Dim box = New TestScores()
        box.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSumOfNumbers.Click
        Dim box = New SumOfNumbers()
        box.Show()
    End Sub
End Class