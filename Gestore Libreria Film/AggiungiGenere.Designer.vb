<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AggiungiGenere
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AggiungiGenere))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextGenere = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListGeneriEsistenti = New System.Windows.Forms.ListView()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Inserisci il nome del genere:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 40)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Oppure scegline uno già esistente nella libreria:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextGenere
        '
        Me.TextGenere.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextGenere.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextGenere.Location = New System.Drawing.Point(12, 32)
        Me.TextGenere.Name = "TextGenere"
        Me.TextGenere.Size = New System.Drawing.Size(225, 30)
        Me.TextGenere.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(87, 423)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListGeneriEsistenti
        '
        Me.ListGeneriEsistenti.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListGeneriEsistenti.LargeImageList = Me.ImageList
        Me.ListGeneriEsistenti.Location = New System.Drawing.Point(12, 108)
        Me.ListGeneriEsistenti.Name = "ListGeneriEsistenti"
        Me.ListGeneriEsistenti.Size = New System.Drawing.Size(225, 309)
        Me.ListGeneriEsistenti.SmallImageList = Me.ImageList
        Me.ListGeneriEsistenti.TabIndex = 18
        Me.ListGeneriEsistenti.UseCompatibleStateImageBehavior = False
        Me.ListGeneriEsistenti.View = System.Windows.Forms.View.SmallIcon
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "animazione.png")
        Me.ImageList.Images.SetKeyName(1, "antica grecia.png")
        Me.ImageList.Images.SetKeyName(2, "antica Roma.png")
        Me.ImageList.Images.SetKeyName(3, "avventura.png")
        Me.ImageList.Images.SetKeyName(4, "azione.png")
        Me.ImageList.Images.SetKeyName(5, "biografico.png")
        Me.ImageList.Images.SetKeyName(6, "black humor.png")
        Me.ImageList.Images.SetKeyName(7, "catastrofico.png")
        Me.ImageList.Images.SetKeyName(8, "comico.png")
        Me.ImageList.Images.SetKeyName(9, "commedia.png")
        Me.ImageList.Images.SetKeyName(10, "drammatico.png")
        Me.ImageList.Images.SetKeyName(11, "droga.png")
        Me.ImageList.Images.SetKeyName(12, "fantascienza.png")
        Me.ImageList.Images.SetKeyName(13, "fantasmi.png")
        Me.ImageList.Images.SetKeyName(14, "fantasy.png")
        Me.ImageList.Images.SetKeyName(15, "finanza.png")
        Me.ImageList.Images.SetKeyName(16, "gangster 32.png")
        Me.ImageList.Images.SetKeyName(17, "gay.png")
        Me.ImageList.Images.SetKeyName(18, "giallo.png")
        Me.ImageList.Images.SetKeyName(19, "guerra.png")
        Me.ImageList.Images.SetKeyName(20, "horror.png")
        Me.ImageList.Images.SetKeyName(21, "informatica.png")
        Me.ImageList.Images.SetKeyName(22, "marinaresco 2.png")
        Me.ImageList.Images.SetKeyName(23, "matematica 2.png")
        Me.ImageList.Images.SetKeyName(24, "medioevo 2.png")
        Me.ImageList.Images.SetKeyName(25, "montagna.png")
        Me.ImageList.Images.SetKeyName(26, "motori.png")
        Me.ImageList.Images.SetKeyName(27, "musica.png")
        Me.ImageList.Images.SetKeyName(28, "musical.png")
        Me.ImageList.Images.SetKeyName(29, "natalizio 2.png")
        Me.ImageList.Images.SetKeyName(30, "noir.png")
        Me.ImageList.Images.SetKeyName(31, "poesia.png")
        Me.ImageList.Images.SetKeyName(32, "politico.png")
        Me.ImageList.Images.SetKeyName(33, "polizesco.png")
        Me.ImageList.Images.SetKeyName(34, "religione.png")
        Me.ImageList.Images.SetKeyName(35, "rock.png")
        Me.ImageList.Images.SetKeyName(36, "sanità.png")
        Me.ImageList.Images.SetKeyName(37, "satira 5.png")
        Me.ImageList.Images.SetKeyName(38, "scienza.png")
        Me.ImageList.Images.SetKeyName(39, "scuola.png")
        Me.ImageList.Images.SetKeyName(40, "sentimentale.png")
        Me.ImageList.Images.SetKeyName(41, "serial killer.png")
        Me.ImageList.Images.SetKeyName(42, "spazio.png")
        Me.ImageList.Images.SetKeyName(43, "spionaggio.png")
        Me.ImageList.Images.SetKeyName(44, "splatter.png")
        Me.ImageList.Images.SetKeyName(45, "sport.png")
        Me.ImageList.Images.SetKeyName(46, "storico.png")
        Me.ImageList.Images.SetKeyName(47, "surrealismo.png")
        Me.ImageList.Images.SetKeyName(48, "thriller.png")
        Me.ImageList.Images.SetKeyName(49, "treni.png")
        Me.ImageList.Images.SetKeyName(50, "ufo.png")
        Me.ImageList.Images.SetKeyName(51, "western.png")
        '
        'AggiungiGenere
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 465)
        Me.Controls.Add(Me.ListGeneriEsistenti)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextGenere)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AggiungiGenere"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Aggiungi genere"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextGenere As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListGeneriEsistenti As System.Windows.Forms.ListView
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
End Class
