Public Class Form_io
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form_Home.Show()
        Me.Close()
    End Sub

    Private Sub btn_file_Click(sender As Object, e As EventArgs) Handles btn_file.Click
        If fd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                ' Read entire contents of file into an array.
                Dim contents = System.IO.File.ReadAllText(fd.FileName)
                tbContent.Text = contents
                tbContent.Enabled = True ' enable the textbox
                lblFile.Text = "File: " & fd.FileName
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            End Try
        End If
    End Sub

    Private Sub tbContent_TextChanged(sender As Object, e As EventArgs) Handles tbContent.TextChanged
        My.Computer.FileSystem.WriteAllText(fd.FileName, tbContent.Text, False)
    End Sub
End Class