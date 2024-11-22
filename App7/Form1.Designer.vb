<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Timer1 = New Timer(components)
        paddlePlayer = New PictureBox()
        paddleComputer = New PictureBox()
        ball = New PictureBox()
        lblPlayerScore = New Label()
        lblComputerScore = New Label()
        CType(paddlePlayer, ComponentModel.ISupportInitialize).BeginInit()
        CType(paddleComputer, ComponentModel.ISupportInitialize).BeginInit()
        CType(ball, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 20
        ' 
        ' paddlePlayer
        ' 
        paddlePlayer.BackColor = SystemColors.ControlText
        paddlePlayer.Location = New Point(130, 112)
        paddlePlayer.Name = "paddlePlayer"
        paddlePlayer.Size = New Size(42, 186)
        paddlePlayer.TabIndex = 0
        paddlePlayer.TabStop = False
        ' 
        ' paddleComputer
        ' 
        paddleComputer.BackColor = SystemColors.ControlText
        paddleComputer.Location = New Point(477, 112)
        paddleComputer.Name = "paddleComputer"
        paddleComputer.Size = New Size(37, 186)
        paddleComputer.TabIndex = 1
        paddleComputer.TabStop = False
        ' 
        ' ball
        ' 
        ball.BackColor = SystemColors.ControlDark
        ball.Location = New Point(356, 214)
        ball.Name = "ball"
        ball.Size = New Size(32, 24)
        ball.TabIndex = 2
        ball.TabStop = False
        ' 
        ' lblPlayerScore
        ' 
        lblPlayerScore.AutoSize = True
        lblPlayerScore.Location = New Point(261, 44)
        lblPlayerScore.Name = "lblPlayerScore"
        lblPlayerScore.Size = New Size(53, 20)
        lblPlayerScore.TabIndex = 3
        lblPlayerScore.Text = "Label1"
        ' 
        ' lblComputerScore
        ' 
        lblComputerScore.AutoSize = True
        lblComputerScore.Location = New Point(417, 44)
        lblComputerScore.Name = "lblComputerScore"
        lblComputerScore.Size = New Size(53, 20)
        lblComputerScore.TabIndex = 4
        lblComputerScore.Text = "Label2"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1276, 450)
        Controls.Add(lblComputerScore)
        Controls.Add(lblPlayerScore)
        Controls.Add(ball)
        Controls.Add(paddleComputer)
        Controls.Add(paddlePlayer)
        Name = "Form1"
        Text = "Form1"
        CType(paddlePlayer, ComponentModel.ISupportInitialize).EndInit()
        CType(paddleComputer, ComponentModel.ISupportInitialize).EndInit()
        CType(ball, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents paddlePlayer As PictureBox
    Friend WithEvents paddleComputer As PictureBox
    Friend WithEvents ball As PictureBox
    Friend WithEvents lblPlayerScore As Label
    Friend WithEvents lblComputerScore As Label

End Class
