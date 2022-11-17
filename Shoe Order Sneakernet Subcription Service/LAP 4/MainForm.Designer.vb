<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.submitformButton = New System.Windows.Forms.Button()
        Me.closeformButton = New System.Windows.Forms.Button()
        Me.resetformButton = New System.Windows.Forms.Button()
        Me.frequencyGroupBox = New System.Windows.Forms.GroupBox()
        Me.annualRadioButton = New System.Windows.Forms.RadioButton()
        Me.evsixRadioButton = New System.Windows.Forms.RadioButton()
        Me.quartRadioButton = New System.Windows.Forms.RadioButton()
        Me.monRadioButton = New System.Windows.Forms.RadioButton()
        Me.shoestyleGroupBox = New System.Windows.Forms.GroupBox()
        Me.sportCheckBox = New System.Windows.Forms.CheckBox()
        Me.sandCheckBox = New System.Windows.Forms.CheckBox()
        Me.dresCheckBox = New System.Windows.Forms.CheckBox()
        Me.casCheckBox = New System.Windows.Forms.CheckBox()
        Me.sizingGroupBox = New System.Windows.Forms.GroupBox()
        Me.narstandLabel = New System.Windows.Forms.Label()
        Me.widthLabel = New System.Windows.Forms.Label()
        Me.shoesizeLabel = New System.Windows.Forms.Label()
        Me.menRadioButton = New System.Windows.Forms.RadioButton()
        Me.womenRadioButton = New System.Windows.Forms.RadioButton()
        Me.widTextBox = New System.Windows.Forms.TextBox()
        Me.shoesizeTextBox = New System.Windows.Forms.TextBox()
        Me.sssLabel1 = New System.Windows.Forms.Label()
        Me.frequencyGroupBox.SuspendLayout()
        Me.shoestyleGroupBox.SuspendLayout()
        Me.sizingGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'submitformButton
        '
        Me.submitformButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitformButton.Location = New System.Drawing.Point(50, 418)
        Me.submitformButton.Margin = New System.Windows.Forms.Padding(6)
        Me.submitformButton.Name = "submitformButton"
        Me.submitformButton.Size = New System.Drawing.Size(178, 66)
        Me.submitformButton.TabIndex = 0
        Me.submitformButton.Text = "Submit Form"
        Me.submitformButton.UseVisualStyleBackColor = True
        '
        'closeformButton
        '
        Me.closeformButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeformButton.Location = New System.Drawing.Point(464, 418)
        Me.closeformButton.Margin = New System.Windows.Forms.Padding(6)
        Me.closeformButton.Name = "closeformButton"
        Me.closeformButton.Size = New System.Drawing.Size(179, 66)
        Me.closeformButton.TabIndex = 6
        Me.closeformButton.Text = "Close Form"
        Me.closeformButton.UseVisualStyleBackColor = True
        '
        'resetformButton
        '
        Me.resetformButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetformButton.Location = New System.Drawing.Point(255, 418)
        Me.resetformButton.Margin = New System.Windows.Forms.Padding(6)
        Me.resetformButton.Name = "resetformButton"
        Me.resetformButton.Size = New System.Drawing.Size(186, 66)
        Me.resetformButton.TabIndex = 5
        Me.resetformButton.Text = "Reset Form"
        Me.resetformButton.UseVisualStyleBackColor = True
        '
        'frequencyGroupBox
        '
        Me.frequencyGroupBox.Controls.Add(Me.annualRadioButton)
        Me.frequencyGroupBox.Controls.Add(Me.evsixRadioButton)
        Me.frequencyGroupBox.Controls.Add(Me.quartRadioButton)
        Me.frequencyGroupBox.Controls.Add(Me.monRadioButton)
        Me.frequencyGroupBox.Location = New System.Drawing.Point(15, 116)
        Me.frequencyGroupBox.Margin = New System.Windows.Forms.Padding(6)
        Me.frequencyGroupBox.Name = "frequencyGroupBox"
        Me.frequencyGroupBox.Padding = New System.Windows.Forms.Padding(6)
        Me.frequencyGroupBox.Size = New System.Drawing.Size(213, 247)
        Me.frequencyGroupBox.TabIndex = 2
        Me.frequencyGroupBox.TabStop = False
        Me.frequencyGroupBox.Text = "Frequency"
        '
        'annualRadioButton
        '
        Me.annualRadioButton.AutoSize = True
        Me.annualRadioButton.Location = New System.Drawing.Point(24, 196)
        Me.annualRadioButton.Name = "annualRadioButton"
        Me.annualRadioButton.Size = New System.Drawing.Size(97, 28)
        Me.annualRadioButton.TabIndex = 3
        Me.annualRadioButton.TabStop = True
        Me.annualRadioButton.Text = "Annualy"
        Me.annualRadioButton.UseVisualStyleBackColor = True
        '
        'evsixRadioButton
        '
        Me.evsixRadioButton.AutoSize = True
        Me.evsixRadioButton.Location = New System.Drawing.Point(21, 148)
        Me.evsixRadioButton.Name = "evsixRadioButton"
        Me.evsixRadioButton.Size = New System.Drawing.Size(174, 28)
        Me.evsixRadioButton.TabIndex = 2
        Me.evsixRadioButton.TabStop = True
        Me.evsixRadioButton.Text = "Every Six Months"
        Me.evsixRadioButton.UseVisualStyleBackColor = True
        '
        'quartRadioButton
        '
        Me.quartRadioButton.AutoSize = True
        Me.quartRadioButton.Location = New System.Drawing.Point(21, 99)
        Me.quartRadioButton.Name = "quartRadioButton"
        Me.quartRadioButton.Size = New System.Drawing.Size(104, 28)
        Me.quartRadioButton.TabIndex = 1
        Me.quartRadioButton.TabStop = True
        Me.quartRadioButton.Text = "Quarterly"
        Me.quartRadioButton.UseVisualStyleBackColor = True
        '
        'monRadioButton
        '
        Me.monRadioButton.AutoSize = True
        Me.monRadioButton.Location = New System.Drawing.Point(24, 51)
        Me.monRadioButton.Name = "monRadioButton"
        Me.monRadioButton.Size = New System.Drawing.Size(94, 28)
        Me.monRadioButton.TabIndex = 0
        Me.monRadioButton.TabStop = True
        Me.monRadioButton.Text = "Monthly"
        Me.monRadioButton.UseVisualStyleBackColor = True
        '
        'shoestyleGroupBox
        '
        Me.shoestyleGroupBox.Controls.Add(Me.sportCheckBox)
        Me.shoestyleGroupBox.Controls.Add(Me.sandCheckBox)
        Me.shoestyleGroupBox.Controls.Add(Me.dresCheckBox)
        Me.shoestyleGroupBox.Controls.Add(Me.casCheckBox)
        Me.shoestyleGroupBox.Location = New System.Drawing.Point(240, 116)
        Me.shoestyleGroupBox.Margin = New System.Windows.Forms.Padding(6)
        Me.shoestyleGroupBox.Name = "shoestyleGroupBox"
        Me.shoestyleGroupBox.Padding = New System.Windows.Forms.Padding(6)
        Me.shoestyleGroupBox.Size = New System.Drawing.Size(215, 247)
        Me.shoestyleGroupBox.TabIndex = 3
        Me.shoestyleGroupBox.TabStop = False
        Me.shoestyleGroupBox.Text = "Shoe Style"
        '
        'sportCheckBox
        '
        Me.sportCheckBox.AutoSize = True
        Me.sportCheckBox.Location = New System.Drawing.Point(37, 197)
        Me.sportCheckBox.Name = "sportCheckBox"
        Me.sportCheckBox.Size = New System.Drawing.Size(82, 28)
        Me.sportCheckBox.TabIndex = 3
        Me.sportCheckBox.Text = "Sports"
        Me.sportCheckBox.UseVisualStyleBackColor = True
        '
        'sandCheckBox
        '
        Me.sandCheckBox.AutoSize = True
        Me.sandCheckBox.Location = New System.Drawing.Point(37, 144)
        Me.sandCheckBox.Name = "sandCheckBox"
        Me.sandCheckBox.Size = New System.Drawing.Size(96, 28)
        Me.sandCheckBox.TabIndex = 2
        Me.sandCheckBox.Text = "Sandals"
        Me.sandCheckBox.UseVisualStyleBackColor = True
        '
        'dresCheckBox
        '
        Me.dresCheckBox.AutoSize = True
        Me.dresCheckBox.Location = New System.Drawing.Point(37, 94)
        Me.dresCheckBox.Name = "dresCheckBox"
        Me.dresCheckBox.Size = New System.Drawing.Size(77, 28)
        Me.dresCheckBox.TabIndex = 1
        Me.dresCheckBox.Text = "Dress"
        Me.dresCheckBox.UseVisualStyleBackColor = True
        '
        'casCheckBox
        '
        Me.casCheckBox.AutoSize = True
        Me.casCheckBox.Location = New System.Drawing.Point(37, 48)
        Me.casCheckBox.Name = "casCheckBox"
        Me.casCheckBox.Size = New System.Drawing.Size(86, 28)
        Me.casCheckBox.TabIndex = 0
        Me.casCheckBox.Text = "Casual"
        Me.casCheckBox.UseVisualStyleBackColor = True
        '
        'sizingGroupBox
        '
        Me.sizingGroupBox.Controls.Add(Me.narstandLabel)
        Me.sizingGroupBox.Controls.Add(Me.widthLabel)
        Me.sizingGroupBox.Controls.Add(Me.shoesizeLabel)
        Me.sizingGroupBox.Controls.Add(Me.menRadioButton)
        Me.sizingGroupBox.Controls.Add(Me.womenRadioButton)
        Me.sizingGroupBox.Controls.Add(Me.widTextBox)
        Me.sizingGroupBox.Controls.Add(Me.shoesizeTextBox)
        Me.sizingGroupBox.Location = New System.Drawing.Point(484, 116)
        Me.sizingGroupBox.Margin = New System.Windows.Forms.Padding(6)
        Me.sizingGroupBox.Name = "sizingGroupBox"
        Me.sizingGroupBox.Padding = New System.Windows.Forms.Padding(6)
        Me.sizingGroupBox.Size = New System.Drawing.Size(222, 247)
        Me.sizingGroupBox.TabIndex = 4
        Me.sizingGroupBox.TabStop = False
        Me.sizingGroupBox.Text = "Sizing"
        '
        'narstandLabel
        '
        Me.narstandLabel.AutoSize = True
        Me.narstandLabel.Location = New System.Drawing.Point(5, 152)
        Me.narstandLabel.Name = "narstandLabel"
        Me.narstandLabel.Size = New System.Drawing.Size(210, 24)
        Me.narstandLabel.TabIndex = 6
        Me.narstandLabel.Text = "Narrow, Standard, Wide"
        '
        'widthLabel
        '
        Me.widthLabel.AutoSize = True
        Me.widthLabel.Location = New System.Drawing.Point(14, 99)
        Me.widthLabel.Name = "widthLabel"
        Me.widthLabel.Size = New System.Drawing.Size(63, 24)
        Me.widthLabel.TabIndex = 5
        Me.widthLabel.Text = "Width:"
        '
        'shoesizeLabel
        '
        Me.shoesizeLabel.AutoSize = True
        Me.shoesizeLabel.Location = New System.Drawing.Point(9, 51)
        Me.shoesizeLabel.Name = "shoesizeLabel"
        Me.shoesizeLabel.Size = New System.Drawing.Size(101, 24)
        Me.shoesizeLabel.TabIndex = 4
        Me.shoesizeLabel.Text = "Shoe Size:"
        '
        'menRadioButton
        '
        Me.menRadioButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.menRadioButton.AutoSize = True
        Me.menRadioButton.Location = New System.Drawing.Point(9, 197)
        Me.menRadioButton.Name = "menRadioButton"
        Me.menRadioButton.Size = New System.Drawing.Size(71, 34)
        Me.menRadioButton.TabIndex = 3
        Me.menRadioButton.TabStop = True
        Me.menRadioButton.Text = "Men's"
        Me.menRadioButton.UseVisualStyleBackColor = True
        '
        'womenRadioButton
        '
        Me.womenRadioButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.womenRadioButton.AutoSize = True
        Me.womenRadioButton.Location = New System.Drawing.Point(95, 197)
        Me.womenRadioButton.Name = "womenRadioButton"
        Me.womenRadioButton.Size = New System.Drawing.Size(100, 34)
        Me.womenRadioButton.TabIndex = 2
        Me.womenRadioButton.TabStop = True
        Me.womenRadioButton.Text = "Women's"
        Me.womenRadioButton.UseVisualStyleBackColor = True
        '
        'widTextBox
        '
        Me.widTextBox.Location = New System.Drawing.Point(113, 96)
        Me.widTextBox.Name = "widTextBox"
        Me.widTextBox.Size = New System.Drawing.Size(100, 29)
        Me.widTextBox.TabIndex = 1
        '
        'shoesizeTextBox
        '
        Me.shoesizeTextBox.Location = New System.Drawing.Point(113, 48)
        Me.shoesizeTextBox.Name = "shoesizeTextBox"
        Me.shoesizeTextBox.Size = New System.Drawing.Size(100, 29)
        Me.shoesizeTextBox.TabIndex = 0
        '
        'sssLabel1
        '
        Me.sssLabel1.AutoSize = True
        Me.sssLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sssLabel1.Location = New System.Drawing.Point(54, 32)
        Me.sssLabel1.Name = "sssLabel1"
        Me.sssLabel1.Size = New System.Drawing.Size(601, 26)
        Me.sssLabel1.TabIndex = 1
        Me.sssLabel1.Text = "Sneakernet Subcription Service ___________________"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(733, 528)
        Me.Controls.Add(Me.sssLabel1)
        Me.Controls.Add(Me.shoestyleGroupBox)
        Me.Controls.Add(Me.sizingGroupBox)
        Me.Controls.Add(Me.frequencyGroupBox)
        Me.Controls.Add(Me.resetformButton)
        Me.Controls.Add(Me.closeformButton)
        Me.Controls.Add(Me.submitformButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "MainForm"
        Me.frequencyGroupBox.ResumeLayout(False)
        Me.frequencyGroupBox.PerformLayout()
        Me.shoestyleGroupBox.ResumeLayout(False)
        Me.shoestyleGroupBox.PerformLayout()
        Me.sizingGroupBox.ResumeLayout(False)
        Me.sizingGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents submitformButton As Button
    Friend WithEvents closeformButton As Button
    Friend WithEvents resetformButton As Button
    Friend WithEvents frequencyGroupBox As GroupBox
    Friend WithEvents annualRadioButton As RadioButton
    Friend WithEvents evsixRadioButton As RadioButton
    Friend WithEvents quartRadioButton As RadioButton
    Friend WithEvents monRadioButton As RadioButton
    Friend WithEvents shoestyleGroupBox As GroupBox
    Friend WithEvents sportCheckBox As CheckBox
    Friend WithEvents sandCheckBox As CheckBox
    Friend WithEvents dresCheckBox As CheckBox
    Friend WithEvents casCheckBox As CheckBox
    Friend WithEvents sizingGroupBox As GroupBox
    Friend WithEvents menRadioButton As RadioButton
    Friend WithEvents womenRadioButton As RadioButton
    Friend WithEvents widTextBox As TextBox
    Friend WithEvents shoesizeTextBox As TextBox
    Friend WithEvents sssLabel1 As Label
    Friend WithEvents narstandLabel As Label
    Friend WithEvents widthLabel As Label
    Friend WithEvents shoesizeLabel As Label
End Class
