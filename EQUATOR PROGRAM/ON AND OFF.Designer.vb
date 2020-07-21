<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ON_AND_OFF
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LBLBULB = New System.Windows.Forms.Label
        Me.BTNOF = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'LBLBULB
        '
        Me.LBLBULB.Location = New System.Drawing.Point(74, 40)
        Me.LBLBULB.Name = "LBLBULB"
        Me.LBLBULB.Size = New System.Drawing.Size(141, 43)
        Me.LBLBULB.TabIndex = 0
        '
        'BTNOF
        '
        Me.BTNOF.Location = New System.Drawing.Point(91, 130)
        Me.BTNOF.Name = "BTNOF"
        Me.BTNOF.Size = New System.Drawing.Size(75, 23)
        Me.BTNOF.TabIndex = 1
        Me.BTNOF.Text = "ON/OFF"
        Me.BTNOF.UseVisualStyleBackColor = True
        '
        'ON_AND_OFF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BTNOF)
        Me.Controls.Add(Me.LBLBULB)
        Me.Name = "ON_AND_OFF"
        Me.Text = "ON_AND_OFF"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LBLBULB As System.Windows.Forms.Label
    Friend WithEvents BTNOF As System.Windows.Forms.Button
End Class
