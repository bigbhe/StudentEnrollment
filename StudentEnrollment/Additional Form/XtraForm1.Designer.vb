<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XtraForm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraForm1))
        Me.DataSetTest = New StudentEnrollment.DataSetTest()
        Me.HeaderTestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HeaderTestTableAdapter = New StudentEnrollment.DataSetTestTableAdapters.headerTestTableAdapter()
        Me.TableAdapterManager = New StudentEnrollment.DataSetTestTableAdapters.TableAdapterManager()
        Me.HeaderTestBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.HeaderTestBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.IdGelombangToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.IdGelombangToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.IsAllToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.IsAllToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.HeaderTestGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.DataSetTest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderTestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderTestBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderTestBindingNavigator.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        CType(Me.HeaderTestGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetTest
        '
        Me.DataSetTest.DataSetName = "DataSetTest"
        Me.DataSetTest.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HeaderTestBindingSource
        '
        Me.HeaderTestBindingSource.DataMember = "headerTest"
        Me.HeaderTestBindingSource.DataSource = Me.DataSetTest
        '
        'HeaderTestTableAdapter
        '
        Me.HeaderTestTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.detailTestTableAdapter = Nothing
        Me.TableAdapterManager.headerTestTableAdapter = Me.HeaderTestTableAdapter
        Me.TableAdapterManager.UpdateOrder = StudentEnrollment.DataSetTestTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HeaderTestBindingNavigator
        '
        Me.HeaderTestBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.HeaderTestBindingNavigator.BindingSource = Me.HeaderTestBindingSource
        Me.HeaderTestBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.HeaderTestBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.HeaderTestBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.HeaderTestBindingNavigatorSaveItem})
        Me.HeaderTestBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.HeaderTestBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HeaderTestBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HeaderTestBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HeaderTestBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.HeaderTestBindingNavigator.Name = "HeaderTestBindingNavigator"
        Me.HeaderTestBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HeaderTestBindingNavigator.Size = New System.Drawing.Size(419, 25)
        Me.HeaderTestBindingNavigator.TabIndex = 0
        Me.HeaderTestBindingNavigator.Text = "BindingNavigator1"
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
        'HeaderTestBindingNavigatorSaveItem
        '
        Me.HeaderTestBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HeaderTestBindingNavigatorSaveItem.Image = CType(resources.GetObject("HeaderTestBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.HeaderTestBindingNavigatorSaveItem.Name = "HeaderTestBindingNavigatorSaveItem"
        Me.HeaderTestBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.HeaderTestBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdGelombangToolStripLabel, Me.IdGelombangToolStripTextBox, Me.IsAllToolStripLabel, Me.IsAllToolStripTextBox, Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(419, 25)
        Me.FillToolStrip.TabIndex = 1
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'IdGelombangToolStripLabel
        '
        Me.IdGelombangToolStripLabel.Name = "IdGelombangToolStripLabel"
        Me.IdGelombangToolStripLabel.Size = New System.Drawing.Size(82, 22)
        Me.IdGelombangToolStripLabel.Text = "idGelombang:"
        '
        'IdGelombangToolStripTextBox
        '
        Me.IdGelombangToolStripTextBox.Name = "IdGelombangToolStripTextBox"
        Me.IdGelombangToolStripTextBox.Size = New System.Drawing.Size(100, 23)
        '
        'IsAllToolStripLabel
        '
        Me.IsAllToolStripLabel.Name = "IsAllToolStripLabel"
        Me.IsAllToolStripLabel.Size = New System.Drawing.Size(32, 15)
        Me.IsAllToolStripLabel.Text = "isAll:"
        '
        'IsAllToolStripTextBox
        '
        Me.IsAllToolStripTextBox.Name = "IsAllToolStripTextBox"
        Me.IsAllToolStripTextBox.Size = New System.Drawing.Size(100, 23)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(26, 19)
        Me.FillToolStripButton.Text = "Fill"
        '
        'HeaderTestGridControl
        '
        Me.HeaderTestGridControl.DataSource = Me.HeaderTestBindingSource
        Me.HeaderTestGridControl.Location = New System.Drawing.Point(99, 100)
        Me.HeaderTestGridControl.MainView = Me.GridView1
        Me.HeaderTestGridControl.Name = "HeaderTestGridControl"
        Me.HeaderTestGridControl.Size = New System.Drawing.Size(300, 220)
        Me.HeaderTestGridControl.TabIndex = 2
        Me.HeaderTestGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.HeaderTestGridControl
        Me.GridView1.Name = "GridView1"
        '
        'XtraForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 340)
        Me.Controls.Add(Me.HeaderTestGridControl)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.HeaderTestBindingNavigator)
        Me.Name = "XtraForm1"
        Me.Text = "XtraForm1"
        CType(Me.DataSetTest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderTestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderTestBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderTestBindingNavigator.ResumeLayout(False)
        Me.HeaderTestBindingNavigator.PerformLayout()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        CType(Me.HeaderTestGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetTest As DataSetTest
    Friend WithEvents HeaderTestBindingSource As BindingSource
    Friend WithEvents HeaderTestTableAdapter As DataSetTestTableAdapters.headerTestTableAdapter
    Friend WithEvents TableAdapterManager As DataSetTestTableAdapters.TableAdapterManager
    Friend WithEvents HeaderTestBindingNavigator As BindingNavigator
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
    Friend WithEvents HeaderTestBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FillToolStrip As ToolStrip
    Friend WithEvents IdGelombangToolStripLabel As ToolStripLabel
    Friend WithEvents IdGelombangToolStripTextBox As ToolStripTextBox
    Friend WithEvents IsAllToolStripLabel As ToolStripLabel
    Friend WithEvents IsAllToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillToolStripButton As ToolStripButton
    Friend WithEvents HeaderTestGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
End Class
