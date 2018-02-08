<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudyMaterialsHub
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
        Me.txtMaterialID = New System.Windows.Forms.TextBox()
        Me.txtMaterialName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaterialDescription = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 15)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(623, 185)
        Me.DataGridView1.TabIndex = 3
        '
        'txtMaterialID
        '
        Me.txtMaterialID.Location = New System.Drawing.Point(157, 208)
        Me.txtMaterialID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMaterialID.Name = "txtMaterialID"
        Me.txtMaterialID.ReadOnly = True
        Me.txtMaterialID.Size = New System.Drawing.Size(204, 22)
        Me.txtMaterialID.TabIndex = 4
        '
        'txtMaterialName
        '
        Me.txtMaterialName.Location = New System.Drawing.Point(157, 240)
        Me.txtMaterialName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMaterialName.Name = "txtMaterialName"
        Me.txtMaterialName.ReadOnly = True
        Me.txtMaterialName.Size = New System.Drawing.Size(204, 22)
        Me.txtMaterialName.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 217)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Material ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 249)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Material Name"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(539, 306)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 28)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Text = "O K"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(539, 342)
        Me.btnView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(100, 28)
        Me.btnView.TabIndex = 9
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 276)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Material Description"
        '
        'txtMaterialDescription
        '
        Me.txtMaterialDescription.Location = New System.Drawing.Point(157, 272)
        Me.txtMaterialDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMaterialDescription.Name = "txtMaterialDescription"
        Me.txtMaterialDescription.ReadOnly = True
        Me.txtMaterialDescription.Size = New System.Drawing.Size(204, 22)
        Me.txtMaterialDescription.TabIndex = 13
        '
        'frmStudyMaterialsHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 385)
        Me.Controls.Add(Me.txtMaterialDescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMaterialName)
        Me.Controls.Add(Me.txtMaterialID)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmStudyMaterialsHub"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStudyMaterialHub"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtMaterialID As System.Windows.Forms.TextBox
    Friend WithEvents txtMaterialName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tdescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMaterialDescription As System.Windows.Forms.TextBox
End Class
