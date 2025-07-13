<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loginform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loginform))
        LabelStatus = New Label()
        Labelsupernova = New Label()
        LabelUsername = New Label()
        TextBoxUsername = New TextBox()
        LabelPassword = New Label()
        TextBoxPassword = New TextBox()
        ButtonLogin = New Button()
        BackgroundVideo = New LibVLCSharp.WinForms.VideoView()
        ButtonTogglePassword = New Button()
        CType(BackgroundVideo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LabelStatus
        ' 
        LabelStatus.Anchor = AnchorStyles.None
        LabelStatus.AutoSize = True
        LabelStatus.BackColor = Color.Transparent
        LabelStatus.BorderStyle = BorderStyle.FixedSingle
        LabelStatus.Location = New Point(454, 534)
        LabelStatus.Name = "LabelStatus"
        LabelStatus.Size = New Size(2, 27)
        LabelStatus.TabIndex = 6
        ' 
        ' Labelsupernova
        ' 
        Labelsupernova.AccessibleRole = AccessibleRole.TitleBar
        Labelsupernova.Anchor = AnchorStyles.None
        Labelsupernova.AutoSize = True
        Labelsupernova.BackColor = Color.LightSkyBlue
        Labelsupernova.FlatStyle = FlatStyle.Flat
        Labelsupernova.Font = New Font("Stencil", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelsupernova.Location = New Point(473, 72)
        Labelsupernova.Name = "Labelsupernova"
        Labelsupernova.Size = New Size(184, 33)
        Labelsupernova.TabIndex = 4
        Labelsupernova.Text = "SuperNova"
        Labelsupernova.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelUsername
        ' 
        LabelUsername.Anchor = AnchorStyles.None
        LabelUsername.AutoSize = True
        LabelUsername.FlatStyle = FlatStyle.Flat
        LabelUsername.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelUsername.Location = New Point(350, 302)
        LabelUsername.Name = "LabelUsername"
        LabelUsername.Size = New Size(106, 25)
        LabelUsername.TabIndex = 0
        LabelUsername.Text = "Username:"
        ' 
        ' TextBoxUsername
        ' 
        TextBoxUsername.Anchor = AnchorStyles.None
        TextBoxUsername.Location = New Point(473, 302)
        TextBoxUsername.Name = "TextBoxUsername"
        TextBoxUsername.Size = New Size(202, 31)
        TextBoxUsername.TabIndex = 2
        ' 
        ' LabelPassword
        ' 
        LabelPassword.Anchor = AnchorStyles.None
        LabelPassword.AutoSize = True
        LabelPassword.BackColor = Color.Transparent
        LabelPassword.FlatStyle = FlatStyle.Flat
        LabelPassword.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelPassword.Location = New Point(350, 373)
        LabelPassword.Name = "LabelPassword"
        LabelPassword.Size = New Size(104, 25)
        LabelPassword.TabIndex = 1
        LabelPassword.Text = "Password:"
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Anchor = AnchorStyles.None
        TextBoxPassword.BackColor = SystemColors.InactiveBorder
        TextBoxPassword.Location = New Point(473, 373)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.Size = New Size(202, 31)
        TextBoxPassword.TabIndex = 3
        TextBoxPassword.UseSystemPasswordChar = True
        ' 
        ' ButtonLogin
        ' 
        ButtonLogin.Anchor = AnchorStyles.None
        ButtonLogin.FlatStyle = FlatStyle.Flat
        ButtonLogin.ForeColor = SystemColors.ControlText
        ButtonLogin.Location = New Point(471, 467)
        ButtonLogin.Name = "ButtonLogin"
        ButtonLogin.Size = New Size(204, 39)
        ButtonLogin.TabIndex = 5
        ButtonLogin.Text = "Login"
        ButtonLogin.UseVisualStyleBackColor = True
        ' 
        ' BackgroundVideo
        ' 
        BackgroundVideo.Anchor = AnchorStyles.None
        BackgroundVideo.BackColor = Color.Black
        BackgroundVideo.Location = New Point(0, 0)
        BackgroundVideo.Margin = New Padding(0)
        BackgroundVideo.MediaPlayer = Nothing
        BackgroundVideo.Name = "BackgroundVideo"
        BackgroundVideo.Size = New Size(1227, 729)
        BackgroundVideo.TabIndex = 7
        BackgroundVideo.Text = "VideoView1"
        ' 
        ' ButtonTogglePassword
        ' 
        ButtonTogglePassword.Anchor = AnchorStyles.None
        ButtonTogglePassword.BackgroundImage = CType(resources.GetObject("ButtonTogglePassword.BackgroundImage"), Image)
        ButtonTogglePassword.BackgroundImageLayout = ImageLayout.Stretch
        ButtonTogglePassword.Location = New Point(690, 373)
        ButtonTogglePassword.Name = "ButtonTogglePassword"
        ButtonTogglePassword.Size = New Size(34, 31)
        ButtonTogglePassword.TabIndex = 8
        ButtonTogglePassword.UseVisualStyleBackColor = True
        ' 
        ' Loginform
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(1227, 729)
        Controls.Add(ButtonTogglePassword)
        Controls.Add(LabelStatus)
        Controls.Add(ButtonLogin)
        Controls.Add(Labelsupernova)
        Controls.Add(TextBoxPassword)
        Controls.Add(TextBoxUsername)
        Controls.Add(LabelPassword)
        Controls.Add(LabelUsername)
        Controls.Add(BackgroundVideo)
        DoubleBuffered = True
        HelpButton = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Loginform"
        Text = "SuperNova"
        CType(BackgroundVideo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents LabelStatus As Label
    Friend WithEvents Labelsupernova As Label
    Friend WithEvents LabelUsername As Label
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents LabelPassword As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents BackgroundVideo As LibVLCSharp.WinForms.VideoView
    Friend WithEvents ButtonTogglePassword As Button
End Class
