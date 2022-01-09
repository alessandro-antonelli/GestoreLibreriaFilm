Public Class InserisciNomeCognome
    Dim ArchivioNomi As List(Of String)
    Public Nome, Cognome As String
    Public SoloInizialeNome As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Nome = TextNome.Text
        Cognome = TextCognome.Text
        SoloInizialeNome = CheckSoloIniziale.Checked
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Sub ImpostaNomeCompletoComeDefault()
        CheckSoloIniziale.Checked = False
    End Sub

    Private Sub InserisciNomeCognome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (MainModule.ModalitaNotte) Then
            Me.BackColor = Color.Black
            Me.ForeColor = Color.White
            Button1.BackColor = Color.FromArgb(32, 32, 32)
            TextNome.BackColor = Color.FromArgb(32, 32, 32)
            TextCognome.BackColor = Color.FromArgb(32, 32, 32)
            ListNomiEsistenti.BackColor = Color.FromArgb(32, 32, 32)
            TextNome.ForeColor = Color.White
            TextCognome.ForeColor = Color.White
            ListNomiEsistenti.ForeColor = Color.White
        End If

        'Popolo ArchivioNomi
        ArchivioNomi = New List(Of String)
        TextNome.Text = ""
        TextCognome.Text = ""

        For Each regista In MainForm.FilmPerRegista
            If (Not regista.GetEtichetta.StartsWith("[") AndAlso Not ArchivioNomi.Contains(regista.GetEtichetta)) Then
                ArchivioNomi.Add(regista.GetEtichetta)
            End If
        Next
        For Each attore In MainForm.FilmPerAttore
            If (Not attore.GetEtichetta.StartsWith("[") AndAlso Not ArchivioNomi.Contains(attore.GetEtichetta)) Then
                ArchivioNomi.Add(attore.GetEtichetta)
            End If
        Next
        For Each musicista In MainForm.FilmPerMusicista
            If (Not musicista.GetEtichetta.StartsWith("[") AndAlso Not ArchivioNomi.Contains(musicista.GetEtichetta)) Then
                ArchivioNomi.Add(musicista.GetEtichetta)
            End If
        Next
        For Each autore In MainForm.FilmPerAutore
            If (Not autore.GetEtichetta.StartsWith("[") AndAlso Not ArchivioNomi.Contains(autore.GetEtichetta)) Then
                ArchivioNomi.Add(autore.GetEtichetta)
            End If
        Next

        ' Mostro elenco
        ListNomiEsistenti.Items.AddRange(ArchivioNomi.ToArray)

        TextNome.Focus()
    End Sub

    Private Sub FiltraNomi() Handles TextNome.KeyPress, TextNome.TextChanged, TextCognome.KeyPress, TextCognome.TextChanged
        If (TextNome.Text.Trim.Length = 0 And TextCognome.Text.Trim.Length = 0) Then
            If (ListNomiEsistenti.Items.Count <> ArchivioNomi.Count) Then ListNomiEsistenti.Items.AddRange(ArchivioNomi.ToArray)
            Exit Sub
        End If

        ListNomiEsistenti.Items.Clear()
        Dim Inserimento As String = TextNome.Text.ToLower + " " + TextCognome.Text.ToLower
        Dim tokens As String() = Inserimento.Split(" ")
        For Each nominativo As String In ArchivioNomi
            Dim CorrispondenzaCompletaTrovata As Boolean = True
            Dim CorrispondenzaInizialeTrovata As Boolean = True
            For Each token As String In tokens
                If (token.Length = 0 Or token.Equals(" ")) Then Continue For
                If (Not nominativo.ToLower.Contains(token)) Then
                    CorrispondenzaCompletaTrovata = False
                    If (Not (nominativo.ToLower.Contains(token.Chars(0) + "."))) Then
                        CorrispondenzaInizialeTrovata = False
                        Exit For
                    End If
                End If
            Next
            If (CorrispondenzaCompletaTrovata) Then
                ListNomiEsistenti.Items.Insert(0, nominativo) 'inserisci in cima
            ElseIf (CorrispondenzaInizialeTrovata) Then
                ListNomiEsistenti.Items.Add(nominativo) 'inserisci in fondo
            End If
        Next
    End Sub

    Private Sub ListNomiEsistenti_Click(sender As Object, e As EventArgs) Handles ListNomiEsistenti.Click
        If (ListNomiEsistenti.SelectedItems.Count > 0) Then
            Dim NomeCognome As String() = MainModule.SeparaNomeCognome(ListNomiEsistenti.SelectedItems.Item(0))
            TextNome.Text = NomeCognome(0)
            TextCognome.Text = NomeCognome(1)
            TextNome.Focus()
        End If
    End Sub

    Private Sub ListNomiEsistenti_DoubleClick(sender As Object, e As EventArgs) Handles ListNomiEsistenti.DoubleClick
        If (ListNomiEsistenti.SelectedItems.Count > 0) Then
            Dim NomeCognome As String() = MainModule.SeparaNomeCognome(ListNomiEsistenti.SelectedItems.Item(0))
            Nome = NomeCognome(0)
            Cognome = NomeCognome(1)
            SoloInizialeNome = CheckSoloIniziale.Checked
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class