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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SimulationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunSimToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetSimToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.simulationGroupBox = New System.Windows.Forms.GroupBox()
        Me.testTextBox = New System.Windows.Forms.TextBox()
        Me.defectTextBox = New System.Windows.Forms.TextBox()
        Me.persentLabel = New System.Windows.Forms.Label()
        Me.persent1Label = New System.Windows.Forms.Label()
        Me.testLabel = New System.Windows.Forms.Label()
        Me.defectLabel = New System.Windows.Forms.Label()
        Me.numberLabel = New System.Windows.Forms.Label()
        Me.numberTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.simulationGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SimulationToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(11, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(367, 32)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SimulationToolStripMenuItem
        '
        Me.SimulationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunSimToolStripMenuItem, Me.ResetSimToolStripMenuItem})
        Me.SimulationToolStripMenuItem.Name = "SimulationToolStripMenuItem"
        Me.SimulationToolStripMenuItem.Size = New System.Drawing.Size(92, 24)
        Me.SimulationToolStripMenuItem.Text = "&Simulation"
        '
        'RunSimToolStripMenuItem
        '
        Me.RunSimToolStripMenuItem.Name = "RunSimToolStripMenuItem"
        Me.RunSimToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.RunSimToolStripMenuItem.Text = "&Run Sim"
        '
        'ResetSimToolStripMenuItem
        '
        Me.ResetSimToolStripMenuItem.Name = "ResetSimToolStripMenuItem"
        Me.ResetSimToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.ResetSimToolStripMenuItem.Text = "R&eset Sim"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(45, 24)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'simulationGroupBox
        '
        Me.simulationGroupBox.Controls.Add(Me.testTextBox)
        Me.simulationGroupBox.Controls.Add(Me.defectTextBox)
        Me.simulationGroupBox.Controls.Add(Me.persentLabel)
        Me.simulationGroupBox.Controls.Add(Me.persent1Label)
        Me.simulationGroupBox.Controls.Add(Me.testLabel)
        Me.simulationGroupBox.Controls.Add(Me.defectLabel)
        Me.simulationGroupBox.Controls.Add(Me.numberLabel)
        Me.simulationGroupBox.Controls.Add(Me.numberTextBox)
        Me.simulationGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.simulationGroupBox.ForeColor = System.Drawing.Color.White
        Me.simulationGroupBox.Location = New System.Drawing.Point(15, 49)
        Me.simulationGroupBox.Margin = New System.Windows.Forms.Padding(6)
        Me.simulationGroupBox.Name = "simulationGroupBox"
        Me.simulationGroupBox.Padding = New System.Windows.Forms.Padding(6)
        Me.simulationGroupBox.Size = New System.Drawing.Size(322, 196)
        Me.simulationGroupBox.TabIndex = 1
        Me.simulationGroupBox.TabStop = False
        Me.simulationGroupBox.Text = "Simulation Settings"
        '
        'testTextBox
        '
        Me.testTextBox.Location = New System.Drawing.Point(183, 148)
        Me.testTextBox.Name = "testTextBox"
        Me.testTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.testTextBox.Size = New System.Drawing.Size(100, 29)
        Me.testTextBox.TabIndex = 6
        '
        'defectTextBox
        '
        Me.defectTextBox.Location = New System.Drawing.Point(183, 93)
        Me.defectTextBox.Name = "defectTextBox"
        Me.defectTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.defectTextBox.Size = New System.Drawing.Size(100, 29)
        Me.defectTextBox.TabIndex = 3
        '
        'persentLabel
        '
        Me.persentLabel.AutoSize = True
        Me.persentLabel.Location = New System.Drawing.Point(289, 96)
        Me.persentLabel.Name = "persentLabel"
        Me.persentLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.persentLabel.Size = New System.Drawing.Size(25, 24)
        Me.persentLabel.TabIndex = 4
        Me.persentLabel.Text = "%"
        '
        'persent1Label
        '
        Me.persent1Label.AutoSize = True
        Me.persent1Label.Location = New System.Drawing.Point(289, 151)
        Me.persent1Label.Name = "persent1Label"
        Me.persent1Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.persent1Label.Size = New System.Drawing.Size(25, 24)
        Me.persent1Label.TabIndex = 7
        Me.persent1Label.Text = "%"
        '
        'testLabel
        '
        Me.testLabel.AutoSize = True
        Me.testLabel.Location = New System.Drawing.Point(21, 151)
        Me.testLabel.Name = "testLabel"
        Me.testLabel.Size = New System.Drawing.Size(135, 24)
        Me.testLabel.TabIndex = 5
        Me.testLabel.Text = "Test Accuracy:"
        '
        'defectLabel
        '
        Me.defectLabel.AutoSize = True
        Me.defectLabel.Location = New System.Drawing.Point(21, 96)
        Me.defectLabel.Name = "defectLabel"
        Me.defectLabel.Size = New System.Drawing.Size(111, 24)
        Me.defectLabel.TabIndex = 2
        Me.defectLabel.Text = "Defect Rate:"
        '
        'numberLabel
        '
        Me.numberLabel.AutoSize = True
        Me.numberLabel.Location = New System.Drawing.Point(21, 41)
        Me.numberLabel.Name = "numberLabel"
        Me.numberLabel.Size = New System.Drawing.Size(154, 24)
        Me.numberLabel.TabIndex = 0
        Me.numberLabel.Text = "Number of Trials:"
        '
        'numberTextBox
        '
        Me.numberTextBox.Location = New System.Drawing.Point(183, 41)
        Me.numberTextBox.Name = "numberTextBox"
        Me.numberTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.numberTextBox.Size = New System.Drawing.Size(100, 29)
        Me.numberTextBox.TabIndex = 1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlueViolet
        Me.ClientSize = New System.Drawing.Size(367, 271)
        Me.Controls.Add(Me.simulationGroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "MainForm"
        Me.Text = "LAP 5 - Monte Carlo Simulation"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.simulationGroupBox.ResumeLayout(False)
        Me.simulationGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SimulationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RunSimToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetSimToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents simulationGroupBox As GroupBox
    Friend WithEvents testTextBox As TextBox
    Friend WithEvents defectTextBox As TextBox
    Friend WithEvents persentLabel As Label
    Friend WithEvents persent1Label As Label
    Friend WithEvents testLabel As Label
    Friend WithEvents defectLabel As Label
    Friend WithEvents numberLabel As Label
    Friend WithEvents numberTextBox As TextBox
End Class
