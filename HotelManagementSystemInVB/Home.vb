Public Class Home

    Private Sub NewRoomToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewRoomToolStripMenuItem.Click
        NewRoom.Show()
    End Sub

    Private Sub NewCustToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewCustToolStripMenuItem.Click
        NewCust.Show()
    End Sub

    Private Sub CheckInToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CheckInToolStripMenuItem.Click
        CheckIn.Show()
    End Sub

    Private Sub CheckOutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CheckOutToolStripMenuItem.Click
        Employee.Show()
    End Sub

    Private Sub NewEmployeeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewEmployeeToolStripMenuItem.Click
        Hide()
    End Sub
End Class