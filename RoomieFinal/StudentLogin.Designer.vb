<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.userlbl_std = New System.Windows.Forms.Label()
        Me.studentNumberTxt = New System.Windows.Forms.TextBox()
        Me.lblpw_std = New System.Windows.Forms.Label()
        Me.studentPasswordTxt = New System.Windows.Forms.TextBox()
        Me.forgotpasslbl = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Login"
        '
        'userlbl_std
        '
        Me.userlbl_std.AutoSize = True
        Me.userlbl_std.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userlbl_std.Location = New System.Drawing.Point(173, 77)
        Me.userlbl_std.Name = "userlbl_std"
        Me.userlbl_std.Size = New System.Drawing.Size(126, 20)
        Me.userlbl_std.TabIndex = 1
        Me.userlbl_std.Text = "Student Number"
        '
        'studentNumberTxt
        '
        Me.studentNumberTxt.Location = New System.Drawing.Point(159, 111)
        Me.studentNumberTxt.Name = "studentNumberTxt"
        Me.studentNumberTxt.Size = New System.Drawing.Size(150, 20)
        Me.studentNumberTxt.TabIndex = 2
        '
        'lblpw_std
        '
        Me.lblpw_std.AutoSize = True
        Me.lblpw_std.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpw_std.Location = New System.Drawing.Point(196, 150)
        Me.lblpw_std.Name = "lblpw_std"
        Me.lblpw_std.Size = New System.Drawing.Size(78, 20)
        Me.lblpw_std.TabIndex = 3
        Me.lblpw_std.Text = "Password"
        '
        'studentPasswordTxt
        '
        Me.studentPasswordTxt.Location = New System.Drawing.Point(159, 182)
        Me.studentPasswordTxt.Name = "studentPasswordTxt"
        Me.studentPasswordTxt.Size = New System.Drawing.Size(150, 20)
        Me.studentPasswordTxt.TabIndex = 2
        '
        'forgotpasslbl
        '
        Me.forgotpasslbl.AutoSize = True
        Me.forgotpasslbl.Location = New System.Drawing.Point(156, 214)
        Me.forgotpasslbl.Name = "forgotpasslbl"
        Me.forgotpasslbl.Size = New System.Drawing.Size(92, 13)
        Me.forgotpasslbl.TabIndex = 4
        Me.forgotpasslbl.Text = "Forgot Password?"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(110, 263)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 31)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Register"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(264, 263)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 31)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Login"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkCyan
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(437, 420)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(46, 40)
        Me.Button3.TabIndex = 6
        Me.Button3.UseVisualStyleBackColor = False
        '
        'StudentLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.forgotpasslbl)
        Me.Controls.Add(Me.lblpw_std)
        Me.Controls.Add(Me.studentPasswordTxt)
        Me.Controls.Add(Me.studentNumberTxt)
        Me.Controls.Add(Me.userlbl_std)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StudentLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents userlbl_std As Label
    Friend WithEvents studentNumberTxt As TextBox
    Friend WithEvents lblpw_std As Label
    Friend WithEvents studentPasswordTxt As TextBox
    Friend WithEvents forgotpasslbl As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
