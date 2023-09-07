Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEjecutar.Click
        Dim aux As String
        aux = "Hola  " + TextBoxMensaje.Text 'palabra que ingresamo'
        MsgBox(aux, , "Saludos") 'MgaBox sirve para mostrar mensaje en otra ventana'
        TextBoxMensaje.Text = "" 'vacia texbox o celda'
        TextBoxMensaje.Focus()




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End

    End Sub
End Class
