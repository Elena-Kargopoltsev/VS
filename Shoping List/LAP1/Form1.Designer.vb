<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.descriptionLabel = New System.Windows.Forms.Label()
        Me.numberofitemsLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.descriptionTextBox = New System.Windows.Forms.TextBox()
        Me.shoppinglist2Label = New System.Windows.Forms.Label()
        Me.CountLabel = New System.Windows.Forms.Label()
        Me.addtolistButton = New System.Windows.Forms.Button()
        Me.yellowButton = New System.Windows.Forms.Button()
        Me.blueButton = New System.Windows.Forms.Button()
        Me.redButton = New System.Windows.Forms.Button()
        Me.resetformButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'descriptionLabel
        '
        Me.descriptionLabel.AutoSize = True
        Me.descriptionLabel.Location = New System.Drawing.Point(65, 37)
        Me.descriptionLabel.Name = "descriptionLabel"
        Me.descriptionLabel.Size = New System.Drawing.Size(142, 21)
        Me.descriptionLabel.TabIndex = 0
        Me.descriptionLabel.Text = "Description:"
        '
        'numberofitemsLabel
        '
        Me.numberofitemsLabel.AutoSize = True
        Me.numberofitemsLabel.Location = New System.Drawing.Point(65, 103)
        Me.numberofitemsLabel.Name = "numberofitemsLabel"
        Me.numberofitemsLabel.Size = New System.Drawing.Size(186, 21)
        Me.numberofitemsLabel.TabIndex = 3
        Me.numberofitemsLabel.Text = "Number of Items:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 14.0!, System.Drawing.FontStyle.Underline)
        Me.Label1.Location = New System.Drawing.Point(65, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Shopping List"
        '
        'descriptionTextBox
        '
        Me.descriptionTextBox.Location = New System.Drawing.Point(213, 37)
        Me.descriptionTextBox.Name = "descriptionTextBox"
        Me.descriptionTextBox.Size = New System.Drawing.Size(305, 29)
        Me.descriptionTextBox.TabIndex = 1
        Me.descriptionTextBox.Text = "Enter Item"
        '
        'shoppinglist2Label
        '
        Me.shoppinglist2Label.BackColor = System.Drawing.Color.Gray
        Me.shoppinglist2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.shoppinglist2Label.ForeColor = System.Drawing.Color.Black
        Me.shoppinglist2Label.Location = New System.Drawing.Point(69, 201)
        Me.shoppinglist2Label.Name = "shoppinglist2Label"
        Me.shoppinglist2Label.Size = New System.Drawing.Size(720, 151)
        Me.shoppinglist2Label.TabIndex = 6
        '
        'CountLabel
        '
        Me.CountLabel.AutoSize = True
        Me.CountLabel.ForeColor = System.Drawing.Color.White
        Me.CountLabel.Location = New System.Drawing.Point(300, 103)
        Me.CountLabel.Name = "CountLabel"
        Me.CountLabel.Size = New System.Drawing.Size(21, 21)
        Me.CountLabel.TabIndex = 4
        Me.CountLabel.Text = "0"
        '
        'addtolistButton
        '
        Me.addtolistButton.Location = New System.Drawing.Point(569, 30)
        Me.addtolistButton.Name = "addtolistButton"
        Me.addtolistButton.Size = New System.Drawing.Size(220, 40)
        Me.addtolistButton.TabIndex = 2
        Me.addtolistButton.Text = "Add to List"
        Me.addtolistButton.UseVisualStyleBackColor = True
        '
        'yellowButton
        '
        Me.yellowButton.Location = New System.Drawing.Point(83, 408)
        Me.yellowButton.Name = "yellowButton"
        Me.yellowButton.Size = New System.Drawing.Size(220, 40)
        Me.yellowButton.TabIndex = 7
        Me.yellowButton.Text = "Yellow"
        Me.yellowButton.UseVisualStyleBackColor = True
        '
        'blueButton
        '
        Me.blueButton.Location = New System.Drawing.Point(320, 408)
        Me.blueButton.Name = "blueButton"
        Me.blueButton.Size = New System.Drawing.Size(220, 40)
        Me.blueButton.TabIndex = 8
        Me.blueButton.Text = "Blue"
        Me.blueButton.UseVisualStyleBackColor = True
        '
        'redButton
        '
        Me.redButton.Location = New System.Drawing.Point(570, 408)
        Me.redButton.Name = "redButton"
        Me.redButton.Size = New System.Drawing.Size(220, 40)
        Me.redButton.TabIndex = 9
        Me.redButton.Text = "Red"
        Me.redButton.UseVisualStyleBackColor = True
        '
        'resetformButton
        '
        Me.resetformButton.Location = New System.Drawing.Point(320, 491)
        Me.resetformButton.Name = "resetformButton"
        Me.resetformButton.Size = New System.Drawing.Size(220, 40)
        Me.resetformButton.TabIndex = 10
        Me.resetformButton.Text = "Reset Form"
        Me.resetformButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(570, 491)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(220, 40)
        Me.exitButton.TabIndex = 11
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1467, 727)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.resetformButton)
        Me.Controls.Add(Me.redButton)
        Me.Controls.Add(Me.blueButton)
        Me.Controls.Add(Me.yellowButton)
        Me.Controls.Add(Me.addtolistButton)
        Me.Controls.Add(Me.CountLabel)
        Me.Controls.Add(Me.shoppinglist2Label)
        Me.Controls.Add(Me.descriptionTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numberofitemsLabel)
        Me.Controls.Add(Me.descriptionLabel)
        Me.Font = New System.Drawing.Font("Courier New", 14.0!)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shopping_List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents descriptionLabel As Label
    Friend WithEvents numberofitemsLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents descriptionTextBox As TextBox
    Friend WithEvents shoppinglist2Label As Label
    Friend WithEvents CountLabel As Label
    Friend WithEvents addtolistButton As Button
    Friend WithEvents yellowButton As Button
    Friend WithEvents blueButton As Button
    Friend WithEvents redButton As Button
    Friend WithEvents resetformButton As Button
    Friend WithEvents exitButton As Button
End Class
