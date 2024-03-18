Imports System

Module Program
    Sub Main()
        Dim Vectornotas(4) As Double
        Dim suma As Double = 0
        Dim prom As Double
        Console.WriteLine("PROMEDIO DE 5 NOTAS")

        For i As Integer = 0 To 4
            Console.Write("Por favor, ingrese la nota " & (i + 1) & ": ")
            Vectornotas(i) = Double.Parse(Console.ReadLine())
            suma += Vectornotas(i)
        Next

        prom = suma / 5

        Console.WriteLine("El promedio de las notas es: " & prom)

        Console.WriteLine("Presione cualquier tecla para salir...")
        Console.ReadKey()
    End Sub
End Module
