Public Class DobleCheeseBacon
    Inherits Producto

    Public Sub DobleCheeseBacon(_nombre As String, _precio As Double)
        MyBase.Producto(_nombre, _precio)
        _nombre = "Doble Cheese Bacon "
        _precio = "5.95"
    End Sub
End Class
