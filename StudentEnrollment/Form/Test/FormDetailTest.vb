Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Base

Public Class FormDetailTest
    Private Sub DetailtestBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DetailtestBindingNavigatorSaveItem.Click
        Save()
    End Sub

    Private Sub FormDetailTest_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
        LabelControl1.Text = String.Format("Isi Detail Data Test Untuk Test {0}", oClassTest.namaTest)
    End Sub

    Private Sub LoadData()
        Try
            Me.DetailtestTableAdapter.Fill(Me.DataSetTest.detailTest, New System.Nullable(Of Integer)(CType(oClassPendaftaran.idGelombang, Integer)), New System.Nullable(Of Boolean)(CType(oClassTest.IsProcess, Boolean)), New System.Nullable(Of Integer)(CType(oClassTest.idHeader, Integer)), New System.Nullable(Of Integer)(CType(oClassTest.idTest, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub Save()
        Try
            defaultState()
            Me.Validate()
            Me.DetailtestBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DataSetTest)
        Catch ex As Exception
            If ex.Message.ToString.ToLower.Contains("primary") Then
                defaultState()
                GridView1.SetFocusedRowCellValue(colisInsert, 0)
                Me.Validate()
                Me.DetailtestBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.DataSetTest)
            End If

        End Try
        LoadData()

    End Sub
    Sub defaultState()
        GridView1.SetFocusedRowCellValue(colidheader, oClassTest.idHeader)
    End Sub

    Private Sub GridView1_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView1.RowUpdated
        Save()
        LoadData()

    End Sub

    Private Sub FormDetailTest_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing


        If oClassTest.getDataKurang > 0 Then

            If XtraMessageBox.Show(String.Format("Data Nilai {0} Belum lengkap apakah anda akan menutup form ini", oClassTest.namaTest), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                e.Cancel = True

            End If
        End If
    End Sub

    'Private Sub checkEditIsFail_EditValueChanged(sender As Object, e As EventArgs)
    '    If checkEditIsFail.CheckState = CheckState.Checked Then
    '        oClassTest.IsProcess = False
    '        LoadData()
    '    ElseIf checkEditIsFail.CheckState = CheckState.Unchecked Then
    '        oClassTest.IsProcess = True
    '        LoadData()

    '    End If
    'End Sub
End Class