Public Class ModificaInfo

    Dim Film As Film

    Public Sub InizializzaFinestra(Film As Film)
        Me.Film = Film
        Me.LinkFile.Text = Film.TitoloITA + If(Not IsNothing(Film.Anno), " [" + Film.Anno.ToString + "]", "")
        UpDownAnno.Maximum = My.Computer.Clock.LocalTime.Year

        If (MainModule.ModalitaNotte) Then
            Me.BackColor = Color.Black
            Me.ForeColor = Color.White
            LinkFile.LinkColor = Color.Yellow
            Dim grigio As Color = Color.FromArgb(255, 32, 32, 32)
            ButtSalva.BackColor = grigio
            ButtRinominaManuale.BackColor = grigio
            Button13.BackColor = grigio
            Button14.BackColor = grigio
            Button15.BackColor = grigio
            Button16.BackColor = grigio
            Button17.BackColor = grigio
            Button18.BackColor = grigio
            Button19.BackColor = grigio
            Button20.BackColor = grigio
            Button21.BackColor = grigio
            Button22.BackColor = grigio

            TextTitoloITA.BackColor = grigio
            TextTitoloORIG.BackColor = grigio
            TextNote.BackColor = grigio
            TextNazione.BackColor = grigio
            UpDownAnno.BackColor = grigio
            ListAttori.BackColor = grigio
            ListAutori.BackColor = grigio
            ListRegisti.BackColor = grigio
            ListGeneri.BackColor = grigio
            ListMusicisti.BackColor = grigio

            TextTitoloITA.ForeColor = Color.White
            TextTitoloORIG.ForeColor = Color.White
            TextNote.ForeColor = Color.White
            TextNazione.ForeColor = Color.White
            UpDownAnno.ForeColor = Color.White
            ListAttori.ForeColor = Color.White
            ListAutori.ForeColor = Color.White
            ListRegisti.ForeColor = Color.White
            ListGeneri.ForeColor = Color.White
            ListMusicisti.ForeColor = Color.White
        End If

        TextTitoloITA.Text = Film.TitoloITA
        If (Not IsNothing(Film.TitoloORIG)) Then TextTitoloORIG.Text = Film.TitoloORIG
        If (Not IsNothing(Film.Anno) AndAlso Film.Anno >= UpDownAnno.Minimum AndAlso Film.Anno <= UpDownAnno.Maximum) Then UpDownAnno.Value = Film.Anno
        If (Not IsNothing(Film.Nazione)) Then TextNazione.Text = Film.Nazione
        If (Not IsNothing(Film.Note)) Then TextNote.Text = Film.Note

        ListRegisti.Items.Clear()
        If (Not IsNothing(Film.Registi)) Then
            For Each regista In Film.Registi
                ListRegisti.Items.Add(regista)
            Next
        End If
        ListAttori.Items.Clear()
        If (Not IsNothing(Film.Attori)) Then
            For Each attore In Film.Attori
                ListAttori.Items.Add(attore)
            Next
        End If
        ListGeneri.Items.Clear()
        If (Not IsNothing(Film.Generi)) Then
            For Each genere In Film.Generi
                ListGeneri.Items.Add(genere)
            Next
        End If
        ListAutori.Items.Clear()
        If (Not IsNothing(Film.Autori)) Then
            For Each autore In Film.Autori
                ListAutori.Items.Add(autore)
            Next
        End If
        ListMusicisti.Items.Clear()
        If (Not IsNothing(Film.Musicisti)) Then
            For Each musicista In Film.Musicisti
                ListMusicisti.Items.Add(musicista)
            Next
        End If

        For Each nazione In MainForm.FilmPerNazione
            If (nazione.GetEtichetta.StartsWith("[")) Then Continue For
            TextNazione.Items.Add(nazione.GetEtichetta.ToUpper())
        Next
    End Sub

    Function GeneraNomeDaForm() As String
        Dim Nome As String = ""

        If (CheckAnnoVuoto.Checked = False) Then
            Nome += UpDownAnno.Value.ToString
        End If
        If (TextNazione.Text.Length > 0) Then
            If (Nome.Length > 0) Then Nome += " "
            Nome += TextNazione.Text.ToUpper
        End If
        If (Nome.Length > 0) Then Nome += " - "

        Nome += TextTitoloITA.Text
        If (TextTitoloORIG.Text.Length > 0) Then Nome += " (" + TextTitoloORIG.Text + ")"
        If (TextNote.Text.Length > 0) Then Nome += " {" + TextNote.Text + "}"
        If (ListGeneri.Items.Count > 0) Then
            Nome += " ["
            For Each Genere In ListGeneri.Items
                Nome += Genere + ", "
            Next
            Nome = Nome.Substring(0, Nome.Length - 2) + "]"
        End If
        If (Nome.Length > 0 AndAlso
            (ListRegisti.Items.Count > 0 OrElse
            ListAutori.Items.Count > 0 OrElse
            ListAttori.Items.Count > 0 OrElse
            ListMusicisti.Items.Count > 0 OrElse
            ListAttori.Items.Count > 0)) Then Nome += " - "

        If (ListRegisti.Items.Count > 0) Then
            For Each Regista In ListRegisti.Items
                Nome += Regista + ", "
            Next
            Nome = Nome.Substring(0, Nome.Length - 2)
        End If
        If (ListAutori.Items.Count > 0) Then
            Nome += ", di "
            For Each Autore In ListAutori.Items
                Nome += Autore + ", "
            Next
            Nome = Nome.Substring(0, Nome.Length - 2)
        End If
        If (ListMusicisti.Items.Count > 0) Then
            Nome += ", musica di "
            For Each Musicista In ListMusicisti.Items
                Nome += Musicista + ", "
            Next
            Nome = Nome.Substring(0, Nome.Length - 2)
        End If
        If (ListAttori.Items.Count > 0) Then
            Nome += ", con "
            For Each Attore In ListAttori.Items
                Nome += Attore + ", "
            Next
            Nome = Nome.Substring(0, Nome.Length - 2)
        End If

        Return Nome + "." + Film.Estensione
    End Function

    Function EPossibileRinominare(NuovoNome As String) As String 'restituisce Nothing se è possibile, altrimenti il motivo per cui non è possibile
        Dim VecchioNome As String = Film.NomeFile

        ' File del film
        If (IsNothing(NuovoNome) OrElse NuovoNome.Length = 0) Then Return "il nome inserito è vuoto!"

        If (VecchioNome.Equals(NuovoNome)) Then
            Return "coincide con quello di partenza!"
        End If

        Dim PercorsoFile As String = My.Settings.LibreriaPercorso + "\" + NuovoNome
        If (PercorsoFile.Length > 255) Then
            Return "nome troppo lungo (sfora di " + (PercorsoFile.Length - 255).ToString + " caratteri)!"
        End If

        If (My.Computer.FileSystem.FileExists(PercorsoFile)) Then
            Return "esiste un altro file con lo stesso nome!"
        End If

        If (NuovoNome.EndsWith(" ")) Then
            Return "non può terminare con uno spazio!"
        End If
        If (NuovoNome.EndsWith(".")) Then
            Return "non può terminare con un punto!"
        End If
        If (NuovoNome.Contains("<") OrElse
            NuovoNome.Contains(">") OrElse
            NuovoNome.Contains(":") OrElse
            NuovoNome.Contains("""") OrElse
            NuovoNome.Contains("/") OrElse
            NuovoNome.Contains("\") OrElse
            NuovoNome.Contains("|") OrElse
            NuovoNome.Contains("?") OrElse
            NuovoNome.Contains("*")) Then
            Return "contiene un carattere non consentito!"
        End If

        If (TextNazione.Text.Length <> 0 And TextNazione.Text.Length <> 3) Then
            Return "il nome della nazione deve essere una sigla di 3 lettere!"
        End If

        'File della Schermata
        Dim PercorsoSchermataVecchio As String = MainModule.PercorsoSchermataFilm(VecchioNome)
        If (My.Computer.FileSystem.FileExists(PercorsoSchermataVecchio)) Then
            Dim PercorsoSchermataNuovo As String = MainModule.PercorsoSchermataFilm(NuovoNome)
            If (My.Computer.FileSystem.FileExists(PercorsoSchermataNuovo)) Then
                Return "esiste già un'altra schermata con questo nome!"
            End If
        End If

        'File del Poster
        Dim PercorsoPosterVecchio As String = MainModule.PercorsoPosterFilm(VecchioNome)
        If (My.Computer.FileSystem.FileExists(PercorsoPosterVecchio)) Then
            Dim PercorsoPosterNuovo As String = MainModule.PercorsoPosterFilm(NuovoNome)
            If (My.Computer.FileSystem.FileExists(PercorsoPosterNuovo)) Then
                Return "esiste già un altro poster con questo nome!"
            End If
        End If

        'File della Trama lunga
        Dim PercorsoTramaVecchio As String = MainModule.PercorsoTramaLunga(VecchioNome)
        If (My.Computer.FileSystem.FileExists(PercorsoTramaVecchio)) Then
            Dim PercorsoTramaNuovo As String = MainModule.PercorsoTramaLunga(NuovoNome)
            If (My.Computer.FileSystem.FileExists(PercorsoTramaNuovo)) Then
                Return "esiste già un altro file della trama con questo nome!"
            End If
        End If

        'File JSON delle Info multimediali
        Dim PercorsoInfoFileVecchio As String = MainModule.PercorsoInfoFile(VecchioNome)
        If (My.Computer.FileSystem.FileExists(PercorsoInfoFileVecchio)) Then
            Dim PercorsoInfoNuovo As String = MainModule.PercorsoInfoFile(NuovoNome)
            If (My.Computer.FileSystem.FileExists(PercorsoInfoNuovo)) Then
                Return "esiste già un altro file di informazioni multimediali con questo nome!"
            End If
        End If

        'File JSON delle Info IMDB
        Dim PercorsoFlagNoIMDBFileVecchio As String = MainModule.PercorsoFlagNienteIMDB(VecchioNome)
        If (My.Computer.FileSystem.FileExists(PercorsoFlagNoIMDBFileVecchio)) Then
            Dim PercorsoFlagNoIMDBFileNuovo As String = MainModule.PercorsoFlagNienteIMDB(NuovoNome)
            If (My.Computer.FileSystem.FileExists(PercorsoFlagNoIMDBFileNuovo)) Then
                Return "esiste già un altro file-flag di assenza informazioni IMDB con questo nome!"
            End If
        Else
            Dim PercorsoIMDBFileVecchio As String = MainModule.PercorsoInfoIMDB(VecchioNome)
            If (My.Computer.FileSystem.FileExists(PercorsoIMDBFileVecchio)) Then
                Dim PercorsoIMDBFileNuovo As String = MainModule.PercorsoInfoIMDB(NuovoNome)
                If (My.Computer.FileSystem.FileExists(PercorsoIMDBFileNuovo)) Then
                    Return "esiste già un altro file di informazioni IMDB con questo nome!"
                End If
            End If
        End If

        'Se nessuno dei precedenti controlli ha causato il Return:
        Return Nothing
    End Function

    Sub EseguiRinomina(VecchioNomeFile As String, NuovoNomeFile As String)
        Try
            'Schermata
            Dim PercorsoSchermataVecchio As String = MainModule.PercorsoSchermataFilm(VecchioNomeFile)
            If (My.Computer.FileSystem.FileExists(PercorsoSchermataVecchio)) Then
                Dim PercorsoSchermataNuovo As String = MainModule.PercorsoSchermataFilm(NuovoNomeFile)
                My.Computer.FileSystem.MoveFile(PercorsoSchermataVecchio, PercorsoSchermataNuovo, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
            End If

            'Poster
            Dim PercorsoPosterVecchio As String = MainModule.PercorsoPosterFilm(VecchioNomeFile)
            If (My.Computer.FileSystem.FileExists(PercorsoPosterVecchio)) Then
                Dim PercorsoPosterNuovo As String = MainModule.PercorsoPosterFilm(NuovoNomeFile)
                My.Computer.FileSystem.MoveFile(PercorsoPosterVecchio, PercorsoPosterNuovo, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
            End If

            'Trama lunga
            Dim PercorsoTramaVecchio As String = MainModule.PercorsoTramaLunga(VecchioNomeFile)
            If (My.Computer.FileSystem.FileExists(PercorsoTramaVecchio)) Then
                Dim PercorsoTramaNuovo As String = MainModule.PercorsoTramaLunga(NuovoNomeFile)
                My.Computer.FileSystem.MoveFile(PercorsoTramaVecchio, PercorsoTramaNuovo, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
            End If

            'Info file
            Dim PercorsoInfoFileVecchio As String = MainModule.PercorsoInfoFile(VecchioNomeFile)
            If (My.Computer.FileSystem.FileExists(PercorsoInfoFileVecchio)) Then
                Dim PercorsoInfoNuovo As String = MainModule.PercorsoInfoFile(NuovoNomeFile)
                My.Computer.FileSystem.MoveFile(PercorsoInfoFileVecchio, PercorsoInfoNuovo, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
            End If

            'Info IMDB
            Dim PercorsoFlagNoIMDBFileVecchio As String = MainModule.PercorsoFlagNienteIMDB(VecchioNomeFile)
            If (My.Computer.FileSystem.FileExists(PercorsoFlagNoIMDBFileVecchio)) Then
                Dim PercorsoFlagNoIMDBFileNuovo As String = MainModule.PercorsoFlagNienteIMDB(NuovoNomeFile)
                My.Computer.FileSystem.MoveFile(PercorsoFlagNoIMDBFileVecchio, PercorsoFlagNoIMDBFileNuovo, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
            Else
                Dim PercorsoIMDBFileVecchio As String = MainModule.PercorsoInfoIMDB(VecchioNomeFile)
                If (My.Computer.FileSystem.FileExists(PercorsoIMDBFileVecchio)) Then
                    Dim PercorsoIMDBFileNuovo As String = MainModule.PercorsoInfoIMDB(NuovoNomeFile)
                    My.Computer.FileSystem.MoveFile(PercorsoIMDBFileVecchio, PercorsoIMDBFileNuovo, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
                End If
            End If

            'Film
            My.Computer.FileSystem.RenameFile(My.Settings.LibreriaPercorso + "\" + VecchioNomeFile, NuovoNomeFile)
        Catch ex As Exception
            MessageBox.Show("Impossibile rinominare: " + ex.ToString)
        End Try
    End Sub

    Function ControllaSeValoriFormValidi() As Boolean Handles TextTitoloITA.TextChanged, TextTitoloITA.KeyPress, TextTitoloORIG.TextChanged, TextTitoloORIG.KeyPress, TextNote.TextChanged, TextNote.KeyPress, TextNazione.TextChanged, TextNazione.KeyPress
        Dim OstacoliAllaRinomina As String = EPossibileRinominare(GeneraNomeDaForm())

        If (IsNothing(OstacoliAllaRinomina)) Then
            Label6.Text = ""
            ButtSalva.Enabled = True
            Return True
        Else
            Label6.Text = "Nome file non valido: " + OstacoliAllaRinomina
            ButtSalva.Enabled = False
            Return False
        End If
    End Function

    Private Sub ButtSalva_Click(sender As Object, e As EventArgs) Handles ButtSalva.Click
        If (ControllaSeValoriFormValidi()) Then
            Dim NuovoNomeFile As String = GeneraNomeDaForm()

            If (MessageBox.Show("Il file:" + Chr(10) + Chr(10) + Film.NomeFile + Chr(10) + Chr(10) +
                                "sarà rinominato in:" + Chr(10) + Chr(10) + NuovoNomeFile, "Confermi rinomina?",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) <> Windows.Forms.DialogResult.Yes) Then
                Exit Sub
            End If

            EseguiRinomina(Film.NomeFile, NuovoNomeFile)

            Me.Close()
        End If
    End Sub

    Private Sub ButtRinominaManuale_Click(sender As Object, e As EventArgs) Handles ButtRinominaManuale.Click
        Dim NuovoNome = InputBox("Inserisci il nuovo nome per il file:", "Rinomina file", Film.NomeFile)
        If (NuovoNome = "" Or NuovoNome = Film.NomeFile) Then Exit Sub

        Dim OstacoliAllaRinomina As String = EPossibileRinominare(NuovoNome)

        If (IsNothing(OstacoliAllaRinomina)) Then
            EseguiRinomina(Film.NomeFile, NuovoNome)
            Me.Close()
        Else
            MessageBox.Show("Il nome inserito non è valido: " + OstacoliAllaRinomina)
        End If
    End Sub

    Private Sub LinkFile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkFile.LinkClicked
        If (My.Computer.FileSystem.FileExists(Film.PercorsoFile)) Then Process.Start(Film.PercorsoFile)
    End Sub

    Private Sub CheckAnnoVuoto_CheckedChanged(sender As Object, e As EventArgs) Handles CheckAnnoVuoto.CheckedChanged
        UpDownAnno.Enabled = Not CheckAnnoVuoto.Checked
        ControllaSeValoriFormValidi()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If (ListRegisti.SelectedItems.Count > 0) Then
            If (MessageBox.Show("Vuoi rimuovere """ + ListRegisti.SelectedItem.ToString + """ dalla lista dei registi del film?", "Confermi rimozione?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then
                ListRegisti.Items.RemoveAt(ListRegisti.SelectedIndex)
                ControllaSeValoriFormValidi()
            End If
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If (ListAttori.SelectedItems.Count > 0) Then
            If (MessageBox.Show("Vuoi rimuovere """ + ListAttori.SelectedItem.ToString + """ dalla lista degli attori del film?", "Confermi rimozione?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then
                ListAttori.Items.RemoveAt(ListAttori.SelectedIndex)
                ControllaSeValoriFormValidi()
            End If
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If (ListGeneri.SelectedItems.Count > 0) Then
            If (MessageBox.Show("Vuoi rimuovere """ + ListGeneri.SelectedItem.ToString + """ dalla lista dei generi del film?", "Confermi rimozione?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then
                ListGeneri.Items.RemoveAt(ListGeneri.SelectedIndex)
                ControllaSeValoriFormValidi()
            End If
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If (ListAutori.SelectedItems.Count > 0) Then
            If (MessageBox.Show("Vuoi rimuovere """ + ListAutori.SelectedItem.ToString + """ dalla lista degli autori del film?", "Confermi rimozione?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then
                ListAutori.Items.RemoveAt(ListAutori.SelectedIndex)
                ControllaSeValoriFormValidi()
            End If
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If (ListMusicisti.SelectedItems.Count > 0) Then
            If (MessageBox.Show("Vuoi rimuovere """ + ListMusicisti.SelectedItem.ToString + """ dalla lista dei musicisti del film?", "Confermi rimozione?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then
                ListMusicisti.Items.RemoveAt(ListMusicisti.SelectedIndex)
                ControllaSeValoriFormValidi()
            End If
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        InserisciNomeCognome.ImpostaNomeCompletoComeDefault()
        If (InserisciNomeCognome.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            If (InserisciNomeCognome.SoloInizialeNome) Then
                ListRegisti.Items.Add(InserisciNomeCognome.Nome.Chars(0) + ". " + InserisciNomeCognome.Cognome)
            Else
                ListRegisti.Items.Add(InserisciNomeCognome.Nome + " " + InserisciNomeCognome.Cognome)
            End If
            ControllaSeValoriFormValidi()
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If (InserisciNomeCognome.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            If (InserisciNomeCognome.SoloInizialeNome) Then
                ListAttori.Items.Add(InserisciNomeCognome.Nome.Chars(0) + ". " + InserisciNomeCognome.Cognome)
            Else
                ListAttori.Items.Add(InserisciNomeCognome.Nome + " " + InserisciNomeCognome.Cognome)
            End If
            ControllaSeValoriFormValidi()
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        InserisciNomeCognome.ImpostaNomeCompletoComeDefault()
        If (InserisciNomeCognome.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            If (InserisciNomeCognome.SoloInizialeNome) Then
                ListAutori.Items.Add(InserisciNomeCognome.Nome.Chars(0) + ". " + InserisciNomeCognome.Cognome)
            Else
                ListAutori.Items.Add(InserisciNomeCognome.Nome + " " + InserisciNomeCognome.Cognome)
            End If
            ControllaSeValoriFormValidi()
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        InserisciNomeCognome.ImpostaNomeCompletoComeDefault()
        If (InserisciNomeCognome.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            If (InserisciNomeCognome.SoloInizialeNome) Then
                ListMusicisti.Items.Add(InserisciNomeCognome.Nome.Chars(0) + ". " + InserisciNomeCognome.Cognome)
            Else
                ListMusicisti.Items.Add(InserisciNomeCognome.Nome + " " + InserisciNomeCognome.Cognome)
            End If
            ControllaSeValoriFormValidi()
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If (AggiungiGenere.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            ListGeneri.Items.Add(AggiungiGenere.Genere)
            ControllaSeValoriFormValidi()
        End If
    End Sub
End Class
