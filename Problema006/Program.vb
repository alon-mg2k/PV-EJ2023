Imports System

Module Program
    Sub Main(args As String())
        Dim lim, cont As Integer
        Console.WriteLine("Obtener todos los n�meros divisores, dame el n�mero l�mite...")
        lim = Console.ReadLine()

        For i = 1 To lim
            If lim Mod i = 0 Then
                Console.WriteLine("El numero [" & i & "] es divisor de " & lim & ".")
            End If

        Next

        Console.ReadKey()
    End Sub
End Module
