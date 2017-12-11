Public Class Menu

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnPlaneArray.Click
        Dim box = New Arrays2()
        box.Show()
    End Sub

    Private Sub btnFriendList1_Click(sender As Object, e As EventArgs) Handles btnFriendList1.Click
        Dim box = New FriendList()
        box.Show()
    End Sub

    Private Sub btnFriendList2_Click(sender As Object, e As EventArgs) Handles btnFriendList2.Click
        Dim box = New FriendsList2()
        box.Show()
    End Sub

    Private Sub btnNumberGen_Click(sender As Object, e As EventArgs) Handles btnNumberGen.Click
        Dim box = New Form1()
        box.Show()
    End Sub
End Class