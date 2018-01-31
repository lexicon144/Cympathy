<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimeSlotCreator
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
        Me.txtClassroom = New System.Windows.Forms.TextBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCreateTimeslot = New System.Windows.Forms.Button()
        Me.btnBrowseClassroom = New System.Windows.Forms.Button()
        Me.btnBrowseTime = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtClassroom
        '
        Me.txtClassroom.Location = New System.Drawing.Point(12, 181)
        Me.txtClassroom.Name = "txtClassroom"
        Me.txtClassroom.ReadOnly = True
        Me.txtClassroom.Size = New System.Drawing.Size(120, 20)
        Me.txtClassroom.TabIndex = 2
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(219, 181)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(120, 20)
        Me.txtTime.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Classroom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(216, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Time"
        '
        'btnCreateTimeslot
        '
        Me.btnCreateTimeslot.Location = New System.Drawing.Point(138, 178)
        Me.btnCreateTimeslot.Name = "btnCreateTimeslot"
        Me.btnCreateTimeslot.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateTimeslot.TabIndex = 6
        Me.btnCreateTimeslot.Text = "Time Slot"
        Me.btnCreateTimeslot.UseVisualStyleBackColor = True
        '
        'btnBrowseClassroom
        '
        Me.btnBrowseClassroom.Location = New System.Drawing.Point(12, 63)
        Me.btnBrowseClassroom.Name = "btnBrowseClassroom"
        Me.btnBrowseClassroom.Size = New System.Drawing.Size(120, 23)
        Me.btnBrowseClassroom.TabIndex = 7
        Me.btnBrowseClassroom.Text = "Browse Classroom"
        Me.btnBrowseClassroom.UseVisualStyleBackColor = True
        '
        'btnBrowseTime
        '
        Me.btnBrowseTime.Location = New System.Drawing.Point(219, 63)
        Me.btnBrowseTime.Name = "btnBrowseTime"
        Me.btnBrowseTime.Size = New System.Drawing.Size(120, 23)
        Me.btnBrowseTime.TabIndex = 8
        Me.btnBrowseTime.Text = "Browse Time"
        Me.btnBrowseTime.UseVisualStyleBackColor = True
        '
        'frmTimeSlotCreation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 213)
        Me.Controls.Add(Me.btnBrowseTime)
        Me.Controls.Add(Me.btnBrowseClassroom)
        Me.Controls.Add(Me.btnCreateTimeslot)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtClassroom)
        Me.Name = "frmTimeSlotCreation"
        Me.Text = "frmTimeSlotCreation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtClassroom As System.Windows.Forms.TextBox
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCreateTimeslot As System.Windows.Forms.Button
    Friend WithEvents btnBrowseClassroom As System.Windows.Forms.Button
    Friend WithEvents btnBrowseTime As System.Windows.Forms.Button
End Class
