Imports MySql.Data.MySqlClient

Public Class StudentDashboard
    Public Property userName As String
    Public Property studentno As String
    Private Sub StudentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        studentName.Text = "Welcome, " & SharedDataModules.userName & "!"
        LoadStudentSchedules()
        UpcomingSchedules()
    End Sub
    Private Sub LoadStudentSchedules()
        Try
            Dim query As String = "SELECT " &
                                  "student_number AS `Stud. No.`, " &
                                  "time_interval AS `Time`, " &
                                  "Monday, " &
                                  "Tuesday, " &
                                  "Wednesday, " &
                                  "Thursday, " &
                                  "Friday, " &
                                  "Saturday, " &
                                  "Sunday " &
                                  "FROM student_schedules " &
                                  "WHERE student_number = '" & SharedDataModules.studentno & "';"



            Dim adapter As New MySqlDataAdapter(query, datacon)
            Dim dtbl As New DataTable()

            adapter.Fill(dtbl)

            studentScheduleTable.DataSource = dtbl
            studentScheduleTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub UpcomingSchedules()
        Dim query As String = "SELECT " &
                              "student_number AS `Stud. No.`, " &
                              "time_interval AS `Time`, " &
                              "Monday, " &
                              "Tuesday, " &
                              "Wednesday, " &
                              "Thursday, " &
                              "Friday, " &
                              "Saturday, " &
                              "Sunday " &
                              "FROM student_schedules " &
                              "WHERE student_number = '" & SharedDataModules.studentno & "';"


        Dim adapter As New MySqlDataAdapter(query, datacon)
        Dim dtbl As New DataTable()

        adapter.Fill(dtbl)

        stdUpcomingData.DataSource = dtbl
        stdUpcomingData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        stdUpcomingData.Rows(0).Height = 22

        For i As Integer = 1 To studentScheduleTable.Rows.Count - 1
            stdUpcomingData.Rows(i).Height = 0
        Next


        Dim currentTime As DateTime = DateTime.Now
        Dim hourOfDay As Integer = currentTime.Hour


        Select Case hourOfDay
            Case 7
                For i As Integer = 1 To 12
                    stdUpcomingData.Rows(i).Height = 22
                Next
            Case 8
                For i As Integer = 1 To 12
                    stdUpcomingData.Rows(i).Height = 22
                Next
            Case 9
                For i As Integer = 2 To 12
                    stdUpcomingData.Rows(i).Height = 22
                Next
            Case 10
                For i As Integer = 3 To 12
                    stdUpcomingData.Rows(i).Height = 22
                Next
            Case 11
                For i As Integer = 4 To 12
                    stdUpcomingData.Rows(i).Height = 22
                Next
            Case 12
                For i As Integer = 5 To 12
                    stdUpcomingData.Rows(i).Height = 22
                Next
            Case 13
                For i As Integer = 6 To 12
                    stdUpcomingData.Rows(i).Height = 22
                Next
            Case 14
                For i As Integer = 7 To 12
                    stdUpcomingData.Rows(i).Height = 22
                Next
            Case 15
                For i As Integer = 8 To 12
                    stdUpcomingData.Rows(i).Height = 22
                Next
            Case 16
                For i As Integer = 9 To 12
                    stdUpcomingData.Rows(i).Height = 22
                Next
            Case 17
                For i As Integer = 10 To 12
                    stdUpcomingData.Rows(i).Height = 22
                Next
            Case 18
                For i As Integer = 11 To 12
                    stdUpcomingData.Rows(i).Height = 22
                Next
            Case 19
                stdUpcomingData.Rows(12).Height = 22
            Case Else

                For i As Integer = 1 To studentScheduleTable.Rows.Count - 1
                    stdUpcomingData.Rows(i).Height = 22
                Next
        End Select
        Dim currentDay As DayOfWeek = DateTime.Now.DayOfWeek

        For Each column As DataGridViewColumn In stdUpcomingData.Columns

            If column.Name <> "Stud. No." AndAlso column.Name <> "Time" Then

                Select Case currentDay
                    Case DayOfWeek.Sunday
                        column.Visible = (column.Name = "Sunday")
                    Case DayOfWeek.Monday
                        column.Visible = (column.Name = "Monday")
                    Case DayOfWeek.Tuesday
                        column.Visible = (column.Name = "Tuesday")
                    Case DayOfWeek.Wednesday
                        column.Visible = (column.Name = "Wednesday")
                    Case DayOfWeek.Thursday
                        column.Visible = (column.Name = "Thursday")
                    Case DayOfWeek.Friday
                        column.Visible = (column.Name = "Friday")
                    Case DayOfWeek.Saturday
                        column.Visible = (column.Name = "Saturday")
                End Select
            Else

                column.Visible = True
            End If
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim mainform As New StudentLogin
        mainform.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim studentroominfo As New StudentRoomInfo
        studentroominfo.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim help As New Help
        help.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim studentnotification As New StudentNotificationPanel
        studentnotification.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim events As New StudentEventDashboard
        events.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub
End Class