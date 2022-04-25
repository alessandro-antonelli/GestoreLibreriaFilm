Imports System.Data.SqlClient

Public Class Libreria

    'Create ADO.NET objects.
    Private ConnessioneDB As SqlConnection 'establishes a database connection

    Sub New()
        ConnettiDB()
    End Sub

    Private Sub ConnettiDB()
        'Create a Connection object.
        ConnessioneDB = New SqlConnection(My.Settings.MovieLibraryConnectionString)
        'ConnessioneDB = New SqlConnection("Initial Catalog=Northwind;" & "Data Source=localhost;Integrated Security=SSPI;")
    End Sub

    Private Function EseguiQuery(Query As String) As String 'runs a query against the database
        Dim myReader As SqlDataReader 'retrieves the results of the query
        Dim results As String = ""

        'Create a Command object.
        Dim myCmd As SqlCommand
        myCmd = ConnessioneDB.CreateCommand
        myCmd.CommandText = Query ' "SELECT FirstName, LastName FROM Employees"

        'Open the connection.
        ConnessioneDB.Open() 'SqlConnection uses your Windows logon details to connect to the Northwind database on your computer
        Try
            myReader = myCmd.ExecuteReader() 'SqlCommand retrieves two fields from the Employees table and creates a SqlDataReader object.
        Catch ex As Exception
            Return ex.Message
        End Try

        'Concatenate the query result into a string.
        Do While myReader.Read() 'myReader.Read returns a boolean value, which indicates whether there are more records to be read
            results += myReader.GetValue(0).ToString() & vbTab & myReader.GetValue(1).ToString() & vbLf
            'results += myReader.GetString(0) & vbTab & myReader.GetString(1) & vbLf
        Loop

        'Close the reader
        myReader.Close()
        'Chiudo connessione
        ConnessioneDB.Close()

        Return results
    End Function

    Sub CreaDatabase()
        EseguiQuery("CREATE DATABASE LibreriaFilm;")

        EseguiQuery("CREATE TABLE [database_name.][schema_name.]table_name (
            pk_column data_type PRIMARY KEY,
            column_1 data_type Not NULL,
            column_2 data_type,
            ...,
            table_constraints
            );")
    End Sub

    Public Function VediFilm() As String
        Return EseguiQuery("SELECT * FROM Movies")
    End Function
    Public Function AggiungiFilm() As String
        Return EseguiQuery("
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
End Class
