Public Class ContVotosD
    Private Sub ContVotosD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TblcompDataSet.VotosDia' Puede moverla o quitarla según sea necesario.
        Me.VotosDiaTableAdapter.Fill(Me.TblcompDataSet.VotosDia)

    End Sub
End Class