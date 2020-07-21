<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ON_AND_OFF_BUTTON
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
        Me.components = New System.ComponentModel.Container
        Me.LBL1 = New System.Windows.Forms.Label
        Me.LBL2 = New System.Windows.Forms.Label
        Me.LBL3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'LBL1
        '
        Me.LBL1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBL1.Location = New System.Drawing.Point(72, 42)
        Me.LBL1.Name = "LBL1"
        Me.LBL1.Size = New System.Drawing.Size(100, 23)
        Me.LBL1.TabIndex = 0
        '
        'LBL2
        '
        Me.LBL2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBL2.Location = New System.Drawing.Point(72, 85)
        Me.LBL2.Name = "LBL2"
        Me.LBL2.Size = New System.Drawing.Size(100, 23)
        Me.LBL2.TabIndex = 1
        '
        'LBL3
        '
        Me.LBL3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBL3.Location = New System.Drawing.Point(72, 123)
        Me.LBL3.Name = "LBL3"
        Me.LBL3.Size = New System.Drawing.Size(100, 23)
        Me.LBL3.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(82, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "ON/OFF"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(173, 180)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(178, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(178, 83)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(178, 114)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 7
        '
        'ON_AND_OFF_BUTTON
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LBL3)
        Me.Controls.Add(Me.LBL2)
        Me.Controls.Add(Me.LBL1)
        Me.Name = "ON_AND_OFF_BUTTON"
        Me.Text = "ON_AND_OFF_BUTTON"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBL1 As System.Windows.Forms.Label
    Friend WithEvents LBL2 As System.Windows.Forms.Label
    Friend WithEvents LBL3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
End Class
