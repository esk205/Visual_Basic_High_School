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
        Me.lblGreeting = New System.Windows.Forms.Label
        Me.lblEnglish = New System.Windows.Forms.RadioButton
        Me.lblSpanish = New System.Windows.Forms.RadioButton
        Me.lblFrench = New System.Windows.Forms.RadioButton
        Me.grpIntroduction = New System.Windows.Forms.GroupBox
        Me.grpLanguage = New System.Windows.Forms.GroupBox
        Me.SuspendLayout()
        '
        'lblGreeting
        '
        Me.lblGreeting.AutoSize = True
        Me.lblGreeting.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreeting.Location = New System.Drawing.Point(152, 29)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(138, 24)
        Me.lblGreeting.TabIndex = 0
        Me.lblGreeting.Text = "Hello, World!"
        Me.lblGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEnglish
        '
        Me.lblEnglish.AutoSize = True
        Me.lblEnglish.Location = New System.Drawing.Point(29, 98)
        Me.lblEnglish.Name = "lblEnglish"
        Me.lblEnglish.Size = New System.Drawing.Size(59, 17)
        Me.lblEnglish.TabIndex = 3
        Me.lblEnglish.TabStop = True
        Me.lblEnglish.Text = "English"
        Me.lblEnglish.UseVisualStyleBackColor = True
        '
        'lblSpanish
        '
        Me.lblSpanish.AutoSize = True
        Me.lblSpanish.Location = New System.Drawing.Point(149, 98)
        Me.lblSpanish.Name = "lblSpanish"
        Me.lblSpanish.Size = New System.Drawing.Size(63, 17)
        Me.lblSpanish.TabIndex = 4
        Me.lblSpanish.TabStop = True
        Me.lblSpanish.Text = "Spanish"
        Me.lblSpanish.UseVisualStyleBackColor = True
        '
        'lblFrench
        '
        Me.lblFrench.AutoSize = True
        Me.lblFrench.Location = New System.Drawing.Point(288, 98)
        Me.lblFrench.Name = "lblFrench"
        Me.lblFrench.Size = New System.Drawing.Size(58, 17)
        Me.lblFrench.TabIndex = 5
        Me.lblFrench.TabStop = True
        Me.lblFrench.Text = "French"
        Me.lblFrench.UseVisualStyleBackColor = True
        '
        'grpIntroduction
        '
        Me.grpIntroduction.Location = New System.Drawing.Point(12, 15)
        Me.grpIntroduction.Name = "grpIntroduction"
        Me.grpIntroduction.Size = New System.Drawing.Size(134, 69)
        Me.grpIntroduction.TabIndex = 6
        Me.grpIntroduction.TabStop = False
        Me.grpIntroduction.Text = "Welcome to the Welcoming Program select a language to state ""Hello"" in. "
        '
        'grpLanguage
        '
        Me.grpLanguage.Location = New System.Drawing.Point(13, 82)
        Me.grpLanguage.Name = "grpLanguage"
        Me.grpLanguage.Size = New System.Drawing.Size(347, 41)
        Me.grpLanguage.TabIndex = 7
        Me.grpLanguage.TabStop = False
        Me.grpLanguage.Text = "Select a Language"
        '
        'lblMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 135)
        Me.Controls.Add(Me.grpIntroduction)
        Me.Controls.Add(Me.lblFrench)
        Me.Controls.Add(Me.lblSpanish)
        Me.Controls.Add(Me.lblEnglish)
        Me.Controls.Add(Me.lblGreeting)
        Me.Controls.Add(Me.grpLanguage)
        Me.Name = "lblMessage"
        Me.Text = "Hello World International"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGreeting As System.Windows.Forms.Label
    Friend WithEvents lblEnglish As System.Windows.Forms.RadioButton
    Friend WithEvents lblSpanish As System.Windows.Forms.RadioButton
    Friend WithEvents lblFrench As System.Windows.Forms.RadioButton
    Friend WithEvents grpIntroduction As System.Windows.Forms.GroupBox
    Friend WithEvents grpLanguage As System.Windows.Forms.GroupBox

End Class
