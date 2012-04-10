Public Interface ICalculoNacionalizado
    Function Calculo(ByVal Entrada As Decimal) As Decimal

End Interface
Public Interface ICalculoNacionalizadoData
    ReadOnly Property MEFSelectorType As EnumMEFSelectorType
    ReadOnly Property MEFSite As String
    ReadOnly Property MEFCountry As EnumMEFCountry
    ReadOnly Property MEFUserCompany As String
End Interface
