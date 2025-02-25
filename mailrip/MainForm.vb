'#################################           
'#  mailrip.fun source by eddit  #
'#################################

'# HOST: mailrip.fun (:80, 3125, 8088) 
'# Addional dir's: /loader/


Imports System.Net.Http
Imports Guna.UI2.WinForms
Imports mailrip.Server
Imports System.Media
Public Class MainForm
    Dim dll As String
    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim animateWindow As New Guna2AnimateWindow(Me)
        animateWindow.AnimationType = Guna2AnimateWindow.AnimateWindowType.AW_SLIDE
        animateWindow.Interval = 400
        animateWindow.SetAnimateWindow(Me, True)
        MomPanel.Location = New Point(1, 1)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If rm_box.Checked = False Then
            rm_box.Checked = True
        Else
            rm_box.Checked = False
        End If
    End Sub

    Private Async Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        AttmptLogin()
    End Sub

    Private Sub errorpage_closer_Tick(sender As Object, e As EventArgs) Handles errorpage_closer.Tick
        Animator.Hide(errorpage)
        errorpage_closer.Stop()
    End Sub
    Sub playwrongpass()
        Dim player2 As New SoundPlayer(My.Resources._error)
        player2.Play()
    End Sub


    Private Sub usernametxt_TextChanged(sender As Object, e As EventArgs) Handles usernametxt.TextChanged
        Dim player1 As New SoundPlayer(My.Resources.typin)
        player1.Play()
    End Sub
End Class