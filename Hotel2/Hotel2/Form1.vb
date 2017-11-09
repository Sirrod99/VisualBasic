Public Class Form1

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub


    
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNights.Clear()
        txtNightlyCharge.Clear()

        txtRoomService.Clear()
        txtTelephone.Clear()
        txtMisc.Clear()

        lblAdditionalCharges.Text = String.Empty
        lblRoomCharges.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotalCharges.Text = String.Empty
        lblTimeToday.Text = Now.ToString("T")
        lblDateToday.Text = Now.ToString("D")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblDateToday.Click

    End Sub

    Private Sub lblTimeToday_Click(sender As Object, e As EventArgs) Handles lblTimeToday.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decRoomCharges As Decimal
        Dim decAddCharges As Decimal
        Dim decSubtotal As Decimal
        Dim decTax As Decimal
        Dim decTotal As Decimal
        Const decTax_Rate As Decimal = 0.08D


        Try
            decRoomCharges = CDec(txtNights.Text) * CDec(txtNightlyCharge.Text)
            lblRoomCharges.Text = decRoomCharges.ToString("c")

            decAddCharges = CDec(txtRoomService.Text) + CDec(txtTelephone.Text) + CDec(txtMisc.Text)
            lblAdditionalCharges.Text = decAddCharges.ToString("c")

            decSubtotal = decRoomCharges + decAddCharges
            lblSubtotal.Text = decSubtotal.ToString("c")

            decTax = decSubtotal * decTax_Rate
            lblTax.Text = decTax.ToString("c")

            decTotal = decSubtotal + decTax
            lblTotalCharges.Text = decTotal.ToString("c")

        Catch
            MessageBox.Show("All input must be valid my friend.")
        End Try




    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDateToday.Text = Now.ToString("D")
        lblTimeToday.Text = Now.ToString("T")

    End Sub
End Class
