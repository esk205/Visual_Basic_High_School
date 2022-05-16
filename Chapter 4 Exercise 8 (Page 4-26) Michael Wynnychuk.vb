'Michael Wynnychuk'
'Programming Advanced'
'Period 2'
'Date Sept.22 2014'

Public Class lblMessage

    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        End
    End Sub

    Private Sub btnDigits_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDigits.Click
        Dim Digit1, Digit As Integer 'Declares the Dimension (Dim) variable and defines as a integer value.
        Dim Digit2 As Integer
        Digit = Val(Me.txtTwoDigitNumber.Text) 'The value entered in the textbox will be used later.'

        Digit1 = Digit / 10
        Digit2 = Digit Mod 10

        Me.lblDigit1.Text = Digit1 'Displays the Answer 
        Me.lblDigit2.Text = Digit2 'Displays the Answer 

    End Sub
End Class
