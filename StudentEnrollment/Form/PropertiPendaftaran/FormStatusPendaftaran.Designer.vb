<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStatusPendaftaran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStatusPendaftaran))
        Me.DataSetPropertiPendaftaran = New StudentEnrollment.DataSetPropertiPendaftaran()
        Me.StatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusTableAdapter = New StudentEnrollment.DataSetPropertiPendaftaranTableAdapters.statusTableAdapter()
        Me.TableAdapterManager = New StudentEnrollment.DataSetPropertiPendaftaranTableAdapters.TableAdapterManager()
        Me.StatusBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetPropertiPendaftaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusBindingNavigator.SuspendLayout()
        CType(Me.StatusGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetPropertiPendaftaran
        '
        Me.DataSetPropertiPendaftaran.DataSetName = "DataSetPropertiPendaftaran"
        Me.DataSetPropertiPendaftaran.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StatusBindingSource
        '
        Me.StatusBindingSource.DataMember = "status"
        Me.StatusBindingSource.DataSource = Me.DataSetPropertiPendaftaran
        '
        'StatusTableAdapter
        '
        Me.StatusTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mstHobiTableAdapter = Nothing
        Me.TableAdapterManager.mstJurusanTableAdapter = Nothing
        Me.TableAdapterManager.mstMataPelajaranTableAdapter = Nothing
        Me.TableAdapterManager.mstTestTableAdapter = Nothing
        Me.TableAdapterManager.statusTableAdapter = Me.StatusTableAdapter
        Me.TableAdapterManager.UpdateOrder = StudentEnrollment.DataSetPropertiPendaftaranTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StatusBindingNavigator
        '
        Me.StatusBindingNavigator.AddNewItem = Nothing
        Me.StatusBindingNavigator.BindingSource = Me.StatusBindingSource
        Me.StatusBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StatusBindingNavigator.DeleteItem = Nothing
        Me.StatusBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.StatusBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StatusBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StatusBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StatusBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StatusBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StatusBindingNavigator.Name = "StatusBindingNavigator"
        Me.StatusBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StatusBindingNavigator.Size = New System.Drawing.Size(409, 25)
        Me.StatusBindingNavigator.TabIndex = 0
        Me.StatusBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'StatusGridControl
        '
        Me.StatusGridControl.DataSource = Me.StatusBindingSource
        Me.StatusGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusGridControl.Location = New System.Drawing.Point(0, 25)
        Me.StatusGridControl.MainView = Me.GridView1
        Me.StatusGridControl.Name = "StatusGridControl"
        Me.StatusGridControl.Size = New System.Drawing.Size(409, 315)
        Me.StatusGridControl.TabIndex = 1
        Me.StatusGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colstatus})
        Me.GridView1.GridControl = Me.StatusGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colstatus
        '
        Me.colstatus.FieldName = "status"
        Me.colstatus.Name = "colstatus"
        Me.colstatus.Visible = True
        Me.colstatus.VisibleIndex = 0
        '
        'FormStatusPendaftaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 340)
        Me.Controls.Add(Me.StatusGridControl)
        Me.Controls.Add(Me.StatusBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormStatusPendaftaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormStatusPendaftaran"
        CType(Me.DataSetPropertiPendaftaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusBindingNavigator.ResumeLayout(False)
        Me.StatusBindingNavigator.PerformLayout()
        CType(Me.StatusGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetPropertiPendaftaran As DataSetPropertiPendaftaran
    Friend WithEvents StatusBindingSource As BindingSource
    Friend WithEvents StatusTableAdapter As DataSetPropertiPendaftaranTableAdapters.statusTableAdapter
    Friend WithEvents TableAdapterManager As DataSetPropertiPendaftaranTableAdapters.TableAdapterManager
    Friend WithEvents StatusBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents StatusGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colstatus As XtraGrid.Columns.GridColumn
End Class
