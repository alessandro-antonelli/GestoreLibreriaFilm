<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IndividuaIMDB
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
        Me.ButtCerca = New System.Windows.Forms.Button()
        Me.TextTitolo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextNomeFile = New System.Windows.Forms.TextBox()
        Me.LinkApriFile = New System.Windows.Forms.LinkLabel()
        Me.ButtAnnulla = New System.Windows.Forms.Button()
        Me.WebBrowser = New System.Windows.Forms.WebBrowser()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UpDownAnno = New System.Windows.Forms.NumericUpDown()
        Me.CheckAnnoSconosciuto = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtNessunaScheda = New System.Windows.Forms.Button()
        CType(Me.UpDownAnno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtCerca
        '
        Me.ButtCerca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtCerca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtCerca.Location = New System.Drawing.Point(371, 254)
        Me.ButtCerca.Name = "ButtCerca"
        Me.ButtCerca.Size = New System.Drawing.Size(99, 28)
        Me.ButtCerca.TabIndex = 3
        Me.ButtCerca.Text = "Cerca"
        Me.ButtCerca.UseVisualStyleBackColor = True
        '
        'TextTitolo
        '
        Me.TextTitolo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextTitolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTitolo.Location = New System.Drawing.Point(63, 216)
        Me.TextTitolo.Multiline = True
        Me.TextTitolo.Name = "TextTitolo"
        Me.TextTitolo.Size = New System.Drawing.Size(407, 32)
        Me.TextTitolo.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Titolo"
        '
        'TextNomeFile
        '
        Me.TextNomeFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextNomeFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextNomeFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNomeFile.Location = New System.Drawing.Point(9, 78)
        Me.TextNomeFile.Multiline = True
        Me.TextNomeFile.Name = "TextNomeFile"
        Me.TextNomeFile.ReadOnly = True
        Me.TextNomeFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextNomeFile.Size = New System.Drawing.Size(461, 66)
        Me.TextNomeFile.TabIndex = 8
        Me.TextNomeFile.Text = "Nomefile" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nomefile"
        Me.TextNomeFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LinkApriFile
        '
        Me.LinkApriFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkApriFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkApriFile.Location = New System.Drawing.Point(390, 55)
        Me.LinkApriFile.Name = "LinkApriFile"
        Me.LinkApriFile.Size = New System.Drawing.Size(80, 20)
        Me.LinkApriFile.TabIndex = 9
        Me.LinkApriFile.TabStop = True
        Me.LinkApriFile.Text = "apri file"
        Me.LinkApriFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtAnnulla
        '
        Me.ButtAnnulla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtAnnulla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtAnnulla.Location = New System.Drawing.Point(289, 526)
        Me.ButtAnnulla.Name = "ButtAnnulla"
        Me.ButtAnnulla.Size = New System.Drawing.Size(181, 65)
        Me.ButtAnnulla.TabIndex = 11
        Me.ButtAnnulla.Text = "Annulla" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(non memorizzare alcunché)"
        Me.ButtAnnulla.UseVisualStyleBackColor = True
        '
        'WebBrowser
        '
        Me.WebBrowser.AllowWebBrowserDrop = False
        Me.WebBrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser.Location = New System.Drawing.Point(12, 288)
        Me.WebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.ScriptErrorsSuppressed = True
        Me.WebBrowser.Size = New System.Drawing.Size(458, 232)
        Me.WebBrowser.TabIndex = 13
        Me.WebBrowser.WebBrowserShortcutsEnabled = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Anno"
        '
        'UpDownAnno
        '
        Me.UpDownAnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpDownAnno.Location = New System.Drawing.Point(63, 254)
        Me.UpDownAnno.Maximum = New Decimal(New Integer() {2022, 0, 0, 0})
        Me.UpDownAnno.Minimum = New Decimal(New Integer() {1850, 0, 0, 0})
        Me.UpDownAnno.Name = "UpDownAnno"
        Me.UpDownAnno.Size = New System.Drawing.Size(78, 28)
        Me.UpDownAnno.TabIndex = 15
        Me.UpDownAnno.Value = New Decimal(New Integer() {2022, 0, 0, 0})
        '
        'CheckAnnoSconosciuto
        '
        Me.CheckAnnoSconosciuto.AutoSize = True
        Me.CheckAnnoSconosciuto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckAnnoSconosciuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckAnnoSconosciuto.Location = New System.Drawing.Point(158, 257)
        Me.CheckAnnoSconosciuto.Name = "CheckAnnoSconosciuto"
        Me.CheckAnnoSconosciuto.Size = New System.Drawing.Size(138, 24)
        Me.CheckAnnoSconosciuto.TabIndex = 16
        Me.CheckAnnoSconosciuto.Text = "Qualsiasi data"
        Me.CheckAnnoSconosciuto.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(458, 66)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Il Gestore non è riuscito a individuare automaticamente la scheda di IMDB relativ" & _
    "a al seguente film:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(458, 66)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Indica la scheda corretta cliccando sul link corrispondente. Se non è nella lista" & _
    ", prova a cambiare i criteri di ricerca."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'ButtNessunaScheda
        '
        Me.ButtNessunaScheda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtNessunaScheda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtNessunaScheda.Location = New System.Drawing.Point(12, 526)
        Me.ButtNessunaScheda.Name = "ButtNessunaScheda"
        Me.ButtNessunaScheda.Size = New System.Drawing.Size(271, 65)
        Me.ButtNessunaScheda.TabIndex = 19
        Me.ButtNessunaScheda.Text = "Nessuna scheda" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(memorizza ""scheda inesistente"" e non chiedere più)"
        Me.ButtNessunaScheda.UseVisualStyleBackColor = True
        '
        'IndividuaIMDB
        '
        Me.AcceptButton = Me.ButtCerca
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtAnnulla
        Me.ClientSize = New System.Drawing.Size(482, 603)
        Me.Controls.Add(Me.LinkApriFile)
        Me.Controls.Add(Me.ButtNessunaScheda)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckAnnoSconosciuto)
        Me.Controls.Add(Me.UpDownAnno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.WebBrowser)
        Me.Controls.Add(Me.ButtAnnulla)
        Me.Controls.Add(Me.TextNomeFile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextTitolo)
        Me.Controls.Add(Me.ButtCerca)
        Me.MinimumSize = New System.Drawing.Size(300, 400)
        Me.Name = "IndividuaIMDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Indica scheda IMDB"
        CType(Me.UpDownAnno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtCerca As System.Windows.Forms.Button
    Friend WithEvents TextTitolo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextNomeFile As System.Windows.Forms.TextBox
    Friend WithEvents LinkApriFile As System.Windows.Forms.LinkLabel
    Friend WithEvents ButtAnnulla As System.Windows.Forms.Button
    Friend WithEvents WebBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UpDownAnno As System.Windows.Forms.NumericUpDown
    Friend WithEvents CheckAnnoSconosciuto As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ButtNessunaScheda As System.Windows.Forms.Button
End Class
