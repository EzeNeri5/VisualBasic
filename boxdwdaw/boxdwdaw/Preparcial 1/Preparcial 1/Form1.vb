Public Class Form1

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TotaldeRegistro > 2 Then
            MsgBox("La Lista esta Llena")
            limpiar(Me)
            TextBox1.Focus()
        Else
            If Val(TextBox3.Text) > 0 And Val(TextBox4.Text) > 0 Then
                TotaldeRegistro += 1
                stock(TotaldeRegistro).articulo = Val(TextBox1.Text)
                stock(TotaldeRegistro).descripcion = TextBox2.Text
                stock(TotaldeRegistro).cantidad = Val(TextBox3.Text)
                stock(TotaldeRegistro).precio = Val(TextBox4.Text)
                MsgBox("Agregado")
                ComboBox1.Items.Add(TextBox1.Text)
                limpiar(Me)
                TextBox1.Focus()
            Else
                MsgBox("Igrese una cantidad y un precio mayor que 0")
            End If

        End If

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For i = 1 To TotaldeRegistro
            If stock(i).articulo = Val(TextBox9.Text) Then
                TextBox5.Text = stock(i).articulo
                TextBox6.Text = stock(i).descripcion
                TextBox7.Text = stock(i).cantidad
                TextBox8.Text = stock(i).precio * stock(i).cantidad
                TextBox9.Text = " "
                Exit Sub
            End If
            If stock(i).descripcion = TextBox9.Text Then
                TextBox5.Text = stock(i).articulo
                TextBox6.Text = stock(i).descripcion
                TextBox7.Text = stock(i).cantidad
                TextBox8.Text = stock(i).precio * stock(i).cantidad
                TextBox9.Text = " "
                Exit Sub
            End If
        Next
        MsgBox("Producto no encontrado")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim i, j, aux As Integer

        For i = 1 To TotaldeRegistro

            If UCase(stock(i).articulo) = UCase(ComboBox1.Text) Then
                TextBox5.Text = stock(i).articulo
                TextBox6.Text = stock(i).descripcion
                TextBox7.Text = stock(i).cantidad
                TextBox8.Text = stock(i).precio
                aux = MsgBox("Quiere eliminar el registro:" + TextBox1.Text, 32 + 1, "Eliminar") '32 signo ? 1 boton aceptar o cancelar'
                If aux = 1 Then
                    TotaldeRegistro = TotaldeRegistro - 1
                    For j = i To TotaldeRegistro 'for para correr las filas, debe dar la vuelta'

                        stock(j).articulo = stock(j + 1).articulo
                        stock(j).descripcion = stock(j + 1).descripcion
                        stock(j).cantidad = stock(j + 1).cantidad
                        stock(j).precio = stock(j + 1).precio
                    Next j
                    ComboBox1.Items.RemoveAt(i - 1)
                    MsgBox("Elimino el registro")
                    limpiar(Me)
                    ComboBox1.Text = " "
                End If

            End If
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        For i = 1 To TotaldeRegistro
            If stock(i).articulo = Val(ComboBox1.Text) Then
                TextBox5.Text = stock(i).articulo
                TextBox6.Text = stock(i).descripcion
                TextBox7.Text = stock(i).cantidad
                TextBox8.Text = stock(i).precio * stock(i).cantidad
                TextBox9.Text = " "
                Exit Sub
            End If
        Next
        MsgBox("Producto no encontrado")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
