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
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(382, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'btnCreateFeedback
        '
        Me.btnCreateFeedback.Location = New System.Drawing.Point(281, 168)
        Me.btnCreateFeedback.Name = "btnCreateFeedback"
        Me.btnCreateFeedback.Size = New System.Drawing.Size(113, 23)
        Me.btnCreateFeedback.TabIndex = 1
        Me.btnCreateFeedback.Text = "Create Feedback"
        Me.btnCreateFeedback.UseVisualStyleBackColor = True
        '
        'btnViewFeedback
        '
        Me.btnViewFeedback.Location = New System.Drawing.Point(281, 197)
        Me.btnViewFeedback.Name = "btnViewFeedback"
        Me.btnViewFeedback.Size = New System.Drawing.Size(113, 23)
        Me.btnViewFeedback.TabIndex = 2
        Me.btnViewFeedback.Text = "View Feedback"
        Me.btnViewFeedback.UseVisualStyleBackColor = True
        '
        'frmMessageHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 238)
        Me.Controls.Add(Me.btnViewFeedback)
        Me.Controls.Add(Me.btnCreateFeedback)
        Me.Controls.Add(Me.DataGridView1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.WeLearnLMS.My.MySettings.Default, "MainFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.WeLearnLMS.My.MySettings.Default.MainFont
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
