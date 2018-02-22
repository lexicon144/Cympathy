Public Class frmTimeManagementHub

    Private _MainCredentials As New c_MainCredentials

    Public Sub New(ByRef MainCredentials As c_MainCredentials)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._MainCredentials = MainCredentials

    End Sub

    Private Sub btnScheduleViewer_Click(sender As Object, e As EventArgs) Handles btnScheduleViewer.Click
        Dim viewer As New frmScheduleViewer()
        viewer.ShowDialog()
    End Sub


    Private Sub btnScheduleCreator_Click(sender As Object, e As EventArgs) Handles btnScheduleCreator.Click
        Dim creator As New frmScheduleCreator()
        creator.ShowDialog()
    End Sub

    Private Sub frmTimeManagementHub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _SharedAdvancedCredentials.MyUserType = c_MainCredentials.UserType.STU Then
            btnScheduleCreator.Enabled = False
            btnLifeSpan.Enabled = False
        End If
    End Sub

    Private Sub btnLifeSpan_Click(sender As Object, e As EventArgs) Handles btnLifeSpan.Click
        Dim Lifespan As New frmScheduleClassroomLifeSpanCreator(_SharedClassroom.ClassroomId)
        Lifespan.ShowDialog()
    End Sub
End Class