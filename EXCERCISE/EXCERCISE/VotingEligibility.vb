Public Class VotingEligibility

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Dim currentDate As DateTime = DateTime.Now
        Dim Age As TimeSpan = currentDate - dtpDOB.Value
        If ((Age.Days / 365) >= 18) Then
            MsgBox("Yes, You Can Vote !")
        Else
            MsgBox("No, You Can Not Vote")
        End If
    End Sub
End Class