Public Class Form1

    Private Sub Suma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Suma.Click
        Dim aux1, aux2 As Double
        aux1 = Val(Replace(tex1.Text, ",", "."))
        aux2 = Val(Replace(Tex2.Text, ",", "."))

        Tex3.Text = aux1 + aux2

    End Sub

    Private Sub Resta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Resta.Click
        Dim aux1, aux2 As Double
        aux1 = Val(Replace(tex1.Text, ",", "."))
        aux2 = Val(Replace(Tex2.Text, ",", "."))

        Tex3.Text = aux1 - aux2
    End Sub

    Private Sub Multiplicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Multiplicacion.Click
        Dim aux1, aux2 As Double
        aux1 = Val(Replace(tex1.Text, ",", "."))
        aux2 = Val(Replace(Tex2.Text, ",", "."))

        Tex3.Text = aux1 * aux2
    End Sub

    Private Sub Division_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Division.Click
        Dim aux1, aux2 As Double
        aux1 = Val(Replace(tex1.Text, ",", "."))
        aux2 = Val(Replace(Tex2.Text, ",", "."))
        If aux1 = 0 Or aux2 = 0 Then
            MsgBox("Esta dividiendo por 0")
            tex1.Text = ""
            Tex2.Text = ""
            tex1.Focus()
        Else
            Tex3.Text = aux1 / aux2
            tex1.Focus()
            tex1.Text = ""
            Tex2.Text = ""
        End If

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        End
    End Sub
End Class
