<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserRegistration))
        Me.userlbl_std = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StudentNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.YearAndSectionTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ConfirmPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SecurityQuestionComboBox = New System.Windows.Forms.ComboBox()
        Me.SecurityAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'userlbl_std
        '
        Me.userlbl_std.AutoSize = True
        Me.userlbl_std.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userlbl_std.Location = New System.Drawing.Point(221, 23)
        Me.userlbl_std.Name = "userlbl_std"
        Me.userlbl_std.Size = New System.Drawing.Size(51, 20)
        Me.userlbl_std.TabIndex = 3
        Me.userlbl_std.Text = "Name"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(171, 46)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(150, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(184, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Student Number"
        '
        'StudentNumberTextBox
        '
        Me.StudentNumberTextBox.Location = New System.Drawing.Point(171, 92)
        Me.StudentNumberTextBox.Name = "StudentNumberTextBox"
        Me.StudentNumberTextBox.Size = New System.Drawing.Size(150, 20)
        Me.StudentNumberTextBox.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(181, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Year and Section"
        '
        'YearAndSectionTextBox
        '
        Me.YearAndSectionTextBox.Location = New System.Drawing.Point(171, 142)
        Me.YearAndSectionTextBox.Name = "YearAndSectionTextBox"
        Me.YearAndSectionTextBox.Size = New System.Drawing.Size(150, 20)
        Me.YearAndSectionTextBox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(205, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(171, 189)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(150, 20)
        Me.PasswordTextBox.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(179, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Confirm Password"
        '
        'ConfirmPasswordTextBox
        '
        Me.ConfirmPasswordTextBox.Location = New System.Drawing.Point(171, 236)
        Me.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox"
        Me.ConfirmPasswordTextBox.Size = New System.Drawing.Size(150, 20)
        Me.ConfirmPasswordTextBox.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(303, 399)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 31)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(95, 399)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 31)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Register"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(179, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Security Question"
        '
        'SecurityQuestionComboBox
        '
        Me.SecurityQuestionComboBox.FormattingEnabled = True
        Me.SecurityQuestionComboBox.Items.AddRange(New Object() {"What is your mother's maiden name?", "What was the name of your first pet?", "What was the name of the street you grew up on?"})
        Me.SecurityQuestionComboBox.Location = New System.Drawing.Point(109, 282)
        Me.SecurityQuestionComboBox.Name = "SecurityQuestionComboBox"
        Me.SecurityQuestionComboBox.Size = New System.Drawing.Size(276, 21)
        Me.SecurityQuestionComboBox.TabIndex = 7
        '
        'SecurityAnswerTextBox
        '
        Me.SecurityAnswerTextBox.Location = New System.Drawing.Point(109, 309)
        Me.SecurityAnswerTextBox.Name = "SecurityAnswerTextBox"
        Me.SecurityAnswerTextBox.Size = New System.Drawing.Size(276, 20)
        Me.SecurityAnswerTextBox.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkCyan
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.DarkCyan
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(12, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 37)
        Me.Button3.TabIndex = 10
        Me.Button3.UseVisualStyleBackColor = False
        '
        'UserRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.SecurityAnswerTextBox)
        Me.Controls.Add(Me.SecurityQuestionComboBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ConfirmPasswordTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.YearAndSectionTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StudentNumberTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.userlbl_std)
        Me.Name = "UserRegistration"
        Me.Text = "UserRegistration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents userlbl_std As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents StudentNumberTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents YearAndSectionTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ConfirmPasswordTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents SecurityQuestionComboBox As ComboBox
    Friend WithEvents SecurityAnswerTextBox As TextBox
    Friend WithEvents Button3 As Button
End Class
