<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudyHub
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
        Me.btnCreateQuiz = New System.Windows.Forms.Button()
        Me.btnViewer = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCreateQuiz
        '
        Me.btnCreateQuiz.Location = New System.Drawing.Point(356, 339)
        Me.btnCreateQuiz.Name = "btnCreateQuiz"
        Me.btnCreateQuiz.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateQuiz.TabIndex = 0
        Me.btnCreateQuiz.Text = "Create Quiz"
        Me.btnCreateQuiz.UseVisualStyleBackColor = True
        '
        'btnViewer
        '
        Me.btnViewer.Location = New System.Drawing.Point(437, 339)
        Me.btnViewer.Name = "btnViewer"
        Me.btnViewer.Size = New System.Drawing.Size(75, 23)
        Me.btnViewer.TabIndex = 1
        Me.btnViewer.Text = "Viewer"
        Me.btnViewer.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 90)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(500, 198)
        Me.DataGridView1.TabIndex = 2
        '
        'frmStudyHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 374)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnViewer)
        Me.Controls.Add(Me.btnCreateQuiz)
        Me.Name = "frmStudyHub"
        Me.Text = "frmStudyHub"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCreateQuiz As System.Windows.Forms.Button
    Friend WithEvents btnViewer As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
