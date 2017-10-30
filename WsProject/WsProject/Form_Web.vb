Imports System.Text.RegularExpressions
Public Class Form_Web
    Private baseUrl As String = "https://sigarra.up.pt/feup/en/func_geral.formview?p_codigo="
    Private imgUrl As String = "https://sigarra.up.pt/feup/en/FOTOGRAFIAS_SERVICE.foto?pct_cod="
    Private Sub btnSearchTeacher_Click(sender As Object, e As EventArgs) Handles btnSearchTeacher.Click
        'validate the id
        If tbId.Text = "" Then
            MsgBox("Teacher's id cannot be blank")
            Return
        End If
        'fill the form
        Dim id As String = getId(tbId.Text)
        Dim html As String = getRequest(baseUrl & id)
        lblName.Text = getNameFromSigarra(html)
        displayImage(pbProfile, imgUrl & id)
    End Sub


    Function getId(ByVal original As String) As String
        If Mid(original, 1, 2).ToLower() = "up" Then
            original = Mid(original, 3)
        End If
        Return original
    End Function

    Function getRequest(ByVal url As String) As String
        Dim webClient As New System.Net.WebClient
        Return webClient.DownloadString(url)
    End Function

    Function getNameFromSigarra(ByRef html As String) As String
        'rudimentary way of doing this
        Dim index As Integer = html.IndexOf("<td class=""formulario-legenda"">Name:</td>")
        If index = -1 Then
            Return "Not Found"
        End If
        Dim nameIsHere As String = Mid(html, index, 200)
        Dim nameRegex As String = "<b>(.*)</b>"
        Dim tempName As String = regexFirstMatch(nameIsHere, nameRegex)
        Return tempName.Replace("<b>", "").Replace("</b>", "")
    End Function

    Function regexFirstMatch(ByRef text As String, ByVal rg As String) As String
        Dim mc As MatchCollection = Regex.Matches(text, rg)
        If mc.Count Then
            Return mc(0).ToString()
        End If
        Return "Not Found"
    End Function

    Function displayImage(ByRef pc As PictureBox, ByVal url As String)
        Using wc As New System.Net.WebClient()
            Try
                pc.Image = Image.FromStream(wc.OpenRead(url))
            Catch ex As Exception
                MsgBox("Unable to download picture")
            End Try
        End Using
        Return Nothing
    End Function

End Class