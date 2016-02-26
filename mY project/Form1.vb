

Public Class Form1

    Private Sub ReceiveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiveToolStripMenuItem.Click
        Me.Hide()
        Receive.Show()
    End Sub

    Private Sub PickToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PickToolStripMenuItem.Click
        Me.Hide()
        Pick.Show()

    End Sub

    Private Sub InventoryListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventoryListToolStripMenuItem.Click
        Me.Hide()
        InventoryList.Show()
    End Sub
End Class
