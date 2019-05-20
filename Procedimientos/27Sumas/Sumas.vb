Imports System

Module Sumas
    Sub Main(args As String())
        Dim nr1, nr2, nr3, nr4, suma As Single
        Dim cantnum As Byte
        Console.WriteLine("Cuantos numeros quiere sumar ( 2, 3, 4: )")
        cantnum = Console.ReadLine()
        If cantnum = 2 Then
            Console.WriteLine("Ingrese numero: ")
            nr1 = Console.ReadLine()
            Console.WriteLine("Ingrese numero: ")
            nr2 = Console.ReadLine()
            Console.WriteLine("El resultado es: " & Sumar(nr1, nr2, suma))
        End If
        If cantnum = 3 Then
            Console.WriteLine("Ingrese numero: ")
            nr1 = Console.ReadLine()
            Console.WriteLine("Ingrese numero: ")
            nr2 = Console.ReadLine()
            Console.WriteLine("Ingrese numero: ")
            nr3 = Console.ReadLine()
            Console.WriteLine("El resultado es: " & Sumar(nr1, nr2, nr3, suma))
        End If
        If cantnum = 4 Then
            Console.WriteLine("Ingrese numero: ")
            nr1 = Console.ReadLine()
            Console.WriteLine("Ingrese numero: ")
            nr2 = Console.ReadLine()
            Console.WriteLine("Ingrese numero: ")
            nr3 = Console.ReadLine()
            Console.WriteLine("Ingrese numero: ")
            nr4 = Console.ReadLine()
            Console.WriteLine("El resultado es: " & Sumar(nr1, nr2, nr3, nr4, suma))
        End If
    End Sub

    Function Sumar(nr1, nr2, suma) As Single
        suma = nr1 + nr2
        Return suma
    End Function

    Function Sumar(nr1, nr2, nr3, suma) As Single
        suma = nr1 + nr2 + nr3
        Return suma
    End Function

    Function Sumar(nr1, nr2, nr3, nr4, suma) As Single
        suma = nr1 + nr2 + nr3 + nr4
        Return suma
    End Function
End Module
