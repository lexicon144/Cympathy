<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScheduleCreator
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
        Me.btnCreateSchedule = New System.Windows.Forms.Button()
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBrowseDays = New System.Windows.Forms.Button()
        Me.btnBrowseTime = New System.Windows.Forms.Button()
        Me.btnBrowseClassroom = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtClassroom = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCreateSchedule
        '
        Me.btnCreateSchedule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCreateSchedule.Location = New System.Drawing.Point(187, 198)
        Me.btnCreateSchedule.Name = "btnCreateSchedule"
        Me.btnCreateSchedule.Size = New System.Drawing.Size(178, 59)
        Me.btnCreateSchedule.TabIndex = 6
        Me.btnCreateSchedule.Text = "Create Schedule"
        Me.btnCreateSchedule.UseVisualStyleBackColor = True
        '
        'txtDay
        '
        Me.txtDay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDay.Location = New System.Drawing.Point(371, 133)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.ReadOnly = True
        Me.txtDay.Size = New System.Drawing.Size(181, 23)
        Me.txtDay.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(371, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 65)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Day"
        '
        'btnBrowseDays
        '
        Me.btnBrowseDays.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBrowseDays.Location = New System.Drawing.Point(371, 3)
        Me.btnBrowseDays.Name = "btnBrowseDays"
        Me.btnBrowseDays.Size = New System.Drawing.Size(181, 59)
        Me.btnBrowseDays.TabIndex = 10
        Me.btnBrowseDays.Text = "Browse Days"
        Me.btnBrowseDays.UseVisualStyleBackColor = True
        '
        'btnBrowseTime
        '
        Me.btnBrowseTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBrowseTime.Location = New System.Drawing.Point(187, 3)
        Me.btnBrowseTime.Name = "btnBrowseTime"
        Me.btnBrowseTime.Size = New System.Drawing.Size(178, 59)
        Me.btnBrowseTime.TabIndex = 16
        Me.btnBrowseTime.Text = "Browse Time"
        Me.btnBrowseTime.UseVisualStyleBackColor = True
        '
        'btnBrowseClassroom
        '
        Me.btnBrowseClassroom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBrowseClassroom.Location = New System.Drawing.Point(3, 3)
        Me.btnBrowseClassroom.Name = "btnBrowseClassroom"
        Me.btnBrowseClassroom.Size = New System.Drawing.Size(178, 59)
        Me.btnBrowseClassroom.TabIndex = 15
        Me.btnBrowseClassroom.Text = "Browse Classroom"
        Me.btnBrowseClassroom.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(187, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 65)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 65)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Classroom"
        '
        'txtTime
        '
        Me.txtTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTime.Location = New System.Drawing.Point(187, 133)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(178, 23)
        Me.txtTime.TabIndex = 12
        '
        'txtClassroom
        '
        Me.txtClassroom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtClassroom.Location = New System.Drawing.Point(3, 133)
        Me.txtClassroom.Name = "txtClassroom"
        Me.txtClassroom.ReadOnly = True
        Me.txtClassroom.Size = New System.Drawing.Size(178, 23)
        Me.txtClassroom.TabIndex = 11
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnCreateSchedule, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBrowseClassroom, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDay, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBrowseTime, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTime, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtClassroom, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBrowseDays, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(555, 260)
        Me.TableLayoutPanel1.TabIndex = 18
        '
        'frmScheduleCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 260)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.WeLearnLMS.My.MySettings.Default, "MainFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.WeLearnLMS.My.MySettings.Default.MainFont
        Me.Name = "frmScheduleCreator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmScheduleCreator"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCreateSchedule As System.Windows.Forms.Button
    Friend WithEvents txtDay As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBrowseDays As System.Windows.Forms.Button
    Friend WithEvents btnBrowseTime As System.Windows.Forms.Button
    Friend WithEvents btnBrowseClassroom As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents txtClassroom As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
