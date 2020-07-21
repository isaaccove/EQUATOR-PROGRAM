Public Class ON_AND_OFF_BUTTON
    Dim K As Integer = 0

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBL2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If K = 0 Then
            LBL1.Visible = True
            LBL2.Visible = True
            LBL3.Visible = True
            K = 1
        ElseIf K = 1 Then
            LBL1.Visible = False
            LBL2.Visible = False
            LBL3.Visible = False
            K = 0
        End If




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If K = 0 Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            K = 1
        ElseIf K = 1 Then
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            K = 0
        End If
    End Sub

    Private Sub ON_AND_OFF_BUTTON_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class