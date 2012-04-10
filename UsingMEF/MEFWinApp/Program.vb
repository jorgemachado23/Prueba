Imports System.ComponentModel.Composition
Imports System.ComponentModel.Composition.Hosting
Imports Contracto.Calculos
Imports System.Configuration


Public Class Program

    Private _CalculoNacionalizado As ICalculoNacionalizado

    <ImportMany()> _
    Private Property CalculosNacionalizado As List(Of ICalculoNacionalizado)

    Public ReadOnly Property CalculoNacionalizado As ICalculoNacionalizado
        Get
            Return _CalculoNacionalizado
        End Get
    End Property

    Public Sub Run()
        Compose()
        Filter()
    End Sub
    Private Sub Compose()
        Dim directoryCatalogPath As String = ConfigurationManager.AppSettings("directoryCatalogPath")
        Dim catalog As New DirectoryCatalog(directoryCatalogPath)

        Dim batch As New CompositionBatch()
        batch.AddPart(Me)

        Dim container As New CompositionContainer(catalog)
        container.Compose(batch)
    End Sub


    Private Sub Filter()
        If Me.CalculosNacionalizado Is Nothing Or CalculosNacionalizado.Count <= 0 Then
            Throw New Exception("No se ha cargado ningun calculo, posiblemente no se ha copiado ningun ensamblado en el directorio del catalogo")
        End If

        Dim countryToUse As String = ConfigurationManager.AppSettings("countryToUse")
        _CalculoNacionalizado = (From calculo In Me.CalculosNacionalizado Where calculo.Pais = countryToUse Select calculo).LastOrDefault

        If _CalculoNacionalizado Is Nothing Then
            Throw New Exception(String.Format("No se encontro ningun calculo con el codigo de pais {0} en el catalogo", countryToUse))
        End If
    End Sub
End Class
