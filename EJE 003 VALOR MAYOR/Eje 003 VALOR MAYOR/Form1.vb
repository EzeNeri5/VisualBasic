Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Valor1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Valor2.Click

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub ValorMayor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValorMayor.Click

    End Sub

    Private Sub Comparar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Comparar.Click
        Dim aux1 As Integer
        Dim aux2 As Integer

        aux1 = TextBox1.Text
        aux2 = TextBox2.Text
        If aux1 > aux2 Then 'condicion simple, aux1 es mayor a aux2'
            ValorMayor.Text = "El valor 1 mayor es: " + aux1.ToString 'ingresa a la condicion y muestra'
        Else 'si es mayor aux2'
            ValorMayor.Text = "El valor 2 mayor es: " + aux2.ToString 'ingresa a esta condicion y muestra'
        End If

    End Sub
End Class
