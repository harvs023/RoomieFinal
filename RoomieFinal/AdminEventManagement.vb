Public Class AdminEventManagement

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim form2 As New AdminCreateEvent()
        form2.Show()
        Me.Hide()
    End Sub
End Class