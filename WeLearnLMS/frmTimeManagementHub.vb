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
End Class