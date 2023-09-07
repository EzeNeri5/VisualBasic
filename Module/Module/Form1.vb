Public Class Form1

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox2.Focus()
            e.Handled = True 'eliminar pitito'

        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TotalRegistro = 0
    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button.Click
        TotalRegistro += 1
        If TotalRegistro > 5 Then
            MsgBox("Lista esta llena")
        Else
            Agenda(TotalRegistro).Nombre = TextBox1.Text
            Agenda(TotalRegistro).Apellido = TextBox2.Text
            Agenda(TotalRegistro).Edad = Val(TextBox3.Text)
            MsgBox("Agregado")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox1.Focus() 'Vuelve en el primer texbox
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dim aux As String
        'aux = TextBox7.Text
        'If aux = TotalRegistro.Then Then
        '    TextBox4.Text = Agenda(TotalRegistro).Nombre
        '    TextBox5.Text = Agenda(TotalRegistro).Apellido
        '    TextBox6.Text = Agenda(TotalRegistro).Edad
        'End If
        For i = 1 To TotalRegistro

            If Agenda(i).Nombre = TextBox7.Text Then


                TextBox4.Text = Agenda(i).Nombre
                TextBox5.Text = Agenda(i).Apellido
                TextBox6.Text = Agenda(i).Edad
                TextBox7.Text = ""
                Exit Sub 'sale de todas las lineas
            End If

            If Agenda(i).Apellido = TextBox7.Text Then

                TextBox4.Text = Agenda(i).Nombre
                TextBox5.Text = Agenda(i).Apellido
                TextBox6.Text = Agenda(i).Edad
                TextBox7.Text = ""
                Exit Sub
            End If

            If Agenda(i).Edad = Val(TextBox7.Text) Then

                TextBox4.Text = Agenda(i).Nombre
                TextBox5.Text = Agenda(i).Apellido
                TextBox6.Text = Agenda(i).Edad
                TextBox7.Text = ""
                Exit Sub
            End If
        Next
        MsgBox("dato no encotrado")
        TextBox7.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i, j, aux As Integer

        For i = 1 To TotalRegistro 'for para eliminar, debe dar la vuelta'

            If UCase(Agenda(i).Nombre) = UCase(TextBox8.Text) Then
                TextBox4.Text = Agenda(i).Nombre
                TextBox5.Text = Agenda(i).Apellido
                TextBox6.Text = Agenda(i).Edad
                aux = MsgBox("Quiere eliminar el registro:" + TextBox1.Text, 32 + 1, "Eliminar") '32 signo ? 1 boton aceptar o cancelar'
                If aux = 1 Then
                    TotalRegistro = TotalRegistro - 1
                    For j = i To TotalRegistro 'for para correr las filas, debe dar la vuelta'
                        Agenda(j).Nombre = Agenda(j + 1).Nombre
                        Agenda(j).Apellido = Agenda(j + 1).Apellido
                        Agenda(j).Edad = Agenda(j + 1).Edad
                    Next j
                    MsgBox("Elimino el registro")
                    TextBox4.Text = ""
                    TextBox5.Text = ""
                    TextBox6.Text = ""
                    TextBox7.Text = ""
                    TextBox8.Text = ""
                    TextBox8.Focus()
                End If

            End If
        Next

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox3.Focus()
            e.Handled = True 'eliminar pitito'
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Chr(13) Then
            Button.Focus()
            e.Handled = True 'eliminar pitito'
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Button.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox1.Focus()
            e.Handled = True 'eliminar pitito'

        End If
    End Sub

    Private Sub TextBox7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox7.KeyDown

    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Button2_Click(sender, e) 'enter en la misma celda'
            e.Handled = True 'eliminar pitito'

        End If
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1.Focus()
            e.Handled = True 'eliminar pitito'

        End If
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub Button2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Button2.KeyPress

    End Sub
End Class
