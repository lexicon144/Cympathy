<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScheduleCreator
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
        Me.btnCreateSchedule = New System.Windows.Forms.Button()
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBrowseDays = New System.Windows.Forms.Button()
        Me.btnBrowseTime = New System.Windows.Forms.Button()
        Me.btnBrowseClassroom = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtClassroom = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCreateSchedule
        '
        Me.btnCreateSchedule.Location = New System.Drawing.Point(172, 130)
        Me.btnCreateSchedule.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCreateSchedule.Name = "btnCreateSchedule"
        Me.btnCreateSchedule.Size = New System.Drawing.Size(160, 28)
        Me.btnCreateSchedule.TabIndex = 6
        Me.btnCreateSchedule.Text = "Create Schedule"
        Me.btnCreateSchedule.UseVisualStyleBackColor = True
        '
        'txtDay
        '
        Me.txtDay.Location = New System.Drawing.Point(340, 59)
        Me.txtDay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.ReadOnly = True
        Me.txtDay.Size = New System.Drawing.Size(159, 22)
        Me.txtDay.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(336, 39)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Day"
        '
        'btnBrowseDays
        '
        Me.btnBrowseDays.Location = New System.Drawing.Point(340, 4)
        Me.btnBrowseDays.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBrowseDays.Name = "btnBrowseDays"
        Me.btnBrowseDays.Size = New System.Drawing.Size(160, 28)
        Me.btnBrowseDays.TabIndex = 10
        Me.btnBrowseDays.Text = "Browse Days"
        Me.btnBrowseDays.UseVisualStyleBackColor = True
        '
        'btnBrowseTime
        '
        Me.btnBrowseTime.Location = New System.Drawing.Point(172, 4)
        Me.btnBrowseTime.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBrowseTime.Name = "btnBrowseTime"
        Me.btnBrowseTime.Size = New System.Drawing.Size(160, 28)
        Me.btnBrowseTime.TabIndex = 16
        Me.btnBrowseTime.Text = "Browse Time"
        Me.btnBrowseTime.UseVisualStyleBackColor = True
        '
        'btnBrowseClassroom
        '
        Me.btnBrowseClassroom.Location = New System.Drawing.Point(4, 4)
        Me.btnBrowseClassroom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBrowseClassroom.Name = "btnBrowseClassroom"
        Me.btnBrowseClassroom.Size = New System.Drawing.Size(160, 28)
        Me.btnBrowseClassroom.TabIndex = 15
        Me.btnBrowseClassroom.Text = "Browse Classroom"
        Me.btnBrowseClassroom.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(168, 36)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 36)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Classroom"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(172, 59)
        Me.txtTime.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(159, 22)
        Me.txtTime.TabIndex = 12
        '
        'txtClassroom
        '
        Me.txtClassroom.Location = New System.Drawing.Point(4, 59)
        Me.txtClassroom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtClassroom.Name = "txtClassroom"
        Me.txtClassroom.ReadOnly = True
        Me.txtClassroom.Size = New System.Drawing.Size(159, 22)
        Me.txtClassroom.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnBrowseClassroom)
        Me.Panel1.Controls.Add(Me.btnCreateSchedule)
        Me.Panel1.Controls.Add(Me.btnBrowseTime)
        Me.Panel1.Controls.Add(Me.txtDay)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnBrowseDays)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtClassroom)
        Me.Panel1.Controls.Add(Me.txtTime)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 158)
        Me.Panel1.TabIndex = 17
        '
        'frmScheduleCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 186)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmScheduleCreator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmScheduleCreator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCreateSchedule As System.Windows.Forms.Button
    Friend WithEvents txtDay As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBrowseDays As System.Windows.Forms.Button
    Friend WithEvents btnBrowseTime As System.Windows.Forms.Button
    Friend WithEvents btnBrowseClassroom As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents txtClassroom As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
