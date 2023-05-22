Imports System

Module Program
    Sub Main(args As String())

        Dim calif As Integer
        Dim flag As Boolean

        Do
            Console.WriteLine("Ingrese una calificación")
            calif = Console.ReadLine()
            If (calif >= 70) Then
                flag = True
                Console.WriteLine("Has acreditado")
            Else
                Console.WriteLine("Has reprobado")
            End If
        Loop While (flag = False)

        Console.ReadKey()
    End Sub
End Module
