Public Class ContextDisableControls
    Private _Strategies As New Dictionary(Of UserType, IDisableControls)
    Public Sub New()
        With _Strategies
            .Add(UserType.ADM, New ImpDisableControlsADMIN)
            .Add(UserType.PRO, New ImpDisableControlsPROFESSOR)
            .Add(UserType.STU, New ImpDisableControlsSTUDENT)
        End With
    End Sub

    Friend Sub DisableAllMe(ByVal UserType As UserType, ByRef ThisIsMe As Control)
        Me._Strategies(UserType).DisableMe(ThisIsMe)
    End Sub

End Class
