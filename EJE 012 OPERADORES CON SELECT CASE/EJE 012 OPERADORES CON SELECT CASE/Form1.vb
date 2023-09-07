Public Class Form1

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Label1.Text = "+"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim aux As String
        aux = Label1.Text
        Select Case aux
            Case "+"
                TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
            Case "-"
                TextBox3.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
            Case "*"
                TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
            Case "/"
                If TextBox1.Text = "0" Or TextBox2.Text = "0" Then
                    MsgBox("No se puede dividir por 0")
                Else : TextBox3.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
                End If
            Case Else
                MsgBox("Seleccione una operacion", 0, "Error")

        End Select
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Label1.Text = "*"
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Label1.Text = "-"
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Label1.Text = "/"
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
