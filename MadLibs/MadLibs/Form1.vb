Public Class Form1


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strInput As String


        strInput = listColor.SelectedItem.ToString() & " dragon is the " &
            listEst.SelectedItem.ToString() & " dragon of all, It has " & listNumber.SelectedItem.ToString() &
            " " & listBodyPartPlural.SelectedItem.ToString() & ", and a " &
            listAnimal.SelectedItem.ToString() & " shaped like a " &
            listNoun.SelectedItem.ToString() & ". It likes to eat " &
            listPluralNoun.SelectedItem.ToString()

        MessageBox.Show("The " & strInput & ", although, it will feat on nearly anything.")




    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
