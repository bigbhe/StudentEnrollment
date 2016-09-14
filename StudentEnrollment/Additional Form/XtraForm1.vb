Public Class XtraForm1
    Private Sub HeaderTestBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles HeaderTestBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.HeaderTestBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetTest)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            Me.HeaderTestTableAdapter.Fill(Me.DataSetTest.headerTest, New System.Nullable(Of Integer)(CType(IdGelombangToolStripTextBox.Text, Integer)), New System.Nullable(Of Boolean)(CType(IsAllToolStripTextBox.Text, Boolean)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class