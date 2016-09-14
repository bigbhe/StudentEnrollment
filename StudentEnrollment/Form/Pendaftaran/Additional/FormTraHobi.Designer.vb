<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTraHobi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTraHobi))
        Me.DataSetPelengkapPendaftaran = New StudentEnrollment.DataSetPelengkapPendaftaran()
        Me.PelamarHobiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PelamarHobiTableAdapter = New StudentEnrollment.DataSetPelengkapPendaftaranTableAdapters.pelamarHobiTableAdapter()
        Me.TableAdapterManager = New StudentEnrollment.DataSetPelengkapPendaftaranTableAdapters.TableAdapterManager()
        Me.PelamarHobiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PelamarHobiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PelamarHobiGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidPelamar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidHobi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PelamarHobiBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstHobiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstHobiTableAdapter = New StudentEnrollment.DataSetPelengkapPendaftaranTableAdapters.mstHobiTableAdapter()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DataSetPelengkapPendaftaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PelamarHobiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PelamarHobiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PelamarHobiBindingNavigator.SuspendLayout()
        CType(Me.PelamarHobiGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PelamarHobiBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstHobiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetPelengkapPendaftaran
        '
        Me.DataSetPelengkapPendaftaran.DataSetName = "DataSetPelengkapPendaftaran"
        Me.DataSetPelengkapPendaftaran.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PelamarHobiBindingSource
        '
        Me.PelamarHobiBindingSource.DataMember = "pelamarHobi"
        Me.PelamarHobiBindingSource.DataSource = Me.DataSetPelengkapPendaftaran
        '
        'PelamarHobiTableAdapter
        '
        Me.PelamarHobiTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.pelamarHobiTableAdapter = Me.PelamarHobiTableAdapter
        Me.TableAdapterManager.pendidikanNonFormalTableAdapter = Nothing
        Me.TableAdapterManager.pengalamanOrganisasiTableAdapter = Nothing
        Me.TableAdapterManager.prestasiTableAdapter = Nothing
        Me.TableAdapterManager.traNilaiUNTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = StudentEnrollment.DataSetPelengkapPendaftaranTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PelamarHobiBindingNavigator
        '
        Me.PelamarHobiBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PelamarHobiBindingNavigator.BindingSource = Me.PelamarHobiBindingSource
        Me.PelamarHobiBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PelamarHobiBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PelamarHobiBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PelamarHobiBindingNavigatorSaveItem})
        Me.PelamarHobiBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PelamarHobiBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PelamarHobiBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PelamarHobiBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PelamarHobiBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PelamarHobiBindingNavigator.Name = "PelamarHobiBindingNavigator"
        Me.PelamarHobiBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PelamarHobiBindingNavigator.Size = New System.Drawing.Size(686, 25)
        Me.PelamarHobiBindingNavigator.TabIndex = 0
        Me.PelamarHobiBindingNavigator.Text = "BindingNavigator1"
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
        'PelamarHobiBindingNavigatorSaveItem
        '
        Me.PelamarHobiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PelamarHobiBindingNavigatorSaveItem.Image = CType(resources.GetObject("PelamarHobiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PelamarHobiBindingNavigatorSaveItem.Name = "PelamarHobiBindingNavigatorSaveItem"
        Me.PelamarHobiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PelamarHobiBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PelamarHobiGridControl
        '
        Me.PelamarHobiGridControl.DataSource = Me.PelamarHobiBindingSource
        Me.PelamarHobiGridControl.Location = New System.Drawing.Point(12, 29)
        Me.PelamarHobiGridControl.MainView = Me.GridView1
        Me.PelamarHobiGridControl.Name = "PelamarHobiGridControl"
        Me.PelamarHobiGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.PelamarHobiGridControl.Size = New System.Drawing.Size(662, 495)
        Me.PelamarHobiGridControl.TabIndex = 2
        Me.PelamarHobiGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colidPelamar, Me.colidHobi})
        Me.GridView1.GridControl = Me.PelamarHobiGridControl
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
        'colidHobi
        '
        Me.colidHobi.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colidHobi.FieldName = "idHobi"
        Me.colidHobi.Name = "colidHobi"
        Me.colidHobi.Visible = True
        Me.colidHobi.VisibleIndex = 0
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.MstHobiBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "varchar"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "id"
        '
        'PelamarHobiBindingSource1
        '
        Me.PelamarHobiBindingSource1.DataMember = "pelamarHobi"
        Me.PelamarHobiBindingSource1.DataSource = Me.DataSetPelengkapPendaftaran
        '
        'MstHobiBindingSource
        '
        Me.MstHobiBindingSource.DataMember = "mstHobi"
        Me.MstHobiBindingSource.DataSource = Me.DataSetPelengkapPendaftaran
        '
        'MstHobiTableAdapter
        '
        Me.MstHobiTableAdapter.ClearBeforeFill = True
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.LabelControl1)
        Me.LayoutControl1.Controls.Add(Me.PelamarHobiGridControl)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(686, 536)
        Me.LayoutControl1.TabIndex = 3
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(686, 536)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.PelamarHobiGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 17)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(666, 499)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.StyleController = Me.LayoutControl1
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "LabelControl1"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.LabelControl1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(666, 17)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'FormTraHobi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 561)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.PelamarHobiBindingNavigator)
        Me.Name = "FormTraHobi"
        Me.Text = "FormTraHobi"
        CType(Me.DataSetPelengkapPendaftaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PelamarHobiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PelamarHobiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PelamarHobiBindingNavigator.ResumeLayout(False)
        Me.PelamarHobiBindingNavigator.PerformLayout()
        CType(Me.PelamarHobiGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PelamarHobiBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstHobiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetPelengkapPendaftaran As DataSetPelengkapPendaftaran
    Friend WithEvents PelamarHobiBindingSource As BindingSource
    Friend WithEvents PelamarHobiTableAdapter As DataSetPelengkapPendaftaranTableAdapters.pelamarHobiTableAdapter
    Friend WithEvents TableAdapterManager As DataSetPelengkapPendaftaranTableAdapters.TableAdapterManager
    Friend WithEvents PelamarHobiBindingNavigator As BindingNavigator
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
    Friend WithEvents PelamarHobiBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PelamarHobiGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colidPelamar As XtraGrid.Columns.GridColumn
    Friend WithEvents colidHobi As XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As Repository.RepositoryItemLookUpEdit
    Friend WithEvents PelamarHobiBindingSource1 As BindingSource
    Friend WithEvents MstHobiBindingSource As BindingSource
    Friend WithEvents MstHobiTableAdapter As DataSetPelengkapPendaftaranTableAdapters.mstHobiTableAdapter
    Friend WithEvents LayoutControl1 As XtraLayout.LayoutControl
    Friend WithEvents LabelControl1 As LabelControl
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As XtraLayout.LayoutControlItem
End Class
