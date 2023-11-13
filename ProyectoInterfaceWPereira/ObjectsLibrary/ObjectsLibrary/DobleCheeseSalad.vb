Public Class DobleCheeseSalad
    Inherits Producto

    Public Sub DobleCheeseSalad(_nombre As String, _precio As Double)
        MyBase.Producto(_nombre, _precio)
        _nombre = "Doble Cheese Salad"
        _precio = "5.95"
    End Sub
End Class
