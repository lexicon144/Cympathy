''' <summary>
''' Interface to verify textbox input
''' </summary>
''' <remarks></remarks>
Public Interface IVerifyTextInput
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Subject">String to be validate</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Verify(ByVal Subject As String) As Boolean
End Interface
