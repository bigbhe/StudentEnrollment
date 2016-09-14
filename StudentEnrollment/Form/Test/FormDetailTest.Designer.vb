<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetailTest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDetailTest))
        Me.DataSetTest = New StudentEnrollment.DataSetTest()
        Me.DetailtestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetailtestTableAdapter = New StudentEnrollment.DataSetTestTableAdapters.detailTestTableAdapter()
        Me.TableAdapterManager = New StudentEnrollment.DataSetTestTableAdapters.TableAdapterManager()
        Me.DetailtestBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DetailtestBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DetailtestGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colidSiswa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNomorPendaftaran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidGelombang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnilai = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisInsert = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidHeader = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DataSetTest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailtestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailtestBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DetailtestBindingNavigator.SuspendLayout()
        CType(Me.DetailtestGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetTest
        '
        Me.DataSetTest.DataSetName = "DataSetTest"
        Me.DataSetTest.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DetailtestBindingSource
        '
        Me.DetailtestBindingSource.DataMember = "detailtest"
        Me.DetailtestBindingSource.DataSource = Me.DataSetTest
        '
        'DetailtestTableAdapter
        '
        Me.DetailtestTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.detailTestTableAdapter = Me.DetailtestTableAdapter
        Me.TableAdapterManager.headerTestTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = StudentEnrollment.DataSetTestTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DetailtestBindingNavigator
        '
        Me.DetailtestBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DetailtestBindingNavigator.BindingSource = Me.DetailtestBindingSource
        Me.DetailtestBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DetailtestBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DetailtestBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DetailtestBindingNavigatorSaveItem})
        Me.DetailtestBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DetailtestBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DetailtestBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DetailtestBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DetailtestBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DetailtestBindingNavigator.Name = "DetailtestBindingNavigator"
        Me.DetailtestBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DetailtestBindingNavigator.Size = New System.Drawing.Size(865, 25)
        Me.DetailtestBindingNavigator.TabIndex = 0
        Me.DetailtestBindingNavigator.Text = "BindingNavigator1"
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
        'DetailtestBindingNavigatorSaveItem
        '
        Me.DetailtestBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DetailtestBindingNavigatorSaveItem.Image = CType(resources.GetObject("DetailtestBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DetailtestBindingNavigatorSaveItem.Name = "DetailtestBindingNavigatorSaveItem"
        Me.DetailtestBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DetailtestBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DetailtestGridControl
        '
        Me.DetailtestGridControl.DataSource = Me.DetailtestBindingSource
        Me.DetailtestGridControl.Location = New System.Drawing.Point(12, 29)
        Me.DetailtestGridControl.MainView = Me.GridView1
        Me.DetailtestGridControl.Name = "DetailtestGridControl"
        Me.DetailtestGridControl.Size = New System.Drawing.Size(841, 627)
        Me.DetailtestGridControl.TabIndex = 2
        Me.DetailtestGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colidSiswa, Me.colnama, Me.colNomorPendaftaran, Me.colidGelombang, Me.colnilai, Me.colisInsert, Me.colidHeader})
        Me.GridView1.GridControl = Me.DetailtestGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colidSiswa
        '
        Me.colidSiswa.FieldName = "idSiswa"
        Me.colidSiswa.Name = "colidSiswa"
        '
        'colnama
        '
        Me.colnama.FieldName = "nama"
        Me.colnama.Name = "colnama"
        Me.colnama.Visible = True
        Me.colnama.VisibleIndex = 0
        '
        'colNomorPendaftaran
        '
        Me.colNomorPendaftaran.FieldName = "NomorPendaftaran"
        Me.colNomorPendaftaran.Name = "colNomorPendaftaran"
        Me.colNomorPendaftaran.Visible = True
        Me.colNomorPendaftaran.VisibleIndex = 1
        '
        'colidGelombang
        '
        Me.colidGelombang.FieldName = "idGelombang"
        Me.colidGelombang.Name = "colidGelombang"
        '
        'colnilai
        '
        Me.colnilai.FieldName = "nilai"
        Me.colnilai.Name = "colnilai"
        Me.colnilai.Visible = True
        Me.colnilai.VisibleIndex = 2
        '
        'colisInsert
        '
        Me.colisInsert.FieldName = "isInsert"
        Me.colisInsert.Name = "colisInsert"
        '
        'colidHeader
        '
        Me.colidHeader.FieldName = "idHeader"
        Me.colidHeader.Name = "colidHeader"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.LabelControl1)
        Me.LayoutControl1.Controls.Add(Me.DetailtestGridControl)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(320, 217, 514, 493)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(865, 668)
        Me.LayoutControl1.TabIndex = 3
        Me.LayoutControl1.Text = "LayoutControl1"
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
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(865, 668)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.DetailtestGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 17)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(845, 631)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.LabelControl1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(845, 17)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'FormDetailTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 693)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DetailtestBindingNavigator)
        Me.Name = "FormDetailTest"
        Me.Text = "FormDetailTest"
        CType(Me.DataSetTest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailtestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailtestBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DetailtestBindingNavigator.ResumeLayout(False)
        Me.DetailtestBindingNavigator.PerformLayout()
        CType(Me.DetailtestGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetTest As DataSetTest
    Friend WithEvents DetailtestBindingSource As BindingSource
    Friend WithEvents DetailtestTableAdapter As DataSetTestTableAdapters.detailtestTableAdapter
    Friend WithEvents TableAdapterManager As DataSetTestTableAdapters.TableAdapterManager
    Friend WithEvents DetailtestBindingNavigator As BindingNavigator
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
    Friend WithEvents DetailtestBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DetailtestGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControl1 As XtraLayout.LayoutControl
    Friend WithEvents LabelControl1 As LabelControl
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As XtraLayout.LayoutControlItem
    Friend WithEvents colidSiswa As XtraGrid.Columns.GridColumn
    Friend WithEvents colnama As XtraGrid.Columns.GridColumn
    Friend WithEvents colNomorPendaftaran As XtraGrid.Columns.GridColumn
    Friend WithEvents colidGelombang As XtraGrid.Columns.GridColumn
    Friend WithEvents colnilai As XtraGrid.Columns.GridColumn
    Friend WithEvents colisInsert As XtraGrid.Columns.GridColumn
    Friend WithEvents colidHeader As XtraGrid.Columns.GridColumn
End Class
