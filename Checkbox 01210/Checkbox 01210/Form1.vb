Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEje1.Click
        Dim aux As String

        If CheckIngles.Checked Then
            aux = CheckIngles.Text
        End If

        If CheckEspaniol.Checked Then
            aux += " " + CheckEspaniol.Text
        End If

        If CheckFrance.Checked Then
            aux += " " + CheckFrance.Text
        End If

        Idioma.Text = aux
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Idioma.Click

        'If CheckIngles.Checked Then
        '    Idioma.Text = CheckIngles.Text
        'End If
        'If CheckFrance.Checked Then
        '    Idioma.Text += CheckFrance.Text
        'End If
        'If CheckEspaniol.Checked Then
        '    Idioma.Text += CheckEspaniol.Text
        'End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckIngles_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckIngles.CheckedChanged
        If CheckIngles.Checked Then
            Idioma.Text = " " + CheckIngles.Text
        Else
            Idioma.Text = Val(Idioma.Text) - Val(CheckIngles.Text)
        End If



    End Sub

    Private Sub CheckFrance_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckFrance.CheckedChanged
        If CheckFrance.Checked Then
            Idioma.Text += " " + CheckFrance.Text
        Else
            Idioma.Text = Val(Idioma.Text) - Val(CheckFrance.Text)


    End Sub

    Private Sub CheckEspaniol_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEspaniol.CheckedChanged
        If CheckEspaniol.Checked Then
            Idioma.Text += " " + CheckEspaniol.Text
        Else
            Idioma.Text = Val(Idioma.Text) - Val(CheckEspaniol.Text)
        End If


    End Sub
End Class
