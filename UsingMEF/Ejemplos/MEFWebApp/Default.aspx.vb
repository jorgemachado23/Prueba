Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim p As New Program
        p.Run()
        Response.Write(String.Format("El calculo es:  {0}", p.CalculoNacionalizado.Calculo(2)).ToString())
    End Sub

End Class