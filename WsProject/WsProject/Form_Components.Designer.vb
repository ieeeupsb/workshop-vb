<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Components
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
        Me.cbShowLabel = New System.Windows.Forms.CheckBox()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.lblToHide = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbLorem = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbShowLabel
        '
        Me.cbShowLabel.AutoSize = True
        Me.cbShowLabel.Checked = True
        Me.cbShowLabel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbShowLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbShowLabel.Location = New System.Drawing.Point(39, 68)
        Me.cbShowLabel.Name = "cbShowLabel"
        Me.cbShowLabel.Size = New System.Drawing.Size(137, 29)
        Me.cbShowLabel.TabIndex = 0
        Me.cbShowLabel.Text = "Show Label"
        Me.cbShowLabel.UseVisualStyleBackColor = True
        '
        'cbType
        '
        Me.cbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"Essay", "Article", "Paragraph", "Poetry"})
        Me.cbType.Location = New System.Drawing.Point(39, 128)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(293, 33)
        Me.cbType.TabIndex = 1
        Me.cbType.Text = "Text Type"
        '
        'lblToHide
        '
        Me.lblToHide.AutoSize = True
        Me.lblToHide.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToHide.Location = New System.Drawing.Point(566, 72)
        Me.lblToHide.Name = "lblToHide"
        Me.lblToHide.Size = New System.Drawing.Size(134, 25)
        Me.lblToHide.TabIndex = 2
        Me.lblToHide.Text = "Label To Hide"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDisplay)
        Me.GroupBox1.Controls.Add(Me.tbLorem)
        Me.GroupBox1.Controls.Add(Me.cbShowLabel)
        Me.GroupBox1.Controls.Add(Me.lblToHide)
        Me.GroupBox1.Controls.Add(Me.cbType)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(58, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(821, 350)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Group Box"
        '
        'tbLorem
        '
        Me.tbLorem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLorem.Location = New System.Drawing.Point(338, 128)
        Me.tbLorem.Multiline = True
        Me.tbLorem.Name = "tbLorem"
        Me.tbLorem.Size = New System.Drawing.Size(438, 147)
        Me.tbLorem.TabIndex = 3
        Me.tbLorem.Text = "Write Something Here To Display"
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.Black
        Me.btnDisplay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDisplay.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisplay.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.ForeColor = System.Drawing.Color.White
        Me.btnDisplay.Location = New System.Drawing.Point(39, 167)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(293, 39)
        Me.btnDisplay.TabIndex = 5
        Me.btnDisplay.Text = "Display Text"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(58, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(164, 53)
        Me.btnBack.TabIndex = 6
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
        Me.lblTitle.Size = New System.Drawing.Size(950, 67)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "Components"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form_Components
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(950, 548)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form_Components"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Components"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbShowLabel As CheckBox
    Friend WithEvents cbType As ComboBox
    Friend WithEvents lblToHide As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbLorem As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblTitle As Label
End Class
