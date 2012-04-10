Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim p As New Program
        p.Run()
        MessageBox.Show(String.Format("El calculo es:  {0}", p.CalculoNacionalizado.Calculo(2)).ToString())
    End Sub
End Class
