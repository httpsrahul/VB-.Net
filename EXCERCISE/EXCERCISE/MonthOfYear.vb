Public Class MonthOfYear
    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Dim month As Integer
        month = Val(txtNumber.Text)
        Select Case month
            Case 1
                MsgBox("Month : January!")
            Case 2
                MsgBox("Month : February!")
            Case 3
                MsgBox("Month : March!")
            Case 4
                MsgBox("Month : April!")
            Case 5
                MsgBox("Month : May!")
            Case 6
                MsgBox("Month : June!")
            Case 7
                MsgBox("Month : July!")
            Case 8
                MsgBox("Month : August!")
            Case 9
                MsgBox("Month : September!")
            Case 10
                MsgBox("Month : October!")
            Case 11
                MsgBox("Month : November!")
            Case 12
                MsgBox("Month : December!")
            Case Else
                MsgBox("Invalid Choice !")
        End Select
    End Sub
End Class