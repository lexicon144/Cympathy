Public Class ImpDisableControlsADMIN

    Implements IDisableControls


    Public Sub DisableMe(ByRef ThisIsMe As Control) Implements IDisableControls.DisableMe
        Console.WriteLine("Ey Boss!")
    End Sub
End Class
