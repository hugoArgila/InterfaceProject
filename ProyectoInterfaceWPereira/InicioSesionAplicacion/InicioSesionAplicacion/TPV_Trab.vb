Public Class TPV_Trab

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Ver panel novedades
    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        PnlCarta.Visible = False
        PnlNov.Visible = True
    End Sub

    'Salir panel novedades
    Private Sub BtnSalirPnlNov_Click(sender As Object, e As EventArgs) Handles BtnSalirPnlNov.Click
        PnlNov.Visible = False
        PnlCarta.Visible = True
    End Sub


    'Ver panel menu parrilla
    Private Sub BtnMenParr_Click(sender As Object, e As EventArgs) Handles BtnMenParr.Click
        PnlCarta.Visible = False
        PnlMenParr.Visible = True
    End Sub

    'Salir panel menu parrilla
    Private Sub BtnSalirPnlMenParr_Click(sender As Object, e As EventArgs) Handles BtnSalirPnlMenParr.Click
        PnlMenParr.Visible = False
        PnlCarta.Visible = True
    End Sub

    'Ver panel menu Pollo
    Private Sub BtnMenPo_Click(sender As Object, e As EventArgs) Handles BtnMenPo.Click
        PnlMenPoll.Visible = True
        PnlCarta.Visible = False
    End Sub

    'Salir menu Pollo
    Private Sub BtnSalirPnlMenPoll_Click(sender As Object, e As EventArgs) Handles BtnSalirPnlMenPoll.Click
        PnlMenPoll.Visible = False
        PnlCarta.Visible = True
    End Sub

    'Ver panel Kings JR
    Private Sub BtnKingjr_Click(sender As Object, e As EventArgs) Handles BtnKingjr.Click
        PnlKinJR.Visible = True
        PnlCarta.Visible = False
    End Sub

    'Salir panel King JR
    Private Sub BtnSalPnlKinJR_Click(sender As Object, e As EventArgs) Handles BtnSalPnlKinJR.Click
        PnlKinJR.Visible = False
        PnlCarta.Visible = True
    End Sub

End Class