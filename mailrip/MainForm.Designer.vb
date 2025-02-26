<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse4 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse5 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Animator = New Guna.UI2.WinForms.Guna2Transition()
        Me.errorpage_closer = New System.Windows.Forms.Timer(Me.components)
        Me.MomPanel = New System.Windows.Forms.Panel()
        Me.errorpage = New Guna.UI2.WinForms.Guna2Panel()
        Me.login_status = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Bar = New Guna.UI2.WinForms.Guna2WinProgressIndicator()
        Me.LoginButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rm_box = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.passwordtxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.usernametxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.MomPanel.SuspendLayout()
        Me.errorpage.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 12
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 8
        Me.Guna2Elipse2.TargetControl = Me.MomPanel
        '
        'Guna2Elipse3
        '
        Me.Guna2Elipse3.BorderRadius = 8
        Me.Guna2Elipse3.TargetControl = Me.Guna2ControlBox1
        '
        'Guna2Elipse4
        '
        Me.Guna2Elipse4.BorderRadius = 8
        Me.Guna2Elipse4.TargetControl = Me.PictureBox1
        '
        'Guna2Elipse5
        '
        Me.Guna2Elipse5.BorderRadius = 8
        Me.Guna2Elipse5.TargetControl = Me.PictureBox2
        '
        'Animator
        '
        Me.Animator.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent
        Me.Animator.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 1.0!
        Me.Animator.DefaultAnimation = Animation1
        '
        'errorpage_closer
        '
        Me.errorpage_closer.Interval = 2000
        '
        'MomPanel
        '
        Me.MomPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.MomPanel.BackgroundImage = Global.mailrip.My.Resources.Resources.app_bg
        Me.MomPanel.Controls.Add(Me.errorpage)
        Me.MomPanel.Controls.Add(Me.Label1)
        Me.MomPanel.Controls.Add(Me.Guna2Panel1)
        Me.MomPanel.Controls.Add(Me.Guna2ControlBox1)
        Me.MomPanel.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Animator.SetDecoration(Me.MomPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.MomPanel.Location = New System.Drawing.Point(2, 2)
        Me.MomPanel.Name = "MomPanel"
        Me.MomPanel.Size = New System.Drawing.Size(429, 293)
        Me.MomPanel.TabIndex = 0
        '
        'errorpage
        '
        Me.errorpage.BackColor = System.Drawing.Color.Transparent
        Me.errorpage.BorderColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.errorpage.BorderRadius = 8
        Me.errorpage.BorderThickness = 1
        Me.errorpage.Controls.Add(Me.login_status)
        Me.Animator.SetDecoration(Me.errorpage, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.errorpage.FillColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.errorpage.Location = New System.Drawing.Point(153, 243)
        Me.errorpage.Name = "errorpage"
        Me.errorpage.ShadowDecoration.Parent = Me.errorpage
        Me.errorpage.Size = New System.Drawing.Size(123, 24)
        Me.errorpage.TabIndex = 8
        Me.errorpage.Visible = False
        '
        'login_status
        '
        Me.login_status.BackColor = System.Drawing.Color.Transparent
        Me.Animator.SetDecoration(Me.login_status, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.login_status.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.login_status.ForeColor = System.Drawing.Color.Silver
        Me.login_status.Location = New System.Drawing.Point(4, 4)
        Me.login_status.Name = "login_status"
        Me.login_status.Size = New System.Drawing.Size(116, 18)
        Me.login_status.TabIndex = 9
        Me.login_status.Text = "n/a"
        Me.login_status.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Animator.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(166, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "member login"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 8
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.Bar)
        Me.Guna2Panel1.Controls.Add(Me.LoginButton)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.rm_box)
        Me.Guna2Panel1.Controls.Add(Me.PictureBox2)
        Me.Guna2Panel1.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.passwordtxt)
        Me.Guna2Panel1.Controls.Add(Me.usernametxt)
        Me.Animator.SetDecoration(Me.Guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(97, 90)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(235, 134)
        Me.Guna2Panel1.TabIndex = 6
        '
        'Bar
        '
        Me.Bar.AutoStart = True
        Me.Bar.CircleSize = 0.3!
        Me.Animator.SetDecoration(Me.Bar, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Bar.Location = New System.Drawing.Point(156, 104)
        Me.Bar.Name = "Bar"
        Me.Bar.NumberOfCircles = 4
        Me.Bar.ProgressColor = System.Drawing.Color.Crimson
        Me.Bar.Size = New System.Drawing.Size(20, 20)
        Me.Bar.TabIndex = 4
        Me.Bar.Visible = False
        '
        'LoginButton
        '
        Me.LoginButton.Animated = True
        Me.LoginButton.AutoRoundedCorners = True
        Me.LoginButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.LoginButton.BorderRadius = 9
        Me.LoginButton.BorderThickness = 1
        Me.LoginButton.CheckedState.Parent = Me.LoginButton
        Me.LoginButton.CustomImages.Parent = Me.LoginButton
        Me.Animator.SetDecoration(Me.LoginButton, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LoginButton.FillColor = System.Drawing.Color.Crimson
        Me.LoginButton.FillColor2 = System.Drawing.Color.DarkRed
        Me.LoginButton.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!)
        Me.LoginButton.ForeColor = System.Drawing.Color.Silver
        Me.LoginButton.HoverState.FillColor = System.Drawing.Color.DarkRed
        Me.LoginButton.HoverState.FillColor2 = System.Drawing.Color.Crimson
        Me.LoginButton.HoverState.Parent = Me.LoginButton
        Me.LoginButton.Location = New System.Drawing.Point(85, 104)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.ShadowDecoration.Parent = Me.LoginButton
        Me.LoginButton.Size = New System.Drawing.Size(65, 21)
        Me.LoginButton.TabIndex = 8
        Me.LoginButton.Text = "login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Animator.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(53, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "save credentials"
        '
        'rm_box
        '
        Me.rm_box.Animated = True
        Me.rm_box.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.rm_box.CheckedState.BorderRadius = 2
        Me.rm_box.CheckedState.BorderThickness = 0
        Me.rm_box.CheckedState.FillColor = System.Drawing.Color.Crimson
        Me.rm_box.CheckedState.Parent = Me.rm_box
        Me.rm_box.CheckMarkColor = System.Drawing.Color.Silver
        Me.Animator.SetDecoration(Me.rm_box, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.rm_box.Location = New System.Drawing.Point(35, 84)
        Me.rm_box.Name = "rm_box"
        Me.rm_box.ShadowDecoration.Parent = Me.rm_box
        Me.rm_box.Size = New System.Drawing.Size(16, 16)
        Me.rm_box.TabIndex = 8
        Me.rm_box.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.rm_box.UncheckedState.BorderRadius = 2
        Me.rm_box.UncheckedState.BorderThickness = 1
        Me.rm_box.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.rm_box.UncheckedState.Parent = Me.rm_box
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Animator.SetDecoration(Me.PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = Global.mailrip.My.Resources.Resources.icons8_password_32px_1
        Me.PictureBox2.Location = New System.Drawing.Point(35, 56)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Animator.SetDecoration(Me.PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = Global.mailrip.My.Resources.Resources.icons8_male_user_32px
        Me.PictureBox1.Location = New System.Drawing.Point(35, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'passwordtxt
        '
        Me.passwordtxt.Animated = True
        Me.passwordtxt.AutoRoundedCorners = True
        Me.passwordtxt.BackColor = System.Drawing.Color.Transparent
        Me.passwordtxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.passwordtxt.BorderRadius = 11
        Me.passwordtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Animator.SetDecoration(Me.passwordtxt, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.passwordtxt.DefaultText = ""
        Me.passwordtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.passwordtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.passwordtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordtxt.DisabledState.Parent = Me.passwordtxt
        Me.passwordtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordtxt.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.passwordtxt.FocusedState.BorderColor = System.Drawing.Color.Crimson
        Me.passwordtxt.FocusedState.Parent = Me.passwordtxt
        Me.passwordtxt.ForeColor = System.Drawing.Color.Crimson
        Me.passwordtxt.HoverState.BorderColor = System.Drawing.Color.Crimson
        Me.passwordtxt.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.passwordtxt.HoverState.Parent = Me.passwordtxt
        Me.passwordtxt.Location = New System.Drawing.Point(30, 53)
        Me.passwordtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.passwordtxt.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.passwordtxt.PlaceholderText = "Password"
        Me.passwordtxt.SelectedText = ""
        Me.passwordtxt.ShadowDecoration.Parent = Me.passwordtxt
        Me.passwordtxt.Size = New System.Drawing.Size(174, 24)
        Me.passwordtxt.TabIndex = 10
        Me.passwordtxt.TextOffset = New System.Drawing.Point(18, 0)
        '
        'usernametxt
        '
        Me.usernametxt.Animated = True
        Me.usernametxt.AutoRoundedCorners = True
        Me.usernametxt.BackColor = System.Drawing.Color.Transparent
        Me.usernametxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.usernametxt.BorderRadius = 11
        Me.usernametxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Animator.SetDecoration(Me.usernametxt, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.usernametxt.DefaultText = ""
        Me.usernametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.usernametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.usernametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usernametxt.DisabledState.Parent = Me.usernametxt
        Me.usernametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usernametxt.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.usernametxt.FocusedState.BorderColor = System.Drawing.Color.Crimson
        Me.usernametxt.FocusedState.Parent = Me.usernametxt
        Me.usernametxt.ForeColor = System.Drawing.Color.Crimson
        Me.usernametxt.HoverState.BorderColor = System.Drawing.Color.Crimson
        Me.usernametxt.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.usernametxt.HoverState.Parent = Me.usernametxt
        Me.usernametxt.Location = New System.Drawing.Point(30, 23)
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.usernametxt.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.usernametxt.PlaceholderText = "Username"
        Me.usernametxt.SelectedText = ""
        Me.usernametxt.ShadowDecoration.Parent = Me.usernametxt
        Me.usernametxt.Size = New System.Drawing.Size(174, 24)
        Me.usernametxt.TabIndex = 8
        Me.usernametxt.TextOffset = New System.Drawing.Point(18, 0)
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.Animated = True
        Me.Guna2ControlBox1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom
        Me.Animator.SetDecoration(Me.Guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.Crimson
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Silver
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(379, 11)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.PressedColor = System.Drawing.Color.Empty
        Me.Guna2ControlBox1.PressedDepth = 60
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(39, 23)
        Me.Guna2ControlBox1.TabIndex = 5
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Animator.SetDecoration(Me.Guna2HtmlLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(11, 11)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(81, 23)
        Me.Guna2HtmlLabel1.TabIndex = 4
        Me.Guna2HtmlLabel1.Text = "<b><font color='white' style='font-size:16px;'>mailrip</font></b><font color='cri" &
    "mson' style='font-size:16px;'>.fun</font>"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(432, 296)
        Me.Controls.Add(Me.MomPanel)
        Me.Animator.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client"
        Me.TopMost = True
        Me.MomPanel.ResumeLayout(False)
        Me.MomPanel.PerformLayout()
        Me.errorpage.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents MomPanel As Panel
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents usernametxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents passwordtxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Elipse4 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse5 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents rm_box As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LoginButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents errorpage As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents login_status As Label
    Friend WithEvents Animator As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents errorpage_closer As Timer
    Friend WithEvents Bar As Guna.UI2.WinForms.Guna2WinProgressIndicator
End Class
