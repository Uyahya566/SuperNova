Imports System.Windows.Forms

Public Class UsersOverviewControl
    Inherits System.Windows.Forms.UserControl

    Private lblTitle As Label
    Private usersGrid As DataGridView

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.Dock = DockStyle.Fill
        Me.BackColor = Color.White

        lblTitle = New Label()
        lblTitle.Text = "User Management"
        lblTitle.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(20, 20)
        Me.Controls.Add(lblTitle)

        usersGrid = New DataGridView()
        usersGrid.Location = New Point(20, 60)
        usersGrid.Size = New Size(500, 300)
        usersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        usersGrid.AllowUserToAddRows = False
        usersGrid.AllowUserToDeleteRows = False
        usersGrid.ReadOnly = True
        usersGrid.Columns.Add("Username", "Username")
        usersGrid.Columns.Add("Role", "Role")
        usersGrid.Rows.Add("admin", "Administrator")
        usersGrid.Rows.Add("john", "Employee")
        usersGrid.Rows.Add("sarah", "Employee")

        Me.Controls.Add(usersGrid)
    End Sub
End Class
