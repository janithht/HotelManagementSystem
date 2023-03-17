Public Class Logging

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPass.UseSystemPasswordChar = True

    End Sub

    Private Sub btnLogging_Click(sender As Object, e As EventArgs) Handles btnLogging.Click
        If cmbUser.SelectedIndex = 0 And txtPass.Text = "M12#gr" Then
            Me.Hide()
            frmMDI.Show()
        ElseIf cmbUser.SelectedIndex = 1 And txtPass.Text = "Sad325*" Then
            Me.Hide()
            frmMDI.Show()
        ElseIf cmbUser.SelectedIndex = 2 And txtPass.Text = "Rec33#*" Then
            Me.Hide()
            frmMDI.Show()
        Else : MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        btnLogging.Enabled = True

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub

    Private Sub lblPass_Click(sender As Object, e As EventArgs) Handles lblPass.Click

    End Sub
End Class