Public Class AdminCreateEvent
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim AdminEventManagementForm As New AdminEventManagement()
        AdminEventManagementForm.Show()
        Me.Close()
    End Sub
End Class