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
        Me.labelInfo = New System.Windows.Forms.ToolStripLabel()
        Me.buttonPrint = New System.Windows.Forms.ToolStripButton()
        Me.MstPendaftarGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidGelombang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNomorPendaftaran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltanggalPendaftaran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltanggalLahir = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colberatBadan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltinggiBadan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgender = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsekolahAsal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colalamatSekolahAsal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnamaAyah = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpekerjaan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlamatAyah = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNamaIbu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpekerjaanIbu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colalamatIbu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpenghasilanOrangTua = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidJurusan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MstJurusanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colnomorIjazah = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnilaiRataRataKelulusan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colphotoIjazah = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colphotoPelamar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhotoKartuKeluarga = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.buttonNilaiUN = New DevExpress.XtraEditors.SimpleButton()
        Me.buttonHobi = New DevExpress.XtraEditors.SimpleButton()
        Me.buttonPengalamanOrganisasi = New DevExpress.XtraEditors.SimpleButton()
        Me.buttonPendidikanNonFormal = New DevExpress.XtraEditors.SimpleButton()
        Me.buttonPrestasi = New DevExpress.XtraEditors.SimpleButton()
        Me.idGelombangTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NomorPendaftaranTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.tanggalPendaftaranDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.namaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.tanggalLahirDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.beratBadanTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.tinggiBadanTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.sekolahAsalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.namaAyahTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.pekerjaanTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AlamatAyahTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NamaIbuTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.pekerjaanIbuTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.alamatIbuTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.penghasilanOrangTuaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.idJurusanLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.AvailableJurusanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.nomorIjazahTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.nilaiRataRataKelulusanTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.photoIjazahPictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.photoPelamarPictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.PhotoKartuKeluargaPictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.idUserTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.statusLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.genderTextEdit = New DevExpress.XtraEditors.RadioGroup()
        Me.alamatSekolahAsalTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.ItemForidGelombang = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNomorPendaftaran = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemFortanggalPendaftaran = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForstatus = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForidUser = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemFornama = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemFortanggalLahir = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForberatBadan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemFortinggiBadan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForgender = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForsekolahAsal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForalamatSekolahAsal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemFornamaAyah = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForpekerjaan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForAlamatAyah = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNamaIbu = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForpekerjaanIbu = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForalamatIbu = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForpenghasilanOrangTua = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForidJurusan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemFornomorIjazah = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemFornilaiRataRataKelulusan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForphotoIjazah = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForphotoPelamar = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPhotoKartuKeluarga = New DevExpress.XtraLayout.LayoutControlItem()
        Me.AvailableJurusanTableAdapter = New StudentEnrollment.DataSetPendaftaranTableAdapters.AvailableJurusanTableAdapter()
        Me.MstJurusanTableAdapter = New StudentEnrollment.DataSetPendaftaranTableAdapters.mstJurusanTableAdapter()
        CType(Me.DataSetPendaftaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstPendaftarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstPendaftarBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MstPendaftarBindingNavigator.SuspendLayout()
        CType(Me.MstPendaftarGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstJurusanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.idGelombangTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NomorPendaftaranTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tanggalPendaftaranDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tanggalPendaftaranDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.namaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tanggalLahirDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tanggalLahirDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beratBadanTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tinggiBadanTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sekolahAsalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.namaAyahTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pekerjaanTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlamatAyahTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamaIbuTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pekerjaanIbuTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alamatIbuTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.penghasilanOrangTuaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idJurusanLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvailableJurusanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nomorIjazahTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nilaiRataRataKelulusanTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.photoIjazahPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.photoPelamarPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhotoKartuKeluargaPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idUserTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.statusLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.genderTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alamatSekolahAsalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidGelombang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNomorPendaftaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFortanggalPendaftaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFornama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFortanggalLahir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForberatBadan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFortinggiBadan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForgender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForsekolahAsal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForalamatSekolahAsal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFornamaAyah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForpekerjaan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAlamatAyah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNamaIbu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForpekerjaanIbu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForalamatIbu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForpenghasilanOrangTua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidJurusan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFornomorIjazah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFornilaiRataRataKelulusan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForphotoIjazah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForphotoPelamar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPhotoKartuKeluarga, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MstPendaftarBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MstPendaftarBindingNavigatorSaveItem, Me.labelInfo, Me.buttonPrint})
        Me.MstPendaftarBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MstPendaftarBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MstPendaftarBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MstPendaftarBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MstPendaftarBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MstPendaftarBindingNavigator.Name = "MstPendaftarBindingNavigator"
        Me.MstPendaftarBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MstPendaftarBindingNavigator.Size = New System.Drawing.Size(1201, 25)
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
        'labelInfo
        '
        Me.labelInfo.Name = "labelInfo"
        Me.labelInfo.Size = New System.Drawing.Size(88, 22)
        Me.labelInfo.Text = "ToolStripLabel1"
        '
        'buttonPrint
        '
        Me.buttonPrint.Image = CType(resources.GetObject("buttonPrint.Image"), System.Drawing.Image)
        Me.buttonPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonPrint.Name = "buttonPrint"
        Me.buttonPrint.Size = New System.Drawing.Size(52, 22)
        Me.buttonPrint.Text = "Print"
        '
        'MstPendaftarGridControl
        '
        Me.MstPendaftarGridControl.DataSource = Me.MstPendaftarBindingSource
        Me.MstPendaftarGridControl.Location = New System.Drawing.Point(12, 459)
        Me.MstPendaftarGridControl.MainView = Me.GridView1
        Me.MstPendaftarGridControl.Name = "MstPendaftarGridControl"
        Me.MstPendaftarGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.MstPendaftarGridControl.Size = New System.Drawing.Size(1177, 282)
        Me.MstPendaftarGridControl.TabIndex = 1
        Me.MstPendaftarGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.OddRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView1.AppearancePrint.OddRow.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colidGelombang, Me.colNomorPendaftaran, Me.coltanggalPendaftaran, Me.colnama, Me.coltanggalLahir, Me.colberatBadan, Me.coltinggiBadan, Me.colgender, Me.colsekolahAsal, Me.colalamatSekolahAsal, Me.colnamaAyah, Me.colpekerjaan, Me.colAlamatAyah, Me.colNamaIbu, Me.colpekerjaanIbu, Me.colalamatIbu, Me.colpenghasilanOrangTua, Me.colidJurusan, Me.colnomorIjazah, Me.colnilaiRataRataKelulusan, Me.colphotoIjazah, Me.colphotoPelamar, Me.colPhotoKartuKeluarga, Me.colidUser, Me.colstatus})
        Me.GridView1.GridControl = Me.MstPendaftarGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsPrint.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colidGelombang
        '
        Me.colidGelombang.FieldName = "idGelombang"
        Me.colidGelombang.Name = "colidGelombang"
        '
        'colNomorPendaftaran
        '
        Me.colNomorPendaftaran.Caption = "Kode Pendaftaran"
        Me.colNomorPendaftaran.FieldName = "NomorPendaftaran"
        Me.colNomorPendaftaran.Name = "colNomorPendaftaran"
        Me.colNomorPendaftaran.Visible = True
        Me.colNomorPendaftaran.VisibleIndex = 0
        '
        'coltanggalPendaftaran
        '
        Me.coltanggalPendaftaran.Caption = "Tanggal Daftar"
        Me.coltanggalPendaftaran.FieldName = "tanggalPendaftaran"
        Me.coltanggalPendaftaran.Name = "coltanggalPendaftaran"
        Me.coltanggalPendaftaran.Visible = True
        Me.coltanggalPendaftaran.VisibleIndex = 10
        '
        'colnama
        '
        Me.colnama.Caption = "Nama"
        Me.colnama.FieldName = "nama"
        Me.colnama.Name = "colnama"
        Me.colnama.Visible = True
        Me.colnama.VisibleIndex = 1
        '
        'coltanggalLahir
        '
        Me.coltanggalLahir.Caption = "DOB"
        Me.coltanggalLahir.FieldName = "tanggalLahir"
        Me.coltanggalLahir.Name = "coltanggalLahir"
        Me.coltanggalLahir.Visible = True
        Me.coltanggalLahir.VisibleIndex = 2
        '
        'colberatBadan
        '
        Me.colberatBadan.Caption = "Berat"
        Me.colberatBadan.FieldName = "beratBadan"
        Me.colberatBadan.Name = "colberatBadan"
        Me.colberatBadan.Visible = True
        Me.colberatBadan.VisibleIndex = 3
        '
        'coltinggiBadan
        '
        Me.coltinggiBadan.Caption = "Tinggi"
        Me.coltinggiBadan.FieldName = "tinggiBadan"
        Me.coltinggiBadan.Name = "coltinggiBadan"
        Me.coltinggiBadan.Visible = True
        Me.coltinggiBadan.VisibleIndex = 4
        '
        'colgender
        '
        Me.colgender.FieldName = "gender"
        Me.colgender.Name = "colgender"
        '
        'colsekolahAsal
        '
        Me.colsekolahAsal.Caption = "Almamater"
        Me.colsekolahAsal.FieldName = "sekolahAsal"
        Me.colsekolahAsal.Name = "colsekolahAsal"
        Me.colsekolahAsal.Visible = True
        Me.colsekolahAsal.VisibleIndex = 5
        '
        'colalamatSekolahAsal
        '
        Me.colalamatSekolahAsal.FieldName = "alamatSekolahAsal"
        Me.colalamatSekolahAsal.Name = "colalamatSekolahAsal"
        '
        'colnamaAyah
        '
        Me.colnamaAyah.Caption = "Ayah"
        Me.colnamaAyah.FieldName = "namaAyah"
        Me.colnamaAyah.Name = "colnamaAyah"
        Me.colnamaAyah.Visible = True
        Me.colnamaAyah.VisibleIndex = 6
        '
        'colpekerjaan
        '
        Me.colpekerjaan.FieldName = "pekerjaan"
        Me.colpekerjaan.Name = "colpekerjaan"
        '
        'colAlamatAyah
        '
        Me.colAlamatAyah.FieldName = "AlamatAyah"
        Me.colAlamatAyah.Name = "colAlamatAyah"
        '
        'colNamaIbu
        '
        Me.colNamaIbu.Caption = "Ibu"
        Me.colNamaIbu.FieldName = "NamaIbu"
        Me.colNamaIbu.Name = "colNamaIbu"
        Me.colNamaIbu.Visible = True
        Me.colNamaIbu.VisibleIndex = 7
        '
        'colpekerjaanIbu
        '
        Me.colpekerjaanIbu.FieldName = "pekerjaanIbu"
        Me.colpekerjaanIbu.Name = "colpekerjaanIbu"
        '
        'colalamatIbu
        '
        Me.colalamatIbu.FieldName = "alamatIbu"
        Me.colalamatIbu.Name = "colalamatIbu"
        '
        'colpenghasilanOrangTua
        '
        Me.colpenghasilanOrangTua.Caption = "Penghasilan"
        Me.colpenghasilanOrangTua.FieldName = "penghasilanOrangTua"
        Me.colpenghasilanOrangTua.Name = "colpenghasilanOrangTua"
        Me.colpenghasilanOrangTua.Visible = True
        Me.colpenghasilanOrangTua.VisibleIndex = 8
        '
        'colidJurusan
        '
        Me.colidJurusan.Caption = "Jurusan"
        Me.colidJurusan.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colidJurusan.FieldName = "idJurusan"
        Me.colidJurusan.Name = "colidJurusan"
        Me.colidJurusan.Visible = True
        Me.colidJurusan.VisibleIndex = 9
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.MstJurusanBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Jurusan"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "id"
        '
        'MstJurusanBindingSource
        '
        Me.MstJurusanBindingSource.DataMember = "mstJurusan"
        Me.MstJurusanBindingSource.DataSource = Me.DataSetPendaftaran
        '
        'colnomorIjazah
        '
        Me.colnomorIjazah.FieldName = "nomorIjazah"
        Me.colnomorIjazah.Name = "colnomorIjazah"
        '
        'colnilaiRataRataKelulusan
        '
        Me.colnilaiRataRataKelulusan.FieldName = "nilaiRataRataKelulusan"
        Me.colnilaiRataRataKelulusan.Name = "colnilaiRataRataKelulusan"
        '
        'colphotoIjazah
        '
        Me.colphotoIjazah.FieldName = "photoIjazah"
        Me.colphotoIjazah.Name = "colphotoIjazah"
        '
        'colphotoPelamar
        '
        Me.colphotoPelamar.FieldName = "photoPelamar"
        Me.colphotoPelamar.Name = "colphotoPelamar"
        '
        'colPhotoKartuKeluarga
        '
        Me.colPhotoKartuKeluarga.FieldName = "PhotoKartuKeluarga"
        Me.colPhotoKartuKeluarga.Name = "colPhotoKartuKeluarga"
        '
        'colidUser
        '
        Me.colidUser.FieldName = "idUser"
        Me.colidUser.Name = "colidUser"
        '
        'colstatus
        '
        Me.colstatus.FieldName = "status"
        Me.colstatus.Name = "colstatus"
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.buttonNilaiUN)
        Me.DataLayoutControl1.Controls.Add(Me.buttonHobi)
        Me.DataLayoutControl1.Controls.Add(Me.buttonPengalamanOrganisasi)
        Me.DataLayoutControl1.Controls.Add(Me.buttonPendidikanNonFormal)
        Me.DataLayoutControl1.Controls.Add(Me.buttonPrestasi)
        Me.DataLayoutControl1.Controls.Add(Me.MstPendaftarGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.idGelombangTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NomorPendaftaranTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.tanggalPendaftaranDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.namaTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.tanggalLahirDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.beratBadanTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.tinggiBadanTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.sekolahAsalTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.namaAyahTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.pekerjaanTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.AlamatAyahTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NamaIbuTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.pekerjaanIbuTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.alamatIbuTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.penghasilanOrangTuaTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.idJurusanLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.nomorIjazahTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.nilaiRataRataKelulusanTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.photoIjazahPictureEdit)
        Me.DataLayoutControl1.Controls.Add(Me.photoPelamarPictureEdit)
        Me.DataLayoutControl1.Controls.Add(Me.PhotoKartuKeluargaPictureEdit)
        Me.DataLayoutControl1.Controls.Add(Me.idUserTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.statusLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.genderTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.alamatSekolahAsalTextEdit)
        Me.DataLayoutControl1.DataSource = Me.MstPendaftarBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForidGelombang, Me.ItemForNomorPendaftaran, Me.ItemFortanggalPendaftaran, Me.ItemForstatus, Me.ItemForidUser})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1565, 125, 250, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(1201, 753)
        Me.DataLayoutControl1.TabIndex = 2
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'buttonNilaiUN
        '
        Me.buttonNilaiUN.Location = New System.Drawing.Point(886, 124)
        Me.buttonNilaiUN.Name = "buttonNilaiUN"
        Me.buttonNilaiUN.Size = New System.Drawing.Size(291, 22)
        Me.buttonNilaiUN.StyleController = Me.DataLayoutControl1
        Me.buttonNilaiUN.TabIndex = 34
        Me.buttonNilaiUN.Text = "Nilai UN"
        '
        'buttonHobi
        '
        Me.buttonHobi.Location = New System.Drawing.Point(886, 228)
        Me.buttonHobi.Name = "buttonHobi"
        Me.buttonHobi.Size = New System.Drawing.Size(291, 22)
        Me.buttonHobi.StyleController = Me.DataLayoutControl1
        Me.buttonHobi.TabIndex = 33
        Me.buttonHobi.Text = "Hobbi"
        '
        'buttonPengalamanOrganisasi
        '
        Me.buttonPengalamanOrganisasi.Location = New System.Drawing.Point(886, 202)
        Me.buttonPengalamanOrganisasi.Name = "buttonPengalamanOrganisasi"
        Me.buttonPengalamanOrganisasi.Size = New System.Drawing.Size(291, 22)
        Me.buttonPengalamanOrganisasi.StyleController = Me.DataLayoutControl1
        Me.buttonPengalamanOrganisasi.TabIndex = 32
        Me.buttonPengalamanOrganisasi.Text = "PengalamanOrganisasi"
        '
        'buttonPendidikanNonFormal
        '
        Me.buttonPendidikanNonFormal.Location = New System.Drawing.Point(886, 176)
        Me.buttonPendidikanNonFormal.Name = "buttonPendidikanNonFormal"
        Me.buttonPendidikanNonFormal.Size = New System.Drawing.Size(291, 22)
        Me.buttonPendidikanNonFormal.StyleController = Me.DataLayoutControl1
        Me.buttonPendidikanNonFormal.TabIndex = 31
        Me.buttonPendidikanNonFormal.Text = "Pendidikan Non Formal"
        '
        'buttonPrestasi
        '
        Me.buttonPrestasi.Location = New System.Drawing.Point(886, 150)
        Me.buttonPrestasi.Name = "buttonPrestasi"
        Me.buttonPrestasi.Size = New System.Drawing.Size(291, 22)
        Me.buttonPrestasi.StyleController = Me.DataLayoutControl1
        Me.buttonPrestasi.TabIndex = 30
        Me.buttonPrestasi.Text = "Prestasi"
        '
        'idGelombangTextEdit
        '
        Me.idGelombangTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "idGelombang", True))
        Me.idGelombangTextEdit.Location = New System.Drawing.Point(133, 12)
        Me.idGelombangTextEdit.Name = "idGelombangTextEdit"
        Me.idGelombangTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idGelombangTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idGelombangTextEdit.Properties.Mask.EditMask = "N0"
        Me.idGelombangTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.idGelombangTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.idGelombangTextEdit.Size = New System.Drawing.Size(261, 20)
        Me.idGelombangTextEdit.StyleController = Me.DataLayoutControl1
        Me.idGelombangTextEdit.TabIndex = 4
        '
        'NomorPendaftaranTextEdit
        '
        Me.NomorPendaftaranTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "NomorPendaftaran", True))
        Me.NomorPendaftaranTextEdit.Location = New System.Drawing.Point(133, 12)
        Me.NomorPendaftaranTextEdit.Name = "NomorPendaftaranTextEdit"
        Me.NomorPendaftaranTextEdit.Size = New System.Drawing.Size(261, 20)
        Me.NomorPendaftaranTextEdit.StyleController = Me.DataLayoutControl1
        Me.NomorPendaftaranTextEdit.TabIndex = 5
        '
        'tanggalPendaftaranDateEdit
        '
        Me.tanggalPendaftaranDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "tanggalPendaftaran", True))
        Me.tanggalPendaftaranDateEdit.EditValue = Nothing
        Me.tanggalPendaftaranDateEdit.Location = New System.Drawing.Point(133, 12)
        Me.tanggalPendaftaranDateEdit.Name = "tanggalPendaftaranDateEdit"
        Me.tanggalPendaftaranDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tanggalPendaftaranDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tanggalPendaftaranDateEdit.Size = New System.Drawing.Size(261, 20)
        Me.tanggalPendaftaranDateEdit.StyleController = Me.DataLayoutControl1
        Me.tanggalPendaftaranDateEdit.TabIndex = 6
        '
        'namaTextEdit
        '
        Me.namaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "nama", True))
        Me.namaTextEdit.Location = New System.Drawing.Point(145, 42)
        Me.namaTextEdit.Name = "namaTextEdit"
        Me.namaTextEdit.Size = New System.Drawing.Size(313, 20)
        Me.namaTextEdit.StyleController = Me.DataLayoutControl1
        Me.namaTextEdit.TabIndex = 7
        '
        'tanggalLahirDateEdit
        '
        Me.tanggalLahirDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "tanggalLahir", True))
        Me.tanggalLahirDateEdit.EditValue = Nothing
        Me.tanggalLahirDateEdit.Location = New System.Drawing.Point(145, 66)
        Me.tanggalLahirDateEdit.Name = "tanggalLahirDateEdit"
        Me.tanggalLahirDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tanggalLahirDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tanggalLahirDateEdit.Size = New System.Drawing.Size(313, 20)
        Me.tanggalLahirDateEdit.StyleController = Me.DataLayoutControl1
        Me.tanggalLahirDateEdit.TabIndex = 8
        '
        'beratBadanTextEdit
        '
        Me.beratBadanTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "beratBadan", True))
        Me.beratBadanTextEdit.Location = New System.Drawing.Point(145, 90)
        Me.beratBadanTextEdit.Name = "beratBadanTextEdit"
        Me.beratBadanTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.beratBadanTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.beratBadanTextEdit.Properties.Mask.EditMask = "N0"
        Me.beratBadanTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.beratBadanTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.beratBadanTextEdit.Size = New System.Drawing.Size(313, 20)
        Me.beratBadanTextEdit.StyleController = Me.DataLayoutControl1
        Me.beratBadanTextEdit.TabIndex = 9
        '
        'tinggiBadanTextEdit
        '
        Me.tinggiBadanTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "tinggiBadan", True))
        Me.tinggiBadanTextEdit.Location = New System.Drawing.Point(145, 114)
        Me.tinggiBadanTextEdit.Name = "tinggiBadanTextEdit"
        Me.tinggiBadanTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.tinggiBadanTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.tinggiBadanTextEdit.Properties.Mask.EditMask = "N0"
        Me.tinggiBadanTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tinggiBadanTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tinggiBadanTextEdit.Size = New System.Drawing.Size(313, 20)
        Me.tinggiBadanTextEdit.StyleController = Me.DataLayoutControl1
        Me.tinggiBadanTextEdit.TabIndex = 10
        '
        'sekolahAsalTextEdit
        '
        Me.sekolahAsalTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "sekolahAsal", True))
        Me.sekolahAsalTextEdit.Location = New System.Drawing.Point(145, 168)
        Me.sekolahAsalTextEdit.Name = "sekolahAsalTextEdit"
        Me.sekolahAsalTextEdit.Size = New System.Drawing.Size(313, 20)
        Me.sekolahAsalTextEdit.StyleController = Me.DataLayoutControl1
        Me.sekolahAsalTextEdit.TabIndex = 12
        '
        'namaAyahTextEdit
        '
        Me.namaAyahTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "namaAyah", True))
        Me.namaAyahTextEdit.Location = New System.Drawing.Point(607, 42)
        Me.namaAyahTextEdit.Name = "namaAyahTextEdit"
        Me.namaAyahTextEdit.Size = New System.Drawing.Size(241, 20)
        Me.namaAyahTextEdit.StyleController = Me.DataLayoutControl1
        Me.namaAyahTextEdit.TabIndex = 14
        '
        'pekerjaanTextEdit
        '
        Me.pekerjaanTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "pekerjaan", True))
        Me.pekerjaanTextEdit.Location = New System.Drawing.Point(607, 66)
        Me.pekerjaanTextEdit.Name = "pekerjaanTextEdit"
        Me.pekerjaanTextEdit.Size = New System.Drawing.Size(241, 20)
        Me.pekerjaanTextEdit.StyleController = Me.DataLayoutControl1
        Me.pekerjaanTextEdit.TabIndex = 15
        '
        'AlamatAyahTextEdit
        '
        Me.AlamatAyahTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "AlamatAyah", True))
        Me.AlamatAyahTextEdit.Location = New System.Drawing.Point(607, 90)
        Me.AlamatAyahTextEdit.Name = "AlamatAyahTextEdit"
        Me.AlamatAyahTextEdit.Size = New System.Drawing.Size(241, 20)
        Me.AlamatAyahTextEdit.StyleController = Me.DataLayoutControl1
        Me.AlamatAyahTextEdit.TabIndex = 16
        '
        'NamaIbuTextEdit
        '
        Me.NamaIbuTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "NamaIbu", True))
        Me.NamaIbuTextEdit.Location = New System.Drawing.Point(607, 114)
        Me.NamaIbuTextEdit.Name = "NamaIbuTextEdit"
        Me.NamaIbuTextEdit.Size = New System.Drawing.Size(241, 20)
        Me.NamaIbuTextEdit.StyleController = Me.DataLayoutControl1
        Me.NamaIbuTextEdit.TabIndex = 17
        '
        'pekerjaanIbuTextEdit
        '
        Me.pekerjaanIbuTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "pekerjaanIbu", True))
        Me.pekerjaanIbuTextEdit.Location = New System.Drawing.Point(607, 138)
        Me.pekerjaanIbuTextEdit.Name = "pekerjaanIbuTextEdit"
        Me.pekerjaanIbuTextEdit.Size = New System.Drawing.Size(241, 20)
        Me.pekerjaanIbuTextEdit.StyleController = Me.DataLayoutControl1
        Me.pekerjaanIbuTextEdit.TabIndex = 18
        '
        'alamatIbuTextEdit
        '
        Me.alamatIbuTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "alamatIbu", True))
        Me.alamatIbuTextEdit.Location = New System.Drawing.Point(607, 162)
        Me.alamatIbuTextEdit.Name = "alamatIbuTextEdit"
        Me.alamatIbuTextEdit.Size = New System.Drawing.Size(241, 20)
        Me.alamatIbuTextEdit.StyleController = Me.DataLayoutControl1
        Me.alamatIbuTextEdit.TabIndex = 19
        '
        'penghasilanOrangTuaTextEdit
        '
        Me.penghasilanOrangTuaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "penghasilanOrangTua", True))
        Me.penghasilanOrangTuaTextEdit.Location = New System.Drawing.Point(607, 186)
        Me.penghasilanOrangTuaTextEdit.Name = "penghasilanOrangTuaTextEdit"
        Me.penghasilanOrangTuaTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.penghasilanOrangTuaTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.penghasilanOrangTuaTextEdit.Properties.Mask.EditMask = "N0"
        Me.penghasilanOrangTuaTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.penghasilanOrangTuaTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.penghasilanOrangTuaTextEdit.Size = New System.Drawing.Size(241, 20)
        Me.penghasilanOrangTuaTextEdit.StyleController = Me.DataLayoutControl1
        Me.penghasilanOrangTuaTextEdit.TabIndex = 20
        '
        'idJurusanLookUpEdit
        '
        Me.idJurusanLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "idJurusan", True))
        Me.idJurusanLookUpEdit.Location = New System.Drawing.Point(997, 42)
        Me.idJurusanLookUpEdit.Name = "idJurusanLookUpEdit"
        Me.idJurusanLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idJurusanLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idJurusanLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idJurusanLookUpEdit.Properties.DataSource = Me.AvailableJurusanBindingSource
        Me.idJurusanLookUpEdit.Properties.DisplayMember = "Jurusan"
        Me.idJurusanLookUpEdit.Properties.NullText = ""
        Me.idJurusanLookUpEdit.Properties.ValueMember = "id"
        Me.idJurusanLookUpEdit.Size = New System.Drawing.Size(180, 20)
        Me.idJurusanLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.idJurusanLookUpEdit.TabIndex = 21
        '
        'AvailableJurusanBindingSource
        '
        Me.AvailableJurusanBindingSource.DataMember = "AvailableJurusan"
        Me.AvailableJurusanBindingSource.DataSource = Me.DataSetPendaftaran
        '
        'nomorIjazahTextEdit
        '
        Me.nomorIjazahTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "nomorIjazah", True))
        Me.nomorIjazahTextEdit.Location = New System.Drawing.Point(997, 66)
        Me.nomorIjazahTextEdit.Name = "nomorIjazahTextEdit"
        Me.nomorIjazahTextEdit.Size = New System.Drawing.Size(180, 20)
        Me.nomorIjazahTextEdit.StyleController = Me.DataLayoutControl1
        Me.nomorIjazahTextEdit.TabIndex = 22
        '
        'nilaiRataRataKelulusanTextEdit
        '
        Me.nilaiRataRataKelulusanTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "nilaiRataRataKelulusan", True))
        Me.nilaiRataRataKelulusanTextEdit.Location = New System.Drawing.Point(997, 90)
        Me.nilaiRataRataKelulusanTextEdit.Name = "nilaiRataRataKelulusanTextEdit"
        Me.nilaiRataRataKelulusanTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.nilaiRataRataKelulusanTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.nilaiRataRataKelulusanTextEdit.Properties.Mask.EditMask = "N0"
        Me.nilaiRataRataKelulusanTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.nilaiRataRataKelulusanTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.nilaiRataRataKelulusanTextEdit.Size = New System.Drawing.Size(180, 20)
        Me.nilaiRataRataKelulusanTextEdit.StyleController = Me.DataLayoutControl1
        Me.nilaiRataRataKelulusanTextEdit.TabIndex = 23
        '
        'photoIjazahPictureEdit
        '
        Me.photoIjazahPictureEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.photoIjazahPictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "photoIjazah", True))
        Me.photoIjazahPictureEdit.Location = New System.Drawing.Point(146, 312)
        Me.photoIjazahPictureEdit.Name = "photoIjazahPictureEdit"
        Me.photoIjazahPictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.photoIjazahPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.photoIjazahPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.photoIjazahPictureEdit.Properties.ZoomAccelerationFactor = 1.0R
        Me.photoIjazahPictureEdit.Size = New System.Drawing.Size(512, 131)
        Me.photoIjazahPictureEdit.StyleController = Me.DataLayoutControl1
        Me.photoIjazahPictureEdit.TabIndex = 24
        '
        'photoPelamarPictureEdit
        '
        Me.photoPelamarPictureEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.photoPelamarPictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "photoPelamar", True))
        Me.photoPelamarPictureEdit.Location = New System.Drawing.Point(24, 312)
        Me.photoPelamarPictureEdit.Name = "photoPelamarPictureEdit"
        Me.photoPelamarPictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.photoPelamarPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.photoPelamarPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.photoPelamarPictureEdit.Properties.ZoomAccelerationFactor = 1.0R
        Me.photoPelamarPictureEdit.Size = New System.Drawing.Size(118, 131)
        Me.photoPelamarPictureEdit.StyleController = Me.DataLayoutControl1
        Me.photoPelamarPictureEdit.TabIndex = 25
        '
        'PhotoKartuKeluargaPictureEdit
        '
        Me.PhotoKartuKeluargaPictureEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.PhotoKartuKeluargaPictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "PhotoKartuKeluarga", True))
        Me.PhotoKartuKeluargaPictureEdit.Location = New System.Drawing.Point(662, 312)
        Me.PhotoKartuKeluargaPictureEdit.Name = "PhotoKartuKeluargaPictureEdit"
        Me.PhotoKartuKeluargaPictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.PhotoKartuKeluargaPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PhotoKartuKeluargaPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PhotoKartuKeluargaPictureEdit.Properties.ZoomAccelerationFactor = 1.0R
        Me.PhotoKartuKeluargaPictureEdit.Size = New System.Drawing.Size(515, 131)
        Me.PhotoKartuKeluargaPictureEdit.StyleController = Me.DataLayoutControl1
        Me.PhotoKartuKeluargaPictureEdit.TabIndex = 26
        '
        'idUserTextEdit
        '
        Me.idUserTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "idUser", True))
        Me.idUserTextEdit.Location = New System.Drawing.Point(133, 439)
        Me.idUserTextEdit.Name = "idUserTextEdit"
        Me.idUserTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idUserTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idUserTextEdit.Properties.Mask.EditMask = "N0"
        Me.idUserTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.idUserTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.idUserTextEdit.Size = New System.Drawing.Size(261, 20)
        Me.idUserTextEdit.StyleController = Me.DataLayoutControl1
        Me.idUserTextEdit.TabIndex = 27
        '
        'statusLookUpEdit
        '
        Me.statusLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "status", True))
        Me.statusLookUpEdit.Location = New System.Drawing.Point(133, 439)
        Me.statusLookUpEdit.Name = "statusLookUpEdit"
        Me.statusLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.statusLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.statusLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.statusLookUpEdit.Properties.NullText = ""
        Me.statusLookUpEdit.Size = New System.Drawing.Size(261, 20)
        Me.statusLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.statusLookUpEdit.TabIndex = 28
        '
        'genderTextEdit
        '
        Me.genderTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "gender", True))
        Me.genderTextEdit.Location = New System.Drawing.Point(145, 138)
        Me.genderTextEdit.Name = "genderTextEdit"
        Me.genderTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.genderTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.genderTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.genderTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.genderTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.genderTextEdit.Properties.Columns = 2
        Me.genderTextEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.genderTextEdit.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Laki-Laki"), New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Perempuan")})
        Me.genderTextEdit.Size = New System.Drawing.Size(313, 26)
        Me.genderTextEdit.StyleController = Me.DataLayoutControl1
        Me.genderTextEdit.TabIndex = 11
        '
        'alamatSekolahAsalTextEdit
        '
        Me.alamatSekolahAsalTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstPendaftarBindingSource, "alamatSekolahAsal", True))
        Me.alamatSekolahAsalTextEdit.Location = New System.Drawing.Point(145, 192)
        Me.alamatSekolahAsalTextEdit.Name = "alamatSekolahAsalTextEdit"
        Me.alamatSekolahAsalTextEdit.Size = New System.Drawing.Size(313, 58)
        Me.alamatSekolahAsalTextEdit.StyleController = Me.DataLayoutControl1
        Me.alamatSekolahAsalTextEdit.TabIndex = 13
        '
        'ItemForidGelombang
        '
        Me.ItemForidGelombang.Control = Me.idGelombangTextEdit
        Me.ItemForidGelombang.Location = New System.Drawing.Point(0, 0)
        Me.ItemForidGelombang.Name = "ItemForidGelombang"
        Me.ItemForidGelombang.Size = New System.Drawing.Size(386, 24)
        Me.ItemForidGelombang.Text = "id Gelombang"
        Me.ItemForidGelombang.TextSize = New System.Drawing.Size(118, 13)
        '
        'ItemForNomorPendaftaran
        '
        Me.ItemForNomorPendaftaran.Control = Me.NomorPendaftaranTextEdit
        Me.ItemForNomorPendaftaran.Location = New System.Drawing.Point(0, 0)
        Me.ItemForNomorPendaftaran.Name = "ItemForNomorPendaftaran"
        Me.ItemForNomorPendaftaran.Size = New System.Drawing.Size(386, 24)
        Me.ItemForNomorPendaftaran.Text = "Nomor Pendaftaran"
        Me.ItemForNomorPendaftaran.TextSize = New System.Drawing.Size(118, 13)
        '
        'ItemFortanggalPendaftaran
        '
        Me.ItemFortanggalPendaftaran.Control = Me.tanggalPendaftaranDateEdit
        Me.ItemFortanggalPendaftaran.Location = New System.Drawing.Point(0, 0)
        Me.ItemFortanggalPendaftaran.Name = "ItemFortanggalPendaftaran"
        Me.ItemFortanggalPendaftaran.Size = New System.Drawing.Size(386, 24)
        Me.ItemFortanggalPendaftaran.Text = "tanggal Pendaftaran"
        Me.ItemFortanggalPendaftaran.TextSize = New System.Drawing.Size(118, 13)
        '
        'ItemForstatus
        '
        Me.ItemForstatus.Control = Me.statusLookUpEdit
        Me.ItemForstatus.Location = New System.Drawing.Point(0, 509)
        Me.ItemForstatus.Name = "ItemForstatus"
        Me.ItemForstatus.Size = New System.Drawing.Size(386, 24)
        Me.ItemForstatus.Text = "status"
        Me.ItemForstatus.TextSize = New System.Drawing.Size(118, 13)
        '
        'ItemForidUser
        '
        Me.ItemForidUser.Control = Me.idUserTextEdit
        Me.ItemForidUser.Location = New System.Drawing.Point(0, 485)
        Me.ItemForidUser.Name = "ItemForidUser"
        Me.ItemForidUser.Size = New System.Drawing.Size(386, 24)
        Me.ItemForidUser.Text = "id User"
        Me.ItemForidUser.TextSize = New System.Drawing.Size(118, 13)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1201, 753)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlGroup3, Me.LayoutControlGroup4, Me.LayoutControlGroup5, Me.LayoutControlGroup6})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1181, 733)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.MstPendaftarGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 447)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1181, 286)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemFornama, Me.ItemFortanggalLahir, Me.ItemForberatBadan, Me.ItemFortinggiBadan, Me.ItemForgender, Me.ItemForsekolahAsal, Me.ItemForalamatSekolahAsal})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(462, 254)
        Me.LayoutControlGroup3.Text = "Detail Calon Peserta Didik"
        '
        'ItemFornama
        '
        Me.ItemFornama.Control = Me.namaTextEdit
        Me.ItemFornama.Location = New System.Drawing.Point(0, 0)
        Me.ItemFornama.Name = "ItemFornama"
        Me.ItemFornama.Size = New System.Drawing.Size(438, 24)
        Me.ItemFornama.Text = "nama"
        Me.ItemFornama.TextSize = New System.Drawing.Size(118, 13)
        '
        'ItemFortanggalLahir
        '
        Me.ItemFortanggalLahir.Control = Me.tanggalLahirDateEdit
        Me.ItemFortanggalLahir.Location = New System.Drawing.Point(0, 24)
        Me.ItemFortanggalLahir.Name = "ItemFortanggalLahir"
        Me.ItemFortanggalLahir.Size = New System.Drawing.Size(438, 24)
        Me.ItemFortanggalLahir.Text = "tanggal Lahir"
        Me.ItemFortanggalLahir.TextSize = New System.Drawing.Size(118, 13)
        '
        'ItemForberatBadan
        '
        Me.ItemForberatBadan.Control = Me.beratBadanTextEdit
        Me.ItemForberatBadan.Location = New System.Drawing.Point(0, 48)
        Me.ItemForberatBadan.Name = "ItemForberatBadan"
        Me.ItemForberatBadan.Size = New System.Drawing.Size(438, 24)
        Me.ItemForberatBadan.Text = "berat Badan"
        Me.ItemForberatBadan.TextSize = New System.Drawing.Size(118, 13)
        '
        'ItemFortinggiBadan
        '
        Me.ItemFortinggiBadan.Control = Me.tinggiBadanTextEdit
        Me.ItemFortinggiBadan.Location = New System.Drawing.Point(0, 72)
        Me.ItemFortinggiBadan.Name = "ItemFortinggiBadan"
        Me.ItemFortinggiBadan.Size = New System.Drawing.Size(438, 24)
        Me.ItemFortinggiBadan.Text = "tinggi Badan"
        Me.ItemFortinggiBadan.TextSize = New System.Drawing.Size(118, 13)
        '
        'ItemForgender
        '
        Me.ItemForgender.Control = Me.genderTextEdit
        Me.ItemForgender.Location = New System.Drawing.Point(0, 96)
        Me.ItemForgender.Name = "ItemForgender"
        Me.ItemForgender.Size = New System.Drawing.Size(438, 30)
        Me.ItemForgender.Text = "gender"
        Me.ItemForgender.TextSize = New System.Drawing.Size(118, 13)
        '
        'ItemForsekolahAsal
        '
        Me.ItemForsekolahAsal.Control = Me.sekolahAsalTextEdit
        Me.ItemForsekolahAsal.Location = New System.Drawing.Point(0, 126)
        Me.ItemForsekolahAsal.Name = "ItemForsekolahAsal"
        Me.ItemForsekolahAsal.Size = New System.Drawing.Size(438, 24)
        Me.ItemForsekolahAsal.Text = "sekolah Asal"
        Me.ItemForsekolahAsal.TextSize = New System.Drawing.Size(118, 13)
        '
        'ItemForalamatSekolahAsal
        '
        Me.ItemForalamatSekolahAsal.Control = Me.alamatSekolahAsalTextEdit
        Me.ItemForalamatSekolahAsal.Location = New System.Drawing.Point(0, 150)
        Me.ItemForalamatSekolahAsal.Name = "ItemForalamatSekolahAsal"
        Me.ItemForalamatSekolahAsal.Size = New System.Drawing.Size(438, 62)
        Me.ItemForalamatSekolahAsal.Text = "alamat Sekolah Asal"
        Me.ItemForalamatSekolahAsal.TextSize = New System.Drawing.Size(118, 13)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemFornamaAyah, Me.ItemForpekerjaan, Me.ItemForAlamatAyah, Me.ItemForNamaIbu, Me.ItemForpekerjaanIbu, Me.ItemForalamatIbu, Me.ItemForpenghasilanOrangTua})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(462, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(390, 254)
        Me.LayoutControlGroup4.Text = "Data Orang Tua Calon Peserta Didik"
        '
        'ItemFornamaAyah
        '
        Me.ItemFornamaAyah.Control = Me.namaAyahTextEdit
        Me.ItemFornamaAyah.Location = New System.Drawing.Point(0, 0)
        Me.ItemFornamaAyah.Name = "ItemFornamaAyah"
        Me.ItemFornamaAyah.Size = New System.Drawing.Size(366, 24)
        Me.ItemFornamaAyah.Text = "nama Ayah"
        Me.ItemFornamaAyah.TextSize = New System.Drawing.Size(118, 13)
        '
        'ItemForpekerjaan
        '
        Me.ItemForpekerjaan.Control = Me.pekerjaanTextEdit
        Me.ItemForpekerjaan.Location = New System.Drawing.Point(0, 24)
        Me.ItemForpekerjaan.Name = "ItemForpekerjaan"
        Me.ItemForpekerjaan.Size = New System.Drawing.Size(366, 24)
        Me.ItemForpekerjaan.Text = "pekerjaan"
        Me.ItemForpekerjaan.TextSize = New System.Drawing.Size(118, 13)
        '
        'ItemForAlamatAyah
        '
        Me.ItemForAlamatAyah.Control = Me.AlamatAyahTextEdit
        Me.ItemForAlamatAyah.Location = New System.Drawing.Point(0, 48)
        Me.ItemForAlamatAyah.Name = "ItemForAlamatAyah"
        Me.ItemForAlamatAyah.Size = New System.Drawing.Size(366, 24)
        Me.ItemForAlamatAyah.Text = "Alamat Ayah"
        Me.ItemForAlamatAyah.TextSize = New System.Drawing.Size(118, 13)
        '
        'ItemForNamaIbu
        '
        Me.ItemForNamaIbu.Control = Me.NamaIbuTextEdit
        Me.ItemForNamaIbu.Location = New System.Drawing.Point(0, 72)
        Me.ItemForNamaIbu.Name = "ItemForNamaIbu"
        Me.ItemForNamaIbu.Size = New System.Drawing.Size(366, 24)
        Me.ItemForNamaIbu.Text = "Nama Ibu"
        Me.ItemForNamaIbu.TextSize = New System.Drawing.Size(118, 13)
        '
        'ItemForpekerjaanIbu
        '
        Me.ItemForpekerjaanIbu.Control = Me.pekerjaanIbuTextEdit
        Me.ItemForpekerjaanIbu.Location = New System.Drawing.Point(0, 96)
        Me.ItemForpekerjaanIbu.Name = "ItemForpekerjaanIbu"
        Me.ItemForpekerjaanIbu.Size = New System.Drawing.Size(366, 24)
        Me.ItemForpekerjaanIbu.Text = "pekerjaan Ibu"
        Me.ItemForpekerjaanIbu.TextSize = New System.Drawing.Size(118, 13)
        '
        'ItemForalamatIbu
        '
        Me.ItemForalamatIbu.Control = Me.alamatIbuTextEdit
        Me.ItemForalamatIbu.Location = New System.Drawing.Point(0, 120)
        Me.ItemForalamatIbu.Name = "ItemForalamatIbu"
        Me.ItemForalamatIbu.Size = New System.Drawing.Size(366, 24)
        Me.ItemForalamatIbu.Text = "alamat Ibu"
        Me.ItemForalamatIbu.TextSize = New System.Drawing.Size(118, 13)
        '
        'ItemForpenghasilanOrangTua
        '
        Me.ItemForpenghasilanOrangTua.Control = Me.penghasilanOrangTuaTextEdit
        Me.ItemForpenghasilanOrangTua.Location = New System.Drawing.Point(0, 144)
        Me.ItemForpenghasilanOrangTua.Name = "ItemForpenghasilanOrangTua"
        Me.ItemForpenghasilanOrangTua.Size = New System.Drawing.Size(366, 68)
        Me.ItemForpenghasilanOrangTua.Text = "penghasilan Orang Tua"
        Me.ItemForpenghasilanOrangTua.TextSize = New System.Drawing.Size(118, 13)
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForidJurusan, Me.ItemFornomorIjazah, Me.ItemFornilaiRataRataKelulusan, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem2, Me.EmptySpaceItem7, Me.EmptySpaceItem1, Me.LayoutControlItem6})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(852, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(329, 254)
        Me.LayoutControlGroup5.Text = "Data"
        '
        'ItemForidJurusan
        '
        Me.ItemForidJurusan.Control = Me.idJurusanLookUpEdit
        Me.ItemForidJurusan.Location = New System.Drawing.Point(0, 0)
        Me.ItemForidJurusan.Name = "ItemForidJurusan"
        Me.ItemForidJurusan.Size = New System.Drawing.Size(305, 24)
        Me.ItemForidJurusan.Text = "id Jurusan"
        Me.ItemForidJurusan.TextSize = New System.Drawing.Size(118, 13)
        '
        'ItemFornomorIjazah
        '
        Me.ItemFornomorIjazah.Control = Me.nomorIjazahTextEdit
        Me.ItemFornomorIjazah.Location = New System.Drawing.Point(0, 24)
        Me.ItemFornomorIjazah.Name = "ItemFornomorIjazah"
        Me.ItemFornomorIjazah.Size = New System.Drawing.Size(305, 24)
        Me.ItemFornomorIjazah.Text = "nomor Ijazah"
        Me.ItemFornomorIjazah.TextSize = New System.Drawing.Size(118, 13)
        '
        'ItemFornilaiRataRataKelulusan
        '
        Me.ItemFornilaiRataRataKelulusan.Control = Me.nilaiRataRataKelulusanTextEdit
        Me.ItemFornilaiRataRataKelulusan.Location = New System.Drawing.Point(0, 48)
        Me.ItemFornilaiRataRataKelulusan.Name = "ItemFornilaiRataRataKelulusan"
        Me.ItemFornilaiRataRataKelulusan.Size = New System.Drawing.Size(305, 24)
        Me.ItemFornilaiRataRataKelulusan.Text = "nilai Rata Rata Kelulusan"
        Me.ItemFornilaiRataRataKelulusan.TextSize = New System.Drawing.Size(118, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.buttonPrestasi
        Me.LayoutControlItem3.Location = New System.Drawing.Point(10, 108)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(295, 26)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.buttonPendidikanNonFormal
        Me.LayoutControlItem4.Location = New System.Drawing.Point(10, 134)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(295, 26)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.buttonPengalamanOrganisasi
        Me.LayoutControlItem5.Location = New System.Drawing.Point(10, 160)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(295, 26)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.buttonNilaiUN
        Me.LayoutControlItem2.Location = New System.Drawing.Point(10, 82)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(295, 26)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(0, 72)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(10, 140)
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(10, 72)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(295, 10)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.buttonHobi
        Me.LayoutControlItem6.Location = New System.Drawing.Point(10, 186)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(295, 26)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForphotoIjazah, Me.ItemForphotoPelamar, Me.ItemForPhotoKartuKeluarga})
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 254)
        Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(1181, 193)
        Me.LayoutControlGroup6.Text = "Dokumen Gambar"
        '
        'ItemForphotoIjazah
        '
        Me.ItemForphotoIjazah.Control = Me.photoIjazahPictureEdit
        Me.ItemForphotoIjazah.Location = New System.Drawing.Point(122, 0)
        Me.ItemForphotoIjazah.MaxSize = New System.Drawing.Size(516, 151)
        Me.ItemForphotoIjazah.MinSize = New System.Drawing.Size(516, 151)
        Me.ItemForphotoIjazah.Name = "ItemForphotoIjazah"
        Me.ItemForphotoIjazah.Size = New System.Drawing.Size(516, 151)
        Me.ItemForphotoIjazah.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.ItemForphotoIjazah.StartNewLine = True
        Me.ItemForphotoIjazah.Text = "photo Ijazah"
        Me.ItemForphotoIjazah.TextLocation = DevExpress.Utils.Locations.Top
        Me.ItemForphotoIjazah.TextSize = New System.Drawing.Size(118, 13)
        '
        'ItemForphotoPelamar
        '
        Me.ItemForphotoPelamar.Control = Me.photoPelamarPictureEdit
        Me.ItemForphotoPelamar.Location = New System.Drawing.Point(0, 0)
        Me.ItemForphotoPelamar.MaxSize = New System.Drawing.Size(122, 151)
        Me.ItemForphotoPelamar.MinSize = New System.Drawing.Size(122, 151)
        Me.ItemForphotoPelamar.Name = "ItemForphotoPelamar"
        Me.ItemForphotoPelamar.Size = New System.Drawing.Size(122, 151)
        Me.ItemForphotoPelamar.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.ItemForphotoPelamar.StartNewLine = True
        Me.ItemForphotoPelamar.Text = "photo Pelamar"
        Me.ItemForphotoPelamar.TextLocation = DevExpress.Utils.Locations.Top
        Me.ItemForphotoPelamar.TextSize = New System.Drawing.Size(118, 13)
        '
        'ItemForPhotoKartuKeluarga
        '
        Me.ItemForPhotoKartuKeluarga.Control = Me.PhotoKartuKeluargaPictureEdit
        Me.ItemForPhotoKartuKeluarga.Location = New System.Drawing.Point(638, 0)
        Me.ItemForPhotoKartuKeluarga.MaxSize = New System.Drawing.Size(519, 151)
        Me.ItemForPhotoKartuKeluarga.MinSize = New System.Drawing.Size(519, 151)
        Me.ItemForPhotoKartuKeluarga.Name = "ItemForPhotoKartuKeluarga"
        Me.ItemForPhotoKartuKeluarga.Size = New System.Drawing.Size(519, 151)
        Me.ItemForPhotoKartuKeluarga.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.ItemForPhotoKartuKeluarga.StartNewLine = True
        Me.ItemForPhotoKartuKeluarga.Text = "Photo Kartu Keluarga"
        Me.ItemForPhotoKartuKeluarga.TextLocation = DevExpress.Utils.Locations.Top
        Me.ItemForPhotoKartuKeluarga.TextSize = New System.Drawing.Size(118, 13)
        '
        'AvailableJurusanTableAdapter
        '
        Me.AvailableJurusanTableAdapter.ClearBeforeFill = True
        '
        'MstJurusanTableAdapter
        '
        Me.MstJurusanTableAdapter.ClearBeforeFill = True
        '
        'FormPendaftaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 778)
        Me.Controls.Add(Me.DataLayoutControl1)
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
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstJurusanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.idGelombangTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NomorPendaftaranTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tanggalPendaftaranDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tanggalPendaftaranDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.namaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tanggalLahirDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tanggalLahirDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beratBadanTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tinggiBadanTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sekolahAsalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.namaAyahTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pekerjaanTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlamatAyahTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamaIbuTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pekerjaanIbuTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alamatIbuTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.penghasilanOrangTuaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idJurusanLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvailableJurusanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nomorIjazahTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nilaiRataRataKelulusanTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.photoIjazahPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.photoPelamarPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhotoKartuKeluargaPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idUserTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.statusLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.genderTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alamatSekolahAsalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidGelombang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNomorPendaftaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFortanggalPendaftaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForstatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFornama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFortanggalLahir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForberatBadan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFortinggiBadan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForgender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForsekolahAsal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForalamatSekolahAsal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFornamaAyah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForpekerjaan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAlamatAyah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNamaIbu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForpekerjaanIbu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForalamatIbu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForpenghasilanOrangTua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidJurusan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFornomorIjazah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFornilaiRataRataKelulusan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForphotoIjazah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForphotoPelamar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPhotoKartuKeluarga, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents colidGelombang As XtraGrid.Columns.GridColumn
    Friend WithEvents colNomorPendaftaran As XtraGrid.Columns.GridColumn
    Friend WithEvents coltanggalPendaftaran As XtraGrid.Columns.GridColumn
    Friend WithEvents colnama As XtraGrid.Columns.GridColumn
    Friend WithEvents coltanggalLahir As XtraGrid.Columns.GridColumn
    Friend WithEvents colberatBadan As XtraGrid.Columns.GridColumn
    Friend WithEvents coltinggiBadan As XtraGrid.Columns.GridColumn
    Friend WithEvents colgender As XtraGrid.Columns.GridColumn
    Friend WithEvents colsekolahAsal As XtraGrid.Columns.GridColumn
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
    Friend WithEvents idGelombangTextEdit As TextEdit
    Friend WithEvents NomorPendaftaranTextEdit As TextEdit
    Friend WithEvents tanggalPendaftaranDateEdit As DateEdit
    Friend WithEvents namaTextEdit As TextEdit
    Friend WithEvents tanggalLahirDateEdit As DateEdit
    Friend WithEvents beratBadanTextEdit As TextEdit
    Friend WithEvents tinggiBadanTextEdit As TextEdit
    Friend WithEvents sekolahAsalTextEdit As TextEdit
    Friend WithEvents namaAyahTextEdit As TextEdit
    Friend WithEvents pekerjaanTextEdit As TextEdit
    Friend WithEvents AlamatAyahTextEdit As TextEdit
    Friend WithEvents NamaIbuTextEdit As TextEdit
    Friend WithEvents pekerjaanIbuTextEdit As TextEdit
    Friend WithEvents alamatIbuTextEdit As TextEdit
    Friend WithEvents penghasilanOrangTuaTextEdit As TextEdit
    Friend WithEvents idJurusanLookUpEdit As LookUpEdit
    Friend WithEvents nomorIjazahTextEdit As TextEdit
    Friend WithEvents nilaiRataRataKelulusanTextEdit As TextEdit
    Friend WithEvents photoIjazahPictureEdit As PictureEdit
    Friend WithEvents photoPelamarPictureEdit As PictureEdit
    Friend WithEvents PhotoKartuKeluargaPictureEdit As PictureEdit
    Friend WithEvents idUserTextEdit As TextEdit
    Friend WithEvents statusLookUpEdit As LookUpEdit
    Friend WithEvents genderTextEdit As RadioGroup
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForidGelombang As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNomorPendaftaran As XtraLayout.LayoutControlItem
    Friend WithEvents ItemFortanggalPendaftaran As XtraLayout.LayoutControlItem
    Friend WithEvents ItemFornama As XtraLayout.LayoutControlItem
    Friend WithEvents ItemFortanggalLahir As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForberatBadan As XtraLayout.LayoutControlItem
    Friend WithEvents ItemFortinggiBadan As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForgender As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForsekolahAsal As XtraLayout.LayoutControlItem
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
    Friend WithEvents AvailableJurusanBindingSource As BindingSource
    Friend WithEvents AvailableJurusanTableAdapter As DataSetPendaftaranTableAdapters.AvailableJurusanTableAdapter
    Friend WithEvents labelInfo As ToolStripLabel
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup4 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup5 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup6 As XtraLayout.LayoutControlGroup
    Friend WithEvents RepositoryItemLookUpEdit1 As Repository.RepositoryItemLookUpEdit
    Friend WithEvents MstJurusanBindingSource As BindingSource
    Friend WithEvents MstJurusanTableAdapter As DataSetPendaftaranTableAdapters.mstJurusanTableAdapter
    Friend WithEvents buttonHobi As SimpleButton
    Friend WithEvents buttonPengalamanOrganisasi As SimpleButton
    Friend WithEvents buttonPendidikanNonFormal As SimpleButton
    Friend WithEvents buttonPrestasi As SimpleButton
    Friend WithEvents alamatSekolahAsalTextEdit As MemoEdit
    Friend WithEvents LayoutControlItem3 As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As XtraLayout.LayoutControlItem
    Friend WithEvents buttonNilaiUN As SimpleButton
    Friend WithEvents LayoutControlItem2 As XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem7 As XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem1 As XtraLayout.EmptySpaceItem
    Friend WithEvents buttonPrint As ToolStripButton
End Class
