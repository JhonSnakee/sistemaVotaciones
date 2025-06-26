Public Class ReporteDia
    Private Sub ReporteDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'tblcompDataSet.VotosDia' Puede moverla o quitarla según sea necesario.
        Me.VotosDiaTableAdapter.Fill(Me.tblcompDataSet.VotosDia)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class