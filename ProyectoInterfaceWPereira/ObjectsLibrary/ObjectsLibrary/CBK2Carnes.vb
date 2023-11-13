Public Class CBK2Carnes
    Inherits Producto

    Public Sub CBK2Carnes(_nombre As String, _precio As Double)
        MyBase.Producto(_nombre, _precio)
        _nombre = "CBK 2 Carnes"
        _precio = "7.75"
    End Sub
End Class
