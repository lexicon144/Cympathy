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
        Me.btnDevAuto13 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RdButtonPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.mainpanel = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.RdButtonPanel.SuspendLayout()
        Me.mainpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tttIndex, Me.tttQuestionBase, Me.tttDistractor1, Me.tttDistractor2, Me.tttDistractor3, Me.tttDistractor4, Me.tttAns, Me.tttActionButton})
        Me.DataGridView1.Location = New System.Drawing.Point(5, 260)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(426, 173)
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
        Me.RichTextBox1.Location = New System.Drawing.Point(5, 52)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(426, 96)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(3, 3)
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
        Me.RadioButton2.Location = New System.Drawing.Point(216, 3)
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
        Me.RadioButton3.Location = New System.Drawing.Point(3, 53)
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
        Me.RadioButton4.Location = New System.Drawing.Point(216, 53)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton4.TabIndex = 5
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'btnDevAuto13
        '
        Me.btnDevAuto13.Location = New System.Drawing.Point(857, 10)
        Me.btnDevAuto13.Name = "btnDevAuto13"
        Me.btnDevAuto13.Size = New System.Drawing.Size(75, 23)
        Me.btnDevAuto13.TabIndex = 6
        Me.btnDevAuto13.Text = "DevAuto13"
        Me.btnDevAuto13.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(857, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(75, 20)
        Me.TextBox1.TabIndex = 7
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblHours, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMinutes, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSeconds, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(167, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(110, 43)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.ForeColor = System.Drawing.Color.Red
        Me.lblHours.Location = New System.Drawing.Point(3, 23)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(21, 13)
        Me.lblHours.TabIndex = 0
        Me.lblHours.Text = "00"
        Me.lblHours.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMinutes
        '
        Me.lblMinutes.AutoSize = True
        Me.lblMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutes.ForeColor = System.Drawing.Color.Red
        Me.lblMinutes.Location = New System.Drawing.Point(39, 23)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(21, 13)
        Me.lblMinutes.TabIndex = 1
        Me.lblMinutes.Text = "00"
        Me.lblMinutes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconds.ForeColor = System.Drawing.Color.Red
        Me.lblSeconds.Location = New System.Drawing.Point(75, 23)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(21, 13)
        Me.lblSeconds.TabIndex = 2
        Me.lblSeconds.Text = "00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "HH"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "MM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "SS"
        '
        'RdButtonPanel
        '
        Me.RdButtonPanel.ColumnCount = 2
        Me.RdButtonPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.RdButtonPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.RdButtonPanel.Controls.Add(Me.RadioButton1, 0, 0)
        Me.RdButtonPanel.Controls.Add(Me.RadioButton2, 1, 0)
        Me.RdButtonPanel.Controls.Add(Me.RadioButton3, 0, 1)
        Me.RdButtonPanel.Controls.Add(Me.RadioButton4, 1, 1)
        Me.RdButtonPanel.Location = New System.Drawing.Point(5, 154)
        Me.RdButtonPanel.Name = "RdButtonPanel"
        Me.RdButtonPanel.RowCount = 2
        Me.RdButtonPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.RdButtonPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.RdButtonPanel.Size = New System.Drawing.Size(426, 100)
        Me.RdButtonPanel.TabIndex = 9
        '
        'mainpanel
        '
        Me.mainpanel.Controls.Add(Me.RichTextBox1)
        Me.mainpanel.Controls.Add(Me.RdButtonPanel)
        Me.mainpanel.Controls.Add(Me.DataGridView1)
        Me.mainpanel.Controls.Add(Me.TableLayoutPanel1)
        Me.mainpanel.Location = New System.Drawing.Point(12, 14)
        Me.mainpanel.Name = "mainpanel"
        Me.mainpanel.Size = New System.Drawing.Size(437, 436)
        Me.mainpanel.TabIndex = 10
        '
        'frmQuestionnaireViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 462)
        Me.Controls.Add(Me.mainpanel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnDevAuto13)
        Me.Name = "frmQuestionnaireViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmQuestionnaireViewer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.RdButtonPanel.ResumeLayout(False)
        Me.RdButtonPanel.PerformLayout()
        Me.mainpanel.ResumeLayout(False)
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
    Friend WithEvents btnDevAuto13 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents tttIndex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tttQuestionBase As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tttDistractor1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tttDistractor2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tttDistractor3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tttDistractor4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tttAns As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tttActionButton As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents lblMinutes As System.Windows.Forms.Label
    Friend WithEvents RdButtonPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblSeconds As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents mainpanel As System.Windows.Forms.Panel
End Class
