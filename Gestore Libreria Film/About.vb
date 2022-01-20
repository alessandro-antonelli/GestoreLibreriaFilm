Public Class About

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://alessandro-antonelli.github.io/")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("https://github.com/alessandro-antonelli/GestoreLibreriaFilm")
    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (MainModule.ModalitaNotte) Then
            Me.BackColor = Color.Black
            Me.ForeColor = Color.White

            TextTerzeParti.BackColor = Color.Black
            TextTerzeParti.ForeColor = Color.White

            LinkLabel1.LinkColor = Color.Yellow
            LinkLabel2.LinkColor = Color.Yellow
            LinkLabel3.LinkColor = Color.Yellow
            LinkLabel4.LinkColor = Color.Yellow
        End If
    End Sub
End Class