Public Class FormMataPelajaran
    Private Sub MstMataPelajaranBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MstMataPelajaranBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MstMataPelajaranBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetPropertiPendaftaran)

    End Sub

    Private Sub FormMataPelajaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetPropertiPendaftaran.mstMataPelajaran' table. You can move, or remove it, as needed.
        Me.MstMataPelajaranTableAdapter.Fill(Me.DataSetPropertiPendaftaran.mstMataPelajaran)

    End Sub
End Class