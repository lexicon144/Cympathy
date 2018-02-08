<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessageHub
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
        Me.btnCreateFeedback = New System.Windows.Forms.Button()
        Me.btnViewFeedback = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 15)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(509, 185)
        Me.DataGridView1.TabIndex = 0
        '
        'btnCreateFeedback
        '
        Me.btnCreateFeedback.Location = New System.Drawing.Point(375, 207)
        Me.btnCreateFeedback.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCreateFeedback.Name = "btnCreateFeedback"
        Me.btnCreateFeedback.Size = New System.Drawing.Size(151, 28)
        Me.btnCreateFeedback.TabIndex = 1
        Me.btnCreateFeedback.Text = "Create Feedback"
        Me.btnCreateFeedback.UseVisualStyleBackColor = True
        '
        'btnViewFeedback
        '
        Me.btnViewFeedback.Location = New System.Drawing.Point(375, 242)
        Me.btnViewFeedback.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnViewFeedback.Name = "btnViewFeedback"
        Me.btnViewFeedback.Size = New System.Drawing.Size(151, 28)
        Me.btnViewFeedback.TabIndex = 2
        Me.btnViewFeedback.Text = "View Feedback"
        Me.btnViewFeedback.UseVisualStyleBackColor = True
        '
        'frmMessageHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 293)
        Me.Controls.Add(Me.btnViewFeedback)
        Me.Controls.Add(Me.btnCreateFeedback)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMessageHub"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFeedbackHub"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnCreateFeedback As System.Windows.Forms.Button
    Friend WithEvents btnViewFeedback As System.Windows.Forms.Button
End Class
