Imports System.Math

Module Potencias
    Sub Main(args As String())
        Dim a As Single
        Dim i As Byte = 2
        Console.WriteLine("Ingrese numero para calcular su potencia: ")
        a = Console.ReadLine()
        For i = 2 To 5
            If i = 4 Then
                Continue For
            End If
            Console.WriteLine("La potencia " & i & " de ese numero es: " & CalcularPotencia(a, i))
        Next
    End Sub
    Function CalcularPotencia(a As Single, i As Byte) As Single
        Return Pow(a, i)
    End Function
End Module
