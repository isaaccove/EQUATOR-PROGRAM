Public Class LOADING_FORM

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 1
        Label2.Text = ProgressBar1.Value & "%"
        If ProgressBar1.Value >= 100 Then
            Timer1.Enabled = False
            Me.Hide()
            LOGIN_FORM.Show()
        End If
    End Sub

    Private Sub LOADING_FORM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class