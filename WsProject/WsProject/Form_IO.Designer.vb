<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_io
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.fd = New System.Windows.Forms.OpenFileDialog()
        Me.btn_file = New System.Windows.Forms.Button()
        Me.tbContent = New System.Windows.Forms.TextBox()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(12, 14)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(164, 53)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(5)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(5)
        Me.lblTitle.Size = New System.Drawing.Size(933, 67)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "Input/Output"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fd
        '
        Me.fd.FileName = "fd_choose"
        Me.fd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'btn_file
        '
        Me.btn_file.BackColor = System.Drawing.Color.Black
        Me.btn_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_file.Location = New System.Drawing.Point(12, 75)
        Me.btn_file.Name = "btn_file"
        Me.btn_file.Size = New System.Drawing.Size(109, 46)
        Me.btn_file.TabIndex = 10
        Me.btn_file.Text = "Choose File"
        Me.btn_file.UseVisualStyleBackColor = False
        '
        'tbContent
        '
        Me.tbContent.AcceptsTab = True
        Me.tbContent.BackColor = System.Drawing.Color.Black
        Me.tbContent.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tbContent.Enabled = False
        Me.tbContent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbContent.ForeColor = System.Drawing.Color.Goldenrod
        Me.tbContent.Location = New System.Drawing.Point(0, 142)
        Me.tbContent.Margin = New System.Windows.Forms.Padding(10)
        Me.tbContent.Multiline = True
        Me.tbContent.Name = "tbContent"
        Me.tbContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbContent.Size = New System.Drawing.Size(933, 307)
        Me.tbContent.TabIndex = 11
        Me.tbContent.Text = "File Contents Go Here"
        '
        'lblFile
        '
        Me.lblFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFile.Location = New System.Drawing.Point(156, 75)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(765, 46)
        Me.lblFile.TabIndex = 12
        Me.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form_io
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(933, 449)
        Me.Controls.Add(Me.lblFile)
        Me.Controls.Add(Me.tbContent)
        Me.Controls.Add(Me.btn_file)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblTitle)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form_io"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input/Output"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents fd As OpenFileDialog
    Friend WithEvents btn_file As Button
    Friend WithEvents tbContent As TextBox
    Friend WithEvents lblFile As Label
End Class
