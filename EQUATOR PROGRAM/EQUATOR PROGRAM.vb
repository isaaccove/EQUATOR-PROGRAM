Public Class EQUATOR_PROGRAM
    Dim cl As Integer = 0
    Dim k As Integer = 0
    Dim sign_indicator As Integer = 0
    Dim variable1 As Double
    Dim variable2 As Double
    Dim addBit As Integer = 0
    Dim subBit As Integer = 0
    Dim multBit As Integer = 0
    Dim divBit As Integer = 0
    Dim modBit As Integer = 0
    Dim powerBit As Integer = 0
    Dim permBit As Integer = 0
    Dim combBit As Integer = 0
    Dim andBit As Integer = 0
    Dim orBit As Integer = 0
    Dim xorBit As Integer = 0
    Dim powerFunctionBit As Integer = 0
    Dim trigFunctionBit As Integer = 0
    Dim HypertrigFunctionBit As Integer = 0
    Dim InversetrigFunction As Integer = 0
    Dim otherFuncsBit As Integer = 0
    Dim logicalFuncsBit As Integer = 0
    Dim memFuncsBit As Integer = 0
    Dim fl As Integer = 0
    Dim memoryVariable As Double = 0
    Dim scientificModeBit As Integer = 0

   

    Private Sub EQUATOR_PROGRAM_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        LOADING_FORM.Close()
        LOGIN_FORM.Close()
    End Sub

    Private Sub EQUATOR_PROGRAM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub
    Public Function factorial(ByVal temp)
        Dim result As Double = temp
        If temp = 0 Then
            Return 1
        Else
            For i = temp - 1 To 1 Step -1
                result = result * i
            Next
        End If
        Return result
    End Function
    Private Function reset_SignBits()
        addBit = 0
        subBit = 0
        multBit = 0
        divBit = 0
        modBit = 0
        powerBit = 0
        permBit = 0
        combBit = 0
        andBit = 0
        orBit = 0
        xorBit = 0
        fl = 0
        Return 0
    End Function
    Private Function permutation(ByVal variable1, ByVal variable2)
        Dim result As Double
        result = factorial(variable1) / factorial(variable1 - variable2)
        Return result
    End Function
    Private Function combination(ByVal variable1, ByVal variable2)
        Dim result As Double
        result = factorial(variable1) / (factorial(variable2) * factorial(variable1 - variable2))
        Return result
    End Function
    Private Function Calculate()
        If displaytext.Text <> "." Then
            variable2 = displaytext.Text
            If fl = 0 Then
                variable1 = variable2
            ElseIf addBit = 1 Then
                variable1 = variable1 + variable2
            ElseIf subBit = 1 Then
                variable1 = variable1 - variable2
            ElseIf multBit = 1 Then
                variable1 = variable1 * variable2
            ElseIf divBit = 1 Then
                variable1 = variable1 / variable2
            ElseIf modBit = 1 Then
                variable1 = variable1 Mod variable2
            ElseIf powerBit = 1 Then
                variable1 = Math.Pow(variable1, variable2)
            ElseIf permBit = 1 Then
                variable1 = permutation(variable1, variable2)
            ElseIf combBit = 1 Then
                variable1 = combination(variable1, variable2)
            ElseIf andBit = 1 Then
                variable1 = variable1 And variable2
            ElseIf orBit = 1 Then
                variable1 = variable1 Or variable2
            ElseIf xorBit = 1 Then
                variable1 = variable1 Xor variable2
            Else
                variable1 = variable2
            End If
            displaytext.Text = variable1
        End If
        Return 0
    End Function

    Private Sub Button63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        If sign_indicator = 0 Then
            displaytext.Text = displaytext.Text & 0
        ElseIf sign_indicator = 1 Then
            displaytext.Text = 0
            sign_indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub displaytext_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles displaytext.KeyPress
        e.Handled = True
        If e.KeyChar Like "[0-9]" Or e.KeyChar = Chr(&H8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles displaytext.TextChanged

    End Sub

    Private Sub Button62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        If sign_indicator = 0 Then
            displaytext.Text = displaytext.Text & 1
        ElseIf sign_indicator = 1 Then
            displaytext.Text = 1
            sign_indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub Button64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        If sign_indicator = 0 Then
            displaytext.Text = displaytext.Text & CStr(2)
        ElseIf sign_indicator = 1 Then
            displaytext.Text = 2
            sign_indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub Button66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        If sign_indicator = 0 Then
            displaytext.Text = displaytext.Text & 3
        ElseIf sign_indicator = 1 Then
            displaytext.Text = 3
            sign_indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub Button46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        If sign_indicator = 0 Then
            displaytext.Text = displaytext.Text & CStr(4)
        ElseIf sign_indicator = 1 Then
            displaytext.Text = 4
            sign_indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub Button47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        If sign_indicator = 0 Then
            displaytext.Text = displaytext.Text & CStr(5)
        ElseIf sign_indicator = 1 Then
            displaytext.Text = 5
            sign_indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub Button48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        If sign_indicator = 0 Then
            displaytext.Text = displaytext.Text & CStr(6)
        ElseIf sign_indicator = 1 Then
            displaytext.Text = 6
            sign_indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        If sign_indicator = 0 Then
            displaytext.Text = displaytext.Text & 7
        ElseIf sign_indicator = 1 Then
            displaytext.Text = 7
            sign_indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        If sign_indicator = 0 Then
            displaytext.Text = displaytext.Text & CStr(8)
        ElseIf sign_indicator = 1 Then
            displaytext.Text = 8
            sign_indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        If sign_indicator = 0 Then
            displaytext.Text = displaytext.Text & CStr(9)
        ElseIf sign_indicator = 1 Then
            displaytext.Text = 9
            sign_indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub Button67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If displaytext.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            addBit = 1
            sign_indicator = 1
        End If
    End Sub

    Private Sub Button68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSub.Click
        If displaytext.Text.Length <> 0 Then
            variable2 = displaytext.Text
            Calculate()
            reset_SignBits()
            subBit = 1
            sign_indicator = 1
        End If
    End Sub

    Private Sub Button49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMult.Click
        If displaytext.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            multBit = 1
            sign_indicator = 1
        End If
    End Sub

    Private Sub Button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiv.Click
        If displaytext.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            divBit = 1
            sign_indicator = 1
        End If
    End Sub

    Private Sub Button69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEqual.Click
        If displaytext.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
        End If
        sign_indicator = 1
    End Sub

    Private Sub Button65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button65.Click
        Dim i As Integer
        Dim chr As Char
        Dim decimal_indicator As Integer = 0
        If sign_indicator <> 1 Then
            For i = 0 To displaytext.Text.Count - 1
                chr = displaytext.Text(i)
                If chr = "." Then
                    decimal_indicator = 1
                End If
            Next
            If decimal_indicator <> 1 Then
                displaytext.Text = displaytext.Text & CStr(".")
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TextBox2.Text = TimeOfDay

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button55.Click
        If displaytext.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            modBit = 1
            sign_indicator = 1
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If displaytext.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            andBit = 1
            sign_indicator = 1
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If displaytext.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            orBit = 1
            sign_indicator = 1
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If displaytext.Text.Length <> 0 Then
            variable1 = CDbl(displaytext.Text)
            variable1 = Not variable1
            displaytext.Text = CStr(variable1)
            sign_indicator = 1
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If displaytext.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            xorBit = 1
            sign_indicator = 1
        End If
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        If displaytext.Text.Length <> 0 Then
            displaytext.Text = displaytext.Text.Remove(displaytext.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub Button70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button70.Click
        If displaytext.Text.Length <> 0 Then
            displaytext.Text = Math.Sin(displaytext.Text)
        End If
        sign_indicator = 1
    End Sub

    Private Sub Button71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button71.Click
        If displaytext.Text.Length <> 0 Then
            displaytext.Text = Math.Cos(displaytext.Text)
        End If
        sign_indicator = 1
    End Sub

    Private Sub Button72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button72.Click
        If displaytext.Text.Length <> 0 Then
            displaytext.Text = Math.Tan(displaytext.Text)
        End If
        sign_indicator = 1
    End Sub

    Private Sub Button43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button43.Click
        displaytext.Text = Math.PI
        sign_indicator = 1
    End Sub

    Private Sub Button53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button53.Click
        If displaytext.Text.Length <> 0 Then
            displaytext.Text = Math.Sinh(displaytext.Text)
        End If
        sign_indicator = 1
    End Sub

    Private Sub Button56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button56.Click
        If displaytext.Text.Length <> 0 Then
            displaytext.Text = Math.Cosh(displaytext.Text)
        End If
        sign_indicator = 1
    End Sub

    Private Sub Button59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button59.Click
        If displaytext.Text.Length <> 0 Then
            displaytext.Text = Math.Tanh(displaytext.Text)
        End If
        sign_indicator = 1
    End Sub

    Private Sub Button58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button58.Click
        If displaytext.Text.Length <> 0 Then
            displaytext.Text = Math.Log10(displaytext.Text)
        End If
        sign_indicator = 1
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        If displaytext.Text.Length <> 0 Then
            If displaytext.Text <> "." Then
                displaytext.Text = Math.Sqrt(displaytext.Text)
            End If
            sign_indicator = 1
        End If
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        If displaytext.Text.Length <> 0 Then
            Dim temp As Double = displaytext.Text
            displaytext.Text = Math.Round(temp)
        End If
        sign_indicator = 1
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        If displaytext.Text.Length <> 0 Then
            Dim temp As Double = displaytext.Text
            displaytext.Text = Math.Ceiling(temp)
        End If
        sign_indicator = 1
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        If displaytext.Text.Length <> 0 Then
            Dim temp As Double = displaytext.Text
            displaytext.Text = Math.Floor(temp)
        End If
        sign_indicator = 1
    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        If displaytext.Text.Length <> 0 Then
            Dim temp As Double = displaytext.Text
            Dim result = factorial(temp)
            displaytext.Text = CStr(result)
        End If
        sign_indicator = 1
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        If displaytext.Text.Length <> 0 Then
            displaytext.Text = displaytext.Text * displaytext.Text
        End If
        sign_indicator = 1
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        If displaytext.Text.Length <> 0 Then
            displaytext.Text = displaytext.Text * displaytext.Text * displaytext.Text
        End If
        sign_indicator = 1
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        If displaytext.Text.Length <> 0 Then
            displaytext.Text = displaytext.Text * displaytext.Text * displaytext.Text * displaytext.Text
        End If
        sign_indicator = 1
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        displaytext.Clear()
        sign_indicator = 0
        variable1 = 0
        variable2 = 0
        memoryVariable = 0
        reset_SignBits()
    End Sub

    Private Sub Button52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button52.Click
        If displaytext.Text.Length <> 0 Then
            displaytext.Text = Math.Exp(displaytext.Text)
        End If
        sign_indicator = 1
    End Sub

    Private Sub Button51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button51.Click

    End Sub

    Private Sub Button41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button41.Click

    End Sub

    Private Sub Button44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button44.Click
        If displaytext.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            powerBit = 1
            sign_indicator = 1
        End If
    End Sub

    Private Sub Button54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button54.Click
        If displaytext.Text <> 0 Then
            Calculate()
            reset_SignBits()
            permBit = 1
            sign_indicator = 1
        End If
    End Sub

    Private Sub Button57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button57.Click
        If displaytext.Text <> 0 Then
            Calculate()
            reset_SignBits()
            combBit = 1
            sign_indicator = 1
        End If
    End Sub

    Private Sub Button60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button60.Click

    End Sub

    Private Sub Button50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button50.Click
        If displaytext.Text <> 0 Then
            displaytext.Text = 1 / displaytext.Text
        End If
    End Sub

    Private Sub Button61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button61.Click

    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click

    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click

    End Sub

    Private Sub Button42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button42.Click
        displaytext.Text = 2 * Math.PI
        sign_indicator = 1
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click

    End Sub

    Private Sub Button47_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button47.Click
        If powerFunctionBit = 0 Then
            Button33.Enabled = 1
            Button34.Enabled = 1
            Button35.Enabled = 1
            powerFunctionBit = 1
        ElseIf powerFunctionBit = 1 Then
            Button33.Enabled = 0
            Button34.Enabled = 0
            Button35.Enabled = 0
            powerFunctionBit = 0

        End If

    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        If displaytext.Text.Length = 0 Then
            displaytext.Text = displaytext.Text + CStr("-")
        ElseIf displaytext.Text <> "." Then
            displaytext.Text = displaytext.Text * -1
        End If
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click

    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        If displaytext.Text.Length <> 0 Then
            Dim temp As Double = displaytext.Text
            displaytext.Text = Math.Truncate(temp)
        End If
        sign_indicator = 1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If k = 0 Then
            btn0.Visible = True
            btn1.Visible = True
            btn2.Visible = True
            btn3.Visible = True
            btn4.Visible = True
            btn5.Visible = True
            btn6.Visible = True
            btn7.Visible = True
            btn8.Visible = True
            btn9.Visible = True
            btnAdd.Visible = True
            btnDiv.Visible = True
            btnEqual.Visible = True
            btnMult.Visible = True
            btnSub.Visible = True
            Button1.Visible = True
            Button2.Visible = True
            Button3.Visible = True
            Button4.Visible = True
            Button5.Visible = True
            Button6.Visible = True
            Button7.Visible = True
            Button8.Visible = True
            Button9.Visible = True
            Button10.Visible = True
            Button11.Visible = True
            Button12.Visible = True
            Button13.Visible = True
            Button14.Visible = True
            Button15.Visible = True
            Button16.Visible = True
            Button17.Visible = True
            Button18.Visible = True
            Button19.Visible = True
            Button20.Visible = True
            Button21.Visible = True
            Button22.Visible = True
            Button23.Visible = True
            Button24.Visible = True
            Button25.Visible = True
            Button26.Visible = True
            Button27.Visible = True
            Button28.Visible = True
            Button29.Visible = True
            Button30.Visible = True
            Button31.Visible = True
            Button32.Visible = True
            Button33.Visible = True
            Button34.Visible = True
            Button35.Visible = True
            Button36.Visible = True
            Button37.Visible = True
            Button38.Visible = True
            Button39.Visible = True
            Button40.Visible = True
            Button41.Visible = True
            Button42.Visible = True
            Button43.Visible = True
            Button44.Visible = True
            Button45.Visible = True
            Button46.Visible = True
            Button47.Visible = True
            Button48.Visible = True
            Button49.Visible = True
            Button50.Visible = True
            Button51.Visible = True
            Button52.Visible = True
            Button53.Visible = True
            Button54.Visible = True
            Button55.Visible = True
            Button56.Visible = True
            Button57.Visible = True
            Button58.Visible = True
            Button59.Visible = True
            Button60.Visible = True
            Button61.Visible = True
            Button65.Visible = True
            Button70.Visible = True
            Button71.Visible = True
            Button72.Visible = True
            k = 1
        ElseIf k = 1 Then
            btn0.Visible = False
            btn1.Visible = False
            btn2.Visible = False
            btn3.Visible = False
            btn4.Visible = False
            btn5.Visible = False
            btn6.Visible = False
            btn7.Visible = False
            btn8.Visible = False
            btn9.Visible = False
            btnAdd.Visible = False
            btnDiv.Visible = False
            btnEqual.Visible = False
            btnMult.Visible = False
            btnSub.Visible = False
            Button1.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
            Button10.Visible = False
            Button11.Visible = False
            Button12.Visible = False
            Button13.Visible = False
            Button14.Visible = False
            Button15.Visible = False
            Button16.Visible = False
            Button17.Visible = False
            Button18.Visible = False
            Button19.Visible = False
            Button20.Visible = False
            Button21.Visible = False
            Button22.Visible = False
            Button23.Visible = False
            Button24.Visible = False
            Button25.Visible = False
            Button26.Visible = False
            Button27.Visible = False
            Button28.Visible = False
            Button29.Visible = False
            Button30.Visible = False
            Button31.Visible = False
            Button32.Visible = False
            Button33.Visible = False
            Button34.Visible = False
            Button35.Visible = False
            Button36.Visible = False
            Button37.Visible = False
            Button38.Visible = False
            Button39.Visible = False
            Button40.Visible = False
            Button41.Visible = False
            Button42.Visible = False
            Button43.Visible = False
            Button44.Visible = False
            Button45.Visible = False
            Button46.Visible = False
            Button47.Visible = False
            Button48.Visible = False
            Button49.Visible = False
            Button50.Visible = False
            Button51.Visible = False
            Button52.Visible = False
            Button53.Visible = False
            Button54.Visible = False
            Button55.Visible = False
            Button56.Visible = False
            Button57.Visible = False
            Button58.Visible = False
            Button59.Visible = False
            Button60.Visible = False
            Button61.Visible = False
            Button65.Visible = False
            Button70.Visible = False
            Button71.Visible = False
            Button72.Visible = False
            k = 0
        End If

    End Sub

   

   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cl = 0 Then
            Button1.BackColor = Color.BlanchedAlmond
            cl = 1
        ElseIf cl = 1 Then
            Button1.BackColor = Color.Brown
            cl = 2
        ElseIf cl = 2 Then
            Button1.BackColor = Color.BlueViolet
            cl = 3
        ElseIf cl = 3 Then
            Button1.BackColor = Color.Gold
            cl = 0
        End If

    End Sub
End Class