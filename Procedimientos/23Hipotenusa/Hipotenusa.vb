Imports System.Math

Module Hipotenusa
    Sub Main(args As String())
        Dim A, B As Single
        Console.WriteLine("Ingrese valor del lado A: ")
        A = Console.ReadLine()
        Console.WriteLine("Ingrese valor del lado B: ")
        B = Console.ReadLine()
        Console.WriteLine("La hipotenusa es: " & Sqrt(Hipotenusa(A, B)))
    End Sub
    Function Hipotenusa(A As Single, B As Single) As Single
        Dim C As Single
        C = Pow(A, 2) + Pow(B, 2)
        Return C
    End Function
End Module
