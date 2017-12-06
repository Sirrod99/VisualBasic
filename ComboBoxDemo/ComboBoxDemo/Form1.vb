Public Class Form1


    Private Sub btnShowSelections_Click(sender As Object, e As EventArgs) Handles btnShowSelections.Click
        txtCountry.Text = cblCountry.Text
        txtPlay.Text = cblPlay.Text
        txtArtist.Text = cblArtist.Text
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
