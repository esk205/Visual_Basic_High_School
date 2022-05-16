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
        Me.btnLethCC = New System.Windows.Forms.RadioButton
        Me.grpSelectBand = New System.Windows.Forms.GroupBox
        Me.btnUOC = New System.Windows.Forms.RadioButton
        Me.btnLethUniversity = New System.Windows.Forms.RadioButton
        Me.btnRDC = New System.Windows.Forms.RadioButton
        Me.btnUOA = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.grpBandMembers = New System.Windows.Forms.GroupBox
        Me.lblAreaCode = New System.Windows.Forms.Label
        Me.lblCity = New System.Windows.Forms.Label
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.lblStreetAvenue = New System.Windows.Forms.Label
        Me.grpSelectBand.SuspendLayout()
        Me.grpBandMembers.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLethCC
        '
        Me.btnLethCC.AutoSize = True
        Me.btnLethCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLethCC.Location = New System.Drawing.Point(6, 28)
        Me.btnLethCC.Name = "btnLethCC"
        Me.btnLethCC.Size = New System.Drawing.Size(218, 21)
        Me.btnLethCC.TabIndex = 2
        Me.btnLethCC.TabStop = True
        Me.btnLethCC.Text = "Lethbridge Community College"
        Me.btnLethCC.UseVisualStyleBackColor = True
        '
        'grpSelectBand
        '
        Me.grpSelectBand.Controls.Add(Me.btnLethCC)
        Me.grpSelectBand.Controls.Add(Me.btnUOC)
        Me.grpSelectBand.Controls.Add(Me.btnLethUniversity)
        Me.grpSelectBand.Controls.Add(Me.btnRDC)
        Me.grpSelectBand.Controls.Add(Me.btnUOA)
        Me.grpSelectBand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSelectBand.Location = New System.Drawing.Point(12, 12)
        Me.grpSelectBand.Name = "grpSelectBand"
        Me.grpSelectBand.Size = New System.Drawing.Size(233, 182)
        Me.grpSelectBand.TabIndex = 3
        Me.grpSelectBand.TabStop = False
        Me.grpSelectBand.Text = "Select a School "
        '
        'btnUOC
        '
        Me.btnUOC.AutoSize = True
        Me.btnUOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUOC.Location = New System.Drawing.Point(6, 137)
        Me.btnUOC.Name = "btnUOC"
        Me.btnUOC.Size = New System.Drawing.Size(156, 21)
        Me.btnUOC.TabIndex = 2
        Me.btnUOC.TabStop = True
        Me.btnUOC.Text = "University of Calgary"
        Me.btnUOC.UseVisualStyleBackColor = True
        '
        'btnLethUniversity
        '
        Me.btnLethUniversity.AutoSize = True
        Me.btnLethUniversity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLethUniversity.Location = New System.Drawing.Point(6, 110)
        Me.btnLethUniversity.Name = "btnLethUniversity"
        Me.btnLethUniversity.Size = New System.Drawing.Size(160, 21)
        Me.btnLethUniversity.TabIndex = 2
        Me.btnLethUniversity.TabStop = True
        Me.btnLethUniversity.Text = "Lethbridge University"
        Me.btnLethUniversity.UseVisualStyleBackColor = True
        '
        'btnRDC
        '
        Me.btnRDC.AutoSize = True
        Me.btnRDC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRDC.Location = New System.Drawing.Point(6, 83)
        Me.btnRDC.Name = "btnRDC"
        Me.btnRDC.Size = New System.Drawing.Size(138, 21)
        Me.btnRDC.TabIndex = 2
        Me.btnRDC.TabStop = True
        Me.btnRDC.Text = "Red Deer College"
        Me.btnRDC.UseVisualStyleBackColor = True
        '
        'btnUOA
        '
        Me.btnUOA.AutoSize = True
        Me.btnUOA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUOA.Location = New System.Drawing.Point(6, 56)
        Me.btnUOA.Name = "btnUOA"
        Me.btnUOA.Size = New System.Drawing.Size(153, 21)
        Me.btnUOA.TabIndex = 2
        Me.btnUOA.TabStop = True
        Me.btnUOA.Text = "University of Alberta"
        Me.btnUOA.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(186, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 4
        '
        'grpBandMembers
        '
        Me.grpBandMembers.Controls.Add(Me.lblAreaCode)
        Me.grpBandMembers.Controls.Add(Me.lblCity)
        Me.grpBandMembers.Controls.Add(Me.RadioButton1)
        Me.grpBandMembers.Controls.Add(Me.lblStreetAvenue)
        Me.grpBandMembers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBandMembers.Location = New System.Drawing.Point(249, 46)
        Me.grpBandMembers.Name = "grpBandMembers"
        Me.grpBandMembers.Size = New System.Drawing.Size(262, 148)
        Me.grpBandMembers.TabIndex = 5
        Me.grpBandMembers.TabStop = False
        Me.grpBandMembers.Text = "Location:"
        '
        'lblAreaCode
        '
        Me.lblAreaCode.AutoSize = True
        Me.lblAreaCode.Location = New System.Drawing.Point(18, 108)
        Me.lblAreaCode.Name = "lblAreaCode"
        Me.lblAreaCode.Size = New System.Drawing.Size(84, 16)
        Me.lblAreaCode.TabIndex = 0
        Me.lblAreaCode.Text = "Area code:"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(18, 73)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(38, 16)
        Me.lblCity.TabIndex = 0
        Me.lblCity.Text = "City:"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(-224, 92)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(156, 21)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "University of Calgary"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'lblStreetAvenue
        '
        Me.lblStreetAvenue.AutoSize = True
        Me.lblStreetAvenue.Location = New System.Drawing.Point(18, 36)
        Me.lblStreetAvenue.Name = "lblStreetAvenue"
        Me.lblStreetAvenue.Size = New System.Drawing.Size(139, 16)
        Me.lblStreetAvenue.TabIndex = 0
        Me.lblStreetAvenue.Text = "Street and Avenue:"
        '
        'lblMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 203)
        Me.Controls.Add(Me.grpBandMembers)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grpSelectBand)
        Me.Name = "lblMessage"
        Me.Text = "Addresses for Universities and Colleges in Alberta"
        Me.grpSelectBand.ResumeLayout(False)
        Me.grpSelectBand.PerformLayout()
        Me.grpBandMembers.ResumeLayout(False)
        Me.grpBandMembers.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLethCC As System.Windows.Forms.RadioButton
    Friend WithEvents grpSelectBand As System.Windows.Forms.GroupBox
    Friend WithEvents btnUOC As System.Windows.Forms.RadioButton
    Friend WithEvents btnLethUniversity As System.Windows.Forms.RadioButton
    Friend WithEvents btnRDC As System.Windows.Forms.RadioButton
    Friend WithEvents btnUOA As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grpBandMembers As System.Windows.Forms.GroupBox
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblStreetAvenue As System.Windows.Forms.Label
    Friend WithEvents lblAreaCode As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton

End Class
