Public Class FormJurusan
    Private Sub MstJurusanBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MstJurusanBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MstJurusanBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetPropertiPendaftaran)

    End Sub

    Private Sub FormJurusan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetPropertiPendaftaran.mstJurusan' table. You can move, or remove it, as needed.
        Me.MstJurusanTableAdapter.Fill(Me.DataSetPropertiPendaftaran.mstJurusan)

    End Sub
End Class