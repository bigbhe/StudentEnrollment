Imports DevExpress.XtraReports.UI

Public Class FormReportPP
    Private Sub loadhobi()
        Try
            Me.DataHobiPPTableAdapter.Fill(Me.DataSetReportPendaftarPersiswa.dataHobiPP, New System.Nullable(Of Integer)(CType(oClassPendaftaran.IdPelamar, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub loadNIlaiUN()
        Try
            Me.DataNilaiUNPPTableAdapter.Fill(Me.DataSetReportPendaftarPersiswa.dataNilaiUNPP, New System.Nullable(Of Integer)(CType(oClassPendaftaran.IdPelamar, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub loadpnedidikanFormal()
        Try
            Me.DataPendidikanNonFormalPPTableAdapter.Fill(Me.DataSetReportPendaftarPersiswa.dataPendidikanNonFormalPP, New System.Nullable(Of Integer)(CType(oClassPendaftaran.IdPelamar, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub loadDataPengalamanOrganisasi()
        Try
            Me.DatapengalamanOrganisasiTableAdapter.Fill(Me.DataSetReportPendaftarPersiswa.datapengalamanOrganisasi, New System.Nullable(Of Integer)(CType(oClassPendaftaran.IdPelamar, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub loadDataPrestasi()
        Try
            Me.DataPrestasiPPTableAdapter.Fill(Me.DataSetReportPendaftarPersiswa.dataPrestasiPP, New System.Nullable(Of Integer)(CType(oClassPendaftaran.IdPelamar, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub loadDataSiswa()
        Try
            Me.DataSiswaPPTableAdapter.Fill(Me.DataSetReportPendaftarPersiswa.dataSiswaPP, New System.Nullable(Of Integer)(CType(oClassPendaftaran.IdPelamar, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub loadDatatest()
        Try
            Me.DataTestTableAdapter.Fill(Me.DataSetReportPendaftarPersiswa.dataTest, New System.Nullable(Of Integer)(CType(oClassPendaftaran.IdPelamar, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FormReportPP_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadDataPengalamanOrganisasi()
        loadDataPrestasi()
        loadDataSiswa()
        loadDatatest()
        loadpnedidikanFormal()
        loadNIlaiUN()
        loadhobi()

        Dim report As New XtraReport1 With {.DataSource = DataSetReportPendaftarPersiswa}
        Dim tools As New ReportPrintTool(report)
        tools.ShowPreview()
        Me.Close()

    End Sub
End Class