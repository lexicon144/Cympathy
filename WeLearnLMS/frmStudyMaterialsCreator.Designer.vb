<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudyMaterialsCreator
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
        Me.txtMaterialName = New System.Windows.Forms.TextBox()
        Me.txtMaterialDescription = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddMaterial = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtMaterialName
        '
        Me.txtMaterialName.Location = New System.Drawing.Point(122, 12)
        Me.txtMaterialName.Name = "txtMaterialName"
        Me.txtMaterialName.Size = New System.Drawing.Size(164, 20)
        Me.txtMaterialName.TabIndex = 0
        '
        'txtMaterialDescription
        '
        Me.txtMaterialDescription.Location = New System.Drawing.Point(122, 39)
        Me.txtMaterialDescription.Multiline = True
        Me.txtMaterialDescription.Name = "txtMaterialDescription"
        Me.txtMaterialDescription.Size = New System.Drawing.Size(164, 86)
        Me.txtMaterialDescription.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Material Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Material Description"
        '
        'btnAddMaterial
        '
        Me.btnAddMaterial.Location = New System.Drawing.Point(211, 131)
        Me.btnAddMaterial.Name = "btnAddMaterial"
        Me.btnAddMaterial.Size = New System.Drawing.Size(75, 23)
        Me.btnAddMaterial.TabIndex = 4
        Me.btnAddMaterial.Text = "Add"
        Me.btnAddMaterial.UseVisualStyleBackColor = True
        '
        'frmStudyMaterialsCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 165)
        Me.Controls.Add(Me.btnAddMaterial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMaterialDescription)
        Me.Controls.Add(Me.txtMaterialName)
        Me.Name = "frmStudyMaterialsCreator"
        Me.Text = "frmStudyMaterialsCreator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMaterialName As System.Windows.Forms.TextBox
    Friend WithEvents txtMaterialDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAddMaterial As System.Windows.Forms.Button
End Class
