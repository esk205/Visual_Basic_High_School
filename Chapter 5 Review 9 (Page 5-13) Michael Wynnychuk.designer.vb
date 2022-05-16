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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lblMessage))
        Me.lblInstructions = New System.Windows.Forms.Label
        Me.grpHowToPlay = New System.Windows.Forms.GroupBox
        Me.lblChose = New System.Windows.Forms.Label
        Me.lblYourChoice = New System.Windows.Forms.Label
        Me.lblTheComputerChose = New System.Windows.Forms.Label
        Me.lblComputerChoice = New System.Windows.Forms.Label
        Me.lblOutcomeStatement = New System.Windows.Forms.Label
        Me.lblOutcome = New System.Windows.Forms.Label
        Me.btnRock1 = New System.Windows.Forms.RadioButton
        Me.btnPaper2 = New System.Windows.Forms.RadioButton
        Me.btnScissors3 = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.grpHowToPlay.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(6, 23)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(549, 169)
        Me.lblInstructions.TabIndex = 5
        Me.lblInstructions.Text = resources.GetString("lblInstructions.Text")
        '
        'grpHowToPlay
        '
        Me.grpHowToPlay.Controls.Add(Me.lblInstructions)
        Me.grpHowToPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHowToPlay.Location = New System.Drawing.Point(0, 186)
        Me.grpHowToPlay.Name = "grpHowToPlay"
        Me.grpHowToPlay.Size = New System.Drawing.Size(520, 177)
        Me.grpHowToPlay.TabIndex = 6
        Me.grpHowToPlay.TabStop = False
        Me.grpHowToPlay.Text = "How to play!"
        '
        'lblChose
        '
        Me.lblChose.AutoSize = True
        Me.lblChose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChose.Location = New System.Drawing.Point(5, 109)
        Me.lblChose.Name = "lblChose"
        Me.lblChose.Size = New System.Drawing.Size(89, 20)
        Me.lblChose.TabIndex = 7
        Me.lblChose.Text = "You chose:"
        '
        'lblYourChoice
        '
        Me.lblYourChoice.AutoSize = True
        Me.lblYourChoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYourChoice.Location = New System.Drawing.Point(100, 112)
        Me.lblYourChoice.Name = "lblYourChoice"
        Me.lblYourChoice.Size = New System.Drawing.Size(78, 16)
        Me.lblYourChoice.TabIndex = 8
        Me.lblYourChoice.Text = "YourChoice"
        '
        'lblTheComputerChose
        '
        Me.lblTheComputerChose.AutoSize = True
        Me.lblTheComputerChose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTheComputerChose.Location = New System.Drawing.Point(222, 110)
        Me.lblTheComputerChose.Name = "lblTheComputerChose"
        Me.lblTheComputerChose.Size = New System.Drawing.Size(158, 20)
        Me.lblTheComputerChose.TabIndex = 9
        Me.lblTheComputerChose.Text = "The computer chose:"
        '
        'lblComputerChoice
        '
        Me.lblComputerChoice.AutoSize = True
        Me.lblComputerChoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComputerChoice.Location = New System.Drawing.Point(386, 113)
        Me.lblComputerChoice.Name = "lblComputerChoice"
        Me.lblComputerChoice.Size = New System.Drawing.Size(108, 16)
        Me.lblComputerChoice.TabIndex = 10
        Me.lblComputerChoice.Text = "ComputerChoice"
        '
        'lblOutcomeStatement
        '
        Me.lblOutcomeStatement.AutoSize = True
        Me.lblOutcomeStatement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutcomeStatement.Location = New System.Drawing.Point(104, 163)
        Me.lblOutcomeStatement.Name = "lblOutcomeStatement"
        Me.lblOutcomeStatement.Size = New System.Drawing.Size(75, 20)
        Me.lblOutcomeStatement.TabIndex = 11
        Me.lblOutcomeStatement.Text = "Results:"
        '
        'lblOutcome
        '
        Me.lblOutcome.AutoSize = True
        Me.lblOutcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutcome.Location = New System.Drawing.Point(185, 163)
        Me.lblOutcome.Name = "lblOutcome"
        Me.lblOutcome.Size = New System.Drawing.Size(74, 20)
        Me.lblOutcome.TabIndex = 12
        Me.lblOutcome.Text = "Outcome"
        '
        'btnRock1
        '
        Me.btnRock1.AutoSize = True
        Me.btnRock1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRock1.Location = New System.Drawing.Point(115, 63)
        Me.btnRock1.Name = "btnRock1"
        Me.btnRock1.Size = New System.Drawing.Size(64, 24)
        Me.btnRock1.TabIndex = 13
        Me.btnRock1.TabStop = True
        Me.btnRock1.Text = "Rock"
        Me.btnRock1.UseVisualStyleBackColor = True
        '
        'btnPaper2
        '
        Me.btnPaper2.AutoSize = True
        Me.btnPaper2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaper2.Location = New System.Drawing.Point(224, 63)
        Me.btnPaper2.Name = "btnPaper2"
        Me.btnPaper2.Size = New System.Drawing.Size(69, 24)
        Me.btnPaper2.TabIndex = 13
        Me.btnPaper2.TabStop = True
        Me.btnPaper2.Text = "Paper"
        Me.btnPaper2.UseVisualStyleBackColor = True
        '
        'btnScissors3
        '
        Me.btnScissors3.AutoSize = True
        Me.btnScissors3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScissors3.Location = New System.Drawing.Point(325, 63)
        Me.btnScissors3.Name = "btnScissors3"
        Me.btnScissors3.Size = New System.Drawing.Size(87, 24)
        Me.btnScissors3.TabIndex = 13
        Me.btnScissors3.TabStop = True
        Me.btnScissors3.Text = "Scissors"
        Me.btnScissors3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(499, 29)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Welcome to Rock, Paper, Scissors the Game!"
        '
        'lblMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 375)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnScissors3)
        Me.Controls.Add(Me.btnPaper2)
        Me.Controls.Add(Me.btnRock1)
        Me.Controls.Add(Me.lblOutcome)
        Me.Controls.Add(Me.lblOutcomeStatement)
        Me.Controls.Add(Me.lblComputerChoice)
        Me.Controls.Add(Me.lblTheComputerChose)
        Me.Controls.Add(Me.lblYourChoice)
        Me.Controls.Add(Me.lblChose)
        Me.Controls.Add(Me.grpHowToPlay)
        Me.Name = "lblMessage"
        Me.Text = "Game: Rock, Paper, Scissors"
        Me.grpHowToPlay.ResumeLayout(False)
        Me.grpHowToPlay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents grpHowToPlay As System.Windows.Forms.GroupBox
    Friend WithEvents lblChose As System.Windows.Forms.Label
    Friend WithEvents lblYourChoice As System.Windows.Forms.Label
    Friend WithEvents lblTheComputerChose As System.Windows.Forms.Label
    Friend WithEvents lblComputerChoice As System.Windows.Forms.Label
    Friend WithEvents lblOutcomeStatement As System.Windows.Forms.Label
    Friend WithEvents lblOutcome As System.Windows.Forms.Label
    Friend WithEvents btnRock1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnPaper2 As System.Windows.Forms.RadioButton
    Friend WithEvents btnScissors3 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
