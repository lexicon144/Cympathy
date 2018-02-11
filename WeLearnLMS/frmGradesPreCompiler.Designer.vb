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
        Me.txtAttendance = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtExamsAverage = New System.Windows.Forms.TextBox()
        Me.txtQuizesAverage = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.grpCompiler.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCompiler
        '
        Me.grpCompiler.Controls.Add(Me.txtAttendance)
        Me.grpCompiler.Controls.Add(Me.Label3)
        Me.grpCompiler.Controls.Add(Me.Label2)
        Me.grpCompiler.Controls.Add(Me.Label1)
        Me.grpCompiler.Controls.Add(Me.txtExamsAverage)
        Me.grpCompiler.Controls.Add(Me.txtQuizesAverage)
        Me.grpCompiler.Location = New System.Drawing.Point(42, 91)
        Me.grpCompiler.Name = "grpCompiler"
        Me.grpCompiler.Size = New System.Drawing.Size(200, 98)
        Me.grpCompiler.TabIndex = 2
        Me.grpCompiler.TabStop = False
        Me.grpCompiler.Text = "Compilation"
        '
        'txtAttendance
        '
        Me.txtAttendance.Location = New System.Drawing.Point(94, 71)
        Me.txtAttendance.Name = "txtAttendance"
        Me.txtAttendance.Size = New System.Drawing.Size(100, 20)
        Me.txtAttendance.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Attendance"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Exams"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Quizes"
        '
        'txtExamsAverage
        '
        Me.txtExamsAverage.Location = New System.Drawing.Point(94, 45)
        Me.txtExamsAverage.Name = "txtExamsAverage"
        Me.txtExamsAverage.ReadOnly = True
        Me.txtExamsAverage.Size = New System.Drawing.Size(100, 20)
        Me.txtExamsAverage.TabIndex = 1
        '
        'txtQuizesAverage
        '
        Me.txtQuizesAverage.Location = New System.Drawing.Point(94, 19)
        Me.txtQuizesAverage.Name = "txtQuizesAverage"
        Me.txtQuizesAverage.ReadOnly = True
        Me.txtQuizesAverage.Size = New System.Drawing.Size(100, 20)
        Me.txtQuizesAverage.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(197, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
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
        'frmGradesPreCompiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grpCompiler)
        Me.Name = "frmGradesPreCompiler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGradesPreCompiler"
        Me.grpCompiler.ResumeLayout(False)
        Me.grpCompiler.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
End Class
