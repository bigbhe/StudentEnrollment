Public Class FormStatusPendaftaran
    Private Sub StatusBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.StatusBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetPropertiPendaftaran)

    End Sub

    Private Sub FormStatusPendaftaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetPropertiPendaftaran.status' table. You can move, or remove it, as needed.
        Me.StatusTableAdapter.Fill(Me.DataSetPropertiPendaftaran.status)

    End Sub
End Class