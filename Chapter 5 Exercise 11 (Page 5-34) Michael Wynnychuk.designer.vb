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
        Me.grpSandwichSize = New System.Windows.Forms.GroupBox
        Me.radSmallSandwich = New System.Windows.Forms.RadioButton
        Me.radLargeSandwich = New System.Windows.Forms.RadioButton
        Me.grpFixings = New System.Windows.Forms.GroupBox
        Me.chkMajonnaise = New System.Windows.Forms.CheckBox
        Me.chkCheese = New System.Windows.Forms.CheckBox
        Me.chkMustard = New System.Windows.Forms.CheckBox
        Me.chkOnion = New System.Windows.Forms.CheckBox
        Me.chkTomato = New System.Windows.Forms.CheckBox
        Me.chkLettuce = New System.Windows.Forms.CheckBox
        Me.lblTotalPrice = New System.Windows.Forms.Label
        Me.lblPrice = New System.Windows.Forms.Label
        Me.btnPlaceOrder = New System.Windows.Forms.Button
        Me.grpSandwichSize.SuspendLayout()
        Me.grpFixings.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSandwichSize
        '
        Me.grpSandwichSize.Controls.Add(Me.radSmallSandwich)
        Me.grpSandwichSize.Controls.Add(Me.radLargeSandwich)
        Me.grpSandwichSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSandwichSize.Location = New System.Drawing.Point(6, 12)
        Me.grpSandwichSize.Name = "grpSandwichSize"
        Me.grpSandwichSize.Size = New System.Drawing.Size(184, 74)
        Me.grpSandwichSize.TabIndex = 0
        Me.grpSandwichSize.TabStop = False
        Me.grpSandwichSize.Text = "Sandwich Size"
        '
        'radSmallSandwich
        '
        Me.radSmallSandwich.AutoSize = True
        Me.radSmallSandwich.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSmallSandwich.Location = New System.Drawing.Point(6, 42)
        Me.radSmallSandwich.Name = "radSmallSandwich"
        Me.radSmallSandwich.Size = New System.Drawing.Size(114, 19)
        Me.radSmallSandwich.TabIndex = 0
        Me.radSmallSandwich.TabStop = True
        Me.radSmallSandwich.Text = "Small Sandwich"
        Me.radSmallSandwich.UseVisualStyleBackColor = True
        '
        'radLargeSandwich
        '
        Me.radLargeSandwich.AutoSize = True
        Me.radLargeSandwich.Location = New System.Drawing.Point(6, 19)
        Me.radLargeSandwich.Name = "radLargeSandwich"
        Me.radLargeSandwich.Size = New System.Drawing.Size(102, 17)
        Me.radLargeSandwich.TabIndex = 0
        Me.radLargeSandwich.TabStop = True
        Me.radLargeSandwich.Text = "Large Sandwich"
        Me.radLargeSandwich.UseVisualStyleBackColor = True
        '
        'grpFixings
        '
        Me.grpFixings.Controls.Add(Me.chkMajonnaise)
        Me.grpFixings.Controls.Add(Me.chkCheese)
        Me.grpFixings.Controls.Add(Me.chkMustard)
        Me.grpFixings.Controls.Add(Me.chkOnion)
        Me.grpFixings.Controls.Add(Me.chkTomato)
        Me.grpFixings.Controls.Add(Me.chkLettuce)
        Me.grpFixings.Location = New System.Drawing.Point(199, 12)
        Me.grpFixings.Name = "grpFixings"
        Me.grpFixings.Size = New System.Drawing.Size(358, 81)
        Me.grpFixings.TabIndex = 1
        Me.grpFixings.TabStop = False
        Me.grpFixings.Text = "Fixings"
        '
        'chkMajonnaise
        '
        Me.chkMajonnaise.AutoSize = True
        Me.chkMajonnaise.Location = New System.Drawing.Point(233, 52)
        Me.chkMajonnaise.Name = "chkMajonnaise"
        Me.chkMajonnaise.Size = New System.Drawing.Size(110, 17)
        Me.chkMajonnaise.TabIndex = 1
        Me.chkMajonnaise.Text = "Majonnaise (Free)"
        Me.chkMajonnaise.UseVisualStyleBackColor = True
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Location = New System.Drawing.Point(115, 52)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(98, 17)
        Me.chkCheese.TabIndex = 1
        Me.chkCheese.Text = "Cheese ($0.50)"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'chkMustard
        '
        Me.chkMustard.AutoSize = True
        Me.chkMustard.Location = New System.Drawing.Point(233, 29)
        Me.chkMustard.Name = "chkMustard"
        Me.chkMustard.Size = New System.Drawing.Size(94, 17)
        Me.chkMustard.TabIndex = 1
        Me.chkMustard.Text = "Mustard (Free)"
        Me.chkMustard.UseVisualStyleBackColor = True
        '
        'chkOnion
        '
        Me.chkOnion.AutoSize = True
        Me.chkOnion.Location = New System.Drawing.Point(7, 52)
        Me.chkOnion.Name = "chkOnion"
        Me.chkOnion.Size = New System.Drawing.Size(90, 17)
        Me.chkOnion.TabIndex = 1
        Me.chkOnion.Text = "Onion ($0.10)"
        Me.chkOnion.UseVisualStyleBackColor = True
        '
        'chkTomato
        '
        Me.chkTomato.AutoSize = True
        Me.chkTomato.Location = New System.Drawing.Point(115, 29)
        Me.chkTomato.Name = "chkTomato"
        Me.chkTomato.Size = New System.Drawing.Size(98, 17)
        Me.chkTomato.TabIndex = 1
        Me.chkTomato.Text = "Tomato ($0.25)"
        Me.chkTomato.UseVisualStyleBackColor = True
        '
        'chkLettuce
        '
        Me.chkLettuce.AutoSize = True
        Me.chkLettuce.Location = New System.Drawing.Point(7, 29)
        Me.chkLettuce.Name = "chkLettuce"
        Me.chkLettuce.Size = New System.Drawing.Size(98, 17)
        Me.chkLettuce.TabIndex = 1
        Me.chkLettuce.Text = "Lettuce ($0.10)"
        Me.chkLettuce.UseVisualStyleBackColor = True
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.Location = New System.Drawing.Point(223, 117)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(95, 18)
        Me.lblTotalPrice.TabIndex = 2
        Me.lblTotalPrice.Text = "Total Price: $"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(324, 117)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(42, 18)
        Me.lblPrice.TabIndex = 2
        Me.lblPrice.Text = "Price"
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Location = New System.Drawing.Point(15, 92)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(175, 50)
        Me.btnPlaceOrder.TabIndex = 3
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 154)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.grpFixings)
        Me.Controls.Add(Me.grpSandwichSize)
        Me.Name = "lblMessage"
        Me.Text = "Sandwich Order"
        Me.grpSandwichSize.ResumeLayout(False)
        Me.grpSandwichSize.PerformLayout()
        Me.grpFixings.ResumeLayout(False)
        Me.grpFixings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpSandwichSize As System.Windows.Forms.GroupBox
    Friend WithEvents radSmallSandwich As System.Windows.Forms.RadioButton
    Friend WithEvents radLargeSandwich As System.Windows.Forms.RadioButton
    Friend WithEvents grpFixings As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents btnPlaceOrder As System.Windows.Forms.Button
    Friend WithEvents chkMajonnaise As System.Windows.Forms.CheckBox
    Friend WithEvents chkCheese As System.Windows.Forms.CheckBox
    Friend WithEvents chkMustard As System.Windows.Forms.CheckBox
    Friend WithEvents chkOnion As System.Windows.Forms.CheckBox
    Friend WithEvents chkTomato As System.Windows.Forms.CheckBox
    Friend WithEvents chkLettuce As System.Windows.Forms.CheckBox

End Class
