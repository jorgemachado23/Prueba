Imports System.ComponentModel.Composition
Imports Contracto.Calculos

<Export(GetType(ICalculoNacionalizado))> _
Public Class Calculo
    Implements Contracto.Calculos.ICalculoNacionalizado


    Public Function Calculo(ByVal Entrada As Decimal) As Decimal Implements Contracto.Calculos.ICalculoNacionalizado.Calculo
        Dim Salida As Decimal = 2 * Entrada
        Return Salida
    End Function

    Public ReadOnly Property Pais As String Implements Contracto.Calculos.ICalculoNacionalizado.Pais
        Get
            Return "rus"
        End Get
    End Property
End Class
