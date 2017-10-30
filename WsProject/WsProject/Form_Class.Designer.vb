<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Class
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Class))
        Me.pb = New System.Windows.Forms.PictureBox()
        Me.tbSteps = New System.Windows.Forms.TrackBar()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSteps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb
        '
        Me.pb.BackgroundImage = CType(resources.GetObject("pb.BackgroundImage"), System.Drawing.Image)
        Me.pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pb.Image = CType(resources.GetObject("pb.Image"), System.Drawing.Image)
        Me.pb.InitialImage = CType(resources.GetObject("pb.InitialImage"), System.Drawing.Image)
        Me.pb.Location = New System.Drawing.Point(373, 186)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(100, 100)
        Me.pb.TabIndex = 0
        Me.pb.TabStop = False
        '
        'tbSteps
        '
        Me.tbSteps.Location = New System.Drawing.Point(12, 538)
        Me.tbSteps.Maximum = 100
        Me.tbSteps.Minimum = 1
        Me.tbSteps.Name = "tbSteps"
        Me.tbSteps.Size = New System.Drawing.Size(299, 56)
        Me.tbSteps.TabIndex = 1
        Me.tbSteps.Value = 1
        '
        'Form_Class
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 606)
        Me.Controls.Add(Me.tbSteps)
        Me.Controls.Add(Me.pb)
        Me.Name = "Form_Class"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Class"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSteps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb As PictureBox
    Friend WithEvents tbSteps As TrackBar
End Class
