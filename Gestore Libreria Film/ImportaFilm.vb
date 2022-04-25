Public Class ImportaFilm
    Public PathFile As String
    Public Titolo As String
    Public Anno As UShort

    Sub DeduciDatiDaNome()
        If (Not My.Computer.FileSystem.FileExists(PathFile)) Then
            Exit Sub
        End If

        Dim NomeFile As String = My.Computer.FileSystem.GetFileInfo(PathFile).Name
        Dim ExtFile As String = My.Computer.FileSystem.GetFileInfo(PathFile).Extension
        NomeFile = NomeFile.Replace(ExtFile, "")

        Dim pos As UShort = 0
        Dim PosAnniTrovati As New List(Of UShort)
        Dim CifreConsecutive As Byte = 0

        For Each carattere As Char In NomeFile
            If (Char.IsDigit(carattere)) Then
                CifreConsecutive += 1
            Else
                If (CifreConsecutive = 4) Then
                    PosAnniTrovati.Add(pos - 4)
                End If
                CifreConsecutive = 0
            End If
            pos += 1
        Next

        For Each PosAnno As UShort In PosAnniTrovati
            Dim PossibileAnno As UShort = UShort.Parse(NomeFile.Substring(PosAnno, 4))
            If (PossibileAnno >= 1850 And PossibileAnno <= My.Computer.Clock.LocalTime.Year) Then
                'scarto i numeri che non sono anni plausibili (prima dell'invenzione del cinema o collocati nel futuro)
                Dim CharSuccessivo As Char = NomeFile.Chars(PosAnno + 4)
                'preferisco i numeri seguiti da spazio/punteggiatura/altro, anziché quelli seguiti da lettere,
                'per scartare diciture tipo "1920p" che non rappresentano l'anno del film
                If (Anno = UShort.MinValue OrElse Not Char.IsLetter(CharSuccessivo)) Then
                    Anno = PossibileAnno
                End If
            End If
        Next

        'Rimuovo dal titolo tutto ciò che non sono lettere, numeri, o spazi
        Titolo = ""
        For Each Carattere As Char In NomeFile.Replace(Anno, "")
            If (Char.IsLetterOrDigit(Carattere) Or Char.IsWhiteSpace(Carattere)) Then
                Titolo += Carattere
            End If
        Next
        While (Titolo.Contains("  "))
            Titolo = Titolo.Replace("  ", " ")
        End While
        Titolo = Titolo.Trim
    End Sub

    Private Sub ImportaFilm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumericUpDown1.Maximum = My.Computer.Clock.LocalTime.Year
        Titolo = Nothing
        Anno = UShort.MinValue

        If (My.Computer.FileSystem.FileExists(PathFile)) Then
            TextBox1.Text = My.Computer.FileSystem.GetFileInfo(PathFile).Name
            DeduciDatiDaNome()
        Else
            TextBox1.Text = PathFile
        End If


        If (IsNothing(Titolo)) Then
            TextBox2.Text = ""
        Else
            TextBox2.Text = Titolo
        End If

        NumericUpDown1.Value = Anno
        If (Anno = UShort.MinValue) Then
            NumericUpDown1.Value = NumericUpDown1.Maximum
            CheckBox1.Checked = False
        Else
            NumericUpDown1.Value = Anno
            CheckBox1.Checked = True
        End If
        TextBox2.Focus()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        NumericUpDown1.Enabled = CheckBox1.Checked
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Titolo = TextBox2.Text

        If (CheckBox1.Checked) Then
            Anno = NumericUpDown1.Value
        Else
            Anno = UShort.MinValue
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class