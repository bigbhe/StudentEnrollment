Imports DevExpress.XtraGrid.Views.Grid

Public Class FormPendaftaran
    Sub SaveData()
        Me.Validate()
        Me.MstPendaftarBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetPendaftaran)

    End Sub
    Private Sub MstPendaftarBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MstPendaftarBindingNavigatorSaveItem.Click
        SaveData()
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
    ''' <summary>
    ''' 
    ''' </summary>
    Sub GetAvailableJurusan()
        Try
            Me.AvailableJurusanTableAdapter.Fill(Me.DataSetPendaftaran.AvailableJurusan, CType(oClassPendaftaran.idGelombang, Integer))
        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub idJurusanLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles idJurusanLookUpEdit.EditValueChanged
        If idJurusanLookUpEdit.ItemIndex = -1 Then
            Exit Sub
        Else
            oClassPendaftaran.idJurusan = CInt(idJurusanLookUpEdit.EditValue)
            Dim i As Integer = oClassPendaftaran.getKuota()
            labelInfo.Text = String.Format("Sisa Kuota Pendaftaran untuk jurusan: {0} Pada: {1} adalah: {2}", idJurusanLookUpEdit.Text, oClassPendaftaran.namaGelombang, i)

        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colidGelombang, oClassPendaftaran.idGelombang)
        GridView1.SetFocusedRowCellValue(coltanggalPendaftaran, Now)
        GridView1.SetFocusedRowCellValue(colNomorPendaftaran, String.Format("SNJ-R{0}{1}", getDateString(), GetUniqueKey(4)))
        GridView1.SetFocusedRowCellValue(colidUser, aUser.IDUser)

    End Sub

    Private Sub buttonNilaiUN_Click(sender As Object, e As EventArgs) Handles buttonNilaiUN.Click
        If GridView1.RowCount = 0 Then Exit Sub
        SaveData()
        oClassPendaftaran.IdPelamar = getId()
        FormNilaiUN.ShowDialog()

    End Sub
    Function getId() As Integer

        Dim i As Integer = CInt(GridView1.GetFocusedRowCellValue(colid))
        oClassPendaftaran.NomorPendaftaran = CType(GridView1.GetFocusedRowCellValue(colNomorPendaftaran), String)
        oClassPendaftaran.namaPendaftar = CType(GridView1.GetFocusedRowCellValue(colnama), String)
        Return i
    End Function

    Private Sub buttonPrestasi_Click(sender As Object, e As EventArgs) Handles buttonPrestasi.Click
        If GridView1.RowCount = 0 Then Exit Sub
        SaveData()
        oClassPendaftaran.IdPelamar = getId()
        FormPrestasi.ShowDialog()

    End Sub

    Private Sub buttonPendidikanNonFormal_Click(sender As Object, e As EventArgs) Handles buttonPendidikanNonFormal.Click
        If GridView1.RowCount = 0 Then Exit Sub
        SaveData()
        oClassPendaftaran.IdPelamar = getId()
        FormPendidikanNonFormal.ShowDialog()
    End Sub

    Private Sub buttonPengalamanOrganisasi_Click(sender As Object, e As EventArgs) Handles buttonPengalamanOrganisasi.Click
        If GridView1.RowCount = 0 Then Exit Sub
        SaveData()
        oClassPendaftaran.IdPelamar = getId()
        FormPengalamanOrganisasi.ShowDialog()
    End Sub

    Private Sub buttonHobi_Click(sender As Object, e As EventArgs) Handles buttonHobi.Click

        If GridView1.RowCount = 0 Then Exit Sub
        SaveData()
        oClassPendaftaran.IdPelamar = getId()
        FormTraHobi.ShowDialog()
    End Sub

    Private Sub FormPendaftaran_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        oClassPendaftaran.IdPelamar = getId()
        Dim i As Integer = oClassPendaftaran.getJumlahDataUn()
        If i < 4 Then
            If XtraMessageBox.Show("Data Nilai UN Belum lengkap apakah anda akan menutup form ini", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                e.Cancel = True
                FormNilaiUN.ShowDialog()
            End If
        End If
    End Sub

    Private Sub buttonPrint_Click(sender As Object, e As EventArgs) Handles buttonPrint.Click
        oClassPendaftaran.IdPelamar = getId()
        FormReportPP.ShowDialog()

    End Sub
End Class