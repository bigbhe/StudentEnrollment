Imports System.Data.SqlClient

Public Class ClassActiveUser
#Region "private members"

    Private _username As String
    Private _password As String



#End Region

#Region "public members - User information"
    Public Property fullname As String
    Public Property IDUser As Integer

    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property
#End Region
    Public Property Password As String
        Get
            Return crypt.DecryptData(_password)
        End Get
        Set(value As String)
            _password = crypt.EncryptData(value)
        End Set
    End Property

    Public Function DoValidation() As Integer
        '   @result value Is
        '   0 = success,
        '   1 = failed by username Not found,
        '   2 = failed by password unmatched,
        '   3 = failed by account logged on,
        '   4 = failed by account non-activated
        '  99 = system failure

        If Not dbOpen() Then
            XtraMessageBox.Show("System failed open connection to SQL Server.", "System Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return 99
        End If

        sqlCmd = New SqlCommand("sysValidationLogin", sqlCnn)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Clear()
        sqlCmd.Parameters.AddWithValue("@username", _username)
        sqlCmd.Parameters.AddWithValue("@password", _password)

        Dim ds As New DataSet


        Try
            sqlDta = New SqlDataAdapter(sqlCmd)
            sqlDta.Fill(ds)
            sqlDta.Dispose()
            sqlCmd.Dispose()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("System failed to validate user with this error:{0}{1}", vbCrLf, ex.Message), "System Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return 99
        Finally
            dbClose()
        End Try

#Disable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
        If ds.Tables(0).Rows(0)(0) = 0 Then
#Enable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Integer'.
            IDUser = ds.Tables(1).Rows(0)("iduser")
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Integer'.

#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
            Fullname = ds.Tables(1).Rows(0)("fullname")
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'String'.
            'Signature = ds.Tables(1).Rows(0)("signature") 'have to create a class to convert byte array to image
        End If

#Disable Warning BC42016 ' Implicit conversion from 'Object' to 'Integer'.
        Return ds.Tables(0).Rows(0)(0)
#Enable Warning BC42016 ' Implicit conversion from 'Object' to 'Integer'.
    End Function




End Class
