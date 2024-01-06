Public Class Factorial
    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Dim factorial As Integer = 1
        Dim number As Integer
        Dim i As Integer
        number = Val(txtNumber.Text)
        If number <= 0 Then
            MsgBox("Invalid Integer")
        ElseIf number <> Math.Ceiling(Val(txtNumber.Text)) Then
            MsgBox("Invalid Integer")
        Else
            i = 1
            While i <= number
                factorial *= i
                i += 1
            End While
            MsgBox("Factorial : " & factorial)
        End If
    End Sub
End Class