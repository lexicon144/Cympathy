Public Class ContextVerification

    Private _Strategy As New Dictionary(Of VMethodology, IVerifyTextInput)
    ''' <summary>
    ''' THIS CONSTUCTS THE CONTEXT
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Console.WriteLine("Instantiated " & Me.ToString)
        With _Strategy

            .Add(VMethodology.Numbers, New StrategyVerifyNumbers)
            .Add(VMethodology.Text, New StrategyVerifyNumbers)
            .Add(VMethodology.Username, New StrategyVerifyUsername)
            .Add(VMethodology.Landline, New StrategyVerifyLandline)
            .Add(VMethodology.Cellular, New StrategyVerifyCellularNumber)
            .Add(VMethodology.VerySimple, New StrategyVerifyVerySimiple)
            .Add(VMethodology.Address, New StrategyVerifyUsername)
            .Add(VMethodology.IPAddress, New StrategyVerifyIPv4)

        End With
    End Sub
    ''' <summary>
    ''' Use the verification method implied with accordance to the designated ENUMERATION chosen
    ''' </summary>
    ''' <param name="Methodology"></param>
    ''' <param name="Q"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function Verify(ByRef Methodology As VMethodology, ByVal Q As String) As Boolean
        Return _Strategy(Methodology).Verify(Q)
    End Function
End Class
