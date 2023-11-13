Public Class BigKing
    Inherits Producto

    Public Sub BigKing(_nombre As String, _precio As Double)
        MyBase.Producto(_nombre, _precio)
        _nombre = "Big King"
        _precio = "5.95"
    End Sub
End Class
