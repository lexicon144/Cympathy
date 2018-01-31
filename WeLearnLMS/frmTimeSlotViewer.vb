Public Class frmTimeSlotViewer

    Private _ThisTimeslot As New c_Timeslot

    Public Sub New(ByRef ThisTimeslot As c_Timeslot)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._ThisTimeslot = ThisTimeslot
    End Sub

    Private Sub frmTimeSlotViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me

            .txtClassroomDescription.Text = ._ThisTimeslot.Classroom.ClassroomDesc
            .txtClassroomID.Text = ._ThisTimeslot.Classroom.ClassroomId
            .txtClassroomName.Text = ._ThisTimeslot.Classroom.ClassroomName
            .txtClassroomType.Text = ._ThisTimeslot.Classroom.ClassType

            .txtTimeDescription.Text = _ThisTimeslot.Time.TimeDescription
            .txtTimeID.Text = _ThisTimeslot.Time.TimeID
            .txtTimestart.Text = _ThisTimeslot.Time.TimeStart
        End With
    End Sub
End Class