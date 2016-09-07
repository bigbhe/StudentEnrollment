Public Class FormLogin
    Private isApproved As Boolean
    Private Sub buttonLogin_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click
        Login()
    End Sub
    Sub Login()
        If txtUserName.Text.Length = 0 Then
            XtraMessageBox.Show("Your account name still empty.", "Data Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUserName.Focus()
            Exit Sub
        End If

        If txtPassword.Text.Length = 0 Then
            XtraMessageBox.Show("Your password still empty.", "Data Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
            Exit Sub
        End If

        aUser.Username = txtUserName.Text
        aUser.Password = txtPassword.Text 'it will be encrypted in class UserActive


        Select Case aUser.DoValidation
            Case 0




                isApproved = True
                'Dim label As New MainForm.labelfullname

                Me.Close()
            Case 1
                XtraMessageBox.Show("Your username not valid.", "Data Unmatched", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUserName.Focus()
                Exit Sub
            Case 2
                XtraMessageBox.Show("Your password not valid.", "Data Unmatched", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Focus()
                Exit Sub
            Case 3
                XtraMessageBox.Show("Your account is currently loggon from other terminal.", "Account Logged On", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtUserName.Focus()
                Exit Sub
            Case 4
                XtraMessageBox.Show("Your account has been blocked by Administrator.", "Account Blocked", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtUserName.Focus()
                Exit Sub
            Case Else
                Exit Sub
        End Select
    End Sub
    Sub Automatelogin()
        txtPassword.Text = "martin"
        txtUserName.Text = "martin"

        Login()

    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Automatelogin()

    End Sub
End Class