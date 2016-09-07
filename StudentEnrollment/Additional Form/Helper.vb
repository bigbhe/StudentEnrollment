Public Class Helper
    Private Sub Helper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetUser.mstUser' table. You can move, or remove it, as needed.
        Me.MstUserTableAdapter.Fill(Me.DataSetUser.mstUser)

    End Sub
End Class