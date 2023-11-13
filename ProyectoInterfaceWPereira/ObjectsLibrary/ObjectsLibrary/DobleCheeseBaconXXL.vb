Public Class DobleCheeseBaconXXL
    Inherits Producto

    Public Sub DobleCheeseBaconXXL(_nombre As String, _precio As Double)
        MyBase.Producto(_nombre, _precio)
        _nombre = "Doble Cheese Bacon XXL"
        _precio = "7.95"
    End Sub
End Class
