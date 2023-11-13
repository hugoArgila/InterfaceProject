Public Class SmokySteakhouseChicken
    Inherits Producto

    Public Sub SmookySteakhouseChicken(_nombre As String, _precio As Double)
        MyBase.Producto(_nombre, _precio)
        _nombre = "Smooky Steakhouse Chicken"
        _precio = "8.45"
    End Sub
End Class
