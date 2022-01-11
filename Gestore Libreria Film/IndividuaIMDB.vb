Imports Newtonsoft.Json.Linq

Public Class IndividuaIMDB

    Dim Film As Film
    Public IdIMDB As String

    Sub CaricaInfoFilm(Film As Film)
        Me.IdIMDB = Nothing

        Me.Film = Film
        TextNomeFile.Text = Film.NomeFile.Replace("." + Film.Estensione, "")

        If (Not IsNothing(Film.TitoloITA) AndAlso Film.TitoloITA.Length <> 0) Then
            TextTitolo.Text = Film.TitoloITA
        Else
            If (Not IsNothing(Film.TitoloORIG) AndAlso Film.TitoloORIG.Length <> 0) Then
                TextTitolo.Text = Film.TitoloORIG
            Else
                TextTitolo.Text = ""
            End If
        End If

        UpDownAnno.Maximum = My.Computer.Clock.LocalTime.Year
        If (Film.Anno <> 0) Then
            CheckAnnoSconosciuto.Checked = False
            UpDownAnno.Value = Film.Anno
        Else
            UpDownAnno.Value = UpDownAnno.Maximum
            CheckAnnoSconosciuto.Checked = True
        End If

        If (MainModule.ModalitaNotte) Then
            Me.ForeColor = Color.White
            TextTitolo.ForeColor = Color.White
            TextNomeFile.ForeColor = Color.White
            LinkApriFile.LinkColor = Color.Yellow

            Me.BackColor = Color.Black
            TextNomeFile.BackColor = Color.Black
            TextTitolo.BackColor = Color.FromArgb(32, 32, 32)
            ButtCerca.BackColor = Color.FromArgb(32, 32, 32)
            ButtAnnulla.BackColor = Color.FromArgb(32, 32, 32)
            ButtNessunaScheda.BackColor = Color.FromArgb(32, 32, 32)
        End If
    End Sub

    Private Sub IndividuaIMDB_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Cerca()
    End Sub

    Sub Cerca() Handles ButtCerca.Click
        If (TextTitolo.Text.Length = 0) Then Return
        If (Not My.Computer.Network.IsAvailable) Then
            MessageBox.Show("Connessione internet assente!", "Impossibile cercare", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Me.UseWaitCursor = True
        ButtCerca.Enabled = False

        Dim PaginaRisultatiRicerca As String = MainModule.RicercaIMDBperTitolo(TextTitolo.Text)
        Dim ElencoRisultatiFiltrato As String = MainModule.ProcessaRispostaIMDB(PaginaRisultatiRicerca, If(CheckAnnoSconosciuto.Checked, 0, UpDownAnno.Value))(0)
        Dim PathElencoFiltrato As String = MainModule.IncorniciaCorpoHTML(ElencoRisultatiFiltrato, True)

        WebBrowser.Navigate(PathElencoFiltrato)
        Me.UseWaitCursor = False
        ButtCerca.Enabled = True
    End Sub

    Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowser.Navigating
        If (IsNothing(e.Url)) Then Return
        Dim URL As String = e.Url.LocalPath
        Dim UnitaSistema As String = URL.Substring(0, 3)
        URL = URL.Replace(UnitaSistema, "")
        If (URL.StartsWith("title\")) Then
            WebBrowser.Stop()
            URL = URL.Replace("title\", "")
            If (URL.Contains("\")) Then
                Me.IdIMDB = URL.Substring(0, URL.IndexOf("\"))
            Else
                Me.IdIMDB = URL
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub ButtNessunaScheda_Click(sender As Object, e As EventArgs) Handles ButtNessunaScheda.Click
        If (MessageBox.Show("Non verranno scaricate informazioni extra da IMDB per il film (poster, recensioni, ecc.), " +
                            "ed eventuali informazioni presenti saranno cancellate." + Chr(10) + Chr(10) +
                            "Non verranno fatti ulteriori tentativi di individuare la scheda; se in futuro cambi idea, " +
                            "dovrai indicare manualmente la scheda IMDB." + Chr(10) + Chr(10) + "Proseguire?", "Sei sicuro?",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes) Then
            MainModule.ScollegaSchedeIMDB(Film)
            Me.IdIMDB = Nothing
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub IndividuaIMDB_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        WebBrowser.Navigate("about:blank")
    End Sub

    Private Sub LinkApriFile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkApriFile.LinkClicked
        If (My.Computer.FileSystem.FileExists(Film.PercorsoFile)) Then
            Process.Start(Film.PercorsoFile)
        End If
    End Sub

    Private Sub TextTitolo_TextChanged(sender As Object, e As EventArgs) Handles TextTitolo.TextChanged
        ButtCerca.Enabled = Not (TextTitolo.Text.Length = 0)
    End Sub

    Private Sub ButtAnnulla_Click(sender As Object, e As EventArgs) Handles ButtAnnulla.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub TextTitolo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextTitolo.KeyPress
        If (e.KeyChar = Chr(10)) Then
            Cerca()
        End If
    End Sub

    Private Sub CheckAnnoSconosciuto_CheckedChanged(sender As Object, e As EventArgs) Handles CheckAnnoSconosciuto.CheckedChanged
        UpDownAnno.Enabled = Not CheckAnnoSconosciuto.Checked
    End Sub
End Class