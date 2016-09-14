Imports DevExpress.XtraGrid.Views.Grid

Public Class FormTraHobi
    Private Sub PelamarHobiBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PelamarHobiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PelamarHobiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetPelengkapPendaftaran)

    End Sub



    Private Sub FormTraHobi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetPelengkapPendaftaran.mstHobi' table. You can move, or remove it, as needed.
        Me.MstHobiTableAdapter.Fill(Me.DataSetPelengkapPendaftaran.mstHobi)
        Try
            Me.PelamarHobiTableAdapter.Fill(Me.DataSetPelengkapPendaftaran.pelamarHobi, New System.Nullable(Of Integer)(CType(oClassPendaftaran.IdPelamar, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        LabelControl1.Text = String.Format("Isi data hobi  Untuk Calon Peserta Didik{0}Dengan Nomor Pendaftaran: {1} - Nama: {2}", vbNewLine, oClassPendaftaran.NomorPendaftaran, oClassPendaftaran.namaPendaftar)
    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colidPelamar, oClassPendaftaran.IdPelamar)
    End Sub
End Class