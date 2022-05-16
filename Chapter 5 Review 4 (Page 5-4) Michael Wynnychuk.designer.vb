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
        Me.btnCheckGuess = New System.Windows.Forms.Button
        Me.lblPrompt = New System.Windows.Forms.Label
        Me.txtPlayerGuess = New System.Windows.Forms.TextBox
        Me.lblAnswer1 = New System.Windows.Forms.Label
        Me.lblAnswer2 = New System.Windows.Forms.Label
        Me.lblCorrectGuess = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnCheckGuess
        '
        Me.btnCheckGuess.Location = New System.Drawing.Point(33, 76)
        Me.btnCheckGuess.Name = "btnCheckGuess"
        Me.btnCheckGuess.Size = New System.Drawing.Size(222, 33)
        Me.btnCheckGuess.TabIndex = 0
        Me.btnCheckGuess.Text = "Check Guess"
        Me.btnCheckGuess.UseVisualStyleBackColor = True
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.Location = New System.Drawing.Point(12, 9)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(193, 16)
        Me.lblPrompt.TabIndex = 1
        Me.lblPrompt.Text = "Enter a guess between 1 and 7:"
        '
        'txtPlayerGuess
        '
        Me.txtPlayerGuess.Location = New System.Drawing.Point(218, 9)
        Me.txtPlayerGuess.Name = "txtPlayerGuess"
        Me.txtPlayerGuess.Size = New System.Drawing.Size(78, 20)
        Me.txtPlayerGuess.TabIndex = 2
        '
        'lblAnswer1
        '
        Me.lblAnswer1.AutoSize = True
        Me.lblAnswer1.Location = New System.Drawing.Point(84, 43)
        Me.lblAnswer1.Name = "lblAnswer1"
        Me.lblAnswer1.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer1.TabIndex = 3
        '
        'lblAnswer2
        '
        Me.lblAnswer2.AutoSize = True
        Me.lblAnswer2.Location = New System.Drawing.Point(30, 43)
        Me.lblAnswer2.Name = "lblAnswer2"
        Me.lblAnswer2.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer2.TabIndex = 3
        '
        'lblCorrectGuess
        '
        Me.lblCorrectGuess.AutoSize = True
        Me.lblCorrectGuess.Location = New System.Drawing.Point(51, 43)
        Me.lblCorrectGuess.Name = "lblCorrectGuess"
        Me.lblCorrectGuess.Size = New System.Drawing.Size(0, 13)
        Me.lblCorrectGuess.TabIndex = 4
        '
        'lblMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 111)
        Me.Controls.Add(Me.lblCorrectGuess)
        Me.Controls.Add(Me.lblAnswer2)
        Me.Controls.Add(Me.lblAnswer1)
        Me.Controls.Add(Me.txtPlayerGuess)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.btnCheckGuess)
        Me.Name = "lblMessage"
        Me.Text = "Number Guess Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCheckGuess As System.Windows.Forms.Button
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents txtPlayerGuess As System.Windows.Forms.TextBox
    Friend WithEvents lblAnswer1 As System.Windows.Forms.Label
    Friend WithEvents lblAnswer2 As System.Windows.Forms.Label
    Friend WithEvents lblCorrectGuess As System.Windows.Forms.Label

End Class
