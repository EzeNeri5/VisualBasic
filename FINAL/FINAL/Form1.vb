Public Class Final


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxCod.TextChanged

    End Sub

    Private Sub TBCodArticulo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBCodArticulo.KeyPress
        TBDescripcion.Focus()
    End Sub

    Private Sub TBCodArticulo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBCodArticulo.TextChanged

    End Sub

    Private Sub BTNAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAgregar.Click
        TotalDB += 1

        If TotalDB > 5 Then
            MsgBox("Lista LLena")
            TotalDB -= 1
        Else
            Stock(TotalDB).CodigoArt = Val(TBCodArticulo.Text)
            Stock(TotalDB).DescripcionArt = TBDescripcion.Text
            Stock(TotalDB).CantidadArt = Val(TBCantidad.Text)
            Stock(TotalDB).PrecioArt = Val(TBPrecio.Text)
            MsgBox("Articulo agregado")
            ComboBox1.Items.Add(TBDescripcion.Text)
            TBCodArticulo.Text = ""
        End If

        limpiar(Me)

    End Sub

    Private Function BaseDatos() As Object
        Throw New NotImplementedException
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub BNTBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNTBuscar.Click
        For i = 1 To TotalDB

            If Stock(i).CodigoArt = Val(TextBoxConsulta.Text) Then
                TextBoxCod.Text = Val(Stock(i).CodigoArt)
                TextBoxDescripcion.Text = Stock(i).DescripcionArt
                TextBoxCantidad.Text = Stock(i).CantidadArt
                TextBoxValor.Text = Val(Stock(i).PrecioArt) * Val(Stock(i).CantidadArt)
                TextBoxConsulta.Text = ""
                Exit Sub
            End If

            If Stock(i).DescripcionArt = TextBoxConsulta.Text Then
                TextBoxCod.Text = Stock(i).CodigoArt
                TextBoxDescripcion.Text = Stock(i).DescripcionArt
                TextBoxCantidad.Text = Stock(i).CantidadArt
                TextBoxValor.Text = Val(Stock(i).PrecioArt) * Val(Stock(i).CantidadArt)
                TextBoxConsulta.Text = ""
                Exit Sub
            End If
        Next
        MsgBox("Articulo no encontrado")
        'limpiar(Me)
    End Sub

    Private Sub BTNEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEliminar.Click

        Dim i, j, aux As Integer

        For i = 1 To TotalDB

            If UCase(Stock(i).DescripcionArt) = UCase(ComboBox1.Text) Then
                TextBoxCod.Text = Stock(i).CodigoArt
                TextBoxDescripcion.Text = Stock(i).DescripcionArt
                TextBoxCantidad.Text = Stock(i).CantidadArt
                TextBoxValor.Text = Val(Stock(i).PrecioArt) * Val(Stock(i).CantidadArt)
                'TextBoxConsulta.Text = ""
                aux = MsgBox("Desea eliminar este aticulo" + TBCodArticulo.Text, 32 + 1, "ELIMINAR")

                If aux = 1 Then
                    TotalDB = TotalDB - 1
                    For j = i To TotalDB
                        Stock(j).CodigoArt = Stock(j + 1).CodigoArt
                        Stock(j).DescripcionArt = Stock(j + 1).DescripcionArt
                        Stock(j).CantidadArt = Stock(j + 1).CantidadArt
                        Stock(j).PrecioArt = Stock(j + 1).PrecioArt
                    Next j
                    ComboBox1.Items.RemoveAt(i - 1)
                    MsgBox("Articulo eliminado")
                    limpiar(Me)
                    ComboBox1.Text = ""
                End If
            End If
        Next
    End Sub

    Private Sub TBDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBDescripcion.KeyPress
        'TBCantidad.Focus()
    End Sub

    Private Sub TBDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBDescripcion.TextChanged

    End Sub

    Private Sub TBCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBCantidad.TextChanged
        'TBPrecio.Focus()
    End Sub

    Private Sub TBPrecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBPrecio.KeyPress

    End Sub

    Private Sub TBPrecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBPrecio.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        For i = 1 To TotalDB

            If Stock(i).DescripcionArt = ComboBox1.Text Then
                TextBoxCod.Text = Stock(i).CodigoArt
                TextBoxDescripcion.Text = Stock(i).DescripcionArt
                TextBoxCantidad.Text = Stock(i).CantidadArt
                TextBoxValor.Text = Val(Stock(i).PrecioArt) * Val(Stock(i).CantidadArt)
                TextBoxConsulta.Text = ""
                Exit Sub
            End If
        Next
    End Sub
End Class
