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
        Me.SuspendLayout()
        '
        'btnScheduleViewer
        '
        Me.btnScheduleViewer.Location = New System.Drawing.Point(12, 93)
        Me.btnScheduleViewer.Name = "btnScheduleViewer"
        Me.btnScheduleViewer.Size = New System.Drawing.Size(116, 23)
        Me.btnScheduleViewer.TabIndex = 2
        Me.btnScheduleViewer.Text = "Schedule Viewer"
        Me.btnScheduleViewer.UseVisualStyleBackColor = True
        '
        'btnScheduleCreator
        '
        Me.btnScheduleCreator.Location = New System.Drawing.Point(12, 41)
        Me.btnScheduleCreator.Name = "btnScheduleCreator"
        Me.btnScheduleCreator.Size = New System.Drawing.Size(116, 23)
        Me.btnScheduleCreator.TabIndex = 3
        Me.btnScheduleCreator.Text = "Schedule Creator"
        Me.btnScheduleCreator.UseVisualStyleBackColor = True
        '
        'frmTimeManagementHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(145, 155)
        Me.Controls.Add(Me.btnScheduleCreator)
        Me.Controls.Add(Me.btnScheduleViewer)
        Me.Name = "frmTimeManagementHub"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTimeManagementHub"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnScheduleViewer As System.Windows.Forms.Button
    Friend WithEvents btnScheduleCreator As System.Windows.Forms.Button
End Class
