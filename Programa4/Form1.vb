Public Class Form1
    Public NumIngresado, NumCorrecto, Correctos, Incorrectos As Integer
    Public rd As New Random
    Public Sub VerificarRespuesta(respuesta As Integer, valorCorrecto As Integer)
        If (respuesta = valorCorrecto) Then
            MsgBox("¡Has ganado el premio!", MsgBoxStyle.Information, "¡Felicidades!")
            Correctos += 1
            tbIntentosExitosos.Text = Correctos
            NumCorrecto = rd.Next(1, 4 + 1)
        Else
            MsgBox("¡Has fallado, suerte a la próxima!", MsgBoxStyle.Critical, "¡Has perdido!")
            Incorrectos += 1
            tbIntentosFallidos.Text = Incorrectos
        End If
    End Sub

    Private Sub ButtonCheckResult(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click
        Dim button As Button = CType(sender, Button)

        Select Case button.Name
            Case "Button1"
                VerificarRespuesta(1, NumCorrecto)
            Case "Button2"
                VerificarRespuesta(2, NumCorrecto)
            Case "Button3"
                VerificarRespuesta(3, NumCorrecto)
            Case "Button4"
                VerificarRespuesta(4, NumCorrecto)
        End Select

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Correctos = 0
        Incorrectos = 0
        NumCorrecto = rd.Next(1, 4 + 1)

        tbIntentosExitosos.Text = Correctos
        tbIntentosFallidos.Text = Incorrectos
    End Sub
End Class
