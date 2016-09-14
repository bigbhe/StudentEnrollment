<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPengalamanOrganisasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPengalamanOrganisasi))
        Me.DataSetPelengkapPendaftaran = New StudentEnrollment.DataSetPelengkapPendaftaran()
        Me.PengalamanOrganisasiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PengalamanOrganisasiTableAdapter = New StudentEnrollment.DataSetPelengkapPendaftaranTableAdapters.pengalamanOrganisasiTableAdapter()
        Me.TableAdapterManager = New StudentEnrollment.DataSetPelengkapPendaftaranTableAdapters.TableAdapterManager()
        Me.PengalamanOrganisasiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.PengalamanOrganisasiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PengalamanOrganisasiGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.OrganisasiTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForOrganisasi = New DevExpress.XtraLayout.LayoutControlItem()
        Me.jabatanTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForjabatan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.keteranganMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.ItemForketerangan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidPelamar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrganisasi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coljabatan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colketerangan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DataSetPelengkapPendaftaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PengalamanOrganisasiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PengalamanOrganisasiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PengalamanOrganisasiBindingNavigator.SuspendLayout()
        CType(Me.PengalamanOrganisasiGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrganisasiTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForOrganisasi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jabatanTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForjabatan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keteranganMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForketerangan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetPelengkapPendaftaran
        '
        Me.DataSetPelengkapPendaftaran.DataSetName = "DataSetPelengkapPendaftaran"
        Me.DataSetPelengkapPendaftaran.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PengalamanOrganisasiBindingSource
        '
        Me.PengalamanOrganisasiBindingSource.DataMember = "pengalamanOrganisasi"
        Me.PengalamanOrganisasiBindingSource.DataSource = Me.DataSetPelengkapPendaftaran
        '
        'PengalamanOrganisasiTableAdapter
        '
        Me.PengalamanOrganisasiTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.pelamarHobiTableAdapter = Nothing
        Me.TableAdapterManager.pendidikanNonFormalTableAdapter = Nothing
        Me.TableAdapterManager.pengalamanOrganisasiTableAdapter = Me.PengalamanOrganisasiTableAdapter
        Me.TableAdapterManager.prestasiTableAdapter = Nothing
        Me.TableAdapterManager.traNilaiUNTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = StudentEnrollment.DataSetPelengkapPendaftaranTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PengalamanOrganisasiBindingNavigator
        '
        Me.PengalamanOrganisasiBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PengalamanOrganisasiBindingNavigator.BindingSource = Me.PengalamanOrganisasiBindingSource
        Me.PengalamanOrganisasiBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PengalamanOrganisasiBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PengalamanOrganisasiBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PengalamanOrganisasiBindingNavigatorSaveItem})
        Me.PengalamanOrganisasiBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PengalamanOrganisasiBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PengalamanOrganisasiBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PengalamanOrganisasiBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PengalamanOrganisasiBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PengalamanOrganisasiBindingNavigator.Name = "PengalamanOrganisasiBindingNavigator"
        Me.PengalamanOrganisasiBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PengalamanOrganisasiBindingNavigator.Size = New System.Drawing.Size(703, 25)
        Me.PengalamanOrganisasiBindingNavigator.TabIndex = 0
        Me.PengalamanOrganisasiBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'PengalamanOrganisasiBindingNavigatorSaveItem
        '
        Me.PengalamanOrganisasiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PengalamanOrganisasiBindingNavigatorSaveItem.Image = CType(resources.GetObject("PengalamanOrganisasiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PengalamanOrganisasiBindingNavigatorSaveItem.Name = "PengalamanOrganisasiBindingNavigatorSaveItem"
        Me.PengalamanOrganisasiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PengalamanOrganisasiBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PengalamanOrganisasiGridControl
        '
        Me.PengalamanOrganisasiGridControl.DataSource = Me.PengalamanOrganisasiBindingSource
        Me.PengalamanOrganisasiGridControl.Location = New System.Drawing.Point(299, 29)
        Me.PengalamanOrganisasiGridControl.MainView = Me.GridView1
        Me.PengalamanOrganisasiGridControl.Name = "PengalamanOrganisasiGridControl"
        Me.PengalamanOrganisasiGridControl.Size = New System.Drawing.Size(392, 455)
        Me.PengalamanOrganisasiGridControl.TabIndex = 2
        Me.PengalamanOrganisasiGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colidPelamar, Me.colOrganisasi, Me.coljabatan, Me.colketerangan})
        Me.GridView1.GridControl = Me.PengalamanOrganisasiGridControl
        Me.GridView1.Name = "GridView1"
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.LabelControl1)
        Me.DataLayoutControl1.Controls.Add(Me.PengalamanOrganisasiGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.OrganisasiTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.jabatanTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.keteranganMemoEdit)
        Me.DataLayoutControl1.DataSource = Me.PengalamanOrganisasiBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(577, 323, 250, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(703, 496)
        Me.DataLayoutControl1.TabIndex = 3
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(703, 496)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForOrganisasi, Me.ItemForjabatan, Me.ItemForketerangan, Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(683, 476)
        '
        'OrganisasiTextEdit
        '
        Me.OrganisasiTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PengalamanOrganisasiBindingSource, "Organisasi", True))
        Me.OrganisasiTextEdit.Location = New System.Drawing.Point(71, 29)
        Me.OrganisasiTextEdit.Name = "OrganisasiTextEdit"
        Me.OrganisasiTextEdit.Size = New System.Drawing.Size(224, 20)
        Me.OrganisasiTextEdit.StyleController = Me.DataLayoutControl1
        Me.OrganisasiTextEdit.TabIndex = 4
        '
        'ItemForOrganisasi
        '
        Me.ItemForOrganisasi.Control = Me.OrganisasiTextEdit
        Me.ItemForOrganisasi.Location = New System.Drawing.Point(0, 17)
        Me.ItemForOrganisasi.Name = "ItemForOrganisasi"
        Me.ItemForOrganisasi.Size = New System.Drawing.Size(287, 24)
        Me.ItemForOrganisasi.Text = "Organisasi"
        Me.ItemForOrganisasi.TextSize = New System.Drawing.Size(55, 13)
        '
        'jabatanTextEdit
        '
        Me.jabatanTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PengalamanOrganisasiBindingSource, "jabatan", True))
        Me.jabatanTextEdit.Location = New System.Drawing.Point(71, 53)
        Me.jabatanTextEdit.Name = "jabatanTextEdit"
        Me.jabatanTextEdit.Size = New System.Drawing.Size(224, 20)
        Me.jabatanTextEdit.StyleController = Me.DataLayoutControl1
        Me.jabatanTextEdit.TabIndex = 5
        '
        'ItemForjabatan
        '
        Me.ItemForjabatan.Control = Me.jabatanTextEdit
        Me.ItemForjabatan.Location = New System.Drawing.Point(0, 41)
        Me.ItemForjabatan.Name = "ItemForjabatan"
        Me.ItemForjabatan.Size = New System.Drawing.Size(287, 24)
        Me.ItemForjabatan.Text = "jabatan"
        Me.ItemForjabatan.TextSize = New System.Drawing.Size(55, 13)
        '
        'keteranganMemoEdit
        '
        Me.keteranganMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PengalamanOrganisasiBindingSource, "keterangan", True))
        Me.keteranganMemoEdit.Location = New System.Drawing.Point(71, 77)
        Me.keteranganMemoEdit.Name = "keteranganMemoEdit"
        Me.keteranganMemoEdit.Size = New System.Drawing.Size(224, 202)
        Me.keteranganMemoEdit.StyleController = Me.DataLayoutControl1
        Me.keteranganMemoEdit.TabIndex = 6
        '
        'ItemForketerangan
        '
        Me.ItemForketerangan.Control = Me.keteranganMemoEdit
        Me.ItemForketerangan.Location = New System.Drawing.Point(0, 65)
        Me.ItemForketerangan.Name = "ItemForketerangan"
        Me.ItemForketerangan.Size = New System.Drawing.Size(287, 206)
        Me.ItemForketerangan.StartNewLine = True
        Me.ItemForketerangan.Text = "keterangan"
        Me.ItemForketerangan.TextSize = New System.Drawing.Size(55, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.PengalamanOrganisasiGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(287, 17)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(396, 459)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 271)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(287, 205)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
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
        'colOrganisasi
        '
        Me.colOrganisasi.FieldName = "Organisasi"
        Me.colOrganisasi.Name = "colOrganisasi"
        Me.colOrganisasi.Visible = True
        Me.colOrganisasi.VisibleIndex = 0
        '
        'coljabatan
        '
        Me.coljabatan.FieldName = "jabatan"
        Me.coljabatan.Name = "coljabatan"
        Me.coljabatan.Visible = True
        Me.coljabatan.VisibleIndex = 1
        '
        'colketerangan
        '
        Me.colketerangan.FieldName = "keterangan"
        Me.colketerangan.Name = "colketerangan"
        Me.colketerangan.Visible = True
        Me.colketerangan.VisibleIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.StyleController = Me.DataLayoutControl1
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "LabelControl1"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.LabelControl1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(683, 17)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'FormPengalamanOrganisasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 521)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.PengalamanOrganisasiBindingNavigator)
        Me.Name = "FormPengalamanOrganisasi"
        Me.Text = "FormPengalamanOrganisasi"
        CType(Me.DataSetPelengkapPendaftaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PengalamanOrganisasiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PengalamanOrganisasiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PengalamanOrganisasiBindingNavigator.ResumeLayout(False)
        Me.PengalamanOrganisasiBindingNavigator.PerformLayout()
        CType(Me.PengalamanOrganisasiGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrganisasiTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForOrganisasi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jabatanTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForjabatan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keteranganMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForketerangan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetPelengkapPendaftaran As DataSetPelengkapPendaftaran
    Friend WithEvents PengalamanOrganisasiBindingSource As BindingSource
    Friend WithEvents PengalamanOrganisasiTableAdapter As DataSetPelengkapPendaftaranTableAdapters.pengalamanOrganisasiTableAdapter
    Friend WithEvents TableAdapterManager As DataSetPelengkapPendaftaranTableAdapters.TableAdapterManager
    Friend WithEvents PengalamanOrganisasiBindingNavigator As BindingNavigator
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
    Friend WithEvents PengalamanOrganisasiBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PengalamanOrganisasiGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colidPelamar As XtraGrid.Columns.GridColumn
    Friend WithEvents colOrganisasi As XtraGrid.Columns.GridColumn
    Friend WithEvents coljabatan As XtraGrid.Columns.GridColumn
    Friend WithEvents colketerangan As XtraGrid.Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As XtraDataLayout.DataLayoutControl
    Friend WithEvents LabelControl1 As LabelControl
    Friend WithEvents OrganisasiTextEdit As TextEdit
    Friend WithEvents jabatanTextEdit As TextEdit
    Friend WithEvents keteranganMemoEdit As MemoEdit
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForOrganisasi As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForjabatan As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForketerangan As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As XtraLayout.LayoutControlItem
End Class
