<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradesPreViewer
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
        Me.txtHits = New System.Windows.Forms.TextBox()
        Me.txtTotalQuestions = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grpRawData = New System.Windows.Forms.GroupBox()
        Me.grpProcessedData = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.grpRawData.SuspendLayout()
        Me.grpProcessedData.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtHits
        '
        Me.txtHits.Location = New System.Drawing.Point(161, 23)
        Me.txtHits.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtHits.Name = "txtHits"
        Me.txtHits.ReadOnly = True
        Me.txtHits.Size = New System.Drawing.Size(96, 22)
        Me.txtHits.TabIndex = 0
        '
        'txtTotalQuestions
        '
        Me.txtTotalQuestions.Location = New System.Drawing.Point(161, 71)
        Me.txtTotalQuestions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTotalQuestions.Name = "txtTotalQuestions"
        Me.txtTotalQuestions.ReadOnly = True
        Me.txtTotalQuestions.Size = New System.Drawing.Size(96, 22)
        Me.txtTotalQuestions.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total Questions"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "HITS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 52)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "/"
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(161, 23)
        Me.txtAverage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.ReadOnly = True
        Me.txtAverage.Size = New System.Drawing.Size(96, 22)
        Me.txtAverage.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 27)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Your Average"
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(161, 57)
        Me.txtScore.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.ReadOnly = True
        Me.txtScore.Size = New System.Drawing.Size(96, 22)
        Me.txtScore.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 60)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Your Score"
        '
        'grpRawData
        '
        Me.grpRawData.Controls.Add(Me.txtHits)
        Me.grpRawData.Controls.Add(Me.txtTotalQuestions)
        Me.grpRawData.Controls.Add(Me.Label3)
        Me.grpRawData.Controls.Add(Me.Label1)
        Me.grpRawData.Controls.Add(Me.Label2)
        Me.grpRawData.Location = New System.Drawing.Point(16, 279)
        Me.grpRawData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpRawData.Name = "grpRawData"
        Me.grpRawData.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpRawData.Size = New System.Drawing.Size(267, 105)
        Me.grpRawData.TabIndex = 9
        Me.grpRawData.TabStop = False
        Me.grpRawData.Text = "Raw Data"
        '
        'grpProcessedData
        '
        Me.grpProcessedData.Controls.Add(Me.txtAverage)
        Me.grpProcessedData.Controls.Add(Me.Label4)
        Me.grpProcessedData.Controls.Add(Me.Label5)
        Me.grpProcessedData.Controls.Add(Me.txtScore)
        Me.grpProcessedData.Location = New System.Drawing.Point(291, 279)
        Me.grpProcessedData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpProcessedData.Name = "grpProcessedData"
        Me.grpProcessedData.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpProcessedData.Size = New System.Drawing.Size(267, 105)
        Me.grpProcessedData.TabIndex = 10
        Me.grpProcessedData.TabStop = False
        Me.grpProcessedData.Text = "Processed Data"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 15)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(541, 257)
        Me.DataGridView1.TabIndex = 11
        '
        'frmGradesPreViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 399)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.grpProcessedData)
        Me.Controls.Add(Me.grpRawData)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmGradesPreViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPreGrades"
        Me.grpRawData.ResumeLayout(False)
        Me.grpRawData.PerformLayout()
        Me.grpProcessedData.ResumeLayout(False)
        Me.grpProcessedData.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtHits As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalQuestions As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAverage As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grpRawData As System.Windows.Forms.GroupBox
    Friend WithEvents grpProcessedData As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
