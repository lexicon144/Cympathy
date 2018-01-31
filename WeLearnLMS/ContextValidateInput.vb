Public Class ContextValidateInput

    Private _Strategy As New Dictionary(Of VMethodology, IVerifyTextInput)
    ''' <summary>
    ''' THIS CONSTUCTS THE CONTEXT
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Console.WriteLine("Instantiated " & Me.ToString)
        _Strategy.Add(VMethodology.Numbers, New StrategyVerifyNumbers)
        _Strategy.Add(VMethodology.Text, New StrategyVerifyNumbers)
        _Strategy.Add(VMethodology.Username, New StrategyVerifyUsername)
        _Strategy.Add(VMethodology.Landline, New StrategyVerifyLandline)
        _Strategy.Add(VMethodology.Cellular, New StrategyVerifyCellularNumber)
        _Strategy.Add(VMethodology.VerySimple, New StrategyVerifyVerySimiple)

    End Sub
    ''' <summary>
    ''' Use the verification method implied with accordance to the designated ENUMERATION chosen
    ''' </summary>
    ''' <param name="Methodology"></param>
    ''' <param name="Q"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function UseThisVerification(ByRef Methodology As VMethodology, ByVal Q As String) As Boolean
        Return _Strategy(Methodology).Verify(Q)
    End Function
End Class
