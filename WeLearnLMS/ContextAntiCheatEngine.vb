Public Class ContextAntiCheatEngine
    Private WeLearnAC As ICheaterExists = New ImpCheaterExistsAMD64CheatEngine
    Private WeLearnAC2 As ICheaterExists = New ImpCheaterExistsI386CheatEngine
    Public Sub New()
        
    End Sub
    Friend Function AntiCheat() As Boolean
        
        Return (WeLearnAC.CheaterExists Or WeLearnAC2.CheaterExists)
    End Function

End Class
