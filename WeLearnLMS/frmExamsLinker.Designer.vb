<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExamsLinker
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtClassroomName = New System.Windows.Forms.TextBox()
        Me.txtClassroomID = New System.Windows.Forms.TextBox()
        Me.btnLink = New System.Windows.Forms.Button()
        Me.grpExamDisplay = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtExamID = New System.Windows.Forms.TextBox()
        Me.txtExamName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpClassroom.SuspendLayout()
        Me.grpExamDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpClassroom
        '
        Me.grpClassroom.Controls.Add(Me.Label4)
        Me.grpClassroom.Controls.Add(Me.Label3)
        Me.grpClassroom.Controls.Add(Me.txtClassroomName)
        Me.grpClassroom.Controls.Add(Me.txtClassroomID)
        Me.grpClassroom.Location = New System.Drawing.Point(299, 12)
        Me.grpClassroom.Name = "grpClassroom"
        Me.grpClassroom.Size = New System.Drawing.Size(200, 100)
        Me.grpClassroom.TabIndex = 10
        Me.grpClassroom.TabStop = False
        Me.grpClassroom.Text = "Classroom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Classroom Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Classroom ID"
        '
        'txtClassroomName
        '
        Me.txtClassroomName.Location = New System.Drawing.Point(94, 42)
        Me.txtClassroomName.Name = "txtClassroomName"
        Me.txtClassroomName.ReadOnly = True
        Me.txtClassroomName.Size = New System.Drawing.Size(100, 20)
        Me.txtClassroomName.TabIndex = 1
        '
        'txtClassroomID
        '
        Me.txtClassroomID.Location = New System.Drawing.Point(94, 15)
        Me.txtClassroomID.Name = "txtClassroomID"
        Me.txtClassroomID.ReadOnly = True
        Me.txtClassroomID.Size = New System.Drawing.Size(100, 20)
        Me.txtClassroomID.TabIndex = 0
        '
        'btnLink
        '
        Me.btnLink.Location = New System.Drawing.Point(218, 77)
        Me.btnLink.Name = "btnLink"
        Me.btnLink.Size = New System.Drawing.Size(75, 23)
        Me.btnLink.TabIndex = 9
        Me.btnLink.Text = "Link ->"
        Me.btnLink.UseVisualStyleBackColor = True
        '
        'grpExamDisplay
        '
        Me.grpExamDisplay.Controls.Add(Me.Label2)
        Me.grpExamDisplay.Controls.Add(Me.Label1)
        Me.grpExamDisplay.Controls.Add(Me.txtExamID)
        Me.grpExamDisplay.Controls.Add(Me.txtExamName)
        Me.grpExamDisplay.Location = New System.Drawing.Point(12, 12)
        Me.grpExamDisplay.Name = "grpExamDisplay"
        Me.grpExamDisplay.Size = New System.Drawing.Size(200, 100)
        Me.grpExamDisplay.TabIndex = 8
        Me.grpExamDisplay.TabStop = False
        Me.grpExamDisplay.Text = "Exam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Exam Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Exam ID"
        '
        'txtExamID
        '
        Me.txtExamID.Location = New System.Drawing.Point(94, 19)
        Me.txtExamID.Name = "txtExamID"
        Me.txtExamID.ReadOnly = True
        Me.txtExamID.Size = New System.Drawing.Size(100, 20)
        Me.txtExamID.TabIndex = 0
        '
        'txtExamName
        '
        Me.txtExamName.Location = New System.Drawing.Point(94, 45)
        Me.txtExamName.Name = "txtExamName"
        Me.txtExamName.ReadOnly = True
        Me.txtExamName.Size = New System.Drawing.Size(100, 20)
        Me.txtExamName.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(230, 61)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "To ->"
        '
        'frmExamsLinker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 126)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.grpClassroom)
        Me.Controls.Add(Me.btnLink)
        Me.Controls.Add(Me.grpExamDisplay)
        Me.Name = "frmExamsLinker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmExamsLinker"
        Me.grpClassroom.ResumeLayout(False)
        Me.grpClassroom.PerformLayout()
        Me.grpExamDisplay.ResumeLayout(False)
        Me.grpExamDisplay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpClassroom As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtClassroomName As System.Windows.Forms.TextBox
    Friend WithEvents txtClassroomID As System.Windows.Forms.TextBox
    Friend WithEvents btnLink As System.Windows.Forms.Button
    Friend WithEvents grpExamDisplay As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtExamID As System.Windows.Forms.TextBox
    Friend WithEvents txtExamName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
