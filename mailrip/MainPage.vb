Imports Guna.UI2.WinForms

Public Class MainPage


    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        read_user.Text = saved_username

        Dim animateWindow As New Guna2AnimateWindow(Me)
        animateWindow.AnimationType = Guna2AnimateWindow.AnimateWindowType.AW_SLIDE
        animateWindow.Interval = 400
        animateWindow.SetAnimateWindow(Me, True)
        MomPanel.Location = New Point(1, 1)
    End Sub

    Private Sub MomPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class