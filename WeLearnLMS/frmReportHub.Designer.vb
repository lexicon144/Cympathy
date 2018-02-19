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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnScheduleReports = New System.Windows.Forms.Button()
        Me.btnQuizReports = New System.Windows.Forms.Button()
        Me.btnClassStanding = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnScheduleReports, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnQuizReports, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnClassStanding, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 13)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(351, 168)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnScheduleReports
        '
        Me.btnScheduleReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnScheduleReports.Location = New System.Drawing.Point(3, 3)
        Me.btnScheduleReports.Name = "btnScheduleReports"
        Me.btnScheduleReports.Size = New System.Drawing.Size(169, 78)
        Me.btnScheduleReports.TabIndex = 0
        Me.btnScheduleReports.Text = "Schedule Reports"
        Me.btnScheduleReports.UseVisualStyleBackColor = True
        '
        'btnQuizReports
        '
        Me.btnQuizReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnQuizReports.Location = New System.Drawing.Point(178, 3)
        Me.btnQuizReports.Name = "btnQuizReports"
        Me.btnQuizReports.Size = New System.Drawing.Size(170, 78)
        Me.btnQuizReports.TabIndex = 1
        Me.btnQuizReports.Text = "Quiz Reports"
        Me.btnQuizReports.UseVisualStyleBackColor = True
        '
        'btnClassStanding
        '
        Me.btnClassStanding.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClassStanding.Location = New System.Drawing.Point(3, 87)
        Me.btnClassStanding.Name = "btnClassStanding"
        Me.btnClassStanding.Size = New System.Drawing.Size(169, 78)
        Me.btnClassStanding.TabIndex = 2
        Me.btnClassStanding.Text = "Class Standing Reports"
        Me.btnClassStanding.UseVisualStyleBackColor = True
        '
        'frmReportHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.WeLearnLMS.My.MySettings.Default.MenuBGC
        Me.ClientSize = New System.Drawing.Size(372, 197)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.WeLearnLMS.My.MySettings.Default, "MainFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.WeLearnLMS.My.MySettings.Default, "MenuBGC", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.WeLearnLMS.My.MySettings.Default.MainFont
        Me.Name = "frmReportHub"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReportHub"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnScheduleReports As System.Windows.Forms.Button
    Friend WithEvents btnQuizReports As System.Windows.Forms.Button
    Friend WithEvents btnClassStanding As System.Windows.Forms.Button
End Class
