﻿Public Class FormClave
    Private Sub FormClave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TblcompDataSet.Contraseña' Puede moverla o quitarla según sea necesario.
        Me.ContraseñaTableAdapter.Fill(Me.TblcompDataSet.Contraseña)

    End Sub
End Class