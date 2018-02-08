<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExamsHub
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
        Me.grpExamDisplay = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtExamID = New System.Windows.Forms.TextBox()
        Me.txtExamName = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpExamDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 15)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(461, 302)
        Me.DataGridView1.TabIndex = 8
        '
        'grpExamDisplay
        '
        Me.grpExamDisplay.Controls.Add(Me.Label2)
        Me.grpExamDisplay.Controls.Add(Me.Label1)
        Me.grpExamDisplay.Controls.Add(Me.txtExamID)
        Me.grpExamDisplay.Controls.Add(Me.txtExamName)
        Me.grpExamDisplay.Location = New System.Drawing.Point(16, 324)
        Me.grpExamDisplay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpExamDisplay.Name = "grpExamDisplay"
        Me.grpExamDisplay.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpExamDisplay.Size = New System.Drawing.Size(245, 123)
        Me.grpExamDisplay.TabIndex = 9
        Me.grpExamDisplay.TabStop = False
        Me.grpExamDisplay.Text = "Exam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Exam Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Exam ID"
        '
        'txtExamID
        '
        Me.txtExamID.Location = New System.Drawing.Point(105, 23)
        Me.txtExamID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtExamID.Name = "txtExamID"
        Me.txtExamID.ReadOnly = True
        Me.txtExamID.Size = New System.Drawing.Size(132, 22)
        Me.txtExamID.TabIndex = 0
        '
        'txtExamName
        '
        Me.txtExamName.Location = New System.Drawing.Point(105, 55)
        Me.txtExamName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtExamName.Name = "txtExamName"
        Me.txtExamName.ReadOnly = True
        Me.txtExamName.Size = New System.Drawing.Size(132, 22)
        Me.txtExamName.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(377, 381)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 28)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Text = "O K"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(377, 419)
        Me.btnView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(100, 28)
        Me.btnView.TabIndex = 9
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'frmExamsHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 464)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.grpExamDisplay)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmExamsHub"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmExamHub"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpExamDisplay.ResumeLayout(False)
        Me.grpExamDisplay.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents grpExamDisplay As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtExamID As System.Windows.Forms.TextBox
    Friend WithEvents txtExamName As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
End Class
