Partial Public Class MainForm
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.labelDateTime = New DevExpress.XtraBars.BarStaticItem()
        Me.BarDockingMenuItem1 = New DevExpress.XtraBars.BarDockingMenuItem()
        Me.labelFullName = New DevExpress.XtraBars.BarStaticItem()
        Me.menuUser = New DevExpress.XtraBars.BarButtonItem()
        Me.menuChangePassword = New DevExpress.XtraBars.BarButtonItem()
        Me.menuMstHobi = New DevExpress.XtraBars.BarButtonItem()
        Me.menuMstJurusan = New DevExpress.XtraBars.BarButtonItem()
        Me.menuMstMataPelajaran = New DevExpress.XtraBars.BarButtonItem()
        Me.menuMstTest = New DevExpress.XtraBars.BarButtonItem()
        Me.menuPendaftaran = New DevExpress.XtraBars.BarButtonItem()
        Me.menuStatus = New DevExpress.XtraBars.BarButtonItem()
        Me.menuGelombang = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpSettings = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.mdiManager = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mdiManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.Controller = Me.BarAndDockingController1
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.SkinRibbonGalleryBarItem1, Me.labelDateTime, Me.BarDockingMenuItem1, Me.labelFullName, Me.menuUser, Me.menuChangePassword, Me.menuMstHobi, Me.menuMstJurusan, Me.menuMstMataPelajaran, Me.menuMstTest, Me.menuPendaftaran, Me.menuStatus, Me.menuGelombang})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 13
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage2, Me.RibbonPage3, Me.rpSettings, Me.ribbonPage1})
        Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.ribbonControl1.Size = New System.Drawing.Size(758, 146)
        Me.ribbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'BarAndDockingController1
        '
        Me.BarAndDockingController1.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
        Me.BarAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
        '
        'SkinRibbonGalleryBarItem1
        '
        Me.SkinRibbonGalleryBarItem1.Caption = "SkinRibbonGalleryBarItem1"
        Me.SkinRibbonGalleryBarItem1.Id = 1
        Me.SkinRibbonGalleryBarItem1.Name = "SkinRibbonGalleryBarItem1"
        '
        'labelDateTime
        '
        Me.labelDateTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.labelDateTime.Caption = "lblDate"
        Me.labelDateTime.Id = 1
        Me.labelDateTime.Name = "labelDateTime"
        Me.labelDateTime.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarDockingMenuItem1
        '
        Me.BarDockingMenuItem1.Caption = "BarDockingMenuItem1"
        Me.BarDockingMenuItem1.Id = 2
        Me.BarDockingMenuItem1.Name = "BarDockingMenuItem1"
        '
        'labelFullName
        '
        Me.labelFullName.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.labelFullName.Caption = "BarStaticItem2"
        Me.labelFullName.Id = 3
        Me.labelFullName.Name = "labelFullName"
        Me.labelFullName.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'menuUser
        '
        Me.menuUser.Caption = "User"
        Me.menuUser.Glyph = CType(resources.GetObject("menuUser.Glyph"), System.Drawing.Image)
        Me.menuUser.Id = 4
        Me.menuUser.LargeGlyph = CType(resources.GetObject("menuUser.LargeGlyph"), System.Drawing.Image)
        Me.menuUser.Name = "menuUser"
        '
        'menuChangePassword
        '
        Me.menuChangePassword.Caption = "Change Password"
        Me.menuChangePassword.Glyph = CType(resources.GetObject("menuChangePassword.Glyph"), System.Drawing.Image)
        Me.menuChangePassword.Id = 5
        Me.menuChangePassword.LargeGlyph = CType(resources.GetObject("menuChangePassword.LargeGlyph"), System.Drawing.Image)
        Me.menuChangePassword.Name = "menuChangePassword"
        '
        'menuMstHobi
        '
        Me.menuMstHobi.Caption = "Data Hobi"
        Me.menuMstHobi.Glyph = Global.StudentEnrollment.My.Resources.Resources.Basketball__11_
        Me.menuMstHobi.Id = 6
        Me.menuMstHobi.Name = "menuMstHobi"
        Me.menuMstHobi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'menuMstJurusan
        '
        Me.menuMstJurusan.Caption = "Jurusan"
        Me.menuMstJurusan.Glyph = Global.StudentEnrollment.My.Resources.Resources.Board__2_
        Me.menuMstJurusan.Id = 7
        Me.menuMstJurusan.Name = "menuMstJurusan"
        Me.menuMstJurusan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'menuMstMataPelajaran
        '
        Me.menuMstMataPelajaran.Caption = "Mata Pelajaran"
        Me.menuMstMataPelajaran.Glyph = Global.StudentEnrollment.My.Resources.Resources.Book___Blue
        Me.menuMstMataPelajaran.Id = 8
        Me.menuMstMataPelajaran.Name = "menuMstMataPelajaran"
        Me.menuMstMataPelajaran.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'menuMstTest
        '
        Me.menuMstTest.Caption = "Data Test"
        Me.menuMstTest.Glyph = Global.StudentEnrollment.My.Resources.Resources._070342_firey_orange_jelly_icon_alphanumeric_question_mark1_ps
        Me.menuMstTest.Id = 9
        Me.menuMstTest.Name = "menuMstTest"
        Me.menuMstTest.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'menuPendaftaran
        '
        Me.menuPendaftaran.Caption = "Daftar Baru"
        Me.menuPendaftaran.Glyph = Global.StudentEnrollment.My.Resources.Resources.Folder___Users__2_
        Me.menuPendaftaran.Id = 10
        Me.menuPendaftaran.Name = "menuPendaftaran"
        Me.menuPendaftaran.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'menuStatus
        '
        Me.menuStatus.Caption = "Status"
        Me.menuStatus.Glyph = Global.StudentEnrollment.My.Resources.Resources._11
        Me.menuStatus.Id = 11
        Me.menuStatus.Name = "menuStatus"
        Me.menuStatus.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'menuGelombang
        '
        Me.menuGelombang.Caption = "Session"
        Me.menuGelombang.Glyph = Global.StudentEnrollment.My.Resources.Resources.online_registration_icon_png_538
        Me.menuGelombang.Id = 12
        Me.menuGelombang.Name = "menuGelombang"
        Me.menuGelombang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Data"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.menuMstHobi)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.menuMstJurusan)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.menuMstMataPelajaran)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.menuMstTest)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.menuStatus)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Properti Pendaftaran"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup5, Me.RibbonPageGroup4})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Pendaftaran"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.AllowTextClipping = False
        Me.RibbonPageGroup5.ItemLinks.Add(Me.menuGelombang)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "Gelombang Pendaftaran"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.menuPendaftaran)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Pendaftaran"
        '
        'rpSettings
        '
        Me.rpSettings.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.rpSettings.Image = CType(resources.GetObject("rpSettings.Image"), System.Drawing.Image)
        Me.rpSettings.KeyTip = "S"
        Me.rpSettings.Name = "rpSettings"
        Me.rpSettings.Text = "Settings"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.SkinRibbonGalleryBarItem1)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "RibbonPageGroup2"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
        Me.ribbonPage1.KeyTip = "R"
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "ribbonPage1"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.ItemLinks.Add(Me.menuUser)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.menuChangePassword)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        Me.ribbonPageGroup1.Text = "User"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.labelFullName)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.labelDateTime)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 329)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.ribbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(758, 31)
        '
        'mdiManager
        '
        Me.mdiManager.Controller = Me.BarAndDockingController1
        Me.mdiManager.MdiParent = Me
        '
        'tmrMain
        '
        Me.tmrMain.Enabled = True
        '
        'MainForm
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 360)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.IsMdiContainer = True
        Me.Name = "MainForm"
        Me.Ribbon = Me.ribbonControl1
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mdiManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents SkinRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents rpSettings As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents labelDateTime As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RepositoryItemTextEdit1 As Repository.RepositoryItemTextEdit
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents mdiManager As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents tmrMain As Timer
    Friend WithEvents BarDockingMenuItem1 As DevExpress.XtraBars.BarDockingMenuItem
    Public WithEvents labelFullName As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents menuUser As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuChangePassword As XtraBars.BarButtonItem
    Friend WithEvents menuMstHobi As XtraBars.BarButtonItem
    Friend WithEvents menuMstJurusan As XtraBars.BarButtonItem
    Friend WithEvents menuMstMataPelajaran As XtraBars.BarButtonItem
    Friend WithEvents RibbonPage2 As XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents menuMstTest As XtraBars.BarButtonItem
    Friend WithEvents menuPendaftaran As XtraBars.BarButtonItem
    Friend WithEvents RibbonPage3 As XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup4 As XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents menuStatus As XtraBars.BarButtonItem
    Friend WithEvents menuGelombang As XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As XtraBars.Ribbon.RibbonPageGroup
End Class
