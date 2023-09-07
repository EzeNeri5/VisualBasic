Public Class Form1

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Boca")
        ComboBox1.Items.Add("River")
        ComboBox1.Items.Add("Idependiente")

        Cantidadtext.Text = ComboBox1.Items.Count
        ComboBox1.Text = "Club"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        numeroText.Text = ComboBox1.SelectedIndex + 1
        clubText.Text = ComboBox1.Text

    End Sub

    Private Sub CantidadText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numeroText.TextChanged

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub ButtonAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAgregar.Click
        ComboBox1.Items.Add(TextAgregar.Text)
        MsgBox("Agregaste " + TextAgregar.Text)
        Cantidadtext.Text = ComboBox1.Items.Count
        ComboBox1.Text = TextAgregar.Text
        TextAgregar.Text = ""
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonInserteElemento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonInserteElemento.Click
        If Val(Textindice1.Text) <= ComboBox1.Items.Count + 1 And Val(Textindice1.Text) >= 0 Then
            ComboBox1.Items.Insert(Val(Textindice1.Text) - 1, Texttexto1.Text)
            Cantidadtext.Text = ComboBox1.Items.Count
            MsgBox(Texttexto1.Text + " Agregado") 'agregar elemento'
            ComboBox1.Text = Texttexto1.Text 'mostrar en celda'
            Textindice1.Text = ComboBox1.Items.Count + 1
            Textindice1.Text = ""
            Texttexto1.Text = ""
            Textindice1.Focus()
            Texttexto1.Focus()
        Else
            MsgBox("El indice esta fuera de rango")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Val(Textindice1.Text) <= ComboBox1.Items.Count + 1 And Val(Textindice1.Text) >= 0 Then
            ComboBox1.Items.Item(Val(Textindice1.Text) - 1) = Texttexto1.Text
            MsgBox(" Modificado")
            ComboBox1.Text = Texttexto1.Text
            Textindice1.Text = ""
            Texttexto1.Text = ""
            Textindice1.Focus()
            Texttexto1.Focus()

        Else
            MsgBox("El indice no exite")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuscar.Click
        Dim indice As Integer
        indice = ComboBox1.FindString(TextNombre.Text)
        If indice = -1 Then
            MsgBox("No se encontro")
        Else
            ComboBox1.SelectedIndex = indice
            numeroText.Text = ComboBox1.SelectedIndex + 1
            clubText.Text = ComboBox1.Text
        End If
        TextNombre.Text = ""
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Val(Textindice1.Text) <= ComboBox1.Items.Count + 1 And Val(Textindice1.Text) >= 0 Then
            ComboBox1.Items.RemoveAt(Val(Textindice1.Text) - 1)
            MsgBox(" Indice Eliminado")
            ComboBox1.Text = "Club"
            Textindice1.Text = ""
            Texttexto1.Text = ""
            clubText.Text = ""
            numeroText.Text = ""
            Cantidadtext.Text = Val(Cantidadtext.Text) - 1
            Textindice1.Focus()
            Texttexto1.Focus()

        Else
            MsgBox("El indice no exite")
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If ComboBox1.Items.Contains(Texttexto1.Text) Then
            ComboBox1.Items.Remove(Texttexto1.Text)
            MsgBox(" Equipo Eliminado")
            ComboBox1.Text = "Club"
            Textindice1.Text = ""
            Texttexto1.Text = ""
            clubText.Text = ""
            numeroText.Text = ""
            Cantidadtext.Text = Val(Cantidadtext.Text) - 1
            Textindice1.Focus()
            Texttexto1.Focus()
            clubText.Focus()
            numeroText.Focus()
        Else
            MsgBox("El Club no exite")
        End If
    End Sub

    Private Sub Textindice1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Textindice1.TextChanged

    End Sub

    Private Sub clubText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clubText.TextChanged

    End Sub
End Class
