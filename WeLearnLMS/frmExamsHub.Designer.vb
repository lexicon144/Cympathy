<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExamsHub
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
        Me.grpExamDisplay = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtExamID = New System.Windows.Forms.TextBox()
        Me.txtExamName = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpExamDisplay.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.DataGridView1.Size = New System.Drawing.Size(346, 245)
        Me.DataGridView1.TabIndex = 8
        '
        'grpExamDisplay
        '
        Me.grpExamDisplay.Controls.Add(Me.TableLayoutPanel1)
        Me.grpExamDisplay.Location = New System.Drawing.Point(12, 263)
        Me.grpExamDisplay.Name = "grpExamDisplay"
        Me.grpExamDisplay.Size = New System.Drawing.Size(265, 100)
        Me.grpExamDisplay.TabIndex = 9
        Me.grpExamDisplay.TabStop = False
        Me.grpExamDisplay.Text = "Exam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Exam Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Exam ID"
        '
        'txtExamID
        '
        Me.txtExamID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtExamID.Location = New System.Drawing.Point(132, 3)
        Me.txtExamID.Name = "txtExamID"
        Me.txtExamID.ReadOnly = True
        Me.txtExamID.Size = New System.Drawing.Size(124, 20)
        Me.txtExamID.TabIndex = 0
        '
        'txtExamName
        '
        Me.txtExamName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtExamName.Location = New System.Drawing.Point(132, 43)
        Me.txtExamName.Name = "txtExamName"
        Me.txtExamName.ReadOnly = True
        Me.txtExamName.Size = New System.Drawing.Size(124, 20)
        Me.txtExamName.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(283, 310)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Text = "O K"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(283, 340)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 23)
        Me.btnView.TabIndex = 9
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtExamID, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtExamName, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(259, 81)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'frmExamsHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 377)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.grpExamDisplay)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmExamsHub"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmExamHub"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpExamDisplay.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents grpExamDisplay As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtExamID As System.Windows.Forms.TextBox
    Friend WithEvents txtExamName As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
