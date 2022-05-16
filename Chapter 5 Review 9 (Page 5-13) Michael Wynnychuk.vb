'Michael Wynnychuk'
'Programming Advanced'
'Period 2'
'Date Sept.30 2014'

Public Class lblMessage

    Dim PlayerMove, ComputerMove As Integer
    Const Rock1 = 1, Paper2 = 2, Scissors3 = 3

    Private Sub btnRock1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRock1.Click
        ComputerMove = Int((3 - 1 + 1) * Rnd()) + 1
        PlayerMove = Rock1

        If ComputerMove = Rock1 Then
            Me.lblYourChoice.Text = "You chose rock!"
            Me.lblComputerChoice.Text = "Computer chose rock too!"
            Me.lblOutcome.Text = "It's a TIE"

        ElseIf ComputerMove = Paper2 Then
            Me.lblYourChoice.Text = "You chose rock!"
            Me.lblComputerChoice.Text = "Computer chose paper!"
            Me.lblOutcome.Text = "You LOSE paper beats rock!"

        ElseIf ComputerMove = Scissors3 Then
            Me.lblYourChoice.Text = "You chose rock!"
            Me.lblComputerChoice.Text = "Computer chose scissors!"
            Me.lblOutcome.Text = "You WIN rock beats scissors!"
        End If
    End Sub

    Private Sub btnPaper2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPaper2.Click
        ComputerMove = Int((3 - 1 + 1) * Rnd()) + 1
        PlayerMove = Paper2

        If ComputerMove = Paper2 Then
            Me.lblYourChoice.Text = "You chose paper!"
            Me.lblComputerChoice.Text = "Computer chose paper too!"
            Me.lblOutcome.Text = "It's a TIE!"

        ElseIf ComputerMove = Scissors3 Then
            Me.lblYourChoice.Text = "You chose paper!"
            Me.lblComputerChoice.Text = "Computer chose scissors!"
            Me.lblOutcome.Text = "You LOSE scissors beats paper!"

        ElseIf ComputerMove = Rock1 Then
            Me.lblYourChoice.Text = "You chose paper!"
            Me.lblComputerChoice.Text = "Computer chose rock!"
            Me.lblOutcome.Text = "You WIN paper beats rock!"
        End If
    End Sub

    Private Sub btnScissors3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnScissors3.Click
        ComputerMove = Int((3 - 1 + 1) * Rnd()) + 1
        PlayerMove = Scissors3

        If ComputerMove = Scissors3 Then
            Me.lblYourChoice.Text = "You chose scissors!"
            Me.lblComputerChoice.Text = "Computer chose scissors!"
            Me.lblOutcome.Text = "It's a TIE!"

        ElseIf ComputerMove = Paper2 Then
            Me.lblYourChoice.Text = "You chose scissors!"
            Me.lblComputerChoice.Text = "Computer chose paper!"
            Me.lblOutcome.Text = "You WIN scissors beats paper!"

        ElseIf ComputerMove = Rock1 Then
            Me.lblYourChoice.Text = "You chose scissors!"
            Me.lblComputerChoice.Text = "Computer chose rock!"
            Me.lblOutcome.Text = "You LOSE rock beats scissors!"
        End If
    End Sub
End Class
