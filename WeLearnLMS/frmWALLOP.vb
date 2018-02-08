Public Class frmWALLOP
    Private Time As Int16 = 3

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Time = 0 Then

            Me.Close()
        Else
            Time -= 1
            lblcount.Text = Time.ToString

            If Time = 0 Then

                Me.Label1.Visible = True
                Me.lblcount.Visible = False
            End If
        End If

    End Sub

    Private Sub frmWALLOP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class