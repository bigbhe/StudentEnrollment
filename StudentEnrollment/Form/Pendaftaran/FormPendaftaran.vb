Imports DevExpress.XtraGrid.Views.Grid

Public Class FormPendaftaran
    Private Sub MstPendaftarBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MstPendaftarBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MstPendaftarBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetPendaftaran)

    End Sub

    Private Sub FormPendaftaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetPendaftaran.mstJurusan' table. You can move, or remove it, as needed.
        Me.MstJurusanTableAdapter.Fill(Me.DataSetPendaftaran.mstJurusan)
        'TODO: This line of code loads data into the 'DataSetPendaftaran.mstPendaftar' table. You can move, or remove it, as needed.
        Me.MstPendaftarTableAdapter.Fill(Me.DataSetPendaftaran.mstPendaftar)
        oClassPendaftaran.GetDataGelombang()
        GetAvailableJurusan()
        GridView1.BestFitColumns(True)
    End Sub
    Sub GetAvailableJurusan()
        Try
            Me.AvailableJurusanTableAdapter.Fill(Me.DataSetPendaftaran.AvailableJurusan, CType(oClassPendaftaran.idGelombang, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub idJurusanLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles idJurusanLookUpEdit.EditValueChanged
        If idJurusanLookUpEdit.ItemIndex = -1 Then
            Exit Sub
        Else
            oClassPendaftaran.idJurusan = CInt(idJurusanLookUpEdit.EditValue)
            Dim i As Integer
            i = oClassPendaftaran.getKuota()
            labelInfo.Text = "Sisa Kuota Pendaftaran untuk jurusan: " & idJurusanLookUpEdit.Text & " Pada: " & oClassPendaftaran.namaGelombang & " adalah: " & i

        End If
    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colidGelombang, oClassPendaftaran.idGelombang)
        GridView1.SetFocusedRowCellValue(coltanggalPendaftaran, Now)
        GridView1.SetFocusedRowCellValue(colNomorPendaftaran, "SNJ-R" & getDateString() & "" & GetUniqueKey(4))
        GridView1.SetFocusedRowCellValue(colidUser, aUser.IDUser)

    End Sub
End Class