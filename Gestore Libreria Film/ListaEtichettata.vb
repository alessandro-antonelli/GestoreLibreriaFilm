Public Class ListaEtichettata
    Private Etichetta As String
    Private Lista As List(Of UShort)
    Private MinAnno As UShort = UShort.MaxValue
    Private MaxAnno As UShort = UShort.MinValue
    Private DurataTotMinuti As UInteger = 0

    Public Sub New(Etichetta As String, PrimoElementoLista As UShort)
        Me.Etichetta = Etichetta
        Lista = New List(Of UShort)
        Me.Aggiungi(PrimoElementoLista)
    End Sub

    Public Sub Aggiungi(elemento As UShort)
        Lista.Add(elemento)
        Dim anno As UShort = MainForm.LibreriaFilm.Item(elemento).Anno
        If (anno <> 0 And anno < MinAnno) Then MinAnno = anno
        If (anno <> 0 And anno > MaxAnno) Then MaxAnno = anno

        Dim DuratMin As UShort = MainForm.LibreriaFilm.Item(elemento).DurataMinuti
        DurataTotMinuti += DuratMin
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

    Public Function GetDurataTotMinuti() As UShort
        Return DurataTotMinuti
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
