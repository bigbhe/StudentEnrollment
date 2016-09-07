<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.txtUserName = New DevExpress.XtraEditors.TextEdit()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.buttonLogin = New DevExpress.XtraEditors.SimpleButton()
        Me.buttonCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(25, 48)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(283, 20)
        Me.txtUserName.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(25, 119)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.UseSystemPasswordChar = True
        Me.txtPassword.Size = New System.Drawing.Size(283, 20)
        Me.txtPassword.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(25, 29)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "User Name"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(25, 100)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Password"
        '
        'buttonLogin
        '
        Me.buttonLogin.Location = New System.Drawing.Point(70, 165)
        Me.buttonLogin.Name = "buttonLogin"
        Me.buttonLogin.Size = New System.Drawing.Size(75, 23)
        Me.buttonLogin.TabIndex = 4
        Me.buttonLogin.Text = "Login"
        '
        'buttonCancel
        '
        Me.buttonCancel.Location = New System.Drawing.Point(169, 165)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(75, 23)
        Me.buttonCancel.TabIndex = 5
        Me.buttonCancel.Text = "Cancel"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.EditValue = Global.StudentEnrollment.My.Resources.Resources._11301366_361196224081390_575244631_n
        Me.PictureEdit1.Location = New System.Drawing.Point(336, 12)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PictureEdit1.Properties.ZoomAccelerationFactor = 1.0R
        Me.PictureEdit1.Size = New System.Drawing.Size(143, 176)
        Me.PictureEdit1.TabIndex = 6
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 208)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.buttonCancel)
        Me.Controls.Add(Me.buttonLogin)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login - SMK Nusa Jaya"
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUserName As TextEdit
    Friend WithEvents txtPassword As TextEdit
    Friend WithEvents LabelControl1 As LabelControl
    Friend WithEvents LabelControl2 As LabelControl
    Friend WithEvents buttonLogin As SimpleButton
    Friend WithEvents buttonCancel As SimpleButton
    Friend WithEvents PictureEdit1 As PictureEdit
End Class
