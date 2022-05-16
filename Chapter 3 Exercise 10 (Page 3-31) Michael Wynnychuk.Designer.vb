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
        Me.mnuPosition = New System.Windows.Forms.ToolStripMenuItem
        Me.MiddleCenterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMiddleCenter = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMiddleLeft = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMiddleRight = New System.Windows.Forms.ToolStripMenuItem
        Me.BottomLeftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuBottomLeft = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuBottomRight = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuBottomCenter = New System.Windows.Forms.ToolStripMenuItem
        Me.TopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuTopCenter = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuTopLeft = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuTopRight = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.lblHere = New System.Windows.Forms.Label
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
        'mnuPosition
        '
        Me.mnuPosition.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MiddleCenterToolStripMenuItem, Me.BottomLeftToolStripMenuItem, Me.TopToolStripMenuItem})
        Me.mnuPosition.Name = "mnuPosition"
        Me.mnuPosition.Size = New System.Drawing.Size(62, 20)
        Me.mnuPosition.Text = "Position"
        '
        'MiddleCenterToolStripMenuItem
        '
        Me.MiddleCenterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMiddleCenter, Me.mnuMiddleLeft, Me.mnuMiddleRight})
        Me.MiddleCenterToolStripMenuItem.Name = "MiddleCenterToolStripMenuItem"
        Me.MiddleCenterToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.MiddleCenterToolStripMenuItem.Text = "Middle "
        '
        'mnuMiddleCenter
        '
        Me.mnuMiddleCenter.Name = "mnuMiddleCenter"
        Me.mnuMiddleCenter.Size = New System.Drawing.Size(149, 22)
        Me.mnuMiddleCenter.Text = "Middle Center"
        '
        'mnuMiddleLeft
        '
        Me.mnuMiddleLeft.Name = "mnuMiddleLeft"
        Me.mnuMiddleLeft.Size = New System.Drawing.Size(149, 22)
        Me.mnuMiddleLeft.Text = "Middle Left"
        '
        'mnuMiddleRight
        '
        Me.mnuMiddleRight.Name = "mnuMiddleRight"
        Me.mnuMiddleRight.Size = New System.Drawing.Size(149, 22)
        Me.mnuMiddleRight.Text = "Middle Right"
        '
        'BottomLeftToolStripMenuItem
        '
        Me.BottomLeftToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBottomLeft, Me.mnuBottomRight, Me.mnuBottomCenter})
        Me.BottomLeftToolStripMenuItem.Name = "BottomLeftToolStripMenuItem"
        Me.BottomLeftToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.BottomLeftToolStripMenuItem.Text = "Bottom "
        '
        'mnuBottomLeft
        '
        Me.mnuBottomLeft.Name = "mnuBottomLeft"
        Me.mnuBottomLeft.Size = New System.Drawing.Size(152, 22)
        Me.mnuBottomLeft.Text = "Bottom Left"
        '
        'mnuBottomRight
        '
        Me.mnuBottomRight.Name = "mnuBottomRight"
        Me.mnuBottomRight.Size = New System.Drawing.Size(152, 22)
        Me.mnuBottomRight.Text = "Bottom Right"
        '
        'mnuBottomCenter
        '
        Me.mnuBottomCenter.Name = "mnuBottomCenter"
        Me.mnuBottomCenter.Size = New System.Drawing.Size(152, 22)
        Me.mnuBottomCenter.Text = "Bottom Center"
        '
        'TopToolStripMenuItem
        '
        Me.TopToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTopCenter, Me.mnuTopLeft, Me.mnuTopRight})
        Me.TopToolStripMenuItem.Name = "TopToolStripMenuItem"
        Me.TopToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.TopToolStripMenuItem.Text = "Top"
        '
        'mnuTopCenter
        '
        Me.mnuTopCenter.Name = "mnuTopCenter"
        Me.mnuTopCenter.Size = New System.Drawing.Size(133, 22)
        Me.mnuTopCenter.Text = "Top Center"
        '
        'mnuTopLeft
        '
        Me.mnuTopLeft.Name = "mnuTopLeft"
        Me.mnuTopLeft.Size = New System.Drawing.Size(133, 22)
        Me.mnuTopLeft.Text = "Top Left"
        '
        'mnuTopRight
        '
        Me.mnuTopRight.Name = "mnuTopRight"
        Me.mnuTopRight.Size = New System.Drawing.Size(133, 22)
        Me.mnuTopRight.Text = "Top Right"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProgram, Me.mnuPosition})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(523, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'lblHere
        '
        Me.lblHere.AutoSize = True
        Me.lblHere.Location = New System.Drawing.Point(206, 76)
        Me.lblHere.Name = "lblHere"
        Me.lblHere.Size = New System.Drawing.Size(40, 13)
        Me.lblHere.TabIndex = 1
        Me.lblHere.Text = "lblHere"
        '
        'lblMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 203)
        Me.Controls.Add(Me.lblHere)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "lblMessage"
        Me.Text = "Position"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuProgram As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPosition As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MiddleCenterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMiddleCenter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMiddleLeft As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMiddleRight As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BottomLeftToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBottomLeft As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBottomRight As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBottomCenter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTopCenter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTopLeft As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTopRight As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents lblHere As System.Windows.Forms.Label

End Class
