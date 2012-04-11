Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim p As New Program
        p.Run()
        'esto es una prueba de cambios para probar GIT
        MessageBox.Show(String.Format("El calculo es:  {0}", p.CalculoNacionalizado.Calculo(2)).ToString())
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
