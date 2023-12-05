Module Module1
    Structure Patient
        Dim code As String
        Dim nom As String
        Dim prenom As String
    End Structure
    Public Patients(100) As Patient
    Public nb As Integer = 0
    Public Sub ajout_patient(p As Patient)
        If nb < 100 Then
            Patients(nb) = p
            nb += 1
        End If
    End Sub
    Public Sub affichage(Dgv As DataGridView)
        For Each p As Patient In Patients
            If p.code IsNot Nothing Then
                Dgv.Rows.Add(p.code, p.nom, p.prenom)
            End If
        Next
    End Sub
    Public Sub supprimerpatient(dataGridView As DataGridView, a As Integer)
        For p = a To nb - 1
            Patients(p) = Patients(p + 1)
        Next
        nb -= 1
        dataGridView.Rows.RemoveAt(a)
    End Sub
    Structure RendezVous
        Dim codePatient As Integer
        Dim dateEtHeure As Date
    End Structure
    Public RDVs(100) As RendezVous
    Public nombreRDVs As Integer = 0

    Function ajoutRDV(nouveauRDV As RendezVous) As Boolean

        If nombreRDVs >= 100 Then
            Console.WriteLine("Le tableau de rendez-vous est saturé.")
            Return False
        End If
        RDVs(nombreRDVs) = nouveauRDV
        nombreRDVs += 1
        Return True
    End Function

    Public Sub afficherRDVs(DGV As DataGridView)
        For i As Integer = 0 To nombreRDVs - 1
            DGV.Rows.Add(RDVs(i).codePatient, RDVs(i).dateEtHeure)
        Next
    End Sub


    Public Sub afficherRDVsDuJour(dataGridView As DataGridView)

        Dim aujourdHui As Date = Date.Now.Date
        For i As Integer = 0 To nombreRDVs - 1
            If RDVs(i).dateEtHeure = aujourdHui Then
                dataGridView.Rows.Add(RDVs(i).codePatient, RDVs(i).dateEtHeure)
            End If
        Next
    End Sub
    Public Sub supprimerRdv(dataGridView As DataGridView, b As Integer)
        For p = b To nb - 1
            Patients(p) = Patients(p + 1)
        Next
        nb -= 1
        dataGridView.Rows.RemoveAt(b)
    End Sub

End Module
