﻿Imports System.Net.Http
Module go_login

    Dim temp_rlogin As String
    Dim temp_rpassword As String


    Public Async Sub AttmptLogin()

        MainForm.LoginButton.Enabled = False
        MainForm.Bar.Visible = True
        Threading.Thread.Sleep(2000)
        '# CHECK IF USER EXISTS IN DATABASE
        Try
            Using client As New HttpClient(New HttpClientHandler With {.Credentials = New Net.NetworkCredential(DecodeBase64(server_login), DecodeBase64(server_password))})
                temp_rlogin = Await client.GetStringAsync($"https://mailrip.fun/database/{MainForm.usernametxt.Text}/user")
                If MainForm.usernametxt.Text.Contains($"{temp_rlogin}") Then
                    '# If found - go to next step
                    MsgBox("Istnieje" & temp_rlogin)
                End If
            End Using
        Catch ex As Exception
            MainForm.login_status.Text = "invalid username"
            MainForm.Animator.Show(MainForm.errorpage)
            MainForm.errorpage_closer.Start()
            MainForm.playwrongpass()
        End Try


        '# enable things again
        MainForm.LoginButton.Enabled = True
        MainForm.Bar.Visible = False
    End Sub



End Module
