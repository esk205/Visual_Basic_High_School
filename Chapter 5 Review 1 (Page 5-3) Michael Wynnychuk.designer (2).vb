'Michael Wynnychuk'
'Programming Advanced'
'Period 2'
'Date Sept.22 2014'

Public Class lblMessage

    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub btnCheckGrade_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCheckGrade.Click
        Dim intGrade As Single

        intGrade = Val(Me.txtEnterTestGrade.Text)

        If intGrade >= 70 Then
            Me.lblGradeStatement.Text = "Good Job!"
        End If

    End Sub

    Private Sub txtEnterTestGrade_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEnterTestGrade.TextChanged
        Me.lblGradeStatement.Text = ""
    End Sub
End Class
