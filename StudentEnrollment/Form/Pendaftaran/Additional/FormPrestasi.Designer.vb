<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrestasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrestasi))
        Me.DataSetPelengkapPendaftaran = New StudentEnrollment.DataSetPelengkapPendaftaran()
        Me.PrestasiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrestasiTableAdapter = New StudentEnrollment.DataSetPelengkapPendaftaranTableAdapters.prestasiTableAdapter()
        Me.TableAdapterManager = New StudentEnrollment.DataSetPelengkapPendaftaranTableAdapters.TableAdapterManager()
        Me.PrestasiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PrestasiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PrestasiGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.PrestasiBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.prestasiTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForprestasi = New DevExpress.XtraLayout.LayoutControlItem()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidPendaftar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colprestasi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DataSetPelengkapPendaftaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrestasiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrestasiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PrestasiBindingNavigator.SuspendLayout()
        CType(Me.PrestasiGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrestasiBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prestasiTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForprestasi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetPelengkapPendaftaran
        '
        Me.DataSetPelengkapPendaftaran.DataSetName = "DataSetPelengkapPendaftaran"
        Me.DataSetPelengkapPendaftaran.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrestasiBindingSource
        '
        Me.PrestasiBindingSource.DataMember = "prestasi"
        Me.PrestasiBindingSource.DataSource = Me.DataSetPelengkapPendaftaran
        '
        'PrestasiTableAdapter
        '
        Me.PrestasiTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.pelamarHobiTableAdapter = Nothing
        Me.TableAdapterManager.pendidikanNonFormalTableAdapter = Nothing
        Me.TableAdapterManager.pengalamanOrganisasiTableAdapter = Nothing
        Me.TableAdapterManager.prestasiTableAdapter = Me.PrestasiTableAdapter
        Me.TableAdapterManager.traNilaiUNTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = StudentEnrollment.DataSetPelengkapPendaftaranTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PrestasiBindingNavigator
        '
        Me.PrestasiBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PrestasiBindingNavigator.BindingSource = Me.PrestasiBindingSource
        Me.PrestasiBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PrestasiBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PrestasiBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PrestasiBindingNavigatorSaveItem})
        Me.PrestasiBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PrestasiBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PrestasiBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PrestasiBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PrestasiBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PrestasiBindingNavigator.Name = "PrestasiBindingNavigator"
        Me.PrestasiBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PrestasiBindingNavigator.Size = New System.Drawing.Size(485, 25)
        Me.PrestasiBindingNavigator.TabIndex = 0
        Me.PrestasiBindingNavigator.Text = "BindingNavigator1"
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
        'PrestasiBindingNavigatorSaveItem
        '
        Me.PrestasiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrestasiBindingNavigatorSaveItem.Image = CType(resources.GetObject("PrestasiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PrestasiBindingNavigatorSaveItem.Name = "PrestasiBindingNavigatorSaveItem"
        Me.PrestasiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PrestasiBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PrestasiGridControl
        '
        Me.PrestasiGridControl.DataSource = Me.PrestasiBindingSource
        Me.PrestasiGridControl.Location = New System.Drawing.Point(12, 53)
        Me.PrestasiGridControl.MainView = Me.GridView1
        Me.PrestasiGridControl.Name = "PrestasiGridControl"
        Me.PrestasiGridControl.Size = New System.Drawing.Size(461, 522)
        Me.PrestasiGridControl.TabIndex = 2
        Me.PrestasiGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colidPendaftar, Me.colprestasi})
        Me.GridView1.GridControl = Me.PrestasiGridControl
        Me.GridView1.Name = "GridView1"
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.LabelControl1)
        Me.DataLayoutControl1.Controls.Add(Me.PrestasiGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.prestasiTextEdit)
        Me.DataLayoutControl1.DataSource = Me.PrestasiBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(485, 587)
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
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(485, 587)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'PrestasiBindingSource1
        '
        Me.PrestasiBindingSource1.DataMember = "prestasi"
        Me.PrestasiBindingSource1.DataSource = Me.DataSetPelengkapPendaftaran
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForprestasi, Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(465, 567)
        '
        'prestasiTextEdit
        '
        Me.prestasiTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrestasiBindingSource, "prestasi", True))
        Me.prestasiTextEdit.Location = New System.Drawing.Point(54, 29)
        Me.prestasiTextEdit.Name = "prestasiTextEdit"
        Me.prestasiTextEdit.Size = New System.Drawing.Size(419, 20)
        Me.prestasiTextEdit.StyleController = Me.DataLayoutControl1
        Me.prestasiTextEdit.TabIndex = 4
        '
        'ItemForprestasi
        '
        Me.ItemForprestasi.Control = Me.prestasiTextEdit
        Me.ItemForprestasi.Location = New System.Drawing.Point(0, 17)
        Me.ItemForprestasi.Name = "ItemForprestasi"
        Me.ItemForprestasi.Size = New System.Drawing.Size(465, 24)
        Me.ItemForprestasi.Text = "prestasi"
        Me.ItemForprestasi.TextSize = New System.Drawing.Size(38, 13)
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
        'colprestasi
        '
        Me.colprestasi.FieldName = "prestasi"
        Me.colprestasi.Name = "colprestasi"
        Me.colprestasi.Visible = True
        Me.colprestasi.VisibleIndex = 0
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.PrestasiGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 41)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(465, 526)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.StyleController = Me.DataLayoutControl1
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "LabelControl1"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.LabelControl1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(465, 17)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'FormPrestasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 612)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.PrestasiBindingNavigator)
        Me.Name = "FormPrestasi"
        Me.Text = "FormPrestasi"
        CType(Me.DataSetPelengkapPendaftaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrestasiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrestasiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PrestasiBindingNavigator.ResumeLayout(False)
        Me.PrestasiBindingNavigator.PerformLayout()
        CType(Me.PrestasiGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrestasiBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prestasiTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForprestasi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetPelengkapPendaftaran As DataSetPelengkapPendaftaran
    Friend WithEvents PrestasiBindingSource As BindingSource
    Friend WithEvents PrestasiTableAdapter As DataSetPelengkapPendaftaranTableAdapters.prestasiTableAdapter
    Friend WithEvents TableAdapterManager As DataSetPelengkapPendaftaranTableAdapters.TableAdapterManager
    Friend WithEvents PrestasiBindingNavigator As BindingNavigator
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
    Friend WithEvents PrestasiBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PrestasiGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colidPendaftar As XtraGrid.Columns.GridColumn
    Friend WithEvents colprestasi As XtraGrid.Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As XtraDataLayout.DataLayoutControl
    Friend WithEvents LabelControl1 As LabelControl
    Friend WithEvents prestasiTextEdit As TextEdit
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForprestasi As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As XtraLayout.LayoutControlItem
    Friend WithEvents PrestasiBindingSource1 As BindingSource
End Class
