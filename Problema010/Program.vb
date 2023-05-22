Imports System

Module Program
    Sub Main(args As String())
        Dim check, check2 As Boolean
        Dim num1, num2, res, correcto, incorrecto As Integer
        Dim s As String

        correcto = 0
        incorrecto = 0

        check = True
        While (check)
            check2 = False
            num1 = Int((400 * Rnd()) + 1)
            num2 = Int((400 * Rnd()) + 1)

            Console.WriteLine("Cúanto es " & num1 & " + " & num2 & "?")
            res = Console.ReadLine()

            If (res = (num1 + num2)) Then
                Console.WriteLine("Correcto")
                correcto += 1
            Else
                Console.WriteLine("Incorrecto")
                incorrecto += 1
            End If

            While (check2 = False)
                Console.WriteLine("¿Deseas continuar?")
                s = Console.ReadLine()

                Select Case s
                    Case "s"
                        check2 = True
                        Console.WriteLine("Recargando...")
                    Case "n"
                        check = False
                        check2 = True
                        Console.WriteLine("Perfecto, su puntuación ha sido " & correcto & " correctas y " & incorrecto & " incorrectas.")
                    Case Else
                        Console.WriteLine("Por favor ingrese S o N")
                End Select
            End While

        End While

        Console.ReadKey()
    End Sub
End Module
