<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminStudentSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminStudentSearch))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nametxt = New System.Windows.Forms.TextBox()
        Me.yrandsctxt = New System.Windows.Forms.TextBox()
        Me.studentnotxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Year and Section:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Student Number:"
        '
        'nametxt
        '
        Me.nametxt.Location = New System.Drawing.Point(72, 35)
        Me.nametxt.Name = "nametxt"
        Me.nametxt.Size = New System.Drawing.Size(207, 20)
        Me.nametxt.TabIndex = 11
        '
        'yrandsctxt
        '
        Me.yrandsctxt.Location = New System.Drawing.Point(149, 60)
        Me.yrandsctxt.Name = "yrandsctxt"
        Me.yrandsctxt.Size = New System.Drawing.Size(130, 20)
        Me.yrandsctxt.TabIndex = 12
        '
        'studentnotxt
        '
        Me.studentnotxt.Location = New System.Drawing.Point(141, 87)
        Me.studentnotxt.Name = "studentnotxt"
        Me.studentnotxt.Size = New System.Drawing.Size(138, 20)
        Me.studentnotxt.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(26, 137)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Edit Info"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(186, 137)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Delete User"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(100, 166)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(81, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Edit Schedule"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkCyan
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.DarkCyan
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(-2, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(29, 32)
        Me.Button4.TabIndex = 15
        Me.Button4.UseVisualStyleBackColor = False
        '
        'AdminStudentSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(291, 211)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.studentnotxt)
        Me.Controls.Add(Me.yrandsctxt)
        Me.Controls.Add(Me.nametxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Name = "AdminStudentSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminStudentSearch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents nametxt As TextBox
    Friend WithEvents yrandsctxt As TextBox
    Friend WithEvents studentnotxt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
