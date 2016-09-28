Public Class FormReportPendaftaranTanggal
    Private Sub loadreport()

        Try
            Me.ReportPendaftarByDateTableAdapter.Fill(Me.DataSetReport.ReportPendaftarByDate, New Date?(DateEdit1.EditValue), New Date?(DateEdit2.EditValue))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Dim report As New XtraReport3 With {.DataSource = DataSetReport.Tables("ReportPendaftarByDate"), .DataMember = "ReportPendaftarByDate"}
        Dim Tools As New DevExpress.XtraReports.UI.ReportPrintTool(report)
        Tools.ShowPreview()



    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        loadreport()

    End Sub

    Private Sub FormReportPendaftaranTanggal_Load(sender As Object, e As EventArgs) Handles Me.Load
        DateEdit1.EditValue = Now
        DateEdit2.EditValue = Now

    End Sub
End Class