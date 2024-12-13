Public Class AdminScheduleManager
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim dt As DataTable = CType(adminScheduleData.DataSource, DataTable)

        Dim newRow As DataRow = dt.NewRow()


        dt.Rows.Add(newRow)
    End Sub
End Class