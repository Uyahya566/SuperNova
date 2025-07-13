

Public Class AdminDashboard
    Inherits Form

    Private isSidebarExpanded As Boolean = True
    Private sidebarExpanding As Boolean

    Public Sub New()
        InitializeComponent()
        ApplySidebarButtonStyles()
    End Sub

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadContent(New DashboardOverviewControl())
    End Sub

    Private Sub btnToggleSidebar_Click(sender As Object, e As EventArgs) Handles btnToggleSidebar.Click
        sidebarExpanding = Not isSidebarExpanded
        SidebarTimer.Start()
    End Sub

    Private Sub SidebarTimer_Tick(sender As Object, e As EventArgs) Handles SidebarTimer.Tick
        If sidebarExpanding Then
            PanelSidebar.Width += 10
            If PanelSidebar.Width >= 200 Then
                SidebarTimer.Stop()
                isSidebarExpanded = True
                ShowSidebarText(True)
            End If
        Else
            PanelSidebar.Width -= 10
            If PanelSidebar.Width <= 60 Then
                SidebarTimer.Stop()
                isSidebarExpanded = False
                ShowSidebarText(False)
            End If
        End If
    End Sub

    Private Sub LoadContent(contentControl As UserControl)
        PanelContent.Controls.Clear()
        contentControl.Dock = DockStyle.Fill
        PanelContent.Controls.Add(contentControl)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        LoadContent(New DashboardOverviewControl())
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        LoadContent(New ReportsOverviewControl())
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        LoadContent(New UsersOverviewControl())
    End Sub

    Private Sub SidebarButton_MouseEnter(sender As Object, e As EventArgs) Handles btnDashboard.MouseEnter, btnReports.MouseEnter, btnUsers.MouseEnter
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.FromArgb(45, 45, 45)
    End Sub

    Private Sub SidebarButton_MouseLeave(sender As Object, e As EventArgs) Handles btnDashboard.MouseLeave, btnReports.MouseLeave, btnUsers.MouseLeave
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.FromArgb(31, 31, 31)
    End Sub

    Private Sub ShowSidebarText(show As Boolean)
        btnDashboard.Text = If(show, "Dashboard", "")
        btnReports.Text = If(show, "Reports", "")
        btnUsers.Text = If(show, "Users", "")
    End Sub

    Private Sub ApplySidebarButtonStyles()
        Dim buttons() As Button = {btnDashboard, btnReports, btnUsers}
        For Each btn As Button In buttons
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.BackColor = Color.FromArgb(31, 31, 31)
            btn.ForeColor = Color.White
            AddHandler btn.MouseEnter, AddressOf SidebarButton_MouseEnter
            AddHandler btn.MouseLeave, AddressOf SidebarButton_MouseLeave
        Next
    End Sub

    Private Sub PanelContent_Paint(sender As Object, e As PaintEventArgs) Handles PanelContent.Paint

    End Sub
End Class
