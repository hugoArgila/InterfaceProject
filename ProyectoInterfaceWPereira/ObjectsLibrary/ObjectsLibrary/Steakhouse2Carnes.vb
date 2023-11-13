Public Class Steakhouse2Carnes
    Inherits Producto

    Public Sub Steakhouse2carnes(_nombre As String, _precio As Double)
        MyBase.Producto(_nombre, _precio)
        _nombre = "Steakhouse 2 Carnes"
        _precio = "9.95"
    End Sub
End Class
