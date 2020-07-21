Public Class ON_AND_OFF
    Dim k As Integer = 0

    Private Sub BTNOF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNOF.Click

        If k = 0 Then
            LBLBULB.BackColor = Color.Red
            k = 1
        ElseIf k = 1 Then
            LBLBULB.BackColor = Color.Black
            k = 2
        ElseIf k = 2 Then
            LBLBULB.BackColor = Color.Blue
            k = 0
        End If
    End Sub

    Private Sub ON_AND_OFF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class