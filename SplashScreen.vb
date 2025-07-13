Public Class SplashScreen
    Private fadeInComplete As Boolean = False
    Private fadeOutStarted As Boolean = False
    Private holdTime As Integer = 0
    Dim targetX As Integer


    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Me.Opacity = 0
        Timer1.Start()
        ' Start both labels off-screen
        LabelSuper.Left = -LabelSuper.Width
        LabelNova.Left = Me.Width

        ' Vertically center them (optional)
        Dim centerY As Integer = (Me.Height - LabelSuper.Height) \ 2
        LabelSuper.Top = centerY
        LabelNova.Top = centerY

        ' Calculate meeting point
        Dim centerX As Integer = (Me.Width - (LabelSuper.Width + LabelNova.Width)) \ 2
        targetX = centerX

        AnimationTimer.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not fadeInComplete Then
            Me.Opacity += 0.05
            If Me.Opacity >= 1 Then
                fadeInComplete = True
            End If
        ElseIf Not fadeOutStarted Then
            holdTime += 1
            If holdTime >= 30 Then ' About 1.5 seconds at 50ms per tick
                fadeOutStarted = True
            End If
        Else
            Me.Opacity -= 0.05
            If Me.Opacity <= 0 Then
                Timer1.Stop()
                Me.Hide()
                LoginForm.Show()
            End If
        End If
    End Sub
End Class
