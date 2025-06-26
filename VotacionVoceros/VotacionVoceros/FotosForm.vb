Public Class FotosForm
    Private Sub FotosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TblcompDataSet.Fotos' Puede moverla o quitarla según sea necesario.
        Me.FotosTableAdapter.Fill(Me.TblcompDataSet.Fotos)

    End Sub
End Class