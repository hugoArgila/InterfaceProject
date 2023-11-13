Public Class DuoBaconCheddar
    Inherits Producto

    Public Sub DuoBaconCheddar(_nombre As String, _precio As Double)
        MyBase.Producto(_nombre, _precio)
        _nombre = "Duo Bacon Cheddar"
        _precio = "8.25"
    End Sub
End Class
