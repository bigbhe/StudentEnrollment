<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportKeteranganLulus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportKeteranganLulus))
        Me.ReportKelulusanTableAdapter = New StudentEnrollment.DataSetReportTableAdapters.ReportKelulusanTableAdapter()
        Me.DataSetReport = New StudentEnrollment.DataSetReport()
        Me.ReportKelulusanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New StudentEnrollment.DataSetReportTableAdapters.TableAdapterManager()
        Me.ReportKelulusanBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ReportKelulusanBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.IdGelToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.IdGelToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ReportKelulusanGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.DataSetReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportKelulusanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportKelulusanBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReportKelulusanBindingNavigator.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        CType(Me.ReportKelulusanGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportKelulusanTableAdapter
        '
        Me.ReportKelulusanTableAdapter.ClearBeforeFill = True
        '
        'DataSetReport
        '
        Me.DataSetReport.DataSetName = "DataSetReport"
        Me.DataSetReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportKelulusanBindingSource
        '
        Me.ReportKelulusanBindingSource.DataMember = "ReportKelulusan"
        Me.ReportKelulusanBindingSource.DataSource = Me.DataSetReport
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = StudentEnrollment.DataSetReportTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ReportKelulusanBindingNavigator
        '
        Me.ReportKelulusanBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ReportKelulusanBindingNavigator.BindingSource = Me.ReportKelulusanBindingSource
        Me.ReportKelulusanBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ReportKelulusanBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ReportKelulusanBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ReportKelulusanBindingNavigatorSaveItem})
        Me.ReportKelulusanBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ReportKelulusanBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ReportKelulusanBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ReportKelulusanBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ReportKelulusanBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ReportKelulusanBindingNavigator.Name = "ReportKelulusanBindingNavigator"
        Me.ReportKelulusanBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ReportKelulusanBindingNavigator.Size = New System.Drawing.Size(689, 25)
        Me.ReportKelulusanBindingNavigator.TabIndex = 0
        Me.ReportKelulusanBindingNavigator.Text = "BindingNavigator1"
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
        'ReportKelulusanBindingNavigatorSaveItem
        '
        Me.ReportKelulusanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ReportKelulusanBindingNavigatorSaveItem.Enabled = False
        Me.ReportKelulusanBindingNavigatorSaveItem.Image = CType(resources.GetObject("ReportKelulusanBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ReportKelulusanBindingNavigatorSaveItem.Name = "ReportKelulusanBindingNavigatorSaveItem"
        Me.ReportKelulusanBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.ReportKelulusanBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdGelToolStripLabel, Me.IdGelToolStripTextBox, Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(689, 25)
        Me.FillToolStrip.TabIndex = 1
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'IdGelToolStripLabel
        '
        Me.IdGelToolStripLabel.Name = "IdGelToolStripLabel"
        Me.IdGelToolStripLabel.Size = New System.Drawing.Size(37, 22)
        Me.IdGelToolStripLabel.Text = "idGel:"
        '
        'IdGelToolStripTextBox
        '
        Me.IdGelToolStripTextBox.Name = "IdGelToolStripTextBox"
        Me.IdGelToolStripTextBox.Size = New System.Drawing.Size(100, 23)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(26, 19)
        Me.FillToolStripButton.Text = "Fill"
        '
        'ReportKelulusanGridControl
        '
        Me.ReportKelulusanGridControl.DataSource = Me.ReportKelulusanBindingSource
        Me.ReportKelulusanGridControl.Location = New System.Drawing.Point(84, 131)
        Me.ReportKelulusanGridControl.MainView = Me.GridView1
        Me.ReportKelulusanGridControl.Name = "ReportKelulusanGridControl"
        Me.ReportKelulusanGridControl.Size = New System.Drawing.Size(300, 220)
        Me.ReportKelulusanGridControl.TabIndex = 2
        Me.ReportKelulusanGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.ReportKelulusanGridControl
        Me.GridView1.Name = "GridView1"
        '
        'ReportKeteranganLulus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 394)
        Me.Controls.Add(Me.ReportKelulusanGridControl)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.ReportKelulusanBindingNavigator)
        Me.Name = "ReportKeteranganLulus"
        Me.Text = "ReportKeteranganLulus"
        CType(Me.DataSetReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportKelulusanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportKelulusanBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReportKelulusanBindingNavigator.ResumeLayout(False)
        Me.ReportKelulusanBindingNavigator.PerformLayout()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        CType(Me.ReportKelulusanGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportKelulusanTableAdapter As DataSetReportTableAdapters.ReportKelulusanTableAdapter
    Friend WithEvents DataSetReport As DataSetReport
    Friend WithEvents ReportKelulusanBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As DataSetReportTableAdapters.TableAdapterManager
    Friend WithEvents ReportKelulusanBindingNavigator As BindingNavigator
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
    Friend WithEvents ReportKelulusanBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FillToolStrip As ToolStrip
    Friend WithEvents IdGelToolStripLabel As ToolStripLabel
    Friend WithEvents IdGelToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillToolStripButton As ToolStripButton
    Friend WithEvents ReportKelulusanGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
End Class
