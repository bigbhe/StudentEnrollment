<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTestHeader
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTestHeader))
        Me.DataSetTest = New StudentEnrollment.DataSetTest()
        Me.HeaderTestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HeaderTestTableAdapter = New StudentEnrollment.DataSetTestTableAdapters.headerTestTableAdapter()
        Me.TableAdapterManager = New StudentEnrollment.DataSetTestTableAdapters.TableAdapterManager()
        Me.HeaderTestBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.HeaderTestBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.buttonDetail = New System.Windows.Forms.ToolStripButton()
        Me.HeaderTestGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidGelombang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidTest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MstTestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.coltanggal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnilaiMinimal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MstTestTableAdapter = New StudentEnrollment.DataSetTestTableAdapters.mstTestTableAdapter()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.idTestLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.tanggalDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.nilaiMinimalTextEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForidTest = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemFortanggal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemFornilaiMinimal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.DataSetTest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderTestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderTestBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderTestBindingNavigator.SuspendLayout()
        CType(Me.HeaderTestGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstTestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.idTestLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tanggalDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tanggalDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nilaiMinimalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidTest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFortanggal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFornilaiMinimal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetTest
        '
        Me.DataSetTest.DataSetName = "DataSetTest"
        Me.DataSetTest.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HeaderTestBindingSource
        '
        Me.HeaderTestBindingSource.DataMember = "headerTest"
        Me.HeaderTestBindingSource.DataSource = Me.DataSetTest
        '
        'HeaderTestTableAdapter
        '
        Me.HeaderTestTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.headerTestTableAdapter = Me.HeaderTestTableAdapter
        Me.TableAdapterManager.UpdateOrder = StudentEnrollment.DataSetTestTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HeaderTestBindingNavigator
        '
        Me.HeaderTestBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.HeaderTestBindingNavigator.BindingSource = Me.HeaderTestBindingSource
        Me.HeaderTestBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.HeaderTestBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.HeaderTestBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.HeaderTestBindingNavigatorSaveItem, Me.buttonDetail})
        Me.HeaderTestBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.HeaderTestBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HeaderTestBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HeaderTestBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HeaderTestBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.HeaderTestBindingNavigator.Name = "HeaderTestBindingNavigator"
        Me.HeaderTestBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HeaderTestBindingNavigator.Size = New System.Drawing.Size(883, 25)
        Me.HeaderTestBindingNavigator.TabIndex = 0
        Me.HeaderTestBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'HeaderTestBindingNavigatorSaveItem
        '
        Me.HeaderTestBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HeaderTestBindingNavigatorSaveItem.Image = CType(resources.GetObject("HeaderTestBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.HeaderTestBindingNavigatorSaveItem.Name = "HeaderTestBindingNavigatorSaveItem"
        Me.HeaderTestBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.HeaderTestBindingNavigatorSaveItem.Text = "Save Data"
        '
        'buttonDetail
        '
        Me.buttonDetail.Image = CType(resources.GetObject("buttonDetail.Image"), System.Drawing.Image)
        Me.buttonDetail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonDetail.Name = "buttonDetail"
        Me.buttonDetail.Size = New System.Drawing.Size(102, 22)
        Me.buttonDetail.Text = "Fill Detail Data"
        '
        'HeaderTestGridControl
        '
        Me.HeaderTestGridControl.DataSource = Me.HeaderTestBindingSource
        Me.HeaderTestGridControl.Location = New System.Drawing.Point(12, 84)
        Me.HeaderTestGridControl.MainView = Me.GridView1
        Me.HeaderTestGridControl.Name = "HeaderTestGridControl"
        Me.HeaderTestGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.HeaderTestGridControl.Size = New System.Drawing.Size(859, 559)
        Me.HeaderTestGridControl.TabIndex = 1
        Me.HeaderTestGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colidGelombang, Me.colidTest, Me.coltanggal, Me.colnilaiMinimal, Me.colidUser})
        Me.GridView1.GridControl = Me.HeaderTestGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colidGelombang
        '
        Me.colidGelombang.FieldName = "idGelombang"
        Me.colidGelombang.Name = "colidGelombang"
        '
        'colidTest
        '
        Me.colidTest.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colidTest.FieldName = "idTest"
        Me.colidTest.Name = "colidTest"
        Me.colidTest.Visible = True
        Me.colidTest.VisibleIndex = 0
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.MstTestBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "NamaTest"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "id"
        '
        'MstTestBindingSource
        '
        Me.MstTestBindingSource.DataMember = "mstTest"
        Me.MstTestBindingSource.DataSource = Me.DataSetTest
        '
        'coltanggal
        '
        Me.coltanggal.FieldName = "tanggal"
        Me.coltanggal.Name = "coltanggal"
        Me.coltanggal.Visible = True
        Me.coltanggal.VisibleIndex = 1
        '
        'colnilaiMinimal
        '
        Me.colnilaiMinimal.FieldName = "nilaiMinimal"
        Me.colnilaiMinimal.Name = "colnilaiMinimal"
        Me.colnilaiMinimal.Visible = True
        Me.colnilaiMinimal.VisibleIndex = 2
        '
        'colidUser
        '
        Me.colidUser.FieldName = "idUser"
        Me.colidUser.Name = "colidUser"
        '
        'MstTestTableAdapter
        '
        Me.MstTestTableAdapter.ClearBeforeFill = True
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.HeaderTestGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.idTestLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.tanggalDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.nilaiMinimalTextEdit)
        Me.DataLayoutControl1.DataSource = Me.HeaderTestBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(883, 655)
        Me.DataLayoutControl1.TabIndex = 2
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'idTestLookUpEdit
        '
        Me.idTestLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.HeaderTestBindingSource, "idTest", True))
        Me.idTestLookUpEdit.Location = New System.Drawing.Point(70, 12)
        Me.idTestLookUpEdit.Name = "idTestLookUpEdit"
        Me.idTestLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idTestLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idTestLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idTestLookUpEdit.Properties.DataSource = Me.MstTestBindingSource
        Me.idTestLookUpEdit.Properties.DisplayMember = "NamaTest"
        Me.idTestLookUpEdit.Properties.NullText = ""
        Me.idTestLookUpEdit.Properties.ValueMember = "id"
        Me.idTestLookUpEdit.Size = New System.Drawing.Size(368, 20)
        Me.idTestLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.idTestLookUpEdit.TabIndex = 4
        '
        'tanggalDateEdit
        '
        Me.tanggalDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.HeaderTestBindingSource, "tanggal", True))
        Me.tanggalDateEdit.EditValue = Nothing
        Me.tanggalDateEdit.Location = New System.Drawing.Point(70, 36)
        Me.tanggalDateEdit.Name = "tanggalDateEdit"
        Me.tanggalDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tanggalDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tanggalDateEdit.Size = New System.Drawing.Size(368, 20)
        Me.tanggalDateEdit.StyleController = Me.DataLayoutControl1
        Me.tanggalDateEdit.TabIndex = 5
        '
        'nilaiMinimalTextEdit
        '
        Me.nilaiMinimalTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.HeaderTestBindingSource, "nilaiMinimal", True))
        Me.nilaiMinimalTextEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nilaiMinimalTextEdit.Location = New System.Drawing.Point(70, 60)
        Me.nilaiMinimalTextEdit.Name = "nilaiMinimalTextEdit"
        Me.nilaiMinimalTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.nilaiMinimalTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.nilaiMinimalTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.nilaiMinimalTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.nilaiMinimalTextEdit.Properties.Mask.EditMask = "N0"
        Me.nilaiMinimalTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.nilaiMinimalTextEdit.Size = New System.Drawing.Size(368, 20)
        Me.nilaiMinimalTextEdit.StyleController = Me.DataLayoutControl1
        Me.nilaiMinimalTextEdit.TabIndex = 6
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(883, 655)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForidTest, Me.ItemFortanggal, Me.ItemFornilaiMinimal, Me.LayoutControlItem1, Me.EmptySpaceItem4})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(863, 635)
        '
        'ItemForidTest
        '
        Me.ItemForidTest.Control = Me.idTestLookUpEdit
        Me.ItemForidTest.Location = New System.Drawing.Point(0, 0)
        Me.ItemForidTest.Name = "ItemForidTest"
        Me.ItemForidTest.Size = New System.Drawing.Size(430, 24)
        Me.ItemForidTest.Text = "id Test"
        Me.ItemForidTest.TextSize = New System.Drawing.Size(55, 13)
        '
        'ItemFortanggal
        '
        Me.ItemFortanggal.Control = Me.tanggalDateEdit
        Me.ItemFortanggal.Location = New System.Drawing.Point(0, 24)
        Me.ItemFortanggal.Name = "ItemFortanggal"
        Me.ItemFortanggal.Size = New System.Drawing.Size(430, 24)
        Me.ItemFortanggal.Text = "tanggal"
        Me.ItemFortanggal.TextSize = New System.Drawing.Size(55, 13)
        '
        'ItemFornilaiMinimal
        '
        Me.ItemFornilaiMinimal.Control = Me.nilaiMinimalTextEdit
        Me.ItemFornilaiMinimal.Location = New System.Drawing.Point(0, 48)
        Me.ItemFornilaiMinimal.Name = "ItemFornilaiMinimal"
        Me.ItemFornilaiMinimal.Size = New System.Drawing.Size(430, 24)
        Me.ItemFornilaiMinimal.Text = "nilai Minimal"
        Me.ItemFornilaiMinimal.TextSize = New System.Drawing.Size(55, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.HeaderTestGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(863, 563)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(430, 0)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(433, 72)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'FormTestHeader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 680)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.HeaderTestBindingNavigator)
        Me.Name = "FormTestHeader"
        Me.Text = "FormTestHeader"
        CType(Me.DataSetTest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderTestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderTestBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderTestBindingNavigator.ResumeLayout(False)
        Me.HeaderTestBindingNavigator.PerformLayout()
        CType(Me.HeaderTestGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstTestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.idTestLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tanggalDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tanggalDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nilaiMinimalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidTest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFortanggal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFornilaiMinimal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetTest As DataSetTest
    Friend WithEvents HeaderTestBindingSource As BindingSource
    Friend WithEvents HeaderTestTableAdapter As DataSetTestTableAdapters.headerTestTableAdapter
    Friend WithEvents TableAdapterManager As DataSetTestTableAdapters.TableAdapterManager
    Friend WithEvents HeaderTestBindingNavigator As BindingNavigator
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
    Friend WithEvents HeaderTestBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents HeaderTestGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colidGelombang As XtraGrid.Columns.GridColumn
    Friend WithEvents colidTest As XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As Repository.RepositoryItemLookUpEdit
    Friend WithEvents coltanggal As XtraGrid.Columns.GridColumn
    Friend WithEvents colnilaiMinimal As XtraGrid.Columns.GridColumn
    Friend WithEvents colidUser As XtraGrid.Columns.GridColumn
    Friend WithEvents MstTestBindingSource As BindingSource
    Friend WithEvents MstTestTableAdapter As DataSetTestTableAdapters.mstTestTableAdapter
    Friend WithEvents DataLayoutControl1 As XtraDataLayout.DataLayoutControl
    Friend WithEvents idTestLookUpEdit As LookUpEdit
    Friend WithEvents tanggalDateEdit As DateEdit
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForidTest As XtraLayout.LayoutControlItem
    Friend WithEvents ItemFortanggal As XtraLayout.LayoutControlItem
    Friend WithEvents ItemFornilaiMinimal As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
    Friend WithEvents buttonDetail As ToolStripButton
    Friend WithEvents nilaiMinimalTextEdit As SpinEdit
    Friend WithEvents EmptySpaceItem4 As XtraLayout.EmptySpaceItem
End Class
