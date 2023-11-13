Public Class BrutalBacon
    Inherits Producto

    Public Sub NewBrutalBacon(_nombre As String, _precio As Double)
        MyBase.NewProducto(_nombre, _precio)
    End Sub

    Public Function getNombre()
        Return nombre = "Brutal Bacon"
    End Function

    Public Function getPrecio()
        Return precio = "7.95"
    End Function

End Class
