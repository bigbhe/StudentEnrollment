<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetailGelombang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDetailGelombang))
        Me.DataSetGelombang = New StudentEnrollment.DataSetGelombang()
        Me.DetailGelombangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetailGelombangTableAdapter = New StudentEnrollment.DataSetGelombangTableAdapters.detailGelombangTableAdapter()
        Me.TableAdapterManager = New StudentEnrollment.DataSetGelombangTableAdapters.TableAdapterManager()
        Me.DetailGelombangBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DetailGelombangBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DetailGelombangGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidHeaderGelombang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidJurusan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkuota = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.idHeaderGelombangTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.idJurusanLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.MstJurusanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.kuotaSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForidHeaderGelombang = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForidJurusan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForkuota = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.MstJurusanTableAdapter = New StudentEnrollment.DataSetGelombangTableAdapters.mstJurusanTableAdapter()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        CType(Me.DataSetGelombang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGelombangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGelombangBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DetailGelombangBindingNavigator.SuspendLayout()
        CType(Me.DetailGelombangGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.idHeaderGelombangTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idJurusanLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstJurusanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kuotaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidHeaderGelombang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidJurusan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForkuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetGelombang
        '
        Me.DataSetGelombang.DataSetName = "DataSetGelombang"
        Me.DataSetGelombang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DetailGelombangBindingSource
        '
        Me.DetailGelombangBindingSource.DataMember = "detailGelombang"
        Me.DetailGelombangBindingSource.DataSource = Me.DataSetGelombang
        '
        'DetailGelombangTableAdapter
        '
        Me.DetailGelombangTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.detailGelombangTableAdapter = Me.DetailGelombangTableAdapter
        Me.TableAdapterManager.headerGelombangTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = StudentEnrollment.DataSetGelombangTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DetailGelombangBindingNavigator
        '
        Me.DetailGelombangBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DetailGelombangBindingNavigator.BindingSource = Me.DetailGelombangBindingSource
        Me.DetailGelombangBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DetailGelombangBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DetailGelombangBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DetailGelombangBindingNavigatorSaveItem})
        Me.DetailGelombangBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DetailGelombangBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DetailGelombangBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DetailGelombangBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DetailGelombangBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DetailGelombangBindingNavigator.Name = "DetailGelombangBindingNavigator"
        Me.DetailGelombangBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DetailGelombangBindingNavigator.Size = New System.Drawing.Size(620, 25)
        Me.DetailGelombangBindingNavigator.TabIndex = 0
        Me.DetailGelombangBindingNavigator.Text = "BindingNavigator1"
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
        'DetailGelombangBindingNavigatorSaveItem
        '
        Me.DetailGelombangBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DetailGelombangBindingNavigatorSaveItem.Image = CType(resources.GetObject("DetailGelombangBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DetailGelombangBindingNavigatorSaveItem.Name = "DetailGelombangBindingNavigatorSaveItem"
        Me.DetailGelombangBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DetailGelombangBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DetailGelombangGridControl
        '
        Me.DetailGelombangGridControl.DataSource = Me.DetailGelombangBindingSource
        Me.DetailGelombangGridControl.Location = New System.Drawing.Point(12, 84)
        Me.DetailGelombangGridControl.MainView = Me.GridView1
        Me.DetailGelombangGridControl.Name = "DetailGelombangGridControl"
        Me.DetailGelombangGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.DetailGelombangGridControl.Size = New System.Drawing.Size(596, 342)
        Me.DetailGelombangGridControl.TabIndex = 2
        Me.DetailGelombangGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colidHeaderGelombang, Me.colidJurusan, Me.colkuota})
        Me.GridView1.GridControl = Me.DetailGelombangGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colidHeaderGelombang
        '
        Me.colidHeaderGelombang.FieldName = "idHeaderGelombang"
        Me.colidHeaderGelombang.Name = "colidHeaderGelombang"
        '
        'colidJurusan
        '
        Me.colidJurusan.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colidJurusan.FieldName = "idJurusan"
        Me.colidJurusan.Name = "colidJurusan"
        Me.colidJurusan.Visible = True
        Me.colidJurusan.VisibleIndex = 0
        '
        'colkuota
        '
        Me.colkuota.FieldName = "kuota"
        Me.colkuota.Name = "colkuota"
        Me.colkuota.Visible = True
        Me.colkuota.VisibleIndex = 1
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.LabelControl1)
        Me.DataLayoutControl1.Controls.Add(Me.DetailGelombangGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.idHeaderGelombangTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.idJurusanLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.kuotaSpinEdit)
        Me.DataLayoutControl1.DataSource = Me.DetailGelombangBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForidHeaderGelombang})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(620, 438)
        Me.DataLayoutControl1.TabIndex = 3
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(93, 20)
        Me.LabelControl1.StyleController = Me.DataLayoutControl1
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "LabelControl1"
        '
        'idHeaderGelombangTextEdit
        '
        Me.idHeaderGelombangTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DetailGelombangBindingSource, "idHeaderGelombang", True))
        Me.idHeaderGelombangTextEdit.Location = New System.Drawing.Point(117, 36)
        Me.idHeaderGelombangTextEdit.Name = "idHeaderGelombangTextEdit"
        Me.idHeaderGelombangTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idHeaderGelombangTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idHeaderGelombangTextEdit.Properties.Mask.EditMask = "N0"
        Me.idHeaderGelombangTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.idHeaderGelombangTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.idHeaderGelombangTextEdit.Size = New System.Drawing.Size(491, 20)
        Me.idHeaderGelombangTextEdit.StyleController = Me.DataLayoutControl1
        Me.idHeaderGelombangTextEdit.TabIndex = 4
        '
        'idJurusanLookUpEdit
        '
        Me.idJurusanLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DetailGelombangBindingSource, "idJurusan", True))
        Me.idJurusanLookUpEdit.Location = New System.Drawing.Point(64, 36)
        Me.idJurusanLookUpEdit.Name = "idJurusanLookUpEdit"
        Me.idJurusanLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idJurusanLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idJurusanLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idJurusanLookUpEdit.Properties.DataSource = Me.MstJurusanBindingSource
        Me.idJurusanLookUpEdit.Properties.DisplayMember = "Jurusan"
        Me.idJurusanLookUpEdit.Properties.NullText = ""
        Me.idJurusanLookUpEdit.Properties.ValueMember = "id"
        Me.idJurusanLookUpEdit.Size = New System.Drawing.Size(544, 20)
        Me.idJurusanLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.idJurusanLookUpEdit.TabIndex = 5
        '
        'MstJurusanBindingSource
        '
        Me.MstJurusanBindingSource.DataMember = "mstJurusan"
        Me.MstJurusanBindingSource.DataSource = Me.DataSetGelombang
        '
        'kuotaSpinEdit
        '
        Me.kuotaSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DetailGelombangBindingSource, "kuota", True))
        Me.kuotaSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.kuotaSpinEdit.Location = New System.Drawing.Point(64, 60)
        Me.kuotaSpinEdit.Name = "kuotaSpinEdit"
        Me.kuotaSpinEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.kuotaSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.kuotaSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kuotaSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.kuotaSpinEdit.Properties.Mask.EditMask = "N0"
        Me.kuotaSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.kuotaSpinEdit.Size = New System.Drawing.Size(544, 20)
        Me.kuotaSpinEdit.StyleController = Me.DataLayoutControl1
        Me.kuotaSpinEdit.TabIndex = 6
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(620, 438)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForidJurusan, Me.ItemForkuota, Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(600, 418)
        '
        'ItemForidHeaderGelombang
        '
        Me.ItemForidHeaderGelombang.Control = Me.idHeaderGelombangTextEdit
        Me.ItemForidHeaderGelombang.Location = New System.Drawing.Point(0, 24)
        Me.ItemForidHeaderGelombang.Name = "ItemForidHeaderGelombang"
        Me.ItemForidHeaderGelombang.Size = New System.Drawing.Size(600, 24)
        Me.ItemForidHeaderGelombang.Text = "id Header Gelombang"
        Me.ItemForidHeaderGelombang.TextSize = New System.Drawing.Size(102, 13)
        '
        'ItemForidJurusan
        '
        Me.ItemForidJurusan.Control = Me.idJurusanLookUpEdit
        Me.ItemForidJurusan.Location = New System.Drawing.Point(0, 24)
        Me.ItemForidJurusan.Name = "ItemForidJurusan"
        Me.ItemForidJurusan.Size = New System.Drawing.Size(600, 24)
        Me.ItemForidJurusan.Text = "id Jurusan"
        Me.ItemForidJurusan.TextSize = New System.Drawing.Size(49, 13)
        '
        'ItemForkuota
        '
        Me.ItemForkuota.Control = Me.kuotaSpinEdit
        Me.ItemForkuota.Location = New System.Drawing.Point(0, 48)
        Me.ItemForkuota.Name = "ItemForkuota"
        Me.ItemForkuota.Size = New System.Drawing.Size(600, 24)
        Me.ItemForkuota.Text = "kuota"
        Me.ItemForkuota.TextSize = New System.Drawing.Size(49, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.DetailGelombangGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(600, 346)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.LabelControl1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(600, 24)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'MstJurusanTableAdapter
        '
        Me.MstJurusanTableAdapter.ClearBeforeFill = True
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.MstJurusanBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Jurusan"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "id"
        '
        'FormDetailGelombang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 463)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.DetailGelombangBindingNavigator)
        Me.Name = "FormDetailGelombang"
        Me.Text = "FormDetailGelombang"
        CType(Me.DataSetGelombang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGelombangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGelombangBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DetailGelombangBindingNavigator.ResumeLayout(False)
        Me.DetailGelombangBindingNavigator.PerformLayout()
        CType(Me.DetailGelombangGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.idHeaderGelombangTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idJurusanLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstJurusanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kuotaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidHeaderGelombang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidJurusan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForkuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetGelombang As DataSetGelombang
    Friend WithEvents DetailGelombangBindingSource As BindingSource
    Friend WithEvents DetailGelombangTableAdapter As DataSetGelombangTableAdapters.detailGelombangTableAdapter
    Friend WithEvents TableAdapterManager As DataSetGelombangTableAdapters.TableAdapterManager
    Friend WithEvents DetailGelombangBindingNavigator As BindingNavigator
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
    Friend WithEvents DetailGelombangBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DetailGelombangGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colidHeaderGelombang As XtraGrid.Columns.GridColumn
    Friend WithEvents colidJurusan As XtraGrid.Columns.GridColumn
    Friend WithEvents colkuota As XtraGrid.Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As XtraDataLayout.DataLayoutControl
    Friend WithEvents idHeaderGelombangTextEdit As TextEdit
    Friend WithEvents idJurusanLookUpEdit As LookUpEdit
    Friend WithEvents kuotaSpinEdit As SpinEdit
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForidHeaderGelombang As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForidJurusan As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForkuota As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
    Friend WithEvents MstJurusanBindingSource As BindingSource
    Friend WithEvents MstJurusanTableAdapter As DataSetGelombangTableAdapters.mstJurusanTableAdapter
    Friend WithEvents LabelControl1 As LabelControl
    Friend WithEvents LayoutControlItem2 As XtraLayout.LayoutControlItem
    Friend WithEvents RepositoryItemLookUpEdit1 As Repository.RepositoryItemLookUpEdit
End Class
