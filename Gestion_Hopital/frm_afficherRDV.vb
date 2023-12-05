Public Class frm_afficherRDV
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_RDV.CellContentClick

    End Sub

    Private Sub frm_afficherRDV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficherRDVs(DGV_RDV)
    End Sub

    Private Sub btn_supprimer_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click
        Dim b As Integer
        b = DGV_RDV.CurrentCell.RowIndex
        supprimerpatient(DGV_RDV, b)
    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        Me.Hide()
    End Sub
End Class