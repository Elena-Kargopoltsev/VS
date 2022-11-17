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
        Me.amountLabel = New System.Windows.Forms.Label()
        Me.amountTextBox = New System.Windows.Forms.TextBox()
        Me.bitcoinexchangerateTextBox = New System.Windows.Forms.TextBox()
        Me.poundexchangefeeTextBox = New System.Windows.Forms.TextBox()
        Me.eurosexchangfeeTextBox = New System.Windows.Forms.TextBox()
        Me.bitcoinamountTextBox = New System.Windows.Forms.TextBox()
        Me.yenamountTextBox = New System.Windows.Forms.TextBox()
        Me.poundsamountTextBox = New System.Windows.Forms.TextBox()
        Me.eurosamountTextBox = New System.Windows.Forms.TextBox()
        Me.conversionTextBox = New System.Windows.Forms.TextBox()
        Me.yenexchangerateTextBox = New System.Windows.Forms.TextBox()
        Me.poundexchangerateTextBox = New System.Windows.Forms.TextBox()
        Me.eurosexchangerateTextBox = New System.Windows.Forms.TextBox()
        Me.bitcoinexchangefeeTextBox = New System.Windows.Forms.TextBox()
        Me.yenexchangefeeTextBox = New System.Windows.Forms.TextBox()
        Me.poundsLabel = New System.Windows.Forms.Label()
        Me.eurosLabel = New System.Windows.Forms.Label()
        Me.procentLabel = New System.Windows.Forms.Label()
        Me.conversionLabel = New System.Windows.Forms.Label()
        Me.exchangefeeLabel = New System.Windows.Forms.Label()
        Me.bitcoinLabel = New System.Windows.Forms.Label()
        Me.yenLabel = New System.Windows.Forms.Label()
        Me.exchangerateLabel = New System.Windows.Forms.Label()
        Me.lessfeeLabel = New System.Windows.Forms.Label()
        Me.plasButton = New System.Windows.Forms.Button()
        Me.minusButton = New System.Windows.Forms.Button()
        Me.exitapplicationButton = New System.Windows.Forms.Button()
        Me.resetformButton = New System.Windows.Forms.Button()
        Me.convertcurrencyButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'amountLabel
        '
        Me.amountLabel.AutoSize = True
        Me.amountLabel.Location = New System.Drawing.Point(25, 53)
        Me.amountLabel.Name = "amountLabel"
        Me.amountLabel.Size = New System.Drawing.Size(118, 20)
        Me.amountLabel.TabIndex = 0
        Me.amountLabel.Text = "Amount (USD):"
        '
        'amountTextBox
        '
        Me.amountTextBox.Location = New System.Drawing.Point(161, 50)
        Me.amountTextBox.Name = "amountTextBox"
        Me.amountTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.amountTextBox.Size = New System.Drawing.Size(163, 26)
        Me.amountTextBox.TabIndex = 1
        '
        'bitcoinexchangerateTextBox
        '
        Me.bitcoinexchangerateTextBox.Location = New System.Drawing.Point(349, 308)
        Me.bitcoinexchangerateTextBox.Name = "bitcoinexchangerateTextBox"
        Me.bitcoinexchangerateTextBox.ReadOnly = True
        Me.bitcoinexchangerateTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.bitcoinexchangerateTextBox.Size = New System.Drawing.Size(163, 26)
        Me.bitcoinexchangerateTextBox.TabIndex = 24
        '
        'poundexchangefeeTextBox
        '
        Me.poundexchangefeeTextBox.Location = New System.Drawing.Point(544, 218)
        Me.poundexchangefeeTextBox.Name = "poundexchangefeeTextBox"
        Me.poundexchangefeeTextBox.ReadOnly = True
        Me.poundexchangefeeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.poundexchangefeeTextBox.Size = New System.Drawing.Size(163, 26)
        Me.poundexchangefeeTextBox.TabIndex = 17
        '
        'eurosexchangfeeTextBox
        '
        Me.eurosexchangfeeTextBox.Location = New System.Drawing.Point(544, 175)
        Me.eurosexchangfeeTextBox.Name = "eurosexchangfeeTextBox"
        Me.eurosexchangfeeTextBox.ReadOnly = True
        Me.eurosexchangfeeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.eurosexchangfeeTextBox.Size = New System.Drawing.Size(163, 26)
        Me.eurosexchangfeeTextBox.TabIndex = 13
        '
        'bitcoinamountTextBox
        '
        Me.bitcoinamountTextBox.Location = New System.Drawing.Point(156, 305)
        Me.bitcoinamountTextBox.Name = "bitcoinamountTextBox"
        Me.bitcoinamountTextBox.ReadOnly = True
        Me.bitcoinamountTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.bitcoinamountTextBox.Size = New System.Drawing.Size(163, 26)
        Me.bitcoinamountTextBox.TabIndex = 23
        '
        'yenamountTextBox
        '
        Me.yenamountTextBox.Location = New System.Drawing.Point(156, 263)
        Me.yenamountTextBox.Name = "yenamountTextBox"
        Me.yenamountTextBox.ReadOnly = True
        Me.yenamountTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.yenamountTextBox.Size = New System.Drawing.Size(163, 26)
        Me.yenamountTextBox.TabIndex = 19
        '
        'poundsamountTextBox
        '
        Me.poundsamountTextBox.Location = New System.Drawing.Point(156, 221)
        Me.poundsamountTextBox.Name = "poundsamountTextBox"
        Me.poundsamountTextBox.ReadOnly = True
        Me.poundsamountTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.poundsamountTextBox.Size = New System.Drawing.Size(163, 26)
        Me.poundsamountTextBox.TabIndex = 15
        '
        'eurosamountTextBox
        '
        Me.eurosamountTextBox.Location = New System.Drawing.Point(156, 175)
        Me.eurosamountTextBox.Name = "eurosamountTextBox"
        Me.eurosamountTextBox.ReadOnly = True
        Me.eurosamountTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.eurosamountTextBox.Size = New System.Drawing.Size(163, 26)
        Me.eurosamountTextBox.TabIndex = 11
        '
        'conversionTextBox
        '
        Me.conversionTextBox.Location = New System.Drawing.Point(161, 93)
        Me.conversionTextBox.Name = "conversionTextBox"
        Me.conversionTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.conversionTextBox.Size = New System.Drawing.Size(163, 26)
        Me.conversionTextBox.TabIndex = 5
        '
        'yenexchangerateTextBox
        '
        Me.yenexchangerateTextBox.Location = New System.Drawing.Point(349, 266)
        Me.yenexchangerateTextBox.Name = "yenexchangerateTextBox"
        Me.yenexchangerateTextBox.ReadOnly = True
        Me.yenexchangerateTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.yenexchangerateTextBox.Size = New System.Drawing.Size(163, 26)
        Me.yenexchangerateTextBox.TabIndex = 20
        '
        'poundexchangerateTextBox
        '
        Me.poundexchangerateTextBox.Location = New System.Drawing.Point(349, 218)
        Me.poundexchangerateTextBox.Name = "poundexchangerateTextBox"
        Me.poundexchangerateTextBox.ReadOnly = True
        Me.poundexchangerateTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.poundexchangerateTextBox.Size = New System.Drawing.Size(163, 26)
        Me.poundexchangerateTextBox.TabIndex = 16
        '
        'eurosexchangerateTextBox
        '
        Me.eurosexchangerateTextBox.Location = New System.Drawing.Point(349, 175)
        Me.eurosexchangerateTextBox.Name = "eurosexchangerateTextBox"
        Me.eurosexchangerateTextBox.ReadOnly = True
        Me.eurosexchangerateTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.eurosexchangerateTextBox.Size = New System.Drawing.Size(163, 26)
        Me.eurosexchangerateTextBox.TabIndex = 12
        '
        'bitcoinexchangefeeTextBox
        '
        Me.bitcoinexchangefeeTextBox.Location = New System.Drawing.Point(544, 308)
        Me.bitcoinexchangefeeTextBox.Name = "bitcoinexchangefeeTextBox"
        Me.bitcoinexchangefeeTextBox.ReadOnly = True
        Me.bitcoinexchangefeeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.bitcoinexchangefeeTextBox.Size = New System.Drawing.Size(163, 26)
        Me.bitcoinexchangefeeTextBox.TabIndex = 25
        '
        'yenexchangefeeTextBox
        '
        Me.yenexchangefeeTextBox.Location = New System.Drawing.Point(544, 263)
        Me.yenexchangefeeTextBox.Name = "yenexchangefeeTextBox"
        Me.yenexchangefeeTextBox.ReadOnly = True
        Me.yenexchangefeeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.yenexchangefeeTextBox.Size = New System.Drawing.Size(163, 26)
        Me.yenexchangefeeTextBox.TabIndex = 21
        '
        'poundsLabel
        '
        Me.poundsLabel.AutoSize = True
        Me.poundsLabel.Location = New System.Drawing.Point(53, 224)
        Me.poundsLabel.Name = "poundsLabel"
        Me.poundsLabel.Size = New System.Drawing.Size(67, 20)
        Me.poundsLabel.TabIndex = 14
        Me.poundsLabel.Text = "Pounds:"
        '
        'eurosLabel
        '
        Me.eurosLabel.AutoSize = True
        Me.eurosLabel.Location = New System.Drawing.Point(53, 175)
        Me.eurosLabel.Name = "eurosLabel"
        Me.eurosLabel.Size = New System.Drawing.Size(55, 20)
        Me.eurosLabel.TabIndex = 10
        Me.eurosLabel.Text = "Euros:"
        '
        'procentLabel
        '
        Me.procentLabel.AutoSize = True
        Me.procentLabel.Location = New System.Drawing.Point(376, 99)
        Me.procentLabel.Name = "procentLabel"
        Me.procentLabel.Size = New System.Drawing.Size(207, 20)
        Me.procentLabel.TabIndex = 6
        Me.procentLabel.Text = "2% for ATM, 3% Credit Card"
        '
        'conversionLabel
        '
        Me.conversionLabel.AutoSize = True
        Me.conversionLabel.Location = New System.Drawing.Point(33, 99)
        Me.conversionLabel.Name = "conversionLabel"
        Me.conversionLabel.Size = New System.Drawing.Size(110, 20)
        Me.conversionLabel.TabIndex = 4
        Me.conversionLabel.Text = "Conversion %:"
        '
        'exchangefeeLabel
        '
        Me.exchangefeeLabel.AutoSize = True
        Me.exchangefeeLabel.Location = New System.Drawing.Point(595, 143)
        Me.exchangefeeLabel.Name = "exchangefeeLabel"
        Me.exchangefeeLabel.Size = New System.Drawing.Size(112, 20)
        Me.exchangefeeLabel.TabIndex = 9
        Me.exchangefeeLabel.Text = "Exchange Fee"
        '
        'bitcoinLabel
        '
        Me.bitcoinLabel.AutoSize = True
        Me.bitcoinLabel.Location = New System.Drawing.Point(53, 308)
        Me.bitcoinLabel.Name = "bitcoinLabel"
        Me.bitcoinLabel.Size = New System.Drawing.Size(61, 20)
        Me.bitcoinLabel.TabIndex = 22
        Me.bitcoinLabel.Text = "Bitcoin:"
        '
        'yenLabel
        '
        Me.yenLabel.AutoSize = True
        Me.yenLabel.Location = New System.Drawing.Point(53, 266)
        Me.yenLabel.Name = "yenLabel"
        Me.yenLabel.Size = New System.Drawing.Size(42, 20)
        Me.yenLabel.TabIndex = 18
        Me.yenLabel.Text = "Yen:"
        '
        'exchangerateLabel
        '
        Me.exchangerateLabel.AutoSize = True
        Me.exchangerateLabel.Location = New System.Drawing.Point(376, 143)
        Me.exchangerateLabel.Name = "exchangerateLabel"
        Me.exchangerateLabel.Size = New System.Drawing.Size(119, 20)
        Me.exchangerateLabel.TabIndex = 8
        Me.exchangerateLabel.Text = "Exchange Rate"
        '
        'lessfeeLabel
        '
        Me.lessfeeLabel.AutoSize = True
        Me.lessfeeLabel.Location = New System.Drawing.Point(157, 143)
        Me.lessfeeLabel.Name = "lessfeeLabel"
        Me.lessfeeLabel.Size = New System.Drawing.Size(141, 20)
        Me.lessfeeLabel.TabIndex = 7
        Me.lessfeeLabel.Text = "Amount(Less Fee)"
        '
        'plasButton
        '
        Me.plasButton.Location = New System.Drawing.Point(380, 38)
        Me.plasButton.Name = "plasButton"
        Me.plasButton.Size = New System.Drawing.Size(75, 38)
        Me.plasButton.TabIndex = 2
        Me.plasButton.Text = "+100"
        Me.plasButton.UseVisualStyleBackColor = True
        '
        'minusButton
        '
        Me.minusButton.Location = New System.Drawing.Point(493, 40)
        Me.minusButton.Name = "minusButton"
        Me.minusButton.Size = New System.Drawing.Size(75, 36)
        Me.minusButton.TabIndex = 3
        Me.minusButton.Text = "-100"
        Me.minusButton.UseVisualStyleBackColor = True
        '
        'exitapplicationButton
        '
        Me.exitapplicationButton.Location = New System.Drawing.Point(512, 372)
        Me.exitapplicationButton.Name = "exitapplicationButton"
        Me.exitapplicationButton.Size = New System.Drawing.Size(209, 56)
        Me.exitapplicationButton.TabIndex = 28
        Me.exitapplicationButton.Text = "Exit Application"
        Me.exitapplicationButton.UseVisualStyleBackColor = True
        '
        'resetformButton
        '
        Me.resetformButton.Location = New System.Drawing.Point(282, 372)
        Me.resetformButton.Name = "resetformButton"
        Me.resetformButton.Size = New System.Drawing.Size(193, 56)
        Me.resetformButton.TabIndex = 27
        Me.resetformButton.Text = "Reset Form"
        Me.resetformButton.UseVisualStyleBackColor = True
        '
        'convertcurrencyButton
        '
        Me.convertcurrencyButton.Location = New System.Drawing.Point(29, 372)
        Me.convertcurrencyButton.Name = "convertcurrencyButton"
        Me.convertcurrencyButton.Size = New System.Drawing.Size(217, 56)
        Me.convertcurrencyButton.TabIndex = 26
        Me.convertcurrencyButton.Text = "Convert Currency"
        Me.convertcurrencyButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(733, 456)
        Me.Controls.Add(Me.convertcurrencyButton)
        Me.Controls.Add(Me.resetformButton)
        Me.Controls.Add(Me.exitapplicationButton)
        Me.Controls.Add(Me.minusButton)
        Me.Controls.Add(Me.plasButton)
        Me.Controls.Add(Me.lessfeeLabel)
        Me.Controls.Add(Me.exchangerateLabel)
        Me.Controls.Add(Me.yenLabel)
        Me.Controls.Add(Me.bitcoinLabel)
        Me.Controls.Add(Me.exchangefeeLabel)
        Me.Controls.Add(Me.conversionLabel)
        Me.Controls.Add(Me.procentLabel)
        Me.Controls.Add(Me.eurosLabel)
        Me.Controls.Add(Me.poundsLabel)
        Me.Controls.Add(Me.yenexchangefeeTextBox)
        Me.Controls.Add(Me.bitcoinexchangefeeTextBox)
        Me.Controls.Add(Me.eurosexchangerateTextBox)
        Me.Controls.Add(Me.poundexchangerateTextBox)
        Me.Controls.Add(Me.yenexchangerateTextBox)
        Me.Controls.Add(Me.conversionTextBox)
        Me.Controls.Add(Me.eurosamountTextBox)
        Me.Controls.Add(Me.poundsamountTextBox)
        Me.Controls.Add(Me.yenamountTextBox)
        Me.Controls.Add(Me.bitcoinamountTextBox)
        Me.Controls.Add(Me.eurosexchangfeeTextBox)
        Me.Controls.Add(Me.poundexchangefeeTextBox)
        Me.Controls.Add(Me.bitcoinexchangerateTextBox)
        Me.Controls.Add(Me.amountTextBox)
        Me.Controls.Add(Me.amountLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Currency Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents amountLabel As Label
    Friend WithEvents amountTextBox As TextBox
    Friend WithEvents bitcoinexchangerateTextBox As TextBox
    Friend WithEvents poundexchangefeeTextBox As TextBox
    Friend WithEvents eurosexchangfeeTextBox As TextBox
    Friend WithEvents bitcoinamountTextBox As TextBox
    Friend WithEvents yenamountTextBox As TextBox
    Friend WithEvents poundsamountTextBox As TextBox
    Friend WithEvents eurosamountTextBox As TextBox
    Friend WithEvents conversionTextBox As TextBox
    Friend WithEvents yenexchangerateTextBox As TextBox
    Friend WithEvents poundexchangerateTextBox As TextBox
    Friend WithEvents eurosexchangerateTextBox As TextBox
    Friend WithEvents bitcoinexchangefeeTextBox As TextBox
    Friend WithEvents yenexchangefeeTextBox As TextBox
    Friend WithEvents poundsLabel As Label
    Friend WithEvents eurosLabel As Label
    Friend WithEvents procentLabel As Label
    Friend WithEvents conversionLabel As Label
    Friend WithEvents exchangefeeLabel As Label
    Friend WithEvents bitcoinLabel As Label
    Friend WithEvents yenLabel As Label
    Friend WithEvents exchangerateLabel As Label
    Friend WithEvents lessfeeLabel As Label
    Friend WithEvents plasButton As Button
    Friend WithEvents minusButton As Button
    Friend WithEvents exitapplicationButton As Button
    Friend WithEvents resetformButton As Button
    Friend WithEvents convertcurrencyButton As Button
End Class
