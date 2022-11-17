<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OutputForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SimulationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RerunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.simulationGroupBox = New System.Windows.Forms.GroupBox()
        Me.falseLabel = New System.Windows.Forms.Label()
        Me.falseTextBox = New System.Windows.Forms.TextBox()
        Me.identifiedLabel = New System.Windows.Forms.Label()
        Me.identifiedTextBox = New System.Windows.Forms.TextBox()
        Me.defectiveLabel = New System.Windows.Forms.Label()
        Me.defectiveTextBox = New System.Windows.Forms.TextBox()
        Me.goodLabel = New System.Windows.Forms.Label()
        Me.goodTextBox = New System.Windows.Forms.TextBox()
        Me.productsLabel = New System.Windows.Forms.Label()
        Me.productsTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.simulationGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SimulationToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(523, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SimulationToolStripMenuItem
        '
        Me.SimulationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RerunToolStripMenuItem})
        Me.SimulationToolStripMenuItem.Name = "SimulationToolStripMenuItem"
        Me.SimulationToolStripMenuItem.Size = New System.Drawing.Size(92, 24)
        Me.SimulationToolStripMenuItem.Text = "&Simulation"
        '
        'RerunToolStripMenuItem
        '
        Me.RerunToolStripMenuItem.Name = "RerunToolStripMenuItem"
        Me.RerunToolStripMenuItem.Size = New System.Drawing.Size(145, 24)
        Me.RerunToolStripMenuItem.Text = "&Rerun Sim"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.CloseToolStripMenuItem.Text = "&Close"
        '
        'simulationGroupBox
        '
        Me.simulationGroupBox.Controls.Add(Me.falseLabel)
        Me.simulationGroupBox.Controls.Add(Me.falseTextBox)
        Me.simulationGroupBox.Controls.Add(Me.identifiedLabel)
        Me.simulationGroupBox.Controls.Add(Me.identifiedTextBox)
        Me.simulationGroupBox.Controls.Add(Me.defectiveLabel)
        Me.simulationGroupBox.Controls.Add(Me.defectiveTextBox)
        Me.simulationGroupBox.Controls.Add(Me.goodLabel)
        Me.simulationGroupBox.Controls.Add(Me.goodTextBox)
        Me.simulationGroupBox.Controls.Add(Me.productsLabel)
        Me.simulationGroupBox.Controls.Add(Me.productsTextBox)
        Me.simulationGroupBox.ForeColor = System.Drawing.Color.White
        Me.simulationGroupBox.Location = New System.Drawing.Point(52, 52)
        Me.simulationGroupBox.Name = "simulationGroupBox"
        Me.simulationGroupBox.Size = New System.Drawing.Size(419, 347)
        Me.simulationGroupBox.TabIndex = 1
        Me.simulationGroupBox.TabStop = False
        Me.simulationGroupBox.Text = "Simulation Results"
        '
        'falseLabel
        '
        Me.falseLabel.AutoSize = True
        Me.falseLabel.Location = New System.Drawing.Point(20, 291)
        Me.falseLabel.Name = "falseLabel"
        Me.falseLabel.Size = New System.Drawing.Size(130, 24)
        Me.falseLabel.TabIndex = 9
        Me.falseLabel.Text = "False Positive:"
        '
        'falseTextBox
        '
        Me.falseTextBox.Location = New System.Drawing.Point(226, 291)
        Me.falseTextBox.Name = "falseTextBox"
        Me.falseTextBox.ReadOnly = True
        Me.falseTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.falseTextBox.Size = New System.Drawing.Size(122, 29)
        Me.falseTextBox.TabIndex = 8
        '
        'identifiedLabel
        '
        Me.identifiedLabel.AutoSize = True
        Me.identifiedLabel.Location = New System.Drawing.Point(20, 230)
        Me.identifiedLabel.Name = "identifiedLabel"
        Me.identifiedLabel.Size = New System.Drawing.Size(157, 24)
        Me.identifiedLabel.TabIndex = 7
        Me.identifiedLabel.Text = "Identified Defects:"
        '
        'identifiedTextBox
        '
        Me.identifiedTextBox.Location = New System.Drawing.Point(226, 230)
        Me.identifiedTextBox.Name = "identifiedTextBox"
        Me.identifiedTextBox.ReadOnly = True
        Me.identifiedTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.identifiedTextBox.Size = New System.Drawing.Size(122, 29)
        Me.identifiedTextBox.TabIndex = 6
        '
        'defectiveLabel
        '
        Me.defectiveLabel.AutoSize = True
        Me.defectiveLabel.Location = New System.Drawing.Point(20, 166)
        Me.defectiveLabel.Name = "defectiveLabel"
        Me.defectiveLabel.Size = New System.Drawing.Size(171, 24)
        Me.defectiveLabel.TabIndex = 5
        Me.defectiveLabel.Text = "Defective Products:"
        '
        'defectiveTextBox
        '
        Me.defectiveTextBox.Location = New System.Drawing.Point(226, 166)
        Me.defectiveTextBox.Name = "defectiveTextBox"
        Me.defectiveTextBox.ReadOnly = True
        Me.defectiveTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.defectiveTextBox.Size = New System.Drawing.Size(122, 29)
        Me.defectiveTextBox.TabIndex = 4
        '
        'goodLabel
        '
        Me.goodLabel.AutoSize = True
        Me.goodLabel.Location = New System.Drawing.Point(20, 109)
        Me.goodLabel.Name = "goodLabel"
        Me.goodLabel.Size = New System.Drawing.Size(141, 24)
        Me.goodLabel.TabIndex = 3
        Me.goodLabel.Text = "Good Products:"
        '
        'goodTextBox
        '
        Me.goodTextBox.Location = New System.Drawing.Point(226, 104)
        Me.goodTextBox.Name = "goodTextBox"
        Me.goodTextBox.ReadOnly = True
        Me.goodTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.goodTextBox.Size = New System.Drawing.Size(122, 29)
        Me.goodTextBox.TabIndex = 2
        '
        'productsLabel
        '
        Me.productsLabel.AutoSize = True
        Me.productsLabel.Location = New System.Drawing.Point(20, 49)
        Me.productsLabel.Name = "productsLabel"
        Me.productsLabel.Size = New System.Drawing.Size(142, 24)
        Me.productsLabel.TabIndex = 1
        Me.productsLabel.Text = "Products Made:"
        '
        'productsTextBox
        '
        Me.productsTextBox.Location = New System.Drawing.Point(226, 44)
        Me.productsTextBox.Name = "productsTextBox"
        Me.productsTextBox.ReadOnly = True
        Me.productsTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.productsTextBox.Size = New System.Drawing.Size(122, 29)
        Me.productsTextBox.TabIndex = 0
        '
        'OutputForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkMagenta
        Me.ClientSize = New System.Drawing.Size(523, 437)
        Me.Controls.Add(Me.simulationGroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "OutputForm"
        Me.Text = "Simulation Results"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.simulationGroupBox.ResumeLayout(False)
        Me.simulationGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SimulationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RerunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents simulationGroupBox As GroupBox
    Friend WithEvents falseLabel As Label
    Friend WithEvents falseTextBox As TextBox
    Friend WithEvents identifiedLabel As Label
    Friend WithEvents identifiedTextBox As TextBox
    Friend WithEvents defectiveLabel As Label
    Friend WithEvents defectiveTextBox As TextBox
    Friend WithEvents goodLabel As Label
    Friend WithEvents goodTextBox As TextBox
    Friend WithEvents productsLabel As Label
    Friend WithEvents productsTextBox As TextBox
End Class
