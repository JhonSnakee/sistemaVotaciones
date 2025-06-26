Imports System.IO
Public Class VotosD
    ':::Ruta donde crearemos nuestro archivo txt
    Dim ruta As String = "C:\VotacionesCME\"
    ':::Nombre del archivo
    Dim archivo As String = "Imagen.txt"

    Dim ruta2 As String = "C:\VotacionesCME\"
    Dim archivo2 As String = "Imagen2.txt"

    Dim ruta3 As String = "C:\VotacionesCME\"
    Dim archivo3 As String = "Imagen3.txt"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Verificamos si exite el archivo de texto, si no exite no hacemos nada
        If File.Exists(ruta & archivo) Then
            Try
                ':::Creamos nuestro objeto de tipo StreamReader que nos permite leer archivos
                Dim leer As New StreamReader(ruta & archivo)

                ':::Indicamos mediante un While que mientras no sea el ultimo caracter repita el proceso
                While leer.Peek <> -1
                    ':::Leemos cada linea del archivo TXT
                    Dim linea As String = leer.ReadLine()
                    ':::Validamos que la linea no este vacia
                    If String.IsNullOrEmpty(linea) Then
                        Continue While
                    End If
                    ':::Agregramos los registros encontrados
                    'Aplicamos la imagen actual
                    PictureBox2.Image = Image.FromFile(linea)

                End While

                leer.Close()

            Catch ex As Exception
                MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::Aprendamos de Programación:::")
            End Try
        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Verificamos si exite el archivo de texto, si no exite no hacemos nada
        If File.Exists(ruta2 & archivo2) Then
            Try
                ':::Creamos nuestro objeto de tipo StreamReader que nos permite leer archivos
                Dim leer As New StreamReader(ruta2 & archivo2)

                ':::Indicamos mediante un While que mientras no sea el ultimo caracter repita el proceso
                While leer.Peek <> -1
                    ':::Leemos cada linea del archivo TXT
                    Dim linea As String = leer.ReadLine()
                    ':::Validamos que la linea no este vacia
                    If String.IsNullOrEmpty(linea) Then
                        Continue While
                    End If
                    ':::Agregramos los registros encontrados
                    'Aplicamos la imagen actual
                    PictureBox3.Image = Image.FromFile(linea)

                End While

                leer.Close()

            Catch ex As Exception
                MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::Aprendamos de Programación:::")
            End Try
        End If

    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Verificamos si exite el archivo de texto, si no exite no hacemos nada
        If File.Exists(ruta3 & archivo3) Then
            Try
                ':::Creamos nuestro objeto de tipo StreamReader que nos permite leer archivos
                Dim leer As New StreamReader(ruta3 & archivo3)

                ':::Indicamos mediante un While que mientras no sea el ultimo caracter repita el proceso
                While leer.Peek <> -1
                    ':::Leemos cada linea del archivo TXT
                    Dim linea As String = leer.ReadLine()
                    ':::Validamos que la linea no este vacia
                    If String.IsNullOrEmpty(linea) Then
                        Continue While
                    End If
                    ':::Agregramos los registros encontrados
                    'Aplicamos la imagen actual
                    PictureBox4.Image = Image.FromFile(linea)

                End While

                leer.Close()

            Catch ex As Exception
                MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::Aprendamos de Programación:::")
            End Try
        End If

    End Sub
    Private Sub VotosD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Registrado = "NO"

        If Registro.VotantesTableAdapter.FillBy(Registro.BasedatosvotacionDataSet.Votantes, Docvottext.Text) Then
            MsgBox("EL USUARIO PUEDE REALIZAR LA VOTACIÓN.")
            Registrado = "SI"
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True

        End If

        If Registrado = "NO" Then
            MsgBox("EL USUARIO NO ESTÁ REGISTRADO, USTED NO PUEDE VOTAR.")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Inicio.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If YaVotaron.YaVotadosTableAdapter.FillBy(YaVotaron.TblcompDataSet.YaVotados, Docvottext.Text) Then
            MsgBox("EL USUARIO YA VOTO")
        Else
            YaVotaron.YaVotadosTableAdapter.Insertar(Docvottext.Text)
            ContVotosD.VotosDiaTableAdapter.SumT1()
            MsgBox("GRACIAS POR VOTAR")
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
        End If
        Docvottext.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If YaVotaron.YaVotadosTableAdapter.FillBy(YaVotaron.TblcompDataSet.YaVotados, Docvottext.Text) Then
            MsgBox("EL USUARIO YA VOTO")
        Else
            YaVotaron.YaVotadosTableAdapter.Insertar(Docvottext.Text)
            ContVotosD.VotosDiaTableAdapter.SumT2()
            MsgBox("GRACIAS POR VOTAR")
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
        End If
        Docvottext.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If YaVotaron.YaVotadosTableAdapter.FillBy(YaVotaron.TblcompDataSet.YaVotados, Docvottext.Text) Then
            MsgBox("EL USUARIO YA VOTO")
        Else
            YaVotaron.YaVotadosTableAdapter.Insertar(Docvottext.Text)
            ContVotosD.VotosDiaTableAdapter.SumT3()
            MsgBox("GRACIAS POR VOTAR")
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
        End If
        Docvottext.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If YaVotaron.YaVotadosTableAdapter.FillBy(YaVotaron.TblcompDataSet.YaVotados, Docvottext.Text) Then
            MsgBox("EL USUARIO YA VOTO")
        Else
            YaVotaron.YaVotadosTableAdapter.Insertar(Docvottext.Text)
            ContVotosD.VotosDiaTableAdapter.SumVB()
            MsgBox("GRACIAS POR VOTAR")
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
        End If
        Docvottext.Text = ""
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub
End Class