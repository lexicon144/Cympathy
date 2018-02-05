Public Class ImpCheaterExistsAMD64CheatEngine
    Implements ICheaterExists

    Public Sub New()

    End Sub
    ''' <summary>
    ''' Simple cheatengine detection
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CheaterExists() As Boolean Implements ICheaterExists.CheaterExists
        Dim p As Process()
        p = Process.GetProcessesByName("cheatengine-x86_64")
        Return (p.Count > 0)
    End Function
End Class
