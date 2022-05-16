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
        Me.lblModelNumber = New System.Windows.Forms.Label
        Me.txtModelNumber = New System.Windows.Forms.TextBox
        Me.lblYourCarIs = New System.Windows.Forms.Label
        Me.lblConditionOfCar = New System.Windows.Forms.Label
        Me.btnEvaluateCar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblModelNumber
        '
        Me.lblModelNumber.AutoSize = True
        Me.lblModelNumber.Location = New System.Drawing.Point(7, 18)
        Me.lblModelNumber.Name = "lblModelNumber"
        Me.lblModelNumber.Size = New System.Drawing.Size(127, 13)
        Me.lblModelNumber.TabIndex = 0
        Me.lblModelNumber.Text = "Enter your model number:"
        '
        'txtModelNumber
        '
        Me.txtModelNumber.Location = New System.Drawing.Point(140, 15)
        Me.txtModelNumber.Name = "txtModelNumber"
        Me.txtModelNumber.Size = New System.Drawing.Size(63, 20)
        Me.txtModelNumber.TabIndex = 4
        '
        'lblYourCarIs
        '
        Me.lblYourCarIs.AutoSize = True
        Me.lblYourCarIs.Location = New System.Drawing.Point(6, 53)
        Me.lblYourCarIs.Name = "lblYourCarIs"
        Me.lblYourCarIs.Size = New System.Drawing.Size(60, 13)
        Me.lblYourCarIs.TabIndex = 5
        Me.lblYourCarIs.Text = "Your car is:"
        '
        'lblConditionOfCar
        '
        Me.lblConditionOfCar.AutoSize = True
        Me.lblConditionOfCar.Location = New System.Drawing.Point(72, 53)
        Me.lblConditionOfCar.Name = "lblConditionOfCar"
        Me.lblConditionOfCar.Size = New System.Drawing.Size(51, 13)
        Me.lblConditionOfCar.TabIndex = 5
        Me.lblConditionOfCar.Text = "Condition"
        '
        'btnEvaluateCar
        '
        Me.btnEvaluateCar.Location = New System.Drawing.Point(219, 10)
        Me.btnEvaluateCar.Name = "btnEvaluateCar"
        Me.btnEvaluateCar.Size = New System.Drawing.Size(95, 29)
        Me.btnEvaluateCar.TabIndex = 6
        Me.btnEvaluateCar.Text = "Evaluate"
        Me.btnEvaluateCar.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 87)
        Me.Controls.Add(Me.btnEvaluateCar)
        Me.Controls.Add(Me.lblConditionOfCar)
        Me.Controls.Add(Me.lblYourCarIs)
        Me.Controls.Add(Me.txtModelNumber)
        Me.Controls.Add(Me.lblModelNumber)
        Me.Name = "lblMessage"
        Me.Text = "Car Models"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblModelNumber As System.Windows.Forms.Label
    Friend WithEvents txtModelNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblYourCarIs As System.Windows.Forms.Label
    Friend WithEvents lblConditionOfCar As System.Windows.Forms.Label
    Friend WithEvents btnEvaluateCar As System.Windows.Forms.Button

End Class
