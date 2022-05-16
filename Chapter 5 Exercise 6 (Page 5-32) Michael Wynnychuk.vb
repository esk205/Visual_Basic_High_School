'Michael Wynnychuk'
'Programming Advanced'
'Period 2'
'Date Oct.7 2014'

Public Class lblMessage

    Dim ModelNumber As Integer

    Private Sub btnEvaluateCar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEvaluateCar.Click
        ModelNumber = Val(txtModelNumber.Text)

        If ModelNumber = 119 Then
            Me.lblConditionOfCar.Text = "Your car is defective. Please have it fixed."

        ElseIf ModelNumber = 179 Then
            Me.lblConditionOfCar.Text = "Your car is defective. Please have it fixed."

        ElseIf ModelNumber = 189 Then
            Me.lblConditionOfCar.Text = "Your car is defective. Please have it fixed."

        ElseIf ModelNumber = 195 Then
            Me.lblConditionOfCar.Text = "Your car is defective. Please have it fixed."

        ElseIf ModelNumber = 221 Then
            Me.lblConditionOfCar.Text = "Your car is defective. Please have it fixed."

        ElseIf ModelNumber = 780 Then
            Me.lblConditionOfCar.Text = "Your car is defective. Please have it fixed."

        Else
            Me.lblConditionOfCar.Text = "Your car is not defective."

        End If
    End Sub
End Class
