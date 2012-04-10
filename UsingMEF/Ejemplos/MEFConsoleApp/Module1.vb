Imports Contrato.Calculos

Module Module1
    Public Sub Main()
        Dim fechainicio As Date = Date.Now
        Dim p As New Program
        p.Run()
        Dim fechafin As Date = Date.Now
        Console.WriteLine(String.Format("El calculo es:  {0}", p.CalculoNacionalizado.Calculo(2)).ToString())

        Console.Write(DateDiff(DateInterval.Second, fechainicio, fechafin))
        Console.Read()
    End Sub
End Module
