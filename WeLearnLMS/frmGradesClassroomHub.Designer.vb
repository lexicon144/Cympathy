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
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCreateGrades
        '
        Me.btnCreateGrades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCreateGrades.Location = New System.Drawing.Point(168, 4)
        Me.btnCreateGrades.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreateGrades.Name = "btnCreateGrades"
        Me.btnCreateGrades.Size = New System.Drawing.Size(157, 254)
        Me.btnCreateGrades.TabIndex = 1
        Me.btnCreateGrades.Text = "Create Grades"
        Me.btnCreateGrades.UseVisualStyleBackColor = True
        '
        'btnViewGrades
        '
        Me.btnViewGrades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnViewGrades.Location = New System.Drawing.Point(3, 3)
        Me.btnViewGrades.Name = "btnViewGrades"
        Me.btnViewGrades.Size = New System.Drawing.Size(158, 256)
        Me.btnViewGrades.TabIndex = 2
        Me.btnViewGrades.Text = "View Grades"
        Me.btnViewGrades.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnCreateGrades, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnViewGrades, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(329, 262)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'frmGradesClassroomHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 286)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmGradesClassroomHub"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGradesClassroomHub"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCreateGrades As System.Windows.Forms.Button
    Friend WithEvents btnViewGrades As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
