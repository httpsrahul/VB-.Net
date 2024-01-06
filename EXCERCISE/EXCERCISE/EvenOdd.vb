Public Class EvenOdd
    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Dim number As Integer
        number = Val(txtNumber.Text)
        If number = 0 And txtNumber.Text <> "0" Then
            MsgBox("Invalid Integer")
        ElseIf number > 0 And number <> Math.Ceiling(Val(txtNumber.Text)) Then
            MsgBox("Invalid Integer")
        ElseIf number < 0 And number <> Math.Floor(Val(txtNumber.Text)) Then
            MsgBox("Invalid Integer")
        ElseIf number = 0 Then
            MsgBox("Number Is Zero")
        ElseIf number Mod 2 = 0 Then
            MsgBox("Number Is Even")
        Else
            MsgBox("Number Is Odd")
        End If
    End Sub
End Class
