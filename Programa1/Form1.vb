Public Class Problema1
    Public NumGenerado, NumIngresado, Correctos, Incorrectos, Omitidos As Integer
    Private Sub lblHeader_Click(sender As Object, e As EventArgs) Handles lblHeader.Click

    End Sub

    Private Function GenerarNumero(min As Integer, max As Integer) As Integer
        Dim generadorAleatorio As New Random()
        Dim valorGenerado = generadorAleatorio.Next(min, max + 1)
        Return valorGenerado
    End Function

    Private Sub Problema1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Correctos = 0
        Incorrectos = 0
        Omitidos = 0

        NumGenerado = GenerarNumero(0, 9)

        tbIntentosExitosos.Text = Correctos
        tbIntentosFallidos.Text = Incorrectos
        tbIntentosOmitidos.Text = Omitidos
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NumGenerado = GenerarNumero(0, 9)
        Omitidos += 1
        tbIntentosOmitidos.Text = Omitidos
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        NumIngresado = Integer.Parse(tbNumero.Text)

        If NumGenerado = NumIngresado Then
            MsgBox("Felicidades! La respuesta es correcta!", MsgBoxStyle.Exclamation, "Respuesta Correcta")
            NumGenerado = GenerarNumero(0, 9)
            Correctos += 1
            tbIntentosExitosos.Text = Correctos
        Else
            MsgBox("Te has equivocado, intenta de nuevo", MsgBoxStyle.Critical, "Respuesta Incorrecta")
            Incorrectos += 1
            tbIntentosFallidos.Text = Incorrectos
        End If

    End Sub
End Class
