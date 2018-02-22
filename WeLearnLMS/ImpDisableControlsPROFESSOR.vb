Public Class ImpDisableControlsPROFESSOR
    Implements IDisableControls

    Public Sub DisableMe(ByRef ThisIsMe As Control) Implements IDisableControls.DisableMe
        For Each elem As Control In ThisIsMe.Controls
            If elem.Name = "PanelAdminOnly" Then
                elem.Enabled = False
                elem.Visible = False
            End If
        Next
    End Sub
End Class
