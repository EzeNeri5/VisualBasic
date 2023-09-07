Public Class Form1
    Dim aux1 As Integer
    Dim aux2 As Integer
    Dim aux3 As Double

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Label1.Text = "+"
        aux1 = Val(TextBox1.Text)
        aux2 = Val(TextBox2.Text)
        aux3 = aux1 + aux2

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Label1.Text = "-"

        aux1 = Val(TextBox1.Text)
        aux2 = Val(TextBox2.Text)
        aux3 = aux1 - aux2

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Label1.Text = "*"

        aux1 = Val(TextBox1.Text)
        aux2 = Val(TextBox2.Text)
        aux3 = aux1 * aux2

    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Label1.Text = "/"

        aux1 = Val(TextBox1.Text)
        aux2 = Val(TextBox2.Text)
        'aux3 = aux1 / aux2
        
        If aux2 = 0 And RadioButton4.Checked Then

            MsgBox("NO SE PUEDE DIVIDIR POR CERO")

        Else : aux3 = aux1 / aux2
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
   

        TextBox3.Text = aux3
    End Sub
End Class
