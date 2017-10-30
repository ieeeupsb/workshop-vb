<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Home
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
        Me.btnComponents = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnIO = New System.Windows.Forms.Button()
        Me.btnWeb = New System.Windows.Forms.Button()
        Me.btnClass = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnComponents
        '
        Me.btnComponents.BackColor = System.Drawing.Color.Black
        Me.btnComponents.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnComponents.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnComponents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComponents.Font = New System.Drawing.Font("Consolas", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComponents.ForeColor = System.Drawing.Color.White
        Me.btnComponents.Location = New System.Drawing.Point(86, 137)
        Me.btnComponents.Name = "btnComponents"
        Me.btnComponents.Size = New System.Drawing.Size(196, 97)
        Me.btnComponents.TabIndex = 0
        Me.btnComponents.Text = "Components"
        Me.btnComponents.UseVisualStyleBackColor = False
        '
        'lblWelcome
        '
        Me.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(0, 0)
        Me.lblWelcome.Margin = New System.Windows.Forms.Padding(5)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Padding = New System.Windows.Forms.Padding(5)
        Me.lblWelcome.Size = New System.Drawing.Size(1152, 67)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome to the Workshop Project"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnIO
        '
        Me.btnIO.BackColor = System.Drawing.Color.Black
        Me.btnIO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIO.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIO.Font = New System.Drawing.Font("Consolas", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIO.ForeColor = System.Drawing.Color.White
        Me.btnIO.Location = New System.Drawing.Point(347, 137)
        Me.btnIO.Name = "btnIO"
        Me.btnIO.Size = New System.Drawing.Size(196, 97)
        Me.btnIO.TabIndex = 2
        Me.btnIO.Text = "I/O"
        Me.btnIO.UseVisualStyleBackColor = False
        '
        'btnWeb
        '
        Me.btnWeb.BackColor = System.Drawing.Color.Black
        Me.btnWeb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWeb.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWeb.Font = New System.Drawing.Font("Consolas", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeb.ForeColor = System.Drawing.Color.White
        Me.btnWeb.Location = New System.Drawing.Point(599, 137)
        Me.btnWeb.Name = "btnWeb"
        Me.btnWeb.Size = New System.Drawing.Size(196, 97)
        Me.btnWeb.TabIndex = 3
        Me.btnWeb.Text = "Web"
        Me.btnWeb.UseVisualStyleBackColor = False
        '
        'btnClass
        '
        Me.btnClass.BackColor = System.Drawing.Color.Black
        Me.btnClass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClass.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClass.Font = New System.Drawing.Font("Consolas", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClass.ForeColor = System.Drawing.Color.White
        Me.btnClass.Location = New System.Drawing.Point(852, 137)
        Me.btnClass.Name = "btnClass"
        Me.btnClass.Size = New System.Drawing.Size(196, 97)
        Me.btnClass.TabIndex = 4
        Me.btnClass.Text = "Class"
        Me.btnClass.UseVisualStyleBackColor = False
        '
        'Form_Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1152, 382)
        Me.Controls.Add(Me.btnClass)
        Me.Controls.Add(Me.btnWeb)
        Me.Controls.Add(Me.btnIO)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnComponents)
        Me.Name = "Form_Home"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnComponents As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnIO As Button
    Friend WithEvents btnWeb As Button
    Friend WithEvents btnClass As Button
End Class
