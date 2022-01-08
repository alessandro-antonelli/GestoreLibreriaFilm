Public Class ModificaInfo

    Dim Film As Film

    Public Sub InizializzaFinestra(Film As Film)
        Me.Film = Film
        Me.LinkLabel1.Text = Film.TitoloITA + If(Not IsNothing(Film.Anno), " [" + Film.Anno.ToString + "]", "")
        UpDownAnno.Maximum = My.Computer.Clock.LocalTime.Year

        If (MainModule.ModalitaNotte) Then
            Me.BackColor = Color.Black
            Me.ForeColor = Color.White
            LinkLabel1.LinkColor = Color.Yellow
            Dim grigio As Color = Color.FromArgb(255, 32, 32, 32)
            ButtSalva.BackColor = grigio
            Button2.BackColor = grigio
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

        If (Not IsNothing(Film.Registi)) Then
            For Each regista In Film.Registi
                ListRegisti.Items.Add(regista)
            Next
        End If
        If (Not IsNothing(Film.Attori)) Then
            For Each attore In Film.Attori
                ListAttori.Items.Add(attore)
            Next
        End If
        If (Not IsNothing(Film.Generi)) Then
            For Each genere In Film.Generi
                ListGeneri.Items.Add(genere)
            Next
        End If
        If (Not IsNothing(Film.Autori)) Then
            For Each autore In Film.Autori
                ListAutori.Items.Add(autore)
            Next
        End If
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

    Function ControllaSeNomeValido() As Boolean Handles TextTitoloITA.TextChanged, TextTitoloITA.KeyPress, TextTitoloORIG.TextChanged, TextTitoloORIG.KeyPress, TextNote.TextChanged, TextNote.KeyPress, TextNazione.TextChanged, TextNazione.KeyPress
        Dim NomeFile As String = GeneraNome()

        If (Film.NomeFile.Equals(NomeFile)) Then
            NomeNonValido("coincide con quello di partenza!")
            Return False
        End If

        Dim PercorsoFile As String = My.Settings.LibreriaPercorso + "\" + NomeFile
        If (PercorsoFile.Length > 255) Then
            NomeNonValido("nome troppo lungo (sfora di " + (PercorsoFile.Length - 255).ToString + " caratteri)!")
            Return False
        End If

        If (My.Computer.FileSystem.FileExists(PercorsoFile)) Then
            NomeNonValido("esiste un altro file con lo stesso nome!")
            Return False
        End If

        If (NomeFile.EndsWith(" ")) Then
            NomeNonValido("non può terminare con uno spazio!")
            Return False
        End If
        If (NomeFile.EndsWith(".")) Then
            NomeNonValido("non può terminare con un punto!")
            Return False
        End If
        If (NomeFile.Contains("<") OrElse
            NomeFile.Contains(">") OrElse
            NomeFile.Contains(":") OrElse
            NomeFile.Contains("""") OrElse
            NomeFile.Contains("/") OrElse
            NomeFile.Contains("\") OrElse
            NomeFile.Contains("|") OrElse
            NomeFile.Contains("?") OrElse
            NomeFile.Contains("*")) Then
            NomeNonValido("contiene un carattere non consentito!")
            Return False
        End If

        If (TextNazione.Text.Length <> 0 And TextNazione.Text.Length <> 3) Then
            NomeNonValido("il nome della nazione deve essere una sigla di 3 lettere!")
            Return False
        End If

        'Altrimenti...
        NomeValido()
        Return True
    End Function

    Sub NomeNonValido(motivo As String)
        Label6.Text = "Nome file non valido: " + motivo
        ButtSalva.Enabled = False
    End Sub

    Sub NomeValido()
        Label6.Text = ""
        ButtSalva.Enabled = True
    End Sub


    Function GeneraNome() As String
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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If (My.Computer.FileSystem.FileExists(Film.PercorsoFile)) Then Process.Start(Film.PercorsoFile)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim VecchioNome As String = film.NomeFile
        Dim NuovoNome = InputBox("Inserisci il nuovo nome per il file:", "Rinomina file", VecchioNome)
        Dim NuovoPercorso = My.Computer.FileSystem.GetFileInfo(film.PercorsoFile).Directory.FullName + "\" + NuovoNome
        If (NuovoNome = "" Or NuovoNome = VecchioNome) Then Exit Sub
        If (My.Computer.FileSystem.FileExists(NuovoPercorso)) Then
            MessageBox.Show("Impossibile rinominare: esiste già un altro file con questo nome!")
            Exit Sub
        End If

        Try
            'Schermata
            Dim PercorsoSchermataVecchio As String = My.Settings.LibreriaPercorso + "\GestoreLibreriaFilm\" + VecchioNome + "_screen.jpg"
            If (PercorsoSchermataVecchio.Length > 255) Then
                Dim CharInEccesso As UShort = PercorsoSchermataVecchio.Length - 255
                PercorsoSchermataVecchio = My.Settings.LibreriaPercorso + "\GestoreLibreriaFilm\" + VecchioNome.Substring(0, VecchioNome.Length - CharInEccesso) + "_screen.jpg"
            End If
            If (My.Computer.FileSystem.FileExists(PercorsoSchermataVecchio)) Then
                Dim PercorsoSchermataNuovo As String = My.Settings.LibreriaPercorso + "\GestoreLibreriaFilm\" + NuovoNome + "_screen.jpg"
                If (PercorsoSchermataNuovo.Length > 255) Then
                    Dim CharInEccesso As UShort = PercorsoSchermataNuovo.Length - 255
                    PercorsoSchermataNuovo = My.Settings.LibreriaPercorso + "\GestoreLibreriaFilm\" + NuovoNome.Substring(0, NuovoNome.Length - CharInEccesso) + "_screen.jpg"
                End If
                If (My.Computer.FileSystem.FileExists(PercorsoSchermataNuovo)) Then
                    MessageBox.Show("Impossibile rinominare: esiste già un altro file con questo nome!")
                    Exit Sub
                End If

                My.Computer.FileSystem.MoveFile(PercorsoSchermataVecchio, PercorsoSchermataNuovo, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
            End If

            'Info
            Dim PercorsoInfoVecchio As String = My.Settings.LibreriaPercorso + "\GestoreLibreriaFilm\" + VecchioNome + "_info.json"
            If (PercorsoInfoVecchio.Length > 255) Then
                Dim CharInEccesso As UShort = PercorsoInfoVecchio.Length - 255
                PercorsoInfoVecchio = My.Settings.LibreriaPercorso + "\GestoreLibreriaFilm\" + VecchioNome.Substring(0, VecchioNome.Length - CharInEccesso) + "_info.json"
            End If
            If (My.Computer.FileSystem.FileExists(PercorsoInfoVecchio)) Then
                Dim PercorsoInfoNuovo As String = My.Settings.LibreriaPercorso + "\GestoreLibreriaFilm\" + NuovoNome + "_info.json"
                If (PercorsoInfoNuovo.Length > 255) Then
                    Dim CharInEccesso As UShort = PercorsoInfoNuovo.Length - 255
                    PercorsoInfoNuovo = My.Settings.LibreriaPercorso + "\GestoreLibreriaFilm\" + NuovoNome.Substring(0, NuovoNome.Length - CharInEccesso) + "_info.json"
                End If
                If (My.Computer.FileSystem.FileExists(PercorsoInfoNuovo)) Then
                    MessageBox.Show("Impossibile rinominare: esiste già un altro file con questo nome!")
                    Exit Sub
                End If

                My.Computer.FileSystem.MoveFile(PercorsoInfoVecchio, PercorsoInfoNuovo, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
            End If

            'Film
            My.Computer.FileSystem.MoveFile(Film.PercorsoFile, NuovoPercorso, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Impossibile rinominare il file: " + e.ToString)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckAnnoVuoto.CheckedChanged
        UpDownAnno.Enabled = Not CheckAnnoVuoto.Checked
        ControllaSeNomeValido()
    End Sub

    Private Sub ButtSalva_Click(sender As Object, e As EventArgs) Handles ButtSalva.Click
        If (ControllaSeNomeValido()) Then
            Dim NuovoNomeFile As String = GeneraNome()
            Dim NuovoPercorsoFile As String = My.Settings.LibreriaPercorso + "\" + NuovoNomeFile

            If (MessageBox.Show("Il file:" + Chr(10) + Chr(10) + Film.NomeFile + Chr(10) + Chr(10) + "sarà rinominato in:" + Chr(10) + Chr(10) + NuovoNomeFile, "Confermi rinomina?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) <> Windows.Forms.DialogResult.Yes) Then
                Exit Sub
            End If

            Try
                'Schermata
                Dim PercorsoSchermataVecchio As String = My.Settings.LibreriaPercorso + "\GestoreLibreriaFilm\" + Film.NomeFile + "_screen.jpg"
                If (PercorsoSchermataVecchio.Length > 255) Then
                    Dim CharInEccesso As UShort = PercorsoSchermataVecchio.Length - 255
                    PercorsoSchermataVecchio = My.Settings.LibreriaPercorso + "\GestoreLibreriaFilm\" + Film.NomeFile.Substring(0, Film.NomeFile.Length - CharInEccesso) + "_screen.jpg"
                End If
                If (My.Computer.FileSystem.FileExists(PercorsoSchermataVecchio)) Then
                    Dim PercorsoSchermataNuovo As String = My.Settings.LibreriaPercorso + "\GestoreLibreriaFilm\" + NuovoNomeFile + "_screen.jpg"
                    If (PercorsoSchermataNuovo.Length > 255) Then
                        Dim CharInEccesso As UShort = PercorsoSchermataNuovo.Length - 255
                        PercorsoSchermataNuovo = My.Settings.LibreriaPercorso + "\GestoreLibreriaFilm\" + NuovoNomeFile.Substring(0, NuovoNomeFile.Length - CharInEccesso) + "_screen.jpg"
                    End If
                    If (My.Computer.FileSystem.FileExists(PercorsoSchermataNuovo)) Then
                        MessageBox.Show("Impossibile rinominare la schermata: esiste già un altro file con questo nome!")
                        Exit Sub
                    End If

                    My.Computer.FileSystem.MoveFile(PercorsoSchermataVecchio, PercorsoSchermataNuovo, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
                End If

                'Info
                Dim PercorsoInfoVecchio As String = My.Settings.LibreriaPercorso + "\GestoreLibreriaFilm\" + Film.NomeFile + "_info.json"
                If (PercorsoInfoVecchio.Length > 255) Then
                    Dim CharInEccesso As UShort = PercorsoInfoVecchio.Length - 255
                    PercorsoInfoVecchio = My.Settings.LibreriaPercorso + "\GestoreLibreriaFilm\" + Film.NomeFile.Substring(0, Film.NomeFile.Length - CharInEccesso) + "_info.json"
                End If
                If (My.Computer.FileSystem.FileExists(PercorsoInfoVecchio)) Then
                    Dim PercorsoInfoNuovo As String = My.Settings.LibreriaPercorso + "\GestoreLibreriaFilm\" + NuovoNomeFile + "_info.json"
                    If (PercorsoInfoNuovo.Length > 255) Then
                        Dim CharInEccesso As UShort = PercorsoInfoNuovo.Length - 255
                        PercorsoInfoNuovo = My.Settings.LibreriaPercorso + "\GestoreLibreriaFilm\" + NuovoNomeFile.Substring(0, NuovoNomeFile.Length - CharInEccesso) + "_info.json"
                    End If
                    If (My.Computer.FileSystem.FileExists(PercorsoInfoNuovo)) Then
                        MessageBox.Show("Impossibile rinominare le informazioni multimediali: esiste già un altro file con questo nome!")
                        Exit Sub
                    End If

                    My.Computer.FileSystem.MoveFile(PercorsoInfoVecchio, PercorsoInfoNuovo, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
                End If

                'Film
                My.Computer.FileSystem.RenameFile(Film.PercorsoFile, NuovoNomeFile)

                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Impossibile rinominare: " + e.ToString)
            End Try
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If (ListRegisti.SelectedItems.Count > 0) Then
            If (MessageBox.Show("Vuoi rimuovere """ + ListRegisti.SelectedItem.ToString + """ dalla lista dei registi del film?", "Confermi rimozione?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then
                ListRegisti.Items.RemoveAt(ListRegisti.SelectedIndex)
                ControllaSeNomeValido()
            End If
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If (ListAttori.SelectedItems.Count > 0) Then
            If (MessageBox.Show("Vuoi rimuovere """ + ListAttori.SelectedItem.ToString + """ dalla lista degli attori del film?", "Confermi rimozione?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then
                ListAttori.Items.RemoveAt(ListAttori.SelectedIndex)
                ControllaSeNomeValido()
            End If
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If (ListGeneri.SelectedItems.Count > 0) Then
            If (MessageBox.Show("Vuoi rimuovere """ + ListGeneri.SelectedItem.ToString + """ dalla lista dei generi del film?", "Confermi rimozione?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then
                ListGeneri.Items.RemoveAt(ListGeneri.SelectedIndex)
                ControllaSeNomeValido()
            End If
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If (ListAutori.SelectedItems.Count > 0) Then
            If (MessageBox.Show("Vuoi rimuovere """ + ListAutori.SelectedItem.ToString + """ dalla lista degli autori del film?", "Confermi rimozione?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then
                ListAutori.Items.RemoveAt(ListAutori.SelectedIndex)
                ControllaSeNomeValido()
            End If
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If (ListMusicisti.SelectedItems.Count > 0) Then
            If (MessageBox.Show("Vuoi rimuovere """ + ListMusicisti.SelectedItem.ToString + """ dalla lista dei musicisti del film?", "Confermi rimozione?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then
                ListMusicisti.Items.RemoveAt(ListMusicisti.SelectedIndex)
                ControllaSeNomeValido()
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
            ControllaSeNomeValido()
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If (InserisciNomeCognome.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            If (InserisciNomeCognome.SoloInizialeNome) Then
                ListAttori.Items.Add(InserisciNomeCognome.Nome.Chars(0) + ". " + InserisciNomeCognome.Cognome)
            Else
                ListAttori.Items.Add(InserisciNomeCognome.Nome + " " + InserisciNomeCognome.Cognome)
            End If
            ControllaSeNomeValido()
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
            ControllaSeNomeValido()
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
            ControllaSeNomeValido()
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If (AggiungiGenere.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            ListGeneri.Items.Add(AggiungiGenere.Genere)
            ControllaSeNomeValido()
        End If
    End Sub
End Class
