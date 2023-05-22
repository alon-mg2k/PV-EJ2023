Imports System

Module Program
    Sub Main(args As String())
        Dim opcion As String

        Do
            Console.WriteLine("Selecciona una figura para calcular su área 1) Cuadrado 2) Triángulo 3) Círculo 4) Rombo 5) Salir")
            opcion = Console.ReadLine()

            Select Case opcion
                Case "1"
                    Dim lado, area As Decimal
                    Console.WriteLine("Dame el lado")
                    lado = Console.ReadLine()
                    area = lado * lado
                    Console.WriteLine("El area del cuadrado es igual a: " & area & " cm.")
                Case "2"
                    Dim lado, altura, area As Decimal
                    Console.WriteLine("Dame el lado")
                    lado = Console.ReadLine()
                    Console.WriteLine("Dame la altura")
                    altura = Console.ReadLine()
                    area = (lado * altura) / 2
                    Console.WriteLine("El area del triángulo es igual a: " & area & " cm.")
                Case "3"
                    Dim radio, area As Decimal
                    Console.WriteLine("Dame el radio")
                    radio = Console.ReadLine()
                    area = Math.PI * Math.Pow(radio, 2)
                    Console.WriteLine("El area del círculo es igual a: " & area & " cm.")
                Case "4"
                    Dim dM, dMen, area As Decimal
                    Console.WriteLine("Dame el diagonal mayor")
                    dM = Console.ReadLine()
                    Console.WriteLine("Dame el diagonal menor")
                    dMen = Console.ReadLine()
                    area = (dM * dMen) / 2
                    Console.WriteLine("El area del rombo es igual a: " & area & " cm.")
                Case "5"
                    Console.WriteLine("Saliendo del programa...")
                Case Else
                    Console.WriteLine("Elija otra opción")
            End Select
        Loop While (Not (opcion = "5"))

        Console.ReadKey()

    End Sub
End Module
