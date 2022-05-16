'Michael Wynnychuk'
'Programming Advanced'
'Period 2'
'Date Sept.15 2014'

Public Class lblMessage

    Private Sub btnAnswer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCelsiusConversion.Click
        Dim sngFahrenheit, sngConversion As Single 'Declares the Dimension (Dim) variable and one of them equals 6'
        sngFahrenheit = Val(Me.txtTemperature.Text) 'The value entered in the textbox for radius will be used later."

        Me.lblCelsius.Text = "The temperature in Celsius is: "
        sngConversion = (5 / 9) * (sngFahrenheit - 32) 'Assigns variable to have values to a circles area.
        Me.lblCelsius.Text = sngConversion 'Display Answer'
    End Sub

    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        End
    End Sub

    Private Sub txtRadius_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTemperature.TextChanged
        Me.lblCelsius.Text = ""
    End Sub

End Class
