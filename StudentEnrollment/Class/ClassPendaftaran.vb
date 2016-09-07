Imports System.Data.SqlClient

Public Class ClassPendaftaran
    Public Property idGelombang As Integer
    Public Property tanggalDaftar As Date
    Public Property namaGelombang As String
    Public Property tanggalMulai As Date
    Public Property tanggalBerakhir As Date
    Public Property kodeGelombang As String
    Public Property idJurusan As Integer


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
        ds.Dispose()

    End Function
End Class
