<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserLogin
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
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.lblChangeServer = New System.Windows.Forms.LinkLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblclientuptime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblHH = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblMM = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblSS = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LoginTimer = New System.Windows.Forms.Timer(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(149, 231)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(123, 13)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Register a New Account"
        '
        'btnLogin
        '
        Me.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProvider1.SetHelpString(Me.btnLogin, "nooowww LOG IN!")
        Me.btnLogin.Location = New System.Drawing.Point(149, 155)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(1)
        Me.btnLogin.Name = "btnLogin"
        Me.HelpProvider1.SetShowHelp(Me.btnLogin, True)
        Me.btnLogin.Size = New System.Drawing.Size(147, 75)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelpProvider1.SetHelpString(Me.txtPassword, "Input your password here (look behind you just in case)")
        Me.txtPassword.Location = New System.Drawing.Point(149, 78)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(1)
        Me.txtPassword.MaxLength = 18
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(10084)
        Me.HelpProvider1.SetShowHelp(Me.txtPassword, True)
        Me.txtPassword.Size = New System.Drawing.Size(147, 20)
        Me.txtPassword.TabIndex = 5
        Me.txtPassword.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelpProvider1.SetHelpString(Me.txtUsername, "Input your Login Username HERE!")
        Me.txtUsername.Location = New System.Drawing.Point(149, 1)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(1)
        Me.txtUsername.MaxLength = 50
        Me.txtUsername.Name = "txtUsername"
        Me.HelpProvider1.SetShowHelp(Me.txtUsername, True)
        Me.txtUsername.Size = New System.Drawing.Size(147, 20)
        Me.txtUsername.TabIndex = 4
        Me.txtUsername.Text = "Username"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Enabled = False
        Me.LinkLabel2.Location = New System.Drawing.Point(151, 308)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(114, 13)
        Me.LinkLabel2.TabIndex = 8
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Forgot your password?"
        '
        'lblChangeServer
        '
        Me.lblChangeServer.AutoSize = True
        Me.lblChangeServer.Location = New System.Drawing.Point(151, 389)
        Me.lblChangeServer.Name = "lblChangeServer"
        Me.lblChangeServer.Size = New System.Drawing.Size(76, 13)
        Me.lblChangeServer.TabIndex = 9
        Me.lblChangeServer.TabStop = True
        Me.lblChangeServer.Text = "Specify Server"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtUsername, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblChangeServer, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPassword, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LinkLabel2, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LinkLabel1, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnLogin, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.56272!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.48746!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(297, 468)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblclientuptime, Me.lblHH, Me.lblMM, Me.lblSS})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 446)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(297, 22)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblclientuptime
        '
        Me.lblclientuptime.Name = "lblclientuptime"
        Me.lblclientuptime.Size = New System.Drawing.Size(88, 17)
        Me.lblclientuptime.Text = "Client Up-time:"
        '
        'lblHH
        '
        Me.lblHH.Name = "lblHH"
        Me.lblHH.Size = New System.Drawing.Size(25, 17)
        Me.lblHH.Text = "HH"
        '
        'lblMM
        '
        Me.lblMM.Name = "lblMM"
        Me.lblMM.Size = New System.Drawing.Size(29, 17)
        Me.lblMM.Text = "MM"
        '
        'lblSS
        '
        Me.lblSS.Name = "lblSS"
        Me.lblSS.Size = New System.Drawing.Size(19, 17)
        Me.lblSS.Text = "SS"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'LoginTimer
        '
        Me.LoginTimer.Enabled = True
        Me.LoginTimer.Interval = 1000
        '
        'frmUserLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 468)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.WeLearnLMS.My.MySettings.Default, "MainFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.WeLearnLMS.My.MySettings.Default.MainFont
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblChangeServer As System.Windows.Forms.LinkLabel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblclientuptime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblHH As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblMM As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblSS As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LoginTimer As System.Windows.Forms.Timer
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider

End Class
