Module Module1

    Public Structure BaseFerreteria

        Public articulo As Integer
        Public descripcion As String
        Public cantidad As Integer
        Public precio As Integer

    End Structure

    Public stock(3) As BaseFerreteria
    Public TotaldeRegistro As Integer

    Public Sub limpiar(ByVal formaux As Form)
        Dim aux As Control

        For Each aux In formaux.Controls

            If TypeOf aux Is TextBox Then
                aux.Text = ""
            End If

        Next
    End Sub
End Module
