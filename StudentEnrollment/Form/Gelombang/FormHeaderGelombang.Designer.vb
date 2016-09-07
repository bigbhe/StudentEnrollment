<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHeaderGelombang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHeaderGelombang))
        Me.DataSetGelombang = New StudentEnrollment.DataSetGelombang()
        Me.HeaderGelombangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HeaderGelombangTableAdapter = New StudentEnrollment.DataSetGelombangTableAdapters.headerGelombangTableAdapter()
        Me.TableAdapterManager = New StudentEnrollment.DataSetGelombangTableAdapters.TableAdapterManager()
        Me.HeaderGelombangBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.HeaderGelombangBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.buttonFill = New System.Windows.Forms.ToolStripButton()
        Me.HeaderGelombangGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkodeGelombang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnamaGelombang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltanggalMulai = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltanggalBerakhir = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.kodeGelombangTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.namaGelombangTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.tanggalMulaiDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.tanggalBerakhirDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForkodeGelombang = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemFornamaGelombang = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemFortanggalMulai = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemFortanggalBerakhir = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DataSetGelombang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderGelombangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderGelombangBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderGelombangBindingNavigator.SuspendLayout()
        CType(Me.HeaderGelombangGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.kodeGelombangTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.namaGelombangTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tanggalMulaiDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tanggalMulaiDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tanggalBerakhirDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tanggalBerakhirDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForkodeGelombang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFornamaGelombang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFortanggalMulai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFortanggalBerakhir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetGelombang
        '
        Me.DataSetGelombang.DataSetName = "DataSetGelombang"
        Me.DataSetGelombang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HeaderGelombangBindingSource
        '
        Me.HeaderGelombangBindingSource.DataMember = "headerGelombang"
        Me.HeaderGelombangBindingSource.DataSource = Me.DataSetGelombang
        '
        'HeaderGelombangTableAdapter
        '
        Me.HeaderGelombangTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.detailGelombangTableAdapter = Nothing
        Me.TableAdapterManager.headerGelombangTableAdapter = Me.HeaderGelombangTableAdapter
        Me.TableAdapterManager.UpdateOrder = StudentEnrollment.DataSetGelombangTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HeaderGelombangBindingNavigator
        '
        Me.HeaderGelombangBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.HeaderGelombangBindingNavigator.BindingSource = Me.HeaderGelombangBindingSource
        Me.HeaderGelombangBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.HeaderGelombangBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.HeaderGelombangBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.HeaderGelombangBindingNavigatorSaveItem, Me.buttonFill})
        Me.HeaderGelombangBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.HeaderGelombangBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HeaderGelombangBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HeaderGelombangBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HeaderGelombangBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.HeaderGelombangBindingNavigator.Name = "HeaderGelombangBindingNavigator"
        Me.HeaderGelombangBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HeaderGelombangBindingNavigator.Size = New System.Drawing.Size(560, 25)
        Me.HeaderGelombangBindingNavigator.TabIndex = 0
        Me.HeaderGelombangBindingNavigator.Text = "BindingNavigator1"
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
        'HeaderGelombangBindingNavigatorSaveItem
        '
        Me.HeaderGelombangBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HeaderGelombangBindingNavigatorSaveItem.Image = CType(resources.GetObject("HeaderGelombangBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.HeaderGelombangBindingNavigatorSaveItem.Name = "HeaderGelombangBindingNavigatorSaveItem"
        Me.HeaderGelombangBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.HeaderGelombangBindingNavigatorSaveItem.Text = "Save Data"
        '
        'buttonFill
        '
        Me.buttonFill.Image = CType(resources.GetObject("buttonFill.Image"), System.Drawing.Image)
        Me.buttonFill.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonFill.Name = "buttonFill"
        Me.buttonFill.Size = New System.Drawing.Size(136, 22)
        Me.buttonFill.Text = "Isi Detail Gelombang"
        '
        'HeaderGelombangGridControl
        '
        Me.HeaderGelombangGridControl.DataSource = Me.HeaderGelombangBindingSource
        Me.HeaderGelombangGridControl.Location = New System.Drawing.Point(12, 84)
        Me.HeaderGelombangGridControl.MainView = Me.GridView1
        Me.HeaderGelombangGridControl.Name = "HeaderGelombangGridControl"
        Me.HeaderGelombangGridControl.Size = New System.Drawing.Size(536, 365)
        Me.HeaderGelombangGridControl.TabIndex = 1
        Me.HeaderGelombangGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colkodeGelombang, Me.colnamaGelombang, Me.coltanggalMulai, Me.coltanggalBerakhir})
        Me.GridView1.GridControl = Me.HeaderGelombangGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colkodeGelombang
        '
        Me.colkodeGelombang.FieldName = "kodeGelombang"
        Me.colkodeGelombang.Name = "colkodeGelombang"
        Me.colkodeGelombang.Visible = True
        Me.colkodeGelombang.VisibleIndex = 0
        '
        'colnamaGelombang
        '
        Me.colnamaGelombang.FieldName = "namaGelombang"
        Me.colnamaGelombang.Name = "colnamaGelombang"
        Me.colnamaGelombang.Visible = True
        Me.colnamaGelombang.VisibleIndex = 1
        '
        'coltanggalMulai
        '
        Me.coltanggalMulai.FieldName = "tanggalMulai"
        Me.coltanggalMulai.Name = "coltanggalMulai"
        Me.coltanggalMulai.Visible = True
        Me.coltanggalMulai.VisibleIndex = 2
        '
        'coltanggalBerakhir
        '
        Me.coltanggalBerakhir.FieldName = "tanggalBerakhir"
        Me.coltanggalBerakhir.Name = "coltanggalBerakhir"
        Me.coltanggalBerakhir.Visible = True
        Me.coltanggalBerakhir.VisibleIndex = 3
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.HeaderGelombangGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.kodeGelombangTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.namaGelombangTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.tanggalMulaiDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.tanggalBerakhirDateEdit)
        Me.DataLayoutControl1.DataSource = Me.HeaderGelombangBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForkodeGelombang})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(560, 461)
        Me.DataLayoutControl1.TabIndex = 2
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'kodeGelombangTextEdit
        '
        Me.kodeGelombangTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.HeaderGelombangBindingSource, "kodeGelombang", True))
        Me.kodeGelombangTextEdit.Location = New System.Drawing.Point(97, 12)
        Me.kodeGelombangTextEdit.Name = "kodeGelombangTextEdit"
        Me.kodeGelombangTextEdit.Size = New System.Drawing.Size(451, 20)
        Me.kodeGelombangTextEdit.StyleController = Me.DataLayoutControl1
        Me.kodeGelombangTextEdit.TabIndex = 4
        '
        'namaGelombangTextEdit
        '
        Me.namaGelombangTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.HeaderGelombangBindingSource, "namaGelombang", True))
        Me.namaGelombangTextEdit.Location = New System.Drawing.Point(97, 12)
        Me.namaGelombangTextEdit.Name = "namaGelombangTextEdit"
        Me.namaGelombangTextEdit.Size = New System.Drawing.Size(451, 20)
        Me.namaGelombangTextEdit.StyleController = Me.DataLayoutControl1
        Me.namaGelombangTextEdit.TabIndex = 5
        '
        'tanggalMulaiDateEdit
        '
        Me.tanggalMulaiDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.HeaderGelombangBindingSource, "tanggalMulai", True))
        Me.tanggalMulaiDateEdit.EditValue = Nothing
        Me.tanggalMulaiDateEdit.Location = New System.Drawing.Point(97, 36)
        Me.tanggalMulaiDateEdit.Name = "tanggalMulaiDateEdit"
        Me.tanggalMulaiDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tanggalMulaiDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tanggalMulaiDateEdit.Size = New System.Drawing.Size(451, 20)
        Me.tanggalMulaiDateEdit.StyleController = Me.DataLayoutControl1
        Me.tanggalMulaiDateEdit.TabIndex = 6
        '
        'tanggalBerakhirDateEdit
        '
        Me.tanggalBerakhirDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.HeaderGelombangBindingSource, "tanggalBerakhir", True))
        Me.tanggalBerakhirDateEdit.EditValue = Nothing
        Me.tanggalBerakhirDateEdit.Location = New System.Drawing.Point(97, 60)
        Me.tanggalBerakhirDateEdit.Name = "tanggalBerakhirDateEdit"
        Me.tanggalBerakhirDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tanggalBerakhirDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tanggalBerakhirDateEdit.Size = New System.Drawing.Size(451, 20)
        Me.tanggalBerakhirDateEdit.StyleController = Me.DataLayoutControl1
        Me.tanggalBerakhirDateEdit.TabIndex = 7
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(560, 461)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemFornamaGelombang, Me.ItemFortanggalMulai, Me.ItemFortanggalBerakhir, Me.LayoutControlItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(540, 441)
        '
        'ItemForkodeGelombang
        '
        Me.ItemForkodeGelombang.Control = Me.kodeGelombangTextEdit
        Me.ItemForkodeGelombang.Location = New System.Drawing.Point(0, 0)
        Me.ItemForkodeGelombang.Name = "ItemForkodeGelombang"
        Me.ItemForkodeGelombang.Size = New System.Drawing.Size(540, 24)
        Me.ItemForkodeGelombang.Text = "kode Gelombang"
        Me.ItemForkodeGelombang.TextSize = New System.Drawing.Size(82, 13)
        '
        'ItemFornamaGelombang
        '
        Me.ItemFornamaGelombang.Control = Me.namaGelombangTextEdit
        Me.ItemFornamaGelombang.Location = New System.Drawing.Point(0, 0)
        Me.ItemFornamaGelombang.Name = "ItemFornamaGelombang"
        Me.ItemFornamaGelombang.Size = New System.Drawing.Size(540, 24)
        Me.ItemFornamaGelombang.Text = "nama Gelombang"
        Me.ItemFornamaGelombang.TextSize = New System.Drawing.Size(82, 13)
        '
        'ItemFortanggalMulai
        '
        Me.ItemFortanggalMulai.Control = Me.tanggalMulaiDateEdit
        Me.ItemFortanggalMulai.Location = New System.Drawing.Point(0, 24)
        Me.ItemFortanggalMulai.Name = "ItemFortanggalMulai"
        Me.ItemFortanggalMulai.Size = New System.Drawing.Size(540, 24)
        Me.ItemFortanggalMulai.Text = "tanggal Mulai"
        Me.ItemFortanggalMulai.TextSize = New System.Drawing.Size(82, 13)
        '
        'ItemFortanggalBerakhir
        '
        Me.ItemFortanggalBerakhir.Control = Me.tanggalBerakhirDateEdit
        Me.ItemFortanggalBerakhir.Location = New System.Drawing.Point(0, 48)
        Me.ItemFortanggalBerakhir.Name = "ItemFortanggalBerakhir"
        Me.ItemFortanggalBerakhir.Size = New System.Drawing.Size(540, 24)
        Me.ItemFortanggalBerakhir.Text = "tanggal Berakhir"
        Me.ItemFortanggalBerakhir.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.HeaderGelombangGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(540, 369)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'FormHeaderGelombang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 486)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.HeaderGelombangBindingNavigator)
        Me.Name = "FormHeaderGelombang"
        Me.Text = "FormHeaderGelombang"
        CType(Me.DataSetGelombang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderGelombangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderGelombangBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGelombangBindingNavigator.ResumeLayout(False)
        Me.HeaderGelombangBindingNavigator.PerformLayout()
        CType(Me.HeaderGelombangGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.kodeGelombangTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.namaGelombangTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tanggalMulaiDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tanggalMulaiDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tanggalBerakhirDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tanggalBerakhirDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForkodeGelombang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFornamaGelombang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFortanggalMulai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFortanggalBerakhir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetGelombang As DataSetGelombang
    Friend WithEvents HeaderGelombangBindingSource As BindingSource
    Friend WithEvents HeaderGelombangTableAdapter As DataSetGelombangTableAdapters.headerGelombangTableAdapter
    Friend WithEvents TableAdapterManager As DataSetGelombangTableAdapters.TableAdapterManager
    Friend WithEvents HeaderGelombangBindingNavigator As BindingNavigator
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
    Friend WithEvents HeaderGelombangBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents HeaderGelombangGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents DataLayoutControl1 As XtraDataLayout.DataLayoutControl
    Friend WithEvents kodeGelombangTextEdit As TextEdit
    Friend WithEvents namaGelombangTextEdit As TextEdit
    Friend WithEvents tanggalMulaiDateEdit As DateEdit
    Friend WithEvents tanggalBerakhirDateEdit As DateEdit
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForkodeGelombang As XtraLayout.LayoutControlItem
    Friend WithEvents ItemFornamaGelombang As XtraLayout.LayoutControlItem
    Friend WithEvents ItemFortanggalMulai As XtraLayout.LayoutControlItem
    Friend WithEvents ItemFortanggalBerakhir As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colkodeGelombang As XtraGrid.Columns.GridColumn
    Friend WithEvents colnamaGelombang As XtraGrid.Columns.GridColumn
    Friend WithEvents coltanggalMulai As XtraGrid.Columns.GridColumn
    Friend WithEvents coltanggalBerakhir As XtraGrid.Columns.GridColumn
    Friend WithEvents buttonFill As ToolStripButton
End Class
