<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticleHub
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
        Me.btnView = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtArticleID = New System.Windows.Forms.TextBox()
        Me.txtArticleName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtArticleBase = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(254, 214)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 23)
        Me.btnView.TabIndex = 0
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(398, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'txtArticleID
        '
        Me.txtArticleID.Location = New System.Drawing.Point(99, 168)
        Me.txtArticleID.Name = "txtArticleID"
        Me.txtArticleID.ReadOnly = True
        Me.txtArticleID.Size = New System.Drawing.Size(100, 20)
        Me.txtArticleID.TabIndex = 3
        '
        'txtArticleName
        '
        Me.txtArticleName.Location = New System.Drawing.Point(99, 195)
        Me.txtArticleName.Name = "txtArticleName"
        Me.txtArticleName.ReadOnly = True
        Me.txtArticleName.Size = New System.Drawing.Size(100, 20)
        Me.txtArticleName.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Article ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Article Name"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(335, 185)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 8
        Me.btnOK.Text = "O K"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtArticleBase
        '
        Me.txtArticleBase.Location = New System.Drawing.Point(99, 221)
        Me.txtArticleBase.Name = "txtArticleBase"
        Me.txtArticleBase.ReadOnly = True
        Me.txtArticleBase.Size = New System.Drawing.Size(100, 20)
        Me.txtArticleBase.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Article Base"
        '
        'frmArticleHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 252)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtArticleBase)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtArticleName)
        Me.Controls.Add(Me.txtArticleID)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnView)
        Me.Name = "frmArticleHub"
        Me.Text = "frmArticleHub"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtArticleID As System.Windows.Forms.TextBox
    Friend WithEvents txtArticleName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtArticleBase As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
