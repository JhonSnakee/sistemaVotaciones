Public Class ConClaveAdmin
    Private Sub ConClaveAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FormClave.ContraseñaTableAdapter.FillBy(FormClave.TblcompDataSet.Contraseña, Clavetxt.Text) Then
            Administrador.Show()
            Me.Close()
        Else
            MsgBox("CONTRASEÑA INCORRECTA")
        End If
    End Sub
End Class