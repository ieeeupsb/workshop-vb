Public Class Form_Class
    Public sman As StickMan
    Private Space As Integer = 32
    Private Plus As Integer = 187
    Private Minus As Integer = 189
    Private Sub Form_Class_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        handleKey(e.KeyCode)
    End Sub

    Private Sub pb_MouseEnter(sender As Object, e As EventArgs) Handles pb.MouseEnter
        sman.leave()
    End Sub

    Private Sub pb_MouseLeave(sender As Object, e As EventArgs) Handles pb.MouseLeave
        sman.enter()
    End Sub

    Private Sub Form_Class_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sman = New StickMan(pb)
    End Sub

    Public Sub handleKey(ByVal k As Integer)
        If k = Space Then
            sman.randomMove()
        ElseIf k = Plus Then
            sman.accelarate()
        ElseIf k = Minus Then
            sman.decelarate()
        Else
            sman.move(k)
        End If
    End Sub
End Class