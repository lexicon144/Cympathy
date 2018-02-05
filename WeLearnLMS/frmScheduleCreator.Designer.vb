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
        Me.SuspendLayout()
        '
        'btnCreateSchedule
        '
        Me.btnCreateSchedule.Location = New System.Drawing.Point(138, 123)
        Me.btnCreateSchedule.Name = "btnCreateSchedule"
        Me.btnCreateSchedule.Size = New System.Drawing.Size(120, 23)
        Me.btnCreateSchedule.TabIndex = 6
        Me.btnCreateSchedule.Text = "Create Schedule"
        Me.btnCreateSchedule.UseVisualStyleBackColor = True
        '
        'txtDay
        '
        Me.txtDay.Location = New System.Drawing.Point(264, 57)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.ReadOnly = True
        Me.txtDay.Size = New System.Drawing.Size(120, 20)
        Me.txtDay.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(261, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Day"
        '
        'btnBrowseDays
        '
        Me.btnBrowseDays.Location = New System.Drawing.Point(264, 12)
        Me.btnBrowseDays.Name = "btnBrowseDays"
        Me.btnBrowseDays.Size = New System.Drawing.Size(120, 23)
        Me.btnBrowseDays.TabIndex = 10
        Me.btnBrowseDays.Text = "Browse Days"
        Me.btnBrowseDays.UseVisualStyleBackColor = True
        '
        'btnBrowseTime
        '
        Me.btnBrowseTime.Location = New System.Drawing.Point(138, 12)
        Me.btnBrowseTime.Name = "btnBrowseTime"
        Me.btnBrowseTime.Size = New System.Drawing.Size(120, 23)
        Me.btnBrowseTime.TabIndex = 16
        Me.btnBrowseTime.Text = "Browse Time"
        Me.btnBrowseTime.UseVisualStyleBackColor = True
        '
        'btnBrowseClassroom
        '
        Me.btnBrowseClassroom.Location = New System.Drawing.Point(12, 12)
        Me.btnBrowseClassroom.Name = "btnBrowseClassroom"
        Me.btnBrowseClassroom.Size = New System.Drawing.Size(120, 23)
        Me.btnBrowseClassroom.TabIndex = 15
        Me.btnBrowseClassroom.Text = "Browse Classroom"
        Me.btnBrowseClassroom.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(135, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Classroom"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(138, 57)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(120, 20)
        Me.txtTime.TabIndex = 12
        '
        'txtClassroom
        '
        Me.txtClassroom.Location = New System.Drawing.Point(12, 57)
        Me.txtClassroom.Name = "txtClassroom"
        Me.txtClassroom.ReadOnly = True
        Me.txtClassroom.Size = New System.Drawing.Size(120, 20)
        Me.txtClassroom.TabIndex = 11
        '
        'frmScheduleCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 158)
        Me.Controls.Add(Me.btnBrowseTime)
        Me.Controls.Add(Me.btnBrowseClassroom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtClassroom)
        Me.Controls.Add(Me.btnBrowseDays)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDay)
        Me.Controls.Add(Me.btnCreateSchedule)
        Me.Name = "frmScheduleCreator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmScheduleCreator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
