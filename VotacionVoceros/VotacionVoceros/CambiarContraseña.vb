Public Class CambiarContraseña
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If FormClave.ContraseñaTableAdapter.FillBy(FormClave.TblcompDataSet.Contraseña, Clavetxt.Text) Then
            If TextBox1.Text = TextBox2.Text Then
                FormClave.ContraseñaTableAdapter.Editar(TextBox1.Text)
                MsgBox("CONTRASEÑA CAMBIADA CON EXITO")
                Me.Close()
            Else
                MsgBox("LA NUEVA CONTRASEÑA NO COINCIDE CON LA CONFIRAMCION")
            End If
        Else
                MsgBox("CONTRASEÑA INCORRECTA")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class