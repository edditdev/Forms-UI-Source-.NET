Imports Guna.UI2.WinForms

Public Class Client
    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim animateWindow As New Guna2AnimateWindow(Me)
        animateWindow.AnimationType = animateWindow.AnimateWindowType.AW_SLIDE
        animateWindow.Interval = 400
        animateWindow.SetAnimateWindow(Me, True)
        MomPanel.Location = New Point(1, 1)
    End Sub
End Class