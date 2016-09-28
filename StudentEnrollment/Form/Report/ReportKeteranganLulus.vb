Public Class ReportKeteranganLulus
    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        oClassPendaftaran.GetDataGelombang()

        Try
            Me.ReportKelulusanTableAdapter.Fill(Me.DataSetReport.ReportKelulusan, New System.Nullable(Of Integer)(CType(oClassPendaftaran.idGelombang, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Dim report As New XtraReport4 With {.DataSource = DataSetReport.Tables("ReportKelulusan"), .DataMember = "ReportKelulusan"}
        Dim tools As New DevExpress.XtraReports.UI.ReportPrintTool(report)
        tools.ShowPreview()
        Me.Close()


    End Sub
    Sub loadData()
        oClassPendaftaran.GetDataGelombang()

        Try
            Me.ReportKelulusanTableAdapter.Fill(Me.DataSetReport.ReportKelulusan, New System.Nullable(Of Integer)(CType(oClassPendaftaran.idGelombang, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Dim report As New XtraReport4 With {.DataSource = DataSetReport.Tables("ReportKelulusan"), .DataMember = "ReportKelulusan"}
        Dim tools As New DevExpress.XtraReports.UI.ReportPrintTool(report)
        tools.ShowPreview()
        Me.Close()


    End Sub

    Private Sub ReportKeteranganLulus_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadData()

    End Sub
End Class