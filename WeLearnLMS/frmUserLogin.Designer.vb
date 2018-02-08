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
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(61, 141)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(159, 17)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Register a New Account"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(109, 66)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(1)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(115, 28)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(23, 39)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(1)
        Me.txtPassword.MaxLength = 18
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(10084)
        Me.txtPassword.Size = New System.Drawing.Size(200, 22)
        Me.txtPassword.TabIndex = 5
        Me.txtPassword.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(23, 12)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(1)
        Me.txtUsername.MaxLength = 50
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(200, 22)
        Me.txtUsername.TabIndex = 4
        Me.txtUsername.Text = "Username"
        '
        'BackgroundWorker1
        '
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Enabled = False
        Me.LinkLabel2.Location = New System.Drawing.Point(72, 178)
        Me.LinkLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(153, 17)
        Me.LinkLabel2.TabIndex = 8
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Forgot your password?"
        '
        'lblChangeServer
        '
        Me.lblChangeServer.AutoSize = True
        Me.lblChangeServer.Location = New System.Drawing.Point(120, 214)
        Me.lblChangeServer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblChangeServer.Name = "lblChangeServer"
        Me.lblChangeServer.Size = New System.Drawing.Size(100, 17)
        Me.lblChangeServer.TabIndex = 9
        Me.lblChangeServer.TabStop = True
        Me.lblChangeServer.Text = "Specify Server"
        '
        'frmUserLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 242)
        Me.Controls.Add(Me.lblChangeServer)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmUserLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
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

End Class
