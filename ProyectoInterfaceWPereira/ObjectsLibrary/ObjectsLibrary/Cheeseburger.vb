Public Class Cheeseburger
    Inherits Producto

    Public Sub CheeseBurger(_nombre As String, _precio As Double)
        MyBase.Producto(_nombre, _precio)
        _nombre = "Cheese Burger"
        _precio = "2.95"
    End Sub
End Class
