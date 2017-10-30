Public Class Form_Home
    Private Sub btnComponents_Click(sender As Object, e As EventArgs) Handles btnComponents.Click
        Form_Components.Show()
        Me.Close()
    End Sub

    Private Sub btnIO_Click(sender As Object, e As EventArgs) Handles btnIO.Click
        Form_io.Show()
        Me.Close()
    End Sub

    Private Sub btnWeb_Click(sender As Object, e As EventArgs) Handles btnWeb.Click
        Form_Web.Show()
        Me.Close()
    End Sub

    Private Sub btnClass_Click(sender As Object, e As EventArgs) Handles btnClass.Click
        Form_Class.Show()
        Me.Close()
    End Sub
End Class
