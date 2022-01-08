Public Class ScegliLibreria

    Private Sub ScegliLibreria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabBenvenuto.Visible = Not (MainForm.Visible)

        If (MainModule.ModalitaNotte) Then
            Me.BackColor = Color.Black
            Me.ForeColor = Color.White
            LinkLabel1.LinkColor = Color.Yellow
            Button1.BackColor = Color.FromArgb(255, 48, 48, 48)
        End If

        If (Not IsNothing(My.Settings.LibreriaPercorso) AndAlso My.Settings.LibreriaPercorso <> "") Then
            If (My.Computer.FileSystem.DirectoryExists(My.Settings.LibreriaPercorso)) Then
                LinkLabel1.Text = My.Settings.LibreriaPercorso
                LinkLabel1.Enabled = True
            Else
                LinkLabel1.Text = "Cartella non esistente: " + My.Settings.LibreriaPercorso
                LinkLabel1.Enabled = False
            End If
        Else
            LinkLabel1.Text = "Nessuna"
            LinkLabel1.Enabled = False
        End If

        CheckSottocartelle.Checked = My.Settings.LibreriaIncludiSottocartelle
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim PrecedentementePathEraVuoto As Boolean = Not My.Computer.FileSystem.DirectoryExists(My.Settings.LibraryPath)
        FolderBrowserDialog.ShowDialog()
        If (My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog.SelectedPath) And My.Settings.LibreriaPercorso <> FolderBrowserDialog.SelectedPath) Then
            LinkLabel1.Text = FolderBrowserDialog.SelectedPath
            LinkLabel1.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.LibreriaPercorso = FolderBrowserDialog.SelectedPath
        My.Settings.LibreriaIncludiSottocartelle = CheckSottocartelle.Checked
        My.Settings.Save()

        If (MainForm.Visible) Then
            MainForm.FileSystemWatcher.Path = My.Settings.LibreriaPercorso
            MainForm.SvuotaElencoFilm()
            'ScansioneLibreria.AvviaScansione(My.Computer.FileSystem.GetFiles(My.Settings.LibraryPath), False, True, MainModule.ModalitaNotte)
            If (CheckSottocartelle.Checked) Then
                ScansioneLibreria.PercorsiFile = My.Computer.FileSystem.GetFiles(My.Settings.LibreriaPercorso, FileIO.SearchOption.SearchAllSubDirectories)
            Else
                ScansioneLibreria.PercorsiFile = My.Computer.FileSystem.GetFiles(My.Settings.LibreriaPercorso, FileIO.SearchOption.SearchTopLevelOnly)
            End If
            ScansioneLibreria.ShowDialog()
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If (My.Computer.FileSystem.DirectoryExists(LinkLabel1.Text)) Then
            Process.Start(LinkLabel1.Text)
        End If
    End Sub
End Class