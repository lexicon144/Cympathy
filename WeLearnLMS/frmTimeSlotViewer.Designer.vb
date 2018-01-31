<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimeSlotViewer
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
        Me.grpClassroom = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtClassroomID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtClassroomName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClassroomDescription = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtClassroomType = New System.Windows.Forms.TextBox()
        Me.grpTimeslot = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTimeID = New System.Windows.Forms.TextBox()
        Me.txtTimeDescription = New System.Windows.Forms.TextBox()
        Me.txtTimestart = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grpClassroom.SuspendLayout()
        Me.grpTimeslot.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpClassroom
        '
        Me.grpClassroom.Controls.Add(Me.Label4)
        Me.grpClassroom.Controls.Add(Me.txtClassroomID)
        Me.grpClassroom.Controls.Add(Me.Label3)
        Me.grpClassroom.Controls.Add(Me.txtClassroomName)
        Me.grpClassroom.Controls.Add(Me.Label2)
        Me.grpClassroom.Controls.Add(Me.txtClassroomDescription)
        Me.grpClassroom.Controls.Add(Me.Label1)
        Me.grpClassroom.Controls.Add(Me.txtClassroomType)
        Me.grpClassroom.Location = New System.Drawing.Point(12, 12)
        Me.grpClassroom.Name = "grpClassroom"
        Me.grpClassroom.Size = New System.Drawing.Size(200, 129)
        Me.grpClassroom.TabIndex = 0
        Me.grpClassroom.TabStop = False
        Me.grpClassroom.Text = "Classroom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Type"
        '
        'txtClassroomID
        '
        Me.txtClassroomID.Location = New System.Drawing.Point(81, 19)
        Me.txtClassroomID.Name = "txtClassroomID"
        Me.txtClassroomID.ReadOnly = True
        Me.txtClassroomID.Size = New System.Drawing.Size(100, 20)
        Me.txtClassroomID.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Description"
        '
        'txtClassroomName
        '
        Me.txtClassroomName.Location = New System.Drawing.Point(81, 45)
        Me.txtClassroomName.Name = "txtClassroomName"
        Me.txtClassroomName.ReadOnly = True
        Me.txtClassroomName.Size = New System.Drawing.Size(100, 20)
        Me.txtClassroomName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Name"
        '
        'txtClassroomDescription
        '
        Me.txtClassroomDescription.Location = New System.Drawing.Point(81, 71)
        Me.txtClassroomDescription.Name = "txtClassroomDescription"
        Me.txtClassroomDescription.ReadOnly = True
        Me.txtClassroomDescription.Size = New System.Drawing.Size(100, 20)
        Me.txtClassroomDescription.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID"
        '
        'txtClassroomType
        '
        Me.txtClassroomType.Location = New System.Drawing.Point(81, 97)
        Me.txtClassroomType.Name = "txtClassroomType"
        Me.txtClassroomType.ReadOnly = True
        Me.txtClassroomType.Size = New System.Drawing.Size(100, 20)
        Me.txtClassroomType.TabIndex = 4
        '
        'grpTimeslot
        '
        Me.grpTimeslot.Controls.Add(Me.Label7)
        Me.grpTimeslot.Controls.Add(Me.Label6)
        Me.grpTimeslot.Controls.Add(Me.txtTimestart)
        Me.grpTimeslot.Controls.Add(Me.txtTimeDescription)
        Me.grpTimeslot.Controls.Add(Me.Label5)
        Me.grpTimeslot.Controls.Add(Me.txtTimeID)
        Me.grpTimeslot.Location = New System.Drawing.Point(218, 12)
        Me.grpTimeslot.Name = "grpTimeslot"
        Me.grpTimeslot.Size = New System.Drawing.Size(200, 129)
        Me.grpTimeslot.TabIndex = 1
        Me.grpTimeslot.TabStop = False
        Me.grpTimeslot.Text = "Timeslot"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Time"
        '
        'txtTimeID
        '
        Me.txtTimeID.Location = New System.Drawing.Point(94, 15)
        Me.txtTimeID.Name = "txtTimeID"
        Me.txtTimeID.ReadOnly = True
        Me.txtTimeID.Size = New System.Drawing.Size(100, 20)
        Me.txtTimeID.TabIndex = 0
        '
        'txtTimeDescription
        '
        Me.txtTimeDescription.Location = New System.Drawing.Point(94, 40)
        Me.txtTimeDescription.Name = "txtTimeDescription"
        Me.txtTimeDescription.ReadOnly = True
        Me.txtTimeDescription.Size = New System.Drawing.Size(100, 20)
        Me.txtTimeDescription.TabIndex = 2
        '
        'txtTimestart
        '
        Me.txtTimestart.Location = New System.Drawing.Point(94, 66)
        Me.txtTimestart.Name = "txtTimestart"
        Me.txtTimestart.ReadOnly = True
        Me.txtTimestart.Size = New System.Drawing.Size(100, 20)
        Me.txtTimestart.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(2, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Time Description"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Time Start"
        '
        'frmTimeSlotViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 165)
        Me.Controls.Add(Me.grpTimeslot)
        Me.Controls.Add(Me.grpClassroom)
        Me.Name = "frmTimeSlotViewer"
        Me.Text = "frmTimeSlotViewer"
        Me.grpClassroom.ResumeLayout(False)
        Me.grpClassroom.PerformLayout()
        Me.grpTimeslot.ResumeLayout(False)
        Me.grpTimeslot.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpClassroom As System.Windows.Forms.GroupBox
    Friend WithEvents txtClassroomID As System.Windows.Forms.TextBox
    Friend WithEvents txtClassroomName As System.Windows.Forms.TextBox
    Friend WithEvents txtClassroomDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtClassroomType As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpTimeslot As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTimeID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTimestart As System.Windows.Forms.TextBox
    Friend WithEvents txtTimeDescription As System.Windows.Forms.TextBox
End Class
