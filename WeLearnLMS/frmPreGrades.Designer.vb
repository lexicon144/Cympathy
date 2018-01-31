<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreGrades
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
        Me.grpRawData.SuspendLayout()
        Me.grpProcessedData.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtHits
        '
        Me.txtHits.Location = New System.Drawing.Point(121, 19)
        Me.txtHits.Name = "txtHits"
        Me.txtHits.ReadOnly = True
        Me.txtHits.Size = New System.Drawing.Size(73, 20)
        Me.txtHits.TabIndex = 0
        '
        'txtTotalQuestions
        '
        Me.txtTotalQuestions.Location = New System.Drawing.Point(121, 58)
        Me.txtTotalQuestions.Name = "txtTotalQuestions"
        Me.txtTotalQuestions.ReadOnly = True
        Me.txtTotalQuestions.Size = New System.Drawing.Size(73, 20)
        Me.txtTotalQuestions.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total Questions"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "HITS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(150, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "/"
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(121, 42)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.ReadOnly = True
        Me.txtAverage.Size = New System.Drawing.Size(73, 20)
        Me.txtAverage.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Your Average"
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(121, 69)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.ReadOnly = True
        Me.txtScore.Size = New System.Drawing.Size(73, 20)
        Me.txtScore.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
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
        Me.grpRawData.Location = New System.Drawing.Point(12, 12)
        Me.grpRawData.Name = "grpRawData"
        Me.grpRawData.Size = New System.Drawing.Size(200, 100)
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
        Me.grpProcessedData.Location = New System.Drawing.Point(12, 118)
        Me.grpProcessedData.Name = "grpProcessedData"
        Me.grpProcessedData.Size = New System.Drawing.Size(200, 100)
        Me.grpProcessedData.TabIndex = 10
        Me.grpProcessedData.TabStop = False
        Me.grpProcessedData.Text = "Processed Data"
        '
        'frmPreGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 236)
        Me.Controls.Add(Me.grpProcessedData)
        Me.Controls.Add(Me.grpRawData)
        Me.Name = "frmPreGrades"
        Me.Text = "frmPreGrades"
        Me.grpRawData.ResumeLayout(False)
        Me.grpRawData.PerformLayout()
        Me.grpProcessedData.ResumeLayout(False)
        Me.grpProcessedData.PerformLayout()
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
End Class
