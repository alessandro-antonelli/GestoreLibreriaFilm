Public Class AggiungiGenere

    Dim ArchivioGeneri As List(Of String)
    Public Genere As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Genere = TextGenere.Text
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub AggiungiGenere_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (MainModule.ModalitaNotte) Then
            Me.BackColor = Color.Black
            Me.ForeColor = Color.White
            Button1.BackColor = Color.FromArgb(32, 32, 32)
            TextGenere.BackColor = Color.FromArgb(32, 32, 32)
            TextGenere.ForeColor = Color.White
            ListGeneriEsistenti.BackColor = Color.FromArgb(32, 32, 32)
            ListGeneriEsistenti.ForeColor = Color.White
        End If

        'Popolo ArchivioNomi
        ArchivioGeneri = New List(Of String)
        TextGenere.Text = ""

        For Each SchedaGenere In MainForm.FilmPerGenere
            If (Not SchedaGenere.GetEtichetta.StartsWith("[") AndAlso Not ArchivioGeneri.Contains(SchedaGenere.GetEtichetta)) Then
                ArchivioGeneri.Add(SchedaGenere.GetEtichetta)
                ListGeneriEsistenti.Items.Add(SchedaGenere.GetEtichetta, MainForm.IndiceIconaGenere(SchedaGenere.GetEtichetta) - 11)
            End If
        Next

        ' Mostro elenco
        TextGenere.Focus()
    End Sub

    Private Sub ListGeneriEsistenti_DoubleClick(sender As Object, e As EventArgs) Handles ListGeneriEsistenti.DoubleClick
        If (ListGeneriEsistenti.SelectedIndices.Count > 0) Then
            Genere = ListGeneriEsistenti.SelectedItems(0).Text
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub FiltraNomi() Handles TextGenere.KeyPress, TextGenere.TextChanged
        If (TextGenere.Text.Trim.Length = 0) Then
            If (ListGeneriEsistenti.Items.Count <> ArchivioGeneri.Count) Then
                For Each StrGenere In ArchivioGeneri
                    ListGeneriEsistenti.Items.Add(StrGenere, MainForm.IndiceIconaGenere(StrGenere) - 11)
                Next
            End If
            Exit Sub
        End If

        ListGeneriEsistenti.Items.Clear()
        For Each GenereStr As String In ArchivioGeneri
            If (GenereStr.Contains(TextGenere.Text.Trim)) Then
                ListGeneriEsistenti.Items.Add(GenereStr, MainForm.IndiceIconaGenere(GenereStr) - 11)
            End If
        Next
    End Sub

    Private Sub ListGeneriEsistenti_Click(sender As Object, e As EventArgs) Handles ListGeneriEsistenti.Click
        If (ListGeneriEsistenti.SelectedIndices.Count > 0) Then
            TextGenere.Text = ListGeneriEsistenti.SelectedItems(0).Text
        End If
    End Sub
End Class