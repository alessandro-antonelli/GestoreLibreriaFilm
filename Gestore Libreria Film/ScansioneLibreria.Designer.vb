<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScansioneLibreria
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
        Me.LabNumFileElaborati = New System.Windows.Forms.Label()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.LabPercentuale = New System.Windows.Forms.Label()
        Me.LabNomeFile = New System.Windows.Forms.Label()
        Me.PicThrobber = New System.Windows.Forms.PictureBox()
        Me.ButtInterrompi = New System.Windows.Forms.Button()
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.LabNumFileTotali = New System.Windows.Forms.Label()
        Me.LabAttività = New System.Windows.Forms.Label()
        CType(Me.PicThrobber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabNumFileElaborati
        '
        Me.LabNumFileElaborati.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabNumFileElaborati.Location = New System.Drawing.Point(12, 9)
        Me.LabNumFileElaborati.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LabNumFileElaborati.Name = "LabNumFileElaborati"
        Me.LabNumFileElaborati.Size = New System.Drawing.Size(43, 18)
        Me.LabNumFileElaborati.TabIndex = 6
        Me.LabNumFileElaborati.Text = "x"
        Me.LabNumFileElaborati.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabNumFileElaborati.UseWaitCursor = True
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar.Location = New System.Drawing.Point(12, 35)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(288, 30)
        Me.ProgressBar.TabIndex = 5
        Me.ProgressBar.UseWaitCursor = True
        '
        'LabPercentuale
        '
        Me.LabPercentuale.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabPercentuale.Location = New System.Drawing.Point(230, 9)
        Me.LabPercentuale.Name = "LabPercentuale"
        Me.LabPercentuale.Size = New System.Drawing.Size(70, 23)
        Me.LabPercentuale.TabIndex = 7
        Me.LabPercentuale.Text = "yy%"
        Me.LabPercentuale.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabPercentuale.UseWaitCursor = True
        '
        'LabNomeFile
        '
        Me.LabNomeFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabNomeFile.AutoEllipsis = True
        Me.LabNomeFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabNomeFile.Location = New System.Drawing.Point(12, 68)
        Me.LabNomeFile.Name = "LabNomeFile"
        Me.LabNomeFile.Size = New System.Drawing.Size(358, 55)
        Me.LabNomeFile.TabIndex = 8
        Me.LabNomeFile.Text = "Nome file"
        Me.LabNomeFile.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LabNomeFile.UseWaitCursor = True
        '
        'PicThrobber
        '
        Me.PicThrobber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicThrobber.Image = Global.GestoreLibreriaFilm.My.Resources.Resources.ThrobberIngranaggio
        Me.PicThrobber.Location = New System.Drawing.Point(306, 0)
        Me.PicThrobber.Name = "PicThrobber"
        Me.PicThrobber.Size = New System.Drawing.Size(65, 65)
        Me.PicThrobber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicThrobber.TabIndex = 9
        Me.PicThrobber.TabStop = False
        Me.PicThrobber.UseWaitCursor = True
        '
        'ButtInterrompi
        '
        Me.ButtInterrompi.Location = New System.Drawing.Point(132, 3)
        Me.ButtInterrompi.Name = "ButtInterrompi"
        Me.ButtInterrompi.Size = New System.Drawing.Size(92, 28)
        Me.ButtInterrompi.TabIndex = 10
        Me.ButtInterrompi.Text = "Interrompi"
        Me.ButtInterrompi.UseVisualStyleBackColor = True
        Me.ButtInterrompi.UseWaitCursor = True
        '
        'BackgroundWorker
        '
        Me.BackgroundWorker.WorkerReportsProgress = True
        Me.BackgroundWorker.WorkerSupportsCancellation = True
        '
        'LabNumFileTotali
        '
        Me.LabNumFileTotali.AutoSize = True
        Me.LabNumFileTotali.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabNumFileTotali.Location = New System.Drawing.Point(58, 9)
        Me.LabNumFileTotali.Name = "LabNumFileTotali"
        Me.LabNumFileTotali.Size = New System.Drawing.Size(45, 18)
        Me.LabNumFileTotali.TabIndex = 11
        Me.LabNumFileTotali.Text = "su tot"
        Me.LabNumFileTotali.UseWaitCursor = True
        '
        'LabAttività
        '
        Me.LabAttività.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabAttività.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabAttività.Location = New System.Drawing.Point(12, 123)
        Me.LabAttività.Name = "LabAttività"
        Me.LabAttività.Size = New System.Drawing.Size(358, 71)
        Me.LabAttività.TabIndex = 12
        Me.LabAttività.Text = "Nome attività eseguita"
        Me.LabAttività.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ScansioneLibreria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtInterrompi
        Me.ClientSize = New System.Drawing.Size(382, 203)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabAttività)
        Me.Controls.Add(Me.LabNumFileTotali)
        Me.Controls.Add(Me.ButtInterrompi)
        Me.Controls.Add(Me.PicThrobber)
        Me.Controls.Add(Me.LabNomeFile)
        Me.Controls.Add(Me.LabPercentuale)
        Me.Controls.Add(Me.LabNumFileElaborati)
        Me.Controls.Add(Me.ProgressBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ScansioneLibreria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Scansione libreria in corso..."
        Me.UseWaitCursor = True
        CType(Me.PicThrobber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabNumFileElaborati As System.Windows.Forms.Label
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents LabPercentuale As System.Windows.Forms.Label
    Friend WithEvents LabNomeFile As System.Windows.Forms.Label
    Friend WithEvents PicThrobber As System.Windows.Forms.PictureBox
    Friend WithEvents ButtInterrompi As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents LabNumFileTotali As System.Windows.Forms.Label
    Friend WithEvents LabAttività As System.Windows.Forms.Label
End Class
