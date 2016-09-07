<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterTest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMasterTest))
        Me.DataSetPropertiPendaftaran = New StudentEnrollment.DataSetPropertiPendaftaran()
        Me.MstTestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstTestTableAdapter = New StudentEnrollment.DataSetPropertiPendaftaranTableAdapters.mstTestTableAdapter()
        Me.TableAdapterManager = New StudentEnrollment.DataSetPropertiPendaftaranTableAdapters.TableAdapterManager()
        Me.MstTestBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MstTestBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MstTestGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNamaTest = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetPropertiPendaftaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstTestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstTestBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MstTestBindingNavigator.SuspendLayout()
        CType(Me.MstTestGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetPropertiPendaftaran
        '
        Me.DataSetPropertiPendaftaran.DataSetName = "DataSetPropertiPendaftaran"
        Me.DataSetPropertiPendaftaran.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MstTestBindingSource
        '
        Me.MstTestBindingSource.DataMember = "mstTest"
        Me.MstTestBindingSource.DataSource = Me.DataSetPropertiPendaftaran
        '
        'MstTestTableAdapter
        '
        Me.MstTestTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mstHobiTableAdapter = Nothing
        Me.TableAdapterManager.mstJurusanTableAdapter = Nothing
        Me.TableAdapterManager.mstMataPelajaranTableAdapter = Nothing
        Me.TableAdapterManager.mstTestTableAdapter = Me.MstTestTableAdapter
        Me.TableAdapterManager.statusTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = StudentEnrollment.DataSetPropertiPendaftaranTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MstTestBindingNavigator
        '
        Me.MstTestBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MstTestBindingNavigator.BindingSource = Me.MstTestBindingSource
        Me.MstTestBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MstTestBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MstTestBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MstTestBindingNavigatorSaveItem})
        Me.MstTestBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MstTestBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MstTestBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MstTestBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MstTestBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MstTestBindingNavigator.Name = "MstTestBindingNavigator"
        Me.MstTestBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MstTestBindingNavigator.Size = New System.Drawing.Size(373, 25)
        Me.MstTestBindingNavigator.TabIndex = 0
        Me.MstTestBindingNavigator.Text = "BindingNavigator1"
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
        'MstTestBindingNavigatorSaveItem
        '
        Me.MstTestBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MstTestBindingNavigatorSaveItem.Image = CType(resources.GetObject("MstTestBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MstTestBindingNavigatorSaveItem.Name = "MstTestBindingNavigatorSaveItem"
        Me.MstTestBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.MstTestBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MstTestGridControl
        '
        Me.MstTestGridControl.DataSource = Me.MstTestBindingSource
        Me.MstTestGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MstTestGridControl.Location = New System.Drawing.Point(0, 25)
        Me.MstTestGridControl.MainView = Me.GridView1
        Me.MstTestGridControl.Name = "MstTestGridControl"
        Me.MstTestGridControl.Size = New System.Drawing.Size(373, 495)
        Me.MstTestGridControl.TabIndex = 1
        Me.MstTestGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colNamaTest})
        Me.GridView1.GridControl = Me.MstTestGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colNamaTest
        '
        Me.colNamaTest.FieldName = "NamaTest"
        Me.colNamaTest.Name = "colNamaTest"
        Me.colNamaTest.Visible = True
        Me.colNamaTest.VisibleIndex = 0
        '
        'FormMasterTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 520)
        Me.Controls.Add(Me.MstTestGridControl)
        Me.Controls.Add(Me.MstTestBindingNavigator)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormMasterTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMasterTest"
        CType(Me.DataSetPropertiPendaftaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstTestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstTestBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MstTestBindingNavigator.ResumeLayout(False)
        Me.MstTestBindingNavigator.PerformLayout()
        CType(Me.MstTestGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetPropertiPendaftaran As DataSetPropertiPendaftaran
    Friend WithEvents MstTestBindingSource As BindingSource
    Friend WithEvents MstTestTableAdapter As DataSetPropertiPendaftaranTableAdapters.mstTestTableAdapter
    Friend WithEvents TableAdapterManager As DataSetPropertiPendaftaranTableAdapters.TableAdapterManager
    Friend WithEvents MstTestBindingNavigator As BindingNavigator
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
    Friend WithEvents MstTestBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MstTestGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colNamaTest As XtraGrid.Columns.GridColumn
End Class
