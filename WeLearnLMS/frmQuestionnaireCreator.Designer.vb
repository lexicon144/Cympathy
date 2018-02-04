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
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSerialize = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.rdSQUIZ = New System.Windows.Forms.RadioButton()
        Me.rdPEXAM = New System.Windows.Forms.RadioButton()
        Me.btnFillUpQuiz = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
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
        Me.Datagridview1.Location = New System.Drawing.Point(230, 101)
        Me.Datagridview1.Name = "Datagridview1"
        Me.Datagridview1.ReadOnly = True
        Me.Datagridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datagridview1.Size = New System.Drawing.Size(542, 228)
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
        Me.txtDisc1.Location = New System.Drawing.Point(100, 121)
        Me.txtDisc1.Name = "txtDisc1"
        Me.txtDisc1.Size = New System.Drawing.Size(100, 20)
        Me.txtDisc1.TabIndex = 1
        '
        'txtDisc2
        '
        Me.txtDisc2.Location = New System.Drawing.Point(100, 148)
        Me.txtDisc2.Name = "txtDisc2"
        Me.txtDisc2.Size = New System.Drawing.Size(100, 20)
        Me.txtDisc2.TabIndex = 2
        '
        'txtDisc3
        '
        Me.txtDisc3.Location = New System.Drawing.Point(100, 174)
        Me.txtDisc3.Name = "txtDisc3"
        Me.txtDisc3.Size = New System.Drawing.Size(100, 20)
        Me.txtDisc3.TabIndex = 3
        '
        'txtDisc4
        '
        Me.txtDisc4.Location = New System.Drawing.Point(100, 200)
        Me.txtDisc4.Name = "txtDisc4"
        Me.txtDisc4.Size = New System.Drawing.Size(100, 20)
        Me.txtDisc4.TabIndex = 4
        '
        'txtQuestion
        '
        Me.txtQuestion.Location = New System.Drawing.Point(100, 19)
        Me.txtQuestion.MaxLength = 2000
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(100, 96)
        Me.txtQuestion.TabIndex = 5
        Me.txtQuestion.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Question"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Distractor 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Distractor 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Distractor 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
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
        Me.GroupBox1.Location = New System.Drawing.Point(13, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(211, 228)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mod"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(113, 75)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtTitle.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(80, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Title"
        '
        'btnSerialize
        '
        Me.btnSerialize.Location = New System.Drawing.Point(697, 335)
        Me.btnSerialize.Name = "btnSerialize"
        Me.btnSerialize.Size = New System.Drawing.Size(75, 23)
        Me.btnSerialize.TabIndex = 14
        Me.btnSerialize.Text = "Serialize"
        Me.btnSerialize.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(149, 335)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(226, 385)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(545, 185)
        Me.RichTextBox1.TabIndex = 16
        Me.RichTextBox1.Text = ""
        '
        'rdSQUIZ
        '
        Me.rdSQUIZ.AutoSize = True
        Me.rdSQUIZ.Location = New System.Drawing.Point(686, 28)
        Me.rdSQUIZ.Name = "rdSQUIZ"
        Me.rdSQUIZ.Size = New System.Drawing.Size(74, 17)
        Me.rdSQUIZ.TabIndex = 17
        Me.rdSQUIZ.TabStop = True
        Me.rdSQUIZ.Text = "Short Quiz"
        Me.rdSQUIZ.UseVisualStyleBackColor = True
        '
        'rdPEXAM
        '
        Me.rdPEXAM.AutoSize = True
        Me.rdPEXAM.Location = New System.Drawing.Point(686, 51)
        Me.rdPEXAM.Name = "rdPEXAM"
        Me.rdPEXAM.Size = New System.Drawing.Size(70, 17)
        Me.rdPEXAM.TabIndex = 18
        Me.rdPEXAM.TabStop = True
        Me.rdPEXAM.Text = "Pre Exam"
        Me.rdPEXAM.UseVisualStyleBackColor = True
        '
        'btnFillUpQuiz
        '
        Me.btnFillUpQuiz.Location = New System.Drawing.Point(12, 12)
        Me.btnFillUpQuiz.Name = "btnFillUpQuiz"
        Me.btnFillUpQuiz.Size = New System.Drawing.Size(75, 23)
        Me.btnFillUpQuiz.TabIndex = 19
        Me.btnFillUpQuiz.Text = "DevAutoFill"
        Me.btnFillUpQuiz.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmQuestionnaireCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 366)
        Me.Controls.Add(Me.btnFillUpQuiz)
        Me.Controls.Add(Me.rdPEXAM)
        Me.Controls.Add(Me.rdSQUIZ)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSerialize)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Datagridview1)
        Me.Name = "frmQuestionnaireCreator"
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
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSerialize As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents rdSQUIZ As System.Windows.Forms.RadioButton
    Friend WithEvents rdPEXAM As System.Windows.Forms.RadioButton
    Friend WithEvents btnFillUpQuiz As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
