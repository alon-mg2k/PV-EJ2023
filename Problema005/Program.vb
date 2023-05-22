Imports System

Module Program
    Sub Main(args As String())
        Dim profesor, materia As String
        Dim n As Integer
        Dim promG, aprob, reprob As Integer

        Console.WriteLine("---------------------------------------------------------------------------------------")
        Console.WriteLine("UNIVERSIDAD AUTONOMA DE NUEVO LEON - FACULTAD DE INGENIERIA MECANICA Y ELECTRICA")
        Console.WriteLine("GENERADORA DE LISTA DE CALIFICACIONES DE ASIGNATURA - 0.2")
        Console.WriteLine("UANL - 1993")
        Console.WriteLine("---------------------------------------------------------------------------------------")

        Console.WriteLine("Dame el nombre de la materia")
        materia = Console.ReadLine()
        Console.WriteLine("Dame el nombre del profesor")
        profesor = Console.ReadLine()
        Console.WriteLine("Dame el total de alumnos en la materia inscrita")
        n = Console.ReadLine()

        Dim nom(n) As String
        Dim mat(n), calif(n), primerp(n), segundop(n), tercerp(n) As Integer

        For i = 1 To n
            Console.WriteLine("Dame el nombre del estudiante [" & i & "]")
            nom(i) = Console.ReadLine()
            Console.WriteLine("")
            Console.WriteLine("Dame la matricula del estudiante [" & i & "]")
            mat(i) = Console.ReadLine()
            Console.WriteLine("")
            Console.WriteLine("Dame el promedio del primer parcial (20 pts) [" & i & "]")
            primerp(i) = Console.ReadLine()
            Console.WriteLine("")
            Console.WriteLine("Dame el promedio del segundo parcial (30 pts) [" & i & "]")
            segundop(i) = Console.ReadLine()
            Console.WriteLine("")
            Console.WriteLine("Dame el promedio del tercer parcial (50 pts) [" & i & "]")
            tercerp(i) = Console.ReadLine()
            Console.WriteLine("")
            calif(i) = (primerp(i) * 0.2) + (segundop(i) * 0.3) + (tercerp(i) * 0.5)

            If (calif(i) >= 70 And calif(i) <= 100) Then
                aprob += 1
            ElseIf (calif(i) < 70 And calif(i) >= 0) Then
                reprob += 1
            Else
                calif(i) = 0
            End If

            promG += calif(i)
        Next

        Console.WriteLine("---------------------------------------------------------------------------------------")
        Console.WriteLine("Materia: " & materia)
        Console.WriteLine("Profesor: " & profesor)
        Console.WriteLine("---------------------------------------------------------------------------------------")

        Console.WriteLine("---------------------------------------------------------------------------------------")
        Console.WriteLine("| Matrícula | Nom. estudiante | 1erParcial | 2doParcial | 3erParcial | Calif ")
        Console.WriteLine("---------------------------------------------------------------------------------------")

        For i = 1 To n
            Console.WriteLine("| " & mat(i) & " | " & nom(i) & " | " & primerp(i) & " | " & segundop(i) & " | " & tercerp(i) & " | " & calif(i))
        Next

        promG /= n

        Console.WriteLine("---------------------------------------------------------------------------------------")

        Console.WriteLine("---------------------------------------------------------------------------------------")
        Console.WriteLine("Aprobados: " & aprob)
        Console.WriteLine("Reprobados: " & reprob)
        Console.WriteLine("Promedio general: " & promG)

        Console.WriteLine("---------------------------------------------------------------------------------------")
        Console.ReadKey()


    End Sub
End Module
