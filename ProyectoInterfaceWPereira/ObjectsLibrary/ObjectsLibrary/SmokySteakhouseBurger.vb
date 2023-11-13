Public Class SmokySteakhouseBurger
    Inherits Producto

    Public Sub SmokySteakhouseBurger(_nombre As String, _precio As Double)
        MyBase.Producto(_nombre, _precio)
        _nombre = "Smoky Steakhouse Burger"
        _precio = "8.45"
    End Sub

End Class
