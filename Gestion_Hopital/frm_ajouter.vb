Public Class frm_ajouter
    Private Sub frm_ajouter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_code.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txt_nom.TextChanged

    End Sub

    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Dim p As Patient
        With p
            .code = txt_code.Text
            .nom = txt_nom.Text
            .prenom = txt_prenom.Text

        End With
        ajout_patient(p)
        frm_priseRDV.cb_code.Items.Add(p.code)
        txt_code.Clear()
        txt_nom.Clear()
        txt_prenom.Clear()

    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        Me.Hide()
        frm_main.Show()
    End Sub


    Private Sub btn_afficher_Click(sender As Object, e As EventArgs)

    End Sub
End Class