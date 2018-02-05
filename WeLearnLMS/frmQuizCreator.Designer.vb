<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuizCreator
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.rtbXMLPreview = New System.Windows.Forms.RichTextBox()
        Me.grpXmlPreview = New System.Windows.Forms.GroupBox()
        Me.btnEditor = New System.Windows.Forms.Button()
        Me.txtQuizName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQuizType = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpXmlPreview.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(404, 288)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'rtbXMLPreview
        '
        Me.rtbXMLPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbXMLPreview.Location = New System.Drawing.Point(3, 16)
        Me.rtbXMLPreview.Name = "rtbXMLPreview"
        Me.rtbXMLPreview.ReadOnly = True
        Me.rtbXMLPreview.Size = New System.Drawing.Size(381, 219)
        Me.rtbXMLPreview.TabIndex = 1
        Me.rtbXMLPreview.Text = ""
        '
        'grpXmlPreview
        '
        Me.grpXmlPreview.Controls.Add(Me.rtbXMLPreview)
        Me.grpXmlPreview.Location = New System.Drawing.Point(11, 73)
        Me.grpXmlPreview.Name = "grpXmlPreview"
        Me.grpXmlPreview.Size = New System.Drawing.Size(387, 238)
        Me.grpXmlPreview.TabIndex = 2
        Me.grpXmlPreview.TabStop = False
        Me.grpXmlPreview.Text = "XML Preview"
        '
        'btnEditor
        '
        Me.btnEditor.Location = New System.Drawing.Point(404, 259)
        Me.btnEditor.Name = "btnEditor"
        Me.btnEditor.Size = New System.Drawing.Size(75, 23)
        Me.btnEditor.TabIndex = 3
        Me.btnEditor.Text = "Edit"
        Me.btnEditor.UseVisualStyleBackColor = True
        '
        'txtQuizName
        '
        Me.txtQuizName.Location = New System.Drawing.Point(79, 12)
        Me.txtQuizName.Name = "txtQuizName"
        Me.txtQuizName.Size = New System.Drawing.Size(100, 20)
        Me.txtQuizName.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Quiz Name"
        '
        'txtQuizType
        '
        Me.txtQuizType.Location = New System.Drawing.Point(79, 38)
        Me.txtQuizType.Name = "txtQuizType"
        Me.txtQuizType.ReadOnly = True
        Me.txtQuizType.Size = New System.Drawing.Size(100, 20)
        Me.txtQuizType.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Quiz Type"
        '
        'frmQuizCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 323)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtQuizType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtQuizName)
        Me.Controls.Add(Me.btnEditor)
        Me.Controls.Add(Me.grpXmlPreview)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "frmQuizCreator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmQuizCreator"
        Me.grpXmlPreview.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents rtbXMLPreview As System.Windows.Forms.RichTextBox
    Friend WithEvents grpXmlPreview As System.Windows.Forms.GroupBox
    Friend WithEvents btnEditor As System.Windows.Forms.Button
    Friend WithEvents txtQuizName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtQuizType As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
