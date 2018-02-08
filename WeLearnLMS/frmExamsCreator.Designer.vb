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
        Me.components = New System.ComponentModel.Container()
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
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelProfessorsOnly = New System.Windows.Forms.Panel()
        Me.grpXmlPreview.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelProfessorsOnly.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEditor
        '
        Me.btnEditor.Location = New System.Drawing.Point(533, 369)
        Me.btnEditor.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditor.Name = "btnEditor"
        Me.btnEditor.Size = New System.Drawing.Size(100, 28)
        Me.btnEditor.TabIndex = 6
        Me.btnEditor.Text = "Edit"
        Me.btnEditor.UseVisualStyleBackColor = True
        '
        'grpXmlPreview
        '
        Me.grpXmlPreview.Controls.Add(Me.rtbXMLPreview)
        Me.grpXmlPreview.Location = New System.Drawing.Point(9, 108)
        Me.grpXmlPreview.Margin = New System.Windows.Forms.Padding(4)
        Me.grpXmlPreview.Name = "grpXmlPreview"
        Me.grpXmlPreview.Padding = New System.Windows.Forms.Padding(4)
        Me.grpXmlPreview.Size = New System.Drawing.Size(516, 325)
        Me.grpXmlPreview.TabIndex = 5
        Me.grpXmlPreview.TabStop = False
        Me.grpXmlPreview.Text = "XML Preview"
        '
        'rtbXMLPreview
        '
        Me.rtbXMLPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbXMLPreview.Location = New System.Drawing.Point(4, 19)
        Me.rtbXMLPreview.Margin = New System.Windows.Forms.Padding(4)
        Me.rtbXMLPreview.Name = "rtbXMLPreview"
        Me.rtbXMLPreview.ReadOnly = True
        Me.rtbXMLPreview.Size = New System.Drawing.Size(508, 302)
        Me.rtbXMLPreview.TabIndex = 1
        Me.rtbXMLPreview.Text = ""
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(533, 405)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 28)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtExamPIN
        '
        Me.txtExamPIN.Location = New System.Drawing.Point(117, 36)
        Me.txtExamPIN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtExamPIN.Name = "txtExamPIN"
        Me.txtExamPIN.Size = New System.Drawing.Size(132, 22)
        Me.txtExamPIN.TabIndex = 7
        '
        'txtExamName
        '
        Me.txtExamName.Location = New System.Drawing.Point(117, 4)
        Me.txtExamName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtExamName.Name = "txtExamName"
        Me.txtExamName.Size = New System.Drawing.Size(132, 22)
        Me.txtExamName.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Exam Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 40)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Exam PIN"
        '
        'txtQType
        '
        Me.txtQType.Location = New System.Drawing.Point(117, 68)
        Me.txtQType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQType.Name = "txtQType"
        Me.txtQType.ReadOnly = True
        Me.txtQType.Size = New System.Drawing.Size(132, 22)
        Me.txtQType.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 72)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "QType"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PanelProfessorsOnly
        '
        Me.PanelProfessorsOnly.Controls.Add(Me.Label1)
        Me.PanelProfessorsOnly.Controls.Add(Me.Label3)
        Me.PanelProfessorsOnly.Controls.Add(Me.btnSave)
        Me.PanelProfessorsOnly.Controls.Add(Me.txtQType)
        Me.PanelProfessorsOnly.Controls.Add(Me.grpXmlPreview)
        Me.PanelProfessorsOnly.Controls.Add(Me.Label2)
        Me.PanelProfessorsOnly.Controls.Add(Me.btnEditor)
        Me.PanelProfessorsOnly.Controls.Add(Me.txtExamPIN)
        Me.PanelProfessorsOnly.Controls.Add(Me.txtExamName)
        Me.PanelProfessorsOnly.Location = New System.Drawing.Point(12, 12)
        Me.PanelProfessorsOnly.Name = "PanelProfessorsOnly"
        Me.PanelProfessorsOnly.Size = New System.Drawing.Size(652, 446)
        Me.PanelProfessorsOnly.TabIndex = 13
        '
        'frmExamsCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 470)
        Me.Controls.Add(Me.PanelProfessorsOnly)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmExamsCreator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmExamsCreator"
        Me.grpXmlPreview.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelProfessorsOnly.ResumeLayout(False)
        Me.PanelProfessorsOnly.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents PanelProfessorsOnly As System.Windows.Forms.Panel
End Class
