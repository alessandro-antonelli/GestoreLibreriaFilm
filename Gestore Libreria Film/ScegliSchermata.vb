
Public Class ScegliSchermata

    Dim Film As Film
    Dim PercorsoSchermataAnteprima As String
    Dim IndiceIcona As UShort

    Sub InizializzaFinestra(Film As Film, IndiceIcona As UShort)
        Me.Film = Film
        Me.IndiceIcona = IndiceIcona
        Me.LinkLabel1.Text = Film.TitoloITA + If(Not IsNothing(Film.Anno), " [" + Film.Anno.ToString + "]", "")

        PictureBox1.Image = Nothing
        Dim PathSchermataEsistente As String = MainModule.PercorsoSchermataFilm(Film.NomeFile)
        If (My.Computer.FileSystem.FileExists(PathSchermataEsistente)) Then
            PictureBox1.ImageLocation = PathSchermataEsistente
        Else
            PictureBox1.ImageLocation = ""
        End If

        PercorsoSchermataAnteprima = MainModule.PercorsoFileAccessorio(Film.NomeFile, "_screen_prova.jpg")
        EliminaSchermataAnteprima()

        If (MainModule.ModalitaNotte) Then
            Me.BackColor = Color.Black
            Me.ForeColor = Color.White
            LinkLabel1.LinkColor = Color.Yellow
            Dim grigio As Color = Color.FromArgb(255, 32, 32, 32)
            Button1.BackColor = grigio
            Button2.BackColor = grigio
            Button3.BackColor = grigio
            Button4.BackColor = grigio
            Button5.BackColor = grigio
            Button6.BackColor = grigio
            Button7.BackColor = grigio
        End If
    End Sub

    Sub EliminaSchermataAnteprima()
        If (My.Computer.FileSystem.FileExists(PercorsoSchermataAnteprima)) Then My.Computer.FileSystem.DeleteFile(PercorsoSchermataAnteprima, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(Film.PercorsoFile)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Enabled = False
        Me.UseWaitCursor = True
        'System.Windows.Shell.TaskbarItemInfo.ProgressState = TaskbarItemProgressState.Indeterminate
        PictureBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        PictureBox1.ImageLocation = ""
        PictureBox1.Image = My.Resources.ThrobberIngranaggio
        EliminaSchermataAnteprima()

        BackgroundWorker.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork
        ScansioneLibreria.EseguiCatturaSchermata(Film.PercorsoFile, PercorsoSchermataAnteprima, Ore.Value, Minuti.Value, Secondi.Value, 400, 250)
    End Sub

    Private Sub BackgroundWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted
        Button2.Enabled = True
        Me.UseWaitCursor = False
        PictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        'System.Windows.Shell.TaskbarItemInfo.ProgressState = TaskbarItemProgressState.None
        If (My.Computer.FileSystem.FileExists(PercorsoSchermataAnteprima) = True) Then
            PictureBox1.ImageLocation = PercorsoSchermataAnteprima
            Button1.Enabled = True
        Else
            Button1.Enabled = False
            MessageBox.Show("Prova a scegliere un istante diverso.", "Cattura della schermata non riuscita!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Sub UscitaSenzaAverSalvato() Handles Button3.Click ', Me.FormClosing
        If (BackgroundWorker.IsBusy) Then
            If (MessageBox.Show("Interrompere l'acquisizione della schermata?", "Interrompere?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then
                BackgroundWorker.CancelAsync()
                Me.DialogResult = Windows.Forms.DialogResult.Abort
                EliminaSchermataAnteprima()
                Me.Close()
            End If
        ElseIf (My.Computer.FileSystem.FileExists(PercorsoSchermataAnteprima)) Then
            Dim risposta As DialogResult = MessageBox.Show("Vuoi salvare la schermata acquisita come icona definitiva del film? Altrimenti sarà ripristinata quella eventualmente pre-esistente.", "Salvare la modifica?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If (risposta = Windows.Forms.DialogResult.Yes) Then
                SalvaSchermataComeDefinitiva()
            Else
                EliminaSchermataAnteprima()
                Me.DialogResult = Windows.Forms.DialogResult.Abort
                Me.Close()
            End If
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End If
    End Sub

    Sub SalvaSchermataComeDefinitiva() Handles Button1.Click
        Dim PercorsoSchermataPreEsistente As String = MainModule.PercorsoSchermataFilm(Film.NomeFile)
        If (My.Computer.FileSystem.FileExists(PercorsoSchermataPreEsistente)) Then My.Computer.FileSystem.DeleteFile(PercorsoSchermataPreEsistente, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)

        My.Computer.FileSystem.MoveFile(PercorsoSchermataAnteprima, PercorsoSchermataPreEsistente, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)

        'MainForm.IconeFilmPiccole.Images.Item(IndiceIcona) = Image.FromFile(PercorsoSchermataPreEsistente)
        'MainForm.IconeFilmGrandi.Images.Item(IndiceIcona) = Image.FromFile(PercorsoSchermataPreEsistente)

        If (IndiceIcona < MainForm.ElencoFilm.VirtualListSize) Then
            MainForm.CacheIcone = Nothing 'Invalido la cache
            MainForm.ElencoFilm.RedrawItems(IndiceIcona, IndiceIcona, False)
            If (MainForm.ElencoFilm.SelectedIndices.Item(0) = IndiceIcona) Then MainForm.PicSchermata.Invalidate()
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (Secondi.Value >= 15) Then
            Secondi.Value -= 15
        ElseIf (Minuti.Value > 0 Or Ore.Value > 0) Then
            Secondi.Value = Secondi.Value + 60 - 15
            If (Minuti.Value >= 1) Then
                Minuti.Value -= 1
            Else
                Minuti.Value = 59
                Ore.Value -= 1
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (Secondi.Value >= 3) Then
            Secondi.Value -= 3
        ElseIf (Minuti.Value > 0 Or Ore.Value > 0) Then
            Secondi.Value = Secondi.Value + 60 - 3
            If (Minuti.Value > 0) Then
                Minuti.Value -= 1
            Else
                Minuti.Value = 59
                Ore.Value -= 1
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (Secondi.Value <= 56) Then
            Secondi.Value += 3
        ElseIf (Minuti.Value < 59 Or Ore.Value < Ore.Maximum) Then
            Secondi.Value = Secondi.Value + 3 - 60
            If (Minuti.Value < 59) Then
                Minuti.Value += 1
            Else
                Minuti.Value = 0
                Ore.Value += 1
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (Secondi.Value <= 44) Then
            Secondi.Value += 15
        ElseIf (Minuti.Value < 59 Or Ore.Value < Ore.Maximum) Then
            Secondi.Value = Secondi.Value + 15 - 60
            If (Minuti.Value < 59) Then
                Minuti.Value += 1
            Else
                Minuti.Value = 0
                Ore.Value += 1
            End If
        End If
    End Sub

    Sub SelezionaTestoOre() Handles Ore.Enter, Ore.MouseUp
        Ore.Select(0, Ore.Text.Length)
    End Sub

    Sub SelezionaTestoMinuti() Handles Minuti.Enter, Minuti.MouseUp
        Minuti.Select(0, Minuti.Text.Length)
    End Sub

    Sub SelezionaTestoSecondi() Handles Secondi.Enter, Secondi.MouseUp
        Secondi.Select(0, Secondi.Text.Length)
    End Sub
End Class