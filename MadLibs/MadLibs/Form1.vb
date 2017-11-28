Public Class Form1


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strInput As String


        strInput = listColor.SelectedItem.ToString() & " frog is the " &
            listEst.SelectedItem.ToString() & " frog of in the world, It eats " & listNumber.SelectedItem.ToString() &
            " " & listBodyPartPlural.SelectedItem.ToString() & " a day, and " &
            listAnimal.SelectedItem.ToString() & ", it also has a chokehold on a " &
            listNoun.SelectedItem.ToString() & ". It likes to lick " &
            listPluralNoun.SelectedItem.ToString()

        MessageBox.Show("The " & strInput & ", although, it will lick nearly anything.")




    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
