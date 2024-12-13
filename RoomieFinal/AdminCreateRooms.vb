Imports MySql.Data.MySqlClient

Public Class AdminCreateRooms
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim room As String = roomnotxt.Text
        Dim building As String = buildingtxt.Text

        ' Construct the SQL INSERT query using string concatenation
        Dim query As String = "INSERT INTO rooms (room_number, building) VALUES ('" & room & "', '" & building & "')"

        Try
            Dim command As New MySqlCommand(query, datacon)
            command.ExecuteNonQuery()
            MessageBox.Show("Room inserted successfully!")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
        End Try

    End Sub
End Class