Public Class Producto

    Protected nombre As String
    Protected precio As Double

    Public Sub Producto(_nombre As String, _precio As Double)
        nombre = _nombre
        precio = _precio
    End Sub

    Public Function getNombre()
        Return nombre
    End Function

    Public Function getPrecio()
        Return precio
    End Function

    Public Function print()
        Dim s As String
        s = "Nombre: " + nombre + " Precio: " + precio.ToString
        Return s
    End Function
End Class
