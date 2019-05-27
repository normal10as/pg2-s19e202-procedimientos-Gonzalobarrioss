Imports System

Module Acumuladora
    Sub Main(args As String())
        Dim acumulador, valor_decimal As Single
        Console.Write("Ingrese un numero: ")
        valor_decimal = Console.ReadLine()
        NumerosAcumulados(acumulador, valor_decimal)
        NumerosAcumulados(acumulador, valor_decimal)
        NumerosAcumulados(acumulador, valor_decimal)
    End Sub

    Sub NumerosAcumulados(ByRef acumulador, valor_decimal)
        acumulador += valor_decimal
        Console.WriteLine(acumulador)
    End Sub
End Module
