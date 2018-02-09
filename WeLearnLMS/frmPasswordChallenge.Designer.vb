<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPasswordChallenge
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
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(91, 126)
        Me.txtAnswer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(132, 22)
        Me.txtAnswer.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 129)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Answer"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(91, 27)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(132, 90)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Challenge"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(124, 158)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 28)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "O K "
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmPasswordChallenge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 210)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAnswer)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmPasswordChallenge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPasswordChallenge"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class
