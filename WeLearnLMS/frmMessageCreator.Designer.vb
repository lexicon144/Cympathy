﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Time Stamp"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Sender ID"
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(79, 86)
        Me.txtMessage.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMessage.MaxLength = 70
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(184, 97)
        Me.txtMessage.TabIndex = 15
        '
        'txtSenderID
        '
        Me.txtSenderID.Location = New System.Drawing.Point(79, 41)
        Me.txtSenderID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSenderID.Name = "txtSenderID"
        Me.txtSenderID.ReadOnly = True
        Me.txtSenderID.Size = New System.Drawing.Size(97, 20)
        Me.txtSenderID.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 65)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Receiver ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 86)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Message"
        '
        'txtReceiverID
        '
        Me.txtReceiverID.Location = New System.Drawing.Point(79, 63)
        Me.txtReceiverID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtReceiverID.Name = "txtReceiverID"
        Me.txtReceiverID.ReadOnly = True
        Me.txtReceiverID.Size = New System.Drawing.Size(97, 20)
        Me.txtReceiverID.TabIndex = 14
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'txtTimeStamp
        '
        Me.txtTimeStamp.AutoSize = True
        Me.txtTimeStamp.Location = New System.Drawing.Point(76, 9)
        Me.txtTimeStamp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtTimeStamp.Name = "txtTimeStamp"
        Me.txtTimeStamp.Size = New System.Drawing.Size(56, 13)
        Me.txtTimeStamp.TabIndex = 22
        Me.txtTimeStamp.TabStop = True
        Me.txtTimeStamp.Text = "timeStamp"
        '
        'txtReceiverNAME
        '
        Me.txtReceiverNAME.AutoSize = True
        Me.txtReceiverNAME.Location = New System.Drawing.Point(177, 65)
        Me.txtReceiverNAME.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtReceiverNAME.Name = "txtReceiverNAME"
        Me.txtReceiverNAME.Size = New System.Drawing.Size(39, 13)
        Me.txtReceiverNAME.TabIndex = 21
        Me.txtReceiverNAME.Text = "Label6"
        '
        'txtSenderNAME
        '
        Me.txtSenderNAME.AutoSize = True
        Me.txtSenderNAME.Location = New System.Drawing.Point(177, 43)
        Me.txtSenderNAME.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtSenderNAME.Name = "txtSenderNAME"
        Me.txtSenderNAME.Size = New System.Drawing.Size(39, 13)
        Me.txtSenderNAME.TabIndex = 20
        Me.txtSenderNAME.Text = "Label5"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(188, 188)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmMessageCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 225)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.txtSenderID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtReceiverID)
        Me.Controls.Add(Me.txtTimeStamp)
        Me.Controls.Add(Me.txtReceiverNAME)
        Me.Controls.Add(Me.txtSenderNAME)
        Me.Name = "frmMessageCreator"
        Me.Text = "frmFeedbackCreator"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
