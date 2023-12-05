Public Class frm_RDVJour


    Private Sub frm_RDVJour_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficherRDVsDuJour(DGV_rdvJour)
    End Sub

    Private Sub DGV_rdvJour_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_rdvJour.CellContentClick

    End Sub

    Private Sub btn_Annuler_Click(sender As Object, e As EventArgs) Handles btn_Annuler.Click
        Me.Hide()
        Me.Hide()

        frm_main.Show()

    End Sub
End Class