Public Class StickMan
    Private L As Integer = 37
    Private U As Integer = 38
    Private R As Integer = 39
    Private D As Integer = 40
    Private _steps As Integer = 10
    Public pb As PictureBox


    Public Sub New(ByVal pb As PictureBox)
        Randomize()
        Me.pb = pb
    End Sub

    Public Property Steps As Integer
        Get
            Return _steps
        End Get
        Set(value As Integer)
            _steps = value
        End Set
    End Property

    Public Sub move(ByVal k As Integer)
        Dim loc As Point = New Point(pb.Location.X, pb.Location.Y)
        Select Case k
            Case L
                loc.X -= Steps
            Case U
                loc.Y -= Steps
            Case R
                loc.X += Steps
            Case D
                loc.Y += Steps
        End Select
        pb.Location = loc
    End Sub

    Public Sub randomMove()
        Me.move(CInt(Math.Ceiling(Rnd() * 4)) + 37)
    End Sub

    Public Sub enter()
        pb.BackColor = Color.Azure
    End Sub

    Public Sub leave()
        pb.BackColor = Color.FromName("Control")
    End Sub


End Class
