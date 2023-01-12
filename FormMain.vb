Public Class FormMain

    Private _numChilds As Integer = 0

    Private Sub ClassicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassicToolStripMenuItem.Click
        Dim formClassic As New FormClassic
        _numChilds += 1
        formClassic.Text = "Classic game #" & _numChilds
        formClassic.MdiParent = Me
        formClassic.Show()
    End Sub

    Private Sub CloseAllChilds()
        For Each frm As FormClassic In Me.MdiChildren
            frm.Close()
        Next

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        CloseAllChilds
        Me.Close()
    End Sub
End Class
