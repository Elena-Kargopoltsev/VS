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
        Me.ProductListDataSet = New Final.ProductListDataSet()
        Me.TblProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProductsTableAdapter = New Final.ProductListDataSetTableAdapters.tblProductsTableAdapter()
        Me.TableAdapterManager = New Final.ProductListDataSetTableAdapters.TableAdapterManager()
        Me.TblProductsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblProductsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblProductsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RunROPReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.detailGroupBox = New System.Windows.Forms.GroupBox()
        Me.productLabel = New System.Windows.Forms.Label()
        Me.unitLabel = New System.Windows.Forms.Label()
        Me.unitorderLabel = New System.Windows.Forms.Label()
        Me.reorderLabel = New System.Windows.Forms.Label()
        Me.averageLabel = New System.Windows.Forms.Label()
        Me.lastButton = New System.Windows.Forms.Button()
        Me.firstButton = New System.Windows.Forms.Button()
        Me.previousButton = New System.Windows.Forms.Button()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.reorderTextBox = New System.Windows.Forms.TextBox()
        Me.stdLabel = New System.Windows.Forms.Label()
        Me.unitTextBox = New System.Windows.Forms.TextBox()
        Me.stdTextBox = New System.Windows.Forms.TextBox()
        Me.averageTextBox = New System.Windows.Forms.TextBox()
        Me.unitorderTextBox = New System.Windows.Forms.TextBox()
        Me.productTextBox = New System.Windows.Forms.TextBox()
        Me.reorderGroupBox = New System.Windows.Forms.GroupBox()
        Me.reorderpoLabel = New System.Windows.Forms.Label()
        Me.reorderpointLabel = New System.Windows.Forms.Label()
        Me.leadLabel = New System.Windows.Forms.Label()
        Me.serviceLabel = New System.Windows.Forms.Label()
        Me.standartLabel = New System.Windows.Forms.Label()
        Me.averLabel = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.transferproductButton = New System.Windows.Forms.Button()
        Me.leadComboBox = New System.Windows.Forms.ComboBox()
        Me.serviceComboBox = New System.Windows.Forms.ComboBox()
        Me.averTextBox = New System.Windows.Forms.TextBox()
        Me.standartTextBox = New System.Windows.Forms.TextBox()
        CType(Me.ProductListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblProductsBindingNavigator.SuspendLayout()
        CType(Me.TblProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.detailGroupBox.SuspendLayout()
        Me.reorderGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProductListDataSet
        '
        Me.ProductListDataSet.DataSetName = "ProductListDataSet"
        Me.ProductListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblProductsBindingSource
        '
        Me.TblProductsBindingSource.DataMember = "tblProducts"
        Me.TblProductsBindingSource.DataSource = Me.ProductListDataSet
        '
        'TblProductsTableAdapter
        '
        Me.TblProductsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblProductsTableAdapter = Me.TblProductsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Final.ProductListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblProductsBindingNavigator
        '
        Me.TblProductsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblProductsBindingNavigator.BindingSource = Me.TblProductsBindingSource
        Me.TblProductsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblProductsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblProductsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TblProductsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblProductsBindingNavigatorSaveItem})
        Me.TblProductsBindingNavigator.Location = New System.Drawing.Point(0, 682)
        Me.TblProductsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblProductsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblProductsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblProductsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblProductsBindingNavigator.Name = "TblProductsBindingNavigator"
        Me.TblProductsBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.TblProductsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblProductsBindingNavigator.Size = New System.Drawing.Size(1042, 27)
        Me.TblProductsBindingNavigator.TabIndex = 4
        Me.TblProductsBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(73, 27)
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
        'TblProductsBindingNavigatorSaveItem
        '
        Me.TblProductsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblProductsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblProductsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblProductsBindingNavigatorSaveItem.Name = "TblProductsBindingNavigatorSaveItem"
        Me.TblProductsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.TblProductsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblProductsDataGridView
        '
        Me.TblProductsDataGridView.AutoGenerateColumns = False
        Me.TblProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.TblProductsDataGridView.DataSource = Me.TblProductsBindingSource
        Me.TblProductsDataGridView.Location = New System.Drawing.Point(18, 452)
        Me.TblProductsDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TblProductsDataGridView.Name = "TblProductsDataGridView"
        Me.TblProductsDataGridView.Size = New System.Drawing.Size(983, 215)
        Me.TblProductsDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ProductID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ProductID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Product Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "QuantityPerUnit"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Qty Per Unit"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "UnitPrice"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Unit Price"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UnitsInStock"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Units In Stock"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UnitsOnOrder"
        Me.DataGridViewTextBoxColumn6.HeaderText = "On Order"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ReorderLevel"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Reorder Level"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "AverageDemandLT"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Average Demand"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "StandardDevLT"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Standard Deviation"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunROPReportToolStripMenuItem, Me.ClearFormToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1042, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RunROPReportToolStripMenuItem
        '
        Me.RunROPReportToolStripMenuItem.Name = "RunROPReportToolStripMenuItem"
        Me.RunROPReportToolStripMenuItem.Size = New System.Drawing.Size(127, 24)
        Me.RunROPReportToolStripMenuItem.Text = "&Run ROP Report"
        '
        'ClearFormToolStripMenuItem
        '
        Me.ClearFormToolStripMenuItem.Name = "ClearFormToolStripMenuItem"
        Me.ClearFormToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.ClearFormToolStripMenuItem.Text = "&Clear Form"
        '
        'detailGroupBox
        '
        Me.detailGroupBox.Controls.Add(Me.productLabel)
        Me.detailGroupBox.Controls.Add(Me.unitLabel)
        Me.detailGroupBox.Controls.Add(Me.unitorderLabel)
        Me.detailGroupBox.Controls.Add(Me.reorderLabel)
        Me.detailGroupBox.Controls.Add(Me.averageLabel)
        Me.detailGroupBox.Controls.Add(Me.lastButton)
        Me.detailGroupBox.Controls.Add(Me.firstButton)
        Me.detailGroupBox.Controls.Add(Me.previousButton)
        Me.detailGroupBox.Controls.Add(Me.nextButton)
        Me.detailGroupBox.Controls.Add(Me.reorderTextBox)
        Me.detailGroupBox.Controls.Add(Me.stdLabel)
        Me.detailGroupBox.Controls.Add(Me.unitTextBox)
        Me.detailGroupBox.Controls.Add(Me.stdTextBox)
        Me.detailGroupBox.Controls.Add(Me.averageTextBox)
        Me.detailGroupBox.Controls.Add(Me.unitorderTextBox)
        Me.detailGroupBox.Controls.Add(Me.productTextBox)
        Me.detailGroupBox.Location = New System.Drawing.Point(18, 60)
        Me.detailGroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.detailGroupBox.Name = "detailGroupBox"
        Me.detailGroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.detailGroupBox.Size = New System.Drawing.Size(474, 344)
        Me.detailGroupBox.TabIndex = 1
        Me.detailGroupBox.TabStop = False
        Me.detailGroupBox.Text = "Detail Product View"
        '
        'productLabel
        '
        Me.productLabel.AutoSize = True
        Me.productLabel.Location = New System.Drawing.Point(50, 30)
        Me.productLabel.Name = "productLabel"
        Me.productLabel.Size = New System.Drawing.Size(68, 20)
        Me.productLabel.TabIndex = 0
        Me.productLabel.Text = "Product:"
        '
        'unitLabel
        '
        Me.unitLabel.AutoSize = True
        Me.unitLabel.Location = New System.Drawing.Point(7, 72)
        Me.unitLabel.Name = "unitLabel"
        Me.unitLabel.Size = New System.Drawing.Size(111, 20)
        Me.unitLabel.TabIndex = 2
        Me.unitLabel.Text = "Units in Stock:"
        '
        'unitorderLabel
        '
        Me.unitorderLabel.AutoSize = True
        Me.unitorderLabel.Location = New System.Drawing.Point(2, 110)
        Me.unitorderLabel.Name = "unitorderLabel"
        Me.unitorderLabel.Size = New System.Drawing.Size(116, 20)
        Me.unitorderLabel.TabIndex = 4
        Me.unitorderLabel.Text = "Units on Order:"
        '
        'reorderLabel
        '
        Me.reorderLabel.AutoSize = True
        Me.reorderLabel.Location = New System.Drawing.Point(6, 154)
        Me.reorderLabel.Name = "reorderLabel"
        Me.reorderLabel.Size = New System.Drawing.Size(112, 20)
        Me.reorderLabel.TabIndex = 6
        Me.reorderLabel.Text = "Reorder Level:"
        '
        'averageLabel
        '
        Me.averageLabel.AutoSize = True
        Me.averageLabel.Location = New System.Drawing.Point(9, 195)
        Me.averageLabel.Name = "averageLabel"
        Me.averageLabel.Size = New System.Drawing.Size(137, 20)
        Me.averageLabel.TabIndex = 8
        Me.averageLabel.Text = "Average Demand:"
        '
        'lastButton
        '
        Me.lastButton.Location = New System.Drawing.Point(356, 287)
        Me.lastButton.Name = "lastButton"
        Me.lastButton.Size = New System.Drawing.Size(111, 34)
        Me.lastButton.TabIndex = 15
        Me.lastButton.Text = "Last"
        Me.lastButton.UseVisualStyleBackColor = True
        '
        'firstButton
        '
        Me.firstButton.Location = New System.Drawing.Point(239, 287)
        Me.firstButton.Name = "firstButton"
        Me.firstButton.Size = New System.Drawing.Size(111, 34)
        Me.firstButton.TabIndex = 14
        Me.firstButton.Text = "First"
        Me.firstButton.UseVisualStyleBackColor = True
        '
        'previousButton
        '
        Me.previousButton.Location = New System.Drawing.Point(122, 287)
        Me.previousButton.Name = "previousButton"
        Me.previousButton.Size = New System.Drawing.Size(111, 34)
        Me.previousButton.TabIndex = 13
        Me.previousButton.Text = "Previous"
        Me.previousButton.UseVisualStyleBackColor = True
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(7, 287)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(111, 34)
        Me.nextButton.TabIndex = 12
        Me.nextButton.Text = "Next"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'reorderTextBox
        '
        Me.reorderTextBox.Location = New System.Drawing.Point(168, 151)
        Me.reorderTextBox.Name = "reorderTextBox"
        Me.reorderTextBox.Size = New System.Drawing.Size(122, 26)
        Me.reorderTextBox.TabIndex = 7
        '
        'stdLabel
        '
        Me.stdLabel.AutoSize = True
        Me.stdLabel.Location = New System.Drawing.Point(3, 238)
        Me.stdLabel.Name = "stdLabel"
        Me.stdLabel.Size = New System.Drawing.Size(143, 20)
        Me.stdLabel.TabIndex = 10
        Me.stdLabel.Text = "Std. Dev. Demand:"
        '
        'unitTextBox
        '
        Me.unitTextBox.Location = New System.Drawing.Point(168, 69)
        Me.unitTextBox.Name = "unitTextBox"
        Me.unitTextBox.Size = New System.Drawing.Size(122, 26)
        Me.unitTextBox.TabIndex = 3
        '
        'stdTextBox
        '
        Me.stdTextBox.Location = New System.Drawing.Point(168, 235)
        Me.stdTextBox.Name = "stdTextBox"
        Me.stdTextBox.Size = New System.Drawing.Size(122, 26)
        Me.stdTextBox.TabIndex = 11
        '
        'averageTextBox
        '
        Me.averageTextBox.Location = New System.Drawing.Point(168, 192)
        Me.averageTextBox.Name = "averageTextBox"
        Me.averageTextBox.Size = New System.Drawing.Size(122, 26)
        Me.averageTextBox.TabIndex = 9
        '
        'unitorderTextBox
        '
        Me.unitorderTextBox.Location = New System.Drawing.Point(168, 107)
        Me.unitorderTextBox.Name = "unitorderTextBox"
        Me.unitorderTextBox.Size = New System.Drawing.Size(122, 26)
        Me.unitorderTextBox.TabIndex = 5
        '
        'productTextBox
        '
        Me.productTextBox.Location = New System.Drawing.Point(168, 27)
        Me.productTextBox.Name = "productTextBox"
        Me.productTextBox.Size = New System.Drawing.Size(277, 26)
        Me.productTextBox.TabIndex = 1
        '
        'reorderGroupBox
        '
        Me.reorderGroupBox.Controls.Add(Me.reorderpoLabel)
        Me.reorderGroupBox.Controls.Add(Me.reorderpointLabel)
        Me.reorderGroupBox.Controls.Add(Me.leadLabel)
        Me.reorderGroupBox.Controls.Add(Me.serviceLabel)
        Me.reorderGroupBox.Controls.Add(Me.standartLabel)
        Me.reorderGroupBox.Controls.Add(Me.averLabel)
        Me.reorderGroupBox.Controls.Add(Me.calculateButton)
        Me.reorderGroupBox.Controls.Add(Me.transferproductButton)
        Me.reorderGroupBox.Controls.Add(Me.leadComboBox)
        Me.reorderGroupBox.Controls.Add(Me.serviceComboBox)
        Me.reorderGroupBox.Controls.Add(Me.averTextBox)
        Me.reorderGroupBox.Controls.Add(Me.standartTextBox)
        Me.reorderGroupBox.Location = New System.Drawing.Point(527, 60)
        Me.reorderGroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.reorderGroupBox.Name = "reorderGroupBox"
        Me.reorderGroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.reorderGroupBox.Size = New System.Drawing.Size(474, 344)
        Me.reorderGroupBox.TabIndex = 2
        Me.reorderGroupBox.TabStop = False
        Me.reorderGroupBox.Text = "Reorder Point Calculator"
        '
        'reorderpoLabel
        '
        Me.reorderpoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.reorderpoLabel.Location = New System.Drawing.Point(223, 194)
        Me.reorderpoLabel.Name = "reorderpoLabel"
        Me.reorderpoLabel.Size = New System.Drawing.Size(155, 31)
        Me.reorderpoLabel.TabIndex = 9
        '
        'reorderpointLabel
        '
        Me.reorderpointLabel.AutoSize = True
        Me.reorderpointLabel.Location = New System.Drawing.Point(68, 195)
        Me.reorderpointLabel.Name = "reorderpointLabel"
        Me.reorderpointLabel.Size = New System.Drawing.Size(111, 20)
        Me.reorderpointLabel.TabIndex = 8
        Me.reorderpointLabel.Text = "Reorder Point:"
        '
        'leadLabel
        '
        Me.leadLabel.AutoSize = True
        Me.leadLabel.Location = New System.Drawing.Point(45, 154)
        Me.leadLabel.Name = "leadLabel"
        Me.leadLabel.Size = New System.Drawing.Size(134, 20)
        Me.leadLabel.TabIndex = 6
        Me.leadLabel.Text = "Lead Time (days):"
        '
        'serviceLabel
        '
        Me.serviceLabel.AutoSize = True
        Me.serviceLabel.Location = New System.Drawing.Point(73, 113)
        Me.serviceLabel.Name = "serviceLabel"
        Me.serviceLabel.Size = New System.Drawing.Size(106, 20)
        Me.serviceLabel.TabIndex = 4
        Me.serviceLabel.Text = "Service Level:"
        '
        'standartLabel
        '
        Me.standartLabel.AutoSize = True
        Me.standartLabel.Location = New System.Drawing.Point(34, 72)
        Me.standartLabel.Name = "standartLabel"
        Me.standartLabel.Size = New System.Drawing.Size(145, 20)
        Me.standartLabel.TabIndex = 2
        Me.standartLabel.Text = "Standart Deviation:"
        '
        'averLabel
        '
        Me.averLabel.AutoSize = True
        Me.averLabel.Location = New System.Drawing.Point(42, 30)
        Me.averLabel.Name = "averLabel"
        Me.averLabel.Size = New System.Drawing.Size(137, 20)
        Me.averLabel.TabIndex = 0
        Me.averLabel.Text = "Average Demand:"
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(253, 287)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(174, 34)
        Me.calculateButton.TabIndex = 11
        Me.calculateButton.Text = "Calculate ROP"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'transferproductButton
        '
        Me.transferproductButton.Location = New System.Drawing.Point(46, 287)
        Me.transferproductButton.Name = "transferproductButton"
        Me.transferproductButton.Size = New System.Drawing.Size(189, 34)
        Me.transferproductButton.TabIndex = 10
        Me.transferproductButton.Text = "Transfer Product Info"
        Me.transferproductButton.UseVisualStyleBackColor = True
        '
        'leadComboBox
        '
        Me.leadComboBox.FormattingEnabled = True
        Me.leadComboBox.Location = New System.Drawing.Point(226, 151)
        Me.leadComboBox.Name = "leadComboBox"
        Me.leadComboBox.Size = New System.Drawing.Size(152, 28)
        Me.leadComboBox.TabIndex = 7
        '
        'serviceComboBox
        '
        Me.serviceComboBox.FormattingEnabled = True
        Me.serviceComboBox.Location = New System.Drawing.Point(226, 110)
        Me.serviceComboBox.Name = "serviceComboBox"
        Me.serviceComboBox.Size = New System.Drawing.Size(152, 28)
        Me.serviceComboBox.TabIndex = 5
        '
        'averTextBox
        '
        Me.averTextBox.Location = New System.Drawing.Point(226, 27)
        Me.averTextBox.Name = "averTextBox"
        Me.averTextBox.Size = New System.Drawing.Size(122, 26)
        Me.averTextBox.TabIndex = 1
        '
        'standartTextBox
        '
        Me.standartTextBox.Location = New System.Drawing.Point(226, 69)
        Me.standartTextBox.Name = "standartTextBox"
        Me.standartTextBox.Size = New System.Drawing.Size(122, 26)
        Me.standartTextBox.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(1042, 709)
        Me.Controls.Add(Me.reorderGroupBox)
        Me.Controls.Add(Me.detailGroupBox)
        Me.Controls.Add(Me.TblProductsDataGridView)
        Me.Controls.Add(Me.TblProductsBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Final - Inventory Control System"
        CType(Me.ProductListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblProductsBindingNavigator.ResumeLayout(False)
        Me.TblProductsBindingNavigator.PerformLayout()
        CType(Me.TblProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.detailGroupBox.ResumeLayout(False)
        Me.detailGroupBox.PerformLayout()
        Me.reorderGroupBox.ResumeLayout(False)
        Me.reorderGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductListDataSet As ProductListDataSet
    Friend WithEvents TblProductsBindingSource As BindingSource
    Friend WithEvents TblProductsTableAdapter As ProductListDataSetTableAdapters.tblProductsTableAdapter
    Friend WithEvents TableAdapterManager As ProductListDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblProductsBindingNavigator As BindingNavigator
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
    Friend WithEvents TblProductsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TblProductsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RunROPReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents detailGroupBox As GroupBox
    Friend WithEvents lastButton As Button
    Friend WithEvents firstButton As Button
    Friend WithEvents previousButton As Button
    Friend WithEvents nextButton As Button
    Friend WithEvents reorderTextBox As TextBox
    Friend WithEvents unitTextBox As TextBox
    Friend WithEvents stdTextBox As TextBox
    Friend WithEvents averageTextBox As TextBox
    Friend WithEvents unitorderTextBox As TextBox
    Friend WithEvents productTextBox As TextBox
    Friend WithEvents reorderGroupBox As GroupBox
    Friend WithEvents averLabel As Label
    Friend WithEvents calculateButton As Button
    Friend WithEvents transferproductButton As Button
    Friend WithEvents leadComboBox As ComboBox
    Friend WithEvents serviceComboBox As ComboBox
    Friend WithEvents averTextBox As TextBox
    Friend WithEvents standartTextBox As TextBox
    Friend WithEvents productLabel As Label
    Friend WithEvents unitLabel As Label
    Friend WithEvents unitorderLabel As Label
    Friend WithEvents reorderLabel As Label
    Friend WithEvents averageLabel As Label
    Friend WithEvents stdLabel As Label
    Friend WithEvents reorderpoLabel As Label
    Friend WithEvents reorderpointLabel As Label
    Friend WithEvents leadLabel As Label
    Friend WithEvents serviceLabel As Label
    Friend WithEvents standartLabel As Label
End Class
