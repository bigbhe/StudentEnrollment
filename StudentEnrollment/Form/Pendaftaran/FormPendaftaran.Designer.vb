<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPendaftaran
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPendaftaran))
        Me.DataSetPendaftaran = New StudentEnrollment.DataSetPendaftaran()
        Me.MstPendaftarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstPendaftarTableAdapter = New StudentEnrollment.DataSetPendaftaranTableAdapters.mstPendaftarTableAdapter()
        Me.TableAdapterManager = New StudentEnrollment.DataSetPendaftaranTableAdapters.TableAdapterManager()
        Me.MstPendaftarBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MstPendaftarBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MstPendaftarGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNomorPendaftaran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltanggalLahir = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colberatBadan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltinggiBadan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgender = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsekolahAsal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkecSekolahAsal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colalamatSekolahAsal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnamaAyah = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpekerjaan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlamatAyah = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNamaIbu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpekerjaanIbu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colalamatIbu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpenghasilanOrangTua = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidJurusan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnomorIjazah = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnilaiRataRataKelulusan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colphotoIjazah = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colphotoPelamar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhotoKartuKeluarga = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.NomorPendaftaranTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForNomorPendaftaran = New DevExpress.XtraLayout.LayoutControlItem()
        Me.namaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemFornama = New DevExpress.XtraLayout.LayoutControlItem()
        Me.tanggalLahirDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ItemFortanggalLahir = New DevExpress.XtraLayout.LayoutControlItem()
        Me.beratBadanTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForberatBadan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.tinggiBadanTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemFortinggiBadan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.genderRadioGroup = New DevExpress.XtraEditors.RadioGroup()
        Me.ItemForgender = New DevExpress.XtraLayout.LayoutControlItem()
        Me.sekolahAsalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForsekolahAsal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.kecSekolahAsalLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ItemForkecSekolahAsal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.alamatSekolahAsalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForalamatSekolahAsal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.namaAyahTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemFornamaAyah = New DevExpress.XtraLayout.LayoutControlItem()
        Me.pekerjaanTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForpekerjaan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.AlamatAyahMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.ItemForAlamatAyah = New DevExpress.XtraLayout.LayoutControlItem()
        Me.NamaIbuTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForNamaIbu = New DevExpress.XtraLayout.LayoutControlItem()
        Me.pekerjaanIbuTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForpekerjaanIbu = New DevExpress.XtraLayout.LayoutControlItem()
        Me.alamatIbuMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.ItemForalamatIbu = New DevExpress.XtraLayout.LayoutControlItem()
        Me.penghasilanOrangTuaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForpenghasilanOrangTua = New DevExpress.XtraLayout.LayoutControlItem()
        Me.idJurusanLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ItemForidJurusan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.nomorIjazahTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemFornomorIjazah = New DevExpress.XtraLayout.LayoutControlItem()
        Me.nilaiRataRataKelulusanSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ItemFornilaiRataRataKelulusan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.photoIjazahPictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.ItemForphotoIjazah = New DevExpress.XtraLayout.LayoutControlItem()
        Me.photoPelamarPictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.ItemForphotoPelamar = New DevExpress.XtraLayout.LayoutControlItem()
        Me.PhotoKartuKeluargaPictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.ItemForPhotoKartuKeluarga = New DevExpress.XtraLayout.LayoutControlItem()
        Me.idUserTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForidUser = New DevExpress.XtraLayout.LayoutControlItem()
        Me.statusLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ItemForstatus = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DataSetPendaftaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstPendaftarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstPendaftarBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MstPendaftarBindingNavigator.SuspendLayout()
        CType(Me.MstPendaftarGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NomorPendaftaranTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNomorPendaftaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.namaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFornama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tanggalLahirDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tanggalLahirDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFortanggalLahir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beratBadanTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForberatBadan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tinggiBadanTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFortinggiBadan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.genderRadioGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForgender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sekolahAsalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForsekolahAsal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kecSekolahAsalLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForkecSekolahAsal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alamatSekolahAsalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForalamatSekolahAsal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.namaAyahTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFornamaAyah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pekerjaanTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForpekerjaan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlamatAyahMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAlamatAyah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamaIbuTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNamaIbu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pekerjaanIbuTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForpekerjaanIbu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alamatIbuMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForalamatIbu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.penghasilanOrangTuaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForpenghasilanOrangTua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idJurusanLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidJurusan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nomorIjazahTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFornomorIjazah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nilaiRataRataKelulusanSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFornilaiRataRataKelulusan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.photoIjazahPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForphotoIjazah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.photoPelamarPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForphotoPelamar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhotoKartuKeluargaPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPhotoKartuKeluarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idUserTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.statusLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetPendaftaran
        '
        Me.DataSetPendaftaran.DataSetName = "DataSetPendaftaran"
        Me.DataSetPendaftaran.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MstPendaftarBindingSource
        '
        Me.MstPendaftarBindingSource.DataMember = "mstPendaftar"
        Me.MstPendaftarBindingSource.DataSource = Me.DataSetPendaftaran
        '
        'MstPendaftarTableAdapter
        '
        Me.MstPendaftarTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mstPendaftarTableAdapter = Me.MstPendaftarTableAdapter
        Me.TableAdapterManager.UpdateOrder = StudentEnrollment.DataSetPendaftaranTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MstPendaftarBindingNavigator
        '
        Me.MstPendaftarBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MstPendaftarBindingNavigator.BindingSource = Me.MstPendaftarBindingSource
        Me.MstPendaftarBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MstPendaftarBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MstPendaftarBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MstPendaftarBindingNavigatorSaveItem})
        Me.MstPendaftarBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MstPendaftarBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MstPendaftarBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MstPendaftarBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MstPendaftarBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MstPendaftarBindingNavigator.Name = "MstPendaftarBindingNavigator"
        Me.MstPendaftarBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MstPendaftarBindingNavigator.Size = New System.Drawing.Size(1216, 25)
        Me.MstPendaftarBindingNavigator.TabIndex = 0
        Me.MstPendaftarBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MstPendaftarBindingNavigatorSaveItem
        '
        Me.MstPendaftarBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MstPendaftarBindingNavigatorSaveItem.Image = CType(resources.GetObject("MstPendaftarBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MstPendaftarBindingNavigatorSaveItem.Name = "MstPendaftarBindingNavigatorSaveItem"
        Me.MstPendaftarBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MstPendaftarBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MstPendaftarGridControl
        '
        Me.MstPendaftarGridControl.DataSource = Me.MstPendaftarBindingSource
        Me.MstPendaftarGridControl.Location = New System.Drawing.Point(804, 484)
        Me.MstPendaftarGridControl.MainView = Me.GridView1
        Me.MstPendaftarGridControl.Name = "MstPendaftarGridControl"
        Me.MstPendaftarGridControl.Size = New System.Drawing.Size(300, 220)
        Me.MstPendaftarGridControl.TabIndex = 1
        Me.MstPendaftarGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colNomorPendaftaran, Me.colnama, Me.coltanggalLahir, Me.colberatBadan, Me.coltinggiBadan, Me.colgender, Me.colsekolahAsal, Me.colkecSekolahAsal, Me.colalamatSekolahAsal, Me.colnamaAyah, Me.colpekerjaan, Me.colAlamatAyah, Me.colNamaIbu, Me.colpekerjaanIbu, Me.colalamatIbu, Me.colpenghasilanOrangTua, Me.colidJurusan, Me.colnomorIjazah, Me.colnilaiRataRataKelulusan, Me.colphotoIjazah, Me.colphotoPelamar, Me.colPhotoKartuKeluarga, Me.colidUser, Me.colstatus})
        Me.GridView1.GridControl = Me.MstPendaftarGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colNomorPendaftaran
        '
        Me.colNomorPendaftaran.FieldName = "NomorPendaftaran"
        Me.colNomorPendaftaran.Name = "colNomorPendaftaran"
        Me.colNomorPendaftaran.Visible = True
        Me.colNomorPendaftaran.VisibleIndex = 0
        '
        'colnama
        '
        Me.colnama.FieldName = "nama"
        Me.colnama.Name = "colnama"
        Me.colnama.Visible = True
        Me.colnama.VisibleIndex = 1
        '
        'coltanggalLahir
        '
        Me.coltanggalLahir.FieldName = "tanggalLahir"
        Me.coltanggalLahir.Name = "coltanggalLahir"
        Me.coltanggalLahir.Visible = True
        Me.coltanggalLahir.VisibleIndex = 2
        '
        'colberatBadan
        '
        Me.colberatBadan.FieldName = "beratBadan"
        Me.colberatBadan.Name = "colberatBadan"
        Me.colberatBadan.Visible = True
        Me.colberatBadan.VisibleIndex = 3
        '
        'coltinggiBadan
        '
        Me.coltinggiBadan.FieldName = "tinggiBadan"
        Me.coltinggiBadan.Name = "coltinggiBadan"
        Me.coltinggiBadan.Visible = True
        Me.coltinggiBadan.VisibleIndex = 4
        '
        'colgender
        '
        Me.colgender.FieldName = "gender"
        Me.colgender.Name = "colgender"
        Me.colgender.Visible = True
        Me.colgender.VisibleIndex = 5
        '
        'colsekolahAsal
        '
        Me.colsekolahAsal.FieldName = "sekolahAsal"
        Me.colsekolahAsal.Name = "colsekolahAsal"
        Me.colsekolahAsal.Visible = True
        Me.colsekolahAsal.VisibleIndex = 6
        '
        'colkecSekolahAsal
        '
        Me.colkecSekolahAsal.FieldName = "kecSekolahAsal"
        Me.colkecSekolahAsal.Name = "colkecSekolahAsal"
        Me.colkecSekolahAsal.Visible = True
        Me.colkecSekolahAsal.VisibleIndex = 7
        '
        'colalamatSekolahAsal
        '
        Me.colalamatSekolahAsal.FieldName = "alamatSekolahAsal"
        Me.colalamatSekolahAsal.Name = "colalamatSekolahAsal"
        Me.colalamatSekolahAsal.Visible = True
        Me.colalamatSekolahAsal.VisibleIndex = 8
        '
        'colnamaAyah
        '
        Me.colnamaAyah.FieldName = "namaAyah"
        Me.colnamaAyah.Name = "colnamaAyah"
        Me.colnamaAyah.Visible = True
        Me.colnamaAyah.VisibleIndex = 9
        '
        'colpekerjaan
        '
        Me.colpekerjaan.FieldName = "pekerjaan"
        Me.colpekerjaan.Name = "colpekerjaan"
        Me.colpekerjaan.Visible = True
        Me.colpekerjaan.VisibleIndex = 10
        '
        'colAlamatAyah
        '
        Me.colAlamatAyah.FieldName = "AlamatAyah"
        Me.colAlamatAyah.Name = "colAlamatAyah"
        Me.colAlamatAyah.Visible = True
        Me.colAlamatAyah.VisibleIndex = 11
        '
        'colNamaIbu
        '
        Me.colNamaIbu.FieldName = "NamaIbu"
        Me.colNamaIbu.Name = "colNamaIbu"
        Me.colNamaIbu.Visible = True
        Me.colNamaIbu.VisibleIndex = 12
        '
        'colpekerjaanIbu
        '
        Me.colpekerjaanIbu.FieldName = "pekerjaanIbu"
        Me.colpekerjaanIbu.Name = "colpekerjaanIbu"
        Me.colpekerjaanIbu.Visible = True
        Me.colpekerjaanIbu.VisibleIndex = 13
        '
        'colalamatIbu
        '
        Me.colalamatIbu.FieldName = "alamatIbu"
        Me.colalamatIbu.Name = "colalamatIbu"
        Me.colalamatIbu.Visible = True
        Me.colalamatIbu.VisibleIndex = 14
        '
        'colpenghasilanOrangTua
        '
        Me.colpenghasilanOrangTua.FieldName = "penghasilanOrangTua"
        Me.colpenghasilanOrangTua.Name = "colpenghasilanOrangTua"
        Me.colpenghasilanOrangTua.Visible = True
        Me.colpenghasilanOrangTua.VisibleIndex = 15
        '
        'colidJurusan
        '
        Me.colidJurusan.FieldName = "idJurusan"
        Me.colidJurusan.Name = "colidJurusan"
        Me.colidJurusan.Visible = True
        Me.colidJurusan.VisibleIndex = 16
        '
        'colnomorIjazah
        '
        Me.colnomorIjazah.FieldName = "nomorIjazah"
        Me.colnomorIjazah.Name = "colnomorIjazah"
        Me.colnomorIjazah.Visible = True
        Me.colnomorIjazah.VisibleIndex = 17
        '
        'colnilaiRataRataKelulusan
        '
        Me.colnilaiRataRataKelulusan.FieldName = "nilaiRataRataKelulusan"
        Me.colnilaiRataRataKelulusan.Name = "colnilaiRataRataKelulusan"
        Me.colnilaiRataRataKelulusan.Visible = True
        Me.colnilaiRataRataKelulusan.VisibleIndex = 18
        '
        'colphotoIjazah
        '
        Me.colphotoIjazah.FieldName = "photoIjazah"
        Me.colphotoIjazah.Name = "colphotoIjazah"
        Me.colphotoIjazah.Visible = True
        Me.colphotoIjazah.VisibleIndex = 19
        '
        'colphotoPelamar
        '
        Me.colphotoPelamar.FieldName = "photoPelamar"
        Me.colphotoPelamar.Name = "colphotoPelamar"
        Me.colphotoPelamar.Visible = True
        Me.colphotoPelamar.VisibleIndex = 20
        '
        'colPhotoKartuKeluarga
        '
        Me.colPhotoKartuKeluarga.FieldName = "PhotoKartuKeluarga"
        Me.colPhotoKartuKeluarga.Name = "colPhotoKartuKeluarga"
        Me.colPhotoKartuKeluarga.Visible = True
        Me.colPhotoKartuKeluarga.VisibleIndex = 21
        '
        'colidUser
        '
        Me.colidUser.FieldName = "idUser"
        Me.colidUser.Name = "colidUser"
        Me.colidUser.Visible = True
        Me.colidUser.VisibleIndex = 22
        '
        'colstatus
        '
        Me.colstatus.FieldName = "status"
        Me.colstatus.Name = "colstatus"
        Me.colstatus.Visible = True
        Me.colstatus.VisibleIndex = 23
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.NomorPendaftaranTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.namaTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.tanggalLahirDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.beratBadanTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.tinggiBadanTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.genderRadioGroup)
        Me.DataLayoutControl1.Controls.Add(Me.sekolahAsalTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.kecSekolahAsalLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.alamatSekolahAsalTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.namaAyahTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.pekerjaanTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.AlamatAyahMemoEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NamaIbuTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.pekerjaanIbuTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.alamatIbuMemoEdit)
        Me.DataLayoutControl1.Controls.Add(Me.penghasilanOrangTuaTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.idJurusanLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.nomorIjazahTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.nilaiRataRataKelulusanSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.photoIjazahPictureEdit)
        Me.DataLayoutControl1.Controls.Add(Me.photoPelamarPictureEdit)
        Me.DataLayoutControl1.Controls.Add(Me.PhotoKartuKeluargaPictureEdit)
        Me.DataLayoutControl1.Controls.Add(Me.idUserTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.statusLookUpEdit)
        Me.DataLayoutControl1.DataSource = Me.MstPendaftarBindingSource
        Me.DataLayoutControl1.Location = New System.Drawing.Point(30, 82)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(489, 617)
        Me.DataLayoutControl1.TabIndex = 2
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(489, 617)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForNomorPendaftaran, Me.ItemFornama, Me.ItemFortanggalLahir, Me.ItemForberatBadan, Me.ItemFortinggiBadan, Me.ItemForgender, Me.ItemForsekolahAsal, Me.ItemForkecSekolahAsal, Me.ItemForalamatSekolahAsal, Me.ItemFornamaAyah, Me.ItemForpekerjaan, Me.ItemForAlamatAyah, Me.ItemForNamaIbu, Me.ItemForpekerjaanIbu, Me.ItemForalamatIbu, Me.ItemForpenghasilanOrangTua, Me.ItemForidJurusan, Me.ItemFornomorIjazah, Me.ItemFornilaiRataRataKelulusan, Me.ItemForphotoIjazah, Me.ItemForphotoPelamar, Me.ItemForPhotoKartuKeluarga, Me.ItemForidUser, Me.ItemForstatus})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(469, 597)
        '
        'NomorPendaftaranTextEdit
        '
        Me.NomorPendaftaranTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "NomorPendaftaran", True))
        Me.NomorPendaftaranTextEdit.Location = New System.Drawing.Point(134, 12)
        Me.NomorPendaftaranTextEdit.Name = "NomorPendaftaranTextEdit"
        Me.NomorPendaftaranTextEdit.Size = New System.Drawing.Size(343, 20)
        Me.NomorPendaftaranTextEdit.StyleController = Me.DataLayoutControl1
        Me.NomorPendaftaranTextEdit.TabIndex = 4
        '
        'ItemForNomorPendaftaran
        '
        Me.ItemForNomorPendaftaran.Control = Me.NomorPendaftaranTextEdit
        Me.ItemForNomorPendaftaran.Location = New System.Drawing.Point(0, 0)
        Me.ItemForNomorPendaftaran.Name = "ItemForNomorPendaftaran"
        Me.ItemForNomorPendaftaran.Size = New System.Drawing.Size(469, 24)
        Me.ItemForNomorPendaftaran.Text = "Nomor Pendaftaran"
        Me.ItemForNomorPendaftaran.TextSize = New System.Drawing.Size(118, 13)
        '
        'namaTextEdit
        '
        Me.namaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "nama", True))
        Me.namaTextEdit.Location = New System.Drawing.Point(134, 36)
        Me.namaTextEdit.Name = "namaTextEdit"
        Me.namaTextEdit.Size = New System.Drawing.Size(343, 20)
        Me.namaTextEdit.StyleController = Me.DataLayoutControl1
        Me.namaTextEdit.TabIndex = 5
        '
        'ItemFornama
        '
        Me.ItemFornama.Control = Me.namaTextEdit
        Me.ItemFornama.Location = New System.Drawing.Point(0, 24)
        Me.ItemFornama.Name = "ItemFornama"
        Me.ItemFornama.Size = New System.Drawing.Size(469, 24)
        Me.ItemFornama.Text = "nama"
        Me.ItemFornama.TextSize = New System.Drawing.Size(118, 13)
        '
        'tanggalLahirDateEdit
        '
        Me.tanggalLahirDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "tanggalLahir", True))
        Me.tanggalLahirDateEdit.EditValue = Nothing
        Me.tanggalLahirDateEdit.Location = New System.Drawing.Point(134, 60)
        Me.tanggalLahirDateEdit.Name = "tanggalLahirDateEdit"
        Me.tanggalLahirDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tanggalLahirDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tanggalLahirDateEdit.Size = New System.Drawing.Size(343, 20)
        Me.tanggalLahirDateEdit.StyleController = Me.DataLayoutControl1
        Me.tanggalLahirDateEdit.TabIndex = 6
        '
        'ItemFortanggalLahir
        '
        Me.ItemFortanggalLahir.Control = Me.tanggalLahirDateEdit
        Me.ItemFortanggalLahir.Location = New System.Drawing.Point(0, 48)
        Me.ItemFortanggalLahir.Name = "ItemFortanggalLahir"
        Me.ItemFortanggalLahir.Size = New System.Drawing.Size(469, 24)
        Me.ItemFortanggalLahir.Text = "tanggal Lahir"
        Me.ItemFortanggalLahir.TextSize = New System.Drawing.Size(118, 13)
        '
        'beratBadanTextEdit
        '
        Me.beratBadanTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "beratBadan", True))
        Me.beratBadanTextEdit.Location = New System.Drawing.Point(134, 84)
        Me.beratBadanTextEdit.Name = "beratBadanTextEdit"
        Me.beratBadanTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.beratBadanTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.beratBadanTextEdit.Properties.Mask.EditMask = "N0"
        Me.beratBadanTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.beratBadanTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.beratBadanTextEdit.Size = New System.Drawing.Size(343, 20)
        Me.beratBadanTextEdit.StyleController = Me.DataLayoutControl1
        Me.beratBadanTextEdit.TabIndex = 7
        '
        'ItemForberatBadan
        '
        Me.ItemForberatBadan.Control = Me.beratBadanTextEdit
        Me.ItemForberatBadan.Location = New System.Drawing.Point(0, 72)
        Me.ItemForberatBadan.Name = "ItemForberatBadan"
        Me.ItemForberatBadan.Size = New System.Drawing.Size(469, 24)
        Me.ItemForberatBadan.Text = "berat Badan"
        Me.ItemForberatBadan.TextSize = New System.Drawing.Size(118, 13)
        '
        'tinggiBadanTextEdit
        '
        Me.tinggiBadanTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "tinggiBadan", True))
        Me.tinggiBadanTextEdit.Location = New System.Drawing.Point(134, 108)
        Me.tinggiBadanTextEdit.Name = "tinggiBadanTextEdit"
        Me.tinggiBadanTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.tinggiBadanTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.tinggiBadanTextEdit.Properties.Mask.EditMask = "N0"
        Me.tinggiBadanTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tinggiBadanTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tinggiBadanTextEdit.Size = New System.Drawing.Size(343, 20)
        Me.tinggiBadanTextEdit.StyleController = Me.DataLayoutControl1
        Me.tinggiBadanTextEdit.TabIndex = 8
        '
        'ItemFortinggiBadan
        '
        Me.ItemFortinggiBadan.Control = Me.tinggiBadanTextEdit
        Me.ItemFortinggiBadan.Location = New System.Drawing.Point(0, 96)
        Me.ItemFortinggiBadan.Name = "ItemFortinggiBadan"
        Me.ItemFortinggiBadan.Size = New System.Drawing.Size(469, 24)
        Me.ItemFortinggiBadan.Text = "tinggi Badan"
        Me.ItemFortinggiBadan.TextSize = New System.Drawing.Size(118, 13)
        '
        'genderRadioGroup
        '
        Me.genderRadioGroup.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "gender", True))
        Me.genderRadioGroup.Location = New System.Drawing.Point(134, 132)
        Me.genderRadioGroup.Name = "genderRadioGroup"
        Me.genderRadioGroup.Size = New System.Drawing.Size(343, 21)
        Me.genderRadioGroup.StyleController = Me.DataLayoutControl1
        Me.genderRadioGroup.TabIndex = 9
        '
        'ItemForgender
        '
        Me.ItemForgender.Control = Me.genderRadioGroup
        Me.ItemForgender.Location = New System.Drawing.Point(0, 120)
        Me.ItemForgender.Name = "ItemForgender"
        Me.ItemForgender.Size = New System.Drawing.Size(469, 25)
        Me.ItemForgender.StartNewLine = True
        Me.ItemForgender.Text = "gender"
        Me.ItemForgender.TextSize = New System.Drawing.Size(118, 13)
        '
        'sekolahAsalTextEdit
        '
        Me.sekolahAsalTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "sekolahAsal", True))
        Me.sekolahAsalTextEdit.Location = New System.Drawing.Point(134, 157)
        Me.sekolahAsalTextEdit.Name = "sekolahAsalTextEdit"
        Me.sekolahAsalTextEdit.Size = New System.Drawing.Size(343, 20)
        Me.sekolahAsalTextEdit.StyleController = Me.DataLayoutControl1
        Me.sekolahAsalTextEdit.TabIndex = 10
        '
        'ItemForsekolahAsal
        '
        Me.ItemForsekolahAsal.Control = Me.sekolahAsalTextEdit
        Me.ItemForsekolahAsal.Location = New System.Drawing.Point(0, 145)
        Me.ItemForsekolahAsal.Name = "ItemForsekolahAsal"
        Me.ItemForsekolahAsal.Size = New System.Drawing.Size(469, 24)
        Me.ItemForsekolahAsal.Text = "sekolah Asal"
        Me.ItemForsekolahAsal.TextSize = New System.Drawing.Size(118, 13)
        '
        'kecSekolahAsalLookUpEdit
        '
        Me.kecSekolahAsalLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "kecSekolahAsal", True))
        Me.kecSekolahAsalLookUpEdit.Location = New System.Drawing.Point(134, 181)
        Me.kecSekolahAsalLookUpEdit.Name = "kecSekolahAsalLookUpEdit"
        Me.kecSekolahAsalLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.kecSekolahAsalLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.kecSekolahAsalLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kecSekolahAsalLookUpEdit.Properties.NullText = ""
        Me.kecSekolahAsalLookUpEdit.Size = New System.Drawing.Size(343, 20)
        Me.kecSekolahAsalLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.kecSekolahAsalLookUpEdit.TabIndex = 11
        '
        'ItemForkecSekolahAsal
        '
        Me.ItemForkecSekolahAsal.Control = Me.kecSekolahAsalLookUpEdit
        Me.ItemForkecSekolahAsal.Location = New System.Drawing.Point(0, 169)
        Me.ItemForkecSekolahAsal.Name = "ItemForkecSekolahAsal"
        Me.ItemForkecSekolahAsal.Size = New System.Drawing.Size(469, 24)
        Me.ItemForkecSekolahAsal.Text = "kec Sekolah Asal"
        Me.ItemForkecSekolahAsal.TextSize = New System.Drawing.Size(118, 13)
        '
        'alamatSekolahAsalTextEdit
        '
        Me.alamatSekolahAsalTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "alamatSekolahAsal", True))
        Me.alamatSekolahAsalTextEdit.Location = New System.Drawing.Point(134, 205)
        Me.alamatSekolahAsalTextEdit.Name = "alamatSekolahAsalTextEdit"
        Me.alamatSekolahAsalTextEdit.Size = New System.Drawing.Size(343, 20)
        Me.alamatSekolahAsalTextEdit.StyleController = Me.DataLayoutControl1
        Me.alamatSekolahAsalTextEdit.TabIndex = 12
        '
        'ItemForalamatSekolahAsal
        '
        Me.ItemForalamatSekolahAsal.Control = Me.alamatSekolahAsalTextEdit
        Me.ItemForalamatSekolahAsal.Location = New System.Drawing.Point(0, 193)
        Me.ItemForalamatSekolahAsal.Name = "ItemForalamatSekolahAsal"
        Me.ItemForalamatSekolahAsal.Size = New System.Drawing.Size(469, 24)
        Me.ItemForalamatSekolahAsal.Text = "alamat Sekolah Asal"
        Me.ItemForalamatSekolahAsal.TextSize = New System.Drawing.Size(118, 13)
        '
        'namaAyahTextEdit
        '
        Me.namaAyahTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "namaAyah", True))
        Me.namaAyahTextEdit.Location = New System.Drawing.Point(134, 229)
        Me.namaAyahTextEdit.Name = "namaAyahTextEdit"
        Me.namaAyahTextEdit.Size = New System.Drawing.Size(343, 20)
        Me.namaAyahTextEdit.StyleController = Me.DataLayoutControl1
        Me.namaAyahTextEdit.TabIndex = 13
        '
        'ItemFornamaAyah
        '
        Me.ItemFornamaAyah.Control = Me.namaAyahTextEdit
        Me.ItemFornamaAyah.Location = New System.Drawing.Point(0, 217)
        Me.ItemFornamaAyah.Name = "ItemFornamaAyah"
        Me.ItemFornamaAyah.Size = New System.Drawing.Size(469, 24)
        Me.ItemFornamaAyah.Text = "nama Ayah"
        Me.ItemFornamaAyah.TextSize = New System.Drawing.Size(118, 13)
        '
        'pekerjaanTextEdit
        '
        Me.pekerjaanTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "pekerjaan", True))
        Me.pekerjaanTextEdit.Location = New System.Drawing.Point(134, 253)
        Me.pekerjaanTextEdit.Name = "pekerjaanTextEdit"
        Me.pekerjaanTextEdit.Size = New System.Drawing.Size(343, 20)
        Me.pekerjaanTextEdit.StyleController = Me.DataLayoutControl1
        Me.pekerjaanTextEdit.TabIndex = 14
        '
        'ItemForpekerjaan
        '
        Me.ItemForpekerjaan.Control = Me.pekerjaanTextEdit
        Me.ItemForpekerjaan.Location = New System.Drawing.Point(0, 241)
        Me.ItemForpekerjaan.Name = "ItemForpekerjaan"
        Me.ItemForpekerjaan.Size = New System.Drawing.Size(469, 24)
        Me.ItemForpekerjaan.Text = "pekerjaan"
        Me.ItemForpekerjaan.TextSize = New System.Drawing.Size(118, 13)
        '
        'AlamatAyahMemoEdit
        '
        Me.AlamatAyahMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "AlamatAyah", True))
        Me.AlamatAyahMemoEdit.Location = New System.Drawing.Point(134, 277)
        Me.AlamatAyahMemoEdit.Name = "AlamatAyahMemoEdit"
        Me.AlamatAyahMemoEdit.Size = New System.Drawing.Size(343, 22)
        Me.AlamatAyahMemoEdit.StyleController = Me.DataLayoutControl1
        Me.AlamatAyahMemoEdit.TabIndex = 15
        '
        'ItemForAlamatAyah
        '
        Me.ItemForAlamatAyah.Control = Me.AlamatAyahMemoEdit
        Me.ItemForAlamatAyah.Location = New System.Drawing.Point(0, 265)
        Me.ItemForAlamatAyah.Name = "ItemForAlamatAyah"
        Me.ItemForAlamatAyah.Size = New System.Drawing.Size(469, 26)
        Me.ItemForAlamatAyah.StartNewLine = True
        Me.ItemForAlamatAyah.Text = "Alamat Ayah"
        Me.ItemForAlamatAyah.TextSize = New System.Drawing.Size(118, 13)
        '
        'NamaIbuTextEdit
        '
        Me.NamaIbuTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "NamaIbu", True))
        Me.NamaIbuTextEdit.Location = New System.Drawing.Point(134, 303)
        Me.NamaIbuTextEdit.Name = "NamaIbuTextEdit"
        Me.NamaIbuTextEdit.Size = New System.Drawing.Size(343, 20)
        Me.NamaIbuTextEdit.StyleController = Me.DataLayoutControl1
        Me.NamaIbuTextEdit.TabIndex = 16
        '
        'ItemForNamaIbu
        '
        Me.ItemForNamaIbu.Control = Me.NamaIbuTextEdit
        Me.ItemForNamaIbu.Location = New System.Drawing.Point(0, 291)
        Me.ItemForNamaIbu.Name = "ItemForNamaIbu"
        Me.ItemForNamaIbu.Size = New System.Drawing.Size(469, 24)
        Me.ItemForNamaIbu.Text = "Nama Ibu"
        Me.ItemForNamaIbu.TextSize = New System.Drawing.Size(118, 13)
        '
        'pekerjaanIbuTextEdit
        '
        Me.pekerjaanIbuTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "pekerjaanIbu", True))
        Me.pekerjaanIbuTextEdit.Location = New System.Drawing.Point(134, 327)
        Me.pekerjaanIbuTextEdit.Name = "pekerjaanIbuTextEdit"
        Me.pekerjaanIbuTextEdit.Size = New System.Drawing.Size(343, 20)
        Me.pekerjaanIbuTextEdit.StyleController = Me.DataLayoutControl1
        Me.pekerjaanIbuTextEdit.TabIndex = 17
        '
        'ItemForpekerjaanIbu
        '
        Me.ItemForpekerjaanIbu.Control = Me.pekerjaanIbuTextEdit
        Me.ItemForpekerjaanIbu.Location = New System.Drawing.Point(0, 315)
        Me.ItemForpekerjaanIbu.Name = "ItemForpekerjaanIbu"
        Me.ItemForpekerjaanIbu.Size = New System.Drawing.Size(469, 24)
        Me.ItemForpekerjaanIbu.Text = "pekerjaan Ibu"
        Me.ItemForpekerjaanIbu.TextSize = New System.Drawing.Size(118, 13)
        '
        'alamatIbuMemoEdit
        '
        Me.alamatIbuMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "alamatIbu", True))
        Me.alamatIbuMemoEdit.Location = New System.Drawing.Point(134, 351)
        Me.alamatIbuMemoEdit.Name = "alamatIbuMemoEdit"
        Me.alamatIbuMemoEdit.Size = New System.Drawing.Size(343, 22)
        Me.alamatIbuMemoEdit.StyleController = Me.DataLayoutControl1
        Me.alamatIbuMemoEdit.TabIndex = 18
        '
        'ItemForalamatIbu
        '
        Me.ItemForalamatIbu.Control = Me.alamatIbuMemoEdit
        Me.ItemForalamatIbu.Location = New System.Drawing.Point(0, 339)
        Me.ItemForalamatIbu.Name = "ItemForalamatIbu"
        Me.ItemForalamatIbu.Size = New System.Drawing.Size(469, 26)
        Me.ItemForalamatIbu.StartNewLine = True
        Me.ItemForalamatIbu.Text = "alamat Ibu"
        Me.ItemForalamatIbu.TextSize = New System.Drawing.Size(118, 13)
        '
        'penghasilanOrangTuaTextEdit
        '
        Me.penghasilanOrangTuaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "penghasilanOrangTua", True))
        Me.penghasilanOrangTuaTextEdit.Location = New System.Drawing.Point(134, 377)
        Me.penghasilanOrangTuaTextEdit.Name = "penghasilanOrangTuaTextEdit"
        Me.penghasilanOrangTuaTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.penghasilanOrangTuaTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.penghasilanOrangTuaTextEdit.Properties.Mask.EditMask = "N0"
        Me.penghasilanOrangTuaTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.penghasilanOrangTuaTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.penghasilanOrangTuaTextEdit.Size = New System.Drawing.Size(343, 20)
        Me.penghasilanOrangTuaTextEdit.StyleController = Me.DataLayoutControl1
        Me.penghasilanOrangTuaTextEdit.TabIndex = 19
        '
        'ItemForpenghasilanOrangTua
        '
        Me.ItemForpenghasilanOrangTua.Control = Me.penghasilanOrangTuaTextEdit
        Me.ItemForpenghasilanOrangTua.Location = New System.Drawing.Point(0, 365)
        Me.ItemForpenghasilanOrangTua.Name = "ItemForpenghasilanOrangTua"
        Me.ItemForpenghasilanOrangTua.Size = New System.Drawing.Size(469, 24)
        Me.ItemForpenghasilanOrangTua.Text = "penghasilan Orang Tua"
        Me.ItemForpenghasilanOrangTua.TextSize = New System.Drawing.Size(118, 13)
        '
        'idJurusanLookUpEdit
        '
        Me.idJurusanLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "idJurusan", True))
        Me.idJurusanLookUpEdit.Location = New System.Drawing.Point(134, 401)
        Me.idJurusanLookUpEdit.Name = "idJurusanLookUpEdit"
        Me.idJurusanLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idJurusanLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idJurusanLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idJurusanLookUpEdit.Properties.NullText = ""
        Me.idJurusanLookUpEdit.Size = New System.Drawing.Size(343, 20)
        Me.idJurusanLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.idJurusanLookUpEdit.TabIndex = 20
        '
        'ItemForidJurusan
        '
        Me.ItemForidJurusan.Control = Me.idJurusanLookUpEdit
        Me.ItemForidJurusan.Location = New System.Drawing.Point(0, 389)
        Me.ItemForidJurusan.Name = "ItemForidJurusan"
        Me.ItemForidJurusan.Size = New System.Drawing.Size(469, 24)
        Me.ItemForidJurusan.Text = "id Jurusan"
        Me.ItemForidJurusan.TextSize = New System.Drawing.Size(118, 13)
        '
        'nomorIjazahTextEdit
        '
        Me.nomorIjazahTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "nomorIjazah", True))
        Me.nomorIjazahTextEdit.Location = New System.Drawing.Point(134, 425)
        Me.nomorIjazahTextEdit.Name = "nomorIjazahTextEdit"
        Me.nomorIjazahTextEdit.Size = New System.Drawing.Size(343, 20)
        Me.nomorIjazahTextEdit.StyleController = Me.DataLayoutControl1
        Me.nomorIjazahTextEdit.TabIndex = 21
        '
        'ItemFornomorIjazah
        '
        Me.ItemFornomorIjazah.Control = Me.nomorIjazahTextEdit
        Me.ItemFornomorIjazah.Location = New System.Drawing.Point(0, 413)
        Me.ItemFornomorIjazah.Name = "ItemFornomorIjazah"
        Me.ItemFornomorIjazah.Size = New System.Drawing.Size(469, 24)
        Me.ItemFornomorIjazah.Text = "nomor Ijazah"
        Me.ItemFornomorIjazah.TextSize = New System.Drawing.Size(118, 13)
        '
        'nilaiRataRataKelulusanSpinEdit
        '
        Me.nilaiRataRataKelulusanSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "nilaiRataRataKelulusan", True))
        Me.nilaiRataRataKelulusanSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nilaiRataRataKelulusanSpinEdit.Location = New System.Drawing.Point(134, 449)
        Me.nilaiRataRataKelulusanSpinEdit.Name = "nilaiRataRataKelulusanSpinEdit"
        Me.nilaiRataRataKelulusanSpinEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.nilaiRataRataKelulusanSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.nilaiRataRataKelulusanSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.nilaiRataRataKelulusanSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.nilaiRataRataKelulusanSpinEdit.Properties.Mask.EditMask = "N0"
        Me.nilaiRataRataKelulusanSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.nilaiRataRataKelulusanSpinEdit.Size = New System.Drawing.Size(343, 20)
        Me.nilaiRataRataKelulusanSpinEdit.StyleController = Me.DataLayoutControl1
        Me.nilaiRataRataKelulusanSpinEdit.TabIndex = 22
        '
        'ItemFornilaiRataRataKelulusan
        '
        Me.ItemFornilaiRataRataKelulusan.Control = Me.nilaiRataRataKelulusanSpinEdit
        Me.ItemFornilaiRataRataKelulusan.Location = New System.Drawing.Point(0, 437)
        Me.ItemFornilaiRataRataKelulusan.Name = "ItemFornilaiRataRataKelulusan"
        Me.ItemFornilaiRataRataKelulusan.Size = New System.Drawing.Size(469, 24)
        Me.ItemFornilaiRataRataKelulusan.Text = "nilai Rata Rata Kelulusan"
        Me.ItemFornilaiRataRataKelulusan.TextSize = New System.Drawing.Size(118, 13)
        '
        'photoIjazahPictureEdit
        '
        Me.photoIjazahPictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "photoIjazah", True))
        Me.photoIjazahPictureEdit.Location = New System.Drawing.Point(134, 473)
        Me.photoIjazahPictureEdit.Name = "photoIjazahPictureEdit"
        Me.photoIjazahPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.photoIjazahPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.photoIjazahPictureEdit.Properties.ZoomAccelerationFactor = 1.0R
        Me.photoIjazahPictureEdit.Size = New System.Drawing.Size(343, 23)
        Me.photoIjazahPictureEdit.StyleController = Me.DataLayoutControl1
        Me.photoIjazahPictureEdit.TabIndex = 23
        '
        'ItemForphotoIjazah
        '
        Me.ItemForphotoIjazah.Control = Me.photoIjazahPictureEdit
        Me.ItemForphotoIjazah.Location = New System.Drawing.Point(0, 461)
        Me.ItemForphotoIjazah.Name = "ItemForphotoIjazah"
        Me.ItemForphotoIjazah.Size = New System.Drawing.Size(469, 27)
        Me.ItemForphotoIjazah.StartNewLine = True
        Me.ItemForphotoIjazah.Text = "photo Ijazah"
        Me.ItemForphotoIjazah.TextSize = New System.Drawing.Size(118, 13)
        '
        'photoPelamarPictureEdit
        '
        Me.photoPelamarPictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "photoPelamar", True))
        Me.photoPelamarPictureEdit.Location = New System.Drawing.Point(134, 500)
        Me.photoPelamarPictureEdit.Name = "photoPelamarPictureEdit"
        Me.photoPelamarPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.photoPelamarPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.photoPelamarPictureEdit.Properties.ZoomAccelerationFactor = 1.0R
        Me.photoPelamarPictureEdit.Size = New System.Drawing.Size(343, 23)
        Me.photoPelamarPictureEdit.StyleController = Me.DataLayoutControl1
        Me.photoPelamarPictureEdit.TabIndex = 24
        '
        'ItemForphotoPelamar
        '
        Me.ItemForphotoPelamar.Control = Me.photoPelamarPictureEdit
        Me.ItemForphotoPelamar.Location = New System.Drawing.Point(0, 488)
        Me.ItemForphotoPelamar.Name = "ItemForphotoPelamar"
        Me.ItemForphotoPelamar.Size = New System.Drawing.Size(469, 27)
        Me.ItemForphotoPelamar.StartNewLine = True
        Me.ItemForphotoPelamar.Text = "photo Pelamar"
        Me.ItemForphotoPelamar.TextSize = New System.Drawing.Size(118, 13)
        '
        'PhotoKartuKeluargaPictureEdit
        '
        Me.PhotoKartuKeluargaPictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "PhotoKartuKeluarga", True))
        Me.PhotoKartuKeluargaPictureEdit.Location = New System.Drawing.Point(134, 527)
        Me.PhotoKartuKeluargaPictureEdit.Name = "PhotoKartuKeluargaPictureEdit"
        Me.PhotoKartuKeluargaPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PhotoKartuKeluargaPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PhotoKartuKeluargaPictureEdit.Properties.ZoomAccelerationFactor = 1.0R
        Me.PhotoKartuKeluargaPictureEdit.Size = New System.Drawing.Size(343, 30)
        Me.PhotoKartuKeluargaPictureEdit.StyleController = Me.DataLayoutControl1
        Me.PhotoKartuKeluargaPictureEdit.TabIndex = 25
        '
        'ItemForPhotoKartuKeluarga
        '
        Me.ItemForPhotoKartuKeluarga.Control = Me.PhotoKartuKeluargaPictureEdit
        Me.ItemForPhotoKartuKeluarga.Location = New System.Drawing.Point(0, 515)
        Me.ItemForPhotoKartuKeluarga.Name = "ItemForPhotoKartuKeluarga"
        Me.ItemForPhotoKartuKeluarga.Size = New System.Drawing.Size(469, 34)
        Me.ItemForPhotoKartuKeluarga.StartNewLine = True
        Me.ItemForPhotoKartuKeluarga.Text = "Photo Kartu Keluarga"
        Me.ItemForPhotoKartuKeluarga.TextSize = New System.Drawing.Size(118, 13)
        '
        'idUserTextEdit
        '
        Me.idUserTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "idUser", True))
        Me.idUserTextEdit.Location = New System.Drawing.Point(134, 561)
        Me.idUserTextEdit.Name = "idUserTextEdit"
        Me.idUserTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idUserTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idUserTextEdit.Properties.Mask.EditMask = "N0"
        Me.idUserTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.idUserTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.idUserTextEdit.Size = New System.Drawing.Size(343, 20)
        Me.idUserTextEdit.StyleController = Me.DataLayoutControl1
        Me.idUserTextEdit.TabIndex = 26
        '
        'ItemForidUser
        '
        Me.ItemForidUser.Control = Me.idUserTextEdit
        Me.ItemForidUser.Location = New System.Drawing.Point(0, 549)
        Me.ItemForidUser.Name = "ItemForidUser"
        Me.ItemForidUser.Size = New System.Drawing.Size(469, 24)
        Me.ItemForidUser.Text = "id User"
        Me.ItemForidUser.TextSize = New System.Drawing.Size(118, 13)
        '
        'statusLookUpEdit
        '
        Me.statusLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "status", True))
        Me.statusLookUpEdit.Location = New System.Drawing.Point(134, 585)
        Me.statusLookUpEdit.Name = "statusLookUpEdit"
        Me.statusLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.statusLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.statusLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.statusLookUpEdit.Properties.NullText = ""
        Me.statusLookUpEdit.Size = New System.Drawing.Size(343, 20)
        Me.statusLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.statusLookUpEdit.TabIndex = 27
        '
        'ItemForstatus
        '
        Me.ItemForstatus.Control = Me.statusLookUpEdit
        Me.ItemForstatus.Location = New System.Drawing.Point(0, 573)
        Me.ItemForstatus.Name = "ItemForstatus"
        Me.ItemForstatus.Size = New System.Drawing.Size(469, 24)
        Me.ItemForstatus.Text = "status"
        Me.ItemForstatus.TextSize = New System.Drawing.Size(118, 13)
        '
        'FormPendaftaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1216, 764)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.MstPendaftarGridControl)
        Me.Controls.Add(Me.MstPendaftarBindingNavigator)
        Me.Name = "FormPendaftaran"
        Me.Text = "FormPendaftaran"
        CType(Me.DataSetPendaftaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstPendaftarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstPendaftarBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MstPendaftarBindingNavigator.ResumeLayout(False)
        Me.MstPendaftarBindingNavigator.PerformLayout()
        CType(Me.MstPendaftarGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NomorPendaftaranTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNomorPendaftaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.namaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFornama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tanggalLahirDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tanggalLahirDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFortanggalLahir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beratBadanTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForberatBadan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tinggiBadanTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFortinggiBadan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.genderRadioGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForgender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sekolahAsalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForsekolahAsal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kecSekolahAsalLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForkecSekolahAsal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alamatSekolahAsalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForalamatSekolahAsal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.namaAyahTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFornamaAyah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pekerjaanTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForpekerjaan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlamatAyahMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAlamatAyah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamaIbuTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNamaIbu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pekerjaanIbuTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForpekerjaanIbu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alamatIbuMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForalamatIbu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.penghasilanOrangTuaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForpenghasilanOrangTua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idJurusanLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidJurusan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nomorIjazahTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFornomorIjazah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nilaiRataRataKelulusanSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFornilaiRataRataKelulusan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.photoIjazahPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForphotoIjazah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.photoPelamarPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForphotoPelamar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhotoKartuKeluargaPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPhotoKartuKeluarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idUserTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.statusLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForstatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetPendaftaran As DataSetPendaftaran
    Friend WithEvents MstPendaftarBindingSource As BindingSource
    Friend WithEvents MstPendaftarTableAdapter As DataSetPendaftaranTableAdapters.mstPendaftarTableAdapter
    Friend WithEvents TableAdapterManager As DataSetPendaftaranTableAdapters.TableAdapterManager
    Friend WithEvents MstPendaftarBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents MstPendaftarBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MstPendaftarGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colNomorPendaftaran As XtraGrid.Columns.GridColumn
    Friend WithEvents colnama As XtraGrid.Columns.GridColumn
    Friend WithEvents coltanggalLahir As XtraGrid.Columns.GridColumn
    Friend WithEvents colberatBadan As XtraGrid.Columns.GridColumn
    Friend WithEvents coltinggiBadan As XtraGrid.Columns.GridColumn
    Friend WithEvents colgender As XtraGrid.Columns.GridColumn
    Friend WithEvents colsekolahAsal As XtraGrid.Columns.GridColumn
    Friend WithEvents colkecSekolahAsal As XtraGrid.Columns.GridColumn
    Friend WithEvents colalamatSekolahAsal As XtraGrid.Columns.GridColumn
    Friend WithEvents colnamaAyah As XtraGrid.Columns.GridColumn
    Friend WithEvents colpekerjaan As XtraGrid.Columns.GridColumn
    Friend WithEvents colAlamatAyah As XtraGrid.Columns.GridColumn
    Friend WithEvents colNamaIbu As XtraGrid.Columns.GridColumn
    Friend WithEvents colpekerjaanIbu As XtraGrid.Columns.GridColumn
    Friend WithEvents colalamatIbu As XtraGrid.Columns.GridColumn
    Friend WithEvents colpenghasilanOrangTua As XtraGrid.Columns.GridColumn
    Friend WithEvents colidJurusan As XtraGrid.Columns.GridColumn
    Friend WithEvents colnomorIjazah As XtraGrid.Columns.GridColumn
    Friend WithEvents colnilaiRataRataKelulusan As XtraGrid.Columns.GridColumn
    Friend WithEvents colphotoIjazah As XtraGrid.Columns.GridColumn
    Friend WithEvents colphotoPelamar As XtraGrid.Columns.GridColumn
    Friend WithEvents colPhotoKartuKeluarga As XtraGrid.Columns.GridColumn
    Friend WithEvents colidUser As XtraGrid.Columns.GridColumn
    Friend WithEvents colstatus As XtraGrid.Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As XtraDataLayout.DataLayoutControl
    Friend WithEvents NomorPendaftaranTextEdit As TextEdit
    Friend WithEvents namaTextEdit As TextEdit
    Friend WithEvents tanggalLahirDateEdit As DateEdit
    Friend WithEvents beratBadanTextEdit As TextEdit
    Friend WithEvents tinggiBadanTextEdit As TextEdit
    Friend WithEvents genderRadioGroup As RadioGroup
    Friend WithEvents sekolahAsalTextEdit As TextEdit
    Friend WithEvents kecSekolahAsalLookUpEdit As LookUpEdit
    Friend WithEvents alamatSekolahAsalTextEdit As TextEdit
    Friend WithEvents namaAyahTextEdit As TextEdit
    Friend WithEvents pekerjaanTextEdit As TextEdit
    Friend WithEvents AlamatAyahMemoEdit As MemoEdit
    Friend WithEvents NamaIbuTextEdit As TextEdit
    Friend WithEvents pekerjaanIbuTextEdit As TextEdit
    Friend WithEvents alamatIbuMemoEdit As MemoEdit
    Friend WithEvents penghasilanOrangTuaTextEdit As TextEdit
    Friend WithEvents idJurusanLookUpEdit As LookUpEdit
    Friend WithEvents nomorIjazahTextEdit As TextEdit
    Friend WithEvents nilaiRataRataKelulusanSpinEdit As SpinEdit
    Friend WithEvents photoIjazahPictureEdit As PictureEdit
    Friend WithEvents photoPelamarPictureEdit As PictureEdit
    Friend WithEvents PhotoKartuKeluargaPictureEdit As PictureEdit
    Friend WithEvents idUserTextEdit As TextEdit
    Friend WithEvents statusLookUpEdit As LookUpEdit
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForNomorPendaftaran As XtraLayout.LayoutControlItem
    Friend WithEvents ItemFornama As XtraLayout.LayoutControlItem
    Friend WithEvents ItemFortanggalLahir As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForberatBadan As XtraLayout.LayoutControlItem
    Friend WithEvents ItemFortinggiBadan As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForgender As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForsekolahAsal As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForkecSekolahAsal As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForalamatSekolahAsal As XtraLayout.LayoutControlItem
    Friend WithEvents ItemFornamaAyah As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForpekerjaan As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForAlamatAyah As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNamaIbu As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForpekerjaanIbu As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForalamatIbu As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForpenghasilanOrangTua As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForidJurusan As XtraLayout.LayoutControlItem
    Friend WithEvents ItemFornomorIjazah As XtraLayout.LayoutControlItem
    Friend WithEvents ItemFornilaiRataRataKelulusan As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForphotoIjazah As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForphotoPelamar As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPhotoKartuKeluarga As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForidUser As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForstatus As XtraLayout.LayoutControlItem
End Class
