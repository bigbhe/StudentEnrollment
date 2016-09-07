<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMataPelajaran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMataPelajaran))
        Me.DataSetPropertiPendaftaran = New StudentEnrollment.DataSetPropertiPendaftaran()
        Me.MstMataPelajaranBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstMataPelajaranTableAdapter = New StudentEnrollment.DataSetPropertiPendaftaranTableAdapters.mstMataPelajaranTableAdapter()
        Me.TableAdapterManager = New StudentEnrollment.DataSetPropertiPendaftaranTableAdapters.TableAdapterManager()
        Me.MstMataPelajaranBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MstMataPelajaranBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MstMataPelajaranGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmataPelajaran = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetPropertiPendaftaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstMataPelajaranBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstMataPelajaranBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MstMataPelajaranBindingNavigator.SuspendLayout()
        CType(Me.MstMataPelajaranGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetPropertiPendaftaran
        '
        Me.DataSetPropertiPendaftaran.DataSetName = "DataSetPropertiPendaftaran"
        Me.DataSetPropertiPendaftaran.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MstMataPelajaranBindingSource
        '
        Me.MstMataPelajaranBindingSource.DataMember = "mstMataPelajaran"
        Me.MstMataPelajaranBindingSource.DataSource = Me.DataSetPropertiPendaftaran
        '
        'MstMataPelajaranTableAdapter
        '
        Me.MstMataPelajaranTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mstHobiTableAdapter = Nothing
        Me.TableAdapterManager.mstJurusanTableAdapter = Nothing
        Me.TableAdapterManager.mstMataPelajaranTableAdapter = Me.MstMataPelajaranTableAdapter
        Me.TableAdapterManager.mstTestTableAdapter = Nothing
        Me.TableAdapterManager.statusTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = StudentEnrollment.DataSetPropertiPendaftaranTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MstMataPelajaranBindingNavigator
        '
        Me.MstMataPelajaranBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MstMataPelajaranBindingNavigator.BindingSource = Me.MstMataPelajaranBindingSource
        Me.MstMataPelajaranBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MstMataPelajaranBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MstMataPelajaranBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MstMataPelajaranBindingNavigatorSaveItem})
        Me.MstMataPelajaranBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MstMataPelajaranBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MstMataPelajaranBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MstMataPelajaranBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MstMataPelajaranBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MstMataPelajaranBindingNavigator.Name = "MstMataPelajaranBindingNavigator"
        Me.MstMataPelajaranBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MstMataPelajaranBindingNavigator.Size = New System.Drawing.Size(388, 25)
        Me.MstMataPelajaranBindingNavigator.TabIndex = 0
        Me.MstMataPelajaranBindingNavigator.Text = "BindingNavigator1"
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
        'MstMataPelajaranBindingNavigatorSaveItem
        '
        Me.MstMataPelajaranBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MstMataPelajaranBindingNavigatorSaveItem.Image = CType(resources.GetObject("MstMataPelajaranBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MstMataPelajaranBindingNavigatorSaveItem.Name = "MstMataPelajaranBindingNavigatorSaveItem"
        Me.MstMataPelajaranBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.MstMataPelajaranBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MstMataPelajaranGridControl
        '
        Me.MstMataPelajaranGridControl.DataSource = Me.MstMataPelajaranBindingSource
        Me.MstMataPelajaranGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MstMataPelajaranGridControl.Location = New System.Drawing.Point(0, 25)
        Me.MstMataPelajaranGridControl.MainView = Me.GridView1
        Me.MstMataPelajaranGridControl.Name = "MstMataPelajaranGridControl"
        Me.MstMataPelajaranGridControl.Size = New System.Drawing.Size(388, 555)
        Me.MstMataPelajaranGridControl.TabIndex = 1
        Me.MstMataPelajaranGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colmataPelajaran})
        Me.GridView1.GridControl = Me.MstMataPelajaranGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colmataPelajaran
        '
        Me.colmataPelajaran.FieldName = "mataPelajaran"
        Me.colmataPelajaran.Name = "colmataPelajaran"
        Me.colmataPelajaran.Visible = True
        Me.colmataPelajaran.VisibleIndex = 0
        '
        'FormMataPelajaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 580)
        Me.Controls.Add(Me.MstMataPelajaranGridControl)
        Me.Controls.Add(Me.MstMataPelajaranBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormMataPelajaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mata Pelajaran"
        CType(Me.DataSetPropertiPendaftaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstMataPelajaranBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstMataPelajaranBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MstMataPelajaranBindingNavigator.ResumeLayout(False)
        Me.MstMataPelajaranBindingNavigator.PerformLayout()
        CType(Me.MstMataPelajaranGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetPropertiPendaftaran As DataSetPropertiPendaftaran
    Friend WithEvents MstMataPelajaranBindingSource As BindingSource
    Friend WithEvents MstMataPelajaranTableAdapter As DataSetPropertiPendaftaranTableAdapters.mstMataPelajaranTableAdapter
    Friend WithEvents TableAdapterManager As DataSetPropertiPendaftaranTableAdapters.TableAdapterManager
    Friend WithEvents MstMataPelajaranBindingNavigator As BindingNavigator
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
    Friend WithEvents MstMataPelajaranBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MstMataPelajaranGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colmataPelajaran As XtraGrid.Columns.GridColumn
End Class
