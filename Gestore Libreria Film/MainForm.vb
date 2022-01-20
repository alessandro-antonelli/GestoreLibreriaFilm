Imports System.Net.WebRequestMethods.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class MainForm
    Public CacheIcone() As ListViewItem
    Dim IndicePrimoElementoInCacheIcone As Integer

    Public LibreriaFilm As New List(Of Film)
    Dim ListaIndiciFilmInCategoria As New List(Of UShort)
    Dim ListaIndiciFilmFiltrati As New List(Of UShort)

    Public TuttiIFilm As ListaEtichettata
    Public FilmPerRegista As New List(Of ListaEtichettata)
    Public FilmPerDecennio As New List(Of ListaEtichettata)
    Public FilmPerAttore As New List(Of ListaEtichettata)
    Public FilmPerGenere As New List(Of ListaEtichettata)
    Public FilmPerNazione As New List(Of ListaEtichettata)
    Public FilmPerAutore As New List(Of ListaEtichettata)
    Public FilmPerMusicista As New List(Of ListaEtichettata)

    'Cronologia di navigazione
    Dim CatNavigazioneAttuale As Byte = 0, ValoreNavigazioneAttuale As Short = -1

    Dim PrecedentiCatNavigazione As New List(Of Byte)
    Dim PrecedentiValNavigazione As New List(Of UShort)
    Dim PrecedentiIconaSelezionataNavigazione As New List(Of UShort)

    Dim SuccessiveCatNavigazione As New List(Of Byte)
    Dim SuccessiviValNavigazione As New List(Of UShort)
    Dim SuccessivaIconaSelezionataNavigazione As New List(Of UShort)

    Const ColoriTestoRTFNotte As String = "\deff0 {\colortbl;\red255\green255\blue255;\red255\green0\blue0;\red64\green200\blue64;\red0\green128\blue255;}"
    Const ColoriTestoRTFGiorno As String = "\deff0 {\colortbl;\red0\green0\blue0;\red255\green0\blue0;\red64\green200\blue64;\red0\green128\blue255;}"

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplitContainerFiltriAvanzati_Icone.Panel1Collapsed = True
        'Visualizzo la categoria "tutti i film"
        NavigaAllaCategoria(0, 0)
    End Sub

    Sub NavigaAllaCategoria(IndiceCategoria As Byte, ValoreCategoria As UShort)
        If (ValoreNavigazioneAttuale <> -1) Then
            PrecedentiCatNavigazione.Add(CatNavigazioneAttuale)
            PrecedentiValNavigazione.Add(ValoreNavigazioneAttuale)
            If (ElencoFilm.SelectedIndices.Count > 0) Then
                PrecedentiIconaSelezionataNavigazione.Add(ElencoFilm.SelectedIndices.Item(0))
            Else
                PrecedentiIconaSelezionataNavigazione.Add(0)
            End If
            ButtCronoIndietro.Enabled = True
        End If

        SuccessiveCatNavigazione.Clear()
        SuccessiviValNavigazione.Clear()
        SuccessivaIconaSelezionataNavigazione.Clear()
        ButtCronoAvanti.Enabled = False

        'cambio cat
        CatNavigazioneAttuale = IndiceCategoria
        ValoreNavigazioneAttuale = ValoreCategoria

        GeneraListaFilmCategoria(IndiceCategoria, ValoreCategoria)
        AggiornaIconeDaLista()
    End Sub

    Private Sub ButtCronoIndietro_Click(sender As Object, e As EventArgs) Handles ButtCronoIndietro.Click
        Dim IndicePrecedenteCronologia As UShort = PrecedentiCatNavigazione.Count - 1

        Dim IndiceCategoria As Byte = PrecedentiCatNavigazione.Item(IndicePrecedenteCronologia)
        Dim ValoreCategoria As UShort = PrecedentiValNavigazione.Item(IndicePrecedenteCronologia)
        Dim IconaSelezionata As UShort = PrecedentiIconaSelezionataNavigazione.Item(IndicePrecedenteCronologia)

        PrecedentiCatNavigazione.RemoveAt(IndicePrecedenteCronologia)
        PrecedentiValNavigazione.RemoveAt(IndicePrecedenteCronologia)
        PrecedentiIconaSelezionataNavigazione.RemoveAt(IndicePrecedenteCronologia)
        If (PrecedentiCatNavigazione.Count <= 0) Then
            ButtCronoIndietro.Enabled = False
        End If

        SuccessiveCatNavigazione.Add(CatNavigazioneAttuale)
        SuccessiviValNavigazione.Add(ValoreNavigazioneAttuale)
        If (ElencoFilm.SelectedIndices.Count > 0) Then
            SuccessivaIconaSelezionataNavigazione.Add(ElencoFilm.SelectedIndices.Item(0))
        Else
            SuccessivaIconaSelezionataNavigazione.Add(0)
        End If
        ButtCronoAvanti.Enabled = True

        'cambio cat
        CatNavigazioneAttuale = IndiceCategoria
        ValoreNavigazioneAttuale = ValoreCategoria

        GeneraListaFilmCategoria(IndiceCategoria, ValoreCategoria)
        AggiornaIconeDaLista()

        ElencoFilm.Focus()
        ElencoFilm.Items.Item(IconaSelezionata).EnsureVisible()
        ElencoFilm.Items.Item(IconaSelezionata).Selected = True
    End Sub

    Private Sub ButtCronoAvanti_Click(sender As Object, e As EventArgs) Handles ButtCronoAvanti.Click
        Dim IndiceProssimaCronologia As UShort = SuccessiveCatNavigazione.Count - 1

        Dim IndiceCategoria As Byte = SuccessiveCatNavigazione.Item(IndiceProssimaCronologia)
        Dim ValoreCategoria As UShort = SuccessiviValNavigazione.Item(IndiceProssimaCronologia)
        Dim IconaSelezionata As UShort = SuccessivaIconaSelezionataNavigazione.Item(IndiceProssimaCronologia)

        SuccessiveCatNavigazione.RemoveAt(IndiceProssimaCronologia)
        SuccessiviValNavigazione.RemoveAt(IndiceProssimaCronologia)
        SuccessivaIconaSelezionataNavigazione.RemoveAt(IndiceProssimaCronologia)
        If (SuccessiveCatNavigazione.Count <= 0) Then
            ButtCronoAvanti.Enabled = False
        End If

        PrecedentiCatNavigazione.Add(CatNavigazioneAttuale)
        PrecedentiValNavigazione.Add(ValoreNavigazioneAttuale)
        If (ElencoFilm.SelectedIndices.Count > 0) Then
            PrecedentiIconaSelezionataNavigazione.Add(ElencoFilm.SelectedIndices.Item(0))
        Else
            PrecedentiIconaSelezionataNavigazione.Add(0)
        End If
        ButtCronoIndietro.Enabled = True

        'cambio cat
        CatNavigazioneAttuale = IndiceCategoria
        ValoreNavigazioneAttuale = ValoreCategoria

        GeneraListaFilmCategoria(IndiceCategoria, ValoreCategoria)
        AggiornaIconeDaLista()

        ElencoFilm.Focus()
        ElencoFilm.Items.Item(IconaSelezionata).EnsureVisible()
        ElencoFilm.Items.Item(IconaSelezionata).Selected = True
    End Sub

    Public Sub AggiungiFilm(Film As Film)
        Dim indice As UShort = LibreriaFilm.Count
        LibreriaFilm.Add(Film)
        If (IsNothing(TuttiIFilm)) Then
            TuttiIFilm = New ListaEtichettata("La tua libreria", indice)
        Else
            TuttiIFilm.Aggiungi(indice)
        End If

        'FilmPerRegista
        If (Not IsNothing(Film.Registi)) Then
            For Each regista In Film.Registi
                Dim ListaRegista As ListaEtichettata = FilmPerRegista.Find(Function(l) regista.Equals(l.GetEtichetta))
                If (IsNothing(ListaRegista)) Then
                    FilmPerRegista.Add(New ListaEtichettata(regista, indice))
                Else
                    ListaRegista.Aggiungi(indice)
                End If
            Next
        Else
            Dim ListaNessunRegista As ListaEtichettata = FilmPerRegista.Find(Function(l) l.GetEtichetta.Equals("[Nessun regista]"))
            If (IsNothing(ListaNessunRegista)) Then
                FilmPerRegista.Add(New ListaEtichettata("[Nessun regista]", indice))
            Else
                ListaNessunRegista.Aggiungi(indice)
            End If
        End If

        'FilmPerDecennio
        If (Not IsNothing(Film.Anno)) Then
            Dim Decennio As String = Film.Anno.ToString.Substring(0, 3) + "0s"
            Dim ListaDecennio As ListaEtichettata = FilmPerDecennio.Find(Function(l) Decennio.Equals(l.GetEtichetta))
            If (IsNothing(ListaDecennio)) Then
                FilmPerDecennio.Add(New ListaEtichettata(Decennio, indice))
            Else
                ListaDecennio.Aggiungi(indice)
            End If
        Else
            Dim ListaNessunaData As ListaEtichettata = FilmPerDecennio.Find(Function(l) l.GetEtichetta.Equals("[Sconosciuto]"))
            If (IsNothing(ListaNessunaData)) Then
                FilmPerDecennio.Add(New ListaEtichettata("[Sconosciuto]", indice))
            Else
                ListaNessunaData.Aggiungi(indice)
            End If
        End If

        'FilmPerGenere
        If (Not IsNothing(Film.Generi)) Then
            For Each genere In Film.Generi
                Dim ListaGenere As ListaEtichettata = FilmPerGenere.Find(Function(l) genere.Equals(l.GetEtichetta))
                If (IsNothing(ListaGenere)) Then
                    FilmPerGenere.Add(New ListaEtichettata(genere, indice))
                Else
                    ListaGenere.Aggiungi(indice)
                End If
            Next
        Else
            Dim ListaNessunGenere As ListaEtichettata = FilmPerGenere.Find(Function(l) l.GetEtichetta.Equals("[Nessun genere]"))
            If (IsNothing(ListaNessunGenere)) Then
                FilmPerGenere.Add(New ListaEtichettata("[Nessun genere]", indice))
            Else
                ListaNessunGenere.Aggiungi(indice)
            End If
        End If

        'FilmPerAttore
        If (Not IsNothing(Film.Attori)) Then
            For Each attore In Film.Attori
                Dim ListaAttore As ListaEtichettata = FilmPerAttore.Find(Function(l) attore.Equals(l.GetEtichetta))
                If (IsNothing(ListaAttore)) Then
                    FilmPerAttore.Add(New ListaEtichettata(attore, indice))
                Else
                    ListaAttore.Aggiungi(indice)
                End If
            Next
        Else
            Dim ListaNessunAttore As ListaEtichettata = FilmPerAttore.Find(Function(l) l.GetEtichetta.Equals("[Sconosciuti]"))
            If (IsNothing(ListaNessunAttore)) Then
                FilmPerAttore.Add(New ListaEtichettata("[Sconosciuti]", indice))
            Else
                ListaNessunAttore.Aggiungi(indice)
            End If
        End If

        'FilmPerNazione
        If (Not IsNothing(Film.Nazione)) Then
            Dim ListaNazione As ListaEtichettata = FilmPerNazione.Find(Function(l) Film.Nazione.Equals(l.GetEtichetta))
            If (IsNothing(ListaNazione)) Then
                FilmPerNazione.Add(New ListaEtichettata(Film.Nazione, indice))
            Else
                ListaNazione.Aggiungi(indice)
            End If
        Else
            Dim ListaNessunaNazione As ListaEtichettata = FilmPerNazione.Find(Function(l) l.GetEtichetta.Equals("[Sconosciuta]"))
            If (IsNothing(ListaNessunaNazione)) Then
                FilmPerNazione.Add(New ListaEtichettata("[Sconosciuta]", indice))
            Else
                ListaNessunaNazione.Aggiungi(indice)
            End If
        End If

        'FilmPerAutore
        If (Not IsNothing(Film.Autori)) Then
            For Each autore In Film.Autori
                Dim ListaAutore As ListaEtichettata = FilmPerAutore.Find(Function(l) autore.Equals(l.GetEtichetta))
                If (IsNothing(ListaAutore)) Then
                    FilmPerAutore.Add(New ListaEtichettata(autore, indice))
                Else
                    ListaAutore.Aggiungi(indice)
                End If
            Next
        Else
            Dim ListaNessunAutore As ListaEtichettata = FilmPerAutore.Find(Function(l) l.GetEtichetta.Equals("[Nessun autore]"))
            If (IsNothing(ListaNessunAutore)) Then
                FilmPerAutore.Add(New ListaEtichettata("[Nessun autore]", indice))
            Else
                ListaNessunAutore.Aggiungi(indice)
            End If
        End If

        'FilmPerMusicista
        If (Not IsNothing(Film.Musicisti)) Then
            For Each musicista In Film.Musicisti
                Dim ListaMusicista As ListaEtichettata = FilmPerMusicista.Find(Function(l) musicista.Equals(l.GetEtichetta))
                If (IsNothing(ListaMusicista)) Then
                    FilmPerMusicista.Add(New ListaEtichettata(musicista, indice))
                Else
                    ListaMusicista.Aggiungi(indice)
                End If
            Next
        Else
            Dim ListaNessunMusicista As ListaEtichettata = FilmPerMusicista.Find(Function(l) l.GetEtichetta.Equals("[Nessun musicista]"))
            If (IsNothing(ListaNessunMusicista)) Then
                FilmPerMusicista.Add(New ListaEtichettata("[Nessun musicista]", indice))
            Else
                ListaNessunMusicista.Aggiungi(indice)
            End If
        End If
    End Sub

    Sub SelezioneCategoria() Handles AlberoCategorieLibreria.AfterSelect
        Dim selezionato As TreeNode = AlberoCategorieLibreria.SelectedNode
        selezionato.EnsureVisible()

        If (selezionato.Level = 0) Then
            If (selezionato.Index = 0) Then
                NavigaAllaCategoria(0, 0)
            Else
                Dim EraChiuso As Boolean = Not selezionato.IsExpanded
                AlberoCategorieLibreria.CollapseAll()
                If (EraChiuso) Then
                    selezionato.Expand()
                Else
                    Me.Text = Application.ProductName
                    PannelloFiltri.Visible = False
                    ElencoFilm.VirtualListSize = 0
                    ImpostaContenutoSchermataDestra(False, False)
                    VisualizzazioneSchedaPersona(False)
                End If
            End If
        ElseIf (selezionato.Level = 1) Then
            NavigaAllaCategoria(selezionato.Parent.Index, selezionato.Index)
        End If
    End Sub

    Function FormattaDurata(DurataMinuti As UInteger, Sintetico As Boolean) As String
        Const MinutiInUnGiorno As UShort = 1440
        Dim Minuti As UShort = (DurataMinuti Mod 60)

        If (DurataMinuti < 60) Then
            If (Not Sintetico) Then
                Return Minuti.ToString + " min"
            Else
                Return Minuti.ToString + "m"
            End If
        ElseIf (DurataMinuti < MinutiInUnGiorno) Then
            If (Not Sintetico) Then
                Dim Ore As UShort = Math.Floor(DurataMinuti / 60) Mod 24
                Return Ore.ToString + If(Ore = 1, " ora", " ore") + If(Minuti <> 0, ", " + Minuti.ToString + " min", "")
            Else
                Return Math.Round(DurataMinuti / 60, 1).ToString + "h"
            End If
        ElseIf (DurataMinuti > MinutiInUnGiorno) Then
            If (Not Sintetico) Then
                Dim OreArrotondate As UShort = Math.Round(DurataMinuti / 60) Mod 24
                Dim GiorniArrotondati As UShort = Math.Round((DurataMinuti - OreArrotondate * 60) / MinutiInUnGiorno)
                Return GiorniArrotondati.ToString + If(GiorniArrotondati = 1, " giorno, ", " giorni, ") + OreArrotondate.ToString + If(OreArrotondate = 1, " ora", " ore")
            Else
                Return Math.Round(DurataMinuti / MinutiInUnGiorno, 1).ToString + "g"
            End If
        End If
    End Function

    Sub GeneraListaFilmCategoria(IndiceCategoria As UShort, IndiceSelezioneNellaCategoria As UShort)
        ListaIndiciFilmInCategoria.Clear()

        FiltroNazioni.Items.Clear()
        FiltroGeneri.Items.Clear()
        FiltroAudio.Items.Clear()
        FiltroSottotitoli.Items.Clear()
        PannelloFiltri.Visible = True

        Dim ListaCategoria As ListaEtichettata

        Select Case IndiceCategoria
            Case 0 'Tutti i film
                ListaCategoria = TuttiIFilm
                Me.Text = "Tutti i film - " + Application.ProductName
                LabCategoriaScelta.Visible = False
                LabValoreCategoriaScelta.Text = "La tua libreria" '"Tutti i film"
                IconaCategoriaScelta.Image = My.Resources.ciak_semplice
                LabConteggioCategoriaScelta.Text = LibreriaFilm.Count.ToString
                VisualizzazioneSchedaPersona(False)
            Case 1 'Registi
                ListaCategoria = FilmPerRegista.Item(IndiceSelezioneNellaCategoria)
                Me.Text = "Regista: " + ListaCategoria.GetEtichetta + " - " + Application.ProductName
                LabCategoriaScelta.Text = "Film del regista"
                IconaCategoriaScelta.Image = My.Resources.camera
                VisualizzazioneSchedaPersona(True, ListaCategoria)
            Case 2 'Attori
                ListaCategoria = FilmPerAttore.Item(IndiceSelezioneNellaCategoria)
                Me.Text = "Attore: " + ListaCategoria.GetEtichetta + " - " + Application.ProductName
                LabCategoriaScelta.Text = "Film con l'attore"
                IconaCategoriaScelta.Image = My.Resources.persona
                VisualizzazioneSchedaPersona(True, ListaCategoria)
            Case 3 'Generi
                ListaCategoria = FilmPerGenere.Item(IndiceSelezioneNellaCategoria)
                Me.Text = "Genere: " + ListaCategoria.GetEtichetta + " - " + Application.ProductName
                LabCategoriaScelta.Text = "Film di genere"
                Dim IndIcona As Byte = IndiceIconaGenere(ListaCategoria.GetEtichetta)
                If (IndIcona <> 0) Then
                    IconaCategoriaScelta.Image = IconeCategorieLibreria.Images.Item(IndIcona)
                Else
                    IconaCategoriaScelta.Image = My.Resources.generi
                End If
                VisualizzazioneSchedaPersona(False)
            Case 4 'Anni pubblicazione
                ListaCategoria = FilmPerDecennio.Item(IndiceSelezioneNellaCategoria)
                Me.Text = "Decennio: " + ListaCategoria.GetEtichetta + " - " + Application.ProductName
                LabCategoriaScelta.Text = "Film usciti negli anni"
                IconaCategoriaScelta.Image = My.Resources.data
                PanPeriodoAttività.Visible = False
                VisualizzazioneSchedaPersona(False)
            Case 5 'Nazioni
                ListaCategoria = FilmPerNazione.Item(IndiceSelezioneNellaCategoria)
                Me.Text = "Nazione: " + ListaCategoria.GetEtichetta.ToUpper + " - " + Application.ProductName
                LabCategoriaScelta.Text = "Film di nazionalità"
                ImpostaRisorsaIconaNazione(ListaCategoria.GetEtichetta, IconaCategoriaScelta, False)
                VisualizzazioneSchedaPersona(False)
            Case 6 'Saghe
                'TODO
            Case 7 'Autori
                ListaCategoria = FilmPerAutore.Item(IndiceSelezioneNellaCategoria)
                Me.Text = "Autore: " + ListaCategoria.GetEtichetta + " - " + Application.ProductName
                LabCategoriaScelta.Text = "Film scritti da"
                IconaCategoriaScelta.Image = My.Resources.autore
                VisualizzazioneSchedaPersona(True, ListaCategoria)
            Case 8 'Musicisti
                ListaCategoria = FilmPerMusicista.Item(IndiceSelezioneNellaCategoria)
                Me.Text = "Musicista: " + ListaCategoria.GetEtichetta + " - " + Application.ProductName
                LabCategoriaScelta.Text = "Film musicati da"
                IconaCategoriaScelta.Image = My.Resources.musica
                VisualizzazioneSchedaPersona(True, ListaCategoria)
            Case 9 'Temi
            Case 10 'Ambientazione
        End Select

        If (IndiceCategoria <> 0) Then LabCategoriaScelta.Visible = True
        If (Not IsNothing(ListaCategoria)) Then
            LabValoreCategoriaScelta.Text = ListaCategoria.GetEtichetta
            LabConteggioCategoriaScelta.Text = ListaCategoria.Conteggio.ToString
            If (IndiceCategoria <> 4) Then ImpostaAnnoAttività(ListaCategoria.GetMinAnno, ListaCategoria.GetMaxAnno)
            LabDurataCat.Text = FormattaDurata(ListaCategoria.GetDurataTotMinuti, False)

            'Incasso medio
            If (ListaCategoria.GetIncassoMedio > 0) Then
                VisualizzaValutazione(ListaCategoria.GetIncassoMedio, 2800000000, IncassiCat, Label64, Panel17, True, {0, 255, 0})
            Else
                Panel17.Visible = False
            End If

            'Voto IMDB medio
            If (ListaCategoria.GetVotoIMDBMedio > 0) Then
                VisualizzaValutazione(ListaCategoria.GetVotoIMDBMedio, 10, VotoIMDBCat, Nothing, Panel15)
            Else
                Panel15.Visible = False
            End If

            'Num voti IMDB medio
            If (ListaCategoria.GetNumVotiIMDBMedio > 0) Then
                VisualizzaValutazione(ListaCategoria.GetNumVotiIMDBMedio, 2500000, NumVotiIMDBCat, Label54, Panel16, True, {102, 255, 255})
            Else
                Panel16.Visible = False
            End If

            'Metacritic medio
            If (ListaCategoria.GetVotoMetacriticMedio > 0) Then
                VisualizzaValutazione(ListaCategoria.GetVotoMetacriticMedio, 100, VotoMetacriticCat, Nothing, Panel18)
            Else
                Panel18.Visible = False
            End If

            'Rotten Tomatoes medio
            If (ListaCategoria.GetVotoRottenMedio > 0) Then
                VisualizzaValutazione(ListaCategoria.GetVotoRottenMedio, 100, RottenCat, Nothing, Panel19)
            Else
                Panel19.Visible = False
            End If

            ListaIndiciFilmInCategoria.AddRange(ListaCategoria.GetArray)

            For Each indice In ListaIndiciFilmInCategoria
                Dim Nazione As String = LibreriaFilm.Item(indice).Nazione
                If (Not IsNothing(Nazione)) Then
                    If (Not FiltroNazioni.Items.Contains(Nazione.ToUpper)) Then FiltroNazioni.Items.Add(Nazione.ToUpper)
                End If

                Dim Generi As List(Of String) = LibreriaFilm.Item(indice).Generi
                If (Not IsNothing(Generi)) Then
                    For Each genere As String In Generi
                        If (Not FiltroGeneri.Items.Contains(genere)) Then FiltroGeneri.Items.Add(genere)
                    Next
                End If

                Dim Sonori As List(Of Sonoro) = LibreriaFilm.Item(indice).Sonori
                If (Not IsNothing(Sonori)) Then
                    For Each audio As Sonoro In Sonori
                        If (Not IsNothing(audio.Lingua) AndAlso Not FiltroAudio.Items.Contains(audio.Lingua.ToUpper)) Then FiltroAudio.Items.Add(audio.Lingua.ToUpper)
                    Next
                End If

                Dim Sottotitoli As List(Of Sottotitolo) = LibreriaFilm.Item(indice).Sottotitoli
                If (Not IsNothing(Sottotitoli)) Then
                    For Each sottotitolo As Sottotitolo In Sottotitoli
                        If (Not IsNothing(sottotitolo.Lingua) AndAlso Not FiltroSottotitoli.Items.Contains(sottotitolo.Lingua.ToUpper)) Then FiltroSottotitoli.Items.Add(sottotitolo.Lingua.ToUpper)
                    Next
                End If
            Next
        End If

        GeneraListaFilmFiltrati()
    End Sub

    Sub VisualizzazioneSchedaPersona(VisualizzareScheda As Boolean, Optional ListaCategoria As ListaEtichettata = Nothing)
        If (VisualizzareScheda AndAlso Not ListaCategoria.GetEtichetta.StartsWith("[")) Then
            Dim NomeCognome As String() = MainModule.SeparaNomeCognome(ListaCategoria.GetEtichetta)
            LabValoreCategoriaScelta.Text = ListaCategoria.GetEtichetta

            'Imposto anni di attività
            If (ListaCategoria.GetMinAnno <> UShort.MaxValue And ListaCategoria.GetMaxAnno <> UShort.MinValue) Then
                PanPeriodoAttività.Visible = True
                If (ListaCategoria.GetMinAnno = ListaCategoria.GetMaxAnno) Then
                    Label13.Text = ListaCategoria.GetMinAnno.ToString
                Else
                    Label13.Text = ListaCategoria.GetMinAnno.ToString + " - " + ListaCategoria.GetMaxAnno.ToString
                End If
            Else
                PanPeriodoAttività.Visible = False
            End If

            'Cerco e imposto immagine
            Dim PathImmagine As String = MainModule.PercorsoImmaginePersona(NomeCognome(1), If(NomeCognome(0).Length > 0, NomeCognome(0).Chars(0), Chr(0)))
            If (My.Computer.FileSystem.FileExists(PathImmagine)) Then
                PicImgPersona.ImageLocation = PathImmagine
            Else
                Me.UseWaitCursor = True
                Dim PathTemporaneo() As String = MainModule.SalvaImmaginiGoogle("site:imdb.com " + ListaCategoria.GetEtichetta, 1)
                If (Not IsNothing(PathTemporaneo) And PathTemporaneo.Length >= 1) Then
                    My.Computer.FileSystem.MoveFile(PathTemporaneo(0), PathImmagine, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
                    PicImgPersona.ImageLocation = PathImmagine
                Else
                    PicImgPersona.ImageLocation = ""
                End If
                Me.UseWaitCursor = False
            End If
            PicImgPersona.Visible = True

        Else
            PicImgPersona.Visible = False
        End If
    End Sub

    Sub ImpostaAnnoAttività(MinAnno As UShort, MaxAnno As UShort)
        If (MinAnno <> UShort.MaxValue And MaxAnno <> UShort.MinValue) Then
            Label12.Visible = True
            Label13.Visible = True
            If (MinAnno = MaxAnno) Then
                Label13.Text = MinAnno.ToString
            Else
                Label13.Text = MinAnno.ToString + " - " + MaxAnno.ToString
            End If
        Else
            Label12.Visible = False
            Label13.Visible = False
        End If
        PanPeriodoAttività.Visible = True
    End Sub

    Sub GeneraListaFilmFiltrati()
        ListaIndiciFilmFiltrati.Clear()
        For Each indice As UShort In ListaIndiciFilmInCategoria
            Dim Film As Film = LibreriaFilm.Item(indice)
            Dim FiltriSuperati As Boolean = True

            ' Testo
            If (CasellaRicerca.Text.Length > 0) Then
                Dim TokenRicerca As String() = CasellaRicerca.Text.ToLower.Split(" ")
                Dim NomeSenzaEstensione As String = Film.NomeFile.Replace("." + Film.Estensione, "").ToLower
                For Each token As String In TokenRicerca
                    If (token.Equals(" ")) Then Continue For
                    If (Not NomeSenzaEstensione.Contains(token)) Then FiltriSuperati = False
                Next
                'Dim TrovatoQualcosa As Boolean = False

                'If (Not IsNothing(Film.TitoloITA)) Then
                '    If (Film.TitoloITA.Contains(CasellaRicerca.Text)) Then TrovatoQualcosa = True
                'End If

                'If (Not TrovatoQualcosa And Not IsNothing(Film.Registi)) Then
                '    For Each regista In Film.Registi
                '        If (regista.Contains(CasellaRicerca.Text)) Then TrovatoQualcosa = True
                '    Next
                'End If

                'If (Not TrovatoQualcosa And Not IsNothing(Film.Attori)) Then
                '    For Each attore In Film.Attori
                '        If (attore.Contains(CasellaRicerca.Text)) Then TrovatoQualcosa = True
                '    Next
                'End If

                'If (Not TrovatoQualcosa) Then FiltriSuperati = False
            End If

            ' Anno min
            If (FiltriSuperati AndAlso FiltroAnnoMin.Value > FiltroAnnoMin.Minimum) Then
                If (IsNothing(Film.Anno) Or Film.Anno = 0) Then
                    FiltriSuperati = False
                Else
                    If (Film.Anno < FiltroAnnoMin.Value) Then FiltriSuperati = False
                End If
            End If

            ' Anno max
            If (FiltriSuperati AndAlso FiltroAnnoMax.Value < FiltroAnnoMax.Maximum) Then
                If (IsNothing(Film.Anno) Or Film.Anno = 0) Then
                    FiltriSuperati = False
                Else
                    If (Film.Anno > FiltroAnnoMax.Value) Then FiltriSuperati = False
                End If
            End If

            ' Durata
            If (FiltriSuperati And FiltroDurataMin.Value > 0) Then
                If (IsNothing(Film.DurataMinuti) Or Film.DurataMinuti = 0) Then
                    FiltriSuperati = False
                Else
                    If (Film.DurataMinuti < FiltroDurataMin.Value Or Film.DurataMinuti > FiltroDurataMax.Value) Then FiltriSuperati = False
                End If
            End If

            ' Risoluzione
            If (FiltriSuperati AndAlso FiltroRisoluzioneMin.Value > 0) Then
                If (IsNothing(Film.Risoluzione)) Then
                    FiltriSuperati = False
                Else
                    Select Case FiltroRisoluzioneMin.Value
                        Case 1
                            If (Film.Risoluzione.Height < 220) Then FiltriSuperati = False
                        Case 2
                            If (Film.Risoluzione.Height < 460) Then FiltriSuperati = False
                        Case 3
                            If (Film.Risoluzione.Height < 700) Then FiltriSuperati = False
                        Case 4
                            If (Film.Risoluzione.Height < 1000) Then FiltriSuperati = False
                        Case 5
                            If (Film.Risoluzione.Height < 1400) Then FiltriSuperati = False
                        Case 6
                            If (Film.Risoluzione.Height < 1700) Then FiltriSuperati = False
                        Case 7
                            If (Film.Risoluzione.Height < 4300) Then FiltriSuperati = False
                    End Select
                End If
            End If

            ' Bitrate
            Dim MinBitrateMBs As Double = GetValoreFiltroBitrate()
            If (FiltriSuperati And MinBitrateMBs > 0) Then
                If (IsNothing(Film.BitrateComplessivoKBpS) Or Film.BitrateComplessivoKBpS = 0) Then
                    FiltriSuperati = False
                Else
                    If ((Film.BitrateComplessivoKBpS / 1000) < MinBitrateMBs) Then FiltriSuperati = False
                End If
            End If

            ' Nazioni
            If (FiltriSuperati AndAlso FiltroNazioni.SelectedItems.Count > 0) Then
                If (IsNothing(Film.Nazione)) Then
                    FiltriSuperati = False
                ElseIf (Not FiltroNazioni.CheckedItems.Contains(Film.Nazione)) Then
                    FiltriSuperati = False
                End If
            End If

            ' Generi
            If (FiltriSuperati AndAlso FiltroGeneri.SelectedItems.Count > 0) Then
                For Each genere As String In FiltroGeneri.SelectedItems
                    If (IsNothing(Film.Generi)) Then
                        FiltriSuperati = False
                    ElseIf (Not Film.Generi.Contains(genere)) Then
                        FiltriSuperati = False
                    End If
                Next
            End If

            ' Lingua audio
            If (FiltriSuperati AndAlso FiltroAudio.SelectedItems.Count > 0) Then
                For Each lingua As String In FiltroAudio.SelectedItems
                    If (IsNothing(Film.Sonori)) Then
                        FiltriSuperati = False
                    ElseIf (Not Film.Sonori.Exists(Function(x) x.Lingua.ToUpper.Equals(lingua))) Then
                        FiltriSuperati = False
                    End If
                Next
            End If

            ' Lingua sottotitoli
            If (FiltriSuperati AndAlso FiltroSottotitoli.SelectedItems.Count > 0) Then
                For Each lingua As String In FiltroSottotitoli.SelectedItems
                    If (IsNothing(Film.Sottotitoli)) Then
                        FiltriSuperati = False
                    ElseIf (Not Film.Sottotitoli.Exists(Function(x) x.Lingua.ToUpper.Equals(lingua))) Then
                        FiltriSuperati = False
                    End If
                Next
            End If

            ' Voto IMDB
            If (FiltriSuperati AndAlso FiltroMinVotoIMDB.Value > FiltroMinVotoIMDB.Minimum) Then
                If (IsNothing(Film.VotoIMDB) OrElse Film.VotoIMDB = 0) Then
                    FiltriSuperati = False
                Else
                    If (Film.VotoIMDB < (FiltroMinVotoIMDB.Value / 10)) Then FiltriSuperati = False
                End If
            End If

            ' Num voti IMDB
            If (FiltriSuperati AndAlso FiltroMinNumVotiIMDB.Value > FiltroMinNumVotiIMDB.Minimum) Then
                If (IsNothing(Film.NumVotiIMDB) OrElse Film.NumVotiIMDB = 0) Then
                    FiltriSuperati = False
                Else
                    If (Film.NumVotiIMDB < (FiltroMinNumVotiIMDB.Value * 1000)) Then FiltriSuperati = False
                End If
            End If

            ' Incasso
            If (FiltriSuperati AndAlso FiltroMinIncasso.Value > FiltroMinIncasso.Minimum) Then
                If (IsNothing(Film.IncassoDollari) OrElse Film.IncassoDollari = 0) Then
                    FiltriSuperati = False
                Else
                    If (Film.IncassoDollari < (FiltroMinIncasso.Value * 1000)) Then FiltriSuperati = False
                End If
            End If

            ' Voto Metacritic
            If (FiltriSuperati AndAlso FiltroMinVotoMetacritic.Value > FiltroMinVotoMetacritic.Minimum) Then
                If (IsNothing(Film.VotoMetacritic) OrElse Film.VotoMetacritic = 0) Then
                    FiltriSuperati = False
                Else
                    If (Film.VotoMetacritic < FiltroMinVotoMetacritic.Value) Then FiltriSuperati = False
                End If
            End If

            ' Voto Rotten Tomatoes
            If (FiltriSuperati AndAlso FiltroMinVotoRotten.Value > FiltroMinVotoRotten.Minimum) Then
                If (IsNothing(Film.VotoRottenTomatoes) OrElse Film.VotoRottenTomatoes = 0) Then
                    FiltriSuperati = False
                Else
                    If (Film.VotoRottenTomatoes < FiltroMinVotoRotten.Value) Then FiltriSuperati = False
                End If
            End If

            ' Premi ricevuti
            If (FiltriSuperati AndAlso RadioButton2.Checked AndAlso Film.OscarNominati + Film.BAFTANominati + Film.AltriPremiNominati = 0) Then
                FiltriSuperati = False
            End If
            If (FiltriSuperati AndAlso RadioButton3.Checked AndAlso Film.OscarNominati = 0) Then
                FiltriSuperati = False
            End If
            If (FiltriSuperati AndAlso RadioButton4.Checked AndAlso Film.OscarVinti + Film.BAFTAVinti + Film.AltriPremiVinti = 0) Then
                FiltriSuperati = False
            End If
            If (FiltriSuperati AndAlso RadioButton5.Checked AndAlso Film.OscarVinti = 0) Then
                FiltriSuperati = False
            End If

            If (FiltriSuperati = True) Then ListaIndiciFilmFiltrati.Add(indice)
        Next

        'Segnalo esito filtraggio
        If (ListaIndiciFilmFiltrati.Count < ListaIndiciFilmInCategoria.Count) Then
            PannelloEsitoFiltri.Visible = True
            LabEsitoFiltri.Text = "(visualizzati " + ListaIndiciFilmFiltrati.Count.ToString + " film su " + ListaIndiciFilmInCategoria.Count.ToString + ")"
        Else
            PannelloEsitoFiltri.Visible = False
        End If
    End Sub

    Sub AggiornaIconeDaLista()
        ForzaAggiornamentoIcone()
        ElencoFilm.VirtualListSize = ListaIndiciFilmFiltrati.Count

        ImpostaContenutoSchermataDestra(False, True)

        'For Each indice In ListaIndiciFilmFiltrati
        '    Dim Film As Film = ListaFilm(indice)
        '    Dim icona As ListViewItem = GeneraIcona(Film)
        '    ElencoFilm.Items.Add(icona)
        'Next
        'ElencoFilm.ArrangeIcons()
        AggiornaColonneInElencoFilm()
        ColAnno.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
        ColNazione.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub

    Private Sub ElencoFilm_RetrieveVirtualItem(sender As Object, e As RetrieveVirtualItemEventArgs) Handles ElencoFilm.RetrieveVirtualItem
        'check to see if the requested item is currently in the cache
        If ((Not IsNothing(CacheIcone)) AndAlso e.ItemIndex >= IndicePrimoElementoInCacheIcone AndAlso
            e.ItemIndex < IndicePrimoElementoInCacheIcone + CacheIcone.Length) Then
            'A cache hit, so get the ListViewItem from the cache instead of making a new one.
            e.Item = CacheIcone(e.ItemIndex - IndicePrimoElementoInCacheIcone)
        ElseIf (e.ItemIndex < ListaIndiciFilmFiltrati.Count) Then
            'A cache miss, so create a new ListViewItem and pass it back.
            Dim indice As UShort = ListaIndiciFilmFiltrati.Item(e.ItemIndex)
            Dim Film As Film = LibreriaFilm(indice)
            Dim icona As ListViewItem = GeneraIcona(Film)
            e.Item = icona
            'ColAnno.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
            'ColNazione.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
        Else
            'Viene richiesta un'icona fuori range: genero icona fittizia
            e.Item = New ListViewItem("foo")
        End If
    End Sub

    Private Sub ElencoFilm_CacheVirtualItems(sender As Object, e As CacheVirtualItemsEventArgs) Handles ElencoFilm.CacheVirtualItems
        'We've gotten a request to refresh the cache. First check if it's really neccesary.
        If ((Not IsNothing(CacheIcone)) AndAlso e.StartIndex >= IndicePrimoElementoInCacheIcone AndAlso e.EndIndex <= (IndicePrimoElementoInCacheIcone + CacheIcone.Length)) Then
            'If the newly requested cache is a subset of the old cache, no need to rebuild everything, so do nothing.
            Exit Sub
        End If

        'Now we need to rebuild the cache.
        IndicePrimoElementoInCacheIcone = e.StartIndex
        Dim length As Integer = e.EndIndex - e.StartIndex + 1 'indexes are inclusive
        CacheIcone = New ListViewItem(length) {}
        SchermateFilmPiccole.Images.Clear()
        SchermateFilmGrandi.Images.Clear()
        PosterFilmPiccoli.Images.Clear()
        PosterFilmGrandi.Images.Clear()

        'Fill the cache with the appropriate ListViewItems.
        Dim i As Integer
        For i = 0 To length
            If (IndicePrimoElementoInCacheIcone + i < ListaIndiciFilmFiltrati.Count) Then
                Dim indice As UShort = ListaIndiciFilmFiltrati.Item(IndicePrimoElementoInCacheIcone + i)
                Dim Film As Film = LibreriaFilm(indice)
                Dim icona As ListViewItem = GeneraIcona(Film)
                CacheIcone(i) = icona
            Else
                CacheIcone(i) = Nothing
            End If
        Next i
    End Sub

    Sub AggiornaColonneInElencoFilm()
        ElencoFilm.Columns.Clear()
        Select Case ElencoFilm.View
            Case View.Details
                ElencoFilm.Columns.Add(ColTitolo)
                ElencoFilm.Columns.Add(ColAnno)
                ElencoFilm.Columns.Add(ColNazione)
                ElencoFilm.Columns.Add(ColRegisti)
                ElencoFilm.Columns.Add(ColGeneri)
                ElencoFilm.Columns.Add(ColAttori)
                ElencoFilm.Columns.Add(ColAutori)
                ElencoFilm.Columns.Add(ColMusicisti)
            Case View.Tile
                ElencoFilm.Columns.Add(ColTitolo)
                ElencoFilm.Columns.Add(ColAnno)
                ElencoFilm.Columns.Add(ColGeneri)
                ElencoFilm.Columns.Add(ColRegisti)
            Case View.SmallIcon
                ElencoFilm.Columns.Add(ColTitolo)
                'ElencoFilm.Columns.Add(ColAnno)
                'ElencoFilm.Columns.Add(ColRegisti)
                ElencoFilm.Columns.Add(ColGeneri)
            Case View.LargeIcon
                ElencoFilm.Columns.Add(ColTitolo)
                ElencoFilm.Columns.Add(ColAnno)
                'ElencoFilm.Columns.Add(ColRegisti)
                'ElencoFilm.Columns.Add(ColGeneri)
            Case View.List
                ElencoFilm.Columns.Add(ColTitolo)
                'ElencoFilm.Columns.Add(ColAnno)
                'ElencoFilm.Columns.Add(ColRegisti)
                'ElencoFilm.Columns.Add(ColGeneri)
        End Select
    End Sub

    Public Enum FonteIconeValoriCategoria As Byte
        Nessuna
        Generi
        Nazioni
    End Enum

    Sub PopolaRamoCategoria(Ramo As Windows.Forms.TreeNode, ListaValoriCategoria As List(Of ListaEtichettata), IconeDaUsare As FonteIconeValoriCategoria,
                            Ordinamento As MainModule.OrdinamentoValoriCategorie, Info As MainModule.InfoCategoria)
        Ramo.Nodes.Clear()

        Select Case Ordinamento
            Case OrdinamentoValoriCategorie.NumFilm
                ListaValoriCategoria.Sort(Function(A As ListaEtichettata, B As ListaEtichettata) B.Conteggio - A.Conteggio)
            Case OrdinamentoValoriCategorie.DurataFilm
                ListaValoriCategoria.Sort(Function(A As ListaEtichettata, B As ListaEtichettata) Integer.Parse(B.GetDurataTotMinuti) - Integer.Parse(A.GetDurataTotMinuti))
            Case OrdinamentoValoriCategorie.NomeAsc
                ListaValoriCategoria.Sort(Function(A As ListaEtichettata, B As ListaEtichettata) String.Compare(A.GetCognomeNome, B.GetCognomeNome))
            Case OrdinamentoValoriCategorie.UltimaUscitaDesc
                ListaValoriCategoria.Sort(Function(A As ListaEtichettata, B As ListaEtichettata) Short.Parse(B.GetMaxAnno) - Short.Parse(A.GetMaxAnno))
            Case OrdinamentoValoriCategorie.UltimaUscitaAsc
                ListaValoriCategoria.Sort(Function(A As ListaEtichettata, B As ListaEtichettata) Short.Parse(A.GetMaxAnno) - Short.Parse(B.GetMaxAnno))
        End Select

        For Each ValoreCategoria In ListaValoriCategoria
            Dim elem As New TreeNode()
            If (ValoreCategoria.GetEtichetta.StartsWith("[")) Then
                elem.Text = ValoreCategoria.GetEtichetta
                elem.ForeColor = Color.SkyBlue
            Else
                elem.Text = ValoreCategoria.GetCognomeNome(True)
            End If

            If (Info <> InfoCategoria.Nessuna) Then elem.Text += " (" 'Chr(10) + Chr(13)

            Select Case Info
                Case InfoCategoria.ConteggioFilm
                    elem.Text += ValoreCategoria.Conteggio.ToString + ")"
                Case InfoCategoria.DurataFilm
                    elem.Text += FormattaDurata(ValoreCategoria.GetDurataTotMinuti, True) + ")"
                Case InfoCategoria.PeriodoAttivita
                    elem.Text += FormattaPeriodoAttivita(ValoreCategoria.GetMinAnno, ValoreCategoria.GetMaxAnno) + ")"
            End Select

            Dim IndiceIcona As UShort
            Select Case IconeDaUsare
                Case FonteIconeValoriCategoria.Nessuna
                    IndiceIcona = 0
                Case FonteIconeValoriCategoria.Generi
                    IndiceIcona = IndiceIconaGenere(ValoreCategoria.GetEtichetta)
                Case FonteIconeValoriCategoria.Nazioni
                    IndiceIcona = IndiceIconaNazione(ValoreCategoria.GetEtichetta)
            End Select
            elem.ImageIndex = IndiceIcona
            elem.SelectedImageIndex = IndiceIcona

            Ramo.Nodes.Add(elem)
        Next
    End Sub

    Function FormattaPeriodoAttivita(MinAnno As UShort, MaxAnno As UShort) As String
        If (MinAnno <> UShort.MaxValue And MaxAnno <> UShort.MinValue) Then
            If (MinAnno = MaxAnno) Then
                Return MinAnno.ToString
            Else
                Return MinAnno.ToString + "-" + MaxAnno.ToString.Substring(2, 2)
            End If
        Else
            Return "?"
        End If
    End Function

    Public Sub AggiornaAlberoCategorie()
        ' ======================= AGGIORNO menu impostazioni albero categorie ======================

        ' Ordinamento categorie
        For Each item As ToolStripMenuItem In DropDownOrdinamentoCategorie.DropDownItems
            item.Checked = False
        Next
        Select Case My.Settings.CategorieOrdinamento
            Case MainModule.OrdinamentoValoriCategorie.NumFilm
                NumeroFilmToolStripMenuItem.Checked = True
            Case MainModule.OrdinamentoValoriCategorie.DurataFilm
                DurataFilmToolStripMenuItem.Checked = True
            Case MainModule.OrdinamentoValoriCategorie.NomeAsc
                AlfabeticoToolStripMenuItem.Checked = True
            Case MainModule.OrdinamentoValoriCategorie.UltimaUscitaDesc
                EpocaDiAttivitàultimaUscitaPiùRecenteToolStripMenuItem.Checked = True
            Case MainModule.OrdinamentoValoriCategorie.UltimaUscitaAsc
                EpocaDiAttivitàultimaUscitaPiùRemotaToolStripMenuItem.Checked = True
        End Select

        ' Info da visualizzare
        For Each item As ToolStripMenuItem In DropDownInfoCategoria.DropDownItems
            item.Checked = False
        Next
        Select Case My.Settings.CategorieInfo
            Case MainModule.InfoCategoria.Nessuna
                NessunaInformazioneToolStripMenuItem.Checked = True
            Case MainModule.InfoCategoria.PeriodoAttivita
                PeriodoDiAttivitàToolStripMenuItem.Checked = True
            Case MainModule.InfoCategoria.DurataFilm
                DurataFilmToolStripMenuItem1.Checked = True
            Case MainModule.InfoCategoria.ConteggioFilm
                ConteggioFilmToolStripMenuItem.Checked = True
        End Select

        ' ======================= AGGIORNO TreeView AlberoCategorieLibreria =======================
        AlberoCategorieLibreria.Nodes.Item(0).Text = "Tutti i film"

        AlberoCategorieLibreria.Nodes.Item(0).Text += Chr(10) + Chr(13) + "(" + LibreriaFilm.Count.ToString + ")"
        'Select Case My.Settings.CategorieInfo
        '    Case MainModule.InfoCategoria.ConteggioFilm
        '        AlberoCategorieLibreria.Nodes.Item(0).Text += Chr(10) + Chr(13) + "(" + LibreriaFilm.Count.ToString + ")"
        '    Case MainModule.InfoCategoria.DurataFilm
        '        'TODO
        '    Case MainModule.InfoCategoria.PeriodoAttivita
        '        'TODO
        'End Select

        'Registi
        PopolaRamoCategoria(AlberoCategorieLibreria.Nodes.Item(1), FilmPerRegista, FonteIconeValoriCategoria.Nessuna, My.Settings.CategorieOrdinamento, My.Settings.CategorieInfo)

        'Attori
        PopolaRamoCategoria(AlberoCategorieLibreria.Nodes.Item(2), FilmPerAttore, FonteIconeValoriCategoria.Nessuna, My.Settings.CategorieOrdinamento, My.Settings.CategorieInfo)

        'Generi
        PopolaRamoCategoria(AlberoCategorieLibreria.Nodes.Item(3), FilmPerGenere, FonteIconeValoriCategoria.Generi, My.Settings.CategorieOrdinamento, My.Settings.CategorieInfo)

        'Decenni
        PopolaRamoCategoria(AlberoCategorieLibreria.Nodes.Item(4), FilmPerDecennio, FonteIconeValoriCategoria.Nessuna, My.Settings.CategorieOrdinamento, My.Settings.CategorieInfo)

        'Nazioni
        PopolaRamoCategoria(AlberoCategorieLibreria.Nodes.Item(5), FilmPerNazione, FonteIconeValoriCategoria.Nazioni, My.Settings.CategorieOrdinamento, My.Settings.CategorieInfo)

        'Autori
        PopolaRamoCategoria(AlberoCategorieLibreria.Nodes.Item(7), FilmPerAutore, FonteIconeValoriCategoria.Nessuna, My.Settings.CategorieOrdinamento, My.Settings.CategorieInfo)

        'Musicisti
        PopolaRamoCategoria(AlberoCategorieLibreria.Nodes.Item(8), FilmPerMusicista, FonteIconeValoriCategoria.Nessuna, My.Settings.CategorieOrdinamento, My.Settings.CategorieInfo)
    End Sub

    Private Sub BottCancellaFiltri_Click(sender As Object, e As EventArgs) Handles BottCancellaFiltri.Click
        CasellaRicerca.Text = ""

        FiltroAnnoMin.Value = FiltroAnnoMin.Minimum
        FiltroAnnoMax.Value = FiltroAnnoMax.Maximum

        FiltroDurataMin.Value = FiltroDurataMin.Minimum
        FiltroDurataMax.Value = FiltroDurataMax.Maximum

        FiltroRisoluzioneMin.Value = FiltroRisoluzioneMin.Minimum
        FiltroBitrateMin.Value = FiltroBitrateMin.Minimum

        FiltroMinIncasso.Value = FiltroMinIncasso.Minimum
        FiltroMinNumVotiIMDB.Value = FiltroMinNumVotiIMDB.Minimum
        FiltroMinVotoIMDB.Value = FiltroMinVotoIMDB.Minimum
        FiltroMinVotoMetacritic.Value = FiltroMinVotoMetacritic.Minimum
        FiltroMinVotoRotten.Value = FiltroMinVotoRotten.Minimum
        RadioButton1.Checked = True

        If (FiltroNazioni.SelectedItems.Count > 0) Then
            For i As UInteger = 0 To FiltroNazioni.Items.Count - 1
                FiltroNazioni.SetItemChecked(i, False)
            Next
        End If

        If (FiltroGeneri.SelectedItems.Count > 0) Then
            For i As UInteger = 0 To FiltroGeneri.Items.Count - 1
                FiltroGeneri.SetItemChecked(i, False)
            Next
        End If

        If (FiltroAudio.SelectedItems.Count > 0) Then
            For i As UInteger = 0 To FiltroAudio.Items.Count - 1
                FiltroAudio.SetItemChecked(i, False)
            Next
        End If

        If (FiltroSottotitoli.SelectedItems.Count > 0) Then
            For i As UInteger = 0 To FiltroSottotitoli.Items.Count - 1
                FiltroSottotitoli.SetItemChecked(i, False)
            Next
        End If

        FiltraLista()
    End Sub

    Sub FiltraLista() Handles BottCerca.Click, BottFiltra.Click
        GeneraListaFilmFiltrati()
        AggiornaIconeDaLista()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ButtTogglePannelloSx.Click
        SplitContainerSX_C.Panel1Collapsed = Not SplitContainerSX_C.Panel1Collapsed
        My.Settings.PannelloSxChiuso = SplitContainerSX_C.Panel1Collapsed
        My.Settings.Save()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ButtTogglePannelloDx.Click
        SplitContainerCSX_DX.Panel2Collapsed = Not SplitContainerCSX_DX.Panel2Collapsed
        My.Settings.PannelloDxChiuso = SplitContainerCSX_DX.Panel2Collapsed
        My.Settings.Save()
    End Sub

    Function GeneraIcona(Film As Film) As ListViewItem
        Dim elemento As New ListViewItem()
        elemento.Text = Film.TitoloITA

        elemento.SubItems.Add(If(IsNothing(Film.Anno), "?", Film.Anno.ToString))
        elemento.SubItems.Item(elemento.SubItems.Count - 1).Name = "ColAnno"
        elemento.SubItems.Add(If(IsNothing(Film.Nazione), "?", Film.Nazione))
        'Dim subs As New ListViewItem.ListViewSubItem
        elemento.SubItems.Item(elemento.SubItems.Count - 1).Name = "ColNazione"
        elemento.SubItems.Add(If(IsNothing(Film.Registi), "?", DaListaAStringa(Film.Registi, True)))
        elemento.SubItems.Item(elemento.SubItems.Count - 1).Name = "ColRegisti"
        elemento.SubItems.Add(If(IsNothing(Film.Generi), "?", DaListaAStringa(Film.Generi)))
        elemento.SubItems.Item(elemento.SubItems.Count - 1).Name = "ColGeneri"
        elemento.SubItems.Add(If(IsNothing(Film.Attori), "", DaListaAStringa(Film.Attori, True)))
        elemento.SubItems.Item(elemento.SubItems.Count - 1).Name = "ColAttori"
        elemento.SubItems.Add(If(IsNothing(Film.Autori), "", DaListaAStringa(Film.Autori, True)))
        elemento.SubItems.Item(elemento.SubItems.Count - 1).Name = "ColAutori"
        elemento.SubItems.Add(If(IsNothing(Film.Musicisti), "", DaListaAStringa(Film.Musicisti, True)))
        elemento.SubItems.Item(elemento.SubItems.Count - 1).Name = "ColMusicisti"

        ' Risoluzione
        'TODO
        'elemento.BackColor = 

        ' Icona
        Dim PercorsoSchermata As String = MainModule.PercorsoSchermataFilm(Film.NomeFile)
        Dim AbbiamoSchermata As Boolean = My.Computer.FileSystem.FileExists(PercorsoSchermata)
        Dim PercorsoPoster As String = MainModule.PercorsoPosterFilm(Film.NomeFile)
        Dim AbbiamoPoster As Boolean = My.Computer.FileSystem.FileExists(PercorsoPoster)

        If (My.Settings.PreferisciIconePoster = True And AbbiamoPoster) Then
            Dim Poster As Image = Image.FromFile(PercorsoPoster)
            PosterFilmPiccoli.Images.Add(Poster)
            PosterFilmGrandi.Images.Add(Poster)
            elemento.ImageIndex = PosterFilmPiccoli.Images.Count - 1
        ElseIf (My.Settings.PreferisciIconePoster = True And Not AbbiamoPoster And AbbiamoSchermata) Then
            Dim Schermata As Image = Image.FromFile(PercorsoSchermata)
            PosterFilmPiccoli.Images.Add(Schermata)
            PosterFilmGrandi.Images.Add(Schermata)
            elemento.ImageIndex = PosterFilmPiccoli.Images.Count - 1
        ElseIf (My.Settings.PreferisciIconePoster = False And AbbiamoSchermata) Then
            Dim Schermata As Image = Image.FromFile(PercorsoSchermata)
            SchermateFilmPiccole.Images.Add(Schermata)
            SchermateFilmGrandi.Images.Add(Schermata)
            elemento.ImageIndex = SchermateFilmPiccole.Images.Count - 1
        ElseIf (My.Settings.PreferisciIconePoster = False And Not AbbiamoSchermata And AbbiamoPoster) Then
            Dim Poster As Image = Image.FromFile(PercorsoPoster)
            SchermateFilmPiccole.Images.Add(Poster)
            SchermateFilmGrandi.Images.Add(Poster)
            elemento.ImageIndex = SchermateFilmPiccole.Images.Count - 1
        End If

        Return elemento
    End Function

    Sub SvuotaElencoFilm()
        ImpostaContenutoSchermataDestra(False, True)
        LibreriaFilm.Clear()
        'ElencoFilm.Items.Clear()
        ElencoFilm.VirtualListSize = 0
        SchermateFilmPiccole.Images.Clear()
        SchermateFilmGrandi.Images.Clear()
        PosterFilmPiccoli.Images.Clear()
        PosterFilmGrandi.Images.Clear()

        FilmPerRegista.Clear()
        FilmPerDecennio.Clear()
        FilmPerAttore.Clear()
        FilmPerGenere.Clear()
        FilmPerNazione.Clear()
        FilmPerAutore.Clear()
        FilmPerMusicista.Clear()
    End Sub

    Sub RegolaAltezzaElenco(Lista As ListView)
        If (Lista.Items.Count <= 0) Then Return
        Dim LarghezzaColonne As UShort = 0
        Dim AltezzaElementi As UShort = 0
        For Each elemento As ListViewItem In Lista.Items
            Dim largh As Short = elemento.Bounds.Width
            If (largh > LarghezzaColonne) Then LarghezzaColonne = largh
            Dim altezza As Short = elemento.Bounds.Height
            If (altezza > AltezzaElementi) Then AltezzaElementi = altezza
        Next

        Dim NumColonne As UShort = Math.Max(1, Math.Floor(Lista.Width / LarghezzaColonne))
        Dim NumRigheNecessarie As UInteger = Math.Ceiling(Lista.Items.Count / NumColonne)
        Lista.Size = New Size(Lista.Width, NumRigheNecessarie * AltezzaElementi + 2)

        Dim NumElementiPerRiga As UInteger = Math.Ceiling(Lista.Items.Count / NumRigheNecessarie)
        Dim riga As Short
        For i As Short = 0 To Lista.Items.Count - 1
            riga = Math.Floor(i / NumElementiPerRiga)
            Dim col As Short = i Mod NumElementiPerRiga
            Lista.Items.Item(i).Position = New Point(col * (LarghezzaColonne + 6), riga * (AltezzaElementi + 4))
            'MessageBox.Show("impostato " + (col * LarghezzaColonne).ToString + "x" + (riga * AltezzaElementi).ToString + ", ora è " + Lista.Items.Item(i).Position.X.ToString + "x" + Lista.Items.Item(i).Position.Y.ToString)
        Next
    End Sub

    Function IndiceIconaGenere(genere As String) As Byte
        Select Case genere.ToLower
            Case "animazione"
                Return 11
            Case "antica grecia"
                Return 12
            Case "antica roma"
                Return 13
            Case "avventura"
                Return 14
            Case "azione"
                Return 15
            Case "biografico"
                Return 16
            Case "black humor"
                Return 17
            Case "catastrofico"
                Return 18
            Case "comico"
                Return 19
            Case "commedia"
                Return 20
            Case "drammatico"
                Return 21
            Case "droga"
                Return 22
            Case "fantascienza"
                Return 23
            Case "fantasmi"
                Return 24
            Case "fantasy"
                Return 25
            Case "finanza"
                Return 26
            Case "gangster"
                Return 27
            Case "gay"
                Return 28
            Case "giallo"
                Return 29
            Case "guerra"
                Return 30
            Case "horror"
                Return 31
            Case "informatica"
                Return 32
            Case "marinaresco"
                Return 33
            Case "matematica"
                Return 34
            Case "medioevo"
                Return 35
            Case "montagna"
                Return 36
            Case "motori"
                Return 37
            Case "musica"
                Return 38
            Case "musical"
                Return 39
            Case "musicale"
                Return 39
            Case "natalizio"
                Return 40
            Case "noir"
                Return 41
            Case "poesia"
                Return 42
            Case "politico"
                Return 43
            Case "polizesco"
                Return 44
            Case "religione"
                Return 45
            Case "rock"
                Return 46
            Case "sanità"
                Return 47
            Case "satira"
                Return 48
            Case "scienza"
                Return 49
            Case "scuola"
                Return 50
            Case "sentimentale"
                Return 51
            Case "serial killer"
                Return 52
            Case "spazio"
                Return 53
            Case "spionaggio"
                Return 54
            Case "splatter"
                Return 55
            Case "sport"
                Return 56
            Case "storico"
                Return 57
            Case "surrealismo"
                Return 58
            Case "thriller"
                Return 59
            Case "treni"
                Return 60
            Case "ufo"
                Return 61
            Case "western"
                Return 62
            Case Else
                Return 0
        End Select
    End Function

    Function IndiceIconaNazione(nazione As String) As Byte
        Select Case nazione.ToUpper
            Case "AUS"
                Return 64
            Case "BRA"
                Return 65
            Case "CAN"
                Return 66
            Case "CIN"
                Return 67
            Case "COR"
                Return 68
            Case "ENG"
                Return 69
            Case "FIN"
                Return 70
            Case "FRA"
                Return 71
            Case "GER"
                Return 72
            Case "GIA"
                Return 73
            Case "IND"
                Return 74
            Case "ITA"
                Return 75
            Case "RUS"
                Return 76
            Case "SPA"
                Return 77
            Case "SVE"
                Return 78
            Case "SVI"
                Return 79
            Case "USA"
                Return 80
            Case Else
                Return 0
        End Select
    End Function

    Sub ImpostaRisorsaIconaNazione(Nazione As String, PictureBox As System.Windows.Forms.PictureBox, NascondiSeSconosciuta As Boolean)
        Select Case Nazione.ToUpper
            Case "USA"
                PictureBox.Image = My.Resources.USA
            Case "ITA"
                PictureBox.Image = My.Resources.ITA
            Case "FRA"
                PictureBox.Image = My.Resources.FRA
            Case "GER"
                PictureBox.Image = My.Resources.GER
            Case "SVE"
                PictureBox.Image = My.Resources.SVE
            Case "ENG"
                PictureBox.Image = My.Resources.ENG
            Case "BRA"
                PictureBox.Image = My.Resources.BRA
            Case "GIA"
                PictureBox.Image = My.Resources.GIA
            Case "CIN"
                PictureBox.Image = My.Resources.CIN
            Case "AUS"
                PictureBox.Image = My.Resources.AUS
            Case "COR"
                PictureBox.Image = My.Resources.COR
            Case "SVI"
                PictureBox.Image = My.Resources.SVI
            Case "RUS"
                PictureBox.Image = My.Resources.RUS
            Case "IND"
                PictureBox.Image = My.Resources.IND
            Case "SPA"
                PictureBox.Image = My.Resources.SPA
            Case "FIN"
                PictureBox.Image = My.Resources.FIN
            Case Else
                If (NascondiSeSconosciuta) Then
                    PictureBox.Visible = False
                Else
                    PictureBox.Image = My.Resources.mondo
                End If
        End Select
    End Sub

    Function GradazioneNeroRossoGialloVerde(Percentuale As Double) As Color
        If (Percentuale > 1) Then Percentuale = 1
        If (Percentuale <= (1 / 3)) Then
            'Gradazioni da nero (0%) al rosso (33%)
            Dim SottoPercentuale As Double = Percentuale * 3
            Return Color.FromArgb(Math.Round(255 * SottoPercentuale), 0, 0)
        ElseIf (Percentuale <= (2 / 3)) Then
            'Gradazioni da rosso (33%) al giallo (66%)
            Dim SottoPercentuale As Double = (Percentuale - (1 / 3)) * 3
            Return Color.FromArgb(255, Math.Round(255 * SottoPercentuale), 0)
        Else
            'Gradazioni da giallo (66%) al verde (100%)
            Dim SottoPercentuale As Double = (Percentuale - (2 / 3)) * 3
            Return Color.FromArgb(255 - Math.Round(255 * SottoPercentuale), 255, 0)
        End If
    End Function

    Private Sub AggiornaContenutoPannelloDestra() Handles ElencoFilm.SelectedIndexChanged
        If (ElencoFilm.SelectedIndices.Count <= 0) Then
            ImpostaContenutoSchermataDestra(False, True)
        Else
            Dim film As Film = LibreriaFilm.Item(ListaIndiciFilmFiltrati.Item(ElencoFilm.SelectedIndices.Item(0)))

            ' Titolo
            LabTitoloITA.Text = film.TitoloITA

            ' Titolo originale
            If (Not IsNothing(film.TitoloORIG) And film.TitoloORIG <> "") Then
                LabTitoloORIG.Text = film.TitoloORIG
                LabTitoloORIG.Visible = True
            Else
                LabTitoloORIG.Visible = False
            End If

            ' Nazione
            If (IsNothing(film.Nazione)) Then
                PannelloNazione.Visible = False
            Else
                NazioneLab.Text = film.Nazione.ToUpper
                PannelloNazione.Visible = True
                NazionePic.Visible = True
                ImpostaRisorsaIconaNazione(film.Nazione, NazionePic, True)
            End If

            'Anno
            If (IsNothing(film.Anno)) Then
                PanelAnno.Visible = False
            Else
                PanelAnno.Visible = True
                LabAnno.Text = film.Anno.ToString
            End If

            'Registi
            If (IsNothing(film.Registi)) Then
                PanelRegisti.Visible = False
            Else
                PanelRegisti.Visible = True
                LabRegisti.Text = DaListaAStringa(film.Registi)
            End If

            'Durata
            If (Not IsNumeric(film.DurataMinuti) Or film.DurataMinuti <= 0) Then
                PanelDurata.Visible = False
            Else
                PanelDurata.Visible = True
                LabDurata.Text = DaMinutiAOreMin(film.DurataMinuti)

                Dim FineVisione As Date = My.Computer.Clock.LocalTime.AddMinutes(film.DurataMinuti)
                LabFineVisione.Text = FineVisione.Hour.ToString + If(FineVisione.Minute < 10, ":0", ":") + FineVisione.Minute.ToString
            End If

            ' Note
            If (IsNothing(film.Note)) Then
                PanelNote.Visible = False
            Else
                LabNote.Text = film.Note
                PanelNote.Visible = True
            End If

            ' Estensione file
            LabEstensione.Text = film.Estensione.ToUpper

            ' Dimensione file
            LabDimensioneFile.Text = If(film.DimensioneMB < 1000, film.DimensioneMB.ToString + " MB", Math.Round(film.DimensioneMB / 1024, 1).ToString + " GB")

            'Contenitore / Codec file
            If (IsNothing(film.Contenitore)) Then
                LabCodecFile.Visible = False
            Else
                LabCodecFile.Visible = True
                LabCodecFile.Text = film.Contenitore.Replace(film.Estensione.ToUpper, "").Trim
            End If

            'Bitrate file
            If (IsNothing(film.BitrateComplessivoKBpS) OrElse film.BitrateComplessivoKBpS = 0) Then
                PanBitrateFile.Visible = False
            Else
                PanBitrateFile.Visible = True
                Dim BitrateArrotondatoMBSenzaDecimali As UShort = Math.Round(film.BitrateComplessivoKBpS / 1000)

                If (film.BitrateComplessivoKBpS > 4000) Then
                    LabBitrateFile.Text = BitrateArrotondatoMBSenzaDecimali.ToString + " Mb/s"
                ElseIf (film.BitrateComplessivoKBpS > 1000) Then
                    LabBitrateFile.Text = Math.Round(film.BitrateComplessivoKBpS / 1000, 1).ToString + " Mb/s"
                Else
                    LabBitrateFile.Text = film.BitrateComplessivoKBpS.ToString + " Kb/s"
                End If

                If (BitrateArrotondatoMBSenzaDecimali < 10) Then
                    Dim PercentualeQualità As Double = film.BitrateComplessivoKBpS / 6144
                    LabBitrateFile.BackColor = GradazioneNeroRossoGialloVerde(PercentualeQualità)
                    LabBitrateFile.ForeColor = If(PercentualeQualità < 0.5, Color.White, Color.Black)
                ElseIf (BitrateArrotondatoMBSenzaDecimali < 40) Then
                    LabBitrateFile.BackColor = Color.DodgerBlue
                    LabBitrateFile.ForeColor = Color.White
                Else
                    LabBitrateFile.BackColor = Color.Gold
                    LabBitrateFile.ForeColor = Color.Black
                End If
            End If

            'Bitrate video
            If (IsNothing(film.BitrateVideoKBpS) OrElse film.BitrateVideoKBpS = 0) Then
                PannelloBitrateVideo.Visible = False
            Else
                PannelloBitrateVideo.Visible = True
                If (film.BitrateVideoKBpS > 1000) Then
                    LabBitrateVideo.Text = Math.Round(film.BitrateVideoKBpS / 1000).ToString + " Mb/s"
                Else
                    LabBitrateVideo.Text = film.BitrateVideoKBpS.ToString + " Kb/s"
                End If
            End If

            'Risoluzione
            If (IsNothing(film.Risoluzione) OrElse film.Risoluzione.IsEmpty) Then
                PannelloRisoluzione.Visible = False
            Else
                PannelloRisoluzione.Visible = True
                Dim altezza = film.Risoluzione.Height
                'LabRisoluzione.Text = film.Risoluzione.Width.ToString + "x" + film.Risoluzione.Height.ToString

                If (altezza >= 4300) Then '8K UHD | 4320p
                    LabTipoRisoluzione.Text = "8K UHD"
                    BadgeRisoluzione.BackColor = Color.Silver
                    BadgeRisoluzione.ForeColor = Color.Black
                ElseIf (altezza >= 1700) Then '4K UHD | 2160p - 1716p
                    LabTipoRisoluzione.Text = "4K UHD"
                    BadgeRisoluzione.BackColor = Color.Gold
                    BadgeRisoluzione.ForeColor = Color.Black
                ElseIf (altezza >= 1400) Then 'QHD - Quad HD | 1440p
                    LabTipoRisoluzione.Text = "QHD"
                    BadgeRisoluzione.BackColor = Color.SandyBrown
                    BadgeRisoluzione.ForeColor = Color.Black
                ElseIf (altezza >= 1000) Then 'FullHD (BD) 1080p
                    LabTipoRisoluzione.Text = "FullHD"
                    BadgeRisoluzione.BackColor = Color.DodgerBlue
                    BadgeRisoluzione.ForeColor = Color.White
                ElseIf (altezza >= 700) Then 'Standard HD / HD ready (BD) 720p
                    LabTipoRisoluzione.Text = "HD"
                    BadgeRisoluzione.BackColor = Color.MediumVioletRed
                    BadgeRisoluzione.ForeColor = Color.White
                ElseIf (altezza >= 460) Then 'SD - VGA-SVGA (DVD - VHS) 480p / 576p
                    LabTipoRisoluzione.Text = "SD"
                    BadgeRisoluzione.BackColor = Color.White
                    BadgeRisoluzione.ForeColor = Color.Black
                ElseIf (altezza >= 220) Then 'LD (VCD, PS1, iPhone1, primo Youtube, PSP) 360p / 240p / 288p
                    LabTipoRisoluzione.Text = "LD"
                    BadgeRisoluzione.BackColor = Color.FromArgb(80, 80, 80)
                    BadgeRisoluzione.ForeColor = Color.White
                Else '144p (min Youtube), 120p (primo Nokia a colori)
                    LabTipoRisoluzione.Text = "<< LD"
                    BadgeRisoluzione.BackColor = Color.Black
                    BadgeRisoluzione.ForeColor = Color.Yellow
                End If

                LabAltezzaRisoluzione.Text = altezza.ToString + "p"
            End If

            'Proporzioni
            If (IsNothing(film.Proporzioni)) Then
                PannelloProporzioni.Visible = False
            Else
                PannelloProporzioni.Visible = True
                LabProporzioni.Text = film.Proporzioni
            End If

            'Codec video
            If (IsNothing(film.CodecVideoNomeBreve)) Then
                PannelloCodecVideo.Visible = False
            Else
                PannelloCodecVideo.Visible = True
                LabCodecVideo.Text = film.CodecVideoNomeBreve.ToUpper
            End If

            'FPS
            If (IsNothing(film.FPS) Or film.FPS = 0) Then
                PannelloFPS.Visible = False
            Else
                PannelloFPS.Visible = True
                LabFPS.Text = Math.Round(film.FPS, 2).ToString + " FPS"
            End If

            'Audio
            Dim NumRigheAudio As Byte = 0
            If (IsNothing(film.Sonori) OrElse film.Sonori.Count <= 0) Then
                RTFAudio.Rtf = "{\rtf1\ansi \deff0 {\colortbl;\red255\green0\blue0;} \cf1 \i Nessun audio \i0 }"
                NumRigheAudio = 1
            Else
                Dim descr As String = "{\rtf1\ansi "
                If (MainModule.ModalitaNotte) Then
                    descr += ColoriTestoRTFNotte
                Else
                    descr += ColoriTestoRTFGiorno
                End If
                descr += "\cf1 "
                'descr += "\b " + film.Sonori.Count.ToString + " audio \b0"

                For Each audio As Sonoro In film.Sonori
                    descr += " \fs30 \bullet  \fs20 "
                    NumRigheAudio += 1

                    If (Not IsNothing(audio.Lingua)) Then descr += "\b " + audio.Lingua.ToUpper() + "\b0 "

                    descr += "\fs19  "
                    If (Not IsNothing(audio.DescrizioneCanali)) Then
                        If (IsNothing(audio.NumCanali) OrElse audio.NumCanali <= 0) Then
                            descr += audio.DescrizioneCanali + " "
                        Else
                            If (audio.NumCanali = 1) Then
                                descr += "\cf2 "
                            ElseIf (audio.NumCanali = 2) Then
                                descr += "\cf3 "
                            ElseIf (audio.NumCanali > 2) Then
                                descr += "\cf4 "
                            End If
                            descr += audio.DescrizioneCanali + "\cf1 "
                        End If
                    End If
                    If (Not IsNothing(audio.CodecNomeBreve)) Then
                        If (audio.CodecNomeBreve.ToLower = "mp3" Or audio.CodecNomeBreve.ToLower = "mp2" Or audio.CodecNomeBreve.ToLower = "mp1") Then
                            descr += " \cf2 " + audio.CodecNomeBreve.ToUpper + "\cf1 "
                        Else
                            descr += " " + audio.CodecNomeBreve.ToUpper
                        End If
                    End If
                    If (Not IsNothing(audio.BitrateKBpS) AndAlso audio.BitrateKBpS > 0) Then
                        If (audio.BitrateKBpS <= 160) Then
                            descr += " \cf2 "
                        ElseIf (audio.BitrateKBpS <= 320) Then
                            descr += " \cf3 "
                        Else
                            descr += " \cf4 "
                        End If
                        descr += audio.BitrateKBpS.ToString + "kb/s\cf1 "
                    End If
                    If (Not IsNothing(audio.CampionamentoHZ) AndAlso audio.CampionamentoHZ > 0) Then descr += " " + Math.Round(audio.CampionamentoHZ / 1000, 1).ToString + " kHz"

                    If (Not IsNothing(audio.Nome)) Then
                        descr += " \line \tab \fs18 [\i " + audio.Nome + "\i0 ]"
                        NumRigheAudio += 1
                    End If
                    descr += "\line "
                Next
                RTFAudio.Rtf = descr.Substring(0, descr.Length - 6) + " }"
            End If
            PannelloAudio.Height = 25 * NumRigheAudio

            'Sottotitoli
            Dim NumRigheSottotitoli As Byte = 0
            If (IsNothing(film.Sottotitoli) OrElse film.Sottotitoli.Count <= 0) Then
                RTFSottotitoli.Rtf = "{\rtf1\ansi \deff0 {\colortbl;\red255\green0\blue0;} \cf1 \i Nessun sottotitolo \i0 }"
                NumRigheSottotitoli = 1
            Else
                Dim descr As String = "{\rtf1\ansi "
                'descr += "\b " + film.Sottotitoli.Count.ToString + " sottotitoli \b0"
                For Each sott As Sottotitolo In film.Sottotitoli
                    descr += " \fs30 \bullet  \fs20 "
                    NumRigheSottotitoli += 1
                    If (Not IsNothing(sott.Lingua)) Then descr += "\b " + sott.Lingua.ToUpper() + "\b0  "
                    If (Not IsNothing(sott.Nome)) Then descr += "\fs19 [\i " + sott.Nome + "\i0 ]\fs20  "
                    If (Not IsNothing(sott.CodecNomeBreve)) Then descr += "\fs16 " + sott.CodecNomeBreve.ToUpper + "\fs20"
                    descr += "\line "
                Next
                RTFSottotitoli.Rtf = descr.Substring(0, descr.Length - 6) + " }"
            End If
            PannelloSottotitoli.Height = 28 * NumRigheSottotitoli

            ' Generi
            If (IsNothing(film.Generi)) Then
                IntestazioneGeneri.Visible = False
                ListaGeneri.Visible = False
            Else
                ListaGeneri.Items.Clear()
                For Each genere In film.Generi
                    Dim icona As Byte = IndiceIconaGenere(genere)
                    If (icona <> 0) Then ListaGeneri.Items.Add(genere, icona) Else ListaGeneri.Items.Add(genere)
                Next
                RegolaAltezzaElenco(ListaGeneri)

                IntestazioneGeneri.Visible = True
                ListaGeneri.Visible = True
            End If

            ' Autori
            If (IsNothing(film.Autori)) Then
                PanelAutori.Visible = False
            Else
                LabAutori.Text = DaListaAStringa(film.Autori)
                PanelAutori.Visible = True
            End If

            ' Attori
            If (IsNothing(film.Attori)) Then
                IntestazioneAttori.Visible = False
                ListaAttori.Visible = False
            Else
                ListaAttori.Items.Clear()
                For Each attore In film.Attori
                    ListaAttori.Items.Add(attore)
                Next
                RegolaAltezzaElenco(ListaAttori)

                IntestazioneAttori.Visible = True
                ListaAttori.Visible = True
            End If

            ' Musicisti
            If (IsNothing(film.Musicisti)) Then
                PanelMusicisti.Visible = False
            Else
                LabMusicisti.Text = DaListaAStringa(film.Musicisti)
                PanelMusicisti.Visible = True
            End If

            'Trama
            Dim AbbiamoTramaBreve As Boolean = Not IsNothing(film.TramaBreve)
            Dim AbbiamoTramaLunga As Boolean = Not IsNothing(film.TramaLunga)

            If (Not AbbiamoTramaBreve AndAlso Not AbbiamoTramaLunga) Then
                PannelloTrama.Visible = False
            Else
                PannelloTrama.Visible = True

                'Trama breve
                If (AbbiamoTramaBreve) Then
                    LabTramaBreve.Text = film.TramaBreve
                Else
                    LabTramaBreve.Text = ""
                End If
                RegolaAltezzaTextboxTramaBreve()

                'Trama lunga
                If (AbbiamoTramaLunga) Then
                    TextTramaLunga.Text = film.TramaLunga
                Else
                    TextTramaLunga.Clear()
                End If

                'Imposto visualizzazione opportuna
                If (AbbiamoTramaBreve And Not AbbiamoTramaLunga) Then
                    VisualizzaTrama(True)
                    ButtonToggleTrama.Enabled = False
                ElseIf (Not AbbiamoTramaBreve And AbbiamoTramaLunga) Then
                    VisualizzaTrama(False)
                    ButtonToggleTrama.Enabled = False
                ElseIf (AbbiamoTramaBreve And AbbiamoTramaLunga) Then
                    VisualizzaTrama(True) 'se abbiamo entrambe, di default mostro quella breve
                    ButtonToggleTrama.Enabled = True
                End If
            End If

            ' Valutazioni
            If (film.VotoMetacritic = 0 AndAlso film.VotoRottenTomatoes = 0 AndAlso
              film.IncassoDollari = 0 AndAlso film.VotoIMDB = 0 AndAlso film.NumVotiIMDB = 0 AndAlso
              film.OscarVinti = 0 AndAlso film.BAFTAVinti = 0 AndAlso film.AltriPremiVinti = 0 AndAlso
              film.OscarNominati = 0 AndAlso film.BAFTANominati = 0 AndAlso film.AltriPremiNominati = 0) Then

                PanelValutazioni.Visible = False
            Else
                PanelValutazioni.Visible = True

                'Incassi
                If (film.IncassoDollari > 0) Then
                    VisualizzaValutazione(film.IncassoDollari, 2800000000, LabIncassi, LabMoltiplicatoreIncassi, PanIncassi, True, {0, 255, 0})
                Else
                    PanIncassi.Visible = False
                End If

                'Voto IMDB
                If (film.VotoIMDB > 0) Then
                    VisualizzaValutazione(film.VotoIMDB, 10, LabVotoIMDB, Nothing, PanVotoIMDB)
                Else
                    PanVotoIMDB.Visible = False
                End If

                'Num voti IMDB
                If (film.NumVotiIMDB > 0) Then
                    VisualizzaValutazione(film.NumVotiIMDB, 2500000, LabNumVotiIMDB, LabMoltiplicatoreNumVotiIMDB, PanNumVotiIMDB, True, {102, 255, 255})
                Else
                    PanNumVotiIMDB.Visible = False
                End If

                'Metacritic
                If (film.VotoMetacritic > 0) Then
                    VisualizzaValutazione(film.VotoMetacritic, 100, LabMetacritic, Nothing, PanMetacritic)
                Else
                    PanMetacritic.Visible = False
                End If

                'Rotten Tomatoes
                If (film.VotoRottenTomatoes > 0) Then
                    VisualizzaValutazione(film.VotoRottenTomatoes, 100, LabRotten, Nothing, PanRotten)
                Else
                    PanRotten.Visible = False
                End If

                'Premi nominati
                If (film.OscarNominati = 0 AndAlso film.BAFTANominati = 0 AndAlso film.AltriPremiNominati = 0) Then
                    PanPremiNominati.Visible = False
                Else
                    PanPremiNominati.Visible = True

                    If (film.OscarNominati = 0) Then
                        PanOscarNominati.Visible = False
                    Else
                        PanOscarNominati.Visible = True
                        LabOscarNominati.Text = film.OscarNominati.ToString
                    End If
                    If (film.BAFTANominati = 0) Then
                        PanBAFTANominati.Visible = False
                    Else
                        PanBAFTANominati.Visible = True
                        LabBAFTANominati.Text = film.BAFTANominati.ToString
                    End If
                    If (film.AltriPremiNominati = 0) Then
                        PanAltriNominati.Visible = False
                    Else
                        PanAltriNominati.Visible = True
                        LabAltriNominati.Text = film.AltriPremiNominati.ToString
                    End If
                End If

                'Premi vinti
                If (film.OscarVinti = 0 AndAlso film.BAFTAVinti = 0 AndAlso film.AltriPremiVinti = 0) Then
                    PanPremiVinti.Visible = False
                Else
                    PanPremiVinti.Visible = True

                    If (film.OscarVinti = 0) Then
                        PanOscarVinti.Visible = False
                    Else
                        PanOscarVinti.Visible = True
                        LabOscarVinti.Text = film.OscarVinti.ToString
                    End If
                    If (film.BAFTAVinti = 0) Then
                        PanBAFTAVinti.Visible = False
                    Else
                        PanBAFTAVinti.Visible = True
                        LabBAFTAVinti.Text = film.BAFTAVinti.ToString
                    End If
                    If (film.AltriPremiVinti = 0) Then
                        PanAltriVinti.Visible = False
                    Else
                        PanAltriVinti.Visible = True
                        LabAltriVinti.Text = film.AltriPremiVinti.ToString
                    End If
                End If
            End If

            ' Schermata
            Dim PercorsoSchermata As String = MainModule.PercorsoSchermataFilm(film.NomeFile)
            If (My.Computer.FileSystem.FileExists(PercorsoSchermata)) Then
                PicSchermata.ImageLocation = PercorsoSchermata
                PicSchermata.Visible = True
            Else
                PicSchermata.Visible = False
            End If

            ' Poster
            If (My.Settings.PannelloPosterChiuso) Then
                SplitPosterInfoPrincipali.Panel1Collapsed = True
                ButtTogglePoster.Enabled = True
            Else
                Dim PathPoster As String = PercorsoPosterFilm(film.NomeFile)
                If (My.Computer.FileSystem.FileExists(PathPoster)) Then
                    PicPoster.ImageLocation = PathPoster
                    SplitPosterInfoPrincipali.Panel1Collapsed = False
                    ButtTogglePoster.Enabled = True
                Else
                    PicPoster.ImageLocation = ""
                    SplitPosterInfoPrincipali.Panel1Collapsed = True
                    ButtTogglePoster.Enabled = False
                End If
            End If

            ImpostaContenutoSchermataDestra(True, False)
        End If
    End Sub

    Sub RegolaAltezzaTextboxTramaBreve()
        Dim NumRighe As UShort = Math.Ceiling(TextRenderer.MeasureText(LabTramaBreve.Text, LabTramaBreve.Font).Width / LabTramaBreve.Width)
        LabTramaBreve.Height = NumRighe * TextRenderer.MeasureText(LabTramaBreve.Text, LabTramaBreve.Font).Height + 4
    End Sub

    Sub VisualizzaValutazione(Voto As Double, ValutazioneMax As UInteger, ByRef LabVoto As Windows.Forms.Label, ByRef LabMoltiplicatore As Windows.Forms.Label, ByRef Pannello As Windows.Forms.Panel, Optional ScalaEsponenziale As Boolean = False, Optional Colore() As Byte = Nothing)
        If (Voto < 10) Then
            LabVoto.Text = Math.Round(Voto, 1).ToString
            If (Not IsNothing(LabMoltiplicatore)) Then LabMoltiplicatore.Text = ""
        ElseIf (Voto < 1000) Then
            LabVoto.Text = Voto.ToString
            If (Not IsNothing(LabMoltiplicatore)) Then LabMoltiplicatore.Text = ""
        ElseIf (Voto < 10000) Then
            LabVoto.Text = Math.Round(Voto / 1000, 1).ToString
            If (Not IsNothing(LabMoltiplicatore)) Then LabMoltiplicatore.Text = "mila"
        ElseIf (Voto < 1000000) Then
            LabVoto.Text = Math.Floor(Voto / 1000).ToString
            If (Not IsNothing(LabMoltiplicatore)) Then LabMoltiplicatore.Text = "mila"
        ElseIf (Voto < 10000000) Then
            LabVoto.Text = Math.Round(Voto / 1000000, 1).ToString
            If (Not IsNothing(LabMoltiplicatore)) Then LabMoltiplicatore.Text = "mln"
        ElseIf (Voto < 1000000000) Then
            LabVoto.Text = Math.Floor(Voto / 1000000).ToString
            If (Not IsNothing(LabMoltiplicatore)) Then LabMoltiplicatore.Text = "mln"
        ElseIf (Voto < 10000000000) Then
            LabVoto.Text = Math.Round(Voto / 1000000000, 1).ToString
            If (Not IsNothing(LabMoltiplicatore)) Then LabMoltiplicatore.Text = "mld"
        Else
            LabVoto.Text = Math.Floor(Voto / 1000000000).ToString
            If (Not IsNothing(LabMoltiplicatore)) Then LabMoltiplicatore.Text = "mld"
        End If

        If (Voto > ValutazioneMax) Then Voto = ValutazioneMax
        Dim Percentuale As Double
        If (ScalaEsponenziale) Then
            'Percentuale = Math.Log(1 + Voto / ValutazioneMax) / Math.Log(2)
            'Percentuale = Math.Exp(Voto / ValutazioneMax) / Math.Exp(2)
            'Percentuale = Math.Pow(5, Voto - ValutazioneMax)
            'Percentuale = (Math.Pow(1.1, Voto / ValutazioneMax) - 1) / (Math.Pow(1.1, 1) - 1)
            Percentuale = Math.Log10(1 + 200 * Voto / ValutazioneMax) / Math.Log10(200 * 2)
            'If (Percentuale > 1) Then Percentuale = 1
        Else
            Percentuale = Voto / ValutazioneMax
        End If
        If (IsNothing(Colore)) Then
            Pannello.BackColor = GradazioneNeroRossoGialloVerde(Percentuale)
        Else
            Pannello.BackColor = Color.FromArgb(255, Math.Round(Percentuale * Colore(0)), Math.Round(Percentuale * Colore(1)), Math.Round(Percentuale * Colore(2)))
        End If
        Pannello.ForeColor = If(Percentuale <= 0.5, Color.White, Color.Black)
        Pannello.Visible = True
    End Sub

    Function DaListaAStringa(Lista As List(Of String), Optional SoloCognomi As Boolean = False) As String
        If (IsNothing(Lista)) Then Return ""

        Dim RetVal As String = ""

        For Each Elemento In Lista
            If (Not SoloCognomi) Then
                RetVal += Elemento + ", "
            Else
                Dim PosPunto As Short = Elemento.IndexOf(".")
                If (PosPunto = -1) Then
                    If (Not Elemento.Contains(" ")) Then
                        RetVal += Elemento + ", "
                    Else
                        Dim Nomi As String() = Elemento.Split(" ")
                        RetVal += Nomi.GetValue(Nomi.Length - 1) + ", "
                    End If
                Else
                    Dim Cognome As String = Elemento.Substring(PosPunto + 1, Elemento.Length - PosPunto - 1)
                    If (Cognome.StartsWith(" ")) Then Cognome = Cognome.Substring(1, Cognome.Length - 1)
                    RetVal += Cognome + ", "
                End If
            End If
        Next

        Return RetVal.Substring(0, RetVal.Length - 2)
    End Function

    Sub RiproduciSelezionato() Handles ElencoFilm.DoubleClick, PlayButton.Click
        If (ElencoFilm.SelectedIndices.Count <= 0) Then Exit Sub
        Dim Path As String = LibreriaFilm.Item(ListaIndiciFilmFiltrati.Item(ElencoFilm.SelectedIndices.Item(0))).PercorsoFile
        If (My.Computer.FileSystem.FileExists(Path)) Then Process.Start(Path)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles EsploraRisorseButton.Click
        If (ElencoFilm.SelectedIndices.Count <= 0) Then Exit Sub
        Process.Start("explorer", "/select,""" + LibreriaFilm.Item(ListaIndiciFilmFiltrati.Item(ElencoFilm.SelectedIndices.Item(0))).PercorsoFile + """")
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ButtFilmCasuale.Click
        Dim NumElem As Integer = ElencoFilm.Items.Count
        If (NumElem = 0) Then Exit Sub

        Dim random As New Random
        Dim sorteggiato As Integer = random.Next(0, NumElem - 1)

        ElencoFilm.Focus()
        ElencoFilm.Items.Item(sorteggiato).EnsureVisible()
        ElencoFilm.Items.Item(sorteggiato).Selected = True
    End Sub

    Private Sub ColonneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColonneToolStripMenuItem.Click
        ElencoFilm.View = View.Details
        AggiornaColonneInElencoFilm()
        'ElencoFilm.Columns.Item(0).Width = 240
        'ElencoFilm.Columns.Item(1).Width = 60
        'ElencoFilm.Columns.Item(2).Width = 140
        'ElencoFilm.Columns.Item(3).Width = 140
        ElencoFilm.ArrangeIcons()
        IconePiccoleToolStripMenuItem.Checked = False
        IconeGrandiToolStripMenuItem.Checked = False
        TilesToolStripMenuItem.Checked = False
        ListaToolStripMenuItem.Checked = False
    End Sub

    Private Sub IconePiccoleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IconePiccoleToolStripMenuItem.Click
        ElencoFilm.View = View.SmallIcon
        AggiornaColonneInElencoFilm()
        ElencoFilm.ArrangeIcons()
        ColonneToolStripMenuItem.Checked = False
        IconeGrandiToolStripMenuItem.Checked = False
        TilesToolStripMenuItem.Checked = False
        ListaToolStripMenuItem.Checked = False
    End Sub

    Private Sub IconeGrandiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IconeGrandiToolStripMenuItem.Click
        ElencoFilm.View = View.LargeIcon
        AggiornaColonneInElencoFilm()
        ElencoFilm.ArrangeIcons()
        IconePiccoleToolStripMenuItem.Checked = False
        ColonneToolStripMenuItem.Checked = False
        TilesToolStripMenuItem.Checked = False
        ListaToolStripMenuItem.Checked = False
    End Sub

    Private Sub TilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TilesToolStripMenuItem.Click
        ElencoFilm.View = View.Tile
        AggiornaColonneInElencoFilm()
        ElencoFilm.ArrangeIcons()
        IconePiccoleToolStripMenuItem.Checked = False
        IconeGrandiToolStripMenuItem.Checked = False
        ColonneToolStripMenuItem.Checked = False
        ListaToolStripMenuItem.Checked = False
    End Sub

    Private Sub ListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaToolStripMenuItem.Click
        ElencoFilm.View = View.List
        AggiornaColonneInElencoFilm()
        ElencoFilm.ArrangeIcons()
        IconePiccoleToolStripMenuItem.Checked = False
        IconeGrandiToolStripMenuItem.Checked = False
        TilesToolStripMenuItem.Checked = False
        ColonneToolStripMenuItem.Checked = False
    End Sub

    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ElencoFilm.ColumnClick
        'If (ElencoFilm.Sorting = SortOrder.Ascending) Then
        '    ElencoFilm.Sorting = SortOrder.Descending
        'Else
        '    ElencoFilm.Sorting = SortOrder.Ascending
        'End If
        'ElencoFilm.Sort()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles IMDBToolStripMenuItem.Click
        Dim film As Film = LibreriaFilm.Item(ListaIndiciFilmFiltrati.Item(ElencoFilm.SelectedIndices.Item(0)))
        Dim PathInfoIMDB As String = MainModule.PercorsoInfoIMDB(film.NomeFile)
        If (My.Computer.FileSystem.FileExists(PathInfoIMDB)) Then
            Dim ReaderInfoIMDB As New System.IO.StreamReader(PathInfoIMDB)
            Dim json As JObject = JObject.Parse(ReaderInfoIMDB.ReadToEnd)
            ReaderInfoIMDB.Close()
            If (json.ContainsKey("imdbID")) Then
                Dim imdbID As String = json.SelectToken("imdbID").Value(Of String)()
                If (Not IsNothing(imdbID) AndAlso imdbID.Length > 0) Then
                    Process.Start("https://www.imdb.com/title/" + imdbID + "/")
                    Exit Sub
                End If
            End If
        End If

        'Se il file InfoIMDB non esiste, oppure non contiene l'ID
        Dim query As String = film.TitoloITA + " " + film.Anno.ToString
        query.Replace(" ", "+")
        Process.Start("https://www.imdb.com/find?q=" + Uri.EscapeUriString(query) + "&s=tt")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles GoogleToolStripMenuItem.Click
        Dim film As Film = LibreriaFilm.Item(ListaIndiciFilmFiltrati.Item(ElencoFilm.SelectedIndices.Item(0)))
        Dim query As String = film.Anno.ToString + " " + DaListaAStringa(film.Registi) + " " + film.TitoloITA
        query.Replace(" ", "+")
        Process.Start("https://www.google.it/search?q=" + Uri.EscapeUriString(query))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles WikiITToolStripMenuItem.Click
        Dim film As Film = LibreriaFilm.Item(ListaIndiciFilmFiltrati.Item(ElencoFilm.SelectedIndices.Item(0)))
        Dim query As String = film.TitoloITA + " " + DaListaAStringa(film.Registi) + " " + film.Anno.ToString
        Process.Start("https://it.wikipedia.org/w/index.php?search=" + Uri.EscapeUriString(query) + "&ns0=1")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles RinominaButton.Click
        Dim film As Film = LibreriaFilm.Item(ListaIndiciFilmFiltrati.Item(ElencoFilm.SelectedIndices.Item(0)))
        ModificaInfo.InizializzaFinestra(film)
        ModificaInfo.ShowDialog()
    End Sub

    Sub ImpostaColori(ModalitaNotte As Boolean)
        Dim Testo As Color
        Dim Sfondo As Color
        Dim SfondoPannello As Color
        Dim BottonieCaselle As Color
        Dim IntestazioniSezione As Color

        If (ModalitaNotte) Then
            Testo = Color.White
            Sfondo = Color.Black
            SfondoPannello = Color.FromArgb(255, 24, 24, 24) 'nero leggermente più chiaro
            BottonieCaselle = Color.FromArgb(255, 48, 48, 48) 'nero ancora più chiaro
            IntestazioniSezione = Color.FromArgb(255, 56, 56, 56) 'grigio

            RTFAudio.Rtf = RTFAudio.Rtf.Replace(ColoriTestoRTFGiorno, ColoriTestoRTFNotte)
        Else
            Testo = Color.Black
            Sfondo = Color.White
            SfondoPannello = Color.FromArgb(255, 246, 246, 246) 'GrigioMenu
            BottonieCaselle = Color.FromArgb(255, 248, 248, 248) 'GrigioPannello
            IntestazioniSezione = Color.FromArgb(255, 227, 227, 227) 'grigio

            RTFAudio.Rtf = RTFAudio.Rtf.Replace(ColoriTestoRTFNotte, ColoriTestoRTFGiorno)
        End If

        Me.ForeColor = Testo
        Me.BackColor = Sfondo
        For Each Scheda As TabPage In SchedeFiltriAvanzati.TabPages
            Scheda.BackColor = Sfondo
        Next
        BarraStrumentiPrincipale.BackColor = SfondoPannello
        BarraStrumentiFilm.BackColor = SfondoPannello
        ToolStripCategorie.BackColor = SfondoPannello

        PannelloFiltri.BackColor = SfondoPannello
        StatusEsecuzioneBackground.BackColor = SfondoPannello
        PanelDettagliFilm.BackColor = SfondoPannello
        SplitContainerCSX_DX.Panel2.BackColor = SfondoPannello
        ElencoFilm.ForeColor = Testo
        ElencoFilm.BackColor = Sfondo
        AlberoCategorieLibreria.ForeColor = Testo
        AlberoCategorieLibreria.BackColor = Sfondo

        ListaGeneri.BackColor = SfondoPannello
        ListaGeneri.ForeColor = Testo
        ListaAttori.BackColor = SfondoPannello
        ListaAttori.ForeColor = Testo
        ListaExtra.BackColor = SfondoPannello
        ListaExtra.ForeColor = Testo
        LabTramaBreve.BackColor = SfondoPannello
        LabTramaBreve.ForeColor = Testo
        TextTramaLunga.BackColor = SfondoPannello
        TextTramaLunga.ForeColor = Testo
        RTFAudio.BackColor = SfondoPannello
        RTFSottotitoli.BackColor = SfondoPannello
        RTFSottotitoli.ForeColor = Testo

        CasellaRicerca.BackColor = BottonieCaselle
        PlaceholderCasellaRicerca.BackColor = BottonieCaselle
        CasellaRicerca.ForeColor = Testo

        FiltroNazioni.BackColor = SfondoPannello
        FiltroNazioni.ForeColor = Testo
        FiltroGeneri.BackColor = SfondoPannello
        FiltroGeneri.ForeColor = Testo
        FiltroAudio.BackColor = SfondoPannello
        FiltroAudio.ForeColor = Testo
        FiltroSottotitoli.BackColor = SfondoPannello
        FiltroSottotitoli.ForeColor = Testo

        IntestazioneAttori.BackColor = IntestazioniSezione
        IntestazioneFile.BackColor = IntestazioniSezione
        IntestazioneGeneri.BackColor = IntestazioniSezione
        IntestazioneTrama.BackColor = IntestazioniSezione
        IntestazioneValutazioni.BackColor = IntestazioniSezione
        IntestazioneContenitore.BackColor = IntestazioniSezione
        IntestazioneVideo.BackColor = IntestazioniSezione
        IntestazioneAudio.BackColor = IntestazioniSezione
        IntestazioneSottotitoli.BackColor = IntestazioniSezione
        IntestazioneExtra.BackColor = IntestazioniSezione

        BottCancellaFiltri.BackColor = BottonieCaselle
        BottFiltra.BackColor = BottonieCaselle
        BottMostraFiltri.BackColor = BottonieCaselle
        BottCerca.BackColor = BottonieCaselle
        BottCancellaFiltri.BackColor = BottonieCaselle
        ButCambiaImgPersona.BackColor = BottonieCaselle
        ButtonToggleTrama.BackColor = BottonieCaselle
        ButtRicercaPersonaIMDB.BackColor = BottonieCaselle
    End Sub

    Private Sub SplitContainerCSX_DX_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainerCSX_DX.SplitterMoved
        If (Not SplitContainerCSX_DX.Panel2Collapsed And Me.Visible) Then
            My.Settings.PannelloDxDimensione = SplitContainerCSX_DX.Width - SplitContainerCSX_DX.SplitterDistance
            My.Settings.Save()
        End If
        Dim DimensioneMax As New Size(SplitContainerCSX_DX.Width - SplitContainerCSX_DX.SplitterDistance, 0)
        Dim DimensioneMaxConIcona As New Size(DimensioneMax.Width - 32, 0)
        'LabTitoloITA.MaximumSize = DimensioneMax
        'LabTitoloORIG.MaximumSize = DimensioneMax
        'LabRegisti.MaximumSize = DimensioneMaxConIcona
        'LabAutori.MaximumSize = DimensioneMaxConIcona
        'LabMusicisti.MaximumSize = DimensioneMaxConIcona
        'If (SplitContainerCSX_DX.Width - SplitContainerCSX_DX.SplitterDistance - 32 - 64 > 0) Then LabNote.MaximumSize = New Size(SplitContainerCSX_DX.Width - SplitContainerCSX_DX.SplitterDistance - 32 - 64, 0)
        If (Not IsNothing(PicPoster.Image)) Then
            If (DimensioneMax.Width > 200 * 2) Then
                'a sinistra il manifesto, a destra le info base del film
                SplitPosterInfoPrincipali.Height = Math.Max(360, SplitPosterInfoPrincipali.Panel2.Height)
                SplitPosterInfoPrincipali.SplitterDistance = 250 'larghezza del manifesto
                SplitPosterInfoPrincipali.Orientation = Orientation.Vertical
            Else
                'sopra il manifesto, sotto le info base del film
                Dim AltezzaPosterPerRiempireLarghezza As UShort = PicPoster.Image.Height * (PicPoster.Width / PicPoster.Image.Width)
                Dim AltezzaManifesto As UShort = If(AltezzaPosterPerRiempireLarghezza > 360, 360, AltezzaPosterPerRiempireLarghezza)
                SplitPosterInfoPrincipali.Height = AltezzaManifesto + SplitPosterInfoPrincipali.Panel2.Height
                SplitPosterInfoPrincipali.SplitterDistance = AltezzaManifesto
                SplitPosterInfoPrincipali.Orientation = Orientation.Horizontal
            End If
        End If

        If (DimensioneMax.Width >= 300 And SplitAudioSottotitoli.Orientation = Orientation.Horizontal) Then
            SplitAudioSottotitoli.Orientation = Orientation.Vertical
            SplitAudioSottotitoli.SplitterDistance = Math.Round(SplitAudioSottotitoli.Width / 2)
        ElseIf (DimensioneMax.Width < 300 And SplitAudioSottotitoli.Orientation = Orientation.Vertical) Then
            SplitAudioSottotitoli.Orientation = Orientation.Horizontal
            SplitAudioSottotitoli.SplitterDistance = Math.Round(SplitAudioSottotitoli.Height / 2)
        End If

        RegolaAltezzaElenco(ListaGeneri)
        RegolaAltezzaElenco(ListaAttori)
        RegolaAltezzaTextboxTramaBreve()
    End Sub
    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainerSX_C.SplitterMoved
        If (Not SplitContainerSX_C.Panel1Collapsed And Me.Visible) Then
            My.Settings.PannelloSxDimensione = SplitContainerSX_C.SplitterDistance
            My.Settings.Save()
        End If
    End Sub

    Private Sub FileSystemWatcher_Changed(sender As Object, e As IO.FileSystemEventArgs) Handles FileSystemWatcher.Changed
        'Dim Indice As UShort = ListaFilm.FindIndex(Function(film As Film) If(film.PercorsoFile = e.FullPath, True, False))
        'If (Indice = -1) Then Exit Sub

        'Dim FilmNuovo As Film = ScansioneLibreria.ParsingNomeFile(e.Name, e.FullPath)
        'ListaFilm.RemoveAt(Indice)
        'ListaFilm.Add(FilmNuovo)

        'Dim IconaVecchiaEraSelezionata As Boolean = ElencoFilm.Items.Item(Indice).Selected
        'ElencoFilm.Items.RemoveAt(Indice)

        'Dim IconaNuova As ListViewItem = InserisciIcona(FilmNuovo)
        'If (IconaVecchiaEraSelezionata) Then
        '    ElencoFilm.Focus()
        '    IconaNuova.EnsureVisible()
        '    IconaNuova.Selected = True
        'End If
    End Sub

    Private Sub FileSystemWatcher_Renamed(sender As Object, e As IO.RenamedEventArgs) Handles FileSystemWatcher.Renamed
        'Dim Indice As UShort = ListaFilm.FindIndex(Function(film As Film) If(film.PercorsoFile = e.OldFullPath, True, False))
        'If (Indice = -1) Then Exit Sub

        'Dim FilmNuovo As Film = ScansioneLibreria.ParsingNomeFile(e.Name, e.FullPath)
        'ListaFilm.RemoveAt(Indice)
        'ListaFilm.Add(FilmNuovo)

        'Dim IconaVecchiaEraSelezionata As Boolean = ElencoFilm.Items.Item(Indice).Selected
        'ElencoFilm.Items.RemoveAt(Indice)

        'Dim IconaNuova As ListViewItem = InserisciIcona(FilmNuovo)
        'If (IconaVecchiaEraSelezionata) Then
        '    ElencoFilm.Focus()
        '    IconaNuova.EnsureVisible()
        '    IconaNuova.Selected = True
        'End If
    End Sub

    Private Sub FileSystemWatcher_Created(sender As Object, e As IO.FileSystemEventArgs) Handles FileSystemWatcher.Created
        'Dim FilmNuovo As Film = ScansioneLibreria.ParsingNomeFile(e.Name, e.FullPath)
        'ListaFilm.Add(FilmNuovo)
        'InserisciIcona(FilmNuovo)
    End Sub

    Private Sub FileSystemWatcher_Deleted(sender As Object, e As IO.FileSystemEventArgs) Handles FileSystemWatcher.Deleted
        'Dim Indice As UShort = ListaFilm.FindIndex(Function(film As Film) If(film.PercorsoFile = e.FullPath, True, False))
        'If (Indice <> -1) Then
        '    ListaFilm.RemoveAt(Indice)
        '    ElencoFilm.Items.RemoveAt(Indice)
        'End If
    End Sub

    Private Sub MainForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        'Adatta dimensione pannelli SX e DX in base alla dimensione della finestra
        'If (Me.WindowState <> FormWindowState.Minimized) Then
        '    If (Not SplitContainerSX_CDX.Panel1Collapsed) Then
        '        SplitContainerSX_CDX.SplitterDistance = My.Settings.PannelloSxDimensione
        '    End If
        '    If (Not SplitContainerCSX_DX.Panel2Collapsed) Then
        '        SplitContainerC_DX.SplitterDistance = SplitContainerC_DX.Width - My.Settings.PannelloDxDimensione
        '    End If
        'End If
    End Sub

    Private Sub MainForm_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        If (Me.Visible = False) Then Exit Sub
        If (Me.WindowState = FormWindowState.Normal) Then
            My.Settings.FinestraDimensione = Me.Size
        Else 'finestra massimizzata o ridotta a icona
            My.Settings.FinestraDimensione = Me.RestoreBounds.Size
        End If
        My.Settings.FinestraMassimizzata = (Me.WindowState = FormWindowState.Maximized)
        My.Settings.Save()
    End Sub

    Private Sub MainForm_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged 'MyBase.Move
        If (Me.Visible = False) Then Exit Sub
        If (Me.WindowState = FormWindowState.Normal) Then
            My.Settings.FinestraPosizione = Me.Location
        Else 'finestra massimizzata o ridotta a icona
            My.Settings.FinestraPosizione = Me.RestoreBounds.Location
        End If
        My.Settings.Save()
    End Sub

    Private Sub PicSchermata_Click(sender As Object, e As EventArgs) Handles PicSchermata.Click
        Dim Film As Film = LibreriaFilm.Item(ListaIndiciFilmFiltrati.Item(ElencoFilm.SelectedIndices.Item(0)))
        Dim Path As String = MainModule.PercorsoSchermataFilm(Film.NomeFile)
        If (My.Computer.FileSystem.FileExists(Path)) Then
            Process.Start(Path)
        End If
    End Sub

    Private Sub PicSchermata_SizeChanged(sender As Object, e As EventArgs) Handles PicSchermata.SizeChanged
        'Dim AltezzaMax As UInteger = Math.Floor(Me.Height * 0.33)
        'PicSchermata.Height = Math.Min(AltezzaMax, Math.Round(PicSchermata.Width * 0.625))
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Dim IndiceNelFiltro As UShort = ElencoFilm.SelectedIndices.Item(0)
        Dim Indice As UShort = ListaIndiciFilmFiltrati.Item(IndiceNelFiltro)
        Dim Film As Film = LibreriaFilm.Item(Indice)
        ScegliSchermata.InizializzaFinestra(Film, IndiceNelFiltro) ', ElencoFilm.Items.Item(IndiceNelFiltro).ImageIndex
        ScegliSchermata.ShowDialog()
    End Sub

    Private Sub BottMostraFiltri_Click(sender As Object, e As EventArgs) Handles BottMostraFiltri.Click
        SplitContainerFiltriAvanzati_Icone.Panel1Collapsed = Not SplitContainerFiltriAvanzati_Icone.Panel1Collapsed
        If (SplitContainerFiltriAvanzati_Icone.Panel1Collapsed) Then
            BottMostraFiltri.Text = "➤ Filtri avanzati"
            BottCerca.Visible = True
        Else
            BottMostraFiltri.Text = "⮟ Filtri avanzati"
            BottCerca.Visible = False
        End If
    End Sub

    Private Sub FiltroAnnoMin_ValueChanged(sender As Object, e As EventArgs) Handles FiltroAnnoMin.ValueChanged
        If (FiltroAnnoMin.Value > FiltroAnnoMax.Value) Then FiltroAnnoMin.Value = FiltroAnnoMax.Value
        If (FiltroAnnoMin.Value = FiltroAnnoMin.Minimum) Then
            Label4.Text = "dal: - ∞"
        Else
            Label4.Text = "dal: " + FiltroAnnoMin.Value.ToString
        End If
    End Sub

    Private Sub FiltroAnnoMax_ValueChanged(sender As Object, e As EventArgs) Handles FiltroAnnoMax.ValueChanged
        If (FiltroAnnoMax.Value < FiltroAnnoMin.Value) Then FiltroAnnoMax.Value = FiltroAnnoMin.Value
        If (FiltroAnnoMax.Value = FiltroAnnoMax.Maximum) Then
            Label5.Text = "al: ∞"
        Else
            Label5.Text = "al: " + FiltroAnnoMax.Value.ToString
        End If
    End Sub

    Function DaMinutiAOreMin(Minuti As UShort) As String
        If (Minuti < 60) Then
            Return Minuti.ToString + " min"
        Else
            Dim Min As UShort = Minuti Mod 60
            Return Math.Floor(Minuti / 60).ToString + "h " + If(Min < 10, "0", "") + Min.ToString + " min"
        End If
    End Function

    Private Sub FiltroDurataMin_ValueChanged(sender As Object, e As EventArgs) Handles FiltroDurataMin.ValueChanged
        If (FiltroDurataMin.Value > FiltroDurataMax.Value) Then FiltroDurataMin.Value = FiltroDurataMax.Value
        Label9.Text = "da: " + DaMinutiAOreMin(FiltroDurataMin.Value)
    End Sub

    Private Sub FiltroDurataMax_ValueChanged(sender As Object, e As EventArgs) Handles FiltroDurataMax.ValueChanged
        If (FiltroDurataMax.Value < FiltroDurataMin.Value) Then FiltroDurataMax.Value = FiltroDurataMin.Value
        If (FiltroDurataMax.Value = FiltroDurataMax.Maximum) Then
            Label8.Text = "a: ∞"
        Else
            Label8.Text = "a: " + DaMinutiAOreMin(FiltroDurataMax.Value)
        End If
    End Sub

    Private Sub CasellaRicerca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CasellaRicerca.KeyPress
        If (e.KeyChar = Chr(13)) Then
            FiltraLista()
        End If
    End Sub

    Private Sub ElencoFilm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ElencoFilm.KeyPress
        If (e.KeyChar = Chr(13)) Then
            RiproduciSelezionato()
        End If
    End Sub

    Private Sub TitoloItalianoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TitoloItalianoToolStripMenuItem.Click
        TogliTutteLeSpunteDalMenuOrdinamento()
        sender.Checked = True
        ListaIndiciFilmFiltrati.Sort(Function(A As UShort, B As UShort) If(IsNothing(LibreriaFilm.Item(A).TitoloITA) Or IsNothing(LibreriaFilm.Item(B).TitoloITA), 0, String.Compare(LibreriaFilm.Item(A).TitoloITA, LibreriaFilm.Item(B).TitoloITA)))
        AggiornaIconeDaLista()
    End Sub

    Private Sub TitoloItalianoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TitoloItalianoToolStripMenuItem1.Click
        TogliTutteLeSpunteDalMenuOrdinamento()
        sender.Checked = True
        ListaIndiciFilmFiltrati.Sort(Function(A As UShort, B As UShort) If(IsNothing(LibreriaFilm.Item(A).TitoloITA) Or IsNothing(LibreriaFilm.Item(B).TitoloITA), 0, -1 * String.Compare(LibreriaFilm.Item(A).TitoloITA, LibreriaFilm.Item(B).TitoloITA)))
        AggiornaIconeDaLista()
    End Sub

    Private Sub AnnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnnoToolStripMenuItem.Click
        TogliTutteLeSpunteDalMenuOrdinamento()
        sender.Checked = True
        ListaIndiciFilmFiltrati.Sort(Function(A As UShort, B As UShort) If(IsNothing(LibreriaFilm.Item(A).Anno) Or IsNothing(LibreriaFilm.Item(B).Anno), 0, Short.Parse(LibreriaFilm.Item(A).Anno.ToString) - LibreriaFilm.Item(B).Anno))
        AggiornaIconeDaLista()
    End Sub

    Private Sub AnnoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AnnoToolStripMenuItem1.Click
        TogliTutteLeSpunteDalMenuOrdinamento()
        sender.Checked = True
        ListaIndiciFilmFiltrati.Sort(Function(A As UShort, B As UShort) If(IsNothing(LibreriaFilm.Item(A).Anno) Or IsNothing(LibreriaFilm.Item(B).Anno), 0, Short.Parse(LibreriaFilm.Item(B).Anno.ToString) - LibreriaFilm.Item(A).Anno))
        AggiornaIconeDaLista()
    End Sub

    Private Sub NazioneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NazioneToolStripMenuItem.Click
        TogliTutteLeSpunteDalMenuOrdinamento()
        sender.Checked = True
        ListaIndiciFilmFiltrati.Sort(Function(A As UShort, B As UShort) If(IsNothing(LibreriaFilm.Item(A).Nazione) Or IsNothing(LibreriaFilm.Item(B).Nazione), 0, String.Compare(LibreriaFilm.Item(A).Nazione, LibreriaFilm.Item(B).Nazione)))
        AggiornaIconeDaLista()
    End Sub

    Private Sub NazioneToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NazioneToolStripMenuItem1.Click
        TogliTutteLeSpunteDalMenuOrdinamento()
        sender.Checked = True
        ListaIndiciFilmFiltrati.Sort(Function(A As UShort, B As UShort) If(IsNothing(LibreriaFilm.Item(A).Nazione) Or IsNothing(LibreriaFilm.Item(B).Nazione), 0, -1 * String.Compare(LibreriaFilm.Item(A).Nazione, LibreriaFilm.Item(B).Nazione)))
        AggiornaIconeDaLista()
    End Sub

    Private Sub DurataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DurataToolStripMenuItem.Click
        TogliTutteLeSpunteDalMenuOrdinamento()
        sender.Checked = True
        ListaIndiciFilmFiltrati.Sort(Function(A As UShort, B As UShort) Short.Parse(LibreriaFilm.Item(A).DurataMinuti.ToString) - LibreriaFilm.Item(B).DurataMinuti)
        AggiornaIconeDaLista()
    End Sub

    Private Sub DurataToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DurataToolStripMenuItem1.Click
        TogliTutteLeSpunteDalMenuOrdinamento()
        sender.Checked = True
        ListaIndiciFilmFiltrati.Sort(Function(A As UShort, B As UShort) Short.Parse(LibreriaFilm.Item(B).DurataMinuti.ToString) - LibreriaFilm.Item(A).DurataMinuti)
        AggiornaIconeDaLista()
    End Sub

    Private Sub ElencoFilm_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles ElencoFilm.DrawSubItem
        e.DrawDefault = True
    End Sub

    Private Sub ElencoFilm_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles ElencoFilm.DrawColumnHeader
        If (ElencoFilm.View = View.Details) Then e.DrawDefault = True
    End Sub

    Private Sub ElencoFilm_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles ElencoFilm.DrawItem
        e.DrawDefault = True
    End Sub

    Private Sub PlaceholderCasellaRicerca_Click(sender As Object, e As EventArgs) Handles PlaceholderCasellaRicerca.Click
        CasellaRicerca.Focus()
    End Sub

    Private Sub CasellaRicerca_Enter(sender As Object, e As EventArgs) Handles CasellaRicerca.Enter
        PlaceholderCasellaRicerca.Visible = False
    End Sub

    Private Sub CasellaRicerca_Leave(sender As Object, e As EventArgs) Handles CasellaRicerca.Leave
        If (CasellaRicerca.Text.Length = 0) Then PlaceholderCasellaRicerca.Visible = True
    End Sub

    Private Sub ListaGeneri_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaGeneri.SelectedIndexChanged
        If (ListaGeneri.SelectedIndices.Count > 0) Then
            Dim genere As String = ListaGeneri.SelectedItems.Item(0).Text
            Dim IndiceGenere As Short = FilmPerGenere.FindIndex(Function(l) genere.Equals(l.GetEtichetta))
            If (IndiceGenere <> -1) Then AlberoCategorieLibreria.SelectedNode = AlberoCategorieLibreria.Nodes(3).Nodes(IndiceGenere)
        End If
    End Sub

    Private Sub ListaAttori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaAttori.SelectedIndexChanged
        If (ListaAttori.SelectedIndices.Count > 0) Then
            Dim attore As String = ListaAttori.SelectedItems.Item(0).Text
            Dim IndiceAttore As Short = FilmPerAttore.FindIndex(Function(l) attore.Equals(l.GetEtichetta))
            If (IndiceAttore <> -1) Then AlberoCategorieLibreria.SelectedNode = AlberoCategorieLibreria.Nodes(2).Nodes(IndiceAttore)
        End If
    End Sub

    Private Sub PannelloNazione_Click(sender As Object, e As EventArgs) Handles PannelloNazione.Click, NazioneLab.Click, NazionePic.Click
        If (NazioneLab.Text.Length > 0) Then
            Dim IndiceNazione As Short = FilmPerNazione.FindIndex(Function(l) NazioneLab.Text.Equals(l.GetEtichetta, StringComparison.CurrentCultureIgnoreCase))
            If (IndiceNazione <> -1) Then AlberoCategorieLibreria.SelectedNode = AlberoCategorieLibreria.Nodes(5).Nodes(IndiceNazione)
        End If
    End Sub

    Private Sub DefinizioneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefinizioneToolStripMenuItem.Click
        TogliTutteLeSpunteDalMenuOrdinamento()
        sender.Checked = True
        ListaIndiciFilmFiltrati.Sort(Function(A As UShort, B As UShort) If(IsNothing(LibreriaFilm.Item(A).Risoluzione), 1, LibreriaFilm.Item(A).Risoluzione.Height - LibreriaFilm.Item(B).Risoluzione.Height))
        AggiornaIconeDaLista()
    End Sub

    Private Sub DefinizioneToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DefinizioneToolStripMenuItem1.Click
        TogliTutteLeSpunteDalMenuOrdinamento()
        sender.Checked = True
        ListaIndiciFilmFiltrati.Sort(Function(A As UShort, B As UShort) If(IsNothing(LibreriaFilm.Item(A).Risoluzione), 1, LibreriaFilm.Item(B).Risoluzione.Height - LibreriaFilm.Item(A).Risoluzione.Height))
        AggiornaIconeDaLista()
    End Sub

    Private Sub BitrateToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BitrateToolStripMenuItem1.Click
        TogliTutteLeSpunteDalMenuOrdinamento()
        sender.Checked = True
        ListaIndiciFilmFiltrati.Sort(Function(A As UShort, B As UShort) Integer.Parse(LibreriaFilm.Item(A).BitrateComplessivoKBpS.ToString) - LibreriaFilm.Item(B).BitrateComplessivoKBpS)
        AggiornaIconeDaLista()
    End Sub

    Private Sub BitrateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BitrateToolStripMenuItem.Click
        TogliTutteLeSpunteDalMenuOrdinamento()
        sender.Checked = True
        ListaIndiciFilmFiltrati.Sort(Function(A As UShort, B As UShort) Short.Parse(LibreriaFilm.Item(B).BitrateComplessivoKBpS.ToString) - LibreriaFilm.Item(A).BitrateComplessivoKBpS)
        AggiornaIconeDaLista()
    End Sub

    Sub TogliTutteLeSpunteDalMenuOrdinamento()
        For Each MenuEntry In SottoMenuOrdineIcone.DropDownItems
            If (MenuEntry.GetType Is GetType(ToolStripMenuItem)) Then
                MenuEntry.Checked = False
            End If
        Next
    End Sub

    Private Sub RTFAudio_SelectionChanged(sender As Object, e As EventArgs) Handles RTFAudio.SelectionChanged
        RTFAudio.Select(0, 0)
        Me.Focus()
    End Sub

    Private Sub RTFSottotitoli_SelectionChanged(sender As Object, e As EventArgs) Handles RTFSottotitoli.SelectionChanged
        RTFSottotitoli.Select(0, 0)
        Me.Focus()
    End Sub

    Private Sub FiltroRisoluzioneMin_ValueChanged(sender As Object, e As EventArgs) Handles FiltroRisoluzioneMin.ValueChanged
        Select Case FiltroRisoluzioneMin.Value
            Case 0
                Label29.Text = "Qualunque"
                Label29.BackColor = Color.Transparent
                Label29.ForeColor = Nothing
            Case 1
                Label29.Text = "Low Definition (240p)"
                Label29.BackColor = Color.FromArgb(80, 80, 80)
                Label29.ForeColor = Color.White
            Case 2
                Label29.Text = "Standard Definition (480p)"
                Label29.BackColor = Color.White
                Label29.ForeColor = Color.Black
            Case 3
                Label29.Text = "High Definition (720p)"
                Label29.BackColor = Color.MediumVioletRed
                Label29.ForeColor = Color.White
            Case 4
                Label29.Text = "Full HD (1080p)"
                Label29.BackColor = Color.DodgerBlue
                Label29.ForeColor = Color.White
            Case 5
                Label29.Text = "Quad HD (1440p)"
                Label29.BackColor = Color.SandyBrown
                Label29.ForeColor = Color.Black
            Case 6
                Label29.Text = "4K UHD (2160p)"
                Label29.BackColor = Color.Gold
                Label29.ForeColor = Color.Black
            Case 7
                Label29.Text = "8K UHD (4320p)"
                Label29.BackColor = Color.Silver
                Label29.ForeColor = Color.Black
        End Select
    End Sub

    Private Sub FiltroBitrateMin_ValueChanged(sender As Object, e As EventArgs) Handles FiltroBitrateMin.ValueChanged
        Dim Minimo As Double = GetValoreFiltroBitrate()
        If (Minimo = 0) Then
            Label30.Text = "Qualunque"
            Label30.ForeColor = Nothing
            Label30.BackColor = Color.Transparent
        Else
            Label30.Text = Minimo.ToString + " MB/s"
            If (Minimo <= 10) Then
                Label30.BackColor = GradazioneNeroRossoGialloVerde(Minimo / 8)
            ElseIf (Minimo <= 30) Then
                Label30.BackColor = Color.SkyBlue
            Else
                Label30.BackColor = Color.Gold
            End If

            If (Minimo <= 2) Then
                Label30.ForeColor = Color.White
            Else
                Label30.ForeColor = Color.Black
            End If
        End If
    End Sub

    Function GetValoreFiltroBitrate() As Double
        Select Case FiltroBitrateMin.Value
            Case 0
                Return 0
            Case 1
                Return 0.5
            Case 2
                Return 1
            Case 3
                Return 1.5
            Case 4
                Return 2
            Case 5
                Return 3
            Case 6
                Return 4
            Case 7
                Return 5
            Case 8
                Return 6
            Case 9
                Return 8
            Case 10
                Return 10
            Case 11
                Return 15
            Case 12
                Return 20
            Case 13
                Return 30
            Case 14
                Return 50
            Case 15
                Return 75
            Case 16
                Return 100
            Case Else
                Return -1
        End Select
    End Function

    Private Sub RiproduciSelezionato(sender As Object, e As EventArgs) Handles PlayButton.Click, ElencoFilm.DoubleClick

    End Sub

    Private Sub FiltraLista(sender As Object, e As EventArgs) Handles BottFiltra.Click, BottCerca.Click

    End Sub

    Private Sub MainForm_SystemColorsChanged(sender As Object, e As EventArgs) Handles MyBase.SystemColorsChanged
        Dim ModalitaCambiata As Boolean = MainModule.AggiornaModalitaNotte()
        If (ModalitaCambiata) Then ImpostaColori(MainModule.ModalitaNotte)
    End Sub

    'Private Sub SplitImmagineDettagli_SplitterMoved(sender As Object, e As SplitterEventArgs)
    '    If (SplitImmagineDettagli.Panel1Collapsed = False And Me.Visible) Then
    '        My.Settings.PannelloSchermataDimensione = SplitImmagineDettagli.SplitterDistance
    '        My.Settings.Save()
    '    End If
    'End Sub

    Private Sub ButtPannelloSchermata_Click(sender As Object, e As EventArgs) Handles ButtPannelloSchermata.Click
        PicSchermata.Visible = Not (PicSchermata.Visible)
        'ButtPannelloSchermata.Text = If(SplitImmagineDettagli.Panel1Collapsed, "mostra schermata ∨", "nascondi schermata ∧")
        ButtPannelloSchermata.BackColor = If(PicSchermata.Visible, Color.FromArgb(192, 192, 255), Color.Transparent)
        My.Settings.PannelloSchermataChiuso = Not PicSchermata.Visible
        My.Settings.Save()
    End Sub

    Private Sub ButtTogglePoster_Click(sender As Object, e As EventArgs) Handles ButtTogglePoster.Click
        SplitPosterInfoPrincipali.Panel1Collapsed = Not SplitPosterInfoPrincipali.Panel1Collapsed
        ButtTogglePoster.BackColor = If(SplitPosterInfoPrincipali.Panel1Collapsed, Color.Transparent, Color.FromArgb(192, 192, 255))
        My.Settings.PannelloPosterChiuso = SplitPosterInfoPrincipali.Panel1Collapsed
        My.Settings.Save()
    End Sub

    Public Sub ImpostaContenutoSchermataDestra(VisualizzaInfoFilm As Boolean, VisualizzaInfoCategoria As Boolean)
        PanelDettagliFilm.Visible = VisualizzaInfoFilm
        BarraStrumentiFilm.Visible = VisualizzaInfoFilm
        PanelDettagliCategoria.Visible = VisualizzaInfoCategoria
    End Sub

    Private Sub ButtRicercaPersonaIMDB_Click(sender As Object, e As EventArgs) Handles ButtRicercaPersonaIMDB.Click
        Process.Start("https://www.imdb.com/search/name-text/?bio=" + Uri.EscapeUriString(LabValoreCategoriaScelta.Text))
    End Sub

    Private Sub PicImgPersona_Click(sender As Object, e As EventArgs) Handles PicImgPersona.Click
        Dim PathImg As String = MainModule.PercorsoImmaginePersona(MainModule.SeparaNomeCognome(LabValoreCategoriaScelta.Text)(1), MainModule.SeparaNomeCognome(LabValoreCategoriaScelta.Text)(0).Chars(0))
        If (My.Computer.FileSystem.FileExists(PathImg)) Then
            Process.Start(PathImg)
        End If
    End Sub

    Private Sub ButCambiaImgPersona_Click_1(sender As Object, e As EventArgs) Handles ButCambiaImgPersona.Click
        Dim PathImmagine As String = MainModule.PercorsoImmaginePersona(MainModule.SeparaNomeCognome(LabValoreCategoriaScelta.Text)(1), If(MainModule.SeparaNomeCognome(LabValoreCategoriaScelta.Text)(0) <> "", MainModule.SeparaNomeCognome(LabValoreCategoriaScelta.Text)(0).Chars(0), ""))
        ScegliImmaginePersona.PreparaFinestra(LabValoreCategoriaScelta.Text, PathImmagine)
        ScegliImmaginePersona.ShowDialog()
    End Sub

    Private Sub DownloadButton_Click(sender As Object, e As EventArgs) Handles DownloadButton.Click
        If (ElencoFilm.SelectedIndices.Count <= 0 OrElse Not My.Computer.Network.IsAvailable) Then Exit Sub
        Dim Film As Film = LibreriaFilm.Item(ListaIndiciFilmFiltrati.Item(ElencoFilm.SelectedIndices.Item(0)))

        IndividuaIMDB.CaricaInfoFilm(Film)
        If (IndividuaIMDB.ShowDialog() <> Windows.Forms.DialogResult.OK) Then
            Exit Sub
        Else
            Dim IdIMDB As String = IndividuaIMDB.IdIMDB

            If (Not IsNothing(IdIMDB)) Then
                MainModule.ScaricaDatiIMDB(IdIMDB, Film.NomeFile)
                'Aggiorno icone
                AggiornaContenutoPannelloDestra()
                ForzaAggiornamentoIcone()
            End If
        End If
    End Sub

    Private Sub ButtonToggleTrama_Click(sender As Object, e As EventArgs) Handles ButtonToggleTrama.Click
        If (LabTramaBreve.Visible) Then
            VisualizzaTrama(False)
        Else
            VisualizzaTrama(True)
        End If
    End Sub

    Sub VisualizzaTrama(Breve As Boolean)
        If (Breve) Then
            LabTramaBreve.Visible = True
            TextTramaLunga.Visible = False
            ButtonToggleTrama.Text = "Espandi"
        Else
            LabTramaBreve.Visible = False
            TextTramaLunga.Visible = True
            ButtonToggleTrama.Text = "Riassumi"
        End If
    End Sub

    Private Sub PicPoster_Click(sender As Object, e As EventArgs) Handles PicPoster.Click
        Dim Film As Film = LibreriaFilm.Item(ListaIndiciFilmFiltrati.Item(ElencoFilm.SelectedIndices.Item(0)))
        Dim Path As String = MainModule.PercorsoPosterFilm(Film.NomeFile)
        If (My.Computer.FileSystem.FileExists(Path)) Then
            Process.Start(Path)
        End If
    End Sub

    Private Sub SchermataToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles SchermataToolStripMenuItem.CheckedChanged
        If (SchermataToolStripMenuItem.Checked) Then
            My.Settings.PreferisciIconePoster = False
            My.Settings.Save()
            ElencoFilm.LargeImageList = SchermateFilmGrandi
            PosterFilmGrandi.Images.Clear()
            ElencoFilm.SmallImageList = SchermateFilmPiccole
            PosterFilmPiccoli.Images.Clear()
            ForzaAggiornamentoIcone()
            PosterToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub PosterToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles PosterToolStripMenuItem.CheckedChanged
        If (PosterToolStripMenuItem.Checked) Then
            My.Settings.PreferisciIconePoster = True
            My.Settings.Save()
            ElencoFilm.LargeImageList = PosterFilmGrandi
            SchermateFilmGrandi.Images.Clear()
            ElencoFilm.SmallImageList = PosterFilmPiccoli
            SchermateFilmPiccole.Images.Clear()
            ForzaAggiornamentoIcone()
            SchermataToolStripMenuItem.Checked = False
        End If
    End Sub

    Sub ForzaAggiornamentoIcone()
        'Invalido la cache esistente
        CacheIcone = Nothing
        'Svuoto raccolta icone esistente
        ElencoFilm.LargeImageList.Images.Clear()
        ElencoFilm.SmallImageList.Images.Clear()
        'Obbligo il ListView a rigenerare le icone
        ElencoFilm.Invalidate()
    End Sub

    Private Sub ScegliLibreriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScegliLibreriaToolStripMenuItem.Click
        ScegliLibreria.ShowDialog()
    End Sub

    Private Sub AutomaticosegueQuelloDiWindowsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TemaWindowsToolStripMenuItem.Click
        My.Settings.TemaColori = MainModule.SceltaTema.Windows
        My.Settings.Save()
        MainModule.AggiornaTemaColoriDaImpostazioni()
    End Sub

    Private Sub TemaChiaroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TemaChiaroToolStripMenuItem.Click
        My.Settings.TemaColori = MainModule.SceltaTema.Giorno
        My.Settings.Save()
        MainModule.AggiornaTemaColoriDaImpostazioni()
    End Sub

    Private Sub TemaScuroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TemaScuroToolStripMenuItem.Click
        My.Settings.TemaColori = MainModule.SceltaTema.Notte
        My.Settings.Save()
        MainModule.AggiornaTemaColoriDaImpostazioni()
    End Sub

    Private Sub NumeroFilmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NumeroFilmToolStripMenuItem.Click
        My.Settings.CategorieOrdinamento = MainModule.OrdinamentoValoriCategorie.NumFilm
        My.Settings.Save()
        AggiornaAlberoCategorie()
    End Sub

    Private Sub DurataFilmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DurataFilmToolStripMenuItem.Click

        My.Settings.CategorieOrdinamento = MainModule.OrdinamentoValoriCategorie.DurataFilm
        My.Settings.Save()
        AggiornaAlberoCategorie()
    End Sub

    Private Sub AlfabeticoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlfabeticoToolStripMenuItem.Click
        My.Settings.CategorieOrdinamento = MainModule.OrdinamentoValoriCategorie.NomeAsc
        My.Settings.Save()
        AggiornaAlberoCategorie()
    End Sub

    Private Sub EpocaDiAttivitàultimaUscitaPiùRecenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EpocaDiAttivitàultimaUscitaPiùRecenteToolStripMenuItem.Click
        My.Settings.CategorieOrdinamento = MainModule.OrdinamentoValoriCategorie.UltimaUscitaDesc
        My.Settings.Save()
        AggiornaAlberoCategorie()
    End Sub

    Private Sub EpocaDiAttivitàultimaUscitaPiùRemotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EpocaDiAttivitàultimaUscitaPiùRemotaToolStripMenuItem.Click
        My.Settings.CategorieOrdinamento = MainModule.OrdinamentoValoriCategorie.UltimaUscitaAsc
        My.Settings.Save()
        AggiornaAlberoCategorie()
    End Sub

    Private Sub NessunaInformazioneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NessunaInformazioneToolStripMenuItem.Click
        My.Settings.CategorieInfo = MainModule.InfoCategoria.Nessuna
        My.Settings.Save()
        AggiornaAlberoCategorie()
    End Sub

    Private Sub PeriodoDiAttivitàToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeriodoDiAttivitàToolStripMenuItem.Click
        My.Settings.CategorieInfo = MainModule.InfoCategoria.PeriodoAttivita
        My.Settings.Save()
        AggiornaAlberoCategorie()
    End Sub

    Private Sub DurataFilmToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DurataFilmToolStripMenuItem1.Click
        My.Settings.CategorieInfo = MainModule.InfoCategoria.DurataFilm
        My.Settings.Save()
        AggiornaAlberoCategorie()
    End Sub

    Private Sub ConteggioFilmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConteggioFilmToolStripMenuItem.Click
        My.Settings.CategorieInfo = MainModule.InfoCategoria.ConteggioFilm
        My.Settings.Save()
        AggiornaAlberoCategorie()
    End Sub

    Private Sub SplitContainerFiltriAvanzati_Icone_SizeChanged(sender As Object, e As EventArgs) Handles SplitContainerFiltriAvanzati_Icone.SizeChanged
        If (SplitContainerFiltriAvanzati_Icone.Width < 800 And SplitContainerFiltriAvanzati_Icone.Orientation = Orientation.Vertical) Then
            SplitContainerFiltriAvanzati_Icone.Orientation = Orientation.Horizontal
            SplitContainerFiltriAvanzati_Icone.SplitterDistance = Math.Floor(SplitContainerFiltriAvanzati_Icone.Height / 3)
        ElseIf (SplitContainerFiltriAvanzati_Icone.Width >= 800 And SplitContainerFiltriAvanzati_Icone.Orientation = Orientation.Horizontal) Then
            SplitContainerFiltriAvanzati_Icone.Orientation = Orientation.Vertical
            SplitContainerFiltriAvanzati_Icone.SplitterDistance = Math.Floor(SplitContainerFiltriAvanzati_Icone.Width / 4)
        End If
    End Sub

    Private Sub AggiornaLibreriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AggiornaLibreriaToolStripMenuItem.Click
        SvuotaElencoFilm()
        ScansioneLibreria.PercorsiFile = My.Computer.FileSystem.GetFiles(My.Settings.LibreriaPercorso)
        ScansioneLibreria.ShowDialog()

        'Aggiorno categorie disponibili (albero menu sinistra)
        AggiornaAlberoCategorie()
        'Ricalcolo i film da visualizzare in base a categoria e filtri selezionati, e ripopolo la ListView con le relative icone
        SelezioneCategoria()
    End Sub

    Private Sub FiltroMinVotoIMDB_ValueChanged(sender As Object, e As EventArgs) Handles FiltroMinVotoIMDB.ValueChanged
        If (FiltroMinVotoIMDB.Value = FiltroMinVotoIMDB.Minimum) Then
            LabMinVotoIMDB.Text = "Qualsiasi"
        Else
            LabMinVotoIMDB.Text = (FiltroMinVotoIMDB.Value / 10).ToString
        End If
    End Sub

    Private Sub FiltroMinVotoMetacritic_ValueChanged(sender As Object, e As EventArgs) Handles FiltroMinVotoMetacritic.ValueChanged
        If (FiltroMinVotoMetacritic.Value = FiltroMinVotoMetacritic.Minimum) Then
            LabMinVotoMetacritic.Text = "Qualsiasi"
        Else
            LabMinVotoMetacritic.Text = FiltroMinVotoMetacritic.Value.ToString + " /100"
        End If
    End Sub

    Private Sub FiltroMinVotoRotten_ValueChanged(sender As Object, e As EventArgs) Handles FiltroMinVotoRotten.ValueChanged
        If (FiltroMinVotoRotten.Value = FiltroMinVotoRotten.Minimum) Then
            LabMinVotoRotten.Text = "Qualsiasi"
        Else
            LabMinVotoRotten.Text = FiltroMinVotoRotten.Value.ToString + "%"
        End If
    End Sub

    Private Sub FiltroMinNumVotiIMDB_ValueChanged(sender As Object, e As EventArgs) Handles FiltroMinNumVotiIMDB.ValueChanged
        If (FiltroMinNumVotiIMDB.Value = FiltroMinNumVotiIMDB.Minimum) Then
            LabMinNumVotiIMDB.Text = "Qualsiasi"
        ElseIf (FiltroMinNumVotiIMDB.Value < 1000) Then
            LabMinNumVotiIMDB.Text = FiltroMinNumVotiIMDB.Value.ToString + " mila"
        Else
            LabMinNumVotiIMDB.Text = Math.Round(FiltroMinNumVotiIMDB.Value / 1000, 2).ToString + " mln"
        End If
    End Sub

    Private Sub FiltroMinIncasso_ValueChanged(sender As Object, e As EventArgs) Handles FiltroMinIncasso.ValueChanged
        If (FiltroMinIncasso.Value = FiltroMinIncasso.Minimum) Then
            LabMinIncasso.Text = "Qualsiasi"
        ElseIf (FiltroMinIncasso.Value < 1000) Then
            LabMinIncasso.Text = FiltroMinIncasso.Value.ToString + " mila $"
        ElseIf (FiltroMinIncasso.Value < 1000000) Then
            LabMinIncasso.Text = Math.Round(FiltroMinIncasso.Value / 1000, 1).ToString + " mln $"
        Else
            LabMinIncasso.Text = Math.Round(FiltroMinIncasso.Value / 1000000, 1).ToString + " mld $"
        End If
    End Sub

    Private Sub PerValutazioneIMDBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerValutazioneIMDBToolStripMenuItem.Click
        TogliTutteLeSpunteDalMenuOrdinamento()
        sender.Checked = True
        ListaIndiciFilmFiltrati.Sort(Function(A As UShort, B As UShort) -1 * (LibreriaFilm.Item(A).VotoIMDB - LibreriaFilm.Item(B).VotoIMDB))
        AggiornaIconeDaLista()
    End Sub

    Private Sub PerNumeroVotiIMDBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerNumeroVotiIMDBToolStripMenuItem.Click
        TogliTutteLeSpunteDalMenuOrdinamento()
        sender.Checked = True
        ListaIndiciFilmFiltrati.Sort(Function(A As UShort, B As UShort) -1 * (Integer.Parse(LibreriaFilm.Item(A).NumVotiIMDB.ToString) - LibreriaFilm.Item(B).NumVotiIMDB))
        AggiornaIconeDaLista()
    End Sub

    Private Sub PerValutazioneMetacriticToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerValutazioneMetacriticToolStripMenuItem.Click
        TogliTutteLeSpunteDalMenuOrdinamento()
        sender.Checked = True
        ListaIndiciFilmFiltrati.Sort(Function(A As UShort, B As UShort) -1 * (Short.Parse(LibreriaFilm.Item(A).VotoMetacritic.ToString) - LibreriaFilm.Item(B).VotoMetacritic))
        AggiornaIconeDaLista()
    End Sub

    Private Sub PerValutazioneRottenTomatoesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerValutazioneRottenTomatoesToolStripMenuItem.Click
        TogliTutteLeSpunteDalMenuOrdinamento()
        sender.Checked = True
        ListaIndiciFilmFiltrati.Sort(Function(A As UShort, B As UShort) -1 * (Short.Parse(LibreriaFilm.Item(A).VotoRottenTomatoes.ToString) - LibreriaFilm.Item(B).VotoRottenTomatoes))
        AggiornaIconeDaLista()
    End Sub

    Private Sub PerIncassiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerIncassiToolStripMenuItem.Click
        TogliTutteLeSpunteDalMenuOrdinamento()
        sender.Checked = True
        ListaIndiciFilmFiltrati.Sort(Function(A As UShort, B As UShort) -1 * (Integer.Parse(LibreriaFilm.Item(A).IncassoDollari.ToString) - LibreriaFilm.Item(B).IncassoDollari))
        AggiornaIconeDaLista()
    End Sub

    Private Sub PerOscarVintiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerOscarVintiToolStripMenuItem.Click
        TogliTutteLeSpunteDalMenuOrdinamento()
        sender.Checked = True
        ListaIndiciFilmFiltrati.Sort(Function(A As UShort, B As UShort) -1 * (Short.Parse(LibreriaFilm.Item(A).OscarVinti.ToString) - LibreriaFilm.Item(B).OscarVinti))
        AggiornaIconeDaLista()
    End Sub

    Private Sub PerOscarvintiNominatiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerOscarvintiNominatiToolStripMenuItem.Click
        TogliTutteLeSpunteDalMenuOrdinamento()
        sender.Checked = True
        ListaIndiciFilmFiltrati.Sort(Function(A As UShort, B As UShort) -1 * (Short.Parse(LibreriaFilm.Item(A).OscarVinti + LibreriaFilm.Item(A).OscarNominati) - (LibreriaFilm.Item(B).OscarVinti + LibreriaFilm.Item(B).OscarNominati)))
        AggiornaIconeDaLista()
    End Sub

    Private Sub PerPremiVintiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerPremiVintiToolStripMenuItem.Click
        TogliTutteLeSpunteDalMenuOrdinamento()
        sender.Checked = True
        ListaIndiciFilmFiltrati.Sort(Function(A As UShort, B As UShort) -1 * (Short.Parse(LibreriaFilm.Item(A).OscarVinti + LibreriaFilm.Item(A).BAFTAVinti + LibreriaFilm.Item(A).AltriPremiVinti) - (LibreriaFilm.Item(B).OscarVinti + LibreriaFilm.Item(B).BAFTAVinti + LibreriaFilm.Item(B).AltriPremiVinti)))
        AggiornaIconeDaLista()
    End Sub

    Private Sub PerPremiNominatiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerPremiNominatiToolStripMenuItem.Click
        TogliTutteLeSpunteDalMenuOrdinamento()
        sender.Checked = True
        ListaIndiciFilmFiltrati.Sort(Function(A As UShort, B As UShort) -1 * (Short.Parse(LibreriaFilm.Item(A).OscarNominati + LibreriaFilm.Item(A).BAFTANominati + LibreriaFilm.Item(A).AltriPremiNominati) - (LibreriaFilm.Item(B).OscarNominati + LibreriaFilm.Item(B).BAFTANominati + LibreriaFilm.Item(B).AltriPremiNominati)))
        AggiornaIconeDaLista()
    End Sub

    Private Sub CreditiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditiToolStripMenuItem.Click
        About.ShowDialog()
    End Sub
End Class
