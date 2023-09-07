Public Class Form1

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Label9.Text = Val(Label9.Text) + 1000
            Label11.Text = Val(Label7.Text) + Val(Label9.Text)
        Else
            Label9.Text = Val(Label9.Text) - 1000
            Label11.Text = Val(Label7.Text) + Val(Label9.Text)
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Label9.Text = Val(Label9.Text) + 2000
            Label11.Text = Val(Label7.Text) + Val(Label9.Text)
        Else
            Label9.Text = Val(Label9.Text) - 2000
            Label11.Text = Val(Label7.Text) + Val(Label9.Text)
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            Label9.Text = Val(Label9.Text) + 3000
            Label11.Text = Val(Label7.Text) + Val(Label9.Text)
        Else
            Label9.Text = Val(Label9.Text) - 3000
            Label11.Text = Val(Label7.Text) + Val(Label9.Text)
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            Label9.Text = Val(Label9.Text) + 4000
            Label11.Text = Val(Label7.Text) + Val(Label9.Text)
        Else
            Label9.Text = Val(Label9.Text) - 4000
            Label11.Text = Val(Label7.Text) + Val(Label9.Text)
        End If
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Label7.Text = 3000
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
End Class
