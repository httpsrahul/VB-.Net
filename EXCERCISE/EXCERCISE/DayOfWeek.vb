Public Class DayOfWeek

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Dim i As Integer
        i = Val(txtNumber.Text)
        Select Case i
            Case 1
                MsgBox("Have A Nice Monday")
            Case 2
                MsgBox("Have A Nice Tuesday")
            Case 3
                MsgBox("Have A Nice Wednesday")
            Case 4
                MsgBox("Have A Nice Thursday")
            Case 5
                MsgBox("Have A Nice Friday")
            Case 6
                MsgBox("Have A Nice Saturday")
            Case 7
                MsgBox("Have A Nice Sunday")
            Case Else
                MsgBox("Invalid Choice !")
        End Select
    End Sub
End Class