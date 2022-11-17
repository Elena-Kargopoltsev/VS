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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GamesDataSet = New LAP_6.GamesDataSet()
        Me.TblGamesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblGamesTableAdapter = New LAP_6.GamesDataSetTableAdapters.tblGamesTableAdapter()
        Me.TableAdapterManager = New LAP_6.GamesDataSetTableAdapters.TableAdapterManager()
        Me.TblGamesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblGamesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblGamesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.filterGroupBox = New System.Windows.Forms.GroupBox()
        Me.genreComboBox = New System.Windows.Forms.ComboBox()
        Me.typeComboBox = New System.Windows.Forms.ComboBox()
        Me.maximumComboBox = New System.Windows.Forms.ComboBox()
        Me.genreLabel = New System.Windows.Forms.Label()
        Me.maximumLabel = New System.Windows.Forms.Label()
        Me.typeLabel = New System.Windows.Forms.Label()
        Me.minimumComboBox = New System.Windows.Forms.ComboBox()
        Me.minimumLabel = New System.Windows.Forms.Label()
        Me.summaryTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.GamesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblGamesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblGamesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblGamesBindingNavigator.SuspendLayout()
        CType(Me.TblGamesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.filterGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1346, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.ResetToolStripMenuItem.Text = "&Reset"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(45, 24)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'GamesDataSet
        '
        Me.GamesDataSet.DataSetName = "GamesDataSet"
        Me.GamesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblGamesBindingSource
        '
        Me.TblGamesBindingSource.DataMember = "tblGames"
        Me.TblGamesBindingSource.DataSource = Me.GamesDataSet
        '
        'TblGamesTableAdapter
        '
        Me.TblGamesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblGamesTableAdapter = Me.TblGamesTableAdapter
        Me.TableAdapterManager.UpdateOrder = LAP_6.GamesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblGamesBindingNavigator
        '
        Me.TblGamesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblGamesBindingNavigator.BindingSource = Me.TblGamesBindingSource
        Me.TblGamesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblGamesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblGamesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblGamesBindingNavigatorSaveItem})
        Me.TblGamesBindingNavigator.Location = New System.Drawing.Point(0, 28)
        Me.TblGamesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblGamesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblGamesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblGamesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblGamesBindingNavigator.Name = "TblGamesBindingNavigator"
        Me.TblGamesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblGamesBindingNavigator.Size = New System.Drawing.Size(1346, 27)
        Me.TblGamesBindingNavigator.TabIndex = 1
        Me.TblGamesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'TblGamesBindingNavigatorSaveItem
        '
        Me.TblGamesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblGamesBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblGamesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblGamesBindingNavigatorSaveItem.Name = "TblGamesBindingNavigatorSaveItem"
        Me.TblGamesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.TblGamesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblGamesDataGridView
        '
        Me.TblGamesDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TblGamesDataGridView.AutoGenerateColumns = False
        Me.TblGamesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblGamesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.TblGamesDataGridView.DataSource = Me.TblGamesBindingSource
        Me.TblGamesDataGridView.Location = New System.Drawing.Point(12, 58)
        Me.TblGamesDataGridView.Name = "TblGamesDataGridView"
        Me.TblGamesDataGridView.Size = New System.Drawing.Size(1300, 194)
        Me.TblGamesDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Game "
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Type"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Genre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Genre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "YearRelease"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Year Release"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NumMinPlayers"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Minimum Players"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NumMaxPlayers"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Maximum Players"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'filterGroupBox
        '
        Me.filterGroupBox.Controls.Add(Me.genreComboBox)
        Me.filterGroupBox.Controls.Add(Me.typeComboBox)
        Me.filterGroupBox.Controls.Add(Me.maximumComboBox)
        Me.filterGroupBox.Controls.Add(Me.genreLabel)
        Me.filterGroupBox.Controls.Add(Me.maximumLabel)
        Me.filterGroupBox.Controls.Add(Me.typeLabel)
        Me.filterGroupBox.Controls.Add(Me.minimumComboBox)
        Me.filterGroupBox.Controls.Add(Me.minimumLabel)
        Me.filterGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filterGroupBox.Location = New System.Drawing.Point(12, 282)
        Me.filterGroupBox.Name = "filterGroupBox"
        Me.filterGroupBox.Size = New System.Drawing.Size(1300, 86)
        Me.filterGroupBox.TabIndex = 3
        Me.filterGroupBox.TabStop = False
        Me.filterGroupBox.Text = "Game Filter"
        '
        'genreComboBox
        '
        Me.genreComboBox.FormattingEnabled = True
        Me.genreComboBox.IntegralHeight = False
        Me.genreComboBox.Items.AddRange(New Object() {"Co-op", "Fighting", "FPS", "Horror", "Open World", "Party", "Platformer", "Racing", "Roll and Move", "RPG", "Sandbox", "Strategy", "Trick Taking"})
        Me.genreComboBox.Location = New System.Drawing.Point(958, 36)
        Me.genreComboBox.MaxDropDownItems = 6
        Me.genreComboBox.Name = "genreComboBox"
        Me.genreComboBox.Size = New System.Drawing.Size(121, 28)
        Me.genreComboBox.TabIndex = 7
        '
        'typeComboBox
        '
        Me.typeComboBox.FormattingEnabled = True
        Me.typeComboBox.IntegralHeight = False
        Me.typeComboBox.Items.AddRange(New Object() {"Video Game", "Board Game", "Card Game"})
        Me.typeComboBox.Location = New System.Drawing.Point(767, 36)
        Me.typeComboBox.MaxDropDownItems = 6
        Me.typeComboBox.Name = "typeComboBox"
        Me.typeComboBox.Size = New System.Drawing.Size(121, 28)
        Me.typeComboBox.TabIndex = 5
        '
        'maximumComboBox
        '
        Me.maximumComboBox.FormattingEnabled = True
        Me.maximumComboBox.IntegralHeight = False
        Me.maximumComboBox.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.maximumComboBox.Location = New System.Drawing.Point(577, 36)
        Me.maximumComboBox.MaxDropDownItems = 6
        Me.maximumComboBox.Name = "maximumComboBox"
        Me.maximumComboBox.Size = New System.Drawing.Size(121, 28)
        Me.maximumComboBox.TabIndex = 3
        '
        'genreLabel
        '
        Me.genreLabel.AutoSize = True
        Me.genreLabel.Location = New System.Drawing.Point(894, 42)
        Me.genreLabel.Name = "genreLabel"
        Me.genreLabel.Size = New System.Drawing.Size(58, 20)
        Me.genreLabel.TabIndex = 6
        Me.genreLabel.Text = "Genre:"
        '
        'maximumLabel
        '
        Me.maximumLabel.AutoSize = True
        Me.maximumLabel.Location = New System.Drawing.Point(358, 36)
        Me.maximumLabel.Name = "maximumLabel"
        Me.maximumLabel.Size = New System.Drawing.Size(213, 20)
        Me.maximumLabel.TabIndex = 2
        Me.maximumLabel.Text = "Maximum Number of Players:"
        '
        'typeLabel
        '
        Me.typeLabel.AutoSize = True
        Me.typeLabel.Location = New System.Drawing.Point(714, 42)
        Me.typeLabel.Name = "typeLabel"
        Me.typeLabel.Size = New System.Drawing.Size(47, 20)
        Me.typeLabel.TabIndex = 4
        Me.typeLabel.Text = "Type:"
        '
        'minimumComboBox
        '
        Me.minimumComboBox.FormattingEnabled = True
        Me.minimumComboBox.IntegralHeight = False
        Me.minimumComboBox.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.minimumComboBox.Location = New System.Drawing.Point(231, 36)
        Me.minimumComboBox.MaxDropDownItems = 6
        Me.minimumComboBox.Name = "minimumComboBox"
        Me.minimumComboBox.Size = New System.Drawing.Size(121, 28)
        Me.minimumComboBox.TabIndex = 1
        '
        'minimumLabel
        '
        Me.minimumLabel.AutoSize = True
        Me.minimumLabel.Location = New System.Drawing.Point(16, 39)
        Me.minimumLabel.Name = "minimumLabel"
        Me.minimumLabel.Size = New System.Drawing.Size(209, 20)
        Me.minimumLabel.TabIndex = 0
        Me.minimumLabel.Text = "Minimum Number of Players:"
        '
        'summaryTextBox
        '
        Me.summaryTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.summaryTextBox.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.summaryTextBox.Location = New System.Drawing.Point(12, 388)
        Me.summaryTextBox.Multiline = True
        Me.summaryTextBox.Name = "summaryTextBox"
        Me.summaryTextBox.ReadOnly = True
        Me.summaryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.summaryTextBox.Size = New System.Drawing.Size(1300, 145)
        Me.summaryTextBox.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1346, 545)
        Me.Controls.Add(Me.summaryTextBox)
        Me.Controls.Add(Me.filterGroupBox)
        Me.Controls.Add(Me.TblGamesDataGridView)
        Me.Controls.Add(Me.TblGamesBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "LAP 6 - Game App"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.GamesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblGamesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblGamesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblGamesBindingNavigator.ResumeLayout(False)
        Me.TblGamesBindingNavigator.PerformLayout()
        CType(Me.TblGamesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.filterGroupBox.ResumeLayout(False)
        Me.filterGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GamesDataSet As GamesDataSet
    Friend WithEvents TblGamesBindingSource As BindingSource
    Friend WithEvents TblGamesTableAdapter As GamesDataSetTableAdapters.tblGamesTableAdapter
    Friend WithEvents TableAdapterManager As GamesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblGamesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TblGamesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TblGamesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents filterGroupBox As GroupBox
    Friend WithEvents genreComboBox As ComboBox
    Friend WithEvents typeComboBox As ComboBox
    Friend WithEvents maximumComboBox As ComboBox
    Friend WithEvents genreLabel As Label
    Friend WithEvents maximumLabel As Label
    Friend WithEvents typeLabel As Label
    Friend WithEvents minimumComboBox As ComboBox
    Friend WithEvents minimumLabel As Label
    Friend WithEvents summaryTextBox As TextBox
End Class
