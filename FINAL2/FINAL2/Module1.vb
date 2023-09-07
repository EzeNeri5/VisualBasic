Module Module1

    Public Structure BaseDatos

        Public proveedor As String
        Public Local As Integer
        Public Sucursal As String
        Public Pais As String

    End Structure

    Public listaProv(5) As BaseDatos
    Public totalRegistro As Integer

    Public Sub limpiar(ByVal formaux As Form)
        Dim aux As Control

        For Each aux In formaux.Controls

            If TypeOf aux Is TextBox Then
                aux.Text = ""
            End If

            If TypeOf aux Is ComboBox Then
                aux.Text = ""
            End If
        Next
    End Sub

End Module
