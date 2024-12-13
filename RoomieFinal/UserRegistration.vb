Imports MySql.Data.MySqlClient

Public Class UserRegistration
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim name As String = NameTextBox.Text
        Dim studentNumber As String = StudentNumberTextBox.Text
        Dim yearAndSection As String = YearAndSectionTextBox.Text
        Dim password As String = PasswordTextBox.Text
        Dim securityQuestion As String = SecurityQuestionComboBox.Text
        Dim securityAnswer As String = SecurityAnswerTextBox.Text
        Dim confirmPassword As String = ConfirmPasswordTextBox.Text
        If String.IsNullOrWhiteSpace(studentNumber) Then
            MessageBox.Show("Student number is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Password is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(confirmPassword) Then
            MessageBox.Show("Confirm Password is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(securityQuestion) Then
            MessageBox.Show("Security Question is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(securityAnswer) Then
            MessageBox.Show("Security Answer is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If password <> confirmPassword Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try

            datacon.Open()

            Dim query As String = "INSERT INTO students (name, student_number, year_and_section, password, security_answer) " & "VALUES ('" & name & "', '" & studentNumber & "', '" & yearAndSection & "', '" & password & "', '" & securityAnswer & "')"
            Dim cmd As New MySqlCommand(query, datacon)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Student information saved successfully!")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            datacon.Close()
        End Try


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim std As New StudentLogin()
        Me.Close()
        std.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim std As New StudentLogin()
        Me.Close()
        std.Show()
    End Sub

End Class