Imports DevExpress.XtraGrid.Views.Grid

Public Class FormHeaderGelombang
    Private Sub HeaderGelombangBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles HeaderGelombangBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.HeaderGelombangBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetGelombang)

    End Sub

    Private Sub FormHeaderGelombang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetGelombang.headerGelombang' table. You can move, or remove it, as needed.
        Me.HeaderGelombangTableAdapter.Fill(Me.DataSetGelombang.headerGelombang)

    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colkodeGelombang, "SNJ-PSB" & getDateString() & "" & GetUniqueKey(3))
    End Sub

    Private Sub buttonFill_Click(sender As Object, e As EventArgs) Handles buttonFill.Click
        oClassGelombang.idGelombang = CInt(GridView1.GetFocusedRowCellValue(colid))
        oClassGelombang.namaGelombang = CType(GridView1.GetFocusedRowCellValue(colnamaGelombang), String)
        oClassGelombang.gelombangStart = CDate(GridView1.GetFocusedRowCellValue(coltanggalMulai))
        oClassGelombang.gelombangEnd = CDate(GridView1.GetFocusedRowCellValue(coltanggalBerakhir))
        oClassGelombang.kodeGelombang = CType(GridView1.GetFocusedRowCellValue(colkodeGelombang), String)
        FormDetailGelombang.ShowDialog()

    End Sub
End Class