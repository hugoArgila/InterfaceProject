Public Class DuoBaconCheddarPollo
    Inherits Producto

    Public Sub DuoBaconCheddarPollo(_nombre As String, _precio As Double)
        MyBase.Producto(_nombre, _precio)
        _nombre = "Duo Bacon Cheddar Pollo"
        _precio = "8.25"
    End Sub
End Class
