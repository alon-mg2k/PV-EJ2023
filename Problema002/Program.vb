Imports System

Module Program
    Sub Main(args As String())
        Dim edad
        Console.WriteLine("Ingrese su edad")
        edad = Console.ReadLine()
        If edad < 18 And edad > 0 Then
            Console.WriteLine("Eres menor de edad")
        ElseIf edad >= 18 And edad < 100 Then
            Console.WriteLine("Eres mayor de edad")
        ElseIf edad <= 0 Then
            Console.Write("No hay años negativos ni edades negativas.")
        Else
            Console.WriteLine("Tienes una edad incoherente, o tu edad ingresada no es válida")
        End If
        Console.ReadKey()
    End Sub

End Module
