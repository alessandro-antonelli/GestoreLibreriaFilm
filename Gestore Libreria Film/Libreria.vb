Public Class Libreria
    Private DatiFilm As New List(Of Film)

    Private TuttiGliIndici As ListaEtichettata
    Private IndiciPerRegista As New List(Of ListaEtichettata)
    Private IndiciPerDecennio As New List(Of ListaEtichettata)
    Private IndiciPerAttore As New List(Of ListaEtichettata)
    Private IndiciPerGenere As New List(Of ListaEtichettata)
    Private IndiciPerNazione As New List(Of ListaEtichettata)
    Private IndiciPerAutore As New List(Of ListaEtichettata)
    Private IndiciPerMusicista As New List(Of ListaEtichettata)

    Sub New()
        '
    End Sub

    Sub GetFilmPerId(Indice As UShort)
        '
    End Sub

    Sub AggiungiEntry(Film As Film)
        '
    End Sub

    Sub RimuoviEntry(Indice As UShort)
        '
    End Sub

    Sub AggiornaEntry(Indice As UShort, EntryAggiornata As Film)
        '
    End Sub

    Sub SalvaSuFile(PercorsoFile As String)
        '
    End Sub

    Sub CaricaDaFile(PercorsoFile As String)
        '
    End Sub
End Class
