Imports MySql.Data.MySqlClient
Module Module2

    Public datacon2 As New MySqlConnection
    Dim server As String = "127.0.0.1"
    Dim dbasename As String = "admin"
    Dim username As String = "root"
    Dim passwd As String = "password"

    Public Sub databaseConnect2()

        If Not datacon2 Is Nothing Then
            datacon2.Close()
            datacon2.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & passwd & ";database=" & dbasename & ""

            Try

                datacon2.Open()
                MsgBox("Database Connected!")

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

        End If

    End Sub


End Module
