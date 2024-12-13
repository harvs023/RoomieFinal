Imports MySql.Data.MySqlClient

Public Class AdminStudentSearch
    Public Property studentno As String
    Public Property userName As String
    Public Property yearandsc As String
    Private Sub AdminStudentSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nametxt.Text = userName
        yrandsctxt.Text = yearandsc
        studentnotxt.Text = studentno
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim studname As String = nametxt.Text
        Dim yearandsection As String = yrandsctxt.Text
        Dim stdno As String = studentnotxt.Text
        Dim query As String = "UPDATE students " &
                              "SET name = '" & studname & "', year_and_section = '" & yearandsection & "' " &
                              "WHERE student_number = '" & stdno & "'"


        Try
            Dim command As New MySqlCommand(query, datacon)
            Dim rowsAffected As Integer = command.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Student record updated successfully!")
            Else
                MessageBox.Show("No student found with the provided student number.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim adminsearch As New AdminPanel
        Me.Close()
        adminsearch.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim studname As String = nametxt.Text
        Dim yearandsection As String = yrandsctxt.Text
        Dim stdno As String = studentnotxt.Text
        Dim query As String = "DELETE FROM students WHERE student_number = '" & stdno & "'"

        Try
            Dim command As New MySqlCommand(query, datacon)
            Dim rowsAffected As Integer = command.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Roomie student record deleted successfully!")
            Else
                MessageBox.Show("No roomie student found with the provided student number.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting from roomie database: " & ex.Message)
        Finally
        End Try
    End Sub
End Class