'Michael Wynnychuk'
'Programming Advanced'
'Period 2'
'Date Sept.11 2014

Public Class lblMessage

    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        End

    End Sub

    Private Sub mnuMiddleCenter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuMiddleCenter.Click
        lblHere.TextAlign = ContentAlignment.BottomRight
        lblHere.Text = "Here"

    End Sub

    Private Sub mnuMiddleLeft_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuMiddleLeft.Click
        lblHere.TextAlign = ContentAlignment.MiddleLeft

    End Sub

    Private Sub mnuTopCenter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuTopCenter.Click
        lblHere.TextAlign = ContentAlignment.TopCenter

    End Sub

    Private Sub mnuTopLeft_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuTopLeft.Click
        lblHere.TextAlign = ContentAlignment.TopLeft

    End Sub

    Private Sub mnuTopRight_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuTopRight.Click
        lblHere.TextAlign = ContentAlignment.TopRight

    End Sub

    Private Sub mnuBottomCenter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuBottomCenter.Click
        lblHere.TextAlign = ContentAlignment.BottomCenter
        lblHere.Text = "Here"

    End Sub

    Private Sub mnuBottomLeft_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuBottomLeft.Click
        lblHere.TextAlign = ContentAlignment.BottomLeft
        lblHere.Text = "Here"

    End Sub

    Private Sub mnuBottomRight_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuBottomRight.Click
        lblHere.TextAlign = ContentAlignment.BottomRight
        lblHere.Text = "Here"

    End Sub

End Class
