<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticleCreator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArticleCreator))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolStripBOLDEN = New System.Windows.Forms.ToolStripButton()
        Me.toolstripITALICIZE = New System.Windows.Forms.ToolStripButton()
        Me.toolstripUNDERLINE = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolstripUNDO = New System.Windows.Forms.ToolStripButton()
        Me.toolstripRedo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.toolstripFILENAME = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolstripSAVE = New System.Windows.Forms.ToolStripButton()
        Me.rtbArticleTextbox = New System.Windows.Forms.RichTextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripBOLDEN, Me.toolstripITALICIZE, Me.toolstripUNDERLINE, Me.ToolStripSeparator2, Me.toolstripUNDO, Me.toolstripRedo, Me.ToolStripSeparator3, Me.ToolStripLabel1, Me.toolstripFILENAME, Me.ToolStripSeparator1, Me.toolstripSAVE})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(562, 25)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'toolStripBOLDEN
        '
        Me.toolStripBOLDEN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripBOLDEN.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripBOLDEN.Name = "toolStripBOLDEN"
        Me.toolStripBOLDEN.Size = New System.Drawing.Size(23, 22)
        Me.toolStripBOLDEN.Text = "B"
        '
        'toolstripITALICIZE
        '
        Me.toolstripITALICIZE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolstripITALICIZE.Image = CType(resources.GetObject("toolstripITALICIZE.Image"), System.Drawing.Image)
        Me.toolstripITALICIZE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripITALICIZE.Name = "toolstripITALICIZE"
        Me.toolstripITALICIZE.Size = New System.Drawing.Size(23, 22)
        Me.toolstripITALICIZE.Text = "I"
        '
        'toolstripUNDERLINE
        '
        Me.toolstripUNDERLINE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolstripUNDERLINE.Image = CType(resources.GetObject("toolstripUNDERLINE.Image"), System.Drawing.Image)
        Me.toolstripUNDERLINE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripUNDERLINE.Name = "toolstripUNDERLINE"
        Me.toolstripUNDERLINE.Size = New System.Drawing.Size(23, 22)
        Me.toolstripUNDERLINE.Text = "U"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'toolstripUNDO
        '
        Me.toolstripUNDO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolstripUNDO.Image = CType(resources.GetObject("toolstripUNDO.Image"), System.Drawing.Image)
        Me.toolstripUNDO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripUNDO.Name = "toolstripUNDO"
        Me.toolstripUNDO.Size = New System.Drawing.Size(40, 22)
        Me.toolstripUNDO.Text = "Undo"
        '
        'toolstripRedo
        '
        Me.toolstripRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolstripRedo.Image = CType(resources.GetObject("toolstripRedo.Image"), System.Drawing.Image)
        Me.toolstripRedo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripRedo.Name = "toolstripRedo"
        Me.toolstripRedo.Size = New System.Drawing.Size(38, 22)
        Me.toolstripRedo.Text = "Redo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripLabel1.Text = "Article Name"
        '
        'toolstripFILENAME
        '
        Me.toolstripFILENAME.Name = "toolstripFILENAME"
        Me.toolstripFILENAME.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'toolstripSAVE
        '
        Me.toolstripSAVE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolstripSAVE.Image = CType(resources.GetObject("toolstripSAVE.Image"), System.Drawing.Image)
        Me.toolstripSAVE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripSAVE.Name = "toolstripSAVE"
        Me.toolstripSAVE.Size = New System.Drawing.Size(35, 22)
        Me.toolstripSAVE.Text = "Save"
        '
        'rtbArticleTextbox
        '
        Me.rtbArticleTextbox.Location = New System.Drawing.Point(0, 28)
        Me.rtbArticleTextbox.Name = "rtbArticleTextbox"
        Me.rtbArticleTextbox.Size = New System.Drawing.Size(562, 362)
        Me.rtbArticleTextbox.TabIndex = 6
        Me.rtbArticleTextbox.Text = ""
        '
        'frmArticleCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 390)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.rtbArticleTextbox)
        Me.Name = "frmArticleCreator"
        Me.Text = "frmArticleCreator"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents toolStripBOLDEN As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripITALICIZE As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripUNDERLINE As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolstripUNDO As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripRedo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents toolstripFILENAME As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolstripSAVE As System.Windows.Forms.ToolStripButton
    Friend WithEvents rtbArticleTextbox As System.Windows.Forms.RichTextBox
End Class
