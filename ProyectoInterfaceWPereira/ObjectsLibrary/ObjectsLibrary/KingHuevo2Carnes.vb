Public Class KingHuevo2Carnes
    Inherits Producto

    Public Sub KingHuevo2Carnes(_nombre As String, _precio As Double)
        MyBase.Producto(_nombre, _precio)
        _nombre = "King Huevo 2 Carnes"
        _precio = "9.45"
    End Sub
End Class
