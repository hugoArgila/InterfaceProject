Public Class BigKingVegetal
    Inherits Producto

    Public Sub BigKingVegetal(_nombre As String, _precio As Double)
        MyBase.Producto(_nombre, _precio)
        _nombre = "Big King Vegetal"
        _precio = "5.95"
    End Sub
End Class
