<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogin
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
        Me.adminloginlbl = New System.Windows.Forms.Label()
        Me.userlbl_std = New System.Windows.Forms.Label()
        Me.adminUsernameTxt = New System.Windows.Forms.TextBox()
        Me.passwordtxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'adminloginlbl
        '
        Me.adminloginlbl.AutoSize = True
        Me.adminloginlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminloginlbl.Location = New System.Drawing.Point(173, 48)
        Me.adminloginlbl.Name = "adminloginlbl"
        Me.adminloginlbl.Size = New System.Drawing.Size(128, 24)
        Me.adminloginlbl.TabIndex = 1
        Me.adminloginlbl.Text = "Admin Login"
        '
        'userlbl_std
        '
        Me.userlbl_std.AutoSize = True
        Me.userlbl_std.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userlbl_std.Location = New System.Drawing.Point(192, 96)
        Me.userlbl_std.Name = "userlbl_std"
        Me.userlbl_std.Size = New System.Drawing.Size(83, 20)
        Me.userlbl_std.TabIndex = 2
        Me.userlbl_std.Text = "Username"
        '
        'adminUsernameTxt
        '
        Me.adminUsernameTxt.Location = New System.Drawing.Point(161, 132)
        Me.adminUsernameTxt.Name = "adminUsernameTxt"
        Me.adminUsernameTxt.Size = New System.Drawing.Size(150, 20)
        Me.adminUsernameTxt.TabIndex = 3
        '
        'passwordtxt
        '
        Me.passwordtxt.Location = New System.Drawing.Point(161, 207)
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.Size = New System.Drawing.Size(150, 20)
        Me.passwordtxt.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = " Password"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(183, 285)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 31)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Login"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AdminLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.passwordtxt)
        Me.Controls.Add(Me.adminUsernameTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.userlbl_std)
        Me.Controls.Add(Me.adminloginlbl)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "AdminLogin"
        Me.Text = "AdminLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents adminloginlbl As Label
    Friend WithEvents userlbl_std As Label
    Friend WithEvents adminUsernameTxt As TextBox
    Friend WithEvents passwordtxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
End Class
