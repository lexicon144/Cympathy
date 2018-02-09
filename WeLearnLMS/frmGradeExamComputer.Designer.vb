<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradeExamComputer
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtRecordedExams = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFullAverage = New System.Windows.Forms.TextBox()
        Me.txtLinkedExams = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 15)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(347, 185)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRecordedExams)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtFullAverage)
        Me.GroupBox1.Controls.Add(Me.txtLinkedExams)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(96, 207)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(267, 123)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Count"
        '
        'txtRecordedExams
        '
        Me.txtRecordedExams.Location = New System.Drawing.Point(125, 23)
        Me.txtRecordedExams.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRecordedExams.Name = "txtRecordedExams"
        Me.txtRecordedExams.ReadOnly = True
        Me.txtRecordedExams.Size = New System.Drawing.Size(132, 22)
        Me.txtRecordedExams.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 92)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Full Average"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-1, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Recorded Exam"
        '
        'txtFullAverage
        '
        Me.txtFullAverage.Location = New System.Drawing.Point(125, 89)
        Me.txtFullAverage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFullAverage.Name = "txtFullAverage"
        Me.txtFullAverage.ReadOnly = True
        Me.txtFullAverage.Size = New System.Drawing.Size(132, 22)
        Me.txtFullAverage.TabIndex = 5
        '
        'txtLinkedExams
        '
        Me.txtLinkedExams.Location = New System.Drawing.Point(125, 55)
        Me.txtLinkedExams.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLinkedExams.Name = "txtLinkedExams"
        Me.txtLinkedExams.ReadOnly = True
        Me.txtLinkedExams.Size = New System.Drawing.Size(132, 22)
        Me.txtLinkedExams.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Linked Exams"
        '
        'BackgroundWorker1
        '
        '
        'frmGradeExamComputer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 343)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmGradeExamComputer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGradeExamComputer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRecordedExams As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFullAverage As System.Windows.Forms.TextBox
    Friend WithEvents txtLinkedExams As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
