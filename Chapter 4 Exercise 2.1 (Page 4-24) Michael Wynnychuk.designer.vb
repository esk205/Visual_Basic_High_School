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
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.lblFahrenheitStatement = New System.Windows.Forms.Label
        Me.btnCelsiusConversion = New System.Windows.Forms.Button
        Me.txtTemperature = New System.Windows.Forms.TextBox
        Me.lblAnswer = New System.Windows.Forms.Label
        Me.lblCelsius = New System.Windows.Forms.Label
        Me.lblCelsiusStatement = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(37, 20)
        Me.mnuExit.Text = "Exit"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(523, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'lblFahrenheitStatement
        '
        Me.lblFahrenheitStatement.AutoSize = True
        Me.lblFahrenheitStatement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFahrenheitStatement.Location = New System.Drawing.Point(63, 59)
        Me.lblFahrenheitStatement.Name = "lblFahrenheitStatement"
        Me.lblFahrenheitStatement.Size = New System.Drawing.Size(308, 20)
        Me.lblFahrenheitStatement.TabIndex = 1
        Me.lblFahrenheitStatement.Text = "Enter the temperature in Fahrenheit: "
        Me.lblFahrenheitStatement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCelsiusConversion
        '
        Me.btnCelsiusConversion.Location = New System.Drawing.Point(215, 147)
        Me.btnCelsiusConversion.Name = "btnCelsiusConversion"
        Me.btnCelsiusConversion.Size = New System.Drawing.Size(111, 30)
        Me.btnCelsiusConversion.TabIndex = 4
        Me.btnCelsiusConversion.Text = "Celsius Conversion"
        Me.btnCelsiusConversion.UseVisualStyleBackColor = True
        '
        'txtTemperature
        '
        Me.txtTemperature.Location = New System.Drawing.Point(377, 59)
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.Size = New System.Drawing.Size(43, 20)
        Me.txtTemperature.TabIndex = 5
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(250, 108)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 6
        '
        'lblCelsius
        '
        Me.lblCelsius.AutoSize = True
        Me.lblCelsius.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelsius.Location = New System.Drawing.Point(281, 108)
        Me.lblCelsius.Name = "lblCelsius"
        Me.lblCelsius.Size = New System.Drawing.Size(0, 18)
        Me.lblCelsius.TabIndex = 7
        '
        'lblCelsiusStatement
        '
        Me.lblCelsiusStatement.AutoSize = True
        Me.lblCelsiusStatement.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelsiusStatement.Location = New System.Drawing.Point(64, 108)
        Me.lblCelsiusStatement.Name = "lblCelsiusStatement"
        Me.lblCelsiusStatement.Size = New System.Drawing.Size(211, 18)
        Me.lblCelsiusStatement.TabIndex = 8
        Me.lblCelsiusStatement.Text = "The temperatuere in Celsius is:"
        '
        'lblMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 203)
        Me.Controls.Add(Me.lblCelsiusStatement)
        Me.Controls.Add(Me.lblCelsius)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtTemperature)
        Me.Controls.Add(Me.btnCelsiusConversion)
        Me.Controls.Add(Me.lblFahrenheitStatement)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "lblMessage"
        Me.Text = "Temperature Conversion"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents lblFahrenheitStatement As System.Windows.Forms.Label
    Friend WithEvents btnCelsiusConversion As System.Windows.Forms.Button
    Friend WithEvents txtTemperature As System.Windows.Forms.TextBox
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents lblCelsius As System.Windows.Forms.Label
    Friend WithEvents lblCelsiusStatement As System.Windows.Forms.Label

End Class
