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
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1900s")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1910s")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1920s")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1930s")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1940s")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1950s")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1960s")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1970s")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1980s")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1990s")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2000s")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2010s")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2020s")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Anni", 5, 5, New System.Windows.Forms.TreeNode() {TreeNode18, TreeNode19, TreeNode20, TreeNode21, TreeNode22, TreeNode23, TreeNode24, TreeNode25, TreeNode26, TreeNode27, TreeNode28, TreeNode29, TreeNode30})
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nazioni", 6, 6)
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Autori", 7, 7)
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Musicisti", 8, 8)
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Temi", 9, 9)
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Antica Grecia")
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Antica Roma")
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Medioevo")
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cinquecento")
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Seicento")
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Settecento")
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ottocento")
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Prima guerra mondiale")
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Seconda guerra mondiale")
        Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Vietnam")
        Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Anni di piombo")
        Dim TreeNode47 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Novecento", New System.Windows.Forms.TreeNode() {TreeNode43, TreeNode44, TreeNode45, TreeNode46})
        Dim TreeNode48 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ambientazione", 10, 10, New System.Windows.Forms.TreeNode() {TreeNode36, TreeNode37, TreeNode38, TreeNode39, TreeNode40, TreeNode41, TreeNode42, TreeNode47})
        Me.BarraStrumentiPrincipale = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColonneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IconePiccoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IconeGrandiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PrimaRigaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TitoloITAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TitoloOriginaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecondaRigaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerzaRigaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripDropDownButton()
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
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SchermataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PosterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IconeCategorieLibreria = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainerC_DX = New System.Windows.Forms.SplitContainer()
        Me.SplitContainerFiltriAvanzati_Icone = New System.Windows.Forms.SplitContainer()
        Me.PannelloFiltriAvanzati = New System.Windows.Forms.Panel()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.FiltroBitrateMin = New System.Windows.Forms.TrackBar()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.FiltroRisoluzioneMin = New System.Windows.Forms.TrackBar()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FiltroGeneri = New System.Windows.Forms.CheckedListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FiltroNazioni = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FiltroAnnoMax = New System.Windows.Forms.TrackBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FiltroDurataMin = New System.Windows.Forms.TrackBar()
        Me.FiltroAnnoMin = New System.Windows.Forms.TrackBar()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FiltroDurataMax = New System.Windows.Forms.TrackBar()
        Me.BottFiltra = New System.Windows.Forms.Button()
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
        Me.PannelloNomeCategoria = New System.Windows.Forms.Panel()
        Me.LabValoreCategoriaScelta = New System.Windows.Forms.Label()
        Me.LabCategoriaScelta = New System.Windows.Forms.Label()
        Me.LabConteggioCategoriaScelta = New System.Windows.Forms.Label()
        Me.PicCategoriaScelta = New System.Windows.Forms.PictureBox()
        Me.PannelloFiltriSemplici = New System.Windows.Forms.Panel()
        Me.PlaceholderCasellaRicerca = New System.Windows.Forms.Label()
        Me.CasellaRicerca = New System.Windows.Forms.TextBox()
        Me.BottMostraFiltri = New System.Windows.Forms.Button()
        Me.BottCerca = New System.Windows.Forms.Button()
        Me.PannelloEsitoFiltri = New System.Windows.Forms.Panel()
        Me.BottCancellaFiltri = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LabEsitoFiltri = New System.Windows.Forms.Label()
        Me.ButtPannelloSchermata = New System.Windows.Forms.Button()
        Me.SplitImmagineDettagli = New System.Windows.Forms.SplitContainer()
        Me.SplitPosterSchermata = New System.Windows.Forms.SplitContainer()
        Me.PicPoster = New System.Windows.Forms.PictureBox()
        Me.PicSchermata = New System.Windows.Forms.PictureBox()
        Me.RiquadroDestraPanel = New System.Windows.Forms.Panel()
        Me.PanelFile = New System.Windows.Forms.Panel()
        Me.PannelloSottotitoli = New System.Windows.Forms.Panel()
        Me.RTFSottotitoli = New System.Windows.Forms.RichTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PannelloAudio = New System.Windows.Forms.Panel()
        Me.RTFAudio = New System.Windows.Forms.RichTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.RigaSottoAudio = New System.Windows.Forms.Panel()
        Me.PannelloVideo = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PannelloCodecVideo = New System.Windows.Forms.Panel()
        Me.LabCodecVideo = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PannelloRisoluzione = New System.Windows.Forms.Panel()
        Me.BadgeRisoluzione = New System.Windows.Forms.Panel()
        Me.LabAltezzaRisoluzione = New System.Windows.Forms.Label()
        Me.LabTipoRisoluzione = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PannelloFPS = New System.Windows.Forms.Panel()
        Me.LabFPS = New System.Windows.Forms.Label()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PannelloProporzioni = New System.Windows.Forms.Panel()
        Me.LabProporzioni = New System.Windows.Forms.Label()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PannelloBitrateVideo = New System.Windows.Forms.Panel()
        Me.LabBitrateVideo = New System.Windows.Forms.Label()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.RigaSottoVideo = New System.Windows.Forms.Panel()
        Me.PannelloContenitore = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.LabBitrateFile = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.LabDimensioneFile = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.LabCodecFile = New System.Windows.Forms.Label()
        Me.LabEstensione = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.RigaSottoFile = New System.Windows.Forms.Panel()
        Me.IntestazioneFile = New System.Windows.Forms.Label()
        Me.PanelValutazioni = New System.Windows.Forms.Panel()
        Me.PanValutazioniCritica = New System.Windows.Forms.Panel()
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
        Me.PanRotten = New System.Windows.Forms.Panel()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.LabRotten = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.PanMetacritic = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LabMetacritic = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.PanValutazioniPubblico = New System.Windows.Forms.Panel()
        Me.PanIncassi = New System.Windows.Forms.Panel()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.LabMoltiplicatoreIncassi = New System.Windows.Forms.Label()
        Me.LabIncassi = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.PanNumVotiIMDB = New System.Windows.Forms.Panel()
        Me.LabMoltiplicatoreNumVotiIMDB = New System.Windows.Forms.Label()
        Me.LabNumVotiIMDB = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.PanVotoIMDB = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LabVotoIMDB = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.IntestazioneValutazioni = New System.Windows.Forms.Label()
        Me.PannelloTrama = New System.Windows.Forms.Panel()
        Me.TextTramaLunga = New System.Windows.Forms.TextBox()
        Me.ButtonToggleTrama = New System.Windows.Forms.Button()
        Me.TextTramaBreve = New System.Windows.Forms.TextBox()
        Me.IntestazioneTrama = New System.Windows.Forms.Label()
        Me.ListaAttori = New System.Windows.Forms.ListView()
        Me.IntestazioneAttori = New System.Windows.Forms.Label()
        Me.ListaGeneri = New System.Windows.Forms.ListView()
        Me.IntestazioneGeneri = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelMusicisti = New System.Windows.Forms.Panel()
        Me.LabMusicisti = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PanelAutori = New System.Windows.Forms.Panel()
        Me.LabAutori = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PanelRegisti = New System.Windows.Forms.Panel()
        Me.LabRegisti = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PanelDurata = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LabFineVisione = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.LabDurata = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PannelloNazione = New System.Windows.Forms.Panel()
        Me.NazionePic = New System.Windows.Forms.PictureBox()
        Me.NazioneLab = New System.Windows.Forms.Label()
        Me.PanelAnno = New System.Windows.Forms.Panel()
        Me.LabAnno = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelNote = New System.Windows.Forms.Panel()
        Me.LabNote = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.PlaceholderPannelloDx = New System.Windows.Forms.Label()
        Me.AlberoCategorieLibreria = New System.Windows.Forms.TreeView()
        Me.SplitContainerSX_CDX = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PicImgPersona = New System.Windows.Forms.PictureBox()
        Me.ButImgPersona = New System.Windows.Forms.Button()
        Me.LabNomePersona = New System.Windows.Forms.Label()
        Me.FileSystemWatcher = New System.IO.FileSystemWatcher()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.PosterFilmPiccoli = New System.Windows.Forms.ImageList(Me.components)
        Me.PosterFilmGrandi = New System.Windows.Forms.ImageList(Me.components)
        Me.BarraStrumentiPrincipale.SuspendLayout()
        Me.SplitContainerC_DX.Panel1.SuspendLayout()
        Me.SplitContainerC_DX.Panel2.SuspendLayout()
        Me.SplitContainerC_DX.SuspendLayout()
        Me.SplitContainerFiltriAvanzati_Icone.Panel1.SuspendLayout()
        Me.SplitContainerFiltriAvanzati_Icone.Panel2.SuspendLayout()
        Me.SplitContainerFiltriAvanzati_Icone.SuspendLayout()
        Me.PannelloFiltriAvanzati.SuspendLayout()
        CType(Me.FiltroBitrateMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FiltroRisoluzioneMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FiltroAnnoMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FiltroDurataMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FiltroAnnoMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FiltroDurataMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PannelloFiltri.SuspendLayout()
        Me.PannelloNomeCategoria.SuspendLayout()
        CType(Me.PicCategoriaScelta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PannelloFiltriSemplici.SuspendLayout()
        Me.PannelloEsitoFiltri.SuspendLayout()
        Me.SplitImmagineDettagli.Panel1.SuspendLayout()
        Me.SplitImmagineDettagli.Panel2.SuspendLayout()
        Me.SplitImmagineDettagli.SuspendLayout()
        Me.SplitPosterSchermata.Panel1.SuspendLayout()
        Me.SplitPosterSchermata.Panel2.SuspendLayout()
        Me.SplitPosterSchermata.SuspendLayout()
        CType(Me.PicPoster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSchermata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RiquadroDestraPanel.SuspendLayout()
        Me.PanelFile.SuspendLayout()
        Me.PannelloSottotitoli.SuspendLayout()
        Me.PannelloAudio.SuspendLayout()
        Me.PannelloVideo.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PannelloCodecVideo.SuspendLayout()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PannelloRisoluzione.SuspendLayout()
        Me.BadgeRisoluzione.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.PannelloFPS.SuspendLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PannelloProporzioni.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PannelloBitrateVideo.SuspendLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PannelloContenitore.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.PanelValutazioni.SuspendLayout()
        Me.PanValutazioniCritica.SuspendLayout()
        Me.PanPremiNominati.SuspendLayout()
        Me.PanAltriNominati.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanBAFTANominati.SuspendLayout()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanOscarNominati.SuspendLayout()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanPremiVinti.SuspendLayout()
        Me.PanAltriVinti.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanBAFTAVinti.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanOscarVinti.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanRotten.SuspendLayout()
        Me.PanMetacritic.SuspendLayout()
        Me.PanValutazioniPubblico.SuspendLayout()
        Me.PanIncassi.SuspendLayout()
        Me.PanNumVotiIMDB.SuspendLayout()
        Me.PanVotoIMDB.SuspendLayout()
        Me.PannelloTrama.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelMusicisti.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAutori.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRegisti.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDurata.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PannelloNazione.SuspendLayout()
        CType(Me.NazionePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAnno.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNote.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraStrumentiFilm.SuspendLayout()
        Me.SplitContainerSX_CDX.Panel1.SuspendLayout()
        Me.SplitContainerSX_CDX.Panel2.SuspendLayout()
        Me.SplitContainerSX_CDX.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PicImgPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarraStrumentiPrincipale
        '
        Me.BarraStrumentiPrincipale.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BarraStrumentiPrincipale.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.BarraStrumentiPrincipale.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton6, Me.ToolStripButton7, Me.ToolStripSplitButton1, Me.ToolStripDropDownButton1, Me.ToolStripButton8, Me.ToolStripButton4, Me.ToolStripDropDownButton2})
        Me.BarraStrumentiPrincipale.Location = New System.Drawing.Point(0, 0)
        Me.BarraStrumentiPrincipale.Name = "BarraStrumentiPrincipale"
        Me.BarraStrumentiPrincipale.Size = New System.Drawing.Size(1193, 59)
        Me.BarraStrumentiPrincipale.TabIndex = 0
        Me.BarraStrumentiPrincipale.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(30, 56)
        Me.ToolStripButton1.Text = "<"
        Me.ToolStripButton1.ToolTipText = "Nascondi/Visualizza pannello Categorie Libreria"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(30, 56)
        Me.ToolStripButton2.Text = ">"
        Me.ToolStripButton2.ToolTipText = "Nascondi/Visualizza pannello Dettagli"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.videocassetta
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(104, 56)
        Me.ToolStripButton3.Text = "Scegli libreria"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton3.ToolTipText = "Scegli la cartella che contiene la libreria"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.aggiorna
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(75, 56)
        Me.ToolStripButton6.Text = "Aggiorna"
        Me.ToolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton6.ToolTipText = "Aggiorna l'elenco dei film dal disco"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.luna
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(51, 56)
        Me.ToolStripButton7.Text = "Notte"
        Me.ToolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton7.ToolTipText = "Cambia i colori della finestra tra Modalità Notte e Modalità Giorno"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaToolStripMenuItem, Me.ColonneToolStripMenuItem, Me.TilesToolStripMenuItem, Me.IconePiccoleToolStripMenuItem, Me.IconeGrandiToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(88, 56)
        Me.ToolStripSplitButton1.Text = "Visualizza"
        Me.ToolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ListaToolStripMenuItem
        '
        Me.ListaToolStripMenuItem.CheckOnClick = True
        Me.ListaToolStripMenuItem.Name = "ListaToolStripMenuItem"
        Me.ListaToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.ListaToolStripMenuItem.Text = "Lista"
        '
        'ColonneToolStripMenuItem
        '
        Me.ColonneToolStripMenuItem.CheckOnClick = True
        Me.ColonneToolStripMenuItem.Name = "ColonneToolStripMenuItem"
        Me.ColonneToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.ColonneToolStripMenuItem.Text = "Colonne/Dettagli"
        '
        'TilesToolStripMenuItem
        '
        Me.TilesToolStripMenuItem.CheckOnClick = True
        Me.TilesToolStripMenuItem.Enabled = False
        Me.TilesToolStripMenuItem.Name = "TilesToolStripMenuItem"
        Me.TilesToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.TilesToolStripMenuItem.Text = "Tiles"
        '
        'IconePiccoleToolStripMenuItem
        '
        Me.IconePiccoleToolStripMenuItem.CheckOnClick = True
        Me.IconePiccoleToolStripMenuItem.Name = "IconePiccoleToolStripMenuItem"
        Me.IconePiccoleToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.IconePiccoleToolStripMenuItem.Text = "Icone piccole"
        '
        'IconeGrandiToolStripMenuItem
        '
        Me.IconeGrandiToolStripMenuItem.CheckOnClick = True
        Me.IconeGrandiToolStripMenuItem.Name = "IconeGrandiToolStripMenuItem"
        Me.IconeGrandiToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.IconeGrandiToolStripMenuItem.Text = "Icone grandi"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrimaRigaToolStripMenuItem, Me.SecondaRigaToolStripMenuItem, Me.TerzaRigaToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(66, 56)
        Me.ToolStripDropDownButton1.Text = "Campi"
        Me.ToolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PrimaRigaToolStripMenuItem
        '
        Me.PrimaRigaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TitoloITAToolStripMenuItem, Me.TitoloOriginaleToolStripMenuItem})
        Me.PrimaRigaToolStripMenuItem.Name = "PrimaRigaToolStripMenuItem"
        Me.PrimaRigaToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
        Me.PrimaRigaToolStripMenuItem.Text = "Prima riga"
        '
        'TitoloITAToolStripMenuItem
        '
        Me.TitoloITAToolStripMenuItem.Name = "TitoloITAToolStripMenuItem"
        Me.TitoloITAToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
        Me.TitoloITAToolStripMenuItem.Text = "Titolo italiano"
        '
        'TitoloOriginaleToolStripMenuItem
        '
        Me.TitoloOriginaleToolStripMenuItem.Name = "TitoloOriginaleToolStripMenuItem"
        Me.TitoloOriginaleToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
        Me.TitoloOriginaleToolStripMenuItem.Text = "Titolo originale"
        '
        'SecondaRigaToolStripMenuItem
        '
        Me.SecondaRigaToolStripMenuItem.Name = "SecondaRigaToolStripMenuItem"
        Me.SecondaRigaToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
        Me.SecondaRigaToolStripMenuItem.Text = "Seconda riga"
        '
        'TerzaRigaToolStripMenuItem
        '
        Me.TerzaRigaToolStripMenuItem.Name = "TerzaRigaToolStripMenuItem"
        Me.TerzaRigaToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
        Me.TerzaRigaToolStripMenuItem.Text = "Terza riga"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.TitoloItalianoToolStripMenuItem, Me.AnnoToolStripMenuItem, Me.NazioneToolStripMenuItem, Me.DurataToolStripMenuItem, Me.DefinizioneToolStripMenuItem, Me.BitrateToolStripMenuItem1, Me.ToolStripSeparator1, Me.DiscendenteToolStripMenuItem, Me.TitoloItalianoToolStripMenuItem1, Me.AnnoToolStripMenuItem1, Me.NazioneToolStripMenuItem1, Me.DurataToolStripMenuItem1, Me.DefinizioneToolStripMenuItem1, Me.BitrateToolStripMenuItem})
        Me.ToolStripButton8.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.ordinamento
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(68, 56)
        Me.ToolStripButton8.Text = "Ordina"
        Me.ToolStripButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(243, 26)
        Me.ToolStripMenuItem1.Text = "Dal minore al maggiore"
        '
        'TitoloItalianoToolStripMenuItem
        '
        Me.TitoloItalianoToolStripMenuItem.Name = "TitoloItalianoToolStripMenuItem"
        Me.TitoloItalianoToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.TitoloItalianoToolStripMenuItem.Text = "per Titolo italiano"
        '
        'AnnoToolStripMenuItem
        '
        Me.AnnoToolStripMenuItem.Checked = True
        Me.AnnoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AnnoToolStripMenuItem.Name = "AnnoToolStripMenuItem"
        Me.AnnoToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.AnnoToolStripMenuItem.Text = "per Anno"
        '
        'NazioneToolStripMenuItem
        '
        Me.NazioneToolStripMenuItem.Name = "NazioneToolStripMenuItem"
        Me.NazioneToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.NazioneToolStripMenuItem.Text = "per Nazione"
        '
        'DurataToolStripMenuItem
        '
        Me.DurataToolStripMenuItem.Name = "DurataToolStripMenuItem"
        Me.DurataToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.DurataToolStripMenuItem.Text = "per Durata"
        '
        'DefinizioneToolStripMenuItem
        '
        Me.DefinizioneToolStripMenuItem.Name = "DefinizioneToolStripMenuItem"
        Me.DefinizioneToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.DefinizioneToolStripMenuItem.Text = "per Definizione"
        '
        'BitrateToolStripMenuItem1
        '
        Me.BitrateToolStripMenuItem1.Name = "BitrateToolStripMenuItem1"
        Me.BitrateToolStripMenuItem1.Size = New System.Drawing.Size(243, 26)
        Me.BitrateToolStripMenuItem1.Text = "per Bitrate"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(240, 6)
        '
        'DiscendenteToolStripMenuItem
        '
        Me.DiscendenteToolStripMenuItem.Enabled = False
        Me.DiscendenteToolStripMenuItem.Name = "DiscendenteToolStripMenuItem"
        Me.DiscendenteToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.DiscendenteToolStripMenuItem.Text = "Dal maggiore al minore"
        '
        'TitoloItalianoToolStripMenuItem1
        '
        Me.TitoloItalianoToolStripMenuItem1.Name = "TitoloItalianoToolStripMenuItem1"
        Me.TitoloItalianoToolStripMenuItem1.Size = New System.Drawing.Size(243, 26)
        Me.TitoloItalianoToolStripMenuItem1.Text = "per Titolo italiano"
        '
        'AnnoToolStripMenuItem1
        '
        Me.AnnoToolStripMenuItem1.Name = "AnnoToolStripMenuItem1"
        Me.AnnoToolStripMenuItem1.Size = New System.Drawing.Size(243, 26)
        Me.AnnoToolStripMenuItem1.Text = "per Anno"
        '
        'NazioneToolStripMenuItem1
        '
        Me.NazioneToolStripMenuItem1.Name = "NazioneToolStripMenuItem1"
        Me.NazioneToolStripMenuItem1.Size = New System.Drawing.Size(243, 26)
        Me.NazioneToolStripMenuItem1.Text = "per Nazione"
        '
        'DurataToolStripMenuItem1
        '
        Me.DurataToolStripMenuItem1.Name = "DurataToolStripMenuItem1"
        Me.DurataToolStripMenuItem1.Size = New System.Drawing.Size(243, 26)
        Me.DurataToolStripMenuItem1.Text = "per Durata"
        '
        'DefinizioneToolStripMenuItem1
        '
        Me.DefinizioneToolStripMenuItem1.Name = "DefinizioneToolStripMenuItem1"
        Me.DefinizioneToolStripMenuItem1.Size = New System.Drawing.Size(243, 26)
        Me.DefinizioneToolStripMenuItem1.Text = "per Definizione"
        '
        'BitrateToolStripMenuItem
        '
        Me.BitrateToolStripMenuItem.Name = "BitrateToolStripMenuItem"
        Me.BitrateToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.BitrateToolStripMenuItem.Text = "per Bitrate"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.dado
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(81, 56)
        Me.ToolStripButton4.Text = "Suggerisci"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton4.ToolTipText = "Ti suggerisce un film a caso tra quelli visualizzati nella schermata attuale"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SchermataToolStripMenuItem, Me.PosterToolStripMenuItem})
        Me.ToolStripDropDownButton2.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.quadro
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(59, 56)
        Me.ToolStripDropDownButton2.Text = "Icone"
        Me.ToolStripDropDownButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SchermataToolStripMenuItem
        '
        Me.SchermataToolStripMenuItem.Checked = True
        Me.SchermataToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SchermataToolStripMenuItem.Name = "SchermataToolStripMenuItem"
        Me.SchermataToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.SchermataToolStripMenuItem.Text = "Schermate"
        '
        'PosterToolStripMenuItem
        '
        Me.PosterToolStripMenuItem.Name = "PosterToolStripMenuItem"
        Me.PosterToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.PosterToolStripMenuItem.Text = "Poster"
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
        '
        'SplitContainerC_DX
        '
        Me.SplitContainerC_DX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerC_DX.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerC_DX.Name = "SplitContainerC_DX"
        '
        'SplitContainerC_DX.Panel1
        '
        Me.SplitContainerC_DX.Panel1.Controls.Add(Me.SplitContainerFiltriAvanzati_Icone)
        Me.SplitContainerC_DX.Panel1.Controls.Add(Me.PannelloFiltri)
        Me.SplitContainerC_DX.Panel1MinSize = 150
        '
        'SplitContainerC_DX.Panel2
        '
        Me.SplitContainerC_DX.Panel2.Controls.Add(Me.ButtPannelloSchermata)
        Me.SplitContainerC_DX.Panel2.Controls.Add(Me.SplitImmagineDettagli)
        Me.SplitContainerC_DX.Panel2.Controls.Add(Me.BarraStrumentiFilm)
        Me.SplitContainerC_DX.Panel2.Controls.Add(Me.PlaceholderPannelloDx)
        Me.SplitContainerC_DX.Panel2MinSize = 50
        Me.SplitContainerC_DX.Size = New System.Drawing.Size(1042, 684)
        Me.SplitContainerC_DX.SplitterDistance = 406
        Me.SplitContainerC_DX.SplitterIncrement = 10
        Me.SplitContainerC_DX.TabIndex = 0
        '
        'SplitContainerFiltriAvanzati_Icone
        '
        Me.SplitContainerFiltriAvanzati_Icone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerFiltriAvanzati_Icone.Location = New System.Drawing.Point(0, 142)
        Me.SplitContainerFiltriAvanzati_Icone.Name = "SplitContainerFiltriAvanzati_Icone"
        Me.SplitContainerFiltriAvanzati_Icone.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerFiltriAvanzati_Icone.Panel1
        '
        Me.SplitContainerFiltriAvanzati_Icone.Panel1.AutoScroll = True
        Me.SplitContainerFiltriAvanzati_Icone.Panel1.Controls.Add(Me.PannelloFiltriAvanzati)
        Me.SplitContainerFiltriAvanzati_Icone.Panel1Collapsed = True
        Me.SplitContainerFiltriAvanzati_Icone.Panel1MinSize = 10
        '
        'SplitContainerFiltriAvanzati_Icone.Panel2
        '
        Me.SplitContainerFiltriAvanzati_Icone.Panel2.Controls.Add(Me.ElencoFilm)
        Me.SplitContainerFiltriAvanzati_Icone.Panel2MinSize = 10
        Me.SplitContainerFiltriAvanzati_Icone.Size = New System.Drawing.Size(406, 542)
        Me.SplitContainerFiltriAvanzati_Icone.SplitterDistance = 478
        Me.SplitContainerFiltriAvanzati_Icone.TabIndex = 2
        '
        'PannelloFiltriAvanzati
        '
        Me.PannelloFiltriAvanzati.AutoSize = True
        Me.PannelloFiltriAvanzati.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PannelloFiltriAvanzati.Controls.Add(Me.Label30)
        Me.PannelloFiltriAvanzati.Controls.Add(Me.FiltroBitrateMin)
        Me.PannelloFiltriAvanzati.Controls.Add(Me.Label31)
        Me.PannelloFiltriAvanzati.Controls.Add(Me.Label29)
        Me.PannelloFiltriAvanzati.Controls.Add(Me.FiltroRisoluzioneMin)
        Me.PannelloFiltriAvanzati.Controls.Add(Me.Label28)
        Me.PannelloFiltriAvanzati.Controls.Add(Me.Label10)
        Me.PannelloFiltriAvanzati.Controls.Add(Me.FiltroGeneri)
        Me.PannelloFiltriAvanzati.Controls.Add(Me.Label6)
        Me.PannelloFiltriAvanzati.Controls.Add(Me.FiltroNazioni)
        Me.PannelloFiltriAvanzati.Controls.Add(Me.Label3)
        Me.PannelloFiltriAvanzati.Controls.Add(Me.Label7)
        Me.PannelloFiltriAvanzati.Controls.Add(Me.FiltroAnnoMax)
        Me.PannelloFiltriAvanzati.Controls.Add(Me.Label8)
        Me.PannelloFiltriAvanzati.Controls.Add(Me.Label4)
        Me.PannelloFiltriAvanzati.Controls.Add(Me.FiltroDurataMin)
        Me.PannelloFiltriAvanzati.Controls.Add(Me.FiltroAnnoMin)
        Me.PannelloFiltriAvanzati.Controls.Add(Me.Label9)
        Me.PannelloFiltriAvanzati.Controls.Add(Me.Label5)
        Me.PannelloFiltriAvanzati.Controls.Add(Me.FiltroDurataMax)
        Me.PannelloFiltriAvanzati.Controls.Add(Me.BottFiltra)
        Me.PannelloFiltriAvanzati.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PannelloFiltriAvanzati.Location = New System.Drawing.Point(0, 0)
        Me.PannelloFiltriAvanzati.Name = "PannelloFiltriAvanzati"
        Me.PannelloFiltriAvanzati.Size = New System.Drawing.Size(150, 478)
        Me.PannelloFiltriAvanzati.TabIndex = 11
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(3, 356)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(89, 27)
        Me.Label30.TabIndex = 20
        Me.Label30.Text = "Qualunque"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FiltroBitrateMin
        '
        Me.FiltroBitrateMin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiltroBitrateMin.AutoSize = False
        Me.FiltroBitrateMin.LargeChange = 1
        Me.FiltroBitrateMin.Location = New System.Drawing.Point(98, 356)
        Me.FiltroBitrateMin.Maximum = 16
        Me.FiltroBitrateMin.Name = "FiltroBitrateMin"
        Me.FiltroBitrateMin.Size = New System.Drawing.Size(49, 25)
        Me.FiltroBitrateMin.TabIndex = 19
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(3, 337)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(122, 18)
        Me.Label31.TabIndex = 18
        Me.Label31.Text = "Bitrate minimo:"
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(3, 312)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(156, 25)
        Me.Label29.TabIndex = 17
        Me.Label29.Text = "Qualunque"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FiltroRisoluzioneMin
        '
        Me.FiltroRisoluzioneMin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiltroRisoluzioneMin.AutoSize = False
        Me.FiltroRisoluzioneMin.LargeChange = 1
        Me.FiltroRisoluzioneMin.Location = New System.Drawing.Point(165, 312)
        Me.FiltroRisoluzioneMin.Maximum = 7
        Me.FiltroRisoluzioneMin.Name = "FiltroRisoluzioneMin"
        Me.FiltroRisoluzioneMin.Size = New System.Drawing.Size(0, 25)
        Me.FiltroRisoluzioneMin.TabIndex = 16
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(3, 294)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(161, 18)
        Me.Label28.TabIndex = 15
        Me.Label28.Text = "Risoluzione minima:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(146, 178)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 18)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Generi:"
        '
        'FiltroGeneri
        '
        Me.FiltroGeneri.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiltroGeneri.CheckOnClick = True
        Me.FiltroGeneri.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FiltroGeneri.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltroGeneri.FormattingEnabled = True
        Me.FiltroGeneri.Location = New System.Drawing.Point(146, 199)
        Me.FiltroGeneri.MultiColumn = True
        Me.FiltroGeneri.Name = "FiltroGeneri"
        Me.FiltroGeneri.Size = New System.Drawing.Size(1, 92)
        Me.FiltroGeneri.Sorted = True
        Me.FiltroGeneri.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Nazioni:"
        '
        'FiltroNazioni
        '
        Me.FiltroNazioni.CheckOnClick = True
        Me.FiltroNazioni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FiltroNazioni.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltroNazioni.FormattingEnabled = True
        Me.FiltroNazioni.Location = New System.Drawing.Point(0, 199)
        Me.FiltroNazioni.MultiColumn = True
        Me.FiltroNazioni.Name = "FiltroNazioni"
        Me.FiltroNazioni.Size = New System.Drawing.Size(140, 92)
        Me.FiltroNazioni.Sorted = True
        Me.FiltroNazioni.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Anno pubblicazione:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(0, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Durata:"
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
        Me.FiltroAnnoMax.Size = New System.Drawing.Size(61, 32)
        Me.FiltroAnnoMax.TabIndex = 2
        Me.FiltroAnnoMax.TickFrequency = 10
        Me.FiltroAnnoMax.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.FiltroAnnoMax.Value = 2023
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 23)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "a: ∞"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "dal: - ∞"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FiltroDurataMin
        '
        Me.FiltroDurataMin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiltroDurataMin.AutoSize = False
        Me.FiltroDurataMin.LargeChange = 30
        Me.FiltroDurataMin.Location = New System.Drawing.Point(111, 115)
        Me.FiltroDurataMin.Maximum = 300
        Me.FiltroDurataMin.Name = "FiltroDurataMin"
        Me.FiltroDurataMin.Size = New System.Drawing.Size(36, 30)
        Me.FiltroDurataMin.SmallChange = 5
        Me.FiltroDurataMin.TabIndex = 7
        Me.FiltroDurataMin.TickFrequency = 30
        Me.FiltroDurataMin.TickStyle = System.Windows.Forms.TickStyle.None
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
        Me.FiltroAnnoMin.Size = New System.Drawing.Size(61, 30)
        Me.FiltroAnnoMin.TabIndex = 1
        Me.FiltroAnnoMin.TickFrequency = 10
        Me.FiltroAnnoMin.TickStyle = System.Windows.Forms.TickStyle.None
        Me.FiltroAnnoMin.Value = 1894
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(0, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 23)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "da: 0 min"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "al: ∞"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FiltroDurataMax
        '
        Me.FiltroDurataMax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiltroDurataMax.AutoSize = False
        Me.FiltroDurataMax.LargeChange = 30
        Me.FiltroDurataMax.Location = New System.Drawing.Point(111, 143)
        Me.FiltroDurataMax.Maximum = 301
        Me.FiltroDurataMax.Name = "FiltroDurataMax"
        Me.FiltroDurataMax.Size = New System.Drawing.Size(36, 32)
        Me.FiltroDurataMax.SmallChange = 5
        Me.FiltroDurataMax.TabIndex = 8
        Me.FiltroDurataMax.TickFrequency = 30
        Me.FiltroDurataMax.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.FiltroDurataMax.Value = 301
        '
        'BottFiltra
        '
        Me.BottFiltra.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BottFiltra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BottFiltra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BottFiltra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BottFiltra.ImageIndex = 63
        Me.BottFiltra.ImageList = Me.IconeCategorieLibreria
        Me.BottFiltra.Location = New System.Drawing.Point(-4, 440)
        Me.BottFiltra.Name = "BottFiltra"
        Me.BottFiltra.Size = New System.Drawing.Size(159, 36)
        Me.BottFiltra.TabIndex = 5
        Me.BottFiltra.Text = "Filtra l'elenco"
        Me.BottFiltra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BottFiltra.UseVisualStyleBackColor = True
        '
        'ElencoFilm
        '
        Me.ElencoFilm.AllowColumnReorder = True
        Me.ElencoFilm.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColTitolo, Me.ColAnno, Me.ColNazione, Me.ColRegisti, Me.ColGeneri, Me.ColAttori, Me.ColAutori, Me.ColMusicisti})
        Me.ElencoFilm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ElencoFilm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElencoFilm.FullRowSelect = True
        Me.ElencoFilm.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ElencoFilm.LargeImageList = Me.SchermateFilmGrandi
        Me.ElencoFilm.Location = New System.Drawing.Point(0, 0)
        Me.ElencoFilm.MultiSelect = False
        Me.ElencoFilm.Name = "ElencoFilm"
        Me.ElencoFilm.OwnerDraw = True
        Me.ElencoFilm.Size = New System.Drawing.Size(406, 542)
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
        Me.PannelloFiltri.Controls.Add(Me.PannelloNomeCategoria)
        Me.PannelloFiltri.Controls.Add(Me.PannelloFiltriSemplici)
        Me.PannelloFiltri.Controls.Add(Me.PannelloEsitoFiltri)
        Me.PannelloFiltri.Dock = System.Windows.Forms.DockStyle.Top
        Me.PannelloFiltri.Location = New System.Drawing.Point(0, 0)
        Me.PannelloFiltri.Name = "PannelloFiltri"
        Me.PannelloFiltri.Size = New System.Drawing.Size(406, 142)
        Me.PannelloFiltri.TabIndex = 1
        Me.PannelloFiltri.Visible = False
        '
        'PannelloNomeCategoria
        '
        Me.PannelloNomeCategoria.Controls.Add(Me.LabValoreCategoriaScelta)
        Me.PannelloNomeCategoria.Controls.Add(Me.LabCategoriaScelta)
        Me.PannelloNomeCategoria.Controls.Add(Me.LabConteggioCategoriaScelta)
        Me.PannelloNomeCategoria.Controls.Add(Me.PicCategoriaScelta)
        Me.PannelloNomeCategoria.Dock = System.Windows.Forms.DockStyle.Top
        Me.PannelloNomeCategoria.Location = New System.Drawing.Point(0, 0)
        Me.PannelloNomeCategoria.Name = "PannelloNomeCategoria"
        Me.PannelloNomeCategoria.Size = New System.Drawing.Size(406, 61)
        Me.PannelloNomeCategoria.TabIndex = 8
        '
        'LabValoreCategoriaScelta
        '
        Me.LabValoreCategoriaScelta.AutoEllipsis = True
        Me.LabValoreCategoriaScelta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabValoreCategoriaScelta.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabValoreCategoriaScelta.Location = New System.Drawing.Point(134, 0)
        Me.LabValoreCategoriaScelta.Margin = New System.Windows.Forms.Padding(0)
        Me.LabValoreCategoriaScelta.Name = "LabValoreCategoriaScelta"
        Me.LabValoreCategoriaScelta.Size = New System.Drawing.Size(158, 61)
        Me.LabValoreCategoriaScelta.TabIndex = 7
        Me.LabValoreCategoriaScelta.Text = "Alfred Hitchcock"
        Me.LabValoreCategoriaScelta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabCategoriaScelta
        '
        Me.LabCategoriaScelta.AutoEllipsis = True
        Me.LabCategoriaScelta.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabCategoriaScelta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabCategoriaScelta.Location = New System.Drawing.Point(64, 0)
        Me.LabCategoriaScelta.Margin = New System.Windows.Forms.Padding(0)
        Me.LabCategoriaScelta.Name = "LabCategoriaScelta"
        Me.LabCategoriaScelta.Size = New System.Drawing.Size(70, 61)
        Me.LabCategoriaScelta.TabIndex = 6
        Me.LabCategoriaScelta.Text = "Film del regista"
        Me.LabCategoriaScelta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabConteggioCategoriaScelta
        '
        Me.LabConteggioCategoriaScelta.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabConteggioCategoriaScelta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabConteggioCategoriaScelta.Location = New System.Drawing.Point(366, 0)
        Me.LabConteggioCategoriaScelta.Margin = New System.Windows.Forms.Padding(0)
        Me.LabConteggioCategoriaScelta.Name = "LabConteggioCategoriaScelta"
        Me.LabConteggioCategoriaScelta.Size = New System.Drawing.Size(40, 61)
        Me.LabConteggioCategoriaScelta.TabIndex = 4
        Me.LabConteggioCategoriaScelta.Text = "42 film"
        Me.LabConteggioCategoriaScelta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicCategoriaScelta
        '
        Me.PicCategoriaScelta.Dock = System.Windows.Forms.DockStyle.Left
        Me.PicCategoriaScelta.Location = New System.Drawing.Point(0, 0)
        Me.PicCategoriaScelta.Margin = New System.Windows.Forms.Padding(0)
        Me.PicCategoriaScelta.Name = "PicCategoriaScelta"
        Me.PicCategoriaScelta.Size = New System.Drawing.Size(64, 61)
        Me.PicCategoriaScelta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicCategoriaScelta.TabIndex = 3
        Me.PicCategoriaScelta.TabStop = False
        '
        'PannelloFiltriSemplici
        '
        Me.PannelloFiltriSemplici.Controls.Add(Me.PlaceholderCasellaRicerca)
        Me.PannelloFiltriSemplici.Controls.Add(Me.CasellaRicerca)
        Me.PannelloFiltriSemplici.Controls.Add(Me.BottMostraFiltri)
        Me.PannelloFiltriSemplici.Controls.Add(Me.BottCerca)
        Me.PannelloFiltriSemplici.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PannelloFiltriSemplici.Location = New System.Drawing.Point(0, 61)
        Me.PannelloFiltriSemplici.Name = "PannelloFiltriSemplici"
        Me.PannelloFiltriSemplici.Size = New System.Drawing.Size(406, 32)
        Me.PannelloFiltriSemplici.TabIndex = 7
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
        Me.PlaceholderCasellaRicerca.Name = "PlaceholderCasellaRicerca"
        Me.PlaceholderCasellaRicerca.Size = New System.Drawing.Size(180, 23)
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
        Me.CasellaRicerca.MinimumSize = New System.Drawing.Size(80, 4)
        Me.CasellaRicerca.Name = "CasellaRicerca"
        Me.CasellaRicerca.Size = New System.Drawing.Size(185, 27)
        Me.CasellaRicerca.TabIndex = 2
        '
        'BottMostraFiltri
        '
        Me.BottMostraFiltri.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BottMostraFiltri.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BottMostraFiltri.Location = New System.Drawing.Point(242, 1)
        Me.BottMostraFiltri.Name = "BottMostraFiltri"
        Me.BottMostraFiltri.Size = New System.Drawing.Size(162, 30)
        Me.BottMostraFiltri.TabIndex = 1
        Me.BottMostraFiltri.Text = "➤ Filtri avanzati"
        Me.BottMostraFiltri.UseVisualStyleBackColor = True
        '
        'BottCerca
        '
        Me.BottCerca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BottCerca.BackgroundImage = Global.GestoreLibreriaFilm.My.Resources.Resources.cerca
        Me.BottCerca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BottCerca.Location = New System.Drawing.Point(191, 1)
        Me.BottCerca.Margin = New System.Windows.Forms.Padding(3, 3, 16, 3)
        Me.BottCerca.Name = "BottCerca"
        Me.BottCerca.Size = New System.Drawing.Size(32, 32)
        Me.BottCerca.TabIndex = 3
        Me.BottCerca.UseVisualStyleBackColor = True
        '
        'PannelloEsitoFiltri
        '
        Me.PannelloEsitoFiltri.Controls.Add(Me.BottCancellaFiltri)
        Me.PannelloEsitoFiltri.Controls.Add(Me.Label11)
        Me.PannelloEsitoFiltri.Controls.Add(Me.LabEsitoFiltri)
        Me.PannelloEsitoFiltri.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PannelloEsitoFiltri.Location = New System.Drawing.Point(0, 93)
        Me.PannelloEsitoFiltri.Name = "PannelloEsitoFiltri"
        Me.PannelloEsitoFiltri.Size = New System.Drawing.Size(406, 49)
        Me.PannelloEsitoFiltri.TabIndex = 6
        Me.PannelloEsitoFiltri.Visible = False
        '
        'BottCancellaFiltri
        '
        Me.BottCancellaFiltri.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BottCancellaFiltri.ForeColor = System.Drawing.Color.Red
        Me.BottCancellaFiltri.Location = New System.Drawing.Point(0, 2)
        Me.BottCancellaFiltri.Name = "BottCancellaFiltri"
        Me.BottCancellaFiltri.Size = New System.Drawing.Size(92, 47)
        Me.BottCancellaFiltri.TabIndex = 5
        Me.BottCancellaFiltri.Text = "Cancella filtri"
        Me.BottCancellaFiltri.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(98, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(305, 25)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Filtri attivi"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabEsitoFiltri
        '
        Me.LabEsitoFiltri.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabEsitoFiltri.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabEsitoFiltri.ForeColor = System.Drawing.Color.Red
        Me.LabEsitoFiltri.Location = New System.Drawing.Point(98, 25)
        Me.LabEsitoFiltri.Name = "LabEsitoFiltri"
        Me.LabEsitoFiltri.Size = New System.Drawing.Size(305, 25)
        Me.LabEsitoFiltri.TabIndex = 4
        Me.LabEsitoFiltri.Text = "(visualizzati 3 film su 52)"
        Me.LabEsitoFiltri.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtPannelloSchermata
        '
        Me.ButtPannelloSchermata.BackColor = System.Drawing.Color.Transparent
        Me.ButtPannelloSchermata.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtPannelloSchermata.FlatAppearance.BorderSize = 0
        Me.ButtPannelloSchermata.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.ButtPannelloSchermata.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtPannelloSchermata.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtPannelloSchermata.ForeColor = System.Drawing.Color.Gray
        Me.ButtPannelloSchermata.Location = New System.Drawing.Point(0, 0)
        Me.ButtPannelloSchermata.Name = "ButtPannelloSchermata"
        Me.ButtPannelloSchermata.Size = New System.Drawing.Size(632, 23)
        Me.ButtPannelloSchermata.TabIndex = 88
        Me.ButtPannelloSchermata.Text = "nascondi schermata ∧"
        Me.ToolTip.SetToolTip(Me.ButtPannelloSchermata, "Nascondi/Visualizza pannello Schermata")
        Me.ButtPannelloSchermata.UseVisualStyleBackColor = False
        '
        'SplitImmagineDettagli
        '
        Me.SplitImmagineDettagli.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitImmagineDettagli.Location = New System.Drawing.Point(0, 0)
        Me.SplitImmagineDettagli.Name = "SplitImmagineDettagli"
        Me.SplitImmagineDettagli.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitImmagineDettagli.Panel1
        '
        Me.SplitImmagineDettagli.Panel1.Controls.Add(Me.SplitPosterSchermata)
        Me.SplitImmagineDettagli.Panel1MinSize = 50
        '
        'SplitImmagineDettagli.Panel2
        '
        Me.SplitImmagineDettagli.Panel2.Controls.Add(Me.RiquadroDestraPanel)
        Me.SplitImmagineDettagli.Panel2MinSize = 100
        Me.SplitImmagineDettagli.Size = New System.Drawing.Size(632, 637)
        Me.SplitImmagineDettagli.SplitterDistance = 150
        Me.SplitImmagineDettagli.SplitterIncrement = 10
        Me.SplitImmagineDettagli.TabIndex = 1
        '
        'SplitPosterSchermata
        '
        Me.SplitPosterSchermata.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitPosterSchermata.Location = New System.Drawing.Point(0, 0)
        Me.SplitPosterSchermata.Name = "SplitPosterSchermata"
        '
        'SplitPosterSchermata.Panel1
        '
        Me.SplitPosterSchermata.Panel1.Controls.Add(Me.PicPoster)
        Me.SplitPosterSchermata.Panel1.Padding = New System.Windows.Forms.Padding(0, 23, 0, 0)
        '
        'SplitPosterSchermata.Panel2
        '
        Me.SplitPosterSchermata.Panel2.Controls.Add(Me.PicSchermata)
        Me.SplitPosterSchermata.Panel2.Padding = New System.Windows.Forms.Padding(0, 23, 0, 0)
        Me.SplitPosterSchermata.Size = New System.Drawing.Size(632, 150)
        Me.SplitPosterSchermata.SplitterDistance = 210
        Me.SplitPosterSchermata.SplitterIncrement = 10
        Me.SplitPosterSchermata.TabIndex = 2
        '
        'PicPoster
        '
        Me.PicPoster.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicPoster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicPoster.Location = New System.Drawing.Point(0, 23)
        Me.PicPoster.Name = "PicPoster"
        Me.PicPoster.Size = New System.Drawing.Size(210, 127)
        Me.PicPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicPoster.TabIndex = 1
        Me.PicPoster.TabStop = False
        Me.ToolTip.SetToolTip(Me.PicPoster, "Poster del film")
        '
        'PicSchermata
        '
        Me.PicSchermata.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicSchermata.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicSchermata.Location = New System.Drawing.Point(0, 23)
        Me.PicSchermata.Name = "PicSchermata"
        Me.PicSchermata.Size = New System.Drawing.Size(418, 127)
        Me.PicSchermata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicSchermata.TabIndex = 2
        Me.PicSchermata.TabStop = False
        Me.ToolTip.SetToolTip(Me.PicSchermata, "Schermata del film")
        Me.PicSchermata.Visible = False
        '
        'RiquadroDestraPanel
        '
        Me.RiquadroDestraPanel.AutoScroll = True
        Me.RiquadroDestraPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RiquadroDestraPanel.Controls.Add(Me.PanelFile)
        Me.RiquadroDestraPanel.Controls.Add(Me.PanelValutazioni)
        Me.RiquadroDestraPanel.Controls.Add(Me.PannelloTrama)
        Me.RiquadroDestraPanel.Controls.Add(Me.ListaAttori)
        Me.RiquadroDestraPanel.Controls.Add(Me.IntestazioneAttori)
        Me.RiquadroDestraPanel.Controls.Add(Me.ListaGeneri)
        Me.RiquadroDestraPanel.Controls.Add(Me.IntestazioneGeneri)
        Me.RiquadroDestraPanel.Controls.Add(Me.Panel3)
        Me.RiquadroDestraPanel.Controls.Add(Me.PanelNote)
        Me.RiquadroDestraPanel.Controls.Add(Me.Label2)
        Me.RiquadroDestraPanel.Controls.Add(Me.Label1)
        Me.RiquadroDestraPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RiquadroDestraPanel.Location = New System.Drawing.Point(0, 0)
        Me.RiquadroDestraPanel.MinimumSize = New System.Drawing.Size(50, 100)
        Me.RiquadroDestraPanel.Name = "RiquadroDestraPanel"
        Me.RiquadroDestraPanel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 47)
        Me.RiquadroDestraPanel.Size = New System.Drawing.Size(632, 483)
        Me.RiquadroDestraPanel.TabIndex = 20
        '
        'PanelFile
        '
        Me.PanelFile.AutoSize = True
        Me.PanelFile.Controls.Add(Me.PannelloSottotitoli)
        Me.PanelFile.Controls.Add(Me.PannelloAudio)
        Me.PanelFile.Controls.Add(Me.PannelloVideo)
        Me.PanelFile.Controls.Add(Me.PannelloContenitore)
        Me.PanelFile.Controls.Add(Me.IntestazioneFile)
        Me.PanelFile.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFile.Location = New System.Drawing.Point(0, 944)
        Me.PanelFile.MinimumSize = New System.Drawing.Size(0, 64)
        Me.PanelFile.Name = "PanelFile"
        Me.PanelFile.Size = New System.Drawing.Size(611, 364)
        Me.PanelFile.TabIndex = 83
        '
        'PannelloSottotitoli
        '
        Me.PannelloSottotitoli.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PannelloSottotitoli.Controls.Add(Me.RTFSottotitoli)
        Me.PannelloSottotitoli.Controls.Add(Me.Label19)
        Me.PannelloSottotitoli.Dock = System.Windows.Forms.DockStyle.Top
        Me.PannelloSottotitoli.Location = New System.Drawing.Point(0, 292)
        Me.PannelloSottotitoli.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.PannelloSottotitoli.MinimumSize = New System.Drawing.Size(2, 72)
        Me.PannelloSottotitoli.Name = "PannelloSottotitoli"
        Me.PannelloSottotitoli.Size = New System.Drawing.Size(611, 72)
        Me.PannelloSottotitoli.TabIndex = 87
        '
        'RTFSottotitoli
        '
        Me.RTFSottotitoli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTFSottotitoli.BulletIndent = 10
        Me.RTFSottotitoli.Cursor = System.Windows.Forms.Cursors.Default
        Me.RTFSottotitoli.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RTFSottotitoli.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTFSottotitoli.Location = New System.Drawing.Point(50, 0)
        Me.RTFSottotitoli.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.RTFSottotitoli.Name = "RTFSottotitoli"
        Me.RTFSottotitoli.ReadOnly = True
        Me.RTFSottotitoli.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RTFSottotitoli.ShortcutsEnabled = False
        Me.RTFSottotitoli.Size = New System.Drawing.Size(561, 72)
        Me.RTFSottotitoli.TabIndex = 55
        Me.RTFSottotitoli.Text = ""
        Me.RTFSottotitoli.WordWrap = False
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label19.ImageIndex = 84
        Me.Label19.ImageList = Me.IconeCategorieLibreria
        Me.Label19.Location = New System.Drawing.Point(0, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(50, 72)
        Me.Label19.TabIndex = 53
        Me.Label19.Text = "Sottotitoli"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'PannelloAudio
        '
        Me.PannelloAudio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PannelloAudio.Controls.Add(Me.RTFAudio)
        Me.PannelloAudio.Controls.Add(Me.Label18)
        Me.PannelloAudio.Controls.Add(Me.RigaSottoAudio)
        Me.PannelloAudio.Dock = System.Windows.Forms.DockStyle.Top
        Me.PannelloAudio.Location = New System.Drawing.Point(0, 217)
        Me.PannelloAudio.Margin = New System.Windows.Forms.Padding(0)
        Me.PannelloAudio.MinimumSize = New System.Drawing.Size(2, 75)
        Me.PannelloAudio.Name = "PannelloAudio"
        Me.PannelloAudio.Size = New System.Drawing.Size(611, 75)
        Me.PannelloAudio.TabIndex = 86
        '
        'RTFAudio
        '
        Me.RTFAudio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTFAudio.BulletIndent = 10
        Me.RTFAudio.Cursor = System.Windows.Forms.Cursors.Default
        Me.RTFAudio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RTFAudio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTFAudio.Location = New System.Drawing.Point(50, 0)
        Me.RTFAudio.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.RTFAudio.Name = "RTFAudio"
        Me.RTFAudio.ReadOnly = True
        Me.RTFAudio.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RTFAudio.ShortcutsEnabled = False
        Me.RTFAudio.Size = New System.Drawing.Size(561, 74)
        Me.RTFAudio.TabIndex = 78
        Me.RTFAudio.Text = ""
        Me.RTFAudio.WordWrap = False
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label18.ImageIndex = 81
        Me.Label18.ImageList = Me.IconeCategorieLibreria
        Me.Label18.Location = New System.Drawing.Point(0, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 74)
        Me.Label18.TabIndex = 77
        Me.Label18.Text = "Au" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dio"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RigaSottoAudio
        '
        Me.RigaSottoAudio.BackColor = System.Drawing.Color.Gray
        Me.RigaSottoAudio.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RigaSottoAudio.Location = New System.Drawing.Point(0, 74)
        Me.RigaSottoAudio.Name = "RigaSottoAudio"
        Me.RigaSottoAudio.Size = New System.Drawing.Size(611, 1)
        Me.RigaSottoAudio.TabIndex = 76
        '
        'PannelloVideo
        '
        Me.PannelloVideo.Controls.Add(Me.TableLayoutPanel1)
        Me.PannelloVideo.Controls.Add(Me.Label20)
        Me.PannelloVideo.Controls.Add(Me.RigaSottoVideo)
        Me.PannelloVideo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PannelloVideo.Location = New System.Drawing.Point(0, 114)
        Me.PannelloVideo.MinimumSize = New System.Drawing.Size(0, 65)
        Me.PannelloVideo.Name = "PannelloVideo"
        Me.PannelloVideo.Size = New System.Drawing.Size(611, 103)
        Me.PannelloVideo.TabIndex = 85
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(50, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(561, 102)
        Me.TableLayoutPanel1.TabIndex = 81
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoSize = True
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.Controls.Add(Me.PannelloCodecVideo)
        Me.Panel2.Controls.Add(Me.PannelloRisoluzione)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(330, 68)
        Me.Panel2.TabIndex = 63
        '
        'PannelloCodecVideo
        '
        Me.PannelloCodecVideo.AutoSize = True
        Me.PannelloCodecVideo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PannelloCodecVideo.Controls.Add(Me.LabCodecVideo)
        Me.PannelloCodecVideo.Controls.Add(Me.Label27)
        Me.PannelloCodecVideo.Controls.Add(Me.PictureBox15)
        Me.PannelloCodecVideo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PannelloCodecVideo.Location = New System.Drawing.Point(0, 36)
        Me.PannelloCodecVideo.MinimumSize = New System.Drawing.Size(0, 32)
        Me.PannelloCodecVideo.Name = "PannelloCodecVideo"
        Me.PannelloCodecVideo.Size = New System.Drawing.Size(330, 32)
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
        'PannelloRisoluzione
        '
        Me.PannelloRisoluzione.AutoSize = True
        Me.PannelloRisoluzione.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PannelloRisoluzione.Controls.Add(Me.BadgeRisoluzione)
        Me.PannelloRisoluzione.Controls.Add(Me.Label26)
        Me.PannelloRisoluzione.Controls.Add(Me.PictureBox9)
        Me.PannelloRisoluzione.Dock = System.Windows.Forms.DockStyle.Top
        Me.PannelloRisoluzione.Location = New System.Drawing.Point(0, 0)
        Me.PannelloRisoluzione.MinimumSize = New System.Drawing.Size(0, 36)
        Me.PannelloRisoluzione.Name = "PannelloRisoluzione"
        Me.PannelloRisoluzione.Size = New System.Drawing.Size(330, 36)
        Me.PannelloRisoluzione.TabIndex = 59
        '
        'BadgeRisoluzione
        '
        Me.BadgeRisoluzione.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BadgeRisoluzione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BadgeRisoluzione.Controls.Add(Me.LabAltezzaRisoluzione)
        Me.BadgeRisoluzione.Controls.Add(Me.LabTipoRisoluzione)
        Me.BadgeRisoluzione.Dock = System.Windows.Forms.DockStyle.Left
        Me.BadgeRisoluzione.Location = New System.Drawing.Point(82, 0)
        Me.BadgeRisoluzione.Name = "BadgeRisoluzione"
        Me.BadgeRisoluzione.Padding = New System.Windows.Forms.Padding(3)
        Me.BadgeRisoluzione.Size = New System.Drawing.Size(132, 36)
        Me.BadgeRisoluzione.TabIndex = 50
        '
        'LabAltezzaRisoluzione
        '
        Me.LabAltezzaRisoluzione.AutoSize = True
        Me.LabAltezzaRisoluzione.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabAltezzaRisoluzione.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabAltezzaRisoluzione.Location = New System.Drawing.Point(77, 3)
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
        Me.LabTipoRisoluzione.Size = New System.Drawing.Size(74, 32)
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
        Me.Label26.Text = "Risolu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "zione:"
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
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.AutoSize = True
        Me.Panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel4.Controls.Add(Me.PannelloFPS)
        Me.Panel4.Controls.Add(Me.PannelloProporzioni)
        Me.Panel4.Controls.Add(Me.PannelloBitrateVideo)
        Me.Panel4.Location = New System.Drawing.Point(339, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(219, 96)
        Me.Panel4.TabIndex = 61
        '
        'PannelloFPS
        '
        Me.PannelloFPS.AutoSize = True
        Me.PannelloFPS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PannelloFPS.Controls.Add(Me.LabFPS)
        Me.PannelloFPS.Controls.Add(Me.PictureBox13)
        Me.PannelloFPS.Dock = System.Windows.Forms.DockStyle.Top
        Me.PannelloFPS.Location = New System.Drawing.Point(0, 64)
        Me.PannelloFPS.MinimumSize = New System.Drawing.Size(0, 32)
        Me.PannelloFPS.Name = "PannelloFPS"
        Me.PannelloFPS.Size = New System.Drawing.Size(219, 32)
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
        Me.PictureBox13.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.FPS
        Me.PictureBox13.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox13.TabIndex = 47
        Me.PictureBox13.TabStop = False
        '
        'PannelloProporzioni
        '
        Me.PannelloProporzioni.AutoSize = True
        Me.PannelloProporzioni.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PannelloProporzioni.Controls.Add(Me.LabProporzioni)
        Me.PannelloProporzioni.Controls.Add(Me.PictureBox12)
        Me.PannelloProporzioni.Dock = System.Windows.Forms.DockStyle.Top
        Me.PannelloProporzioni.Location = New System.Drawing.Point(0, 32)
        Me.PannelloProporzioni.MinimumSize = New System.Drawing.Size(0, 32)
        Me.PannelloProporzioni.Name = "PannelloProporzioni"
        Me.PannelloProporzioni.Size = New System.Drawing.Size(219, 32)
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
        'PannelloBitrateVideo
        '
        Me.PannelloBitrateVideo.AutoSize = True
        Me.PannelloBitrateVideo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PannelloBitrateVideo.Controls.Add(Me.LabBitrateVideo)
        Me.PannelloBitrateVideo.Controls.Add(Me.PictureBox14)
        Me.PannelloBitrateVideo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PannelloBitrateVideo.Location = New System.Drawing.Point(0, 0)
        Me.PannelloBitrateVideo.MinimumSize = New System.Drawing.Size(0, 32)
        Me.PannelloBitrateVideo.Name = "PannelloBitrateVideo"
        Me.PannelloBitrateVideo.Size = New System.Drawing.Size(219, 32)
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
        Me.PictureBox14.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.peso
        Me.PictureBox14.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox14.TabIndex = 47
        Me.PictureBox14.TabStop = False
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label20.ImageIndex = 83
        Me.Label20.ImageList = Me.IconeCategorieLibreria
        Me.Label20.Location = New System.Drawing.Point(0, 0)
        Me.Label20.MinimumSize = New System.Drawing.Size(50, 73)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 102)
        Me.Label20.TabIndex = 80
        Me.Label20.Text = "Vid" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "eo"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RigaSottoVideo
        '
        Me.RigaSottoVideo.BackColor = System.Drawing.Color.Gray
        Me.RigaSottoVideo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RigaSottoVideo.Location = New System.Drawing.Point(0, 102)
        Me.RigaSottoVideo.Name = "RigaSottoVideo"
        Me.RigaSottoVideo.Size = New System.Drawing.Size(611, 1)
        Me.RigaSottoVideo.TabIndex = 76
        '
        'PannelloContenitore
        '
        Me.PannelloContenitore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PannelloContenitore.Controls.Add(Me.Panel8)
        Me.PannelloContenitore.Controls.Add(Me.Panel7)
        Me.PannelloContenitore.Controls.Add(Me.Panel6)
        Me.PannelloContenitore.Controls.Add(Me.Label22)
        Me.PannelloContenitore.Controls.Add(Me.RigaSottoFile)
        Me.PannelloContenitore.Dock = System.Windows.Forms.DockStyle.Top
        Me.PannelloContenitore.Location = New System.Drawing.Point(0, 32)
        Me.PannelloContenitore.Name = "PannelloContenitore"
        Me.PannelloContenitore.Size = New System.Drawing.Size(611, 82)
        Me.PannelloContenitore.TabIndex = 84
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.LabBitrateFile)
        Me.Panel8.Controls.Add(Me.Label23)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(50, 50)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(561, 30)
        Me.Panel8.TabIndex = 79
        '
        'LabBitrateFile
        '
        Me.LabBitrateFile.AutoSize = True
        Me.LabBitrateFile.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabBitrateFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabBitrateFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabBitrateFile.ImageIndex = 7
        Me.LabBitrateFile.Location = New System.Drawing.Point(54, 0)
        Me.LabBitrateFile.Name = "LabBitrateFile"
        Me.LabBitrateFile.Padding = New System.Windows.Forms.Padding(3)
        Me.LabBitrateFile.Size = New System.Drawing.Size(85, 26)
        Me.LabBitrateFile.TabIndex = 74
        Me.LabBitrateFile.Text = "21 MB/s"
        Me.LabBitrateFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label23.ImageIndex = 7
        Me.Label23.Location = New System.Drawing.Point(0, 0)
        Me.Label23.MinimumSize = New System.Drawing.Size(0, 26)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(54, 26)
        Me.Label23.TabIndex = 73
        Me.Label23.Text = "Bitrate:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.LabDimensioneFile)
        Me.Panel7.Controls.Add(Me.Label24)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(50, 25)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(561, 25)
        Me.Panel7.TabIndex = 78
        '
        'LabDimensioneFile
        '
        Me.LabDimensioneFile.AutoSize = True
        Me.LabDimensioneFile.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabDimensioneFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabDimensioneFile.Location = New System.Drawing.Point(91, 0)
        Me.LabDimensioneFile.Name = "LabDimensioneFile"
        Me.LabDimensioneFile.Size = New System.Drawing.Size(61, 20)
        Me.LabDimensioneFile.TabIndex = 73
        Me.LabDimensioneFile.Text = "4,5 GB"
        Me.LabDimensioneFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(0, 0)
        Me.Label24.MinimumSize = New System.Drawing.Size(0, 20)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(91, 20)
        Me.Label24.TabIndex = 72
        Me.Label24.Text = "Dimensione:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel6
        '
        Me.Panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel6.Controls.Add(Me.LabCodecFile)
        Me.Panel6.Controls.Add(Me.LabEstensione)
        Me.Panel6.Controls.Add(Me.Label25)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(50, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(561, 25)
        Me.Panel6.TabIndex = 77
        '
        'LabCodecFile
        '
        Me.LabCodecFile.AutoSize = True
        Me.LabCodecFile.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabCodecFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabCodecFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabCodecFile.ImageIndex = 7
        Me.LabCodecFile.Location = New System.Drawing.Point(134, 0)
        Me.LabCodecFile.Name = "LabCodecFile"
        Me.LabCodecFile.Size = New System.Drawing.Size(82, 20)
        Me.LabCodecFile.TabIndex = 70
        Me.LabCodecFile.Text = "Matrioska"
        Me.LabCodecFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabEstensione
        '
        Me.LabEstensione.AutoSize = True
        Me.LabEstensione.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabEstensione.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabEstensione.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabEstensione.ImageIndex = 7
        Me.LabEstensione.Location = New System.Drawing.Point(89, 0)
        Me.LabEstensione.Name = "LabEstensione"
        Me.LabEstensione.Size = New System.Drawing.Size(45, 20)
        Me.LabEstensione.TabIndex = 69
        Me.LabEstensione.Text = "MKV"
        Me.LabEstensione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label25.ImageIndex = 7
        Me.Label25.Location = New System.Drawing.Point(0, 0)
        Me.Label25.MinimumSize = New System.Drawing.Size(0, 20)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(89, 20)
        Me.Label25.TabIndex = 68
        Me.Label25.Text = "Contenitore:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label22.ImageIndex = 82
        Me.Label22.ImageList = Me.IconeCategorieLibreria
        Me.Label22.Location = New System.Drawing.Point(0, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 81)
        Me.Label22.TabIndex = 76
        Me.Label22.Text = "Fi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "le"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RigaSottoFile
        '
        Me.RigaSottoFile.BackColor = System.Drawing.Color.Gray
        Me.RigaSottoFile.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RigaSottoFile.Location = New System.Drawing.Point(0, 81)
        Me.RigaSottoFile.Name = "RigaSottoFile"
        Me.RigaSottoFile.Size = New System.Drawing.Size(611, 1)
        Me.RigaSottoFile.TabIndex = 75
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
        Me.IntestazioneFile.Size = New System.Drawing.Size(611, 32)
        Me.IntestazioneFile.TabIndex = 40
        Me.IntestazioneFile.Text = "File"
        Me.IntestazioneFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelValutazioni
        '
        Me.PanelValutazioni.AutoSize = True
        Me.PanelValutazioni.Controls.Add(Me.PanValutazioniCritica)
        Me.PanelValutazioni.Controls.Add(Me.PanValutazioniPubblico)
        Me.PanelValutazioni.Controls.Add(Me.IntestazioneValutazioni)
        Me.PanelValutazioni.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelValutazioni.Location = New System.Drawing.Point(0, 671)
        Me.PanelValutazioni.Name = "PanelValutazioni"
        Me.PanelValutazioni.Size = New System.Drawing.Size(611, 273)
        Me.PanelValutazioni.TabIndex = 81
        '
        'PanValutazioniCritica
        '
        Me.PanValutazioniCritica.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanValutazioniCritica.Controls.Add(Me.PanPremiNominati)
        Me.PanValutazioniCritica.Controls.Add(Me.PanPremiVinti)
        Me.PanValutazioniCritica.Controls.Add(Me.PanRotten)
        Me.PanValutazioniCritica.Controls.Add(Me.PanMetacritic)
        Me.PanValutazioniCritica.Controls.Add(Me.Label43)
        Me.PanValutazioniCritica.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanValutazioniCritica.Location = New System.Drawing.Point(0, 152)
        Me.PanValutazioniCritica.Name = "PanValutazioniCritica"
        Me.PanValutazioniCritica.Size = New System.Drawing.Size(611, 121)
        Me.PanValutazioniCritica.TabIndex = 45
        '
        'PanPremiNominati
        '
        Me.PanPremiNominati.BackColor = System.Drawing.Color.Silver
        Me.PanPremiNominati.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanPremiNominati.Controls.Add(Me.PanAltriNominati)
        Me.PanPremiNominati.Controls.Add(Me.PanBAFTANominati)
        Me.PanPremiNominati.Controls.Add(Me.PanOscarNominati)
        Me.PanPremiNominati.Controls.Add(Me.Label47)
        Me.PanPremiNominati.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanPremiNominati.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanPremiNominati.Location = New System.Drawing.Point(320, 0)
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
        Me.Label44.Size = New System.Drawing.Size(52, 32)
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
        'PanPremiVinti
        '
        Me.PanPremiVinti.BackColor = System.Drawing.Color.Gold
        Me.PanPremiVinti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanPremiVinti.Controls.Add(Me.PanAltriVinti)
        Me.PanPremiVinti.Controls.Add(Me.PanBAFTAVinti)
        Me.PanPremiVinti.Controls.Add(Me.PanOscarVinti)
        Me.PanPremiVinti.Controls.Add(Me.Label40)
        Me.PanPremiVinti.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanPremiVinti.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanPremiVinti.Location = New System.Drawing.Point(174, 0)
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
        Me.PictureBox10.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.premio_oro
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
        Me.Label37.Location = New System.Drawing.Point(81, 0)
        Me.Label37.Margin = New System.Windows.Forms.Padding(0)
        Me.Label37.MinimumSize = New System.Drawing.Size(0, 32)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(65, 32)
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
        Me.LabOscarVinti.Size = New System.Drawing.Size(49, 32)
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
        'PanRotten
        '
        Me.PanRotten.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanRotten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanRotten.Controls.Add(Me.Label32)
        Me.PanRotten.Controls.Add(Me.LabRotten)
        Me.PanRotten.Controls.Add(Me.Label38)
        Me.PanRotten.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanRotten.Location = New System.Drawing.Point(89, 0)
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
        'PanMetacritic
        '
        Me.PanMetacritic.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanMetacritic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanMetacritic.Controls.Add(Me.Label16)
        Me.PanMetacritic.Controls.Add(Me.LabMetacritic)
        Me.PanMetacritic.Controls.Add(Me.Label15)
        Me.PanMetacritic.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanMetacritic.Location = New System.Drawing.Point(25, 0)
        Me.PanMetacritic.MinimumSize = New System.Drawing.Size(2, 95)
        Me.PanMetacritic.Name = "PanMetacritic"
        Me.PanMetacritic.Size = New System.Drawing.Size(64, 121)
        Me.PanMetacritic.TabIndex = 51
        '
        'Label16
        '
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(0, 85)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 17)
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
        Me.LabMetacritic.Size = New System.Drawing.Size(62, 45)
        Me.LabMetacritic.TabIndex = 1
        Me.LabMetacritic.Text = "00"
        Me.LabMetacritic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(0, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 40)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Meta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "critic"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label43
        '
        Me.Label43.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(0, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(25, 121)
        Me.Label43.TabIndex = 50
        Me.Label43.Text = "Critica"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanValutazioniPubblico
        '
        Me.PanValutazioniPubblico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanValutazioniPubblico.Controls.Add(Me.PanIncassi)
        Me.PanValutazioniPubblico.Controls.Add(Me.PanNumVotiIMDB)
        Me.PanValutazioniPubblico.Controls.Add(Me.PanVotoIMDB)
        Me.PanValutazioniPubblico.Controls.Add(Me.Label45)
        Me.PanValutazioniPubblico.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanValutazioniPubblico.Location = New System.Drawing.Point(0, 32)
        Me.PanValutazioniPubblico.Name = "PanValutazioniPubblico"
        Me.PanValutazioniPubblico.Size = New System.Drawing.Size(611, 120)
        Me.PanValutazioniPubblico.TabIndex = 44
        '
        'PanIncassi
        '
        Me.PanIncassi.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanIncassi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanIncassi.Controls.Add(Me.Label39)
        Me.PanIncassi.Controls.Add(Me.LabMoltiplicatoreIncassi)
        Me.PanIncassi.Controls.Add(Me.LabIncassi)
        Me.PanIncassi.Controls.Add(Me.Label35)
        Me.PanIncassi.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanIncassi.Location = New System.Drawing.Point(180, 0)
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
        'PanNumVotiIMDB
        '
        Me.PanNumVotiIMDB.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanNumVotiIMDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanNumVotiIMDB.Controls.Add(Me.LabMoltiplicatoreNumVotiIMDB)
        Me.PanNumVotiIMDB.Controls.Add(Me.LabNumVotiIMDB)
        Me.PanNumVotiIMDB.Controls.Add(Me.Label34)
        Me.PanNumVotiIMDB.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanNumVotiIMDB.Location = New System.Drawing.Point(100, 0)
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
        'PanVotoIMDB
        '
        Me.PanVotoIMDB.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanVotoIMDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanVotoIMDB.Controls.Add(Me.Label17)
        Me.PanVotoIMDB.Controls.Add(Me.LabVotoIMDB)
        Me.PanVotoIMDB.Controls.Add(Me.Label36)
        Me.PanVotoIMDB.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanVotoIMDB.Location = New System.Drawing.Point(25, 0)
        Me.PanVotoIMDB.Name = "PanVotoIMDB"
        Me.PanVotoIMDB.Size = New System.Drawing.Size(75, 120)
        Me.PanVotoIMDB.TabIndex = 52
        '
        'Label17
        '
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(0, 65)
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
        Me.LabVotoIMDB.Location = New System.Drawing.Point(0, 20)
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
        Me.Label36.Size = New System.Drawing.Size(73, 20)
        Me.Label36.TabIndex = 0
        Me.Label36.Text = "IMDB"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label45
        '
        Me.Label45.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(0, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(25, 120)
        Me.Label45.TabIndex = 51
        Me.Label45.Text = "Pubblico"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IntestazioneValutazioni
        '
        Me.IntestazioneValutazioni.BackColor = System.Drawing.SystemColors.ControlLight
        Me.IntestazioneValutazioni.Dock = System.Windows.Forms.DockStyle.Top
        Me.IntestazioneValutazioni.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntestazioneValutazioni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IntestazioneValutazioni.Location = New System.Drawing.Point(0, 0)
        Me.IntestazioneValutazioni.Name = "IntestazioneValutazioni"
        Me.IntestazioneValutazioni.Size = New System.Drawing.Size(611, 32)
        Me.IntestazioneValutazioni.TabIndex = 38
        Me.IntestazioneValutazioni.Text = "Valutazioni"
        Me.IntestazioneValutazioni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PannelloTrama
        '
        Me.PannelloTrama.AutoSize = True
        Me.PannelloTrama.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PannelloTrama.Controls.Add(Me.TextTramaLunga)
        Me.PannelloTrama.Controls.Add(Me.ButtonToggleTrama)
        Me.PannelloTrama.Controls.Add(Me.TextTramaBreve)
        Me.PannelloTrama.Controls.Add(Me.IntestazioneTrama)
        Me.PannelloTrama.Dock = System.Windows.Forms.DockStyle.Top
        Me.PannelloTrama.Location = New System.Drawing.Point(0, 434)
        Me.PannelloTrama.Name = "PannelloTrama"
        Me.PannelloTrama.Size = New System.Drawing.Size(611, 237)
        Me.PannelloTrama.TabIndex = 80
        '
        'TextTramaLunga
        '
        Me.TextTramaLunga.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextTramaLunga.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextTramaLunga.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTramaLunga.Location = New System.Drawing.Point(0, 117)
        Me.TextTramaLunga.Margin = New System.Windows.Forms.Padding(3, 3, 16, 3)
        Me.TextTramaLunga.MinimumSize = New System.Drawing.Size(0, 22)
        Me.TextTramaLunga.Multiline = True
        Me.TextTramaLunga.Name = "TextTramaLunga"
        Me.TextTramaLunga.ReadOnly = True
        Me.TextTramaLunga.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextTramaLunga.Size = New System.Drawing.Size(611, 120)
        Me.TextTramaLunga.TabIndex = 42
        Me.TextTramaLunga.Visible = False
        '
        'ButtonToggleTrama
        '
        Me.ButtonToggleTrama.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonToggleTrama.Location = New System.Drawing.Point(520, 4)
        Me.ButtonToggleTrama.Name = "ButtonToggleTrama"
        Me.ButtonToggleTrama.Size = New System.Drawing.Size(88, 25)
        Me.ButtonToggleTrama.TabIndex = 41
        Me.ButtonToggleTrama.Text = "Espandi"
        Me.ButtonToggleTrama.UseVisualStyleBackColor = True
        '
        'TextTramaBreve
        '
        Me.TextTramaBreve.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextTramaBreve.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextTramaBreve.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTramaBreve.Location = New System.Drawing.Point(0, 32)
        Me.TextTramaBreve.Margin = New System.Windows.Forms.Padding(3, 3, 16, 3)
        Me.TextTramaBreve.MinimumSize = New System.Drawing.Size(0, 22)
        Me.TextTramaBreve.Multiline = True
        Me.TextTramaBreve.Name = "TextTramaBreve"
        Me.TextTramaBreve.ReadOnly = True
        Me.TextTramaBreve.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextTramaBreve.Size = New System.Drawing.Size(611, 85)
        Me.TextTramaBreve.TabIndex = 40
        '
        'IntestazioneTrama
        '
        Me.IntestazioneTrama.BackColor = System.Drawing.SystemColors.ControlLight
        Me.IntestazioneTrama.Dock = System.Windows.Forms.DockStyle.Top
        Me.IntestazioneTrama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntestazioneTrama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IntestazioneTrama.Location = New System.Drawing.Point(0, 0)
        Me.IntestazioneTrama.Name = "IntestazioneTrama"
        Me.IntestazioneTrama.Size = New System.Drawing.Size(611, 32)
        Me.IntestazioneTrama.TabIndex = 39
        Me.IntestazioneTrama.Text = "Trama"
        Me.IntestazioneTrama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        ListViewItem1.StateImageIndex = 0
        Me.ListaAttori.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.ListaAttori.Location = New System.Drawing.Point(0, 399)
        Me.ListaAttori.Margin = New System.Windows.Forms.Padding(3, 3, 16, 3)
        Me.ListaAttori.MultiSelect = False
        Me.ListaAttori.Name = "ListaAttori"
        Me.ListaAttori.Scrollable = False
        Me.ListaAttori.Size = New System.Drawing.Size(611, 35)
        Me.ListaAttori.TabIndex = 79
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
        Me.IntestazioneAttori.Location = New System.Drawing.Point(0, 367)
        Me.IntestazioneAttori.Name = "IntestazioneAttori"
        Me.IntestazioneAttori.Size = New System.Drawing.Size(611, 32)
        Me.IntestazioneAttori.TabIndex = 78
        Me.IntestazioneAttori.Text = "Attori"
        Me.IntestazioneAttori.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        ListViewItem6.StateImageIndex = 0
        Me.ListaGeneri.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem4, ListViewItem5, ListViewItem6})
        Me.ListaGeneri.Location = New System.Drawing.Point(0, 304)
        Me.ListaGeneri.Margin = New System.Windows.Forms.Padding(3, 3, 16, 3)
        Me.ListaGeneri.MultiSelect = False
        Me.ListaGeneri.Name = "ListaGeneri"
        Me.ListaGeneri.Scrollable = False
        Me.ListaGeneri.ShowGroups = False
        Me.ListaGeneri.Size = New System.Drawing.Size(611, 63)
        Me.ListaGeneri.SmallImageList = Me.IconeCategorieLibreria
        Me.ListaGeneri.TabIndex = 75
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
        Me.IntestazioneGeneri.Location = New System.Drawing.Point(0, 272)
        Me.IntestazioneGeneri.Name = "IntestazioneGeneri"
        Me.IntestazioneGeneri.Size = New System.Drawing.Size(611, 32)
        Me.IntestazioneGeneri.TabIndex = 77
        Me.IntestazioneGeneri.Text = "Generi"
        Me.IntestazioneGeneri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel3.Controls.Add(Me.PanelMusicisti)
        Me.Panel3.Controls.Add(Me.PanelAutori)
        Me.Panel3.Controls.Add(Me.PanelRegisti)
        Me.Panel3.Controls.Add(Me.PanelDurata)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 103)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(611, 169)
        Me.Panel3.TabIndex = 76
        '
        'PanelMusicisti
        '
        Me.PanelMusicisti.AutoSize = True
        Me.PanelMusicisti.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelMusicisti.Controls.Add(Me.LabMusicisti)
        Me.PanelMusicisti.Controls.Add(Me.PictureBox5)
        Me.PanelMusicisti.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMusicisti.Location = New System.Drawing.Point(0, 134)
        Me.PanelMusicisti.Name = "PanelMusicisti"
        Me.PanelMusicisti.Size = New System.Drawing.Size(611, 35)
        Me.PanelMusicisti.TabIndex = 27
        '
        'LabMusicisti
        '
        Me.LabMusicisti.AutoSize = True
        Me.LabMusicisti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMusicisti.Location = New System.Drawing.Point(32, 0)
        Me.LabMusicisti.MinimumSize = New System.Drawing.Size(0, 32)
        Me.LabMusicisti.Name = "LabMusicisti"
        Me.LabMusicisti.Size = New System.Drawing.Size(118, 32)
        Me.LabMusicisti.TabIndex = 15
        Me.LabMusicisti.Text = "Ennio Morricone"
        Me.LabMusicisti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.musica
        Me.PictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 13
        Me.PictureBox5.TabStop = False
        '
        'PanelAutori
        '
        Me.PanelAutori.AutoSize = True
        Me.PanelAutori.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelAutori.Controls.Add(Me.LabAutori)
        Me.PanelAutori.Controls.Add(Me.PictureBox6)
        Me.PanelAutori.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAutori.Location = New System.Drawing.Point(0, 99)
        Me.PanelAutori.Name = "PanelAutori"
        Me.PanelAutori.Size = New System.Drawing.Size(611, 35)
        Me.PanelAutori.TabIndex = 26
        '
        'LabAutori
        '
        Me.LabAutori.AutoSize = True
        Me.LabAutori.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabAutori.Location = New System.Drawing.Point(32, 0)
        Me.LabAutori.MinimumSize = New System.Drawing.Size(0, 32)
        Me.LabAutori.Name = "LabAutori"
        Me.LabAutori.Size = New System.Drawing.Size(95, 32)
        Me.LabAutori.TabIndex = 13
        Me.LabAutori.Text = "Stephen King"
        Me.LabAutori.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.autore
        Me.PictureBox6.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 11
        Me.PictureBox6.TabStop = False
        '
        'PanelRegisti
        '
        Me.PanelRegisti.AutoSize = True
        Me.PanelRegisti.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelRegisti.Controls.Add(Me.LabRegisti)
        Me.PanelRegisti.Controls.Add(Me.PictureBox4)
        Me.PanelRegisti.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelRegisti.Location = New System.Drawing.Point(0, 64)
        Me.PanelRegisti.Name = "PanelRegisti"
        Me.PanelRegisti.Size = New System.Drawing.Size(611, 35)
        Me.PanelRegisti.TabIndex = 25
        '
        'LabRegisti
        '
        Me.LabRegisti.AutoSize = True
        Me.LabRegisti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabRegisti.Location = New System.Drawing.Point(32, 0)
        Me.LabRegisti.MinimumSize = New System.Drawing.Size(0, 32)
        Me.LabRegisti.Name = "LabRegisti"
        Me.LabRegisti.Size = New System.Drawing.Size(108, 32)
        Me.LabRegisti.TabIndex = 7
        Me.LabRegisti.Text = "Sergio Leone"
        Me.LabRegisti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.camera
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'PanelDurata
        '
        Me.PanelDurata.AutoSize = True
        Me.PanelDurata.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelDurata.Controls.Add(Me.Label14)
        Me.PanelDurata.Controls.Add(Me.LabFineVisione)
        Me.PanelDurata.Controls.Add(Me.Label21)
        Me.PanelDurata.Controls.Add(Me.LabDurata)
        Me.PanelDurata.Controls.Add(Me.PictureBox3)
        Me.PanelDurata.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDurata.Location = New System.Drawing.Point(0, 32)
        Me.PanelDurata.MinimumSize = New System.Drawing.Size(0, 32)
        Me.PanelDurata.Name = "PanelDurata"
        Me.PanelDurata.Size = New System.Drawing.Size(611, 32)
        Me.PanelDurata.TabIndex = 24
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(214, 0)
        Me.Label14.Margin = New System.Windows.Forms.Padding(0)
        Me.Label14.MinimumSize = New System.Drawing.Size(0, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 32)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = ")"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabFineVisione
        '
        Me.LabFineVisione.AutoSize = True
        Me.LabFineVisione.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabFineVisione.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabFineVisione.Location = New System.Drawing.Point(165, 0)
        Me.LabFineVisione.Margin = New System.Windows.Forms.Padding(0)
        Me.LabFineVisione.MinimumSize = New System.Drawing.Size(0, 32)
        Me.LabFineVisione.Name = "LabFineVisione"
        Me.LabFineVisione.Size = New System.Drawing.Size(49, 32)
        Me.LabFineVisione.TabIndex = 11
        Me.LabFineVisione.Text = "23:58"
        Me.LabFineVisione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(81, 0)
        Me.Label21.Margin = New System.Windows.Forms.Padding(0)
        Me.Label21.MinimumSize = New System.Drawing.Size(0, 32)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(84, 32)
        Me.Label21.TabIndex = 10
        Me.Label21.Text = "(finiresti alle"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabDurata
        '
        Me.LabDurata.AutoSize = True
        Me.LabDurata.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabDurata.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabDurata.Location = New System.Drawing.Point(32, 0)
        Me.LabDurata.MinimumSize = New System.Drawing.Size(0, 32)
        Me.LabDurata.Name = "LabDurata"
        Me.LabDurata.Size = New System.Drawing.Size(49, 32)
        Me.LabDurata.TabIndex = 9
        Me.LabDurata.Text = "1h 20"
        Me.LabDurata.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox3.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.cronometro
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.MaximumSize = New System.Drawing.Size(0, 32)
        Me.PictureBox3.MinimumSize = New System.Drawing.Size(32, 32)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.PannelloNazione)
        Me.Panel1.Controls.Add(Me.PanelAnno)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.MinimumSize = New System.Drawing.Size(0, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(611, 32)
        Me.Panel1.TabIndex = 23
        '
        'PannelloNazione
        '
        Me.PannelloNazione.AutoSize = True
        Me.PannelloNazione.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PannelloNazione.Controls.Add(Me.NazionePic)
        Me.PannelloNazione.Controls.Add(Me.NazioneLab)
        Me.PannelloNazione.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PannelloNazione.Dock = System.Windows.Forms.DockStyle.Left
        Me.PannelloNazione.Location = New System.Drawing.Point(89, 0)
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
        Me.NazioneLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NazioneLab.Location = New System.Drawing.Point(38, 0)
        Me.NazioneLab.MinimumSize = New System.Drawing.Size(0, 32)
        Me.NazioneLab.Name = "NazioneLab"
        Me.NazioneLab.Size = New System.Drawing.Size(41, 32)
        Me.NazioneLab.TabIndex = 16
        Me.NazioneLab.Text = "USA"
        Me.NazioneLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelAnno
        '
        Me.PanelAnno.AutoSize = True
        Me.PanelAnno.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelAnno.Controls.Add(Me.LabAnno)
        Me.PanelAnno.Controls.Add(Me.PictureBox1)
        Me.PanelAnno.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelAnno.Location = New System.Drawing.Point(0, 0)
        Me.PanelAnno.MinimumSize = New System.Drawing.Size(0, 32)
        Me.PanelAnno.Name = "PanelAnno"
        Me.PanelAnno.Size = New System.Drawing.Size(89, 32)
        Me.PanelAnno.TabIndex = 53
        '
        'LabAnno
        '
        Me.LabAnno.AutoSize = True
        Me.LabAnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabAnno.Location = New System.Drawing.Point(32, 0)
        Me.LabAnno.Margin = New System.Windows.Forms.Padding(3, 0, 12, 0)
        Me.LabAnno.MinimumSize = New System.Drawing.Size(45, 32)
        Me.LabAnno.Name = "LabAnno"
        Me.LabAnno.Size = New System.Drawing.Size(45, 32)
        Me.LabAnno.TabIndex = 2
        Me.LabAnno.Text = "1959"
        Me.LabAnno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.data
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(0, 32)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(32, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelNote
        '
        Me.PanelNote.AutoSize = True
        Me.PanelNote.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelNote.Controls.Add(Me.LabNote)
        Me.PanelNote.Controls.Add(Me.PictureBox7)
        Me.PanelNote.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelNote.Location = New System.Drawing.Point(0, 66)
        Me.PanelNote.Name = "PanelNote"
        Me.PanelNote.Size = New System.Drawing.Size(611, 37)
        Me.PanelNote.TabIndex = 74
        '
        'LabNote
        '
        Me.LabNote.AutoSize = True
        Me.LabNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabNote.Location = New System.Drawing.Point(38, 0)
        Me.LabNote.MinimumSize = New System.Drawing.Size(0, 32)
        Me.LabNote.Name = "LabNote"
        Me.LabNote.Size = New System.Drawing.Size(96, 32)
        Me.LabNote.TabIndex = 7
        Me.LabNote.Text = "Director's cut"
        Me.LabNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.note
        Me.PictureBox7.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(32, 34)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 1
        Me.PictureBox7.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label2.Location = New System.Drawing.Point(0, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 28)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "TitoloOriginale"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 38)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Titolo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'BarraStrumentiFilm
        '
        Me.BarraStrumentiFilm.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarraStrumentiFilm.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BarraStrumentiFilm.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.BarraStrumentiFilm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayButton, Me.EsploraRisorseButton, Me.RinominaButton, Me.DownloadButton, Me.CercaInternetButton, Me.ToolStripButton5})
        Me.BarraStrumentiFilm.Location = New System.Drawing.Point(0, 637)
        Me.BarraStrumentiFilm.Name = "BarraStrumentiFilm"
        Me.BarraStrumentiFilm.Size = New System.Drawing.Size(632, 47)
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
        Me.GoogleToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.GoogleToolStripMenuItem.Text = "Google"
        '
        'WikiITToolStripMenuItem
        '
        Me.WikiITToolStripMenuItem.Name = "WikiITToolStripMenuItem"
        Me.WikiITToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.WikiITToolStripMenuItem.Text = "Wikipedia IT"
        '
        'IMDBToolStripMenuItem
        '
        Me.IMDBToolStripMenuItem.Name = "IMDBToolStripMenuItem"
        Me.IMDBToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
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
        'PlaceholderPannelloDx
        '
        Me.PlaceholderPannelloDx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlaceholderPannelloDx.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaceholderPannelloDx.ForeColor = System.Drawing.Color.Gray
        Me.PlaceholderPannelloDx.Location = New System.Drawing.Point(0, 0)
        Me.PlaceholderPannelloDx.Name = "PlaceholderPannelloDx"
        Me.PlaceholderPannelloDx.Size = New System.Drawing.Size(632, 684)
        Me.PlaceholderPannelloDx.TabIndex = 89
        Me.PlaceholderPannelloDx.Text = "Seleziona un film per vedere qui i dettagli."
        Me.PlaceholderPannelloDx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.AlberoCategorieLibreria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AlberoCategorieLibreria.Name = "AlberoCategorieLibreria"
        TreeNode1.ImageIndex = 1
        TreeNode1.Name = "Nodo0"
        TreeNode1.SelectedImageIndex = 1
        TreeNode1.Text = "Tutti i film"
        TreeNode2.ImageIndex = 2
        TreeNode2.Name = "Node0"
        TreeNode2.SelectedImageIndex = 2
        TreeNode2.Text = "Registi"
        TreeNode3.ImageIndex = 3
        TreeNode3.Name = "Node1"
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
        TreeNode17.Name = "Node2"
        TreeNode17.SelectedImageIndex = 4
        TreeNode17.Text = "Generi"
        TreeNode18.Name = "Node28"
        TreeNode18.Text = "1900s"
        TreeNode19.Name = "Node29"
        TreeNode19.Text = "1910s"
        TreeNode20.Name = "Node30"
        TreeNode20.Text = "1920s"
        TreeNode21.Name = "Node31"
        TreeNode21.Text = "1930s"
        TreeNode22.Name = "Node32"
        TreeNode22.Text = "1940s"
        TreeNode23.Name = "Node33"
        TreeNode23.Text = "1950s"
        TreeNode24.Name = "Node34"
        TreeNode24.Text = "1960s"
        TreeNode25.Name = "Node35"
        TreeNode25.Text = "1970s"
        TreeNode26.Name = "Node36"
        TreeNode26.Text = "1980s"
        TreeNode27.Name = "Node37"
        TreeNode27.Text = "1990s"
        TreeNode28.Name = "Node38"
        TreeNode28.Text = "2000s"
        TreeNode29.Name = "Node39"
        TreeNode29.Text = "2010s"
        TreeNode30.Name = "Node40"
        TreeNode30.Text = "2020s"
        TreeNode31.ImageIndex = 5
        TreeNode31.Name = "Node4"
        TreeNode31.SelectedImageIndex = 5
        TreeNode31.Text = "Anni"
        TreeNode32.ImageIndex = 6
        TreeNode32.Name = "Nodo1"
        TreeNode32.SelectedImageIndex = 6
        TreeNode32.Text = "Nazioni"
        TreeNode33.ImageIndex = 7
        TreeNode33.Name = "Nodo0"
        TreeNode33.SelectedImageIndex = 7
        TreeNode33.Text = "Autori"
        TreeNode34.ImageIndex = 8
        TreeNode34.Name = "Nodo1"
        TreeNode34.SelectedImageIndex = 8
        TreeNode34.Text = "Musicisti"
        TreeNode35.ImageIndex = 9
        TreeNode35.Name = "Node3"
        TreeNode35.SelectedImageIndex = 9
        TreeNode35.Text = "Temi"
        TreeNode36.Name = "Node19"
        TreeNode36.Text = "Antica Grecia"
        TreeNode37.Name = "Node20"
        TreeNode37.Text = "Antica Roma"
        TreeNode38.Name = "Node21"
        TreeNode38.Text = "Medioevo"
        TreeNode39.Name = "Node22"
        TreeNode39.Text = "Cinquecento"
        TreeNode40.Name = "Node23"
        TreeNode40.Text = "Seicento"
        TreeNode41.Name = "Node24"
        TreeNode41.Text = "Settecento"
        TreeNode42.Name = "Node25"
        TreeNode42.Text = "Ottocento"
        TreeNode43.Name = "Node41"
        TreeNode43.Text = "Prima guerra mondiale"
        TreeNode44.Name = "Node42"
        TreeNode44.Text = "Seconda guerra mondiale"
        TreeNode45.Name = "Node27"
        TreeNode45.Text = "Vietnam"
        TreeNode46.Name = "Node43"
        TreeNode46.Text = "Anni di piombo"
        TreeNode47.Name = "Node26"
        TreeNode47.Text = "Novecento"
        TreeNode48.ImageIndex = 10
        TreeNode48.Name = "Node18"
        TreeNode48.SelectedImageIndex = 10
        TreeNode48.Text = "Ambientazione"
        Me.AlberoCategorieLibreria.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode17, TreeNode31, TreeNode32, TreeNode33, TreeNode34, TreeNode35, TreeNode48})
        Me.AlberoCategorieLibreria.SelectedImageIndex = 0
        Me.AlberoCategorieLibreria.ShowNodeToolTips = True
        Me.AlberoCategorieLibreria.ShowRootLines = False
        Me.AlberoCategorieLibreria.Size = New System.Drawing.Size(147, 447)
        Me.AlberoCategorieLibreria.TabIndex = 1
        '
        'SplitContainerSX_CDX
        '
        Me.SplitContainerSX_CDX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerSX_CDX.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainerSX_CDX.Location = New System.Drawing.Point(0, 59)
        Me.SplitContainerSX_CDX.Name = "SplitContainerSX_CDX"
        '
        'SplitContainerSX_CDX.Panel1
        '
        Me.SplitContainerSX_CDX.Panel1.Controls.Add(Me.SplitContainer1)
        Me.SplitContainerSX_CDX.Panel1MinSize = 50
        '
        'SplitContainerSX_CDX.Panel2
        '
        Me.SplitContainerSX_CDX.Panel2.Controls.Add(Me.SplitContainerC_DX)
        Me.SplitContainerSX_CDX.Panel2MinSize = 140
        Me.SplitContainerSX_CDX.Size = New System.Drawing.Size(1193, 684)
        Me.SplitContainerSX_CDX.SplitterDistance = 147
        Me.SplitContainerSX_CDX.SplitterIncrement = 10
        Me.SplitContainerSX_CDX.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.AlberoCategorieLibreria)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label12)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label13)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PicImgPersona)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ButImgPersona)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabNomePersona)
        Me.SplitContainer1.Size = New System.Drawing.Size(147, 684)
        Me.SplitContainer1.SplitterDistance = 447
        Me.SplitContainer1.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoEllipsis = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(0, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(147, 20)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Periodo attività:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(0, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(147, 20)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "1926 - 1963"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicImgPersona
        '
        Me.PicImgPersona.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicImgPersona.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PicImgPersona.Location = New System.Drawing.Point(0, 76)
        Me.PicImgPersona.Name = "PicImgPersona"
        Me.PicImgPersona.Size = New System.Drawing.Size(147, 131)
        Me.PicImgPersona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicImgPersona.TabIndex = 5
        Me.PicImgPersona.TabStop = False
        '
        'ButImgPersona
        '
        Me.ButImgPersona.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButImgPersona.Location = New System.Drawing.Point(0, 207)
        Me.ButImgPersona.Name = "ButImgPersona"
        Me.ButImgPersona.Size = New System.Drawing.Size(147, 26)
        Me.ButImgPersona.TabIndex = 4
        Me.ButImgPersona.Text = "Cambia immagine"
        Me.ButImgPersona.UseVisualStyleBackColor = True
        '
        'LabNomePersona
        '
        Me.LabNomePersona.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabNomePersona.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabNomePersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabNomePersona.Location = New System.Drawing.Point(0, 0)
        Me.LabNomePersona.Name = "LabNomePersona"
        Me.LabNomePersona.Size = New System.Drawing.Size(147, 60)
        Me.LabNomePersona.TabIndex = 0
        Me.LabNomePersona.Text = "Label32"
        Me.LabNomePersona.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 743)
        Me.Controls.Add(Me.SplitContainerSX_CDX)
        Me.Controls.Add(Me.BarraStrumentiPrincipale)
        Me.Location = New System.Drawing.Point(0, 19)
        Me.MinimumSize = New System.Drawing.Size(250, 150)
        Me.Name = "MainForm"
        Me.Text = "Gestore Libreria Film"
        Me.BarraStrumentiPrincipale.ResumeLayout(False)
        Me.BarraStrumentiPrincipale.PerformLayout()
        Me.SplitContainerC_DX.Panel1.ResumeLayout(False)
        Me.SplitContainerC_DX.Panel1.PerformLayout()
        Me.SplitContainerC_DX.Panel2.ResumeLayout(False)
        Me.SplitContainerC_DX.Panel2.PerformLayout()
        Me.SplitContainerC_DX.ResumeLayout(False)
        Me.SplitContainerFiltriAvanzati_Icone.Panel1.ResumeLayout(False)
        Me.SplitContainerFiltriAvanzati_Icone.Panel1.PerformLayout()
        Me.SplitContainerFiltriAvanzati_Icone.Panel2.ResumeLayout(False)
        Me.SplitContainerFiltriAvanzati_Icone.ResumeLayout(False)
        Me.PannelloFiltriAvanzati.ResumeLayout(False)
        Me.PannelloFiltriAvanzati.PerformLayout()
        CType(Me.FiltroBitrateMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FiltroRisoluzioneMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FiltroAnnoMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FiltroDurataMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FiltroAnnoMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FiltroDurataMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PannelloFiltri.ResumeLayout(False)
        Me.PannelloNomeCategoria.ResumeLayout(False)
        CType(Me.PicCategoriaScelta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PannelloFiltriSemplici.ResumeLayout(False)
        Me.PannelloFiltriSemplici.PerformLayout()
        Me.PannelloEsitoFiltri.ResumeLayout(False)
        Me.SplitImmagineDettagli.Panel1.ResumeLayout(False)
        Me.SplitImmagineDettagli.Panel2.ResumeLayout(False)
        Me.SplitImmagineDettagli.ResumeLayout(False)
        Me.SplitPosterSchermata.Panel1.ResumeLayout(False)
        Me.SplitPosterSchermata.Panel2.ResumeLayout(False)
        Me.SplitPosterSchermata.ResumeLayout(False)
        CType(Me.PicPoster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSchermata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RiquadroDestraPanel.ResumeLayout(False)
        Me.RiquadroDestraPanel.PerformLayout()
        Me.PanelFile.ResumeLayout(False)
        Me.PannelloSottotitoli.ResumeLayout(False)
        Me.PannelloAudio.ResumeLayout(False)
        Me.PannelloVideo.ResumeLayout(False)
        Me.PannelloVideo.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PannelloCodecVideo.ResumeLayout(False)
        Me.PannelloCodecVideo.PerformLayout()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PannelloRisoluzione.ResumeLayout(False)
        Me.PannelloRisoluzione.PerformLayout()
        Me.BadgeRisoluzione.ResumeLayout(False)
        Me.BadgeRisoluzione.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.PannelloFPS.ResumeLayout(False)
        Me.PannelloFPS.PerformLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PannelloProporzioni.ResumeLayout(False)
        Me.PannelloProporzioni.PerformLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PannelloBitrateVideo.ResumeLayout(False)
        Me.PannelloBitrateVideo.PerformLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PannelloContenitore.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.PanelValutazioni.ResumeLayout(False)
        Me.PanValutazioniCritica.ResumeLayout(False)
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
        Me.PanRotten.ResumeLayout(False)
        Me.PanMetacritic.ResumeLayout(False)
        Me.PanValutazioniPubblico.ResumeLayout(False)
        Me.PanIncassi.ResumeLayout(False)
        Me.PanNumVotiIMDB.ResumeLayout(False)
        Me.PanVotoIMDB.ResumeLayout(False)
        Me.PannelloTrama.ResumeLayout(False)
        Me.PannelloTrama.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.PanelMusicisti.ResumeLayout(False)
        Me.PanelMusicisti.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAutori.ResumeLayout(False)
        Me.PanelAutori.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRegisti.ResumeLayout(False)
        Me.PanelRegisti.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDurata.ResumeLayout(False)
        Me.PanelDurata.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PannelloNazione.ResumeLayout(False)
        Me.PannelloNazione.PerformLayout()
        CType(Me.NazionePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAnno.ResumeLayout(False)
        Me.PanelAnno.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelNote.ResumeLayout(False)
        Me.PanelNote.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraStrumentiFilm.ResumeLayout(False)
        Me.BarraStrumentiFilm.PerformLayout()
        Me.SplitContainerSX_CDX.Panel1.ResumeLayout(False)
        Me.SplitContainerSX_CDX.Panel2.ResumeLayout(False)
        Me.SplitContainerSX_CDX.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PicImgPersona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarraStrumentiPrincipale As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents IconePiccoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IconeGrandiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ColonneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IconeCategorieLibreria As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainerC_DX As System.Windows.Forms.SplitContainer
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
    Friend WithEvents SplitContainerSX_CDX As System.Windows.Forms.SplitContainer
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
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents TitoloItalianoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NazioneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DurataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DiscendenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PannelloFiltri As System.Windows.Forms.Panel
    Friend WithEvents BottCerca As System.Windows.Forms.Button
    Friend WithEvents CasellaRicerca As System.Windows.Forms.TextBox
    Friend WithEvents BottMostraFiltri As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FiltroAnnoMax As System.Windows.Forms.TrackBar
    Friend WithEvents FiltroAnnoMin As System.Windows.Forms.TrackBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SplitContainerFiltriAvanzati_Icone As System.Windows.Forms.SplitContainer
    Friend WithEvents BottFiltra As System.Windows.Forms.Button
    Friend WithEvents BottCancellaFiltri As System.Windows.Forms.Button
    Friend WithEvents LabEsitoFiltri As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents FiltroDurataMin As System.Windows.Forms.TrackBar
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents FiltroDurataMax As System.Windows.Forms.TrackBar
    Friend WithEvents PannelloFiltriAvanzati As System.Windows.Forms.Panel
    Friend WithEvents PannelloFiltriSemplici As System.Windows.Forms.Panel
    Friend WithEvents PannelloEsitoFiltri As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents FiltroGeneri As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FiltroNazioni As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TitoloItalianoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnnoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NazioneToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DurataToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PannelloNomeCategoria As System.Windows.Forms.Panel
    Friend WithEvents PicCategoriaScelta As System.Windows.Forms.PictureBox
    Friend WithEvents PlaceholderCasellaRicerca As System.Windows.Forms.Label
    Friend WithEvents LabConteggioCategoriaScelta As System.Windows.Forms.Label
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents DefinizioneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BitrateToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DefinizioneToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BitrateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FiltroRisoluzioneMin As System.Windows.Forms.TrackBar
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents FiltroBitrateMin As System.Windows.Forms.TrackBar
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents ButtPannelloSchermata As System.Windows.Forms.Button
    Friend WithEvents SplitImmagineDettagli As System.Windows.Forms.SplitContainer
    Friend WithEvents PicSchermata As System.Windows.Forms.PictureBox
    Friend WithEvents RiquadroDestraPanel As System.Windows.Forms.Panel
    Friend WithEvents PanelFile As System.Windows.Forms.Panel
    Friend WithEvents PannelloSottotitoli As System.Windows.Forms.Panel
    Friend WithEvents RTFSottotitoli As System.Windows.Forms.RichTextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents PannelloAudio As System.Windows.Forms.Panel
    Friend WithEvents RTFAudio As System.Windows.Forms.RichTextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents RigaSottoAudio As System.Windows.Forms.Panel
    Friend WithEvents PannelloVideo As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PannelloCodecVideo As System.Windows.Forms.Panel
    Friend WithEvents LabCodecVideo As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents PictureBox15 As System.Windows.Forms.PictureBox
    Friend WithEvents PannelloRisoluzione As System.Windows.Forms.Panel
    Friend WithEvents BadgeRisoluzione As System.Windows.Forms.Panel
    Friend WithEvents LabAltezzaRisoluzione As System.Windows.Forms.Label
    Friend WithEvents LabTipoRisoluzione As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PannelloFPS As System.Windows.Forms.Panel
    Friend WithEvents LabFPS As System.Windows.Forms.Label
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents PannelloProporzioni As System.Windows.Forms.Panel
    Friend WithEvents LabProporzioni As System.Windows.Forms.Label
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents PannelloBitrateVideo As System.Windows.Forms.Panel
    Friend WithEvents LabBitrateVideo As System.Windows.Forms.Label
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents RigaSottoVideo As System.Windows.Forms.Panel
    Friend WithEvents PannelloContenitore As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents LabBitrateFile As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents LabDimensioneFile As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents LabCodecFile As System.Windows.Forms.Label
    Friend WithEvents LabEstensione As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents RigaSottoFile As System.Windows.Forms.Panel
    Friend WithEvents IntestazioneFile As System.Windows.Forms.Label
    Friend WithEvents PanelValutazioni As System.Windows.Forms.Panel
    Friend WithEvents IntestazioneValutazioni As System.Windows.Forms.Label
    Friend WithEvents PannelloTrama As System.Windows.Forms.Panel
    Friend WithEvents TextTramaBreve As System.Windows.Forms.TextBox
    Friend WithEvents IntestazioneTrama As System.Windows.Forms.Label
    Friend WithEvents ListaAttori As System.Windows.Forms.ListView
    Friend WithEvents IntestazioneAttori As System.Windows.Forms.Label
    Friend WithEvents ListaGeneri As System.Windows.Forms.ListView
    Friend WithEvents IntestazioneGeneri As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PanelMusicisti As System.Windows.Forms.Panel
    Friend WithEvents LabMusicisti As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelAutori As System.Windows.Forms.Panel
    Friend WithEvents LabAutori As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelRegisti As System.Windows.Forms.Panel
    Friend WithEvents LabRegisti As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelDurata As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LabFineVisione As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents LabDurata As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PannelloNazione As System.Windows.Forms.Panel
    Friend WithEvents NazionePic As System.Windows.Forms.PictureBox
    Friend WithEvents NazioneLab As System.Windows.Forms.Label
    Friend WithEvents PanelAnno As System.Windows.Forms.Panel
    Friend WithEvents LabAnno As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelNote As System.Windows.Forms.Panel
    Friend WithEvents LabNote As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PlaceholderPannelloDx As System.Windows.Forms.Label
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents PrimaRigaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TitoloITAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TitoloOriginaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SecondaRigaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TerzaRigaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents LabNomePersona As System.Windows.Forms.Label
    Friend WithEvents LabValoreCategoriaScelta As System.Windows.Forms.Label
    Friend WithEvents LabCategoriaScelta As System.Windows.Forms.Label
    Friend WithEvents ButImgPersona As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PicImgPersona As System.Windows.Forms.PictureBox
    Friend WithEvents TextTramaLunga As System.Windows.Forms.TextBox
    Friend WithEvents ButtonToggleTrama As System.Windows.Forms.Button
    Friend WithEvents PanValutazioniCritica As System.Windows.Forms.Panel
    Friend WithEvents PanValutazioniPubblico As System.Windows.Forms.Panel
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
    Friend WithEvents PanRotten As System.Windows.Forms.Panel
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents LabRotten As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents PanMetacritic As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LabMetacritic As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents PanIncassi As System.Windows.Forms.Panel
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents LabMoltiplicatoreIncassi As System.Windows.Forms.Label
    Friend WithEvents LabIncassi As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents PanNumVotiIMDB As System.Windows.Forms.Panel
    Friend WithEvents LabMoltiplicatoreNumVotiIMDB As System.Windows.Forms.Label
    Friend WithEvents LabNumVotiIMDB As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents PanVotoIMDB As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LabVotoIMDB As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents SplitPosterSchermata As System.Windows.Forms.SplitContainer
    Friend WithEvents PicPoster As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SchermataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PosterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PosterFilmPiccoli As System.Windows.Forms.ImageList
    Friend WithEvents PosterFilmGrandi As System.Windows.Forms.ImageList

End Class
