﻿Imports System.ComponentModel.Composition
Imports Contrato.Calculos

<Export(GetType(ICalculoNacionalizado))> _
<ExportMetadata("MEFSelectorType", "Country")> _
<ExportMetadata("MEFCountry", "Colombia")> _
<ExportMetadata("MEFUserCompany", Nothing)>
Public Class Calculo
    Implements Contrato.Calculos.ICalculoNacionalizado

    Public Function Calculo(ByVal Entrada As Decimal) As Decimal Implements Contrato.Calculos.ICalculoNacionalizado.Calculo
        Dim Salida As Decimal = 3 * Entrada
        Return Salida
    End Function


End Class
