Public Class frmDayDialog
    Private _Day As DayOfWeek
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Friend ReadOnly Property GetDay As DayOfWeek
        Get
            Return Me._Day
        End Get
    End Property


    Private Sub frmDayDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.AddRange(DayOfWeek.GetNames(GetType(DayOfWeek)))
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me._Day = DirectCast(sender, ComboBox).SelectedIndex
    End Sub
End Class