Public Class KingHuevo
    Inherits Producto

    Public Sub KingHuevo(_nombre As String, _precio As Double)
        MyBase.Producto(_nombre, _precio)
        _nombre = "King Huevo"
        _precio = "7.95"
    End Sub
End Class
