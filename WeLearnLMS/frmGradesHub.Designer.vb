<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradesHub
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
        Me.grpClassroom = New System.Windows.Forms.GroupBox()
        Me.grpGrade = New System.Windows.Forms.GroupBox()
        Me.txtClassroomID = New System.Windows.Forms.TextBox()
        Me.txtClassroomName = New System.Windows.Forms.TextBox()
        Me.txtGradeScore = New System.Windows.Forms.TextBox()
        Me.txtGradeMark = New System.Windows.Forms.TextBox()
        Me.txtGradeLetter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpClassroom.SuspendLayout()
        Me.grpGrade.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(477, 136)
        Me.DataGridView1.TabIndex = 0
        '
        'grpClassroom
        '
        Me.grpClassroom.Controls.Add(Me.Label5)
        Me.grpClassroom.Controls.Add(Me.Label4)
        Me.grpClassroom.Controls.Add(Me.txtClassroomName)
        Me.grpClassroom.Controls.Add(Me.txtClassroomID)
        Me.grpClassroom.Location = New System.Drawing.Point(12, 154)
        Me.grpClassroom.Name = "grpClassroom"
        Me.grpClassroom.Size = New System.Drawing.Size(200, 140)
        Me.grpClassroom.TabIndex = 1
        Me.grpClassroom.TabStop = False
        Me.grpClassroom.Text = "Classroom"
        '
        'grpGrade
        '
        Me.grpGrade.Controls.Add(Me.Label3)
        Me.grpGrade.Controls.Add(Me.Label2)
        Me.grpGrade.Controls.Add(Me.Label1)
        Me.grpGrade.Controls.Add(Me.txtGradeLetter)
        Me.grpGrade.Controls.Add(Me.txtGradeMark)
        Me.grpGrade.Controls.Add(Me.txtGradeScore)
        Me.grpGrade.Location = New System.Drawing.Point(218, 154)
        Me.grpGrade.Name = "grpGrade"
        Me.grpGrade.Size = New System.Drawing.Size(200, 140)
        Me.grpGrade.TabIndex = 2
        Me.grpGrade.TabStop = False
        Me.grpGrade.Text = "Grade"
        '
        'txtClassroomID
        '
        Me.txtClassroomID.Location = New System.Drawing.Point(94, 19)
        Me.txtClassroomID.Name = "txtClassroomID"
        Me.txtClassroomID.ReadOnly = True
        Me.txtClassroomID.Size = New System.Drawing.Size(100, 20)
        Me.txtClassroomID.TabIndex = 0
        '
        'txtClassroomName
        '
        Me.txtClassroomName.Location = New System.Drawing.Point(94, 45)
        Me.txtClassroomName.Name = "txtClassroomName"
        Me.txtClassroomName.ReadOnly = True
        Me.txtClassroomName.Size = New System.Drawing.Size(100, 20)
        Me.txtClassroomName.TabIndex = 1
        '
        'txtGradeScore
        '
        Me.txtGradeScore.Location = New System.Drawing.Point(94, 19)
        Me.txtGradeScore.Name = "txtGradeScore"
        Me.txtGradeScore.ReadOnly = True
        Me.txtGradeScore.Size = New System.Drawing.Size(100, 20)
        Me.txtGradeScore.TabIndex = 0
        '
        'txtGradeMark
        '
        Me.txtGradeMark.Location = New System.Drawing.Point(94, 45)
        Me.txtGradeMark.Name = "txtGradeMark"
        Me.txtGradeMark.ReadOnly = True
        Me.txtGradeMark.Size = New System.Drawing.Size(100, 20)
        Me.txtGradeMark.TabIndex = 1
        '
        'txtGradeLetter
        '
        Me.txtGradeLetter.Location = New System.Drawing.Point(94, 71)
        Me.txtGradeLetter.Name = "txtGradeLetter"
        Me.txtGradeLetter.ReadOnly = True
        Me.txtGradeLetter.Size = New System.Drawing.Size(100, 20)
        Me.txtGradeLetter.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Score"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mark"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Letter"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Name"
        '
        'frmGradesHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 306)
        Me.Controls.Add(Me.grpGrade)
        Me.Controls.Add(Me.grpClassroom)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmGradesHub"
        Me.Text = "frmGradesHub"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpClassroom.ResumeLayout(False)
        Me.grpClassroom.PerformLayout()
        Me.grpGrade.ResumeLayout(False)
        Me.grpGrade.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents grpClassroom As System.Windows.Forms.GroupBox
    Friend WithEvents txtClassroomName As System.Windows.Forms.TextBox
    Friend WithEvents txtClassroomID As System.Windows.Forms.TextBox
    Friend WithEvents grpGrade As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGradeLetter As System.Windows.Forms.TextBox
    Friend WithEvents txtGradeMark As System.Windows.Forms.TextBox
    Friend WithEvents txtGradeScore As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
