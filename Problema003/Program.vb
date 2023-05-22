Imports System

Module Program
    Sub Main(args As String())
        Dim nombre As String
        Console.WriteLine("Dame tu nombre")
        nombre = Console.ReadLine()
        Console.WriteLine("Hola, mucho gusto " & nombre)
        Console.ReadKey()
    End Sub
End Module
