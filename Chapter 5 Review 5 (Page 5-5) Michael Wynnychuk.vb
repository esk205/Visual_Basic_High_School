'Michael Wynnychuk'
'Programming Advanced'
'Period 2'
'Date Sept.24 2014'

Public Class lblMessage

    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub btnCheckGrade_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCheckGrade.Click
        Dim CheckGrade As Single

        CheckGrade = Val(Me.txtEnterGrade.Text)

        If CheckGrade >= 93 Then
            Me.lblGradeStatement.Text = "Your grade is a A, excellent job!"
            CheckGrade = CheckGrade - CheckGrade

        ElseIf CheckGrade <= 92 And CheckGrade >= 85 Then
            Me.lblGradeStatement.Text = "Your grade is a B, good job!"
            CheckGrade = CheckGrade - CheckGrade

        ElseIf CheckGrade <= 84 And CheckGrade >= 78 Then
            Me.lblGradeStatement.Text = "Your grade is a C, study more!"
            CheckGrade = CheckGrade - CheckGrade

        ElseIf CheckGrade <= 77 And CheckGrade >= 69 Then
            Me.lblGradeStatement.Text = "Your grade is a D, study more!"
            CheckGrade = CheckGrade - CheckGrade

        ElseIf CheckGrade <= 68 And CheckGrade >= 0 Then
            Me.lblGradeStatement.Text = "Invalid grade."

        End If

    End Sub
End Class
