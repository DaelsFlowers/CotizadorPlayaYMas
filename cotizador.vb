Imports System.Drawing.Printing


Public Class cotizador
    Public res, c1a, c2a, c3a, c4a, cf, cv, cr, personas, dc As Double
    Public precioventa, ventas, redes, adiconsto, totalventasventas, preciodeventaventa, utilidadventa As Double
    Public vfc, oc, vic, lcc, upmc As Double
    Public vendedorfc, organizadorc, vendedoric, lidercc, utilidadpc, disenoce As Double
    Public vfc2, oc2, vic2, lcc2, upmc2 As Double
    Public vendedorfc2, organizadorc2, vendedoric2, lidercc2, utilidadpc2 As Double
    Dim lstLinesToPrint As New List(Of String)




    'NEW VARIABLES DOUBLE
    Dim vr As Double
    'variables porcentaje y dinero 
    'Dim vendedorfree1, organizadorfree1, liderfree1, disenadorfree1, playasfree1, vendedorfree2, organizadorfree2, liderfree2, disenadorfree2, playasfree2 As Double
    'Dim vendedorfree1v, organizadorfree1v, liderfree1v, disenadorfree1v, playasfree1v, vendedorfree2v, organizadorfree2v, liderfree2v, disenadorfree2v, playasfree2v As Double
    'Dim vendedorint1, organizadorint1, liderint1, disenadorint1, playasint1, vendedorint2, organizadorint2, liderint2, disenadorint2, playasint2 As Double
    'Dim vendedorint1v, organizadorint1v, liderint1v, disenadorint1v, playasint1v, vendedorint2v, organizadorint2v, liderint2v, disenadorint2v, playasint2v As Double
    'variables donde se guardan esos datos anteriores
    'dinero primera parte
    Dim funvenfreed, funorgfreed, funliderfreed, fundisefreed, funplayasfreed, funvenintd, funorgintd, funliderintd, fundiseintd, funplayasintd As Double
    'variables porcentaje 1
    Dim porvenfree, pororgfree, porliderfree, pordisefree, porplayasfree, porvenint, pororgint, porliderint, pordiseint, porplayasint As Double
    'dinero segunda parte
    Dim funvenfreevd, funorgfreevd, funliderfreevd, fundisefreevd, funplayasfreevd, funvenintvd, funorgintvd, funliderintvd, fundiseintvd, funplayasintvd As Double
    'no se declaran porcentajes ya que no se utilizan solo se visualizan


    Private Sub cotizador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblbanner.Parent = picbanner
        lblbanner.BackColor = Color.Transparent
        TextBox3.Text = 0
        C1.Text = 0
        C2.Text = 0
        C3.Text = 0
        C4.Text = 0
        TextBox6.Text = 0
        cr = 5
        TextBox13.Text = "%" + CStr(cr)
        vr = 5
        TextBox52.Text = "%" + CStr(vr)

        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

        'porcentajes free 1----------------------

        porvenfree = 5
        pororgfree = 29
        porliderfree = 5
        pordisefree = 1
        porplayasfree = 65
        'formato porcentaje free 1-------------------

        txtvenfre1.Text = "%" + CStr(porvenfree)
        txtorgfree1.Text = "%" + CStr(pororgfree)
        txtliderfre1.Text = "%" + CStr(porliderfree)
        disefree1.Text = "%" + CStr(pordisefree)
        txtplayasfree1.Text = "%" + CStr(porplayasfree)
        '--fin porcentajes free 1-------------------
        '-----------------------------------------------------------------------------------------------------
        'porcentajes int 1--------------------------
        porvenint = 2.5
        pororgint = 19.5
        porliderint = 2.5
        pordiseint = 1
        porplayasint = 77
        'formato porcentaje int 1-------------------

        txtvenint1.Text = "%" + CStr(porvenint)
        txtorgint1.Text = "%" + CStr(pororgint)
        txtliderint1.Text = "%" + CStr(porliderint)
        txtdiseint1.Text = "%" + CStr(pordiseint)
        txtplayasint1.Text = "%" + CStr(porplayasint)
        '--fin porcentajes int 1-------------------
        '-----------------------------------------------------------------------------------------------------
        'formato porcentaje free 2-------------------

        txtvenfree1v.Text = "%" + CStr(porvenfree)
        txtorgfree1v.Text = "%" + CStr(pororgfree)
        txtliderfree1v.Text = "%" + CStr(porliderfree)
        txtdisefree1v.Text = "%" + CStr(pordisefree)
        txtplayasfree1v.Text = "%" + CStr(porplayasfree)
        '--fin porcentajes free 2-------------------
        '-----------------------------------------------------------------------------------------------------
        'formato porcentaje int 2-------------------

        txtvenint1v.Text = "%" + CStr(porvenint)
        txtorgint1v.Text = "%" + CStr(pororgint)
        txtliderint1v.Text = "%" + CStr(porliderint)
        txtdiseint1v.Text = "%" + CStr(pordiseint)
        txtplayasint1v.Text = "%" + CStr(porplayasint)
        '--fin porcentajes int 2-------------------

        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXx


        txtfecreport.Text = DateTime.Now.ToShortDateString()


        retunrvariables()
    End Sub





    Private Sub cotizador_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.ExitThread()
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dateone.ValueChanged
        datestar.Text = dateone.Value
    End Sub

    Private Sub TextBox19_Leave(sender As Object, e As EventArgs) Handles txtvenfre1.Leave
        If txtvenfre1.Text = "" Then
            txtvenfre1.Text = 0
            retunrvariables()
        ElseIf IsNumeric(txtvenfre1.Text) Then
            vfc = CDbl(txtvenfre1.Text)
            If vfc > 100 Then
                MsgBox("El Porcentaje No Puede Ser Mayor a 100", vbCritical, "Error")
                txtvenfre1.Clear()
            Else
                retunrvariables()
                txtvenfre1.Text = "%" + CStr(vfc)
            End If
        Else
            MsgBox("El Valor No Es Un Numero", vbCritical, "Error")
            txtvenfre1.Text = 0
            retunrvariables()
        End If
    End Sub

    Private Sub TextBox19_Enter(sender As Object, e As EventArgs) Handles txtvenfre1.Enter
        txtvenfre1.Text = Replace(txtvenfre1.Text, "%", "")
    End Sub

    Private Sub TextBox18_Leave(sender As Object, e As EventArgs) Handles txtorgfree1.Leave
        If txtorgfree1.Text = "" Then
            txtorgfree1.Text = 0
            retunrvariables()
        ElseIf IsNumeric(txtorgfree1.Text) Then
            oc = CDbl(txtorgfree1.Text)
            If oc > 100 Then
                MsgBox("El Porcentaje No Puede Ser Mayor a 100", vbCritical, "Error")
                txtorgfree1.Clear()
            Else
                retunrvariables()
                txtorgfree1.Text = "%" + CStr(oc)
            End If
        Else
            MsgBox("El Valor No Es Un Numero", vbCritical, "Error")
            txtorgfree1.Text = 0
            retunrvariables()
        End If
    End Sub

    Private Sub TextBox13_Enter(sender As Object, e As EventArgs) Handles TextBox13.Enter
        TextBox13.SelectAll()
        TextBox13.Text = Replace(TextBox13.Text, "%", "")
    End Sub

    Private Sub TextBox18_Enter(sender As Object, e As EventArgs) Handles txtorgfree1.Enter
        txtorgfree1.Text = Replace(txtorgfree1.Text, "%", "")
    End Sub

    Private Sub TextBox20_TextChanged(sender As Object, e As EventArgs) Handles txtorgfree2.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtplayasfree2.TextChanged

    End Sub

    Private Sub TextBox38_TextChanged(sender As Object, e As EventArgs) Handles txtorgint2.TextChanged

    End Sub

    Private Sub TextBox25_Leave(sender As Object, e As EventArgs) Handles txtliderfre1.Leave
        If txtliderfre1.Text = "" Then
            txtliderfre1.Text = 0
            retunrvariables()
        ElseIf IsNumeric(txtliderfre1.Text) Then
            vic = CDbl(txtliderfre1.Text)
            If vic > 100 Then
                MsgBox("El Porcentaje No Puede Ser Mayor a 100", vbCritical, "Error")
                txtliderfre1.Clear()
            Else
                retunrvariables()
                txtliderfre1.Text = "%" + CStr(vic)
            End If
        Else
            MsgBox("El Valor No Es Un Numero", vbCritical, "Error")
            txtliderfre1.Text = 0
            retunrvariables()
        End If
    End Sub

    Private Sub TextBox25_Enter(sender As Object, e As EventArgs) Handles txtliderfre1.Enter
        txtliderfre1.Text = Replace(txtliderfre1.Text, "%", "")
    End Sub

    Private Sub TextBox24_Leave(sender As Object, e As EventArgs) Handles disefree1.Leave
        If disefree1.Text = "" Then
            disefree1.Text = 0
            retunrvariables()
        ElseIf IsNumeric(disefree1.Text) Then
            lcc = CDbl(disefree1.Text)
            If lcc > 100 Then
                MsgBox("El Porcentaje No Puede Ser Mayor a 100", vbCritical, "Error")
                disefree1.Clear()
            Else
                retunrvariables()
                disefree1.Text = "%" + CStr(lcc)
            End If
        Else
            MsgBox("El Valor No Es Un Numero", vbCritical, "Error")
            disefree1.Text = 0
            retunrvariables()
        End If
    End Sub

    Private Sub TextBox24_Enter(sender As Object, e As EventArgs) Handles disefree1.Enter
        disefree1.Text = Replace(disefree1.Text, "%", "")
    End Sub

    Private Sub TextBox26_Leave(sender As Object, e As EventArgs)
        If txtdiseint1.Text = "" Then
            txtdiseint1.Text = 0
            retunrvariables()
        ElseIf IsNumeric(txtdiseint1.Text) Then
            upmc = CDbl(txtdiseint1.Text)
            If upmc > 100 Then
                MsgBox("El Porcentaje No Puede Ser Mayor a 100", vbCritical, "Error")
                txtdiseint1.Clear()
            Else
                retunrvariables()
                txtdiseint1.Text = "%" + CStr(upmc)
            End If
        Else
            MsgBox("El Valor No Es Un Numero", vbCritical, "Error")
            txtdiseint1.Text = 0
            retunrvariables()
        End If
    End Sub

    Private Sub TextBox26_Enter(sender As Object, e As EventArgs)
        txtdiseint1.Text = Replace(txtdiseint1.Text, "%", "")
    End Sub

    Private Sub C3_Leave(sender As Object, e As EventArgs) Handles C3.Leave
        If C3.Text = "" Then
            C3.Text = 0
            c3a = 0
            retunrvariables()
        ElseIf IsNumeric(C3.Text) Then
            c3a = CDbl(C3.Text)

            retunrvariables()
        Else
            MsgBox("El Valor Esta Mal", vbCritical, "Error")
            C3.Text = 0
            c3a = 0
            retunrvariables()
        End If
        C3.Text = Format(CDec(C3.Text), "$0.00")
    End Sub

    Private Sub C4_Leave(sender As Object, e As EventArgs) Handles C4.Leave
        If C4.Text = "" Then
            C4.Text = 0
            c4a = 0
            retunrvariables()
        ElseIf IsNumeric(C4.Text) Then
            c4a = CDbl(C4.Text)
            retunrvariables()
        Else
            MsgBox("El Valor Esta Mal", vbCritical, "Error")
            C4.Text = 0
            c4a = 0
            retunrvariables()
        End If
        C4.Text = Format(CDec(C4.Text), "$0.00")
    End Sub


    Private Sub TextBox6_Enter(sender As Object, e As EventArgs) Handles TextBox6.Enter
        TextBox6.SelectAll()
        TextBox6.Text = Replace(TextBox6.Text, "%", "")
    End Sub




    Private Sub TextBox5_Enter(sender As Object, e As EventArgs) Handles txtplayasfree1.Enter
        txtplayasfree1.Text = Replace(txtplayasfree1.Text, "%", "")
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            retunrvariables()
            e.Handled = True
            TextBox2.Focus()

        End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            retunrvariables()
            e.Handled = True
            TextBox3.Focus()
        End If
    End Sub

    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            retunrvariables()
            e.Handled = True
            C1.Focus()
        End If
    End Sub

    Private Sub TextBox54_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox54.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            retunrvariables()
            e.Handled = True
            btnImprimirSimple.Focus()
        End If
    End Sub

    Private Sub C1_KeyDown(sender As Object, e As KeyEventArgs) Handles C1.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            retunrvariables()
            e.Handled = True
            C2.Focus()
        End If
    End Sub

    Private Sub C2_KeyDown(sender As Object, e As KeyEventArgs) Handles C2.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            retunrvariables()
            e.Handled = True
            C3.Focus()
        End If
    End Sub

    Private Sub C3_KeyDown(sender As Object, e As KeyEventArgs) Handles C3.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            retunrvariables()
            e.Handled = True
            C4.Focus()
        End If
    End Sub

    Private Sub C4_KeyDown(sender As Object, e As KeyEventArgs) Handles C4.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            retunrvariables()
            e.Handled = True
            TextBox11.Focus()
        End If
    End Sub

    Private Sub TextBox6_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox6.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            retunrvariables()
            e.Handled = True
            TextBox52.Focus()
        End If
    End Sub

    Private Sub TextBox11_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox11.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            retunrvariables()
            e.Handled = True
            TextBox6.Focus()
        End If
    End Sub

    Private Sub TextBox13_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox13.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            retunrvariables()
            e.Handled = True
            TextBox54.Focus()
        End If

    End Sub

    Private Sub dateone_KeyDown(sender As Object, e As KeyEventArgs) Handles dateone.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            e.Handled = True
            SendKeys.Send("{F4}")
            Me.SelectNextControl(dateone, True, True, True, True)
        End If
    End Sub

    Private Sub dateout_KeyDown(sender As Object, e As KeyEventArgs) Handles dateout.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            SendKeys.Send("{F4}")
            Me.SelectNextControl(dateout, True, True, True, True)
        End If
    End Sub

    Private Sub btnImprimirSimple_KeyDown(sender As Object, e As KeyEventArgs) Handles btnImprimirSimple.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            imprimir()
        End If
    End Sub

    Private Sub TextBox5_Leave(sender As Object, e As EventArgs) Handles txtplayasfree1.Leave
        If txtplayasfree1.Text = "" Then
            txtplayasfree1.Text = 0
            retunrvariables()
        ElseIf IsNumeric(txtplayasfree1.Text) Then
            dc = CDbl(txtplayasfree1.Text)
            If dc > 100 Then
                MsgBox("El Porcentaje No Puede Ser Mayor a 100", vbCritical, "Error")
                txtplayasfree1.Clear()
            Else
                retunrvariables()
                txtplayasfree1.Text = "%" + CStr(dc)
            End If
        Else
            MsgBox("El Valor No Es Un Numero", vbCritical, "Error")
            txtplayasfree1.Text = 0
            retunrvariables()
        End If
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        TextBox1.SelectAll()
    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        TextBox2.SelectAll()
    End Sub

    Private Sub TextBox3_Enter(sender As Object, e As EventArgs) Handles TextBox3.Enter
        TextBox3.SelectAll()
    End Sub

    Private Sub C1_Enter(sender As Object, e As EventArgs) Handles C1.Enter
        C1.SelectAll()
        C1.Text = Replace(C1.Text, "$", "")
    End Sub

    Private Sub C2_Enter(sender As Object, e As EventArgs) Handles C2.Enter
        C2.SelectAll()
        C2.Text = Replace(C2.Text, "$", "")
    End Sub

    Private Sub C3_Enter(sender As Object, e As EventArgs) Handles C3.Enter
        C3.SelectAll()
        C3.Text = Replace(C3.Text, "$", "")
    End Sub

    Private Sub C4_Enter(sender As Object, e As EventArgs) Handles C4.Enter
        C4.SelectAll()
        C4.Text = Replace(C4.Text, "$", "")
    End Sub

    Private Sub TextBox11_Enter(sender As Object, e As EventArgs) Handles TextBox11.Enter
        TextBox11.SelectAll()
    End Sub

    Private Sub TextBox52_Enter(sender As Object, e As EventArgs) Handles TextBox52.Enter
        TextBox52.SelectAll()
        TextBox52.Text = Replace(TextBox52.Text, "%", "")
    End Sub

    Private Sub TextBox52_Leave(sender As Object, e As EventArgs) Handles TextBox52.Leave
        If TextBox52.Text = "" Then
            TextBox52.Text = 0
            retunrvariables()
        ElseIf IsNumeric(TextBox52.Text) Then
            vr = CDbl(TextBox52.Text)
            If vr > 100 Then
                MsgBox("El Porcentaje No Puede Ser Mayor a 100", vbCritical, "Error")
                TextBox52.Clear()
            Else
                retunrvariables()
                TextBox52.Text = "%" + CStr(vr)
            End If
        Else
            MsgBox("El Valor No Es Un Numero", vbCritical, "Error")
            TextBox52.Text = 0
            retunrvariables()
        End If
    End Sub

    Private Sub TextBox52_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox52.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            retunrvariables()
            e.Handled = True
            TextBox13.Focus()
        End If
    End Sub

    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles TextBox3.Leave
        If TextBox3.Text = "" Then
            TextBox3.Text = 0
            personas = CDbl(TextBox3.Text)
            retunrvariables()
        Else
            personas = CDbl(TextBox3.Text)
            retunrvariables()
        End If

    End Sub


    Private Sub TextBox13_Leave(sender As Object, e As EventArgs) Handles TextBox13.Leave
        If TextBox13.Text = "" Then
            TextBox13.Text = 0
            retunrvariables()
        ElseIf IsNumeric(TextBox13.Text) Then
            cr = CDbl(TextBox13.Text)
            If cr > 100 Then
                MsgBox("El Porcentaje No Puede Ser Mayor a 100", vbCritical, "Error")
                TextBox13.Clear()
            Else
                retunrvariables()
                TextBox13.Text = "%" + CStr(cr)
            End If
        Else
            MsgBox("El Valor No Es Un Numero", vbCritical, "Error")
            TextBox13.Text = 0
            retunrvariables()
        End If
    End Sub

    Private Sub TextBox6_Leave(sender As Object, e As EventArgs) Handles TextBox6.Leave
        If TextBox6.Text = "" Then
            TextBox6.Text = 0
            retunrvariables()
        ElseIf IsNumeric(TextBox6.Text) Then
            cf = CDbl(TextBox6.Text)
            If cf > 100 Then
                MsgBox("El Porcentaje No Puede Ser Mayor a 100", vbCritical, "Error")
                TextBox6.Clear()
            Else
                retunrvariables()

                TextBox6.Text = "%" + CStr(cf)
            End If
        Else
            MsgBox("El Valor No Es Un Numero", vbCritical, "Error")
            TextBox6.Text = 0
            retunrvariables()
        End If
    End Sub

    Private Sub dateout_ValueChanged(sender As Object, e As EventArgs) Handles dateout.ValueChanged
        dateend.Text = dateout.Value
    End Sub

    Private Sub C1_Leave(sender As Object, e As EventArgs) Handles C1.Leave
        If C1.Text = "" Then
            C1.Text = 0
            c1a = 0
            retunrvariables()
        ElseIf IsNumeric(C1.Text) Then
            c1a = CDbl(C1.Text)
            retunrvariables()
        Else
            MsgBox("El Valor Esta Mal", vbCritical, "Error")
            C1.Text = 0
            c1a = 0
            retunrvariables()
        End If
        C1.Text = Format(CDec(C1.Text), "$0.00")
    End Sub



    Private Sub C2_Leave(sender As Object, e As EventArgs) Handles C2.Leave
        If C2.Text = "" Then
            C2.Text = 0
            c2a = 0
            retunrvariables()
        ElseIf IsNumeric(C2.Text) Then
            c2a = CDbl(C2.Text)
            retunrvariables()
        Else
            MsgBox("El Valor Esta Mal", vbCritical, "Error")
            C2.Text = 0
            c2a = 0
            retunrvariables()
        End If
        C2.Text = Format(CDec(C2.Text), "$0.00")
    End Sub
    '[X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X]
    '[X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X]  Mundo Operaciones  [X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X]
    '[X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X]
    Public Sub sumar()
        CCT.Text = c1a + c2a + c3a + c4a
        res = CDec(CCT.Text)
        CCT.Text = Format(CDec(CCT.Text), "$0.00")
    End Sub

    Public Sub cadi()
        adiconsto = (precioventa * (cr / 100)) + (precioventa * (vr / 100))
        TextBox14.Text = adiconsto
        TextBox14.Text = Format(CDec(TextBox14.Text), "$0.00")
    End Sub
    Public Sub cventas()
        precioventa = (res * (cf / 100)) + res
        TextBox8.Text = precioventa
        TextBox8.Text = Format(CDec(TextBox8.Text), "$0.00")
    End Sub

    Public Sub tvv()
        totalventasventas = precioventa + adiconsto
        TextBox17.Text = totalventasventas
        TextBox17.Text = Format(CDec(TextBox17.Text), "$0.00")
    End Sub
    Public Sub pvp()
        preciodeventaventa = totalventasventas / personas
        If totalventasventas = 0 Or personas = 0 Then
            preciodeventaventa = 0
            TextBox16.Text = preciodeventaventa
            TextBox16.Text = Format(CDec(TextBox16.Text), "$0.00")
        Else
            TextBox16.Text = preciodeventaventa
            TextBox16.Text = Format(CDec(TextBox16.Text), "$0.00")
        End If

    End Sub

    Public Sub utv()
        utilidadventa = precioventa - res
        TextBox15.Text = utilidadventa
        TextBox15.Text = Format(CDec(TextBox15.Text), "$0.00")
    End Sub

    Public Sub genecomi1()
        funvenfreed = utilidadventa * (porvenfree / 100)
        txtvenfre2.Text = funvenfreed
        txtvenfre2.Text = Format(CDec(txtvenfre2.Text), "$0.00")
    End Sub

    Public Sub genecomi2()
        funorgfreed = utilidadventa * (pororgfree / 100)
        txtorgfree2.Text = funorgfreed
        txtorgfree2.Text = Format(CDec(txtorgfree2.Text), "$0.00")
    End Sub

    Public Sub genecomi3()
        funliderfreed = utilidadventa * (porliderfree / 100)
        txtliderfre2.Text = funliderfreed
        txtliderfre2.Text = Format(CDec(txtliderfre2.Text), "$0.00")
    End Sub

    Public Sub genecomi4()
        fundisefreed = utilidadventa * (pordisefree / 100)
        disefree2.Text = fundisefreed
        disefree2.Text = Format(CDec(disefree2.Text), "$0.00")
    End Sub

    Public Sub genecomi5()
        funplayasfreed = utilidadventa * (porplayasfree / 100)
        txtplayasfree2.Text = funplayasfreed
        txtplayasfree2.Text = Format(CDec(txtplayasfree2.Text), "$0.00")
    End Sub

    Public Sub genecomi6()
        funvenintd = utilidadventa * (porvenint / 100)
        txtvenint2.Text = funvenintd
        txtvenint2.Text = Format(CDec(txtvenint2.Text), "$0.00")
    End Sub

    Public Sub genecomi7()
        funorgintd = utilidadventa * (pororgint / 100)
        txtorgint2.Text = funorgintd
        txtorgint2.Text = Format(CDec(txtorgint2.Text), "$0.00")
    End Sub

    Public Sub genecomi8()
        funliderintd = utilidadventa * (porliderint / 100)
        txtliderint2.Text = funliderintd
        txtliderint2.Text = Format(CDec(txtliderint2.Text), "$0.00")
    End Sub

    Public Sub genecomi9()
        fundiseintd = utilidadventa * (pordiseint / 100)
        txtdiseint2.Text = fundiseintd
        txtdiseint2.Text = Format(CDec(txtdiseint2.Text), "$0.00")
    End Sub
    Public Sub genecomi10()
        funplayasintd = utilidadventa * (porplayasint / 100)
        txtplayasint2.Text = funplayasintd
        txtplayasint2.Text = Format(CDec(txtplayasint2.Text), "$0.00")
    End Sub

    Public Sub genecomi11()
        funvenfreevd = funvenfreed / personas
        txtvenfree2v.Text = funvenfreevd
        txtvenfree2v.Text = Format(CDec(txtvenfree2v.Text), "$0.00")
    End Sub

    Public Sub genecomi12()
        funorgfreevd = funorgfreed / personas
        txtorgfree2v.Text = funorgfreevd
        txtorgfree2v.Text = Format(CDec(txtorgfree2v.Text), "$0.00")
    End Sub

    Public Sub genecomi13()
        funliderfreevd = funliderfreed / personas
        txtliderfree2v.Text = funliderfreevd
        txtliderfree2v.Text = Format(CDec(txtliderfree2v.Text), "$0.00")
    End Sub

    Public Sub genecomi14()
        fundisefreevd = fundisefreed / personas
        txtdisefree2v.Text = fundisefreevd
        txtdisefree2v.Text = Format(CDec(txtdisefree2v.Text), "$0.00")
    End Sub

    Public Sub genecomi15()
        funplayasfreevd = funplayasfreed / personas
        txtplayasfree2v.Text = funplayasfreevd
        txtplayasfree2v.Text = Format(CDec(txtplayasfree2v.Text), "$0.00")
    End Sub

    Public Sub genecomi16()
        funvenintvd = funvenintd / personas
        txtvenint2v.Text = funvenintvd
        txtvenint2v.Text = Format(CDec(txtvenint2v.Text), "$0.00")
    End Sub

    Public Sub genecomi17()
        funorgintvd = funorgintd / personas
        txtorgint2v.Text = funorgintvd
        txtorgint2v.Text = Format(CDec(txtorgint2v.Text), "$0.00")
    End Sub

    Public Sub genecomi18()
        funliderintvd = funliderintd / personas
        txtliderint2v.Text = funliderintvd
        txtliderint2v.Text = Format(CDec(txtliderint2v.Text), "$0.00")
    End Sub

    Public Sub genecomi19()
        fundiseintvd = fundiseintd / personas
        txtdiseint2v.Text = fundiseintvd
        txtdiseint2v.Text = Format(CDec(txtdiseint2v.Text), "$0.00")
    End Sub
    Public Sub genecomi20()
        funplayasintvd = funplayasintd / personas
        txtplayasint2v.Text = funplayasintvd
        txtplayasint2v.Text = Format(CDec(txtplayasint2v.Text), "$0.00")
    End Sub



    '[X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X]
    '[X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X]  Mundo Operaciones  [X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X]
    '[X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X][X]

    Public Sub retunrvariables()
        sumar()     'check
        cadi()      'check
        cventas()   'check
        tvv()       'check
        utv()       'check
        genecomi1()
        genecomi2()
        genecomi3()
        genecomi4()
        genecomi5()
        genecomi6()
        genecomi7()
        genecomi8()
        genecomi9()
        genecomi10()
        If personas = 0 Then
        Else
            pvp()
            genecomi11()
            genecomi12()
            genecomi13()
            genecomi14()
            genecomi15()
            genecomi16()
            genecomi17()
            genecomi18()
            genecomi19()
            genecomi20()
        End If

    End Sub

    Public Sub imprimir()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or C1.Text = "" Or C2.Text = "" Or C3.Text = "" Or C4.Text = "" Or TextBox6.Text = "" Or TextBox13.Text = "" Or TextBox11.Text = "" Then
            MsgBox("Favor De Rellenar Todos Los Campos", vbInformation, "Faltan Campos")
        Else
            retunrvariables()
            ' ejemplo simple para imprimir en .NET
            ' Usamos una clase del tipo PrintDocument
            Dim printDoc As New PrintDocument

            ' asignamos el método de evento para cada página a imprimir
            AddHandler printDoc.PrintPage, AddressOf print_PrintPage
            ' indicamos que queremos imprimir

            Try
                printDoc.Print()
            Catch ex As Exception
                MsgBox("Favor De Cerrar El Documento Antes De Actualizarlo", vbCritical, "DOCUMENTO ABIERTO")
            End Try
        End If
    End Sub


    Private Sub btnImprimirSimple_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImprimirSimple.Click

        retunrvariables()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or C1.Text = "" Or C2.Text = "" Or C3.Text = "" Or C4.Text = "" Or TextBox6.Text = "" Or TextBox13.Text = "" Or TextBox54.Text = "" Then
            MsgBox("Favor De Rellenar Todos Los Campos", vbInformation, "Faltan Campos")
        Else
            If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ' ejemplo simple para imprimir en .NET
                ' Usamos una clase del tipo PrintDocument



                Dim printDoc As New PrintDocument
                ' asignamos el método de evento para cada página a imprimir
                AddHandler printDoc.PrintPage, AddressOf print_PrintPage

                ' indicamos que queremos imprimir

                Try
                    PrintDialog1.PrinterSettings = printDoc.PrinterSettings
                    PrintDialog1.PrinterSettings.PrinterName = "Microsoft Print to PDF"

                    PrintPreviewDialog1.Document = printDoc
                    'PrintPreviewDialog1.ShowDialog()
                    printDoc.Print()

                Catch ex As Exception

                End Try
            End If

        End If

    End Sub




    Private Sub print_PrintPage(ByVal sender As Object,
                            ByVal e As PrintPageEventArgs)
        ' Este evento se producirá cada vez que se imprima una nueva página


        ' La fuente a usar arial a tamano 9
        Dim prFont As New Font("Arial", 9)
        Dim prFontP As New Font("Arial", 11, FontStyle.Bold)
        Dim prFontT As New Font("Arial", 20, FontStyle.Bold)
        ' la posición superior y left
        Dim xPos As Integer = 5
        Dim yPos As Integer = 0



        Dim txttb As String = "CORRIDA DE VIAJE"
        Dim txtaa As String = "DATOS DEL VIAJE"
        Dim txtab As String = "COSTOS"
        Dim txtac As String = "VENTA"
        Dim txtad As String = "COMISIONES TOTAL EVENTO"
        Dim txtae As String = "COMISIONES POR PERSONA VENDIDO"
        Dim txt1 As String = "Origen:"
        Dim txt1a As String = TextBox1.Text
        Dim txt2 As String = "Destino:"
        Dim txt1b As String = TextBox2.Text
        Dim txt3 As String = "Cantidad De Personas:"
        Dim txt1c As String = TextBox3.Text
        Dim txt4 As String = "Fecha Inicio:"
        Dim txt1d As String = datestar.Text
        Dim txt5 As String = "Fecha Fin:"
        Dim txt1e As String = dateend.Text

        Dim txt6 As String = "Traslado:"
        Dim txt2a As String = C1.Text
        Dim txt7 As String = "Hospedaje:"
        Dim txt2b As String = C2.Text
        Dim txt8 As String = "Guia:"
        Dim txt2c As String = C3.Text
        Dim txt9 As String = "Otro:"
        Dim txt2d As String = C4.Text
        Dim txt10 As String = "Concepto De Otro:"
        Dim txt2e As String = TextBox11.Text

        Dim txt11 As String = "Total Costos: "
        Dim txt3a As String = CCT.Text
        Dim txt12 As String = "Factor: "
        Dim txt3b As String = TextBox6.Text
        Dim txt13 As String = "Precio Venta: "
        Dim txt3c As String = TextBox8.Text
        Dim txt14a As String = "Adicional"
        Dim txt14b As String = "Ventas:"
        Dim txt3da As String = TextBox52.Text
        Dim txt14 As String = "Redes: "
        Dim txt3d As String = TextBox13.Text
        Dim txt15 As String = TextBox14.Text

        Dim txt16 As String = "Total Venta: "
        Dim txt4a As String = TextBox17.Text
        Dim txt17 As String = "Precio De Venta Para Personas: "
        Dim txt4b As String = TextBox16.Text
        Dim txt18 As String = "Utilidad Total: "
        Dim txt4c As String = TextBox15.Text

        Dim txt19 As String = "Freelance"
        Dim txt21 As String = "Interno"
        Dim txt20 As String = "Vendedor Freelance:"
        Dim txt22 As String = "Organizador:"
        Dim txt23 As String = "Lider De Quien Organiza:"
        Dim txt24 As String = "Diseñador(A)"
        Dim txt25 As String = "Playas Y Mas Nacional:"
        Dim txt26 As String = "Vendedor Interno:"

        Dim txt5a As String = txtvenfre2.Text
        Dim txt5b As String = txtorgfree2.Text
        Dim txt5c As String = txtliderfre2.Text
        Dim txt5d As String = disefree2.Text
        Dim txt5e As String = txtplayasfree2.Text

        Dim txt6a As String = txtvenint2.Text
        Dim txt6b As String = txtorgint2.Text
        Dim txt6c As String = txtliderint2.Text
        Dim txt6d As String = txtdiseint2.Text
        Dim txt6e As String = txtplayasint2.Text

        Dim txt5aa As String = txtvenfree2v.Text
        Dim txt5ba As String = txtorgfree2v.Text
        Dim txt5ca As String = txtliderfree2v.Text
        Dim txt5da As String = txtdisefree2v.Text
        Dim txt5ea As String = txtplayasfree2v.Text

        Dim txt6aa As String = txtvenint2v.Text
        Dim txt6ba As String = txtorgint2v.Text
        Dim txt6ca As String = txtliderint2v.Text
        Dim txt6da As String = txtdiseint2v.Text
        Dim txt6ea As String = txtplayasint2v.Text




        Dim txt45 As String = "AUTORIZADO"
        Dim txt46 As String = "DIRECCIÓN PLAYAS Y MAS"
        Dim txt47 As String = "AUTORIZADO"
        Dim txt48 As String = "DIRECCIÓN GENERAL GRUPO ALCANCE"


        '/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\
        '\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/


        Dim text2 As String = "FECHA ELABORACIÓN: " + txtfecreport.Text
        Dim text1 As String = "ELABORADO POR:         " + TextBox54.Text
        Dim text3 As String = ""
        Dim text4 As String = ""
        Dim text5 As String = ""
        Dim text6 As String = ""
        Dim text7 As String = ""
        Dim text8 As String = ""
        Dim text9 As String = ""
        Dim text10 As String = ""
        Dim text11 As String = ""
        Dim text12 As String = ""







        ' imprimimos la cadena


        '-------------------banner--------------------------------------------------------------
        e.Graphics.DrawImage(PictureBox1.Image, xPos + 25, yPos + 10, 170, 100)
        e.Graphics.DrawString(txttb, prFontT, Brushes.Black, xPos + 550, yPos + 50)
        'le agregamos 4 lineas de separacion del tope   
        yPos = yPos + 120
        '----------------------------------------------------------------------------------------

        '-------------------datos usuario--------------------------------------------------------
        e.Graphics.DrawString(text2, prFontP, Brushes.Black, xPos + 20, yPos + 10)
        e.Graphics.DrawString(text1, prFontP, Brushes.Black, xPos + 20, yPos + 30)
        yPos = yPos + 80
        '----------------------------------------------------------------------------------------


        '-------------------datos banner 1--------------------------------------------------------
        e.Graphics.DrawImage(picback1.Image, 10, yPos, 825, 30)
        e.Graphics.DrawString(txtaa, prFontP, Brushes.Black, xPos + 20, yPos + 6)
        yPos = yPos + 40
        '----------------------------------------------------------------------------------------

        '-------------------datos viaje-----------------------------------------------------------
        xPos = 25
        xPos = 25
        e.Graphics.DrawString(txt1, prFont, Brushes.Black, xPos, yPos)
        xPos = 250
        e.Graphics.DrawString(txt1a, prFont, Brushes.Black, xPos, yPos)
        xPos = 25
        yPos = yPos + 15
        e.Graphics.DrawString(txt2, prFont, Brushes.Black, xPos, yPos)
        xPos = 250
        e.Graphics.DrawString(txt1b, prFont, Brushes.Black, xPos, yPos)
        xPos = 25
        yPos = yPos + 15
        e.Graphics.DrawString(txt3, prFont, Brushes.Black, xPos, yPos)
        xPos = 250
        e.Graphics.DrawString(txt1c, prFont, Brushes.Black, xPos, yPos)
        xPos = 25
        yPos = yPos + 15
        e.Graphics.DrawString(txt4, prFont, Brushes.Black, xPos, yPos)
        xPos = 250
        e.Graphics.DrawString(txt1d, prFont, Brushes.Black, xPos, yPos)
        xPos = 25
        yPos = yPos + 15
        e.Graphics.DrawString(txt5, prFont, Brushes.Black, xPos, yPos)
        xPos = 250
        e.Graphics.DrawString(txt1e, prFont, Brushes.Black, xPos, yPos)
        xPos = 25
        '-------------------------------------------------------------------------------------------




        '-------------------costos banner--------------------------------------------------------------
        yPos = yPos + 30
        xPos = 5
        e.Graphics.DrawImage(picback1.Image, 10, yPos, 830, 30)
        e.Graphics.DrawString(txtab, prFontP, Brushes.Black, xPos + 20, yPos + 6)
        '-------------------------------------------------------------------------------------------




        '-------------------costos texto parrafo 1--------------------------------------------------------------
        yPos = yPos + 40
        xPos = 250
        e.Graphics.DrawString(txt6, prFont, Brushes.Black, 25, yPos)

        e.Graphics.DrawString(txt2a, prFont, Brushes.Black, xPos, yPos)

        yPos = yPos + 15
        e.Graphics.DrawString(txt7, prFont, Brushes.Black, 25, yPos)


        e.Graphics.DrawString(txt2b, prFont, Brushes.Black, xPos, yPos)

        yPos = yPos + 15
        e.Graphics.DrawString(txt8, prFont, Brushes.Black, 25, yPos)

        e.Graphics.DrawString(txt2c, prFont, Brushes.Black, xPos, yPos)

        yPos = yPos + 15
        e.Graphics.DrawString(txt9, prFont, Brushes.Black, 25, yPos)

        e.Graphics.DrawString(txt2d, prFont, Brushes.Black, xPos, yPos)

        yPos = yPos + 15
        e.Graphics.DrawString(txt10, prFont, Brushes.Black, 25, yPos)
        e.Graphics.DrawString(txt2e, prFont, Brushes.Black, xPos, yPos)
        '-------------------------------------------------------------------------------------------




        '-------------------costos texto parrafo 2--------------------------------------------------------------
        xPos = 650
        yPos = yPos - 60
        e.Graphics.DrawString(txt11, prFont, Brushes.Black, 400, yPos)
        e.Graphics.DrawString(txt3a, prFont, Brushes.Black, xPos, yPos)
        yPos = yPos + 15
        e.Graphics.DrawString(txt12, prFont, Brushes.Black, 400, yPos)
        e.Graphics.DrawString(txt3b, prFont, Brushes.Black, xPos, yPos)
        yPos = yPos + 15
        e.Graphics.DrawString(txt13, prFont, Brushes.Black, 400, yPos)
        e.Graphics.DrawString(txt3c, prFont, Brushes.Black, xPos, yPos)
        yPos = yPos + 30
        e.Graphics.DrawString(txt14a, prFont, Brushes.Black, 400, yPos)
        yPos = yPos + 15
        'done   
        e.Graphics.DrawString(txt14b, prFont, Brushes.Black, 400, yPos)
        e.Graphics.DrawString(txt3da, prFont, Brushes.Black, 470, yPos)

        e.Graphics.DrawString(txt14, prFont, Brushes.Black, 520, yPos)
        e.Graphics.DrawString(txt3d, prFont, Brushes.Black, 590, yPos)
        e.Graphics.DrawString(txt15, prFont, Brushes.Black, 650, yPos)
        '-------------------------------------------------------------------------------------------



        '-------------------venta banner--------------------------------------------------------------
        yPos = yPos + 30
        xPos = 5
        e.Graphics.DrawImage(picback1.Image, 10, yPos, 830, 30)
        e.Graphics.DrawString(txtac, prFontP, Brushes.Black, xPos + 20, yPos + 6)
        '-------------------------------------------------------------------------------------------


        '-------------------venta datos--------------------------------------------------------------
        yPos = yPos + 40
        e.Graphics.DrawString(txt16, prFont, Brushes.Black, 25, yPos)
        e.Graphics.DrawString(txt4a, prFont, Brushes.Black, 250, yPos)
        yPos = yPos + 15
        e.Graphics.DrawString(txt17, prFont, Brushes.Black, 25, yPos)
        e.Graphics.DrawString(txt4b, prFont, Brushes.Black, 250, yPos)
        yPos = yPos + 15
        e.Graphics.DrawString(txt18, prFont, Brushes.Black, 25, yPos)
        e.Graphics.DrawString(txt4c, prFont, Brushes.Black, 250, yPos)
        '-------------------------------------------------------------------------------------------




        '-------------------comision total banner--------------------------------------------------------------
        yPos = yPos + 30
        xPos = 5
        e.Graphics.DrawImage(picback1.Image, 10, yPos, 830, 30)
        e.Graphics.DrawString(txtad, prFontP, Brushes.Black, xPos + 20, yPos + 6)
        '-------------------------------------------------------------------------------------------




        '-------------------comisiones datos parrafo 1--------------------------------------------------------------
        yPos = yPos + 40
        e.Graphics.DrawString(txt19, prFontP, Brushes.Black, 25, yPos)
        e.Graphics.DrawString(txt21, prFontP, Brushes.Black, 400, yPos)
        yPos = yPos + 30
        e.Graphics.DrawString(txt20, prFont, Brushes.Black, 25, yPos)
        e.Graphics.DrawString(txt26, prFont, Brushes.Black, 400, yPos)
        e.Graphics.DrawString(txt5a, prFont, Brushes.Black, 250, yPos)
        e.Graphics.DrawString(txt6a, prFont, Brushes.Black, 650, yPos)
        yPos = yPos + 15
        e.Graphics.DrawString(txt22, prFont, Brushes.Black, 25, yPos)
        e.Graphics.DrawString(txt22, prFont, Brushes.Black, 400, yPos)
        e.Graphics.DrawString(txt5b, prFont, Brushes.Black, 250, yPos)
        e.Graphics.DrawString(txt6b, prFont, Brushes.Black, 650, yPos)
        yPos = yPos + 15
        e.Graphics.DrawString(txt23, prFont, Brushes.Black, 25, yPos)
        e.Graphics.DrawString(txt23, prFont, Brushes.Black, 400, yPos)
        e.Graphics.DrawString(txt5c, prFont, Brushes.Black, 250, yPos)
        e.Graphics.DrawString(txt6c, prFont, Brushes.Black, 650, yPos)
        yPos = yPos + 15
        e.Graphics.DrawString(txt24, prFont, Brushes.Black, 25, yPos)
        e.Graphics.DrawString(txt24, prFont, Brushes.Black, 400, yPos)
        e.Graphics.DrawString(txt5d, prFont, Brushes.Black, 250, yPos)
        e.Graphics.DrawString(txt6d, prFont, Brushes.Black, 650, yPos)
        yPos = yPos + 15
        e.Graphics.DrawString(txt25, prFont, Brushes.Black, 25, yPos)
        e.Graphics.DrawString(txt25, prFont, Brushes.Black, 400, yPos)
        e.Graphics.DrawString(txt5e, prFont, Brushes.Black, 250, yPos)
        e.Graphics.DrawString(txt6e, prFont, Brushes.Black, 650, yPos)
        '-------------------------------------------------------------------------------------------






        '-------------------vendido total banner--------------------------------------------------------------
        yPos = yPos + 30
        xPos = 5
        e.Graphics.DrawImage(picback1.Image, 10, yPos, 830, 30)
        e.Graphics.DrawString(txtae, prFontP, Brushes.Black, xPos + 20, yPos + 6)
        '-------------------------------------------------------------------------------------------




        '-------------------comisiones datos parrafo 1--------------------------------------------------------------
        yPos = yPos + 40
        e.Graphics.DrawString(txt19, prFontP, Brushes.Black, 25, yPos)
        e.Graphics.DrawString(txt21, prFontP, Brushes.Black, 400, yPos)
        yPos = yPos + 30
        e.Graphics.DrawString(txt20, prFont, Brushes.Black, 25, yPos)
        e.Graphics.DrawString(txt26, prFont, Brushes.Black, 400, yPos)
        e.Graphics.DrawString(txt5aa, prFont, Brushes.Black, 250, yPos)
        e.Graphics.DrawString(txt6aa, prFont, Brushes.Black, 650, yPos)
        yPos = yPos + 15
        e.Graphics.DrawString(txt22, prFont, Brushes.Black, 25, yPos)
        e.Graphics.DrawString(txt22, prFont, Brushes.Black, 400, yPos)
        e.Graphics.DrawString(txt5ba, prFont, Brushes.Black, 250, yPos)
        e.Graphics.DrawString(txt6ba, prFont, Brushes.Black, 650, yPos)
        yPos = yPos + 15
        e.Graphics.DrawString(txt23, prFont, Brushes.Black, 25, yPos)
        e.Graphics.DrawString(txt23, prFont, Brushes.Black, 400, yPos)
        e.Graphics.DrawString(txt5ca, prFont, Brushes.Black, 250, yPos)
        e.Graphics.DrawString(txt6ca, prFont, Brushes.Black, 650, yPos)
        yPos = yPos + 15
        e.Graphics.DrawString(txt24, prFont, Brushes.Black, 25, yPos)
        e.Graphics.DrawString(txt24, prFont, Brushes.Black, 400, yPos)
        e.Graphics.DrawString(txt5da, prFont, Brushes.Black, 250, yPos)
        e.Graphics.DrawString(txt6da, prFont, Brushes.Black, 650, yPos)
        yPos = yPos + 15
        e.Graphics.DrawString(txt25, prFont, Brushes.Black, 25, yPos)
        e.Graphics.DrawString(txt25, prFont, Brushes.Black, 400, yPos)
        e.Graphics.DrawString(txt5ea, prFont, Brushes.Black, 250, yPos)
        e.Graphics.DrawString(txt6ea, prFont, Brushes.Black, 650, yPos)
        '-------------------------------------------------------------------------------------------





        '-------------------texto extra--------------------------------------------------------------
        yPos = yPos + 180
        e.Graphics.DrawImage(PictureBox2.Image, 25, yPos - 10, 250, 2)
        e.Graphics.DrawString(txt45, prFont, Brushes.Black, 100, yPos)
        e.Graphics.DrawImage(PictureBox2.Image, 450, yPos - 10, 250, 2)
        e.Graphics.DrawString(txt47, prFont, Brushes.Black, 533, yPos)
        yPos = yPos + 15

        e.Graphics.DrawString(txt46, prFont, Brushes.Black, 60, yPos)
        e.Graphics.DrawString(txt48, prFont, Brushes.Black, 450, yPos)


        '-------------------------------------------------------------------------------------------
        ' indicamos que ya no hay nada más que imprimir
        ' (el valor predeterminado de esta propiedad es False)

        e.HasMorePages = False



    End Sub

End Class

