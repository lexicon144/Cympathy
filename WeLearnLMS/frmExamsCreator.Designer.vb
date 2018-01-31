<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExamsCreator
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
        Me.btnEditor = New System.Windows.Forms.Button()
        Me.grpXmlPreview = New System.Windows.Forms.GroupBox()
        Me.rtbXMLPreview = New System.Windows.Forms.RichTextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtExamPIN = New System.Windows.Forms.TextBox()
        Me.txtExamName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQType = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpXmlPreview.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEditor
        '
        Me.btnEditor.Location = New System.Drawing.Point(408, 318)
        Me.btnEditor.Name = "btnEditor"
        Me.btnEditor.Size = New System.Drawing.Size(75, 23)
        Me.btnEditor.TabIndex = 6
        Me.btnEditor.Text = "Edit"
        Me.btnEditor.UseVisualStyleBackColor = True
        '
        'grpXmlPreview
        '
        Me.grpXmlPreview.Controls.Add(Me.rtbXMLPreview)
        Me.grpXmlPreview.Location = New System.Drawing.Point(15, 106)
        Me.grpXmlPreview.Name = "grpXmlPreview"
        Me.grpXmlPreview.Size = New System.Drawing.Size(387, 264)
        Me.grpXmlPreview.TabIndex = 5
        Me.grpXmlPreview.TabStop = False
        Me.grpXmlPreview.Text = "XML Preview"
        '
        'rtbXMLPreview
        '
        Me.rtbXMLPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbXMLPreview.Location = New System.Drawing.Point(3, 16)
        Me.rtbXMLPreview.Name = "rtbXMLPreview"
        Me.rtbXMLPreview.ReadOnly = True
        Me.rtbXMLPreview.Size = New System.Drawing.Size(381, 245)
        Me.rtbXMLPreview.TabIndex = 1
        Me.rtbXMLPreview.Text = ""
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(408, 347)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtExamPIN
        '
        Me.txtExamPIN.Location = New System.Drawing.Point(96, 47)
        Me.txtExamPIN.Name = "txtExamPIN"
        Me.txtExamPIN.ReadOnly = True
        Me.txtExamPIN.Size = New System.Drawing.Size(100, 20)
        Me.txtExamPIN.TabIndex = 7
        '
        'txtExamName
        '
        Me.txtExamName.Location = New System.Drawing.Point(96, 21)
        Me.txtExamName.Name = "txtExamName"
        Me.txtExamName.ReadOnly = True
        Me.txtExamName.Size = New System.Drawing.Size(100, 20)
        Me.txtExamName.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Exam Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Exam PIN"
        '
        'txtQType
        '
        Me.txtQType.Location = New System.Drawing.Point(96, 73)
        Me.txtQType.Name = "txtQType"
        Me.txtQType.ReadOnly = True
        Me.txtQType.Size = New System.Drawing.Size(100, 20)
        Me.txtQType.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "QType"
        '
        'frmExamsCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 382)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtQType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtExamName)
        Me.Controls.Add(Me.txtExamPIN)
        Me.Controls.Add(Me.btnEditor)
        Me.Controls.Add(Me.grpXmlPreview)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "frmExamsCreator"
        Me.Text = "frmExamsCreator"
        Me.grpXmlPreview.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEditor As System.Windows.Forms.Button
    Friend WithEvents grpXmlPreview As System.Windows.Forms.GroupBox
    Friend WithEvents rtbXMLPreview As System.Windows.Forms.RichTextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtExamPIN As System.Windows.Forms.TextBox
    Friend WithEvents txtExamName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtQType As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
