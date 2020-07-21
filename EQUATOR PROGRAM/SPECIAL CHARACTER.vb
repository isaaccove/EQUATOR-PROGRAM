Public Class SPECIAL_CHARACTER

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim L As Integer
        Dim Chk As Char
        Dim Decindicator As Integer = 0
        For L = 0 To TXT1.Text.Count - 1
            Chk = TXT1.Text(L)
            If Chk = "@" Then
                Decindicator = 1
            ElseIf Chk = "#" Then
                Decindicator = 2
            End If
        Next
        If Decindicator = 1 Then
            MsgBox("This character is not allowed", MsgBoxStyle.Critical)
            TXT1.Clear()
            TXT1.Focus()
        ElseIf Decindicator = 2 Then
            MsgBox("Such character is not allowed", MsgBoxStyle.Critical)
            TXT1.Clear()
            TXT1.Focus()
        End If
    End Sub
End Class