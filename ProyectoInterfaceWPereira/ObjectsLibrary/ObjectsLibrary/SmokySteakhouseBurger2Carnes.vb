Public Class SmokySteakhouseBurger2Carnes

    Inherits Producto

    Public Sub SmokySteakhouseBurger2Carnes(_nombre As String, _precio As Double)
        MyBase.Producto(_nombre, _precio)
        _nombre = "Smoky Steakhouse Burger 2 Carnes"
        _precio = "10.45"
    End Sub

End Class
