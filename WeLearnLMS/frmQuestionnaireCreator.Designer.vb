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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.Datagridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Datagridview1
        '
        Me.Datagridview1.AllowUserToAddRows = False
        Me.Datagridview1.AllowUserToDeleteRows = False
        Me.Datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datagridview1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tttQuestion, Me.tttDistractor1, Me.tttDistractor2, Me.tttDistractor3, Me.tttDistractor4})
        Me.HelpProvider1.SetHelpString(Me.Datagridview1, "This is the preview of all the questions")
        Me.Datagridview1.Location = New System.Drawing.Point(230, 118)
        Me.Datagridview1.Name = "Datagridview1"
        Me.Datagridview1.ReadOnly = True
        Me.Datagridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.HelpProvider1.SetShowHelp(Me.Datagridview1, True)
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
        Me.HelpProvider1.SetHelpString(Me.txtDisc1, "Distractor Number 1")
        Me.txtDisc1.Location = New System.Drawing.Point(71, 80)
        Me.txtDisc1.Name = "txtDisc1"
        Me.HelpProvider1.SetShowHelp(Me.txtDisc1, True)
        Me.txtDisc1.Size = New System.Drawing.Size(131, 20)
        Me.txtDisc1.TabIndex = 1
        '
        'txtDisc2
        '
        Me.HelpProvider1.SetHelpString(Me.txtDisc2, "Disctractor Number 2")
        Me.txtDisc2.Location = New System.Drawing.Point(71, 110)
        Me.txtDisc2.Name = "txtDisc2"
        Me.HelpProvider1.SetShowHelp(Me.txtDisc2, True)
        Me.txtDisc2.Size = New System.Drawing.Size(131, 20)
        Me.txtDisc2.TabIndex = 2
        '
        'txtDisc3
        '
        Me.HelpProvider1.SetHelpString(Me.txtDisc3, "Distractor Number 3")
        Me.txtDisc3.Location = New System.Drawing.Point(71, 141)
        Me.txtDisc3.Name = "txtDisc3"
        Me.HelpProvider1.SetShowHelp(Me.txtDisc3, True)
        Me.txtDisc3.Size = New System.Drawing.Size(131, 20)
        Me.txtDisc3.TabIndex = 3
        '
        'txtDisc4
        '
        Me.HelpProvider1.SetHelpString(Me.txtDisc4, "This is the True Answer")
        Me.txtDisc4.Location = New System.Drawing.Point(71, 175)
        Me.txtDisc4.Name = "txtDisc4"
        Me.HelpProvider1.SetShowHelp(Me.txtDisc4, True)
        Me.txtDisc4.Size = New System.Drawing.Size(131, 20)
        Me.txtDisc4.TabIndex = 4
        '
        'txtQuestion
        '
        Me.HelpProvider1.SetHelpString(Me.txtQuestion, "This is the Main Question")
        Me.txtQuestion.Location = New System.Drawing.Point(71, 3)
        Me.txtQuestion.MaxLength = 2000
        Me.txtQuestion.Name = "txtQuestion"
        Me.HelpProvider1.SetShowHelp(Me.txtQuestion, True)
        Me.txtQuestion.Size = New System.Drawing.Size(131, 71)
        Me.txtQuestion.TabIndex = 5
        Me.txtQuestion.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Question"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Distractor 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Distractor 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Distractor 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 26)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Correct Answer"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(211, 228)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mod"
        '
        'btnSerialize
        '
        Me.btnSerialize.Location = New System.Drawing.Point(662, 352)
        Me.btnSerialize.Name = "btnSerialize"
        Me.btnSerialize.Size = New System.Drawing.Size(110, 51)
        Me.btnSerialize.TabIndex = 14
        Me.btnSerialize.Text = "Serialize"
        Me.btnSerialize.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.HelpProvider1.SetHelpString(Me.btnAdd, "Add the Question to the Datagridview")
        Me.btnAdd.Location = New System.Drawing.Point(230, 352)
        Me.btnAdd.Name = "btnAdd"
        Me.HelpProvider1.SetShowHelp(Me.btnAdd, True)
        Me.btnAdd.Size = New System.Drawing.Size(131, 51)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(230, 648)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(545, 90)
        Me.RichTextBox1.TabIndex = 16
        Me.RichTextBox1.Text = ""
        '
        'rdSQUIZ
        '
        Me.rdSQUIZ.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.rdSQUIZ, "Set This as a Short Quiz")
        Me.rdSQUIZ.Location = New System.Drawing.Point(3, 3)
        Me.rdSQUIZ.Name = "rdSQUIZ"
        Me.HelpProvider1.SetShowHelp(Me.rdSQUIZ, True)
        Me.rdSQUIZ.Size = New System.Drawing.Size(74, 17)
        Me.rdSQUIZ.TabIndex = 17
        Me.rdSQUIZ.TabStop = True
        Me.rdSQUIZ.Text = "Short Quiz"
        Me.rdSQUIZ.UseVisualStyleBackColor = True
        '
        'rdPEXAM
        '
        Me.rdPEXAM.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.rdPEXAM, "Set this as a PreExam")
        Me.rdPEXAM.Location = New System.Drawing.Point(3, 29)
        Me.rdPEXAM.Name = "rdPEXAM"
        Me.HelpProvider1.SetShowHelp(Me.rdPEXAM, True)
        Me.rdPEXAM.Size = New System.Drawing.Size(70, 17)
        Me.rdPEXAM.TabIndex = 18
        Me.rdPEXAM.TabStop = True
        Me.rdPEXAM.Text = "Pre Exam"
        Me.rdPEXAM.UseVisualStyleBackColor = True
        '
        'btnFillUpQuiz
        '
        Me.btnFillUpQuiz.Location = New System.Drawing.Point(61, 639)
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
        'rdOEXAM
        '
        Me.rdOEXAM.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.rdOEXAM, "Set this as the Official Exam")
        Me.rdOEXAM.Location = New System.Drawing.Point(3, 55)
        Me.rdOEXAM.Name = "rdOEXAM"
        Me.HelpProvider1.SetShowHelp(Me.rdOEXAM, True)
        Me.rdOEXAM.Size = New System.Drawing.Size(62, 17)
        Me.rdOEXAM.TabIndex = 20
        Me.rdOEXAM.TabStop = True
        Me.rdOEXAM.Text = "O Exam"
        Me.rdOEXAM.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.65854!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.34146!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtQuestion, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDisc1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDisc2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDisc3, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDisc4, 1, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.84211!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.35407!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.83254!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.26794!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.22488!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(205, 209)
        Me.TableLayoutPanel1.TabIndex = 21
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.TableLayoutPanel2)
        Me.HelpProvider1.SetHelpString(Me.grpOptions, "Options in creating the questionnaire")
        Me.grpOptions.Location = New System.Drawing.Point(13, 12)
        Me.grpOptions.Name = "grpOptions"
        Me.HelpProvider1.SetShowHelp(Me.grpOptions, True)
        Me.grpOptions.Size = New System.Drawing.Size(90, 100)
        Me.grpOptions.TabIndex = 21
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.rdOEXAM, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.rdSQUIZ, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.rdPEXAM, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(84, 81)
        Me.TableLayoutPanel2.TabIndex = 22
        '
        'frmQuestionnaireCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 415)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.btnFillUpQuiz)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSerialize)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Datagridview1)
        Me.HelpProvider1.SetHelpString(Me, "This is the Questionnaire Creator. `")
        Me.Name = "frmQuestionnaireCreator"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmQuestionnaireCreator"
        CType(Me.Datagridview1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grpOptions As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
End Class
