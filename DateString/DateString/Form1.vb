Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnShowDate_Click(sender As Object, e As EventArgs) Handles btnShowDate.Click
        lblDateString.Text = txtDayofWeek.Text & ", " & txtMonth.Text &
             " " & txtDayofMonth.Text & ", " &
            txtYear.Text
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtDayofWeek.TextChanged

    End Sub

    Private Sub txtMonth_TextChanged(sender As Object, e As EventArgs) Handles txtMonth.TextChanged

    End Sub

    Private Sub txtDayofMonth_TextChanged(sender As Object, e As EventArgs) Handles txtDayofMonth.TextChanged

    End Sub

    Private Sub txtYear_TextChanged(sender As Object, e As EventArgs) Handles txtYear.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDayofMonth.Clear()
        txtDayofWeek.Clear()
        txtMonth.Clear()
        txtYear.Clear()

    End Sub
End Class
