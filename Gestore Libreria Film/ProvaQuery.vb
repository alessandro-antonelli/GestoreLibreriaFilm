Public Class ProvaQuery
    Dim Libr As Libreria
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(Libr.VediFilm())
    End Sub

    Private Sub ProvaQuery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Libr = New Libreria()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show(Libr.AggiungiFilm())
    End Sub
End Class