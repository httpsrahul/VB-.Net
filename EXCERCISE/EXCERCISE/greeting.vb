Public Class greeting

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        If radioMale.Checked Then
            MsgBox("Hello Mr." & txtString.Text)
        Else
            MsgBox("Hello Ms." & txtString.Text)
        End If
    End Sub
End Class