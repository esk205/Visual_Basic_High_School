'Michael Wynnychuk'
'Programming Advanced'
'Period 2'
'Date Sept.8 2014

Public Class lblMessage

    Private Sub btnExpression1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpression1.Click
        Me.lblExpression1.Text = 5 + 2 ^ 3
    End Sub

    Private Sub btnExpression2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpression2.Click
        Me.lblExpression2.Text = 4 / 2 + 5
    End Sub

    Private Sub btnExpression3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpression3.Click
        Me.lblExpression3.Text = 3 + 4 * 2
    End Sub

    Private Sub btnExpression4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpression4.Click
        Me.lblExpression4.Text = 7 - 3 + 2
    End Sub

    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        End
    End Sub
End Class
