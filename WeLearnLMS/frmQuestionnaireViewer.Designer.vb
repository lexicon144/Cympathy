<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestionnaireViewer
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tttIndex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tttQuestionBase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tttDistractor1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tttDistractor2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tttDistractor3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tttDistractor4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tttAns = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tttActionButton = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tttIndex, Me.tttQuestionBase, Me.tttDistractor1, Me.tttDistractor2, Me.tttDistractor3, Me.tttDistractor4, Me.tttAns, Me.tttActionButton})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(426, 191)
        Me.DataGridView1.TabIndex = 0
        '
        'tttIndex
        '
        Me.tttIndex.HeaderText = "INDEX"
        Me.tttIndex.Name = "tttIndex"
        Me.tttIndex.ReadOnly = True
        '
        'tttQuestionBase
        '
        Me.tttQuestionBase.HeaderText = "Question"
        Me.tttQuestionBase.Name = "tttQuestionBase"
        Me.tttQuestionBase.ReadOnly = True
        '
        'tttDistractor1
        '
        Me.tttDistractor1.HeaderText = "Disc1"
        Me.tttDistractor1.Name = "tttDistractor1"
        Me.tttDistractor1.ReadOnly = True
        '
        'tttDistractor2
        '
        Me.tttDistractor2.HeaderText = "Disc2"
        Me.tttDistractor2.Name = "tttDistractor2"
        Me.tttDistractor2.ReadOnly = True
        '
        'tttDistractor3
        '
        Me.tttDistractor3.HeaderText = "Disc3"
        Me.tttDistractor3.Name = "tttDistractor3"
        Me.tttDistractor3.ReadOnly = True
        '
        'tttDistractor4
        '
        Me.tttDistractor4.HeaderText = "Disc4"
        Me.tttDistractor4.Name = "tttDistractor4"
        Me.tttDistractor4.ReadOnly = True
        '
        'tttAns
        '
        Me.tttAns.HeaderText = "ANS"
        Me.tttAns.Name = "tttAns"
        Me.tttAns.ReadOnly = True
        '
        'tttActionButton
        '
        Me.tttActionButton.HeaderText = "Select"
        Me.tttActionButton.Name = "tttActionButton"
        Me.tttActionButton.ReadOnly = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(445, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(321, 96)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(472, 114)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(472, 138)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(472, 162)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton3.TabIndex = 4
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(471, 185)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton4.TabIndex = 5
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'frmQuestionnaireViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 227)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmQuestionnaireViewer"
        Me.Text = "frmQuestionnaireViewer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tttIndex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tttQuestionBase As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tttDistractor1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tttDistractor2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tttDistractor3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tttDistractor4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tttAns As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tttActionButton As System.Windows.Forms.DataGridViewButtonColumn
End Class
