<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNilaiUN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNilaiUN))
        Me.DataSetPelengkapPendaftaran = New StudentEnrollment.DataSetPelengkapPendaftaran()
        Me.TraNilaiUNBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TraNilaiUNTableAdapter = New StudentEnrollment.DataSetPelengkapPendaftaranTableAdapters.traNilaiUNTableAdapter()
        Me.TableAdapterManager = New StudentEnrollment.DataSetPelengkapPendaftaranTableAdapters.TableAdapterManager()
        Me.TraNilaiUNBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TraNilaiUNBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TraNilaiUNGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidPelamar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidUjian = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MstMataPelajaranBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colnilai = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.labelInfo = New DevExpress.XtraEditors.LabelControl()
        Me.idUjianLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.nilaiTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForidUjian = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemFornilai = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.MstMataPelajaranTableAdapter = New StudentEnrollment.DataSetPelengkapPendaftaranTableAdapters.mstMataPelajaranTableAdapter()
        CType(Me.DataSetPelengkapPendaftaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraNilaiUNBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraNilaiUNBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TraNilaiUNBindingNavigator.SuspendLayout()
        CType(Me.TraNilaiUNGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstMataPelajaranBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.idUjianLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nilaiTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidUjian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFornilai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetPelengkapPendaftaran
        '
        Me.DataSetPelengkapPendaftaran.DataSetName = "DataSetPelengkapPendaftaran"
        Me.DataSetPelengkapPendaftaran.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TraNilaiUNBindingSource
        '
        Me.TraNilaiUNBindingSource.DataMember = "traNilaiUN"
        Me.TraNilaiUNBindingSource.DataSource = Me.DataSetPelengkapPendaftaran
        '
        'TraNilaiUNTableAdapter
        '
        Me.TraNilaiUNTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.pelamarHobiTableAdapter = Nothing
        Me.TableAdapterManager.pendidikanNonFormalTableAdapter = Nothing
        Me.TableAdapterManager.pengalamanOrganisasiTableAdapter = Nothing
        Me.TableAdapterManager.prestasiTableAdapter = Nothing
        Me.TableAdapterManager.traNilaiUNTableAdapter = Me.TraNilaiUNTableAdapter
        Me.TableAdapterManager.UpdateOrder = StudentEnrollment.DataSetPelengkapPendaftaranTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TraNilaiUNBindingNavigator
        '
        Me.TraNilaiUNBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TraNilaiUNBindingNavigator.BindingSource = Me.TraNilaiUNBindingSource
        Me.TraNilaiUNBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TraNilaiUNBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TraNilaiUNBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TraNilaiUNBindingNavigatorSaveItem})
        Me.TraNilaiUNBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TraNilaiUNBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TraNilaiUNBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TraNilaiUNBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TraNilaiUNBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TraNilaiUNBindingNavigator.Name = "TraNilaiUNBindingNavigator"
        Me.TraNilaiUNBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TraNilaiUNBindingNavigator.Size = New System.Drawing.Size(373, 25)
        Me.TraNilaiUNBindingNavigator.TabIndex = 0
        Me.TraNilaiUNBindingNavigator.Text = "BindingNavigator1"
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
        'TraNilaiUNBindingNavigatorSaveItem
        '
        Me.TraNilaiUNBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TraNilaiUNBindingNavigatorSaveItem.Image = CType(resources.GetObject("TraNilaiUNBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TraNilaiUNBindingNavigatorSaveItem.Name = "TraNilaiUNBindingNavigatorSaveItem"
        Me.TraNilaiUNBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TraNilaiUNBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TraNilaiUNGridControl
        '
        Me.TraNilaiUNGridControl.DataSource = Me.TraNilaiUNBindingSource
        Me.TraNilaiUNGridControl.Location = New System.Drawing.Point(12, 77)
        Me.TraNilaiUNGridControl.MainView = Me.GridView1
        Me.TraNilaiUNGridControl.Name = "TraNilaiUNGridControl"
        Me.TraNilaiUNGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.TraNilaiUNGridControl.Size = New System.Drawing.Size(349, 522)
        Me.TraNilaiUNGridControl.TabIndex = 2
        Me.TraNilaiUNGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colidPelamar, Me.colidUjian, Me.colnilai})
        Me.GridView1.GridControl = Me.TraNilaiUNGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colidPelamar
        '
        Me.colidPelamar.FieldName = "idPelamar"
        Me.colidPelamar.Name = "colidPelamar"
        '
        'colidUjian
        '
        Me.colidUjian.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colidUjian.FieldName = "idUjian"
        Me.colidUjian.Name = "colidUjian"
        Me.colidUjian.Visible = True
        Me.colidUjian.VisibleIndex = 0
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.MstMataPelajaranBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "mataPelajaran"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "id"
        '
        'MstMataPelajaranBindingSource
        '
        Me.MstMataPelajaranBindingSource.DataMember = "mstMataPelajaran"
        Me.MstMataPelajaranBindingSource.DataSource = Me.DataSetPelengkapPendaftaran
        '
        'colnilai
        '
        Me.colnilai.FieldName = "nilai"
        Me.colnilai.Name = "colnilai"
        Me.colnilai.Visible = True
        Me.colnilai.VisibleIndex = 1
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.labelInfo)
        Me.DataLayoutControl1.Controls.Add(Me.TraNilaiUNGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.idUjianLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.nilaiTextEdit)
        Me.DataLayoutControl1.DataSource = Me.TraNilaiUNBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(373, 611)
        Me.DataLayoutControl1.TabIndex = 3
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'labelInfo
        '
        Me.labelInfo.Location = New System.Drawing.Point(12, 12)
        Me.labelInfo.Name = "labelInfo"
        Me.labelInfo.Size = New System.Drawing.Size(66, 13)
        Me.labelInfo.StyleController = Me.DataLayoutControl1
        Me.labelInfo.TabIndex = 4
        Me.labelInfo.Text = "LabelControl1"
        '
        'idUjianLookUpEdit
        '
        Me.idUjianLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TraNilaiUNBindingSource, "idUjian", True))
        Me.idUjianLookUpEdit.Location = New System.Drawing.Point(50, 29)
        Me.idUjianLookUpEdit.Name = "idUjianLookUpEdit"
        Me.idUjianLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idUjianLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idUjianLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idUjianLookUpEdit.Properties.DataSource = Me.MstMataPelajaranBindingSource
        Me.idUjianLookUpEdit.Properties.DisplayMember = "mataPelajaran"
        Me.idUjianLookUpEdit.Properties.NullText = ""
        Me.idUjianLookUpEdit.Properties.ValueMember = "id"
        Me.idUjianLookUpEdit.Size = New System.Drawing.Size(311, 20)
        Me.idUjianLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.idUjianLookUpEdit.TabIndex = 4
        '
        'nilaiTextEdit
        '
        Me.nilaiTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TraNilaiUNBindingSource, "nilai", True))
        Me.nilaiTextEdit.Location = New System.Drawing.Point(50, 53)
        Me.nilaiTextEdit.Name = "nilaiTextEdit"
        Me.nilaiTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.nilaiTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.nilaiTextEdit.Properties.Mask.EditMask = "N0"
        Me.nilaiTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.nilaiTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.nilaiTextEdit.Size = New System.Drawing.Size(311, 20)
        Me.nilaiTextEdit.StyleController = Me.DataLayoutControl1
        Me.nilaiTextEdit.TabIndex = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(373, 611)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForidUjian, Me.ItemFornilai, Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(353, 591)
        '
        'ItemForidUjian
        '
        Me.ItemForidUjian.Control = Me.idUjianLookUpEdit
        Me.ItemForidUjian.Location = New System.Drawing.Point(0, 17)
        Me.ItemForidUjian.Name = "ItemForidUjian"
        Me.ItemForidUjian.Size = New System.Drawing.Size(353, 24)
        Me.ItemForidUjian.Text = "id Ujian"
        Me.ItemForidUjian.TextSize = New System.Drawing.Size(35, 13)
        '
        'ItemFornilai
        '
        Me.ItemFornilai.Control = Me.nilaiTextEdit
        Me.ItemFornilai.Location = New System.Drawing.Point(0, 41)
        Me.ItemFornilai.Name = "ItemFornilai"
        Me.ItemFornilai.Size = New System.Drawing.Size(353, 24)
        Me.ItemFornilai.Text = "nilai"
        Me.ItemFornilai.TextSize = New System.Drawing.Size(35, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TraNilaiUNGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 65)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(353, 526)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.labelInfo
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(353, 17)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'MstMataPelajaranTableAdapter
        '
        Me.MstMataPelajaranTableAdapter.ClearBeforeFill = True
        '
        'FormNilaiUN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 636)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.TraNilaiUNBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormNilaiUN"
        Me.Text = "FormNilaiUN"
        CType(Me.DataSetPelengkapPendaftaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraNilaiUNBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraNilaiUNBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TraNilaiUNBindingNavigator.ResumeLayout(False)
        Me.TraNilaiUNBindingNavigator.PerformLayout()
        CType(Me.TraNilaiUNGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstMataPelajaranBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.idUjianLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nilaiTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidUjian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFornilai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetPelengkapPendaftaran As DataSetPelengkapPendaftaran
    Friend WithEvents TraNilaiUNBindingSource As BindingSource
    Friend WithEvents TraNilaiUNTableAdapter As DataSetPelengkapPendaftaranTableAdapters.traNilaiUNTableAdapter
    Friend WithEvents TableAdapterManager As DataSetPelengkapPendaftaranTableAdapters.TableAdapterManager
    Friend WithEvents TraNilaiUNBindingNavigator As BindingNavigator
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
    Friend WithEvents TraNilaiUNBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TraNilaiUNGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colidPelamar As XtraGrid.Columns.GridColumn
    Friend WithEvents colidUjian As XtraGrid.Columns.GridColumn
    Friend WithEvents colnilai As XtraGrid.Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As XtraDataLayout.DataLayoutControl
    Friend WithEvents idUjianLookUpEdit As LookUpEdit
    Friend WithEvents nilaiTextEdit As TextEdit
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForidUjian As XtraLayout.LayoutControlItem
    Friend WithEvents ItemFornilai As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
    Friend WithEvents labelInfo As LabelControl
    Friend WithEvents LayoutControlItem2 As XtraLayout.LayoutControlItem
    Friend WithEvents MstMataPelajaranBindingSource As BindingSource
    Friend WithEvents MstMataPelajaranTableAdapter As DataSetPelengkapPendaftaranTableAdapters.mstMataPelajaranTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit1 As Repository.RepositoryItemLookUpEdit
End Class
