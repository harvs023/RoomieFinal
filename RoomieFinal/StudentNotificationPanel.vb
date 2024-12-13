Imports MySql.Data.MySqlClient
Public Class StudentNotificationPanel
    Public Property userName1 As String
    Public Property yearandsection As String
    Private Sub StudentNotificationPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Namelbl.Text = SharedDataModules.userName
        Sectionlbl.Text = SharedDataModules.yearandsection
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
End Class