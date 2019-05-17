Imports System.DateTime

Module Nueva_Fecha
    Sub Main(args As String())
        Dim fecha As Date
        Dim dias As Byte
        Console.WriteLine("Ingrese una fecha: ")
        fecha = Console.ReadLine()
        Console.WriteLine("Ingrese dias a sumar: ")
        dias = Console.ReadLine()
        Console.WriteLine("La nueva fecha es: " & NuevaFecha(fecha, dias))
    End Sub
    Function NuevaFecha(fecha As Date, dias As Byte) As String
        Return fecha.AddDays(dias)
    End Function
End Module
