<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestionnaireCreator
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
        Me.Datagridview1 = New System.Windows.Forms.DataGridView()
        Me.tttQuestion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tttDistractor1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tttDistractor2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tttDistractor3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tttDistractor4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDisc1 = New System.Windows.Forms.TextBox()
        Me.txtDisc2 = New System.Windows.Forms.TextBox()
        Me.txtDisc3 = New System.Windows.Forms.TextBox()
        Me.txtDisc4 = New System.Windows.Forms.TextBox()
        Me.txtQuestion = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSerialize = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.rdSQUIZ = New System.Windows.Forms.RadioButton()
        Me.rdPEXAM = New System.Windows.Forms.RadioButton()
        Me.btnFillUpQuiz = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.rdOEXAM = New System.Windows.Forms.RadioButton()
        CType(Me.Datagridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Datagridview1
        '
        Me.Datagridview1.AllowUserToAddRows = False
        Me.Datagridview1.AllowUserToDeleteRows = False
        Me.Datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datagridview1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tttQuestion, Me.tttDistractor1, Me.tttDistractor2, Me.tttDistractor3, Me.tttDistractor4})
        Me.Datagridview1.Location = New System.Drawing.Point(307, 124)
        Me.Datagridview1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Datagridview1.Name = "Datagridview1"
        Me.Datagridview1.ReadOnly = True
        Me.Datagridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datagridview1.Size = New System.Drawing.Size(723, 281)
        Me.Datagridview1.TabIndex = 0
        '
        'tttQuestion
        '
        Me.tttQuestion.HeaderText = "Question"
        Me.tttQuestion.Name = "tttQuestion"
        Me.tttQuestion.ReadOnly = True
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
        'txtDisc1
        '
        Me.txtDisc1.Location = New System.Drawing.Point(133, 149)
        Me.txtDisc1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDisc1.Name = "txtDisc1"
        Me.txtDisc1.Size = New System.Drawing.Size(132, 22)
        Me.txtDisc1.TabIndex = 1
        '
        'txtDisc2
        '
        Me.txtDisc2.Location = New System.Drawing.Point(133, 182)
        Me.txtDisc2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDisc2.Name = "txtDisc2"
        Me.txtDisc2.Size = New System.Drawing.Size(132, 22)
        Me.txtDisc2.TabIndex = 2
        '
        'txtDisc3
        '
        Me.txtDisc3.Location = New System.Drawing.Point(133, 214)
        Me.txtDisc3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDisc3.Name = "txtDisc3"
        Me.txtDisc3.Size = New System.Drawing.Size(132, 22)
        Me.txtDisc3.TabIndex = 3
        '
        'txtDisc4
        '
        Me.txtDisc4.Location = New System.Drawing.Point(133, 246)
        Me.txtDisc4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDisc4.Name = "txtDisc4"
        Me.txtDisc4.Size = New System.Drawing.Size(132, 22)
        Me.txtDisc4.TabIndex = 4
        '
        'txtQuestion
        '
        Me.txtQuestion.Location = New System.Drawing.Point(133, 23)
        Me.txtQuestion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtQuestion.MaxLength = 2000
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(132, 117)
        Me.txtQuestion.TabIndex = 5
        Me.txtQuestion.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Question"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 153)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Distractor 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 186)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Distractor 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 218)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Distractor 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 250)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Correct Answer"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtQuestion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDisc1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDisc2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDisc3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDisc4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 124)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(281, 281)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mod"
        '
        'btnSerialize
        '
        Me.btnSerialize.Location = New System.Drawing.Point(479, 412)
        Me.btnSerialize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSerialize.Name = "btnSerialize"
        Me.btnSerialize.Size = New System.Drawing.Size(100, 28)
        Me.btnSerialize.TabIndex = 14
        Me.btnSerialize.Text = "Serialize"
        Me.btnSerialize.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(199, 412)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 28)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(301, 474)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(725, 227)
        Me.RichTextBox1.TabIndex = 16
        Me.RichTextBox1.Text = ""
        '
        'rdSQUIZ
        '
        Me.rdSQUIZ.AutoSize = True
        Me.rdSQUIZ.Location = New System.Drawing.Point(929, 15)
        Me.rdSQUIZ.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdSQUIZ.Name = "rdSQUIZ"
        Me.rdSQUIZ.Size = New System.Drawing.Size(96, 21)
        Me.rdSQUIZ.TabIndex = 17
        Me.rdSQUIZ.TabStop = True
        Me.rdSQUIZ.Text = "Short Quiz"
        Me.rdSQUIZ.UseVisualStyleBackColor = True
        '
        'rdPEXAM
        '
        Me.rdPEXAM.AutoSize = True
        Me.rdPEXAM.Location = New System.Drawing.Point(929, 43)
        Me.rdPEXAM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdPEXAM.Name = "rdPEXAM"
        Me.rdPEXAM.Size = New System.Drawing.Size(89, 21)
        Me.rdPEXAM.TabIndex = 18
        Me.rdPEXAM.TabStop = True
        Me.rdPEXAM.Text = "Pre Exam"
        Me.rdPEXAM.UseVisualStyleBackColor = True
        '
        'btnFillUpQuiz
        '
        Me.btnFillUpQuiz.Location = New System.Drawing.Point(16, 15)
        Me.btnFillUpQuiz.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFillUpQuiz.Name = "btnFillUpQuiz"
        Me.btnFillUpQuiz.Size = New System.Drawing.Size(100, 28)
        Me.btnFillUpQuiz.TabIndex = 19
        Me.btnFillUpQuiz.Text = "DevAutoFill"
        Me.btnFillUpQuiz.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'rdOEXAM
        '
        Me.rdOEXAM.AutoSize = True
        Me.rdOEXAM.Location = New System.Drawing.Point(929, 71)
        Me.rdOEXAM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdOEXAM.Name = "rdOEXAM"
        Me.rdOEXAM.Size = New System.Drawing.Size(78, 21)
        Me.rdOEXAM.TabIndex = 20
        Me.rdOEXAM.TabStop = True
        Me.rdOEXAM.Text = "O Exam"
        Me.rdOEXAM.UseVisualStyleBackColor = True
        '
        'frmQuestionnaireCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 450)
        Me.Controls.Add(Me.rdOEXAM)
        Me.Controls.Add(Me.btnFillUpQuiz)
        Me.Controls.Add(Me.rdPEXAM)
        Me.Controls.Add(Me.rdSQUIZ)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSerialize)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Datagridview1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmQuestionnaireCreator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmQuestionnaireCreator"
        CType(Me.Datagridview1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Datagridview1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtDisc1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDisc2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDisc3 As System.Windows.Forms.TextBox
    Friend WithEvents txtDisc4 As System.Windows.Forms.TextBox
    Friend WithEvents txtQuestion As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tttQuestion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tttDistractor1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tttDistractor2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tttDistractor3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tttDistractor4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSerialize As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents rdSQUIZ As System.Windows.Forms.RadioButton
    Friend WithEvents rdPEXAM As System.Windows.Forms.RadioButton
    Friend WithEvents btnFillUpQuiz As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents rdOEXAM As System.Windows.Forms.RadioButton
End Class
