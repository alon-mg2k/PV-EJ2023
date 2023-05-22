Public Class Form1
    Public Valor1, Valor2, ValorCorrecto, Correctos, Incorrectos As Integer
    Public ListaOpciones As New List(Of Integer)()
    Public ListaBotones As New List(Of Button)()
    Public rd As New Random
    Public Sub VerificarRespuesta(respuesta As String)
        Dim conversionRespuesta = Integer.Parse(respuesta)
        If (conversionRespuesta = ValorCorrecto) Then
            MsgBox("¡Respuesta Correcta!", MsgBoxStyle.Information, "¡Éxito!")
            Correctos += 1
            tbIntentosExitosos.Text = Correctos
        Else
            MsgBox("¡Respuesta Incorrecta!", MsgBoxStyle.Critical, "¡Error!")
            Incorrectos += 1
            tbIntentosFallidos.Text = Incorrectos
        End If
        GenerarNuevaPregunta()
    End Sub

    Private Sub ButtonCheckResult(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click
        Dim button As Button = CType(sender, Button)

        Select Case button.Name
            Case "Button1"
                VerificarRespuesta(Button1.Text)
            Case "Button2"
                VerificarRespuesta(Button2.Text)
            Case "Button3"
                VerificarRespuesta(Button3.Text)
            Case "Button4"
                VerificarRespuesta(Button4.Text)
        End Select

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Correctos = 0
        Incorrectos = 0

        tbIntentosExitosos.Text = Correctos
        tbIntentosFallidos.Text = Incorrectos

        GenerarNuevaPregunta()
    End Sub

    Private Sub GenerarNuevaPregunta()
        Valor1 = ObtenerEnteroDefinido()
        Valor2 = ObtenerEnteroDefinido()
        ValorCorrecto = Valor1 + Valor2

        Label1.Text = "¿Cuánto es " & Valor1 & " + " & Valor2 & "?"

        ListaOpciones.Clear()
        ListaBotones.Clear()

        ListaOpciones = RetornarListaOpciones(ValorCorrecto)
        ListaBotones = RetornarListaBotones()

        For i = 0 To 3
            ListaBotones(i).Text = ListaOpciones(i).ToString()
        Next
    End Sub
    Private Function ObtenerEnteroDefinido() As Integer
        Dim enteroDefinido As Integer = rd.Next(500, 10000 + 1)
        Return enteroDefinido
    End Function
    Private Function RetornarListaOpciones(Resultado As Integer) As List(Of Integer)
        Dim ListaOpciones As New List(Of Integer)()
        Dim PosicionAleatoria As Integer = rd.Next(0, 3 + 1)

        For i = 0 To 3
            If (i = PosicionAleatoria) Then
                ListaOpciones.Add(Resultado)
            Else
                Dim Operador As Integer = rd.Next(1, 2 + 1)
                If (Operador = 1) Then
                    ListaOpciones.Add(Resultado - rd.Next(0, 100 + 1))
                ElseIf (Operador = 2) Then
                    ListaOpciones.Add(Resultado + rd.Next(0, 100 + 1))
                End If
            End If
        Next

        Return ListaOpciones
    End Function
    Private Function RetornarListaBotones() As List(Of Button)
        Dim ListaBotones As New List(Of Button)() From
            {Button1, Button2, Button3, Button4}
        Return ListaBotones
    End Function
End Class
