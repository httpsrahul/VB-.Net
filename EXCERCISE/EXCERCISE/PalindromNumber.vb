Public Class PalindromNumber

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Dim number As Integer
        Dim reminder As Integer
        Dim reverse As Integer = 0
        number = Val(txtNumber.Text)
        If number <= 0 Then
            MsgBox("Invalid Integer !")
        ElseIf number <> Math.Ceiling(Val(txtNumber.Text)) Then
            MsgBox("Invalid Integer !")
        Else
            While number > 0
                reminder = number Mod 10
                reverse = reverse * 10 + reminder
                number = number / 10
            End While
            If reverse = Val(txtNumber.Text) Then
                MsgBox("Yes, It's Palindrome Number !")
            Else
                MsgBox("No,It's Not Palindrome Number !")
            End If
        End If
    End Sub
End Class