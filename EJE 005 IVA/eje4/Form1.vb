Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim valor As Integer
        Dim iva As Integer
        Dim total As Integer
        valor = Val(TextBox1.Text)
        iva = valor * 0.1
        total = valor * 1.1
        TextBox2.Text = iva.ToString
        TextBox3.Text = total.ToString
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim valor As Integer
        Dim iva As Integer
        Dim total As Integer
        valor = Val(TextBox1.Text)
        iva = valor * 0.2
        total = valor * 1.2
        TextBox2.Text = iva.ToString
        TextBox3.Text = total.ToString
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
