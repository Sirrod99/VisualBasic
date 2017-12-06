Public Class Form1
    Dim tailTotal As Integer
    Dim headTotal As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFlip.Click
        Dim intSideUp As Integer


        Dim rand As New Random

        intSideUp = rand.Next(2)
        If intSideUp = 0 Then
            PictureBox1.Visible = True
            PictureBox2.Visible = False
            tailTotal = 1 + tailTotal

        Else
            PictureBox2.Visible = True
            PictureBox1.Visible = False
            headTotal = 1 + headTotal


        End If
        lblTailsTotal.Text = tailTotal.ToString("n")
        lblHeadTotal.Text = headTotal.ToString("n")
    End Sub
End Class
