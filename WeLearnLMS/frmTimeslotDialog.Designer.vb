<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimeslotDialog
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtTimeID = New System.Windows.Forms.TextBox()
        Me.txtTimeDescription = New System.Windows.Forms.TextBox()
        Me.txtClassroomID = New System.Windows.Forms.TextBox()
        Me.txtClassroomDescription = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.txtClassroomName = New System.Windows.Forms.TextBox()
        Me.txtClassroomType = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTimeStart = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTimeSlotID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 39)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(696, 165)
        Me.DataGridView1.TabIndex = 0
        '
        'txtTimeID
        '
        Me.txtTimeID.Location = New System.Drawing.Point(385, 208)
        Me.txtTimeID.Name = "txtTimeID"
        Me.txtTimeID.ReadOnly = True
        Me.txtTimeID.Size = New System.Drawing.Size(100, 20)
        Me.txtTimeID.TabIndex = 1
        '
        'txtTimeDescription
        '
        Me.txtTimeDescription.Location = New System.Drawing.Point(385, 234)
        Me.txtTimeDescription.Name = "txtTimeDescription"
        Me.txtTimeDescription.ReadOnly = True
        Me.txtTimeDescription.Size = New System.Drawing.Size(100, 20)
        Me.txtTimeDescription.TabIndex = 2
        '
        'txtClassroomID
        '
        Me.txtClassroomID.Location = New System.Drawing.Point(123, 210)
        Me.txtClassroomID.Name = "txtClassroomID"
        Me.txtClassroomID.ReadOnly = True
        Me.txtClassroomID.Size = New System.Drawing.Size(100, 20)
        Me.txtClassroomID.TabIndex = 3
        '
        'txtClassroomDescription
        '
        Me.txtClassroomDescription.Location = New System.Drawing.Point(123, 236)
        Me.txtClassroomDescription.Name = "txtClassroomDescription"
        Me.txtClassroomDescription.ReadOnly = True
        Me.txtClassroomDescription.Size = New System.Drawing.Size(100, 20)
        Me.txtClassroomDescription.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(335, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Time ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(321, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Time Desc"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Classroom ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Classroom Desc"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(633, 344)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 9
        Me.btnOK.Text = "O K "
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(123, 13)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(100, 20)
        Me.txtFilter.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(88, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Filter"
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(368, 10)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(75, 23)
        Me.btnFilter.TabIndex = 12
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'txtClassroomName
        '
        Me.txtClassroomName.Location = New System.Drawing.Point(123, 262)
        Me.txtClassroomName.Name = "txtClassroomName"
        Me.txtClassroomName.ReadOnly = True
        Me.txtClassroomName.Size = New System.Drawing.Size(100, 20)
        Me.txtClassroomName.TabIndex = 13
        '
        'txtClassroomType
        '
        Me.txtClassroomType.Location = New System.Drawing.Point(123, 288)
        Me.txtClassroomType.Name = "txtClassroomType"
        Me.txtClassroomType.ReadOnly = True
        Me.txtClassroomType.Size = New System.Drawing.Size(100, 20)
        Me.txtClassroomType.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Classroom Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Classroom Type"
        '
        'txtTimeStart
        '
        Me.txtTimeStart.Location = New System.Drawing.Point(385, 261)
        Me.txtTimeStart.Name = "txtTimeStart"
        Me.txtTimeStart.ReadOnly = True
        Me.txtTimeStart.Size = New System.Drawing.Size(100, 20)
        Me.txtTimeStart.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(324, 265)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Time Start"
        '
        'txtTimeSlotID
        '
        Me.txtTimeSlotID.Location = New System.Drawing.Point(123, 347)
        Me.txtTimeSlotID.Name = "txtTimeSlotID"
        Me.txtTimeSlotID.ReadOnly = True
        Me.txtTimeSlotID.Size = New System.Drawing.Size(100, 20)
        Me.txtTimeSlotID.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(57, 354)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Timeslot ID"
        '
        'frmTimeslotDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 383)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTimeSlotID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTimeStart)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtClassroomType)
        Me.Controls.Add(Me.txtClassroomName)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtClassroomDescription)
        Me.Controls.Add(Me.txtClassroomID)
        Me.Controls.Add(Me.txtTimeDescription)
        Me.Controls.Add(Me.txtTimeID)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmTimeslotDialog"
        Me.Text = "frmTimeslotDialog"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtTimeID As System.Windows.Forms.TextBox
    Friend WithEvents txtTimeDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtClassroomID As System.Windows.Forms.TextBox
    Friend WithEvents txtClassroomDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents txtClassroomName As System.Windows.Forms.TextBox
    Friend WithEvents txtClassroomType As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTimeStart As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTimeSlotID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
