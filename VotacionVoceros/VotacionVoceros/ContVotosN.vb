Public Class ContVotosN
    Private Sub ContVotosN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TblcompDataSet.VotosNoche' Puede moverla o quitarla según sea necesario.
        Me.VotosNocheTableAdapter.Fill(Me.TblcompDataSet.VotosNoche)

    End Sub
End Class