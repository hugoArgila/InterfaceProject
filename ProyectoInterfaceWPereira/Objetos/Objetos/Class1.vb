Public Class Producto

    Protected nombre As String
    Protected precio As Double

    Public Sub NewProducto(_nombre As String, _precio As Double)
        nombre = _nombre
        precio = _precio
    End Sub

    Public Function imprimir() As String
        Dim s As String
        s = "Producto: " + nombre + " Precio: " + precio.ToString + "�"
        Return s
    End Function

End Class