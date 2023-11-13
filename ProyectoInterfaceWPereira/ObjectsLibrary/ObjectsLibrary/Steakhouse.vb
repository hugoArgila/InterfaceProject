Public Class Steakhouse
    Inherits Producto

    Public Sub Steakhouse(_nombre As String, _precio As Double)
        MyBase.Producto(_nombre, _precio)
        _nombre = "Steakhouse"
        _precio = "7.95"
    End Sub
End Class
