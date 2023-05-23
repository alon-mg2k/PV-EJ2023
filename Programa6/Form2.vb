Imports System.Numerics

Public Class Form2
    Public Dificultad, TipoReactivo As String
    Public Correcto As Boolean?
    Public Tiempo As Long
    Public ListaOpciones As New List(Of Decimal)()
    Public ListaBotones As New List(Of Button)()
    Public Valor1, Valor2, RespuestaCorrecta As Decimal
    Public rd As New Random

    Public Sub New(dificultad As String, tipoReactivo As String, tiempo As Long)
        InitializeComponent()
        Me.Tiempo = tiempo
        Me.TipoReactivo = tipoReactivo
        Me.Dificultad = dificultad
        GenerarNuevaPregunta(tipoReactivo, dificultad, tiempo)
    End Sub
    Public Sub VerificarRespuesta(respuesta As String)
        Dim conversionRespuesta = Decimal.Parse(respuesta)
        If (conversionRespuesta = RespuestaCorrecta) Then
            MsgBox("¡Respuesta Correcta!", MsgBoxStyle.Information, "¡Éxito!")
            Form1.Acertados += 1
            Form1.tbIntentosExitosos.Text = Form1.Acertados
            Correcto = True
            Me.Close()
        Else
            MsgBox("¡Respuesta Incorrecta!", MsgBoxStyle.Critical, "¡Error!")
            Form1.Fallidos += 1
            Form1.tbIntentosFallidos.Text = Form1.Fallidos
            Correcto = False
            Me.Close()
        End If

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

    Private Sub GenerarNuevaPregunta(tipoReactivo As String, dificultad As String, tiempo As Long)
        Valor1 = ObtenerEnteroDefinido(dificultad)
        Valor2 = ObtenerEnteroDefinido(dificultad)
        RespuestaCorrecta = RetornarResultado(tipoReactivo)

        ListaOpciones.Clear()
        ListaBotones.Clear()

        ListaOpciones = RetornarListaOpciones(RespuestaCorrecta)
        ListaBotones = RetornarListaBotones()

        For i = 0 To 3
            ListaBotones(i).Text = ListaOpciones(i).ToString()
        Next

        MostrarPregunta(tipoReactivo)
    End Sub
    Private Function ObtenerEnteroDefinido(dificultad As String) As Decimal
        Dim enteroDefinido As Integer
        Select Case dificultad
            Case "Fácil"
                enteroDefinido = rd.Next(100, 250 + 1)
            Case "Medio"
                enteroDefinido = rd.Next(250, 5000 + 1)
            Case "Dificil"
                enteroDefinido = rd.Next(5000, 10000 + 1)
        End Select
        Return enteroDefinido
    End Function
    Private Function RetornarListaOpciones(Resultado As Decimal) As List(Of Decimal)
        Dim ListaOpciones As New List(Of Decimal)()
        Dim PosicionAleatoria As Integer = rd.Next(0, 3 + 1)

        For i = 0 To 3
            If (i = PosicionAleatoria) Then
                ListaOpciones.Add(Resultado)
            Else
                Dim Operador As Integer = rd.Next(1, 2 + 1)
                If (Operador = 1) Then
                    ListaOpciones.Add(Resultado - rd.Next(0, rd.Next(0, 100 + 1) + 1))
                ElseIf (Operador = 2) Then
                    ListaOpciones.Add(Resultado + rd.Next(0, rd.Next(0, 100 + 1) + 1))
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
    Public Function RetornarResultado(tipoReactivo As String) As Decimal
        Dim res As Decimal
        Select Case tipoReactivo
            Case "Suma"
                res = Valor1 + Valor2
            Case "Resta"
                res = Valor1 - Valor2
            Case "Multiplicación"
                res = Valor1 * Valor2
            Case "División"
                res = Valor1 / Valor2
            Case "Residuo"
                res = Valor1 Mod Valor2
            Case "Potencia"
                res = Math.Pow(Valor1, 2)
        End Select
        Return res
    End Function
    Public Sub MostrarPregunta(tipoReactivo As String)
        Select Case tipoReactivo
            Case "Suma"
                Label1.Text = "¿Cuánto es " & Valor1 & " + " & Valor2 & "?"
            Case "Resta"
                Label1.Text = "¿Cuánto es " & Valor1 & " - " & Valor2 & "?"
            Case "Multiplicación"
                Label1.Text = "¿Cuánto es " & Valor1 & " * " & Valor2 & "?"
            Case "División"
                Label1.Text = "¿Cuánto es " & Valor1 & " / " & Valor2 & "?"
            Case "Residuo"
                Label1.Text = "¿Cuánto es el residuo de división entre " & Valor1 & " y " & Valor2 & "?"
            Case "Potencia"
                Label1.Text = "¿Cuánto es " & Valor1 & " al cuadrado?"
        End Select
    End Sub

    Private Sub CerrarPregunta(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (Correcto Is Nothing) Then
            MsgBox("¡No se ha indicado ninguna respuesta!", MsgBoxStyle.Critical, "¡Error!")
            Form1.Omitidos += 1
            Form1.tbIntentosOmitidos.Text = Form1.Omitidos
        End If
    End Sub
End Class