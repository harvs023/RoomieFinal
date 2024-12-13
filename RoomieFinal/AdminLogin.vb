Imports MySql.Data.MySqlClient

Public Class AdminLogin
    Private Sub userlbl_std_Click(sender As Object, e As EventArgs) Handles userlbl_std.Click, Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim adminusername As String = adminUsernameTxt.Text
        Dim password As String = passwordtxt.Text
        If String.IsNullOrWhiteSpace(adminusername) Then
            MessageBox.Show("Username is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Password is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try

            Dim query As String = "SELECT username FROM admin " &
                     "WHERE password = '" & password & "' "
            Dim cmd As New MySqlCommand(query, datacon2)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim userName As String = reader("username").ToString()
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                reader.Close()
                Dim admindashboard As New AdminPanel()
                admindashboard.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid admin number or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            reader.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try
    End Sub

    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passwordtxt.PasswordChar = "*"c
        databaseConnect2()
    End Sub
End Class