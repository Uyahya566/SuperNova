<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class splashscreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        LabelSuper = New Label()
        Timer1 = New Timer(components)
        LabelNova = New Label()
        AnimationTimer = New Timer(components)
        SuspendLayout()
        ' 
        ' LabelSuper
        ' 
        LabelSuper.AutoSize = True
        LabelSuper.Font = New Font("Showcard Gothic", 26F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelSuper.Location = New Point(428, 150)
        LabelSuper.Name = "LabelSuper"
        LabelSuper.Size = New Size(195, 65)
        LabelSuper.TabIndex = 0
        LabelSuper.Text = "Super"
        ' 
        ' Timer1
        ' 
        ' 
        ' LabelNova
        ' 
        LabelNova.AutoSize = True
        LabelNova.Font = New Font("Showcard Gothic", 26F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelNova.Location = New Point(612, 150)
        LabelNova.Name = "LabelNova"
        LabelNova.Size = New Size(165, 65)
        LabelNova.TabIndex = 1
        LabelNova.Text = "Nova"
        ' 
        ' AnimationTimer
        ' 
        AnimationTimer.Enabled = True
        ' 
        ' splashscreen
        ' 
        ClientSize = New Size(1348, 384)
        Controls.Add(LabelNova)
        Controls.Add(LabelSuper)
        Name = "splashscreen"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents splashscreen As Label
    Friend WithEvents LabelSuper As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelNova As Label
    Friend WithEvents AnimationTimer As Timer

End Class
