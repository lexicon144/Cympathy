Module POSIXEpoch

    Public Function DateTimeToEpoch(ByVal DateTimeValue As Date) As Integer
        Try
            Return CInt(DateTimeValue.Subtract(CDate("1.1.1970 00:00:00")).TotalSeconds)
        Catch ex As System.OverflowException
            Return -1
        End Try
    End Function

    Public Function EpochToDateTime(ByVal EpochValue As Integer) As Date
        If EpochValue >= 0 Then
            Return CDate("1.1.1970 00:00:00").AddSeconds(EpochValue)
        Else
            Return CDate("1.1.1970 00:00:00")
        End If
    End Function

End Module
