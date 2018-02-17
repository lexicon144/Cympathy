<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradesClassroomHub
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
        Me.btnCreateGrades = New System.Windows.Forms.Button()
        Me.btnViewGrades = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelProfessorsOnly = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanelProfessorsOnly.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCreateGrades
        '
        Me.btnCreateGrades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCreateGrades.Location = New System.Drawing.Point(0, 0)
        Me.btnCreateGrades.Name = "btnCreateGrades"
        Me.btnCreateGrades.Size = New System.Drawing.Size(145, 81)
        Me.btnCreateGrades.TabIndex = 1
        Me.btnCreateGrades.Text = "Create Grades"
        Me.btnCreateGrades.UseVisualStyleBackColor = True
        '
        'btnViewGrades
        '
        Me.btnViewGrades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnViewGrades.Location = New System.Drawing.Point(2, 2)
        Me.btnViewGrades.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewGrades.Name = "btnViewGrades"
        Me.btnViewGrades.Size = New System.Drawing.Size(147, 83)
        Me.btnViewGrades.TabIndex = 2
        Me.btnViewGrades.Text = "View Grades"
        Me.btnViewGrades.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PanelProfessorsOnly, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnViewGrades, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(302, 87)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'PanelProfessorsOnly
        '
        Me.PanelProfessorsOnly.Controls.Add(Me.btnCreateGrades)
        Me.PanelProfessorsOnly.Location = New System.Drawing.Point(154, 3)
        Me.PanelProfessorsOnly.Name = "PanelProfessorsOnly"
        Me.PanelProfessorsOnly.Size = New System.Drawing.Size(145, 81)
        Me.PanelProfessorsOnly.TabIndex = 4
        '
        'frmGradesClassroomHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 87)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.WeLearnLMS.My.MySettings.Default, "MainFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.WeLearnLMS.My.MySettings.Default.MainFont
        Me.Name = "frmGradesClassroomHub"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGradesClassroomHub"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PanelProfessorsOnly.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCreateGrades As System.Windows.Forms.Button
    Friend WithEvents btnViewGrades As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanelProfessorsOnly As System.Windows.Forms.Panel
End Class
