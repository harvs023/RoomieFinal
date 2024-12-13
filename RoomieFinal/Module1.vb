Imports MySql.Data.MySqlClient
Module Module1

    Public datacon As New MySqlConnection
    Dim server As String = "127.0.0.1"
    Dim dbasename As String = "roomie"
    Dim username As String = "root"
    Dim passwd As String = "password"

    Public Sub databaseConnect()

        If Not datacon Is Nothing Then
            datacon.Close()
            datacon.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & passwd & ";database=" & dbasename & ""

            Try

                datacon.Open()
                MsgBox("Database Connected!")

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

        End If

    End Sub


End Module