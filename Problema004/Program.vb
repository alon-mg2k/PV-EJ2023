Imports System

Module Program
    Sub Main(args As String())
        Dim nserie, lim, resultado, total As Integer
        total = 0
        Console.WriteLine("Dame un numero")
        nserie = Console.ReadLine()
        Console.WriteLine("Dame las veces a multiplicar")
        lim = Console.ReadLine()
        For i = 1 To lim
            resultado = nserie * i
            Console.WriteLine("------------------------------------------------------------------------")
            Console.WriteLine("Tabla del [" & nserie & "] múltiplo[" & i & "] Resultado = " & resultado)
            Console.WriteLine("------------------------------------------------------------------------")
            total += resultado
        Next
        Console.WriteLine("Resultado total: " & total)
        Console.ReadKey()
    End Sub
End Module
