Imports System.DateTime


Module AhoraEs
    Sub Main(args As String())
        FechaActual()
        Console.WriteLine("La hora actual es: " & HoraActual())
    End Sub
    Sub FechaActual()
        Console.WriteLine("La fecha actual es: " & Now.Date)
    End Sub
    Function HoraActual() As String
        Return Now.Hour & ":" & Now.Minute
    End Function
End Module
