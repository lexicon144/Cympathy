﻿Module SharedMod

    Friend _SharedConnString As IConStringBuilder = New ImpConStringBuilderDeployment


    Friend Sub startupsound()
        Try
            My.Computer.Audio.Play(Application.StartupPath & "\Sounds\startup.wav", AudioPlayMode.Background)
            'My.Computer.Audio.Play(My.Resources.startup, AudioPlayMode.Background)
        Catch xxx As Exception
            Console.WriteLine(xxx.Message)
        End Try
    End Sub

    Friend Sub logoutsound()
        Try
            My.Computer.Audio.Play(Application.StartupPath & "\Sounds\logout.wav", AudioPlayMode.Background)
            'My.Computer.Audio.Play(My.Resources.logout, AudioPlayMode.Background)
        Catch xxx As Exception
            Console.WriteLine(xxx.Message)
        End Try
    End Sub

End Module
