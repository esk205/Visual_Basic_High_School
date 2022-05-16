'Michael Wynnychuk'
'Programming Advanced'
'Period 2'
'Date Oct.14 2014'

Public Class lblMessage

    Dim SandwichSize, CostOfExtras, Total As Decimal 'Declares a Dim variable and describes it as a decimal.

    Private Sub radSmallSandwich_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radSmallSandwich.Click
        SandwichSize = 0 'Resets Sandwich to zero
        SandwichSize = SandwichSize + 2.5 'Adds 2.5 to the decimal variable SandwichSize
    End Sub

    Private Sub radKargeSandwich_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radLargeSandwich.Click
        SandwichSize = 0 'Resets Sandwich to zero
        SandwichSize = SandwichSize + 4 'Adds 4 to the decimal variable SandwichSize
    End Sub

    Private Sub btnPlaceOrder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlaceOrder.Click
        Total = 0 'Resets Total to zero
        CostOfExtras = 0 'Resets CostOfExtras to zero

        If Me.chkLettuce.Checked = True Then 'Executes if the Lettuce checkbox is checked 
            CostOfExtras = CostOfExtras + 0.1 'Adds 0.1 to CostOfExtras
        End If

        If Me.chkOnion.Checked = True Then 'Executes if the Onion checkbox is checked 
            CostOfExtras = CostOfExtras + 0.1 'Adds 0.1 to CostOfExtras
        End If

        If Me.chkTomato.Checked = True Then 'Executes if the Tomato checkbox is checked 
            CostOfExtras = CostOfExtras + 0.25 'Adds 0.25 to CostOfExtras 
        End If

        If Me.chkCheese.Checked = True Then 'Executes if the Cheese checkbox is checked 
            CostOfExtras = CostOfExtras + 0.5 'Adds 0.5 to CostOfExtras
        End If

        Total = SandwichSize + CostOfExtras 'Adds variables SandwichSize and CostOfExtras for the total.
        Me.lblPrice.Text = Total 'Displays the total cost.
    End Sub
End Class
