Public Class Form1
    Shared val1, val2, res, a, b As Decimal
    Shared OperacionFlag As String

    Private Sub NumKeyPad_Click(sender As Object, e As EventArgs) Handles buttonPad1.Click, buttonPad2.Click, buttonPad3.Click, buttonPad4.Click, buttonPad5.Click, buttonPad6.Click, buttonPad7.Click, buttonPad8.Click, buttonPad9.Click, buttonPad0.Click, buttonPadDot.Click, buttonParenthesisLeft.Click, buttonParenthesisRight.Click
        Dim button As Button = CType(sender, Button)
        Select Case button.Name
            Case "buttonPad0"
                tbScreen.Text += "0"
            Case "buttonPad1"
                tbScreen.Text += "1"
            Case "buttonPad2"
                tbScreen.Text += "2"
            Case "buttonPad3"
                tbScreen.Text += "3"
            Case "buttonPad4"
                tbScreen.Text += "4"
            Case "buttonPad5"
                tbScreen.Text += "5"
            Case "buttonPad6"
                tbScreen.Text += "6"
            Case "buttonPad7"
                tbScreen.Text += "7"
            Case "buttonPad8"
                tbScreen.Text += "8"
            Case "buttonPad9"
                tbScreen.Text += "9"
            Case "buttonPadDot"
                tbScreen.Text += "."
        End Select
    End Sub

    Private Sub OpKeyPad_Click(sender As Object, e As EventArgs) Handles buttonPadAdd.Click, buttonPadRemove.Click, buttonPadDivide.Click, buttonPadMultiply.Click, buttonPadMod.Click, buttonPadPow.Click, buttonPadRoot.Click, buttonPadClear.Click, btnPadEquals.Click, btnCE.Click
        Dim button As Button = CType(sender, Button)
        Select Case button.Name
            Case "buttonPadAdd"
                val1 = LeerNumero(val1)
                OperacionFlag = "Add"
                tbScreen.Text = ""
                tbScreen.PlaceholderText = "0"
            Case "buttonPadRemove"
                val1 = LeerNumero(val1)
                OperacionFlag = "Remove"
                tbScreen.Text = ""
                tbScreen.PlaceholderText = "0"
            Case "buttonPadDivide"
                val1 = LeerNumero(val1)
                OperacionFlag = "Divide"
                tbScreen.Text = ""
                tbScreen.PlaceholderText = "0"
            Case "buttonPadMultiply"
                val1 = LeerNumero(val1)
                OperacionFlag = "Multply"
                tbScreen.Text = ""
                tbScreen.PlaceholderText = "0"
            Case "buttonPadMod"
                val1 = LeerNumero(val1)
                OperacionFlag = "Mod"
                tbScreen.Text = ""
                tbScreen.PlaceholderText = "0"
            Case "buttonPadPow"
                val1 = LeerNumero(val1)
                OperacionFlag = "Pow"
                tbScreen.Text = ""
                tbScreen.PlaceholderText = "0"
            Case "buttonPadRoot"
                val1 = LeerNumero(val1)
                OperacionFlag = "Root"
                tbScreen.Text = ""
                tbScreen.PlaceholderText = "0"
            Case "buttonPadClear"
                val1 = Nothing
                val2 = Nothing
                tbScreen.Text = ""
                tbScreen.PlaceholderText = "0"
            Case "btnCE"
                val1 = Nothing
                val2 = Nothing
                a = 0
                b = 0
                res = 0
                tbScreen.Text = ""
                tbScreen.PlaceholderText = "0"
            Case "btnPadEquals"
                RealizarOperacion(OperacionFlag, val1)
                tbScreen.Text = res
        End Select
    End Sub
    Private Function LeerNumero(val As Decimal) As Decimal
        val = Decimal.Parse(tbScreen.Text)
        tbScreen.Text = ""
        tbScreen.PlaceholderText = "0"
        Return val
    End Function
    Private Sub VarKeyPad_Click(sender As Object, e As EventArgs) Handles buttonKeyRes.Click, buttonVarA.Click, buttonVarB.Click
        Dim button As Button = CType(sender, Button)
        Select Case button.Name
            Case "buttonVarA"
                If (a = Nothing) Then
                    a = Decimal.Parse(tbScreen.Text)
                    tbScreen.Text = String.Empty
                    tbScreen.PlaceholderText = "0"
                Else
                    tbScreen.Text = a.ToString
                End If
            Case "buttonVarB"
                If (b = Nothing) Then
                    b = Decimal.Parse(tbScreen.Text)
                    tbScreen.Text = String.Empty
                    tbScreen.PlaceholderText = "0"
                Else
                    tbScreen.Text = b.ToString
                End If
            Case "buttonKeyRes"
                tbScreen.Text = res.ToString
        End Select
    End Sub
    Private Sub RealizarOperacion(operacionFlag As String, val1 As Decimal)
        val2 = Nothing
        val2 = LeerNumero(val2)
        Select Case operacionFlag
            Case "Add"
                res = val1 + val2
            Case "Remove"
                res = val1 - val2
            Case "Divide"
                res = val1 / val2
            Case "Multply"
                res = val1 * val2
            Case "Mod"
                res = val1 Mod val2
            Case "Pow"
                res = Math.Pow(val1, val2)
            Case "Root"
                res = Math.Pow(val1, 1 / val2)
        End Select
        tbScreen.Text = res
    End Sub
    Private Sub CalcLoad(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class
