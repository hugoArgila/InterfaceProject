Public Class Form1
    Private Sub TextBoxUsuario_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsuario.TextChanged
        Dim a As Integer
        Dim c As Char

        For a = 1 To TextBoxUsuario.Text.Length

            c = GetChar(TextBoxUsuario.Text, a)

            ' Validacion para comprobar que el campo usuario no puede estar vacio
            If TextBoxUsuario.Text = "" Then
                MsgBox("El campo no puede estar en blanco",, "Error")
                TextBoxUsuario.Clear()
                TextBoxUsuario.Focus()
            End If

            ' Validacion para comprobar que el campo usuario no puede tener valores numericos
            If IsNumeric(c) Then
                MsgBox("El campo no puede ser numerico",, "Error")
                TextBoxUsuario.Clear()
                TextBoxUsuario.Focus()
            End If
        Next a
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        'Comprobacion que la contraseña y el usuario sean correctos
        If ((TextBoxContraseña.Text = "hugo" And TextBoxUsuario.Text = "hugo") Or (TextBoxContraseña.Text = "pereira" And TextBoxUsuario.Text = "pereira")) Then
            ' Si la contreseña y usuario son hugo y pereira, se ira al formulario con la tpv del trabajador
            TPV_Trab.Show()
            Me.Hide()
        ElseIf (TextBoxContraseña.Text = "javier" And TextBoxUsuario.Text = "javier") Then
            ' Si la contreseña y usuario son javier, se ira al formulario con la tpv del encargado
            TPV_Admin.Show()
            Me.Hide()
        End If

        If Not ((TextBoxContraseña.Text = "hugo" And TextBoxUsuario.Text = "hugo") Or (TextBoxContraseña.Text = "pereira" And
            TextBoxUsuario.Text = "pereira") Or (TextBoxContraseña.Text = "javier" And TextBoxUsuario.Text = "javier")) And Not TextBoxContraseña.Text = "" Then
            ' Si la contraseña y/o usuario son incorrectos se mostrara un msgbox y se limpiaran los textbox
            MsgBox("Usuario y/o contraseña son Incorrectas. Intentelo de nuevo.",, "Error Inicio Sesion")
            TextBoxUsuario.Clear()
            TextBoxContraseña.Clear()
        ElseIf TextBoxContraseña.Text = "" Then
            ' Si la contraseña esta vacia se mostrara un msgbox y se limpiaran el textbox
            MsgBox("El campo no puede estar vacio ",, "Error")
            TextBoxContraseña.Clear()
            TextBoxContraseña.Focus()
        End If
    End Sub

End Class
