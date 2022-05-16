'Michael Wynnychuk'
'Programming Advanced'
'Period 2'
'Date Sept.15 2014'

Public Class lblMessage

    Private Sub btnAnswer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnswer.Click
        Dim sngRadius = 6, sngCircleArea As Single 'Declares the Dimension (Dim) variable and one of them equals 6'

        sngCircleArea = 3.14 * sngRadius ^ 2 'Assigns variable to have values to a circles area.
        Me.lblAnswer.Text = sngCircleArea 'Displays the Answer
    End Sub

    Private Sub mnuExit_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        End
    End Sub
End Class
