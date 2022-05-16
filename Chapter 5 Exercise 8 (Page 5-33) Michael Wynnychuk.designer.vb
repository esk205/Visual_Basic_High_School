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
        Me.chkCallWaiting = New System.Windows.Forms.CheckBox
        Me.chkCallForwarding = New System.Windows.Forms.CheckBox
        Me.chkCallerID = New System.Windows.Forms.CheckBox
        Me.grpSelectOptions = New System.Windows.Forms.GroupBox
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblCost = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'chkCallWaiting
        '
        Me.chkCallWaiting.AutoSize = True
        Me.chkCallWaiting.Location = New System.Drawing.Point(28, 39)
        Me.chkCallWaiting.Name = "chkCallWaiting"
        Me.chkCallWaiting.Size = New System.Drawing.Size(82, 17)
        Me.chkCallWaiting.TabIndex = 0
        Me.chkCallWaiting.Text = "Call Waiting"
        Me.chkCallWaiting.UseVisualStyleBackColor = True
        '
        'chkCallForwarding
        '
        Me.chkCallForwarding.AutoSize = True
        Me.chkCallForwarding.Location = New System.Drawing.Point(28, 72)
        Me.chkCallForwarding.Name = "chkCallForwarding"
        Me.chkCallForwarding.Size = New System.Drawing.Size(98, 17)
        Me.chkCallForwarding.TabIndex = 0
        Me.chkCallForwarding.Text = "Call Forwarding"
        Me.chkCallForwarding.UseVisualStyleBackColor = True
        '
        'chkCallerID
        '
        Me.chkCallerID.AutoSize = True
        Me.chkCallerID.Location = New System.Drawing.Point(28, 104)
        Me.chkCallerID.Name = "chkCallerID"
        Me.chkCallerID.Size = New System.Drawing.Size(66, 17)
        Me.chkCallerID.TabIndex = 0
        Me.chkCallerID.Text = "Caller ID"
        Me.chkCallerID.UseVisualStyleBackColor = True
        '
        'grpSelectOptions
        '
        Me.grpSelectOptions.Location = New System.Drawing.Point(12, 12)
        Me.grpSelectOptions.Name = "grpSelectOptions"
        Me.grpSelectOptions.Size = New System.Drawing.Size(200, 118)
        Me.grpSelectOptions.TabIndex = 1
        Me.grpSelectOptions.TabStop = False
        Me.grpSelectOptions.Text = "Select options:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 136)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 28)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(108, 146)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "Total:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(148, 146)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(28, 13)
        Me.lblCost.TabIndex = 3
        Me.lblCost.Text = "Cost"
        '
        'lblMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(218, 181)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.chkCallerID)
        Me.Controls.Add(Me.chkCallForwarding)
        Me.Controls.Add(Me.chkCallWaiting)
        Me.Controls.Add(Me.grpSelectOptions)
        Me.Name = "lblMessage"
        Me.Text = "Phone Bill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkCallWaiting As System.Windows.Forms.CheckBox
    Friend WithEvents chkCallForwarding As System.Windows.Forms.CheckBox
    Friend WithEvents chkCallerID As System.Windows.Forms.CheckBox
    Friend WithEvents grpSelectOptions As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblCost As System.Windows.Forms.Label

End Class
