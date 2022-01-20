Public Class ListaEtichettata
    Private Etichetta As String
    Private Lista As List(Of UShort)
    Private MinAnno As UShort = UShort.MaxValue
    Private MaxAnno As UShort = UShort.MinValue
    Private DurataTotMinuti As UInteger = 0

    Private SommaVotiIMDB As Double = 0
    Private CardinalitaVotiIMDB As UShort = 0
    Private SommaNumVotiIMDB As ULong = 0
    Private CardinalitaNumVotiIMDB As UShort = 0
    Private SommaVotiMetacritic As UInteger = 0
    Private CardinalitaVotiMetacritic As UShort = 0
    Private SommaVotiRotten As UInteger = 0
    Private CardinalitaVotiRotten As UShort = 0
    Private SommaIncassi As ULong = 0
    Private CardinalitaIncassi As UShort = 0

    Public Sub New(Etichetta As String, PrimoElementoLista As UShort)
        Me.Etichetta = Etichetta
        Lista = New List(Of UShort)
        Me.Aggiungi(PrimoElementoLista)
    End Sub

    Public Sub Aggiungi(indice As UShort)
        Lista.Add(indice)

        Dim elemento As Film = MainForm.LibreriaFilm.Item(indice)

        Dim anno As UShort = elemento.Anno
        If (anno <> 0 And anno < MinAnno) Then MinAnno = anno
        If (anno <> 0 And anno > MaxAnno) Then MaxAnno = anno

        DurataTotMinuti += elemento.DurataMinuti

        SommaVotiIMDB += elemento.VotoIMDB
        If (elemento.VotoIMDB <> 0) Then CardinalitaVotiIMDB += 1
        SommaNumVotiIMDB += Math.Round(elemento.NumVotiIMDB / 100)
        If (elemento.NumVotiIMDB <> 0) Then CardinalitaNumVotiIMDB += 1
        SommaVotiMetacritic += elemento.VotoMetacritic
        If (elemento.VotoMetacritic <> 0) Then CardinalitaVotiMetacritic += 1
        SommaVotiRotten += elemento.VotoRottenTomatoes
        If (elemento.VotoRottenTomatoes <> 0) Then CardinalitaVotiRotten += 1
        SommaIncassi += Math.Round(elemento.IncassoDollari / 1000)
        If (elemento.IncassoDollari <> 0) Then CardinalitaIncassi += 1
    End Sub

    Public Function GetEtichetta() As String
        Return New String(Me.Etichetta)
    End Function

    Public Function GetCognomeNome(Optional SoloCognome As Boolean = False) As String
        If (Etichetta.StartsWith("[")) Then
            Return New String(Me.Etichetta)
        Else
            Dim NomeCognome As String() = MainModule.SeparaNomeCognome(Etichetta)
            If (SoloCognome) Then
                Return NomeCognome(1)
            Else
                Return NomeCognome(1) + ", " + NomeCognome(0)
            End If
        End If
    End Function

    Public Function GetMinAnno() As UShort
        Return MinAnno
    End Function

    Public Function GetMaxAnno() As UShort
        Return MaxAnno
    End Function

    Public Function GetDurataTotMinuti() As UInteger
        Return DurataTotMinuti
    End Function

    Public Function GetVotoIMDBMedio() As Double
        If (CardinalitaVotiIMDB = 0) Then
            Return 0
        Else
            Return SommaVotiIMDB / CardinalitaVotiIMDB
        End If
    End Function

    Public Function GetNumVotiIMDBMedio() As UInteger
        If (CardinalitaNumVotiIMDB = 0) Then
            Return 0
        Else
            Return Math.Round(SommaNumVotiIMDB / CardinalitaNumVotiIMDB * 100)
        End If
    End Function

    Public Function GetIncassoMedio() As UInteger
        If (CardinalitaIncassi = 0) Then
            Return 0
        Else
            Return Math.Round(SommaIncassi / CardinalitaIncassi * 1000)
        End If
    End Function

    Public Function GetVotoMetacriticMedio() As Byte
        If (CardinalitaVotiMetacritic = 0) Then
            Return 0
        Else
            Return Math.Min(100, Math.Round(SommaVotiMetacritic / CardinalitaVotiMetacritic))
        End If
    End Function

    Public Function GetVotoRottenMedio() As Byte
        If (CardinalitaVotiRotten = 0) Then
            Return 0
        Else
            Return Math.Min(100, Math.Round(SommaVotiRotten / CardinalitaVotiRotten))
        End If
    End Function
    Public Function GetArray() As UShort()
        Return Lista.ToArray
    End Function

    Public Function Conteggio() As Short
        Return Lista.Count
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If (Not obj.GetType.ToString.Equals(Me.GetType.ToString)) Then
            Return False
        Else
            Return String.Equals(obj.Etichetta, Me.Etichetta)
        End If
    End Function
End Class
