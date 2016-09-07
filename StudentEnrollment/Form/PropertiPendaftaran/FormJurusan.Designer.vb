<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJurusan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormJurusan))
        Me.DataSetPropertiPendaftaran = New StudentEnrollment.DataSetPropertiPendaftaran()
        Me.MstJurusanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstJurusanTableAdapter = New StudentEnrollment.DataSetPropertiPendaftaranTableAdapters.mstJurusanTableAdapter()
        Me.TableAdapterManager = New StudentEnrollment.DataSetPropertiPendaftaranTableAdapters.TableAdapterManager()
        Me.MstJurusanBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MstJurusanBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MstJurusanGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJurusan = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetPropertiPendaftaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstJurusanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstJurusanBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MstJurusanBindingNavigator.SuspendLayout()
        CType(Me.MstJurusanGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetPropertiPendaftaran
        '
        Me.DataSetPropertiPendaftaran.DataSetName = "DataSetPropertiPendaftaran"
        Me.DataSetPropertiPendaftaran.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MstJurusanBindingSource
        '
        Me.MstJurusanBindingSource.DataMember = "mstJurusan"
        Me.MstJurusanBindingSource.DataSource = Me.DataSetPropertiPendaftaran
        '
        'MstJurusanTableAdapter
        '
        Me.MstJurusanTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mstHobiTableAdapter = Nothing
        Me.TableAdapterManager.mstJurusanTableAdapter = Me.MstJurusanTableAdapter
        Me.TableAdapterManager.mstMataPelajaranTableAdapter = Nothing
        Me.TableAdapterManager.mstTestTableAdapter = Nothing
        Me.TableAdapterManager.statusTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = StudentEnrollment.DataSetPropertiPendaftaranTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MstJurusanBindingNavigator
        '
        Me.MstJurusanBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MstJurusanBindingNavigator.BindingSource = Me.MstJurusanBindingSource
        Me.MstJurusanBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MstJurusanBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MstJurusanBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MstJurusanBindingNavigatorSaveItem})
        Me.MstJurusanBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MstJurusanBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MstJurusanBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MstJurusanBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MstJurusanBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MstJurusanBindingNavigator.Name = "MstJurusanBindingNavigator"
        Me.MstJurusanBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MstJurusanBindingNavigator.Size = New System.Drawing.Size(364, 25)
        Me.MstJurusanBindingNavigator.TabIndex = 0
        Me.MstJurusanBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'MstJurusanBindingNavigatorSaveItem
        '
        Me.MstJurusanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MstJurusanBindingNavigatorSaveItem.Image = CType(resources.GetObject("MstJurusanBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MstJurusanBindingNavigatorSaveItem.Name = "MstJurusanBindingNavigatorSaveItem"
        Me.MstJurusanBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.MstJurusanBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MstJurusanGridControl
        '
        Me.MstJurusanGridControl.DataSource = Me.MstJurusanBindingSource
        Me.MstJurusanGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MstJurusanGridControl.Location = New System.Drawing.Point(0, 25)
        Me.MstJurusanGridControl.MainView = Me.GridView1
        Me.MstJurusanGridControl.Name = "MstJurusanGridControl"
        Me.MstJurusanGridControl.Size = New System.Drawing.Size(364, 603)
        Me.MstJurusanGridControl.TabIndex = 1
        Me.MstJurusanGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colJurusan})
        Me.GridView1.GridControl = Me.MstJurusanGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colJurusan
        '
        Me.colJurusan.FieldName = "Jurusan"
        Me.colJurusan.Name = "colJurusan"
        Me.colJurusan.Visible = True
        Me.colJurusan.VisibleIndex = 0
        '
        'FormJurusan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 628)
        Me.Controls.Add(Me.MstJurusanGridControl)
        Me.Controls.Add(Me.MstJurusanBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormJurusan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormJurusan"
        CType(Me.DataSetPropertiPendaftaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstJurusanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstJurusanBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MstJurusanBindingNavigator.ResumeLayout(False)
        Me.MstJurusanBindingNavigator.PerformLayout()
        CType(Me.MstJurusanGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetPropertiPendaftaran As DataSetPropertiPendaftaran
    Friend WithEvents MstJurusanBindingSource As BindingSource
    Friend WithEvents MstJurusanTableAdapter As DataSetPropertiPendaftaranTableAdapters.mstJurusanTableAdapter
    Friend WithEvents TableAdapterManager As DataSetPropertiPendaftaranTableAdapters.TableAdapterManager
    Friend WithEvents MstJurusanBindingNavigator As BindingNavigator
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
    Friend WithEvents MstJurusanBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MstJurusanGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colJurusan As XtraGrid.Columns.GridColumn
End Class
