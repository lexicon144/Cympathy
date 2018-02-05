<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassroomLinker
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
        Me.components = New System.ComponentModel.Container()
        Me.grpEnrollment = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnroll = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtClassName = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClassDesc = New System.Windows.Forms.TextBox()
        Me.txtClassID = New System.Windows.Forms.TextBox()
        Me.grpClassDetails = New System.Windows.Forms.GroupBox()
        Me.grpEnrollment.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpClassDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpEnrollment
        '
        Me.grpEnrollment.Controls.Add(Me.Label5)
        Me.grpEnrollment.Controls.Add(Me.txtStudentName)
        Me.grpEnrollment.Controls.Add(Me.txtStudentID)
        Me.grpEnrollment.Controls.Add(Me.Label1)
        Me.grpEnrollment.Location = New System.Drawing.Point(11, 11)
        Me.grpEnrollment.Margin = New System.Windows.Forms.Padding(2)
        Me.grpEnrollment.Name = "grpEnrollment"
        Me.grpEnrollment.Padding = New System.Windows.Forms.Padding(2)
        Me.grpEnrollment.Size = New System.Drawing.Size(201, 124)
        Me.grpEnrollment.TabIndex = 14
        Me.grpEnrollment.TabStop = False
        Me.grpEnrollment.Text = "Enrollment"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Student Name"
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(97, 44)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.ReadOnly = True
        Me.txtStudentName.Size = New System.Drawing.Size(100, 20)
        Me.txtStudentName.TabIndex = 4
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(97, 19)
        Me.txtStudentID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.ReadOnly = True
        Me.txtStudentID.Size = New System.Drawing.Size(100, 20)
        Me.txtStudentID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Student ID"
        '
        'btnEnroll
        '
        Me.btnEnroll.Location = New System.Drawing.Point(205, 151)
        Me.btnEnroll.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEnroll.Name = "btnEnroll"
        Me.btnEnroll.Size = New System.Drawing.Size(97, 22)
        Me.btnEnroll.TabIndex = 6
        Me.btnEnroll.Text = "Enroll"
        Me.btnEnroll.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 19)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ID"
        '
        'txtClassName
        '
        Me.txtClassName.Location = New System.Drawing.Point(57, 41)
        Me.txtClassName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtClassName.Name = "txtClassName"
        Me.txtClassName.ReadOnly = True
        Me.txtClassName.Size = New System.Drawing.Size(129, 20)
        Me.txtClassName.TabIndex = 4
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 67)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Desc"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'txtClassDesc
        '
        Me.txtClassDesc.Location = New System.Drawing.Point(57, 65)
        Me.txtClassDesc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtClassDesc.Multiline = True
        Me.txtClassDesc.Name = "txtClassDesc"
        Me.txtClassDesc.ReadOnly = True
        Me.txtClassDesc.Size = New System.Drawing.Size(129, 41)
        Me.txtClassDesc.TabIndex = 1
        '
        'txtClassID
        '
        Me.txtClassID.Location = New System.Drawing.Point(57, 17)
        Me.txtClassID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtClassID.Name = "txtClassID"
        Me.txtClassID.ReadOnly = True
        Me.txtClassID.Size = New System.Drawing.Size(129, 20)
        Me.txtClassID.TabIndex = 0
        '
        'grpClassDetails
        '
        Me.grpClassDetails.Controls.Add(Me.Label4)
        Me.grpClassDetails.Controls.Add(Me.txtClassName)
        Me.grpClassDetails.Controls.Add(Me.Label3)
        Me.grpClassDetails.Controls.Add(Me.Label2)
        Me.grpClassDetails.Controls.Add(Me.txtClassDesc)
        Me.grpClassDetails.Controls.Add(Me.txtClassID)
        Me.grpClassDetails.Location = New System.Drawing.Point(297, 11)
        Me.grpClassDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.grpClassDetails.Name = "grpClassDetails"
        Me.grpClassDetails.Padding = New System.Windows.Forms.Padding(2)
        Me.grpClassDetails.Size = New System.Drawing.Size(188, 124)
        Me.grpClassDetails.TabIndex = 12
        Me.grpClassDetails.TabStop = False
        Me.grpClassDetails.Text = "Class Details"
        '
        'frmClassroomLinker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 184)
        Me.Controls.Add(Me.grpEnrollment)
        Me.Controls.Add(Me.grpClassDetails)
        Me.Controls.Add(Me.btnEnroll)
        Me.Name = "frmClassroomLinker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmClassroomLinker"
        Me.grpEnrollment.ResumeLayout(False)
        Me.grpEnrollment.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpClassDetails.ResumeLayout(False)
        Me.grpClassDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpEnrollment As System.Windows.Forms.GroupBox
    Friend WithEvents txtStudentID As System.Windows.Forms.TextBox
    Friend WithEvents btnEnroll As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtClassName As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents grpClassDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtClassDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtClassID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtStudentName As System.Windows.Forms.TextBox
End Class
