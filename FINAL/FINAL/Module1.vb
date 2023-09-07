Module Module1

    Public Structure BaseDatos

        Public CodigoArt As Integer
        Public DescripcionArt As String
        Public CantidadArt As Integer
        Public PrecioArt As Integer

    End Structure

    Public Stock(5) As BaseDatos
    Public TotalDB As Integer

    Public Sub limpiar(ByVal formaux As Form)
        Dim aux As Control

        For Each aux In formaux.Controls

            If TypeOf aux Is TextBox Then
                aux.Text = ""
            End If

        Next
    End Sub
End Module