<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportHub
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ViewReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScheduleReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassStandingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuizPartialToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExamPartialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassroomFullToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(514, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ViewReportsToolStripMenuItem
        '
        Me.ViewReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScheduleReportsToolStripMenuItem, Me.ClassStandingToolStripMenuItem, Me.GradesToolStripMenuItem})
        Me.ViewReportsToolStripMenuItem.Name = "ViewReportsToolStripMenuItem"
        Me.ViewReportsToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.ViewReportsToolStripMenuItem.Text = "View Reports"
        '
        'ScheduleReportsToolStripMenuItem
        '
        Me.ScheduleReportsToolStripMenuItem.Name = "ScheduleReportsToolStripMenuItem"
        Me.ScheduleReportsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ScheduleReportsToolStripMenuItem.Text = "Schedule"
        '
        'ClassStandingToolStripMenuItem
        '
        Me.ClassStandingToolStripMenuItem.Name = "ClassStandingToolStripMenuItem"
        Me.ClassStandingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClassStandingToolStripMenuItem.Text = "Class Standing"
        '
        'GradesToolStripMenuItem
        '
        Me.GradesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuizPartialToolStripMenuItem1, Me.ExamPartialToolStripMenuItem, Me.ClassroomFullToolStripMenuItem})
        Me.GradesToolStripMenuItem.Name = "GradesToolStripMenuItem"
        Me.GradesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GradesToolStripMenuItem.Text = "Grades"
        '
        'QuizPartialToolStripMenuItem1
        '
        Me.QuizPartialToolStripMenuItem1.Name = "QuizPartialToolStripMenuItem1"
        Me.QuizPartialToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.QuizPartialToolStripMenuItem1.Text = "Quiz (Partial)"
        '
        'ExamPartialToolStripMenuItem
        '
        Me.ExamPartialToolStripMenuItem.Name = "ExamPartialToolStripMenuItem"
        Me.ExamPartialToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ExamPartialToolStripMenuItem.Text = "Exam (Partial)"
        '
        'ClassroomFullToolStripMenuItem
        '
        Me.ClassroomFullToolStripMenuItem.Name = "ClassroomFullToolStripMenuItem"
        Me.ClassroomFullToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ClassroomFullToolStripMenuItem.Text = "Classroom (Full)"
        '
        'frmReportHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.WeLearnLMS.My.MySettings.Default.MenuBGC
        Me.ClientSize = New System.Drawing.Size(514, 304)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.WeLearnLMS.My.MySettings.Default, "MainFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.WeLearnLMS.My.MySettings.Default, "MenuBGC", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.WeLearnLMS.My.MySettings.Default.MainFont
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmReportHub"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReportHub"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ViewReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScheduleReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassStandingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GradesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuizPartialToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExamPartialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassroomFullToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
