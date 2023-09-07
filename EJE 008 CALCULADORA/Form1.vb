Public Class Form1
    Dim aux1 As Double
    Dim operador As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.Length < 12 Then
            TextBox1.Text = TextBox1.Text + "1"
        End If
        
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If operador = "suma" Then
            TextBox1.Text = aux1 + TextBox1.Text
            If TextBox1.Text.Length < 13 Then
            Else
                TextBox1.Text = "OVERFLOW"
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text.Length < 12 Then
            TextBox1.Text = TextBox1.Text + "2"
        End If

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click

        aux1 = Val(TextBox1.Text)
        TextBox1.Text = ""
        operador = "suma"

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text.Length < 12 Then
            TextBox1.Text = TextBox1.Text + "3"
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox1.Text.Length < 12 Then
            TextBox1.Text = TextBox1.Text + "4"
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If TextBox1.Text.Length < 12 Then
            TextBox1.Text = TextBox1.Text + "5"
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If TextBox1.Text.Length < 12 Then
            TextBox1.Text = TextBox1.Text + "6"
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If TextBox1.Text.Length < 12 Then
            TextBox1.Text = TextBox1.Text + "7"
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If TextBox1.Text.Length < 12 Then
            TextBox1.Text = TextBox1.Text + "8"
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If TextBox1.Text.Length < 12 Then
            TextBox1.Text = TextBox1.Text + "9"
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If TextBox1.Text.Length < 12 Then
            TextBox1.Text = TextBox1.Text + "0"
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If operador = "resta" Then
            TextBox1.Text = aux1 - TextBox1.Text

        End If
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        If operador = "suma" Then
            TextBox1.Text = aux1 * TextBox1.Text
            If TextBox1.Text.Length < 13 Then
            Else
                TextBox1.Text = "OVERFLOW"
            End If
        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        If operador = "suma" Then
            TextBox1.Text = aux1 / TextBox1.Text
            End If
    End Sub
End Class
