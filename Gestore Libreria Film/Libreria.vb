Imports System.Data.SqlClient

Public Class Libreria

    'Create ADO.NET objects.
    Private ConnessioneDB As SqlConnection 'establishes a database connection

    Sub New()
        'Create a Connection object.
        ConnessioneDB = New SqlConnection(My.Settings.MovieLibraryConnectionString)
    End Sub

    Private Sub ConnettiDB()
        If (ConnessioneDB.State = ConnectionState.Closed Or
            ConnessioneDB.State = ConnectionState.Broken) Then

            'SqlConnection uses your Windows logon details to connect to the Northwind database on your computer
            ConnessioneDB.Open()
        End If
    End Sub

    Private Sub DisconnettiDB()
        If (ConnessioneDB.State = ConnectionState.Open) Then
            ConnessioneDB.Close()
        End If
    End Sub

    'Runs a query against the database. Restituisce il lettore dei risultati
    'La connessione deve essere aperta dal chiamante (con ConnettiDB) prima di invocare il metodo
    'Dopo l'invocazione, il chiamante deve chiudere il lettore (QueryResults.Close) e la connessione (DisconnettiDB)
    Private Function PerformQuery(Query As String) As SqlDataReader
        If (ConnessioneDB.State <> ConnectionState.Open) Then
            Throw New Exception("Connection with database is not open!")
        End If

        'Create a Command object.
        Dim myCmd As SqlCommand
        myCmd = ConnessioneDB.CreateCommand
        myCmd.CommandText = Query

        'Executes query and retrieves results
        Dim QueryResults As SqlDataReader
        Try
            QueryResults = myCmd.ExecuteReader() 'SqlCommand retrieves two fields from the Employees table and creates a SqlDataReader object.
        Catch ex As Exception
            Throw ex
        End Try
        Return QueryResults
    End Function

    Function ResultCount(QueryResults As SqlDataReader)
        If (QueryResults.HasRows = False) Then
            Return 0
        Else
            Dim Count As Integer = 0
            Do While QueryResults.Read()
                'Ogni iterazione esamina una riga dei risultati della query
                Count += 1
            Loop
            Return Count
        End If
    End Function
    Function RowHasField(QueryResults As SqlDataReader, FieldName As String) As Boolean
        If (QueryResults.HasRows = False) Then Throw New Exception()
        Dim NumCol As Integer = QueryResults.GetOrdinal(FieldName)
        Return Not QueryResults.IsDBNull(NumCol)
    End Function

    Function FieldValueInRow(QueryResults As SqlDataReader, FieldName As String) As Object
        If (QueryResults.HasRows = False) Then Throw New Exception()
        Dim NumCol As Integer = QueryResults.GetOrdinal(FieldName)
        Return QueryResults.GetValue(NumCol)
        'QueryResults.GetFieldValue(Of()
    End Function

    '    QueryResults.HasRows
    '    NomeColonna = QueryResults.GetName()

    '    'Concatenate the query result into a string.
    '    Do While QueryResults.Read() 'myReader.Read returns a boolean value, which indicates whether there are more records to be read
    '        'Ogni iterazione esamina una riga dei risultati della query
    '        'myReader.FieldCount
    '        TextResults += QueryResults.GetValue(0).ToString() & vbTab & QueryResults.GetValue(1).ToString() & vbLf
    '        'results += myReader.GetString(0) & vbTab & myReader.GetString(1) & vbLf
    '    Loop

    '    'Close the reader
    '    QueryResults.Close()

    Sub CreaDatabase()
        PerformQuery("CREATE DATABASE LibreriaFilm;")

        PerformQuery("CREATE TABLE [database_name.][schema_name.]table_name (
            pk_column data_type PRIMARY KEY,
            column_1 data_type Not NULL,
            column_2 data_type,
            ...,
            table_constraints
            );")
    End Sub

    Public Function VediFilm() As String
        Return PerformQuery("SELECT * FROM Movies")
    End Function
    Public Function AggiungiFilm() As String
        Return PerformQuery("
            INSERT INTO Movies (
                    TitleLocal,
                    DateFirstPublished,
                    RatingMetacritic,
                    DateAdded,
                    Watched
                )

            VALUES (
                    'Vita e opere di Germano Mosconi',
                    '19920228',
                    98,
                    '20220425',
                    0
                );
            ")
    End Function

    Sub ScanFilesAndUpdateDB(PercorsiFileSuDisco As ObjectModel.ReadOnlyCollection(Of String))
        ConnettiDB()

        Dim PercorsiFileSoloSuDisco As New List(Of String)
        PercorsiFileSoloSuDisco.AddRange(PercorsiFileSuDisco) 'inizializzo i file solo su disco con tutti i file; poi rimuoverò quelli trovati anche nel DB
        Dim IDFileSoloSuDB As New List(Of Integer)

        'COSA FA ElencoFileDB.RecordsAffected ?

        ' Passo 1: considero corrispondenti i file che coincidono per path e dimensione e ultima modifica
        Dim ElencoFileDB As SqlDataReader = PerformQuery("SELECT ID, Path, SizeByte, DateLastEdited FROM Files")
        Do While ElencoFileDB.Read()
            Dim FilePath As String = FieldValueInRow(ElencoFileDB, "Path")
            Dim DiskFileInfo = My.Computer.FileSystem.GetFileInfo(FilePath)
            Dim DBSizeByte As Integer = FieldValueInRow(ElencoFileDB, "SizeByte")
            Dim DBDateLastEdited As Date = FieldValueInRow(ElencoFileDB, "DateLastEdited")

            Dim PercorsoCoincide As Boolean = PercorsiFileSuDisco.Contains(FilePath)
            Dim DimensioneCoincide As Boolean = (DiskFileInfo.Length = DBSizeByte)
            Dim UltimaModificaCoincide As Boolean = (DiskFileInfo.LastWriteTimeUtc.CompareTo(DBDateLastEdited) = 0)

            If (PercorsoCoincide And DimensioneCoincide And UltimaModificaCoincide) Then
                'They're the same file!
                PercorsiFileSoloSuDisco.Remove(FilePath)
            Else
                Dim DBId As Integer = FieldValueInRow(ElencoFileDB, "ID")
                IDFileSoloSuDB.Add(DBId)
            End If
        Loop
        ElencoFileDB.Close()

        ' Passo 2: considero corrispondenti i file che non coincidono per path,
        ' ma coincidono per dimensione e ultima modifica
        If (IDFileSoloSuDB.Count > 0 And PercorsiFileSoloSuDisco.Count > 0) Then
            For Each DBID In IDFileSoloSuDB
                Dim RigaDB As SqlDataReader = PerformQuery("SELECT * FROM Files WHERE ID = " + DBID)
                If (RigaDB.HasRows = False) Then Throw New Exception
                RigaDB.Read()
                Dim DBSizeByte As Integer = FieldValueInRow(RigaDB, "SizeByte")
                Dim DBEditTime As Date = FieldValueInRow(RigaDB, "DateLastEdited")

                For Each PercorsoFileDisco In PercorsiFileSoloSuDisco
                    Dim InfoFileDisco = My.Computer.FileSystem.GetFileInfo(PercorsoFileDisco)
                    If (InfoFileDisco.Length = DBSizeByte And InfoFileDisco.LastWriteTimeUtc.CompareTo(DBEditTime) = 0) Then
                        'They're the same file!
                        IDFileSoloSuDB.Remove(DBID)
                        PercorsiFileSoloSuDisco.Remove(PercorsoFileDisco)
                        UpdateFileInfo(PercorsoFileDisco, DBID)
                        Exit For
                    End If
                Next
            Next
        End If

        ' Passo 3: considero corrispondenti i file che non coincidono né per path, né per ultima modifica,
        ' ma coincidono per dimensione e hash MD5
        If (IDFileSoloSuDB.Count > 0 And PercorsiFileSoloSuDisco.Count > 0) Then
            For Each DBID In IDFileSoloSuDB
                Dim RigaDB As SqlDataReader = PerformQuery("SELECT * FROM Files WHERE ID = " + DBID)
                If (RigaDB.HasRows = False) Then Throw New Exception
                RigaDB.Read()
                Dim DBSizeByte As Integer = FieldValueInRow(RigaDB, "SizeByte")
                If RowHasField(RigaDB, "HashMD5") Then
                    Dim DBMD5 As String = FieldValueInRow(RigaDB, "HashMD5")
                    For Each PercorsoFileDisco In PercorsiFileSoloSuDisco
                        Dim InfoFileDisco = My.Computer.FileSystem.GetFileInfo(PercorsoFileDisco)
                        If (InfoFileDisco.Length <> DBSizeByte) Then Continue For

                        Dim DiskMD5 As String = ScansioneLibreria.md5(PercorsoFileDisco)
                        If (DiskMD5.Equals(DBMD5)) Then
                            'They're the same file!
                            IDFileSoloSuDB.Remove(DBID)
                            PercorsiFileSoloSuDisco.Remove(PercorsoFileDisco)
                            UpdateFileInfo(PercorsoFileDisco, DBID)
                            Exit For
                        End If
                    Next
                End If
            Next
        End If

        ' Passo 4: considero NON corrispondenti i file rimasti. Cioè quelli che:
        ' a) non coincidono né per path, né per ultima modifica; NON coincidono per dimensione
        ' b) non coincidono né per path, né per ultima modifica; coincidono per dimensione ma NON coincidono per hash MD5
        ' c) non coincidono né per path, né per ultima modifica; coincidono per dimensione ma non avevano un hash nel DB con cui fare il confronto

        ' Rimuovo dal DB i file presenti solo su DB
        For Each DBID In IDFileSoloSuDB
            RemoveMovie(DBID)
        Next

        ' Aggiungo al DB i file presenti solo su disco
        For Each PercorsoFileDisco In PercorsiFileSoloSuDisco
            AddNewMovie(PercorsoFileDisco)
        Next

        DisconnettiDB()
    End Sub

    Sub SovrascriviCampoFile(IDFile, FieldName, NewValue)
        '
    End Sub

    Sub AddNewMovie(FilePath As String)

    End Sub

    Sub UpdateFileInfo(MovieFilePath As String, MovieID As Integer)

    End Sub

    Sub RemoveMovie(ID As Integer)

    End Sub
End Class
