﻿Public Class Population

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Declare variables for calculation
        Dim intCount As Integer
        Dim dblTotal As Double

        'Calculate population, and display output
        listOutput.Items.Add("Day Approximate Population")
        listOutput.Items.Add("-----------------------------------")
        dblTotal = 2
        intCount = 1


        listOutput.Items.Add(intCount.ToString + " " + dblTotal.ToString)

        For intCount = intCount + 1 To txtDays.Text
            dblTotal = ((txtIncreasePct.Text * dblTotal) / 100) + dblTotal
            listOutput.Items.Add(intCount.ToString + " " + dblTotal.ToString)
        Next
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class