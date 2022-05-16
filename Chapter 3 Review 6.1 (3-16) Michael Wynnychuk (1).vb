Public Class lblMessage

    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        End
    End Sub

    Private Sub mnuHelloWorld1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuHelloWorld1.Click
        lblHello.Text = "Hello, world!"
        Me.lblHello.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub mnuSmile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuSmile.Click
        lblHello.Text = "Smile!"
    End Sub
End Class
