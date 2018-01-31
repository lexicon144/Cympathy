<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuizHub
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
        Me.grpQuizDisplay = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQuizID = New System.Windows.Forms.TextBox()
        Me.txtQuizName = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.grpQuizDisplay.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpQuizDisplay
        '
        Me.grpQuizDisplay.Controls.Add(Me.Label2)
        Me.grpQuizDisplay.Controls.Add(Me.Label1)
        Me.grpQuizDisplay.Controls.Add(Me.txtQuizID)
        Me.grpQuizDisplay.Controls.Add(Me.txtQuizName)
        Me.grpQuizDisplay.Location = New System.Drawing.Point(12, 263)
        Me.grpQuizDisplay.Name = "grpQuizDisplay"
        Me.grpQuizDisplay.Size = New System.Drawing.Size(200, 100)
        Me.grpQuizDisplay.TabIndex = 6
        Me.grpQuizDisplay.TabStop = False
        Me.grpQuizDisplay.Text = "Quiz"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Quiz Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Quiz ID"
        '
        'txtQuizID
        '
        Me.txtQuizID.Location = New System.Drawing.Point(94, 19)
        Me.txtQuizID.Name = "txtQuizID"
        Me.txtQuizID.ReadOnly = True
        Me.txtQuizID.Size = New System.Drawing.Size(100, 20)
        Me.txtQuizID.TabIndex = 0
        '
        'txtQuizName
        '
        Me.txtQuizName.Location = New System.Drawing.Point(94, 45)
        Me.txtQuizName.Name = "txtQuizName"
        Me.txtQuizName.ReadOnly = True
        Me.txtQuizName.Size = New System.Drawing.Size(100, 20)
        Me.txtQuizName.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(500, 245)
        Me.DataGridView1.TabIndex = 7
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(437, 306)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 14
        Me.btnOK.Text = "O K"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(437, 335)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 23)
        Me.btnView.TabIndex = 12
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'frmQuizHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 370)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.grpQuizDisplay)
        Me.Name = "frmQuizHub"
        Me.Text = "frmStudyHub"
        Me.grpQuizDisplay.ResumeLayout(False)
        Me.grpQuizDisplay.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpQuizDisplay As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtQuizID As System.Windows.Forms.TextBox
    Friend WithEvents txtQuizName As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
End Class
