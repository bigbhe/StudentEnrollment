Public Class FormPendaftaran
    Private Sub MstPendaftarBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MstPendaftarBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MstPendaftarBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetPendaftaran)

    End Sub

    Private Sub FormPendaftaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetPendaftaran.mstPendaftar' table. You can move, or remove it, as needed.
        Me.MstPendaftarTableAdapter.Fill(Me.DataSetPendaftaran.mstPendaftar)

    End Sub
End Class