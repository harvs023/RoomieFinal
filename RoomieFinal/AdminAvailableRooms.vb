Imports MySql.Data.MySqlClient

Public Class AdminAvailableRooms
    Private Sub AdminAvailableRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim query As String = "SELECT room_number, building FROM rooms"
            Dim cmd As New MySqlCommand(query, datacon)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim roomnumber = reader("room_number").ToString()
                Dim building = reader("building").ToString()
                reader.Close()
                ComboBox1.Text = roomnumber
                ComboBox2.Text = building
            Else
                MessageBox.Show("Invalid student number or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            reader.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim create As New AdminCreateRooms()
        create.Show()
        Me.Hide()
    End Sub




    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim date1 As String = datetxt.Text
        Dim starttime As String = sttime.Text
        Dim endtime3 As String = endtime.Text
        Dim availability As String
        If RadioButton1.Checked Then
            availability = "Yes"
        ElseIf RadioButton2.Checked Then
            availability = "No"
        End If

        Dim query As String = "INSERT INTO room_availability (room_number, building, availability_date, start_time, end_time, is_available) VALUES ('" & ComboBox1.Text & "', '" & ComboBox2.Text & "', '" & date1 & "', '" & starttime & "', '" & endtime3 & "', '" & availability & "')"

        Try
            Dim command As New MySqlCommand(query, datacon)
            command.ExecuteNonQuery()
            MessageBox.Show("Room availability inserted successfully!")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


End Class