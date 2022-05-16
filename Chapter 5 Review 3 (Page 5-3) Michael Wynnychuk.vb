'Michael Wynnychuk'
'Programming Advanced'
'Period 2'
'Date Sept.23 2014'

Public Class lblMessage

    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub btnCheckGrade_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnswer.Click
        Dim intRadius, AnswerRadius As Single

        intRadius = Val(Me.txtEnterRadiusOfCircle.Text)

        If intRadius < 0 Then
            Me.lblAnswerBox1.Text = "Negative radii are illegal."
        Else
            AnswerRadius = intRadius ^ 2 * 3.14
            Me.lblAnswerBox2.Text = AnswerRadius
        End If

    End Sub

    Private Sub txtEnterTestGrade_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEnterRadiusOfCircle.TextChanged
        Me.lblAnswerBox1.Text = ""
        Me.lblAnswerBox2.Text = ""

    End Sub
End Class
