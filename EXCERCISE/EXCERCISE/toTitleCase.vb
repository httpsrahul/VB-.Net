Imports System.Globalization

Public Class toTitleCase
    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Dim str As String
        str = txtString.Text
        MsgBox(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str))
    End Sub
End Class