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
        Me.arrivalLabel = New System.Windows.Forms.Label()
        Me.lightLabel = New System.Windows.Forms.Label()
        Me.systemLabel = New System.Windows.Forms.Label()
        Me.serviceLabel = New System.Windows.Forms.Label()
        Me.simulateButton = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.arrivalTextBox = New System.Windows.Forms.TextBox()
        Me.bigTextBox = New System.Windows.Forms.TextBox()
        Me.systemTextBox = New System.Windows.Forms.TextBox()
        Me.serviceTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'arrivalLabel
        '
        Me.arrivalLabel.AutoSize = True
        Me.arrivalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arrivalLabel.Location = New System.Drawing.Point(40, 34)
        Me.arrivalLabel.Name = "arrivalLabel"
        Me.arrivalLabel.Size = New System.Drawing.Size(132, 26)
        Me.arrivalLabel.TabIndex = 0
        Me.arrivalLabel.Text = "Arrival Rate:"
        '
        'lightLabel
        '
        Me.lightLabel.AutoSize = True
        Me.lightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lightLabel.Location = New System.Drawing.Point(362, 167)
        Me.lightLabel.Name = "lightLabel"
        Me.lightLabel.Size = New System.Drawing.Size(237, 26)
        Me.lightLabel.TabIndex = 7
        Me.lightLabel.Text = "(Light, Medium, Heavy)"
        '
        'systemLabel
        '
        Me.systemLabel.AutoSize = True
        Me.systemLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.systemLabel.Location = New System.Drawing.Point(40, 167)
        Me.systemLabel.Name = "systemLabel"
        Me.systemLabel.Size = New System.Drawing.Size(146, 26)
        Me.systemLabel.TabIndex = 5
        Me.systemLabel.Text = "System Load:"
        '
        'serviceLabel
        '
        Me.serviceLabel.AutoSize = True
        Me.serviceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serviceLabel.Location = New System.Drawing.Point(40, 96)
        Me.serviceLabel.Name = "serviceLabel"
        Me.serviceLabel.Size = New System.Drawing.Size(143, 26)
        Me.serviceLabel.TabIndex = 3
        Me.serviceLabel.Text = "Service Rate:"
        '
        'simulateButton
        '
        Me.simulateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.simulateButton.Location = New System.Drawing.Point(530, 34)
        Me.simulateButton.Name = "simulateButton"
        Me.simulateButton.Size = New System.Drawing.Size(164, 39)
        Me.simulateButton.TabIndex = 2
        Me.simulateButton.Text = "Simulate"
        Me.simulateButton.UseVisualStyleBackColor = True
        '
        'closeButton
        '
        Me.closeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeButton.Location = New System.Drawing.Point(530, 481)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(223, 39)
        Me.closeButton.TabIndex = 10
        Me.closeButton.Text = "Close"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'resetButton
        '
        Me.resetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetButton.Location = New System.Drawing.Point(301, 481)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(180, 39)
        Me.resetButton.TabIndex = 9
        Me.resetButton.Text = "Reset Form"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'arrivalTextBox
        '
        Me.arrivalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arrivalTextBox.Location = New System.Drawing.Point(207, 31)
        Me.arrivalTextBox.Name = "arrivalTextBox"
        Me.arrivalTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.arrivalTextBox.Size = New System.Drawing.Size(133, 32)
        Me.arrivalTextBox.TabIndex = 1
        '
        'bigTextBox
        '
        Me.bigTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bigTextBox.Location = New System.Drawing.Point(29, 254)
        Me.bigTextBox.Multiline = True
        Me.bigTextBox.Name = "bigTextBox"
        Me.bigTextBox.ReadOnly = True
        Me.bigTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.bigTextBox.Size = New System.Drawing.Size(724, 190)
        Me.bigTextBox.TabIndex = 8
        '
        'systemTextBox
        '
        Me.systemTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.systemTextBox.Location = New System.Drawing.Point(207, 161)
        Me.systemTextBox.Name = "systemTextBox"
        Me.systemTextBox.Size = New System.Drawing.Size(133, 32)
        Me.systemTextBox.TabIndex = 6
        '
        'serviceTextBox
        '
        Me.serviceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serviceTextBox.Location = New System.Drawing.Point(207, 96)
        Me.serviceTextBox.Name = "serviceTextBox"
        Me.serviceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.serviceTextBox.Size = New System.Drawing.Size(133, 32)
        Me.serviceTextBox.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(800, 546)
        Me.Controls.Add(Me.serviceTextBox)
        Me.Controls.Add(Me.systemTextBox)
        Me.Controls.Add(Me.bigTextBox)
        Me.Controls.Add(Me.arrivalTextBox)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.simulateButton)
        Me.Controls.Add(Me.serviceLabel)
        Me.Controls.Add(Me.systemLabel)
        Me.Controls.Add(Me.lightLabel)
        Me.Controls.Add(Me.arrivalLabel)
        Me.Name = "Form1"
        Me.Text = "Waiting Line Simulation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents arrivalLabel As Label
    Friend WithEvents lightLabel As Label
    Friend WithEvents systemLabel As Label
    Friend WithEvents serviceLabel As Label
    Friend WithEvents simulateButton As Button
    Friend WithEvents closeButton As Button
    Friend WithEvents resetButton As Button
    Friend WithEvents arrivalTextBox As TextBox
    Friend WithEvents bigTextBox As TextBox
    Friend WithEvents systemTextBox As TextBox
    Friend WithEvents serviceTextBox As TextBox
End Class
