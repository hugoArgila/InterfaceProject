Public Class LongVegetal
    Inherits Producto

    Public Sub Longvegetal(_nombre As String, _precio As Double)
        MyBase.Producto(_nombre, _precio)
        _nombre = "Long Vegetal"
        _precio = "5.95"
    End Sub
End Class
