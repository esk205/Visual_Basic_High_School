'Michael Wynnychuk'
'Programming Advanced'
'Period 2'
'Date Sept.9 2014

Public Class lblMessage

    Private Sub btnLethCC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLethCC.Click
        Me.lblStreetAvenue.Text = "3000 College Drive S"
        Me.lblCity.Text = "City: Lethbridge"
        Me.lblAreaCode.Text = "AB T1K 1L6"
    End Sub

    Private Sub btnUOA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUOA.Click
        Me.lblStreetAvenue.Text = "116 St and 85 Ave"
        Me.lblCity.Text = "City: Edmonton"
        Me.lblAreaCode.Text = "AB T6G 2R3"
    End Sub

    Private Sub btnRDC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRDC.Click
        Me.lblStreetAvenue.Text = "100 College Blvd"
        Me.lblCity.Text = "City: Red Deer"
        Me.lblAreaCode.Text = "AB T4N 5H5"
    End Sub

    Private Sub btnLethUniversity_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLethUniversity.Click
        Me.lblStreetAvenue.Text = "4401 University Dr W"
        Me.lblCity.Text = "City: Lethbridge"
        Me.lblAreaCode.Text = "AB T1K 3M4"
    End Sub

    Private Sub btnUOC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUOC.Click, RadioButton1.Click
        Me.lblStreetAvenue.Text = "2500 University Dr NW"
        Me.lblCity.Text = "City: Calgary"
        Me.lblAreaCode.Text = "AB T2N 1N4"
    End Sub

End Class
