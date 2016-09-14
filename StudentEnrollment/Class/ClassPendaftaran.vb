Imports System.Data.SqlClient
Imports System.Threading.Tasks

Public Class ClassPendaftaran
    Public Property idGelombang As Integer
    Public Property tanggalDaftar As Date
    Public Property namaGelombang As String
    Public Property tanggalMulai As Date
    Public Property tanggalBerakhir As Date
    Public Property kodeGelombang As String
    Public Property idJurusan As Integer

    ' Fields...
    Private _jumlahDataUN As Integer
    Private _namaPendaftar As String
    Private _nomorPendaftaran As String
    Private _idPelamar As Integer

    Public Property IdPelamar As Integer
        Get
            Return _idPelamar
        End Get
        Set(ByVal Value As Integer)
      _idPelamar = Value
        End Set
    End Property


    Public Property namaPendaftar As String
        Get
            Return _namaPendaftar
        End Get
        Set(ByVal Value As String)
      _namaPendaftar = Value
        End Set
    End Property

    Public Property NomorPendaftaran As String
        Get
            Return _nomorPendaftaran
        End Get
        Set(ByVal Value As String)
            _nomorPendaftaran = Value
        End Set
    End Property

    Public Property jumlahDataUN As Integer
        Get
            Return _jumlahDataUN
        End Get
        Set(ByVal Value As Integer)
      _jumlahDataUN = Value
        End Set
    End Property
    

    Sub New()
        tanggalDaftar = Now
        idJurusan = 0
    End Sub

    Public Function GetDataGelombang() As Integer


        If Not dbOpen() Then
            XtraMessageBox.Show("System failed open connection to SQL Server.", "System Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return 99
        End If

        sqlCmd = New SqlCommand("getDataGelombang", sqlCnn)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Clear()
        sqlCmd.Parameters.AddWithValue("@TanggalPendaftaran", tanggalDaftar)

        Dim ds As New DataSet


        Try
            sqlDta = New SqlDataAdapter(sqlCmd)
            sqlDta.Fill(ds)
            sqlDta.Dispose()
            sqlCmd.Dispose()
        Catch ex As Exception
            ex.Message.ToString()
            Return 99
        Finally
            dbClose()
        End Try


        idGelombang = CInt(ds.Tables(0).Rows(0)("id"))
        kodeGelombang = CType(ds.Tables(0).Rows(0)("kodeGelombang"), String)
        namaGelombang = CType(ds.Tables(0).Rows(0)("namaGelombang"), String)
        tanggalMulai = CDate(ds.Tables(0).Rows(0)("tanggalMulai"))
        tanggalBerakhir = CDate(ds.Tables(0).Rows(0)("tanggalBerakhir"))



#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Integer'.
        Return ds.Tables(0).Rows(0)(0)
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Integer'.
        ds.Dispose()

    End Function

    Public Function getKuota() As Integer
        If Not dbOpen() Then
            XtraMessageBox.Show("System failed open connection to SQL Server.", "System Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return 99
        End If

        sqlCmd = New SqlCommand("getDataKuota", sqlCnn)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Clear()
        sqlCmd.Parameters.AddWithValue("@idHeaderGelombang", idGelombang)
        sqlCmd.Parameters.AddWithValue("@idJurusan", idJurusan)

        Dim ds As New DataSet
        ds.Dispose()

        Try
            sqlDta = New SqlDataAdapter(sqlCmd)
            sqlDta.Fill(ds)
            sqlDta.Dispose()
            sqlCmd.Dispose()
        Catch ex As Exception
            ex.Message.ToString()

        Finally
            dbClose()
        End Try

#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Integer'.
        Return ds.Tables(0).Rows(0)("SisaKuota")
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Integer'.
        Dim t = Task.Factory.StartNew(Sub() ds.Dispose())
        t.Wait()

    End Function
    Public Function getJumlahDataUn() As Integer
        dbOpen()

        sqlCmd = New SqlCommand("checkDataUN", sqlCnn)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Clear()
        sqlCmd.Parameters.AddWithValue("@idPelamar", IdPelamar)



        sqlCmd.Parameters.Add("@dataSummary", SqlDbType.Int).Direction = ParameterDirection.Output

        sqlCmd.ExecuteNonQuery()

        jumlahDataUN = CInt(sqlCmd.Parameters("@dataSummary").Value)
#Disable Warning BC42016 ' Implicits conversion from 'Object' to 'Integer'.
        Return jumlahDataUN
        dbClose()
    End Function
End Class
