﻿Public Class Eliminar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Registro.VotantesTableAdapter.BFilas()
        MsgBox("REGISTROS ELIMINADOS CON EXITO")
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class