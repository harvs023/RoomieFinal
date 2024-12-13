Imports MySql.Data.MySqlClient

Public Class StudentLogin

    Dim query As String
    Dim tableInfo As DataTable
    Dim da As MySqlDataAdapter

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            Application.Exit()
        End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        studentPasswordTxt.PasswordChar = "*"c
        databaseConnect()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim reg As New UserRegistration
        reg.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim studentNumber As String = studentNumberTxt.Text
        Dim password As String = studentPasswordTxt.Text
        If String.IsNullOrWhiteSpace(studentNumber) Then
            MessageBox.Show("Student Number is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Password is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try

            Dim query As String = "SELECT student_number, name, year_and_section FROM students " &
                     "WHERE student_number = '" & studentNumber & "' " &
                     "AND password = '" & password & "' "
            Dim cmd As New MySqlCommand(query, datacon)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                SharedDataModules.userName = reader("name").ToString()
                SharedDataModules.studentno = reader("student_number").ToString()
                SharedDataModules.yearandsection = reader("year_and_section").ToString()
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                reader.Close()
                Dim notification As New StudentNotificationPanel()
                Dim dashboard As New StudentDashboard()
                dashboard.Show()
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim admin As New AdminLogin
        admin.Show()
        Me.Hide()
    End Sub


End Class
