Public Class SumOfDigits
    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Dim number As Integer
        Dim reminder As Integer
        Dim Sum As Integer = 0
        number = Val(txtNumber.Text)
        If number <= 0 Then
            MsgBox("Invalid Integer !")
        ElseIf number <> Math.Ceiling(Val(txtNumber.Text)) Then
            MsgBox("Invalid Integer !")
        Else
            While number > 0
                reminder = number Mod 10
                Sum = Sum + reminder
                number = number / 10
            End While
            MsgBox("Sum Of Digir : " & Sum)
        End If
    End Sub
End Class