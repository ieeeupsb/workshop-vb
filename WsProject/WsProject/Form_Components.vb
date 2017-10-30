Public Class Form_Components
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form_Home.Show()
        Me.Close()
    End Sub

    Private Sub cbShowLabel_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowLabel.CheckedChanged
        lblToHide.Visible = cbShowLabel.Checked()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        If cbType.SelectedIndex < 0 Then
            MsgBox("Please Select a Text Type Before printing")
        Else
            MsgBox(cbType.SelectedItem & vbCrLf & vbCrLf & tbLorem.Text)
        End If

    End Sub
End Class