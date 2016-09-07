
Imports DevExpress.XtraGrid

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormChangePassword
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
        Me.DataSetUser = New StudentEnrollment.DataSetUser()
        Me.GetChangePasswordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetChangePasswordTableAdapter = New StudentEnrollment.DataSetUserTableAdapters.getChangePasswordTableAdapter()
        Me.TableAdapterManager = New StudentEnrollment.DataSetUserTableAdapters.TableAdapterManager()
        Me.GetChangePasswordGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colidUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpassword = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.textEditOldPassword = New DevExpress.XtraEditors.TextEdit()
        Me.textEditNewPassword = New DevExpress.XtraEditors.TextEdit()
        Me.textEditNewPassword2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.DataSetUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetChangePasswordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetChangePasswordGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textEditOldPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textEditNewPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textEditNewPassword2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetUser
        '
        Me.DataSetUser.DataSetName = "DataSetUser"
        Me.DataSetUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GetChangePasswordBindingSource
        '
        Me.GetChangePasswordBindingSource.DataMember = "getChangePassword"
        Me.GetChangePasswordBindingSource.DataSource = Me.DataSetUser
        '
        'GetChangePasswordTableAdapter
        '
        Me.GetChangePasswordTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.getChangePasswordTableAdapter = Me.GetChangePasswordTableAdapter
        Me.TableAdapterManager.mstUserTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = StudentEnrollment.DataSetUserTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GetChangePasswordGridControl
        '
        Me.GetChangePasswordGridControl.DataSource = Me.GetChangePasswordBindingSource
        Me.GetChangePasswordGridControl.Location = New System.Drawing.Point(676, 244)
        Me.GetChangePasswordGridControl.MainView = Me.GridView1
        Me.GetChangePasswordGridControl.Name = "GetChangePasswordGridControl"
        Me.GetChangePasswordGridControl.Size = New System.Drawing.Size(135, 154)
        Me.GetChangePasswordGridControl.TabIndex = 2
        Me.GetChangePasswordGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colidUser, Me.colpassword})
        Me.GridView1.GridControl = Me.GetChangePasswordGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colidUser
        '
        Me.colidUser.FieldName = "idUser"
        Me.colidUser.Name = "colidUser"
        Me.colidUser.Visible = True
        Me.colidUser.VisibleIndex = 0
        '
        'colpassword
        '
        Me.colpassword.FieldName = "password"
        Me.colpassword.Name = "colpassword"
        Me.colpassword.Visible = True
        Me.colpassword.VisibleIndex = 1
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(70, 260)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(133, 23)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "Change Password"
        '
        'textEditOldPassword
        '
        Me.textEditOldPassword.Location = New System.Drawing.Point(54, 67)
        Me.textEditOldPassword.Name = "textEditOldPassword"
        Me.textEditOldPassword.Size = New System.Drawing.Size(176, 20)
        Me.textEditOldPassword.TabIndex = 4
        '
        'textEditNewPassword
        '
        Me.textEditNewPassword.Location = New System.Drawing.Point(54, 134)
        Me.textEditNewPassword.Name = "textEditNewPassword"
        Me.textEditNewPassword.Size = New System.Drawing.Size(176, 20)
        Me.textEditNewPassword.TabIndex = 5
        '
        'textEditNewPassword2
        '
        Me.textEditNewPassword2.Location = New System.Drawing.Point(54, 200)
        Me.textEditNewPassword2.Name = "textEditNewPassword2"
        Me.textEditNewPassword2.Size = New System.Drawing.Size(176, 20)
        Me.textEditNewPassword2.TabIndex = 6
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(54, 48)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(117, 13)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Type Your Old Password"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(54, 115)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(122, 13)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Type Your New Password"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(54, 181)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(133, 13)
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "Retype Your New Password"
        '
        'FormChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 330)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.textEditNewPassword2)
        Me.Controls.Add(Me.textEditNewPassword)
        Me.Controls.Add(Me.textEditOldPassword)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GetChangePasswordGridControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormChangePassword"
        CType(Me.DataSetUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetChangePasswordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetChangePasswordGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textEditOldPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textEditNewPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textEditNewPassword2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetUser As DataSetUser
    Friend WithEvents GetChangePasswordBindingSource As BindingSource
    Friend WithEvents GetChangePasswordTableAdapter As DataSetUserTableAdapters.getChangePasswordTableAdapter
    Friend WithEvents TableAdapterManager As DataSetUserTableAdapters.TableAdapterManager
    Friend WithEvents GetChangePasswordGridControl As GridControl
    Friend WithEvents GridView1 As Views.Grid.GridView
    Friend WithEvents colidUser As Columns.GridColumn
    Friend WithEvents colpassword As Columns.GridColumn
    Friend WithEvents SimpleButton1 As SimpleButton
    Friend WithEvents textEditOldPassword As TextEdit
    Friend WithEvents textEditNewPassword As TextEdit
    Friend WithEvents textEditNewPassword2 As TextEdit
    Friend WithEvents LabelControl1 As LabelControl
    Friend WithEvents LabelControl2 As LabelControl
    Friend WithEvents LabelControl3 As LabelControl
End Class
