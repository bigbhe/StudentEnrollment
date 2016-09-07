<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Helper
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.idUserTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.MstUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetUser = New StudentEnrollment.DataSetUser()
        Me.usernameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.fullnameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.passwordTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.signaturePictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.lastIPTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.lastLogonDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.isLogonCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.isActiveCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForidUser = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForusername = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForfullname = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForpassword = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForsignature = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForlastIP = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForlastLogon = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForisLogon = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForisActive = New DevExpress.XtraLayout.LayoutControlItem()
        Me.MstUserTableAdapter = New StudentEnrollment.DataSetUserTableAdapters.mstUserTableAdapter()
        Me.TableAdapterManager = New StudentEnrollment.DataSetUserTableAdapters.TableAdapterManager()
        Me.MstUserGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colidUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colusername = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfullname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpassword = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsignature = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collastIP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collastLogon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisLogon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisActive = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.idUserTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usernameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fullnameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passwordTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.signaturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lastIPTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lastLogonDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lastLogonDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isLogonCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isActiveCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForusername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForfullname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForpassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForsignature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForlastIP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForlastLogon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForisLogon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForisActive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstUserGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.idUserTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.usernameTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.fullnameTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.passwordTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.signaturePictureEdit)
        Me.DataLayoutControl1.Controls.Add(Me.lastIPTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.lastLogonDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.isLogonCheckEdit)
        Me.DataLayoutControl1.Controls.Add(Me.isActiveCheckEdit)
        Me.DataLayoutControl1.DataSource = Me.MstUserBindingSource
        Me.DataLayoutControl1.Location = New System.Drawing.Point(34, 34)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(232, 354)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'idUserTextEdit
        '
        Me.idUserTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstUserBindingSource, "idUser", True))
        Me.idUserTextEdit.Location = New System.Drawing.Point(64, 12)
        Me.idUserTextEdit.Name = "idUserTextEdit"
        Me.idUserTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idUserTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idUserTextEdit.Properties.Mask.EditMask = "N0"
        Me.idUserTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.idUserTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.idUserTextEdit.Size = New System.Drawing.Size(156, 20)
        Me.idUserTextEdit.StyleController = Me.DataLayoutControl1
        Me.idUserTextEdit.TabIndex = 4
        '
        'MstUserBindingSource
        '
        Me.MstUserBindingSource.DataMember = "mstUser"
        Me.MstUserBindingSource.DataSource = Me.DataSetUser
        '
        'DataSetUser
        '
        Me.DataSetUser.DataSetName = "DataSetUser"
        Me.DataSetUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'usernameTextEdit
        '
        Me.usernameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstUserBindingSource, "username", True))
        Me.usernameTextEdit.Location = New System.Drawing.Point(64, 36)
        Me.usernameTextEdit.Name = "usernameTextEdit"
        Me.usernameTextEdit.Size = New System.Drawing.Size(156, 20)
        Me.usernameTextEdit.StyleController = Me.DataLayoutControl1
        Me.usernameTextEdit.TabIndex = 5
        '
        'fullnameTextEdit
        '
        Me.fullnameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstUserBindingSource, "fullname", True))
        Me.fullnameTextEdit.Location = New System.Drawing.Point(64, 60)
        Me.fullnameTextEdit.Name = "fullnameTextEdit"
        Me.fullnameTextEdit.Size = New System.Drawing.Size(156, 20)
        Me.fullnameTextEdit.StyleController = Me.DataLayoutControl1
        Me.fullnameTextEdit.TabIndex = 6
        '
        'passwordTextEdit
        '
        Me.passwordTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstUserBindingSource, "password", True))
        Me.passwordTextEdit.Location = New System.Drawing.Point(64, 84)
        Me.passwordTextEdit.Name = "passwordTextEdit"
        Me.passwordTextEdit.Size = New System.Drawing.Size(156, 20)
        Me.passwordTextEdit.StyleController = Me.DataLayoutControl1
        Me.passwordTextEdit.TabIndex = 7
        '
        'signaturePictureEdit
        '
        Me.signaturePictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstUserBindingSource, "signature", True))
        Me.signaturePictureEdit.Location = New System.Drawing.Point(64, 108)
        Me.signaturePictureEdit.Name = "signaturePictureEdit"
        Me.signaturePictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.signaturePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.signaturePictureEdit.Properties.ZoomAccelerationFactor = 1.0R
        Me.signaturePictureEdit.Size = New System.Drawing.Size(156, 140)
        Me.signaturePictureEdit.StyleController = Me.DataLayoutControl1
        Me.signaturePictureEdit.TabIndex = 8
        '
        'lastIPTextEdit
        '
        Me.lastIPTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstUserBindingSource, "lastIP", True))
        Me.lastIPTextEdit.Location = New System.Drawing.Point(64, 252)
        Me.lastIPTextEdit.Name = "lastIPTextEdit"
        Me.lastIPTextEdit.Size = New System.Drawing.Size(156, 20)
        Me.lastIPTextEdit.StyleController = Me.DataLayoutControl1
        Me.lastIPTextEdit.TabIndex = 9
        '
        'lastLogonDateEdit
        '
        Me.lastLogonDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstUserBindingSource, "lastLogon", True))
        Me.lastLogonDateEdit.EditValue = Nothing
        Me.lastLogonDateEdit.Location = New System.Drawing.Point(64, 276)
        Me.lastLogonDateEdit.Name = "lastLogonDateEdit"
        Me.lastLogonDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lastLogonDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lastLogonDateEdit.Size = New System.Drawing.Size(156, 20)
        Me.lastLogonDateEdit.StyleController = Me.DataLayoutControl1
        Me.lastLogonDateEdit.TabIndex = 10
        '
        'isLogonCheckEdit
        '
        Me.isLogonCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstUserBindingSource, "isLogon", True))
        Me.isLogonCheckEdit.Location = New System.Drawing.Point(64, 300)
        Me.isLogonCheckEdit.Name = "isLogonCheckEdit"
        Me.isLogonCheckEdit.Properties.Caption = "is Logon"
        Me.isLogonCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.isLogonCheckEdit.Size = New System.Drawing.Size(156, 19)
        Me.isLogonCheckEdit.StyleController = Me.DataLayoutControl1
        Me.isLogonCheckEdit.TabIndex = 11
        '
        'isActiveCheckEdit
        '
        Me.isActiveCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstUserBindingSource, "isActive", True))
        Me.isActiveCheckEdit.Location = New System.Drawing.Point(64, 323)
        Me.isActiveCheckEdit.Name = "isActiveCheckEdit"
        Me.isActiveCheckEdit.Properties.Caption = "is Active"
        Me.isActiveCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.isActiveCheckEdit.Size = New System.Drawing.Size(156, 19)
        Me.isActiveCheckEdit.StyleController = Me.DataLayoutControl1
        Me.isActiveCheckEdit.TabIndex = 12
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(232, 354)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForidUser, Me.ItemForusername, Me.ItemForfullname, Me.ItemForpassword, Me.ItemForsignature, Me.ItemForlastIP, Me.ItemForlastLogon, Me.ItemForisLogon, Me.ItemForisActive})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(212, 334)
        '
        'ItemForidUser
        '
        Me.ItemForidUser.Control = Me.idUserTextEdit
        Me.ItemForidUser.Location = New System.Drawing.Point(0, 0)
        Me.ItemForidUser.Name = "ItemForidUser"
        Me.ItemForidUser.Size = New System.Drawing.Size(212, 24)
        Me.ItemForidUser.Text = "id User"
        Me.ItemForidUser.TextSize = New System.Drawing.Size(49, 13)
        '
        'ItemForusername
        '
        Me.ItemForusername.Control = Me.usernameTextEdit
        Me.ItemForusername.Location = New System.Drawing.Point(0, 24)
        Me.ItemForusername.Name = "ItemForusername"
        Me.ItemForusername.Size = New System.Drawing.Size(212, 24)
        Me.ItemForusername.Text = "username"
        Me.ItemForusername.TextSize = New System.Drawing.Size(49, 13)
        '
        'ItemForfullname
        '
        Me.ItemForfullname.Control = Me.fullnameTextEdit
        Me.ItemForfullname.Location = New System.Drawing.Point(0, 48)
        Me.ItemForfullname.Name = "ItemForfullname"
        Me.ItemForfullname.Size = New System.Drawing.Size(212, 24)
        Me.ItemForfullname.Text = "fullname"
        Me.ItemForfullname.TextSize = New System.Drawing.Size(49, 13)
        '
        'ItemForpassword
        '
        Me.ItemForpassword.Control = Me.passwordTextEdit
        Me.ItemForpassword.Location = New System.Drawing.Point(0, 72)
        Me.ItemForpassword.Name = "ItemForpassword"
        Me.ItemForpassword.Size = New System.Drawing.Size(212, 24)
        Me.ItemForpassword.Text = "password"
        Me.ItemForpassword.TextSize = New System.Drawing.Size(49, 13)
        '
        'ItemForsignature
        '
        Me.ItemForsignature.Control = Me.signaturePictureEdit
        Me.ItemForsignature.Location = New System.Drawing.Point(0, 96)
        Me.ItemForsignature.Name = "ItemForsignature"
        Me.ItemForsignature.Size = New System.Drawing.Size(212, 144)
        Me.ItemForsignature.StartNewLine = True
        Me.ItemForsignature.Text = "signature"
        Me.ItemForsignature.TextSize = New System.Drawing.Size(49, 13)
        '
        'ItemForlastIP
        '
        Me.ItemForlastIP.Control = Me.lastIPTextEdit
        Me.ItemForlastIP.Location = New System.Drawing.Point(0, 240)
        Me.ItemForlastIP.Name = "ItemForlastIP"
        Me.ItemForlastIP.Size = New System.Drawing.Size(212, 24)
        Me.ItemForlastIP.Text = "last IP"
        Me.ItemForlastIP.TextSize = New System.Drawing.Size(49, 13)
        '
        'ItemForlastLogon
        '
        Me.ItemForlastLogon.Control = Me.lastLogonDateEdit
        Me.ItemForlastLogon.Location = New System.Drawing.Point(0, 264)
        Me.ItemForlastLogon.Name = "ItemForlastLogon"
        Me.ItemForlastLogon.Size = New System.Drawing.Size(212, 24)
        Me.ItemForlastLogon.Text = "last Logon"
        Me.ItemForlastLogon.TextSize = New System.Drawing.Size(49, 13)
        '
        'ItemForisLogon
        '
        Me.ItemForisLogon.Control = Me.isLogonCheckEdit
        Me.ItemForisLogon.Location = New System.Drawing.Point(0, 288)
        Me.ItemForisLogon.Name = "ItemForisLogon"
        Me.ItemForisLogon.Size = New System.Drawing.Size(212, 23)
        Me.ItemForisLogon.Text = "is Logon"
        Me.ItemForisLogon.TextSize = New System.Drawing.Size(49, 13)
        '
        'ItemForisActive
        '
        Me.ItemForisActive.Control = Me.isActiveCheckEdit
        Me.ItemForisActive.Location = New System.Drawing.Point(0, 311)
        Me.ItemForisActive.Name = "ItemForisActive"
        Me.ItemForisActive.Size = New System.Drawing.Size(212, 23)
        Me.ItemForisActive.Text = "is Active"
        Me.ItemForisActive.TextSize = New System.Drawing.Size(49, 13)
        '
        'MstUserTableAdapter
        '
        Me.MstUserTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.getChangePasswordTableAdapter = Nothing
        Me.TableAdapterManager.mstUserTableAdapter = Me.MstUserTableAdapter
        Me.TableAdapterManager.UpdateOrder = StudentEnrollment.DataSetUserTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MstUserGridControl
        '
        Me.MstUserGridControl.DataSource = Me.MstUserBindingSource
        Me.MstUserGridControl.Location = New System.Drawing.Point(417, 130)
        Me.MstUserGridControl.MainView = Me.GridView1
        Me.MstUserGridControl.Name = "MstUserGridControl"
        Me.MstUserGridControl.Size = New System.Drawing.Size(300, 220)
        Me.MstUserGridControl.TabIndex = 1
        Me.MstUserGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colidUser, Me.colusername, Me.colfullname, Me.colpassword, Me.colsignature, Me.collastIP, Me.collastLogon, Me.colisLogon, Me.colisActive})
        Me.GridView1.GridControl = Me.MstUserGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colidUser
        '
        Me.colidUser.FieldName = "idUser"
        Me.colidUser.Name = "colidUser"
        Me.colidUser.Visible = True
        Me.colidUser.VisibleIndex = 0
        '
        'colusername
        '
        Me.colusername.FieldName = "username"
        Me.colusername.Name = "colusername"
        Me.colusername.Visible = True
        Me.colusername.VisibleIndex = 1
        '
        'colfullname
        '
        Me.colfullname.FieldName = "fullname"
        Me.colfullname.Name = "colfullname"
        Me.colfullname.Visible = True
        Me.colfullname.VisibleIndex = 2
        '
        'colpassword
        '
        Me.colpassword.FieldName = "password"
        Me.colpassword.Name = "colpassword"
        Me.colpassword.Visible = True
        Me.colpassword.VisibleIndex = 3
        '
        'colsignature
        '
        Me.colsignature.FieldName = "signature"
        Me.colsignature.Name = "colsignature"
        Me.colsignature.Visible = True
        Me.colsignature.VisibleIndex = 4
        '
        'collastIP
        '
        Me.collastIP.FieldName = "lastIP"
        Me.collastIP.Name = "collastIP"
        Me.collastIP.Visible = True
        Me.collastIP.VisibleIndex = 5
        '
        'collastLogon
        '
        Me.collastLogon.FieldName = "lastLogon"
        Me.collastLogon.Name = "collastLogon"
        Me.collastLogon.Visible = True
        Me.collastLogon.VisibleIndex = 6
        '
        'colisLogon
        '
        Me.colisLogon.FieldName = "isLogon"
        Me.colisLogon.Name = "colisLogon"
        Me.colisLogon.Visible = True
        Me.colisLogon.VisibleIndex = 7
        '
        'colisActive
        '
        Me.colisActive.FieldName = "isActive"
        Me.colisActive.Name = "colisActive"
        Me.colisActive.Visible = True
        Me.colisActive.VisibleIndex = 8
        '
        'Helper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 507)
        Me.Controls.Add(Me.MstUserGridControl)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Name = "Helper"
        Me.Text = "Helper"
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.idUserTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usernameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fullnameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passwordTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.signaturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lastIPTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lastLogonDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lastLogonDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isLogonCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isActiveCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForusername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForfullname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForpassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForsignature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForlastIP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForlastLogon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForisLogon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForisActive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstUserGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents DataSetUser As DataSetUser
    Friend WithEvents MstUserBindingSource As BindingSource
    Friend WithEvents MstUserTableAdapter As DataSetUserTableAdapters.mstUserTableAdapter
    Friend WithEvents idUserTextEdit As TextEdit
    Friend WithEvents usernameTextEdit As TextEdit
    Friend WithEvents fullnameTextEdit As TextEdit
    Friend WithEvents passwordTextEdit As TextEdit
    Friend WithEvents signaturePictureEdit As PictureEdit
    Friend WithEvents lastIPTextEdit As TextEdit
    Friend WithEvents lastLogonDateEdit As DateEdit
    Friend WithEvents isLogonCheckEdit As CheckEdit
    Friend WithEvents isActiveCheckEdit As CheckEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForidUser As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForusername As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForfullname As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForpassword As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForsignature As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForlastIP As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForlastLogon As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForisLogon As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForisActive As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TableAdapterManager As DataSetUserTableAdapters.TableAdapterManager
    Friend WithEvents MstUserGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colidUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colusername As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfullname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpassword As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsignature As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collastIP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collastLogon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisLogon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisActive As DevExpress.XtraGrid.Columns.GridColumn
End Class
