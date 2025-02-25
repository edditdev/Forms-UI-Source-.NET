'#################################           
'#  mailrip.fun source by eddit  #
'#################################

'# HOST: mailrip.fun (:80, 3125, 8088) 
'# Addional dir's: /loader/


Imports System.Net.Http
Imports Guna.UI2.WinForms
Imports mailrip.Server
Public Class Client
    Dim dll As String
    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim animateWindow As New Guna2AnimateWindow(Me)
        animateWindow.AnimationType = animateWindow.AnimateWindowType.AW_SLIDE
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

    Private Async Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Try
            Using client As New HttpClient(New HttpClientHandler With {.Credentials = New Net.NetworkCredential(DecodeBase64(server_login), DecodeBase64(server_password))})
                dll = Await client.GetStringAsync("https://mailrip.fun/database/eddit/pass")
                MsgBox(dll)
            End Using
        Catch ex As Exception
            MsgBox("OOPA! " & ex.Message)
        End Try
    End Sub
End Class