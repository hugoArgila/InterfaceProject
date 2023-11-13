Public Class BigKingXXL
    Inherits Producto

    Public Sub BigKingXXL(_nombre As String, _precio As Double)
        MyBase.Producto(_nombre, _precio)
        _nombre = "Big king XXL"
        _precio = "7.95"
    End Sub
End Class
