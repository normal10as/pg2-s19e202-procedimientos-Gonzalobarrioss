Imports System

Module Acumuladora
    Sub Main(args As String())
        Dim acumulador, y As Single
        Console.WriteLine("Ingrese un numero: ")
        acumulador = Console.ReadLine()
        NumerosAcumulados(y, acumulador)
    End Sub

    Sub NumerosAcumulados(y, acumulador)
        Dim i As Byte
        For i = 0 To 2
            y = y + acumulador
            Console.WriteLine(y)
        Next

    End Sub
End Module
