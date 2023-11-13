Public Class CBK
    Inherits Producto

    Public Sub CBK(_nombre As String, _precio As Double)
        MyBase.Producto(_nombre, _precio)
        _nombre = "CBK"
        _precio = "6.75"
    End Sub
End Class
