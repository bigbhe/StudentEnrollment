Imports DevExpress.XtraGrid.Views.Grid

Public Class FormPrestasi
    Private Sub PrestasiBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PrestasiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PrestasiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetPelengkapPendaftaran)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormPrestasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadData()
        LabelControl1.Text = String.Format("Isi Data Prestasi Untuk Calon Peserta Didik{0}Dengan Nomor Pendaftaran: {1} - Nama: {2}", vbNewLine, oClassPendaftaran.NomorPendaftaran, oClassPendaftaran.namaPendaftar)
    End Sub
    Sub loadData()
        Try
            Me.PrestasiTableAdapter.Fill(Me.DataSetPelengkapPendaftaran.prestasi, New System.Nullable(Of Integer)(CType(oClassPendaftaran.IdPelamar, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colidPendaftar, oClassPendaftaran.IdPelamar)

    End Sub
End Class