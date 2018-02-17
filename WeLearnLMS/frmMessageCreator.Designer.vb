<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessageCreator
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.txtSenderID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtReceiverID = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtTimeStamp = New System.Windows.Forms.LinkLabel()
        Me.txtReceiverNAME = New System.Windows.Forms.Label()
        Me.txtSenderNAME = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnSave = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Time Stamp"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Sender ID"
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(149, 170)
        Me.txtMessage.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMessage.MaxLength = 70
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(143, 82)
        Me.txtMessage.TabIndex = 15
        '
        'txtSenderID
        '
        Me.txtSenderID.Location = New System.Drawing.Point(149, 2)
        Me.txtSenderID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSenderID.Name = "txtSenderID"
        Me.txtSenderID.ReadOnly = True
        Me.txtSenderID.Size = New System.Drawing.Size(97, 23)
        Me.txtSenderID.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Receiver ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 168)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Message"
        '
        'txtReceiverID
        '
        Me.txtReceiverID.Location = New System.Drawing.Point(149, 86)
        Me.txtReceiverID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtReceiverID.Name = "txtReceiverID"
        Me.txtReceiverID.ReadOnly = True
        Me.txtReceiverID.Size = New System.Drawing.Size(97, 23)
        Me.txtReceiverID.TabIndex = 14
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'txtTimeStamp
        '
        Me.txtTimeStamp.AutoSize = True
        Me.txtTimeStamp.Location = New System.Drawing.Point(94, 9)
        Me.txtTimeStamp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtTimeStamp.Name = "txtTimeStamp"
        Me.txtTimeStamp.Size = New System.Drawing.Size(74, 17)
        Me.txtTimeStamp.TabIndex = 22
        Me.txtTimeStamp.TabStop = True
        Me.txtTimeStamp.Text = "timeStamp"
        '
        'txtReceiverNAME
        '
        Me.txtReceiverNAME.AutoSize = True
        Me.txtReceiverNAME.Location = New System.Drawing.Point(311, 118)
        Me.txtReceiverNAME.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtReceiverNAME.Name = "txtReceiverNAME"
        Me.txtReceiverNAME.Size = New System.Drawing.Size(51, 17)
        Me.txtReceiverNAME.TabIndex = 21
        Me.txtReceiverNAME.Text = "Label6"
        '
        'txtSenderNAME
        '
        Me.txtSenderNAME.AutoSize = True
        Me.txtSenderNAME.Location = New System.Drawing.Point(311, 29)
        Me.txtSenderNAME.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtSenderNAME.Name = "txtSenderNAME"
        Me.txtSenderNAME.Size = New System.Drawing.Size(51, 17)
        Me.txtSenderNAME.TabIndex = 20
        Me.txtSenderNAME.Text = "Label5"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(229, 289)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtSenderID, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtReceiverID, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtMessage, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 29)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(294, 254)
        Me.TableLayoutPanel1.TabIndex = 25
        '
        'frmMessageCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 358)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTimeStamp)
        Me.Controls.Add(Me.txtReceiverNAME)
        Me.Controls.Add(Me.txtSenderNAME)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.WeLearnLMS.My.MySettings.Default, "MainFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.WeLearnLMS.My.MySettings.Default.MainFont
        Me.Name = "frmMessageCreator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFeedbackCreator"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents txtSenderID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtReceiverID As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtTimeStamp As System.Windows.Forms.LinkLabel
    Friend WithEvents txtReceiverNAME As System.Windows.Forms.Label
    Friend WithEvents txtSenderNAME As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
