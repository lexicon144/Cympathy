Public Class ImpCheaterExistsI386CheatEngine
    Implements ICheaterExists

    Public Sub New()

    End Sub

    Public Function CheaterExists() As Boolean Implements ICheaterExists.CheaterExists
        Dim p As Process() = Process.GetProcessesByName("cheatengine-i386")
        Return (p.Count > 0)
    End Function
End Class
