Public Class FormHobi
    Private Sub MstHobiBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MstHobiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MstHobiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetPropertiPendaftaran)

    End Sub

    Private Sub FormHobi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetPropertiPendaftaran.mstHobi' table. You can move, or remove it, as needed.
        Me.MstHobiTableAdapter.Fill(Me.DataSetPropertiPendaftaran.mstHobi)

    End Sub
End Class