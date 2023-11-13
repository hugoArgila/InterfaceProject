Public Class LongChicken
    Inherits Producto

    Public Sub LongChicken(_nombre As String, _precio As Double)
        MyBase.Producto(_nombre, _precio)
        _nombre = "Long Chicken"
        _precio = "5.95"
    End Sub
End Class
