﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReport4
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReport4))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.DataSetReport1 = New StudentEnrollment.DataSetReport()
        Me.ReportPendaftarByDateTableAdapter = New StudentEnrollment.DataSetReportTableAdapters.ReportPendaftarByDateTableAdapter()
        Me.PageHeaderBand1 = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrLabel69 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.Dpi = 100.0!
        Me.Detail.HeightF = 23.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable2
        '
        Me.XrTable2.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrTable2.Dpi = 100.0!
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(638.0!, 23.0!)
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell8, Me.XrTableCell10, Me.XrTableCell12})
        Me.XrTableRow4.Dpi = 100.0!
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 1.0R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.CanGrow = False
        Me.XrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ReportKelulusan.Nama")})
        Me.XrTableCell8.Dpi = 100.0!
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StyleName = "DataField"
        Me.XrTableCell8.Text = "XrTableCell8"
        Me.XrTableCell8.Weight = 51.5R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.CanGrow = False
        Me.XrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ReportKelulusan.NomorPendaftaran")})
        Me.XrTableCell10.Dpi = 100.0!
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StyleName = "DataField"
        Me.XrTableCell10.Text = "XrTableCell10"
        Me.XrTableCell10.Weight = 167.5R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.CanGrow = False
        Me.XrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ReportKelulusan.Keterangan")})
        Me.XrTableCell12.Dpi = 100.0!
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.StyleName = "DataField"
        Me.XrTableCell12.Text = "XrTableCell12"
        Me.XrTableCell12.Weight = 99.0R
        '
        'DataSetReport1
        '
        Me.DataSetReport1.DataSetName = "DataSetReport"
        Me.DataSetReport1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportPendaftarByDateTableAdapter
        '
        Me.ReportPendaftarByDateTableAdapter.ClearBeforeFill = True
        '
        'PageHeaderBand1
        '
        Me.PageHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.PageHeaderBand1.Dpi = 100.0!
        Me.PageHeaderBand1.HeightF = 42.0!
        Me.PageHeaderBand1.Name = "PageHeaderBand1"
        '
        'XrTable1
        '
        Me.XrTable1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrTable1.Dpi = 100.0!
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 6.0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(638.0!, 36.0!)
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.XrTableCell9, Me.XrTableCell11})
        Me.XrTableRow3.Dpi = 100.0!
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1.0R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.CanGrow = False
        Me.XrTableCell7.Dpi = 100.0!
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StyleName = "FieldCaption"
        Me.XrTableCell7.Text = "Nama"
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell7.Weight = 51.5R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.CanGrow = False
        Me.XrTableCell9.Dpi = 100.0!
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StyleName = "FieldCaption"
        Me.XrTableCell9.Text = "Nomor Pendaftaran"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell9.Weight = 167.5R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.CanGrow = False
        Me.XrTableCell11.Dpi = 100.0!
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StyleName = "FieldCaption"
        Me.XrTableCell11.Text = "Keterangan"
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell11.Weight = 99.0R
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3})
        Me.XrTableRow1.Dpi = 100.0!
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Dpi = 100.0!
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Text = "XrTableCell1"
        Me.XrTableCell1.Weight = 1.0R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Dpi = 100.0!
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "XrTableCell2"
        Me.XrTableCell2.Weight = 1.0R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Dpi = 100.0!
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = "XrTableCell3"
        Me.XrTableCell3.Weight = 1.0R
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6})
        Me.XrTableRow2.Dpi = 100.0!
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Dpi = 100.0!
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Text = "XrTableCell4"
        Me.XrTableCell4.Weight = 1.0R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Dpi = 100.0!
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Text = "XrTableCell5"
        Me.XrTableCell5.Weight = 1.0R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Dpi = 100.0!
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Text = "XrTableCell6"
        Me.XrTableCell6.Weight = 1.0R
        '
        'PageFooterBand1
        '
        Me.PageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.XrPageInfo2})
        Me.PageFooterBand1.Dpi = 100.0!
        Me.PageFooterBand1.HeightF = 29.0!
        Me.PageFooterBand1.Name = "PageFooterBand1"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Dpi = 100.0!
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 6.0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
        Me.XrPageInfo1.StyleName = "PageInfo"
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Dpi = 100.0!
        Me.XrPageInfo2.Format = "Page {0} of {1}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(331.0!, 6.0!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
        Me.XrPageInfo2.StyleName = "PageInfo"
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'ReportHeaderBand1
        '
        Me.ReportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1})
        Me.ReportHeaderBand1.Dpi = 100.0!
        Me.ReportHeaderBand1.HeightF = 53.0!
        Me.ReportHeaderBand1.Name = "ReportHeaderBand1"
        '
        'XrLabel1
        '
        Me.XrLabel1.Dpi = 100.0!
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 6.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(638.0!, 35.0!)
        Me.XrLabel1.StyleName = "Title"
        Me.XrLabel1.Text = "Laporan Kelulusan"
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1.0!
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 21.0!)
        Me.Title.ForeColor = System.Drawing.Color.Black
        Me.Title.Name = "Title"
        '
        'FieldCaption
        '
        Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
        Me.FieldCaption.BorderColor = System.Drawing.Color.Black
        Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.FieldCaption.BorderWidth = 1.0!
        Me.FieldCaption.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.FieldCaption.ForeColor = System.Drawing.Color.Black
        Me.FieldCaption.Name = "FieldCaption"
        '
        'PageInfo
        '
        Me.PageInfo.BackColor = System.Drawing.Color.Transparent
        Me.PageInfo.BorderColor = System.Drawing.Color.Black
        Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PageInfo.BorderWidth = 1.0!
        Me.PageInfo.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.PageInfo.ForeColor = System.Drawing.Color.Black
        Me.PageInfo.Name = "PageInfo"
        '
        'DataField
        '
        Me.DataField.BackColor = System.Drawing.Color.Transparent
        Me.DataField.BorderColor = System.Drawing.Color.Black
        Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DataField.BorderWidth = 1.0!
        Me.DataField.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DataField.ForeColor = System.Drawing.Color.Black
        Me.DataField.Name = "DataField"
        Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel69, Me.XrPictureBox2, Me.XrLabel39})
        Me.TopMarginBand1.Dpi = 100.0!
        Me.TopMarginBand1.HeightF = 121.875!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.Dpi = 100.0!
        Me.BottomMarginBand1.HeightF = 100.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'XrLabel69
        '
        Me.XrLabel69.Dpi = 100.0!
        Me.XrLabel69.LocationFloat = New DevExpress.Utils.PointFloat(142.9166!, 52.58333!)
        Me.XrLabel69.Name = "XrLabel69"
        Me.XrLabel69.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel69.SizeF = New System.Drawing.SizeF(493.8751!, 23.0!)
        Me.XrLabel69.StylePriority.UseTextAlignment = False
        Me.XrLabel69.Text = "JL Nusa Dua Atas, No. 48, Bencongan, Kelapa Dua, 15810, Kec. Tangerang"
        Me.XrLabel69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.Dpi = 100.0!
        Me.XrPictureBox2.Image = CType(resources.GetObject("XrPictureBox2.Image"), System.Drawing.Image)
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(13.20828!, 0!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(116.6666!, 121.875!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        '
        'XrLabel39
        '
        Me.XrLabel39.Dpi = 100.0!
        Me.XrLabel39.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(142.9165!, 25.41666!)
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel39.SizeF = New System.Drawing.SizeF(493.8751!, 27.16667!)
        Me.XrLabel39.StylePriority.UseFont = False
        Me.XrLabel39.StylePriority.UseTextAlignment = False
        Me.XrLabel39.Text = "SMK NUSA JAYA"
        Me.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XtraReport4
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeaderBand1, Me.PageFooterBand1, Me.ReportHeaderBand1, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.DataMember = "ReportKelulusan"
        Me.DataSource = Me.DataSetReport1
        Me.Margins = New System.Drawing.Printing.Margins(100, 100, 122, 100)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "16.1"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetReport1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents DataSetReport1 As DataSetReport
    Friend WithEvents ReportPendaftarByDateTableAdapter As DataSetReportTableAdapters.ReportPendaftarByDateTableAdapter
    Friend WithEvents PageHeaderBand1 As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents ReportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel69 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
End Class
