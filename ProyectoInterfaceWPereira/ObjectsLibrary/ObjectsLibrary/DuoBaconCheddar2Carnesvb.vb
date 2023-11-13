Public Class DuoBaconCheddar2Carnesvb
    Inherits Producto

    Public Sub DuoBaconCheddar2Carnes(_nombre As String, _precio As Double)
        MyBase.Producto(_nombre, _precio)
        _nombre = "Duo Bacon Cheddar 2 carnes"
        _precio = "10.25"
    End Sub
End Class
