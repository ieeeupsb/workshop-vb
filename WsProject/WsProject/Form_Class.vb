Public Class Form_Class
    Public sman As StickMan
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

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles tbSteps.Scroll
        sman.Steps = tbSteps.Value
    End Sub

    Private Sub tbSteps_KeyDown(sender As Object, e As KeyEventArgs) Handles tbSteps.KeyDown
        handleKey(e.KeyCode)
    End Sub

    Public Sub handleKey(ByVal k As Integer)
        If k = 32 Then
            sman.randomMove()
        Else
            sman.move(k)
        End If
    End Sub
End Class