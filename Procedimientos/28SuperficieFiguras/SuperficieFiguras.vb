Imports System

Module SuperficieFiguras
    Sub Main(args As String())
        Dim a, b, c As Single
        Console.WriteLine("Calcular superficie de un cuadrado")
        Console.WriteLine("Ingrese valor del lado del cuadrado: ")
            a = Console.ReadLine()
            Console.WriteLine("La superficie es: " & CalcularSuperficie(a))
        Console.WriteLine("Calcular superficie de un rectangulo")
        Console.WriteLine("Ingrese base del rectangulo: ")
            a = Console.ReadLine()
            Console.WriteLine("Ingrese altura del rectangulo: ")
            b = Console.ReadLine()
            Console.WriteLine("La superficie es: " & CalcularSuperficie(a, b))
        Console.WriteLine("Calcular superficie de un trapecio")
        Console.WriteLine("Ingrese valor del base mayor del trapecio: ")
            a = Console.ReadLine()
            Console.WriteLine("Ingrese base menor del trapecio: ")
            b = Console.ReadLine()
            Console.WriteLine("Ingrese altura del trapecio: ")
            c = Console.ReadLine()
        Console.WriteLine("La superficie es: " & CalcularSuperficie(a, b, c))
    End Sub

    Function CalcularSuperficie(a) As Single
        Dim superf_cuadrado As Single
        superf_cuadrado = a * a
        Return superf_cuadrado
    End Function

    Function CalcularSuperficie(a, b) As Single
        Dim superf_rectangulo As Single
        superf_rectangulo = a * b
        Return superf_rectangulo
    End Function

    Function CalcularSuperficie(a, b, c) As Single
        Dim superf_trapecio As Single
        superf_trapecio = ((a + b) / 2) * c
        Return superf_trapecio
    End Function
End Module
