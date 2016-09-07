Public Class FormMasterTest
    Private Sub MstTestBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MstTestBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MstTestBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetPropertiPendaftaran)

    End Sub

    Private Sub FormMasterTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetPropertiPendaftaran.mstTest' table. You can move, or remove it, as needed.
        Me.MstTestTableAdapter.Fill(Me.DataSetPropertiPendaftaran.mstTest)

    End Sub
End Class