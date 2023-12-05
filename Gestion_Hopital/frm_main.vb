Public Class frm_main
    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AjouterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterToolStripMenuItem.Click
        frm_ajouter.Show()
    End Sub

    Private Sub AfficherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfficherToolStripMenuItem.Click
        frm_afficherpatient.Show()
    End Sub

    Private Sub PriseDeRDVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PriseDeRDVToolStripMenuItem.Click
        frm_priseRDV.Show()
    End Sub

    Private Sub RDVJourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RDVJourToolStripMenuItem.Click

        frm_RDVJour.Show()
    End Sub

    Private Sub RDVsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RDVsToolStripMenuItem.Click
        frm_afficherRDV.Show()
    End Sub
End Class