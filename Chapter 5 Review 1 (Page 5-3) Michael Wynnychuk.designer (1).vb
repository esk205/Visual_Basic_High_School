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
        Me.btnCheckGrade = New System.Windows.Forms.Button
        Me.lblEnterDigitStatement = New System.Windows.Forms.Label
        Me.txtEnterTestGrade = New System.Windows.Forms.TextBox
        Me.lblGradeStatement = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnCheckGrade
        '
        Me.btnCheckGrade.Location = New System.Drawing.Point(23, 74)
        Me.btnCheckGrade.Name = "btnCheckGrade"
        Me.btnCheckGrade.Size = New System.Drawing.Size(186, 32)
        Me.btnCheckGrade.TabIndex = 1
        Me.btnCheckGrade.Text = "Check Grade"
        Me.btnCheckGrade.UseVisualStyleBackColor = True
        '
        'lblEnterDigitStatement
        '
        Me.lblEnterDigitStatement.AutoSize = True
        Me.lblEnterDigitStatement.Location = New System.Drawing.Point(39, 15)
        Me.lblEnterDigitStatement.Name = "lblEnterDigitStatement"
        Me.lblEnterDigitStatement.Size = New System.Drawing.Size(94, 13)
        Me.lblEnterDigitStatement.TabIndex = 2
        Me.lblEnterDigitStatement.Text = "Enter a test grade:"
        '
        'txtEnterTestGrade
        '
        Me.txtEnterTestGrade.Location = New System.Drawing.Point(139, 12)
        Me.txtEnterTestGrade.Name = "txtEnterTestGrade"
        Me.txtEnterTestGrade.Size = New System.Drawing.Size(44, 20)
        Me.txtEnterTestGrade.TabIndex = 3
        '
        'lblGradeStatement
        '
        Me.lblGradeStatement.AutoSize = True
        Me.lblGradeStatement.Location = New System.Drawing.Point(88, 47)
        Me.lblGradeStatement.Name = "lblGradeStatement"
        Me.lblGradeStatement.Size = New System.Drawing.Size(0, 13)
        Me.lblGradeStatement.TabIndex = 4
        '
        'lblMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 112)
        Me.Controls.Add(Me.lblGradeStatement)
        Me.Controls.Add(Me.txtEnterTestGrade)
        Me.Controls.Add(Me.lblEnterDigitStatement)
        Me.Controls.Add(Me.btnCheckGrade)
        Me.Name = "lblMessage"
        Me.Text = "Test Grade"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCheckGrade As System.Windows.Forms.Button
    Friend WithEvents lblEnterDigitStatement As System.Windows.Forms.Label
    Friend WithEvents txtEnterTestGrade As System.Windows.Forms.TextBox
    Friend WithEvents lblGradeStatement As System.Windows.Forms.Label

End Class
