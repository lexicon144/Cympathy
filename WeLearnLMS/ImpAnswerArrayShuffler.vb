Public Class ImpAnswerArrayShuffler
    Implements IAnswerArrayShuffler

    Public Sub New()

    End Sub

    Public Sub Shuffle(ByRef data As String()) Implements IAnswerArrayShuffler.Shuffle

        Dim retVal As String() = New String(data.Length - 1) {}
        Dim ind As String() = New String(data.Length - 1) {}
        Dim index As Integer
        Dim rand As New Random()

        For i As Integer = 0 To data.Length - 1
            ind(i) = 0
        Next

        For i As Integer = 0 To data.Length - 1
            Do
                index = rand.[Next](data.Length)
            Loop While ind(index) <> 0

            ind(index) = 1
            retVal(i) = data(index)
        Next

        data = retVal
    End Sub


End Class
