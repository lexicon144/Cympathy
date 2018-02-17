<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScheduleReport
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
        Me.backgroundReportLoader = New System.ComponentModel.BackgroundWorker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.backgroundProgressLoader = New System.Windows.Forms.ToolStripProgressBar()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.StatusStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'backgroundReportLoader
        '
        Me.backgroundReportLoader.WorkerReportsProgress = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.backgroundProgressLoader})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 392)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(875, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'backgroundProgressLoader
        '
        Me.backgroundProgressLoader.Name = "backgroundProgressLoader"
        Me.backgroundProgressLoader.Size = New System.Drawing.Size(100, 16)
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(428, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(420, 371)
        Me.WebBrowser1.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.WebBrowser1, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(851, 377)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'frmScheduleReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 414)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "frmScheduleReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmScheduleReport"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents backgroundReportLoader As System.ComponentModel.BackgroundWorker
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents backgroundProgressLoader As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

End Class
