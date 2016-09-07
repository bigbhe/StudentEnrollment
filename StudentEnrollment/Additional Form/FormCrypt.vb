Public Class FormCrypt
    Private Sub FormCrypt_Load(sender As Object, e As EventArgs) Handles Me.Load
        MemoEdit1.Text = crypt.EncryptData("GROOT") & "Server" & vbNewLine & crypt.EncryptData("TemplateWithoutUserAccessRight") & "Database" & vbNewLine & crypt.EncryptData("sa") & "user" & vbNewLine & crypt.EncryptData("123") & "password" & vbNewLine & crypt.EncryptData("template") & ""
    End Sub
End Class