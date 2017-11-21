Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim intStartIndex As Integer
        Dim intFoundIndex As Integer

        If IsNumeric(txtStartIndex.Text) Then
            If txtToFind.Text.Length > 0 Then
                intStartIndex = CInt(txtStartIndex.Text)
                intFoundIndex = lblString.Text.IndexOf(txtToFind.Text, intStartIndex)
            End If
        End If
    End Sub
End Class
