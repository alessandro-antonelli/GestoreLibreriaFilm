<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("C. Grant")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("G. Kelly")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("B. Pitt")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Guerra", 29)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Drammatico", 20)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Comico", 18)
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tutti i film", 1, 1)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Registi", 2, 2)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Attori", 3, 3)
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("🙂 Commedia")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("🤣 Comico")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("😭 Drammatico")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("🕵️ Giallo")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("👮 Polizesco")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("🏴 Noir")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("🤢 Splatter")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("😱 Horror", New System.Windows.Forms.TreeNode() {TreeNode10})
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("😲 Thriller", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8, TreeNode9, TreeNode11})
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("🔫 Gangster")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("🤖 Fantascienza")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("⚔️ Guerra")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("🎅 Natalizio")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Generi", 4, 4, New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5, TreeNode6, TreeNode12, TreeNode13, TreeNode14, TreeNode15, TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Anni", 5, 5)
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nazioni", 6, 6)
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Saghe", 85, 85)
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Autori", 7, 7)
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Musicisti", 8, 8)
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Temi", 9, 9)
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Antica Grecia")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Antica Roma")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Medioevo")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cinquecento")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Seicento")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Settecento")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ottocento")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Prima guerra mondiale")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Seconda guerra mondiale")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Vietnam")
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Anni di piombo")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Novecento", New System.Windows.Forms.TreeNode() {TreeNode31, TreeNode32, TreeNode33, TreeNode34})
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ambientazione", 10, 10, New System.Windows.Forms.TreeNode() {TreeNode24, TreeNode25, TreeNode26, TreeNode27, TreeNode28, TreeNode29, TreeNode30, TreeNode35})
        Me.BarraStrumentiPrincipale = New System.Windows.Forms.ToolStrip()
        Me.ButtTogglePannelloSx = New System.Windows.Forms.ToolStripButton()
        Me.ButtTogglePannelloDx = New System.Windows.Forms.ToolStripButton()
        Me.ButtCronoIndietro = New System.Windows.Forms.ToolStripButton()
        Me.ButtCronoAvanti = New System.Windows.Forms.ToolStripButton()
        Me.SottoMenuVisualizzazioneIcone = New System.Windows.Forms.ToolStripDropDownButton()
        Me.VisualizzazioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IconeGrandiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IconePiccoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColonneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FonteIconeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchermataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PosterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScegliCampiTestualeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScegliCampiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SottoMenuOrdineIcone = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TitoloItalianoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NazioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DurataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefinizioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BitrateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DiscendenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TitoloItalianoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnnoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NazioneToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DurataToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefinizioneToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BitrateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerValutazioneIMDBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerNumeroVotiIMDBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerValutazioneMetacriticToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerValutazioneRottenTomatoesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerIncassiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerOscarVintiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerOscarvintiNominatiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerPremiVintiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerPremiNominatiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtFilmCasuale = New System.Windows.Forms.ToolStripButton()
        Me.SottoMenuImpostazioni = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ScegliLibreriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AggiornaLibreriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TemaColoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemaWindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemaChiaroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemaScuroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpostazioniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ControllaAggiornamentiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.IconeCategorieLibreria = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainerFiltriAvanzati_Icone = New System.Windows.Forms.SplitContainer()
        Me.SchedeFiltriAvanzati = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanel9 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.FiltroNazioni = New System.Windows.Forms.CheckedListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.FiltroGeneri = New System.Windows.Forms.CheckedListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FiltroDurataMin = New System.Windows.Forms.TrackBar()
        Me.FiltroDurataMax = New System.Windows.Forms.TrackBar()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FiltroAnnoMax = New System.Windows.Forms.TrackBar()
        Me.FiltroAnnoMin = New System.Windows.Forms.TrackBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanel8 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.FiltroAudio = New System.Windows.Forms.CheckedListBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.FiltroSottotitoli = New System.Windows.Forms.CheckedListBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.FiltroBitrateMin = New System.Windows.Forms.TrackBar()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.FiltroRisoluzioneMin = New System.Windows.Forms.TrackBar()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.FiltroMinVotoRotten = New System.Windows.Forms.TrackBar()
        Me.LabMinVotoRotten = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.FiltroMinVotoMetacritic = New System.Windows.Forms.TrackBar()
        Me.LabMinVotoMetacritic = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.FiltroMinIncasso = New System.Windows.Forms.TrackBar()
        Me.LabMinIncasso = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.FiltroMinNumVotiIMDB = New System.Windows.Forms.TrackBar()
        Me.LabMinNumVotiIMDB = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FiltroMinVotoIMDB = New System.Windows.Forms.TrackBar()
        Me.LabMinVotoIMDB = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.BottFiltra = New System.Windows.Forms.Button()
        Me.StatusEsecuzioneBackground = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ElencoFilm = New System.Windows.Forms.ListView()
        Me.ColTitolo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColAnno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColNazione = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColRegisti = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColGeneri = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColAttori = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColAutori = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColMusicisti = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SchermateFilmGrandi = New System.Windows.Forms.ImageList(Me.components)
        Me.SchermateFilmPiccole = New System.Windows.Forms.ImageList(Me.components)
        Me.PannelloFiltri = New System.Windows.Forms.Panel()
        Me.PannelloFiltriSemplici = New System.Windows.Forms.Panel()
        Me.PlaceholderCasellaRicerca = New System.Windows.Forms.Label()
        Me.CasellaRicerca = New System.Windows.Forms.TextBox()
        Me.BottMostraFiltri = New System.Windows.Forms.Button()
        Me.BottCerca = New System.Windows.Forms.Button()
        Me.PannelloEsitoFiltri = New System.Windows.Forms.FlowLayoutPanel()
        Me.LabEsitoFiltri = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BottCancellaFiltri = New System.Windows.Forms.Button()
        Me.PanelDettagliFilm = New System.Windows.Forms.Panel()
        Me.PannelloExtra = New System.Windows.Forms.Panel()
        Me.ButtAddExtra = New System.Windows.Forms.Button()
        Me.ListaExtra = New System.Windows.Forms.ListBox()
        Me.IntestazioneExtra = New System.Windows.Forms.Label()
        Me.PanelFile = New System.Windows.Forms.Panel()
        Me.SplitAudioSottotitoli = New System.Windows.Forms.SplitContainer()
        Me.PannelloAudio = New System.Windows.Forms.Panel()
        Me.RTFAudio = New System.Windows.Forms.RichTextBox()
        Me.IntestazioneAudio = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox20 = New System.Windows.Forms.PictureBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PannelloSottotitoli = New System.Windows.Forms.Panel()
        Me.RTFSottotitoli = New System.Windows.Forms.RichTextBox()
        Me.IntestazioneSottotitoli = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox21 = New System.Windows.Forms.PictureBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.PannelloVideo = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel7 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PannelloRisoluzione = New System.Windows.Forms.Panel()
        Me.BadgeRisoluzione = New System.Windows.Forms.Panel()
        Me.LabAltezzaRisoluzione = New System.Windows.Forms.Label()
        Me.LabTipoRisoluzione = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PannelloCodecVideo = New System.Windows.Forms.Panel()
        Me.LabCodecVideo = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PannelloBitrateVideo = New System.Windows.Forms.Panel()
        Me.LabBitrateVideo = New System.Windows.Forms.Label()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PannelloProporzioni = New System.Windows.Forms.Panel()
        Me.LabProporzioni = New System.Windows.Forms.Label()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PannelloFPS = New System.Windows.Forms.Panel()
        Me.LabFPS = New System.Windows.Forms.Label()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.IntestazioneVideo = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox19 = New System.Windows.Forms.PictureBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.PannelloContenitore = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.LabEstensione = New System.Windows.Forms.Label()
        Me.LabCodecFile = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.LabDimensioneFile = New System.Windows.Forms.Label()
        Me.PanBitrateFile = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.LabBitrateFile = New System.Windows.Forms.Label()
        Me.IntestazioneContenitore = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.IntestazioneFile = New System.Windows.Forms.Label()
        Me.PanelValutazioni = New System.Windows.Forms.Panel()
        Me.PanComtenutoValutazioni = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.PanVotoIMDB = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LabVotoIMDB = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.PanNumVotiIMDB = New System.Windows.Forms.Panel()
        Me.LabMoltiplicatoreNumVotiIMDB = New System.Windows.Forms.Label()
        Me.LabNumVotiIMDB = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.PanIncassi = New System.Windows.Forms.Panel()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.LabMoltiplicatoreIncassi = New System.Windows.Forms.Label()
        Me.LabIncassi = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.PanMetacritic = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LabMetacritic = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PanRotten = New System.Windows.Forms.Panel()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.LabRotten = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.PanPremiVinti = New System.Windows.Forms.Panel()
        Me.PanAltriVinti = New System.Windows.Forms.Panel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.LabAltriVinti = New System.Windows.Forms.Label()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PanBAFTAVinti = New System.Windows.Forms.Panel()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.LabBAFTAVinti = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PanOscarVinti = New System.Windows.Forms.Panel()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.LabOscarVinti = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.PanPremiNominati = New System.Windows.Forms.Panel()
        Me.PanAltriNominati = New System.Windows.Forms.Panel()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.LabAltriNominati = New System.Windows.Forms.Label()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PanBAFTANominati = New System.Windows.Forms.Panel()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.LabBAFTANominati = New System.Windows.Forms.Label()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PanOscarNominati = New System.Windows.Forms.Panel()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.LabOscarNominati = New System.Windows.Forms.Label()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.IntestazioneValutazioni = New System.Windows.Forms.Label()
        Me.PannelloTrama = New System.Windows.Forms.Panel()
        Me.LabTramaBreve = New System.Windows.Forms.Label()
        Me.TextTramaLunga = New System.Windows.Forms.TextBox()
        Me.ButtonToggleTrama = New System.Windows.Forms.Button()
        Me.IntestazioneTrama = New System.Windows.Forms.Label()
        Me.PannelloAttori = New System.Windows.Forms.Panel()
        Me.ListaAttori = New System.Windows.Forms.ListView()
        Me.IntestazioneAttori = New System.Windows.Forms.Label()
        Me.PannelloGeneri = New System.Windows.Forms.Panel()
        Me.ListaGeneri = New System.Windows.Forms.ListView()
        Me.IntestazioneGeneri = New System.Windows.Forms.Label()
        Me.SplitPosterInfoPrincipali = New System.Windows.Forms.SplitContainer()
        Me.PicPoster = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LabTitoloITA = New System.Windows.Forms.Label()
        Me.LabTitoloORIG = New System.Windows.Forms.Label()
        Me.PanelNote = New System.Windows.Forms.Panel()
        Me.LabNote = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PanelToggleImg = New System.Windows.Forms.Panel()
        Me.ButtPannelloSchermata = New System.Windows.Forms.Button()
        Me.ButtTogglePoster = New System.Windows.Forms.Button()
        Me.PanelAnno = New System.Windows.Forms.Panel()
        Me.LabAnno = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PannelloNazione = New System.Windows.Forms.Panel()
        Me.NazionePic = New System.Windows.Forms.PictureBox()
        Me.NazioneLab = New System.Windows.Forms.Label()
        Me.PanelDurata = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LabDurata = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.LabFineVisione = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PanelRegisti = New System.Windows.Forms.Panel()
        Me.LabRegisti = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PanelAutori = New System.Windows.Forms.Panel()
        Me.LabAutori = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PanelMusicisti = New System.Windows.Forms.Panel()
        Me.LabMusicisti = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PicSchermata = New System.Windows.Forms.PictureBox()
        Me.BarraStrumentiFilm = New System.Windows.Forms.ToolStrip()
        Me.PlayButton = New System.Windows.Forms.ToolStripButton()
        Me.EsploraRisorseButton = New System.Windows.Forms.ToolStripButton()
        Me.RinominaButton = New System.Windows.Forms.ToolStripButton()
        Me.DownloadButton = New System.Windows.Forms.ToolStripButton()
        Me.CercaInternetButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.GoogleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WikiITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IMDBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.AlberoCategorieLibreria = New System.Windows.Forms.TreeView()
        Me.SplitContainerSX_C = New System.Windows.Forms.SplitContainer()
        Me.ToolStripCategorie = New System.Windows.Forms.ToolStrip()
        Me.DropDownOrdinamentoCategorie = New System.Windows.Forms.ToolStripDropDownButton()
        Me.EpocaDiAttivitàultimaUscitaPiùRemotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EpocaDiAttivitàultimaUscitaPiùRecenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlfabeticoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DurataFilmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NumeroFilmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DropDownInfoCategoria = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NessunaInformazioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeriodoDiAttivitàToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DurataFilmToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConteggioFilmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton5 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NomeCognomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CognomeNomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CognomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InizialeCognomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileSystemWatcher = New System.IO.FileSystemWatcher()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.PosterFilmPiccoli = New System.Windows.Forms.ImageList(Me.components)
        Me.PosterFilmGrandi = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainerCSX_DX = New System.Windows.Forms.SplitContainer()
        Me.SplitContainerBarreStrumenti_CSX = New System.Windows.Forms.SplitContainer()
        Me.PanelDettagliCategoria = New System.Windows.Forms.Panel()
        Me.ValutazioniCat = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VotoIMDBCat = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.NumVotiIMDBCat = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.IncassiCat = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.VotoMetacriticCat = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.RottenCat = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtRicercaPersonaIMDB = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ButCambiaImgPersona = New System.Windows.Forms.Button()
        Me.PanNumeroFilm = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LabConteggioCategoriaScelta = New System.Windows.Forms.Label()
        Me.PanDurataTotale = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.LabDurataCat = New System.Windows.Forms.Label()
        Me.PanPeriodoAttività = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PicImgPersona = New System.Windows.Forms.PictureBox()
        Me.LabValoreCategoriaScelta = New System.Windows.Forms.Label()
        Me.LabCategoriaScelta = New System.Windows.Forms.Label()
        Me.IconaCategoriaScelta = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BarraStrumentiPrincipale.SuspendLayout()
        CType(Me.SplitContainerFiltriAvanzati_Icone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerFiltriAvanzati_Icone.Panel1.SuspendLayout()
        Me.SplitContainerFiltriAvanzati_Icone.Panel2.SuspendLayout()
        Me.SplitContainerFiltriAvanzati_Icone.SuspendLayout()
        Me.SchedeFiltriAvanzati.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.FlowLayoutPanel9.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.FiltroDurataMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FiltroDurataMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.FiltroAnnoMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FiltroAnnoMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.FlowLayoutPanel8.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.FiltroBitrateMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        CType(Me.FiltroRisoluzioneMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.FiltroMinVotoRotten, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.FiltroMinVotoMetacritic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.FiltroMinIncasso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.FiltroMinNumVotiIMDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.FiltroMinVotoIMDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        Me.StatusEsecuzioneBackground.SuspendLayout()
        Me.PannelloFiltri.SuspendLayout()
        Me.PannelloFiltriSemplici.SuspendLayout()
        Me.PannelloEsitoFiltri.SuspendLayout()
        Me.PanelDettagliFilm.SuspendLayout()
        Me.PannelloExtra.SuspendLayout()
        Me.PanelFile.SuspendLayout()
        CType(Me.SplitAudioSottotitoli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitAudioSottotitoli.Panel1.SuspendLayout()
        Me.SplitAudioSottotitoli.Panel2.SuspendLayout()
        Me.SplitAudioSottotitoli.SuspendLayout()
        Me.PannelloAudio.SuspendLayout()
        Me.IntestazioneAudio.SuspendLayout()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PannelloSottotitoli.SuspendLayout()
        Me.IntestazioneSottotitoli.SuspendLayout()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PannelloVideo.SuspendLayout()
        Me.FlowLayoutPanel7.SuspendLayout()
        Me.PannelloRisoluzione.SuspendLayout()
        Me.BadgeRisoluzione.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PannelloCodecVideo.SuspendLayout()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PannelloBitrateVideo.SuspendLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PannelloProporzioni.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PannelloFPS.SuspendLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IntestazioneVideo.SuspendLayout()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PannelloContenitore.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.PanBitrateFile.SuspendLayout()
        Me.IntestazioneContenitore.SuspendLayout()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelValutazioni.SuspendLayout()
        Me.PanComtenutoValutazioni.SuspendLayout()
        Me.PanVotoIMDB.SuspendLayout()
        Me.PanNumVotiIMDB.SuspendLayout()
        Me.PanIncassi.SuspendLayout()
        Me.PanMetacritic.SuspendLayout()
        Me.PanRotten.SuspendLayout()
        Me.PanPremiVinti.SuspendLayout()
        Me.PanAltriVinti.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanBAFTAVinti.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanOscarVinti.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanPremiNominati.SuspendLayout()
        Me.PanAltriNominati.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanBAFTANominati.SuspendLayout()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanOscarNominati.SuspendLayout()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PannelloTrama.SuspendLayout()
        Me.PannelloAttori.SuspendLayout()
        Me.PannelloGeneri.SuspendLayout()
        CType(Me.SplitPosterInfoPrincipali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitPosterInfoPrincipali.Panel1.SuspendLayout()
        Me.SplitPosterInfoPrincipali.Panel2.SuspendLayout()
        Me.SplitPosterInfoPrincipali.SuspendLayout()
        CType(Me.PicPoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel6.SuspendLayout()
        Me.PanelNote.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelToggleImg.SuspendLayout()
        Me.PanelAnno.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PannelloNazione.SuspendLayout()
        CType(Me.NazionePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDurata.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRegisti.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAutori.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMusicisti.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSchermata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraStrumentiFilm.SuspendLayout()
        CType(Me.SplitContainerSX_C, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerSX_C.Panel1.SuspendLayout()
        Me.SplitContainerSX_C.Panel2.SuspendLayout()
        Me.SplitContainerSX_C.SuspendLayout()
        Me.ToolStripCategorie.SuspendLayout()
        CType(Me.FileSystemWatcher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerCSX_DX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerCSX_DX.Panel1.SuspendLayout()
        Me.SplitContainerCSX_DX.Panel2.SuspendLayout()
        Me.SplitContainerCSX_DX.SuspendLayout()
        CType(Me.SplitContainerBarreStrumenti_CSX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerBarreStrumenti_CSX.Panel1.SuspendLayout()
        Me.SplitContainerBarreStrumenti_CSX.Panel2.SuspendLayout()
        Me.SplitContainerBarreStrumenti_CSX.SuspendLayout()
        Me.PanelDettagliCategoria.SuspendLayout()
        Me.ValutazioniCat.SuspendLayout()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.PanNumeroFilm.SuspendLayout()
        Me.PanDurataTotale.SuspendLayout()
        Me.PanPeriodoAttività.SuspendLayout()
        CType(Me.PicImgPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconaCategoriaScelta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarraStrumentiPrincipale
        '
        Me.BarraStrumentiPrincipale.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BarraStrumentiPrincipale.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.BarraStrumentiPrincipale.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButtTogglePannelloSx, Me.ButtTogglePannelloDx, Me.ButtCronoIndietro, Me.ButtCronoAvanti, Me.SottoMenuVisualizzazioneIcone, Me.SottoMenuOrdineIcone, Me.ButtFilmCasuale, Me.SottoMenuImpostazioni, Me.ToolStripButton1})
        Me.BarraStrumentiPrincipale.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.BarraStrumentiPrincipale.Location = New System.Drawing.Point(0, 0)
        Me.BarraStrumentiPrincipale.Name = "BarraStrumentiPrincipale"
        Me.BarraStrumentiPrincipale.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.BarraStrumentiPrincipale.Size = New System.Drawing.Size(559, 67)
        Me.BarraStrumentiPrincipale.TabIndex = 0
        Me.BarraStrumentiPrincipale.Text = "Barra strumenti"
        '
        'ButtTogglePannelloSx
        '
        Me.ButtTogglePannelloSx.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtTogglePannelloSx.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.sidebar_left_grey
        Me.ButtTogglePannelloSx.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtTogglePannelloSx.Name = "ButtTogglePannelloSx"
        Me.ButtTogglePannelloSx.Size = New System.Drawing.Size(36, 64)
        Me.ButtTogglePannelloSx.Text = "<"
        Me.ButtTogglePannelloSx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtTogglePannelloSx.ToolTipText = "Nascondi/Visualizza pannello Categorie Libreria"
        '
        'ButtTogglePannelloDx
        '
        Me.ButtTogglePannelloDx.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ButtTogglePannelloDx.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtTogglePannelloDx.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.sidebar_right_grey
        Me.ButtTogglePannelloDx.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtTogglePannelloDx.Name = "ButtTogglePannelloDx"
        Me.ButtTogglePannelloDx.Size = New System.Drawing.Size(36, 64)
        Me.ButtTogglePannelloDx.Text = ">"
        Me.ButtTogglePannelloDx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtTogglePannelloDx.ToolTipText = "Nascondi/Visualizza pannello Dettagli"
        '
        'ButtCronoIndietro
        '
        Me.ButtCronoIndietro.Enabled = False
        Me.ButtCronoIndietro.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.indietro
        Me.ButtCronoIndietro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtCronoIndietro.Name = "ButtCronoIndietro"
        Me.ButtCronoIndietro.Size = New System.Drawing.Size(65, 64)
        Me.ButtCronoIndietro.Text = "Indietro"
        Me.ButtCronoIndietro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtCronoIndietro.ToolTipText = "Torna alla categoria visualizzata in precedenza"
        '
        'ButtCronoAvanti
        '
        Me.ButtCronoAvanti.Enabled = False
        Me.ButtCronoAvanti.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.avanti
        Me.ButtCronoAvanti.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtCronoAvanti.Name = "ButtCronoAvanti"
        Me.ButtCronoAvanti.Size = New System.Drawing.Size(55, 64)
        Me.ButtCronoAvanti.Text = "Avanti"
        Me.ButtCronoAvanti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtCronoAvanti.ToolTipText = "Torna alla categoria visualizzata successivamente"
        '
        'SottoMenuVisualizzazioneIcone
        '
        Me.SottoMenuVisualizzazioneIcone.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisualizzazioneToolStripMenuItem, Me.FonteIconeToolStripMenuItem, Me.ScegliCampiTestualeToolStripMenuItem, Me.ScegliCampiToolStripMenuItem})
        Me.SottoMenuVisualizzazioneIcone.Image = CType(resources.GetObject("SottoMenuVisualizzazioneIcone.Image"), System.Drawing.Image)
        Me.SottoMenuVisualizzazioneIcone.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SottoMenuVisualizzazioneIcone.Name = "SottoMenuVisualizzazioneIcone"
        Me.SottoMenuVisualizzazioneIcone.Size = New System.Drawing.Size(59, 64)
        Me.SottoMenuVisualizzazioneIcone.Text = "Icone"
        Me.SottoMenuVisualizzazioneIcone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SottoMenuVisualizzazioneIcone.ToolTipText = "Personalizza l'aspetto delle icone dei film"
        '
        'VisualizzazioneToolStripMenuItem
        '
        Me.VisualizzazioneToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IconeGrandiToolStripMenuItem, Me.IconePiccoleToolStripMenuItem, Me.ListaToolStripMenuItem, Me.ColonneToolStripMenuItem})
        Me.VisualizzazioneToolStripMenuItem.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.icone
        Me.VisualizzazioneToolStripMenuItem.Name = "VisualizzazioneToolStripMenuItem"
        Me.VisualizzazioneToolStripMenuItem.Size = New System.Drawing.Size(363, 26)
        Me.VisualizzazioneToolStripMenuItem.Text = "Tipo visualizzazione"
        Me.VisualizzazioneToolStripMenuItem.ToolTipText = "Scegli il tipo di icone da visualizzare"
        '
        'IconeGrandiToolStripMenuItem
        '
        Me.IconeGrandiToolStripMenuItem.CheckOnClick = True
        Me.IconeGrandiToolStripMenuItem.Name = "IconeGrandiToolStripMenuItem"
        Me.IconeGrandiToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.IconeGrandiToolStripMenuItem.Text = "Icone grandi"
        '
        'IconePiccoleToolStripMenuItem
        '
        Me.IconePiccoleToolStripMenuItem.CheckOnClick = True
        Me.IconePiccoleToolStripMenuItem.Name = "IconePiccoleToolStripMenuItem"
        Me.IconePiccoleToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.IconePiccoleToolStripMenuItem.Text = "Icone piccole"
        '
        'ListaToolStripMenuItem
        '
        Me.ListaToolStripMenuItem.CheckOnClick = True
        Me.ListaToolStripMenuItem.Name = "ListaToolStripMenuItem"
        Me.ListaToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.ListaToolStripMenuItem.Text = "Lista"
        '
        'ColonneToolStripMenuItem
        '
        Me.ColonneToolStripMenuItem.CheckOnClick = True
        Me.ColonneToolStripMenuItem.Name = "ColonneToolStripMenuItem"
        Me.ColonneToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.ColonneToolStripMenuItem.Text = "Colonne/Dettagli"
        '
        'FonteIconeToolStripMenuItem
        '
        Me.FonteIconeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SchermataToolStripMenuItem, Me.PosterToolStripMenuItem})
        Me.FonteIconeToolStripMenuItem.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.quadro
        Me.FonteIconeToolStripMenuItem.Name = "FonteIconeToolStripMenuItem"
        Me.FonteIconeToolStripMenuItem.Size = New System.Drawing.Size(363, 26)
        Me.FonteIconeToolStripMenuItem.Text = "Contenuto miniature"
        Me.FonteIconeToolStripMenuItem.ToolTipText = "Scegli quale immagine visualizzare nelle icone"
        '
        'SchermataToolStripMenuItem
        '
        Me.SchermataToolStripMenuItem.CheckOnClick = True
        Me.SchermataToolStripMenuItem.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.pellicola
        Me.SchermataToolStripMenuItem.Name = "SchermataToolStripMenuItem"
        Me.SchermataToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SchermataToolStripMenuItem.Text = "Preferisci schermate"
        '
        'PosterToolStripMenuItem
        '
        Me.PosterToolStripMenuItem.CheckOnClick = True
        Me.PosterToolStripMenuItem.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.note
        Me.PosterToolStripMenuItem.Name = "PosterToolStripMenuItem"
        Me.PosterToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.PosterToolStripMenuItem.Text = "Preferisci poster"
        '
        'ScegliCampiTestualeToolStripMenuItem
        '
        Me.ScegliCampiTestualeToolStripMenuItem.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.fields2
        Me.ScegliCampiTestualeToolStripMenuItem.Name = "ScegliCampiTestualeToolStripMenuItem"
        Me.ScegliCampiTestualeToolStripMenuItem.Size = New System.Drawing.Size(363, 26)
        Me.ScegliCampiTestualeToolStripMenuItem.Text = "Campi/Colonne da visualizzare (testuale)"
        Me.ScegliCampiTestualeToolStripMenuItem.ToolTipText = "Scegli quali informazioni visualizzare a fianco delle icone"
        '
        'ScegliCampiToolStripMenuItem
        '
        Me.ScegliCampiToolStripMenuItem.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.fields2
        Me.ScegliCampiToolStripMenuItem.Name = "ScegliCampiToolStripMenuItem"
        Me.ScegliCampiToolStripMenuItem.Size = New System.Drawing.Size(363, 26)
        Me.ScegliCampiToolStripMenuItem.Text = "Campi/Colonne da visualizzare (nuovo)"
        Me.ScegliCampiToolStripMenuItem.ToolTipText = "Scegli quali informazioni visualizzare a fianco delle icone"
        '
        'SottoMenuOrdineIcone
        '
        Me.SottoMenuOrdineIcone.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.TitoloItalianoToolStripMenuItem, Me.AnnoToolStripMenuItem, Me.NazioneToolStripMenuItem, Me.DurataToolStripMenuItem, Me.DefinizioneToolStripMenuItem, Me.BitrateToolStripMenuItem1, Me.ToolStripSeparator1, Me.DiscendenteToolStripMenuItem, Me.TitoloItalianoToolStripMenuItem1, Me.AnnoToolStripMenuItem1, Me.NazioneToolStripMenuItem1, Me.DurataToolStripMenuItem1, Me.DefinizioneToolStripMenuItem1, Me.BitrateToolStripMenuItem, Me.PerValutazioneIMDBToolStripMenuItem, Me.PerNumeroVotiIMDBToolStripMenuItem, Me.PerValutazioneMetacriticToolStripMenuItem, Me.PerValutazioneRottenTomatoesToolStripMenuItem, Me.PerIncassiToolStripMenuItem, Me.PerOscarVintiToolStripMenuItem, Me.PerOscarvintiNominatiToolStripMenuItem, Me.PerPremiVintiToolStripMenuItem, Me.PerPremiNominatiToolStripMenuItem})
        Me.SottoMenuOrdineIcone.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.ordinamento
        Me.SottoMenuOrdineIcone.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SottoMenuOrdineIcone.Name = "SottoMenuOrdineIcone"
        Me.SottoMenuOrdineIcone.Size = New System.Drawing.Size(68, 64)
        Me.SottoMenuOrdineIcone.Text = "Ordina"
        Me.SottoMenuOrdineIcone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SottoMenuOrdineIcone.ToolTipText = "Scegli come ordinare le icone dei film"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.sort_asc_lett_num
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(312, 26)
        Me.ToolStripMenuItem1.Text = "Dal minore al maggiore"
        '
        'TitoloItalianoToolStripMenuItem
        '
        Me.TitoloItalianoToolStripMenuItem.Name = "TitoloItalianoToolStripMenuItem"
        Me.TitoloItalianoToolStripMenuItem.Size = New System.Drawing.Size(312, 26)
        Me.TitoloItalianoToolStripMenuItem.Text = "per Titolo italiano"
        '
        'AnnoToolStripMenuItem
        '
        Me.AnnoToolStripMenuItem.Checked = True
        Me.AnnoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AnnoToolStripMenuItem.Name = "AnnoToolStripMenuItem"
        Me.AnnoToolStripMenuItem.Size = New System.Drawing.Size(312, 26)
        Me.AnnoToolStripMenuItem.Text = "per Anno"
        '
        'NazioneToolStripMenuItem
        '
        Me.NazioneToolStripMenuItem.Name = "NazioneToolStripMenuItem"
        Me.NazioneToolStripMenuItem.Size = New System.Drawing.Size(312, 26)
        Me.NazioneToolStripMenuItem.Text = "per Nazione"
        '
        'DurataToolStripMenuItem
        '
        Me.DurataToolStripMenuItem.Name = "DurataToolStripMenuItem"
        Me.DurataToolStripMenuItem.Size = New System.Drawing.Size(312, 26)
        Me.DurataToolStripMenuItem.Text = "per Durata"
        '
        'DefinizioneToolStripMenuItem
        '
        Me.DefinizioneToolStripMenuItem.Name = "DefinizioneToolStripMenuItem"
        Me.DefinizioneToolStripMenuItem.Size = New System.Drawing.Size(312, 26)
        Me.DefinizioneToolStripMenuItem.Text = "per Definizione"
        '
        'BitrateToolStripMenuItem1
        '
        Me.BitrateToolStripMenuItem1.Name = "BitrateToolStripMenuItem1"
        Me.BitrateToolStripMenuItem1.Size = New System.Drawing.Size(312, 26)
        Me.BitrateToolStripMenuItem1.Text = "per Bitrate"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(309, 6)
        '
        'DiscendenteToolStripMenuItem
        '
        Me.DiscendenteToolStripMenuItem.Enabled = False
        Me.DiscendenteToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscendenteToolStripMenuItem.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.sort_desc_lett_num
        Me.DiscendenteToolStripMenuItem.Name = "DiscendenteToolStripMenuItem"
        Me.DiscendenteToolStripMenuItem.Size = New System.Drawing.Size(312, 26)
        Me.DiscendenteToolStripMenuItem.Text = "Dal maggiore al minore"
        '
        'TitoloItalianoToolStripMenuItem1
        '
        Me.TitoloItalianoToolStripMenuItem1.Name = "TitoloItalianoToolStripMenuItem1"
        Me.TitoloItalianoToolStripMenuItem1.Size = New System.Drawing.Size(312, 26)
        Me.TitoloItalianoToolStripMenuItem1.Text = "per Titolo italiano"
        '
        'AnnoToolStripMenuItem1
        '
        Me.AnnoToolStripMenuItem1.Name = "AnnoToolStripMenuItem1"
        Me.AnnoToolStripMenuItem1.Size = New System.Drawing.Size(312, 26)
        Me.AnnoToolStripMenuItem1.Text = "per Anno"
        '
        'NazioneToolStripMenuItem1
        '
        Me.NazioneToolStripMenuItem1.Name = "NazioneToolStripMenuItem1"
        Me.NazioneToolStripMenuItem1.Size = New System.Drawing.Size(312, 26)
        Me.NazioneToolStripMenuItem1.Text = "per Nazione"
        '
        'DurataToolStripMenuItem1
        '
        Me.DurataToolStripMenuItem1.Name = "DurataToolStripMenuItem1"
        Me.DurataToolStripMenuItem1.Size = New System.Drawing.Size(312, 26)
        Me.DurataToolStripMenuItem1.Text = "per Durata"
        '
        'DefinizioneToolStripMenuItem1
        '
        Me.DefinizioneToolStripMenuItem1.Name = "DefinizioneToolStripMenuItem1"
        Me.DefinizioneToolStripMenuItem1.Size = New System.Drawing.Size(312, 26)
        Me.DefinizioneToolStripMenuItem1.Text = "per Definizione"
        '
        'BitrateToolStripMenuItem
        '
        Me.BitrateToolStripMenuItem.Name = "BitrateToolStripMenuItem"
        Me.BitrateToolStripMenuItem.Size = New System.Drawing.Size(312, 26)
        Me.BitrateToolStripMenuItem.Text = "per Bitrate"
        '
        'PerValutazioneIMDBToolStripMenuItem
        '
        Me.PerValutazioneIMDBToolStripMenuItem.Name = "PerValutazioneIMDBToolStripMenuItem"
        Me.PerValutazioneIMDBToolStripMenuItem.Size = New System.Drawing.Size(312, 26)
        Me.PerValutazioneIMDBToolStripMenuItem.Text = "per Valutazione IMDB"
        '
        'PerNumeroVotiIMDBToolStripMenuItem
        '
        Me.PerNumeroVotiIMDBToolStripMenuItem.Name = "PerNumeroVotiIMDBToolStripMenuItem"
        Me.PerNumeroVotiIMDBToolStripMenuItem.Size = New System.Drawing.Size(312, 26)
        Me.PerNumeroVotiIMDBToolStripMenuItem.Text = "per Numero voti IMDB"
        '
        'PerValutazioneMetacriticToolStripMenuItem
        '
        Me.PerValutazioneMetacriticToolStripMenuItem.Name = "PerValutazioneMetacriticToolStripMenuItem"
        Me.PerValutazioneMetacriticToolStripMenuItem.Size = New System.Drawing.Size(312, 26)
        Me.PerValutazioneMetacriticToolStripMenuItem.Text = "per Valutazione Metacritic"
        '
        'PerValutazioneRottenTomatoesToolStripMenuItem
        '
        Me.PerValutazioneRottenTomatoesToolStripMenuItem.Name = "PerValutazioneRottenTomatoesToolStripMenuItem"
        Me.PerValutazioneRottenTomatoesToolStripMenuItem.Size = New System.Drawing.Size(312, 26)
        Me.PerValutazioneRottenTomatoesToolStripMenuItem.Text = "per Valutazione Rotten Tomatoes"
        '
        'PerIncassiToolStripMenuItem
        '
        Me.PerIncassiToolStripMenuItem.Name = "PerIncassiToolStripMenuItem"
        Me.PerIncassiToolStripMenuItem.Size = New System.Drawing.Size(312, 26)
        Me.PerIncassiToolStripMenuItem.Text = "per Incassi"
        '
        'PerOscarVintiToolStripMenuItem
        '
        Me.PerOscarVintiToolStripMenuItem.Name = "PerOscarVintiToolStripMenuItem"
        Me.PerOscarVintiToolStripMenuItem.Size = New System.Drawing.Size(312, 26)
        Me.PerOscarVintiToolStripMenuItem.Text = "per Oscar vinti"
        '
        'PerOscarvintiNominatiToolStripMenuItem
        '
        Me.PerOscarvintiNominatiToolStripMenuItem.Name = "PerOscarvintiNominatiToolStripMenuItem"
        Me.PerOscarvintiNominatiToolStripMenuItem.Size = New System.Drawing.Size(312, 26)
        Me.PerOscarvintiNominatiToolStripMenuItem.Text = "per Oscar (vinti + nominati)"
        '
        'PerPremiVintiToolStripMenuItem
        '
        Me.PerPremiVintiToolStripMenuItem.Name = "PerPremiVintiToolStripMenuItem"
        Me.PerPremiVintiToolStripMenuItem.Size = New System.Drawing.Size(312, 26)
        Me.PerPremiVintiToolStripMenuItem.Text = "per Premi vinti"
        '
        'PerPremiNominatiToolStripMenuItem
        '
        Me.PerPremiNominatiToolStripMenuItem.Name = "PerPremiNominatiToolStripMenuItem"
        Me.PerPremiNominatiToolStripMenuItem.Size = New System.Drawing.Size(312, 26)
        Me.PerPremiNominatiToolStripMenuItem.Text = "per Premi (vinti + nominati)"
        '
        'ButtFilmCasuale
        '
        Me.ButtFilmCasuale.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.dado
        Me.ButtFilmCasuale.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtFilmCasuale.Name = "ButtFilmCasuale"
        Me.ButtFilmCasuale.Size = New System.Drawing.Size(81, 64)
        Me.ButtFilmCasuale.Text = "Suggerisci"
        Me.ButtFilmCasuale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtFilmCasuale.ToolTipText = "Suggerisci un film a caso tra quelli visualizzati nella schermata attuale"
        '
        'SottoMenuImpostazioni
        '
        Me.SottoMenuImpostazioni.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScegliLibreriaToolStripMenuItem, Me.AggiornaLibreriaToolStripMenuItem, Me.ToolStripSeparator3, Me.TemaColoriToolStripMenuItem, Me.ImpostazioniToolStripMenuItem, Me.ToolStripSeparator2, Me.ControllaAggiornamentiToolStripMenuItem, Me.CreditiToolStripMenuItem})
        Me.SottoMenuImpostazioni.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.impostazioni
        Me.SottoMenuImpostazioni.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SottoMenuImpostazioni.Name = "SottoMenuImpostazioni"
        Me.SottoMenuImpostazioni.Size = New System.Drawing.Size(109, 64)
        Me.SottoMenuImpostazioni.Text = "Impostazioni"
        Me.SottoMenuImpostazioni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SottoMenuImpostazioni.ToolTipText = "Impostazioni del Gestore Libreria Film"
        '
        'ScegliLibreriaToolStripMenuItem
        '
        Me.ScegliLibreriaToolStripMenuItem.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.videocassetta
        Me.ScegliLibreriaToolStripMenuItem.Name = "ScegliLibreriaToolStripMenuItem"
        Me.ScegliLibreriaToolStripMenuItem.Size = New System.Drawing.Size(288, 26)
        Me.ScegliLibreriaToolStripMenuItem.Text = "Scegli posizione della libreria"
        '
        'AggiornaLibreriaToolStripMenuItem
        '
        Me.AggiornaLibreriaToolStripMenuItem.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.aggiorna
        Me.AggiornaLibreriaToolStripMenuItem.Name = "AggiornaLibreriaToolStripMenuItem"
        Me.AggiornaLibreriaToolStripMenuItem.Size = New System.Drawing.Size(288, 26)
        Me.AggiornaLibreriaToolStripMenuItem.Text = "Aggiorna libreria"
        Me.AggiornaLibreriaToolStripMenuItem.ToolTipText = "Aggiorna l'elenco dei film dal disco"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(285, 6)
        '
        'TemaColoriToolStripMenuItem
        '
        Me.TemaColoriToolStripMenuItem.AutoSize = False
        Me.TemaColoriToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TemaWindowsToolStripMenuItem, Me.TemaChiaroToolStripMenuItem, Me.TemaScuroToolStripMenuItem})
        Me.TemaColoriToolStripMenuItem.Name = "TemaColoriToolStripMenuItem"
        Me.TemaColoriToolStripMenuItem.Size = New System.Drawing.Size(292, 30)
        Me.TemaColoriToolStripMenuItem.Text = "Tema colori"
        '
        'TemaWindowsToolStripMenuItem
        '
        Me.TemaWindowsToolStripMenuItem.Name = "TemaWindowsToolStripMenuItem"
        Me.TemaWindowsToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.TemaWindowsToolStripMenuItem.Text = "Automatico"
        Me.TemaWindowsToolStripMenuItem.ToolTipText = "Alterna automaticamente tema chiaro/scuro per corrispondere al tema impostato in " &
    "Windows (solo versioni 8/10/11)"
        '
        'TemaChiaroToolStripMenuItem
        '
        Me.TemaChiaroToolStripMenuItem.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.sole
        Me.TemaChiaroToolStripMenuItem.Name = "TemaChiaroToolStripMenuItem"
        Me.TemaChiaroToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.TemaChiaroToolStripMenuItem.Text = "Chiaro (giorno)"
        '
        'TemaScuroToolStripMenuItem
        '
        Me.TemaScuroToolStripMenuItem.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.luna
        Me.TemaScuroToolStripMenuItem.Name = "TemaScuroToolStripMenuItem"
        Me.TemaScuroToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.TemaScuroToolStripMenuItem.Text = "Scuro (notte)"
        '
        'ImpostazioniToolStripMenuItem
        '
        Me.ImpostazioniToolStripMenuItem.Enabled = False
        Me.ImpostazioniToolStripMenuItem.Name = "ImpostazioniToolStripMenuItem"
        Me.ImpostazioniToolStripMenuItem.Size = New System.Drawing.Size(288, 26)
        Me.ImpostazioniToolStripMenuItem.Text = "Altre impostazioni"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(285, 6)
        '
        'ControllaAggiornamentiToolStripMenuItem
        '
        Me.ControllaAggiornamentiToolStripMenuItem.Enabled = False
        Me.ControllaAggiornamentiToolStripMenuItem.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.download
        Me.ControllaAggiornamentiToolStripMenuItem.Name = "ControllaAggiornamentiToolStripMenuItem"
        Me.ControllaAggiornamentiToolStripMenuItem.Size = New System.Drawing.Size(288, 26)
        Me.ControllaAggiornamentiToolStripMenuItem.Text = "Controlla aggiornamenti"
        '
        'CreditiToolStripMenuItem
        '
        Me.CreditiToolStripMenuItem.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.info
        Me.CreditiToolStripMenuItem.Name = "CreditiToolStripMenuItem"
        Me.CreditiToolStripMenuItem.Size = New System.Drawing.Size(288, 26)
        Me.CreditiToolStripMenuItem.Text = "Crediti"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.aggiungi
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(96, 56)
        Me.ToolStripButton1.Text = "Importa film"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'IconeCategorieLibreria
        '
        Me.IconeCategorieLibreria.ImageStream = CType(resources.GetObject("IconeCategorieLibreria.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IconeCategorieLibreria.TransparentColor = System.Drawing.Color.Transparent
        Me.IconeCategorieLibreria.Images.SetKeyName(0, "vuoto.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(1, "ciak semplice.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(2, "camera.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(3, "persona.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(4, "generi.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(5, "data.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(6, "mondo.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(7, "autore.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(8, "musica.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(9, "argomenti.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(10, "epoca 2.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(11, "animazione.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(12, "antica grecia.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(13, "antica Roma.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(14, "avventura.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(15, "azione.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(16, "biografico.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(17, "black humor.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(18, "catastrofico.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(19, "comico.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(20, "commedia.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(21, "drammatico.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(22, "droga.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(23, "fantascienza.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(24, "fantasmi.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(25, "fantasy.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(26, "finanza.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(27, "gangster 32.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(28, "gay.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(29, "giallo.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(30, "guerra.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(31, "horror.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(32, "informatica.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(33, "marinaresco 2.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(34, "matematica 2.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(35, "medioevo 3.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(36, "montagna.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(37, "motori.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(38, "musica.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(39, "musical.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(40, "natalizio 2.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(41, "noir.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(42, "poesia.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(43, "politico.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(44, "polizesco.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(45, "religione.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(46, "rock.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(47, "sanità.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(48, "satira 5.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(49, "scienza.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(50, "scuola.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(51, "sentimentale.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(52, "serial killer.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(53, "spazio.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(54, "spionaggio.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(55, "splatter.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(56, "sport.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(57, "storico.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(58, "surrealismo.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(59, "thriller.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(60, "treni.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(61, "ufo.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(62, "western.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(63, "cerca.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(64, "AUS.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(65, "BRA.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(66, "CAN.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(67, "CIN.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(68, "COR.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(69, "ENG.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(70, "FIN.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(71, "FRA.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(72, "GER.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(73, "GIA.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(74, "IND.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(75, "ITA.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(76, "RUS.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(77, "SPA.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(78, "SVE.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(79, "SVI.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(80, "USA.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(81, "audio.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(82, "floppy.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(83, "pellicola.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(84, "sottotitoli.png")
        Me.IconeCategorieLibreria.Images.SetKeyName(85, "saga-franklin.png")
        '
        'SplitContainerFiltriAvanzati_Icone
        '
        Me.SplitContainerFiltriAvanzati_Icone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerFiltriAvanzati_Icone.Location = New System.Drawing.Point(0, 92)
        Me.SplitContainerFiltriAvanzati_Icone.Name = "SplitContainerFiltriAvanzati_Icone"
        Me.SplitContainerFiltriAvanzati_Icone.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerFiltriAvanzati_Icone.Panel1
        '
        Me.SplitContainerFiltriAvanzati_Icone.Panel1.AutoScroll = True
        Me.SplitContainerFiltriAvanzati_Icone.Panel1.Controls.Add(Me.SchedeFiltriAvanzati)
        Me.SplitContainerFiltriAvanzati_Icone.Panel1.Controls.Add(Me.Panel12)
        Me.SplitContainerFiltriAvanzati_Icone.Panel1MinSize = 10
        '
        'SplitContainerFiltriAvanzati_Icone.Panel2
        '
        Me.SplitContainerFiltriAvanzati_Icone.Panel2.Controls.Add(Me.StatusEsecuzioneBackground)
        Me.SplitContainerFiltriAvanzati_Icone.Panel2.Controls.Add(Me.ElencoFilm)
        Me.SplitContainerFiltriAvanzati_Icone.Panel2MinSize = 10
        Me.SplitContainerFiltriAvanzati_Icone.Size = New System.Drawing.Size(408, 591)
        Me.SplitContainerFiltriAvanzati_Icone.SplitterDistance = 280
        Me.SplitContainerFiltriAvanzati_Icone.TabIndex = 2
        '
        'SchedeFiltriAvanzati
        '
        Me.SchedeFiltriAvanzati.Controls.Add(Me.TabPage1)
        Me.SchedeFiltriAvanzati.Controls.Add(Me.TabPage2)
        Me.SchedeFiltriAvanzati.Controls.Add(Me.TabPage3)
        Me.SchedeFiltriAvanzati.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SchedeFiltriAvanzati.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchedeFiltriAvanzati.Location = New System.Drawing.Point(0, 0)
        Me.SchedeFiltriAvanzati.MaximumSize = New System.Drawing.Size(800, 1000)
        Me.SchedeFiltriAvanzati.Multiline = True
        Me.SchedeFiltriAvanzati.Name = "SchedeFiltriAvanzati"
        Me.SchedeFiltriAvanzati.SelectedIndex = 0
        Me.SchedeFiltriAvanzati.Size = New System.Drawing.Size(408, 239)
        Me.SchedeFiltriAvanzati.TabIndex = 29
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.FlowLayoutPanel9)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(400, 206)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dati film"
        '
        'FlowLayoutPanel9
        '
        Me.FlowLayoutPanel9.AutoSize = True
        Me.FlowLayoutPanel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel9.Controls.Add(Me.Panel5)
        Me.FlowLayoutPanel9.Controls.Add(Me.Panel20)
        Me.FlowLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel9.Location = New System.Drawing.Point(3, 178)
        Me.FlowLayoutPanel9.Name = "FlowLayoutPanel9"
        Me.FlowLayoutPanel9.Size = New System.Drawing.Size(373, 226)
        Me.FlowLayoutPanel9.TabIndex = 89
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.FiltroNazioni)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(100, 220)
        Me.Panel5.TabIndex = 90
        '
        'FiltroNazioni
        '
        Me.FiltroNazioni.CheckOnClick = True
        Me.FiltroNazioni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FiltroNazioni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FiltroNazioni.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltroNazioni.FormattingEnabled = True
        Me.FiltroNazioni.Location = New System.Drawing.Point(0, 18)
        Me.FiltroNazioni.Name = "FiltroNazioni"
        Me.FiltroNazioni.Size = New System.Drawing.Size(100, 202)
        Me.FiltroNazioni.Sorted = True
        Me.FiltroNazioni.TabIndex = 13
        Me.FiltroNazioni.ThreeDCheckBoxes = True
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Nazioni:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel20
        '
        Me.Panel20.Controls.Add(Me.FiltroGeneri)
        Me.Panel20.Controls.Add(Me.Label10)
        Me.Panel20.Location = New System.Drawing.Point(109, 3)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(200, 220)
        Me.Panel20.TabIndex = 91
        '
        'FiltroGeneri
        '
        Me.FiltroGeneri.CheckOnClick = True
        Me.FiltroGeneri.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FiltroGeneri.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FiltroGeneri.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltroGeneri.FormattingEnabled = True
        Me.FiltroGeneri.Location = New System.Drawing.Point(0, 18)
        Me.FiltroGeneri.Name = "FiltroGeneri"
        Me.FiltroGeneri.Size = New System.Drawing.Size(200, 202)
        Me.FiltroGeneri.Sorted = True
        Me.FiltroGeneri.TabIndex = 15
        Me.FiltroGeneri.ThreeDCheckBoxes = True
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(200, 18)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Generi:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.FiltroDurataMin)
        Me.Panel3.Controls.Add(Me.FiltroDurataMax)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 91)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(373, 87)
        Me.Panel3.TabIndex = 88
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(373, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Durata:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 23)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "a: ∞"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FiltroDurataMin
        '
        Me.FiltroDurataMin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiltroDurataMin.AutoSize = False
        Me.FiltroDurataMin.LargeChange = 30
        Me.FiltroDurataMin.Location = New System.Drawing.Point(111, 24)
        Me.FiltroDurataMin.Maximum = 300
        Me.FiltroDurataMin.Name = "FiltroDurataMin"
        Me.FiltroDurataMin.Size = New System.Drawing.Size(259, 30)
        Me.FiltroDurataMin.SmallChange = 5
        Me.FiltroDurataMin.TabIndex = 7
        Me.FiltroDurataMin.TickFrequency = 30
        Me.FiltroDurataMin.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'FiltroDurataMax
        '
        Me.FiltroDurataMax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiltroDurataMax.AutoSize = False
        Me.FiltroDurataMax.LargeChange = 30
        Me.FiltroDurataMax.Location = New System.Drawing.Point(111, 52)
        Me.FiltroDurataMax.Maximum = 301
        Me.FiltroDurataMax.Name = "FiltroDurataMax"
        Me.FiltroDurataMax.Size = New System.Drawing.Size(259, 32)
        Me.FiltroDurataMax.SmallChange = 5
        Me.FiltroDurataMax.TabIndex = 8
        Me.FiltroDurataMax.TickFrequency = 30
        Me.FiltroDurataMax.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.FiltroDurataMax.Value = 301
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(0, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 23)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "da: 0 min"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.FiltroAnnoMax)
        Me.Panel1.Controls.Add(Me.FiltroAnnoMin)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(373, 88)
        Me.Panel1.TabIndex = 88
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(373, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Anno pubblicazione:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "dal: - ∞"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FiltroAnnoMax
        '
        Me.FiltroAnnoMax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiltroAnnoMax.AutoSize = False
        Me.FiltroAnnoMax.LargeChange = 10
        Me.FiltroAnnoMax.Location = New System.Drawing.Point(86, 49)
        Me.FiltroAnnoMax.Maximum = 2023
        Me.FiltroAnnoMax.Minimum = 1895
        Me.FiltroAnnoMax.Name = "FiltroAnnoMax"
        Me.FiltroAnnoMax.Size = New System.Drawing.Size(284, 32)
        Me.FiltroAnnoMax.TabIndex = 2
        Me.FiltroAnnoMax.TickFrequency = 10
        Me.FiltroAnnoMax.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.FiltroAnnoMax.Value = 2023
        '
        'FiltroAnnoMin
        '
        Me.FiltroAnnoMin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiltroAnnoMin.AutoSize = False
        Me.FiltroAnnoMin.LargeChange = 10
        Me.FiltroAnnoMin.Location = New System.Drawing.Point(86, 21)
        Me.FiltroAnnoMin.Maximum = 2022
        Me.FiltroAnnoMin.Minimum = 1894
        Me.FiltroAnnoMin.Name = "FiltroAnnoMin"
        Me.FiltroAnnoMin.Size = New System.Drawing.Size(284, 30)
        Me.FiltroAnnoMin.TabIndex = 1
        Me.FiltroAnnoMin.TickFrequency = 10
        Me.FiltroAnnoMin.TickStyle = System.Windows.Forms.TickStyle.None
        Me.FiltroAnnoMin.Value = 1894
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 30)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "al: ∞"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.FlowLayoutPanel8)
        Me.TabPage2.Controls.Add(Me.Panel11)
        Me.TabPage2.Controls.Add(Me.Panel10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(400, 206)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "File"
        '
        'FlowLayoutPanel8
        '
        Me.FlowLayoutPanel8.AutoSize = True
        Me.FlowLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel8.Controls.Add(Me.Panel13)
        Me.FlowLayoutPanel8.Controls.Add(Me.Panel14)
        Me.FlowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel8.Location = New System.Drawing.Point(3, 121)
        Me.FlowLayoutPanel8.Name = "FlowLayoutPanel8"
        Me.FlowLayoutPanel8.Size = New System.Drawing.Size(373, 223)
        Me.FlowLayoutPanel8.TabIndex = 24
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.FiltroAudio)
        Me.Panel13.Controls.Add(Me.Label61)
        Me.Panel13.Location = New System.Drawing.Point(3, 3)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(150, 214)
        Me.Panel13.TabIndex = 23
        '
        'FiltroAudio
        '
        Me.FiltroAudio.CheckOnClick = True
        Me.FiltroAudio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FiltroAudio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FiltroAudio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltroAudio.FormattingEnabled = True
        Me.FiltroAudio.Location = New System.Drawing.Point(0, 40)
        Me.FiltroAudio.Name = "FiltroAudio"
        Me.FiltroAudio.Size = New System.Drawing.Size(150, 174)
        Me.FiltroAudio.Sorted = True
        Me.FiltroAudio.TabIndex = 15
        Me.FiltroAudio.ThreeDCheckBoxes = True
        '
        'Label61
        '
        Me.Label61.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(0, 0)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(150, 40)
        Me.Label61.TabIndex = 14
        Me.Label61.Text = "Deve avere audio in lingua:"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.FiltroSottotitoli)
        Me.Panel14.Controls.Add(Me.Label62)
        Me.Panel14.Location = New System.Drawing.Point(159, 3)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(170, 217)
        Me.Panel14.TabIndex = 24
        '
        'FiltroSottotitoli
        '
        Me.FiltroSottotitoli.CheckOnClick = True
        Me.FiltroSottotitoli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FiltroSottotitoli.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FiltroSottotitoli.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltroSottotitoli.FormattingEnabled = True
        Me.FiltroSottotitoli.Location = New System.Drawing.Point(0, 40)
        Me.FiltroSottotitoli.Name = "FiltroSottotitoli"
        Me.FiltroSottotitoli.Size = New System.Drawing.Size(170, 177)
        Me.FiltroSottotitoli.Sorted = True
        Me.FiltroSottotitoli.TabIndex = 15
        Me.FiltroSottotitoli.ThreeDCheckBoxes = True
        '
        'Label62
        '
        Me.Label62.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(0, 0)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(170, 40)
        Me.Label62.TabIndex = 14
        Me.Label62.Text = "Deve avere sottotitoli in lingua:"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel11
        '
        Me.Panel11.AutoSize = True
        Me.Panel11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel11.Controls.Add(Me.Label30)
        Me.Panel11.Controls.Add(Me.Label31)
        Me.Panel11.Controls.Add(Me.FiltroBitrateMin)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(3, 69)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(373, 52)
        Me.Panel11.TabIndex = 22
        '
        'Label30
        '
        Me.Label30.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(0, 18)
        Me.Label30.MinimumSize = New System.Drawing.Size(0, 30)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(100, 34)
        Me.Label30.TabIndex = 22
        Me.Label30.Text = "Qualunque"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(0, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(373, 18)
        Me.Label31.TabIndex = 21
        Me.Label31.Text = "Bitrate minimo:"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FiltroBitrateMin
        '
        Me.FiltroBitrateMin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiltroBitrateMin.AutoSize = False
        Me.FiltroBitrateMin.LargeChange = 1
        Me.FiltroBitrateMin.Location = New System.Drawing.Point(106, 19)
        Me.FiltroBitrateMin.Maximum = 16
        Me.FiltroBitrateMin.Name = "FiltroBitrateMin"
        Me.FiltroBitrateMin.Size = New System.Drawing.Size(259, 30)
        Me.FiltroBitrateMin.TabIndex = 19
        '
        'Panel10
        '
        Me.Panel10.AutoSize = True
        Me.Panel10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel10.Controls.Add(Me.Label29)
        Me.Panel10.Controls.Add(Me.Label28)
        Me.Panel10.Controls.Add(Me.FiltroRisoluzioneMin)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(3, 3)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(373, 66)
        Me.Panel10.TabIndex = 21
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(0, 18)
        Me.Label29.MaximumSize = New System.Drawing.Size(95, 45)
        Me.Label29.MinimumSize = New System.Drawing.Size(95, 45)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(95, 45)
        Me.Label29.TabIndex = 18
        Me.Label29.Text = "Qualunque"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(0, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(373, 18)
        Me.Label28.TabIndex = 15
        Me.Label28.Text = "Risoluzione minima:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FiltroRisoluzioneMin
        '
        Me.FiltroRisoluzioneMin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiltroRisoluzioneMin.AutoSize = False
        Me.FiltroRisoluzioneMin.LargeChange = 1
        Me.FiltroRisoluzioneMin.Location = New System.Drawing.Point(101, 21)
        Me.FiltroRisoluzioneMin.Maximum = 7
        Me.FiltroRisoluzioneMin.Name = "FiltroRisoluzioneMin"
        Me.FiltroRisoluzioneMin.Size = New System.Drawing.Size(264, 42)
        Me.FiltroRisoluzioneMin.TabIndex = 16
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.Panel9)
        Me.TabPage3.Controls.Add(Me.Panel8)
        Me.TabPage3.Controls.Add(Me.Panel7)
        Me.TabPage3.Controls.Add(Me.Panel6)
        Me.TabPage3.Controls.Add(Me.Panel4)
        Me.TabPage3.Controls.Add(Me.Panel2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(400, 206)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Recensioni"
        '
        'Panel9
        '
        Me.Panel9.AutoSize = True
        Me.Panel9.Controls.Add(Me.RadioButton5)
        Me.Panel9.Controls.Add(Me.RadioButton4)
        Me.Panel9.Controls.Add(Me.RadioButton3)
        Me.Panel9.Controls.Add(Me.RadioButton2)
        Me.Panel9.Controls.Add(Me.RadioButton1)
        Me.Panel9.Controls.Add(Me.Label60)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(3, 253)
        Me.Panel9.MaximumSize = New System.Drawing.Size(300, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(300, 140)
        Me.Panel9.TabIndex = 6
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton5.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadioButton5.Location = New System.Drawing.Point(0, 116)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(300, 24)
        Me.RadioButton5.TabIndex = 6
        Me.RadioButton5.Text = "Vittoria degli Oscar"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton4.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadioButton4.Location = New System.Drawing.Point(0, 92)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(300, 24)
        Me.RadioButton4.TabIndex = 5
        Me.RadioButton4.Text = "Vittoria di qualsiasi premio"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton3.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadioButton3.Location = New System.Drawing.Point(0, 68)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(300, 24)
        Me.RadioButton3.TabIndex = 4
        Me.RadioButton3.Text = "Nomination degli Oscar"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton2.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadioButton2.Location = New System.Drawing.Point(0, 44)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(300, 24)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.Text = "Nomination di qualsiasi premio"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadioButton1.Location = New System.Drawing.Point(0, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(300, 24)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Nessun requisito"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label60
        '
        Me.Label60.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(0, 0)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(300, 20)
        Me.Label60.TabIndex = 1
        Me.Label60.Text = "Deve aver ricevuto:"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.FiltroMinVotoRotten)
        Me.Panel8.Controls.Add(Me.LabMinVotoRotten)
        Me.Panel8.Controls.Add(Me.Label59)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(3, 203)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(373, 50)
        Me.Panel8.TabIndex = 5
        '
        'FiltroMinVotoRotten
        '
        Me.FiltroMinVotoRotten.AutoSize = False
        Me.FiltroMinVotoRotten.Cursor = System.Windows.Forms.Cursors.Default
        Me.FiltroMinVotoRotten.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FiltroMinVotoRotten.LargeChange = 10
        Me.FiltroMinVotoRotten.Location = New System.Drawing.Point(80, 20)
        Me.FiltroMinVotoRotten.Maximum = 100
        Me.FiltroMinVotoRotten.Name = "FiltroMinVotoRotten"
        Me.FiltroMinVotoRotten.Size = New System.Drawing.Size(293, 30)
        Me.FiltroMinVotoRotten.TabIndex = 17
        Me.FiltroMinVotoRotten.TickFrequency = 10
        '
        'LabMinVotoRotten
        '
        Me.LabMinVotoRotten.AutoSize = True
        Me.LabMinVotoRotten.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabMinVotoRotten.Location = New System.Drawing.Point(0, 20)
        Me.LabMinVotoRotten.MinimumSize = New System.Drawing.Size(80, 30)
        Me.LabMinVotoRotten.Name = "LabMinVotoRotten"
        Me.LabMinVotoRotten.Size = New System.Drawing.Size(80, 30)
        Me.LabMinVotoRotten.TabIndex = 1
        Me.LabMinVotoRotten.Text = "Qualsiasi"
        Me.LabMinVotoRotten.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label59
        '
        Me.Label59.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(0, 0)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(373, 20)
        Me.Label59.TabIndex = 0
        Me.Label59.Text = "Minima valutazione Rotten Tomatoes:"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.FiltroMinVotoMetacritic)
        Me.Panel7.Controls.Add(Me.LabMinVotoMetacritic)
        Me.Panel7.Controls.Add(Me.Label57)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(3, 153)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(373, 50)
        Me.Panel7.TabIndex = 4
        '
        'FiltroMinVotoMetacritic
        '
        Me.FiltroMinVotoMetacritic.AutoSize = False
        Me.FiltroMinVotoMetacritic.Cursor = System.Windows.Forms.Cursors.Default
        Me.FiltroMinVotoMetacritic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FiltroMinVotoMetacritic.LargeChange = 10
        Me.FiltroMinVotoMetacritic.Location = New System.Drawing.Point(80, 20)
        Me.FiltroMinVotoMetacritic.Maximum = 100
        Me.FiltroMinVotoMetacritic.Name = "FiltroMinVotoMetacritic"
        Me.FiltroMinVotoMetacritic.Size = New System.Drawing.Size(293, 30)
        Me.FiltroMinVotoMetacritic.TabIndex = 17
        Me.FiltroMinVotoMetacritic.TickFrequency = 10
        '
        'LabMinVotoMetacritic
        '
        Me.LabMinVotoMetacritic.AutoSize = True
        Me.LabMinVotoMetacritic.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabMinVotoMetacritic.Location = New System.Drawing.Point(0, 20)
        Me.LabMinVotoMetacritic.MinimumSize = New System.Drawing.Size(80, 30)
        Me.LabMinVotoMetacritic.Name = "LabMinVotoMetacritic"
        Me.LabMinVotoMetacritic.Size = New System.Drawing.Size(80, 30)
        Me.LabMinVotoMetacritic.TabIndex = 1
        Me.LabMinVotoMetacritic.Text = "Qualsiasi"
        Me.LabMinVotoMetacritic.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label57
        '
        Me.Label57.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(0, 0)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(373, 20)
        Me.Label57.TabIndex = 0
        Me.Label57.Text = "Minima valutazione Metacritic:"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.FiltroMinIncasso)
        Me.Panel6.Controls.Add(Me.LabMinIncasso)
        Me.Panel6.Controls.Add(Me.Label55)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(3, 103)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(373, 50)
        Me.Panel6.TabIndex = 3
        '
        'FiltroMinIncasso
        '
        Me.FiltroMinIncasso.AutoSize = False
        Me.FiltroMinIncasso.Cursor = System.Windows.Forms.Cursors.Default
        Me.FiltroMinIncasso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FiltroMinIncasso.LargeChange = 3
        Me.FiltroMinIncasso.Location = New System.Drawing.Point(95, 20)
        Me.FiltroMinIncasso.Maximum = 16
        Me.FiltroMinIncasso.Name = "FiltroMinIncasso"
        Me.FiltroMinIncasso.Size = New System.Drawing.Size(278, 30)
        Me.FiltroMinIncasso.TabIndex = 17
        Me.FiltroMinIncasso.TickFrequency = 3
        '
        'LabMinIncasso
        '
        Me.LabMinIncasso.AutoSize = True
        Me.LabMinIncasso.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabMinIncasso.Location = New System.Drawing.Point(0, 20)
        Me.LabMinIncasso.MinimumSize = New System.Drawing.Size(95, 30)
        Me.LabMinIncasso.Name = "LabMinIncasso"
        Me.LabMinIncasso.Size = New System.Drawing.Size(95, 30)
        Me.LabMinIncasso.TabIndex = 1
        Me.LabMinIncasso.Text = "Qualsiasi"
        Me.LabMinIncasso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label55
        '
        Me.Label55.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(0, 0)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(373, 20)
        Me.Label55.TabIndex = 0
        Me.Label55.Text = "Incasso minimo:"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.FiltroMinNumVotiIMDB)
        Me.Panel4.Controls.Add(Me.LabMinNumVotiIMDB)
        Me.Panel4.Controls.Add(Me.Label53)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 53)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(373, 50)
        Me.Panel4.TabIndex = 2
        '
        'FiltroMinNumVotiIMDB
        '
        Me.FiltroMinNumVotiIMDB.AutoSize = False
        Me.FiltroMinNumVotiIMDB.Cursor = System.Windows.Forms.Cursors.Default
        Me.FiltroMinNumVotiIMDB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FiltroMinNumVotiIMDB.LargeChange = 4
        Me.FiltroMinNumVotiIMDB.Location = New System.Drawing.Point(85, 20)
        Me.FiltroMinNumVotiIMDB.Maximum = 15
        Me.FiltroMinNumVotiIMDB.Name = "FiltroMinNumVotiIMDB"
        Me.FiltroMinNumVotiIMDB.Size = New System.Drawing.Size(288, 30)
        Me.FiltroMinNumVotiIMDB.TabIndex = 17
        Me.FiltroMinNumVotiIMDB.TickFrequency = 4
        '
        'LabMinNumVotiIMDB
        '
        Me.LabMinNumVotiIMDB.AutoSize = True
        Me.LabMinNumVotiIMDB.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabMinNumVotiIMDB.Location = New System.Drawing.Point(0, 20)
        Me.LabMinNumVotiIMDB.MinimumSize = New System.Drawing.Size(85, 30)
        Me.LabMinNumVotiIMDB.Name = "LabMinNumVotiIMDB"
        Me.LabMinNumVotiIMDB.Size = New System.Drawing.Size(85, 30)
        Me.LabMinNumVotiIMDB.TabIndex = 1
        Me.LabMinNumVotiIMDB.Text = "Qualsiasi"
        Me.LabMinNumVotiIMDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label53
        '
        Me.Label53.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(0, 0)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(373, 20)
        Me.Label53.TabIndex = 0
        Me.Label53.Text = "Minimo numero di voti su IMDB:"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.FiltroMinVotoIMDB)
        Me.Panel2.Controls.Add(Me.LabMinVotoIMDB)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(373, 50)
        Me.Panel2.TabIndex = 1
        '
        'FiltroMinVotoIMDB
        '
        Me.FiltroMinVotoIMDB.AutoSize = False
        Me.FiltroMinVotoIMDB.Cursor = System.Windows.Forms.Cursors.Default
        Me.FiltroMinVotoIMDB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FiltroMinVotoIMDB.LargeChange = 10
        Me.FiltroMinVotoIMDB.Location = New System.Drawing.Point(80, 20)
        Me.FiltroMinVotoIMDB.Maximum = 100
        Me.FiltroMinVotoIMDB.Name = "FiltroMinVotoIMDB"
        Me.FiltroMinVotoIMDB.Size = New System.Drawing.Size(293, 30)
        Me.FiltroMinVotoIMDB.TabIndex = 17
        Me.FiltroMinVotoIMDB.TickFrequency = 10
        '
        'LabMinVotoIMDB
        '
        Me.LabMinVotoIMDB.AutoSize = True
        Me.LabMinVotoIMDB.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabMinVotoIMDB.Location = New System.Drawing.Point(0, 20)
        Me.LabMinVotoIMDB.MinimumSize = New System.Drawing.Size(80, 30)
        Me.LabMinVotoIMDB.Name = "LabMinVotoIMDB"
        Me.LabMinVotoIMDB.Size = New System.Drawing.Size(80, 30)
        Me.LabMinVotoIMDB.TabIndex = 1
        Me.LabMinVotoIMDB.Text = "Qualsiasi"
        Me.LabMinVotoIMDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(0, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(373, 20)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Minima valutazione IMDB:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel12
        '
        Me.Panel12.AutoSize = True
        Me.Panel12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel12.Controls.Add(Me.BottFiltra)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(0, 239)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(408, 41)
        Me.Panel12.TabIndex = 90
        '
        'BottFiltra
        '
        Me.BottFiltra.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BottFiltra.AutoSize = True
        Me.BottFiltra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BottFiltra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BottFiltra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BottFiltra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BottFiltra.ImageIndex = 63
        Me.BottFiltra.ImageList = Me.IconeCategorieLibreria
        Me.BottFiltra.Location = New System.Drawing.Point(129, 0)
        Me.BottFiltra.Name = "BottFiltra"
        Me.BottFiltra.Size = New System.Drawing.Size(151, 38)
        Me.BottFiltra.TabIndex = 5
        Me.BottFiltra.Text = "Filtra l'elenco"
        Me.BottFiltra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BottFiltra.UseVisualStyleBackColor = True
        '
        'StatusEsecuzioneBackground
        '
        Me.StatusEsecuzioneBackground.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusEsecuzioneBackground.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusEsecuzioneBackground.Location = New System.Drawing.Point(0, 276)
        Me.StatusEsecuzioneBackground.MaximumSize = New System.Drawing.Size(500, 0)
        Me.StatusEsecuzioneBackground.Name = "StatusEsecuzioneBackground"
        Me.StatusEsecuzioneBackground.ShowItemToolTips = True
        Me.StatusEsecuzioneBackground.Size = New System.Drawing.Size(408, 0)
        Me.StatusEsecuzioneBackground.SizingGrip = False
        Me.StatusEsecuzioneBackground.Stretch = False
        Me.StatusEsecuzioneBackground.TabIndex = 88
        Me.StatusEsecuzioneBackground.Text = "Attività in background"
        Me.StatusEsecuzioneBackground.UseWaitCursor = True
        Me.StatusEsecuzioneBackground.Visible = False
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.AutoToolTip = True
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 1)
        Me.ToolStripProgressBar1.ToolTipText = "50%"
        Me.ToolStripProgressBar1.Value = 50
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(159, 1)
        Me.ToolStripStatusLabel1.Text = "Attività in background:"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(96, 1)
        Me.ToolStripStatusLabel2.Text = "Descr attività"
        '
        'ElencoFilm
        '
        Me.ElencoFilm.AllowColumnReorder = True
        Me.ElencoFilm.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColTitolo, Me.ColAnno, Me.ColNazione, Me.ColRegisti, Me.ColGeneri, Me.ColAttori, Me.ColAutori, Me.ColMusicisti})
        Me.ElencoFilm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ElencoFilm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElencoFilm.FullRowSelect = True
        Me.ElencoFilm.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ElencoFilm.HideSelection = False
        Me.ElencoFilm.LargeImageList = Me.SchermateFilmGrandi
        Me.ElencoFilm.Location = New System.Drawing.Point(0, 0)
        Me.ElencoFilm.MultiSelect = False
        Me.ElencoFilm.Name = "ElencoFilm"
        Me.ElencoFilm.OwnerDraw = True
        Me.ElencoFilm.Size = New System.Drawing.Size(408, 307)
        Me.ElencoFilm.SmallImageList = Me.SchermateFilmPiccole
        Me.ElencoFilm.TabIndex = 0
        Me.ElencoFilm.TileSize = New System.Drawing.Size(125, 50)
        Me.ElencoFilm.UseCompatibleStateImageBehavior = False
        Me.ElencoFilm.VirtualMode = True
        '
        'ColTitolo
        '
        Me.ColTitolo.Text = "Titolo"
        Me.ColTitolo.Width = 240
        '
        'ColAnno
        '
        Me.ColAnno.Text = "Anno"
        Me.ColAnno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColAnno.Width = 50
        '
        'ColNazione
        '
        Me.ColNazione.Text = "Nazione"
        Me.ColNazione.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColNazione.Width = 40
        '
        'ColRegisti
        '
        Me.ColRegisti.Text = "Registi"
        Me.ColRegisti.Width = 100
        '
        'ColGeneri
        '
        Me.ColGeneri.Text = "Generi"
        Me.ColGeneri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColGeneri.Width = 180
        '
        'ColAttori
        '
        Me.ColAttori.Text = "Attori"
        Me.ColAttori.Width = 180
        '
        'ColAutori
        '
        Me.ColAutori.Text = "Autori"
        Me.ColAutori.Width = 100
        '
        'ColMusicisti
        '
        Me.ColMusicisti.Text = "Musicisti"
        Me.ColMusicisti.Width = 100
        '
        'SchermateFilmGrandi
        '
        Me.SchermateFilmGrandi.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit
        Me.SchermateFilmGrandi.ImageSize = New System.Drawing.Size(230, 144)
        Me.SchermateFilmGrandi.TransparentColor = System.Drawing.Color.Transparent
        '
        'SchermateFilmPiccole
        '
        Me.SchermateFilmPiccole.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit
        Me.SchermateFilmPiccole.ImageSize = New System.Drawing.Size(102, 64)
        Me.SchermateFilmPiccole.TransparentColor = System.Drawing.Color.Transparent
        '
        'PannelloFiltri
        '
        Me.PannelloFiltri.AutoSize = True
        Me.PannelloFiltri.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PannelloFiltri.Controls.Add(Me.PannelloFiltriSemplici)
        Me.PannelloFiltri.Controls.Add(Me.PannelloEsitoFiltri)
        Me.PannelloFiltri.Dock = System.Windows.Forms.DockStyle.Top
        Me.PannelloFiltri.Location = New System.Drawing.Point(0, 0)
        Me.PannelloFiltri.Name = "PannelloFiltri"
        Me.PannelloFiltri.Size = New System.Drawing.Size(408, 92)
        Me.PannelloFiltri.TabIndex = 1
        Me.PannelloFiltri.Visible = False
        '
        'PannelloFiltriSemplici
        '
        Me.PannelloFiltriSemplici.Controls.Add(Me.PlaceholderCasellaRicerca)
        Me.PannelloFiltriSemplici.Controls.Add(Me.CasellaRicerca)
        Me.PannelloFiltriSemplici.Controls.Add(Me.BottMostraFiltri)
        Me.PannelloFiltriSemplici.Controls.Add(Me.BottCerca)
        Me.PannelloFiltriSemplici.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PannelloFiltriSemplici.Location = New System.Drawing.Point(0, 0)
        Me.PannelloFiltriSemplici.Name = "PannelloFiltriSemplici"
        Me.PannelloFiltriSemplici.Size = New System.Drawing.Size(408, 32)
        Me.PannelloFiltriSemplici.TabIndex = 91
        '
        'PlaceholderCasellaRicerca
        '
        Me.PlaceholderCasellaRicerca.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlaceholderCasellaRicerca.BackColor = System.Drawing.SystemColors.Window
        Me.PlaceholderCasellaRicerca.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PlaceholderCasellaRicerca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaceholderCasellaRicerca.ForeColor = System.Drawing.Color.Gray
        Me.PlaceholderCasellaRicerca.Location = New System.Drawing.Point(3, 5)
        Me.PlaceholderCasellaRicerca.MaximumSize = New System.Drawing.Size(696, 23)
        Me.PlaceholderCasellaRicerca.Name = "PlaceholderCasellaRicerca"
        Me.PlaceholderCasellaRicerca.Size = New System.Drawing.Size(183, 23)
        Me.PlaceholderCasellaRicerca.TabIndex = 4
        Me.PlaceholderCasellaRicerca.Text = "Cerca..."
        Me.PlaceholderCasellaRicerca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CasellaRicerca
        '
        Me.CasellaRicerca.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CasellaRicerca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CasellaRicerca.Location = New System.Drawing.Point(0, 3)
        Me.CasellaRicerca.MaximumSize = New System.Drawing.Size(700, 27)
        Me.CasellaRicerca.MinimumSize = New System.Drawing.Size(80, 4)
        Me.CasellaRicerca.Name = "CasellaRicerca"
        Me.CasellaRicerca.Size = New System.Drawing.Size(187, 27)
        Me.CasellaRicerca.TabIndex = 2
        '
        'BottMostraFiltri
        '
        Me.BottMostraFiltri.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BottMostraFiltri.AutoSize = True
        Me.BottMostraFiltri.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BottMostraFiltri.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BottMostraFiltri.Location = New System.Drawing.Point(244, 1)
        Me.BottMostraFiltri.Name = "BottMostraFiltri"
        Me.BottMostraFiltri.Size = New System.Drawing.Size(138, 30)
        Me.BottMostraFiltri.TabIndex = 1
        Me.BottMostraFiltri.Text = "➤ Filtri avanzati"
        Me.BottMostraFiltri.UseVisualStyleBackColor = True
        '
        'BottCerca
        '
        Me.BottCerca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BottCerca.BackgroundImage = Global.GestoreLibreriaFilm.My.Resources.Resources.cerca
        Me.BottCerca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BottCerca.Location = New System.Drawing.Point(193, 1)
        Me.BottCerca.Margin = New System.Windows.Forms.Padding(3, 3, 16, 3)
        Me.BottCerca.Name = "BottCerca"
        Me.BottCerca.Size = New System.Drawing.Size(32, 32)
        Me.BottCerca.TabIndex = 3
        Me.BottCerca.UseVisualStyleBackColor = True
        '
        'PannelloEsitoFiltri
        '
        Me.PannelloEsitoFiltri.AutoSize = True
        Me.PannelloEsitoFiltri.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PannelloEsitoFiltri.Controls.Add(Me.LabEsitoFiltri)
        Me.PannelloEsitoFiltri.Controls.Add(Me.Label11)
        Me.PannelloEsitoFiltri.Controls.Add(Me.BottCancellaFiltri)
        Me.PannelloEsitoFiltri.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PannelloEsitoFiltri.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.PannelloEsitoFiltri.Location = New System.Drawing.Point(0, 32)
        Me.PannelloEsitoFiltri.Name = "PannelloEsitoFiltri"
        Me.PannelloEsitoFiltri.Size = New System.Drawing.Size(408, 60)
        Me.PannelloEsitoFiltri.TabIndex = 90
        Me.PannelloEsitoFiltri.Visible = False
        '
        'LabEsitoFiltri
        '
        Me.LabEsitoFiltri.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabEsitoFiltri.AutoSize = True
        Me.LabEsitoFiltri.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabEsitoFiltri.ForeColor = System.Drawing.Color.Red
        Me.LabEsitoFiltri.Location = New System.Drawing.Point(182, 0)
        Me.LabEsitoFiltri.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.LabEsitoFiltri.MinimumSize = New System.Drawing.Size(0, 30)
        Me.LabEsitoFiltri.Name = "LabEsitoFiltri"
        Me.LabEsitoFiltri.Size = New System.Drawing.Size(223, 30)
        Me.LabEsitoFiltri.TabIndex = 4
        Me.LabEsitoFiltri.Text = "(visualizzati 3 film su 52)"
        Me.LabEsitoFiltri.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(78, 0)
        Me.Label11.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Label11.MinimumSize = New System.Drawing.Size(0, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 30)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Filtri attivi"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BottCancellaFiltri
        '
        Me.BottCancellaFiltri.AutoSize = True
        Me.BottCancellaFiltri.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BottCancellaFiltri.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BottCancellaFiltri.ForeColor = System.Drawing.Color.Red
        Me.BottCancellaFiltri.Location = New System.Drawing.Point(273, 30)
        Me.BottCancellaFiltri.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.BottCancellaFiltri.MinimumSize = New System.Drawing.Size(0, 30)
        Me.BottCancellaFiltri.Name = "BottCancellaFiltri"
        Me.BottCancellaFiltri.Size = New System.Drawing.Size(132, 30)
        Me.BottCancellaFiltri.TabIndex = 5
        Me.BottCancellaFiltri.Text = "Cancella filtri"
        Me.BottCancellaFiltri.UseVisualStyleBackColor = True
        '
        'PanelDettagliFilm
        '
        Me.PanelDettagliFilm.AutoScroll = True
        Me.PanelDettagliFilm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelDettagliFilm.Controls.Add(Me.PannelloExtra)
        Me.PanelDettagliFilm.Controls.Add(Me.PanelFile)
        Me.PanelDettagliFilm.Controls.Add(Me.PanelValutazioni)
        Me.PanelDettagliFilm.Controls.Add(Me.PannelloTrama)
        Me.PanelDettagliFilm.Controls.Add(Me.PannelloAttori)
        Me.PanelDettagliFilm.Controls.Add(Me.PannelloGeneri)
        Me.PanelDettagliFilm.Controls.Add(Me.SplitPosterInfoPrincipali)
        Me.PanelDettagliFilm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDettagliFilm.Location = New System.Drawing.Point(0, 0)
        Me.PanelDettagliFilm.Margin = New System.Windows.Forms.Padding(3, 3, 3, 47)
        Me.PanelDettagliFilm.MinimumSize = New System.Drawing.Size(50, 100)
        Me.PanelDettagliFilm.Name = "PanelDettagliFilm"
        Me.PanelDettagliFilm.Padding = New System.Windows.Forms.Padding(0, 0, 0, 47)
        Me.PanelDettagliFilm.Size = New System.Drawing.Size(651, 743)
        Me.PanelDettagliFilm.TabIndex = 20
        '
        'PannelloExtra
        '
        Me.PannelloExtra.AutoSize = True
        Me.PannelloExtra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PannelloExtra.Controls.Add(Me.ButtAddExtra)
        Me.PannelloExtra.Controls.Add(Me.ListaExtra)
        Me.PannelloExtra.Controls.Add(Me.IntestazioneExtra)
        Me.PannelloExtra.Dock = System.Windows.Forms.DockStyle.Top
        Me.PannelloExtra.Location = New System.Drawing.Point(0, 1497)
        Me.PannelloExtra.Name = "PannelloExtra"
        Me.PannelloExtra.Size = New System.Drawing.Size(630, 90)
        Me.PannelloExtra.TabIndex = 104
        Me.PannelloExtra.Visible = False
        '
        'ButtAddExtra
        '
        Me.ButtAddExtra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtAddExtra.BackColor = System.Drawing.Color.Transparent
        Me.ButtAddExtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtAddExtra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtAddExtra.Location = New System.Drawing.Point(597, 0)
        Me.ButtAddExtra.Name = "ButtAddExtra"
        Me.ButtAddExtra.Size = New System.Drawing.Size(30, 30)
        Me.ButtAddExtra.TabIndex = 43
        Me.ButtAddExtra.Text = "+"
        Me.ToolTip.SetToolTip(Me.ButtAddExtra, "Allega un contenuto extra al film (documentario, ""making of"", commento...)")
        Me.ButtAddExtra.UseVisualStyleBackColor = False
        '
        'ListaExtra
        '
        Me.ListaExtra.BackColor = System.Drawing.SystemColors.Control
        Me.ListaExtra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListaExtra.Cursor = System.Windows.Forms.Cursors.Default
        Me.ListaExtra.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListaExtra.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaExtra.FormattingEnabled = True
        Me.ListaExtra.ItemHeight = 29
        Me.ListaExtra.Items.AddRange(New Object() {"The Making Of", "Documentario di Tizio", "Comento di Caio"})
        Me.ListaExtra.Location = New System.Drawing.Point(0, 32)
        Me.ListaExtra.Name = "ListaExtra"
        Me.ListaExtra.Size = New System.Drawing.Size(630, 58)
        Me.ListaExtra.TabIndex = 42
        '
        'IntestazioneExtra
        '
        Me.IntestazioneExtra.BackColor = System.Drawing.SystemColors.ControlLight
        Me.IntestazioneExtra.Dock = System.Windows.Forms.DockStyle.Top
        Me.IntestazioneExtra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntestazioneExtra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IntestazioneExtra.ImageList = Me.IconeCategorieLibreria
        Me.IntestazioneExtra.Location = New System.Drawing.Point(0, 0)
        Me.IntestazioneExtra.Name = "IntestazioneExtra"
        Me.IntestazioneExtra.Size = New System.Drawing.Size(630, 32)
        Me.IntestazioneExtra.TabIndex = 41
        Me.IntestazioneExtra.Text = "Contenuti extra"
        Me.IntestazioneExtra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelFile
        '
        Me.PanelFile.AutoSize = True
        Me.PanelFile.Controls.Add(Me.SplitAudioSottotitoli)
        Me.PanelFile.Controls.Add(Me.PannelloVideo)
        Me.PanelFile.Controls.Add(Me.PannelloContenitore)
        Me.PanelFile.Controls.Add(Me.IntestazioneFile)
        Me.PanelFile.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFile.Location = New System.Drawing.Point(0, 1106)
        Me.PanelFile.MinimumSize = New System.Drawing.Size(0, 64)
        Me.PanelFile.Name = "PanelFile"
        Me.PanelFile.Size = New System.Drawing.Size(630, 391)
        Me.PanelFile.TabIndex = 103
        '
        'SplitAudioSottotitoli
        '
        Me.SplitAudioSottotitoli.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitAudioSottotitoli.IsSplitterFixed = True
        Me.SplitAudioSottotitoli.Location = New System.Drawing.Point(0, 281)
        Me.SplitAudioSottotitoli.Name = "SplitAudioSottotitoli"
        '
        'SplitAudioSottotitoli.Panel1
        '
        Me.SplitAudioSottotitoli.Panel1.Controls.Add(Me.PannelloAudio)
        '
        'SplitAudioSottotitoli.Panel2
        '
        Me.SplitAudioSottotitoli.Panel2.Controls.Add(Me.PannelloSottotitoli)
        Me.SplitAudioSottotitoli.Size = New System.Drawing.Size(630, 110)
        Me.SplitAudioSottotitoli.SplitterDistance = 310
        Me.SplitAudioSottotitoli.SplitterWidth = 1
        Me.SplitAudioSottotitoli.TabIndex = 88
        '
        'PannelloAudio
        '
        Me.PannelloAudio.Controls.Add(Me.RTFAudio)
        Me.PannelloAudio.Controls.Add(Me.IntestazioneAudio)
        Me.PannelloAudio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PannelloAudio.Location = New System.Drawing.Point(0, 0)
        Me.PannelloAudio.Margin = New System.Windows.Forms.Padding(0)
        Me.PannelloAudio.Name = "PannelloAudio"
        Me.PannelloAudio.Size = New System.Drawing.Size(310, 110)
        Me.PannelloAudio.TabIndex = 0
        '
        'RTFAudio
        '
        Me.RTFAudio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTFAudio.BulletIndent = 10
        Me.RTFAudio.Cursor = System.Windows.Forms.Cursors.Default
        Me.RTFAudio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RTFAudio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTFAudio.Location = New System.Drawing.Point(46, 0)
        Me.RTFAudio.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.RTFAudio.Name = "RTFAudio"
        Me.RTFAudio.ReadOnly = True
        Me.RTFAudio.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RTFAudio.ShortcutsEnabled = False
        Me.RTFAudio.Size = New System.Drawing.Size(264, 110)
        Me.RTFAudio.TabIndex = 78
        Me.RTFAudio.Text = ""
        '
        'IntestazioneAudio
        '
        Me.IntestazioneAudio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.IntestazioneAudio.BackColor = System.Drawing.SystemColors.ControlLight
        Me.IntestazioneAudio.Controls.Add(Me.PictureBox20)
        Me.IntestazioneAudio.Controls.Add(Me.Label20)
        Me.IntestazioneAudio.Dock = System.Windows.Forms.DockStyle.Left
        Me.IntestazioneAudio.Location = New System.Drawing.Point(0, 0)
        Me.IntestazioneAudio.Name = "IntestazioneAudio"
        Me.IntestazioneAudio.Size = New System.Drawing.Size(46, 110)
        Me.IntestazioneAudio.TabIndex = 89
        '
        'PictureBox20
        '
        Me.PictureBox20.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.audio
        Me.PictureBox20.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox20.TabIndex = 0
        Me.PictureBox20.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(3, 46)
        Me.Label20.MinimumSize = New System.Drawing.Size(0, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(34, 40)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Audio"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PannelloSottotitoli
        '
        Me.PannelloSottotitoli.Controls.Add(Me.RTFSottotitoli)
        Me.PannelloSottotitoli.Controls.Add(Me.IntestazioneSottotitoli)
        Me.PannelloSottotitoli.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PannelloSottotitoli.Location = New System.Drawing.Point(0, 0)
        Me.PannelloSottotitoli.Margin = New System.Windows.Forms.Padding(0)
        Me.PannelloSottotitoli.Name = "PannelloSottotitoli"
        Me.PannelloSottotitoli.Size = New System.Drawing.Size(319, 110)
        Me.PannelloSottotitoli.TabIndex = 1
        '
        'RTFSottotitoli
        '
        Me.RTFSottotitoli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTFSottotitoli.BulletIndent = 10
        Me.RTFSottotitoli.Cursor = System.Windows.Forms.Cursors.Default
        Me.RTFSottotitoli.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RTFSottotitoli.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTFSottotitoli.Location = New System.Drawing.Point(46, 0)
        Me.RTFSottotitoli.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.RTFSottotitoli.Name = "RTFSottotitoli"
        Me.RTFSottotitoli.ReadOnly = True
        Me.RTFSottotitoli.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RTFSottotitoli.ShortcutsEnabled = False
        Me.RTFSottotitoli.Size = New System.Drawing.Size(273, 110)
        Me.RTFSottotitoli.TabIndex = 55
        Me.RTFSottotitoli.Text = ""
        '
        'IntestazioneSottotitoli
        '
        Me.IntestazioneSottotitoli.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.IntestazioneSottotitoli.BackColor = System.Drawing.SystemColors.ControlLight
        Me.IntestazioneSottotitoli.Controls.Add(Me.PictureBox21)
        Me.IntestazioneSottotitoli.Controls.Add(Me.Label22)
        Me.IntestazioneSottotitoli.Dock = System.Windows.Forms.DockStyle.Left
        Me.IntestazioneSottotitoli.Location = New System.Drawing.Point(0, 0)
        Me.IntestazioneSottotitoli.Name = "IntestazioneSottotitoli"
        Me.IntestazioneSottotitoli.Size = New System.Drawing.Size(46, 110)
        Me.IntestazioneSottotitoli.TabIndex = 89
        '
        'PictureBox21
        '
        Me.PictureBox21.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.sottotitoli
        Me.PictureBox21.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox21.Name = "PictureBox21"
        Me.PictureBox21.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox21.TabIndex = 0
        Me.PictureBox21.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(3, 46)
        Me.Label22.MinimumSize = New System.Drawing.Size(0, 40)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(37, 60)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Sottotitoli"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PannelloVideo
        '
        Me.PannelloVideo.Controls.Add(Me.FlowLayoutPanel7)
        Me.PannelloVideo.Controls.Add(Me.IntestazioneVideo)
        Me.PannelloVideo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PannelloVideo.Location = New System.Drawing.Point(0, 147)
        Me.PannelloVideo.Name = "PannelloVideo"
        Me.PannelloVideo.Size = New System.Drawing.Size(630, 134)
        Me.PannelloVideo.TabIndex = 91
        '
        'FlowLayoutPanel7
        '
        Me.FlowLayoutPanel7.Controls.Add(Me.PannelloRisoluzione)
        Me.FlowLayoutPanel7.Controls.Add(Me.PannelloCodecVideo)
        Me.FlowLayoutPanel7.Controls.Add(Me.PannelloBitrateVideo)
        Me.FlowLayoutPanel7.Controls.Add(Me.PannelloProporzioni)
        Me.FlowLayoutPanel7.Controls.Add(Me.PannelloFPS)
        Me.FlowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel7.Location = New System.Drawing.Point(46, 0)
        Me.FlowLayoutPanel7.Name = "FlowLayoutPanel7"
        Me.FlowLayoutPanel7.Size = New System.Drawing.Size(584, 134)
        Me.FlowLayoutPanel7.TabIndex = 90
        '
        'PannelloRisoluzione
        '
        Me.PannelloRisoluzione.AutoSize = True
        Me.PannelloRisoluzione.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PannelloRisoluzione.Controls.Add(Me.BadgeRisoluzione)
        Me.PannelloRisoluzione.Controls.Add(Me.Label26)
        Me.PannelloRisoluzione.Controls.Add(Me.PictureBox9)
        Me.PannelloRisoluzione.Location = New System.Drawing.Point(20, 3)
        Me.PannelloRisoluzione.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.PannelloRisoluzione.MinimumSize = New System.Drawing.Size(0, 36)
        Me.PannelloRisoluzione.Name = "PannelloRisoluzione"
        Me.PannelloRisoluzione.Size = New System.Drawing.Size(215, 36)
        Me.PannelloRisoluzione.TabIndex = 59
        '
        'BadgeRisoluzione
        '
        Me.BadgeRisoluzione.AutoSize = True
        Me.BadgeRisoluzione.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BadgeRisoluzione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BadgeRisoluzione.Controls.Add(Me.LabAltezzaRisoluzione)
        Me.BadgeRisoluzione.Controls.Add(Me.LabTipoRisoluzione)
        Me.BadgeRisoluzione.Dock = System.Windows.Forms.DockStyle.Left
        Me.BadgeRisoluzione.Location = New System.Drawing.Point(82, 0)
        Me.BadgeRisoluzione.Name = "BadgeRisoluzione"
        Me.BadgeRisoluzione.Padding = New System.Windows.Forms.Padding(3)
        Me.BadgeRisoluzione.Size = New System.Drawing.Size(133, 36)
        Me.BadgeRisoluzione.TabIndex = 50
        '
        'LabAltezzaRisoluzione
        '
        Me.LabAltezzaRisoluzione.AutoSize = True
        Me.LabAltezzaRisoluzione.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabAltezzaRisoluzione.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabAltezzaRisoluzione.Location = New System.Drawing.Point(74, 3)
        Me.LabAltezzaRisoluzione.Margin = New System.Windows.Forms.Padding(12, 3, 3, 3)
        Me.LabAltezzaRisoluzione.MinimumSize = New System.Drawing.Size(2, 32)
        Me.LabAltezzaRisoluzione.Name = "LabAltezzaRisoluzione"
        Me.LabAltezzaRisoluzione.Size = New System.Drawing.Size(54, 32)
        Me.LabAltezzaRisoluzione.TabIndex = 53
        Me.LabAltezzaRisoluzione.Text = "1080p"
        Me.LabAltezzaRisoluzione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabTipoRisoluzione
        '
        Me.LabTipoRisoluzione.AutoSize = True
        Me.LabTipoRisoluzione.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabTipoRisoluzione.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabTipoRisoluzione.Location = New System.Drawing.Point(3, 3)
        Me.LabTipoRisoluzione.Margin = New System.Windows.Forms.Padding(12, 3, 3, 3)
        Me.LabTipoRisoluzione.MinimumSize = New System.Drawing.Size(2, 32)
        Me.LabTipoRisoluzione.Name = "LabTipoRisoluzione"
        Me.LabTipoRisoluzione.Size = New System.Drawing.Size(71, 32)
        Me.LabTipoRisoluzione.TabIndex = 52
        Me.LabTipoRisoluzione.Text = "FullHD"
        Me.LabTipoRisoluzione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(32, 0)
        Me.Label26.MinimumSize = New System.Drawing.Size(0, 32)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(50, 36)
        Me.Label26.TabIndex = 49
        Me.Label26.Text = "Risolu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "zione"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox9
        '
        Me.PictureBox9.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox9.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.monitor
        Me.PictureBox9.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(32, 36)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 47
        Me.PictureBox9.TabStop = False
        '
        'PannelloCodecVideo
        '
        Me.PannelloCodecVideo.AutoSize = True
        Me.PannelloCodecVideo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PannelloCodecVideo.Controls.Add(Me.LabCodecVideo)
        Me.PannelloCodecVideo.Controls.Add(Me.Label27)
        Me.PannelloCodecVideo.Controls.Add(Me.PictureBox15)
        Me.PannelloCodecVideo.Location = New System.Drawing.Point(258, 3)
        Me.PannelloCodecVideo.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.PannelloCodecVideo.MinimumSize = New System.Drawing.Size(0, 32)
        Me.PannelloCodecVideo.Name = "PannelloCodecVideo"
        Me.PannelloCodecVideo.Size = New System.Drawing.Size(141, 32)
        Me.PannelloCodecVideo.TabIndex = 61
        '
        'LabCodecVideo
        '
        Me.LabCodecVideo.AutoSize = True
        Me.LabCodecVideo.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabCodecVideo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabCodecVideo.Location = New System.Drawing.Point(88, 0)
        Me.LabCodecVideo.MinimumSize = New System.Drawing.Size(0, 32)
        Me.LabCodecVideo.Name = "LabCodecVideo"
        Me.LabCodecVideo.Size = New System.Drawing.Size(53, 32)
        Me.LabCodecVideo.TabIndex = 51
        Me.LabCodecVideo.Text = "H.264"
        Me.LabCodecVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(32, 0)
        Me.Label27.MinimumSize = New System.Drawing.Size(0, 32)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(56, 32)
        Me.Label27.TabIndex = 50
        Me.Label27.Text = "Codec:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox15
        '
        Me.PictureBox15.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox15.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.impostazioni
        Me.PictureBox15.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox15.TabIndex = 47
        Me.PictureBox15.TabStop = False
        '
        'PannelloBitrateVideo
        '
        Me.PannelloBitrateVideo.AutoSize = True
        Me.PannelloBitrateVideo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PannelloBitrateVideo.Controls.Add(Me.LabBitrateVideo)
        Me.PannelloBitrateVideo.Controls.Add(Me.PictureBox14)
        Me.PannelloBitrateVideo.Location = New System.Drawing.Point(422, 3)
        Me.PannelloBitrateVideo.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.PannelloBitrateVideo.MinimumSize = New System.Drawing.Size(0, 32)
        Me.PannelloBitrateVideo.Name = "PannelloBitrateVideo"
        Me.PannelloBitrateVideo.Size = New System.Drawing.Size(104, 32)
        Me.PannelloBitrateVideo.TabIndex = 57
        '
        'LabBitrateVideo
        '
        Me.LabBitrateVideo.AutoSize = True
        Me.LabBitrateVideo.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabBitrateVideo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabBitrateVideo.Location = New System.Drawing.Point(32, 0)
        Me.LabBitrateVideo.MinimumSize = New System.Drawing.Size(0, 32)
        Me.LabBitrateVideo.Name = "LabBitrateVideo"
        Me.LabBitrateVideo.Size = New System.Drawing.Size(72, 32)
        Me.LabBitrateVideo.TabIndex = 48
        Me.LabBitrateVideo.Text = "12 MB/s"
        Me.LabBitrateVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox14
        '
        Me.PictureBox14.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox14.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.peso_grey
        Me.PictureBox14.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox14.TabIndex = 47
        Me.PictureBox14.TabStop = False
        '
        'PannelloProporzioni
        '
        Me.PannelloProporzioni.AutoSize = True
        Me.PannelloProporzioni.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PannelloProporzioni.Controls.Add(Me.LabProporzioni)
        Me.PannelloProporzioni.Controls.Add(Me.PictureBox12)
        Me.PannelloProporzioni.Location = New System.Drawing.Point(20, 45)
        Me.PannelloProporzioni.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.PannelloProporzioni.MinimumSize = New System.Drawing.Size(0, 32)
        Me.PannelloProporzioni.Name = "PannelloProporzioni"
        Me.PannelloProporzioni.Size = New System.Drawing.Size(64, 32)
        Me.PannelloProporzioni.TabIndex = 58
        '
        'LabProporzioni
        '
        Me.LabProporzioni.AutoSize = True
        Me.LabProporzioni.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabProporzioni.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabProporzioni.Location = New System.Drawing.Point(32, 0)
        Me.LabProporzioni.MinimumSize = New System.Drawing.Size(0, 32)
        Me.LabProporzioni.Name = "LabProporzioni"
        Me.LabProporzioni.Size = New System.Drawing.Size(32, 32)
        Me.LabProporzioni.TabIndex = 48
        Me.LabProporzioni.Text = "4:3"
        Me.LabProporzioni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox12
        '
        Me.PictureBox12.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox12.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.squadra
        Me.PictureBox12.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox12.TabIndex = 47
        Me.PictureBox12.TabStop = False
        '
        'PannelloFPS
        '
        Me.PannelloFPS.AutoSize = True
        Me.PannelloFPS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PannelloFPS.Controls.Add(Me.LabFPS)
        Me.PannelloFPS.Controls.Add(Me.PictureBox13)
        Me.PannelloFPS.Location = New System.Drawing.Point(107, 45)
        Me.PannelloFPS.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.PannelloFPS.MinimumSize = New System.Drawing.Size(0, 32)
        Me.PannelloFPS.Name = "PannelloFPS"
        Me.PannelloFPS.Size = New System.Drawing.Size(96, 32)
        Me.PannelloFPS.TabIndex = 60
        '
        'LabFPS
        '
        Me.LabFPS.AutoSize = True
        Me.LabFPS.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabFPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabFPS.Location = New System.Drawing.Point(32, 0)
        Me.LabFPS.MinimumSize = New System.Drawing.Size(0, 32)
        Me.LabFPS.Name = "LabFPS"
        Me.LabFPS.Size = New System.Drawing.Size(64, 32)
        Me.LabFPS.TabIndex = 48
        Me.LabFPS.Text = "25 FPS"
        Me.LabFPS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox13
        '
        Me.PictureBox13.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox13.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.FPS_grey
        Me.PictureBox13.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox13.TabIndex = 47
        Me.PictureBox13.TabStop = False
        '
        'IntestazioneVideo
        '
        Me.IntestazioneVideo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.IntestazioneVideo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.IntestazioneVideo.Controls.Add(Me.PictureBox19)
        Me.IntestazioneVideo.Controls.Add(Me.Label49)
        Me.IntestazioneVideo.Dock = System.Windows.Forms.DockStyle.Left
        Me.IntestazioneVideo.Location = New System.Drawing.Point(0, 0)
        Me.IntestazioneVideo.Name = "IntestazioneVideo"
        Me.IntestazioneVideo.Size = New System.Drawing.Size(46, 134)
        Me.IntestazioneVideo.TabIndex = 89
        '
        'PictureBox19
        '
        Me.PictureBox19.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.pellicola
        Me.PictureBox19.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox19.Name = "PictureBox19"
        Me.PictureBox19.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox19.TabIndex = 0
        Me.PictureBox19.TabStop = False
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(3, 46)
        Me.Label49.MinimumSize = New System.Drawing.Size(0, 40)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(36, 40)
        Me.Label49.TabIndex = 1
        Me.Label49.Text = "Video"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PannelloContenitore
        '
        Me.PannelloContenitore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PannelloContenitore.Controls.Add(Me.FlowLayoutPanel2)
        Me.PannelloContenitore.Controls.Add(Me.IntestazioneContenitore)
        Me.PannelloContenitore.Dock = System.Windows.Forms.DockStyle.Top
        Me.PannelloContenitore.Location = New System.Drawing.Point(0, 32)
        Me.PannelloContenitore.Name = "PannelloContenitore"
        Me.PannelloContenitore.Size = New System.Drawing.Size(630, 115)
        Me.PannelloContenitore.TabIndex = 90
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel2.Controls.Add(Me.FlowLayoutPanel4)
        Me.FlowLayoutPanel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.FlowLayoutPanel2.Controls.Add(Me.PanBitrateFile)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(46, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(584, 115)
        Me.FlowLayoutPanel2.TabIndex = 86
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.AutoSize = True
        Me.FlowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel4.Controls.Add(Me.Label25)
        Me.FlowLayoutPanel4.Controls.Add(Me.LabEstensione)
        Me.FlowLayoutPanel4.Controls.Add(Me.LabCodecFile)
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(20, 3)
        Me.FlowLayoutPanel4.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(234, 20)
        Me.FlowLayoutPanel4.TabIndex = 88
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label25.ImageIndex = 7
        Me.Label25.Location = New System.Drawing.Point(3, 0)
        Me.Label25.MinimumSize = New System.Drawing.Size(0, 20)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(89, 20)
        Me.Label25.TabIndex = 68
        Me.Label25.Text = "Contenitore:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabEstensione
        '
        Me.LabEstensione.AutoSize = True
        Me.LabEstensione.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabEstensione.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabEstensione.ImageIndex = 7
        Me.LabEstensione.Location = New System.Drawing.Point(98, 0)
        Me.LabEstensione.Name = "LabEstensione"
        Me.LabEstensione.Size = New System.Drawing.Size(45, 20)
        Me.LabEstensione.TabIndex = 69
        Me.LabEstensione.Text = "MKV"
        Me.LabEstensione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabCodecFile
        '
        Me.LabCodecFile.AutoSize = True
        Me.LabCodecFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabCodecFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabCodecFile.ImageIndex = 7
        Me.LabCodecFile.Location = New System.Drawing.Point(149, 0)
        Me.LabCodecFile.Name = "LabCodecFile"
        Me.LabCodecFile.Size = New System.Drawing.Size(82, 20)
        Me.LabCodecFile.TabIndex = 72
        Me.LabCodecFile.Text = "Matrioska"
        Me.LabCodecFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.Label24)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabDimensioneFile)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(277, 3)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(164, 20)
        Me.FlowLayoutPanel1.TabIndex = 88
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(3, 0)
        Me.Label24.MinimumSize = New System.Drawing.Size(0, 20)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(91, 20)
        Me.Label24.TabIndex = 72
        Me.Label24.Text = "Dimensione:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabDimensioneFile
        '
        Me.LabDimensioneFile.AutoSize = True
        Me.LabDimensioneFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabDimensioneFile.Location = New System.Drawing.Point(100, 0)
        Me.LabDimensioneFile.Name = "LabDimensioneFile"
        Me.LabDimensioneFile.Size = New System.Drawing.Size(61, 20)
        Me.LabDimensioneFile.TabIndex = 73
        Me.LabDimensioneFile.Text = "4,5 GB"
        Me.LabDimensioneFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanBitrateFile
        '
        Me.PanBitrateFile.AutoSize = True
        Me.PanBitrateFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanBitrateFile.Controls.Add(Me.Label23)
        Me.PanBitrateFile.Controls.Add(Me.LabBitrateFile)
        Me.PanBitrateFile.Location = New System.Drawing.Point(20, 29)
        Me.PanBitrateFile.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.PanBitrateFile.Name = "PanBitrateFile"
        Me.PanBitrateFile.Size = New System.Drawing.Size(151, 26)
        Me.PanBitrateFile.TabIndex = 88
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label23.ImageIndex = 7
        Me.Label23.Location = New System.Drawing.Point(3, 0)
        Me.Label23.MinimumSize = New System.Drawing.Size(0, 26)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(54, 26)
        Me.Label23.TabIndex = 73
        Me.Label23.Text = "Bitrate:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabBitrateFile
        '
        Me.LabBitrateFile.AutoSize = True
        Me.LabBitrateFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabBitrateFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabBitrateFile.ImageIndex = 7
        Me.LabBitrateFile.Location = New System.Drawing.Point(63, 0)
        Me.LabBitrateFile.Name = "LabBitrateFile"
        Me.LabBitrateFile.Padding = New System.Windows.Forms.Padding(3)
        Me.LabBitrateFile.Size = New System.Drawing.Size(85, 26)
        Me.LabBitrateFile.TabIndex = 74
        Me.LabBitrateFile.Text = "21 MB/s"
        Me.LabBitrateFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IntestazioneContenitore
        '
        Me.IntestazioneContenitore.AutoSize = True
        Me.IntestazioneContenitore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.IntestazioneContenitore.BackColor = System.Drawing.SystemColors.ControlLight
        Me.IntestazioneContenitore.Controls.Add(Me.PictureBox18)
        Me.IntestazioneContenitore.Controls.Add(Me.Label48)
        Me.IntestazioneContenitore.Dock = System.Windows.Forms.DockStyle.Left
        Me.IntestazioneContenitore.Location = New System.Drawing.Point(0, 0)
        Me.IntestazioneContenitore.Name = "IntestazioneContenitore"
        Me.IntestazioneContenitore.Size = New System.Drawing.Size(46, 115)
        Me.IntestazioneContenitore.TabIndex = 88
        '
        'PictureBox18
        '
        Me.PictureBox18.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.floppy
        Me.PictureBox18.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox18.TabIndex = 0
        Me.PictureBox18.TabStop = False
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(3, 46)
        Me.Label48.MinimumSize = New System.Drawing.Size(0, 40)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(40, 40)
        Me.Label48.TabIndex = 1
        Me.Label48.Text = "File"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IntestazioneFile
        '
        Me.IntestazioneFile.BackColor = System.Drawing.SystemColors.ControlLight
        Me.IntestazioneFile.Dock = System.Windows.Forms.DockStyle.Top
        Me.IntestazioneFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntestazioneFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IntestazioneFile.ImageList = Me.IconeCategorieLibreria
        Me.IntestazioneFile.Location = New System.Drawing.Point(0, 0)
        Me.IntestazioneFile.Name = "IntestazioneFile"
        Me.IntestazioneFile.Size = New System.Drawing.Size(630, 32)
        Me.IntestazioneFile.TabIndex = 40
        Me.IntestazioneFile.Text = "File"
        Me.IntestazioneFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelValutazioni
        '
        Me.PanelValutazioni.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelValutazioni.Controls.Add(Me.PanComtenutoValutazioni)
        Me.PanelValutazioni.Controls.Add(Me.IntestazioneValutazioni)
        Me.PanelValutazioni.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelValutazioni.Location = New System.Drawing.Point(0, 821)
        Me.PanelValutazioni.Name = "PanelValutazioni"
        Me.PanelValutazioni.Size = New System.Drawing.Size(630, 285)
        Me.PanelValutazioni.TabIndex = 102
        '
        'PanComtenutoValutazioni
        '
        Me.PanComtenutoValutazioni.AutoSize = True
        Me.PanComtenutoValutazioni.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanComtenutoValutazioni.Controls.Add(Me.Label45)
        Me.PanComtenutoValutazioni.Controls.Add(Me.PanVotoIMDB)
        Me.PanComtenutoValutazioni.Controls.Add(Me.PanNumVotiIMDB)
        Me.PanComtenutoValutazioni.Controls.Add(Me.PanIncassi)
        Me.PanComtenutoValutazioni.Controls.Add(Me.Label43)
        Me.PanComtenutoValutazioni.Controls.Add(Me.PanMetacritic)
        Me.PanComtenutoValutazioni.Controls.Add(Me.PanRotten)
        Me.PanComtenutoValutazioni.Controls.Add(Me.PanPremiVinti)
        Me.PanComtenutoValutazioni.Controls.Add(Me.PanPremiNominati)
        Me.PanComtenutoValutazioni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanComtenutoValutazioni.Location = New System.Drawing.Point(0, 32)
        Me.PanComtenutoValutazioni.Name = "PanComtenutoValutazioni"
        Me.PanComtenutoValutazioni.Size = New System.Drawing.Size(630, 253)
        Me.PanComtenutoValutazioni.TabIndex = 1
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(3, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(25, 120)
        Me.Label45.TabIndex = 51
        Me.Label45.Text = "Pubblico"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanVotoIMDB
        '
        Me.PanVotoIMDB.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanVotoIMDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanVotoIMDB.Controls.Add(Me.Label17)
        Me.PanVotoIMDB.Controls.Add(Me.LabVotoIMDB)
        Me.PanVotoIMDB.Controls.Add(Me.Label36)
        Me.PanVotoIMDB.Location = New System.Drawing.Point(34, 3)
        Me.PanVotoIMDB.Name = "PanVotoIMDB"
        Me.PanVotoIMDB.Size = New System.Drawing.Size(75, 120)
        Me.PanVotoIMDB.TabIndex = 52
        '
        'Label17
        '
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(0, 85)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 17)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "/ 10"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabVotoIMDB
        '
        Me.LabVotoIMDB.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabVotoIMDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabVotoIMDB.Location = New System.Drawing.Point(0, 40)
        Me.LabVotoIMDB.Name = "LabVotoIMDB"
        Me.LabVotoIMDB.Size = New System.Drawing.Size(73, 45)
        Me.LabVotoIMDB.TabIndex = 1
        Me.LabVotoIMDB.Text = "0.0"
        Me.LabVotoIMDB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label36
        '
        Me.Label36.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(0, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(73, 40)
        Me.Label36.TabIndex = 0
        Me.Label36.Text = "IMDB"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanNumVotiIMDB
        '
        Me.PanNumVotiIMDB.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanNumVotiIMDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanNumVotiIMDB.Controls.Add(Me.LabMoltiplicatoreNumVotiIMDB)
        Me.PanNumVotiIMDB.Controls.Add(Me.LabNumVotiIMDB)
        Me.PanNumVotiIMDB.Controls.Add(Me.Label34)
        Me.PanNumVotiIMDB.Location = New System.Drawing.Point(115, 3)
        Me.PanNumVotiIMDB.Name = "PanNumVotiIMDB"
        Me.PanNumVotiIMDB.Size = New System.Drawing.Size(80, 120)
        Me.PanNumVotiIMDB.TabIndex = 53
        '
        'LabMoltiplicatoreNumVotiIMDB
        '
        Me.LabMoltiplicatoreNumVotiIMDB.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabMoltiplicatoreNumVotiIMDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMoltiplicatoreNumVotiIMDB.Location = New System.Drawing.Point(0, 85)
        Me.LabMoltiplicatoreNumVotiIMDB.Name = "LabMoltiplicatoreNumVotiIMDB"
        Me.LabMoltiplicatoreNumVotiIMDB.Size = New System.Drawing.Size(78, 35)
        Me.LabMoltiplicatoreNumVotiIMDB.TabIndex = 4
        Me.LabMoltiplicatoreNumVotiIMDB.Text = "kk"
        Me.LabMoltiplicatoreNumVotiIMDB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabNumVotiIMDB
        '
        Me.LabNumVotiIMDB.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabNumVotiIMDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabNumVotiIMDB.Location = New System.Drawing.Point(0, 40)
        Me.LabNumVotiIMDB.Name = "LabNumVotiIMDB"
        Me.LabNumVotiIMDB.Size = New System.Drawing.Size(78, 45)
        Me.LabNumVotiIMDB.TabIndex = 1
        Me.LabNumVotiIMDB.Text = "000"
        Me.LabNumVotiIMDB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(0, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(78, 40)
        Me.Label34.TabIndex = 0
        Me.Label34.Text = "Num voti" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "IMDB"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanIncassi
        '
        Me.PanIncassi.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanIncassi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanIncassi.Controls.Add(Me.Label39)
        Me.PanIncassi.Controls.Add(Me.LabMoltiplicatoreIncassi)
        Me.PanIncassi.Controls.Add(Me.LabIncassi)
        Me.PanIncassi.Controls.Add(Me.Label35)
        Me.PanIncassi.Location = New System.Drawing.Point(201, 3)
        Me.PanIncassi.Name = "PanIncassi"
        Me.PanIncassi.Size = New System.Drawing.Size(80, 120)
        Me.PanIncassi.TabIndex = 54
        '
        'Label39
        '
        Me.Label39.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(0, 95)
        Me.Label39.Margin = New System.Windows.Forms.Padding(0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(78, 20)
        Me.Label39.TabIndex = 6
        Me.Label39.Text = "$"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabMoltiplicatoreIncassi
        '
        Me.LabMoltiplicatoreIncassi.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabMoltiplicatoreIncassi.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMoltiplicatoreIncassi.Location = New System.Drawing.Point(0, 65)
        Me.LabMoltiplicatoreIncassi.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMoltiplicatoreIncassi.Name = "LabMoltiplicatoreIncassi"
        Me.LabMoltiplicatoreIncassi.Size = New System.Drawing.Size(78, 30)
        Me.LabMoltiplicatoreIncassi.TabIndex = 5
        Me.LabMoltiplicatoreIncassi.Text = "mml"
        Me.LabMoltiplicatoreIncassi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabIncassi
        '
        Me.LabIncassi.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabIncassi.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabIncassi.Location = New System.Drawing.Point(0, 20)
        Me.LabIncassi.Name = "LabIncassi"
        Me.LabIncassi.Size = New System.Drawing.Size(78, 45)
        Me.LabIncassi.TabIndex = 1
        Me.LabIncassi.Text = "000"
        Me.LabIncassi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label35
        '
        Me.Label35.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(0, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(78, 20)
        Me.Label35.TabIndex = 0
        Me.Label35.Text = "Incassi"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(287, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(25, 121)
        Me.Label43.TabIndex = 50
        Me.Label43.Text = "Critica"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanMetacritic
        '
        Me.PanMetacritic.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanMetacritic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanMetacritic.Controls.Add(Me.Label16)
        Me.PanMetacritic.Controls.Add(Me.LabMetacritic)
        Me.PanMetacritic.Controls.Add(Me.Label15)
        Me.PanMetacritic.Location = New System.Drawing.Point(318, 3)
        Me.PanMetacritic.MinimumSize = New System.Drawing.Size(2, 95)
        Me.PanMetacritic.Name = "PanMetacritic"
        Me.PanMetacritic.Size = New System.Drawing.Size(85, 121)
        Me.PanMetacritic.TabIndex = 51
        '
        'Label16
        '
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(0, 85)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 17)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "/ 100"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabMetacritic
        '
        Me.LabMetacritic.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabMetacritic.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMetacritic.Location = New System.Drawing.Point(0, 40)
        Me.LabMetacritic.Name = "LabMetacritic"
        Me.LabMetacritic.Size = New System.Drawing.Size(83, 45)
        Me.LabMetacritic.TabIndex = 1
        Me.LabMetacritic.Text = "001"
        Me.LabMetacritic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(0, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 40)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Metacritic"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanRotten
        '
        Me.PanRotten.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanRotten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanRotten.Controls.Add(Me.Label32)
        Me.PanRotten.Controls.Add(Me.LabRotten)
        Me.PanRotten.Controls.Add(Me.Label38)
        Me.PanRotten.Location = New System.Drawing.Point(409, 3)
        Me.PanRotten.MinimumSize = New System.Drawing.Size(2, 95)
        Me.PanRotten.Name = "PanRotten"
        Me.PanRotten.Size = New System.Drawing.Size(85, 121)
        Me.PanRotten.TabIndex = 52
        '
        'Label32
        '
        Me.Label32.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(0, 80)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(83, 17)
        Me.Label32.TabIndex = 3
        Me.Label32.Text = "%"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabRotten
        '
        Me.LabRotten.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabRotten.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabRotten.Location = New System.Drawing.Point(0, 40)
        Me.LabRotten.Name = "LabRotten"
        Me.LabRotten.Size = New System.Drawing.Size(83, 40)
        Me.LabRotten.TabIndex = 1
        Me.LabRotten.Text = "001"
        Me.LabRotten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label38
        '
        Me.Label38.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(0, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(83, 40)
        Me.Label38.TabIndex = 0
        Me.Label38.Text = "Rotten Tomatoes"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanPremiVinti
        '
        Me.PanPremiVinti.BackColor = System.Drawing.Color.Gold
        Me.PanPremiVinti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanPremiVinti.Controls.Add(Me.PanAltriVinti)
        Me.PanPremiVinti.Controls.Add(Me.PanBAFTAVinti)
        Me.PanPremiVinti.Controls.Add(Me.PanOscarVinti)
        Me.PanPremiVinti.Controls.Add(Me.Label40)
        Me.PanPremiVinti.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanPremiVinti.Location = New System.Drawing.Point(3, 130)
        Me.PanPremiVinti.Name = "PanPremiVinti"
        Me.PanPremiVinti.Size = New System.Drawing.Size(146, 121)
        Me.PanPremiVinti.TabIndex = 53
        '
        'PanAltriVinti
        '
        Me.PanAltriVinti.Controls.Add(Me.Label42)
        Me.PanAltriVinti.Controls.Add(Me.LabAltriVinti)
        Me.PanAltriVinti.Controls.Add(Me.PictureBox10)
        Me.PanAltriVinti.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanAltriVinti.Location = New System.Drawing.Point(0, 84)
        Me.PanAltriVinti.Name = "PanAltriVinti"
        Me.PanAltriVinti.Size = New System.Drawing.Size(144, 32)
        Me.PanAltriVinti.TabIndex = 3
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(71, 0)
        Me.Label42.Margin = New System.Windows.Forms.Padding(0)
        Me.Label42.MinimumSize = New System.Drawing.Size(0, 32)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(37, 32)
        Me.Label42.TabIndex = 2
        Me.Label42.Text = "altri"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabAltriVinti
        '
        Me.LabAltriVinti.AutoSize = True
        Me.LabAltriVinti.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabAltriVinti.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabAltriVinti.Location = New System.Drawing.Point(32, 0)
        Me.LabAltriVinti.Margin = New System.Windows.Forms.Padding(0)
        Me.LabAltriVinti.MinimumSize = New System.Drawing.Size(0, 32)
        Me.LabAltriVinti.Name = "LabAltriVinti"
        Me.LabAltriVinti.Size = New System.Drawing.Size(39, 32)
        Me.LabAltriVinti.TabIndex = 1
        Me.LabAltriVinti.Text = "88"
        Me.LabAltriVinti.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox10
        '
        Me.PictureBox10.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox10.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.premio_oro2
        Me.PictureBox10.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 0
        Me.PictureBox10.TabStop = False
        '
        'PanBAFTAVinti
        '
        Me.PanBAFTAVinti.Controls.Add(Me.Label33)
        Me.PanBAFTAVinti.Controls.Add(Me.LabBAFTAVinti)
        Me.PanBAFTAVinti.Controls.Add(Me.PictureBox8)
        Me.PanBAFTAVinti.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanBAFTAVinti.Location = New System.Drawing.Point(0, 52)
        Me.PanBAFTAVinti.Name = "PanBAFTAVinti"
        Me.PanBAFTAVinti.Size = New System.Drawing.Size(144, 32)
        Me.PanBAFTAVinti.TabIndex = 2
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(71, 0)
        Me.Label33.Margin = New System.Windows.Forms.Padding(0)
        Me.Label33.MinimumSize = New System.Drawing.Size(0, 32)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(54, 32)
        Me.Label33.TabIndex = 2
        Me.Label33.Text = "BAFTA"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabBAFTAVinti
        '
        Me.LabBAFTAVinti.AutoSize = True
        Me.LabBAFTAVinti.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabBAFTAVinti.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabBAFTAVinti.Location = New System.Drawing.Point(32, 0)
        Me.LabBAFTAVinti.Margin = New System.Windows.Forms.Padding(0)
        Me.LabBAFTAVinti.MinimumSize = New System.Drawing.Size(0, 32)
        Me.LabBAFTAVinti.Name = "LabBAFTAVinti"
        Me.LabBAFTAVinti.Size = New System.Drawing.Size(39, 32)
        Me.LabBAFTAVinti.TabIndex = 1
        Me.LabBAFTAVinti.Text = "88"
        Me.LabBAFTAVinti.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox8
        '
        Me.PictureBox8.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox8.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.bafta
        Me.PictureBox8.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 0
        Me.PictureBox8.TabStop = False
        '
        'PanOscarVinti
        '
        Me.PanOscarVinti.Controls.Add(Me.Label37)
        Me.PanOscarVinti.Controls.Add(Me.LabOscarVinti)
        Me.PanOscarVinti.Controls.Add(Me.PictureBox2)
        Me.PanOscarVinti.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanOscarVinti.Location = New System.Drawing.Point(0, 20)
        Me.PanOscarVinti.Name = "PanOscarVinti"
        Me.PanOscarVinti.Size = New System.Drawing.Size(144, 32)
        Me.PanOscarVinti.TabIndex = 1
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(80, 0)
        Me.Label37.Margin = New System.Windows.Forms.Padding(0)
        Me.Label37.MinimumSize = New System.Drawing.Size(0, 32)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(63, 32)
        Me.Label37.TabIndex = 2
        Me.Label37.Text = "Oscar"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabOscarVinti
        '
        Me.LabOscarVinti.AutoSize = True
        Me.LabOscarVinti.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabOscarVinti.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabOscarVinti.Location = New System.Drawing.Point(32, 0)
        Me.LabOscarVinti.Margin = New System.Windows.Forms.Padding(0)
        Me.LabOscarVinti.MinimumSize = New System.Drawing.Size(0, 32)
        Me.LabOscarVinti.Name = "LabOscarVinti"
        Me.LabOscarVinti.Size = New System.Drawing.Size(48, 32)
        Me.LabOscarVinti.TabIndex = 1
        Me.LabOscarVinti.Text = "88"
        Me.LabOscarVinti.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.oscar2
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Label40
        '
        Me.Label40.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(0, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(144, 20)
        Me.Label40.TabIndex = 0
        Me.Label40.Text = "Premi vinti"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanPremiNominati
        '
        Me.PanPremiNominati.BackColor = System.Drawing.Color.Silver
        Me.PanPremiNominati.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanPremiNominati.Controls.Add(Me.PanAltriNominati)
        Me.PanPremiNominati.Controls.Add(Me.PanBAFTANominati)
        Me.PanPremiNominati.Controls.Add(Me.PanOscarNominati)
        Me.PanPremiNominati.Controls.Add(Me.Label47)
        Me.PanPremiNominati.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanPremiNominati.Location = New System.Drawing.Point(155, 130)
        Me.PanPremiNominati.MinimumSize = New System.Drawing.Size(2, 95)
        Me.PanPremiNominati.Name = "PanPremiNominati"
        Me.PanPremiNominati.Size = New System.Drawing.Size(133, 121)
        Me.PanPremiNominati.TabIndex = 54
        '
        'PanAltriNominati
        '
        Me.PanAltriNominati.Controls.Add(Me.Label41)
        Me.PanAltriNominati.Controls.Add(Me.LabAltriNominati)
        Me.PanAltriNominati.Controls.Add(Me.PictureBox11)
        Me.PanAltriNominati.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanAltriNominati.Location = New System.Drawing.Point(0, 84)
        Me.PanAltriNominati.Name = "PanAltriNominati"
        Me.PanAltriNominati.Size = New System.Drawing.Size(131, 32)
        Me.PanAltriNominati.TabIndex = 6
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(66, 0)
        Me.Label41.Margin = New System.Windows.Forms.Padding(0)
        Me.Label41.MinimumSize = New System.Drawing.Size(0, 32)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(31, 32)
        Me.Label41.TabIndex = 2
        Me.Label41.Text = "altri"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabAltriNominati
        '
        Me.LabAltriNominati.AutoSize = True
        Me.LabAltriNominati.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabAltriNominati.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabAltriNominati.Location = New System.Drawing.Point(32, 0)
        Me.LabAltriNominati.Margin = New System.Windows.Forms.Padding(0)
        Me.LabAltriNominati.MinimumSize = New System.Drawing.Size(0, 32)
        Me.LabAltriNominati.Name = "LabAltriNominati"
        Me.LabAltriNominati.Size = New System.Drawing.Size(34, 32)
        Me.LabAltriNominati.TabIndex = 1
        Me.LabAltriNominati.Text = "88"
        Me.LabAltriNominati.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox11
        '
        Me.PictureBox11.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox11.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.premio_argento
        Me.PictureBox11.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox11.TabIndex = 0
        Me.PictureBox11.TabStop = False
        '
        'PanBAFTANominati
        '
        Me.PanBAFTANominati.Controls.Add(Me.Label44)
        Me.PanBAFTANominati.Controls.Add(Me.LabBAFTANominati)
        Me.PanBAFTANominati.Controls.Add(Me.PictureBox16)
        Me.PanBAFTANominati.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanBAFTANominati.Location = New System.Drawing.Point(0, 52)
        Me.PanBAFTANominati.Name = "PanBAFTANominati"
        Me.PanBAFTANominati.Size = New System.Drawing.Size(131, 32)
        Me.PanBAFTANominati.TabIndex = 5
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(66, 0)
        Me.Label44.Margin = New System.Windows.Forms.Padding(0)
        Me.Label44.MinimumSize = New System.Drawing.Size(0, 32)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(51, 32)
        Me.Label44.TabIndex = 2
        Me.Label44.Text = "BAFTA"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabBAFTANominati
        '
        Me.LabBAFTANominati.AutoSize = True
        Me.LabBAFTANominati.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabBAFTANominati.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabBAFTANominati.Location = New System.Drawing.Point(32, 0)
        Me.LabBAFTANominati.Margin = New System.Windows.Forms.Padding(0)
        Me.LabBAFTANominati.MinimumSize = New System.Drawing.Size(0, 32)
        Me.LabBAFTANominati.Name = "LabBAFTANominati"
        Me.LabBAFTANominati.Size = New System.Drawing.Size(34, 32)
        Me.LabBAFTANominati.TabIndex = 1
        Me.LabBAFTANominati.Text = "88"
        Me.LabBAFTANominati.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox16
        '
        Me.PictureBox16.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox16.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.bafta_argento
        Me.PictureBox16.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox16.TabIndex = 0
        Me.PictureBox16.TabStop = False
        '
        'PanOscarNominati
        '
        Me.PanOscarNominati.Controls.Add(Me.Label46)
        Me.PanOscarNominati.Controls.Add(Me.LabOscarNominati)
        Me.PanOscarNominati.Controls.Add(Me.PictureBox17)
        Me.PanOscarNominati.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanOscarNominati.Location = New System.Drawing.Point(0, 20)
        Me.PanOscarNominati.Name = "PanOscarNominati"
        Me.PanOscarNominati.Size = New System.Drawing.Size(131, 32)
        Me.PanOscarNominati.TabIndex = 4
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(73, 0)
        Me.Label46.Margin = New System.Windows.Forms.Padding(0)
        Me.Label46.MinimumSize = New System.Drawing.Size(0, 32)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(60, 32)
        Me.Label46.TabIndex = 2
        Me.Label46.Text = "Oscar"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabOscarNominati
        '
        Me.LabOscarNominati.AutoSize = True
        Me.LabOscarNominati.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabOscarNominati.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabOscarNominati.Location = New System.Drawing.Point(32, 0)
        Me.LabOscarNominati.Margin = New System.Windows.Forms.Padding(0)
        Me.LabOscarNominati.MinimumSize = New System.Drawing.Size(0, 32)
        Me.LabOscarNominati.Name = "LabOscarNominati"
        Me.LabOscarNominati.Size = New System.Drawing.Size(41, 32)
        Me.LabOscarNominati.TabIndex = 1
        Me.LabOscarNominati.Text = "88"
        Me.LabOscarNominati.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox17
        '
        Me.PictureBox17.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox17.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.oscar_argento
        Me.PictureBox17.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox17.TabIndex = 0
        Me.PictureBox17.TabStop = False
        '
        'Label47
        '
        Me.Label47.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(0, 0)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(131, 20)
        Me.Label47.TabIndex = 0
        Me.Label47.Text = "Premi nominati"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IntestazioneValutazioni
        '
        Me.IntestazioneValutazioni.BackColor = System.Drawing.SystemColors.ControlLight
        Me.IntestazioneValutazioni.Dock = System.Windows.Forms.DockStyle.Top
        Me.IntestazioneValutazioni.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntestazioneValutazioni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IntestazioneValutazioni.Location = New System.Drawing.Point(0, 0)
        Me.IntestazioneValutazioni.Name = "IntestazioneValutazioni"
        Me.IntestazioneValutazioni.Size = New System.Drawing.Size(630, 32)
        Me.IntestazioneValutazioni.TabIndex = 38
        Me.IntestazioneValutazioni.Text = "Valutazioni"
        Me.IntestazioneValutazioni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PannelloTrama
        '
        Me.PannelloTrama.AutoSize = True
        Me.PannelloTrama.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PannelloTrama.Controls.Add(Me.LabTramaBreve)
        Me.PannelloTrama.Controls.Add(Me.TextTramaLunga)
        Me.PannelloTrama.Controls.Add(Me.ButtonToggleTrama)
        Me.PannelloTrama.Controls.Add(Me.IntestazioneTrama)
        Me.PannelloTrama.Dock = System.Windows.Forms.DockStyle.Top
        Me.PannelloTrama.Location = New System.Drawing.Point(0, 594)
        Me.PannelloTrama.Name = "PannelloTrama"
        Me.PannelloTrama.Size = New System.Drawing.Size(630, 227)
        Me.PannelloTrama.TabIndex = 101
        '
        'LabTramaBreve
        '
        Me.LabTramaBreve.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabTramaBreve.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabTramaBreve.Font = New System.Drawing.Font("Cambria", 13.8!)
        Me.LabTramaBreve.Location = New System.Drawing.Point(0, 152)
        Me.LabTramaBreve.Margin = New System.Windows.Forms.Padding(3, 3, 16, 3)
        Me.LabTramaBreve.MinimumSize = New System.Drawing.Size(0, 22)
        Me.LabTramaBreve.Name = "LabTramaBreve"
        Me.LabTramaBreve.Size = New System.Drawing.Size(630, 75)
        Me.LabTramaBreve.TabIndex = 88
        Me.LabTramaBreve.Text = "LabTramaBreve"
        '
        'TextTramaLunga
        '
        Me.TextTramaLunga.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextTramaLunga.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextTramaLunga.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTramaLunga.Location = New System.Drawing.Point(0, 32)
        Me.TextTramaLunga.Margin = New System.Windows.Forms.Padding(3, 3, 16, 3)
        Me.TextTramaLunga.MinimumSize = New System.Drawing.Size(0, 22)
        Me.TextTramaLunga.Multiline = True
        Me.TextTramaLunga.Name = "TextTramaLunga"
        Me.TextTramaLunga.ReadOnly = True
        Me.TextTramaLunga.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextTramaLunga.Size = New System.Drawing.Size(630, 120)
        Me.TextTramaLunga.TabIndex = 42
        Me.TextTramaLunga.Text = "TextTramaLunga"
        Me.TextTramaLunga.Visible = False
        '
        'ButtonToggleTrama
        '
        Me.ButtonToggleTrama.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonToggleTrama.Location = New System.Drawing.Point(539, 2)
        Me.ButtonToggleTrama.Name = "ButtonToggleTrama"
        Me.ButtonToggleTrama.Size = New System.Drawing.Size(88, 28)
        Me.ButtonToggleTrama.TabIndex = 41
        Me.ButtonToggleTrama.Text = "Espandi"
        Me.ButtonToggleTrama.UseVisualStyleBackColor = True
        '
        'IntestazioneTrama
        '
        Me.IntestazioneTrama.BackColor = System.Drawing.SystemColors.ControlLight
        Me.IntestazioneTrama.Dock = System.Windows.Forms.DockStyle.Top
        Me.IntestazioneTrama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntestazioneTrama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IntestazioneTrama.Location = New System.Drawing.Point(0, 0)
        Me.IntestazioneTrama.Name = "IntestazioneTrama"
        Me.IntestazioneTrama.Size = New System.Drawing.Size(630, 32)
        Me.IntestazioneTrama.TabIndex = 39
        Me.IntestazioneTrama.Text = "Trama"
        Me.IntestazioneTrama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PannelloAttori
        '
        Me.PannelloAttori.AutoSize = True
        Me.PannelloAttori.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PannelloAttori.Controls.Add(Me.ListaAttori)
        Me.PannelloAttori.Controls.Add(Me.IntestazioneAttori)
        Me.PannelloAttori.Dock = System.Windows.Forms.DockStyle.Top
        Me.PannelloAttori.Location = New System.Drawing.Point(0, 527)
        Me.PannelloAttori.Name = "PannelloAttori"
        Me.PannelloAttori.Size = New System.Drawing.Size(630, 67)
        Me.PannelloAttori.TabIndex = 100
        '
        'ListaAttori
        '
        Me.ListaAttori.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.ListaAttori.AutoArrange = False
        Me.ListaAttori.BackColor = System.Drawing.SystemColors.Control
        Me.ListaAttori.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListaAttori.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListaAttori.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListaAttori.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaAttori.FullRowSelect = True
        Me.ListaAttori.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListaAttori.HideSelection = False
        ListViewItem1.StateImageIndex = 0
        Me.ListaAttori.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.ListaAttori.Location = New System.Drawing.Point(0, 32)
        Me.ListaAttori.Margin = New System.Windows.Forms.Padding(3, 3, 16, 3)
        Me.ListaAttori.MultiSelect = False
        Me.ListaAttori.Name = "ListaAttori"
        Me.ListaAttori.Scrollable = False
        Me.ListaAttori.Size = New System.Drawing.Size(630, 35)
        Me.ListaAttori.TabIndex = 81
        Me.ListaAttori.UseCompatibleStateImageBehavior = False
        Me.ListaAttori.View = System.Windows.Forms.View.SmallIcon
        '
        'IntestazioneAttori
        '
        Me.IntestazioneAttori.BackColor = System.Drawing.SystemColors.ControlLight
        Me.IntestazioneAttori.Dock = System.Windows.Forms.DockStyle.Top
        Me.IntestazioneAttori.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntestazioneAttori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IntestazioneAttori.ImageIndex = 2
        Me.IntestazioneAttori.Location = New System.Drawing.Point(0, 0)
        Me.IntestazioneAttori.Name = "IntestazioneAttori"
        Me.IntestazioneAttori.Size = New System.Drawing.Size(630, 32)
        Me.IntestazioneAttori.TabIndex = 80
        Me.IntestazioneAttori.Text = "Attori"
        Me.IntestazioneAttori.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PannelloGeneri
        '
        Me.PannelloGeneri.AutoSize = True
        Me.PannelloGeneri.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PannelloGeneri.Controls.Add(Me.ListaGeneri)
        Me.PannelloGeneri.Controls.Add(Me.IntestazioneGeneri)
        Me.PannelloGeneri.Dock = System.Windows.Forms.DockStyle.Top
        Me.PannelloGeneri.Location = New System.Drawing.Point(0, 432)
        Me.PannelloGeneri.Name = "PannelloGeneri"
        Me.PannelloGeneri.Size = New System.Drawing.Size(630, 95)
        Me.PannelloGeneri.TabIndex = 99
        '
        'ListaGeneri
        '
        Me.ListaGeneri.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.ListaGeneri.AutoArrange = False
        Me.ListaGeneri.BackColor = System.Drawing.SystemColors.Control
        Me.ListaGeneri.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListaGeneri.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListaGeneri.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListaGeneri.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaGeneri.FullRowSelect = True
        Me.ListaGeneri.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListaGeneri.HideSelection = False
        ListViewItem6.StateImageIndex = 0
        Me.ListaGeneri.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem4, ListViewItem5, ListViewItem6})
        Me.ListaGeneri.Location = New System.Drawing.Point(0, 32)
        Me.ListaGeneri.Margin = New System.Windows.Forms.Padding(3, 3, 16, 3)
        Me.ListaGeneri.MultiSelect = False
        Me.ListaGeneri.Name = "ListaGeneri"
        Me.ListaGeneri.Scrollable = False
        Me.ListaGeneri.ShowGroups = False
        Me.ListaGeneri.Size = New System.Drawing.Size(630, 63)
        Me.ListaGeneri.SmallImageList = Me.IconeCategorieLibreria
        Me.ListaGeneri.TabIndex = 79
        Me.ListaGeneri.UseCompatibleStateImageBehavior = False
        Me.ListaGeneri.View = System.Windows.Forms.View.SmallIcon
        '
        'IntestazioneGeneri
        '
        Me.IntestazioneGeneri.BackColor = System.Drawing.SystemColors.ControlLight
        Me.IntestazioneGeneri.Dock = System.Windows.Forms.DockStyle.Top
        Me.IntestazioneGeneri.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntestazioneGeneri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IntestazioneGeneri.ImageIndex = 3
        Me.IntestazioneGeneri.Location = New System.Drawing.Point(0, 0)
        Me.IntestazioneGeneri.Name = "IntestazioneGeneri"
        Me.IntestazioneGeneri.Size = New System.Drawing.Size(630, 32)
        Me.IntestazioneGeneri.TabIndex = 78
        Me.IntestazioneGeneri.Text = "Generi"
        Me.IntestazioneGeneri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitPosterInfoPrincipali
        '
        Me.SplitPosterInfoPrincipali.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitPosterInfoPrincipali.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitPosterInfoPrincipali.IsSplitterFixed = True
        Me.SplitPosterInfoPrincipali.Location = New System.Drawing.Point(0, 0)
        Me.SplitPosterInfoPrincipali.Name = "SplitPosterInfoPrincipali"
        '
        'SplitPosterInfoPrincipali.Panel1
        '
        Me.SplitPosterInfoPrincipali.Panel1.Controls.Add(Me.PicPoster)
        '
        'SplitPosterInfoPrincipali.Panel2
        '
        Me.SplitPosterInfoPrincipali.Panel2.Controls.Add(Me.FlowLayoutPanel6)
        Me.SplitPosterInfoPrincipali.Size = New System.Drawing.Size(630, 432)
        Me.SplitPosterInfoPrincipali.SplitterDistance = 250
        Me.SplitPosterInfoPrincipali.SplitterWidth = 1
        Me.SplitPosterInfoPrincipali.TabIndex = 98
        '
        'PicPoster
        '
        Me.PicPoster.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicPoster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicPoster.Location = New System.Drawing.Point(0, 0)
        Me.PicPoster.Name = "PicPoster"
        Me.PicPoster.Size = New System.Drawing.Size(250, 432)
        Me.PicPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicPoster.TabIndex = 1
        Me.PicPoster.TabStop = False
        Me.ToolTip.SetToolTip(Me.PicPoster, "Poster del film")
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.AutoSize = True
        Me.FlowLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel6.Controls.Add(Me.LabTitoloITA)
        Me.FlowLayoutPanel6.Controls.Add(Me.LabTitoloORIG)
        Me.FlowLayoutPanel6.Controls.Add(Me.PanelNote)
        Me.FlowLayoutPanel6.Controls.Add(Me.PanelToggleImg)
        Me.FlowLayoutPanel6.Controls.Add(Me.PanelAnno)
        Me.FlowLayoutPanel6.Controls.Add(Me.PannelloNazione)
        Me.FlowLayoutPanel6.Controls.Add(Me.PanelDurata)
        Me.FlowLayoutPanel6.Controls.Add(Me.PanelRegisti)
        Me.FlowLayoutPanel6.Controls.Add(Me.PanelAutori)
        Me.FlowLayoutPanel6.Controls.Add(Me.PanelMusicisti)
        Me.FlowLayoutPanel6.Controls.Add(Me.PicSchermata)
        Me.FlowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel6.MinimumSize = New System.Drawing.Size(140, 100)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(379, 432)
        Me.FlowLayoutPanel6.TabIndex = 2
        '
        'LabTitoloITA
        '
        Me.LabTitoloITA.AutoSize = True
        Me.FlowLayoutPanel6.SetFlowBreak(Me.LabTitoloITA, True)
        Me.LabTitoloITA.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.LabTitoloITA.Location = New System.Drawing.Point(3, 0)
        Me.LabTitoloITA.Name = "LabTitoloITA"
        Me.LabTitoloITA.Size = New System.Drawing.Size(94, 38)
        Me.LabTitoloITA.TabIndex = 20
        Me.LabTitoloITA.Text = "Titolo"
        Me.LabTitoloITA.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'LabTitoloORIG
        '
        Me.LabTitoloORIG.AutoSize = True
        Me.FlowLayoutPanel6.SetFlowBreak(Me.LabTitoloORIG, True)
        Me.LabTitoloORIG.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.LabTitoloORIG.Location = New System.Drawing.Point(3, 38)
        Me.LabTitoloORIG.Name = "LabTitoloORIG"
        Me.LabTitoloORIG.Size = New System.Drawing.Size(141, 28)
        Me.LabTitoloORIG.TabIndex = 21
        Me.LabTitoloORIG.Text = "TitoloOriginale"
        '
        'PanelNote
        '
        Me.PanelNote.AutoSize = True
        Me.PanelNote.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelNote.Controls.Add(Me.LabNote)
        Me.PanelNote.Controls.Add(Me.PictureBox7)
        Me.PanelNote.Location = New System.Drawing.Point(3, 81)
        Me.PanelNote.Name = "PanelNote"
        Me.PanelNote.Size = New System.Drawing.Size(149, 34)
        Me.PanelNote.TabIndex = 74
        '
        'LabNote
        '
        Me.LabNote.AutoSize = True
        Me.LabNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabNote.Location = New System.Drawing.Point(38, 0)
        Me.LabNote.Margin = New System.Windows.Forms.Padding(0)
        Me.LabNote.MinimumSize = New System.Drawing.Size(0, 32)
        Me.LabNote.Name = "LabNote"
        Me.LabNote.Size = New System.Drawing.Size(111, 32)
        Me.LabNote.TabIndex = 7
        Me.LabNote.Text = "Director's cut"
        Me.LabNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.note
        Me.PictureBox7.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(32, 34)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 1
        Me.PictureBox7.TabStop = False
        '
        'PanelToggleImg
        '
        Me.PanelToggleImg.AutoSize = True
        Me.PanelToggleImg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelToggleImg.Controls.Add(Me.ButtPannelloSchermata)
        Me.PanelToggleImg.Controls.Add(Me.ButtTogglePoster)
        Me.FlowLayoutPanel6.SetFlowBreak(Me.PanelToggleImg, True)
        Me.PanelToggleImg.Location = New System.Drawing.Point(158, 81)
        Me.PanelToggleImg.Name = "PanelToggleImg"
        Me.PanelToggleImg.Size = New System.Drawing.Size(79, 35)
        Me.PanelToggleImg.TabIndex = 88
        '
        'ButtPannelloSchermata
        '
        Me.ButtPannelloSchermata.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtPannelloSchermata.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtPannelloSchermata.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.ButtPannelloSchermata.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtPannelloSchermata.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtPannelloSchermata.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtPannelloSchermata.Location = New System.Drawing.Point(44, 0)
        Me.ButtPannelloSchermata.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtPannelloSchermata.Name = "ButtPannelloSchermata"
        Me.ButtPannelloSchermata.Size = New System.Drawing.Size(35, 35)
        Me.ButtPannelloSchermata.TabIndex = 90
        Me.ButtPannelloSchermata.Text = "S"
        Me.ToolTip.SetToolTip(Me.ButtPannelloSchermata, "Nascondi/Visualizza la schermata del film")
        Me.ButtPannelloSchermata.UseVisualStyleBackColor = False
        '
        'ButtTogglePoster
        '
        Me.ButtTogglePoster.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtTogglePoster.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtTogglePoster.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.ButtTogglePoster.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtTogglePoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtTogglePoster.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtTogglePoster.Location = New System.Drawing.Point(0, 0)
        Me.ButtTogglePoster.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtTogglePoster.Name = "ButtTogglePoster"
        Me.ButtTogglePoster.Size = New System.Drawing.Size(35, 35)
        Me.ButtTogglePoster.TabIndex = 0
        Me.ButtTogglePoster.Text = "P"
        Me.ToolTip.SetToolTip(Me.ButtTogglePoster, "Nascondi/Visualizza il poster del film")
        Me.ButtTogglePoster.UseVisualStyleBackColor = False
        '
        'PanelAnno
        '
        Me.PanelAnno.AutoSize = True
        Me.PanelAnno.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelAnno.Controls.Add(Me.LabAnno)
        Me.PanelAnno.Controls.Add(Me.PictureBox1)
        Me.PanelAnno.Location = New System.Drawing.Point(3, 122)
        Me.PanelAnno.MinimumSize = New System.Drawing.Size(0, 32)
        Me.PanelAnno.Name = "PanelAnno"
        Me.PanelAnno.Size = New System.Drawing.Size(98, 32)
        Me.PanelAnno.TabIndex = 53
        '
        'LabAnno
        '
        Me.LabAnno.AutoSize = True
        Me.LabAnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabAnno.Location = New System.Drawing.Point(32, 0)
        Me.LabAnno.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.LabAnno.MinimumSize = New System.Drawing.Size(45, 32)
        Me.LabAnno.Name = "LabAnno"
        Me.LabAnno.Size = New System.Drawing.Size(54, 32)
        Me.LabAnno.TabIndex = 2
        Me.LabAnno.Text = "1959"
        Me.LabAnno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.data
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(0, 32)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(32, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PannelloNazione
        '
        Me.PannelloNazione.AutoSize = True
        Me.PannelloNazione.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PannelloNazione.Controls.Add(Me.NazionePic)
        Me.PannelloNazione.Controls.Add(Me.NazioneLab)
        Me.PannelloNazione.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlowLayoutPanel6.SetFlowBreak(Me.PannelloNazione, True)
        Me.PannelloNazione.Location = New System.Drawing.Point(107, 122)
        Me.PannelloNazione.MinimumSize = New System.Drawing.Size(0, 32)
        Me.PannelloNazione.Name = "PannelloNazione"
        Me.PannelloNazione.Size = New System.Drawing.Size(114, 32)
        Me.PannelloNazione.TabIndex = 54
        '
        'NazionePic
        '
        Me.NazionePic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NazionePic.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.USA
        Me.NazionePic.Location = New System.Drawing.Point(0, 0)
        Me.NazionePic.Margin = New System.Windows.Forms.Padding(0)
        Me.NazionePic.Name = "NazionePic"
        Me.NazionePic.Size = New System.Drawing.Size(32, 32)
        Me.NazionePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.NazionePic.TabIndex = 2
        Me.NazionePic.TabStop = False
        '
        'NazioneLab
        '
        Me.NazioneLab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NazioneLab.AutoSize = True
        Me.NazioneLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NazioneLab.Location = New System.Drawing.Point(38, 0)
        Me.NazioneLab.Margin = New System.Windows.Forms.Padding(0)
        Me.NazioneLab.MinimumSize = New System.Drawing.Size(0, 32)
        Me.NazioneLab.Name = "NazioneLab"
        Me.NazioneLab.Size = New System.Drawing.Size(50, 32)
        Me.NazioneLab.TabIndex = 16
        Me.NazioneLab.Text = "USA"
        Me.NazioneLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelDurata
        '
        Me.PanelDurata.AutoSize = True
        Me.PanelDurata.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelDurata.Controls.Add(Me.PictureBox3)
        Me.PanelDurata.Controls.Add(Me.LabDurata)
        Me.PanelDurata.Controls.Add(Me.Label21)
        Me.PanelDurata.Controls.Add(Me.LabFineVisione)
        Me.PanelDurata.Controls.Add(Me.Label14)
        Me.FlowLayoutPanel6.SetFlowBreak(Me.PanelDurata, True)
        Me.PanelDurata.Location = New System.Drawing.Point(3, 160)
        Me.PanelDurata.Name = "PanelDurata"
        Me.PanelDurata.Size = New System.Drawing.Size(229, 32)
        Me.PanelDurata.TabIndex = 75
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.cronometro
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox3.MaximumSize = New System.Drawing.Size(0, 32)
        Me.PictureBox3.MinimumSize = New System.Drawing.Size(32, 32)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'LabDurata
        '
        Me.LabDurata.AutoSize = True
        Me.LabDurata.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabDurata.Location = New System.Drawing.Point(32, 0)
        Me.LabDurata.Margin = New System.Windows.Forms.Padding(0)
        Me.LabDurata.MinimumSize = New System.Drawing.Size(0, 32)
        Me.LabDurata.Name = "LabDurata"
        Me.LabDurata.Size = New System.Drawing.Size(60, 32)
        Me.LabDurata.TabIndex = 9
        Me.LabDurata.Text = "1h 20"
        Me.LabDurata.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(92, 0)
        Me.Label21.Margin = New System.Windows.Forms.Padding(0)
        Me.Label21.MinimumSize = New System.Drawing.Size(0, 32)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(77, 32)
        Me.Label21.TabIndex = 10
        Me.Label21.Text = "(finiresti alle"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabFineVisione
        '
        Me.LabFineVisione.AutoSize = True
        Me.LabFineVisione.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabFineVisione.Location = New System.Drawing.Point(169, 0)
        Me.LabFineVisione.Margin = New System.Windows.Forms.Padding(0)
        Me.LabFineVisione.MinimumSize = New System.Drawing.Size(0, 32)
        Me.LabFineVisione.Name = "LabFineVisione"
        Me.LabFineVisione.Size = New System.Drawing.Size(49, 32)
        Me.LabFineVisione.TabIndex = 11
        Me.LabFineVisione.Text = "23:58"
        Me.LabFineVisione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(218, 0)
        Me.Label14.Margin = New System.Windows.Forms.Padding(0)
        Me.Label14.MinimumSize = New System.Drawing.Size(0, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(11, 32)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = ")"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelRegisti
        '
        Me.PanelRegisti.AutoSize = True
        Me.PanelRegisti.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelRegisti.Controls.Add(Me.LabRegisti)
        Me.PanelRegisti.Controls.Add(Me.PictureBox4)
        Me.FlowLayoutPanel6.SetFlowBreak(Me.PanelRegisti, True)
        Me.PanelRegisti.Location = New System.Drawing.Point(3, 198)
        Me.PanelRegisti.Name = "PanelRegisti"
        Me.PanelRegisti.Size = New System.Drawing.Size(161, 32)
        Me.PanelRegisti.TabIndex = 25
        '
        'LabRegisti
        '
        Me.LabRegisti.AutoSize = True
        Me.LabRegisti.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabRegisti.Location = New System.Drawing.Point(32, 0)
        Me.LabRegisti.Margin = New System.Windows.Forms.Padding(0)
        Me.LabRegisti.MinimumSize = New System.Drawing.Size(0, 32)
        Me.LabRegisti.Name = "LabRegisti"
        Me.LabRegisti.Size = New System.Drawing.Size(129, 32)
        Me.LabRegisti.TabIndex = 7
        Me.LabRegisti.Text = "Sergio Leone"
        Me.LabRegisti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.camera
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'PanelAutori
        '
        Me.PanelAutori.AutoSize = True
        Me.PanelAutori.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelAutori.Controls.Add(Me.LabAutori)
        Me.PanelAutori.Controls.Add(Me.PictureBox6)
        Me.FlowLayoutPanel6.SetFlowBreak(Me.PanelAutori, True)
        Me.PanelAutori.Location = New System.Drawing.Point(3, 236)
        Me.PanelAutori.Name = "PanelAutori"
        Me.PanelAutori.Size = New System.Drawing.Size(140, 32)
        Me.PanelAutori.TabIndex = 26
        '
        'LabAutori
        '
        Me.LabAutori.AutoSize = True
        Me.LabAutori.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabAutori.Location = New System.Drawing.Point(32, 0)
        Me.LabAutori.Margin = New System.Windows.Forms.Padding(0)
        Me.LabAutori.MinimumSize = New System.Drawing.Size(0, 32)
        Me.LabAutori.Name = "LabAutori"
        Me.LabAutori.Size = New System.Drawing.Size(108, 32)
        Me.LabAutori.TabIndex = 13
        Me.LabAutori.Text = "Stephen King"
        Me.LabAutori.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.autore
        Me.PictureBox6.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 11
        Me.PictureBox6.TabStop = False
        '
        'PanelMusicisti
        '
        Me.PanelMusicisti.AutoSize = True
        Me.PanelMusicisti.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelMusicisti.Controls.Add(Me.LabMusicisti)
        Me.PanelMusicisti.Controls.Add(Me.PictureBox5)
        Me.PanelMusicisti.Location = New System.Drawing.Point(3, 274)
        Me.PanelMusicisti.Name = "PanelMusicisti"
        Me.PanelMusicisti.Size = New System.Drawing.Size(168, 32)
        Me.PanelMusicisti.TabIndex = 27
        '
        'LabMusicisti
        '
        Me.LabMusicisti.AutoSize = True
        Me.LabMusicisti.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMusicisti.Location = New System.Drawing.Point(37, 0)
        Me.LabMusicisti.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMusicisti.MinimumSize = New System.Drawing.Size(0, 32)
        Me.LabMusicisti.Name = "LabMusicisti"
        Me.LabMusicisti.Size = New System.Drawing.Size(131, 32)
        Me.LabMusicisti.TabIndex = 15
        Me.LabMusicisti.Text = "Ennio Morricone"
        Me.LabMusicisti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.musica
        Me.PictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 13
        Me.PictureBox5.TabStop = False
        '
        'PicSchermata
        '
        Me.PicSchermata.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicSchermata.Location = New System.Drawing.Point(3, 312)
        Me.PicSchermata.Name = "PicSchermata"
        Me.PicSchermata.Size = New System.Drawing.Size(258, 113)
        Me.PicSchermata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicSchermata.TabIndex = 2
        Me.PicSchermata.TabStop = False
        Me.ToolTip.SetToolTip(Me.PicSchermata, "Schermata del film")
        '
        'BarraStrumentiFilm
        '
        Me.BarraStrumentiFilm.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarraStrumentiFilm.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BarraStrumentiFilm.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.BarraStrumentiFilm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayButton, Me.EsploraRisorseButton, Me.RinominaButton, Me.DownloadButton, Me.CercaInternetButton, Me.ToolStripButton5})
        Me.BarraStrumentiFilm.Location = New System.Drawing.Point(0, 696)
        Me.BarraStrumentiFilm.Name = "BarraStrumentiFilm"
        Me.BarraStrumentiFilm.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BarraStrumentiFilm.Size = New System.Drawing.Size(651, 47)
        Me.BarraStrumentiFilm.Stretch = True
        Me.BarraStrumentiFilm.TabIndex = 85
        Me.BarraStrumentiFilm.Text = "Strumenti Film"
        '
        'PlayButton
        '
        Me.PlayButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PlayButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayButton.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.play
        Me.PlayButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(44, 44)
        Me.PlayButton.Text = "Riproduci il film"
        '
        'EsploraRisorseButton
        '
        Me.EsploraRisorseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EsploraRisorseButton.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.cartella
        Me.EsploraRisorseButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EsploraRisorseButton.Name = "EsploraRisorseButton"
        Me.EsploraRisorseButton.Size = New System.Drawing.Size(44, 44)
        Me.EsploraRisorseButton.Text = "Visualizza file in Esplora risorse"
        '
        'RinominaButton
        '
        Me.RinominaButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RinominaButton.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.modifica
        Me.RinominaButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RinominaButton.Name = "RinominaButton"
        Me.RinominaButton.Size = New System.Drawing.Size(44, 44)
        Me.RinominaButton.Text = "Rinomina"
        '
        'DownloadButton
        '
        Me.DownloadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DownloadButton.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.download
        Me.DownloadButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DownloadButton.Name = "DownloadButton"
        Me.DownloadButton.Size = New System.Drawing.Size(44, 44)
        Me.DownloadButton.Text = "Acquisisci informazioni da Internet"
        '
        'CercaInternetButton
        '
        Me.CercaInternetButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CercaInternetButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoogleToolStripMenuItem, Me.WikiITToolStripMenuItem, Me.IMDBToolStripMenuItem})
        Me.CercaInternetButton.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.CercaInternet
        Me.CercaInternetButton.Name = "CercaInternetButton"
        Me.CercaInternetButton.Size = New System.Drawing.Size(54, 44)
        Me.CercaInternetButton.Text = "Apri la scheda del film su Internet"
        '
        'GoogleToolStripMenuItem
        '
        Me.GoogleToolStripMenuItem.Name = "GoogleToolStripMenuItem"
        Me.GoogleToolStripMenuItem.Size = New System.Drawing.Size(175, 26)
        Me.GoogleToolStripMenuItem.Text = "Google"
        '
        'WikiITToolStripMenuItem
        '
        Me.WikiITToolStripMenuItem.Name = "WikiITToolStripMenuItem"
        Me.WikiITToolStripMenuItem.Size = New System.Drawing.Size(175, 26)
        Me.WikiITToolStripMenuItem.Text = "Wikipedia IT"
        '
        'IMDBToolStripMenuItem
        '
        Me.IMDBToolStripMenuItem.Name = "IMDBToolStripMenuItem"
        Me.IMDBToolStripMenuItem.Size = New System.Drawing.Size(175, 26)
        Me.IMDBToolStripMenuItem.Text = "IMDB"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.quadro
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(44, 44)
        Me.ToolStripButton5.Text = "Cambia schermata"
        '
        'AlberoCategorieLibreria
        '
        Me.AlberoCategorieLibreria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlberoCategorieLibreria.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AlberoCategorieLibreria.FullRowSelect = True
        Me.AlberoCategorieLibreria.HideSelection = False
        Me.AlberoCategorieLibreria.ImageIndex = 0
        Me.AlberoCategorieLibreria.ImageList = Me.IconeCategorieLibreria
        Me.AlberoCategorieLibreria.Indent = 35
        Me.AlberoCategorieLibreria.ItemHeight = 40
        Me.AlberoCategorieLibreria.Location = New System.Drawing.Point(0, 0)
        Me.AlberoCategorieLibreria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 35)
        Me.AlberoCategorieLibreria.Name = "AlberoCategorieLibreria"
        TreeNode1.ImageIndex = 1
        TreeNode1.Name = "NodoTuttiFilm"
        TreeNode1.SelectedImageIndex = 1
        TreeNode1.Text = "Tutti i film"
        TreeNode2.ImageIndex = 2
        TreeNode2.Name = "NodoCatRegisti"
        TreeNode2.SelectedImageIndex = 2
        TreeNode2.Text = "Registi"
        TreeNode3.ImageIndex = 3
        TreeNode3.Name = "NodoCatAttori"
        TreeNode3.SelectedImageIndex = 3
        TreeNode3.Text = "Attori"
        TreeNode4.Name = "Node5"
        TreeNode4.Text = "🙂 Commedia"
        TreeNode5.Name = "Node7"
        TreeNode5.Text = "🤣 Comico"
        TreeNode6.Name = "Node6"
        TreeNode6.Text = "😭 Drammatico"
        TreeNode7.Name = "Node12"
        TreeNode7.Text = "🕵️ Giallo"
        TreeNode8.Name = "Node13"
        TreeNode8.Text = "👮 Polizesco"
        TreeNode9.Name = "Node14"
        TreeNode9.Text = "🏴 Noir"
        TreeNode10.Name = "Node11"
        TreeNode10.Text = "🤢 Splatter"
        TreeNode11.Name = "Node8"
        TreeNode11.Text = "😱 Horror"
        TreeNode12.Name = "Node9"
        TreeNode12.Text = "😲 Thriller"
        TreeNode13.Name = "Node17"
        TreeNode13.Text = "🔫 Gangster"
        TreeNode14.Name = "Node10"
        TreeNode14.Text = "🤖 Fantascienza"
        TreeNode15.Name = "Node16"
        TreeNode15.Text = "⚔️ Guerra"
        TreeNode16.Name = "Node15"
        TreeNode16.Text = "🎅 Natalizio"
        TreeNode17.ImageIndex = 4
        TreeNode17.Name = "NodoCatGeneri"
        TreeNode17.SelectedImageIndex = 4
        TreeNode17.Text = "Generi"
        TreeNode18.ImageIndex = 5
        TreeNode18.Name = "NodoCatDecenni"
        TreeNode18.SelectedImageIndex = 5
        TreeNode18.Text = "Anni"
        TreeNode19.ImageIndex = 6
        TreeNode19.Name = "NodoCatNazioni"
        TreeNode19.SelectedImageIndex = 6
        TreeNode19.Text = "Nazioni"
        TreeNode20.ImageIndex = 85
        TreeNode20.Name = "NodoCatSaghe"
        TreeNode20.SelectedImageIndex = 85
        TreeNode20.Text = "Saghe"
        TreeNode21.ImageIndex = 7
        TreeNode21.Name = "NodoCatAutori"
        TreeNode21.SelectedImageIndex = 7
        TreeNode21.Text = "Autori"
        TreeNode22.ImageIndex = 8
        TreeNode22.Name = "NodoCatMusicisti"
        TreeNode22.SelectedImageIndex = 8
        TreeNode22.Text = "Musicisti"
        TreeNode23.ImageIndex = 9
        TreeNode23.Name = "NodoCatTemi"
        TreeNode23.SelectedImageIndex = 9
        TreeNode23.Text = "Temi"
        TreeNode24.Name = "Node19"
        TreeNode24.Text = "Antica Grecia"
        TreeNode25.Name = "Node20"
        TreeNode25.Text = "Antica Roma"
        TreeNode26.Name = "Node21"
        TreeNode26.Text = "Medioevo"
        TreeNode27.Name = "Node22"
        TreeNode27.Text = "Cinquecento"
        TreeNode28.Name = "Node23"
        TreeNode28.Text = "Seicento"
        TreeNode29.Name = "Node24"
        TreeNode29.Text = "Settecento"
        TreeNode30.Name = "Node25"
        TreeNode30.Text = "Ottocento"
        TreeNode31.Name = "Node41"
        TreeNode31.Text = "Prima guerra mondiale"
        TreeNode32.Name = "Node42"
        TreeNode32.Text = "Seconda guerra mondiale"
        TreeNode33.Name = "Node27"
        TreeNode33.Text = "Vietnam"
        TreeNode34.Name = "Node43"
        TreeNode34.Text = "Anni di piombo"
        TreeNode35.Name = "Node26"
        TreeNode35.Text = "Novecento"
        TreeNode36.ImageIndex = 10
        TreeNode36.Name = "NodoCatAmbientazione"
        TreeNode36.SelectedImageIndex = 10
        TreeNode36.Text = "Ambientazione"
        Me.AlberoCategorieLibreria.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode17, TreeNode18, TreeNode19, TreeNode20, TreeNode21, TreeNode22, TreeNode23, TreeNode36})
        Me.AlberoCategorieLibreria.SelectedImageIndex = 0
        Me.AlberoCategorieLibreria.ShowNodeToolTips = True
        Me.AlberoCategorieLibreria.ShowRootLines = False
        Me.AlberoCategorieLibreria.Size = New System.Drawing.Size(147, 683)
        Me.AlberoCategorieLibreria.TabIndex = 1
        '
        'SplitContainerSX_C
        '
        Me.SplitContainerSX_C.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerSX_C.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainerSX_C.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerSX_C.Name = "SplitContainerSX_C"
        '
        'SplitContainerSX_C.Panel1
        '
        Me.SplitContainerSX_C.Panel1.Controls.Add(Me.ToolStripCategorie)
        Me.SplitContainerSX_C.Panel1.Controls.Add(Me.AlberoCategorieLibreria)
        Me.SplitContainerSX_C.Panel1MinSize = 50
        '
        'SplitContainerSX_C.Panel2
        '
        Me.SplitContainerSX_C.Panel2.Controls.Add(Me.SplitContainerFiltriAvanzati_Icone)
        Me.SplitContainerSX_C.Panel2.Controls.Add(Me.PannelloFiltri)
        Me.SplitContainerSX_C.Panel2MinSize = 140
        Me.SplitContainerSX_C.Size = New System.Drawing.Size(559, 683)
        Me.SplitContainerSX_C.SplitterDistance = 147
        Me.SplitContainerSX_C.SplitterIncrement = 10
        Me.SplitContainerSX_C.TabIndex = 1
        '
        'ToolStripCategorie
        '
        Me.ToolStripCategorie.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStripCategorie.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripCategorie.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStripCategorie.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DropDownOrdinamentoCategorie, Me.DropDownInfoCategoria, Me.ToolStripDropDownButton5})
        Me.ToolStripCategorie.Location = New System.Drawing.Point(0, 644)
        Me.ToolStripCategorie.Name = "ToolStripCategorie"
        Me.ToolStripCategorie.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStripCategorie.Size = New System.Drawing.Size(147, 39)
        Me.ToolStripCategorie.TabIndex = 2
        Me.ToolStripCategorie.Text = "ToolStrip1"
        '
        'DropDownOrdinamentoCategorie
        '
        Me.DropDownOrdinamentoCategorie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DropDownOrdinamentoCategorie.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EpocaDiAttivitàultimaUscitaPiùRemotaToolStripMenuItem, Me.EpocaDiAttivitàultimaUscitaPiùRecenteToolStripMenuItem, Me.AlfabeticoToolStripMenuItem, Me.DurataFilmToolStripMenuItem, Me.NumeroFilmToolStripMenuItem})
        Me.DropDownOrdinamentoCategorie.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.ordinamento
        Me.DropDownOrdinamentoCategorie.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DropDownOrdinamentoCategorie.Name = "DropDownOrdinamentoCategorie"
        Me.DropDownOrdinamentoCategorie.Size = New System.Drawing.Size(46, 36)
        Me.DropDownOrdinamentoCategorie.Text = "Ordina valori categoria per"
        '
        'EpocaDiAttivitàultimaUscitaPiùRemotaToolStripMenuItem
        '
        Me.EpocaDiAttivitàultimaUscitaPiùRemotaToolStripMenuItem.Name = "EpocaDiAttivitàultimaUscitaPiùRemotaToolStripMenuItem"
        Me.EpocaDiAttivitàultimaUscitaPiùRemotaToolStripMenuItem.Size = New System.Drawing.Size(470, 26)
        Me.EpocaDiAttivitàultimaUscitaPiùRemotaToolStripMenuItem.Text = "Periodo di attività ascendente (ultima uscita più remota)"
        '
        'EpocaDiAttivitàultimaUscitaPiùRecenteToolStripMenuItem
        '
        Me.EpocaDiAttivitàultimaUscitaPiùRecenteToolStripMenuItem.Name = "EpocaDiAttivitàultimaUscitaPiùRecenteToolStripMenuItem"
        Me.EpocaDiAttivitàultimaUscitaPiùRecenteToolStripMenuItem.Size = New System.Drawing.Size(470, 26)
        Me.EpocaDiAttivitàultimaUscitaPiùRecenteToolStripMenuItem.Text = "Periodo di attività discendente (ultima uscita più recente)"
        '
        'AlfabeticoToolStripMenuItem
        '
        Me.AlfabeticoToolStripMenuItem.Name = "AlfabeticoToolStripMenuItem"
        Me.AlfabeticoToolStripMenuItem.Size = New System.Drawing.Size(470, 26)
        Me.AlfabeticoToolStripMenuItem.Text = "Nome (ordine alfabetico ascendente A-Z)"
        '
        'DurataFilmToolStripMenuItem
        '
        Me.DurataFilmToolStripMenuItem.Name = "DurataFilmToolStripMenuItem"
        Me.DurataFilmToolStripMenuItem.Size = New System.Drawing.Size(470, 26)
        Me.DurataFilmToolStripMenuItem.Text = "Durata film"
        '
        'NumeroFilmToolStripMenuItem
        '
        Me.NumeroFilmToolStripMenuItem.Name = "NumeroFilmToolStripMenuItem"
        Me.NumeroFilmToolStripMenuItem.Size = New System.Drawing.Size(470, 26)
        Me.NumeroFilmToolStripMenuItem.Text = "Numero film"
        '
        'DropDownInfoCategoria
        '
        Me.DropDownInfoCategoria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DropDownInfoCategoria.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NessunaInformazioneToolStripMenuItem, Me.PeriodoDiAttivitàToolStripMenuItem, Me.DurataFilmToolStripMenuItem1, Me.ConteggioFilmToolStripMenuItem})
        Me.DropDownInfoCategoria.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.fields2
        Me.DropDownInfoCategoria.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DropDownInfoCategoria.Name = "DropDownInfoCategoria"
        Me.DropDownInfoCategoria.Size = New System.Drawing.Size(46, 36)
        Me.DropDownInfoCategoria.Text = "Informazioni da visualizzare"
        '
        'NessunaInformazioneToolStripMenuItem
        '
        Me.NessunaInformazioneToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.NessunaInformazioneToolStripMenuItem.Name = "NessunaInformazioneToolStripMenuItem"
        Me.NessunaInformazioneToolStripMenuItem.Size = New System.Drawing.Size(239, 26)
        Me.NessunaInformazioneToolStripMenuItem.Text = "Nessuna informazione"
        '
        'PeriodoDiAttivitàToolStripMenuItem
        '
        Me.PeriodoDiAttivitàToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PeriodoDiAttivitàToolStripMenuItem.Name = "PeriodoDiAttivitàToolStripMenuItem"
        Me.PeriodoDiAttivitàToolStripMenuItem.Size = New System.Drawing.Size(239, 26)
        Me.PeriodoDiAttivitàToolStripMenuItem.Text = "Periodo di attività"
        '
        'DurataFilmToolStripMenuItem1
        '
        Me.DurataFilmToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DurataFilmToolStripMenuItem1.Name = "DurataFilmToolStripMenuItem1"
        Me.DurataFilmToolStripMenuItem1.Size = New System.Drawing.Size(239, 26)
        Me.DurataFilmToolStripMenuItem1.Text = "Durata film"
        '
        'ConteggioFilmToolStripMenuItem
        '
        Me.ConteggioFilmToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ConteggioFilmToolStripMenuItem.Name = "ConteggioFilmToolStripMenuItem"
        Me.ConteggioFilmToolStripMenuItem.Size = New System.Drawing.Size(239, 26)
        Me.ConteggioFilmToolStripMenuItem.Text = "Conteggio film"
        '
        'ToolStripDropDownButton5
        '
        Me.ToolStripDropDownButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NomeCognomeToolStripMenuItem, Me.CognomeNomeToolStripMenuItem, Me.CognomeToolStripMenuItem, Me.InizialeCognomeToolStripMenuItem})
        Me.ToolStripDropDownButton5.Enabled = False
        Me.ToolStripDropDownButton5.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.persona
        Me.ToolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton5.Name = "ToolStripDropDownButton5"
        Me.ToolStripDropDownButton5.Size = New System.Drawing.Size(46, 36)
        Me.ToolStripDropDownButton5.Text = "Formato dei nomi di persona"
        '
        'NomeCognomeToolStripMenuItem
        '
        Me.NomeCognomeToolStripMenuItem.Name = "NomeCognomeToolStripMenuItem"
        Me.NomeCognomeToolStripMenuItem.Size = New System.Drawing.Size(267, 26)
        Me.NomeCognomeToolStripMenuItem.Text = "Nome + Cognome"
        '
        'CognomeNomeToolStripMenuItem
        '
        Me.CognomeNomeToolStripMenuItem.Name = "CognomeNomeToolStripMenuItem"
        Me.CognomeNomeToolStripMenuItem.Size = New System.Drawing.Size(267, 26)
        Me.CognomeNomeToolStripMenuItem.Text = "Cognome, Nome"
        '
        'CognomeToolStripMenuItem
        '
        Me.CognomeToolStripMenuItem.Name = "CognomeToolStripMenuItem"
        Me.CognomeToolStripMenuItem.Size = New System.Drawing.Size(267, 26)
        Me.CognomeToolStripMenuItem.Text = "Cognome"
        '
        'InizialeCognomeToolStripMenuItem
        '
        Me.InizialeCognomeToolStripMenuItem.Name = "InizialeCognomeToolStripMenuItem"
        Me.InizialeCognomeToolStripMenuItem.Size = New System.Drawing.Size(267, 26)
        Me.InizialeCognomeToolStripMenuItem.Text = "Iniziale Nome + Cognome"
        '
        'FileSystemWatcher
        '
        Me.FileSystemWatcher.EnableRaisingEvents = True
        Me.FileSystemWatcher.NotifyFilter = CType(((System.IO.NotifyFilters.FileName Or System.IO.NotifyFilters.Size) _
            Or System.IO.NotifyFilters.LastWrite), System.IO.NotifyFilters)
        Me.FileSystemWatcher.SynchronizingObject = Me
        '
        'PosterFilmPiccoli
        '
        Me.PosterFilmPiccoli.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit
        Me.PosterFilmPiccoli.ImageSize = New System.Drawing.Size(70, 100)
        Me.PosterFilmPiccoli.TransparentColor = System.Drawing.Color.Transparent
        '
        'PosterFilmGrandi
        '
        Me.PosterFilmGrandi.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit
        Me.PosterFilmGrandi.ImageSize = New System.Drawing.Size(175, 250)
        Me.PosterFilmGrandi.TransparentColor = System.Drawing.Color.Transparent
        '
        'SplitContainerCSX_DX
        '
        Me.SplitContainerCSX_DX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerCSX_DX.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerCSX_DX.Name = "SplitContainerCSX_DX"
        '
        'SplitContainerCSX_DX.Panel1
        '
        Me.SplitContainerCSX_DX.Panel1.Controls.Add(Me.SplitContainerBarreStrumenti_CSX)
        Me.SplitContainerCSX_DX.Panel1MinSize = 80
        '
        'SplitContainerCSX_DX.Panel2
        '
        Me.SplitContainerCSX_DX.Panel2.Controls.Add(Me.BarraStrumentiFilm)
        Me.SplitContainerCSX_DX.Panel2.Controls.Add(Me.PanelDettagliFilm)
        Me.SplitContainerCSX_DX.Panel2.Controls.Add(Me.PanelDettagliCategoria)
        Me.SplitContainerCSX_DX.Size = New System.Drawing.Size(1214, 743)
        Me.SplitContainerCSX_DX.SplitterDistance = 559
        Me.SplitContainerCSX_DX.SplitterIncrement = 10
        Me.SplitContainerCSX_DX.TabIndex = 1
        '
        'SplitContainerBarreStrumenti_CSX
        '
        Me.SplitContainerBarreStrumenti_CSX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerBarreStrumenti_CSX.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainerBarreStrumenti_CSX.IsSplitterFixed = True
        Me.SplitContainerBarreStrumenti_CSX.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerBarreStrumenti_CSX.Name = "SplitContainerBarreStrumenti_CSX"
        Me.SplitContainerBarreStrumenti_CSX.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerBarreStrumenti_CSX.Panel1
        '
        Me.SplitContainerBarreStrumenti_CSX.Panel1.Controls.Add(Me.BarraStrumentiPrincipale)
        '
        'SplitContainerBarreStrumenti_CSX.Panel2
        '
        Me.SplitContainerBarreStrumenti_CSX.Panel2.Controls.Add(Me.SplitContainerSX_C)
        Me.SplitContainerBarreStrumenti_CSX.Size = New System.Drawing.Size(559, 743)
        Me.SplitContainerBarreStrumenti_CSX.SplitterDistance = 59
        Me.SplitContainerBarreStrumenti_CSX.SplitterWidth = 1
        Me.SplitContainerBarreStrumenti_CSX.TabIndex = 2
        '
        'PanelDettagliCategoria
        '
        Me.PanelDettagliCategoria.AutoScroll = True
        Me.PanelDettagliCategoria.Controls.Add(Me.ValutazioniCat)
        Me.PanelDettagliCategoria.Controls.Add(Me.FlowLayoutPanel3)
        Me.PanelDettagliCategoria.Controls.Add(Me.PicImgPersona)
        Me.PanelDettagliCategoria.Controls.Add(Me.LabValoreCategoriaScelta)
        Me.PanelDettagliCategoria.Controls.Add(Me.LabCategoriaScelta)
        Me.PanelDettagliCategoria.Controls.Add(Me.IconaCategoriaScelta)
        Me.PanelDettagliCategoria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDettagliCategoria.Location = New System.Drawing.Point(0, 0)
        Me.PanelDettagliCategoria.Name = "PanelDettagliCategoria"
        Me.PanelDettagliCategoria.Size = New System.Drawing.Size(651, 743)
        Me.PanelDettagliCategoria.TabIndex = 93
        '
        'ValutazioniCat
        '
        Me.ValutazioniCat.AutoSize = True
        Me.ValutazioniCat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ValutazioniCat.Controls.Add(Me.FlowLayoutPanel5)
        Me.ValutazioniCat.Controls.Add(Me.Label88)
        Me.ValutazioniCat.Dock = System.Windows.Forms.DockStyle.Top
        Me.ValutazioniCat.Location = New System.Drawing.Point(0, 642)
        Me.ValutazioniCat.Name = "ValutazioniCat"
        Me.ValutazioniCat.Size = New System.Drawing.Size(630, 162)
        Me.ValutazioniCat.TabIndex = 104
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.AutoSize = True
        Me.FlowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel5.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel5.Controls.Add(Me.Panel15)
        Me.FlowLayoutPanel5.Controls.Add(Me.Panel16)
        Me.FlowLayoutPanel5.Controls.Add(Me.Panel17)
        Me.FlowLayoutPanel5.Controls.Add(Me.Label67)
        Me.FlowLayoutPanel5.Controls.Add(Me.Panel18)
        Me.FlowLayoutPanel5.Controls.Add(Me.Panel19)
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(0, 32)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(497, 127)
        Me.FlowLayoutPanel5.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 120)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Pubblico"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel15.Controls.Add(Me.Label2)
        Me.Panel15.Controls.Add(Me.VotoIMDBCat)
        Me.Panel15.Controls.Add(Me.Label52)
        Me.Panel15.Location = New System.Drawing.Point(34, 3)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(75, 120)
        Me.Panel15.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "/ 10"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VotoIMDBCat
        '
        Me.VotoIMDBCat.Dock = System.Windows.Forms.DockStyle.Top
        Me.VotoIMDBCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VotoIMDBCat.Location = New System.Drawing.Point(0, 40)
        Me.VotoIMDBCat.Name = "VotoIMDBCat"
        Me.VotoIMDBCat.Size = New System.Drawing.Size(73, 45)
        Me.VotoIMDBCat.TabIndex = 1
        Me.VotoIMDBCat.Text = "0.0"
        Me.VotoIMDBCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label52
        '
        Me.Label52.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(0, 0)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(73, 40)
        Me.Label52.TabIndex = 0
        Me.Label52.Text = "IMDB"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel16.Controls.Add(Me.Label54)
        Me.Panel16.Controls.Add(Me.NumVotiIMDBCat)
        Me.Panel16.Controls.Add(Me.Label58)
        Me.Panel16.Location = New System.Drawing.Point(115, 3)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(80, 120)
        Me.Panel16.TabIndex = 53
        '
        'Label54
        '
        Me.Label54.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(0, 85)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(78, 35)
        Me.Label54.TabIndex = 4
        Me.Label54.Text = "kk"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumVotiIMDBCat
        '
        Me.NumVotiIMDBCat.Dock = System.Windows.Forms.DockStyle.Top
        Me.NumVotiIMDBCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumVotiIMDBCat.Location = New System.Drawing.Point(0, 40)
        Me.NumVotiIMDBCat.Name = "NumVotiIMDBCat"
        Me.NumVotiIMDBCat.Size = New System.Drawing.Size(78, 45)
        Me.NumVotiIMDBCat.TabIndex = 1
        Me.NumVotiIMDBCat.Text = "000"
        Me.NumVotiIMDBCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label58
        '
        Me.Label58.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(0, 0)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(78, 40)
        Me.Label58.TabIndex = 0
        Me.Label58.Text = "Num voti" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "IMDB"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel17.Controls.Add(Me.Label63)
        Me.Panel17.Controls.Add(Me.Label64)
        Me.Panel17.Controls.Add(Me.IncassiCat)
        Me.Panel17.Controls.Add(Me.Label66)
        Me.Panel17.Location = New System.Drawing.Point(201, 3)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(80, 120)
        Me.Panel17.TabIndex = 54
        '
        'Label63
        '
        Me.Label63.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(0, 95)
        Me.Label63.Margin = New System.Windows.Forms.Padding(0)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(78, 20)
        Me.Label63.TabIndex = 6
        Me.Label63.Text = "$"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label64
        '
        Me.Label64.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(0, 65)
        Me.Label64.Margin = New System.Windows.Forms.Padding(0)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(78, 30)
        Me.Label64.TabIndex = 5
        Me.Label64.Text = "mml"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IncassiCat
        '
        Me.IncassiCat.Dock = System.Windows.Forms.DockStyle.Top
        Me.IncassiCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncassiCat.Location = New System.Drawing.Point(0, 20)
        Me.IncassiCat.Name = "IncassiCat"
        Me.IncassiCat.Size = New System.Drawing.Size(78, 45)
        Me.IncassiCat.TabIndex = 1
        Me.IncassiCat.Text = "000"
        Me.IncassiCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label66
        '
        Me.Label66.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(0, 0)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(78, 20)
        Me.Label66.TabIndex = 0
        Me.Label66.Text = "Incassi"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label67
        '
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(287, 0)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(25, 121)
        Me.Label67.TabIndex = 50
        Me.Label67.Text = "Critica"
        Me.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel18.Controls.Add(Me.Label68)
        Me.Panel18.Controls.Add(Me.VotoMetacriticCat)
        Me.Panel18.Controls.Add(Me.Label70)
        Me.Panel18.Location = New System.Drawing.Point(318, 3)
        Me.Panel18.MinimumSize = New System.Drawing.Size(2, 95)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(85, 121)
        Me.Panel18.TabIndex = 51
        '
        'Label68
        '
        Me.Label68.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(0, 85)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(83, 17)
        Me.Label68.TabIndex = 2
        Me.Label68.Text = "/ 100"
        Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VotoMetacriticCat
        '
        Me.VotoMetacriticCat.Dock = System.Windows.Forms.DockStyle.Top
        Me.VotoMetacriticCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VotoMetacriticCat.Location = New System.Drawing.Point(0, 40)
        Me.VotoMetacriticCat.Name = "VotoMetacriticCat"
        Me.VotoMetacriticCat.Size = New System.Drawing.Size(83, 45)
        Me.VotoMetacriticCat.TabIndex = 1
        Me.VotoMetacriticCat.Text = "001"
        Me.VotoMetacriticCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label70
        '
        Me.Label70.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(0, 0)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(83, 40)
        Me.Label70.TabIndex = 0
        Me.Label70.Text = "Metacritic"
        Me.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel19.Controls.Add(Me.Label71)
        Me.Panel19.Controls.Add(Me.RottenCat)
        Me.Panel19.Controls.Add(Me.Label73)
        Me.Panel19.Location = New System.Drawing.Point(409, 3)
        Me.Panel19.MinimumSize = New System.Drawing.Size(2, 95)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(85, 121)
        Me.Panel19.TabIndex = 52
        '
        'Label71
        '
        Me.Label71.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label71.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(0, 80)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(83, 17)
        Me.Label71.TabIndex = 3
        Me.Label71.Text = "%"
        Me.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RottenCat
        '
        Me.RottenCat.Dock = System.Windows.Forms.DockStyle.Top
        Me.RottenCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RottenCat.Location = New System.Drawing.Point(0, 40)
        Me.RottenCat.Name = "RottenCat"
        Me.RottenCat.Size = New System.Drawing.Size(83, 40)
        Me.RottenCat.TabIndex = 1
        Me.RottenCat.Text = "001"
        Me.RottenCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label73
        '
        Me.Label73.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(0, 0)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(83, 40)
        Me.Label73.TabIndex = 0
        Me.Label73.Text = "Rotten Tomatoes"
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label88
        '
        Me.Label88.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label88.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label88.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label88.Location = New System.Drawing.Point(0, 0)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(630, 32)
        Me.Label88.TabIndex = 38
        Me.Label88.Text = "Media valutazioni"
        Me.Label88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoSize = True
        Me.FlowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel3.Controls.Add(Me.ButtRicercaPersonaIMDB)
        Me.FlowLayoutPanel3.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel3.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel3.Controls.Add(Me.ButCambiaImgPersona)
        Me.FlowLayoutPanel3.Controls.Add(Me.PanNumeroFilm)
        Me.FlowLayoutPanel3.Controls.Add(Me.PanDurataTotale)
        Me.FlowLayoutPanel3.Controls.Add(Me.PanPeriodoAttività)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 520)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(630, 122)
        Me.FlowLayoutPanel3.TabIndex = 30
        '
        'ButtRicercaPersonaIMDB
        '
        Me.ButtRicercaPersonaIMDB.Location = New System.Drawing.Point(3, 3)
        Me.ButtRicercaPersonaIMDB.Name = "ButtRicercaPersonaIMDB"
        Me.ButtRicercaPersonaIMDB.Size = New System.Drawing.Size(80, 26)
        Me.ButtRicercaPersonaIMDB.TabIndex = 9
        Me.ButtRicercaPersonaIMDB.Text = "IMDB"
        Me.ButtRicercaPersonaIMDB.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(89, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 26)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Wikipedia IT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(210, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 26)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Wikipedia EN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ButCambiaImgPersona
        '
        Me.ButCambiaImgPersona.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel3.SetFlowBreak(Me.ButCambiaImgPersona, True)
        Me.ButCambiaImgPersona.Location = New System.Drawing.Point(331, 3)
        Me.ButCambiaImgPersona.Name = "ButCambiaImgPersona"
        Me.ButCambiaImgPersona.Size = New System.Drawing.Size(147, 26)
        Me.ButCambiaImgPersona.TabIndex = 4
        Me.ButCambiaImgPersona.Text = "Cambia immagine"
        Me.ButCambiaImgPersona.UseVisualStyleBackColor = True
        '
        'PanNumeroFilm
        '
        Me.PanNumeroFilm.AutoSize = True
        Me.PanNumeroFilm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanNumeroFilm.Controls.Add(Me.Label18)
        Me.PanNumeroFilm.Controls.Add(Me.LabConteggioCategoriaScelta)
        Me.FlowLayoutPanel3.SetFlowBreak(Me.PanNumeroFilm, True)
        Me.PanNumeroFilm.Location = New System.Drawing.Point(20, 35)
        Me.PanNumeroFilm.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.PanNumeroFilm.Name = "PanNumeroFilm"
        Me.PanNumeroFilm.Size = New System.Drawing.Size(151, 24)
        Me.PanNumeroFilm.TabIndex = 11
        '
        'Label18
        '
        Me.Label18.AutoEllipsis = True
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(3, 0)
        Me.Label18.MinimumSize = New System.Drawing.Size(0, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(105, 24)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Numero film:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabConteggioCategoriaScelta
        '
        Me.LabConteggioCategoriaScelta.AutoSize = True
        Me.LabConteggioCategoriaScelta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabConteggioCategoriaScelta.Location = New System.Drawing.Point(114, 0)
        Me.LabConteggioCategoriaScelta.Name = "LabConteggioCategoriaScelta"
        Me.LabConteggioCategoriaScelta.Size = New System.Drawing.Size(34, 22)
        Me.LabConteggioCategoriaScelta.TabIndex = 4
        Me.LabConteggioCategoriaScelta.Text = "XX"
        Me.LabConteggioCategoriaScelta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanDurataTotale
        '
        Me.PanDurataTotale.AutoSize = True
        Me.PanDurataTotale.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanDurataTotale.Controls.Add(Me.Label50)
        Me.PanDurataTotale.Controls.Add(Me.LabDurataCat)
        Me.FlowLayoutPanel3.SetFlowBreak(Me.PanDurataTotale, True)
        Me.PanDurataTotale.Location = New System.Drawing.Point(20, 65)
        Me.PanDurataTotale.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.PanDurataTotale.Name = "PanDurataTotale"
        Me.PanDurataTotale.Size = New System.Drawing.Size(194, 24)
        Me.PanDurataTotale.TabIndex = 12
        '
        'Label50
        '
        Me.Label50.AutoEllipsis = True
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(3, 0)
        Me.Label50.MinimumSize = New System.Drawing.Size(0, 24)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(111, 24)
        Me.Label50.TabIndex = 7
        Me.Label50.Text = "Durata totale:"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabDurataCat
        '
        Me.LabDurataCat.AutoSize = True
        Me.LabDurataCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabDurataCat.Location = New System.Drawing.Point(120, 0)
        Me.LabDurataCat.Name = "LabDurataCat"
        Me.LabDurataCat.Size = New System.Drawing.Size(71, 22)
        Me.LabDurataCat.TabIndex = 6
        Me.LabDurataCat.Text = "123 ore"
        Me.LabDurataCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanPeriodoAttività
        '
        Me.PanPeriodoAttività.AutoSize = True
        Me.PanPeriodoAttività.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanPeriodoAttività.Controls.Add(Me.Label12)
        Me.PanPeriodoAttività.Controls.Add(Me.Label13)
        Me.PanPeriodoAttività.Location = New System.Drawing.Point(20, 95)
        Me.PanPeriodoAttività.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.PanPeriodoAttività.Name = "PanPeriodoAttività"
        Me.PanPeriodoAttività.Size = New System.Drawing.Size(314, 24)
        Me.PanPeriodoAttività.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoEllipsis = True
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 0)
        Me.Label12.MinimumSize = New System.Drawing.Size(0, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(196, 24)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Periodo di pubblicazione:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(205, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 22)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "1348 - 1815"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicImgPersona
        '
        Me.PicImgPersona.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicImgPersona.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicImgPersona.Location = New System.Drawing.Point(0, 220)
        Me.PicImgPersona.MaximumSize = New System.Drawing.Size(0, 300)
        Me.PicImgPersona.Name = "PicImgPersona"
        Me.PicImgPersona.Size = New System.Drawing.Size(630, 300)
        Me.PicImgPersona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicImgPersona.TabIndex = 29
        Me.PicImgPersona.TabStop = False
        '
        'LabValoreCategoriaScelta
        '
        Me.LabValoreCategoriaScelta.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabValoreCategoriaScelta.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabValoreCategoriaScelta.Location = New System.Drawing.Point(0, 140)
        Me.LabValoreCategoriaScelta.Name = "LabValoreCategoriaScelta"
        Me.LabValoreCategoriaScelta.Size = New System.Drawing.Size(630, 80)
        Me.LabValoreCategoriaScelta.TabIndex = 27
        Me.LabValoreCategoriaScelta.Text = "Nome cat"
        Me.LabValoreCategoriaScelta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabCategoriaScelta
        '
        Me.LabCategoriaScelta.AutoEllipsis = True
        Me.LabCategoriaScelta.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabCategoriaScelta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabCategoriaScelta.Location = New System.Drawing.Point(0, 100)
        Me.LabCategoriaScelta.Margin = New System.Windows.Forms.Padding(0)
        Me.LabCategoriaScelta.MinimumSize = New System.Drawing.Size(0, 40)
        Me.LabCategoriaScelta.Name = "LabCategoriaScelta"
        Me.LabCategoriaScelta.Size = New System.Drawing.Size(630, 40)
        Me.LabCategoriaScelta.TabIndex = 26
        Me.LabCategoriaScelta.Text = "Film del regista"
        Me.LabCategoriaScelta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IconaCategoriaScelta
        '
        Me.IconaCategoriaScelta.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconaCategoriaScelta.Location = New System.Drawing.Point(0, 0)
        Me.IconaCategoriaScelta.Margin = New System.Windows.Forms.Padding(0)
        Me.IconaCategoriaScelta.Name = "IconaCategoriaScelta"
        Me.IconaCategoriaScelta.Size = New System.Drawing.Size(630, 100)
        Me.IconaCategoriaScelta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconaCategoriaScelta.TabIndex = 19
        Me.IconaCategoriaScelta.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 743)
        Me.Controls.Add(Me.SplitContainerCSX_DX)
        Me.Location = New System.Drawing.Point(0, 19)
        Me.MinimumSize = New System.Drawing.Size(250, 150)
        Me.Name = "MainForm"
        Me.Text = "Gestore Libreria Film"
        Me.BarraStrumentiPrincipale.ResumeLayout(False)
        Me.BarraStrumentiPrincipale.PerformLayout()
        Me.SplitContainerFiltriAvanzati_Icone.Panel1.ResumeLayout(False)
        Me.SplitContainerFiltriAvanzati_Icone.Panel1.PerformLayout()
        Me.SplitContainerFiltriAvanzati_Icone.Panel2.ResumeLayout(False)
        Me.SplitContainerFiltriAvanzati_Icone.Panel2.PerformLayout()
        CType(Me.SplitContainerFiltriAvanzati_Icone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerFiltriAvanzati_Icone.ResumeLayout(False)
        Me.SchedeFiltriAvanzati.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.FlowLayoutPanel9.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.FiltroDurataMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FiltroDurataMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.FiltroAnnoMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FiltroAnnoMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.FlowLayoutPanel8.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        CType(Me.FiltroBitrateMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.FiltroRisoluzioneMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.FiltroMinVotoRotten, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.FiltroMinVotoMetacritic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.FiltroMinIncasso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.FiltroMinNumVotiIMDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.FiltroMinVotoIMDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.StatusEsecuzioneBackground.ResumeLayout(False)
        Me.StatusEsecuzioneBackground.PerformLayout()
        Me.PannelloFiltri.ResumeLayout(False)
        Me.PannelloFiltri.PerformLayout()
        Me.PannelloFiltriSemplici.ResumeLayout(False)
        Me.PannelloFiltriSemplici.PerformLayout()
        Me.PannelloEsitoFiltri.ResumeLayout(False)
        Me.PannelloEsitoFiltri.PerformLayout()
        Me.PanelDettagliFilm.ResumeLayout(False)
        Me.PanelDettagliFilm.PerformLayout()
        Me.PannelloExtra.ResumeLayout(False)
        Me.PanelFile.ResumeLayout(False)
        Me.SplitAudioSottotitoli.Panel1.ResumeLayout(False)
        Me.SplitAudioSottotitoli.Panel2.ResumeLayout(False)
        CType(Me.SplitAudioSottotitoli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitAudioSottotitoli.ResumeLayout(False)
        Me.PannelloAudio.ResumeLayout(False)
        Me.IntestazioneAudio.ResumeLayout(False)
        Me.IntestazioneAudio.PerformLayout()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PannelloSottotitoli.ResumeLayout(False)
        Me.IntestazioneSottotitoli.ResumeLayout(False)
        Me.IntestazioneSottotitoli.PerformLayout()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PannelloVideo.ResumeLayout(False)
        Me.FlowLayoutPanel7.ResumeLayout(False)
        Me.FlowLayoutPanel7.PerformLayout()
        Me.PannelloRisoluzione.ResumeLayout(False)
        Me.PannelloRisoluzione.PerformLayout()
        Me.BadgeRisoluzione.ResumeLayout(False)
        Me.BadgeRisoluzione.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PannelloCodecVideo.ResumeLayout(False)
        Me.PannelloCodecVideo.PerformLayout()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PannelloBitrateVideo.ResumeLayout(False)
        Me.PannelloBitrateVideo.PerformLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PannelloProporzioni.ResumeLayout(False)
        Me.PannelloProporzioni.PerformLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PannelloFPS.ResumeLayout(False)
        Me.PannelloFPS.PerformLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IntestazioneVideo.ResumeLayout(False)
        Me.IntestazioneVideo.PerformLayout()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PannelloContenitore.ResumeLayout(False)
        Me.PannelloContenitore.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.PanBitrateFile.ResumeLayout(False)
        Me.PanBitrateFile.PerformLayout()
        Me.IntestazioneContenitore.ResumeLayout(False)
        Me.IntestazioneContenitore.PerformLayout()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelValutazioni.ResumeLayout(False)
        Me.PanelValutazioni.PerformLayout()
        Me.PanComtenutoValutazioni.ResumeLayout(False)
        Me.PanVotoIMDB.ResumeLayout(False)
        Me.PanNumVotiIMDB.ResumeLayout(False)
        Me.PanIncassi.ResumeLayout(False)
        Me.PanMetacritic.ResumeLayout(False)
        Me.PanRotten.ResumeLayout(False)
        Me.PanPremiVinti.ResumeLayout(False)
        Me.PanAltriVinti.ResumeLayout(False)
        Me.PanAltriVinti.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanBAFTAVinti.ResumeLayout(False)
        Me.PanBAFTAVinti.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanOscarVinti.ResumeLayout(False)
        Me.PanOscarVinti.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanPremiNominati.ResumeLayout(False)
        Me.PanAltriNominati.ResumeLayout(False)
        Me.PanAltriNominati.PerformLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanBAFTANominati.ResumeLayout(False)
        Me.PanBAFTANominati.PerformLayout()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanOscarNominati.ResumeLayout(False)
        Me.PanOscarNominati.PerformLayout()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PannelloTrama.ResumeLayout(False)
        Me.PannelloTrama.PerformLayout()
        Me.PannelloAttori.ResumeLayout(False)
        Me.PannelloGeneri.ResumeLayout(False)
        Me.SplitPosterInfoPrincipali.Panel1.ResumeLayout(False)
        Me.SplitPosterInfoPrincipali.Panel2.ResumeLayout(False)
        Me.SplitPosterInfoPrincipali.Panel2.PerformLayout()
        CType(Me.SplitPosterInfoPrincipali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitPosterInfoPrincipali.ResumeLayout(False)
        CType(Me.PicPoster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel6.ResumeLayout(False)
        Me.FlowLayoutPanel6.PerformLayout()
        Me.PanelNote.ResumeLayout(False)
        Me.PanelNote.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelToggleImg.ResumeLayout(False)
        Me.PanelAnno.ResumeLayout(False)
        Me.PanelAnno.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PannelloNazione.ResumeLayout(False)
        Me.PannelloNazione.PerformLayout()
        CType(Me.NazionePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDurata.ResumeLayout(False)
        Me.PanelDurata.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRegisti.ResumeLayout(False)
        Me.PanelRegisti.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAutori.ResumeLayout(False)
        Me.PanelAutori.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMusicisti.ResumeLayout(False)
        Me.PanelMusicisti.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSchermata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraStrumentiFilm.ResumeLayout(False)
        Me.BarraStrumentiFilm.PerformLayout()
        Me.SplitContainerSX_C.Panel1.ResumeLayout(False)
        Me.SplitContainerSX_C.Panel1.PerformLayout()
        Me.SplitContainerSX_C.Panel2.ResumeLayout(False)
        Me.SplitContainerSX_C.Panel2.PerformLayout()
        CType(Me.SplitContainerSX_C, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerSX_C.ResumeLayout(False)
        Me.ToolStripCategorie.ResumeLayout(False)
        Me.ToolStripCategorie.PerformLayout()
        CType(Me.FileSystemWatcher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerCSX_DX.Panel1.ResumeLayout(False)
        Me.SplitContainerCSX_DX.Panel2.ResumeLayout(False)
        Me.SplitContainerCSX_DX.Panel2.PerformLayout()
        CType(Me.SplitContainerCSX_DX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerCSX_DX.ResumeLayout(False)
        Me.SplitContainerBarreStrumenti_CSX.Panel1.ResumeLayout(False)
        Me.SplitContainerBarreStrumenti_CSX.Panel1.PerformLayout()
        Me.SplitContainerBarreStrumenti_CSX.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerBarreStrumenti_CSX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerBarreStrumenti_CSX.ResumeLayout(False)
        Me.PanelDettagliCategoria.ResumeLayout(False)
        Me.PanelDettagliCategoria.PerformLayout()
        Me.ValutazioniCat.ResumeLayout(False)
        Me.ValutazioniCat.PerformLayout()
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.PanNumeroFilm.ResumeLayout(False)
        Me.PanNumeroFilm.PerformLayout()
        Me.PanDurataTotale.ResumeLayout(False)
        Me.PanDurataTotale.PerformLayout()
        Me.PanPeriodoAttività.ResumeLayout(False)
        Me.PanPeriodoAttività.PerformLayout()
        CType(Me.PicImgPersona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconaCategoriaScelta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarraStrumentiPrincipale As System.Windows.Forms.ToolStrip
    Friend WithEvents ButtTogglePannelloSx As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtTogglePannelloDx As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtFilmCasuale As System.Windows.Forms.ToolStripButton
    Friend WithEvents SottoMenuVisualizzazioneIcone As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents IconeCategorieLibreria As System.Windows.Forms.ImageList
    Friend WithEvents ElencoFilm As System.Windows.Forms.ListView
    Friend WithEvents ColAnno As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColNazione As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColTitolo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColRegisti As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColGeneri As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColAttori As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColAutori As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColMusicisti As System.Windows.Forms.ColumnHeader
    Friend WithEvents AlberoCategorieLibreria As System.Windows.Forms.TreeView
    Friend WithEvents SplitContainerSX_C As System.Windows.Forms.SplitContainer
    Friend WithEvents FileSystemWatcher As System.IO.FileSystemWatcher
    Friend WithEvents SchermateFilmPiccole As System.Windows.Forms.ImageList
    Friend WithEvents SchermateFilmGrandi As System.Windows.Forms.ImageList
    Friend WithEvents BarraStrumentiFilm As System.Windows.Forms.ToolStrip
    Friend WithEvents PlayButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EsploraRisorseButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents RinominaButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DownloadButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CercaInternetButton As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents GoogleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WikiITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IMDBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SottoMenuOrdineIcone As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents TitoloItalianoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NazioneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DurataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DiscendenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PannelloFiltri As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FiltroAnnoMax As System.Windows.Forms.TrackBar
    Friend WithEvents FiltroAnnoMin As System.Windows.Forms.TrackBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SplitContainerFiltriAvanzati_Icone As System.Windows.Forms.SplitContainer
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents FiltroDurataMin As System.Windows.Forms.TrackBar
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents FiltroDurataMax As System.Windows.Forms.TrackBar
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TitoloItalianoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnnoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NazioneToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DurataToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents DefinizioneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BitrateToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DefinizioneToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BitrateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FiltroRisoluzioneMin As System.Windows.Forms.TrackBar
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents FiltroBitrateMin As System.Windows.Forms.TrackBar
    Friend WithEvents PicSchermata As System.Windows.Forms.PictureBox
    Friend WithEvents PanelDettagliFilm As System.Windows.Forms.Panel
    Friend WithEvents PosterFilmPiccoli As System.Windows.Forms.ImageList
    Friend WithEvents PosterFilmGrandi As System.Windows.Forms.ImageList
    Friend WithEvents SplitContainerCSX_DX As System.Windows.Forms.SplitContainer
    Friend WithEvents ButtPannelloSchermata As System.Windows.Forms.Button
    Friend WithEvents PerValutazioneIMDBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerNumeroVotiIMDBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerValutazioneMetacriticToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerValutazioneRottenTomatoesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerIncassiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerOscarVintiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerOscarvintiNominatiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerPremiVintiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerPremiNominatiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainerBarreStrumenti_CSX As System.Windows.Forms.SplitContainer
    Friend WithEvents PanelDettagliCategoria As System.Windows.Forms.Panel
    Friend WithEvents IconaCategoriaScelta As System.Windows.Forms.PictureBox
    Friend WithEvents LabValoreCategoriaScelta As System.Windows.Forms.Label
    Friend WithEvents LabCategoriaScelta As System.Windows.Forms.Label
    Friend WithEvents SchedeFiltriAvanzati As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents FiltroMinVotoRotten As System.Windows.Forms.TrackBar
    Friend WithEvents LabMinVotoRotten As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents FiltroMinVotoMetacritic As System.Windows.Forms.TrackBar
    Friend WithEvents LabMinVotoMetacritic As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents FiltroMinIncasso As System.Windows.Forms.TrackBar
    Friend WithEvents LabMinIncasso As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents FiltroMinNumVotiIMDB As System.Windows.Forms.TrackBar
    Friend WithEvents LabMinNumVotiIMDB As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents FiltroMinVotoIMDB As System.Windows.Forms.TrackBar
    Friend WithEvents LabMinVotoIMDB As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ButtRicercaPersonaIMDB As System.Windows.Forms.Button
    Friend WithEvents ButCambiaImgPersona As System.Windows.Forms.Button
    Friend WithEvents PanNumeroFilm As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents LabConteggioCategoriaScelta As System.Windows.Forms.Label
    Friend WithEvents PanDurataTotale As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents LabDurataCat As System.Windows.Forms.Label
    Friend WithEvents PanPeriodoAttività As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PicImgPersona As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents BottFiltra As System.Windows.Forms.Button
    Friend WithEvents SottoMenuImpostazioni As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ScegliLibreriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TemaColoriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TemaWindowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TemaChiaroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TemaScuroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImpostazioniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ControllaAggiornamentiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreditiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlaceholderCasellaRicerca As System.Windows.Forms.Label
    Friend WithEvents CasellaRicerca As System.Windows.Forms.TextBox
    Friend WithEvents BottMostraFiltri As System.Windows.Forms.Button
    Friend WithEvents BottCerca As System.Windows.Forms.Button
    Friend WithEvents PannelloEsitoFiltri As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents LabEsitoFiltri As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BottCancellaFiltri As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel8 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents PannelloExtra As System.Windows.Forms.Panel
    Friend WithEvents ButtAddExtra As System.Windows.Forms.Button
    Friend WithEvents ListaExtra As System.Windows.Forms.ListBox
    Friend WithEvents IntestazioneExtra As System.Windows.Forms.Label
    Friend WithEvents PanelFile As System.Windows.Forms.Panel
    Friend WithEvents PannelloAudio As System.Windows.Forms.Panel
    Friend WithEvents RTFAudio As System.Windows.Forms.RichTextBox
    Friend WithEvents IntestazioneAudio As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PictureBox20 As System.Windows.Forms.PictureBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents PannelloSottotitoli As System.Windows.Forms.Panel
    Friend WithEvents RTFSottotitoli As System.Windows.Forms.RichTextBox
    Friend WithEvents IntestazioneSottotitoli As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PictureBox21 As System.Windows.Forms.PictureBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents PannelloVideo As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel7 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PannelloRisoluzione As System.Windows.Forms.Panel
    Friend WithEvents BadgeRisoluzione As System.Windows.Forms.Panel
    Friend WithEvents LabAltezzaRisoluzione As System.Windows.Forms.Label
    Friend WithEvents LabTipoRisoluzione As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PannelloCodecVideo As System.Windows.Forms.Panel
    Friend WithEvents LabCodecVideo As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents PictureBox15 As System.Windows.Forms.PictureBox
    Friend WithEvents PannelloBitrateVideo As System.Windows.Forms.Panel
    Friend WithEvents LabBitrateVideo As System.Windows.Forms.Label
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox
    Friend WithEvents PannelloProporzioni As System.Windows.Forms.Panel
    Friend WithEvents LabProporzioni As System.Windows.Forms.Label
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents PannelloFPS As System.Windows.Forms.Panel
    Friend WithEvents LabFPS As System.Windows.Forms.Label
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents IntestazioneVideo As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PictureBox19 As System.Windows.Forms.PictureBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents PannelloContenitore As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents LabEstensione As System.Windows.Forms.Label
    Friend WithEvents LabCodecFile As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents LabDimensioneFile As System.Windows.Forms.Label
    Friend WithEvents PanBitrateFile As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents LabBitrateFile As System.Windows.Forms.Label
    Friend WithEvents IntestazioneContenitore As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PictureBox18 As System.Windows.Forms.PictureBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents IntestazioneFile As System.Windows.Forms.Label
    Friend WithEvents PanelValutazioni As System.Windows.Forms.Panel
    Friend WithEvents PanComtenutoValutazioni As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents PanVotoIMDB As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LabVotoIMDB As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents PanNumVotiIMDB As System.Windows.Forms.Panel
    Friend WithEvents LabMoltiplicatoreNumVotiIMDB As System.Windows.Forms.Label
    Friend WithEvents LabNumVotiIMDB As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents PanIncassi As System.Windows.Forms.Panel
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents LabMoltiplicatoreIncassi As System.Windows.Forms.Label
    Friend WithEvents LabIncassi As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents PanMetacritic As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LabMetacritic As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PanRotten As System.Windows.Forms.Panel
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents LabRotten As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents PanPremiVinti As System.Windows.Forms.Panel
    Friend WithEvents PanAltriVinti As System.Windows.Forms.Panel
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents LabAltriVinti As System.Windows.Forms.Label
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents PanBAFTAVinti As System.Windows.Forms.Panel
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents LabBAFTAVinti As System.Windows.Forms.Label
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PanOscarVinti As System.Windows.Forms.Panel
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents LabOscarVinti As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents PanPremiNominati As System.Windows.Forms.Panel
    Friend WithEvents PanAltriNominati As System.Windows.Forms.Panel
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents LabAltriNominati As System.Windows.Forms.Label
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents PanBAFTANominati As System.Windows.Forms.Panel
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents LabBAFTANominati As System.Windows.Forms.Label
    Friend WithEvents PictureBox16 As System.Windows.Forms.PictureBox
    Friend WithEvents PanOscarNominati As System.Windows.Forms.Panel
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents LabOscarNominati As System.Windows.Forms.Label
    Friend WithEvents PictureBox17 As System.Windows.Forms.PictureBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents IntestazioneValutazioni As System.Windows.Forms.Label
    Friend WithEvents PannelloTrama As System.Windows.Forms.Panel
    Friend WithEvents LabTramaBreve As System.Windows.Forms.Label
    Friend WithEvents TextTramaLunga As System.Windows.Forms.TextBox
    Friend WithEvents ButtonToggleTrama As System.Windows.Forms.Button
    Friend WithEvents IntestazioneTrama As System.Windows.Forms.Label
    Friend WithEvents PannelloAttori As System.Windows.Forms.Panel
    Friend WithEvents ListaAttori As System.Windows.Forms.ListView
    Friend WithEvents IntestazioneAttori As System.Windows.Forms.Label
    Friend WithEvents PannelloGeneri As System.Windows.Forms.Panel
    Friend WithEvents ListaGeneri As System.Windows.Forms.ListView
    Friend WithEvents IntestazioneGeneri As System.Windows.Forms.Label
    Friend WithEvents SplitPosterInfoPrincipali As System.Windows.Forms.SplitContainer
    Friend WithEvents PicPoster As System.Windows.Forms.PictureBox
    Friend WithEvents FlowLayoutPanel6 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents LabTitoloITA As System.Windows.Forms.Label
    Friend WithEvents LabTitoloORIG As System.Windows.Forms.Label
    Friend WithEvents PanelNote As System.Windows.Forms.Panel
    Friend WithEvents LabNote As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelAnno As System.Windows.Forms.Panel
    Friend WithEvents LabAnno As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PannelloNazione As System.Windows.Forms.Panel
    Friend WithEvents NazionePic As System.Windows.Forms.PictureBox
    Friend WithEvents NazioneLab As System.Windows.Forms.Label
    Friend WithEvents PanelDurata As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents LabDurata As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents LabFineVisione As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PanelRegisti As System.Windows.Forms.Panel
    Friend WithEvents LabRegisti As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelAutori As System.Windows.Forms.Panel
    Friend WithEvents LabAutori As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelMusicisti As System.Windows.Forms.Panel
    Friend WithEvents LabMusicisti As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelToggleImg As System.Windows.Forms.Panel
    Friend WithEvents ButtTogglePoster As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SplitAudioSottotitoli As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripCategorie As System.Windows.Forms.ToolStrip
    Friend WithEvents DropDownOrdinamentoCategorie As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents EpocaDiAttivitàultimaUscitaPiùRemotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EpocaDiAttivitàultimaUscitaPiùRecenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlfabeticoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DurataFilmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NumeroFilmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DropDownInfoCategoria As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents NessunaInformazioneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PeriodoDiAttivitàToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DurataFilmToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConteggioFilmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton5 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents InizialeCognomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CognomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NomeCognomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CognomeNomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtCronoIndietro As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtCronoAvanti As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusEsecuzioneBackground As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents PannelloFiltriSemplici As System.Windows.Forms.Panel
    Friend WithEvents AggiornaLibreriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ValutazioniCat As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel5 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents VotoIMDBCat As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents NumVotiIMDBCat As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents IncassiCat As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents VotoMetacriticCat As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents RottenCat As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel9 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents FiltroNazioni As System.Windows.Forms.CheckedListBox
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents FiltroGeneri As System.Windows.Forms.CheckedListBox
    Friend WithEvents FiltroAudio As System.Windows.Forms.CheckedListBox
    Friend WithEvents FiltroSottotitoli As System.Windows.Forms.CheckedListBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents VisualizzazioneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColonneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IconePiccoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IconeGrandiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FonteIconeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SchermataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PosterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScegliCampiTestualeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScegliCampiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
