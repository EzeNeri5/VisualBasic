Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("1") 'agrega elemento (texto)'
        ComboBox1.Items.Add("2")
        ComboBox1.Items.Add("3")
        ComboBox1.Items.Add("4")
        ComboBox1.Items.Add("Juan")
        ComboBox1.Items.Add("Mariano")

        ComboBox1.Text = "seleccion"
        TextBox1.Text = ComboBox1.Items.Count
        'para saber la cantidad registrada'

        With ListBox1.Items
            .Add("1")
            .Add("2")
            .Add("3")
            .Add("4")
            .Add("Juan")
            .Add("Pedro")
        End With

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ComboBox1.Items.Add(TextBox2.Text)
        TextBox1.Text = ComboBox1.Items.Count
        MsgBox(TextBox2.Text + " Agregado") 'agregar elemento'
        ComboBox1.Text = TextBox2.Text 'mostrar en celda'
        TextBox2.Text = ""

    End Sub

    Private Sub LineShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LineShape2.Click, LineShape3.Click, LineShape4.Click, LineShape5.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'ComboBox1.Items.Insert (indice, texto)'
        If Val(TextBox3.Text) <= ComboBox1.Items.Count + 1 And Val(TextBox3.Text) >= 0 Then
            ComboBox1.Items.Insert(Val(TextBox3.Text) - 1, TextBox4.Text)
            TextBox1.Text = ComboBox1.Items.Count
            MsgBox(TextBox4.Text + " Agregado") 'agregar elemento'
            ComboBox1.Text = TextBox2.Text 'mostrar en celda'
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox3.Focus()
            TextBox4.Focus()
        Else
            MsgBox("el indice esta fuera de rango")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        TextBox8.Text = ComboBox1.Text
        TextBox7.Text = ComboBox1.SelectedIndex + 1

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'ComboBox1.Items.Insert (indice, texto)'
        If Val(TextBox5.Text) <= ComboBox1.Items.Count + 1 And Val(TextBox5.Text) >= 0 Then
            ComboBox1.Items.Item(Val(TextBox5.Text) - 1) = TextBox6.Text

        Else
            MsgBox("el indice esta fuera de rango")
        End If
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim indice As Integer
        indice = ComboBox1.FindString(TextBox10.Text)
        If indice = -1 Then
            MsgBox("No se encontro")
        Else
            ComboBox1.SelectedIndex = indice
            TextBox7.Text = ComboBox1.Text
            TextBox8.Text = ComboBox1.SelectedIndex

        End If
        TextBox10.Text = ""

    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Val(TextBox3.Text) <= ComboBox1.Items.Count + 1 And Val(TextBox3.Text) >= 0 Then
            ComboBox1.Items.RemoveAt(Val(TextBox11.Text) - 1)
        Else
            MsgBox("el indice esta fuera de rango")
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        If Val(TextBox3.Text) <= ComboBox1.Items.Count + 1 And Val(TextBox3.Text) >= 0 Then
            ComboBox1.Items.Contains(TextBox10.Text)
            ComboBox1.Items.Remove(TextBox10.Text)

        Else
            MsgBox("el indice esta fuera de rango")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub
End Class
