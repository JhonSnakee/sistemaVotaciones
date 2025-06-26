Public Class ReporteNoche
    Private Sub ReporteNoche_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'tblcompDataSet.VotosNoche' Puede moverla o quitarla según sea necesario.
        Me.VotosNocheTableAdapter.Fill(Me.tblcompDataSet.VotosNoche)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class