Imports DevExpress.XtraGrid.Views.Grid

Public Class FormTestHeader
    Public Property isAll As Boolean
    Private Sub HeaderTestBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles HeaderTestBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.HeaderTestBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetTest)

    End Sub

    Private Sub FormTestHeader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetTest.mstTest' table. You can move, or remove it, as needed.
        Me.MstTestTableAdapter.Fill(Me.DataSetTest.mstTest)
        'TODO: This line of code loads data into the 'DataSetTest.headerTest' table. You can move, or remove it, as needed.
        loadDataHeader()
        oClassPendaftaran.GetDataGelombang()
    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colidGelombang, oClassPendaftaran.idGelombang)
        GridView1.SetFocusedRowCellValue(colidUser, aUser.IDUser)
    End Sub

    Private Sub buttonDetail_Click(sender As Object, e As EventArgs) Handles buttonDetail.Click
        oClassTest.idTest = CInt(GridView1.GetFocusedRowCellValue(colidTest))
        oClassTest.namaTest = GridView1.GetFocusedRowCellDisplayText(colidTest)
        oClassTest.idHeader = GridView1.GetFocusedRowCellValue(colid)
        FormDetailTest.ShowDialog()

    End Sub

    Sub loadDataHeader()
        oClassPendaftaran.GetDataGelombang()

        Try
            Me.HeaderTestTableAdapter.Fill(Me.DataSetTest.headerTest, New Integer?(oClassPendaftaran.idGelombang), New Boolean?(isAll))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class