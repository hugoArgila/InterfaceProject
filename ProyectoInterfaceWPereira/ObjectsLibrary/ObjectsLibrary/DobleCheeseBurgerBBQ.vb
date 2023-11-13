Public Class DobleCheeseBurgerBBQ
    Inherits Producto

    Public Sub DobleCheeseBurgerBBQ(_nombre As String, _precio As Double)
        MyBase.Producto(_nombre, _precio)
        _nombre = "Doble Cheese Burger BBQ"
        _precio = "6.95"
    End Sub
End Class
