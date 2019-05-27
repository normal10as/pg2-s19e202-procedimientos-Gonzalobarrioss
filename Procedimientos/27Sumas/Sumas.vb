Imports System

Module Sumas
    Sub Main(args As String())
        Dim nr1, nr2, nr3, nr4, suma As Single
        Console.WriteLine("Sumar 2 numeros")
        Console.Write("Ingrese primer numero: ")
        nr1 = Console.ReadLine()
        Console.Write("Ingrese segundo numero: ")
        nr2 = Console.ReadLine()
        Console.WriteLine("El resultado es: " & Sumar(nr1, nr2, suma))
        Console.WriteLine("Sumar 3 numeros")
        Console.Write("Ingrese primer numero: ")
        nr1 = Console.ReadLine()
        Console.Write("Ingrese segundo numero: ")
        nr2 = Console.ReadLine()
        Console.Write("Ingrese tercer numero: ")
        nr3 = Console.ReadLine()
        Console.WriteLine("El resultado es: " & Sumar(nr1, nr2, nr3, suma))
        Console.WriteLine("Sumar 4 numeros")
        Console.Write("Ingrese primer numero: ")
        nr1 = Console.ReadLine()
        Console.Write("Ingrese segundo numero: ")
        nr2 = Console.ReadLine()
        Console.Write("Ingrese tercer numero: ")
        nr3 = Console.ReadLine()
        Console.Write("Ingrese cuarto numero: ")
        nr4 = Console.ReadLine()
        Console.WriteLine("El resultado es: " & Sumar(nr1, nr2, nr3, nr4, suma))
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
