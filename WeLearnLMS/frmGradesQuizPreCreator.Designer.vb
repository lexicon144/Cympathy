<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradesQuizPreCreator
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
        Me.grpQuiz = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtQuizName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQuizID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpGrade = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGradeFullScore = New System.Windows.Forms.TextBox()
        Me.txtGradeNumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.grpQuiz.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grpGrade.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpQuiz
        '
        Me.grpQuiz.Controls.Add(Me.TableLayoutPanel1)
        Me.grpQuiz.Location = New System.Drawing.Point(4, 4)
        Me.grpQuiz.Margin = New System.Windows.Forms.Padding(4)
        Me.grpQuiz.Name = "grpQuiz"
        Me.grpQuiz.Padding = New System.Windows.Forms.Padding(4)
        Me.grpQuiz.Size = New System.Drawing.Size(339, 185)
        Me.grpQuiz.TabIndex = 1
        Me.grpQuiz.TabStop = False
        Me.grpQuiz.Text = "Quiz"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtQuizName, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtQuizID, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 19)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(331, 162)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'txtQuizName
        '
        Me.txtQuizName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtQuizName.Location = New System.Drawing.Point(169, 85)
        Me.txtQuizName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuizName.Name = "txtQuizName"
        Me.txtQuizName.ReadOnly = True
        Me.txtQuizName.Size = New System.Drawing.Size(158, 22)
        Me.txtQuizName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(4, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 81)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Quiz Name"
        '
        'txtQuizID
        '
        Me.txtQuizID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtQuizID.Location = New System.Drawing.Point(169, 4)
        Me.txtQuizID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuizID.Name = "txtQuizID"
        Me.txtQuizID.ReadOnly = True
        Me.txtQuizID.Size = New System.Drawing.Size(158, 22)
        Me.txtQuizID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 81)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Quiz ID"
        '
        'grpGrade
        '
        Me.grpGrade.Controls.Add(Me.TableLayoutPanel2)
        Me.grpGrade.Location = New System.Drawing.Point(351, 4)
        Me.grpGrade.Margin = New System.Windows.Forms.Padding(4)
        Me.grpGrade.Name = "grpGrade"
        Me.grpGrade.Padding = New System.Windows.Forms.Padding(4)
        Me.grpGrade.Size = New System.Drawing.Size(339, 185)
        Me.grpGrade.TabIndex = 2
        Me.grpGrade.TabStop = False
        Me.grpGrade.Text = "Grade"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtGradeFullScore, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtGradeNumber, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 19)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(331, 162)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(4, 81)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 81)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Average Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(4, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 81)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Full Score"
        '
        'txtGradeFullScore
        '
        Me.txtGradeFullScore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtGradeFullScore.Location = New System.Drawing.Point(169, 4)
        Me.txtGradeFullScore.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGradeFullScore.Name = "txtGradeFullScore"
        Me.txtGradeFullScore.ReadOnly = True
        Me.txtGradeFullScore.Size = New System.Drawing.Size(158, 22)
        Me.txtGradeFullScore.TabIndex = 4
        '
        'txtGradeNumber
        '
        Me.txtGradeNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtGradeNumber.Location = New System.Drawing.Point(169, 85)
        Me.txtGradeNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGradeNumber.Name = "txtGradeNumber"
        Me.txtGradeNumber.ReadOnly = True
        Me.txtGradeNumber.Size = New System.Drawing.Size(158, 22)
        Me.txtGradeNumber.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(4, 193)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Label5"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.grpQuiz)
        Me.FlowLayoutPanel1.Controls.Add(Me.grpGrade)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(702, 238)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'frmGradesQuizPreCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 238)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmGradesQuizPreCreator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "viewr"
        Me.grpQuiz.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.grpGrade.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpQuiz As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtQuizName As System.Windows.Forms.TextBox
    Friend WithEvents txtQuizID As System.Windows.Forms.TextBox
    Friend WithEvents grpGrade As System.Windows.Forms.GroupBox
    Friend WithEvents txtGradeNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGradeFullScore As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
End Class
