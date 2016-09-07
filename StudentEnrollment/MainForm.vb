Imports System.ComponentModel
Imports System.Text


Partial Public Class MainForm

    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = My.Settings.Skins
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        FormLogin.ShowDialog()
        labelFullName.Caption = aUser.fullname
    End Sub

    Private Sub tmrMain_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
        labelDateTime.Caption = Format(Now, "HH:mm:ss") + vbCrLf + Format(Now, "dddd, dd MMMM yyyy")
    End Sub

    Private Sub menuUser_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuUser.ItemClick
        If Me.MdiChildren.Contains(FormUser) Then
            FormUser.Focus()
        Else
            FormUser.MdiParent = Me
            FormUser.Show()
        End If
    End Sub

    Private Sub menuChangePassword_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuChangePassword.ItemClick
        FormChangePassword.ShowDialog()

    End Sub

    Private Sub menuMstHobi_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuMstHobi.ItemClick
        FormHobi.ShowDialog()

    End Sub

    Private Sub menuMstMataPelajaran_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuMstMataPelajaran.ItemClick
        FormMataPelajaran.ShowDialog()

    End Sub

    Private Sub menuMstJurusan_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuMstJurusan.ItemClick
        FormJurusan.ShowDialog()

    End Sub

    Private Sub menuMstTest_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuMstTest.ItemClick
        FormMasterTest.ShowDialog()

    End Sub

    Private Sub menuStatus_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuStatus.ItemClick
        FormStatusPendaftaran.ShowDialog()

    End Sub

    Private Sub menuGelombang_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuGelombang.ItemClick

        If Me.MdiChildren.Contains(FormHeaderGelombang) Then
            FormHeaderGelombang.Focus()
        Else
            FormHeaderGelombang.MdiParent = Me
            FormHeaderGelombang.Show()
        End If
    End Sub

    Private Sub menuPendaftaran_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuPendaftaran.ItemClick
        If Me.MdiChildren.Contains(FormPendaftaran) Then
            FormPendaftaran.Focus()
        Else
            FormPendaftaran.MdiParent = Me
            FormPendaftaran.Show()
        End If
    End Sub
End Class
