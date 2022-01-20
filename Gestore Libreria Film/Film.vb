Public Class Film
    Public IMDBID As Integer

    Public NomeFile As String
    Public PercorsoFile As String
    Public HashMD5 As String
    Public DimensioneMB As Integer

    Public Estensione As String
    Public Contenitore As String
    Public BitrateComplessivoKBpS As UShort
    Public DurataSecondi As UInteger
    Public DurataMinuti As UShort

    Public Risoluzione As Size
    Public Proporzioni As String
    Public FPS As Double
    Public CodecVideoNomeBreve As String
    Public CodecVideoNomeLungo As String
    Public BitrateVideoKBpS As UShort

    Public Sonori As List(Of Sonoro)
    Public Sottotitoli As List(Of Sottotitolo)

    Public Anno As UShort
    Public Nazione As String
    Public TitoloITA As String
    Public TitoloORIG As String
    Public Note As String
    Public Generi As List(Of String)
    Public Registi As List(Of String)
    Public Attori As List(Of String)
    Public Autori As List(Of String)
    Public Musicisti As List(Of String)

    Public TramaBreve As String
    Public TramaLunga As String
    Public URLPoster As String

    Public IncassoDollari As UInteger
    Public VotoIMDB As Double
    Public NumVotiIMDB As Integer
    Public VotoMetacritic As Byte
    Public VotoRottenTomatoes As Byte

    Public OscarVinti As UShort
    Public OscarNominati As UShort
    Public BAFTAVinti As UShort
    Public BAFTANominati As UShort
    Public AltriPremiVinti As UShort
    Public AltriPremiNominati As UShort
End Class
