'Michael Wynnychuk'
'Programming Advanced'
'Period 2'
'Date Sept.25 2014'

Public Class lblMessage

    Private Sub btnCheckGuess_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCheckGuess.Click
        Dim intGuess As Integer
        Const intSecretNumber = 7

        intGuess = Val(txtPlayerGuess.Text)

        If intGuess = intSecretNumber And intGuess <= 7 And intGuess >= 1 Then
            Me.lblCorrectGuess.Text = "You've correctly guessed the number!"

        ElseIf intGuess > intSecretNumber And intGuess <= 7 And intGuess >= 1 Then
            Me.lblAnswer1.Text = "Your number is too high."

        ElseIf intGuess < intSecretNumber And intGuess <= 7 And intGuess >= 1 Then
            Me.lblAnswer1.Text = "Your number is too low."

        Else
            Me.lblAnswer2.Text = "You must enter a number that is between 1 and 7 "
        End If

    End Sub

    Private Sub txtPlayerGuess_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPlayerGuess.TextChanged
        Me.lblAnswer2.Text = ""
        Me.lblAnswer1.Text = ""
        Me.lblCorrectGuess.Text = ""
    End Sub
End Class
