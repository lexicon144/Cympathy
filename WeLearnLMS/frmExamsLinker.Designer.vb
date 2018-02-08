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
        Me.grpClassroom.Location = New System.Drawing.Point(355, 15)
        Me.grpClassroom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpClassroom.Name = "grpClassroom"
        Me.grpClassroom.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpClassroom.Size = New System.Drawing.Size(267, 123)
        Me.grpClassroom.TabIndex = 10
        Me.grpClassroom.TabStop = False
        Me.grpClassroom.Text = "Classroom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 55)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Classroom Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Classroom ID"
        '
        'txtClassroomName
        '
        Me.txtClassroomName.Location = New System.Drawing.Point(125, 52)
        Me.txtClassroomName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtClassroomName.Name = "txtClassroomName"
        Me.txtClassroomName.ReadOnly = True
        Me.txtClassroomName.Size = New System.Drawing.Size(132, 22)
        Me.txtClassroomName.TabIndex = 1
        '
        'txtClassroomID
        '
        Me.txtClassroomID.Location = New System.Drawing.Point(125, 18)
        Me.txtClassroomID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtClassroomID.Name = "txtClassroomID"
        Me.txtClassroomID.ReadOnly = True
        Me.txtClassroomID.Size = New System.Drawing.Size(132, 22)
        Me.txtClassroomID.TabIndex = 0
        '
        'btnLink
        '
        Me.btnLink.Location = New System.Drawing.Point(272, 160)
        Me.btnLink.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLink.Name = "btnLink"
        Me.btnLink.Size = New System.Drawing.Size(100, 28)
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
        Me.grpExamDisplay.Location = New System.Drawing.Point(16, 15)
        Me.grpExamDisplay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpExamDisplay.Name = "grpExamDisplay"
        Me.grpExamDisplay.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpExamDisplay.Size = New System.Drawing.Size(267, 123)
        Me.grpExamDisplay.TabIndex = 8
        Me.grpExamDisplay.TabStop = False
        Me.grpExamDisplay.Text = "Exam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Exam Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Exam ID"
        '
        'txtExamID
        '
        Me.txtExamID.Location = New System.Drawing.Point(125, 23)
        Me.txtExamID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtExamID.Name = "txtExamID"
        Me.txtExamID.ReadOnly = True
        Me.txtExamID.Size = New System.Drawing.Size(132, 22)
        Me.txtExamID.TabIndex = 0
        '
        'txtExamName
        '
        Me.txtExamName.Location = New System.Drawing.Point(125, 55)
        Me.txtExamName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtExamName.Name = "txtExamName"
        Me.txtExamName.ReadOnly = True
        Me.txtExamName.Size = New System.Drawing.Size(132, 22)
        Me.txtExamName.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(306, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "To ->"
        '
        'frmExamsLinker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 204)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.grpClassroom)
        Me.Controls.Add(Me.btnLink)
        Me.Controls.Add(Me.grpExamDisplay)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
