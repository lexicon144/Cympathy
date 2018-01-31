<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradeFinal
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnMark = New System.Windows.Forms.Button()
        Me.btnBrowseStudent = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(387, 114)
        Me.DataGridView1.TabIndex = 0
        '
        'btnMark
        '
        Me.btnMark.Location = New System.Drawing.Point(324, 226)
        Me.btnMark.Name = "btnMark"
        Me.btnMark.Size = New System.Drawing.Size(75, 23)
        Me.btnMark.TabIndex = 1
        Me.btnMark.Text = "Mark"
        Me.btnMark.UseVisualStyleBackColor = True
        '
        'btnBrowseStudent
        '
        Me.btnBrowseStudent.Location = New System.Drawing.Point(12, 226)
        Me.btnBrowseStudent.Name = "btnBrowseStudent"
        Me.btnBrowseStudent.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseStudent.TabIndex = 2
        Me.btnBrowseStudent.Text = "Browse"
        Me.btnBrowseStudent.UseVisualStyleBackColor = True
        '
        'frmGradeFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 261)
        Me.Controls.Add(Me.btnBrowseStudent)
        Me.Controls.Add(Me.btnMark)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmGradeFinal"
        Me.Text = "frmFinalGrade"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnMark As System.Windows.Forms.Button
    Friend WithEvents btnBrowseStudent As System.Windows.Forms.Button
End Class
