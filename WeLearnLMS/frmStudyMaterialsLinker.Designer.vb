<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudyMaterialsLinker
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
        Me.grpMaterialDisplay = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaterialID = New System.Windows.Forms.TextBox()
        Me.txtMaterialName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpClassroom.SuspendLayout()
        Me.grpMaterialDisplay.SuspendLayout()
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
        Me.grpClassroom.TabIndex = 7
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
        Me.btnLink.TabIndex = 6
        Me.btnLink.Text = "Link ->"
        Me.btnLink.UseVisualStyleBackColor = True
        '
        'grpMaterialDisplay
        '
        Me.grpMaterialDisplay.Controls.Add(Me.Label2)
        Me.grpMaterialDisplay.Controls.Add(Me.Label1)
        Me.grpMaterialDisplay.Controls.Add(Me.txtMaterialID)
        Me.grpMaterialDisplay.Controls.Add(Me.txtMaterialName)
        Me.grpMaterialDisplay.Location = New System.Drawing.Point(16, 15)
        Me.grpMaterialDisplay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpMaterialDisplay.Name = "grpMaterialDisplay"
        Me.grpMaterialDisplay.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpMaterialDisplay.Size = New System.Drawing.Size(267, 123)
        Me.grpMaterialDisplay.TabIndex = 5
        Me.grpMaterialDisplay.TabStop = False
        Me.grpMaterialDisplay.Text = "Material"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Material Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Material ID"
        '
        'txtMaterialID
        '
        Me.txtMaterialID.Location = New System.Drawing.Point(125, 23)
        Me.txtMaterialID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMaterialID.Name = "txtMaterialID"
        Me.txtMaterialID.ReadOnly = True
        Me.txtMaterialID.Size = New System.Drawing.Size(132, 22)
        Me.txtMaterialID.TabIndex = 0
        '
        'txtMaterialName
        '
        Me.txtMaterialName.Location = New System.Drawing.Point(125, 55)
        Me.txtMaterialName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMaterialName.Name = "txtMaterialName"
        Me.txtMaterialName.ReadOnly = True
        Me.txtMaterialName.Size = New System.Drawing.Size(132, 22)
        Me.txtMaterialName.TabIndex = 1
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
        'frmStudyMaterialsLinker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 226)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.grpClassroom)
        Me.Controls.Add(Me.btnLink)
        Me.Controls.Add(Me.grpMaterialDisplay)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmStudyMaterialsLinker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStudyMaterialsLinker"
        Me.grpClassroom.ResumeLayout(False)
        Me.grpClassroom.PerformLayout()
        Me.grpMaterialDisplay.ResumeLayout(False)
        Me.grpMaterialDisplay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpClassroom As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtClassroomName As System.Windows.Forms.TextBox
    Friend WithEvents txtClassroomID As System.Windows.Forms.TextBox
    Friend WithEvents btnLink As System.Windows.Forms.Button
    Friend WithEvents grpMaterialDisplay As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMaterialID As System.Windows.Forms.TextBox
    Friend WithEvents txtMaterialName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
