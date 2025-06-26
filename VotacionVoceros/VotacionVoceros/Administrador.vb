Public Class Administrador
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CambiarContraseña.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Inicio.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReporteDia.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReporteNoche.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ImgJorn.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Eliminar.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        YaVotaron.YaVotadosTableAdapter.BFilas()
        ContVotosD.VotosDiaTableAdapter.Editar(Z, Z, Z, Z)
        ContVotosN.VotosNocheTableAdapter.Editar(Z, Z, Z, Z)
        MsgBox("REGISTROS ELIMINADOS CON EXITO")
    End Sub
End Class