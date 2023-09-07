Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        totalRegistro = 0

        ComboLocal.Items.Add(1)
        ComboLocal.Items.Add(2)
        ComboLocal.Items.Add(3)
        ComboLocal.Items.Add(4)
        ComboLocal.Items.Add(5)

        ComboSucursal.Items.Add("San Justo")
        ComboSucursal.Items.Add("Ramos Mejia")
        ComboSucursal.Items.Add("CABA")
        ComboSucursal.Items.Add("Ciudadela")
        ComboSucursal.Items.Add("Exterior")

        ComboPais.Items.Add("Argentina")
        ComboPais.Items.Add("Chile")
        ComboPais.Items.Add("Uruguay")
        ComboPais.Items.Add("Brasil")

    End Sub

    Private Sub BTNSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSALIR.Click
        End
    End Sub

    Private Sub BTNAniadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAniadir.Click
        'pongo un numero menos asi no tira error cuando se llena la lista
        If totalRegistro > 4 Then
            MsgBox("Lista LLENA")
            limpiar(Me)
            TBProveedor.Focus()
            Exit Sub
        Else
            'Si NO INGRESA NOMBRE SALE CARTEL DE ALERTA
            If TBProveedor.Text <> "" Then
                totalRegistro += 1
                listaProv(totalRegistro).proveedor = TBProveedor.Text
                listaProv(totalRegistro).Local = ComboLocal.Text
                listaProv(totalRegistro).Sucursal = ComboSucursal.Text
                listaProv(totalRegistro).Pais = ComboPais.Text
                MsgBox("Proveedor AGREGADO")
                ComboBoxPorveedores.Items.Add(TBProveedor.Text)
                limpiar(Me)
                TBProveedor.Focus()
            Else
                MsgBox("Ingrese nombre del PROVEEDOR")
                TBProveedor.Focus()
            End If

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'boton de consulta
        For i = 1 To totalRegistro
            If listaProv(i).proveedor = ComboBoxPorveedores.Text Then
                TextBoxLocal.Text = listaProv(i).Local
                TextBoxSucursal.Text = listaProv(i).Sucursal
                TextBoxPais.Text = listaProv(i).Pais
                Exit Sub
            End If
        Next
        MsgBox("Proveedor NO ENCONTRADO")
    End Sub

    Private Sub BTNEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEliminar.Click
        Dim aux As Integer

        For i = 1 To totalRegistro

            If UCase(listaProv(i).proveedor) = UCase(ComboBoxPorveedores.Text) Then
                TextBoxLocal.Text = listaProv(i).Local
                TextBoxSucursal.Text = listaProv(i).Sucursal
                TextBoxPais.Text = listaProv(i).Pais
                aux = MsgBox("Desea ELIMINAR este Proveedor " + ComboBoxPorveedores.Text, 32 + 1, "ELIMINAR")

                If aux = 1 Then
                    totalRegistro -= 1
                    For j = 1 To totalRegistro
                        listaProv(j).proveedor = listaProv(j + 1).proveedor
                        listaProv(j).Local = listaProv(j + 1).Local
                        listaProv(j).Sucursal = listaProv(j + 1).Sucursal
                        listaProv(j).Pais = listaProv(j + 1).Pais
                    Next j
                    ComboBoxPorveedores.Items.RemoveAt(i - 1)
                    MsgBox("Proveedor ELIMINADO")
                    limpiar(Me)
                    ComboBoxPorveedores.Text = ""
                End If

            End If

        Next
        MsgBox("Proveedor NO ENCONTRADO")
    End Sub

    Private Sub ComboBoxPorveedores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxPorveedores.SelectedIndexChanged
        'COMENTE PORQ SINO ME LO MUESTRA DIRECTAMENTE
        'For i = 1 To totalRegistro
        '    If listaProv(i).proveedor = ComboBoxPorveedores.Text Then
        '        TextBoxLocal.Text = listaProv(i).Local
        '        TextBoxSucursal.Text = listaProv(i).Sucursal
        '        TextBoxPais.Text = listaProv(i).Pais
        '        Exit Sub
        '    End If
        'Next
        'MsgBox("Proveedor NO ENCONTRADO")
    End Sub
End Class
