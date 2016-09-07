Imports DevExpress.XtraGrid.Views.Grid

Public Class FormDetailGelombang
    Private Sub DetailGelombangBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DetailGelombangBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DetailGelombangBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetGelombang)

    End Sub

    Sub LoadDataDetail()
        Try
            Me.DetailGelombangTableAdapter.Fill(Me.DataSetGelombang.detailGelombang, New System.Nullable(Of Integer)(CType(oClassGelombang.idGelombang, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FormDetailGelombang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetGelombang.mstJurusan' table. You can move, or remove it, as needed.
        Me.MstJurusanTableAdapter.Fill(Me.DataSetGelombang.mstJurusan)
        LoadDataDetail()
        LabelControl1.Text = "Isi data detail gelombang: " & oClassGelombang.namaGelombang
    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colidHeaderGelombang, oClassGelombang.idGelombang)
    End Sub
End Class