Public Class Form1

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged


    End Sub

    Private Sub ButtonLunes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLunes.Click
        Dim dia As String 'declaro variable'
        dia = ButtonLunes.Text

        TextBox1.Text = dia 'ingreso el valor dia a la celda'

    End Sub

    Private Sub ButtonMartes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMartes.Click

        TextBox1.Text = "Martes" 'ingreso el valor dia a la celda'

    End Sub

    Private Sub ButtonMiercoles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMiercoles.Click
        Dim dia As String
        dia = ButtonMiercoles.Text

        TextBox1.Text = dia

    End Sub

    Private Sub ButtonJueves_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonJueves.Click
        Dim dia As String
        dia = ButtonJueves.Text

        TextBox1.Text = dia

    End Sub

    Private Sub ButtonViernes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonViernes.Click
        Dim dia As String
        dia = ButtonViernes.Text

        TextBox1.Text = dia

    End Sub

    Private Sub ButtonSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSalir.Click
        End
    End Sub
End Class
