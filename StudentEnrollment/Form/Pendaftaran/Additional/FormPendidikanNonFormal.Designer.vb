<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPendidikanNonFormal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPendidikanNonFormal))
        Me.DataSetPelengkapPendaftaran = New StudentEnrollment.DataSetPelengkapPendaftaran()
        Me.PendidikanNonFormalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PendidikanNonFormalTableAdapter = New StudentEnrollment.DataSetPelengkapPendaftaranTableAdapters.pendidikanNonFormalTableAdapter()
        Me.TableAdapterManager = New StudentEnrollment.DataSetPelengkapPendaftaranTableAdapters.TableAdapterManager()
        Me.PendidikanNonFormalBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PendidikanNonFormalBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PendidikanNonFormalGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidPendaftar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpendidikan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colinstansi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colalamat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnomorSertifikat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.pendidikanTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForpendidikan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.instansiTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForinstansi = New DevExpress.XtraLayout.LayoutControlItem()
        Me.alamatMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.ItemForalamat = New DevExpress.XtraLayout.LayoutControlItem()
        Me.nomorSertifikatTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemFornomorSertifikat = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DataSetPelengkapPendaftaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PendidikanNonFormalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PendidikanNonFormalBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PendidikanNonFormalBindingNavigator.SuspendLayout()
        CType(Me.PendidikanNonFormalGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pendidikanTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForpendidikan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.instansiTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForinstansi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alamatMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForalamat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nomorSertifikatTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFornomorSertifikat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetPelengkapPendaftaran
        '
        Me.DataSetPelengkapPendaftaran.DataSetName = "DataSetPelengkapPendaftaran"
        Me.DataSetPelengkapPendaftaran.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PendidikanNonFormalBindingSource
        '
        Me.PendidikanNonFormalBindingSource.DataMember = "pendidikanNonFormal"
        Me.PendidikanNonFormalBindingSource.DataSource = Me.DataSetPelengkapPendaftaran
        '
        'PendidikanNonFormalTableAdapter
        '
        Me.PendidikanNonFormalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.pelamarHobiTableAdapter = Nothing
        Me.TableAdapterManager.pendidikanNonFormalTableAdapter = Me.PendidikanNonFormalTableAdapter
        Me.TableAdapterManager.pengalamanOrganisasiTableAdapter = Nothing
        Me.TableAdapterManager.prestasiTableAdapter = Nothing
        Me.TableAdapterManager.traNilaiUNTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = StudentEnrollment.DataSetPelengkapPendaftaranTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PendidikanNonFormalBindingNavigator
        '
        Me.PendidikanNonFormalBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PendidikanNonFormalBindingNavigator.BindingSource = Me.PendidikanNonFormalBindingSource
        Me.PendidikanNonFormalBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PendidikanNonFormalBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PendidikanNonFormalBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PendidikanNonFormalBindingNavigatorSaveItem})
        Me.PendidikanNonFormalBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PendidikanNonFormalBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PendidikanNonFormalBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PendidikanNonFormalBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PendidikanNonFormalBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PendidikanNonFormalBindingNavigator.Name = "PendidikanNonFormalBindingNavigator"
        Me.PendidikanNonFormalBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PendidikanNonFormalBindingNavigator.Size = New System.Drawing.Size(643, 25)
        Me.PendidikanNonFormalBindingNavigator.TabIndex = 0
        Me.PendidikanNonFormalBindingNavigator.Text = "BindingNavigator1"
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
        'PendidikanNonFormalBindingNavigatorSaveItem
        '
        Me.PendidikanNonFormalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PendidikanNonFormalBindingNavigatorSaveItem.Image = CType(resources.GetObject("PendidikanNonFormalBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PendidikanNonFormalBindingNavigatorSaveItem.Name = "PendidikanNonFormalBindingNavigatorSaveItem"
        Me.PendidikanNonFormalBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PendidikanNonFormalBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PendidikanNonFormalGridControl
        '
        Me.PendidikanNonFormalGridControl.DataSource = Me.PendidikanNonFormalBindingSource
        Me.PendidikanNonFormalGridControl.Location = New System.Drawing.Point(280, 29)
        Me.PendidikanNonFormalGridControl.MainView = Me.GridView1
        Me.PendidikanNonFormalGridControl.Name = "PendidikanNonFormalGridControl"
        Me.PendidikanNonFormalGridControl.Size = New System.Drawing.Size(351, 315)
        Me.PendidikanNonFormalGridControl.TabIndex = 2
        Me.PendidikanNonFormalGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colidPendaftar, Me.colpendidikan, Me.colinstansi, Me.colalamat, Me.colnomorSertifikat})
        Me.GridView1.GridControl = Me.PendidikanNonFormalGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colidPendaftar
        '
        Me.colidPendaftar.FieldName = "idPendaftar"
        Me.colidPendaftar.Name = "colidPendaftar"
        '
        'colpendidikan
        '
        Me.colpendidikan.FieldName = "pendidikan"
        Me.colpendidikan.Name = "colpendidikan"
        Me.colpendidikan.Visible = True
        Me.colpendidikan.VisibleIndex = 0
        '
        'colinstansi
        '
        Me.colinstansi.FieldName = "instansi"
        Me.colinstansi.Name = "colinstansi"
        Me.colinstansi.Visible = True
        Me.colinstansi.VisibleIndex = 1
        '
        'colalamat
        '
        Me.colalamat.FieldName = "alamat"
        Me.colalamat.Name = "colalamat"
        Me.colalamat.Visible = True
        Me.colalamat.VisibleIndex = 2
        '
        'colnomorSertifikat
        '
        Me.colnomorSertifikat.FieldName = "nomorSertifikat"
        Me.colnomorSertifikat.Name = "colnomorSertifikat"
        Me.colnomorSertifikat.Visible = True
        Me.colnomorSertifikat.VisibleIndex = 3
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.LabelControl1)
        Me.DataLayoutControl1.Controls.Add(Me.PendidikanNonFormalGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.pendidikanTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.instansiTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.alamatMemoEdit)
        Me.DataLayoutControl1.Controls.Add(Me.nomorSertifikatTextEdit)
        Me.DataLayoutControl1.DataSource = Me.PendidikanNonFormalBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(643, 356)
        Me.DataLayoutControl1.TabIndex = 3
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(643, 356)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForpendidikan, Me.ItemForinstansi, Me.ItemForalamat, Me.ItemFornomorSertifikat, Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(623, 336)
        '
        'pendidikanTextEdit
        '
        Me.pendidikanTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PendidikanNonFormalBindingSource, "pendidikan", True))
        Me.pendidikanTextEdit.Location = New System.Drawing.Point(92, 29)
        Me.pendidikanTextEdit.Name = "pendidikanTextEdit"
        Me.pendidikanTextEdit.Size = New System.Drawing.Size(184, 20)
        Me.pendidikanTextEdit.StyleController = Me.DataLayoutControl1
        Me.pendidikanTextEdit.TabIndex = 4
        '
        'ItemForpendidikan
        '
        Me.ItemForpendidikan.Control = Me.pendidikanTextEdit
        Me.ItemForpendidikan.Location = New System.Drawing.Point(0, 17)
        Me.ItemForpendidikan.Name = "ItemForpendidikan"
        Me.ItemForpendidikan.Size = New System.Drawing.Size(268, 24)
        Me.ItemForpendidikan.Text = "pendidikan"
        Me.ItemForpendidikan.TextSize = New System.Drawing.Size(76, 13)
        '
        'instansiTextEdit
        '
        Me.instansiTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PendidikanNonFormalBindingSource, "instansi", True))
        Me.instansiTextEdit.Location = New System.Drawing.Point(92, 53)
        Me.instansiTextEdit.Name = "instansiTextEdit"
        Me.instansiTextEdit.Size = New System.Drawing.Size(184, 20)
        Me.instansiTextEdit.StyleController = Me.DataLayoutControl1
        Me.instansiTextEdit.TabIndex = 5
        '
        'ItemForinstansi
        '
        Me.ItemForinstansi.Control = Me.instansiTextEdit
        Me.ItemForinstansi.Location = New System.Drawing.Point(0, 41)
        Me.ItemForinstansi.Name = "ItemForinstansi"
        Me.ItemForinstansi.Size = New System.Drawing.Size(268, 24)
        Me.ItemForinstansi.Text = "instansi"
        Me.ItemForinstansi.TextSize = New System.Drawing.Size(76, 13)
        '
        'alamatMemoEdit
        '
        Me.alamatMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PendidikanNonFormalBindingSource, "alamat", True))
        Me.alamatMemoEdit.Location = New System.Drawing.Point(92, 77)
        Me.alamatMemoEdit.Name = "alamatMemoEdit"
        Me.alamatMemoEdit.Size = New System.Drawing.Size(184, 243)
        Me.alamatMemoEdit.StyleController = Me.DataLayoutControl1
        Me.alamatMemoEdit.TabIndex = 6
        '
        'ItemForalamat
        '
        Me.ItemForalamat.Control = Me.alamatMemoEdit
        Me.ItemForalamat.Location = New System.Drawing.Point(0, 65)
        Me.ItemForalamat.Name = "ItemForalamat"
        Me.ItemForalamat.Size = New System.Drawing.Size(268, 247)
        Me.ItemForalamat.StartNewLine = True
        Me.ItemForalamat.Text = "alamat"
        Me.ItemForalamat.TextSize = New System.Drawing.Size(76, 13)
        '
        'nomorSertifikatTextEdit
        '
        Me.nomorSertifikatTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PendidikanNonFormalBindingSource, "nomorSertifikat", True))
        Me.nomorSertifikatTextEdit.Location = New System.Drawing.Point(92, 324)
        Me.nomorSertifikatTextEdit.Name = "nomorSertifikatTextEdit"
        Me.nomorSertifikatTextEdit.Size = New System.Drawing.Size(184, 20)
        Me.nomorSertifikatTextEdit.StyleController = Me.DataLayoutControl1
        Me.nomorSertifikatTextEdit.TabIndex = 7
        '
        'ItemFornomorSertifikat
        '
        Me.ItemFornomorSertifikat.Control = Me.nomorSertifikatTextEdit
        Me.ItemFornomorSertifikat.Location = New System.Drawing.Point(0, 312)
        Me.ItemFornomorSertifikat.Name = "ItemFornomorSertifikat"
        Me.ItemFornomorSertifikat.Size = New System.Drawing.Size(268, 24)
        Me.ItemFornomorSertifikat.Text = "nomor Sertifikat"
        Me.ItemFornomorSertifikat.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.PendidikanNonFormalGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(268, 17)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(355, 319)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.StyleController = Me.DataLayoutControl1
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "LabelControl1"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.LabelControl1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(623, 17)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'FormPendidikanNonFormal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 381)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.PendidikanNonFormalBindingNavigator)
        Me.Name = "FormPendidikanNonFormal"
        Me.Text = "FormPendidikanNonFormal"
        CType(Me.DataSetPelengkapPendaftaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PendidikanNonFormalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PendidikanNonFormalBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PendidikanNonFormalBindingNavigator.ResumeLayout(False)
        Me.PendidikanNonFormalBindingNavigator.PerformLayout()
        CType(Me.PendidikanNonFormalGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pendidikanTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForpendidikan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.instansiTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForinstansi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alamatMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForalamat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nomorSertifikatTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFornomorSertifikat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetPelengkapPendaftaran As DataSetPelengkapPendaftaran
    Friend WithEvents PendidikanNonFormalBindingSource As BindingSource
    Friend WithEvents PendidikanNonFormalTableAdapter As DataSetPelengkapPendaftaranTableAdapters.pendidikanNonFormalTableAdapter
    Friend WithEvents TableAdapterManager As DataSetPelengkapPendaftaranTableAdapters.TableAdapterManager
    Friend WithEvents PendidikanNonFormalBindingNavigator As BindingNavigator
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
    Friend WithEvents PendidikanNonFormalBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PendidikanNonFormalGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colidPendaftar As XtraGrid.Columns.GridColumn
    Friend WithEvents colpendidikan As XtraGrid.Columns.GridColumn
    Friend WithEvents colinstansi As XtraGrid.Columns.GridColumn
    Friend WithEvents colalamat As XtraGrid.Columns.GridColumn
    Friend WithEvents colnomorSertifikat As XtraGrid.Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As XtraDataLayout.DataLayoutControl
    Friend WithEvents pendidikanTextEdit As TextEdit
    Friend WithEvents instansiTextEdit As TextEdit
    Friend WithEvents alamatMemoEdit As MemoEdit
    Friend WithEvents nomorSertifikatTextEdit As TextEdit
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForpendidikan As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForinstansi As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForalamat As XtraLayout.LayoutControlItem
    Friend WithEvents ItemFornomorSertifikat As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
    Friend WithEvents LabelControl1 As LabelControl
    Friend WithEvents LayoutControlItem2 As XtraLayout.LayoutControlItem
End Class
