Public Class frmAttendance

    Private TimeMapper As ITimeMapper

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SignIn()
        TimeMapper = New ImpTimeMapperIn()
        TimeMapper.TimeMapper(_SharedUserID, _SharedClassroom.ClassroomId)
    End Sub

    Private Sub SignOut()
        TimeMapper = New ImpTimeMapperOut()
        TimeMapper.TimeMapper(_SharedUserID, _SharedClassroom.ClassroomId)
    End Sub
End Class