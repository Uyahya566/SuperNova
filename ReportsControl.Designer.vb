Imports System.Windows.Forms

Public Class ReportsOverviewControl
    Inherits System.Windows.Forms.UserControl

    Private lblTitle As Label
    Private reportsList As ListBox

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.Dock = DockStyle.Fill
        Me.BackColor = Color.White

        lblTitle = New Label()
        lblTitle.Text = "Reports"
        lblTitle.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(20, 20)
        Me.Controls.Add(lblTitle)

        reportsList = New ListBox()
        reportsList.Font = New Font("Segoe UI", 10)
        reportsList.Size = New Size(400, 300)
        reportsList.Location = New Point(20, 60)
        reportsList.Items.AddRange(New String() {
            "Monthly Sales Report",
            "User Activity Log",
            "Inventory Summary",
            "Revenue Analysis",
            "Feedback Overview"
        })
        Me.Controls.Add(reportsList)
    End Sub
End Class
