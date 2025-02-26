<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Me.Guna2Elipse5 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse4 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.MomPanel = New System.Windows.Forms.Panel()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.LoginButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.read_user = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2HtmlToolTip1 = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.MomPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse5
        '
        Me.Guna2Elipse5.BorderRadius = 8
        '
        'Guna2Elipse4
        '
        Me.Guna2Elipse4.BorderRadius = 8
        '
        'Guna2Elipse3
        '
        Me.Guna2Elipse3.BorderRadius = 8
        Me.Guna2Elipse3.TargetControl = Me.Guna2ControlBox1
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 8
        Me.Guna2Elipse2.TargetControl = Me.MomPanel
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 13
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(11, 11)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(81, 23)
        Me.Guna2HtmlLabel1.TabIndex = 4
        Me.Guna2HtmlLabel1.Text = "<b><font color='white' style='font-size:16px;'>mailrip</font></b><font color='cri" &
    "mson' style='font-size:16px;'>.fun</font>"
        '
        'MomPanel
        '
        Me.MomPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MomPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.MomPanel.BackgroundImage = Global.mailrip.My.Resources.Resources.app_bg
        Me.MomPanel.Controls.Add(Me.Guna2GradientButton2)
        Me.MomPanel.Controls.Add(Me.Guna2GradientButton1)
        Me.MomPanel.Controls.Add(Me.LoginButton)
        Me.MomPanel.Controls.Add(Me.Guna2HtmlLabel2)
        Me.MomPanel.Controls.Add(Me.PictureBox1)
        Me.MomPanel.Controls.Add(Me.read_user)
        Me.MomPanel.Controls.Add(Me.Guna2Panel1)
        Me.MomPanel.Controls.Add(Me.Guna2ControlBox1)
        Me.MomPanel.Location = New System.Drawing.Point(2, 2)
        Me.MomPanel.Name = "MomPanel"
        Me.MomPanel.Size = New System.Drawing.Size(595, 435)
        Me.MomPanel.TabIndex = 1
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.Animated = True
        Me.Guna2GradientButton1.AutoRoundedCorners = True
        Me.Guna2GradientButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Guna2GradientButton1.BorderRadius = 9
        Me.Guna2GradientButton1.BorderThickness = 1
        Me.Guna2GradientButton1.CheckedState.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.CustomImages.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!)
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.Crimson
        Me.Guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Guna2GradientButton1.HoverState.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Image = Global.mailrip.My.Resources.Resources.icons8_website_18px
        Me.Guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Guna2GradientButton1.ImageOffset = New System.Drawing.Point(-1, 0)
        Me.Guna2GradientButton1.ImageSize = New System.Drawing.Size(16, 16)
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(517, 389)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.ShadowDecoration.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(33, 21)
        Me.Guna2GradientButton1.TabIndex = 17
        Me.Guna2HtmlToolTip1.SetToolTip(Me.Guna2GradientButton1, resources.GetString("Guna2GradientButton1.ToolTip"))
        '
        'LoginButton
        '
        Me.LoginButton.Animated = True
        Me.LoginButton.AutoRoundedCorners = True
        Me.LoginButton.BackColor = System.Drawing.Color.Transparent
        Me.LoginButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.LoginButton.BorderRadius = 9
        Me.LoginButton.BorderThickness = 1
        Me.LoginButton.CheckedState.Parent = Me.LoginButton
        Me.LoginButton.CustomImages.Parent = Me.LoginButton
        Me.LoginButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.LoginButton.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.LoginButton.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.ForeColor = System.Drawing.Color.Crimson
        Me.LoginButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.LoginButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.LoginButton.HoverState.Parent = Me.LoginButton
        Me.LoginButton.Image = Global.mailrip.My.Resources.Resources.icons8_discord_18px
        Me.LoginButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.LoginButton.ImageOffset = New System.Drawing.Point(-1, 0)
        Me.LoginButton.ImageSize = New System.Drawing.Size(16, 16)
        Me.LoginButton.Location = New System.Drawing.Point(556, 389)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.ShadowDecoration.Parent = Me.LoginButton
        Me.LoginButton.Size = New System.Drawing.Size(33, 21)
        Me.LoginButton.TabIndex = 13
        Me.Guna2HtmlToolTip1.SetToolTip(Me.LoginButton, resources.GetString("LoginButton.ToolTip"))
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(10, 11)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(81, 23)
        Me.Guna2HtmlLabel2.TabIndex = 10
        Me.Guna2HtmlLabel2.Text = "<b><font color='white' style='font-size:16px;'>mailrip</font></b><font color='cri" &
    "mson' style='font-size:16px;'>.fun</font>"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.mailrip.My.Resources.Resources.icons8_male_user_32px
        Me.PictureBox1.Location = New System.Drawing.Point(8, 396)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(14, 14)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'read_user
        '
        Me.read_user.AutoSize = True
        Me.read_user.BackColor = System.Drawing.Color.Transparent
        Me.read_user.Font = New System.Drawing.Font("Segoe UI Semibold", 7.0!, System.Drawing.FontStyle.Bold)
        Me.read_user.ForeColor = System.Drawing.Color.Silver
        Me.read_user.Location = New System.Drawing.Point(23, 397)
        Me.read_user.Name = "read_user"
        Me.read_user.Size = New System.Drawing.Size(24, 12)
        Me.read_user.TabIndex = 8
        Me.read_user.Text = "N/A"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 1
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 415)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(595, 20)
        Me.Guna2Panel1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 12)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "mailrip.fun | 2025"
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.Animated = True
        Me.Guna2ControlBox1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.Crimson
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Silver
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(545, 11)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.PressedColor = System.Drawing.Color.Empty
        Me.Guna2ControlBox1.PressedDepth = 60
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(39, 23)
        Me.Guna2ControlBox1.TabIndex = 5
        '
        'Guna2HtmlToolTip1
        '
        Me.Guna2HtmlToolTip1.AllowLinksHandling = True
        Me.Guna2HtmlToolTip1.AutoPopDelay = 5500
        Me.Guna2HtmlToolTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Guna2HtmlToolTip1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Guna2HtmlToolTip1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2HtmlToolTip1.InitialDelay = 550
        Me.Guna2HtmlToolTip1.MaximumSize = New System.Drawing.Size(0, 0)
        Me.Guna2HtmlToolTip1.ReshowDelay = 220
        Me.Guna2HtmlToolTip1.ShowAlways = True
        Me.Guna2HtmlToolTip1.StripAmpersands = True
        Me.Guna2HtmlToolTip1.TitleFont = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlToolTip1.UseGdiPlusTextRendering = True
        '
        'Guna2GradientButton2
        '
        Me.Guna2GradientButton2.Animated = True
        Me.Guna2GradientButton2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientButton2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Guna2GradientButton2.BorderRadius = 12
        Me.Guna2GradientButton2.BorderThickness = 1
        Me.Guna2GradientButton2.CheckedState.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.CustomImages.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Guna2GradientButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!)
        Me.Guna2GradientButton2.ForeColor = System.Drawing.Color.Crimson
        Me.Guna2GradientButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Guna2GradientButton2.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Guna2GradientButton2.HoverState.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2GradientButton2.ImageOffset = New System.Drawing.Point(-1, 0)
        Me.Guna2GradientButton2.ImageSize = New System.Drawing.Size(32, 32)
        Me.Guna2GradientButton2.Location = New System.Drawing.Point(58, 99)
        Me.Guna2GradientButton2.Name = "Guna2GradientButton2"
        Me.Guna2GradientButton2.ShadowDecoration.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Size = New System.Drawing.Size(172, 120)
        Me.Guna2GradientButton2.TabIndex = 18
        Me.Guna2HtmlToolTip1.SetToolTip(Me.Guna2GradientButton2, resources.GetString("Guna2GradientButton2.ToolTip"))
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(598, 438)
        Me.Controls.Add(Me.MomPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainPage"
        Me.MomPanel.ResumeLayout(False)
        Me.MomPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Elipse5 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse4 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents MomPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents read_user As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents LoginButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2HtmlToolTip1 As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
End Class
