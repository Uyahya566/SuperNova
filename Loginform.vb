Imports LibVLCSharp.Shared
Imports LibVLCSharp.WinForms

Public Class Loginform
    Private libVLC As LibVLC
    Private mediaPlayer As MediaPlayer
    Private currentMedia As Media
    Private passwordVisible As Boolean = False

    Private Sub Loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Window behavior
        Me.AutoScaleMode = AutoScaleMode.None
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimumSize = New Size(800, 600)
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.ControlBox = True

        ' Initialize LibVLC
        Core.Initialize()
        libVLC = New LibVLC()
        mediaPlayer = New MediaPlayer(libVLC)

        ' Assign MediaPlayer to VideoView
        BackgroundVideo.MediaPlayer = mediaPlayer
        BackgroundVideo.Dock = DockStyle.Fill
        BackgroundVideo.Margin = New Padding(0)
        BackgroundVideo.Padding = New Padding(0)

        ' Play background video
        Dim videoPath As String = IO.Path.Combine(Application.StartupPath, "scene.mov")
        PlayLoopingVideo(videoPath)

        ' Setup password field
        TextBoxPassword.UseSystemPasswordChar = True
        ButtonTogglePassword.FlatStyle = FlatStyle.Flat

        ' Optional status label config
        LabelStatus.Text = ""
        LabelStatus.ForeColor = Color.Red
        LabelStatus.BackColor = Color.Transparent
        LabelStatus.BringToFront()

        BringLoginControlsToFront()
        CenterLoginControls()
    End Sub

    Private Sub PlayLoopingVideo(videoPath As String)
        If currentMedia IsNot Nothing Then currentMedia.Dispose()

        currentMedia = New Media(libVLC, videoPath, FromType.FromPath)
        currentMedia.AddOption(":input-repeat=65535")
        currentMedia.AddOption(":no-video-title-show")
        currentMedia.AddOption(":video-on-top")

        mediaPlayer.Media = currentMedia
        mediaPlayer.Mute = True
        mediaPlayer.Scale = 1
        mediaPlayer.AspectRatio = Nothing
        mediaPlayer.Play()
    End Sub

    Private Sub BringLoginControlsToFront()
        Dim controls() As Control = {
            Labelsupernova,
            LabelUsername,
            TextBoxUsername,
            LabelPassword,
            TextBoxPassword,
            ButtonTogglePassword,
            ButtonLogin,
            LabelStatus
        }

        For Each c As Control In controls
            c.BringToFront()
        Next
    End Sub

    Private Sub CenterLoginControls()
        Dim controls() As Control = {
            Labelsupernova,
            LabelUsername,
            TextBoxUsername,
            LabelPassword,
            TextBoxPassword,
            ButtonTogglePassword,
            ButtonLogin,
            LabelStatus
        }

        Dim minX As Integer = controls.Min(Function(c) c.Left)
        Dim minY As Integer = controls.Min(Function(c) c.Top)
        Dim maxX As Integer = controls.Max(Function(c) c.Right)
        Dim maxY As Integer = controls.Max(Function(c) c.Bottom)

        Dim groupWidth As Integer = maxX - minX
        Dim groupHeight As Integer = maxY - minY

        Dim newLeft As Integer = (Me.ClientSize.Width - groupWidth) \ 2
        Dim newTop As Integer = (Me.ClientSize.Height - groupHeight) \ 2

        Dim offsetX As Integer = newLeft - minX
        Dim offsetY As Integer = newTop - minY

        For Each c As Control In controls
            c.Left += offsetX
            c.Top += offsetY
        Next
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim username = TextBoxUsername.Text.Trim()
        Dim password = TextBoxPassword.Text

        Dim users As New Dictionary(Of String, Tuple(Of String, String)) From {
            {"admin", Tuple.Create("password123", "Admin")},
            {"john", Tuple.Create("emp123", "Employee")},
            {"sarah", Tuple.Create("emp456", "Employee")}
        }

        If users.ContainsKey(username) AndAlso users(username).Item1 = password Then
            Dim role = users(username).Item2

            LabelStatus.Text = ""
            MessageBox.Show("Login successful! Role: " & role, "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Hide()

            If role = "Admin" Then
                Dim adminForm As New Admindashboard()
                adminForm.Show()
            ElseIf role = "Employee" Then
                Dim employeeForm As New EmployeeDashboard()
                employeeForm.Show()
            End If
        Else
            LabelStatus.Text = "Invalid username or password."
            LabelStatus.ForeColor = Color.Red
            LabelStatus.BringToFront()
        End If
    End Sub

    Private Sub ButtonTogglePassword_Click(sender As Object, e As EventArgs) Handles ButtonTogglePassword.Click
        passwordVisible = Not passwordVisible
        TextBoxPassword.UseSystemPasswordChar = Not passwordVisible
    End Sub
End Class