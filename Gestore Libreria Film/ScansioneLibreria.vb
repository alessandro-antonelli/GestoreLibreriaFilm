Imports System.IO
Imports System.Security.Cryptography
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ScansioneLibreria
    Public PercorsiFile As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
    Dim ListaFilmSenzaIdIMDB As New List(Of Film)

    Private Sub ScansioneLibreria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (MainModule.ModalitaNotte = True) Then
            Me.BackColor = Color.Black
            Me.ForeColor = Color.White
            ButtInterrompi.BackColor = Color.FromArgb(255, 32, 32, 32)
        End If

        ListaFilmSenzaIdIMDB.Clear()
        LabPercentuale.Text = "0%"
        LabNumFileElaborati.Text = "0"
        LabNumFileTotali.Text = "su " + PercorsiFile.Count.ToString
        ProgressBar.Value = 0
        ProgressBar.Maximum = PercorsiFile.Count
        LabAttività.Text = "Lettura nome e attributi"
        LabNomeFile.Text = My.Computer.FileSystem.GetFileInfo(PercorsiFile.Item(0)).Name
    End Sub

    Private Sub ScansioneLibreria_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        BackgroundWorker.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork
        EseguiScansione(PercorsiFile)
    End Sub

    Private Sub BackgroundWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker.ProgressChanged
        LabNumFileElaborati.Text = e.ProgressPercentage.ToString
        ProgressBar.Value = e.ProgressPercentage
        LabPercentuale.Text = Math.Floor(ProgressBar.Value / ProgressBar.Maximum * 100).ToString + "%"

        Dim Argomenti As Object() = e.UserState
        'Campi di UserState:
        'String - descrizione attività in corso
        'String - nome del file attualmente in elaborazione
        'Film - elaborato da aggiungere alla libreria
        'Booleano - indica se l'IdIMDB manca (ed è da chiedere all'utente)

        If (IsNothing(Argomenti) OrElse Argomenti.Length < 2) Then
            LabAttività.Text = ""
            If (e.ProgressPercentage < PercorsiFile.Count) Then
                LabNomeFile.Text = My.Computer.FileSystem.GetFileInfo(PercorsiFile.Item(e.ProgressPercentage)).Name
            Else
                LabNomeFile.Text = ""
            End If
        Else
            If (Argomenti.Length >= 2) Then
                If (Not IsNothing(Argomenti(0))) Then LabAttività.Text = Argomenti(0).ToString
                If (Not IsNothing(Argomenti(1))) Then LabNomeFile.Text = Argomenti(1).ToString
            End If
            If (Argomenti.Length >= 4) Then
                Dim Film As Film = Argomenti(2)
                Dim IdIMDBmancante As Boolean = Argomenti(3)

                If (Not IsNothing(Film)) Then
                    MainForm.AggiungiFilm(Film)
                    If (IdIMDBmancante) Then
                        ListaFilmSenzaIdIMDB.Add(Film)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BackgroundWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted
        If (ListaFilmSenzaIdIMDB.Count > 0 And Not BackgroundWorker.CancellationPending) Then
            LabAttività.Text = "Inserimento manuale dei codici IMDB non trovati automaticamente"
            LabPercentuale.Text = "0%"
            LabNumFileElaborati.Text = "0"
            LabNumFileTotali.Text = "su " + ListaFilmSenzaIdIMDB.Count.ToString
            ProgressBar.Value = 0
            ProgressBar.Maximum = ListaFilmSenzaIdIMDB.Count

            For Each Film In ListaFilmSenzaIdIMDB
                LabNomeFile.Text = Film.NomeFile
                IndividuaIMDB.CaricaInfoFilm(Film)
                If (IndividuaIMDB.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                    If (Not IsNothing(IndividuaIMDB.IdIMDB)) Then
                        MainModule.ScaricaDatiIMDB(IndividuaIMDB.IdIMDB, Film.NomeFile)
                        'TODO
                        'Film = ParsingJSONIMDB(Film, PercorsoInfoIMDB)
                    End If
                End If

                ProgressBar.Value += 1
                LabNumFileElaborati.Text = ProgressBar.Value.ToString
                LabPercentuale.Text = Math.Floor(ProgressBar.Value / ProgressBar.Maximum * 100).ToString + "%"
            Next
        End If

        LabAttività.Text = "Scansione completa"
        LabNomeFile.Text = ""
        MainForm.AggiornaAlberoCategorie()
        Me.Close()
    End Sub

    Private Sub EseguiScansione(PercorsiFile As System.Collections.ObjectModel.ReadOnlyCollection(Of String))
        If (IsNothing(PercorsiFile) Or PercorsiFile.Count <= 0 Or Not My.Computer.FileSystem.DirectoryExists(My.Settings.LibreriaPercorso)) Then Return
        BackgroundWorker.ReportProgress(0, {"Inizializzazione...", ""})

        Dim CartellaDatiLibreria As String = MainModule.PercorsoDatiLibreria()

        Dim ListaFileAccessori As New List(Of String)
        ListaFileAccessori.AddRange(My.Computer.FileSystem.GetFiles(CartellaDatiLibreria, FileIO.SearchOption.SearchTopLevelOnly))

        Dim Film As Film

        Dim i, tot As Integer
        i = 0
        tot = PercorsiFile.Count

        For Each PercorsoFile In PercorsiFile
            If (BackgroundWorker.CancellationPending = True) Then Exit For

            Dim NomeFile As String = My.Computer.FileSystem.GetFileInfo(PercorsoFile).Name
            BackgroundWorker.ReportProgress(i, {"Lettura nome e attributi", NomeFile})

            Select Case My.Computer.FileSystem.GetFileInfo(PercorsoFile).Extension.ToLower
                Case ".db", ".ini", ".nfo", ".txt", ".jpg", ".jpeg", ".png", ".bmp", ".rar", ".zip", ".doc", ".docx", ".sub", ".idx", ".srt", ".mp3", ".ac3", ".ogg", ".flac", ".cue", ".lnk"
                    'Do nothing and Continue For

                    i += 1
                    BackgroundWorker.ReportProgress(i)
                Case Else
                    Dim IdIMDBmancante As Boolean = False
                    Film = ParsingNomeFile(NomeFile, PercorsoFile)
                    'Dim HashMD5 As String = md5(PercorsoFile)
                    'Film.HashMD5 = HashMD5

                    Dim PercorsoInfoFile As String = MainModule.PercorsoInfoFile(NomeFile)
                    If (My.Computer.FileSystem.FileExists(PercorsoInfoFile)) Then
                        BackgroundWorker.ReportProgress(i, {"Lettura report sulla codifica", NomeFile})
                        Film = ParsingJSONInfo(Film, PercorsoInfoFile)
                        ListaFileAccessori.Remove(PercorsoInfoFile)
                    Else
                        BackgroundWorker.ReportProgress(i, {"Generazione report sulla codifica", NomeFile})
                        RegistraInfo(PercorsoFile, PercorsoInfoFile)
                        BackgroundWorker.ReportProgress(i, {"Lettura report sulla codifica", NomeFile})
                        If (My.Computer.FileSystem.FileExists(PercorsoInfoFile)) Then Film = ParsingJSONInfo(Film, PercorsoInfoFile)
                    End If

                    Dim PercorsoSchermata As String = MainModule.PercorsoSchermataFilm(NomeFile)
                    If (My.Computer.FileSystem.FileExists(PercorsoSchermata)) Then
                        ListaFileAccessori.Remove(PercorsoSchermata)
                    Else
                        BackgroundWorker.ReportProgress(i, {"Acquisizione schermata", NomeFile})
                        CatturaSchermata(PercorsoFile, PercorsoSchermata)
                    End If

                    Dim PercorsoFlagNoIMDB As String = MainModule.PercorsoFlagNienteIMDB(NomeFile)
                    If (My.Computer.FileSystem.FileExists(PercorsoFlagNoIMDB)) Then
                        ListaFileAccessori.Remove(PercorsoFlagNoIMDB)
                    Else
                        Dim PercorsoInfoIMDB As String = MainModule.PercorsoInfoIMDB(NomeFile)
                        If (My.Computer.FileSystem.FileExists(PercorsoInfoIMDB)) Then
                            BackgroundWorker.ReportProgress(i, {"Lettura informazioni di IMDB", NomeFile})
                            Film = ParsingJSONIMDB(Film, PercorsoInfoIMDB)
                            ListaFileAccessori.Remove(PercorsoInfoIMDB)
                        Else
                            If (My.Computer.Network.IsAvailable) Then
                                BackgroundWorker.ReportProgress(i, {"Individuazione codice IMDB", NomeFile})
                                Dim IdIMDB As String = TrovaIDimdbAutomatico(Film)
                                If (Not IsNothing(IdIMDB)) Then
                                    BackgroundWorker.ReportProgress(i, {"Download informazioni da IMDB", NomeFile})
                                    MainModule.ScaricaDatiIMDB(IdIMDB, Film.NomeFile)
                                    BackgroundWorker.ReportProgress(i, {"Lettura informazioni di IMDB", NomeFile})
                                    If (My.Computer.FileSystem.FileExists(PercorsoInfoIMDB)) Then Film = ParsingJSONIMDB(Film, PercorsoInfoIMDB)
                                Else
                                    IdIMDBmancante = True
                                End If
                            End If
                        End If
                    End If

                    Dim PercorsoTramaLunga As String = MainModule.PercorsoTramaLunga(NomeFile)
                    If (My.Computer.FileSystem.FileExists(PercorsoTramaLunga)) Then
                        Dim LettoreFile As New IO.StreamReader(PercorsoTramaLunga)
                        Film.TramaLunga = LettoreFile.ReadToEnd
                        LettoreFile.Close()

                        ListaFileAccessori.Remove(PercorsoTramaLunga)
                    End If

                    Dim PercorsoPoster As String = MainModule.PercorsoPosterFilm(NomeFile)
                    If (My.Computer.FileSystem.FileExists(PercorsoPoster)) Then
                        ListaFileAccessori.Remove(PercorsoPoster)
                    End If

                    i += 1
                    BackgroundWorker.ReportProgress(i, {Nothing, Nothing, Film, IdIMDBmancante})
                    'Campi di UserState:
                    'String - descrizione attività in corso
                    'String - nome del file attualmente in elaborazione
                    'Film - elaborato da aggiungere alla libreria
                    'Booleano - indica se l'IdIMDB manca (ed è da chiedere all'utente)
            End Select
        Next

        BackgroundWorker.ReportProgress(i, {"Finalizzazione...", ""})

        ' Rimuovo dalla CartellaDatiLibreria i file che non corrispondono ad alcun film della libreria
        ' (schermate e info relative a film cancellati/rinominati manualmente)
        If (Not BackgroundWorker.CancellationPending) Then
            For Each File In ListaFileAccessori
                My.Computer.FileSystem.DeleteFile(File, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
            Next
        End If
    End Sub

    Function ParsingJSONIMDB(Film As Film, PercorsoInfo As String) As Film
        Try
            Dim ReaderIMDB As New System.IO.StreamReader(PercorsoInfo)
            Dim json As JObject = JObject.Parse(ReaderIMDB.ReadToEnd)
            ReaderIMDB.Close()

            'Trama breve
            If (json.ContainsKey("Plot")) Then
                Dim TramaBreve As String = json.SelectToken("Plot").Value(Of String)()
                If (Not TramaBreve.ToUpper.Equals("N/A")) Then
                    Film.TramaBreve = TramaBreve
                End If
            End If

            'Incassi
            If (json.ContainsKey("BoxOffice")) Then
                Dim StrIncassi As String = json.SelectToken("BoxOffice").Value(Of String)()
                If (Not StrIncassi.ToUpper.Equals("N/A")) Then
                    StrIncassi = StrIncassi.Replace("$", "")
                    While (StrIncassi.Contains(","))
                        StrIncassi = StrIncassi.Replace(",", "")
                    End While
                    Film.IncassoDollari = UInteger.Parse(StrIncassi)
                End If
            End If

            'Rating IMDB
            If (json.ContainsKey("imdbRating")) Then
                Dim StrVotoIMDB As String = json.SelectToken("imdbRating").Value(Of String)()
                StrVotoIMDB = StrVotoIMDB.Trim
                If (StrVotoIMDB.Length = 3 AndAlso StrVotoIMDB.Chars(1) = Chr(46)) Then 'Chr(46) = punto (.)
                    Dim VotoIMDB As Double = Short.Parse(StrVotoIMDB.Chars(0)) + (Integer.Parse(StrVotoIMDB.Chars(2)) / 10)
                    Film.VotoIMDB = VotoIMDB
                End If
            End If

            'Numero voti IMDB
            If (json.ContainsKey("imdbVotes")) Then
                Dim StrNumVotiIMDB As String = json.SelectToken("imdbVotes").Value(Of String)()
                If (Not StrNumVotiIMDB.ToUpper.Equals("N/A")) Then
                    While (StrNumVotiIMDB.Contains(","))
                        StrNumVotiIMDB = StrNumVotiIMDB.Replace(",", "")
                    End While
                    Film.NumVotiIMDB = UInteger.Parse(StrNumVotiIMDB)
                End If
            End If

            'Metacritic
            If (json.ContainsKey("Metascore")) Then
                Dim StrMetascore As String = json.SelectToken("Metascore").Value(Of String)()
                If (Not StrMetascore.ToUpper.Equals("N/A")) Then
                    Film.VotoMetacritic = UShort.Parse(StrMetascore)
                End If
            End If

            'Rotten Tomatoes
            If (json.ContainsKey("Ratings")) Then
                Dim ArrayValutazioni As JArray = json.SelectToken("Ratings")
                If (Not IsNothing(ArrayValutazioni) AndAlso ArrayValutazioni.Count > 0) Then
                    For i As UShort = 0 To ArrayValutazioni.Count - 1
                        Dim Valutazione As JObject = ArrayValutazioni.Item(i)
                        If (Valutazione.ContainsKey("Source") And Valutazione.ContainsKey("Value")) Then
                            Dim fonte As String = Valutazione.SelectToken("Source").Value(Of String)()
                            Dim StrVoto As String = Valutazione.SelectToken("Value").Value(Of String)()

                            If (fonte.Equals("Rotten Tomatoes")) Then
                                StrVoto = StrVoto.Replace("%", "")
                                Film.VotoRottenTomatoes = UShort.Parse(StrVoto)
                                Exit For
                            End If
                        End If
                    Next
                End If
            End If

            ' =================================== PREMI ================================
            If (json.ContainsKey("Awards")) Then
                Dim StrPremi As String = json.SelectToken("Awards").Value(Of String)()
                If (Not IsNothing(StrPremi) AndAlso StrPremi.Length <> 0 AndAlso Not StrPremi.ToUpper.Equals("N/A")) Then
                    StrPremi = StrPremi.ToLower

                    ' Parsing del premio più rilevante ricevuto
                    If (StrPremi.StartsWith("won") Or StrPremi.StartsWith("nominated for")) Then

                        Dim NomePremio As String, QuantitaPremio As UShort, Vittoria As Boolean

                        If (StrPremi.StartsWith("won")) Then
                            Vittoria = True
                            StrPremi = StrPremi.Substring(4, StrPremi.Length - 4)
                        ElseIf (StrPremi.StartsWith("nominated for")) Then
                            Vittoria = False
                            StrPremi = StrPremi.Substring(14, StrPremi.Length - 14)
                        End If

                        Dim FineNumeroQuantita As UShort = StrPremi.IndexOf(" ")
                        QuantitaPremio = UShort.Parse(StrPremi.Substring(0, FineNumeroQuantita))
                        StrPremi = StrPremi.Substring(FineNumeroQuantita + 1, StrPremi.Length - FineNumeroQuantita - 1)

                        Dim FineNomePremio As UShort
                        If (StrPremi.Contains(".")) Then
                            FineNomePremio = StrPremi.IndexOf(".")
                            NomePremio = StrPremi.Substring(0, FineNomePremio)
                            StrPremi = StrPremi.Substring(FineNomePremio + 2, StrPremi.Length - FineNomePremio - 2)
                        Else
                            'FineNomePremio = indice del primo char che è un numero
                            Dim i As UShort = 0
                            For i = 0 To StrPremi.Length - 1
                                Dim dummy As Byte
                                If (Byte.TryParse(StrPremi.Chars(i), dummy)) Then
                                    FineNomePremio = i
                                    Exit For
                                End If
                            Next

                            NomePremio = StrPremi.Substring(0, FineNomePremio - 1)
                            StrPremi = StrPremi.Substring(FineNomePremio, StrPremi.Length - FineNomePremio)
                        End If

                        Select Case NomePremio
                            Case "oscar", "oscars"
                                If (Vittoria) Then
                                    Film.OscarVinti = QuantitaPremio
                                Else
                                    Film.OscarNominati = QuantitaPremio
                                End If
                            Case "bafta film award", "bafta film"
                                If (Vittoria) Then
                                    Film.BAFTAVinti = QuantitaPremio
                                Else
                                    Film.BAFTANominati = QuantitaPremio
                                End If
                        End Select
                    End If

                    'Parsing degli altri premi ricevuti
                    Dim StrAltreVittorie As String = Nothing, StrAltreNomination As String = Nothing
                    Dim PosDivisoreVitNom As Short = StrPremi.IndexOf("&")

                    If (PosDivisoreVitNom <> -1) Then
                        'la stringa elenca sia vittorie che nomination
                        StrAltreVittorie = StrPremi.Substring(0, PosDivisoreVitNom - 1)
                        StrAltreNomination = StrPremi.Substring(PosDivisoreVitNom + 2, StrPremi.Length - PosDivisoreVitNom - 2)
                    Else
                        'la stringa elenca solo vittorie o solo nomination
                        If (StrPremi.EndsWith("wins") Or StrPremi.EndsWith("wins total")) Then
                            StrAltreVittorie = StrPremi
                        ElseIf (StrPremi.EndsWith("nominations") Or StrPremi.EndsWith("nominations total")) Then
                            StrAltreNomination = StrPremi
                        End If
                    End If

                    If (Not IsNothing(StrAltreVittorie)) Then
                        Dim StrAltriPremiVinti = StrAltreVittorie.Substring(0, StrAltreVittorie.IndexOf(" "))
                        Film.AltriPremiVinti = UShort.Parse(StrAltriPremiVinti)
                    End If
                    If (Not IsNothing(StrAltreNomination)) Then
                        Dim StrAltriPremiNominati = StrAltreNomination.Substring(0, StrAltreNomination.IndexOf(" "))
                        Film.AltriPremiNominati = UShort.Parse(StrAltriPremiNominati)
                    End If

                    ' Sottraggo i premi già conteggiati separatamente (Oscar, BAFTA)
                    Film.AltriPremiVinti = If(Film.AltriPremiVinti > Film.OscarVinti + Film.BAFTAVinti, Film.AltriPremiVinti - Film.OscarVinti - Film.BAFTAVinti, 0)
                    Film.AltriPremiNominati = If(Film.AltriPremiNominati > Film.OscarNominati + Film.BAFTANominati, Film.AltriPremiNominati - Film.OscarNominati - Film.BAFTANominati, 0)
                End If
            End If

        Catch ex As JsonReaderException

        End Try
        Return Film
    End Function

    Function ParsingJSONInfo(Film As Film, PercorsoInfo As String) As Film
        Try
            Dim Reader As New System.IO.StreamReader(PercorsoInfo)
            Dim json As JObject = JObject.Parse(Reader.ReadToEnd)
            Reader.Close()

            Dim DurataSecondi As Double = json.SelectToken("format").SelectToken("duration").Value(Of Double)()
            Film.DurataSecondi = DurataSecondi
            Film.DurataMinuti = Math.Round(DurataSecondi / 60)

            Dim BitrateComplessivo As Integer = json.SelectToken("format").SelectToken("bit_rate").Value(Of Integer)() 'BIT (non byte) al secondo
            Film.BitrateComplessivoKBpS = Math.Round(BitrateComplessivo / 1000)

            Film.Contenitore = json.SelectToken("format").SelectToken("format_long_name").Value(Of String)()

            Dim StreamsArray As JArray = json.SelectToken("streams")
            For i As UShort = 0 To StreamsArray.Count - 1
                If (BackgroundWorker.CancellationPending) Then Exit For

                Dim Stream As JObject = StreamsArray.Item(i)
                Dim tipo As String = Stream.SelectToken("codec_type").Value(Of String)()

                If (tipo.Equals("video")) Then

                    If (Stream.ContainsKey("disposition")) Then
                        Dim disposizione As JObject = Stream.SelectToken("disposition")
                        If (disposizione.ContainsKey("attached_pic")) Then
                            Dim SiTrattaDiAllegato As Boolean = disposizione.SelectToken("attached_pic").Value(Of Boolean)()
                            If (SiTrattaDiAllegato) Then Continue For
                        End If
                    End If

                    If (Stream.ContainsKey("codec_name")) Then
                        Film.CodecVideoNomeBreve = Stream.SelectToken("codec_name").Value(Of String)()
                    End If
                    If (Stream.ContainsKey("codec_long_name")) Then
                        Film.CodecVideoNomeLungo = Stream.SelectToken("codec_long_name").Value(Of String)()
                    End If
                    If (Stream.ContainsKey("bit_rate")) Then
                        Dim BitrateVideo As Integer = Stream.SelectToken("bit_rate").Value(Of Integer)() 'un audio a 128 kb/s risulta 128000
                        Film.BitrateVideoKBpS = Math.Round(BitrateVideo / 1000)
                    End If

                    If (Stream.ContainsKey("width") And Stream.ContainsKey("height")) Then
                        Film.Risoluzione = New Size(Stream.SelectToken("width").Value(Of UShort)(), Stream.SelectToken("height").Value(Of UShort)())
                    End If
                    If (Stream.ContainsKey("display_aspect_ratio")) Then
                        Film.Proporzioni = Stream.SelectToken("display_aspect_ratio").Value(Of String)()
                    End If

                    If (Stream.ContainsKey("avg_frame_rate")) Then
                        Dim FPS As String = Stream.SelectToken("avg_frame_rate").Value(Of String)() '25/1

                        If (FPS.Contains("/") AndAlso Not FPS.Equals("0/0")) Then
                            Dim Numeratore As Integer = Integer.Parse(FPS.Substring(0, FPS.IndexOf("/")))
                            Dim Denominatore As Integer = Integer.Parse(FPS.Substring(FPS.IndexOf("/") + 1, FPS.Length - FPS.IndexOf("/") - 1))
                            Film.FPS = Numeratore / Denominatore
                        End If
                    End If
                    If (Film.FPS = 0 AndAlso Stream.ContainsKey("r_frame_rate")) Then
                        Dim FPS As String = Stream.SelectToken("r_frame_rate").Value(Of String)() '25/1

                        If (FPS.Contains("/") AndAlso Not FPS.Equals("0/0")) Then
                            Dim Numeratore As Integer = Integer.Parse(FPS.Substring(0, FPS.IndexOf("/")))
                            Dim Denominatore As Integer = Integer.Parse(FPS.Substring(FPS.IndexOf("/") + 1, FPS.Length - FPS.IndexOf("/") - 1))
                            Film.FPS = Numeratore / Denominatore
                        End If
                    End If
                ElseIf (tipo.Equals("audio")) Then
                    Dim Sonoro As New Sonoro

                    If (Stream.ContainsKey("tags")) Then
                        Dim tags As JObject = Stream.SelectToken("tags")
                        If (tags.ContainsKey("language")) Then Sonoro.Lingua = tags.SelectToken("language")
                        If (tags.ContainsKey("title")) Then Sonoro.Nome = tags.SelectToken("title")
                    End If

                    If (Stream.ContainsKey("codec_name")) Then
                        Sonoro.CodecNomeBreve = Stream.SelectToken("codec_name").Value(Of String)()
                    End If
                    If (Stream.ContainsKey("codec_long_name")) Then
                        Sonoro.CodecNomeLungo = Stream.SelectToken("codec_long_name").Value(Of String)()
                    End If
                    If (Stream.ContainsKey("bit_rate")) Then
                        Dim BitrateAudio As Integer = Stream.SelectToken("bit_rate").Value(Of Integer)() 'un audio a 128 kb/s risulta 128000
                        Sonoro.BitrateKBpS = Math.Round(BitrateAudio / 1000)
                    End If

                    If (Stream.ContainsKey("sample_rate")) Then
                        Sonoro.CampionamentoHZ = Stream.SelectToken("sample_rate").Value(Of Integer)() '44100
                    End If
                    If (Stream.ContainsKey("channels")) Then
                        Sonoro.NumCanali = Stream.SelectToken("channels").Value(Of Short)() '2
                    End If
                    If (Stream.ContainsKey("channel_layout")) Then
                        Sonoro.DescrizioneCanali = Stream.SelectToken("channel_layout").Value(Of String)() 'stereo
                    End If

                    If (IsNothing(Film.Sonori)) Then Film.Sonori = New List(Of Sonoro)
                    Film.Sonori.Add(Sonoro)
                ElseIf (tipo.Equals("subtitle")) Then
                    Dim Sottotitolo As New Sottotitolo

                    If (Stream.ContainsKey("codec_name")) Then
                        Sottotitolo.CodecNomeBreve = Stream.SelectToken("codec_name").Value(Of String)()
                    End If
                    If (Stream.ContainsKey("codec_long_name")) Then
                        Sottotitolo.CodecNomeLungo = Stream.SelectToken("codec_long_name").Value(Of String)()
                    End If

                    If (Stream.ContainsKey("tags")) Then
                        Dim tags As JObject = Stream.SelectToken("tags")
                        If (tags.ContainsKey("language")) Then Sottotitolo.Lingua = tags.SelectToken("language")
                        If (tags.ContainsKey("title")) Then Sottotitolo.Nome = tags.SelectToken("title")
                    End If

                    If (IsNothing(Film.Sottotitoli)) Then Film.Sottotitoli = New List(Of Sottotitolo)
                    Film.Sottotitoli.Add(Sottotitolo)
                End If
            Next
        Catch ex As JsonReaderException

        End Try
        Return Film
    End Function

    Sub RegistraInfo(PercorsoVideo As String, PercorsoInfo As String)
        If (PercorsoInfo.Length > 255) Then
            Exit Sub
        End If
        Dim PercorsoEseguibileFFProbe As String = My.Computer.FileSystem.CurrentDirectory + "\ffprobe.exe"
        If (Not My.Computer.FileSystem.FileExists(PercorsoEseguibileFFProbe)) Then
            MessageBox.Show("Impossibile trovare l'eseguibile di FFprobe! Assicurati che sia in: " + PercorsoEseguibileFFProbe)
            Exit Sub
        End If
        If (Not My.Computer.FileSystem.FileExists(PercorsoVideo)) Then
            MessageBox.Show("RegistraInfo: Impossibile trovare il video in " + PercorsoVideo)
            Exit Sub
        End If

        If (My.Computer.FileSystem.FileExists(PercorsoInfo)) Then
            My.Computer.FileSystem.DeleteFile(PercorsoInfo, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        End If

        Dim ffprobe As New Process()
        ffprobe.StartInfo.Arguments = " -v quiet -show_format -show_streams -print_format json """ + PercorsoVideo + """"
        ffprobe.StartInfo.FileName = PercorsoEseguibileFFProbe
        ffprobe.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        ffprobe.StartInfo.CreateNoWindow = True
        ffprobe.StartInfo.UseShellExecute = False
        ffprobe.StartInfo.RedirectStandardOutput = True
        Dim ScrittoreFile As New IO.StreamWriter(PercorsoInfo, False, System.Text.Encoding.Unicode)
        ffprobe.Start()

        ScrittoreFile.Write(ffprobe.StandardOutput.ReadToEnd())

        ffprobe.WaitForExit()
        ScrittoreFile.Close()
        If (ffprobe.ExitCode <> 0) Then
            My.Computer.FileSystem.DeleteFile(PercorsoInfo, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
        End If
    End Sub

    Sub CatturaSchermata(PercorsoVideo As String, PercorsoSchermata As String)
        If (PercorsoSchermata.Length > 255) Then
            Exit Sub
        End If
        Dim PercorsoEseguibileFFMPEG As String = My.Computer.FileSystem.CurrentDirectory + "\ffmpeg.exe"
        If (Not My.Computer.FileSystem.FileExists(PercorsoEseguibileFFMPEG)) Then
            MessageBox.Show("Impossibile trovare l'eseguibile di FFMPG! Assicurati che sia in: " + PercorsoEseguibileFFMPEG)
            Exit Sub
        End If
        If (Not My.Computer.FileSystem.FileExists(PercorsoVideo)) Then
            MessageBox.Show("CatturaSchermata: Impossibile trovare il video in " + PercorsoVideo)
            Exit Sub
        End If

        If (My.Computer.FileSystem.FileExists(PercorsoSchermata)) Then
            My.Computer.FileSystem.DeleteFile(PercorsoSchermata, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        End If

        EseguiCatturaSchermata(PercorsoVideo, PercorsoSchermata, 0, 1, 0, 400, 250)

        If (Not My.Computer.FileSystem.FileExists(PercorsoSchermata) Or My.Computer.FileSystem.GetFileInfo(PercorsoSchermata).Length < 8192) Then
            My.Computer.FileSystem.DeleteFile(PercorsoSchermata, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            EseguiCatturaSchermata(PercorsoVideo, PercorsoSchermata, 0, 1, 30, 400, 250)

            If (Not My.Computer.FileSystem.FileExists(PercorsoSchermata) Or My.Computer.FileSystem.GetFileInfo(PercorsoSchermata).Length < 8192) Then
                My.Computer.FileSystem.DeleteFile(PercorsoSchermata, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
                EseguiCatturaSchermata(PercorsoVideo, PercorsoSchermata, 0, 2, 0, 400, 250)
            End If
        End If
    End Sub

    Public Sub EseguiCatturaSchermata(PercorsoVideo As String, PercorsoSchermata As String, Ore As UShort, Min As UShort, Sec As UShort, Largh As UInteger, Alt As UInteger)
        Try
            Dim PercorsoEseguibileFFMPEG As String = My.Computer.FileSystem.CurrentDirectory + "\ffmpeg.exe"
            Dim ffmpeg As New Process()
            ffmpeg.StartInfo.Arguments = " -accurate_seek -ss " + Ore.ToString + ":" + Min.ToString + ":" + Sec.ToString +
                " -i """ + PercorsoVideo + """ -frames:v 1 -vf ""scale=max(" + Largh.ToString + "\,a*" + Alt.ToString + "):max(" + Alt.ToString +
                "\," + Largh.ToString + "/a),crop=" + Largh.ToString + ":" + Alt.ToString + """ """ + PercorsoSchermata + """"
            ffmpeg.StartInfo.FileName = PercorsoEseguibileFFMPEG
            ffmpeg.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            ffmpeg.Start()

            'ffmpeg.WaitForExit()
            While (Not ffmpeg.HasExited)
                If ((Me.BackgroundWorker.IsBusy AndAlso Me.BackgroundWorker.CancellationPending) Or
                    (ScegliSchermata.BackgroundWorker.IsBusy AndAlso ScegliSchermata.BackgroundWorker.CancellationPending)) Then
                    ffmpeg.StandardInput.Write("q")
                    Exit Sub
                Else
                    Threading.Thread.Sleep(1500)
                End If
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If (Not IsNothing(ex.InnerException)) Then MessageBox.Show(ex.InnerException.Message)
        End Try
    End Sub

    Function md5(ByVal file_name As String)
        Dim hash = System.Security.Cryptography.MD5.Create()
        Dim hashValue() As Byte
        Dim fileStream As FileStream = File.OpenRead(file_name)
        fileStream.Position = 0
        hashValue = hash.ComputeHash(fileStream)
        Dim hash_hex = PrintByteArray(hashValue)
        fileStream.Close()
        Return hash_hex
    End Function

    Public Function PrintByteArray(ByVal array() As Byte)
        Dim hex_value As String = ""
        Dim i As Integer
        For i = 0 To array.Length - 1
            hex_value += array(i).ToString("X2")
        Next i
        Return hex_value.ToLower
    End Function

    Public Function ParsingNomeFile(NomeFileAncoraDaAnalizzare As String, PercorsoFile As String) As Film
        Dim SottostringaInAnalisi As String

        Dim Film As New Film

        Film.PercorsoFile = PercorsoFile
        Film.NomeFile = NomeFileAncoraDaAnalizzare

        ' Estensione
        Film.Estensione = My.Computer.FileSystem.GetFileInfo(PercorsoFile).Extension
        Film.Estensione = Film.Estensione.Substring(1, Film.Estensione.Length - 1)

        Film.DimensioneMB = My.Computer.FileSystem.GetFileInfo(PercorsoFile).Length / 1048576

        NomeFileAncoraDaAnalizzare = NomeFileAncoraDaAnalizzare.Replace(My.Computer.FileSystem.GetFileInfo(PercorsoFile).Extension, "")

        If (Not NomeFileAncoraDaAnalizzare.Contains(" - ")) Then
            Film.TitoloITA = NomeFileAncoraDaAnalizzare
        Else
            ' Data e nazione
            SottostringaInAnalisi = NomeFileAncoraDaAnalizzare.Substring(0, NomeFileAncoraDaAnalizzare.IndexOf("-") - 1)

            SottostringaInAnalisi = SottostringaInAnalisi.Trim
            If (SottostringaInAnalisi.Contains(" ")) Then
                Dim AnnoStr As String = SottostringaInAnalisi.Split(" ")(0).Trim
                Integer.TryParse(AnnoStr, Film.Anno)
                Film.Nazione = SottostringaInAnalisi.Replace(AnnoStr, "").Trim.ToUpper
            Else
                Integer.TryParse(SottostringaInAnalisi, Film.Anno)
            End If

            NomeFileAncoraDaAnalizzare = NomeFileAncoraDaAnalizzare.Substring(NomeFileAncoraDaAnalizzare.IndexOf("-") + 2, NomeFileAncoraDaAnalizzare.Length - NomeFileAncoraDaAnalizzare.IndexOf("-") - 2)

            ' Attori
            If (NomeFileAncoraDaAnalizzare.Contains(" con ")) Then
                Dim InizioAttori = NomeFileAncoraDaAnalizzare.LastIndexOf(" con ", NomeFileAncoraDaAnalizzare.Length - 1, NomeFileAncoraDaAnalizzare.Length, StringComparison.InvariantCultureIgnoreCase)

                SottostringaInAnalisi = NomeFileAncoraDaAnalizzare.Substring(InizioAttori, NomeFileAncoraDaAnalizzare.Length - InizioAttori)
                SottostringaInAnalisi = SottostringaInAnalisi.Replace(", con ", "")
                SottostringaInAnalisi = SottostringaInAnalisi.Replace(" con ", "")
                SottostringaInAnalisi = SottostringaInAnalisi.Replace("con ", "")
                SottostringaInAnalisi = SottostringaInAnalisi.Replace("con", "")
                SottostringaInAnalisi = SottostringaInAnalisi.Replace(", ", ",")

                Film.Attori = New List(Of String)
                Film.Attori.AddRange(SottostringaInAnalisi.Split(","))

                NomeFileAncoraDaAnalizzare = NomeFileAncoraDaAnalizzare.Substring(0, InizioAttori)
                If (NomeFileAncoraDaAnalizzare.EndsWith(",")) Then NomeFileAncoraDaAnalizzare = NomeFileAncoraDaAnalizzare.Substring(0, NomeFileAncoraDaAnalizzare.Length - 1)
            End If

            ' Musicisti
            If (NomeFileAncoraDaAnalizzare.Contains(" musica di ")) Then
                Dim InizioMusicisti = NomeFileAncoraDaAnalizzare.IndexOf(" musica di ", 0, NomeFileAncoraDaAnalizzare.Length, StringComparison.InvariantCultureIgnoreCase)

                SottostringaInAnalisi = NomeFileAncoraDaAnalizzare.Substring(InizioMusicisti, NomeFileAncoraDaAnalizzare.Length - InizioMusicisti)
                SottostringaInAnalisi = SottostringaInAnalisi.Replace(", musica di ", "")
                SottostringaInAnalisi = SottostringaInAnalisi.Replace(" musica di ", "")
                SottostringaInAnalisi = SottostringaInAnalisi.Replace(", ", ",")

                Film.Musicisti = New List(Of String)
                Film.Musicisti.AddRange(SottostringaInAnalisi.Split(","))

                NomeFileAncoraDaAnalizzare = NomeFileAncoraDaAnalizzare.Substring(0, InizioMusicisti)
                If (NomeFileAncoraDaAnalizzare.EndsWith(",")) Then NomeFileAncoraDaAnalizzare = NomeFileAncoraDaAnalizzare.Substring(0, NomeFileAncoraDaAnalizzare.Length - 1)
            End If

            ' Autori
            If (NomeFileAncoraDaAnalizzare.Contains(" di ")) Then
                Dim InizioAutori = NomeFileAncoraDaAnalizzare.LastIndexOf(" di ", NomeFileAncoraDaAnalizzare.Length - 1, NomeFileAncoraDaAnalizzare.Length, StringComparison.InvariantCultureIgnoreCase)

                SottostringaInAnalisi = NomeFileAncoraDaAnalizzare.Substring(InizioAutori, NomeFileAncoraDaAnalizzare.Length - InizioAutori)
                SottostringaInAnalisi = SottostringaInAnalisi.Replace(", di ", "")
                SottostringaInAnalisi = SottostringaInAnalisi.Replace(" di ", "")
                SottostringaInAnalisi = SottostringaInAnalisi.Replace("di ", "")
                SottostringaInAnalisi = SottostringaInAnalisi.Replace(", ", ",")

                If (Not SottostringaInAnalisi.Contains(" - ")) Then
                    Film.Autori = New List(Of String)
                    Film.Autori.AddRange(SottostringaInAnalisi.Split(","))

                    NomeFileAncoraDaAnalizzare = NomeFileAncoraDaAnalizzare.Substring(0, InizioAutori)
                    If (NomeFileAncoraDaAnalizzare.EndsWith(",")) Then NomeFileAncoraDaAnalizzare = NomeFileAncoraDaAnalizzare.Substring(0, NomeFileAncoraDaAnalizzare.Length - 1)
                End If
            End If

            ' Registi
            If (NomeFileAncoraDaAnalizzare.Contains(" - ")) Then
                Dim InizioRegisti = NomeFileAncoraDaAnalizzare.LastIndexOf(" - ", NomeFileAncoraDaAnalizzare.Length - 1, NomeFileAncoraDaAnalizzare.Length, StringComparison.InvariantCultureIgnoreCase) + 3

                SottostringaInAnalisi = NomeFileAncoraDaAnalizzare.Substring(InizioRegisti, NomeFileAncoraDaAnalizzare.Length - InizioRegisti)
                SottostringaInAnalisi = SottostringaInAnalisi.Replace(" - ", "")
                SottostringaInAnalisi = SottostringaInAnalisi.Replace(", ", ",")

                Film.Registi = New List(Of String)
                Film.Registi.AddRange(SottostringaInAnalisi.Split(","))

                NomeFileAncoraDaAnalizzare = NomeFileAncoraDaAnalizzare.Substring(0, InizioRegisti)
                If (NomeFileAncoraDaAnalizzare.EndsWith("- ")) Then NomeFileAncoraDaAnalizzare = NomeFileAncoraDaAnalizzare.Substring(0, NomeFileAncoraDaAnalizzare.Length - 2)
                If (NomeFileAncoraDaAnalizzare.EndsWith("-")) Then NomeFileAncoraDaAnalizzare = NomeFileAncoraDaAnalizzare.Substring(0, NomeFileAncoraDaAnalizzare.Length - 1)
                If (NomeFileAncoraDaAnalizzare.EndsWith(" ")) Then NomeFileAncoraDaAnalizzare = NomeFileAncoraDaAnalizzare.Substring(0, NomeFileAncoraDaAnalizzare.Length - 1)
            End If

            If (NomeFileAncoraDaAnalizzare.Contains("[") And NomeFileAncoraDaAnalizzare.Contains("]")) Then
                Dim InizioGeneri = NomeFileAncoraDaAnalizzare.IndexOf("[") + 1
                Dim FineGeneri = NomeFileAncoraDaAnalizzare.IndexOf("]")

                SottostringaInAnalisi = NomeFileAncoraDaAnalizzare.Substring(InizioGeneri, FineGeneri - InizioGeneri)
                SottostringaInAnalisi = SottostringaInAnalisi.Replace(" [", "")
                SottostringaInAnalisi = SottostringaInAnalisi.Replace("[", "")
                SottostringaInAnalisi = SottostringaInAnalisi.Replace("] ", "")
                SottostringaInAnalisi = SottostringaInAnalisi.Replace("]", "")
                SottostringaInAnalisi = SottostringaInAnalisi.Replace(", ", ",")

                Film.Generi = New List(Of String)
                Film.Generi.AddRange(SottostringaInAnalisi.Split(","))

                NomeFileAncoraDaAnalizzare = NomeFileAncoraDaAnalizzare.Substring(0, InizioGeneri)
                If (NomeFileAncoraDaAnalizzare.EndsWith("[")) Then NomeFileAncoraDaAnalizzare = NomeFileAncoraDaAnalizzare.Substring(0, NomeFileAncoraDaAnalizzare.Length - 1)
                If (NomeFileAncoraDaAnalizzare.EndsWith(" ")) Then NomeFileAncoraDaAnalizzare = NomeFileAncoraDaAnalizzare.Substring(0, NomeFileAncoraDaAnalizzare.Length - 1)
            End If

            If (NomeFileAncoraDaAnalizzare.Contains("{") And NomeFileAncoraDaAnalizzare.Contains("}")) Then
                Dim InizioNote = NomeFileAncoraDaAnalizzare.IndexOf("{")
                Dim FineNote = NomeFileAncoraDaAnalizzare.IndexOf("}")

                SottostringaInAnalisi = NomeFileAncoraDaAnalizzare.Substring(InizioNote, FineNote - InizioNote)
                SottostringaInAnalisi = SottostringaInAnalisi.Replace(" {", "")
                SottostringaInAnalisi = SottostringaInAnalisi.Replace("{", "")
                SottostringaInAnalisi = SottostringaInAnalisi.Replace("} ", "")
                SottostringaInAnalisi = SottostringaInAnalisi.Replace("}", "")

                Film.Note = SottostringaInAnalisi

                NomeFileAncoraDaAnalizzare = NomeFileAncoraDaAnalizzare.Substring(0, InizioNote)
                If (NomeFileAncoraDaAnalizzare.EndsWith(" ")) Then NomeFileAncoraDaAnalizzare = NomeFileAncoraDaAnalizzare.Substring(0, NomeFileAncoraDaAnalizzare.Length - 1)
            End If

            If (NomeFileAncoraDaAnalizzare.Contains("(") And NomeFileAncoraDaAnalizzare.Contains(")")) Then
                Dim InizioTitoloORIG = NomeFileAncoraDaAnalizzare.IndexOf("(") + 1
                Dim FineTitoloORIG = NomeFileAncoraDaAnalizzare.IndexOf(")")

                SottostringaInAnalisi = NomeFileAncoraDaAnalizzare.Substring(InizioTitoloORIG, FineTitoloORIG - InizioTitoloORIG)
                SottostringaInAnalisi = SottostringaInAnalisi.Replace(" (", "")
                SottostringaInAnalisi = SottostringaInAnalisi.Replace("(", "")
                SottostringaInAnalisi = SottostringaInAnalisi.Replace(") ", "")
                SottostringaInAnalisi = SottostringaInAnalisi.Replace(")", "")

                Film.TitoloORIG = SottostringaInAnalisi

                NomeFileAncoraDaAnalizzare = NomeFileAncoraDaAnalizzare.Substring(0, InizioTitoloORIG - 1)
                If (NomeFileAncoraDaAnalizzare.EndsWith(" ")) Then NomeFileAncoraDaAnalizzare = NomeFileAncoraDaAnalizzare.Substring(0, NomeFileAncoraDaAnalizzare.Length - 1)
            End If

            Film.TitoloITA = NomeFileAncoraDaAnalizzare
        End If
        Return Film
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtInterrompi.Click
        BackgroundWorker.CancelAsync()
        ButtInterrompi.Enabled = False
    End Sub
End Class