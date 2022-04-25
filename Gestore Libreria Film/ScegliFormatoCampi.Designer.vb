<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScegliFormatoCampi
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Arancia meccanica", 0)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScegliFormatoCampi))
        Me.ButtSalva = New System.Windows.Forms.Button()
        Me.ButtAnnulla = New System.Windows.Forms.Button()
        Me.ElencoCampi = New System.Windows.Forms.CheckedListBox()
        Me.ElencoEsempio = New System.Windows.Forms.ListView()
        Me.ColTitolo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColAnno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColNazione = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColRegisti = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColGeneri = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColAttori = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColAutori = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColMusicisti = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SceltaStileAnteprima = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtSpostaSu = New System.Windows.Forms.Button()
        Me.ButtSpostaGiu = New System.Windows.Forms.Button()
        Me.ImmaginiGrandi = New System.Windows.Forms.ImageList(Me.components)
        Me.ImmaginiPiccole = New System.Windows.Forms.ImageList(Me.components)
        Me.SceltaOpzioniCampo = New System.Windows.Forms.ComboBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupOpzioni = New System.Windows.Forms.GroupBox()
        Me.GroupOpzioniNoTabella = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupOpzioni.SuspendLayout()
        Me.GroupOpzioniNoTabella.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtSalva
        '
        Me.ButtSalva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtSalva.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtSalva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtSalva.Location = New System.Drawing.Point(545, 414)
        Me.ButtSalva.Name = "ButtSalva"
        Me.ButtSalva.Size = New System.Drawing.Size(75, 27)
        Me.ButtSalva.TabIndex = 0
        Me.ButtSalva.Text = "Salva"
        Me.ButtSalva.UseVisualStyleBackColor = True
        '
        'ButtAnnulla
        '
        Me.ButtAnnulla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtAnnulla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtAnnulla.Location = New System.Drawing.Point(464, 414)
        Me.ButtAnnulla.Name = "ButtAnnulla"
        Me.ButtAnnulla.Size = New System.Drawing.Size(75, 27)
        Me.ButtAnnulla.TabIndex = 6
        Me.ButtAnnulla.Text = "Annulla"
        Me.ButtAnnulla.UseVisualStyleBackColor = True
        '
        'ElencoCampi
        '
        Me.ElencoCampi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ElencoCampi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElencoCampi.FormattingEnabled = True
        Me.ElencoCampi.Items.AddRange(New Object() {"Titolo italiano", "Titolo originale", "Anno", "Nazione", "Registi", "Attori", "Autori", "Musicisti", "Generi", "Durata", "Note", "Contenitore file", "Bitrate", "Risoluzione", "Lingue audio", "Lingue sottotitoli", "Voto IMDB", "Voto Rotten Tomatoes", "Voto Metacritic", "Numero voti su IMDB", "Incassi", "Oscar vinti", "Oscar nominati", "BAFTA vinti", "BAFTA nominati", "Altri premi vinti", "Altri premi nominati"})
        Me.ElencoCampi.Location = New System.Drawing.Point(12, 12)
        Me.ElencoCampi.Name = "ElencoCampi"
        Me.ElencoCampi.Size = New System.Drawing.Size(296, 142)
        Me.ElencoCampi.TabIndex = 7
        '
        'ElencoEsempio
        '
        Me.ElencoEsempio.AllowColumnReorder = True
        Me.ElencoEsempio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ElencoEsempio.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColTitolo, Me.ColAnno, Me.ColNazione, Me.ColRegisti, Me.ColGeneri, Me.ColAttori, Me.ColAutori, Me.ColMusicisti})
        Me.ElencoEsempio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElencoEsempio.FullRowSelect = True
        Me.ElencoEsempio.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ElencoEsempio.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.ElencoEsempio.LargeImageList = Me.ImmaginiGrandi
        Me.ElencoEsempio.Location = New System.Drawing.Point(6, 51)
        Me.ElencoEsempio.MultiSelect = False
        Me.ElencoEsempio.Name = "ElencoEsempio"
        Me.ElencoEsempio.OwnerDraw = True
        Me.ElencoEsempio.Size = New System.Drawing.Size(256, 339)
        Me.ElencoEsempio.SmallImageList = Me.ImmaginiPiccole
        Me.ElencoEsempio.TabIndex = 8
        Me.ElencoEsempio.TileSize = New System.Drawing.Size(125, 50)
        Me.ElencoEsempio.UseCompatibleStateImageBehavior = False
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
        'SceltaStileAnteprima
        '
        Me.SceltaStileAnteprima.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SceltaStileAnteprima.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SceltaStileAnteprima.Items.AddRange(New Object() {"Icone grandi", "Icone piccole", "Lista", "Dettagli/Colonne"})
        Me.SceltaStileAnteprima.Location = New System.Drawing.Point(6, 21)
        Me.SceltaStileAnteprima.Name = "SceltaStileAnteprima"
        Me.SceltaStileAnteprima.Size = New System.Drawing.Size(256, 26)
        Me.SceltaStileAnteprima.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.SceltaStileAnteprima)
        Me.GroupBox1.Controls.Add(Me.ElencoEsempio)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(352, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 396)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Anteprima"
        '
        'ButtSpostaSu
        '
        Me.ButtSpostaSu.Enabled = False
        Me.ButtSpostaSu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtSpostaSu.Location = New System.Drawing.Point(314, 12)
        Me.ButtSpostaSu.Name = "ButtSpostaSu"
        Me.ButtSpostaSu.Size = New System.Drawing.Size(32, 32)
        Me.ButtSpostaSu.TabIndex = 11
        Me.ButtSpostaSu.Text = "↑"
        Me.ButtSpostaSu.UseVisualStyleBackColor = True
        '
        'ButtSpostaGiu
        '
        Me.ButtSpostaGiu.Enabled = False
        Me.ButtSpostaGiu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtSpostaGiu.Location = New System.Drawing.Point(314, 50)
        Me.ButtSpostaGiu.Name = "ButtSpostaGiu"
        Me.ButtSpostaGiu.Size = New System.Drawing.Size(32, 32)
        Me.ButtSpostaGiu.TabIndex = 12
        Me.ButtSpostaGiu.Text = "↓"
        Me.ButtSpostaGiu.UseVisualStyleBackColor = True
        '
        'ImmaginiGrandi
        '
        Me.ImmaginiGrandi.ImageStream = CType(resources.GetObject("ImmaginiGrandi.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImmaginiGrandi.TransparentColor = System.Drawing.Color.Transparent
        Me.ImmaginiGrandi.Images.SetKeyName(0, "ciak semplice.png")
        '
        'ImmaginiPiccole
        '
        Me.ImmaginiPiccole.ImageStream = CType(resources.GetObject("ImmaginiPiccole.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImmaginiPiccole.TransparentColor = System.Drawing.Color.Transparent
        Me.ImmaginiPiccole.Images.SetKeyName(0, "ciak semplice.png")
        '
        'SceltaOpzioniCampo
        '
        Me.SceltaOpzioniCampo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SceltaOpzioniCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FlowLayoutPanel1.SetFlowBreak(Me.SceltaOpzioniCampo, True)
        Me.SceltaOpzioniCampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SceltaOpzioniCampo.Items.AddRange(New Object() {"Solo Cognome", "Cognome + Iniziale Nome", "Cognome, Nome", "Nome + Cognome"})
        Me.SceltaOpzioniCampo.Location = New System.Drawing.Point(148, 3)
        Me.SceltaOpzioniCampo.Name = "SceltaOpzioniCampo"
        Me.SceltaOpzioniCampo.Size = New System.Drawing.Size(154, 26)
        Me.SceltaOpzioniCampo.TabIndex = 15
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.SceltaOpzioniCampo)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel1.Controls.Add(Me.ComboBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel1.Controls.Add(Me.ComboBox3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.ComboBox2)
        Me.FlowLayoutPanel1.Controls.Add(Me.CheckBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.NumericUpDown2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.CheckBox2)
        Me.FlowLayoutPanel1.Controls.Add(Me.NumericUpDown1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 18)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(328, 169)
        Me.FlowLayoutPanel1.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.MinimumSize = New System.Drawing.Size(0, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 26)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Formato nominativi:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Enabled = False
        Me.NumericUpDown2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown2.Location = New System.Drawing.Point(177, 129)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(52, 28)
        Me.NumericUpDown2.TabIndex = 17
        Me.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown2.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.FlowLayoutPanel1.SetFlowBreak(Me.Label4, True)
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(235, 126)
        Me.Label4.MinimumSize = New System.Drawing.Size(0, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 28)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "elementi"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(3, 129)
        Me.CheckBox1.MinimumSize = New System.Drawing.Size(0, 28)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(168, 28)
        Me.CheckBox1.TabIndex = 19
        Me.CheckBox1.Text = "Limita elenco ai primi"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(3, 163)
        Me.CheckBox2.MinimumSize = New System.Drawing.Size(0, 28)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(233, 28)
        Me.CheckBox2.TabIndex = 22
        Me.CheckBox2.Text = "Tronca testo campo se supera"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Enabled = False
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(242, 163)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {250, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(60, 28)
        Me.NumericUpDown1.TabIndex = 20
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown1.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.FlowLayoutPanel1.SetFlowBreak(Me.Label3, True)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 194)
        Me.Label3.MinimumSize = New System.Drawing.Size(0, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 28)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "caratteri"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 30)
        Me.Label5.MinimumSize = New System.Drawing.Size(0, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 26)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Formato data:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FlowLayoutPanel1.SetFlowBreak(Me.ComboBox1, True)
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Items.AddRange(New Object() {"1984", "'84", "84"})
        Me.ComboBox1.Location = New System.Drawing.Point(110, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(61, 26)
        Me.ComboBox1.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.MinimumSize = New System.Drawing.Size(0, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 27)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Prima del campo:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2.SetFlowBreak(Me.TextBox2, True)
        Me.TextBox2.Font = New System.Drawing.Font("Lucida Console", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(118, 36)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(116, 27)
        Me.TextBox2.TabIndex = 26
        Me.TextBox2.Text = " - "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 33)
        Me.Label7.MinimumSize = New System.Drawing.Size(0, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 27)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Dopo il campo:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2.SetFlowBreak(Me.TextBox3, True)
        Me.TextBox3.Font = New System.Drawing.Font("Lucida Console", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(133, 3)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(116, 27)
        Me.TextBox3.TabIndex = 28
        '
        'GroupOpzioni
        '
        Me.GroupOpzioni.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupOpzioni.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupOpzioni.Location = New System.Drawing.Point(12, 160)
        Me.GroupOpzioni.Name = "GroupOpzioni"
        Me.GroupOpzioni.Size = New System.Drawing.Size(334, 190)
        Me.GroupOpzioni.TabIndex = 18
        Me.GroupOpzioni.TabStop = False
        Me.GroupOpzioni.Text = "Opzioni campo"
        Me.GroupOpzioni.Visible = False
        '
        'GroupOpzioniNoTabella
        '
        Me.GroupOpzioniNoTabella.Controls.Add(Me.FlowLayoutPanel2)
        Me.GroupOpzioniNoTabella.Location = New System.Drawing.Point(12, 356)
        Me.GroupOpzioniNoTabella.Name = "GroupOpzioniNoTabella"
        Me.GroupOpzioniNoTabella.Size = New System.Drawing.Size(331, 89)
        Me.GroupOpzioniNoTabella.TabIndex = 19
        Me.GroupOpzioniNoTabella.TabStop = False
        Me.GroupOpzioniNoTabella.Text = "Opzioni per le viste NON tabellari"
        Me.GroupOpzioniNoTabella.Visible = False
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBox3)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBox2)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 18)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(325, 68)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 94)
        Me.Label1.MinimumSize = New System.Drawing.Size(0, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 26)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Formato campo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FlowLayoutPanel1.SetFlowBreak(Me.ComboBox2, True)
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.Items.AddRange(New Object() {"Icona", "Sigla", "Nome completo"})
        Me.ComboBox2.Location = New System.Drawing.Point(128, 97)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(101, 26)
        Me.ComboBox2.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 62)
        Me.Label8.MinimumSize = New System.Drawing.Size(0, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 26)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Formato durata:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox3
        '
        Me.ComboBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FlowLayoutPanel1.SetFlowBreak(Me.ComboBox3, True)
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.Items.AddRange(New Object() {"1:45", "1 45'", "1h 45m", "1 ora 45 min", "1 ora 45 minuti", "105'", "105m", "105 min", "105 minuti", "1,75 h", "1,8 h"})
        Me.ComboBox3.Location = New System.Drawing.Point(123, 65)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(106, 26)
        Me.ComboBox3.TabIndex = 28
        '
        'ScegliFormatoCampi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtAnnulla
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.GroupOpzioni)
        Me.Controls.Add(Me.GroupOpzioniNoTabella)
        Me.Controls.Add(Me.ButtSpostaGiu)
        Me.Controls.Add(Me.ButtSpostaSu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ElencoCampi)
        Me.Controls.Add(Me.ButtAnnulla)
        Me.Controls.Add(Me.ButtSalva)
        Me.Name = "ScegliFormatoCampi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Scegli i campi"
        Me.GroupBox1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupOpzioni.ResumeLayout(False)
        Me.GroupOpzioniNoTabella.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtSalva As System.Windows.Forms.Button
    Friend WithEvents ButtAnnulla As System.Windows.Forms.Button
    Friend WithEvents ElencoCampi As System.Windows.Forms.CheckedListBox
    Friend WithEvents ElencoEsempio As System.Windows.Forms.ListView
    Friend WithEvents ColTitolo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColAnno As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColNazione As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColRegisti As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColGeneri As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColAttori As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColAutori As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColMusicisti As System.Windows.Forms.ColumnHeader
    Friend WithEvents SceltaStileAnteprima As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtSpostaSu As System.Windows.Forms.Button
    Friend WithEvents ButtSpostaGiu As System.Windows.Forms.Button
    Friend WithEvents ImmaginiGrandi As System.Windows.Forms.ImageList
    Friend WithEvents ImmaginiPiccole As System.Windows.Forms.ImageList
    Friend WithEvents SceltaOpzioniCampo As System.Windows.Forms.ComboBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupOpzioni As System.Windows.Forms.GroupBox
    Friend WithEvents GroupOpzioniNoTabella As System.Windows.Forms.GroupBox
End Class
