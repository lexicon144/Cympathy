<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPasswordModifier
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
        Me.txtPassword1 = New System.Windows.Forms.TextBox()
        Me.txtPassword2 = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPassword1
        '
        Me.txtPassword1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelpProvider1.SetHelpString(Me.txtPassword1, "Type in the New Password")
        Me.txtPassword1.Location = New System.Drawing.Point(3, 41)
        Me.txtPassword1.Name = "txtPassword1"
        Me.HelpProvider1.SetShowHelp(Me.txtPassword1, True)
        Me.txtPassword1.Size = New System.Drawing.Size(190, 20)
        Me.txtPassword1.TabIndex = 0
        Me.txtPassword1.UseSystemPasswordChar = True
        '
        'txtPassword2
        '
        Me.txtPassword2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelpProvider1.SetHelpString(Me.txtPassword2, "To confirm, type in the password again")
        Me.txtPassword2.Location = New System.Drawing.Point(3, 117)
        Me.txtPassword2.Name = "txtPassword2"
        Me.HelpProvider1.SetShowHelp(Me.txtPassword2, True)
        Me.txtPassword2.Size = New System.Drawing.Size(190, 20)
        Me.txtPassword2.TabIndex = 1
        Me.txtPassword2.UseSystemPasswordChar = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.HelpProvider1.SetHelpString(Me.btnOK, "Confirm and Save the password")
        Me.btnOK.Location = New System.Drawing.Point(10, 202)
        Me.btnOK.Name = "btnOK"
        Me.HelpProvider1.SetShowHelp(Me.btnOK, True)
        Me.btnOK.Size = New System.Drawing.Size(96, 29)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "Confirm"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Type your Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Type it again.. just to make sure"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPassword2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPassword1, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(9, 10)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(196, 154)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'Button1
        '
        Me.HelpProvider1.SetHelpString(Me.Button1, "peek on your password")
        Me.Button1.Location = New System.Drawing.Point(119, 202)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.HelpProvider1.SetShowHelp(Me.Button1, True)
        Me.Button1.Size = New System.Drawing.Size(86, 29)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Peek Password"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmPasswordModifier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(213, 242)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Button1)
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPasswordModifier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPasswordModifier"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtPassword1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword2 As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
