Imports System

Module Program
    Sub Main(args As String())
        Dim nota1, nota2, nota3, prom As Integer
        Console.WriteLine("Dame tu promedio de tareas")
        nota1 = Console.ReadLine()
        Console.WriteLine("Dame tu promedio de examenes")
        nota2 = Console.ReadLine()
        Console.WriteLine("Dame tu promedio del proyecto integrador")
        nota3 = Console.ReadLine()
        If (nota1 >= 0 And nota1 <= 100) And (nota2 >= 0 And nota2 <= 100) And (nota3 >= 0 And nota3 <= 100) Then
            prom = (nota1 * 0.2) + (nota2 * 0.3) + (nota3 * 0.5)
            If prom >= 70 Then
                Console.WriteLine("Has pasado el curso con: " & prom)
            Else
                Console.WriteLine("Has reprobado el curso con: " & prom)
            End If
        Else
            Console.WriteLine("Resultados no validos")
        End If
        Console.ReadKey()
    End Sub
End Module
