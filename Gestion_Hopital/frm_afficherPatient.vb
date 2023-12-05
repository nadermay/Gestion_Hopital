Public Class frm_afficherpatient
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_patient.CellContentClick

    End Sub

    Private Sub frm_afficherpatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        affichage(dgv_patient)
    End Sub

    Private Sub btn_supprimer_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_supprimer_Click_1(sender As Object, e As EventArgs) Handles btn_supprimer.Click
        Dim a As Integer
        a = dgv_patient.CurrentCell.RowIndex
        supprimerpatient(dgv_patient, a)
    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        Me.Hide()
    End Sub
End Class