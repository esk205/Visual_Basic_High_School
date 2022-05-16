'Michael Wynnychuk'
'Programming Advanced'
'Period 2'
'Date Sept.8 2014

Public Class lblMessage

    

    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub lblCity_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblCity.Click
        Me.lblCity.Text = ("Red Deer")
    End Sub

    Private Sub lblName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblName.Click
        Me.lblName.Text = ("Michael Wynnychuk")
    End Sub

    Private Sub lblProvince_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblProvince.Click
        Me.lblProvince.Text = ("Alberta")
    End Sub
End Class
