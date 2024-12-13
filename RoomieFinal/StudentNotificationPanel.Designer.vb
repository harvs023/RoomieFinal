<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentNotificationPanel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentNotificationPanel))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Sectionlbl = New System.Windows.Forms.Label()
        Me.Namelbl = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(194, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(383, 367)
        Me.Panel2.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel3.Location = New System.Drawing.Point(12, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(368, 100)
        Me.Panel3.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(160, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Label4"
        '
        'Sectionlbl
        '
        Me.Sectionlbl.AutoSize = True
        Me.Sectionlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sectionlbl.Location = New System.Drawing.Point(47, 32)
        Me.Sectionlbl.Name = "Sectionlbl"
        Me.Sectionlbl.Size = New System.Drawing.Size(43, 13)
        Me.Sectionlbl.TabIndex = 12
        Me.Sectionlbl.Text = "Section"
        '
        'Namelbl
        '
        Me.Namelbl.AutoSize = True
        Me.Namelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Namelbl.Location = New System.Drawing.Point(47, 16)
        Me.Namelbl.Name = "Namelbl"
        Me.Namelbl.Size = New System.Drawing.Size(49, 16)
        Me.Namelbl.TabIndex = 11
        Me.Namelbl.Text = "Name"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkCyan
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.DarkCyan
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(10, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 38)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.WindowText
        Me.Panel1.Location = New System.Drawing.Point(187, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 471)
        Me.Panel1.TabIndex = 13
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkCyan
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.DarkCyan
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(194, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 37)
        Me.Button2.TabIndex = 14
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(298, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 24)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Notifications"
        '
        'StudentNotificationPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(589, 461)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Sectionlbl)
        Me.Controls.Add(Me.Namelbl)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "StudentNotificationPanel"
        Me.Text = "StudentNotificationPanel"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Sectionlbl As Label
    Friend WithEvents Namelbl As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
End Class
