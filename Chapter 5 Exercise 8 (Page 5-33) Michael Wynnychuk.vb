'Michael Wynnychuk'
'Programming Advanced'
'Period 2'
'Date Oct.9 2014'

Public Class lblMessage

    Dim BaseCost = 25, ExtraCost = 0, Total As Decimal

    Private Sub btnCalculate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        ExtraCost = 0

        If Me.chkCallerID.Checked = True Then
            ExtraCost = ExtraCost + 3.5
        End If

        If Me.chkCallForwarding.Checked = True Then
            ExtraCost = ExtraCost + 3.5
        End If

        If Me.chkCallWaiting.Checked = True Then
            ExtraCost = ExtraCost + 3.5
        End If

        Total = BaseCost + ExtraCost
        Me.lblCost.Text = Total
        Me.lblTotal.Text = ExtraCost

    End Sub
End Class
