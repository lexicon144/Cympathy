<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradesPreCompiler
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
        Me.components = New System.ComponentModel.Container()
        Me.grpCompiler = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAttendance = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQuizesAverage = New System.Windows.Forms.TextBox()
        Me.txtExamsAverage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.backgroundProgress = New System.Windows.Forms.ToolStripProgressBar()
        Me.grpCompiler.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCompiler
        '
        Me.grpCompiler.Controls.Add(Me.TableLayoutPanel1)
        Me.grpCompiler.Location = New System.Drawing.Point(13, 13)
        Me.grpCompiler.Margin = New System.Windows.Forms.Padding(4)
        Me.grpCompiler.Name = "grpCompiler"
        Me.grpCompiler.Padding = New System.Windows.Forms.Padding(4)
        Me.grpCompiler.Size = New System.Drawing.Size(389, 187)
        Me.grpCompiler.TabIndex = 2
        Me.grpCompiler.TabStop = False
        Me.grpCompiler.Text = "Compilation"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtAttendance, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtQuizesAverage, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtExamsAverage, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(381, 164)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 108)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Attendance"
        '
        'txtAttendance
        '
        Me.txtAttendance.Location = New System.Drawing.Point(194, 112)
        Me.txtAttendance.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAttendance.Name = "txtAttendance"
        Me.txtAttendance.Size = New System.Drawing.Size(132, 22)
        Me.txtAttendance.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Exams"
        '
        'txtQuizesAverage
        '
        Me.txtQuizesAverage.Location = New System.Drawing.Point(194, 4)
        Me.txtQuizesAverage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuizesAverage.Name = "txtQuizesAverage"
        Me.txtQuizesAverage.ReadOnly = True
        Me.txtQuizesAverage.Size = New System.Drawing.Size(132, 22)
        Me.txtQuizesAverage.TabIndex = 0
        '
        'txtExamsAverage
        '
        Me.txtExamsAverage.Location = New System.Drawing.Point(194, 58)
        Me.txtExamsAverage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtExamsAverage.Name = "txtExamsAverage"
        Me.txtExamsAverage.ReadOnly = True
        Me.txtExamsAverage.Size = New System.Drawing.Size(132, 22)
        Me.txtExamsAverage.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Quizes"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(298, 208)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "O K "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.backgroundProgress})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 254)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(415, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'backgroundProgress
        '
        Me.backgroundProgress.Name = "backgroundProgress"
        Me.backgroundProgress.Size = New System.Drawing.Size(100, 16)
        '
        'frmGradesPreCompiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 276)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grpCompiler)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmGradesPreCompiler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGradesPreCompiler"
        Me.grpCompiler.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpCompiler As System.Windows.Forms.GroupBox
    Friend WithEvents txtAttendance As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtExamsAverage As System.Windows.Forms.TextBox
    Friend WithEvents txtQuizesAverage As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents backgroundProgress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
