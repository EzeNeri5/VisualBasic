Public Class Form1

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Items.Clear()
        Select Case ComboBox1.SelectedIndex
            Case "0"
                ComboBox2.Items.Add("HP")
                ComboBox2.Items.Add("EPSON")
                ComboBox2.Items.Add("SATO")
            Case "1"
                ComboBox2.Items.Add("KINGSTON")
                ComboBox2.Items.Add("SAMSUNG")
                ComboBox2.Items.Add("SANDISK")
            Case "2"
                ComboBox2.Items.Add("LG")
                ComboBox2.Items.Add("DELL")
                ComboBox2.Items.Add("SAMSUNG")
        End Select

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

        Select ComboBox2.Text
            Case "HP"
                TextBox1.Text = 10000
            Case "EPSON"
                TextBox1.Text = 15000
            Case "SATO"
                TextBox1.Text = 20000
            Case "LG"
                TextBox1.Text = 1000
            Case "DELL"
                TextBox1.Text = 1500
            Case "SAMSUNG"
                TextBox1.Text = 2000
            Case "KINGSTON"
                TextBox1.Text = 100
            Case "SAMSUNG"
                TextBox1.Text = 150
            Case "SANDISK"
                TextBox1.Text = 200
        End Select


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Impresora")
        ComboBox1.Items.Add("Memoria")
        ComboBox1.Items.Add("Monitor")




        
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ComboBox1.Items.Add(TextBox1.Text)
        MsgBox("Producto Agregado")

    End Sub
End Class
