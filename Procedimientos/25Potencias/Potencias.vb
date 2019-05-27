Imports System.Math

Module Potencias
    Sub Main(args As String())
        Dim a As Single
        Dim i As Byte = 1
        Console.WriteLine("Ingrese numero para calcular su potencia: ")
        a = Console.ReadLine()
        Console.WriteLine("La potencia  de ese numero es: " & CalcularPotencia(a, i))
        Console.WriteLine("La potencia  de ese numero es: " & CalcularPotencia(a, i))
        CalcularPotencia(a, i)
        Console.WriteLine("La potencia  de ese numero es: " & CalcularPotencia(a, i))
    End Sub
    Function CalcularPotencia(a, ByRef i) As Single
        i += 1
        Return Pow(a, i)
    End Function
End Module
