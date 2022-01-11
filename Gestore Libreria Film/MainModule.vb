Imports Newtonsoft.Json.Linq

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
        If (My.Settings.PreferisciIconePoster = True) Then
            MainForm.PosterToolStripMenuItem.Checked = True
        Else
            MainForm.SchermataToolStripMenuItem.Checked = True
        End If

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

    Function PercorsoPosterFilm(NomeFileFilm As String) As String
        Return PercorsoFileAccessorio(NomeFileFilm, "_poster.jpg")
    End Function

    Function PercorsoInfoFile(NomeFileFilm As String) As String
        Return PercorsoFileAccessorio(NomeFileFilm, "_info.json")
    End Function

    Function PercorsoInfoIMDB(NomeFileFilm As String) As String
        Return PercorsoFileAccessorio(NomeFileFilm, "_IMDB.json")
    End Function

    Function PercorsoTramaLunga(NomeFileFilm As String) As String
        Return PercorsoFileAccessorio(NomeFileFilm, "_plotlong.txt")
    End Function

    Function PercorsoFlagNienteIMDB(NomeFileFilm As String) As String
        Return PercorsoFileAccessorio(NomeFileFilm, "_NoIMDB")
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

        Dim url As String = "https://www.google.com/search?q=" + Uri.EscapeUriString(Query) + "&tbm=isch"
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

    Sub ScollegaSchedeIMDB(Film As Film)
        Dim PathInfoIMDB As String = MainModule.PercorsoInfoIMDB(Film.NomeFile)
        If (My.Computer.FileSystem.FileExists(PathInfoIMDB)) Then My.Computer.FileSystem.DeleteFile(PathInfoIMDB, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
        Dim PathPoster As String = MainModule.PercorsoPosterFilm(Film.NomeFile)
        If (My.Computer.FileSystem.FileExists(PathPoster)) Then My.Computer.FileSystem.DeleteFile(PathPoster, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)

        Dim PathFlag As String = MainModule.PercorsoFlagNienteIMDB(Film.NomeFile)
        Dim Scrittore As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(PathFlag, True)
        Scrittore.Close()
    End Sub

    Function GetChiaveOMDB() As String
        Dim FilePath As String = Application.StartupPath + "\OMDBkey.txt"
        If (Not My.Computer.FileSystem.FileExists(FilePath)) Then
            Return Nothing
        Else
            Dim APIkey As String
            Dim LettoreChiave As New IO.StreamReader(FilePath)
            APIkey = LettoreChiave.ReadToEnd
            LettoreChiave.Close()
            Return APIkey
        End If
    End Function

    Function TrovaIDimdbAutomatico(Film As Film) As String
        If (Not My.Computer.Network.IsAvailable Or IsNothing(Film)) Then Return Nothing

        Dim PaginaRisultatiRicerca As String
        Dim ElencoRisultatiFiltrato As List(Of String())

        If (Film.Anno <> 0) Then
            'Cerco <TitoloITA, Anno>
            PaginaRisultatiRicerca = RicercaIMDBperTitolo(Film.TitoloITA)
            ElencoRisultatiFiltrato = ProcessaRispostaIMDB(PaginaRisultatiRicerca, Film.Anno)(1)

            If (ElencoRisultatiFiltrato.Count = 1) Then
                Return ElencoRisultatiFiltrato.Item(0)(2)
            ElseIf (Not IsNothing(Film.TitoloORIG)) Then
                'Cerco <TitoloORIG, Anno>
                PaginaRisultatiRicerca = RicercaIMDBperTitolo(Film.TitoloORIG)
                ElencoRisultatiFiltrato = ProcessaRispostaIMDB(PaginaRisultatiRicerca, Film.Anno)(1)
                If (ElencoRisultatiFiltrato.Count = 1) Then Return ElencoRisultatiFiltrato.Item(0)(2)
            End If
        End If

        'Cerco <TitoloITA>
        PaginaRisultatiRicerca = RicercaIMDBperTitolo(Film.TitoloITA)
        ElencoRisultatiFiltrato = ProcessaRispostaIMDB(PaginaRisultatiRicerca, 0)(1)
        If (ElencoRisultatiFiltrato.Count = 1) Then
            Return ElencoRisultatiFiltrato.Item(0)(2)
        ElseIf (Not IsNothing(Film.TitoloORIG)) Then
            'Cerco <TitoloORIG>
            PaginaRisultatiRicerca = RicercaIMDBperTitolo(Film.TitoloORIG)
            ElencoRisultatiFiltrato = ProcessaRispostaIMDB(PaginaRisultatiRicerca, 0)(1)
            If (ElencoRisultatiFiltrato.Count = 1) Then Return ElencoRisultatiFiltrato.Item(0)(2)
        End If

        'Tutti i tentativi hanno non hanno dato risultati (0 risultati della query) o risultati non univoci (più di 1 risultato della query):
        'bisogna chiedere intervento manuale all'utente
        Return Nothing
    End Function

    Function RicercaIMDBperTitolo(Titolo As String) As String
        If (IsNothing(Titolo) OrElse Titolo.Length = 0) Then Return ""
        Dim URL As String = "https://www.imdb.com/find?q=" + Uri.EscapeUriString(Titolo) + "&s=tt"
        Dim PathRisposta As String = My.Computer.FileSystem.GetTempFileName
        If (My.Computer.FileSystem.FileExists(PathRisposta)) Then My.Computer.FileSystem.DeleteFile(PathRisposta, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
        My.Computer.Network.DownloadFile(URL, PathRisposta)

        Dim LettoreRisposta As New IO.StreamReader(PathRisposta)
        Dim SorgenteRisposta As String = LettoreRisposta.ReadToEnd
        LettoreRisposta.Close()
        Return SorgenteRisposta
    End Function

    Function IncorniciaCorpoHTML(CorpoHTML As String, SalvaSuFile As Boolean) As String
        Dim SorgenteHTML As String = "<!DOCTYPE html><html><head><style>a img {outline : none; text-decoration: none; border: none} body {font-family: sans-serif;"
        If (MainModule.ModalitaNotte) Then
            SorgenteHTML += "color: white; background-color: black } a {color: orange}"
        Else
            SorgenteHTML += "color: black; background-color: white } a {color: blue}"
        End If
        SorgenteHTML += "</style></head><body>" + CorpoHTML + "</body></html>"

        If (SalvaSuFile) Then
            Dim PathFileHTML As String = My.Computer.FileSystem.GetTempFileName + ".htm"
            Dim ScrittoreHTMLRipulito As New IO.StreamWriter(PathFileHTML, False, System.Text.Encoding.Unicode)
            ScrittoreHTMLRipulito.Write(SorgenteHTML)
            ScrittoreHTMLRipulito.Close()
            Return PathFileHTML
        Else
            Return SorgenteHTML
        End If
    End Function

    Function ProcessaRispostaIMDB(SorgenteRisposta As String, AnnoFiltraggio As UShort) As Object()
        Dim ListaRisultati As New List(Of String())

        If (IsNothing(SorgenteRisposta) Or SorgenteRisposta.Length = 0) Then
            Return {"<html><head></head><body><h1>Errore</h1>Ricevuta da IMDB risposta vuota!</body></html>", ListaRisultati}
        End If

        Dim InizioElenco As Integer = SorgenteRisposta.IndexOf("<table class=""findList"">")
        Dim FineElenco As Integer = SorgenteRisposta.IndexOf("<div id=""sidebar"">")
        Dim SorgenteAncoraDaFiltrare, SorgenteFiltrato As String

        If (SorgenteRisposta.Contains("No results found for") Or
            SorgenteRisposta.Contains("<div class=""findNoResults"">") Or
            InizioElenco = -1) Then
            InizioElenco = SorgenteRisposta.IndexOf("<div class=""article"">")
            SorgenteAncoraDaFiltrare = SorgenteRisposta.Substring(InizioElenco, FineElenco - InizioElenco)
            SorgenteFiltrato = SorgenteAncoraDaFiltrare
        Else
            SorgenteAncoraDaFiltrare = SorgenteRisposta.Substring(InizioElenco, FineElenco - InizioElenco)

            'If (AnnoFiltraggio = 0) Then
            '    SorgenteElencoFiltrato = SorgenteElenco
            'Else
            Dim RigaCorrente As String

            Dim InizioPrimaRiga As Integer = SorgenteAncoraDaFiltrare.IndexOf("<tr")
            If (InizioPrimaRiga <> -1) Then
                RigaCorrente = SorgenteAncoraDaFiltrare.Substring(0, InizioPrimaRiga)
                SorgenteAncoraDaFiltrare = SorgenteAncoraDaFiltrare.Substring(InizioPrimaRiga, SorgenteAncoraDaFiltrare.Length - InizioPrimaRiga)
            Else
                RigaCorrente = SorgenteAncoraDaFiltrare
                SorgenteAncoraDaFiltrare = ""
            End If
            SorgenteFiltrato = RigaCorrente

            While (SorgenteAncoraDaFiltrare.Length > 0)
                Dim FineRiga As Integer = SorgenteAncoraDaFiltrare.IndexOf("</tr>")
                If (FineRiga <> -1) Then
                    RigaCorrente = SorgenteAncoraDaFiltrare.Substring(0, FineRiga + 5)
                    SorgenteAncoraDaFiltrare = SorgenteAncoraDaFiltrare.Substring(FineRiga + 5, SorgenteAncoraDaFiltrare.Length - FineRiga - 5)
                Else
                    RigaCorrente = SorgenteAncoraDaFiltrare
                    SorgenteAncoraDaFiltrare = ""
                End If

                If (Not RigaCorrente.Contains("<tr")) Then
                    SorgenteFiltrato += RigaCorrente
                Else
                    'If (Riga.Contains("(" + AnnoFiltraggio.ToString + ")") Or AnnoFiltraggio = 0) Then
                    'SorgenteElencoFiltrato += Riga
                    'Else

                    Dim FineImmagine As Integer = RigaCorrente.IndexOf("<td class=""result_text"">")
                    Dim RitaglioRiga As String = RigaCorrente.Substring(FineImmagine, RigaCorrente.Length - FineImmagine)

                    Dim InizioID As Integer = RitaglioRiga.IndexOf("<a href=""/title/") + 16
                    Dim FineID As Integer = RitaglioRiga.IndexOf("/?ref_=fn_tt_tt")
                    Dim IDRiga As String = RitaglioRiga.Substring(InizioID, FineID - InizioID)

                    RitaglioRiga = RitaglioRiga.Substring(FineID, RitaglioRiga.Length - FineID)

                    Dim InizioTitolo As Integer = RitaglioRiga.IndexOf(""" >") + 3
                    Dim FineTitolo As Integer = RitaglioRiga.IndexOf("</a>")
                    Dim TitoloRiga As String = RitaglioRiga.Substring(InizioTitolo, FineTitolo - InizioTitolo)
                    RitaglioRiga = RitaglioRiga.Substring(FineTitolo + 4, RitaglioRiga.Length - FineTitolo - 4)

                    'Rimuovo evetuali numeri romani dopo il titolo
                    RitaglioRiga = RitaglioRiga.Replace("(I)", "")
                    RitaglioRiga = RitaglioRiga.Replace("(II)", "")
                    RitaglioRiga = RitaglioRiga.Replace("(III)", "")
                    RitaglioRiga = RitaglioRiga.Replace("(IV)", "")
                    RitaglioRiga = RitaglioRiga.Replace("(V)", "")
                    RitaglioRiga = RitaglioRiga.Replace("(VI)", "")
                    RitaglioRiga = RitaglioRiga.Replace("(VII)", "")
                    RitaglioRiga = RitaglioRiga.Replace("(VIII)", "")
                    RitaglioRiga = RitaglioRiga.Replace("(IX)", "")
                    RitaglioRiga = RitaglioRiga.Replace("(X)", "")
                    RitaglioRiga = RitaglioRiga.Replace("(XI)", "")
                    RitaglioRiga = RitaglioRiga.Replace("(XII)", "")
                    RitaglioRiga = RitaglioRiga.Replace("(XIII)", "")
                    RitaglioRiga = RitaglioRiga.Replace("(XIV)", "")
                    RitaglioRiga = RitaglioRiga.Replace("(XV)", "")
                    RitaglioRiga = RitaglioRiga.Replace("(XVI)", "")
                    RitaglioRiga = RitaglioRiga.Replace("(XVII)", "")
                    RitaglioRiga = RitaglioRiga.Replace("(XVIII)", "")
                    RitaglioRiga = RitaglioRiga.Replace("(XIX)", "")
                    RitaglioRiga = RitaglioRiga.Replace("(XX)", "")

                    Dim StrAnnoRiga As String = RitaglioRiga.Substring(RitaglioRiga.IndexOf("(") + 1, 4)
                    Dim AnnoRiga As UShort
                    Dim EsitoCast As Boolean = UShort.TryParse(StrAnnoRiga, AnnoRiga)

                    If (AnnoFiltraggio = 0 OrElse (EsitoCast = True AndAlso AnnoRiga = AnnoFiltraggio)) Then
                        SorgenteFiltrato += RigaCorrente
                        ListaRisultati.Add({TitoloRiga, If(EsitoCast, AnnoRiga, StrAnnoRiga), IDRiga})
                    End If
                End If
            End While
            'End If
        End If

        Return {SorgenteFiltrato, ListaRisultati}
    End Function

    Sub ScaricaDatiIMDB(IdIMDB As String, NomeFileFilm As String)
        If (IsNothing(IdIMDB) OrElse IdIMDB.Length = 0 OrElse IsNothing(NomeFileFilm) OrElse NomeFileFilm.Length = 0 OrElse Not My.Computer.Network.IsAvailable) Then Return
        Dim APIkey As String = GetChiaveOMDB()
        If (IsNothing(APIkey)) Then Return

        Dim PathRisposta As String = PercorsoInfoIMDB(NomeFileFilm)
        ScaricaSchedaOMDB(APIkey, IdIMDB, False, PathRisposta)

        Dim FlagNoIMDB As String = PercorsoFlagNienteIMDB(NomeFileFilm)
        If (My.Computer.FileSystem.FileExists(FlagNoIMDB)) Then
            My.Computer.FileSystem.DeleteFile(FlagNoIMDB, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
        End If

        Dim PathTempTramaLunga As String = My.Computer.FileSystem.SpecialDirectories.Temp + "\GLF_OMDB_tramalunga.json"
        Dim Riuscito As Boolean = ScaricaSchedaOMDB(APIkey, IdIMDB, True, PathTempTramaLunga)

        If (Riuscito) Then
            Dim ReaderRisposta As New System.IO.StreamReader(PathTempTramaLunga)
            Dim json As JObject = JObject.Parse(ReaderRisposta.ReadToEnd)
            Dim StrTramaLunga As String = json.SelectToken("Plot").Value(Of String)()
            Dim URLPoster As String = json.SelectToken("Poster").Value(Of String)()
            ReaderRisposta.Close()

            If (Not StrTramaLunga.ToUpper.Equals("N/A")) Then
                Dim WriterTramaLunga As New System.IO.StreamWriter(PercorsoTramaLunga(NomeFileFilm), False, System.Text.Encoding.Unicode)
                WriterTramaLunga.Write(StrTramaLunga)
                WriterTramaLunga.Close()
            End If
            If (Not IsNothing(URLPoster) AndAlso URLPoster.Length > 0 AndAlso Not URLPoster.Equals("N/A")) Then
                Dim PathPoster As String = PercorsoPosterFilm(NomeFileFilm)
                If (Not (My.Computer.FileSystem.FileExists(PathPoster))) Then My.Computer.Network.DownloadFile(URLPoster, PathPoster)
            End If
            My.Computer.FileSystem.DeleteFile(PathTempTramaLunga, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
        End If


        'Dim TitoloRicerca As String

        'If (Not IsNothing(Film.TitoloORIG)) Then
        '    TitoloRicerca = Film.TitoloORIG
        '    Riuscito = ScaricaSchedaOMDB(APIkey, TitoloRicerca, Film.Anno, False, PathRisposta, If(IsNothing(Film.Registi), Nothing, Film.Registi(0)))
        'End If

        'If (Not Riuscito) Then
        '    TitoloRicerca = Film.TitoloITA
        '    Riuscito = ScaricaSchedaOMDB(APIkey, TitoloRicerca, Film.Anno, False, PathRisposta, If(IsNothing(Film.Registi), Nothing, Film.Registi(0)))
        'End If

        'If (Not Riuscito) Then
        '    TitoloRicerca = Film.TitoloITA
        '    Dim UltimoSpazio As Short = TitoloRicerca.LastIndexOf(" ")

        '    While (Not Riuscito And UltimoSpazio <> -1)
        '        TitoloRicerca = TitoloRicerca.Substring(0, UltimoSpazio)
        '        Riuscito = ScaricaSchedaOMDB(APIkey, TitoloRicerca, Film.Anno, False, PathRisposta, If(IsNothing(Film.Registi), Nothing, Film.Registi(0)))
        '        UltimoSpazio = TitoloRicerca.LastIndexOf(" ")
        '    End While
        'End If
        'While (Not Riuscito)
        '    TitoloRicerca = InputBox("Non è stato possibile trovare automaticamente il film su IMDB. Inserire il nome con cui effettuare la ricerca:" + Chr(10) + Chr(10) + "Titolo film: " + Film.TitoloITA + If(Not IsNothing(Film.TitoloORIG), " (" + Film.TitoloORIG + ")", ""), "Insersci titolo manualmente", Film.TitoloITA)
        '    If (IsNothing(TitoloRicerca) OrElse TitoloRicerca.Length = 0) Then
        '        Exit Sub
        '    Else
        '        Riuscito = ScaricaSchedaOMDB(APIkey, TitoloRicerca, Film.Anno, False, PathRisposta, If(IsNothing(Film.Registi), Nothing, Film.Registi(0)))
        '    End If
        'End While
    End Sub

    Function ScaricaSchedaOMDB(APIkey As String, IdIMDB As String, TramaLunga As Boolean, PathRisposta As String) As Boolean 'il valore di ritorno indica l'esito
        Dim URL As String = "http://www.omdbapi.com/?apikey=" + APIkey
        URL += "&i=" + IdIMDB
        URL += "&r=json"
        URL += If(TramaLunga, "&plot=full", "&plot=short")

        EseguiRichiestaOMDB(URL, PathRisposta)
        If (Not My.Computer.FileSystem.FileExists(PathRisposta)) Then Return False

        Dim ReaderRisposta As New System.IO.StreamReader(PathRisposta)
        Try
            Dim json As JObject = JObject.Parse(ReaderRisposta.ReadToEnd)
            ReaderRisposta.Close()
            Dim esito As Boolean = json.SelectToken("Response").Value(Of Boolean)()
            If (esito = False) Then
                Dim errore As String = json.SelectToken("Error").Value(Of String)()
                MessageBox.Show(errore)
                My.Computer.FileSystem.DeleteFile(PathRisposta, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
                Return False
            Else
                Return True
            End If
        Catch e As Exception
            ReaderRisposta.Close()
            MessageBox.Show(e.ToString)
            Return False
        End Try
    End Function

    Function ScaricaSchedaOMDB(APIkey As String, Titolo As String, Anno As UShort, TramaLunga As Boolean,
                               PathRisposta As String, Regista As String) As Boolean 'il valore di ritorno indica l'esito

        Dim URL As String = "http://www.omdbapi.com/?apikey=" + APIkey
        URL += "&t=" + Titolo
        URL += "&type=movie"
        If (Anno <> 0) Then URL += "&y=" + Anno.ToString
        URL += "&r=json"
        URL += If(TramaLunga, "&plot=full", "&plot=short")

        EseguiRichiestaOMDB(URL, PathRisposta)
        If (Not My.Computer.FileSystem.FileExists(PathRisposta)) Then Return False

        Dim ReaderRisposta As New System.IO.StreamReader(PathRisposta)
        Try
            Dim json As JObject = JObject.Parse(ReaderRisposta.ReadToEnd)
            Dim esito As Boolean = json.SelectToken("Response").Value(Of Boolean)()
            If (esito = False) Then
                'Dim errore As String = json.SelectToken("Error").Value(Of String)()
                ReaderRisposta.Close()
                'MessageBox.Show(errore)
                My.Computer.FileSystem.DeleteFile(PathRisposta, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
                Return False
            Else
                If (IsNothing(Regista)) Then
                    ReaderRisposta.Close()
                    Return True
                Else
                    Dim RegistaRicevuto As String = json.SelectToken("Director").Value(Of String)()
                    Dim NomiRegista As String() = Regista.Split(" ")
                    Dim Confrontando As String = If(NomiRegista.Length < 3, NomiRegista(0), NomiRegista(2))
                    If (RegistaRicevuto.Equals(Regista) Or RegistaRicevuto.Contains(Confrontando) Or Regista.Contains(RegistaRicevuto.Split(" ")(0))) Then
                        ReaderRisposta.Close()
                        Return True
                    Else
                        ReaderRisposta.Close()
                        Return False
                    End If
                End If
            End If

        Catch e As Exception
            ReaderRisposta.Close()
            MessageBox.Show(e.ToString)
            Return False
        End Try

    End Function

    Sub EseguiRichiestaOMDB(URLdomanda, PathRisposta)
        If (My.Computer.FileSystem.FileExists(PathRisposta)) Then My.Computer.FileSystem.DeleteFile(PathRisposta, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)

        Try
            My.Computer.Network.DownloadFile(URLdomanda, PathRisposta)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Module
