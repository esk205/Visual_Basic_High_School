'Michael Wynnychuk'
'Programming Advanced'
'Period 2'
'Date Oct.23 2014'

' The Prime Number program will determine whatever number the user inputs 
' to be or not to be a prime number. A message box will prompt the user
' and notify whether not the number is prime or not.

Public Class lblMessage

    Dim TestNumber = 0, Divisor = 1

    Private Sub btnTest_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTest.Click

        TestNumber = (Me.txtTestNumber.Text)
        Divisor = 1

        If TestNumber <= 1 Then
            MessageBox.Show("This number is not a prime number!")

        Else
            Do
                Divisor = Divisor + 1
            Loop While TestNumber Mod Divisor <> 0
        End If

        If Divisor = TestNumber And TestNumber <> 1 Then
            MessageBox.Show("This number is a prime number!")

        ElseIf TestNumber <> 1 Then
            MessageBox.Show("This number is not a prime number!")

        End If
    End Sub
End Class
