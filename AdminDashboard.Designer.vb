<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboard
    Inherits System.Windows.Forms.Form

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'Declare controls
    Private WithEvents PanelSidebar As System.Windows.Forms.Panel
    Private WithEvents PanelContent As System.Windows.Forms.Panel
    Private WithEvents btnToggleSidebar As System.Windows.Forms.Button
    Private WithEvents btnDashboard As System.Windows.Forms.Button
    Private WithEvents btnReports As System.Windows.Forms.Button
    Private WithEvents btnUsers As System.Windows.Forms.Button
    Private WithEvents SidebarTimer As System.Windows.Forms.Timer

    'Form overrides dispose to clean up the component list.
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

    'NOTE: The following procedure is required by the Windows Form Designer
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        PanelSidebar = New Panel()
        btnUsers = New Button()
        btnReports = New Button()
        btnDashboard = New Button()
        btnToggleSidebar = New Button()
        PanelContent = New Panel()
        SidebarTimer = New Timer(components)
        PanelSidebar.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelSidebar
        ' 
        PanelSidebar.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        PanelSidebar.Controls.Add(btnUsers)
        PanelSidebar.Controls.Add(btnReports)
        PanelSidebar.Controls.Add(btnDashboard)
        PanelSidebar.Controls.Add(btnToggleSidebar)
        PanelSidebar.Dock = DockStyle.Left
        PanelSidebar.Location = New Point(0, 0)
        PanelSidebar.Margin = New Padding(5, 6, 5, 6)
        PanelSidebar.Name = "PanelSidebar"
        PanelSidebar.Size = New Size(333, 1050)
        PanelSidebar.TabIndex = 1
        ' 
        ' btnUsers
        ' 
        btnUsers.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        btnUsers.Dock = DockStyle.Top
        btnUsers.FlatAppearance.BorderSize = 0
        btnUsers.FlatStyle = FlatStyle.Flat
        btnUsers.ForeColor = Color.White
        btnUsers.Location = New Point(0, 261)
        btnUsers.Margin = New Padding(5, 6, 5, 6)
        btnUsers.Name = "btnUsers"
        btnUsers.Size = New Size(333, 87)
        btnUsers.TabIndex = 0
        btnUsers.Text = "Users"
        btnUsers.UseVisualStyleBackColor = False
        ' 
        ' btnReports
        ' 
        btnReports.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        btnReports.Dock = DockStyle.Top
        btnReports.FlatAppearance.BorderSize = 0
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.ForeColor = Color.White
        btnReports.Location = New Point(0, 174)
        btnReports.Margin = New Padding(5, 6, 5, 6)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(333, 87)
        btnReports.TabIndex = 1
        btnReports.Text = "Reports"
        btnReports.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        btnDashboard.Dock = DockStyle.Top
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.ForeColor = Color.White
        btnDashboard.Location = New Point(0, 87)
        btnDashboard.Margin = New Padding(5, 6, 5, 6)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(333, 87)
        btnDashboard.TabIndex = 2
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' btnToggleSidebar
        ' 
        btnToggleSidebar.BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        btnToggleSidebar.Dock = DockStyle.Top
        btnToggleSidebar.FlatAppearance.BorderSize = 0
        btnToggleSidebar.FlatStyle = FlatStyle.Flat
        btnToggleSidebar.ForeColor = Color.White
        btnToggleSidebar.Location = New Point(0, 0)
        btnToggleSidebar.Margin = New Padding(5, 6, 5, 6)
        btnToggleSidebar.Name = "btnToggleSidebar"
        btnToggleSidebar.Size = New Size(333, 87)
        btnToggleSidebar.TabIndex = 3
        btnToggleSidebar.Text = "☰"
        btnToggleSidebar.UseVisualStyleBackColor = False
        ' 
        ' PanelContent
        ' 
        PanelContent.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        PanelContent.Dock = DockStyle.Fill
        PanelContent.Location = New Point(333, 0)
        PanelContent.Margin = New Padding(5, 6, 5, 6)
        PanelContent.Name = "PanelContent"
        PanelContent.Size = New Size(1334, 1050)
        PanelContent.TabIndex = 0
        ' 
        ' SidebarTimer
        ' 
        SidebarTimer.Interval = 15
        ' 
        ' AdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1667, 1050)
        Controls.Add(PanelContent)
        Controls.Add(PanelSidebar)
        Margin = New Padding(5, 6, 5, 6)
        Name = "AdminDashboard"
        Text = "Admin Dashboard"
        PanelSidebar.ResumeLayout(False)
        ResumeLayout(False)

    End Sub
End Class
