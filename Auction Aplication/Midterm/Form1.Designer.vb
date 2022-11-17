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
        Me.itemdesLabel = New System.Windows.Forms.Label()
        Me.plusButton = New System.Windows.Forms.Button()
        Me.auctionTextBox = New System.Windows.Forms.TextBox()
        Me.shippingTextBox = New System.Windows.Forms.TextBox()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.quantityLabel = New System.Windows.Forms.Label()
        Me.basepTextBox = New System.Windows.Forms.TextBox()
        Me.resetformButton = New System.Windows.Forms.Button()
        Me.basepriceLabel = New System.Windows.Forms.Label()
        Me.quantityTextBox = New System.Windows.Forms.TextBox()
        Me.minusButton = New System.Windows.Forms.Button()
        Me.shippingLabel = New System.Windows.Forms.Label()
        Me.itemTextBox = New System.Windows.Forms.TextBox()
        Me.addlistButton = New System.Windows.Forms.Button()
        Me.auctionLabel = New System.Windows.Forms.Label()
        Me.standartLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'itemdesLabel
        '
        Me.itemdesLabel.AutoSize = True
        Me.itemdesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemdesLabel.Location = New System.Drawing.Point(25, 47)
        Me.itemdesLabel.Name = "itemdesLabel"
        Me.itemdesLabel.Size = New System.Drawing.Size(176, 26)
        Me.itemdesLabel.TabIndex = 0
        Me.itemdesLabel.Text = "Item Description:"
        '
        'plusButton
        '
        Me.plusButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plusButton.Location = New System.Drawing.Point(389, 113)
        Me.plusButton.Name = "plusButton"
        Me.plusButton.Size = New System.Drawing.Size(82, 32)
        Me.plusButton.TabIndex = 4
        Me.plusButton.Text = "+1"
        Me.plusButton.UseVisualStyleBackColor = True
        '
        'auctionTextBox
        '
        Me.auctionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.auctionTextBox.Location = New System.Drawing.Point(30, 466)
        Me.auctionTextBox.Multiline = True
        Me.auctionTextBox.Name = "auctionTextBox"
        Me.auctionTextBox.ReadOnly = True
        Me.auctionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.auctionTextBox.Size = New System.Drawing.Size(714, 256)
        Me.auctionTextBox.TabIndex = 15
        '
        'shippingTextBox
        '
        Me.shippingTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shippingTextBox.Location = New System.Drawing.Point(233, 249)
        Me.shippingTextBox.Name = "shippingTextBox"
        Me.shippingTextBox.Size = New System.Drawing.Size(136, 32)
        Me.shippingTextBox.TabIndex = 9
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(518, 332)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(226, 43)
        Me.exitButton.TabIndex = 13
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'quantityLabel
        '
        Me.quantityLabel.AutoSize = True
        Me.quantityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantityLabel.Location = New System.Drawing.Point(25, 113)
        Me.quantityLabel.Name = "quantityLabel"
        Me.quantityLabel.Size = New System.Drawing.Size(99, 26)
        Me.quantityLabel.TabIndex = 2
        Me.quantityLabel.Text = "Quantity:"
        '
        'basepTextBox
        '
        Me.basepTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.basepTextBox.Location = New System.Drawing.Point(233, 180)
        Me.basepTextBox.Name = "basepTextBox"
        Me.basepTextBox.Size = New System.Drawing.Size(136, 32)
        Me.basepTextBox.TabIndex = 7
        '
        'resetformButton
        '
        Me.resetformButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetformButton.Location = New System.Drawing.Point(280, 332)
        Me.resetformButton.Name = "resetformButton"
        Me.resetformButton.Size = New System.Drawing.Size(215, 43)
        Me.resetformButton.TabIndex = 12
        Me.resetformButton.Text = "Reset Form"
        Me.resetformButton.UseVisualStyleBackColor = True
        '
        'basepriceLabel
        '
        Me.basepriceLabel.AutoSize = True
        Me.basepriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.basepriceLabel.Location = New System.Drawing.Point(25, 180)
        Me.basepriceLabel.Name = "basepriceLabel"
        Me.basepriceLabel.Size = New System.Drawing.Size(124, 26)
        Me.basepriceLabel.TabIndex = 6
        Me.basepriceLabel.Text = "Base Price:"
        '
        'quantityTextBox
        '
        Me.quantityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantityTextBox.Location = New System.Drawing.Point(233, 113)
        Me.quantityTextBox.Name = "quantityTextBox"
        Me.quantityTextBox.ReadOnly = True
        Me.quantityTextBox.Size = New System.Drawing.Size(136, 32)
        Me.quantityTextBox.TabIndex = 3
        '
        'minusButton
        '
        Me.minusButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minusButton.Location = New System.Drawing.Point(510, 113)
        Me.minusButton.Name = "minusButton"
        Me.minusButton.Size = New System.Drawing.Size(78, 32)
        Me.minusButton.TabIndex = 5
        Me.minusButton.Text = "-1"
        Me.minusButton.UseVisualStyleBackColor = True
        '
        'shippingLabel
        '
        Me.shippingLabel.AutoSize = True
        Me.shippingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shippingLabel.Location = New System.Drawing.Point(25, 249)
        Me.shippingLabel.Name = "shippingLabel"
        Me.shippingLabel.Size = New System.Drawing.Size(181, 26)
        Me.shippingLabel.TabIndex = 8
        Me.shippingLabel.Text = "Shipping Method:"
        '
        'itemTextBox
        '
        Me.itemTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemTextBox.Location = New System.Drawing.Point(233, 47)
        Me.itemTextBox.Name = "itemTextBox"
        Me.itemTextBox.Size = New System.Drawing.Size(511, 32)
        Me.itemTextBox.TabIndex = 1
        '
        'addlistButton
        '
        Me.addlistButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addlistButton.Location = New System.Drawing.Point(30, 332)
        Me.addlistButton.Name = "addlistButton"
        Me.addlistButton.Size = New System.Drawing.Size(235, 43)
        Me.addlistButton.TabIndex = 11
        Me.addlistButton.Text = "Add to List"
        Me.addlistButton.UseVisualStyleBackColor = True
        '
        'auctionLabel
        '
        Me.auctionLabel.AutoSize = True
        Me.auctionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.auctionLabel.Location = New System.Drawing.Point(25, 407)
        Me.auctionLabel.Name = "auctionLabel"
        Me.auctionLabel.Size = New System.Drawing.Size(125, 26)
        Me.auctionLabel.TabIndex = 14
        Me.auctionLabel.Text = "Auction List"
        '
        'standartLabel
        '
        Me.standartLabel.AutoSize = True
        Me.standartLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.standartLabel.Location = New System.Drawing.Point(384, 252)
        Me.standartLabel.Name = "standartLabel"
        Me.standartLabel.Size = New System.Drawing.Size(265, 26)
        Me.standartLabel.TabIndex = 10
        Me.standartLabel.Text = "Standart, Priority, Express"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(788, 779)
        Me.Controls.Add(Me.standartLabel)
        Me.Controls.Add(Me.itemTextBox)
        Me.Controls.Add(Me.addlistButton)
        Me.Controls.Add(Me.auctionLabel)
        Me.Controls.Add(Me.quantityTextBox)
        Me.Controls.Add(Me.minusButton)
        Me.Controls.Add(Me.shippingLabel)
        Me.Controls.Add(Me.basepTextBox)
        Me.Controls.Add(Me.resetformButton)
        Me.Controls.Add(Me.basepriceLabel)
        Me.Controls.Add(Me.shippingTextBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.quantityLabel)
        Me.Controls.Add(Me.auctionTextBox)
        Me.Controls.Add(Me.plusButton)
        Me.Controls.Add(Me.itemdesLabel)
        Me.Name = "Form1"
        Me.Text = "Spring 2021 Midterm Auction Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents itemdesLabel As Label
    Friend WithEvents plusButton As Button
    Friend WithEvents auctionTextBox As TextBox
    Friend WithEvents shippingTextBox As TextBox
    Friend WithEvents exitButton As Button
    Friend WithEvents quantityLabel As Label
    Friend WithEvents basepTextBox As TextBox
    Friend WithEvents resetformButton As Button
    Friend WithEvents basepriceLabel As Label
    Friend WithEvents quantityTextBox As TextBox
    Friend WithEvents minusButton As Button
    Friend WithEvents shippingLabel As Label
    Friend WithEvents itemTextBox As TextBox
    Friend WithEvents addlistButton As Button
    Friend WithEvents auctionLabel As Label
    Friend WithEvents standartLabel As Label
End Class
