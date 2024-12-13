<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentDashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.studentName = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.studentScheduleTable = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.stdUpcomingData = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.studentScheduleTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.stdUpcomingData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.studentName)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(881, 56)
        Me.Panel1.TabIndex = 0
        '
        'studentName
        '
        Me.studentName.AutoSize = True
        Me.studentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentName.Location = New System.Drawing.Point(9, 16)
        Me.studentName.Name = "studentName"
        Me.studentName.Size = New System.Drawing.Size(65, 24)
        Me.studentName.TabIndex = 3
        Me.studentName.Text = "Name"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkCyan
        Me.Button4.Location = New System.Drawing.Point(764, 17)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(64, 31)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Events"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(554, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(46, 40)
        Me.Button6.TabIndex = 8
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkCyan
        Me.Button2.Location = New System.Drawing.Point(644, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 31)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Room Information"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(592, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 40)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(833, 16)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(39, 34)
        Me.Button5.TabIndex = 7
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(391, 15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(46, 40)
        Me.Button3.TabIndex = 7
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.studentScheduleTable)
        Me.Panel2.Location = New System.Drawing.Point(3, 90)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(664, 359)
        Me.Panel2.TabIndex = 1
        '
        'studentScheduleTable
        '
        Me.studentScheduleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.studentScheduleTable.Location = New System.Drawing.Point(6, 6)
        Me.studentScheduleTable.Name = "studentScheduleTable"
        Me.studentScheduleTable.ReadOnly = True
        Me.studentScheduleTable.Size = New System.Drawing.Size(655, 353)
        Me.studentScheduleTable.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.stdUpcomingData)
        Me.Panel3.Location = New System.Drawing.Point(673, 78)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(211, 371)
        Me.Panel3.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(316, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Schedule"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(715, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Upcoming Classes"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(1, 61)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "ADD"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'stdUpcomingData
        '
        Me.stdUpcomingData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.stdUpcomingData.Location = New System.Drawing.Point(3, 3)
        Me.stdUpcomingData.Name = "stdUpcomingData"
        Me.stdUpcomingData.Size = New System.Drawing.Size(205, 365)
        Me.stdUpcomingData.TabIndex = 0
        '
        'StudentDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(887, 461)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "StudentDashboard"
        Me.Text = "StudentDashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.studentScheduleTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.stdUpcomingData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents studentName As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents studentScheduleTable As DataGridView
    Friend WithEvents Button7 As Button
    Friend WithEvents stdUpcomingData As DataGridView
End Class
