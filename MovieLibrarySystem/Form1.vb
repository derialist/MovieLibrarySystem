Public Class form_registration
    Private Sub lnkToLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkToLogin.LinkClicked
        registrationPanel.Visible = False
        loginPanel.Visible = True
    End Sub

    Private Sub lnkToRegistration_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkToRegistration.LinkClicked
        loginPanel.Visible = False
        registrationPanel.Visible = True
    End Sub

    Private Sub registrationPanel_Paint(sender As Object, e As PaintEventArgs) Handles registrationPanel.Paint

    End Sub

    Private Sub loginPanel_Paint(sender As Object, e As PaintEventArgs) Handles loginPanel.Paint

    End Sub
End Class
