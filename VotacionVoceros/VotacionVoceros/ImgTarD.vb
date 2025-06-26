Imports System.IO
Public Class ImgTarD
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
                    VotosD.PictureBox2.Image = Image.FromFile(linea)

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
                    VotosD.PictureBox3.Image = Image.FromFile(linea)

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
                    VotosD.PictureBox4.Image = Image.FromFile(linea)

                End While

                leer.Close()

            Catch ex As Exception
                MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::Aprendamos de Programación:::")
            End Try
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim CargarImagenes As New OpenFileDialog()

        CargarImagenes.Filter = "Archivo PNG,JPG,BMP|*.png; *.jpg; *.bmp"

        If CargarImagenes.ShowDialog() = DialogResult.OK Then

            Dim fs As FileStream

            ':::Validamos si la carpeta de ruta existe, si no existe la creamos
            Try
                If File.Exists(ruta) Then

                    'Creamos el archivo de texto
                    fs = File.Create(ruta & archivo)
                    fs.Close()

                    'Guardamos el archivo de texto con la ruta de la imagen
                    Dim escribir As New StreamWriter(ruta & archivo, True)

                    'guardarmos la ruta de la imagen obtenida en el OpenFileDialog
                    escribir.WriteLine(Path.GetFullPath(CargarImagenes.FileName))

                    escribir.Close()

                    'Aplicamos la imagen actual
                    VotosD.PictureBox2.Image = Image.FromFile(Path.GetFullPath(CargarImagenes.FileName))

                    MsgBox("LA IMAGEN FUE CARGADA CON EXITO.")

                Else

                    ':::Si la carpeta no existe la creamos
                    Directory.CreateDirectory(ruta)

                    'Creamos el archivo de texto
                    fs = File.Create(ruta & archivo)
                    fs.Close()

                    'Guardamos el archivo de texto con la ruta de la imagen
                    Dim escribir As New StreamWriter(ruta & archivo, True)

                    'guardarmos la ruta de la imagen obtenida en el OpenFileDialog
                    escribir.WriteLine(Path.GetFullPath(CargarImagenes.FileName))

                    escribir.Close()

                    'Aplicamos la imagen actual
                    VotosD.PictureBox2.Image = Image.FromFile(Path.GetFullPath(CargarImagenes.FileName))

                    MsgBox("LA IMAGEN FUE CARGADA CON EXITO.")

                End If

            Catch ex As Exception

                MsgBox("Se presento un problema al momento de crear el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::Aprendamos de Programación:::")

            End Try

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim CargarImagenes As New OpenFileDialog()

        CargarImagenes.Filter = "Archivo PNG,JPG,BMP|*.png; *.jpg; *.bmp"

        If CargarImagenes.ShowDialog() = DialogResult.OK Then

            Dim fs As FileStream

            ':::Validamos si la carpeta de ruta existe, si no existe la creamos
            Try
                If File.Exists(ruta2) Then

                    'Creamos el archivo de texto
                    fs = File.Create(ruta2 & archivo2)
                    fs.Close()

                    'Guardamos el archivo de texto con la ruta de la imagen
                    Dim escribir As New StreamWriter(ruta2 & archivo2, True)

                    'guardarmos la ruta de la imagen obtenida en el OpenFileDialog
                    escribir.WriteLine(Path.GetFullPath(CargarImagenes.FileName))

                    escribir.Close()

                    'Aplicamos la imagen actual
                    VotosD.PictureBox3.Image = Image.FromFile(Path.GetFullPath(CargarImagenes.FileName))

                    MsgBox("LA IMAGEN FUE CARGADA CON EXITO.")

                Else

                    ':::Si la carpeta no existe la creamos
                    Directory.CreateDirectory(ruta2)

                    'Creamos el archivo de texto
                    fs = File.Create(ruta2 & archivo2)
                    fs.Close()

                    'Guardamos el archivo de texto con la ruta de la imagen
                    Dim escribir As New StreamWriter(ruta2 & archivo2, True)

                    'guardarmos la ruta de la imagen obtenida en el OpenFileDialog
                    escribir.WriteLine(Path.GetFullPath(CargarImagenes.FileName))

                    escribir.Close()

                    'Aplicamos la imagen actual
                    VotosD.PictureBox3.Image = Image.FromFile(Path.GetFullPath(CargarImagenes.FileName))

                    MsgBox("LA IMAGEN FUE CARGADA CON EXITO.")

                End If

            Catch ex As Exception

                MsgBox("Se presento un problema al momento de crear el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::Aprendamos de Programación:::")

            End Try

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim CargarImagenes As New OpenFileDialog()

        CargarImagenes.Filter = "Archivo PNG,JPG,BMP|*.png; *.jpg; *.bmp"

        If CargarImagenes.ShowDialog() = DialogResult.OK Then

            Dim fs As FileStream

            ':::Validamos si la carpeta de ruta existe, si no existe la creamos
            Try
                If File.Exists(ruta3) Then

                    'Creamos el archivo de texto
                    fs = File.Create(ruta3 & archivo3)
                    fs.Close()

                    'Guardamos el archivo de texto con la ruta de la imagen
                    Dim escribir As New StreamWriter(ruta3 & archivo3, True)

                    'guardarmos la ruta de la imagen obtenida en el OpenFileDialog
                    escribir.WriteLine(Path.GetFullPath(CargarImagenes.FileName))

                    escribir.Close()

                    'Aplicamos la imagen actual
                    VotosD.PictureBox4.Image = Image.FromFile(Path.GetFullPath(CargarImagenes.FileName))

                    MsgBox("LA IMAGEN FUE CARGADA CON EXITO.")

                Else

                    ':::Si la carpeta no existe la creamos
                    Directory.CreateDirectory(ruta3)

                    'Creamos el archivo de texto
                    fs = File.Create(ruta3 & archivo3)
                    fs.Close()

                    'Guardamos el archivo de texto con la ruta de la imagen
                    Dim escribir As New StreamWriter(ruta3 & archivo3, True)

                    'guardarmos la ruta de la imagen obtenida en el OpenFileDialog
                    escribir.WriteLine(Path.GetFullPath(CargarImagenes.FileName))

                    escribir.Close()

                    'Aplicamos la imagen actual
                    VotosD.PictureBox4.Image = Image.FromFile(Path.GetFullPath(CargarImagenes.FileName))

                    MsgBox("LA IMAGEN FUE CARGADA CON EXITO.")

                End If

            Catch ex As Exception

                MsgBox("Se presento un problema al momento de crear el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::Aprendamos de Programación:::")

            End Try

        End If
    End Sub
End Class