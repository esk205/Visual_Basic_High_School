'Michael Wynnychuk'
'Programming Advanced'
'Period 2'
'Date Oct.23 2014'

'This program is called "Game 21" in this program whoever has a total of 21 or 
'has a high number than the computer opponent, wins. If both have a total over 21
'it is considered a draw and it is also a draw if both the computer and the player
'have the same number. The player may draw a third card to increase their total number
'and the computer will draw a third card if the computers total is greater than or equal
'to 16. This program has a pop up window to notify the player of the results of the game,
'also there's a exit button to close the program and "Play Game" button to play the game
'with a default setting of two cards drawn. The card numbers range from 1 to 10, and the
'results are only displayed after the player presses the "Check Score" button.

Public Class lblMessage

    Dim ComputerNumber = 0, PlayerNumber = 0, HighNumber = 10, LowNumber = 1, RandomNumber3 As Long 'Declares and defines some variables, all are Long
    Private Sub btnDrawCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrawCard.Click

        Randomize() 'Allows for the use of the code Rnd() which is used in a equation to make numbers random.
        RandomNumber3 = (HighNumber - LowNumber + 1) * Rnd() + LowNumber 'Defines what numerical value RandomNumber3 is.
        Me.lblRandomNumber3.Text = RandomNumber3 'Displays in the lblRandomNumber3 RandomNumber3's value.
    End Sub

    Private Sub btnCheckScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPlayGame.Click, btnCheckScore.Click
        Dim RandomNumber1, RandomNumber2, RandomNumber4, RandomNumber5, RandomNumber6 As Long

        Randomize() 'Allows for the use of the code Rnd() which is used in a equation to make numbers random.
        RandomNumber1 = (HighNumber - LowNumber + 1) * Rnd() + LowNumber 'Defines what numerical value RandomNumber1 is.
        RandomNumber2 = (HighNumber - LowNumber + 1) * Rnd() + LowNumber 'Defines what numerical value RandomNumber2 is.
        RandomNumber4 = (HighNumber - LowNumber + 1) * Rnd() + LowNumber 'Defines what numerical value RandomNumber4 is.
        RandomNumber5 = (HighNumber - LowNumber + 1) * Rnd() + LowNumber 'Defines what numerical value RandomNumber5 is.
        RandomNumber6 = (HighNumber - LowNumber + 1) * Rnd() + LowNumber 'Defines what numerical value RandomNumber6 is.

        Me.lblRandomNumber1.Text = RandomNumber1 'Displays RandomNumber1
        Me.lblRandomNumber2.Text = RandomNumber2 'Displays RandomNumber2
        Me.lblRandomNumber4.Text = RandomNumber4 'Displays RandomNumber4
        Me.lblRandomNumber5.Text = RandomNumber5 'Displays RandomNumber5

        ComputerNumber = RandomNumber4 + RandomNumber5 + RandomNumber6 ' Adds the computers random numbers.
        PlayerNumber = RandomNumber1 + RandomNumber2 'Adds up some of the players random numbers.

        If RandomNumber3 > 0 Then
            PlayerNumber = PlayerNumber + RandomNumber3 'Adds RandomNumber3 value to the total
            RandomNumber3 = 0 'Resets RandomNumber3 to zero
        Else
            Me.lblRandomNumber3.Text = "" 'If DrawCard was not selected the text will go blank
        End If

        If (RandomNumber4 + RandomNumber5) >= 16 Then 'If both RandomNumber variables is less than 16 or equal to.
            Me.lblRandomNumber6.Text = "" 'This will make RandomNumber6's text go blank.
            ComputerNumber = RandomNumber4 + RandomNumber5 'Defines what ComputerNumber is equal to.
        Else
            Me.lblRandomNumber6.Text = RandomNumber6 'Displays the number for the label lblRandomNumber6.
            ComputerNumber = RandomNumber4 + RandomNumber5 + RandomNumber6 'Defines what ComputerNumber is equal to.
        End If

        Me.lblPlayerScore.Text = PlayerNumber
        Me.lblComputerScore.Text = ComputerNumber

        If ComputerNumber > 21 And PlayerNumber > 21 Or ComputerNumber = PlayerNumber Then 'Works'
            MessageBox.Show("DRAW!")

        ElseIf ComputerNumber > PlayerNumber And ComputerNumber <= 21 Or ComputerNumber <= 21 And PlayerNumber > 21 Then
            MessageBox.Show("Computer wins, you lose!")

        ElseIf ComputerNumber > PlayerNumber And ComputerNumber <= 21 Then
            MessageBox.Show("Computer wins, you lost!")

        ElseIf PlayerNumber > ComputerNumber And PlayerNumber <= 21 Or PlayerNumber <= 21 And ComputerNumber > 21 Then
            MessageBox.Show("You win, computer lost!")

        ElseIf PlayerNumber < 21 And ComputerNumber > 21 Then
            MessageBox.Show("You win, computer lost!")
        End If
    End Sub
    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        End
    End Sub
End Class
