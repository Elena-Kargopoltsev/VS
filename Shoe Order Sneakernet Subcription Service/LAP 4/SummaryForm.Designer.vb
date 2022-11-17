<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
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
        Me.summTextBox = New System.Windows.Forms.TextBox()
        Me.confirmButton = New System.Windows.Forms.Button()
        Me.backButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'summTextBox
        '
        Me.summTextBox.Location = New System.Drawing.Point(27, 15)
        Me.summTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.summTextBox.Multiline = True
        Me.summTextBox.Name = "summTextBox"
        Me.summTextBox.ReadOnly = True
        Me.summTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.summTextBox.Size = New System.Drawing.Size(446, 318)
        Me.summTextBox.TabIndex = 0
        '
        'confirmButton
        '
        Me.confirmButton.Location = New System.Drawing.Point(27, 363)
        Me.confirmButton.Name = "confirmButton"
        Me.confirmButton.Size = New System.Drawing.Size(201, 43)
        Me.confirmButton.TabIndex = 1
        Me.confirmButton.Text = "Confirm Order"
        Me.confirmButton.UseVisualStyleBackColor = True
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(256, 363)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(195, 43)
        Me.backButton.TabIndex = 2
        Me.backButton.Text = "Back to Main Form"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(497, 499)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.confirmButton)
        Me.Controls.Add(Me.summTextBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "SummaryForm"
        Me.Text = "Order_Summary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents summTextBox As TextBox
    Friend WithEvents confirmButton As Button
    Friend WithEvents backButton As Button
End Class
