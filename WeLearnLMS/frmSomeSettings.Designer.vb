<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSomeSettings
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
        Me.btnSetMainColoursSettings = New System.Windows.Forms.Button()
        Me.btnSetQuestBackgrounds = New System.Windows.Forms.Button()
        Me.btnSetFontSizeSettings = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSetMainColoursSettings
        '
        Me.btnSetMainColoursSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSetMainColoursSettings.Location = New System.Drawing.Point(3, 3)
        Me.btnSetMainColoursSettings.Name = "btnSetMainColoursSettings"
        Me.btnSetMainColoursSettings.Size = New System.Drawing.Size(143, 47)
        Me.btnSetMainColoursSettings.TabIndex = 0
        Me.btnSetMainColoursSettings.Text = "Set Main Colours"
        Me.btnSetMainColoursSettings.UseVisualStyleBackColor = True
        '
        'btnSetQuestBackgrounds
        '
        Me.btnSetQuestBackgrounds.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSetQuestBackgrounds.Location = New System.Drawing.Point(152, 3)
        Me.btnSetQuestBackgrounds.Name = "btnSetQuestBackgrounds"
        Me.btnSetQuestBackgrounds.Size = New System.Drawing.Size(143, 47)
        Me.btnSetQuestBackgrounds.TabIndex = 1
        Me.btnSetQuestBackgrounds.Text = "Set Questionnaire Viewer Backgrounds"
        Me.btnSetQuestBackgrounds.UseVisualStyleBackColor = True
        '
        'btnSetFontSizeSettings
        '
        Me.btnSetFontSizeSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSetFontSizeSettings.Location = New System.Drawing.Point(3, 56)
        Me.btnSetFontSizeSettings.Name = "btnSetFontSizeSettings"
        Me.btnSetFontSizeSettings.Size = New System.Drawing.Size(143, 47)
        Me.btnSetFontSizeSettings.TabIndex = 2
        Me.btnSetFontSizeSettings.Text = "Set My Font Size"
        Me.btnSetFontSizeSettings.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSetMainColoursSettings, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSetFontSizeSettings, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSetQuestBackgrounds, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(298, 106)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'frmSomeSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 106)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmSomeSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmSomeSettings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSetMainColoursSettings As System.Windows.Forms.Button
    Friend WithEvents btnSetQuestBackgrounds As System.Windows.Forms.Button
    Friend WithEvents btnSetFontSizeSettings As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
End Class
