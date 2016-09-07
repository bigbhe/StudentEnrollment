<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHobi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHobi))
        Me.DataSetPropertiPendaftaran = New StudentEnrollment.DataSetPropertiPendaftaran()
        Me.MstHobiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstHobiTableAdapter = New StudentEnrollment.DataSetPropertiPendaftaranTableAdapters.mstHobiTableAdapter()
        Me.TableAdapterManager = New StudentEnrollment.DataSetPropertiPendaftaranTableAdapters.TableAdapterManager()
        Me.MstHobiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MstHobiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MstHobiGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvarchar = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetPropertiPendaftaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstHobiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstHobiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MstHobiBindingNavigator.SuspendLayout()
        CType(Me.MstHobiGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetPropertiPendaftaran
        '
        Me.DataSetPropertiPendaftaran.DataSetName = "DataSetPropertiPendaftaran"
        Me.DataSetPropertiPendaftaran.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MstHobiBindingSource
        '
        Me.MstHobiBindingSource.DataMember = "mstHobi"
        Me.MstHobiBindingSource.DataSource = Me.DataSetPropertiPendaftaran
        '
        'MstHobiTableAdapter
        '
        Me.MstHobiTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mstHobiTableAdapter = Me.MstHobiTableAdapter
        Me.TableAdapterManager.mstJurusanTableAdapter = Nothing
        Me.TableAdapterManager.mstMataPelajaranTableAdapter = Nothing
        Me.TableAdapterManager.mstTestTableAdapter = Nothing
        Me.TableAdapterManager.statusTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = StudentEnrollment.DataSetPropertiPendaftaranTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MstHobiBindingNavigator
        '
        Me.MstHobiBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MstHobiBindingNavigator.BindingSource = Me.MstHobiBindingSource
        Me.MstHobiBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MstHobiBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MstHobiBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MstHobiBindingNavigatorSaveItem})
        Me.MstHobiBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MstHobiBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MstHobiBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MstHobiBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MstHobiBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MstHobiBindingNavigator.Name = "MstHobiBindingNavigator"
        Me.MstHobiBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MstHobiBindingNavigator.Size = New System.Drawing.Size(320, 25)
        Me.MstHobiBindingNavigator.TabIndex = 0
        Me.MstHobiBindingNavigator.Text = "BindingNavigator1"
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
        'MstHobiBindingNavigatorSaveItem
        '
        Me.MstHobiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MstHobiBindingNavigatorSaveItem.Image = CType(resources.GetObject("MstHobiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MstHobiBindingNavigatorSaveItem.Name = "MstHobiBindingNavigatorSaveItem"
        Me.MstHobiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MstHobiBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MstHobiGridControl
        '
        Me.MstHobiGridControl.DataSource = Me.MstHobiBindingSource
        Me.MstHobiGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MstHobiGridControl.Location = New System.Drawing.Point(0, 25)
        Me.MstHobiGridControl.MainView = Me.GridView1
        Me.MstHobiGridControl.Name = "MstHobiGridControl"
        Me.MstHobiGridControl.Size = New System.Drawing.Size(320, 596)
        Me.MstHobiGridControl.TabIndex = 1
        Me.MstHobiGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colvarchar})
        Me.GridView1.GridControl = Me.MstHobiGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colvarchar
        '
        Me.colvarchar.Caption = "Hobby"
        Me.colvarchar.FieldName = "varchar"
        Me.colvarchar.Name = "colvarchar"
        Me.colvarchar.Visible = True
        Me.colvarchar.VisibleIndex = 0
        '
        'FormHobi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 621)
        Me.Controls.Add(Me.MstHobiGridControl)
        Me.Controls.Add(Me.MstHobiBindingNavigator)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormHobi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormHobi"
        CType(Me.DataSetPropertiPendaftaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstHobiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstHobiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MstHobiBindingNavigator.ResumeLayout(False)
        Me.MstHobiBindingNavigator.PerformLayout()
        CType(Me.MstHobiGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetPropertiPendaftaran As DataSetPropertiPendaftaran
    Friend WithEvents MstHobiBindingSource As BindingSource
    Friend WithEvents MstHobiTableAdapter As DataSetPropertiPendaftaranTableAdapters.mstHobiTableAdapter
    Friend WithEvents TableAdapterManager As DataSetPropertiPendaftaranTableAdapters.TableAdapterManager
    Friend WithEvents MstHobiBindingNavigator As BindingNavigator
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
    Friend WithEvents MstHobiBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MstHobiGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colvarchar As XtraGrid.Columns.GridColumn
End Class
