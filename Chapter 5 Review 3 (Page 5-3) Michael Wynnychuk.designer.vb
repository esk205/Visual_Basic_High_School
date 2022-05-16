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
        Me.btnAnswer = New System.Windows.Forms.Button
        Me.lblEnterRadiusStatement = New System.Windows.Forms.Label
        Me.txtEnterRadiusOfCircle = New System.Windows.Forms.TextBox
        Me.lblAnswerBox1 = New System.Windows.Forms.Label
        Me.lblAnswerBox2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnAnswer
        '
        Me.btnAnswer.Location = New System.Drawing.Point(79, 84)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(171, 32)
        Me.btnAnswer.TabIndex = 1
        Me.btnAnswer.Text = "Answer"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'lblEnterRadiusStatement
        '
        Me.lblEnterRadiusStatement.AutoSize = True
        Me.lblEnterRadiusStatement.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterRadiusStatement.Location = New System.Drawing.Point(29, 15)
        Me.lblEnterRadiusStatement.Name = "lblEnterRadiusStatement"
        Me.lblEnterRadiusStatement.Size = New System.Drawing.Size(176, 16)
        Me.lblEnterRadiusStatement.TabIndex = 2
        Me.lblEnterRadiusStatement.Text = "Enter the radius of the circle: "
        '
        'txtEnterRadiusOfCircle
        '
        Me.txtEnterRadiusOfCircle.Location = New System.Drawing.Point(211, 14)
        Me.txtEnterRadiusOfCircle.Name = "txtEnterRadiusOfCircle"
        Me.txtEnterRadiusOfCircle.Size = New System.Drawing.Size(82, 20)
        Me.txtEnterRadiusOfCircle.TabIndex = 3
        '
        'lblAnswerBox1
        '
        Me.lblAnswerBox1.AutoSize = True
        Me.lblAnswerBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswerBox1.Location = New System.Drawing.Point(87, 49)
        Me.lblAnswerBox1.Name = "lblAnswerBox1"
        Me.lblAnswerBox1.Size = New System.Drawing.Size(0, 16)
        Me.lblAnswerBox1.TabIndex = 4
        '
        'lblAnswerBox2
        '
        Me.lblAnswerBox2.AutoSize = True
        Me.lblAnswerBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswerBox2.Location = New System.Drawing.Point(146, 49)
        Me.lblAnswerBox2.Name = "lblAnswerBox2"
        Me.lblAnswerBox2.Size = New System.Drawing.Size(0, 16)
        Me.lblAnswerBox2.TabIndex = 4
        '
        'lblMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 122)
        Me.Controls.Add(Me.lblAnswerBox2)
        Me.Controls.Add(Me.lblAnswerBox1)
        Me.Controls.Add(Me.txtEnterRadiusOfCircle)
        Me.Controls.Add(Me.lblEnterRadiusStatement)
        Me.Controls.Add(Me.btnAnswer)
        Me.Name = "lblMessage"
        Me.Text = "Circle Area"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAnswer As System.Windows.Forms.Button
    Friend WithEvents lblEnterRadiusStatement As System.Windows.Forms.Label
    Friend WithEvents txtEnterRadiusOfCircle As System.Windows.Forms.TextBox
    Friend WithEvents lblAnswerBox1 As System.Windows.Forms.Label
    Friend WithEvents lblAnswerBox2 As System.Windows.Forms.Label

End Class
