Imports System.Data.SqlClient

Public Class ClassTest
    ' Fields...
    Private _isProcess As Boolean
    Private _jumlahDataKurang As Integer
    Private _idHeader As Integer
    Private _namaTest As String
    Private _idTest As Integer

    Public Property idTest As Integer
        Get
            Return _idTest
        End Get
        Set(ByVal Value As Integer)
            _idTest = Value
        End Set
    End Property

    Public Property namaTest As String
        Get
            Return _namaTest
        End Get
        Set(ByVal Value As String)
            _namaTest = Value
        End Set
    End Property

    Public Property idHeader As Integer
        Get
            Return _idHeader
        End Get
        Set(ByVal Value As Integer)
            _idHeader = Value
        End Set
    End Property

    Public Property jumlahDataKurang As Integer
        Get
            Return _jumlahDataKurang
        End Get
        Set(ByVal Value As Integer)
      _jumlahDataKurang = Value
        End Set
    End Property
    Public Property IsProcess As Boolean
        Get
            Return _isProcess
        End Get
        Set(ByVal Value As Boolean)
      _isProcess = Value
        End Set
    End Property
    Sub New()
        isProcess = True
    End Sub
    Public Function getDataKurang() As Integer
        dbOpen()

        sqlCmd = New SqlCommand("getJumlahNilaiMasuk", sqlCnn)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Clear()
        sqlCmd.Parameters.AddWithValue("@idHeader", idHeader)
        sqlCmd.Parameters.AddWithValue("@idGelombang", oClassPendaftaran.idGelombang)

        sqlCmd.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output
        Try
            sqlCmd.ExecuteNonQuery()

            jumlahDataKurang = CInt(sqlCmd.Parameters("@result").Value)
        Catch ex As Exception
            If ex.ToString.ToLower.Contains("conversion") Then
                alertDialogFail(MainForm, "Data belum diisi sama sekali")
            End If

        End Try

#Disable Warning BC42016 ' Implicits conversion from 'Object' to 'Integer'.
        Return jumlahDataKurang
        dbClose()
    End Function
End Class
