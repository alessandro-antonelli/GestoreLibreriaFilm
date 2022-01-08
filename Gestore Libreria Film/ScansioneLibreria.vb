Imports System.IO
Imports System.Security.Cryptography
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ScansioneLibreria
    Public PercorsiFile As System.Collections.ObjectModel.ReadOnlyCollection(Of String)

    Private Sub ScansioneLibreria_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If (MainModule.ModalitaNotte = True) Then
            Me.BackColor = Color.Black
            Me.ForeColor = Color.White
            Button1.BackColor = Color.FromArgb(255, 32, 32, 32)
        End If

        Label1.Text = "0%"
        Label2.Text = "0"
        Label4.Text = "su " + PercorsiFile.Count.ToString
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = PercorsiFile.Count
        Label3.Text = My.Computer.FileSystem.GetFileInfo(PercorsiFile.Item(0)).Name

        BackgroundWorker.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork
        EseguiScansione(PercorsiFile)
    End Sub

    Private Sub BackgroundWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker.ProgressChanged
        Dim Film As Film = e.UserState

        Label2.Text = e.ProgressPercentage.ToString
        ProgressBar1.Value = e.ProgressPercentage
        Label1.Text = Math.Floor(ProgressBar1.Value / ProgressBar1.Maximum * 100).ToString + "%"
        If (e.ProgressPercentage < PercorsiFile.Count) Then
            Label3.Text = My.Computer.FileSystem.GetFileInfo(PercorsiFile.Item(e.ProgressPercentage)).Name
        End If

        If (Not IsNothing(Film)) Then MainForm.AggiungiFilm(Film)
    End Sub

    Private Sub BackgroundWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted
        MainForm.AggiornaAlberoCategorie()
        Me.Close()
    End Sub

    Private Sub EseguiScansione(PercorsiFile As System.Collections.ObjectModel.ReadOnlyCollection(Of String))
        If (IsNothing(PercorsiFile) Or PercorsiFile.Count <= 0 Or Not My.Computer.FileSystem.DirectoryExists(My.Settings.LibreriaPercorso)) Then Return

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

            Select Case My.Computer.FileSystem.GetFileInfo(PercorsoFile).Extension.ToLower
                Case ".db", ".ini", ".nfo", ".txt", ".jpg", ".jpeg", ".png", ".bmp", ".rar", ".zip", ".doc", ".docx", ".sub", ".idx", ".srt", ".mp3", ".ac3", ".ogg", ".flac", ".cue", ".lnk"
                    'Do nothing and Continue For

                    i += 1
                    BackgroundWorker.ReportProgress(i)
                Case Else
                    Film = ParsingNomeFile(NomeFile, PercorsoFile)
                    'Dim HashMD5 As String = md5(PercorsoFile)
                    'Film.HashMD5 = HashMD5

                    Dim PercorsoInfo As String = MainModule.PercorsoInfoFilm(NomeFile)
                    If (My.Computer.FileSystem.FileExists(PercorsoInfo)) Then
                        Film = ParsingJSONInfo(Film, PercorsoInfo)
                        ListaFileAccessori.Remove(PercorsoInfo)
                    Else
                        RegistraInfo(PercorsoFile, PercorsoInfo)
                        If (My.Computer.FileSystem.FileExists(PercorsoInfo)) Then Film = ParsingJSONInfo(Film, PercorsoInfo)
                    End If

                    Dim PercorsoSchermata As String = MainModule.PercorsoSchermataFilm(NomeFile)
                    If (My.Computer.FileSystem.FileExists(PercorsoSchermata)) Then
                        ListaFileAccessori.Remove(PercorsoSchermata)
                    Else
                        CatturaSchermata(PercorsoFile, PercorsoSchermata)
                    End If

                    i += 1
                    BackgroundWorker.ReportProgress(i, Film)
            End Select
        Next

        ' Rimuovo dalla CartellaDatiLibreria i file che non corrispondono ad alcun film della libreria
        ' (schermate e info relative a film cancellati/rinominati manualmente)
        If (Not BackgroundWorker.CancellationPending) Then
            For Each File In ListaFileAccessori
                My.Computer.FileSystem.DeleteFile(File, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
            Next
        End If
    End Sub

    Function ParsingJSONInfo(Film As Film, PercorsoInfo As String) As Film
        Dim Reader As New System.IO.StreamReader(PercorsoInfo)
        Try
            Dim json As JObject = JObject.Parse(Reader.ReadToEnd)

            Dim DurataSecondi As Double = json.SelectToken("format").SelectToken("duration").Value(Of Double)()
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
            '
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BackgroundWorker.CancelAsync()
        Button1.Enabled = False
    End Sub
End Class