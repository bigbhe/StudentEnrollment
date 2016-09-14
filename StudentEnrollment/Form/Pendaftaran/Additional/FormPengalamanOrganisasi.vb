Imports DevExpress.XtraGrid.Views.Grid

Public Class FormPengalamanOrganisasi
    Private Sub PengalamanOrganisasiBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PengalamanOrganisasiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PengalamanOrganisasiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetPelengkapPendaftaran)

    End Sub



    Sub loadData()
        Try
            Me.PengalamanOrganisasiTableAdapter.Fill(Me.DataSetPelengkapPendaftaran.pengalamanOrganisasi, New System.Nullable(Of Integer)(CType(oClassPendaftaran.IdPelamar, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FormPengalamanOrganisasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadData()
        LabelControl1.Text = String.Format("Isi data Pengalaman Organisasi Untuk Calon Peserta Didik{0}Dengan Nomor Pendaftaran: {1} - Nama: {2}", vbNewLine, oClassPendaftaran.NomorPendaftaran, oClassPendaftaran.namaPendaftar)
    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colidPelamar, oClassPendaftaran.IdPelamar)
    End Sub
End Class