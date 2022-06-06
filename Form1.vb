Public Class Form1
    Public a As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblusu.Parent = piccont
        lblusu.BackColor = Color.Transparent
        lblpass.Parent = piccont
        lblpass.BackColor = Color.Transparent
        a = False

    End Sub

    Private Sub btnentrar_Click(sender As Object, e As EventArgs) Handles btnentrar.Click
        If txtusu.Text = "" Or txtpass.Text = "" Then
            MsgBox("Favor De Logearte", vbInformation, "Login")
        Else
            If txtusu.Text = "user01" And txtpass.Text = "user01" Then
                Me.Hide()
                cotizador.Show()
            Else
                MsgBox("El Nombre O Contraseña Estan Mal", vbCritical, "Login")
            End If
        End If
    End Sub

    Private Sub txtusu_KeyDown(sender As Object, e As KeyEventArgs) Handles txtusu.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            txtpass.Focus()
        End If
    End Sub

    Private Sub txtpass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpass.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            btnentrar.Focus()
        End If
    End Sub

    Private Sub txtusu_Enter(sender As Object, e As EventArgs) Handles txtusu.Enter
        txtusu.SelectAll()
    End Sub

    Private Sub txtpass_Enter(sender As Object, e As EventArgs) Handles txtpass.Enter
        txtpass.SelectAll()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = Not a
        If a = True Then
            txtpass.PasswordChar = ""
        Else
            txtpass.PasswordChar = "*"
        End If
    End Sub
End Class
