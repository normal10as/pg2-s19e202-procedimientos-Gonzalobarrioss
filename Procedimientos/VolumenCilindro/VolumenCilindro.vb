Imports System.Math

Module VolumenCilindro
    Const pi As Single = 3.14159265
    Sub Main(args As String())
        Dim radio_base As Single
        Dim altura As UInt16
        Console.WriteLine("Ingrese Radio base del  cilindro: ")
        radio_base = Console.ReadLine()
        Console.WriteLine("Ingrese Altura del cilindro: ")
        altura = Console.ReadLine()
        Console.WriteLine("El volumen del cilindro es: " & Volumen_Cilindro(radio_base, altura))
    End Sub
    Function Volumen_Cilindro(radio_base As Single, altura As UInt16) As Single
        Dim Volumen As Single
        Volumen = pi * (Pow(radio_base, 2) * altura)
        Return Volumen
    End Function
End Module
