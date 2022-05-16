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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnuProgram = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPlayGame = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem
        Me.btnDrawCard = New System.Windows.Forms.Button
        Me.lblPlayerIsDealt = New System.Windows.Forms.Label
        Me.lblPlayersScore = New System.Windows.Forms.Label
        Me.btnCheckScore = New System.Windows.Forms.Button
        Me.lblComputerIsDealt = New System.Windows.Forms.Label
        Me.lblComputersScore = New System.Windows.Forms.Label
        Me.lblPlayerScore = New System.Windows.Forms.Label
        Me.lblComputerScore = New System.Windows.Forms.Label
        Me.lblRandomNumber1 = New System.Windows.Forms.Label
        Me.lblRandomNumber2 = New System.Windows.Forms.Label
        Me.lblRandomNumber3 = New System.Windows.Forms.Label
        Me.lblRandomNumber4 = New System.Windows.Forms.Label
        Me.lblRandomNumber5 = New System.Windows.Forms.Label
        Me.lblRandomNumber6 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProgram})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(458, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuProgram
        '
        Me.mnuProgram.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPlayGame, Me.mnuExit})
        Me.mnuProgram.Name = "mnuProgram"
        Me.mnuProgram.Size = New System.Drawing.Size(65, 20)
        Me.mnuProgram.Text = "Program"
        '
        'mnuPlayGame
        '
        Me.mnuPlayGame.Name = "mnuPlayGame"
        Me.mnuPlayGame.Size = New System.Drawing.Size(152, 22)
        Me.mnuPlayGame.Text = "Play Game!"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "Exit "
        '
        'btnDrawCard
        '
        Me.btnDrawCard.Location = New System.Drawing.Point(343, 89)
        Me.btnDrawCard.Name = "btnDrawCard"
        Me.btnDrawCard.Size = New System.Drawing.Size(103, 29)
        Me.btnDrawCard.TabIndex = 1
        Me.btnDrawCard.Text = "Draw Card!"
        Me.btnDrawCard.UseVisualStyleBackColor = True
        '
        'lblPlayerIsDealt
        '
        Me.lblPlayerIsDealt.AutoSize = True
        Me.lblPlayerIsDealt.Location = New System.Drawing.Point(27, 33)
        Me.lblPlayerIsDealt.Name = "lblPlayerIsDealt"
        Me.lblPlayerIsDealt.Size = New System.Drawing.Size(96, 13)
        Me.lblPlayerIsDealt.TabIndex = 2
        Me.lblPlayerIsDealt.Text = "The player is dealt:"
        '
        'lblPlayersScore
        '
        Me.lblPlayersScore.AutoSize = True
        Me.lblPlayersScore.Location = New System.Drawing.Point(24, 89)
        Me.lblPlayersScore.Name = "lblPlayersScore"
        Me.lblPlayersScore.Size = New System.Drawing.Size(77, 13)
        Me.lblPlayersScore.TabIndex = 2
        Me.lblPlayersScore.Text = "Player's Score:"
        '
        'btnCheckScore
        '
        Me.btnCheckScore.Location = New System.Drawing.Point(30, 125)
        Me.btnCheckScore.Name = "btnCheckScore"
        Me.btnCheckScore.Size = New System.Drawing.Size(109, 32)
        Me.btnCheckScore.TabIndex = 1
        Me.btnCheckScore.Text = "Check Score"
        Me.btnCheckScore.UseVisualStyleBackColor = True
        '
        'lblComputerIsDealt
        '
        Me.lblComputerIsDealt.AutoSize = True
        Me.lblComputerIsDealt.Location = New System.Drawing.Point(27, 171)
        Me.lblComputerIsDealt.Name = "lblComputerIsDealt"
        Me.lblComputerIsDealt.Size = New System.Drawing.Size(112, 13)
        Me.lblComputerIsDealt.TabIndex = 2
        Me.lblComputerIsDealt.Text = "The computer is dealt:"
        '
        'lblComputersScore
        '
        Me.lblComputersScore.AutoSize = True
        Me.lblComputersScore.Location = New System.Drawing.Point(27, 218)
        Me.lblComputersScore.Name = "lblComputersScore"
        Me.lblComputersScore.Size = New System.Drawing.Size(93, 13)
        Me.lblComputersScore.TabIndex = 2
        Me.lblComputersScore.Text = "Computer's Score:"
        '
        'lblPlayerScore
        '
        Me.lblPlayerScore.AutoSize = True
        Me.lblPlayerScore.Location = New System.Drawing.Point(104, 89)
        Me.lblPlayerScore.Name = "lblPlayerScore"
        Me.lblPlayerScore.Size = New System.Drawing.Size(35, 13)
        Me.lblPlayerScore.TabIndex = 2
        Me.lblPlayerScore.Text = "Score"
        '
        'lblComputerScore
        '
        Me.lblComputerScore.AutoSize = True
        Me.lblComputerScore.Location = New System.Drawing.Point(119, 218)
        Me.lblComputerScore.Name = "lblComputerScore"
        Me.lblComputerScore.Size = New System.Drawing.Size(35, 13)
        Me.lblComputerScore.TabIndex = 2
        Me.lblComputerScore.Text = "Score"
        '
        'lblRandomNumber1
        '
        Me.lblRandomNumber1.AutoSize = True
        Me.lblRandomNumber1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRandomNumber1.Location = New System.Drawing.Point(39, 60)
        Me.lblRandomNumber1.Name = "lblRandomNumber1"
        Me.lblRandomNumber1.Size = New System.Drawing.Size(136, 16)
        Me.lblRandomNumber1.TabIndex = 2
        Me.lblRandomNumber1.Text = "Random Number 1"
        '
        'lblRandomNumber2
        '
        Me.lblRandomNumber2.AutoSize = True
        Me.lblRandomNumber2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRandomNumber2.Location = New System.Drawing.Point(177, 60)
        Me.lblRandomNumber2.Name = "lblRandomNumber2"
        Me.lblRandomNumber2.Size = New System.Drawing.Size(136, 16)
        Me.lblRandomNumber2.TabIndex = 2
        Me.lblRandomNumber2.Text = "Random Number 2"
        '
        'lblRandomNumber3
        '
        Me.lblRandomNumber3.AutoSize = True
        Me.lblRandomNumber3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRandomNumber3.Location = New System.Drawing.Point(315, 60)
        Me.lblRandomNumber3.Name = "lblRandomNumber3"
        Me.lblRandomNumber3.Size = New System.Drawing.Size(136, 16)
        Me.lblRandomNumber3.TabIndex = 2
        Me.lblRandomNumber3.Text = "Random Number 3"
        '
        'lblRandomNumber4
        '
        Me.lblRandomNumber4.AutoSize = True
        Me.lblRandomNumber4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRandomNumber4.Location = New System.Drawing.Point(39, 193)
        Me.lblRandomNumber4.Name = "lblRandomNumber4"
        Me.lblRandomNumber4.Size = New System.Drawing.Size(136, 16)
        Me.lblRandomNumber4.TabIndex = 2
        Me.lblRandomNumber4.Text = "Random Number 4"
        '
        'lblRandomNumber5
        '
        Me.lblRandomNumber5.AutoSize = True
        Me.lblRandomNumber5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRandomNumber5.Location = New System.Drawing.Point(177, 193)
        Me.lblRandomNumber5.Name = "lblRandomNumber5"
        Me.lblRandomNumber5.Size = New System.Drawing.Size(136, 16)
        Me.lblRandomNumber5.TabIndex = 2
        Me.lblRandomNumber5.Text = "Random Number 5"
        '
        'lblRandomNumber6
        '
        Me.lblRandomNumber6.AutoSize = True
        Me.lblRandomNumber6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRandomNumber6.Location = New System.Drawing.Point(315, 193)
        Me.lblRandomNumber6.Name = "lblRandomNumber6"
        Me.lblRandomNumber6.Size = New System.Drawing.Size(136, 16)
        Me.lblRandomNumber6.TabIndex = 2
        Me.lblRandomNumber6.Text = "Random Number 6"
        '
        'lblMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 248)
        Me.Controls.Add(Me.lblComputersScore)
        Me.Controls.Add(Me.lblComputerIsDealt)
        Me.Controls.Add(Me.lblComputerScore)
        Me.Controls.Add(Me.lblRandomNumber6)
        Me.Controls.Add(Me.lblRandomNumber3)
        Me.Controls.Add(Me.lblRandomNumber5)
        Me.Controls.Add(Me.lblRandomNumber4)
        Me.Controls.Add(Me.lblRandomNumber2)
        Me.Controls.Add(Me.lblRandomNumber1)
        Me.Controls.Add(Me.lblPlayerScore)
        Me.Controls.Add(Me.lblPlayersScore)
        Me.Controls.Add(Me.lblPlayerIsDealt)
        Me.Controls.Add(Me.btnCheckScore)
        Me.Controls.Add(Me.btnDrawCard)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "lblMessage"
        Me.Text = "Game 21"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents btnDrawCard As System.Windows.Forms.Button
    Friend WithEvents lblPlayerIsDealt As System.Windows.Forms.Label
    Friend WithEvents lblPlayersScore As System.Windows.Forms.Label
    Friend WithEvents mnuProgram As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPlayGame As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCheckScore As System.Windows.Forms.Button
    Friend WithEvents lblComputerIsDealt As System.Windows.Forms.Label
    Friend WithEvents lblComputersScore As System.Windows.Forms.Label
    Friend WithEvents lblPlayerScore As System.Windows.Forms.Label
    Friend WithEvents lblComputerScore As System.Windows.Forms.Label
    Friend WithEvents lblRandomNumber1 As System.Windows.Forms.Label
    Friend WithEvents lblRandomNumber2 As System.Windows.Forms.Label
    Friend WithEvents lblRandomNumber3 As System.Windows.Forms.Label
    Friend WithEvents lblRandomNumber4 As System.Windows.Forms.Label
    Friend WithEvents lblRandomNumber5 As System.Windows.Forms.Label
    Friend WithEvents lblRandomNumber6 As System.Windows.Forms.Label

End Class
