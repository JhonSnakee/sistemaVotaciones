Public Class YaVotaron
    Private Sub YaVotaron_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TblcompDataSet.YaVotados' Puede moverla o quitarla según sea necesario.
        Me.YaVotadosTableAdapter.Fill(Me.TblcompDataSet.YaVotados)

    End Sub
End Class