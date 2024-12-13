Imports MySql.Data.MySqlClient
Public Class AdminPanel
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles search.Click
        Dim studentno As String = studentnotxt.Text
        If String.IsNullOrWhiteSpace(studentno) Then
            MessageBox.Show("Student Number is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try

            Dim query As String = "SELECT student_number, name, year_and_section FROM students " &
                     "WHERE student_number = '" & studentno & "'"
            Dim cmd As New MySqlCommand(query, datacon)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim userName As String = reader("name").ToString()
                Dim studentnumber As String = reader("student_number").ToString()
                Dim yearandsc As String = reader("year_and_section").ToString()
                MessageBox.Show("Search Found", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                reader.Close()
                Dim adminsearch As New AdminStudentSearch
                adminsearch.userName = userName
                adminsearch.studentno = studentno
                adminsearch.yearandsc = yearandsc
                adminsearch.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid student number or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            reader.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim available As New AdminAvailableRooms
        available.Show()
        Me.Hide()
    End Sub
End Class