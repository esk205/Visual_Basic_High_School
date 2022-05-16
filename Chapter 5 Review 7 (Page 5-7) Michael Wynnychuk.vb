'Michael Wynnychuk'
'Programming Advanced'
'Period 2'
'Date Sept.24 2014'

Public Class lblMessage

    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub btnRandomNumbers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRandomNumbers.Click

        Randomize()
        Me.lblRandNum1.Text = Int(32 * Rnd()) + 10
        Me.lblRandNum2.Text = Int(32 * Rnd()) + 10
        Me.lblRandNum3.Text = Int(32 * Rnd()) + 10
        Me.lblRandNum4.Text = Int(32 * Rnd()) + 10
        Me.lblRandNum5.Text = Int(32 * Rnd()) + 10
        Me.lblRandNum6.Text = Int(32 * Rnd()) + 10
        
    End Sub
End Class
