<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lblMessage
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
        Me.lblPromptEnterInteger = New System.Windows.Forms.Label
        Me.btnTest = New System.Windows.Forms.Button
        Me.txtTestNumber = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lblPromptEnterInteger
        '
        Me.lblPromptEnterInteger.AutoSize = True
        Me.lblPromptEnterInteger.Location = New System.Drawing.Point(31, 33)
        Me.lblPromptEnterInteger.Name = "lblPromptEnterInteger"
        Me.lblPromptEnterInteger.Size = New System.Drawing.Size(86, 13)
        Me.lblPromptEnterInteger.TabIndex = 0
        Me.lblPromptEnterInteger.Text = "Enter an Integer:"
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(175, 41)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(87, 41)
        Me.btnTest.TabIndex = 1
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'txtTestNumber
        '
        Me.txtTestNumber.Location = New System.Drawing.Point(123, 30)
        Me.txtTestNumber.Name = "txtTestNumber"
        Me.txtTestNumber.Size = New System.Drawing.Size(33, 20)
        Me.txtTestNumber.TabIndex = 2
        '
        'lblMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 94)
        Me.Controls.Add(Me.txtTestNumber)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.lblPromptEnterInteger)
        Me.Name = "lblMessage"
        Me.Text = "Prime Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPromptEnterInteger As System.Windows.Forms.Label
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents txtTestNumber As System.Windows.Forms.TextBox

End Class
