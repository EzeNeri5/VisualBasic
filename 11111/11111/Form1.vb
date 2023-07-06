Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TotalRegistro = 0

        ComboBox2.Items.Add("Borges")
        ComboBox2.Items.Add("Sabatto")
        ComboBox2.Items.Add("Dogliotti")
        ComboBox2.Items.Add("Zarate")
        ComboBox2.Items.Add("Luna")

        ComboBox3.Items.Add(2023)
        ComboBox3.Items.Add(2022)
        ComboBox3.Items.Add(2021)
        ComboBox3.Items.Add(2020)
        ComboBox3.Items.Add(2019)

        ComboBox4.Items.Add("Argentina")
        ComboBox4.Items.Add("Brasil")

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        'For i = 1 To TotalRegistro

        '    If Agenda(i).titulo = ComboBox1.SelectedItem Then

        '        ComboBox2.SelectedItem = Agenda(TotalRegistro).autor
        '        ComboBox3.SelectedItem = Agenda(TotalRegistro).anio
        '        ComboBox4.SelectedItem = Agenda(TotalRegistro).pais

        '    End If
        'Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TotalRegistro += 1
        If TotalRegistro > 5 Then
            MsgBox("Lista esta llena")
        Else
            ComboBox1.Items.Add(TextBox1.Text)

            Agenda(TotalRegistro).titulo = TextBox1.Text
            Agenda(TotalRegistro).autor = ComboBox2.Text
            Agenda(TotalRegistro).anio = Val(ComboBox3.Text)
            Agenda(TotalRegistro).pais = ComboBox4.Text

            TextBox1.Text = ""
        End If
    End Sub

    Private Function BaseDeDatos() As Object
        Throw New NotImplementedException
    End Function

End Class
