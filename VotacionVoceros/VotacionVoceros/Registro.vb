Public Class Registro
    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasedatosvotacionDataSet.Votantes' Puede moverla o quitarla según sea necesario.
        Me.VotantesTableAdapter.Fill(Me.BasedatosvotacionDataSet.Votantes)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Inicio.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.VotantesTableAdapter.Insertar(FichaTextBox.Text, ProgramaTextBox.Text, Tipo_DocumentoTextBox.Text, No_DocumentoTextBox.Text, Nombres_y_ApellidosTextBox.Text)
        Me.VotantesTableAdapter.Fill(Me.BasedatosvotacionDataSet.Votantes)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.VotantesTableAdapter.Modificar(FichaTextBox.Text, ProgramaTextBox.Text, Tipo_DocumentoTextBox.Text, No_DocumentoTextBox.Text, Nombres_y_ApellidosTextBox.Text, No_DocumentoTextBox.Text)
        Me.VotantesTableAdapter.Fill(Me.BasedatosvotacionDataSet.Votantes)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.VotantesTableAdapter.Borrar(No_DocumentoTextBox.Text)
        Me.VotantesTableAdapter.Fill(Me.BasedatosvotacionDataSet.Votantes)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call LimpiarTextBox(Me)
    End Sub

    Public Sub LimpiarTextBox(ByVal frm As Form)
        For Each Control In frm.Controls
            If TypeOf Control Is TextBox Then
                FichaTextBox.Text = ""
                ProgramaTextBox.Text = ""
                Tipo_DocumentoTextBox.Text = ""
                No_DocumentoTextBox.Text = ""
                Nombres_y_ApellidosTextBox.Text = ""
            End If
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.VotantesTableAdapter.FillBy(Me.BasedatosvotacionDataSet.Votantes, No_DocumentoTextBox.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.VotantesTableAdapter.Fill(Me.BasedatosvotacionDataSet.Votantes)
    End Sub
End Class