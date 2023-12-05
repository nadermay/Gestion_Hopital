Public Class frm_priseRDV
    Private Sub frm_priseRDV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTP_date.Format = DateTimePickerFormat.Custom
        DTP_date.CustomFormat = "yyyy-MM-dd HH:mm"
    End Sub

    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Dim a As New RendezVous()
        a.codePatient = cb_code.Text
        a.dateEtHeure = DTP_date.Value ' Utilisez Value au lieu de Text pour récupérer la date et l'heure
        ajoutRDV(a)
        cb_code.Text = ""
        DTP_date.Value = DateTime.Now

    End Sub

    Private Sub btn_afficher_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        Me.Hide()
        frm_main.Show()
    End Sub

    Private Sub cb_code_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_code.SelectedIndexChanged

    End Sub

    Private Sub DTP_date_ValueChanged(sender As Object, e As EventArgs) Handles DTP_date.ValueChanged

    End Sub
End Class
