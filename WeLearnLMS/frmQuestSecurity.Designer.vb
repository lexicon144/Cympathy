<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestSecurity
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.grpExamDisplay = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtExamID = New System.Windows.Forms.TextBox()
        Me.txtExamName = New System.Windows.Forms.TextBox()
        Me.grpExamDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(106, 120)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(131, 146)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "O K "
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'grpExamDisplay
        '
        Me.grpExamDisplay.Controls.Add(Me.Label2)
        Me.grpExamDisplay.Controls.Add(Me.Label1)
        Me.grpExamDisplay.Controls.Add(Me.txtExamID)
        Me.grpExamDisplay.Controls.Add(Me.txtExamName)
        Me.grpExamDisplay.Location = New System.Drawing.Point(12, 12)
        Me.grpExamDisplay.Name = "grpExamDisplay"
        Me.grpExamDisplay.Size = New System.Drawing.Size(200, 73)
        Me.grpExamDisplay.TabIndex = 9
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
        'frmQuestSecurity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 181)
        Me.Controls.Add(Me.grpExamDisplay)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frmQuestSecurity"
        Me.Text = "frmExamSecurity"
        Me.grpExamDisplay.ResumeLayout(False)
        Me.grpExamDisplay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents grpExamDisplay As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtExamID As System.Windows.Forms.TextBox
    Friend WithEvents txtExamName As System.Windows.Forms.TextBox
End Class
