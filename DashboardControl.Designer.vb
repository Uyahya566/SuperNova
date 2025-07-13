Imports System.Windows.Forms

Public Class DashboardOverviewControl
    Inherits UserControl

    Private lblTitle As Label
    Private cardUsers As Panel
    Private cardSales As Panel
    Private cardReports As Panel
    Private cardLogs As Panel

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.Dock = DockStyle.Fill
        Me.BackColor = Color.White

        ' Title
        lblTitle = New Label()
        lblTitle.Text = "Dashboard Overview"
        lblTitle.Font = New Font("Segoe UI", 18, FontStyle.Bold)
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(30, 20)
        Me.Controls.Add(lblTitle)

        ' Cards
        cardUsers = CreateCard("Total Users", "1,204", Color.FromArgb(52, 152, 219), New Point(30, 80))
        cardSales = CreateCard("Monthly Sales", "$12,430", Color.FromArgb(46, 204, 113), New Point(250, 80))
        cardReports = CreateCard("Active Reports", "53", Color.FromArgb(241, 196, 15), New Point(470, 80))
        cardLogs = CreateCard("System Logs", "87", Color.FromArgb(231, 76, 60), New Point(690, 80))

        Me.Controls.Add(cardUsers)
        Me.Controls.Add(cardSales)
        Me.Controls.Add(cardReports)
        Me.Controls.Add(cardLogs)
    End Sub

    Private Function CreateCard(title As String, value As String, backColor As Color, location As Point) As Panel
        Dim card As New Panel()
        card.Size = New Size(200, 100)
        card.Location = location
        card.BackColor = backColor
        card.BorderStyle = BorderStyle.None

        Dim lblTitle As New Label()
        lblTitle.Text = title
        lblTitle.ForeColor = Color.White
        lblTitle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblTitle.Location = New Point(10, 10)
        lblTitle.AutoSize = True

        Dim lblValue As New Label()
        lblValue.Text = value
        lblValue.ForeColor = Color.White
        lblValue.Font = New Font("Segoe UI", 20, FontStyle.Bold)
        lblValue.Location = New Point(10, 40)
        lblValue.AutoSize = True

        card.Controls.Add(lblTitle)
        card.Controls.Add(lblValue)
        Return card
    End Function
End Class
