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
        Me.lblEnterGrade = New System.Windows.Forms.Label
        Me.txtEnterGrade = New System.Windows.Forms.TextBox
        Me.lblGradeStatement = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnCheckGrade
        '
        Me.btnCheckGrade.Location = New System.Drawing.Point(79, 84)
        Me.btnCheckGrade.Name = "btnCheckGrade"
        Me.btnCheckGrade.Size = New System.Drawing.Size(171, 32)
        Me.btnCheckGrade.TabIndex = 1
        Me.btnCheckGrade.Text = "Check Grade"
        Me.btnCheckGrade.UseVisualStyleBackColor = True
        '
        'lblEnterGrade
        '
        Me.lblEnterGrade.AutoSize = True
        Me.lblEnterGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterGrade.Location = New System.Drawing.Point(45, 13)
        Me.lblEnterGrade.Name = "lblEnterGrade"
        Me.lblEnterGrade.Size = New System.Drawing.Size(156, 16)
        Me.lblEnterGrade.TabIndex = 2
        Me.lblEnterGrade.Text = "Enter Grade Percentage:"
        '
        'txtEnterGrade
        '
        Me.txtEnterGrade.Location = New System.Drawing.Point(207, 12)
        Me.txtEnterGrade.Name = "txtEnterGrade"
        Me.txtEnterGrade.Size = New System.Drawing.Size(55, 20)
        Me.txtEnterGrade.TabIndex = 3
        '
        'lblGradeStatement
        '
        Me.lblGradeStatement.AutoSize = True
        Me.lblGradeStatement.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradeStatement.Location = New System.Drawing.Point(89, 47)
        Me.lblGradeStatement.Name = "lblGradeStatement"
        Me.lblGradeStatement.Size = New System.Drawing.Size(133, 16)
        Me.lblGradeStatement.TabIndex = 4
        Me.lblGradeStatement.Text = "TestGradeStatement"
        '
        'lblMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 122)
        Me.Controls.Add(Me.lblGradeStatement)
        Me.Controls.Add(Me.txtEnterGrade)
        Me.Controls.Add(Me.lblEnterGrade)
        Me.Controls.Add(Me.btnCheckGrade)
        Me.Name = "lblMessage"
        Me.Text = "Test Grade"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCheckGrade As System.Windows.Forms.Button
    Friend WithEvents lblEnterGrade As System.Windows.Forms.Label
    Friend WithEvents txtEnterGrade As System.Windows.Forms.TextBox
    Friend WithEvents lblGradeStatement As System.Windows.Forms.Label

End Class
