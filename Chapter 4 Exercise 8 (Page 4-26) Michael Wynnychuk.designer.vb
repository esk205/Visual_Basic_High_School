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
        Me.mnuProgram = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.btnDigits = New System.Windows.Forms.Button
        Me.lblEnterDigitStatement = New System.Windows.Forms.Label
        Me.txtTwoDigitNumber = New System.Windows.Forms.TextBox
        Me.lblTheFirstDigitStatement = New System.Windows.Forms.Label
        Me.lblTheSecondDigitStatement = New System.Windows.Forms.Label
        Me.lblDigit1 = New System.Windows.Forms.Label
        Me.lblDigit2 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuProgram
        '
        Me.mnuProgram.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnuProgram.Name = "mnuProgram"
        Me.mnuProgram.Size = New System.Drawing.Size(65, 20)
        Me.mnuProgram.Text = "Program"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(92, 22)
        Me.mnuExit.Text = "Exit"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProgram})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(268, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnDigits
        '
        Me.btnDigits.Location = New System.Drawing.Point(48, 121)
        Me.btnDigits.Name = "btnDigits"
        Me.btnDigits.Size = New System.Drawing.Size(186, 32)
        Me.btnDigits.TabIndex = 1
        Me.btnDigits.Text = "Digits"
        Me.btnDigits.UseVisualStyleBackColor = True
        '
        'lblEnterDigitStatement
        '
        Me.lblEnterDigitStatement.AutoSize = True
        Me.lblEnterDigitStatement.Location = New System.Drawing.Point(45, 38)
        Me.lblEnterDigitStatement.Name = "lblEnterDigitStatement"
        Me.lblEnterDigitStatement.Size = New System.Drawing.Size(124, 13)
        Me.lblEnterDigitStatement.TabIndex = 2
        Me.lblEnterDigitStatement.Text = "Enter a two digit number:"
        '
        'txtTwoDigitNumber
        '
        Me.txtTwoDigitNumber.Location = New System.Drawing.Point(176, 38)
        Me.txtTwoDigitNumber.Name = "txtTwoDigitNumber"
        Me.txtTwoDigitNumber.Size = New System.Drawing.Size(44, 20)
        Me.txtTwoDigitNumber.TabIndex = 3
        '
        'lblTheFirstDigitStatement
        '
        Me.lblTheFirstDigitStatement.AutoSize = True
        Me.lblTheFirstDigitStatement.Location = New System.Drawing.Point(45, 69)
        Me.lblTheFirstDigitStatement.Name = "lblTheFirstDigitStatement"
        Me.lblTheFirstDigitStatement.Size = New System.Drawing.Size(83, 13)
        Me.lblTheFirstDigitStatement.TabIndex = 4
        Me.lblTheFirstDigitStatement.Text = "The first digit is: "
        '
        'lblTheSecondDigitStatement
        '
        Me.lblTheSecondDigitStatement.AutoSize = True
        Me.lblTheSecondDigitStatement.Location = New System.Drawing.Point(45, 96)
        Me.lblTheSecondDigitStatement.Name = "lblTheSecondDigitStatement"
        Me.lblTheSecondDigitStatement.Size = New System.Drawing.Size(99, 13)
        Me.lblTheSecondDigitStatement.TabIndex = 5
        Me.lblTheSecondDigitStatement.Text = "The second digit is:"
        '
        'lblDigit1
        '
        Me.lblDigit1.AutoSize = True
        Me.lblDigit1.Location = New System.Drawing.Point(134, 69)
        Me.lblDigit1.Name = "lblDigit1"
        Me.lblDigit1.Size = New System.Drawing.Size(34, 13)
        Me.lblDigit1.TabIndex = 6
        Me.lblDigit1.Text = "Digit1"
        '
        'lblDigit2
        '
        Me.lblDigit2.AutoSize = True
        Me.lblDigit2.Location = New System.Drawing.Point(153, 96)
        Me.lblDigit2.Name = "lblDigit2"
        Me.lblDigit2.Size = New System.Drawing.Size(34, 13)
        Me.lblDigit2.TabIndex = 6
        Me.lblDigit2.Text = "Digit2"
        '
        'lblMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 163)
        Me.Controls.Add(Me.lblDigit2)
        Me.Controls.Add(Me.lblDigit1)
        Me.Controls.Add(Me.lblTheSecondDigitStatement)
        Me.Controls.Add(Me.lblTheFirstDigitStatement)
        Me.Controls.Add(Me.txtTwoDigitNumber)
        Me.Controls.Add(Me.lblEnterDigitStatement)
        Me.Controls.Add(Me.btnDigits)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "lblMessage"
        Me.Text = "Digit of a Number"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuProgram As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents btnDigits As System.Windows.Forms.Button
    Friend WithEvents lblEnterDigitStatement As System.Windows.Forms.Label
    Friend WithEvents txtTwoDigitNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblTheFirstDigitStatement As System.Windows.Forms.Label
    Friend WithEvents lblTheSecondDigitStatement As System.Windows.Forms.Label
    Friend WithEvents lblDigit1 As System.Windows.Forms.Label
    Friend WithEvents lblDigit2 As System.Windows.Forms.Label

End Class
