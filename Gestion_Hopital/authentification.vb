Public Class frm_authentification
    Private Sub authentification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btn_connecter_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_connecter.Click
        Dim Login As String
        Dim Mdp As String
        Login = txt_utilisateur.Text
        Mdp = txt_mdp.Text

        If (Login = "admin") And (Mdp = "1234") Then
            Me.Hide()
            frm_main.WindowState = FormWindowState.Maximized




            frm_main.Show()
        Else
            MessageBox.Show("Nom ou mot de passe est incorrect")
        End If
        txt_utilisateur.Clear()
        txt_mdp.Clear()

    End Sub

    Private Sub btn_annuler_Click_1(sender As Object, e As EventArgs) Handles btn_annuler.Click
        txt_utilisateur.Clear()
        txt_mdp.Clear()
    End Sub
End Class
