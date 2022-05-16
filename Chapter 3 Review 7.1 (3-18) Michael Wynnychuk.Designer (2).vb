Public Class lblMessage

    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub lblEnglish_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEnglish.CheckedChanged
        lblGreeting.Text = "Hello World!"
    End Sub

    Private Sub lblFrench_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblFrench.CheckedChanged
        lblGreeting.Text = "Bonjour le monde!"
    End Sub

    Private Sub lblSpanish_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblSpanish.CheckedChanged
        lblGreeting.Text = "Hola, mundo!"
    End Sub
End Class
