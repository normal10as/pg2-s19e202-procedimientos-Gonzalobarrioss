Imports System

Module SuperficieFiguras
    Sub Main(args As String())
        Dim a, b, c As Single
        Dim eleccion As Byte
        Console.WriteLine("Que superficie desea calcular (1- Cuadrado / 2- Rectangulo / 3- Trapecio): ")
        eleccion = Console.ReadLine()
        If eleccion = 1 Then
            Console.WriteLine("Ingrese valor del lado del cuadrado: ")
            a = Console.ReadLine()
            Console.WriteLine("La superficie es: " & CalcularSuperficie(a))
        End If
        If eleccion = 2 Then
            Console.WriteLine("Ingrese base del rectangulo: ")
            a = Console.ReadLine()
            Console.WriteLine("Ingrese altura del rectangulo: ")
            b = Console.ReadLine()
            Console.WriteLine("La superficie es: " & CalcularSuperficie(a, b))
        End If
        If eleccion = 3 Then
            Console.WriteLine("Ingrese valor del base mayor del trapecio: ")
            a = Console.ReadLine()
            Console.WriteLine("Ingrese base menor del trapecio: ")
            b = Console.ReadLine()
            Console.WriteLine("Ingrese altura del trapecio: ")
            c = Console.ReadLine()
            Console.WriteLine("La superficie es: " & CalcularSuperficie(a, b, c))
        End If
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
