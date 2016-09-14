Imports DevExpress.XtraGrid.Views.Grid

Public Class FormNilaiUN
    Private Sub TraNilaiUNBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TraNilaiUNBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.TraNilaiUNBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DataSetPelengkapPendaftaran)
        Catch ex As Exception
            uniqueAlert(Me, ex.ToString)
        End Try
    End Sub

    Sub loadData()
        Try
            Me.TraNilaiUNTableAdapter.Fill(Me.DataSetPelengkapPendaftaran.traNilaiUN, New Integer?(oClassPendaftaran.IdPelamar))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FormNilaiUN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetPelengkapPendaftaran.mstMataPelajaran' table. You can move, or remove it, as needed.
        Me.MstMataPelajaranTableAdapter.Fill(Me.DataSetPelengkapPendaftaran.mstMataPelajaran)
        loadData()
        labelInfo.Text = String.Format("Isi Nilai Ujian Untuk Calon Peserta Didik{0}Dengan Nomor Pendaftaran: {1} - Nama: {2}", vbNewLine, oClassPendaftaran.NomorPendaftaran, oClassPendaftaran.namaPendaftar)

    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colidPelamar, oClassPendaftaran.IdPelamar)
    End Sub
End Class