Imports DevExpress.XtraGrid.Views.Grid

Public Class FormPendidikanNonFormal
    Private Sub PendidikanNonFormalBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PendidikanNonFormalBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PendidikanNonFormalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetPelengkapPendaftaran)

    End Sub


    Sub LoadData()
        Try
            Me.PendidikanNonFormalTableAdapter.Fill(Me.DataSetPelengkapPendaftaran.pendidikanNonFormal, CType(oClassPendaftaran.IdPelamar, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FormPendidikanNonFormal_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
        LabelControl1.Text = String.Format("Isi data pendidikan non Formal Untuk Calon Peserta Didik{0}Dengan Nomor Pendaftaran: {1}  Nama: {2}", vbNewLine, oClassPendaftaran.NomorPendaftaran, oClassPendaftaran.namaPendaftar)

    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colidPendaftar, oClassPendaftaran.IdPelamar)
    End Sub
End Class