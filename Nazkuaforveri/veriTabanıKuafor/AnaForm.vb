Public Class AnaForm
    Private Sub MüşteriİşlemleriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MüşteriİşlemleriToolStripMenuItem.Click
        musteriformu.ShowDialog(Me)
        musteriformu.Dispose()
    End Sub

    Private Sub PersonelİşlemleriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonelİşlemleriToolStripMenuItem.Click
        personelformu.ShowDialog(Me)
        personelformu.Dispose()
    End Sub

    Private Sub RandevuİşlemleriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RandevuİşlemleriToolStripMenuItem.Click
        randevuformu.ShowDialog(Me)
        randevuformu.Dispose()
    End Sub

    Private Sub ModelİşlemleriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModelİşlemleriToolStripMenuItem.Click
        modelFormu.ShowDialog(Me)
        modelFormu.Dispose()
    End Sub
End Class