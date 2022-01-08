﻿Public Class ScegliImmaginePersona
    Dim BaseFileTemp As String = My.Computer.FileSystem.SpecialDirectories.Temp + "\GLF_ScegliPersona_"
    Dim PathFileDefinitivo As String

    Sub PreparaFinestra(QueryIniziale As String, PathImgDefinitiva As String)
        Me.PathFileDefinitivo = PathImgDefinitiva
        TextBox1.Text = QueryIniziale
        If (MainModule.ModalitaNotte) Then
            Me.BackColor = Color.Black
            Me.ForeColor = Color.White
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.FromArgb(32, 32, 32)
            Button1.BackColor = Color.FromArgb(32, 32, 32)
        End If
        PictureBox1.Image = My.Resources.ThrobberIngranaggio
        PictureBox2.Image = My.Resources.ThrobberIngranaggio
        PictureBox3.Image = My.Resources.ThrobberIngranaggio
        PictureBox4.Image = My.Resources.ThrobberIngranaggio
        PictureBox5.Image = My.Resources.ThrobberIngranaggio
        PictureBox6.Image = My.Resources.ThrobberIngranaggio
        PictureBox7.Image = My.Resources.ThrobberIngranaggio
        PictureBox8.Image = My.Resources.ThrobberIngranaggio
        PictureBox9.Image = My.Resources.ThrobberIngranaggio
    End Sub

    Private Sub ScegliImmaginePersona_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ScaricaMiniature(TextBox1.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ScaricaMiniature(TextBox1.Text)
    End Sub

    Sub ScaricaMiniature(query As String)
        Me.UseWaitCursor = True
        For i As UShort = 1 To 9
            If (My.Computer.FileSystem.FileExists(BaseFileTemp + i.ToString + ".jpg")) Then
                My.Computer.FileSystem.DeleteFile(BaseFileTemp + i.ToString + ".jpg", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
            End If

            If (MainModule.SalvaImmagineGoogle(query, i, BaseFileTemp + i.ToString + ".jpg") = True) Then
                ImpostaImmagineBox(i, BaseFileTemp + i.ToString + ".jpg")
            Else
                ImpostaImmagineBox(i, Nothing)
            End If
        Next
        Me.UseWaitCursor = False
    End Sub

    Sub SalvaImmagine(indice As UShort)
        Dim PathTemporaneoScelto As String = BaseFileTemp + indice.ToString + ".jpg"
        If (My.Computer.FileSystem.FileExists(PathTemporaneoScelto)) Then
            If (My.Computer.FileSystem.FileExists(PathFileDefinitivo)) Then
                My.Computer.FileSystem.DeleteFile(PathFileDefinitivo, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
            End If
            My.Computer.FileSystem.MoveFile(PathTemporaneoScelto, PathFileDefinitivo)
        End If
        MainForm.PicImgPersona.LoadAsync()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Sub ImpostaImmagineBox(Indice As UShort, PathImmagine As String)
        Select Case Indice
            Case 1
                If (IsNothing(PathImmagine)) Then
                    PictureBox1.Image = PictureBox1.ErrorImage
                Else
                    PictureBox1.ImageLocation = PathImmagine
                End If
            Case 2
                If (IsNothing(PathImmagine)) Then
                    PictureBox2.Image = PictureBox1.ErrorImage
                Else
                    PictureBox2.ImageLocation = PathImmagine
                End If
            Case 3
                If (IsNothing(PathImmagine)) Then
                    PictureBox3.Image = PictureBox1.ErrorImage
                Else
                    PictureBox3.ImageLocation = PathImmagine
                End If
            Case 4
                If (IsNothing(PathImmagine)) Then
                    PictureBox4.Image = PictureBox1.ErrorImage
                Else
                    PictureBox4.ImageLocation = PathImmagine
                End If
            Case 5
                If (IsNothing(PathImmagine)) Then
                    PictureBox5.Image = PictureBox1.ErrorImage
                Else
                    PictureBox5.ImageLocation = PathImmagine
                End If
            Case 6
                If (IsNothing(PathImmagine)) Then
                    PictureBox6.Image = PictureBox1.ErrorImage
                Else
                    PictureBox6.ImageLocation = PathImmagine
                End If
            Case 7
                If (IsNothing(PathImmagine)) Then
                    PictureBox7.Image = PictureBox1.ErrorImage
                Else
                    PictureBox7.ImageLocation = PathImmagine
                End If
            Case 8
                If (IsNothing(PathImmagine)) Then
                    PictureBox8.Image = PictureBox1.ErrorImage
                Else
                    PictureBox8.ImageLocation = PathImmagine
                End If
            Case 9
                If (IsNothing(PathImmagine)) Then
                    PictureBox9.Image = PictureBox1.ErrorImage
                Else
                    PictureBox9.ImageLocation = PathImmagine
                End If
        End Select
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        SalvaImmagine(1)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        SalvaImmagine(2)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        SalvaImmagine(3)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        SalvaImmagine(6)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        SalvaImmagine(5)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        SalvaImmagine(4)
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        SalvaImmagine(9)
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        SalvaImmagine(8)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        SalvaImmagine(7)
    End Sub
End Class