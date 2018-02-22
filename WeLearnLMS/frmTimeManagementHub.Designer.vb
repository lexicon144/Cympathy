<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimeManagementHub
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
        Me.btnScheduleViewer = New System.Windows.Forms.Button()
        Me.btnScheduleCreator = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLifeSpan = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnScheduleViewer
        '
        Me.btnScheduleViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelpProvider1.SetHelpString(Me.btnScheduleViewer, "Click this to open the Schedule Viewer")
        Me.btnScheduleViewer.Location = New System.Drawing.Point(3, 3)
        Me.btnScheduleViewer.Name = "btnScheduleViewer"
        Me.HelpProvider1.SetShowHelp(Me.btnScheduleViewer, True)
        Me.btnScheduleViewer.Size = New System.Drawing.Size(218, 105)
        Me.btnScheduleViewer.TabIndex = 2
        Me.btnScheduleViewer.Text = "Schedule Viewer"
        Me.btnScheduleViewer.UseVisualStyleBackColor = True
        '
        'btnScheduleCreator
        '
        Me.btnScheduleCreator.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelpProvider1.SetHelpString(Me.btnScheduleCreator, "Click this to Create The Schedules")
        Me.btnScheduleCreator.Location = New System.Drawing.Point(227, 3)
        Me.btnScheduleCreator.Name = "btnScheduleCreator"
        Me.HelpProvider1.SetShowHelp(Me.btnScheduleCreator, True)
        Me.btnScheduleCreator.Size = New System.Drawing.Size(218, 105)
        Me.btnScheduleCreator.TabIndex = 3
        Me.btnScheduleCreator.Text = "Schedule Creator"
        Me.btnScheduleCreator.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnScheduleViewer, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnScheduleCreator, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnLifeSpan, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(674, 111)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'btnLifeSpan
        '
        Me.btnLifeSpan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProvider1.SetHelpString(Me.btnLifeSpan, "Click this to Create the Life span of the classroom")
        Me.btnLifeSpan.Location = New System.Drawing.Point(451, 3)
        Me.btnLifeSpan.Name = "btnLifeSpan"
        Me.HelpProvider1.SetShowHelp(Me.btnLifeSpan, True)
        Me.btnLifeSpan.Size = New System.Drawing.Size(220, 105)
        Me.btnLifeSpan.TabIndex = 4
        Me.btnLifeSpan.Text = "Lifespan Creator"
        Me.btnLifeSpan.UseVisualStyleBackColor = True
        '
        'frmTimeManagementHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 111)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.WeLearnLMS.My.MySettings.Default, "MainFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.WeLearnLMS.My.MySettings.Default.MainFont
        Me.Name = "frmTimeManagementHub"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTimeManagementHub"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnScheduleViewer As System.Windows.Forms.Button
    Friend WithEvents btnScheduleCreator As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnLifeSpan As System.Windows.Forms.Button
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
