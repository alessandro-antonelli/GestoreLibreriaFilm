Module MainModule
    Public ModalitaNotte As Boolean

    Sub Main(args As String())
        Application.EnableVisualStyles()
        MainForm.VisualizzazioneContenutoSchermataDestra(False)

        ' Modalità notte
        AggiornaModalitaNotte()
        If (ModalitaNotte) Then MainForm.ImpostaColori(True)

        ' Ripristino preferenze finestra
        MainForm.Size = My.Settings.FinestraDimensione
        MainForm.Location = My.Settings.FinestraPosizione
        If (My.Settings.FinestraMassimizzata = True) Then
            MainForm.WindowState = FormWindowState.Maximized
        Else
            MainForm.WindowState = FormWindowState.Normal
        End If

        ' Ripristino preferenze pannelli
        MainForm.SplitContainerSX_CDX.SplitterDistance = My.Settings.PannelloSxDimensione
        MainForm.SplitContainerC_DX.SplitterDistance = MainForm.SplitContainerC_DX.Width - My.Settings.PannelloDxDimensione
        MainForm.SplitImmagineDettagli.SplitterDistance = My.Settings.PannelloSchermataDimensione
        MainForm.SplitContainerSX_CDX.Panel1Collapsed = My.Settings.PannelloSxChiuso
        MainForm.SplitContainerC_DX.Panel2Collapsed = My.Settings.PannelloDxChiuso
        MainForm.SplitImmagineDettagli.Panel1Collapsed = My.Settings.PannelloSchermataChiuso
        MainForm.ButtPannelloSchermata.Text = If(My.Settings.PannelloSchermataChiuso, "mostra schermata ∨", "nascondi schermata ∧")

        ' Elementi form
        MainForm.FileSystemWatcher.Path = My.Settings.LibreriaPercorso
        MainForm.FiltroAnnoMin.Maximum = My.Computer.Clock.LocalTime.Year
        MainForm.FiltroAnnoMax.Maximum = My.Computer.Clock.LocalTime.Year + 1
        MainForm.FiltroAnnoMax.Value = My.Computer.Clock.LocalTime.Year + 1

        ' Ripristino preferenze visualizzatore film
        MainForm.ElencoFilm.View = My.Settings.VistaIcone
        Select Case My.Settings.VistaIcone
            Case View.Details
                MainForm.ColonneToolStripMenuItem.Checked = True
                'Me.ElencoFilm.Columns.Item(0).Width = 240
                'Me.ElencoFilm.Columns.Item(1).Width = 60
                'Me.ElencoFilm.Columns.Item(2).Width = 140
                'Me.ElencoFilm.Columns.Item(3).Width = 140
            Case View.LargeIcon
                MainForm.IconeGrandiToolStripMenuItem.Checked = True
            Case View.List
                MainForm.ListaToolStripMenuItem.Checked = True
            Case View.SmallIcon
                MainForm.IconePiccoleToolStripMenuItem.Checked = True
            Case View.Tile
                MainForm.TilesToolStripMenuItem.Checked = True
        End Select
        MainForm.ElencoFilm.ArrangeIcons()

        'Me.ElencoFilm.Columns.Add(MainForm.ColTitolo)
        'Me.ElencoFilm.Columns.Add(MainForm.ColAnno)
        'Me.ElencoFilm.Columns.Add(MainForm.ColRegisti)
        'Me.ElencoFilm.Columns.Add(MainForm.ColGeneri)

        'Visualizza il contenuto della categoria "Tutti i film"
        'GeneraListaFilmCategoria(0, 0)
        'AggiornaIconeDaLista()

        ' Cartelle
        If (Not My.Computer.FileSystem.DirectoryExists(My.Settings.LibreriaPercorso)) Then
            'E' il primo avvio dell'app

            'Salvo su disco le impostazioni di default
            'My.Settings.Reset()
            'My.Settings.Save()

            ' Chiedo cartella libreria
            Dim esito As DialogResult = ScegliLibreria.ShowDialog()
            If (esito <> DialogResult.OK Or Not My.Computer.FileSystem.DirectoryExists(My.Settings.LibreriaPercorso)) Then
                Application.Exit()
                Return
            End If
        End If
        'While (Not My.Computer.FileSystem.DirectoryExists(My.Settings.LibraryPath))
        '    ScegliLibreria.ShowDialog()
        'End While

        Dim CartellaDatiLibreria As String = My.Settings.LibreriaPercorso + "\GestoreLibreriaFilm\"
        If (Not My.Computer.FileSystem.DirectoryExists(CartellaDatiLibreria)) Then
            My.Computer.FileSystem.CreateDirectory(CartellaDatiLibreria)
            My.Computer.FileSystem.GetDirectoryInfo(CartellaDatiLibreria).Attributes = IO.FileAttributes.Hidden
        End If

        ScansioneLibreria.PercorsiFile = My.Computer.FileSystem.GetFiles(My.Settings.LibreriaPercorso)
        ScansioneLibreria.ShowDialog()

        Application.Run(MainForm)
    End Sub

    Public Function AggiornaModalitaNotte() As Boolean
        Dim ValorePrecedente As Boolean = ModalitaNotte

        Dim ChiaveModalità As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", "")
        If (Not IsNothing(ChiaveModalità) AndAlso ChiaveModalità.Equals("0")) Then
            ModalitaNotte = True
        Else
            ModalitaNotte = False
        End If

        Return (ModalitaNotte.Equals(ValorePrecedente))
    End Function
    Public Function SeparaNomeCognome(Nominativo) As String()
        Dim Nome As String = ""
        Dim Cognome As String = ""

        Dim PosPunto As Short = Nominativo.IndexOf(".")
        If (PosPunto = -1) Then
            If (Not Nominativo.Contains(" ")) Then
                'Input nella forma: Antonelli
                Cognome = Nominativo
                Nome = ""
            Else
                'Input nella forma: Alessandro Antonelli
                Dim PartiNominativo As String() = Nominativo.Split(" ")
                Cognome = PartiNominativo.GetValue(PartiNominativo.Length - 1)

                For i As UShort = 0 To PartiNominativo.Length - 2
                    Nome += PartiNominativo.GetValue(i) + " "
                Next
                Nome = Nome.Substring(0, Nome.Length - 1)
            End If
        Else
            'Input nella forma: A. Antonelli
            Cognome = Nominativo.Substring(PosPunto + 1, Nominativo.Length - PosPunto - 1)
            If (Cognome.StartsWith(" ")) Then Cognome = Cognome.Substring(1, Cognome.Length - 1)

            Nome = Nominativo.Substring(0, PosPunto)
            If (Nome.EndsWith(" ")) Then Nome = Nome.Substring(0, Nome.Length - 1)
            Nome += "."
        End If

        Return {Nome, Cognome}
    End Function

    Function PercorsoDatiLibreria() As String
        If (IsNothing(My.Settings.LibreriaPercorso) OrElse Not My.Computer.FileSystem.DirectoryExists(My.Settings.LibreriaPercorso)) Then
            Return Nothing
        End If
        Dim PathDatiLibreria As String = My.Settings.LibreriaPercorso + "\GestoreLibreriaFilm\"
        If (Not My.Computer.FileSystem.DirectoryExists(PathDatiLibreria)) Then
            My.Computer.FileSystem.CreateDirectory(PathDatiLibreria)
            My.Computer.FileSystem.GetDirectoryInfo(PathDatiLibreria).Attributes = IO.FileAttributes.Hidden
        End If
        Return PathDatiLibreria
    End Function

    Function PercorsoDatiPersone() As String
        If (IsNothing(My.Settings.LibreriaPercorso) OrElse Not My.Computer.FileSystem.DirectoryExists(My.Settings.LibreriaPercorso)) Then
            Return Nothing
        End If
        Dim PathDatiLibreria As String = PercorsoDatiLibreria()
        Dim PathDatiPersone As String = PathDatiLibreria + "\persone\"
        If (Not My.Computer.FileSystem.DirectoryExists(PathDatiPersone)) Then
            My.Computer.FileSystem.CreateDirectory(PathDatiPersone)
        End If
        Return PathDatiPersone
    End Function

    Function PercorsoSchermataFilm(NomeFileFilm As String) As String
        Return PercorsoFileAccessorio(NomeFileFilm, "_screen.jpg")
    End Function

    Function PercorsoInfoFilm(NomeFileFilm As String) As String
        Return PercorsoFileAccessorio(NomeFileFilm, "_info.json")
    End Function

    Function PercorsoFileAccessorio(NomeFileFilm As String, Suffisso As String)
        If (IsNothing(My.Settings.LibreriaPercorso) OrElse Not My.Computer.FileSystem.DirectoryExists(My.Settings.LibreriaPercorso)) Then
            Return Nothing
        End If
        'Dim PathDatiLibreria As String = My.Settings.LibreriaPercorso + "\GestoreLibreriaFilm\"
        Dim PathDatiLibreria As String = PercorsoDatiLibreria()

        Const MaxLunghezzaPercorsoFile As UShort = 255

        Dim PathFileAccessorio As String = PathDatiLibreria + NomeFileFilm + Suffisso
        If (PathFileAccessorio.Length > MaxLunghezzaPercorsoFile) Then
            Dim CharInEccesso As UShort = PathFileAccessorio.Length - MaxLunghezzaPercorsoFile
            PathFileAccessorio = PathDatiLibreria + NomeFileFilm.Substring(0, NomeFileFilm.Length - CharInEccesso) + Suffisso
        End If

        Return PathFileAccessorio
    End Function

    Function PercorsoImmaginePersona(CognomePersona As String, InizialeNomePersona As Char)
        If (IsNothing(My.Settings.LibreriaPercorso) OrElse Not My.Computer.FileSystem.DirectoryExists(My.Settings.LibreriaPercorso)) Then
            Return Nothing
        End If
        Dim PathDatiPersone As String = PercorsoDatiPersone()
        Return PathDatiPersone + "\" + CognomePersona + If(InizialeNomePersona <> Chr(0), "_" + InizialeNomePersona, "") + ".jpg"
    End Function

    'restituisce la lista dei path delle immagini JPG salvate
    Function SalvaImmaginiGoogle(Query As String, QuantitaRisultatiDesiderati As UShort) As String()
        If (Not My.Computer.Network.IsAvailable OrElse IsNothing(Query) OrElse Query.Length <= 0) Then Return Nothing

        Dim url As String = "https://www.google.com/search?q=" + Query + "&tbm=isch"
        Dim PathHTM = My.Computer.FileSystem.SpecialDirectories.Temp + "\GLF_RicercaGoogle.htm"
        If (My.Computer.FileSystem.FileExists(PathHTM)) Then My.Computer.FileSystem.DeleteFile(PathHTM, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)

        Try
            My.Computer.Network.DownloadFile(url, PathHTM)

            Dim LettoreHTML As New IO.StreamReader(PathHTM, System.Text.Encoding.UTF8)
            Dim StringaHTML As String = LettoreHTML.ReadToEnd
            LettoreHTML.Close()

            Dim PathImmagini(QuantitaRisultatiDesiderati) As String
            For i As UShort = 1 To QuantitaRisultatiDesiderati
                PathImmagini(i - 1) = My.Computer.FileSystem.SpecialDirectories.Temp + "\GLF_RicercaGoogle_ris" + i.ToString + ".jpg"
                Dim URLImg As String = GetURLImmagine(i, StringaHTML)
                If (URLImg.Length <= 0) Then Return Nothing

                If (My.Computer.FileSystem.FileExists(PathImmagini(i - 1))) Then My.Computer.FileSystem.DeleteFile(PathImmagini(i - 1), FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
                My.Computer.Network.DownloadFile(URLImg, PathImmagini(i - 1))
            Next
            Return PathImmagini

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return Nothing
        End Try
    End Function

    Private Function GetURLImmagine(NumRisultatoDesiderato As UShort, SorgenteHTML As String) As String
        If (NumRisultatoDesiderato < 1 OrElse IsNothing(SorgenteHTML) OrElse SorgenteHTML.Length <= 0) Then Return Nothing

        Dim NumRisultatoRaggiunto = 1
        Dim URLImg As String = ""

        While True
            Dim IndInizioTag As Integer = SorgenteHTML.IndexOf("<img class=")
            If (IndInizioTag = -1) Then Return False
            SorgenteHTML = SorgenteHTML.Substring(IndInizioTag, SorgenteHTML.Length - IndInizioTag)

            Dim IndInizioURLImg As Integer = SorgenteHTML.IndexOf("src=""")
            If (IndInizioURLImg = -1) Then Continue While
            IndInizioURLImg += 5
            SorgenteHTML = SorgenteHTML.Substring(IndInizioURLImg, SorgenteHTML.Length - IndInizioURLImg)

            Dim IndFineURL As Integer = SorgenteHTML.IndexOf("""")
            If (IndFineURL = -1) Then Continue While
            URLImg = SorgenteHTML.Substring(0, IndFineURL)

            If (URLImg.StartsWith("https")) Then
                'abbiamo trovato il tag <img> di un risultato della query
                If (NumRisultatoRaggiunto = NumRisultatoDesiderato) Then
                    Exit While
                Else
                    NumRisultatoRaggiunto += 1
                    Continue While
                End If
            Else
                'abbiamo trovato il tag <img> del logo google o simili
                Continue While
            End If
        End While

        Return URLImg
    End Function
End Module
