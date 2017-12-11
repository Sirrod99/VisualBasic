Public Class Arrays2

    Private Sub btnDisplayPrice_Click(sender As Object, e As EventArgs) Handles btnDisplayPrice.Click
        Dim intRow, intCol As Integer


        Const intMax_ROW As Integer = 5
        Const intMAX_COL As Integer = 3


        Dim decPrices(,) = {{450D, 450D, 450D, 450D},
                            {425D, 425D, 425D, 425D},
                            {400D, 400D, 400D, 400D},
                            {375D, 375D, 375D, 375D},
                            {375D, 375D, 375D, 375D},
                            {350D, 350D, 350D, 350D}}

        Try
            intRow = CInt(txtRow.Text)
            intCol = CInt(txtCol.Text)

            If intRow >= 0 And intRow <= IntMax_ROW Then
                If intCol >= 0 And intCol <= intMAX_COL Then
                    lblPrice.Text = decPrices(intRow, intCol).ToString("c")
                Else
                    MessageBox.Show("Column must be 0 through " &
                                    intMAX_COL.ToString())
                End If
            Else
                MessageBox.Show("Row must be 0 through " &
                                intMax_ROW.ToString())
            End If
        Catch
            MessageBox.Show("Row and column must be integers.")

        End Try


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class