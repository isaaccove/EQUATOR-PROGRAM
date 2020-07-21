Public Class LOGIN_FORM

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TXTU.Text = "" Then
            MsgBox("please enter the username", MsgBoxStyle.Critical)
        ElseIf TXTP.Text = "" Then
            MsgBox("please enter the password", MsgBoxStyle.Critical)
        Else
            Dim K, J As String
            K = UCase(TXTU.Text)
            J = UCase(TXTP.Text)
            If K = "ISAACAPP" Then
                If J = "ISAAC123" Then
                    MsgBox("login successful", MsgBoxStyle.Information)
                    Me.Hide()
                    EQUATOR_PROGRAM.Show()
                Else
                    MsgBox("Incorrect Password", MsgBoxStyle.Critical)
                    TXTP.Clear()
                    TXTP.Focus()
                End If
            Else
                MsgBox("Invalid Username", MsgBoxStyle.Critical)
                TXTU.Clear()
                TXTU.Focus()
            End If
        End If
    End Sub
End Class