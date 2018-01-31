<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRankingHub
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
        Me.btnProfessors = New System.Windows.Forms.Button()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnProfessors
        '
        Me.btnProfessors.Location = New System.Drawing.Point(184, 12)
        Me.btnProfessors.Name = "btnProfessors"
        Me.btnProfessors.Size = New System.Drawing.Size(75, 23)
        Me.btnProfessors.TabIndex = 0
        Me.btnProfessors.Text = "Professors"
        Me.btnProfessors.UseVisualStyleBackColor = True
        '
        'btnStudent
        '
        Me.btnStudent.Location = New System.Drawing.Point(184, 41)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(75, 23)
        Me.btnStudent.TabIndex = 1
        Me.btnStudent.Text = "Students"
        Me.btnStudent.UseVisualStyleBackColor = True
        '
        'frmRankingHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 80)
        Me.Controls.Add(Me.btnStudent)
        Me.Controls.Add(Me.btnProfessors)
        Me.Name = "frmRankingHub"
        Me.Text = "frmRankingHub"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnProfessors As System.Windows.Forms.Button
    Friend WithEvents btnStudent As System.Windows.Forms.Button
End Class
